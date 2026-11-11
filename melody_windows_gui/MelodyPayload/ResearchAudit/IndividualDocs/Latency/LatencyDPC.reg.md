# Latency/LatencyDPC.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `866506c2fa9fc1136c3bdc6b3871b77900fd7cd72e35bd130045e78bd0b1a000`
- **Recipe verdict / verdict rețetă:** `RETIRED`
- **Windows container / interval Windows:** `7600+`
- **Runtime prerequisite / condiție runtime:** `existing-key`
- **Value/operation descriptions / operații:** 4
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L4 · SET-VALUE · `PerfLevelSrc`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Video\{DEB039CC-B704-4F53-B43E-9DD4432FA2E9}\0000`
- **Raw .reg data:** `dword:00003322`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Perf Level Src” în ramura CurrentControlSet / Control / Video la 13090 (0x00003322) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “Perf Level Src” option in registry branch CurrentControlSet / Control / Video to 13090 (0x00003322) (REG_DWORD). The raw Registry recipe is retired from execution; this operation remains documented for reference only.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Undocumented/low-level latency or kernel tuning lacks a stable supported Windows contract; retired.
- **OS support / versiuni:** `7600+`

### L5 · SET-VALUE · `PowerMizerEnable`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Video\{DEB039CC-B704-4F53-B43E-9DD4432FA2E9}\0000`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Power Mizer Enable” în ramura CurrentControlSet / Control / Video la 1 (0x00000001) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “Power Mizer Enable” option in registry branch CurrentControlSet / Control / Video to 1 (0x00000001) (REG_DWORD). The raw Registry recipe is retired from execution; this operation remains documented for reference only.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Undocumented/low-level latency or kernel tuning lacks a stable supported Windows contract; retired.
- **OS support / versiuni:** `7600+`

### L6 · SET-VALUE · `PowermizerLevel`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Video\{DEB039CC-B704-4F53-B43E-9DD4432FA2E9}\0000`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Powermizer Level” în ramura CurrentControlSet / Control / Video la 1 (0x00000001) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “Powermizer Level” option in registry branch CurrentControlSet / Control / Video to 1 (0x00000001) (REG_DWORD). The raw Registry recipe is retired from execution; this operation remains documented for reference only.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Undocumented/low-level latency or kernel tuning lacks a stable supported Windows contract; retired.
- **OS support / versiuni:** `7600+`

### L7 · SET-VALUE · `PowermizerLevelAC`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Video\{DEB039CC-B704-4F53-B43E-9DD4432FA2E9}\0000`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Powermizer Level AC” în ramura CurrentControlSet / Control / Video la 1 (0x00000001) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “Powermizer Level AC” option in registry branch CurrentControlSet / Control / Video to 1 (0x00000001) (REG_DWORD). The raw Registry recipe is retired from execution; this operation remains documented for reference only.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Undocumented/low-level latency or kernel tuning lacks a stable supported Windows contract; retired.
- **OS support / versiuni:** `7600+`

## Referințe / References

- Raw Registry execution is retired because no supportable cross-version contract was established for the recipe.
