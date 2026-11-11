using System;
using System.Windows.Forms;

namespace Melody
{
    internal static class Program
    {
        [STAThread]
        private static void Main(string[] args)
        {
            if (args != null && args.Length > 0 && string.Equals(args[0], "--disable-edge-update-worker", StringComparison.OrdinalIgnoreCase))
            {
                try
                {
                    ScheduledTaskChangeResult result = TaskSchedulerMaintenance.SetEnabledByNamePrefix(TaskSchedulerMaintenance.EdgeUpdateTaskPrefix, false);
                    Environment.ExitCode = result.Errors.Count == 0 ? 0 : 92;
                }
                catch
                {
                    Environment.ExitCode = 92;
                }
                return;
            }

            if (args != null && args.Length > 0 && string.Equals(args[0], "--restore-worker", StringComparison.OrdinalIgnoreCase))
            {
                try
                {
                    RegistryBackupStore.RestoreAll();
                    Environment.ExitCode = 0;
                }
                catch
                {
                    Environment.ExitCode = 91;
                }
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
