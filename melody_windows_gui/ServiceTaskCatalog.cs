using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Xml;

namespace Melody
{
    internal sealed class OptionalOperation
    {
        public string Id, Kind, Category, Title, Description, Source, Start;
        public string AvailabilityLabel;
        public int MinBuild;
        public override string ToString() { return (AvailabilityLabel ?? "[READY]") + "  " + Title + "  ·  " + Category; }
    }

    // A strict opt-in catalogue. It never creates missing Windows services or tasks.
    // Service configuration goes through SCM (sc.exe), not by importing a generic .reg.
    internal static class ServiceTaskCatalog
    {
        private static readonly IList<OptionalOperation> All = Load();
        public static IList<OptionalOperation> Services { get { return All.Where(x => x.Kind == "service").ToList(); } }
        public static IList<OptionalOperation> Tasks { get { return All.Where(x => x.Kind == "task").ToList(); } }

        private static IList<OptionalOperation> Load()
        {
            List<OptionalOperation> result = new List<OptionalOperation>();
            using (Stream input = typeof(ServiceTaskCatalog).Assembly.GetManifestResourceStream("Melody.ServiceTasks/Catalog.xml"))
            {
                if (input == null) return result;
                XmlDocument document = new XmlDocument();
                document.XmlResolver = null;
                document.Load(input);
                foreach (XmlNode node in document.SelectNodes("/optionalCatalog/option"))
                {
                    Func<string, string> get = name => node.Attributes[name] == null ? "" : node.Attributes[name].Value;
                    result.Add(new OptionalOperation {
                        Id = get("id").Replace("\\\\", "\\"), Kind = get("kind"), Category = get("category"),
                        Title = get("title"), Description = get("description"), Source = get("source"),
                        Start = get("start"), MinBuild = Int32.Parse(get("min_build"), CultureInfo.InvariantCulture)
                    });
                }
            }
            // Untrusted/accidentally altered manifest cannot select arbitrary SCM objects.
            if (result.GroupBy(x => x.Kind + "|" + x.Id, StringComparer.OrdinalIgnoreCase).Any(x => x.Count() > 1))
                throw new InvalidDataException("Duplicate service/task catalogue IDs.");
            return result;
        }

        public static OptionalOperation Find(string kind, string id)
        {
            return All.FirstOrDefault(x => x.Kind.Equals(kind, StringComparison.OrdinalIgnoreCase) &&
                x.Id.Equals(id, StringComparison.OrdinalIgnoreCase));
        }

        public static bool TryServiceStart(string name, out int startup)
        {
            startup = -1;
            if (String.IsNullOrWhiteSpace(name) || name.IndexOf('\\') >= 0 || name.IndexOf('"') >= 0) return false;
            try
            {
                using (RegistryKey root = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
                using (RegistryKey service = root.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\" + name, false))
                {
                    if (service == null) return false;
                    object typeObj = service.GetValue("Type");
                    if (typeObj == null) return false;
                    int type = Convert.ToInt32(typeObj, CultureInfo.InvariantCulture);
                    if ((type & 0x30) == 0 || (type & ~0x130) != 0) return false; // Only Windows user-mode services.
                    if (Convert.ToInt32(service.GetValue("LaunchProtected", 0), CultureInfo.InvariantCulture) != 0) return false;
                    object startObj = service.GetValue("Start");
                    if (startObj == null) return false;
                    startup = Convert.ToInt32(startObj, CultureInfo.InvariantCulture);
                    return startup >= 2 && startup <= 4; // no boot/system drivers
                }
            }
            catch { return false; }
        }

        public static bool Eligible(OptionalOperation op, WindowsProfile os, out string detail)
        {
            detail = "Ready.";
            if (op == null || os == null || !os.Supported || os.Build < op.MinBuild)
            { detail = "Requires Windows build " + (op == null ? 0 : op.MinBuild) + "+."; return false; }
            if (op.Kind == "service")
            {
                int existing;
                if (!TryServiceStart(op.Id, out existing)) { detail = "Target is not installed on this computer; Melody will skip it safely."; return true; }
                int target = op.Start == "manual" ? 3 : 4;
                if (existing == target) { detail = "Applied: " + StartupLabel(existing) + "."; return true; }
                detail = "Installed · current " + StartupLabel(existing) + " → " + StartupLabel(target) + ".";
                return true;
            }
            bool enabled;
            if (!TaskSchedulerMaintenance.TryGetState(op.Id, out enabled))
            { detail = "Target is not installed on this computer; Melody will skip it safely."; return true; }
            if (!enabled) { detail = "Applied: task already disabled."; return true; }
            detail = "Installed and enabled → disabled.";
            return true;
        }

        private static string StartupLabel(int value)
        {
            if (value == 2) return "Automatic";
            if (value == 3) return "Manual";
            if (value == 4) return "Disabled";
            return "Unsupported startup type";
        }

        public static void ConfigureStartup(string serviceName, int newStart)
        {
            int current;
            if (!TryServiceStart(serviceName, out current))
                throw new InvalidOperationException("Service is absent, protected or not a safe Windows service: " + serviceName);
            if (newStart < 2 || newStart > 4) throw new ArgumentOutOfRangeException("newStart");
            if (current == newStart) return;
            string sc = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "sc.exe");
            string startArg = newStart == 2 ? "auto" : newStart == 3 ? "demand" : "disabled";
            using (Process process = Process.Start(new ProcessStartInfo {
                FileName = sc, Arguments = "config \"" + serviceName + "\" start= " + startArg,
                UseShellExecute = false, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true
            }))
            {
                if (process == null) throw new InvalidOperationException("SCM did not start.");
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();
                process.WaitForExit();
                if (process.ExitCode != 0) throw new InvalidOperationException("SCM error " + process.ExitCode + ": " + output + " " + error);
            }
            int result;
            if (!TryServiceStart(serviceName, out result) || result != newStart)
                throw new InvalidOperationException("SCM did not confirm the requested start type for " + serviceName);
        }

        public static void Preflight(ApplySelection selection, WindowsProfile actual)
        {
            if (selection.SelectedServices.Distinct(StringComparer.OrdinalIgnoreCase).Count() != selection.SelectedServices.Count ||
                selection.SelectedTasks.Distinct(StringComparer.OrdinalIgnoreCase).Count() != selection.SelectedTasks.Count)
                throw new InvalidOperationException("Duplicate selected service/task.");
            foreach (string id in selection.SelectedServices)
            {
                OptionalOperation op = Find("service", id);
                if (op == null)
                    throw new InvalidOperationException("Service is not in Melody's approved catalogue: " + id);
                string detail;
                if (!Eligible(op, actual, out detail))
                    throw new InvalidOperationException("Service is no longer eligible: " + id + ". " + detail);
            }
            foreach (string id in selection.SelectedTasks)
            {
                OptionalOperation op = Find("task", id);
                if (op == null)
                    throw new InvalidOperationException("Scheduled task is not in Melody's approved catalogue: " + id);
                string detail;
                if (!Eligible(op, actual, out detail))
                    throw new InvalidOperationException("Scheduled task is no longer eligible: " + id + ". " + detail);
            }
        }
    }
}
