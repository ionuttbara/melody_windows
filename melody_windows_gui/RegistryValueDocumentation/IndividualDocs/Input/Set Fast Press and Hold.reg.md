# Input/Set Fast Press and Hold.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `50fc952cfff7e45c0066269da6fa0beb754074b29f7545dd46a943fc9b435fe3`
- **Recipe verdict / verdict rețetă:** `CONDITIONAL`
- **Windows container / interval Windows:** `7600+`
- **Runtime prerequisite / condiție runtime:** `existing-key`
- **Value/operation descriptions / operații:** 2
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L4 · SET-VALUE · `HoldActivationTime`

- **Registry key:** `HKEY_CURRENT_USER\Control Panel\Pen`
- **Raw .reg data:** `dword:00002000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Hold Activation Time” în ramura Control Panel / Pen la 8192 (0x00002000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Hold Activation Time” option in registry branch Control Panel / Pen to 8192 (0x00002000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L5 · SET-VALUE · `HoldWidth`

- **Registry key:** `HKEY_CURRENT_USER\Control Panel\Pen`
- **Raw .reg data:** `dword:00000008`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Hold Width” în ramura Control Panel / Pen la 8 (0x00000008) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Hold Width” option in registry branch Control Panel / Pen to 8 (0x00000008) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

## Referințe / References

- No exact vendor URL is attached. The final runtime rule requires the exact live Registry target to exist before Melody enables the recipe.
