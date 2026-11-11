# Tasks/Remove In-Shell Tasks.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `80fdd32557141ec390eaa9d9668e310faba6e0ba9ff1f0c4448fba485cc0c443`
- **Recipe verdict / verdict rețetă:** `API`
- **Windows container / interval Windows:** `7600+`
- **Runtime prerequisite / condiție runtime:** `none / niciuna`
- **Value/operation descriptions / operații:** 16
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L3 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Schedule\TaskCache\Tree\Microsoft\Windows\Shell\FamilySafetyMonitor`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Elimină ramura meniului contextual/shell „FamilySafetyMonitor”, inclusiv comenzile și subcheile sale; verifică dacă alte extensii depind de aceasta. Melody nu execută această operație Registry brută; configurarea este delegată API-ului sau paginii Windows dedicate.
- **What it configures / EN:** Removes context-menu/shell branch “FamilySafetyMonitor”, including commands and child keys; check whether other extensions depend on it. Melody does not execute this raw Registry operation; configuration is delegated to the dedicated Windows API or page.
- **Final verdict / verdict final:** `API`
- **Certitudine / Evidence:** Raw TaskCache registry mutation replaced by Task Scheduler API (Vista+; Melody floor Windows 7).
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/taskschd/nf-taskschd-itaskfolder-deletetask`

### L5 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Schedule\TaskCache\Tree\Microsoft\Windows\Shell\FamilySafetyRefreshTask`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Elimină ramura meniului contextual/shell „FamilySafetyRefreshTask”, inclusiv comenzile și subcheile sale; verifică dacă alte extensii depind de aceasta. Melody nu execută această operație Registry brută; configurarea este delegată API-ului sau paginii Windows dedicate.
- **What it configures / EN:** Removes context-menu/shell branch “FamilySafetyRefreshTask”, including commands and child keys; check whether other extensions depend on it. Melody does not execute this raw Registry operation; configuration is delegated to the dedicated Windows API or page.
- **Final verdict / verdict final:** `API`
- **Certitudine / Evidence:** Raw TaskCache registry mutation replaced by Task Scheduler API (Vista+; Melody floor Windows 7).
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/taskschd/nf-taskschd-itaskfolder-deletetask`

### L7 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Schedule\TaskCache\Tree\Microsoft\Windows\Shell\IndexerAutomaticMaintenance`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Elimină ramura meniului contextual/shell „IndexerAutomaticMaintenance”, inclusiv comenzile și subcheile sale; verifică dacă alte extensii depind de aceasta. Melody nu execută această operație Registry brută; configurarea este delegată API-ului sau paginii Windows dedicate.
- **What it configures / EN:** Removes context-menu/shell branch “IndexerAutomaticMaintenance”, including commands and child keys; check whether other extensions depend on it. Melody does not execute this raw Registry operation; configuration is delegated to the dedicated Windows API or page.
- **Final verdict / verdict final:** `API`
- **Certitudine / Evidence:** Raw TaskCache registry mutation replaced by Task Scheduler API (Vista+; Melody floor Windows 7).
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/taskschd/nf-taskschd-itaskfolder-deletetask`

### L9 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Schedule\TaskCache\Tree\Microsoft\Windows\PushToInstall`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „PushToInstall” din ramura Microsoft / Windows NT / CurrentVersion, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Melody nu execută această operație Registry brută; configurarea este delegată API-ului sau paginii Windows dedicate.
- **What it configures / EN:** Deletes the entire “PushToInstall” key in registry branch Microsoft / Windows NT / CurrentVersion, including all values and subkeys. Exact key semantics are unverified. Melody does not execute this raw Registry operation; configuration is delegated to the dedicated Windows API or page.
- **Final verdict / verdict final:** `API`
- **Certitudine / Evidence:** Raw TaskCache registry mutation replaced by Task Scheduler API (Vista+; Melody floor Windows 7).
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/taskschd/nf-taskschd-itaskfolder-deletetask`

### L11 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Schedule\TaskCache\Tree\Microsoft\OneCore`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „OneCore” din ramura Microsoft / Windows NT / CurrentVersion, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Melody nu execută această operație Registry brută; configurarea este delegată API-ului sau paginii Windows dedicate.
- **What it configures / EN:** Deletes the entire “OneCore” key in registry branch Microsoft / Windows NT / CurrentVersion, including all values and subkeys. Exact key semantics are unverified. Melody does not execute this raw Registry operation; configuration is delegated to the dedicated Windows API or page.
- **Final verdict / verdict final:** `API`
- **Certitudine / Evidence:** Raw TaskCache registry mutation replaced by Task Scheduler API (Vista+; Melody floor Windows 7).
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/taskschd/nf-taskschd-itaskfolder-deletetask`

### L13 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Schedule\TaskCache\Tree\Microsoft\Windows\AppID`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „AppID” din ramura Microsoft / Windows NT / CurrentVersion, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Melody nu execută această operație Registry brută; configurarea este delegată API-ului sau paginii Windows dedicate.
- **What it configures / EN:** Deletes the entire “AppID” key in registry branch Microsoft / Windows NT / CurrentVersion, including all values and subkeys. Exact key semantics are unverified. Melody does not execute this raw Registry operation; configuration is delegated to the dedicated Windows API or page.
- **Final verdict / verdict final:** `API`
- **Certitudine / Evidence:** Raw TaskCache registry mutation replaced by Task Scheduler API (Vista+; Melody floor Windows 7).
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/taskschd/nf-taskschd-itaskfolder-deletetask`

### L15 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Schedule\TaskCache\Tree\Microsoft\Windows\ApplicationData`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „ApplicationData” din ramura Microsoft / Windows NT / CurrentVersion, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Melody nu execută această operație Registry brută; configurarea este delegată API-ului sau paginii Windows dedicate.
- **What it configures / EN:** Deletes the entire “ApplicationData” key in registry branch Microsoft / Windows NT / CurrentVersion, including all values and subkeys. Exact key semantics are unverified. Melody does not execute this raw Registry operation; configuration is delegated to the dedicated Windows API or page.
- **Final verdict / verdict final:** `API`
- **Certitudine / Evidence:** Raw TaskCache registry mutation replaced by Task Scheduler API (Vista+; Melody floor Windows 7).
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/taskschd/nf-taskschd-itaskfolder-deletetask`

### L17 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Schedule\TaskCache\Tree\Microsoft\Windows\SettingSync`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „SettingSync” din ramura Microsoft / Windows NT / CurrentVersion, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Melody nu execută această operație Registry brută; configurarea este delegată API-ului sau paginii Windows dedicate.
- **What it configures / EN:** Deletes the entire “SettingSync” key in registry branch Microsoft / Windows NT / CurrentVersion, including all values and subkeys. Exact key semantics are unverified. Melody does not execute this raw Registry operation; configuration is delegated to the dedicated Windows API or page.
- **Final verdict / verdict final:** `API`
- **Certitudine / Evidence:** Raw TaskCache registry mutation replaced by Task Scheduler API (Vista+; Melody floor Windows 7).
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/taskschd/nf-taskschd-itaskfolder-deletetask`

### L19 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Schedule\TaskCache\Tree\Microsoft\Windows\CloudExperienceHost`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „CloudExperienceHost” din ramura Microsoft / Windows NT / CurrentVersion, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Melody nu execută această operație Registry brută; configurarea este delegată API-ului sau paginii Windows dedicate.
- **What it configures / EN:** Deletes the entire “CloudExperienceHost” key in registry branch Microsoft / Windows NT / CurrentVersion, including all values and subkeys. Exact key semantics are unverified. Melody does not execute this raw Registry operation; configuration is delegated to the dedicated Windows API or page.
- **Final verdict / verdict final:** `API`
- **Certitudine / Evidence:** Raw TaskCache registry mutation replaced by Task Scheduler API (Vista+; Melody floor Windows 7).
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/taskschd/nf-taskschd-itaskfolder-deletetask`

### L21 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Schedule\TaskCache\Tree\Microsoft\Windows\Management`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „Management” din ramura Microsoft / Windows NT / CurrentVersion, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Melody nu execută această operație Registry brută; configurarea este delegată API-ului sau paginii Windows dedicate.
- **What it configures / EN:** Deletes the entire “Management” key in registry branch Microsoft / Windows NT / CurrentVersion, including all values and subkeys. Exact key semantics are unverified. Melody does not execute this raw Registry operation; configuration is delegated to the dedicated Windows API or page.
- **Final verdict / verdict final:** `API`
- **Certitudine / Evidence:** Raw TaskCache registry mutation replaced by Task Scheduler API (Vista+; Melody floor Windows 7).
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/taskschd/nf-taskschd-itaskfolder-deletetask`

### L23 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Schedule\TaskCache\Tree\Microsoft\Windows\NetTrace`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „NetTrace” din ramura Microsoft / Windows NT / CurrentVersion, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Melody nu execută această operație Registry brută; configurarea este delegată API-ului sau paginii Windows dedicate.
- **What it configures / EN:** Deletes the entire “NetTrace” key in registry branch Microsoft / Windows NT / CurrentVersion, including all values and subkeys. Exact key semantics are unverified. Melody does not execute this raw Registry operation; configuration is delegated to the dedicated Windows API or page.
- **Final verdict / verdict final:** `API`
- **Certitudine / Evidence:** Raw TaskCache registry mutation replaced by Task Scheduler API (Vista+; Melody floor Windows 7).
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/taskschd/nf-taskschd-itaskfolder-deletetask`

### L25 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Schedule\TaskCache\Tree\Microsoft\Windows\Offline Files`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „Offline Files” din ramura Microsoft / Windows NT / CurrentVersion, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Melody nu execută această operație Registry brută; configurarea este delegată API-ului sau paginii Windows dedicate.
- **What it configures / EN:** Deletes the entire “Offline Files” key in registry branch Microsoft / Windows NT / CurrentVersion, including all values and subkeys. Exact key semantics are unverified. Melody does not execute this raw Registry operation; configuration is delegated to the dedicated Windows API or page.
- **Final verdict / verdict final:** `API`
- **Certitudine / Evidence:** Raw TaskCache registry mutation replaced by Task Scheduler API (Vista+; Melody floor Windows 7).
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/taskschd/nf-taskschd-itaskfolder-deletetask`

### L27 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Schedule\TaskCache\Tree\Microsoft\Windows\PI`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „PI” din ramura Microsoft / Windows NT / CurrentVersion, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Melody nu execută această operație Registry brută; configurarea este delegată API-ului sau paginii Windows dedicate.
- **What it configures / EN:** Deletes the entire “PI” key in registry branch Microsoft / Windows NT / CurrentVersion, including all values and subkeys. Exact key semantics are unverified. Melody does not execute this raw Registry operation; configuration is delegated to the dedicated Windows API or page.
- **Final verdict / verdict final:** `API`
- **Certitudine / Evidence:** Raw TaskCache registry mutation replaced by Task Scheduler API (Vista+; Melody floor Windows 7).
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/taskschd/nf-taskschd-itaskfolder-deletetask`

### L29 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Schedule\TaskCache\Tree\Microsoft\Windows\PLA`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „PLA” din ramura Microsoft / Windows NT / CurrentVersion, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Melody nu execută această operație Registry brută; configurarea este delegată API-ului sau paginii Windows dedicate.
- **What it configures / EN:** Deletes the entire “PLA” key in registry branch Microsoft / Windows NT / CurrentVersion, including all values and subkeys. Exact key semantics are unverified. Melody does not execute this raw Registry operation; configuration is delegated to the dedicated Windows API or page.
- **Final verdict / verdict final:** `API`
- **Certitudine / Evidence:** Raw TaskCache registry mutation replaced by Task Scheduler API (Vista+; Melody floor Windows 7).
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/taskschd/nf-taskschd-itaskfolder-deletetask`

### L31 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Schedule\TaskCache\Tree\Microsoft\Windows\Kernel`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „Kernel” din ramura Microsoft / Windows NT / CurrentVersion, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Melody nu execută această operație Registry brută; configurarea este delegată API-ului sau paginii Windows dedicate.
- **What it configures / EN:** Deletes the entire “Kernel” key in registry branch Microsoft / Windows NT / CurrentVersion, including all values and subkeys. Exact key semantics are unverified. Melody does not execute this raw Registry operation; configuration is delegated to the dedicated Windows API or page.
- **Final verdict / verdict final:** `API`
- **Certitudine / Evidence:** Raw TaskCache registry mutation replaced by Task Scheduler API (Vista+; Melody floor Windows 7).
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/taskschd/nf-taskschd-itaskfolder-deletetask`

### L33 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Schedule\TaskCache\Tree\Microsoft\Windows\AppListBackup`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „AppListBackup” din ramura Microsoft / Windows NT / CurrentVersion, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Melody nu execută această operație Registry brută; configurarea este delegată API-ului sau paginii Windows dedicate.
- **What it configures / EN:** Deletes the entire “AppListBackup” key in registry branch Microsoft / Windows NT / CurrentVersion, including all values and subkeys. Exact key semantics are unverified. Melody does not execute this raw Registry operation; configuration is delegated to the dedicated Windows API or page.
- **Final verdict / verdict final:** `API`
- **Certitudine / Evidence:** Raw TaskCache registry mutation replaced by Task Scheduler API (Vista+; Melody floor Windows 7).
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/taskschd/nf-taskschd-itaskfolder-deletetask`

## Referințe / References

- https://learn.microsoft.com/en-us/windows/win32/api/taskschd/nf-taskschd-itaskfolder-deletetask
