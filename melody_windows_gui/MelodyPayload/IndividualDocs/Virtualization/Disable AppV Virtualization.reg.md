# Virtualization/Disable AppV Virtualization.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `47355e8bcf71fe3aa6e684825fde46f2180a9123a08e293cca1801122e3ca3ce`
- **Recipe verdict / verdict rețetă:** `CONDITIONAL`
- **Windows container / interval Windows:** `7600+`
- **Runtime prerequisite / condiție runtime:** `existing-key`
- **Value/operation descriptions / operații:** 2
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L4 · SET-VALUE · `EnableDynamicVirtualization`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\AppV\Client\Virtualization`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Enable Dynamic Virtualization” în ramura Policies / Microsoft / AppV la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Enable Dynamic Virtualization” option in registry branch Policies / Microsoft / AppV to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Application/vendor policy; applied only when its exact target already exists or the component prerequisite is met.
- **OS support / versiuni:** `7600+`

### L5 · SET-VALUE · `ProcessesUsingVirtualComponents`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\AppV\Client\Virtualization`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Processes Using Virtual Components” în ramura Policies / Microsoft / AppV la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Processes Using Virtual Components” option in registry branch Policies / Microsoft / AppV to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Application/vendor policy; applied only when its exact target already exists or the component prerequisite is met.
- **OS support / versiuni:** `7600+`

## Referințe / References

- No exact vendor URL is attached. The final runtime rule requires the exact live Registry target to exist before Melody enables the recipe.
