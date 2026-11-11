# Software/Disable Windows Disk Quota.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `fd7c99b819e63bd633c22a2b2a2acabea6557b2da2b424f1ceef10f2ca066aca`
- **Recipe verdict / verdict rețetă:** `CONDITIONAL`
- **Windows container / interval Windows:** `7600+`
- **Runtime prerequisite / condiție runtime:** `existing-key`
- **Value/operation descriptions / operații:** 4
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L4 · SET-VALUE · `Enforce`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows NT\DiskQuota`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Enforce” în politicile componentelor Windows NT la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Enforce” option in Windows NT component policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Application/vendor policy; applied only when its exact target already exists or the component prerequisite is met.
- **OS support / versiuni:** `7600+`

### L5 · SET-VALUE · `Enable`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows NT\DiskQuota`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Enable” în politicile componentelor Windows NT la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Enable” option in Windows NT component policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Application/vendor policy; applied only when its exact target already exists or the component prerequisite is met.
- **OS support / versiuni:** `7600+`

### L6 · SET-VALUE · `LogEventOverLimit`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows NT\DiskQuota`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Log Event Over Limit” în politicile componentelor Windows NT la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Log Event Over Limit” option in Windows NT component policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Application/vendor policy; applied only when its exact target already exists or the component prerequisite is met.
- **OS support / versiuni:** `7600+`

### L7 · SET-VALUE · `LogEventOverThreshold`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows NT\DiskQuota`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Log Event Over Threshold” în politicile componentelor Windows NT la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Log Event Over Threshold” option in Windows NT component policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Application/vendor policy; applied only when its exact target already exists or the component prerequisite is met.
- **OS support / versiuni:** `7600+`

## Referințe / References

- No exact vendor URL is attached. The final runtime rule requires the exact live Registry target to exist before Melody enables the recipe.
