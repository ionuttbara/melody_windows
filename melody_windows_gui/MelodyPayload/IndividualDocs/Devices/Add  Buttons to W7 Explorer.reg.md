# Devices/Add  Buttons to W7 Explorer.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `f5df3dbe1e4c3547562f1bc51efb768ecd88ab0d6766140aea50d7e1e423c11a`
- **Recipe verdict / verdict rețetă:** `CONDITIONAL`
- **Windows container / interval Windows:** `7600+`
- **Runtime prerequisite / condiție runtime:** `existing-key`
- **Value/operation descriptions / operații:** 2
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L4 · SET-VALUE · `(Default)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\FolderTypes\{5c4f28b5-f869-4e84-8e60-f11db97c5cc7}\TasksItemsSelected`
- **Raw .reg data:** `"Windows.Cut;Windows.Copy;Windows.Delete;Windows.copyaspath;Windows.ShowHiddenFiles"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează valoarea implicită în Explorer și interfața shell la Windows.Cut;Windows.Copy;Windows.Delete;Windows.copyaspath;Windows.ShowHiddenFiles (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets default value in File Explorer and Windows shell to Windows.Cut;Windows.Copy;Windows.Delete;Windows.copyaspath;Windows.ShowHiddenFiles (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L7 · SET-VALUE · `(Default)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\FolderTypes\{5c4f28b5-f869-4e84-8e60-f11db97c5cc7}\TasksNoItemsSelected`
- **Raw .reg data:** `"Windows.Paste;Windows.Undo;Windows.Redo;Windows.ShowHiddenFiles"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează valoarea implicită în Explorer și interfața shell la Windows.Paste;Windows.Undo;Windows.Redo;Windows.ShowHiddenFiles (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets default value in File Explorer and Windows shell to Windows.Paste;Windows.Undo;Windows.Redo;Windows.ShowHiddenFiles (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

## Referințe / References

- No exact vendor URL is attached. The final runtime rule requires the exact live Registry target to exist before Melody enables the recipe.
