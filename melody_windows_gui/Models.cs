using System;
using System.Collections.Generic;

namespace Melody
{
    internal sealed class RegistryAsset
    {
        public string ResourceName { get; set; }
        public string RelativePath { get; set; }
        public string Category { get; set; }
        public string DisplayName { get; set; }
        public bool IsBloatware { get; set; }
        public bool IsContextMenu { get; set; }

        public override string ToString() { return DisplayName ?? RelativePath ?? ResourceName; }
    }

    internal sealed class ScriptAsset
    {
        public string ResourceName { get; set; }
        public string FileName { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public bool DefaultSelected { get; set; }

        public override string ToString() { return DisplayName ?? FileName ?? ResourceName; }
    }


    internal sealed class SystemActionInfo
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool DefaultSelected { get; set; }
        public bool ChangesRegistry { get; set; }
        public override string ToString() { return Name ?? Id; }
    }

    internal sealed class ApplySelection
    {
        public List<RegistryAsset> RegistryAssets { get; private set; }
        public List<ScriptAsset> Scripts { get; private set; }
        public List<string> Actions { get; private set; }
        public List<string> SelectedServices { get; private set; }
        public List<string> SelectedTasks { get; private set; }
        public int TargetBuild { get; set; }
        public bool IncludeIbbTaskExtras { get; set; }
        public bool RestartExplorerForGameDvr { get; set; }
        public bool RemoveDefender { get; set; }
        public bool RemoveWindowsSecurityApp { get; set; }
        public bool InstallStartBack { get; set; }

        public ApplySelection()
        {
            RegistryAssets = new List<RegistryAsset>();
            Scripts = new List<ScriptAsset>();
            Actions = new List<string>();
            SelectedServices = new List<string>();
            SelectedTasks = new List<string>();
        }
    }

    internal sealed class ApplyResult
    {
        public int RegistryFilesApplied { get; set; }
        public int RegistryOperationsApplied { get; set; }
        public int ScriptsRun { get; set; }
        public int ServicesChanged { get; set; }
        public int ScheduledTasksChanged { get; set; }
        public int ActionsRun { get; set; }
        public int SecurityRegistryFilesApplied { get; set; }
        public int InstallersRun { get; set; }
        public List<string> Errors { get; private set; }

        public ApplyResult() { Errors = new List<string>(); }
        public bool Success { get { return Errors.Count == 0; } }
    }
}
