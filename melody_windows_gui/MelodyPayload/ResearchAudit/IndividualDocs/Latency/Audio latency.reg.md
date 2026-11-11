# Latency/Audio latency.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `55a065158f0b419bd06d9efa8fd0efb519d12e81fdc543fd54857521de84d9ed`
- **Recipe verdict / verdict rețetă:** `RETIRED`
- **Windows container / interval Windows:** `7600+`
- **Runtime prerequisite / condiție runtime:** `existing-key`
- **Value/operation descriptions / operații:** 3
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L6 · SET-VALUE · `AllowHeadlessExecution`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\BackgroundModel\BackgroundAudioPolicy`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Allow Headless Execution” în ramura Microsoft / Windows NT / CurrentVersion la 1 (0x00000001) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “Allow Headless Execution” option in registry branch Microsoft / Windows NT / CurrentVersion to 1 (0x00000001) (REG_DWORD). The raw Registry recipe is retired from execution; this operation remains documented for reference only.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Undocumented/low-level latency or kernel tuning lacks a stable supported Windows contract; retired.
- **OS support / versiuni:** `7600+`

### L7 · SET-VALUE · `AllowMultipleBackgroundTasks`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\BackgroundModel\BackgroundAudioPolicy`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Allow Multiple Background Tasks” în ramura Microsoft / Windows NT / CurrentVersion la 1 (0x00000001) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “Allow Multiple Background Tasks” option in registry branch Microsoft / Windows NT / CurrentVersion to 1 (0x00000001) (REG_DWORD). The raw Registry recipe is retired from execution; this operation remains documented for reference only.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Undocumented/low-level latency or kernel tuning lacks a stable supported Windows contract; retired.
- **OS support / versiuni:** `7600+`

### L8 · SET-VALUE · `InactivityTimeoutMs`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\BackgroundModel\BackgroundAudioPolicy`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Inactivity Timeout Ms” în ramura Microsoft / Windows NT / CurrentVersion la 0 (0x00000000) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “Inactivity Timeout Ms” option in registry branch Microsoft / Windows NT / CurrentVersion to 0 (0x00000000) (REG_DWORD). The raw Registry recipe is retired from execution; this operation remains documented for reference only.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Undocumented/low-level latency or kernel tuning lacks a stable supported Windows contract; retired.
- **OS support / versiuni:** `7600+`

## Referințe / References

- Raw Registry execution is retired because no supportable cross-version contract was established for the recipe.
