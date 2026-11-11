# Windows Apparence/Disable_JPEG_Desktop_wallpaper_import_quality.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `4e28307cb8d253cc0dc7513338e4c0aec149e097c1bc6c316b41f6452b199265`
- **Recipe verdict / verdict rețetă:** `CONDITIONAL`
- **Windows container / interval Windows:** `7600+`
- **Runtime prerequisite / condiție runtime:** `existing-key`
- **Value/operation descriptions / operații:** 1
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L9 · SET-VALUE · `JPEGImportQuality`

- **Registry key:** `HKEY_CURRENT_USER\Control Panel\Desktop`
- **Raw .reg data:** `dword:00000064`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „JPEGImport Quality” în opțiunile desktopului la 100 (0x00000064) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “JPEGImport Quality” option in desktop settings to 100 (0x00000064) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

## Referințe / References

- No exact vendor URL is attached. The final runtime rule requires the exact live Registry target to exist before Melody enables the recipe.
