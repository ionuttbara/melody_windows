# Telemetry/Logging/Disable Windows WMI Loggers.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `ba72dedaf6d25199e195cfc3c878fb68135362fd64bd29abd455d9c5f4e503bd`
- **Recipe verdict / verdict rețetă:** `RETIRED`
- **Windows container / interval Windows:** `7600+`
- **Runtime prerequisite / condiție runtime:** `none / niciuna`
- **Value/operation descriptions / operații:** 49
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L6 · SET-VALUE · `WMIEnable`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\Reliability Analysis\WMI`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „WMIEnable” în ramura Policies / Microsoft / Windows la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “WMIEnable” option in registry branch Policies / Microsoft / Windows to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows policy-family value; exact target value must already exist unless separately documented above.
- **OS support / versiuni:** `7600+`

### L9 · SET-VALUE · `TimeStampInterval`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Reliability`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Time Stamp Interval” în ramura Microsoft / Windows / CurrentVersion la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Time Stamp Interval” option in registry branch Microsoft / Windows / CurrentVersion to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L13 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\WMI\Autologger\NtfsLog`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „NtfsLog” din ramura CurrentControlSet / Control / WMI, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “NtfsLog” key in registry branch CurrentControlSet / Control / WMI, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L15 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\WMI\Autologger\RefsLog`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „RefsLog” din ramura CurrentControlSet / Control / WMI, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “RefsLog” key in registry branch CurrentControlSet / Control / WMI, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L17 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\WMI\GlobalLogger`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „GlobalLogger” din ramura CurrentControlSet / Control / WMI, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “GlobalLogger” key in registry branch CurrentControlSet / Control / WMI, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L19 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\WMI\Autologger\WMI_Traces`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „WMI_Traces” din ramura CurrentControlSet / Control / WMI, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “WMI_Traces” key in registry branch CurrentControlSet / Control / WMI, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L21 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\WMI\Autologger\EventLog-Nefarius-Drivers-HidHide-Diagnostic`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „EventLog-Nefarius-Drivers-HidHide-Diagnostic” din ramura CurrentControlSet / Control / WMI, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “EventLog-Nefarius-Drivers-HidHide-Diagnostic” key in registry branch CurrentControlSet / Control / WMI, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L23 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\WMI\Autologger\EventLog-Nefarius-Drivers-HidHideClient-Diagnostic`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „EventLog-Nefarius-Drivers-HidHideClient-Diagnostic” din ramura CurrentControlSet / Control / WMI, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “EventLog-Nefarius-Drivers-HidHideClient-Diagnostic” key in registry branch CurrentControlSet / Control / WMI, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L25 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\WMI\Autologger\EventLog-Nefarius-Drivers-HidHideCLI-Diagnostic`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „EventLog-Nefarius-Drivers-HidHideCLI-Diagnostic” din ramura CurrentControlSet / Control / WMI, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “EventLog-Nefarius-Drivers-HidHideCLI-Diagnostic” key in registry branch CurrentControlSet / Control / WMI, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L27 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\WMI\Autologger\Cellcore`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „Cellcore” din ramura CurrentControlSet / Control / WMI, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “Cellcore” key in registry branch CurrentControlSet / Control / WMI, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L29 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\WMI\Autologger\Circular Kernel Context Logger`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „Circular Kernel Context Logger” din ramura CurrentControlSet / Control / WMI, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “Circular Kernel Context Logger” key in registry branch CurrentControlSet / Control / WMI, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L31 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\WMI\Autologger\CloudExperienceHostOobe`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „CloudExperienceHostOobe” din ramura CurrentControlSet / Control / WMI, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “CloudExperienceHostOobe” key in registry branch CurrentControlSet / Control / WMI, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L33 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\WMI\Autologger\DataMarket`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „DataMarket” din ramura CurrentControlSet / Control / WMI, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “DataMarket” key in registry branch CurrentControlSet / Control / WMI, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L35 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\WMI\Autologger\HolographicDevice`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „HolographicDevice” din ramura CurrentControlSet / Control / WMI, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “HolographicDevice” key in registry branch CurrentControlSet / Control / WMI, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L37 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\WMI\Autologger\iclsClient`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „iclsClient” din ramura CurrentControlSet / Control / WMI, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “iclsClient” key in registry branch CurrentControlSet / Control / WMI, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L39 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\WMI\Autologger\iclsProxy`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „iclsProxy” din ramura CurrentControlSet / Control / WMI, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “iclsProxy” key in registry branch CurrentControlSet / Control / WMI, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L41 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\WMI\Autologger\Mellanox-Kernel`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „Mellanox-Kernel” din ramura CurrentControlSet / Control / WMI, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “Mellanox-Kernel” key in registry branch CurrentControlSet / Control / WMI, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L43 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\WMI\Autologger\Microsoft-Windows-AssignedAccess-Trace`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „Microsoft-Windows-AssignedAccess-Trace” din ramura CurrentControlSet / Control / WMI, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “Microsoft-Windows-AssignedAccess-Trace” key in registry branch CurrentControlSet / Control / WMI, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L45 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\WMI\Autologger\Microsoft-Windows-Setup`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „Microsoft-Windows-Setup” din ramura CurrentControlSet / Control / WMI, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “Microsoft-Windows-Setup” key in registry branch CurrentControlSet / Control / WMI, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L47 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\WMI\Autologger\NBSMBLOGGER`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „NBSMBLOGGER” din ramura CurrentControlSet / Control / WMI, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “NBSMBLOGGER” key in registry branch CurrentControlSet / Control / WMI, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L49 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\WMI\Autologger\PEAuthLog`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „PEAuthLog” din ramura CurrentControlSet / Control / WMI, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “PEAuthLog” key in registry branch CurrentControlSet / Control / WMI, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L51 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\WMI\Autologger\RdrLog`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „RdrLog” din ramura CurrentControlSet / Control / WMI, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “RdrLog” key in registry branch CurrentControlSet / Control / WMI, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L53 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\WMI\Autologger\ReadyBoot`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „ReadyBoot” din ramura CurrentControlSet / Control / WMI, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “ReadyBoot” key in registry branch CurrentControlSet / Control / WMI, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L55 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\WMI\Autologger\SetupPlatform`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „SetupPlatform” din ramura CurrentControlSet / Control / WMI, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “SetupPlatform” key in registry branch CurrentControlSet / Control / WMI, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L57 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\WMI\Autologger\SetupPlatformTel`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „SetupPlatformTel” din ramura CurrentControlSet / Control / WMI, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “SetupPlatformTel” key in registry branch CurrentControlSet / Control / WMI, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L59 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\WMI\Autologger\SocketHeciServer`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „SocketHeciServer” din ramura CurrentControlSet / Control / WMI, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “SocketHeciServer” key in registry branch CurrentControlSet / Control / WMI, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L61 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\WMI\Autologger\SpoolerLogger`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „SpoolerLogger” din ramura CurrentControlSet / Control / WMI, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “SpoolerLogger” key in registry branch CurrentControlSet / Control / WMI, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L63 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\WMI\Autologger\SQMLogger`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „SQMLogger” din ramura CurrentControlSet / Control / WMI, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “SQMLogger” key in registry branch CurrentControlSet / Control / WMI, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L65 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\WMI\Autologger\TileStore`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „TileStore” din ramura CurrentControlSet / Control / WMI, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “TileStore” key in registry branch CurrentControlSet / Control / WMI, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L67 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\WMI\Autologger\Tpm`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „Tpm” din ramura CurrentControlSet / Control / WMI, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “Tpm” key in registry branch CurrentControlSet / Control / WMI, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L69 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\WMI\Autologger\TPMProvisioningService`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „TPMProvisioningService” din ramura CurrentControlSet / Control / WMI, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “TPMProvisioningService” key in registry branch CurrentControlSet / Control / WMI, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L71 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\WMI\Autologger\WiFiDriverIHVSession`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „WiFiDriverIHVSession” din ramura CurrentControlSet / Control / WMI, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “WiFiDriverIHVSession” key in registry branch CurrentControlSet / Control / WMI, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L73 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\WMI\Autologger\WiFiDriverIHVSessionRepro`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „WiFiDriverIHVSessionRepro” din ramura CurrentControlSet / Control / WMI, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “WiFiDriverIHVSessionRepro” key in registry branch CurrentControlSet / Control / WMI, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L75 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\WMI\Autologger\WifiDriverSession`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „WifiDriverSession” din ramura CurrentControlSet / Control / WMI, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “WifiDriverSession” key in registry branch CurrentControlSet / Control / WMI, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L77 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\WMI\Autologger\WiFiSession`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „WiFiSession” din ramura CurrentControlSet / Control / WMI, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “WiFiSession” key in registry branch CurrentControlSet / Control / WMI, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L79 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\WMI\Autologger\Microsoft-Windows-Rdp-Graphics-RdpIdd-Trace`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „Microsoft-Windows-Rdp-Graphics-RdpIdd-Trace” din ramura CurrentControlSet / Control / WMI, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “Microsoft-Windows-Rdp-Graphics-RdpIdd-Trace” key in registry branch CurrentControlSet / Control / WMI, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L81 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\WMI\Autologger\UBPM`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „UBPM” din ramura CurrentControlSet / Control / WMI, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “UBPM” key in registry branch CurrentControlSet / Control / WMI, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L83 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\WMI\Autologger\WFP-IPsec Trace`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „WFP-IPsec Trace” din ramura CurrentControlSet / Control / WMI, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “WFP-IPsec Trace” key in registry branch CurrentControlSet / Control / WMI, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L85 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\WMI\Autologger\WinPhoneCritical`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „WinPhoneCritical” din ramura CurrentControlSet / Control / WMI, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “WinPhoneCritical” key in registry branch CurrentControlSet / Control / WMI, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L87 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\WMI\Autologger\Diagtrack-Listener`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „Diagtrack-Listener” din ramura CurrentControlSet / Control / WMI, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “Diagtrack-Listener” key in registry branch CurrentControlSet / Control / WMI, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L89 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\WMI\Autologger\DiagLog`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „DiagLog” din ramura CurrentControlSet / Control / WMI, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “DiagLog” key in registry branch CurrentControlSet / Control / WMI, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L91 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\WMI\Autologger\UnionFS-Filter`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „UnionFS-Filter” din ramura CurrentControlSet / Control / WMI, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “UnionFS-Filter” key in registry branch CurrentControlSet / Control / WMI, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L93 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\WMI\Autologger\Microsoft-Windows-ProjFS-Filter-Log`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „Microsoft-Windows-ProjFS-Filter-Log” din ramura CurrentControlSet / Control / WMI, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “Microsoft-Windows-ProjFS-Filter-Log” key in registry branch CurrentControlSet / Control / WMI, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L95 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\WMI\Autologger\NetCore`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „NetCore” din ramura CurrentControlSet / Control / WMI, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “NetCore” key in registry branch CurrentControlSet / Control / WMI, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L97 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\WMI\Autologger\WdiContextLog`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „WdiContextLog” din ramura CurrentControlSet / Control / WMI, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “WdiContextLog” key in registry branch CurrentControlSet / Control / WMI, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L99 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\WMI\Autologger\RadioMgr`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „RadioMgr” din ramura CurrentControlSet / Control / WMI, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “RadioMgr” key in registry branch CurrentControlSet / Control / WMI, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L101 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\WMI\Autologger\FilterMgr-Logger`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „FilterMgr-Logger” din ramura CurrentControlSet / Control / WMI, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “FilterMgr-Logger” key in registry branch CurrentControlSet / Control / WMI, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L103 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\WMI\Autologger\LwtNetLog`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „LwtNetLog” din ramura CurrentControlSet / Control / WMI, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “LwtNetLog” key in registry branch CurrentControlSet / Control / WMI, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L105 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\WMI\Autologger\TCPIPLOGGER`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „TCPIPLOGGER” din ramura CurrentControlSet / Control / WMI, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “TCPIPLOGGER” key in registry branch CurrentControlSet / Control / WMI, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

## Referințe / References

- Raw Registry execution is retired because no supportable cross-version contract was established for the recipe.
