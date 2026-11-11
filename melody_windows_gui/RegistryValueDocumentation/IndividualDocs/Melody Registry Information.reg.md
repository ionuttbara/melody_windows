# Melody Registry Information.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `69e92b0e067e3000d52d156922a34d52626c86ffb5d58ad82ce2e71dca35d07b`
- **Recipe verdict / verdict rețetă:** `CONDITIONAL`
- **Windows container / interval Windows:** `7600+`
- **Runtime prerequisite / condiție runtime:** `existing-key`
- **Value/operation descriptions / operații:** 5
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L4 · SET-VALUE · `DisplayName`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall\GalleryInc.Scripting.Melody`
- **Raw .reg data:** `"Melody"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Display Name” în ramura WOW6432Node / Microsoft / Windows la Melody (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Display Name” option in registry branch WOW6432Node / Microsoft / Windows to Melody (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L5 · SET-VALUE · `DisplayVersion`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall\GalleryInc.Scripting.Melody`
- **Raw .reg data:** `"16.0-rcA"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Display Version” în ramura WOW6432Node / Microsoft / Windows la 16.0-rcA (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Display Version” option in registry branch WOW6432Node / Microsoft / Windows to 16.0-rcA (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L6 · SET-VALUE · `Publisher`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall\GalleryInc.Scripting.Melody`
- **Raw .reg data:** `"Gallery Inc"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Publisher” în ramura WOW6432Node / Microsoft / Windows la Gallery Inc (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Publisher” option in registry branch WOW6432Node / Microsoft / Windows to Gallery Inc (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L7 · SET-VALUE · `DisplayIcon`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall\GalleryInc.Scripting.Melody`
- **Raw .reg data:** `"C:\\ProgramData\\Melody\\Icon\\melody.ico"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Display Icon” în ramura WOW6432Node / Microsoft / Windows la C:\ProgramData\Melody\Icon\melody.ico (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Display Icon” option in registry branch WOW6432Node / Microsoft / Windows to C:\ProgramData\Melody\Icon\melody.ico (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L8 · SET-VALUE · `EstimatedSize`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall\GalleryInc.Scripting.Melody`
- **Raw .reg data:** `dword:00000512`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Estimated Size” în ramura WOW6432Node / Microsoft / Windows la 1298 (0x00000512) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Estimated Size” option in registry branch WOW6432Node / Microsoft / Windows to 1298 (0x00000512) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

## Referințe / References

- No exact vendor URL is attached. The final runtime rule requires the exact live Registry target to exist before Melody enables the recipe.
