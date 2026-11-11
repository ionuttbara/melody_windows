using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace Melody
{
    internal static class DefenderRemovalRunner
    {
        private const string AppxStorePath = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Appx\AppxAllUserStore";

        public static bool HasRegistryChanges(bool removeDefender, bool removeWindowsSecurityApp)
        {
            return removeDefender || removeWindowsSecurityApp;
        }

        public static void CaptureBaseline(bool removeDefender, bool removeWindowsSecurityApp, string sid, Action<string> log)
        {
            if (removeDefender)
            {
                foreach (RegistryAsset asset in EmbeddedAssets.GetDefenderRegistryAssets(false))
                {
                    Log(log, "Backup Defender removal: " + asset.RelativePath);
                    RegFileEngine.CaptureBackup(asset, sid);
                }
            }

            if (removeWindowsSecurityApp)
            {
                foreach (RegistryAsset asset in EmbeddedAssets.GetDefenderRegistryAssets(true))
                {
                    Log(log, "Backup Windows Security App removal: " + asset.RelativePath);
                    RegFileEngine.CaptureBackup(asset, sid);
                }
                CaptureSecHealthAppxMarkers(sid, log);
            }
        }

        public static void Apply(bool removeDefender, bool removeWindowsSecurityApp, string sid, ApplyResult result, Action<string> log)
        {
            if (removeDefender)
            {
                Log(log, "Windows Defender removal selected (default option).");
                foreach (RegistryAsset asset in EmbeddedAssets.GetDefenderRegistryAssets(false))
                    ApplyRegistryAsset(asset, sid, result, log);
            }

            if (removeWindowsSecurityApp)
            {
                Log(log, "Windows Security App removal selected: SecHealthUI + SecurityHealthService.");
                TryStopProcess("SecHealthUI", log);

                try
                {
                    Log(log, "Remove Windows Security App: running embedded RemoveSecHealthApp.ps1 through PowerRun...");
                    PowerRunBridge.RunPowerShellScriptText(EmbeddedAssets.ReadRemoveSecHealthAppScript(), "RemoveSecHealthApp.ps1");
                    result.ActionsRun++;
                }
                catch (Exception ex)
                {
                    result.Errors.Add("Windows Security App (SecHealthUI): " + ex.Message);
                    Log(log, "ERROR: Windows Security App (SecHealthUI) — " + ex.Message);
                }

                foreach (RegistryAsset asset in EmbeddedAssets.GetDefenderRegistryAssets(true))
                    ApplyRegistryAsset(asset, sid, result, log);
            }
            else if (removeDefender)
            {
                Log(log, "Windows Security App is being kept; SecurityHealthService is not removed by Melody.");
            }
        }

        private static void ApplyRegistryAsset(RegistryAsset asset, string sid, ApplyResult result, Action<string> log)
        {
            try
            {
                Log(log, "Apply security registry: " + asset.RelativePath);
                RegistryFileApplyResult applied = RegFileEngine.Apply(asset, sid);
                result.RegistryFilesApplied++;
                result.SecurityRegistryFilesApplied++;
                result.RegistryOperationsApplied += applied.OperationCount;
                if (applied.UsedPowerRun) Log(log, "  Applied normal pass + embedded PowerRun pass.");
            }
            catch (Exception ex)
            {
                result.Errors.Add(asset.RelativePath + ": " + ex.Message);
                Log(log, "ERROR: " + asset.RelativePath + " — " + ex.Message);
            }
        }

        private static void CaptureSecHealthAppxMarkers(string sid, Action<string> log)
        {
            IList<SecurityPackageMarker> packages = QuerySecurityPackages();
            List<string> users = new List<string> { "S-1-5-18" };
            using (RegistryKey store = RegistryUtil.OpenKey("HKEY_LOCAL_MACHINE", AppxStorePath, false))
            {
                if (store != null)
                {
                    foreach (string name in store.GetSubKeyNames())
                    {
                        if (name.StartsWith("S-1-5-21", StringComparison.OrdinalIgnoreCase) && !users.Contains(name, StringComparer.OrdinalIgnoreCase))
                            users.Add(name);
                    }
                }
            }

            int markerCount = 0;
            foreach (SecurityPackageMarker package in packages)
            {
                if (!string.IsNullOrWhiteSpace(package.FamilyName))
                {
                    RegistryBackupStore.CaptureKeyMarker("HKEY_LOCAL_MACHINE", AppxStorePath + @"\Deprovisioned\" + package.FamilyName, sid);
                    markerCount++;
                }

                if (!string.IsNullOrWhiteSpace(package.PackageIdentity))
                {
                    foreach (string userSid in users)
                    {
                        RegistryBackupStore.CaptureKeyMarker("HKEY_LOCAL_MACHINE", AppxStorePath + @"\EndOfLife\" + userSid + "\\" + package.PackageIdentity, sid);
                        markerCount++;
                    }
                }
            }
            Log(log, "Backup: " + markerCount + " SecHealthUI Appx deprovision/EndOfLife registry marker(s).");
        }

        private static IList<SecurityPackageMarker> QuerySecurityPackages()
        {
            const string ps = @"
$ErrorActionPreference='Stop'
$apps = @(Get-AppxPackage -AllUsers -ErrorAction SilentlyContinue | Where-Object { $_.Name -like '*SecHealthUI*' -or $_.PackageFullName -like '*SecHealthUI*' })
$provs = @(Get-AppxProvisionedPackage -Online -ErrorAction Stop | Where-Object { $_.DisplayName -like '*SecHealthUI*' -or $_.PackageName -like '*SecHealthUI*' })
foreach ($p in $provs) {
  $match = $apps | Where-Object { $_.Name -eq $p.DisplayName } | Select-Object -First 1
  $family = $match.PackageFamilyName
  if ([string]::IsNullOrWhiteSpace($family) -and -not [string]::IsNullOrWhiteSpace($p.PublisherId)) { $family = $p.DisplayName + '_' + $p.PublisherId }
  [Console]::Out.WriteLine(('P' + [char]9 + $p.PackageName + [char]9 + $family))
}
foreach ($a in $apps) {
  [Console]::Out.WriteLine(('A' + [char]9 + $a.PackageFullName + [char]9 + $a.PackageFamilyName))
}
";
            string encoded = Convert.ToBase64String(Encoding.Unicode.GetBytes(ps));
            string powershell = Path.Combine(Environment.SystemDirectory, @"WindowsPowerShell\v1.0\powershell.exe");
            if (!File.Exists(powershell)) powershell = "powershell.exe";
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = powershell,
                Arguments = "-NoProfile -ExecutionPolicy Bypass -EncodedCommand " + encoded,
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                WindowStyle = ProcessWindowStyle.Hidden
            };

            using (Process process = Process.Start(psi))
            {
                if (process == null) throw new InvalidOperationException("Could not query the Windows Security App package state.");
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();
                process.WaitForExit();
                if (process.ExitCode != 0)
                    throw new InvalidOperationException("Could not capture the Windows Security App package baseline: " + error.Trim());

                Dictionary<string, SecurityPackageMarker> unique = new Dictionary<string, SecurityPackageMarker>(StringComparer.OrdinalIgnoreCase);
                foreach (string raw in output.Replace("\r\n", "\n").Split('\n'))
                {
                    string line = raw.Trim();
                    if (line.Length == 0) continue;
                    string[] parts = line.Split('\t');
                    if (parts.Length < 3) continue;
                    string identity = parts[1].Trim();
                    string family = parts[2].Trim();
                    string key = identity + "|" + family;
                    if (!unique.ContainsKey(key)) unique.Add(key, new SecurityPackageMarker { PackageIdentity = identity, FamilyName = family });
                }
                return unique.Values.ToList();
            }
        }

        private static void TryStopProcess(string name, Action<string> log)
        {
            foreach (Process process in Process.GetProcessesByName(name))
            {
                try
                {
                    process.Kill();
                    process.WaitForExit(3000);
                    Log(log, "Stopped " + name + ".exe before removal.");
                }
                catch (Exception ex)
                {
                    Log(log, "Warning: could not stop " + name + ".exe: " + ex.Message);
                }
                finally
                {
                    process.Dispose();
                }
            }
        }

        private static void Log(Action<string> log, string text)
        {
            if (log != null) log(text);
        }

        private sealed class SecurityPackageMarker
        {
            public string PackageIdentity { get; set; }
            public string FamilyName { get; set; }
        }
    }
}
