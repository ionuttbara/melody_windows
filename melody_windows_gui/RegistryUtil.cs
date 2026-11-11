using Microsoft.Win32;
using System;
using System.Security.Principal;

namespace Melody
{
    internal static class RegistryUtil
    {
        public static string CurrentUserSid()
        {
            try
            {
                using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
                    return identity.User == null ? string.Empty : identity.User.Value;
            }
            catch { return string.Empty; }
        }

        public static void CanonicalizeUserRoot(ref string root, ref string path, string sid)
        {
            root = NormalizeRoot(root);
            path = (path ?? string.Empty).TrimStart('\\');
            if (root == "HKEY_CURRENT_USER")
            {
                if (string.IsNullOrWhiteSpace(sid)) throw new InvalidOperationException("Could not determine the current user SID.");
                root = "HKEY_USERS";
                path = string.IsNullOrEmpty(path) ? sid : sid + "\\" + path;
            }
        }

        public static string NormalizeRoot(string root)
        {
            string value = (root ?? string.Empty).Trim().ToUpperInvariant();
            switch (value)
            {
                case "HKLM": return "HKEY_LOCAL_MACHINE";
                case "HKCU": return "HKEY_CURRENT_USER";
                case "HKCR": return "HKEY_CLASSES_ROOT";
                case "HKU": return "HKEY_USERS";
                default: return value;
            }
        }

        public static RegistryKey OpenBaseKey(string root, bool writable)
        {
            string normalized = NormalizeRoot(root);
            RegistryView view = RegistryView.Registry64;
            switch (normalized)
            {
                case "HKEY_LOCAL_MACHINE": return RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, view);
                case "HKEY_USERS": return RegistryKey.OpenBaseKey(RegistryHive.Users, view);
                case "HKEY_CLASSES_ROOT": return RegistryKey.OpenBaseKey(RegistryHive.ClassesRoot, view);
                case "HKEY_CURRENT_CONFIG": return RegistryKey.OpenBaseKey(RegistryHive.CurrentConfig, view);
                default: throw new NotSupportedException("Unsupported registry root: " + root);
            }
        }

        public static RegistryKey OpenKey(string root, string path, bool writable)
        {
            RegistryKey baseKey = OpenBaseKey(root, writable);
            try
            {
                RegistryKey key = baseKey.OpenSubKey(path ?? string.Empty, writable);
                baseKey.Dispose();
                return key;
            }
            catch
            {
                baseKey.Dispose();
                throw;
            }
        }

        public static RegistryKey CreateKey(string root, string path)
        {
            RegistryKey baseKey = OpenBaseKey(root, true);
            try
            {
                RegistryKey key = baseKey.CreateSubKey(path ?? string.Empty, true);
                baseKey.Dispose();
                return key;
            }
            catch
            {
                baseKey.Dispose();
                throw;
            }
        }

        public static void DeleteKeyTree(string root, string path)
        {
            if (string.IsNullOrWhiteSpace(path)) throw new InvalidOperationException("Refusing to delete a registry hive root.");
            using (RegistryKey baseKey = OpenBaseKey(root, true))
            {
                try { baseKey.DeleteSubKeyTree(path, false); }
                catch (ArgumentException) { }
            }
        }

        public static int Depth(string path)
        {
            if (string.IsNullOrWhiteSpace(path)) return 0;
            return path.Split(new[] { '\\' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
