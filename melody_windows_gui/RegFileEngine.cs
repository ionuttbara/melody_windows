using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security;
using System.Text;

namespace Melody
{
    internal enum RegOperationKind
    {
        CreateKey,
        SetValue,
        DeleteValue,
        DeleteKey
    }

    internal sealed class RegOperation
    {
        public string Root;
        public string Path;
        public string ValueName;
        public RegOperationKind Kind;
        public RegistryValueKind ValueKind;
        public object Value;
    }

    internal sealed class RegistryFileApplyResult
    {
        public int OperationCount;
        public bool UsedPowerRun;
    }

    internal static class RegFileEngine
    {
        public static IList<RegOperation> ParseAsset(RegistryAsset asset)
        {
            if (asset == null) throw new ArgumentNullException("asset");
            return Parse(EmbeddedAssets.ReadText(asset.ResourceName));
        }

        public static void CaptureBackup(RegistryAsset asset, string sid)
        {
            foreach (RegOperation operation in ParseAsset(asset))
            {
                string root = operation.Root;
                string path = operation.Path;
                if (operation.Kind == RegOperationKind.DeleteKey)
                    RegistryBackupStore.CaptureDeletedKeyTree(root, path, sid);
                else if (operation.Kind == RegOperationKind.CreateKey)
                    RegistryBackupStore.CaptureKeyMarker(root, path, sid);
                else
                    RegistryBackupStore.CaptureValue(root, path, operation.ValueName ?? string.Empty, sid);
            }
        }

        public static RegistryFileApplyResult Apply(RegistryAsset asset, string sid)
        {
            CompatibilityRule rule = CompatibilityCatalog.Find(asset);
            if (rule == null || !rule.IsExecutableStatus)
                throw new InvalidOperationException("This registry recipe is not executable: " +
                    CompatibilityCatalog.DisplayVerdict(rule));

            IList<RegOperation> operations = ParseAsset(asset);
            bool conditional = String.Equals(rule.Status, "conditional", StringComparison.OrdinalIgnoreCase);

            if (conditional)
            {
                bool documentedCreateException = String.Equals(rule.Prerequisite, "chrome-report", StringComparison.OrdinalIgnoreCase) ||
                    String.Equals(rule.Prerequisite, "chrome-update", StringComparison.OrdinalIgnoreCase);
                // Most CONDITIONAL recipes mean exact live targets only. The two browser policies
                // are explicit opt-in exceptions with separately checked installed components.
                foreach (RegOperation operation in operations)
                {
                    if (documentedCreateException) ApplyOperation(operation, sid);
                    else ApplyConditionalOperation(operation, sid);
                }
                // Never run CONDITIONAL content through the raw PowerRun pass.
                return new RegistryFileApplyResult { OperationCount = operations.Count, UsedPowerRun = false };
            }

            // VERIFIED/CORRECTED recipes keep the original elevated second pass. HKCU is
            // normalized to HKEY_USERS\<original SID> so SYSTEM never writes its own profile.
            try
            {
                foreach (RegOperation operation in operations) ApplyOperation(operation, sid);
            }
            catch (UnauthorizedAccessException) { }
            catch (SecurityException) { }

            PowerRunBridge.ApplyRegistryText(EmbeddedAssets.ReadText(asset.ResourceName), sid);
            return new RegistryFileApplyResult { OperationCount = operations.Count, UsedPowerRun = true };
        }

        private static void ApplyConditionalOperation(RegOperation operation, string sid)
        {
            string root = operation.Root;
            string path = operation.Path;
            RegistryUtil.CanonicalizeUserRoot(ref root, ref path, sid);
            using (RegistryKey existing = RegistryUtil.OpenKey(root, path, operation.Kind != RegOperationKind.CreateKey))
            {
                if (existing == null)
                    throw new InvalidOperationException("Conditional target no longer exists: " + root + "\\" + path);

                if (operation.Kind == RegOperationKind.CreateKey) return;
                if (operation.Kind == RegOperationKind.SetValue)
                {
                    string name = operation.ValueName ?? string.Empty;
                    if (!existing.GetValueNames().Contains(name, StringComparer.OrdinalIgnoreCase))
                        throw new InvalidOperationException("Conditional value no longer exists: " + name);
                    existing.SetValue(name, operation.Value, operation.ValueKind);
                    return;
                }
                if (operation.Kind == RegOperationKind.DeleteValue)
                {
                    string name = operation.ValueName ?? string.Empty;
                    if (!existing.GetValueNames().Contains(name, StringComparer.OrdinalIgnoreCase))
                        throw new InvalidOperationException("Conditional value no longer exists: " + name);
                    existing.DeleteValue(name, false);
                    return;
                }
            }

            // DeleteKey cannot be performed while the target is open. Re-checking immediately
            // before the delete avoids turning a vanished target into a new/phantom operation.
            if (operation.Kind == RegOperationKind.DeleteKey)
                RegistryUtil.DeleteKeyTree(root, path);
        }

        private static void ApplyOperation(RegOperation operation, string sid)
        {
            string root = operation.Root;
            string path = operation.Path;
            RegistryUtil.CanonicalizeUserRoot(ref root, ref path, sid);
            switch (operation.Kind)
            {
                case RegOperationKind.CreateKey:
                    using (RegistryKey created = RegistryUtil.CreateKey(root, path)) { }
                    break;
                case RegOperationKind.DeleteKey:
                    RegistryUtil.DeleteKeyTree(root, path);
                    break;
                case RegOperationKind.DeleteValue:
                    using (RegistryKey deleteKey = RegistryUtil.OpenKey(root, path, true))
                    {
                        if (deleteKey != null) deleteKey.DeleteValue(operation.ValueName ?? string.Empty, false);
                    }
                    break;
                case RegOperationKind.SetValue:
                    using (RegistryKey setKey = RegistryUtil.CreateKey(root, path))
                        setKey.SetValue(operation.ValueName ?? string.Empty, operation.Value, operation.ValueKind);
                    break;
            }
        }

        public static IList<RegOperation> Parse(string script)
        {
            List<RegOperation> result = new List<RegOperation>();
            string currentRoot = null;
            string currentPath = null;

            foreach (string logical in GetLogicalLines(script ?? string.Empty))
            {
                string line = logical.Trim();
                if (line.Length == 0 || line.StartsWith(";", StringComparison.Ordinal) || line.StartsWith("#", StringComparison.Ordinal)) continue;
                if (line.StartsWith("Windows Registry Editor", StringComparison.OrdinalIgnoreCase) || line.StartsWith("REGEDIT4", StringComparison.OrdinalIgnoreCase)) continue;

                if (line.StartsWith("[", StringComparison.Ordinal) && line.EndsWith("]", StringComparison.Ordinal))
                {
                    string inner = line.Substring(1, line.Length - 2).Trim();
                    bool deleteKey = inner.StartsWith("-", StringComparison.Ordinal);
                    if (deleteKey) inner = inner.Substring(1).Trim();
                    int slash = inner.IndexOf('\\');
                    currentRoot = slash < 0 ? inner : inner.Substring(0, slash);
                    currentPath = slash < 0 ? string.Empty : inner.Substring(slash + 1);
                    currentRoot = RegistryUtil.NormalizeRoot(currentRoot);
                    if (!IsSupportedRoot(currentRoot))
                        throw new NotSupportedException("Unsupported or malformed registry root: " + line);

                    if (deleteKey)
                    {
                        result.Add(new RegOperation
                        {
                            Root = currentRoot,
                            Path = currentPath,
                            ValueName = string.Empty,
                            Kind = RegOperationKind.DeleteKey
                        });
                    }
                    else if (!string.IsNullOrWhiteSpace(currentPath))
                    {
                        result.Add(new RegOperation
                        {
                            Root = currentRoot,
                            Path = currentPath,
                            ValueName = string.Empty,
                            Kind = RegOperationKind.CreateKey
                        });
                    }
                    continue;
                }

                int equals = FindEquals(line);
                if (equals <= 0 || string.IsNullOrEmpty(currentRoot)) continue;

                string left = line.Substring(0, equals).Trim();
                string right = line.Substring(equals + 1).Trim();
                string valueName = left == "@" ? string.Empty : ParseQuoted(left);

                if (right == "-")
                {
                    result.Add(NewValueOperation(currentRoot, currentPath, valueName, RegOperationKind.DeleteValue, RegistryValueKind.None, null));
                    continue;
                }

                if (right.StartsWith("dword:", StringComparison.OrdinalIgnoreCase))
                {
                    string hex = right.Substring(6).Trim();
                    if (hex.Length > 8) hex = hex.Substring(0, 8);
                    uint parsed;
                    if (!uint.TryParse(hex, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out parsed))
                        throw new FormatException("Invalid DWORD value: " + right);
                    result.Add(NewValueOperation(currentRoot, currentPath, valueName, RegOperationKind.SetValue, RegistryValueKind.DWord, unchecked((int)parsed)));
                    continue;
                }

                if (right.StartsWith("hex(b):", StringComparison.OrdinalIgnoreCase))
                {
                    byte[] bytes = ParseHexBytes(right.Substring(7));
                    if (bytes.Length > 8) throw new FormatException("REG_QWORD contains more than 8 bytes.");
                    byte[] qwordBytes = new byte[8];
                    Array.Copy(bytes, qwordBytes, bytes.Length);
                    result.Add(NewValueOperation(currentRoot, currentPath, valueName, RegOperationKind.SetValue, RegistryValueKind.QWord, BitConverter.ToInt64(qwordBytes, 0)));
                    continue;
                }

                if (right.StartsWith("hex(2):", StringComparison.OrdinalIgnoreCase))
                {
                    string value = Encoding.Unicode.GetString(ParseHexBytes(right.Substring(7))).TrimEnd('\0');
                    result.Add(NewValueOperation(currentRoot, currentPath, valueName, RegOperationKind.SetValue, RegistryValueKind.ExpandString, value));
                    continue;
                }

                if (right.StartsWith("hex(7):", StringComparison.OrdinalIgnoreCase))
                {
                    string text = Encoding.Unicode.GetString(ParseHexBytes(right.Substring(7))).TrimEnd('\0');
                    string[] parts = text.Split(new[] { '\0' }, StringSplitOptions.RemoveEmptyEntries);
                    result.Add(NewValueOperation(currentRoot, currentPath, valueName, RegOperationKind.SetValue, RegistryValueKind.MultiString, parts));
                    continue;
                }

                if (right.StartsWith("hex(3):", StringComparison.OrdinalIgnoreCase))
                {
                    result.Add(NewValueOperation(currentRoot, currentPath, valueName, RegOperationKind.SetValue, RegistryValueKind.Binary, ParseHexBytes(right.Substring(7))));
                    continue;
                }

                if (right.StartsWith("REG_MULTI_SZ:", StringComparison.OrdinalIgnoreCase))
                {
                    string raw = right.Substring("REG_MULTI_SZ:".Length).Trim();
                    string text = raw.StartsWith("\"", StringComparison.Ordinal) ? ParseQuoted(raw) : raw;
                    string[] parts = text.IndexOf('\0') >= 0 ? text.Split(new[] { '\0' }, StringSplitOptions.RemoveEmptyEntries) : new[] { text };
                    result.Add(NewValueOperation(currentRoot, currentPath, valueName, RegOperationKind.SetValue, RegistryValueKind.MultiString, parts));
                    continue;
                }

                if (right.StartsWith("hex:", StringComparison.OrdinalIgnoreCase))
                {
                    result.Add(NewValueOperation(currentRoot, currentPath, valueName, RegOperationKind.SetValue, RegistryValueKind.Binary, ParseHexBytes(right.Substring(4))));
                    continue;
                }

                if (right.StartsWith("\"", StringComparison.Ordinal))
                {
                    result.Add(NewValueOperation(currentRoot, currentPath, valueName, RegOperationKind.SetValue, RegistryValueKind.String, ParseQuoted(right)));
                    continue;
                }

                throw new NotSupportedException("Unsupported .reg value syntax: " + right);
            }
            return result;
        }

        private static RegOperation NewValueOperation(string root, string path, string valueName, RegOperationKind kind, RegistryValueKind valueKind, object value)
        {
            return new RegOperation { Root = root, Path = path, ValueName = valueName, Kind = kind, ValueKind = valueKind, Value = value };
        }

        private static bool IsSupportedRoot(string root)
        {
            return root == "HKEY_LOCAL_MACHINE" || root == "HKEY_CURRENT_USER" || root == "HKEY_CLASSES_ROOT" || root == "HKEY_USERS";
        }

        private static IEnumerable<string> GetLogicalLines(string script)
        {
            string[] physical = script.Replace("\r\n", "\n").Replace('\r', '\n').Split('\n');
            StringBuilder current = new StringBuilder();
            foreach (string raw in physical)
            {
                string line = raw.TrimEnd();
                if (current.Length > 0)
                {
                    if (line.EndsWith("\\", StringComparison.Ordinal))
                    {
                        current.Append(line.Substring(0, line.Length - 1).Trim());
                        continue;
                    }
                    current.Append(line.Trim());
                    yield return current.ToString();
                    current.Clear();
                    continue;
                }

                if (line.EndsWith("\\", StringComparison.Ordinal) && line.IndexOf('=') >= 0 && !line.TrimStart().StartsWith("[", StringComparison.Ordinal))
                {
                    current.Append(line.Substring(0, line.Length - 1).Trim());
                    continue;
                }
                yield return line;
            }
            if (current.Length > 0) yield return current.ToString();
        }

        private static byte[] ParseHexBytes(string value)
        {
            string compact = (value ?? string.Empty).Replace(" ", string.Empty).Replace("\t", string.Empty);
            string[] parts = compact.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            List<byte> bytes = new List<byte>();
            foreach (string part in parts)
            {
                byte parsed;
                if (!byte.TryParse(part.Trim(), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out parsed))
                    throw new FormatException("Invalid hexadecimal byte: " + part);
                bytes.Add(parsed);
            }
            return bytes.ToArray();
        }

        private static int FindEquals(string line)
        {
            bool quoted = false;
            bool escape = false;
            for (int i = 0; i < line.Length; i++)
            {
                char c = line[i];
                if (escape) { escape = false; continue; }
                if (c == '\\') { escape = true; continue; }
                if (c == '"') { quoted = !quoted; continue; }
                if (c == '=' && !quoted) return i;
            }
            return -1;
        }

        private static string ParseQuoted(string value)
        {
            string s = (value ?? string.Empty).Trim();
            if (s.Length < 2 || s[0] != '"') throw new FormatException("Expected quoted registry string: " + value);
            StringBuilder result = new StringBuilder();
            bool escape = false;
            for (int i = 1; i < s.Length; i++)
            {
                char c = s[i];
                if (escape)
                {
                    if (c == '"' || c == '\\') result.Append(c);
                    else { result.Append('\\'); result.Append(c); }
                    escape = false;
                    continue;
                }
                if (c == '\\') { escape = true; continue; }
                if (c == '"') return result.ToString();
                result.Append(c);
            }
            if (escape) result.Append('\\');
            return result.ToString();
        }
    }
}
