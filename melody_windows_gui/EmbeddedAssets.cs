using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Melody
{
    internal static class EmbeddedAssets
    {
        private const string RegistryPrefix = "Melody.Registry/";
        private const string ScriptPrefix = "Melody.Script/";
        private const string DefenderPrefix = "Melody.Defender/";
        private const string InstallerPrefix = "Melody.Installer/";
        private static readonly Assembly Assembly = typeof(EmbeddedAssets).Assembly;

        public static IList<RegistryAsset> GetRegistryAssets()
        {
            List<RegistryAsset> result = new List<RegistryAsset>();
            foreach (string rawName in Assembly.GetManifestResourceNames())
            {
                string name = rawName.Replace('\\', '/');
                if (!name.StartsWith(RegistryPrefix, StringComparison.OrdinalIgnoreCase) || !name.EndsWith(".reg", StringComparison.OrdinalIgnoreCase))
                    continue;

                string relative = name.Substring(RegistryPrefix.Length).TrimStart('/');
                string[] parts = relative.Split(new[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                string category = parts.Length > 1 ? parts[0] : "General";
                string file = parts.Length > 0 ? parts[parts.Length - 1] : relative;
                string display = Path.GetFileNameWithoutExtension(file);
                bool bloat = category.Equals("Blotware Remover", StringComparison.OrdinalIgnoreCase) || category.Equals("Bloatware Remover", StringComparison.OrdinalIgnoreCase);
                bool context = category.Equals("Context Menu", StringComparison.OrdinalIgnoreCase);

                result.Add(new RegistryAsset
                {
                    ResourceName = rawName,
                    RelativePath = relative,
                    Category = category,
                    DisplayName = display,
                    IsBloatware = bloat,
                    IsContextMenu = context
                });
            }
            return result.OrderBy(x => x.Category, StringComparer.CurrentCultureIgnoreCase)
                .ThenBy(x => x.RelativePath, StringComparer.CurrentCultureIgnoreCase).ToList();
        }

        public static IList<ScriptAsset> GetScriptAssets()
        {
            Dictionary<string, string> descriptions = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Disable Device to TurnOff this device to save power.ps1", "Disables device power-off and wake permissions through WMI." },
                { "Disable HPET.ps1", "Disables the High Precision Event Timer device." },
                { "Kill CrossDeviceResume.cmd", "Disables Cross Device Resume for the current user policy SID." },
                { "Networking Tweaks.ps1", "Applies Melody networking, adapter and TCP/IP tuning." },
                { "Patch Policy to EU Mode.ps1", "Patches IntegratedServicesRegionPolicySet.json when applicable." },
                { "Remove Capabilities.ps1", "Opt-in: remove installed Steps Recorder / Math Recognizer ONLY, after DISM discovery." },
                { "Remove Features.ps1", "Opt-in: disable only available TFTP, Telnet and Simple TCP services; no payload removal." },
                { "Unsplit Services.ps1", "Opt-in Windows 10 1703+: changes the SvcHost split threshold; some services always remain isolated." }
            };

            // Bulk device/network changes and irreversible DISM operations are not safe defaults.
            HashSet<string> melodyDefaults = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            List<ScriptAsset> result = new List<ScriptAsset>();
            foreach (string rawName in Assembly.GetManifestResourceNames())
            {
                string name = rawName.Replace('\\', '/');
                if (!name.StartsWith(ScriptPrefix, StringComparison.OrdinalIgnoreCase)) continue;
                string relative = name.Substring(ScriptPrefix.Length).TrimStart('/');
                string file = relative.Split('/').Last();
                string desc;
                if (!descriptions.TryGetValue(file, out desc)) desc = "Runs the embedded Melody script.";
                result.Add(new ScriptAsset
                {
                    ResourceName = rawName,
                    FileName = file,
                    DisplayName = Path.GetFileNameWithoutExtension(file),
                    Description = desc,
                    DefaultSelected = melodyDefaults.Contains(file)
                });
            }
            return result.OrderBy(x => x.DisplayName, StringComparer.CurrentCultureIgnoreCase).ToList();
        }


        public static IList<RegistryAsset> GetDefenderRegistryAssets(bool securityComponents)
        {
            string wanted = securityComponents ? DefenderPrefix + "Remove_SecurityComp/" : DefenderPrefix + "Remove_Defender/";
            List<RegistryAsset> result = new List<RegistryAsset>();
            foreach (string rawName in Assembly.GetManifestResourceNames())
            {
                string name = rawName.Replace('\\', '/');
                if (!name.StartsWith(wanted, StringComparison.OrdinalIgnoreCase) || !name.EndsWith(".reg", StringComparison.OrdinalIgnoreCase))
                    continue;
                string relative = name.Substring(DefenderPrefix.Length).TrimStart('/');
                string file = relative.Split('/').Last();
                result.Add(new RegistryAsset
                {
                    ResourceName = rawName,
                    RelativePath = "Defender/" + relative,
                    Category = securityComponents ? "Windows Security App" : "Windows Defender",
                    DisplayName = Path.GetFileNameWithoutExtension(file),
                    IsBloatware = false,
                    IsContextMenu = false
                });
            }
            return result.OrderBy(x => x.RelativePath, StringComparer.CurrentCultureIgnoreCase).ToList();
        }

        public static string ReadRemoveSecHealthAppScript()
        {
            string resource = Assembly.GetManifestResourceNames().FirstOrDefault(x => x.Replace('\\', '/').Equals(DefenderPrefix + "RemoveSecHealthApp.ps1", StringComparison.OrdinalIgnoreCase));
            if (resource == null) throw new FileNotFoundException("Embedded RemoveSecHealthApp.ps1 resource is missing.");
            return ReadText(resource);
        }

        public static byte[] ReadStartBackInstaller()
        {
            string resource = Assembly.GetManifestResourceNames().FirstOrDefault(x => x.Replace('\\', '/').StartsWith(InstallerPrefix, StringComparison.OrdinalIgnoreCase) && x.EndsWith(".exe", StringComparison.OrdinalIgnoreCase));
            if (resource == null) throw new FileNotFoundException("Embedded StartBack installer resource is missing.");
            return ReadBytes(resource);
        }

        public static string GetStartBackInstallerFileName()
        {
            string resource = Assembly.GetManifestResourceNames().FirstOrDefault(x => x.Replace('\\', '/').StartsWith(InstallerPrefix, StringComparison.OrdinalIgnoreCase) && x.EndsWith(".exe", StringComparison.OrdinalIgnoreCase));
            if (resource == null) return "StartBack.exe";
            string name = resource.Replace('\\', '/');
            return name.Substring(InstallerPrefix.Length);
        }

        public static string ReadText(string resourceName)
        {
            using (Stream stream = Assembly.GetManifestResourceStream(resourceName))
            {
                if (stream == null) throw new FileNotFoundException("Embedded resource was not found: " + resourceName);
                using (MemoryStream ms = new MemoryStream())
                {
                    stream.CopyTo(ms);
                    byte[] data = ms.ToArray();
                    if (data.Length >= 2 && data[0] == 0xFF && data[1] == 0xFE) return Encoding.Unicode.GetString(data, 2, data.Length - 2);
                    if (data.Length >= 2 && data[0] == 0xFE && data[1] == 0xFF) return Encoding.BigEndianUnicode.GetString(data, 2, data.Length - 2);
                    if (data.Length >= 3 && data[0] == 0xEF && data[1] == 0xBB && data[2] == 0xBF) return Encoding.UTF8.GetString(data, 3, data.Length - 3);
                    try
                    {
                        return new UTF8Encoding(false, true).GetString(data);
                    }
                    catch (DecoderFallbackException)
                    {
                        return Encoding.GetEncoding(1252).GetString(data);
                    }
                }
            }
        }

        public static byte[] ReadBytes(string resourceName)
        {
            using (Stream stream = Assembly.GetManifestResourceStream(resourceName))
            {
                if (stream == null) throw new FileNotFoundException("Embedded resource was not found: " + resourceName);
                using (MemoryStream ms = new MemoryStream())
                {
                    stream.CopyTo(ms);
                    return ms.ToArray();
                }
            }
        }

        public static void EnsureProgramDataIcons()
        {
            string target = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "Melody", "Icon");
            Directory.CreateDirectory(target);
            foreach (string rawName in Assembly.GetManifestResourceNames())
            {
                string name = rawName.Replace('\\', '/');
                if (!name.StartsWith("Melody.Icon/", StringComparison.OrdinalIgnoreCase)) continue;
                string fileName = name.Substring("Melody.Icon/".Length);
                File.WriteAllBytes(Path.Combine(target, fileName), ReadBytes(rawName));
            }
        }

        public static byte[] ReadPowerRun()
        {
            string resource = Assembly.GetManifestResourceNames().FirstOrDefault(x => x.Replace('\\', '/').Equals("Melody.Tool/PowerRun.exe", StringComparison.OrdinalIgnoreCase));
            if (resource == null) throw new FileNotFoundException("Embedded PowerRun.exe resource is missing.");
            return ReadBytes(resource);
        }
    }
}
