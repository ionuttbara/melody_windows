# GPU/AMD GPU Tweaks.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `eaf17bff4ad60e5b76f09722c8290fa84bd65cf7208f554863e103d24d63b9ad`
- **Recipe verdict / verdict rețetă:** `RETIRED`
- **Windows container / interval Windows:** `7600+`
- **Runtime prerequisite / condiție runtime:** `existing-key`
- **Value/operation descriptions / operații:** 76
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L4 · SET-VALUE · `PP_DisableAutoWattman`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\amdkmpfd`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „PP Disable Auto Wattman” în configurația serviciilor sau driverelor la 1 (0x00000001) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “PP Disable Auto Wattman” option in service or driver configuration to 1 (0x00000001) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L5 · SET-VALUE · `PP_Force3DPerformanceMode`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\amdkmpfd`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „PP Force3DPerformance Mode” în configurația serviciilor sau driverelor la 1 (0x00000001) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “PP Force3DPerformance Mode” option in service or driver configuration to 1 (0x00000001) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L6 · SET-VALUE · `PP_ForceHighDPMLevel`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\amdkmpfd`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „PP Force High DPMLevel” în configurația serviciilor sau driverelor la 1 (0x00000001) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “PP Force High DPMLevel” option in service or driver configuration to 1 (0x00000001) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L7 · SET-VALUE · `PP_ForceHighUVDState`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\amdkmpfd`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „PP Force High UVDState” în configurația serviciilor sau driverelor la 1 (0x00000001) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “PP Force High UVDState” option in service or driver configuration to 1 (0x00000001) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L8 · SET-VALUE · `PP_ForceMCLKHigh`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\amdkmpfd`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „PP Force MCLKHigh” în configurația serviciilor sau driverelor la 1 (0x00000001) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “PP Force MCLKHigh” option in service or driver configuration to 1 (0x00000001) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L9 · SET-VALUE · `PP_ForceSCLKHigh`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\amdkmpfd`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „PP Force SCLKHigh” în configurația serviciilor sau driverelor la 1 (0x00000001) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “PP Force SCLKHigh” option in service or driver configuration to 1 (0x00000001) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L10 · SET-VALUE · `DisableAspmL0s`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\amdkmpfd`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Disable Aspm L0s” în configurația serviciilor sau driverelor la 1 (0x00000001) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “Disable Aspm L0s” option in service or driver configuration to 1 (0x00000001) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L11 · SET-VALUE · `DisableAspmL1`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\amdkmpfd`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Disable Aspm L1” în configurația serviciilor sau driverelor la 1 (0x00000001) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “Disable Aspm L1” option in service or driver configuration to 1 (0x00000001) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L12 · SET-VALUE · `EnableAspmL0s`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\amdkmpfd`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Enable Aspm L0s” în configurația serviciilor sau driverelor la 0 (0x00000000) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “Enable Aspm L0s” option in service or driver configuration to 0 (0x00000000) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L13 · SET-VALUE · `EnableAspmL1`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\amdkmpfd`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Enable Aspm L1” în configurația serviciilor sau driverelor la 0 (0x00000000) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “Enable Aspm L1” option in service or driver configuration to 0 (0x00000000) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L14 · SET-VALUE · `KMD_UseBestGPUPowerOption`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\amdkmpfd`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „KMD Use Best GPUPower Option” în configurația serviciilor sau driverelor la 1 (0x00000001) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “KMD Use Best GPUPower Option” option in service or driver configuration to 1 (0x00000001) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L15 · DELETE-VALUE · `KMD_OSControlsGPUPower`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\amdkmpfd`
- **Raw .reg data:** `-`
- **Type / tip:** `VALUE DELETE`
- **Ce face / RO:** Elimină opțiunea „KMD OSControls GPUPower” din configurația serviciilor sau driverelor; NU echivalează automat cu dezactivarea funcției și poate restabili o valoare implicită. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Removes the “KMD OSControls GPUPower” option from service or driver configuration; this does NOT necessarily disable the feature and may restore a default behavior. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L16 · DELETE-VALUE · `KMD_EnableHWCursor`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\amdkmpfd`
- **Raw .reg data:** `-`
- **Type / tip:** `VALUE DELETE`
- **Ce face / RO:** Elimină opțiunea „KMD Enable HWCursor” din configurația serviciilor sau driverelor; NU echivalează automat cu dezactivarea funcției și poate restabili o valoare implicită. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Removes the “KMD Enable HWCursor” option from service or driver configuration; this does NOT necessarily disable the feature and may restore a default behavior. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L19 · SET-VALUE · `PP_DisableAutoWattman`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\amdwddmg`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „PP Disable Auto Wattman” în configurația serviciilor sau driverelor la 1 (0x00000001) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “PP Disable Auto Wattman” option in service or driver configuration to 1 (0x00000001) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L20 · SET-VALUE · `PP_Force3DPerformanceMode`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\amdwddmg`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „PP Force3DPerformance Mode” în configurația serviciilor sau driverelor la 1 (0x00000001) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “PP Force3DPerformance Mode” option in service or driver configuration to 1 (0x00000001) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L21 · SET-VALUE · `PP_ForceHighDPMLevel`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\amdwddmg`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „PP Force High DPMLevel” în configurația serviciilor sau driverelor la 1 (0x00000001) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “PP Force High DPMLevel” option in service or driver configuration to 1 (0x00000001) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L22 · SET-VALUE · `PP_ForceHighUVDState`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\amdwddmg`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „PP Force High UVDState” în configurația serviciilor sau driverelor la 1 (0x00000001) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “PP Force High UVDState” option in service or driver configuration to 1 (0x00000001) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L23 · SET-VALUE · `PP_ForceMCLKHigh`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\amdwddmg`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „PP Force MCLKHigh” în configurația serviciilor sau driverelor la 1 (0x00000001) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “PP Force MCLKHigh” option in service or driver configuration to 1 (0x00000001) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L24 · SET-VALUE · `PP_ForceSCLKHigh`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\amdwddmg`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „PP Force SCLKHigh” în configurația serviciilor sau driverelor la 1 (0x00000001) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “PP Force SCLKHigh” option in service or driver configuration to 1 (0x00000001) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L25 · SET-VALUE · `DisableAspmL0s`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\amdwddmg`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Disable Aspm L0s” în configurația serviciilor sau driverelor la 1 (0x00000001) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “Disable Aspm L0s” option in service or driver configuration to 1 (0x00000001) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L26 · SET-VALUE · `DisableAspmL1`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\amdwddmg`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Disable Aspm L1” în configurația serviciilor sau driverelor la 1 (0x00000001) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “Disable Aspm L1” option in service or driver configuration to 1 (0x00000001) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L27 · SET-VALUE · `EnableAspmL0s`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\amdwddmg`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Enable Aspm L0s” în configurația serviciilor sau driverelor la 0 (0x00000000) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “Enable Aspm L0s” option in service or driver configuration to 0 (0x00000000) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L28 · SET-VALUE · `EnableAspmL1`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\amdwddmg`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Enable Aspm L1” în configurația serviciilor sau driverelor la 0 (0x00000000) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “Enable Aspm L1” option in service or driver configuration to 0 (0x00000000) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L29 · SET-VALUE · `KMD_UseBestGPUPowerOption`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\amdwddmg`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „KMD Use Best GPUPower Option” în configurația serviciilor sau driverelor la 1 (0x00000001) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “KMD Use Best GPUPower Option” option in service or driver configuration to 1 (0x00000001) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L30 · DELETE-VALUE · `KMD_OSControlsGPUPower`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\amdwddmg`
- **Raw .reg data:** `-`
- **Type / tip:** `VALUE DELETE`
- **Ce face / RO:** Elimină opțiunea „KMD OSControls GPUPower” din configurația serviciilor sau driverelor; NU echivalează automat cu dezactivarea funcției și poate restabili o valoare implicită. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Removes the “KMD OSControls GPUPower” option from service or driver configuration; this does NOT necessarily disable the feature and may restore a default behavior. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L31 · DELETE-VALUE · `KMD_EnableHWCursor`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\amdwddmg`
- **Raw .reg data:** `-`
- **Type / tip:** `VALUE DELETE`
- **Ce face / RO:** Elimină opțiunea „KMD Enable HWCursor” din configurația serviciilor sau driverelor; NU echivalează automat cu dezactivarea funcției și poate restabili o valoare implicită. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Removes the “KMD Enable HWCursor” option from service or driver configuration; this does NOT necessarily disable the feature and may restore a default behavior. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L33 · SET-VALUE · `PP_DisableAutoWattman`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\amdgpuv`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „PP Disable Auto Wattman” în configurația serviciilor sau driverelor la 1 (0x00000001) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “PP Disable Auto Wattman” option in service or driver configuration to 1 (0x00000001) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L34 · SET-VALUE · `PP_Force3DPerformanceMode`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\amdgpuv`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „PP Force3DPerformance Mode” în configurația serviciilor sau driverelor la 1 (0x00000001) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “PP Force3DPerformance Mode” option in service or driver configuration to 1 (0x00000001) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L35 · SET-VALUE · `PP_ForceHighDPMLevel`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\amdgpuv`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „PP Force High DPMLevel” în configurația serviciilor sau driverelor la 1 (0x00000001) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “PP Force High DPMLevel” option in service or driver configuration to 1 (0x00000001) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L36 · SET-VALUE · `PP_ForceHighUVDState`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\amdgpuv`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „PP Force High UVDState” în configurația serviciilor sau driverelor la 1 (0x00000001) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “PP Force High UVDState” option in service or driver configuration to 1 (0x00000001) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L37 · SET-VALUE · `PP_ForceMCLKHigh`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\amdgpuv`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „PP Force MCLKHigh” în configurația serviciilor sau driverelor la 1 (0x00000001) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “PP Force MCLKHigh” option in service or driver configuration to 1 (0x00000001) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L38 · SET-VALUE · `PP_ForceSCLKHigh`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\amdgpuv`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „PP Force SCLKHigh” în configurația serviciilor sau driverelor la 1 (0x00000001) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “PP Force SCLKHigh” option in service or driver configuration to 1 (0x00000001) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L39 · SET-VALUE · `DisableAspmL0s`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\amdgpuv`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Disable Aspm L0s” în configurația serviciilor sau driverelor la 1 (0x00000001) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “Disable Aspm L0s” option in service or driver configuration to 1 (0x00000001) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L40 · SET-VALUE · `DisableAspmL1`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\amdgpuv`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Disable Aspm L1” în configurația serviciilor sau driverelor la 1 (0x00000001) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “Disable Aspm L1” option in service or driver configuration to 1 (0x00000001) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L41 · SET-VALUE · `EnableAspmL0s`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\amdgpuv`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Enable Aspm L0s” în configurația serviciilor sau driverelor la 0 (0x00000000) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “Enable Aspm L0s” option in service or driver configuration to 0 (0x00000000) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L42 · SET-VALUE · `EnableAspmL1`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\amdgpuv`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Enable Aspm L1” în configurația serviciilor sau driverelor la 0 (0x00000000) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “Enable Aspm L1” option in service or driver configuration to 0 (0x00000000) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L43 · SET-VALUE · `KMD_UseBestGPUPowerOption`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\amdgpuv`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „KMD Use Best GPUPower Option” în configurația serviciilor sau driverelor la 1 (0x00000001) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “KMD Use Best GPUPower Option” option in service or driver configuration to 1 (0x00000001) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L44 · DELETE-VALUE · `KMD_OSControlsGPUPower`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\amdgpuv`
- **Raw .reg data:** `-`
- **Type / tip:** `VALUE DELETE`
- **Ce face / RO:** Elimină opțiunea „KMD OSControls GPUPower” din configurația serviciilor sau driverelor; NU echivalează automat cu dezactivarea funcției și poate restabili o valoare implicită. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Removes the “KMD OSControls GPUPower” option from service or driver configuration; this does NOT necessarily disable the feature and may restore a default behavior. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L45 · DELETE-VALUE · `KMD_EnableHWCursor`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\amdgpuv`
- **Raw .reg data:** `-`
- **Type / tip:** `VALUE DELETE`
- **Ce face / RO:** Elimină opțiunea „KMD Enable HWCursor” din configurația serviciilor sau driverelor; NU echivalează automat cu dezactivarea funcției și poate restabili o valoare implicită. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Removes the “KMD Enable HWCursor” option from service or driver configuration; this does NOT necessarily disable the feature and may restore a default behavior. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L48 · SET-VALUE · `PP_DisableAutoWattman`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\atikmdag`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „PP Disable Auto Wattman” în configurația serviciilor sau driverelor la 1 (0x00000001) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “PP Disable Auto Wattman” option in service or driver configuration to 1 (0x00000001) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L49 · SET-VALUE · `PP_Force3DPerformanceMode`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\atikmdag`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „PP Force3DPerformance Mode” în configurația serviciilor sau driverelor la 1 (0x00000001) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “PP Force3DPerformance Mode” option in service or driver configuration to 1 (0x00000001) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L50 · SET-VALUE · `PP_ForceHighDPMLevel`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\atikmdag`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „PP Force High DPMLevel” în configurația serviciilor sau driverelor la 1 (0x00000001) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “PP Force High DPMLevel” option in service or driver configuration to 1 (0x00000001) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L51 · SET-VALUE · `PP_ForceHighUVDState`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\atikmdag`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „PP Force High UVDState” în configurația serviciilor sau driverelor la 1 (0x00000001) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “PP Force High UVDState” option in service or driver configuration to 1 (0x00000001) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L52 · SET-VALUE · `PP_ForceMCLKHigh`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\atikmdag`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „PP Force MCLKHigh” în configurația serviciilor sau driverelor la 1 (0x00000001) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “PP Force MCLKHigh” option in service or driver configuration to 1 (0x00000001) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L53 · SET-VALUE · `PP_ForceSCLKHigh`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\atikmdag`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „PP Force SCLKHigh” în configurația serviciilor sau driverelor la 1 (0x00000001) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “PP Force SCLKHigh” option in service or driver configuration to 1 (0x00000001) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L54 · SET-VALUE · `DisableAspmL0s`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\atikmdag`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Disable Aspm L0s” în configurația serviciilor sau driverelor la 1 (0x00000001) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “Disable Aspm L0s” option in service or driver configuration to 1 (0x00000001) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L55 · SET-VALUE · `DisableAspmL1`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\atikmdag`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Disable Aspm L1” în configurația serviciilor sau driverelor la 1 (0x00000001) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “Disable Aspm L1” option in service or driver configuration to 1 (0x00000001) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L56 · SET-VALUE · `EnableAspmL0s`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\atikmdag`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Enable Aspm L0s” în configurația serviciilor sau driverelor la 0 (0x00000000) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “Enable Aspm L0s” option in service or driver configuration to 0 (0x00000000) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L57 · SET-VALUE · `EnableAspmL1`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\atikmdag`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Enable Aspm L1” în configurația serviciilor sau driverelor la 0 (0x00000000) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “Enable Aspm L1” option in service or driver configuration to 0 (0x00000000) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L58 · SET-VALUE · `KMD_UseBestGPUPowerOption`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\atikmdag`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „KMD Use Best GPUPower Option” în configurația serviciilor sau driverelor la 1 (0x00000001) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “KMD Use Best GPUPower Option” option in service or driver configuration to 1 (0x00000001) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L59 · DELETE-VALUE · `KMD_OSControlsGPUPower`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\atikmdag`
- **Raw .reg data:** `-`
- **Type / tip:** `VALUE DELETE`
- **Ce face / RO:** Elimină opțiunea „KMD OSControls GPUPower” din configurația serviciilor sau driverelor; NU echivalează automat cu dezactivarea funcției și poate restabili o valoare implicită. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Removes the “KMD OSControls GPUPower” option from service or driver configuration; this does NOT necessarily disable the feature and may restore a default behavior. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L60 · DELETE-VALUE · `KMD_EnableHWCursor`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\atikmdag`
- **Raw .reg data:** `-`
- **Type / tip:** `VALUE DELETE`
- **Ce face / RO:** Elimină opțiunea „KMD Enable HWCursor” din configurația serviciilor sau driverelor; NU echivalează automat cu dezactivarea funcției și poate restabili o valoare implicită. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Removes the “KMD Enable HWCursor” option from service or driver configuration; this does NOT necessarily disable the feature and may restore a default behavior. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L63 · DELETE-VALUE · `KMD_OSControlsGPUPower`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class{4d36e968-e325-11ce-bfc1-08002be10318}\0000`
- **Raw .reg data:** `-`
- **Type / tip:** `VALUE DELETE`
- **Ce face / RO:** Elimină opțiunea „KMD OSControls GPUPower” din configurația claselor de dispozitive; NU echivalează automat cu dezactivarea funcției și poate restabili o valoare implicită. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Removes the “KMD OSControls GPUPower” option from device-class configuration; this does NOT necessarily disable the feature and may restore a default behavior. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L64 · DELETE-VALUE · `KMD_EnableHWCursor`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class{4d36e968-e325-11ce-bfc1-08002be10318}\0000`
- **Raw .reg data:** `-`
- **Type / tip:** `VALUE DELETE`
- **Ce face / RO:** Elimină opțiunea „KMD Enable HWCursor” din configurația claselor de dispozitive; NU echivalează automat cu dezactivarea funcției și poate restabili o valoare implicită. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Removes the “KMD Enable HWCursor” option from device-class configuration; this does NOT necessarily disable the feature and may restore a default behavior. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L65 · SET-VALUE · `KMD_EnableHsa`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class{4d36e968-e325-11ce-bfc1-08002be10318}\0000`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „KMD Enable Hsa” în configurația claselor de dispozitive la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “KMD Enable Hsa” option in device-class configuration to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L66 · SET-VALUE · `KMD_EnableHsaHws`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class{4d36e968-e325-11ce-bfc1-08002be10318}\0000`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „KMD Enable Hsa Hws” în configurația claselor de dispozitive la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “KMD Enable Hsa Hws” option in device-class configuration to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L67 · DELETE-VALUE · `KMD_EnableHsaSignal`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class{4d36e968-e325-11ce-bfc1-08002be10318}\0000`
- **Raw .reg data:** `-`
- **Type / tip:** `VALUE DELETE`
- **Ce face / RO:** Elimină opțiunea „KMD Enable Hsa Signal” din configurația claselor de dispozitive; NU echivalează automat cu dezactivarea funcției și poate restabili o valoare implicită. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Removes the “KMD Enable Hsa Signal” option from device-class configuration; this does NOT necessarily disable the feature and may restore a default behavior. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L70 · DELETE-VALUE · `KMD_OSControlsGPUPower`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class{4d36e968-e325-11ce-bfc1-08002be10318}\0001`
- **Raw .reg data:** `-`
- **Type / tip:** `VALUE DELETE`
- **Ce face / RO:** Elimină opțiunea „KMD OSControls GPUPower” din configurația claselor de dispozitive; NU echivalează automat cu dezactivarea funcției și poate restabili o valoare implicită. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Removes the “KMD OSControls GPUPower” option from device-class configuration; this does NOT necessarily disable the feature and may restore a default behavior. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L71 · DELETE-VALUE · `KMD_EnableHWCursor`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class{4d36e968-e325-11ce-bfc1-08002be10318}\0001`
- **Raw .reg data:** `-`
- **Type / tip:** `VALUE DELETE`
- **Ce face / RO:** Elimină opțiunea „KMD Enable HWCursor” din configurația claselor de dispozitive; NU echivalează automat cu dezactivarea funcției și poate restabili o valoare implicită. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Removes the “KMD Enable HWCursor” option from device-class configuration; this does NOT necessarily disable the feature and may restore a default behavior. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L72 · SET-VALUE · `KMD_EnableHsa`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class{4d36e968-e325-11ce-bfc1-08002be10318}\0001`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „KMD Enable Hsa” în configurația claselor de dispozitive la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “KMD Enable Hsa” option in device-class configuration to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L73 · SET-VALUE · `KMD_EnableHsaHws`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class{4d36e968-e325-11ce-bfc1-08002be10318}\0001`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „KMD Enable Hsa Hws” în configurația claselor de dispozitive la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “KMD Enable Hsa Hws” option in device-class configuration to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L74 · DELETE-VALUE · `KMD_EnableHsaSignal`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class{4d36e968-e325-11ce-bfc1-08002be10318}\0001`
- **Raw .reg data:** `-`
- **Type / tip:** `VALUE DELETE`
- **Ce face / RO:** Elimină opțiunea „KMD Enable Hsa Signal” din configurația claselor de dispozitive; NU echivalează automat cu dezactivarea funcției și poate restabili o valoare implicită. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Removes the “KMD Enable Hsa Signal” option from device-class configuration; this does NOT necessarily disable the feature and may restore a default behavior. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L77 · DELETE-VALUE · `KMD_OSControlsGPUPower`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class{4d36e968-e325-11ce-bfc1-08002be10318}\0002`
- **Raw .reg data:** `-`
- **Type / tip:** `VALUE DELETE`
- **Ce face / RO:** Elimină opțiunea „KMD OSControls GPUPower” din configurația claselor de dispozitive; NU echivalează automat cu dezactivarea funcției și poate restabili o valoare implicită. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Removes the “KMD OSControls GPUPower” option from device-class configuration; this does NOT necessarily disable the feature and may restore a default behavior. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L78 · DELETE-VALUE · `KMD_EnableHWCursor`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class{4d36e968-e325-11ce-bfc1-08002be10318}\0002`
- **Raw .reg data:** `-`
- **Type / tip:** `VALUE DELETE`
- **Ce face / RO:** Elimină opțiunea „KMD Enable HWCursor” din configurația claselor de dispozitive; NU echivalează automat cu dezactivarea funcției și poate restabili o valoare implicită. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Removes the “KMD Enable HWCursor” option from device-class configuration; this does NOT necessarily disable the feature and may restore a default behavior. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L79 · SET-VALUE · `KMD_EnableHsa`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class{4d36e968-e325-11ce-bfc1-08002be10318}\0002`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „KMD Enable Hsa” în configurația claselor de dispozitive la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “KMD Enable Hsa” option in device-class configuration to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L80 · SET-VALUE · `KMD_EnableHsaHws`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class{4d36e968-e325-11ce-bfc1-08002be10318}\0002`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „KMD Enable Hsa Hws” în configurația claselor de dispozitive la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “KMD Enable Hsa Hws” option in device-class configuration to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L81 · DELETE-VALUE · `KMD_EnableHsaSignal`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class{4d36e968-e325-11ce-bfc1-08002be10318}\0002`
- **Raw .reg data:** `-`
- **Type / tip:** `VALUE DELETE`
- **Ce face / RO:** Elimină opțiunea „KMD Enable Hsa Signal” din configurația claselor de dispozitive; NU echivalează automat cu dezactivarea funcției și poate restabili o valoare implicită. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Removes the “KMD Enable Hsa Signal” option from device-class configuration; this does NOT necessarily disable the feature and may restore a default behavior. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L84 · DELETE-VALUE · `KMD_OSControlsGPUPower`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class{4d36e968-e325-11ce-bfc1-08002be10318}\0003`
- **Raw .reg data:** `-`
- **Type / tip:** `VALUE DELETE`
- **Ce face / RO:** Elimină opțiunea „KMD OSControls GPUPower” din configurația claselor de dispozitive; NU echivalează automat cu dezactivarea funcției și poate restabili o valoare implicită. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Removes the “KMD OSControls GPUPower” option from device-class configuration; this does NOT necessarily disable the feature and may restore a default behavior. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L85 · DELETE-VALUE · `KMD_EnableHWCursor`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class{4d36e968-e325-11ce-bfc1-08002be10318}\0003`
- **Raw .reg data:** `-`
- **Type / tip:** `VALUE DELETE`
- **Ce face / RO:** Elimină opțiunea „KMD Enable HWCursor” din configurația claselor de dispozitive; NU echivalează automat cu dezactivarea funcției și poate restabili o valoare implicită. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Removes the “KMD Enable HWCursor” option from device-class configuration; this does NOT necessarily disable the feature and may restore a default behavior. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L86 · SET-VALUE · `KMD_EnableHsa`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class{4d36e968-e325-11ce-bfc1-08002be10318}\0003`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „KMD Enable Hsa” în configurația claselor de dispozitive la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “KMD Enable Hsa” option in device-class configuration to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L87 · SET-VALUE · `KMD_EnableHsaHws`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class{4d36e968-e325-11ce-bfc1-08002be10318}\0003`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „KMD Enable Hsa Hws” în configurația claselor de dispozitive la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “KMD Enable Hsa Hws” option in device-class configuration to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L88 · DELETE-VALUE · `KMD_EnableHsaSignal`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class{4d36e968-e325-11ce-bfc1-08002be10318}\0003`
- **Raw .reg data:** `-`
- **Type / tip:** `VALUE DELETE`
- **Ce face / RO:** Elimină opțiunea „KMD Enable Hsa Signal” din configurația claselor de dispozitive; NU echivalează automat cu dezactivarea funcției și poate restabili o valoare implicită. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Removes the “KMD Enable Hsa Signal” option from device-class configuration; this does NOT necessarily disable the feature and may restore a default behavior. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L91 · DELETE-VALUE · `KMD_OSControlsGPUPower`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\amdkmdag`
- **Raw .reg data:** `-`
- **Type / tip:** `VALUE DELETE`
- **Ce face / RO:** Elimină opțiunea „KMD OSControls GPUPower” din configurația serviciilor sau driverelor; NU echivalează automat cu dezactivarea funcției și poate restabili o valoare implicită. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Removes the “KMD OSControls GPUPower” option from service or driver configuration; this does NOT necessarily disable the feature and may restore a default behavior. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L92 · DELETE-VALUE · `KMD_EnableHWCursor`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\amdkmdag`
- **Raw .reg data:** `-`
- **Type / tip:** `VALUE DELETE`
- **Ce face / RO:** Elimină opțiunea „KMD Enable HWCursor” din configurația serviciilor sau driverelor; NU echivalează automat cu dezactivarea funcției și poate restabili o valoare implicită. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Removes the “KMD Enable HWCursor” option from service or driver configuration; this does NOT necessarily disable the feature and may restore a default behavior. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L95 · DELETE-VALUE · `KMD_OSControlsGPUPower`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\amdkmdap`
- **Raw .reg data:** `-`
- **Type / tip:** `VALUE DELETE`
- **Ce face / RO:** Elimină opțiunea „KMD OSControls GPUPower” din configurația serviciilor sau driverelor; NU echivalează automat cu dezactivarea funcției și poate restabili o valoare implicită. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Removes the “KMD OSControls GPUPower” option from service or driver configuration; this does NOT necessarily disable the feature and may restore a default behavior. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

### L96 · DELETE-VALUE · `KMD_EnableHWCursor`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\amdkmdap`
- **Raw .reg data:** `-`
- **Type / tip:** `VALUE DELETE`
- **Ce face / RO:** Elimină opțiunea „KMD Enable HWCursor” din configurația serviciilor sau driverelor; NU echivalează automat cu dezactivarea funcției și poate restabili o valoare implicită. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Removes the “KMD Enable HWCursor” option from service or driver configuration; this does NOT necessarily disable the feature and may restore a default behavior. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Driver-private value has no stable cross-driver Windows contract; retired instead of pretending a minimum build.
- **OS support / versiuni:** `7600+`

## Referințe / References

- Raw Registry execution is retired because no supportable cross-version contract was established for the recipe.
