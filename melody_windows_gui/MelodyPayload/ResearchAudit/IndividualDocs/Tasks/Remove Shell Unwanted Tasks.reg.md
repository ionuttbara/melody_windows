# Tasks/Remove Shell Unwanted Tasks.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `0daf32de588fb612fb38d54a6bcec8150d75c7c251efc884a8a0dce23ff377a5`
- **Recipe verdict / verdict rețetă:** `API`
- **Windows container / interval Windows:** `7600+`
- **Runtime prerequisite / condiție runtime:** `existing-key`
- **Value/operation descriptions / operații:** 3
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

## Referințe / References

- https://learn.microsoft.com/en-us/windows/win32/api/taskschd/nf-taskschd-itaskfolder-deletetask
