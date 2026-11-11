# Kernel/tick duration.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `ac215577b09e91150b0138c26f1420f81ccb8c23e9730eaa319e16f1453aa84e`
- **Recipe verdict / verdict rețetă:** `RETIRED`
- **Windows container / interval Windows:** `7600+`
- **Runtime prerequisite / condiție runtime:** `existing-key`
- **Value/operation descriptions / operații:** 5
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L4 · SET-VALUE · `DebugPollInterval`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Session Manager\kernel`
- **Raw .reg data:** `dword:000003e8`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Debug Poll Interval” în ramura ControlSet001 / Control / Session Manager la 1000 (0x000003E8) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “Debug Poll Interval” option in registry branch ControlSet001 / Control / Session Manager to 1000 (0x000003E8) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Undocumented/low-level latency or kernel tuning lacks a stable supported Windows contract; retired.
- **OS support / versiuni:** `7600+`

### L5 · SET-VALUE · `MaxDynamicTickDuration`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Session Manager\kernel`
- **Raw .reg data:** `dword:000003e8`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Max Dynamic Tick Duration” în ramura ControlSet001 / Control / Session Manager la 1000 (0x000003E8) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “Max Dynamic Tick Duration” option in registry branch ControlSet001 / Control / Session Manager to 1000 (0x000003E8) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Undocumented/low-level latency or kernel tuning lacks a stable supported Windows contract; retired.
- **OS support / versiuni:** `7600+`

### L6 · SET-VALUE · `SerializeTimerExpiration`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Session Manager\kernel`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Serialize Timer Expiration” în ramura ControlSet001 / Control / Session Manager la 1 (0x00000001) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “Serialize Timer Expiration” option in registry branch ControlSet001 / Control / Session Manager to 1 (0x00000001) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Undocumented/low-level latency or kernel tuning lacks a stable supported Windows contract; retired.
- **OS support / versiuni:** `7600+`

### L9 · SET-VALUE · `EnableNoGatewayLocationDetection`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\services\NlaSvc\Parameters\Internet`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Enable No Gateway Location Detection” în configurația serviciilor sau driverelor la 1 (0x00000001) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “Enable No Gateway Location Detection” option in service or driver configuration to 1 (0x00000001) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Undocumented/low-level latency or kernel tuning lacks a stable supported Windows contract; retired.
- **OS support / versiuni:** `7600+`

### L10 · SET-VALUE · `CorpLocationProbeTimeout`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\services\NlaSvc\Parameters\Internet`
- **Raw .reg data:** `dword:0000001E`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Corp Location Probe Timeout” în configurația serviciilor sau driverelor la 30 (0x0000001E) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “Corp Location Probe Timeout” option in service or driver configuration to 30 (0x0000001E) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Undocumented/low-level latency or kernel tuning lacks a stable supported Windows contract; retired.
- **OS support / versiuni:** `7600+`

## Referințe / References

- Raw Registry execution is retired because no supportable cross-version contract was established for the recipe.
