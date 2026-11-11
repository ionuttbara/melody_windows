using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Xml;
using System.Management;
using Microsoft.Win32;

namespace Melody
{
    // SHA-256 binds each compatibility decision to the exact embedded .reg bytes audited.
    // An unreviewed payload change is rejected by the SHA-256 gate, never silently accepted.
    internal sealed class CompatibilityRule
    {
        public string Path, Status, Reason, Source, Sha256, Prerequisite;
        public int MinBuild, MaxBuild, MinRevision;
        public bool IsExecutableStatus
        {
            get
            {
                return Status == "verified" || Status == "corrected" || Status == "conditional";
            }
        }

        public bool Allows(int build, int revision)
        {
            if (!IsExecutableStatus || build < MinBuild || (MaxBuild != 0 && build > MaxBuild)) return false;
            // Revision floors only apply to their exact minimum build, not future feature releases.
            if (build == MinBuild && revision < MinRevision) return false;
            return true;
        }
    }

    internal static class CompatibilityCatalog
    {
        private static readonly Dictionary<string, CompatibilityRule> Rules = ReadCatalog();
        private static readonly Dictionary<string, bool> CheckedHash = new Dictionary<string, bool>(StringComparer.OrdinalIgnoreCase);

        private static Dictionary<string, CompatibilityRule> ReadCatalog()
        {
            Dictionary<string, CompatibilityRule> data = new Dictionary<string, CompatibilityRule>(StringComparer.OrdinalIgnoreCase);
            using (Stream stream = typeof(EmbeddedAssets).Assembly.GetManifestResourceStream("Melody.Compatibility/Catalog.xml"))
            {
                if (stream == null) return data; // Explicit fail-closed when manifest is not embedded.
                XmlDocument document = new XmlDocument();
                document.XmlResolver = null;
                document.Load(stream);
                foreach (XmlNode node in document.SelectNodes("/registryCatalog/recipe"))
                {
                    CompatibilityRule rule = new CompatibilityRule
                    {
                        Path = Attr(node, "path"), Status = Attr(node, "status"),
                        Reason = Attr(node, "reason"), Source = Attr(node, "source"),
                        Sha256 = Attr(node, "sha256"), Prerequisite = Attr(node, "prerequisite"),
                        MinBuild = Int32.Parse(Attr(node, "min_build")), MaxBuild = Int32.Parse(Attr(node, "max_build")),
                        MinRevision = Int32.Parse(String.IsNullOrEmpty(Attr(node, "min_revision")) ? "0" : Attr(node, "min_revision"))
                    };
                    data.Add(rule.Path, rule);
                }
            }
            return data;
        }

        private static string Attr(XmlNode n, string name)
        {
            XmlAttribute a = n.Attributes[name];
            return a == null ? "" : a.Value;
        }

        public static string ScriptDocument(string filename)
        {
            if (String.IsNullOrWhiteSpace(filename)) return "No script selected.";
            string wanted = "Melody.ScriptDocs/" + filename.Replace('\\', '/');
            string matched = typeof(EmbeddedAssets).Assembly.GetManifestResourceNames()
                .FirstOrDefault(name => name.Replace('\\', '/').Equals(wanted, StringComparison.OrdinalIgnoreCase));
            if (matched == null) return "Individual script documentation missing; no action will run.";
            try { return EmbeddedAssets.ReadText(matched); }
            catch (Exception e) { return "Script documentation unavailable: " + e.Message; }
        }

        public static string ValueDocument(RegistryAsset asset)
        {
            if (asset == null) return "No registry asset selected.";
            string wanted = "Melody.ValueDocs/" + asset.RelativePath.Replace('\\', '/') + ".md";
            string found = typeof(EmbeddedAssets).Assembly.GetManifestResourceNames()
                .FirstOrDefault(x => x.Replace('\\', '/').Equals(wanted, StringComparison.OrdinalIgnoreCase));
            if (found == null) return "Value dossier missing.\r\n" + IndividualDocument(asset);
            try { return EmbeddedAssets.ReadText(found); }
            catch (Exception ex) { return "Documentation cannot be read: " + ex.Message; }
        }

        // Supplemental, per-recipe engineering research; not an execution permission.
        public static string ResearchDocument(RegistryAsset asset)
        {
            if (asset == null || String.IsNullOrWhiteSpace(asset.RelativePath))
                return "No research selection.";
            string wanted = "Melody.Research/IndividualDocs/" + asset.RelativePath.Replace('\\', '/') + ".md";
            string matched = typeof(EmbeddedAssets).Assembly.GetManifestResourceNames()
                .FirstOrDefault(name => name.Replace('\\', '/').Equals(wanted, StringComparison.OrdinalIgnoreCase));
            if (matched == null)
                return "No supplemental research available. See the original individual audit below.";
            try { return EmbeddedAssets.ReadText(matched); }
            catch (Exception ex) { return "Research resource unavailable: " + ex.Message; }
        }

        public static string IndividualDocument(RegistryAsset asset)
        {
            if (asset == null || String.IsNullOrWhiteSpace(asset.RelativePath)) return "No registry item selected.";
            string wanted = "Melody.Compatibility/IndividualDocs/" + asset.RelativePath.Replace('\\', '/') + ".md";
            string matched = typeof(EmbeddedAssets).Assembly.GetManifestResourceNames()
                .FirstOrDefault(name => name.Replace('\\', '/').Equals(wanted, StringComparison.OrdinalIgnoreCase));
            if (matched == null) return "Individual documentation resource missing. No changes will be made.";
            try { return EmbeddedAssets.ReadText(matched); }
            catch (Exception e) { return "Documentation cannot be read: " + e.Message; }
        }

        public static CompatibilityRule Find(RegistryAsset asset)
        {
            if (asset == null || String.IsNullOrWhiteSpace(asset.RelativePath)) return null;
            CompatibilityRule rule;
            return Rules.TryGetValue(asset.RelativePath.Replace('\\', '/'), out rule) ? rule : null;
        }

        public static bool IntegrityOk(RegistryAsset asset)
        {
            CompatibilityRule rule = Find(asset);
            if (rule == null) return false;
            bool cached;
            lock (CheckedHash)
            {
                if (CheckedHash.TryGetValue(rule.Path, out cached)) return cached;
            }
            bool valid = false;
            try
            {
                using (var sha = SHA256.Create())
                {
                    byte[] digest = sha.ComputeHash(EmbeddedAssets.ReadBytes(asset.ResourceName));
                    string hex = BitConverter.ToString(digest).Replace("-", "").ToLowerInvariant();
                    valid = hex.Equals(rule.Sha256, StringComparison.OrdinalIgnoreCase);
                }
            }
            catch (Exception) { valid = false; }
            lock (CheckedHash) CheckedHash[rule.Path] = valid;
            return valid;
        }

        internal static string DisplayBuildRange(CompatibilityRule rule)
        {
            if (rule == null) return "Unknown";
            if (String.Equals(rule.Prerequisite, "taskmanager-background-bug", StringComparison.OrdinalIgnoreCase))
                return "26100 / 26120 / 26200 / 26300 / 26320";
            string floor = rule.MinBuild.ToString() + (rule.MinRevision > 0 ? "." + rule.MinRevision.ToString() : "");
            return floor + (rule.MaxBuild > 0 ? "–" + rule.MaxBuild : "+");
        }

        internal static string DisplayVerdict(CompatibilityRule rule)
        {
            if (rule == null) return "UNCLASSIFIED";
            switch ((rule.Status ?? "").ToLowerInvariant())
            {
                case "verified": return "VERIFIED";
                case "corrected": return "CORRECTED";
                case "conditional": return "CONDITIONAL";
                case "api": return "USE API";
                case "retired": return "READY";
                default: return rule.Status.ToUpperInvariant();
            }
        }

        public static bool AllowedByCatalog(RegistryAsset asset, WindowsProfile os)
        {
            CompatibilityRule rule = Find(asset);
            return os != null && os.Supported && rule != null && rule.Allows(os.Build, os.Revision) && IntegrityOk(asset);
        }

        // Feature/install prerequisites beyond OS build. Never create phantom services/policies.
        public static bool InstalledPrerequisite(CompatibilityRule rule)
        {
            if (rule == null) return false;
            string req = rule.Prerequisite ?? "";
            if (req == "" || req == "existing-key") return true;
            if (req == "taskmanager-background-bug")
            {
                WindowsProfile os = WindowsProfile.Detect();
                if (os == null || !os.Supported) return false;
                return os.Build == 26100 || os.Build == 26120 || os.Build == 26200 ||
                       os.Build == 26300 || os.Build == 26320;
            }
            if (req == "gwx-legacy")
            {
                WindowsProfile os = WindowsProfile.Detect();
                // Microsoft's historical GWX offer targeted Windows 7 SP1 and Windows 8.1.
                return os != null && !os.IsServer && (os.Build == 7601 || os.Build == 9200 || os.Build == 9600);
            }
            if (req == "copilot-policy")
            {
                // Microsoft documents this deprecated policy only for commercial policy editions
                // and specific servicing floors. Do not infer support from a broad build range.
                if (!IsCommercialPolicyEdition()) return false;
                WindowsProfile os = WindowsProfile.Detect();
                if (os == null || !os.Supported) return false;
                if (os.Build == 19044 || os.Build == 19045) return os.Revision >= 3758;
                if (os.Build == 22621) return os.Revision >= 2361;
                return os.Build >= 22631;
            }
            if (req == "sandbox")
            {
                // WMI reports whether the optional feature is actually enabled on this PC.
                if (!IsOptionalFeatureEnabled("Containers-DisposableClientVM")) return false;
                try
                {
                    using (RegistryKey k = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion"))
                    {
                        string edition = Convert.ToString(k.GetValue("EditionID")) ?? "";
                        return edition.IndexOf("Professional", StringComparison.OrdinalIgnoreCase) >= 0 ||
                               edition.IndexOf("Enterprise", StringComparison.OrdinalIgnoreCase) >= 0 ||
                               edition.IndexOf("Education", StringComparison.OrdinalIgnoreCase) >= 0;
                    }
                }
                catch { return false; }
            }
            if (req == "recall")
            {
                // WindowsAI CSP applies to managed OS editions; mere build and component
                // presence are not sufficient evidence on unsupported editions.
                if (!IsCommercialPolicyEdition()) return false;
                return IsOptionalFeatureEnabled("Recall") ||
                       IsOptionalFeatureEnabled("Microsoft-Windows-Recall");
            }
            if (req == "wpp-policy-edition")
                return IsCommercialPolicyEdition();
            if (req == "office16")
                return Exists(Registry.LocalMachine, @"SOFTWARE\Microsoft\Office\16.0") ||
                       Exists(Registry.CurrentUser, @"SOFTWARE\Microsoft\Office\16.0");
            if (req == "edge-update-domain")
            {
                // Both the generic Edge update policy and the WebView2-specific policy
                // must have a real installed consumer and a sufficiently new updater.
                if (!IsDomainJoined()) return false;
                string x86 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
                string pf = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
                if (!File.Exists(Path.Combine(x86, @"Microsoft\Edge\Application\msedge.exe")) &&
                    !File.Exists(Path.Combine(pf, @"Microsoft\Edge\Application\msedge.exe"))) return false;
                string first = Path.Combine(x86, @"Microsoft\EdgeUpdate\MicrosoftEdgeUpdate.exe");
                string second = Path.Combine(pf, @"Microsoft\EdgeUpdate\MicrosoftEdgeUpdate.exe");
                if (!UpdaterVersionMeets(first, new Version(1, 3, 127, 1)) &&
                    !UpdaterVersionMeets(second, new Version(1, 3, 127, 1))) return false;
                return HasWebView2Runtime();
            }
            if (req == "edge-update")
            {
                string x86 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
                return File.Exists(Path.Combine(x86, @"Microsoft\EdgeUpdate\MicrosoftEdgeUpdate.exe")) ||
                       File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), @"Microsoft\EdgeUpdate\MicrosoftEdgeUpdate.exe"));
            }
            if (req == "chrome-update" || req == "chrome-report")
            {
                string local = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                bool chrome = File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), @"Google\Chrome\Application\chrome.exe")) ||
                              File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), @"Google\Chrome\Application\chrome.exe")) ||
                              File.Exists(Path.Combine(local, @"Google\Chrome\Application\chrome.exe"));
                if (!chrome) return false;
                if (req == "chrome-update")
                {
                    return File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), @"Google\Update\GoogleUpdate.exe")) ||
                           File.Exists(Path.Combine(local, @"Google\Update\GoogleUpdate.exe")) ||
                           Exists(Registry.LocalMachine, @"SOFTWARE\Google\Update");
                }
                // Report extension is not bundled with Chrome; no registry noise unless installed.
                string profiles = Path.Combine(local, @"Google\Chrome\User Data");
                if (!Directory.Exists(profiles)) return false;
                try { return Directory.EnumerateDirectories(profiles, "emahakmocgideepebncgnmlmliepgpgb", SearchOption.AllDirectories).Any(); }
                catch { return false; }
            }
            return false; // Any future prerequisite must be implemented explicitly.
        }

        private static bool EdgeClientOsSupported(WindowsProfile os)
        {
            if (os == null || !os.Supported) return false;
            if (os.Family == WindowsFamily.Windows11) return true;
            if (os.Family != WindowsFamily.Windows10) return false;
            if (os.Build >= 16299) return true; // Windows 10 SAC 1709+.
            if (os.Build != 10240 && os.Build != 14393) return false;
            try
            {
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion"))
                {
                    string ed = key == null ? "" : Convert.ToString(key.GetValue("EditionID")) ?? "";
                    return ed.StartsWith("EnterpriseS", StringComparison.OrdinalIgnoreCase) ||
                        ed.StartsWith("IoTEnterpriseS", StringComparison.OrdinalIgnoreCase);
                }
            }
            catch { return false; }
        }

        private static bool IsCommercialPolicyEdition()
        {
            try
            {
                using (RegistryKey k = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion"))
                {
                    if (k == null) return false;
                    string ed = Convert.ToString(k.GetValue("EditionID")) ?? "";
                    return ed.StartsWith("Professional", StringComparison.OrdinalIgnoreCase) ||
                        ed.StartsWith("Enterprise", StringComparison.OrdinalIgnoreCase) ||
                        ed.StartsWith("Education", StringComparison.OrdinalIgnoreCase) ||
                        ed.StartsWith("IoTEnterprise", StringComparison.OrdinalIgnoreCase);
                }
            }
            catch { return false; }
        }

        private static bool UpdaterVersionMeets(string exe, Version minimum)
        {
            try
            {
                if (!File.Exists(exe)) return false;
                Version installed;
                string version = FileVersionInfo.GetVersionInfo(exe).FileVersion;
                return Version.TryParse(version, out installed) && installed.CompareTo(minimum) >= 0;
            }
            catch { return false; }
        }

        private static bool HasWebView2Runtime()
        {
            // Official WebView2 docs use the (non-empty, nonzero) EdgeUpdate Clients/pv
            // marker. Probe registry views rather than guessing by an AppData directory.
            const string path = @"SOFTWARE\Microsoft\EdgeUpdate\Clients\{F3017226-FE2A-4295-8BDF-00C3A9A7E4C5}";
            try
            {
                using (RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32))
                using (RegistryKey app = key.OpenSubKey(path))
                    if (ValidVersionMarker(app)) return true;
                using (RegistryKey user = Registry.CurrentUser.OpenSubKey(path))
                    if (ValidVersionMarker(user)) return true;
                using (RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
                using (RegistryKey app = key.OpenSubKey(path))
                    if (ValidVersionMarker(app)) return true;
            }
            catch { return false; }
            return false;
        }

        private static bool ValidVersionMarker(RegistryKey key)
        {
            if (key == null) return false;
            Version v;
            return Version.TryParse(Convert.ToString(key.GetValue("pv")), out v) &&
                v.CompareTo(new Version(0, 0, 0, 0)) > 0;
        }

        private static bool IsOptionalFeatureEnabled(string name)
        {
            try
            {
                using (var search = new ManagementObjectSearcher(
                    "SELECT Name, InstallState FROM Win32_OptionalFeature WHERE Name='" + name + "'"))
                {
                    foreach (ManagementBaseObject feature in search.Get())
                        if (Convert.ToInt32(feature["InstallState"]) == 1) return true;
                }
            }
            catch { }
            return false;
        }

        private static bool IsDomainJoined()
        {
            try
            {
                using (var search = new ManagementObjectSearcher("SELECT PartOfDomain FROM Win32_ComputerSystem"))
                    foreach (ManagementBaseObject pc in search.Get())
                        if (Convert.ToBoolean(pc["PartOfDomain"])) return true;
            }
            catch { }
            return false;
        }

        private static bool Exists(RegistryKey root, string path)
        {
            try { using (RegistryKey key = root.OpenSubKey(path)) return key != null; }
            catch { return false; }
        }

        public static bool CanApplyNow(RegistryAsset asset, WindowsProfile os)
        {
            if (!AllowedByCatalog(asset, os)) return false;
            CompatibilityRule rule = Find(asset);
            // Vendor's supported OS list for current Edge/WebView2: Windows 10 SAC 1709+;
            // Windows 10 Enterprise 2015/2016 LTSC are explicit exceptions.
            if (rule.Prerequisite == "edge-update-domain" && !EdgeClientOsSupported(os)) return false;
            if (!InstalledPrerequisite(rule)) return false;
            try
            {
                IList<RegOperation> operations = RegFileEngine.ParseAsset(asset);
                // For unverified policies, never manufacture a nonexistent target key.
                if (rule.Status == "conditional" && rule.Prerequisite != "chrome-report" &&
                    rule.Prerequisite != "chrome-update" && !ExistingTargetsForAllWrites(operations)) return false;
                // Even documented policies are not applied if every existing setting matches and
                // no new value is required. Delete-only recipes with absent keys are skipped.
                return HasDifference(operations);
            }
            catch (Exception) { return false; } // Unsupported .reg syntax is unavailable, not a crash.
        }

        public static bool IsAppliedByMelody(RegistryAsset asset)
        {
            if (asset == null || !RegistryBackupStore.WasRecipeApplied(asset.RelativePath)) return false;
            try { return !HasDifference(RegFileEngine.ParseAsset(asset)); }
            catch { return false; }
        }

        // CONDITIONAL recipes are allowed only when every exact target already exists.
        // Melody therefore never manufactures an undocumented key/value simply because a
        // recipe was present in the historical collection.
        private static bool ExistingTargetsForAllWrites(IEnumerable<RegOperation> operations)
        {
            bool anyRealOperation = false;
            foreach (RegOperation op in operations)
            {
                try
                {
                    using (RegistryKey key = RegistryUtil.OpenKey(op.Root, op.Path, false))
                    {
                        if (key == null) return false;
                        if (op.Kind == RegOperationKind.CreateKey) continue;
                        anyRealOperation = true;
                        if ((op.Kind == RegOperationKind.SetValue || op.Kind == RegOperationKind.DeleteValue) &&
                            !key.GetValueNames().Contains(op.ValueName ?? "", StringComparer.OrdinalIgnoreCase))
                            return false;
                    }
                }
                catch { return false; }
            }
            return anyRealOperation;
        }

        private static bool ValuesEqual(object oldValue, object newValue)
        {
            if (oldValue is byte[] && newValue is byte[])
                return ((byte[])oldValue).SequenceEqual((byte[])newValue);
            if (oldValue is string[] && newValue is string[])
                return ((string[])oldValue).SequenceEqual((string[])newValue);
            return Object.Equals(oldValue, newValue);
        }

        private static bool HasDifference(IEnumerable<RegOperation> operations)
        {
            foreach (RegOperation op in operations)
            {
                if (op.Kind == RegOperationKind.CreateKey) continue;
                try
                {
                    using (RegistryKey key = RegistryUtil.OpenKey(op.Root, op.Path, false))
                    {
                        if (op.Kind == RegOperationKind.DeleteKey)
                        { if (key != null) return true; continue; }
                        if (op.Kind == RegOperationKind.DeleteValue)
                        { if (key != null && key.GetValueNames().Contains(op.ValueName ?? "", StringComparer.OrdinalIgnoreCase)) return true; continue; }
                        if (op.Kind == RegOperationKind.SetValue)
                        {
                            if (key == null) return true;
                            string name = op.ValueName ?? "";
                            if (!key.GetValueNames().Contains(name, StringComparer.OrdinalIgnoreCase)) return true;
                            object previous = key.GetValue(name, null, RegistryValueOptions.DoNotExpandEnvironmentNames);
                            if (key.GetValueKind(name) != op.ValueKind || !ValuesEqual(previous, op.Value)) return true;
                        }
                    }
                }
                catch (System.Security.SecurityException) { return false; }
                catch (UnauthorizedAccessException) { return false; }
                catch (Exception) { return false; }
            }
            return false;
        }
    }
}
