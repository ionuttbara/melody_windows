# Devices/Disk Tweaks.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `382f7846adbcf6d31f0b88fa63692fb00ae26dedda3ebb2223effa1cd89917da`
- **Recipe verdict / verdict rețetă:** `RETIRED`
- **Windows container / interval Windows:** `7600+`
- **Runtime prerequisite / condiție runtime:** `existing-key`
- **Value/operation descriptions / operații:** 26
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L5 · SET-VALUE · `Enabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\LeapSecondInformation`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Enabled” în ramura CurrentControlSet / Control / LeapSecondInformation la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Enabled” option in registry branch CurrentControlSet / Control / LeapSecondInformation to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L8 · SET-VALUE · `TCGSecurityActivationDisabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\EnhancedStorageDevices`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „TCGSecurity Activation Disabled” în ramura Policies / Microsoft / Windows la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “TCGSecurity Activation Disabled” option in registry branch Policies / Microsoft / Windows to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows policy-family value; exact target value must already exist unless separately documented above.
- **OS support / versiuni:** `7600+`

### L11 · SET-VALUE · `TelemetryPerformanceEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\StorPort`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Telemetry Performance Enabled” în ramura CurrentControlSet / Control / StorPort la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Telemetry Performance Enabled” option in registry branch CurrentControlSet / Control / StorPort to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L12 · SET-VALUE · `TelemetryErrorDataEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\StorPort`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Telemetry Error Data Enabled” în ramura CurrentControlSet / Control / StorPort la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Telemetry Error Data Enabled” option in registry branch CurrentControlSet / Control / StorPort to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L13 · SET-VALUE · `TelemetryDeviceHealthEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\StorPort`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Telemetry Device Health Enabled” în ramura CurrentControlSet / Control / StorPort la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Telemetry Device Health Enabled” option in registry branch CurrentControlSet / Control / StorPort to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L14 · SET-VALUE · `HmbAllocationPolicy`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\StorPort`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Hmb Allocation Policy” în ramura CurrentControlSet / Control / StorPort la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Hmb Allocation Policy” option in registry branch CurrentControlSet / Control / StorPort to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L17 · SET-VALUE · `NVMeDisablePerfThrottling`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Classpnp`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „NVMe Disable Perf Throttling” în configurația claselor de dispozitive la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “NVMe Disable Perf Throttling” option in device-class configuration to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L20 · SET-VALUE · `LPM`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\services\iaStor\Parameters\Port0`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „LPM” în configurația serviciilor sau driverelor la 0 (0x00000000) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “LPM” option in service or driver configuration to 0 (0x00000000) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L21 · SET-VALUE · `LPMDSTATE`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\services\iaStor\Parameters\Port0`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „LPMDSTATE” în configurația serviciilor sau driverelor la 0 (0x00000000) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “LPMDSTATE” option in service or driver configuration to 0 (0x00000000) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L22 · SET-VALUE · `DIPM`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\services\iaStor\Parameters\Port0`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „DIPM” în configurația serviciilor sau driverelor la 0 (0x00000000) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “DIPM” option in service or driver configuration to 0 (0x00000000) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L25 · SET-VALUE · `LPM`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\services\iaStor\Parameters\Port1`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „LPM” în configurația serviciilor sau driverelor la 0 (0x00000000) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “LPM” option in service or driver configuration to 0 (0x00000000) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L26 · SET-VALUE · `LPMDSTATE`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\services\iaStor\Parameters\Port1`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „LPMDSTATE” în configurația serviciilor sau driverelor la 0 (0x00000000) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “LPMDSTATE” option in service or driver configuration to 0 (0x00000000) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L27 · SET-VALUE · `DIPM`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\services\iaStor\Parameters\Port1`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „DIPM” în configurația serviciilor sau driverelor la 0 (0x00000000) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “DIPM” option in service or driver configuration to 0 (0x00000000) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L30 · SET-VALUE · `LPM`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\services\iaStor\Parameters\Port2`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „LPM” în configurația serviciilor sau driverelor la 0 (0x00000000) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “LPM” option in service or driver configuration to 0 (0x00000000) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L31 · SET-VALUE · `LPMDSTATE`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\services\iaStor\Parameters\Port2`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „LPMDSTATE” în configurația serviciilor sau driverelor la 0 (0x00000000) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “LPMDSTATE” option in service or driver configuration to 0 (0x00000000) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L32 · SET-VALUE · `DIPM`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\services\iaStor\Parameters\Port2`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „DIPM” în configurația serviciilor sau driverelor la 0 (0x00000000) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “DIPM” option in service or driver configuration to 0 (0x00000000) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L35 · SET-VALUE · `LPM`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\services\iaStor\Parameters\Port3`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „LPM” în configurația serviciilor sau driverelor la 0 (0x00000000) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “LPM” option in service or driver configuration to 0 (0x00000000) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L36 · SET-VALUE · `LPMDSTATE`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\services\iaStor\Parameters\Port3`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „LPMDSTATE” în configurația serviciilor sau driverelor la 0 (0x00000000) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “LPMDSTATE” option in service or driver configuration to 0 (0x00000000) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L37 · SET-VALUE · `DIPM`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\services\iaStor\Parameters\Port3`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „DIPM” în configurația serviciilor sau driverelor la 0 (0x00000000) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “DIPM” option in service or driver configuration to 0 (0x00000000) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L40 · SET-VALUE · `LPM`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\services\iaStor\Parameters\Port4`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „LPM” în configurația serviciilor sau driverelor la 0 (0x00000000) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “LPM” option in service or driver configuration to 0 (0x00000000) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L41 · SET-VALUE · `LPMDSTATE`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\services\iaStor\Parameters\Port4`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „LPMDSTATE” în configurația serviciilor sau driverelor la 0 (0x00000000) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “LPMDSTATE” option in service or driver configuration to 0 (0x00000000) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L42 · SET-VALUE · `DIPM`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\services\iaStor\Parameters\Port4`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „DIPM” în configurația serviciilor sau driverelor la 0 (0x00000000) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “DIPM” option in service or driver configuration to 0 (0x00000000) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L45 · SET-VALUE · `LPM`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\services\iaStor\Parameters\Port5`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „LPM” în configurația serviciilor sau driverelor la 0 (0x00000000) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “LPM” option in service or driver configuration to 0 (0x00000000) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L46 · SET-VALUE · `LPMDSTATE`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\services\iaStor\Parameters\Port5`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „LPMDSTATE” în configurația serviciilor sau driverelor la 0 (0x00000000) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “LPMDSTATE” option in service or driver configuration to 0 (0x00000000) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L47 · SET-VALUE · `DIPM`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\services\iaStor\Parameters\Port5`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „DIPM” în configurația serviciilor sau driverelor la 0 (0x00000000) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “DIPM” option in service or driver configuration to 0 (0x00000000) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L50 · SET-VALUE · `SwapfileControl`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Swapfile Control” în ramura CurrentControlSet / Control / Session Manager la 0 (0x00000000) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “Swapfile Control” option in registry branch CurrentControlSet / Control / Session Manager to 0 (0x00000000) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Undocumented/low-level latency or kernel tuning lacks a stable supported Windows contract; retired.
- **OS support / versiuni:** `7600+`

## Referințe / References

- Raw Registry execution is retired because no supportable cross-version contract was established for the recipe.
