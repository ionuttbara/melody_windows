using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Melody
{
    internal sealed class ScheduledTaskState
    {
        public string Path { get; set; }
        public bool Enabled { get; set; }
    }

    internal sealed class ScheduledTaskChangeResult
    {
        public int Matched { get; set; }
        public int Changed { get; set; }
        public List<string> Errors { get; private set; }

        public ScheduledTaskChangeResult()
        {
            Errors = new List<string>();
        }
    }

    internal static class TaskSchedulerMaintenance
    {
        public const string EdgeUpdateTaskPrefix = "MicrosoftEdgeUpdateTask";

        public static IList<ScheduledTaskState> FindByNamePrefix(string prefix)
        {
            List<ScheduledTaskState> result = new List<ScheduledTaskState>();
            if (string.IsNullOrWhiteSpace(prefix)) return result;

            object serviceObj = null;
            object rootFolderObj = null;
            try
            {
                Type type = Type.GetTypeFromProgID("Schedule.Service");
                if (type == null) throw new InvalidOperationException("Task Scheduler COM API is unavailable.");
                serviceObj = Activator.CreateInstance(type);
                dynamic service = serviceObj;
                service.Connect();
                rootFolderObj = service.GetFolder("\\");
                EnumerateFolder((dynamic)rootFolderObj, prefix, result);
                return result;
            }
            finally
            {
                ReleaseCom(rootFolderObj);
                ReleaseCom(serviceObj);
            }
        }

        public static ScheduledTaskChangeResult SetEnabledByNamePrefix(string prefix, bool enabled)
        {
            ScheduledTaskChangeResult result = new ScheduledTaskChangeResult();
            if (string.IsNullOrWhiteSpace(prefix))
            {
                result.Errors.Add("Task-name prefix is empty.");
                return result;
            }

            object serviceObj = null;
            object rootFolderObj = null;
            try
            {
                Type type = Type.GetTypeFromProgID("Schedule.Service");
                if (type == null)
                {
                    result.Errors.Add("Task Scheduler COM API is unavailable.");
                    return result;
                }
                serviceObj = Activator.CreateInstance(type);
                dynamic service = serviceObj;
                service.Connect();
                rootFolderObj = service.GetFolder("\\");
                SetEnabledInFolder((dynamic)rootFolderObj, prefix, enabled, result);
                return result;
            }
            catch (Exception ex)
            {
                result.Errors.Add(ex.Message);
                return result;
            }
            finally
            {
                ReleaseCom(rootFolderObj);
                ReleaseCom(serviceObj);
            }
        }

        // Exact-path check; never create an absent task or mistake a similarly named task for the target.
        public static bool TryGetState(string taskPath, out bool enabled)
        {
            enabled = false;
            object serviceObj = null;
            object folderObj = null;
            object taskObj = null;
            try
            {
                string folderPath, name;
                SplitTaskPath(taskPath, out folderPath, out name);
                if (String.IsNullOrWhiteSpace(name)) return false;
                Type type = Type.GetTypeFromProgID("Schedule.Service");
                if (type == null) return false;
                serviceObj = Activator.CreateInstance(type);
                dynamic service = serviceObj;
                service.Connect();
                folderObj = service.GetFolder(folderPath);
                dynamic folder = folderObj;
                taskObj = folder.GetTask(name);
                dynamic task = taskObj;
                // Require the resolved task path to be identical, not a prefix.
                if (!String.Equals(Convert.ToString(task.Path), taskPath, StringComparison.OrdinalIgnoreCase)) return false;
                enabled = Convert.ToBoolean(task.Enabled);
                return true;
            }
            catch { return false; }
            finally
            {
                ReleaseCom(taskObj);
                ReleaseCom(folderObj);
                ReleaseCom(serviceObj);
            }
        }

        public static void SetEnabled(string taskPath, bool enabled)
        {
            object serviceObj = null;
            object folderObj = null;
            object taskObj = null;
            try
            {
                string folderPath;
                string name;
                SplitTaskPath(taskPath, out folderPath, out name);
                Type type = Type.GetTypeFromProgID("Schedule.Service");
                if (type == null) throw new InvalidOperationException("Task Scheduler COM API is unavailable.");
                serviceObj = Activator.CreateInstance(type);
                dynamic service = serviceObj;
                service.Connect();
                folderObj = service.GetFolder(folderPath);
                dynamic folder = folderObj;
                taskObj = folder.GetTask(name);
                dynamic task = taskObj;
                task.Enabled = enabled;
            }
            finally
            {
                ReleaseCom(taskObj);
                ReleaseCom(folderObj);
                ReleaseCom(serviceObj);
            }
        }

        private static void EnumerateFolder(dynamic folder, string prefix, List<ScheduledTaskState> result)
        {
            object tasksObj = null;
            object foldersObj = null;
            try
            {
                tasksObj = folder.GetTasks(1); // include hidden tasks
                dynamic tasks = tasksObj;
                int taskCount = Convert.ToInt32(tasks.Count);
                for (int i = 1; i <= taskCount; i++)
                {
                    object taskObj = null;
                    try
                    {
                        taskObj = tasks.Item(i);
                        dynamic task = taskObj;
                        string name = Convert.ToString(task.Name);
                        if (!string.IsNullOrWhiteSpace(name) && name.StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
                        {
                            string path = Convert.ToString(task.Path);
                            if (string.IsNullOrWhiteSpace(path)) path = "\\" + name;
                            result.Add(new ScheduledTaskState
                            {
                                Path = path,
                                Enabled = Convert.ToBoolean(task.Enabled)
                            });
                        }
                    }
                    finally { ReleaseCom(taskObj); }
                }

                foldersObj = folder.GetFolders(0);
                dynamic folders = foldersObj;
                int folderCount = Convert.ToInt32(folders.Count);
                for (int i = 1; i <= folderCount; i++)
                {
                    object childObj = null;
                    try
                    {
                        childObj = folders.Item(i);
                        EnumerateFolder((dynamic)childObj, prefix, result);
                    }
                    finally { ReleaseCom(childObj); }
                }
            }
            finally
            {
                ReleaseCom(tasksObj);
                ReleaseCom(foldersObj);
            }
        }

        private static void SetEnabledInFolder(dynamic folder, string prefix, bool enabled, ScheduledTaskChangeResult result)
        {
            object tasksObj = null;
            object foldersObj = null;
            try
            {
                tasksObj = folder.GetTasks(1);
                dynamic tasks = tasksObj;
                int taskCount = Convert.ToInt32(tasks.Count);
                for (int i = 1; i <= taskCount; i++)
                {
                    object taskObj = null;
                    try
                    {
                        taskObj = tasks.Item(i);
                        dynamic task = taskObj;
                        string name = Convert.ToString(task.Name);
                        if (!string.IsNullOrWhiteSpace(name) && name.StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
                        {
                            result.Matched++;
                            bool current = Convert.ToBoolean(task.Enabled);
                            if (current != enabled)
                            {
                                task.Enabled = enabled;
                                result.Changed++;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        if (result.Errors.Count < 8) result.Errors.Add("Task update failed: " + ex.Message);
                    }
                    finally { ReleaseCom(taskObj); }
                }

                foldersObj = folder.GetFolders(0);
                dynamic folders = foldersObj;
                int folderCount = Convert.ToInt32(folders.Count);
                for (int i = 1; i <= folderCount; i++)
                {
                    object childObj = null;
                    try
                    {
                        childObj = folders.Item(i);
                        SetEnabledInFolder((dynamic)childObj, prefix, enabled, result);
                    }
                    catch (Exception ex)
                    {
                        if (result.Errors.Count < 8) result.Errors.Add("Task folder scan failed: " + ex.Message);
                    }
                    finally { ReleaseCom(childObj); }
                }
            }
            finally
            {
                ReleaseCom(tasksObj);
                ReleaseCom(foldersObj);
            }
        }

        private static void SplitTaskPath(string path, out string folder, out string name)
        {
            string value = string.IsNullOrWhiteSpace(path) ? "\\" : path;
            int slash = value.LastIndexOf('\\');
            name = slash >= 0 ? value.Substring(slash + 1) : value;
            folder = slash <= 0 ? "\\" : value.Substring(0, slash);
        }

        private static void ReleaseCom(object value)
        {
            try
            {
                if (value != null && Marshal.IsComObject(value)) Marshal.FinalReleaseComObject(value);
            }
            catch { }
        }
    }
}
