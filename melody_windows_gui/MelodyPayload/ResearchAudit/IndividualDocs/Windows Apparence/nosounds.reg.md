# Windows Apparence/nosounds.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `8219e6309bb2ba6a3b124303ef383db2d94223699ae5053839c3e06dede1ff86`
- **Recipe verdict / verdict rețetă:** `CONDITIONAL`
- **Windows container / interval Windows:** `7600+`
- **Runtime prerequisite / condiție runtime:** `existing-key`
- **Value/operation descriptions / operații:** 3
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L9 · SET-VALUE · `(Default)`

- **Registry key:** `HKEY_CURRENT_USER\AppEvents\Schemes`
- **Raw .reg data:** `".None"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează valoarea implicită în ramura AppEvents / Schemes la .None (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets default value in registry branch AppEvents / Schemes to .None (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Legacy Windows setting; only existing keys/values are changed on the detected system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/sysinfo/registry`

### L10 · SET-VALUE · `packagebase`

- **Registry key:** `HKEY_CURRENT_USER\AppEvents\Schemes`
- **Raw .reg data:** `"C:\\Windows\\media"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „packagebase” în ramura AppEvents / Schemes la C:\Windows\media (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “packagebase” option in registry branch AppEvents / Schemes to C:\Windows\media (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Legacy Windows setting; only existing keys/values are changed on the detected system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/sysinfo/registry`

### L15 · SET-VALUE · `(Default)`

- **Registry key:** `HKEY_CURRENT_USER\AppEvents\Schemes\Names\.None`
- **Raw .reg data:** `"No Sounds"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează valoarea implicită în ramura Schemes / Names / .None la No Sounds (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets default value in registry branch Schemes / Names / .None to No Sounds (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Legacy Windows setting; only existing keys/values are changed on the detected system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/sysinfo/registry`

## Referințe / References

- https://learn.microsoft.com/en-us/windows/win32/sysinfo/registry
