# System/Disable OS Disk Usage.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `9fbb976ed9f607e7061cb4f086eb244e7deba78137c9bbe8971236cef5c99bcc`
- **Recipe verdict / verdict rețetă:** `RETIRED`
- **Windows container / interval Windows:** `7600+`
- **Runtime prerequisite / condiție runtime:** `existing-key`
- **Value/operation descriptions / operații:** 5
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L4 · SET-VALUE · `PagingFiles`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Session Manager\Memory Management`
- **Raw .reg data:** `hex(7):43,00,3a,00,5c,00,70,00,61,00,67,00,65,00,66,00,69,00,6c,00,65,00,2e,00,73,00,79,00,73,00,20,00,34,00,30,00,39,00,36,00,20,00,38,00,31,00,39,00,32,00,00,00,00,00`
- **Type / tip:** `REG_MULTI_SZ`
- **Ce face / RO:** Configurează opțiunea „Paging Files” în ramura ControlSet001 / Control / Session Manager la date hexazecimale; de verificat lista de șiruri / hex data, verify string list (REG_MULTI_SZ). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “Paging Files” option in registry branch ControlSet001 / Control / Session Manager to date hexazecimale; de verificat lista de șiruri / hex data, verify string list (REG_MULTI_SZ). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Undocumented/low-level latency or kernel tuning lacks a stable supported Windows contract; retired.
- **OS support / versiuni:** `7600+`

### L7 · DELETE-VALUE · `SystemPages`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Session Manager\Memory Management`
- **Raw .reg data:** `-`
- **Type / tip:** `VALUE DELETE`
- **Ce face / RO:** Elimină opțiunea „System Pages” din ramura ControlSet001 / Control / Session Manager; NU echivalează automat cu dezactivarea funcției și poate restabili o valoare implicită. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Removes the “System Pages” option from registry branch ControlSet001 / Control / Session Manager; this does NOT necessarily disable the feature and may restore a default behavior. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Undocumented/low-level latency or kernel tuning lacks a stable supported Windows contract; retired.
- **OS support / versiuni:** `7600+`

### L10 · SET-VALUE · `ShippedWithReserves`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\ReserveManager`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Shipped With Reserves” în ramura Microsoft / Windows / CurrentVersion la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Shipped With Reserves” option in registry branch Microsoft / Windows / CurrentVersion to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L11 · SET-VALUE · `PassedPolicy`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\ReserveManager`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Passed Policy” în ramura Microsoft / Windows / CurrentVersion la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Passed Policy” option in registry branch Microsoft / Windows / CurrentVersion to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L14 · SET-VALUE · `DisableSR`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows NT\SystemRestore`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Disable SR” în politicile componentelor Windows NT la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Disable SR” option in Windows NT component policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Application/vendor policy; applied only when its exact target already exists or the component prerequisite is met.
- **OS support / versiuni:** `7600+`

## Referințe / References

- Raw Registry execution is retired because no supportable cross-version contract was established for the recipe.
