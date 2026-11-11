using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Melody
{
    internal static class RegistryBackupStore
    {
        private const string EntriesName = "Entries";

        public static bool HasActiveBackup()
        {
            try
            {
                using (RegistryKey root = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
                using (RegistryKey key = root.OpenSubKey(AppInfo.BackupRegistryPath + "\\" + AppInfo.ActiveBackupName, false))
                    return key != null;
            }
            catch { return false; }
        }

        public static string GetBackupSummary()
        {
            try
            {
                using (RegistryKey active = OpenActive(false))
                {
                    if (active == null) return "No registry backup is currently stored.";
                    string created = Convert.ToString(active.GetValue("CreatedUtc", ""), CultureInfo.InvariantCulture);
                    int count = Convert.ToInt32(active.GetValue("EntryCount", 0), CultureInfo.InvariantCulture);
                    object fromBuild = active.GetValue("OriginOSBuild");
                    object lastBuild = active.GetValue("LastSeenOSBuild");
                    string buildLabel = fromBuild == null ? " (source build unknown)" :
                        " (baseline build " + Convert.ToString(fromBuild, CultureInfo.InvariantCulture) + ")";
                    if (fromBuild != null && lastBuild != null && !String.Equals(Convert.ToString(fromBuild), Convert.ToString(lastBuild), StringComparison.OrdinalIgnoreCase))
                        buildLabel += " · extended on build " + Convert.ToString(lastBuild, CultureInfo.InvariantCulture);
                    return "Backup detected: " + count + " preserved baseline entries" + buildLabel +
                        (string.IsNullOrWhiteSpace(created) ? "." : " · created " + created + ".");
                }
            }
            catch { return "A Melody registry backup is present."; }
        }

        public static void EnsureActive(string sid, int actualBuild)
        {
            using (RegistryKey active = OpenActive(true))
            {
                // Keep the original baseline across Windows upgrades. Newly introduced targets
                // are appended only when first changed; existing snapshots are never overwritten.
                RecordObservedBuild(active, actualBuild);
                string originalSid = Convert.ToString(active.GetValue("UserSid", ""), CultureInfo.InvariantCulture);
                if (!string.IsNullOrWhiteSpace(originalSid) && !string.Equals(originalSid, sid, StringComparison.OrdinalIgnoreCase))
                    throw new InvalidOperationException("This backup belongs to another Windows user. Restore it under that user first.");
                if (active.GetValue("CreatedUtc") == null)
                {
                    active.SetValue("CreatedUtc", DateTime.UtcNow.ToString("o", CultureInfo.InvariantCulture), RegistryValueKind.String);
                    active.SetValue("MelodyVersion", AppInfo.Version, RegistryValueKind.String);
                    active.SetValue("UserSid", sid ?? string.Empty, RegistryValueKind.String);
                    active.SetValue("OriginOSBuild", actualBuild, RegistryValueKind.DWord);
                    active.SetValue("EntryCount", 0, RegistryValueKind.DWord);
                }
                // An rcB backup has no origin marker. Preserve it and label its source as
                // unknown; do not silently assert that it came from this Windows build.
                using (active.CreateSubKey(EntriesName, true)) { }
            }
        }

        public static void EnsureRestorable(WindowsProfile os)
        {
            if (os == null || !os.Supported)
                throw new InvalidOperationException("Registry restore requires a supported Windows workstation.");
            using (RegistryKey active = OpenActive(false))
                if (active != null) RecordObservedBuild(active, os.Build);
        }

        private static void RecordObservedBuild(RegistryKey active, int actualBuild)
        {
            if (active == null) return;
            object source = active.GetValue("OriginOSBuild");
            if (source == null) active.SetValue("OriginOSBuild", actualBuild, RegistryValueKind.DWord);
            active.SetValue("LastSeenOSBuild", actualBuild, RegistryValueKind.DWord);
            if (source != null && Convert.ToInt32(source, CultureInfo.InvariantCulture) != actualBuild)
                active.SetValue("WindowsUpgradeObserved", 1, RegistryValueKind.DWord);
        }

        public static void CaptureValue(string root, string path, string valueName, string sid)
        {
            RegistryUtil.CanonicalizeUserRoot(ref root, ref path, sid);
            if (HasTreeSnapshotForAncestor(root, path)) return;
            CaptureKeyMarker(root, path, sid, true);

            string identity = "VALUE|" + root + "|" + path + "|" + (valueName ?? string.Empty);
            using (RegistryKey entry = OpenEntry(identity, true, out bool created))
            {
                if (!created) return;
                SetIdentity(entry, "Value", root, path);
                entry.SetValue("ValueName", valueName ?? string.Empty, RegistryValueKind.String);

                using (RegistryKey key = RegistryUtil.OpenKey(root, path, false))
                {
                    if (key == null)
                    {
                        entry.SetValue("Existed", 0, RegistryValueKind.DWord);
                    }
                    else
                    {
                        bool exists = key.GetValueNames().Any(x => string.Equals(x, valueName ?? string.Empty, StringComparison.OrdinalIgnoreCase));
                        entry.SetValue("Existed", exists ? 1 : 0, RegistryValueKind.DWord);
                        if (exists)
                        {
                            RegistryValueKind kind = key.GetValueKind(valueName ?? string.Empty);
                            object value = key.GetValue(valueName ?? string.Empty, null, RegistryValueOptions.DoNotExpandEnvironmentNames);
                            entry.SetValue("ValueKind", (int)kind, RegistryValueKind.DWord);
                            if (value != null) entry.SetValue("Data", value, kind);
                        }
                    }
                }
                IncrementCount();
            }
        }

        public static void CaptureKeyMarker(string root, string path, string sid)
        {
            CaptureKeyMarker(root, path, sid, false);
        }

        private static void CaptureKeyMarker(string root, string path, string sid, bool alreadyCanonical)
        {
            if (!alreadyCanonical) RegistryUtil.CanonicalizeUserRoot(ref root, ref path, sid);
            if (HasTreeSnapshotForAncestor(root, path)) return;
            string identity = "KEY|" + root + "|" + path;
            using (RegistryKey entry = OpenEntry(identity, true, out bool created))
            {
                if (!created) return;
                SetIdentity(entry, "Key", root, path);
                using (RegistryKey key = RegistryUtil.OpenKey(root, path, false))
                    entry.SetValue("Existed", key == null ? 0 : 1, RegistryValueKind.DWord);
                IncrementCount();
            }
        }

        public static void CaptureDeletedKeyTree(string root, string path, string sid)
        {
            RegistryUtil.CanonicalizeUserRoot(ref root, ref path, sid);
            if (HasTreeSnapshotForAncestor(root, path)) return;
            string identity = "TREE|" + root + "|" + path;
            using (RegistryKey entry = OpenEntry(identity, true, out bool created))
            {
                if (!created) return;
                SetIdentity(entry, "Tree", root, path);
                using (RegistryKey source = RegistryUtil.OpenKey(root, path, false))
                {
                    bool exists = source != null;
                    entry.SetValue("Existed", exists ? 1 : 0, RegistryValueKind.DWord);
                    if (exists)
                    {
                        using (RegistryKey tree = entry.CreateSubKey("TreeData", true))
                            CopyTree(source, tree);
                    }
                }
                IncrementCount();
            }
        }

        public static void CaptureTaskState(string taskPath, bool enabled)
        {
            if (string.IsNullOrWhiteSpace(taskPath)) return;
            string identity = "TASK|" + taskPath;
            using (RegistryKey entry = OpenEntry(identity, true, out bool created))
            {
                if (!created) return;
                entry.SetValue("Kind", "Task", RegistryValueKind.String);
                entry.SetValue("Path", taskPath, RegistryValueKind.String);
                entry.SetValue("Enabled", enabled ? 1 : 0, RegistryValueKind.DWord);
                IncrementCount();
            }
        }

        // Service settings are backed up separately from raw registry values so restore
        // can also update the live Service Control Manager database.
        public static void CaptureServiceStart(string name, int original)
        {
            if (String.IsNullOrWhiteSpace(name) || original < 2 || original > 4)
                throw new ArgumentException("Invalid service startup baseline.");
            string identity = "SERVICE|" + name;
            using (RegistryKey entry = OpenEntry(identity, true, out bool created))
            {
                if (!created) return; // preserve first baseline, never replace it on reapply
                entry.SetValue("Kind", "Service", RegistryValueKind.String);
                entry.SetValue("Path", name, RegistryValueKind.String);
                entry.SetValue("OriginalStart", original, RegistryValueKind.DWord);
                IncrementCount();
            }
        }

        public static void MarkRecipeApplied(string relativePath, int operationCount)
        {
            if (String.IsNullOrWhiteSpace(relativePath)) return;
            using (RegistryKey active = OpenActive(true))
            using (RegistryKey applied = active.CreateSubKey("AppliedRecipes", true))
            using (RegistryKey entry = applied.CreateSubKey(HashIdentity(relativePath), true))
            {
                entry.SetValue("Path", relativePath, RegistryValueKind.String);
                entry.SetValue("AppliedUtc", DateTime.UtcNow.ToString("o", CultureInfo.InvariantCulture), RegistryValueKind.String);
                entry.SetValue("MelodyVersion", AppInfo.Version, RegistryValueKind.String);
                entry.SetValue("OperationCount", operationCount, RegistryValueKind.DWord);
            }
        }

        public static HashSet<string> GetAppliedRecipePaths()
        {
            HashSet<string> result = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            try
            {
                using (RegistryKey active = OpenActive(false))
                using (RegistryKey applied = active == null ? null : active.OpenSubKey("AppliedRecipes", false))
                {
                    if (applied == null) return result;
                    foreach (string name in applied.GetSubKeyNames())
                        using (RegistryKey entry = applied.OpenSubKey(name, false))
                        {
                            string path = entry == null ? "" : Convert.ToString(entry.GetValue("Path"), CultureInfo.InvariantCulture);
                            if (!String.IsNullOrWhiteSpace(path)) result.Add(path);
                        }
                }
            }
            catch { }
            return result;
        }

        public static bool WasRecipeApplied(string relativePath)
        {
            if (String.IsNullOrWhiteSpace(relativePath)) return false;
            try
            {
                using (RegistryKey active = OpenActive(false))
                using (RegistryKey applied = active == null ? null : active.OpenSubKey("AppliedRecipes", false))
                using (RegistryKey entry = applied == null ? null : applied.OpenSubKey(HashIdentity(relativePath), false))
                    return entry != null && String.Equals(Convert.ToString(entry.GetValue("Path")), relativePath, StringComparison.OrdinalIgnoreCase);
            }
            catch { return false; }
        }

        private static string HashIdentity(string text)
        {
            using (SHA256 sha = SHA256.Create())
                return BitConverter.ToString(sha.ComputeHash(Encoding.UTF8.GetBytes(text ?? String.Empty))).Replace("-", "");
        }

        public static int RestoreAll()
        {
            int restored = 0;
            using (RegistryKey active = OpenActive(false))
            {
                if (active == null) return 0;
                EnsureRestorable(WindowsProfile.Detect()); // Checked again inside the elevated restore worker.
                using (RegistryKey entries = active.OpenSubKey(EntriesName, false))
                {
                    if (entries == null) return 0;
                    List<BackupEntry> list = new List<BackupEntry>();
                    foreach (string name in entries.GetSubKeyNames())
                    {
                        using (RegistryKey entry = entries.OpenSubKey(name, false))
                        {
                            if (entry == null) continue;
                            list.Add(new BackupEntry
                            {
                                Name = name,
                                Kind = Convert.ToString(entry.GetValue("Kind", ""), CultureInfo.InvariantCulture),
                                Root = Convert.ToString(entry.GetValue("Root", ""), CultureInfo.InvariantCulture),
                                Path = Convert.ToString(entry.GetValue("Path", ""), CultureInfo.InvariantCulture),
                                ValueName = Convert.ToString(entry.GetValue("ValueName", ""), CultureInfo.InvariantCulture)
                            });
                        }
                    }

                    foreach (BackupEntry item in list.Where(x => x.Kind == "Service").OrderBy(x => x.Path, StringComparer.OrdinalIgnoreCase))
                    {
                        using (RegistryKey entry = entries.OpenSubKey(item.Name, false))
                        {
                            if (entry == null) continue;
                            int original = Convert.ToInt32(entry.GetValue("OriginalStart", -1), CultureInfo.InvariantCulture);
                            if (original >= 2 && original <= 4)
                            {
                                int current;
                                // Windows upgrades may have removed a service since backup. Never recreate one.
                                if (ServiceTaskCatalog.TryServiceStart(item.Path, out current))
                                    ServiceTaskCatalog.ConfigureStartup(item.Path, original);
                                restored++;
                            }
                        }
                    }
                    foreach (BackupEntry item in list.Where(x => x.Kind == "Tree").OrderBy(x => RegistryUtil.Depth(x.Path)))
                    {
                        using (RegistryKey entry = entries.OpenSubKey(item.Name, false)) { RestoreTree(entry); restored++; }
                    }
                    foreach (BackupEntry item in list.Where(x => x.Kind == "Value").OrderBy(x => RegistryUtil.Depth(x.Path)))
                    {
                        using (RegistryKey entry = entries.OpenSubKey(item.Name, false)) { RestoreValue(entry); restored++; }
                    }
                    foreach (BackupEntry item in list.Where(x => x.Kind == "Key").OrderByDescending(x => RegistryUtil.Depth(x.Path)))
                    {
                        using (RegistryKey entry = entries.OpenSubKey(item.Name, false)) { RestoreKeyMarker(entry); restored++; }
                    }
                    foreach (BackupEntry item in list.Where(x => x.Kind == "Task").OrderBy(x => x.Path, StringComparer.OrdinalIgnoreCase))
                    {
                        using (RegistryKey entry = entries.OpenSubKey(item.Name, false)) { RestoreTask(entry); restored++; }
                    }
                }
            }

            DeleteActive();
            return restored;
        }

        public static void DeleteActive()
        {
            using (RegistryKey root = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
            using (RegistryKey backup = root.CreateSubKey(AppInfo.BackupRegistryPath, true))
            {
                try { backup.DeleteSubKeyTree(AppInfo.ActiveBackupName, false); }
                catch (ArgumentException) { }
            }
        }

        private static void RestoreTree(RegistryKey entry)
        {
            string root = Convert.ToString(entry.GetValue("Root", ""), CultureInfo.InvariantCulture);
            string path = Convert.ToString(entry.GetValue("Path", ""), CultureInfo.InvariantCulture);
            bool existed = Convert.ToInt32(entry.GetValue("Existed", 0), CultureInfo.InvariantCulture) != 0;
            RegistryUtil.DeleteKeyTree(root, path);
            if (!existed) return;
            using (RegistryKey target = RegistryUtil.CreateKey(root, path))
            using (RegistryKey tree = entry.OpenSubKey("TreeData", false))
            {
                if (tree != null) CopyTree(tree, target);
            }
        }

        private static void RestoreValue(RegistryKey entry)
        {
            string root = Convert.ToString(entry.GetValue("Root", ""), CultureInfo.InvariantCulture);
            string path = Convert.ToString(entry.GetValue("Path", ""), CultureInfo.InvariantCulture);
            string valueName = Convert.ToString(entry.GetValue("ValueName", ""), CultureInfo.InvariantCulture);
            bool existed = Convert.ToInt32(entry.GetValue("Existed", 0), CultureInfo.InvariantCulture) != 0;
            if (!existed)
            {
                using (RegistryKey key = RegistryUtil.OpenKey(root, path, true))
                {
                    if (key != null)
                    {
                        try { key.DeleteValue(valueName, false); } catch (ArgumentException) { }
                    }
                }
                return;
            }

            RegistryValueKind kind = (RegistryValueKind)Convert.ToInt32(entry.GetValue("ValueKind", (int)RegistryValueKind.String), CultureInfo.InvariantCulture);
            object data = entry.GetValue("Data", null, RegistryValueOptions.DoNotExpandEnvironmentNames);
            using (RegistryKey key = RegistryUtil.CreateKey(root, path))
                key.SetValue(valueName, data, kind);
        }

        private static void RestoreKeyMarker(RegistryKey entry)
        {
            bool existed = Convert.ToInt32(entry.GetValue("Existed", 0), CultureInfo.InvariantCulture) != 0;
            if (existed) return;
            string root = Convert.ToString(entry.GetValue("Root", ""), CultureInfo.InvariantCulture);
            string path = Convert.ToString(entry.GetValue("Path", ""), CultureInfo.InvariantCulture);
            RegistryUtil.DeleteKeyTree(root, path);
        }

        private static void RestoreTask(RegistryKey entry)
        {
            string taskPath = Convert.ToString(entry.GetValue("Path", ""), CultureInfo.InvariantCulture);
            bool enabled = Convert.ToInt32(entry.GetValue("Enabled", 1), CultureInfo.InvariantCulture) != 0;
            if (!string.IsNullOrWhiteSpace(taskPath)) TaskSchedulerMaintenance.SetEnabled(taskPath, enabled);
        }

        private static bool HasTreeSnapshotForAncestor(string root, string path)
        {
            string current = path ?? string.Empty;
            while (!string.IsNullOrWhiteSpace(current))
            {
                string identity = "TREE|" + root + "|" + current;
                using (RegistryKey entry = OpenEntry(identity, false, out bool unused))
                    if (entry != null) return true;
                int slash = current.LastIndexOf('\\');
                if (slash < 0) break;
                current = current.Substring(0, slash);
            }
            return false;
        }

        private static RegistryKey OpenActive(bool create)
        {
            RegistryKey root = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
            try
            {
                RegistryKey key = create
                    ? root.CreateSubKey(AppInfo.BackupRegistryPath + "\\" + AppInfo.ActiveBackupName, true)
                    : root.OpenSubKey(AppInfo.BackupRegistryPath + "\\" + AppInfo.ActiveBackupName, false);
                root.Dispose();
                return key;
            }
            catch
            {
                root.Dispose();
                throw;
            }
        }

        private static RegistryKey OpenEntry(string identity, bool create, out bool created)
        {
            created = false;
            RegistryKey active = OpenActive(create);
            if (active == null) return null;
            try
            {
                RegistryKey entries = create ? active.CreateSubKey(EntriesName, true) : active.OpenSubKey(EntriesName, false);
                active.Dispose();
                if (entries == null) return null;
                string hash = Hash(identity);
                bool existed;
                using (RegistryKey existing = entries.OpenSubKey(hash, false)) existed = existing != null;
                RegistryKey entry = create ? entries.CreateSubKey(hash, true) : entries.OpenSubKey(hash, false);
                entries.Dispose();
                created = create && !existed;
                return entry;
            }
            catch
            {
                active.Dispose();
                throw;
            }
        }

        private static string Hash(string identity)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(identity.ToUpperInvariant()));
                StringBuilder sb = new StringBuilder(data.Length * 2);
                foreach (byte b in data) sb.Append(b.ToString("x2", CultureInfo.InvariantCulture));
                return sb.ToString();
            }
        }

        private static void SetIdentity(RegistryKey entry, string kind, string root, string path)
        {
            entry.SetValue("Kind", kind, RegistryValueKind.String);
            entry.SetValue("Root", root, RegistryValueKind.String);
            entry.SetValue("Path", path ?? string.Empty, RegistryValueKind.String);
        }

        private static void IncrementCount()
        {
            using (RegistryKey active = OpenActive(true))
            {
                int count = Convert.ToInt32(active.GetValue("EntryCount", 0), CultureInfo.InvariantCulture);
                active.SetValue("EntryCount", count + 1, RegistryValueKind.DWord);
            }
        }

        private static void CopyTree(RegistryKey source, RegistryKey destination)
        {
            foreach (string valueName in source.GetValueNames())
            {
                RegistryValueKind kind = source.GetValueKind(valueName);
                object value = source.GetValue(valueName, null, RegistryValueOptions.DoNotExpandEnvironmentNames);
                if (value != null) destination.SetValue(valueName, value, kind);
            }
            foreach (string subName in source.GetSubKeyNames())
            {
                using (RegistryKey sourceSub = source.OpenSubKey(subName, false))
                using (RegistryKey destinationSub = destination.CreateSubKey(subName, true))
                {
                    if (sourceSub != null && destinationSub != null) CopyTree(sourceSub, destinationSub);
                }
            }
        }

        private sealed class BackupEntry
        {
            public string Name;
            public string Kind;
            public string Root;
            public string Path;
            public string ValueName;
        }
    }
}
