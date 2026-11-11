using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace Melody
{
    internal static class PowerRunBridge
    {
        private static readonly object ExtractLock = new object();
        private static string sessionDirectory;
        private static string sessionPowerRun;

        private static string GetPowerRunPath()
        {
            lock (ExtractLock)
            {
                if (!string.IsNullOrWhiteSpace(sessionPowerRun) && File.Exists(sessionPowerRun))
                    return sessionPowerRun;

                // PowerRun is extracted once per Melody process into a unique session folder.
                // Never overwrite the executable between registry operations: Windows can keep
                // the image locked briefly after execution, which previously caused hundreds
                // of "file is being used by another process" failures.
                sessionDirectory = Path.Combine(
                    Path.GetTempPath(),
                    "Gallery Inc",
                    "MelodyScript",
                    "PowerRun",
                    "session-" + Process.GetCurrentProcess().Id.ToString() + "-" + Guid.NewGuid().ToString("N"));
                Directory.CreateDirectory(sessionDirectory);
                sessionPowerRun = Path.Combine(sessionDirectory, "PowerRun.exe");
                File.WriteAllBytes(sessionPowerRun, EmbeddedAssets.ReadPowerRun());
                return sessionPowerRun;
            }
        }

        public static void ApplyRegistryText(string registryText, string sid)
        {
            string powerRun = GetPowerRunPath();
            string dir = Path.GetDirectoryName(powerRun);
            string regFile = Path.Combine(dir, "melody-" + Guid.NewGuid().ToString("N") + ".reg");

            string normalized = NormalizeCurrentUser(registryText ?? string.Empty, sid);
            File.WriteAllText(regFile, normalized, Encoding.Unicode);
            try
            {
                string regedit = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), "regedit.exe");
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = powerRun,
                    Arguments = Quote(regedit) + " /s " + Quote(regFile),
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    WorkingDirectory = dir,
                    WindowStyle = ProcessWindowStyle.Hidden
                };
                using (Process process = Process.Start(psi))
                {
                    if (process == null) throw new InvalidOperationException("PowerRun could not be started.");
                    process.WaitForExit();
                    if (process.ExitCode != 0) throw new InvalidOperationException("PowerRun/regedit failed with exit code " + process.ExitCode + ".");
                }
            }
            finally
            {
                DeleteWithRetry(regFile);
            }
        }


        public static void RunPowerShellScriptText(string scriptText, string fileName)
        {
            string powerRun = GetPowerRunPath();
            string dir = Path.GetDirectoryName(powerRun);
            string safeName = string.IsNullOrWhiteSpace(fileName) ? "melody-worker.ps1" : fileName;
            string scriptFile = Path.Combine(dir, Guid.NewGuid().ToString("N") + "-" + safeName);
            File.WriteAllText(scriptFile, scriptText ?? string.Empty, new UTF8Encoding(true));
            try
            {
                string powershell = Path.Combine(Environment.SystemDirectory, @"WindowsPowerShell\v1.0\powershell.exe");
                if (!File.Exists(powershell)) powershell = "powershell.exe";
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = powerRun,
                    Arguments = Quote(powershell) + " -NoProfile -ExecutionPolicy Bypass -File " + Quote(scriptFile),
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    WorkingDirectory = dir,
                    WindowStyle = ProcessWindowStyle.Hidden
                };
                using (Process process = Process.Start(psi))
                {
                    if (process == null) throw new InvalidOperationException("PowerRun PowerShell worker could not be started.");
                    process.WaitForExit();
                    if (process.ExitCode != 0) throw new InvalidOperationException("PowerRun/PowerShell failed with exit code " + process.ExitCode + ".");
                }
            }
            finally
            {
                DeleteWithRetry(scriptFile);
            }
        }

        public static void DisableEdgeUpdateTasksWithPowerRun()
        {
            string powerRun = GetPowerRunPath();
            string dir = Path.GetDirectoryName(powerRun);
            string self = System.Reflection.Assembly.GetExecutingAssembly().Location;
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = powerRun,
                Arguments = Quote(self) + " --disable-edge-update-worker",
                UseShellExecute = false,
                CreateNoWindow = true,
                WorkingDirectory = Path.GetDirectoryName(self),
                WindowStyle = ProcessWindowStyle.Hidden
            };
            using (Process process = Process.Start(psi))
            {
                if (process == null) throw new InvalidOperationException("PowerRun task worker could not be started.");
                process.WaitForExit();
                if (process.ExitCode != 0) throw new InvalidOperationException("PowerRun task worker failed with exit code " + process.ExitCode + ".");
            }
        }

        public static void RestoreRegistryBackupWithPowerRun()
        {
            string powerRun = GetPowerRunPath();
            string self = System.Reflection.Assembly.GetExecutingAssembly().Location;
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = powerRun,
                Arguments = Quote(self) + " --restore-worker",
                UseShellExecute = false,
                CreateNoWindow = true,
                WorkingDirectory = Path.GetDirectoryName(self),
                WindowStyle = ProcessWindowStyle.Hidden
            };
            using (Process process = Process.Start(psi))
            {
                if (process == null) throw new InvalidOperationException("PowerRun restore worker could not be started.");
                process.WaitForExit();
                if (process.ExitCode != 0) throw new InvalidOperationException("PowerRun restore worker failed with exit code " + process.ExitCode + ".");
            }
        }

        private static void DeleteWithRetry(string path)
        {
            for (int attempt = 0; attempt < 5; attempt++)
            {
                try
                {
                    if (File.Exists(path)) File.Delete(path);
                    return;
                }
                catch (IOException) { System.Threading.Thread.Sleep(100); }
                catch (UnauthorizedAccessException) { System.Threading.Thread.Sleep(100); }
            }
        }

        private static string NormalizeCurrentUser(string text, string sid)
        {
            if (string.IsNullOrWhiteSpace(sid)) return text;
            text = text.Replace("[HKEY_CURRENT_USER\\", "[HKEY_USERS\\" + sid + "\\");
            text = text.Replace("[-HKEY_CURRENT_USER\\", "[-HKEY_USERS\\" + sid + "\\");
            return text;
        }

        private static string Quote(string value)
        {
            return "\"" + (value ?? string.Empty).Replace("\"", "\\\"") + "\"";
        }
    }
}
