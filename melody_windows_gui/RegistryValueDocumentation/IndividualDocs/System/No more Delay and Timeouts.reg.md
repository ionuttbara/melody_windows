# System/No more Delay and Timeouts.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `92c5df6242f8b69efee1774f501db47937ce48f19e8bfe765e5792136f46e81e`
- **Recipe verdict / verdict rețetă:** `RETIRED`
- **Windows container / interval Windows:** `7600+`
- **Runtime prerequisite / condiție runtime:** `existing-key`
- **Value/operation descriptions / operații:** 22
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L4 · SET-VALUE · `VerboseStatus`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Verbose Status” în ramura Microsoft / Windows / CurrentVersion la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Verbose Status” option in registry branch Microsoft / Windows / CurrentVersion to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L7 · SET-VALUE · `ShutdownReasonOn`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Reliability`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Shutdown Reason On” în ramura Microsoft / Windows / CurrentVersion la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Shutdown Reason On” option in registry branch Microsoft / Windows / CurrentVersion to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L8 · SET-VALUE · `ShutdownReasonUI`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Reliability`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Shutdown Reason UI” în ramura Microsoft / Windows / CurrentVersion la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Shutdown Reason UI” option in registry branch Microsoft / Windows / CurrentVersion to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L11 · SET-VALUE · `ShutdownReasonOn`

- **Registry key:** `HKEY_LOCAL_MACHINE\Software\Policies\Microsoft\Windows NT\Reliability`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Shutdown Reason On” în politicile componentelor Windows NT la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Shutdown Reason On” option in Windows NT component policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Application/vendor policy; applied only when its exact target already exists or the component prerequisite is met.
- **OS support / versiuni:** `7600+`

### L12 · SET-VALUE · `ShutdownReasonUI`

- **Registry key:** `HKEY_LOCAL_MACHINE\Software\Policies\Microsoft\Windows NT\Reliability`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Shutdown Reason UI” în politicile componentelor Windows NT la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Shutdown Reason UI” option in Windows NT component policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Application/vendor policy; applied only when its exact target already exists or the component prerequisite is met.
- **OS support / versiuni:** `7600+`

### L15 · SET-VALUE · `ShutdownWarningDialogTimeout`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Windows`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Shutdown Warning Dialog Timeout” în ramura Microsoft / Windows NT / CurrentVersion la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Shutdown Warning Dialog Timeout” option in registry branch Microsoft / Windows NT / CurrentVersion to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L18 · SET-VALUE · `AutoEndTasks`

- **Registry key:** `HKEY_CURRENT_USER\Control Panel\Desktop`
- **Raw .reg data:** `"1"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Auto End Tasks” în opțiunile desktopului la 1 (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Auto End Tasks” option in desktop settings to 1 (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L19 · SET-VALUE · `MenuShowDelay`

- **Registry key:** `HKEY_CURRENT_USER\Control Panel\Desktop`
- **Raw .reg data:** `"0"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Menu Show Delay” în opțiunile desktopului la 0 (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Menu Show Delay” option in desktop settings to 0 (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L20 · SET-VALUE · `ForegroundLockTimeout`

- **Registry key:** `HKEY_CURRENT_USER\Control Panel\Desktop`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Foreground Lock Timeout” în opțiunile desktopului la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Foreground Lock Timeout” option in desktop settings to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L21 · SET-VALUE · `WaitToKillAppTimeout`

- **Registry key:** `HKEY_CURRENT_USER\Control Panel\Desktop`
- **Raw .reg data:** `"1"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Wait To Kill App Timeout” în opțiunile desktopului la 1 (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Wait To Kill App Timeout” option in desktop settings to 1 (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L22 · SET-VALUE · `WaitToKillServiceTimeout`

- **Registry key:** `HKEY_CURRENT_USER\Control Panel\Desktop`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Wait To Kill Service Timeout” în opțiunile desktopului la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Wait To Kill Service Timeout” option in desktop settings to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L23 · SET-VALUE · `HungAppTimeout`

- **Registry key:** `HKEY_CURRENT_USER\Control Panel\Desktop`
- **Raw .reg data:** `"1000"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Hung App Timeout” în opțiunile desktopului la 1000 (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Hung App Timeout” option in desktop settings to 1000 (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L24 · SET-VALUE · `LowLevelHooksTimeout`

- **Registry key:** `HKEY_CURRENT_USER\Control Panel\Desktop`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Low Level Hooks Timeout” în opțiunile desktopului la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Low Level Hooks Timeout” option in desktop settings to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L27 · SET-VALUE · `WaitToKillServiceTimeout`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control`
- **Raw .reg data:** `"1"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Wait To Kill Service Timeout” în ramura SYSTEM / CurrentControlSet / Control la 1 (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Wait To Kill Service Timeout” option in registry branch SYSTEM / CurrentControlSet / Control to 1 (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L28 · SET-VALUE · `DisableRemoteScmEndpoints`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Disable Remote Scm Endpoints” în ramura SYSTEM / CurrentControlSet / Control la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Disable Remote Scm Endpoints” option in registry branch SYSTEM / CurrentControlSet / Control to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L29 · SET-VALUE · `HandlerTimeout`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control`
- **Raw .reg data:** `dword:7FFFFFFF`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Handler Timeout” în ramura SYSTEM / CurrentControlSet / Control la 2147483647 (0x7FFFFFFF) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Handler Timeout” option in registry branch SYSTEM / CurrentControlSet / Control to 2147483647 (0x7FFFFFFF) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L32 · SET-VALUE · `WaitToKillServiceTimeout`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control`
- **Raw .reg data:** `"1"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Wait To Kill Service Timeout” în ramura SYSTEM / ControlSet001 / Control la 1 (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Wait To Kill Service Timeout” option in registry branch SYSTEM / ControlSet001 / Control to 1 (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L33 · SET-VALUE · `DisableRemoteScmEndpoints`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Disable Remote Scm Endpoints” în ramura SYSTEM / ControlSet001 / Control la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Disable Remote Scm Endpoints” option in registry branch SYSTEM / ControlSet001 / Control to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L34 · SET-VALUE · `HandlerTimeout`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control`
- **Raw .reg data:** `dword:7FFFFFFF`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Handler Timeout” în ramura SYSTEM / ControlSet001 / Control la 2147483647 (0x7FFFFFFF) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Handler Timeout” option in registry branch SYSTEM / ControlSet001 / Control to 2147483647 (0x7FFFFFFF) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L37 · SET-VALUE · `PollBootPartitionTimeout`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\PnP`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Poll Boot Partition Timeout” în ramura CurrentControlSet / Control / PnP la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Poll Boot Partition Timeout” option in registry branch CurrentControlSet / Control / PnP to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L40 · SET-VALUE · `ThumbnailLivePreviewHoverTime`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Thumbnail Live Preview Hover Time” în Explorer și interfața shell la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Thumbnail Live Preview Hover Time” option in File Explorer and Windows shell to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L43 · SET-VALUE · `ServicesPipeTimeout`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control`
- **Raw .reg data:** `dword:00240000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Services Pipe Timeout” în ramura SYSTEM / CurrentControlSet / Control la 2359296 (0x00240000) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “Services Pipe Timeout” option in registry branch SYSTEM / CurrentControlSet / Control to 2359296 (0x00240000) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** 30,000 ms approximates the normal service timeout; recipe has no demonstrated optimization benefit.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/troubleshoot/windows-server/system-management-components/service-not-start-events-7000-7011-time-out-error`

## Referințe / References

- https://learn.microsoft.com/en-us/troubleshoot/windows-server/system-management-components/service-not-start-events-7000-7011-time-out-error
