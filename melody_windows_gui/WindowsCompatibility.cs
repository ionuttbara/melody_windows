using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Melody
{
    internal enum WindowsFamily { Unsupported, Windows7, Windows8, Windows81, Windows10, Windows11 }

    // An OS container is always derived from the computer on which Melody is running.
    // Never infer Windows 11 from ProductName: Windows 11 originally reported Windows 10.
    internal sealed class WindowsProfile
    {
        public WindowsFamily Family { get; private set; }
        public int Build { get; private set; }
        public int Revision { get; private set; }
        public bool IsServer { get; private set; }
        public string DisplayName { get; private set; }
        public bool Supported { get { return !IsServer && Family != WindowsFamily.Unsupported; } }
        public bool IsLegacy { get { return Family == WindowsFamily.Windows7 || Family == WindowsFamily.Windows8 || Family == WindowsFamily.Windows81; } }
        // .NET 4.8 is unsupported on Windows 10 builds 10240/10586; use the legacy binary and conservative recipes.
        public bool IsConservative { get { return IsLegacy || (Family == WindowsFamily.Windows10 && Build < 14393); } }

        internal WindowsProfile(int build, int revision, bool server)
        {
            Build = build;
            Revision = revision;
            IsServer = server;
            Family = Classify(build);
            DisplayName = (server ? "Windows Server (not validated)" : FamilyName(Family)) + "  ·  build " + build.ToString(CultureInfo.InvariantCulture) +
                (revision > 0 ? "." + revision.ToString(CultureInfo.InvariantCulture) : "");
        }

        public static WindowsFamily Classify(int build)
        {
            if (build >= 7600 && build < 8000) return WindowsFamily.Windows7;
            if (build == 9200) return WindowsFamily.Windows8;
            if (build >= 9600 && build < 10000) return WindowsFamily.Windows81;
            if (build >= 10240 && build < 22000) return WindowsFamily.Windows10;
            if (build >= 22000) return WindowsFamily.Windows11;
            return WindowsFamily.Unsupported;
        }

        private static string FamilyName(WindowsFamily family)
        {
            switch (family)
            {
                case WindowsFamily.Windows7: return "Windows 7";
                case WindowsFamily.Windows8: return "Windows 8";
                case WindowsFamily.Windows81: return "Windows 8.1";
                case WindowsFamily.Windows10: return "Windows 10";
                case WindowsFamily.Windows11: return "Windows 11";
                default: return "Unsupported Windows";
            }
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        private struct OsVersionInfo
        {
            public int Size;
            public int Major;
            public int Minor;
            public int Build;
            public int Platform;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)] public string ServicePack;
            public ushort ServicePackMajor;
            public ushort ServicePackMinor;
            public ushort SuiteMask;
            public byte ProductType;
            public byte Reserved;
        }

        [DllImport("ntdll.dll", CharSet = CharSet.Unicode)]
        private static extern int RtlGetVersion(ref OsVersionInfo version);

        public static WindowsProfile Detect()
        {
            int build = 0;
            int revision = 0;
            bool server = false;
            try
            {
                // Read the native OS version, independent of compatibility manifest/version lies.
                OsVersionInfo version = new OsVersionInfo();
                version.Size = Marshal.SizeOf(typeof(OsVersionInfo));
                if (RtlGetVersion(ref version) == 0)
                {
                    build = version.Build;
                    server = version.ProductType != 1; // VER_NT_WORKSTATION
                }
            }
            catch (DllNotFoundException) { }
            catch (EntryPointNotFoundException) { }

            try
            {
                using (RegistryKey current = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion"))
                {
                    if (current != null)
                    {
                        int registryBuild;
                        if (int.TryParse(Convert.ToString(current.GetValue("CurrentBuildNumber") ?? current.GetValue("CurrentBuild"), CultureInfo.InvariantCulture), out registryBuild) && registryBuild > 0)
                        {
                            // Prefer RtlGetVersion if present; registry supplies a fallback for older systems.
                            if (build <= 0) build = registryBuild;
                        }
                        int.TryParse(Convert.ToString(current.GetValue("UBR"), CultureInfo.InvariantCulture), out revision);
                        string type = Convert.ToString(current.GetValue("InstallationType")) ?? string.Empty;
                        if (type.IndexOf("Server", StringComparison.OrdinalIgnoreCase) >= 0) server = true;
                    }
                }
            }
            catch (System.Security.SecurityException) { }
            catch (UnauthorizedAccessException) { }
            return new WindowsProfile(build, revision, server);
        }

        // Controlled construction makes it possible to test all build containers without OS spoofing.
        internal static WindowsProfile ForBuild(int build) { return new WindowsProfile(build, 0, false); }
    }

    internal static class WindowsCompatibility
    {
        // Intentionally strict on Windows 7/8: these are recipes verified to address features
        // present on those generations. Mixed or unknown newer recipes are not offered.
        private static readonly HashSet<string> LegacyRecipes = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            "Devices/AutoPlay Handlers.reg", "Devices/Disable F1 Key.reg",
            "Devices/Disable Communication chaning volume (Sound Control Panel).reg",
            "Devices/Disable Showing Recycle Bin Dialog when you delete a file.reg",
            "Devices/Show_empty_drives_for_current_user.reg",
            "Devices/Enable_numerical_sorting_in_File_Explorer.reg",
            "Devices/CD Read Speed Maximum Performance.reg",
            "Input/Keyboard Accessibility Flags.reg", "Input/Mouse.reg",
            "Network/Disable Branch Cache.reg", "Network/NLA Parameters.reg",
            "Network/Disable Windows PeerNet.reg", "Network/PeerNet.reg",
            "Network/Internet Control Panel Policies.reg",
            "Software/CMD Tweaks.reg", "Software/MSConfig Message Show.reg",
            "Software/Sysinternals Eula Prompts Skip.reg",
            "Windows Apparence/Cursors.reg", "Windows Apparence/Disable Windows Startup Sound.reg",
            "Windows Apparence/nosounds.reg",
            "Windows Apparence/Disable changing mouse icons when change theme.reg",
            "Windows Apparence/This PC and Recycle Bin on the Desktop.reg",
            "Windows Explorer/Disable Common Dialog History.reg",
            "Windows Explorer/ThumbnailQuality Optimization.reg",
            "System/Enable Windows Script Hosting.reg"
        };

        // Mixed historical recipes that also touch browser executables, policy, updaters
        // or Edge task state. Never let their general category enable them implicitly.
        private static readonly HashSet<string> BrowserSensitiveMixedRecipes = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            "GPU/GPU Usage Optimization.reg",
            "Resource Manager/Application Priority and Affinities.reg",
            "Security/Disable Windows SmartScreen.reg",
            "Services/Remove App Services.reg",
            "Services/Remove App Updaters Services.reg",
            "System/Disable System Mitigations.reg",
            "Tasks/Remove Windows Update Tasks.reg",
            "Telemetry/DataCollection/Disable Windows Data Collection.reg",
            "Telemetry/Logging/Disable Windows Event Logging.reg",
            "Windows Update/Windows Update.reg"
        };

        public static bool IsBrowserSensitiveMixed(RegistryAsset asset)
        {
            return asset != null && BrowserSensitiveMixedRecipes.Contains(asset.RelativePath.Replace('\\', '/'));
        }

        // Separate browser container; only explicitly approved reporting/update policies are ON.
        public static bool IsDefaultBrowserRecipe(RegistryAsset asset)
        {
            if (asset == null || !IsBrowser(asset)) return false;
            string file = asset.RelativePath.Replace('\\', '/');
            return file.EndsWith("/Google Chrome Report Extension.reg", StringComparison.OrdinalIgnoreCase) ||
                   file.EndsWith("/Google Update Service.reg", StringComparison.OrdinalIgnoreCase) ||
                   file.EndsWith("/Microsoft Edge Update.reg", StringComparison.OrdinalIgnoreCase);
        }

        public static bool IsBrowser(RegistryAsset asset)
        {
            return asset != null && asset.Category.Equals("Browser Configuration", StringComparison.OrdinalIgnoreCase);
        }

        public static bool IsLegacyOptional(RegistryAsset asset)
        {
            return asset != null && asset.Category.Equals("Legacy Optional", StringComparison.OrdinalIgnoreCase);
        }

        public static bool IsApplicable(RegistryAsset asset, WindowsProfile os)
        {
            if (asset == null || os == null || !os.Supported) return false;
            // Melody 16.0 uses the per-recipe catalog as the single version authority.
            // A maximum build is intentionally used only by the historical GWX recipe.
            // Feature/component presence is checked separately by CompatibilityCatalog.CanApplyNow().
            return CompatibilityCatalog.AllowedByCatalog(asset, os);
        }

        private static bool IsLegacyContext(string path)
        {
            string lower = path.ToLowerInvariant();
            return lower.Contains("/extract msi.reg") || lower.Contains("/register dll and ocx.reg") ||
                   lower.Contains("/take onwership.reg") || lower.Contains("/txt file in new menu.reg") ||
                   lower.Contains("/add_run_as_administrator_to_msi_context_menu.reg") ||
                   lower.Contains("/add_run_as_administrator_to_ps1_context_menu.reg");
        }

        public static bool IsApplicable(ScriptAsset script, WindowsProfile os)
        {
            if (script == null || os == null || !os.Supported) return false;
            string name = script.FileName;
            // Final 16.0 gates after real-Windows validation.
            if (name.Equals("Kill CrossDeviceResume.cmd", StringComparison.OrdinalIgnoreCase)) return os.Build >= 26100;
            if (name.Equals("Unsplit Services.ps1", StringComparison.OrdinalIgnoreCase)) return os.Build >= 15063;
            if (name.Equals("Remove Capabilities.ps1", StringComparison.OrdinalIgnoreCase) ||
                name.Equals("Remove Features.ps1", StringComparison.OrdinalIgnoreCase)) return os.Build >= 10240;
            if (name.Equals("Patch Policy to EU Mode.ps1", StringComparison.OrdinalIgnoreCase)) return os.Build >= 22621;
            if (name.Equals("Disable HPET.ps1", StringComparison.OrdinalIgnoreCase) ||
                name.Equals("Networking Tweaks.ps1", StringComparison.OrdinalIgnoreCase) ||
                name.Equals("Disable Device to TurnOff this device to save power.ps1", StringComparison.OrdinalIgnoreCase)) return os.Build >= 7600;
            return os.Build >= 7600;
        }

        public static bool IsApplicable(SystemActionInfo action, WindowsProfile os)
        {
            if (action == null || os == null || !os.Supported) return false;
            if (os.IsConservative) return action.Id == "disable-hibernation";
            if (action.Id == "remove-lockdown") return false; // Do not remove machine PowerShell policy silently.
            if (action.Id == "disable-reserved-storage") return os.Build >= 19041; // Microsoft: DISM command introduced in 2004
            if (action.Id == "disable-app-offloading") return os.Build >= 16299;
            if (action.Id == "clear-gamedvr") return os.Build >= 14393;
            return true;
        }

        public static bool CanRemoveDefender(WindowsProfile os) { return false; /* Raw destructive Defender registry removal is retired. */ }
        public static bool CanRemoveSecurityApp(WindowsProfile os) { return false; /* Raw servicing/app-removal payload is retired. */ }
        public static bool CanInstallStartBack(WindowsProfile os) { return os != null && os.Supported && os.Build >= 22000; }
        public static bool CanUseEdgeTaskExtra(WindowsProfile os) { return os != null && os.Supported && os.Build >= 14393; }

        public static bool DefaultRegularCategory(string name, WindowsProfile os)
        {
            if (os == null || !os.Supported) return false;
            // The regular modern preset remains available on 10/11; legacy tweaks require
            // selection by the user instead of blindly enabling a category's entire contents.
            if (os.IsConservative) return false;
            return false; // Each .reg needs individual approval; category-wide defaults removed.
        }
    }
}
