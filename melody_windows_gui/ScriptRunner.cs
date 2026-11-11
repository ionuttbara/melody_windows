using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Melody
{
    internal static class ScriptRunner
    {
        private static readonly string[] NetworkInterfaceValues = new[]
        {
            "*FlowControl", "FlowControlCap", "TxIntDelay", "TxAbsIntDelay", "RxIntDelay", "RxAbsIntDelay",
            "FatChannelIntolerant", "*InterruptModeration", "LogDisconnectEvent", "LogLinkStateEvent", "GigaLite",
            "*EEE", "AdvancedEEE", "AutoPowerSaveModeEnabled", "EnableEDT", "EnableGreenEthernet", "EEELinkAdvertisement",
            "ENPWMode", "GPPSW", "PowerSavingMode", "ULPMode", "TCPNoDelay", "TcpAckFrequency", "TcpDelAckTicks"
        };

        public static IList<SystemActionInfo> GetSystemActions()
        {
            return new List<SystemActionInfo>
            {
                new SystemActionInfo { Id = "remove-lockdown", Name = "Remove PowerShell lockdown policy", Description = "Deletes __PSLockdownPolicy from the machine environment, matching the original Melody batch.", DefaultSelected = false, ChangesRegistry = true },
                new SystemActionInfo { Id = "disable-app-offloading", Name = "Disable Microsoft Store app offloading", Description = "Sets discovered EnableAppOffloading values to 0.", DefaultSelected = false, ChangesRegistry = true },
                new SystemActionInfo { Id = "disable-hibernation", Name = "Disable hibernation / Fast Startup", Description = "Runs powercfg -h off.", DefaultSelected = false, ChangesRegistry = false },
                new SystemActionInfo { Id = "disable-reserved-storage", Name = "Disable Reserved Storage", Description = "Runs DISM /Online /Set-ReservedStorageState /State:Disabled.", DefaultSelected = false, ChangesRegistry = false },
                new SystemActionInfo { Id = "clear-gamedvr", Name = "Clear the current user's GameDVR cache", Description = "Deletes %LOCALAPPDATA%\\Microsoft\\GameDVR. Melody can restart Windows Explorer first so locked cache files can be removed safely.", DefaultSelected = false, ChangesRegistry = false }
            };
        }

        public static ApplyResult Run(ApplySelection selection, Action<string> log)
        {
            if (selection == null) throw new ArgumentNullException("selection");
            WindowsProfile actual = WindowsProfile.Detect();
            if (!actual.Supported || actual.Build != selection.TargetBuild)
                throw new InvalidOperationException("Windows build mismatch or unsupported OS. No settings were applied.");
            foreach (RegistryAsset asset in selection.RegistryAssets)
                if (!WindowsCompatibility.IsApplicable(asset, actual) || !CompatibilityCatalog.CanApplyNow(asset, actual))
                    throw new InvalidOperationException("Incompatible registry recipe: " + asset.RelativePath);
            foreach (ScriptAsset script in selection.Scripts)
                if (!WindowsCompatibility.IsApplicable(script, actual))
                    throw new InvalidOperationException("Incompatible script: " + script.FileName);
            foreach (string id in selection.Actions)
            {
                SystemActionInfo action = GetSystemActions().FirstOrDefault(x => x.Id == id);
                if (action == null || !WindowsCompatibility.IsApplicable(action, actual))
                    throw new InvalidOperationException("Incompatible/unknown action: " + id);
            }
            // A changed/removed live target aborts BEFORE backup or other writes.
            ServiceTaskCatalog.Preflight(selection, actual);
            if ((selection.RemoveDefender && !WindowsCompatibility.CanRemoveDefender(actual)) ||
                (selection.RemoveWindowsSecurityApp && !WindowsCompatibility.CanRemoveSecurityApp(actual)) ||
                (selection.InstallStartBack && !WindowsCompatibility.CanInstallStartBack(actual)) ||
                (selection.IncludeIbbTaskExtras && !WindowsCompatibility.CanUseEdgeTaskExtra(actual)))
                throw new InvalidOperationException("An additional component is incompatible with this OS.");
            string sid = RegistryUtil.CurrentUserSid();
            if (string.IsNullOrWhiteSpace(sid)) throw new InvalidOperationException("Could not determine the current user SID.");
            ApplyResult result = new ApplyResult();

            if (selection.RegistryAssets.Any(x => x.RelativePath.Equals("Melody Registry Information.reg", StringComparison.OrdinalIgnoreCase)))
                EmbeddedAssets.EnsureProgramDataIcons();

            bool needsRegistryBackup = selection.RegistryAssets.Count > 0 ||
                selection.Scripts.Any(ScriptChangesRegistry) ||
                selection.Actions.Any(ActionChangesRegistry) ||
                selection.IncludeIbbTaskExtras ||
                selection.SelectedServices.Count > 0 || selection.SelectedTasks.Count > 0 ||
                DefenderRemovalRunner.HasRegistryChanges(selection.RemoveDefender, selection.RemoveWindowsSecurityApp);

            if (needsRegistryBackup)
            {
                Log(log, "Creating/verifying registry baseline in " + AppInfo.BackupFullPath + " ...");
                RegistryBackupStore.EnsureActive(sid, actual.Build);

                // Important: capture every selected registry target before the first mutation in this run.
                foreach (RegistryAsset asset in selection.RegistryAssets)
                {
                    Log(log, "Backup: " + asset.RelativePath);
                    RegFileEngine.CaptureBackup(asset, sid);
                }
                foreach (ScriptAsset script in selection.Scripts) CaptureScriptRegistry(script, sid, log);
                foreach (string action in selection.Actions) CaptureActionRegistry(action, sid, log);
                if (selection.IncludeIbbTaskExtras)
                {
                    IList<ScheduledTaskState> tasks = TaskSchedulerMaintenance.FindByNamePrefix(TaskSchedulerMaintenance.EdgeUpdateTaskPrefix);
                    foreach (ScheduledTaskState task in tasks) RegistryBackupStore.CaptureTaskState(task.Path, task.Enabled);
                    Log(log, "Backup: " + tasks.Count + " MicrosoftEdgeUpdateTask* state(s).");
                }
                foreach (string id in selection.SelectedServices)
                {
                    int current;
                    if (!ServiceTaskCatalog.TryServiceStart(id, out current)) { Log(log, "SKIP: service is not installed: " + id); continue; }
                    RegistryBackupStore.CaptureValue("HKLM", @"SYSTEM\CurrentControlSet\Services\" + id, "Start", sid);
                    RegistryBackupStore.CaptureServiceStart(id, current);
                    Log(log, "Backup: service " + id + " startup " + current + ".");
                }
                foreach (string id in selection.SelectedTasks)
                {
                    bool enabled;
                    if (!TaskSchedulerMaintenance.TryGetState(id, out enabled)) { Log(log, "SKIP: task is not installed: " + id); continue; }
                    RegistryBackupStore.CaptureTaskState(id, enabled);
                    Log(log, "Backup: task " + id + ", originally " + (enabled ? "enabled" : "disabled") + ".");
                }
                DefenderRemovalRunner.CaptureBaseline(selection.RemoveDefender, selection.RemoveWindowsSecurityApp, sid, log);
            }

            foreach (RegistryAsset asset in selection.RegistryAssets)
            {
                try
                {
                    if (!WindowsCompatibility.IsApplicable(asset, actual) || !CompatibilityCatalog.CanApplyNow(asset, actual))
                    {
                        Log(log, "SKIP: target no longer needs this registry recipe: " + asset.RelativePath);
                        continue;
                    }
                    Log(log, "Apply registry: " + asset.RelativePath);
                    RegistryFileApplyResult applied = RegFileEngine.Apply(asset, sid);
                    result.RegistryFilesApplied++;
                    result.RegistryOperationsApplied += applied.OperationCount;
                    RegistryBackupStore.MarkRecipeApplied(asset.RelativePath, applied.OperationCount);
                    if (applied.UsedPowerRun) Log(log, "  Applied normal pass + embedded PowerRun pass (matching Melody command2.bat).");
                }
                catch (Exception ex)
                {
                    result.Errors.Add(asset.RelativePath + ": " + ex.Message);
                    Log(log, "ERROR: " + asset.RelativePath + " — " + ex.Message);
                }
            }

            if (selection.IncludeIbbTaskExtras)
            {
                try
                {
                    Log(log, "IBB-DismTools task extra: disable MicrosoftEdgeUpdateTask* ...");
                    ScheduledTaskChangeResult taskResult = TaskSchedulerMaintenance.SetEnabledByNamePrefix(TaskSchedulerMaintenance.EdgeUpdateTaskPrefix, false);
                    if (taskResult.Errors.Count > 0)
                    {
                        Log(log, "  Normal Task Scheduler pass could not change every matching task; retrying through embedded PowerRun.");
                        PowerRunBridge.DisableEdgeUpdateTasksWithPowerRun();
                    }
                    Log(log, "  Edge Update tasks matched: " + taskResult.Matched + "; disabled in normal pass: " + taskResult.Changed + ".");
                    result.ActionsRun++;
                }
                catch (Exception ex)
                {
                    result.Errors.Add("MicrosoftEdgeUpdateTask*: " + ex.Message);
                    Log(log, "ERROR: MicrosoftEdgeUpdateTask* — " + ex.Message);
                }
            }

            // Service/task actions are isolated, opt-in and use exact live targets.
            // Changing the start type does not force-stop a running service.
            foreach (string id in selection.SelectedServices)
            {
                try
                {
                    OptionalOperation op = ServiceTaskCatalog.Find("service", id);
                    if (op == null) throw new InvalidOperationException("Unknown service option.");
                    int currentStart;
                    if (!ServiceTaskCatalog.TryServiceStart(id, out currentStart)) { Log(log, "SKIP: service is not installed: " + id); continue; }
                    int target = op.Start == "manual" ? 3 : 4;
                    Log(log, "SCM: " + op.Title + " (" + id + ") -> " + op.Start + ".");
                    ServiceTaskCatalog.ConfigureStartup(id, target);
                    result.ServicesChanged++;
                }
                catch (Exception ex)
                {
                    result.Errors.Add("Service " + id + ": " + ex.Message);
                    Log(log, "ERROR: service " + id + " — " + ex.Message);
                }
            }
            foreach (string id in selection.SelectedTasks)
            {
                try
                {
                    bool enabled;
                    if (!TaskSchedulerMaintenance.TryGetState(id, out enabled)) { Log(log, "SKIP: task is not installed: " + id); continue; }
                    if (enabled) TaskSchedulerMaintenance.SetEnabled(id, false);
                    bool after;
                    if (!TaskSchedulerMaintenance.TryGetState(id, out after) || after)
                        throw new InvalidOperationException("Task Scheduler did not confirm disable.");
                    Log(log, "Task Scheduler: disabled " + id + ".");
                    result.ScheduledTasksChanged++;
                }
                catch (Exception ex)
                {
                    result.Errors.Add("Task " + id + ": " + ex.Message);
                    Log(log, "ERROR: task " + id + " — " + ex.Message);
                }
            }

            foreach (ScriptAsset script in selection.Scripts)
            {
                try
                {
                    Log(log, "Run script: " + script.FileName);
                    RunEmbeddedScript(script);
                    result.ScriptsRun++;
                }
                catch (Exception ex)
                {
                    result.Errors.Add(script.FileName + ": " + ex.Message);
                    Log(log, "ERROR: " + script.FileName + " — " + ex.Message);
                }
            }

            foreach (string action in selection.Actions)
            {
                try
                {
                    Log(log, "Run action: " + action);
                    RunAction(action, sid, selection.RestartExplorerForGameDvr, log);
                    result.ActionsRun++;
                }
                catch (Exception ex)
                {
                    result.Errors.Add(action + ": " + ex.Message);
                    Log(log, "ERROR: " + action + " — " + ex.Message);
                }
            }

            // Security removal is applied after the regular Melody settings so the supplied
            // Defender remover stays isolated from the normal tweak catalogue.
            DefenderRemovalRunner.Apply(selection.RemoveDefender, selection.RemoveWindowsSecurityApp, sid, result, log);

            // StartBack is intentionally last, after all selected settings.
            if (selection.InstallStartBack)
            {
                try
                {
                    InstallerRunner.InstallStartBack(log);
                    result.InstallersRun++;
                }
                catch (Exception ex)
                {
                    result.Errors.Add("StartBack: " + ex.Message);
                    Log(log, "ERROR: StartBack — " + ex.Message);
                }
            }

            return result;
        }

        private static bool ScriptChangesRegistry(ScriptAsset script)
        {
            if (script == null) return false;
            return script.FileName.Equals("Kill CrossDeviceResume.cmd", StringComparison.OrdinalIgnoreCase) ||
                   script.FileName.Equals("Networking Tweaks.ps1", StringComparison.OrdinalIgnoreCase) ||
                   script.FileName.Equals("Unsplit Services.ps1", StringComparison.OrdinalIgnoreCase);
        }

        private static bool ActionChangesRegistry(string id)
        {
            return string.Equals(id, "remove-lockdown", StringComparison.OrdinalIgnoreCase) ||
                   string.Equals(id, "disable-app-offloading", StringComparison.OrdinalIgnoreCase);
        }

        private static void CaptureScriptRegistry(ScriptAsset script, string sid, Action<string> log)
        {
            if (script == null) return;
            if (script.FileName.Equals("Kill CrossDeviceResume.cmd", StringComparison.OrdinalIgnoreCase))
            {
                string path = @"SOFTWARE\Microsoft\PolicyManager\current\" + sid + @"\Connectivity";
                RegistryBackupStore.CaptureValue("HKEY_LOCAL_MACHINE", path, "DisableCrossDeviceResume", sid);
                RegistryBackupStore.CaptureValue("HKEY_LOCAL_MACHINE", path, "DisableCrossDeviceResume_ProviderSet", sid);
                Log(log, "Backup: CrossDeviceResume policy registry values.");
            }
            else if (script.FileName.Equals("Unsplit Services.ps1", StringComparison.OrdinalIgnoreCase))
            {
                RegistryBackupStore.CaptureValue("HKEY_LOCAL_MACHINE", @"SYSTEM\CurrentControlSet\Control", "SvcHostSplitThresholdInKB", sid);
                Log(log, "Backup: SvcHostSplitThresholdInKB.");
            }
            else if (script.FileName.Equals("Networking Tweaks.ps1", StringComparison.OrdinalIgnoreCase))
            {
                CaptureChildValueSet(@"SYSTEM\CurrentControlSet\services\NetBT\Parameters\Interfaces", new[] { "NetbiosOptions" }, sid);
                CaptureChildValueSet(@"SYSTEM\CurrentControlSet\Services\Tcpip\Parameters\Interfaces", NetworkInterfaceValues, sid);
                Log(log, "Backup: explicit registry values changed by Networking Tweaks.ps1.");
            }
        }

        private static void CaptureActionRegistry(string action, string sid, Action<string> log)
        {
            if (string.Equals(action, "remove-lockdown", StringComparison.OrdinalIgnoreCase))
            {
                RegistryBackupStore.CaptureValue("HKEY_LOCAL_MACHINE", @"SYSTEM\CurrentControlSet\Control\Session Manager\Environment", "__PSLockdownPolicy", sid);
                Log(log, "Backup: __PSLockdownPolicy.");
            }
            else if (string.Equals(action, "disable-app-offloading", StringComparison.OrdinalIgnoreCase))
            {
                foreach (string path in EnumerateKeysWithValue(@"SOFTWARE\Microsoft\Windows\CurrentVersion\InstallService\Stubification", "EnableAppOffloading"))
                    RegistryBackupStore.CaptureValue("HKEY_LOCAL_MACHINE", path, "EnableAppOffloading", sid);
                Log(log, "Backup: discovered EnableAppOffloading values.");
            }
        }

        private static void CaptureChildValueSet(string parentPath, IEnumerable<string> valueNames, string sid)
        {
            using (RegistryKey parent = RegistryUtil.OpenKey("HKEY_LOCAL_MACHINE", parentPath, false))
            {
                if (parent == null) return;
                foreach (string sub in parent.GetSubKeyNames())
                {
                    string path = parentPath + "\\" + sub;
                    foreach (string valueName in valueNames) RegistryBackupStore.CaptureValue("HKEY_LOCAL_MACHINE", path, valueName, sid);
                }
            }
        }

        private static IList<string> EnumerateKeysWithValue(string rootPath, string valueName)
        {
            List<string> result = new List<string>();
            using (RegistryKey root = RegistryUtil.OpenKey("HKEY_LOCAL_MACHINE", rootPath, false))
            {
                if (root == null) return result;
                WalkForValue(root, rootPath, valueName, result);
            }
            return result;
        }

        private static void WalkForValue(RegistryKey key, string path, string valueName, List<string> result)
        {
            if (key.GetValueNames().Any(x => string.Equals(x, valueName, StringComparison.OrdinalIgnoreCase))) result.Add(path);
            foreach (string sub in key.GetSubKeyNames())
            {
                try
                {
                    using (RegistryKey child = key.OpenSubKey(sub, false))
                        if (child != null) WalkForValue(child, path + "\\" + sub, valueName, result);
                }
                catch { }
            }
        }

        private static void RunEmbeddedScript(ScriptAsset script)
        {
            string dir = Path.Combine(Path.GetTempPath(), "Gallery Inc", "MelodyScript", "Scripts", Guid.NewGuid().ToString("N"));
            Directory.CreateDirectory(dir);
            string file = Path.Combine(dir, script.FileName);
            File.WriteAllBytes(file, EmbeddedAssets.ReadBytes(script.ResourceName));
            try
            {
                string extension = Path.GetExtension(file);
                if (extension.Equals(".ps1", StringComparison.OrdinalIgnoreCase))
                    RunProcess("powershell.exe", "-NoProfile -ExecutionPolicy Bypass -File " + Quote(file), dir, true);
                else
                    RunProcess(Environment.GetEnvironmentVariable("COMSPEC") ?? "cmd.exe", "/d /c " + Quote(file), dir, true);
            }
            finally
            {
                try { Directory.Delete(dir, true); } catch { }
            }
        }

        private static void RunAction(string action, string sid, bool restartExplorerForGameDvr, Action<string> log)
        {
            if (string.Equals(action, "remove-lockdown", StringComparison.OrdinalIgnoreCase))
            {
                using (RegistryKey key = RegistryUtil.OpenKey("HKEY_LOCAL_MACHINE", @"SYSTEM\CurrentControlSet\Control\Session Manager\Environment", true))
                    if (key != null) key.DeleteValue("__PSLockdownPolicy", false);
                return;
            }
            if (string.Equals(action, "disable-app-offloading", StringComparison.OrdinalIgnoreCase))
            {
                foreach (string path in EnumerateKeysWithValue(@"SOFTWARE\Microsoft\Windows\CurrentVersion\InstallService\Stubification", "EnableAppOffloading"))
                {
                    using (RegistryKey key = RegistryUtil.OpenKey("HKEY_LOCAL_MACHINE", path, true))
                        if (key != null) key.SetValue("EnableAppOffloading", 0, RegistryValueKind.DWord);
                }
                return;
            }
            if (string.Equals(action, "disable-hibernation", StringComparison.OrdinalIgnoreCase))
            {
                RunProcess("powercfg.exe", "-h off", Environment.SystemDirectory, true);
                return;
            }
            if (string.Equals(action, "disable-reserved-storage", StringComparison.OrdinalIgnoreCase))
            {
                RunProcess(Path.Combine(Environment.SystemDirectory, "dism.exe"), "/Online /Set-ReservedStorageState /State:Disabled", Environment.SystemDirectory, true);
                return;
            }
            if (string.Equals(action, "clear-gamedvr", StringComparison.OrdinalIgnoreCase))
            {
                ClearCurrentUserGameDvrCache(restartExplorerForGameDvr, log);
                return;
            }
            throw new NotSupportedException("Unknown Melody action: " + action);
        }


        private static void ClearCurrentUserGameDvrCache(bool restartExplorer, Action<string> log)
        {
            string gameDvr = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Microsoft", "GameDVR");
            bool explorerWasStopped = false;

            try
            {
                if (restartExplorer)
                {
                    Log(log, "  GameDVR: stopping Windows Explorer to release cache handles...");
                    explorerWasStopped = StopExplorer();
                    System.Threading.Thread.Sleep(500);
                }

                if (!Directory.Exists(gameDvr))
                {
                    Log(log, "  GameDVR cache folder does not exist; nothing to clear.");
                    return;
                }

                Exception last = null;
                for (int attempt = 1; attempt <= 8; attempt++)
                {
                    try
                    {
                        NormalizeAttributes(gameDvr);
                        Directory.Delete(gameDvr, true);
                        Log(log, "  GameDVR cache cleared.");
                        return;
                    }
                    catch (IOException ex)
                    {
                        last = ex;
                    }
                    catch (UnauthorizedAccessException ex)
                    {
                        last = ex;
                    }

                    System.Threading.Thread.Sleep(250);
                }

                if (!restartExplorer)
                    throw new IOException("The GameDVR cache is still in use. Run the action again and choose Yes when Melody asks to restart Windows Explorer.", last);
                throw new IOException("The GameDVR cache is still in use even after Windows Explorer was restarted. Close Xbox Game Bar or other recording software and try again.", last);
            }
            finally
            {
                if (restartExplorer && explorerWasStopped)
                {
                    Log(log, "  GameDVR: starting Windows Explorer again...");
                    StartExplorer();
                }
            }
        }

        private static bool StopExplorer()
        {
            Process[] processes = Process.GetProcessesByName("explorer");
            bool stopped = false;
            foreach (Process process in processes)
            {
                try
                {
                    process.Kill();
                    process.WaitForExit(5000);
                    stopped = true;
                }
                catch { }
                finally { process.Dispose(); }
            }
            return stopped;
        }

        private static void StartExplorer()
        {
            try
            {
                string explorer = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), "explorer.exe");
                Process.Start(new ProcessStartInfo
                {
                    FileName = explorer,
                    UseShellExecute = true,
                    WorkingDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Windows)
                });
            }
            catch { }
        }

        private static void NormalizeAttributes(string directory)
        {
            try
            {
                DirectoryInfo root = new DirectoryInfo(directory);
                root.Attributes &= ~FileAttributes.ReadOnly;
                foreach (FileInfo file in root.GetFiles("*", SearchOption.AllDirectories))
                {
                    try { file.Attributes = FileAttributes.Normal; } catch { }
                }
                foreach (DirectoryInfo dir in root.GetDirectories("*", SearchOption.AllDirectories))
                {
                    try { dir.Attributes &= ~FileAttributes.ReadOnly; } catch { }
                }
            }
            catch { }
        }

        private static void RunProcess(string fileName, string arguments, string workingDirectory, bool hidden)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = fileName,
                Arguments = arguments,
                WorkingDirectory = workingDirectory,
                UseShellExecute = false,
                CreateNoWindow = hidden,
                WindowStyle = hidden ? ProcessWindowStyle.Hidden : ProcessWindowStyle.Normal,
                RedirectStandardOutput = false,
                RedirectStandardError = false
            };
            using (Process process = Process.Start(psi))
            {
                if (process == null) throw new InvalidOperationException("Could not start " + fileName + ".");
                process.WaitForExit();
                if (process.ExitCode != 0)
                    throw new InvalidOperationException(Path.GetFileName(fileName) + " exited with code " + process.ExitCode + ".");
            }
        }

        private static string Quote(string value)
        {
            return "\"" + (value ?? string.Empty).Replace("\"", "\\\"") + "\"";
        }

        private static void Log(Action<string> log, string text)
        {
            if (log != null) log(text);
        }
    }
}
