using System;
using System.Diagnostics;
using System.IO;

namespace Melody
{
    internal static class InstallerRunner
    {
        public static void InstallStartBack(Action<string> log)
        {
            string dir = Path.Combine(Path.GetTempPath(), "Gallery Inc", "MelodyScript", "Installers", Guid.NewGuid().ToString("N"));
            Directory.CreateDirectory(dir);
            string fileName = EmbeddedAssets.GetStartBackInstallerFileName();
            string installer = Path.Combine(dir, fileName);
            File.WriteAllBytes(installer, EmbeddedAssets.ReadStartBackInstaller());
            try
            {
                if (log != null) log("Install StartBack: " + fileName + " /SILENT");
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = installer,
                    Arguments = "/SILENT",
                    WorkingDirectory = dir,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    WindowStyle = ProcessWindowStyle.Hidden
                };
                using (Process process = Process.Start(psi))
                {
                    if (process == null) throw new InvalidOperationException("StartBack installer could not be started.");
                    process.WaitForExit();
                    if (process.ExitCode != 0) throw new InvalidOperationException("StartBack silent installer returned exit code " + process.ExitCode + ".");
                }
            }
            finally
            {
                try { Directory.Delete(dir, true); } catch { }
            }
        }
    }
}
