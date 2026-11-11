# Tasks/Remove Network  Tasks.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `467b517928f68789db1b7cb376da48710dbdcc001011c9684b88d6211dd89505`
- **Recipe verdict / verdict rețetă:** `API`
- **Windows container / interval Windows:** `7600+`
- **Runtime prerequisite / condiție runtime:** `existing-key`
- **Value/operation descriptions / operații:** 1
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L3 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Schedule\TaskCache\Tree\Microsoft\Windows\Network Connectivity Status Indicator`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „Network Connectivity Status Indicator” din ramura Microsoft / Windows NT / CurrentVersion, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Melody nu execută această operație Registry brută; configurarea este delegată API-ului sau paginii Windows dedicate.
- **What it configures / EN:** Deletes the entire “Network Connectivity Status Indicator” key in registry branch Microsoft / Windows NT / CurrentVersion, including all values and subkeys. Exact key semantics are unverified. Melody does not execute this raw Registry operation; configuration is delegated to the dedicated Windows API or page.
- **Final verdict / verdict final:** `API`
- **Certitudine / Evidence:** Raw TaskCache registry mutation replaced by Task Scheduler API (Vista+; Melody floor Windows 7).
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/taskschd/nf-taskschd-itaskfolder-deletetask`

## Referințe / References

- https://learn.microsoft.com/en-us/windows/win32/api/taskschd/nf-taskschd-itaskfolder-deletetask
