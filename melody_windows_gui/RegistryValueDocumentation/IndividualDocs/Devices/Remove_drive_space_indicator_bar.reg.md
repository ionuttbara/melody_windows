# Devices/Remove_drive_space_indicator_bar.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `4ea589c3ed8b6a8d3b724a8c61afd47819940483ca66c3906cabea124dea2924`
- **Recipe verdict / verdict rețetă:** `CONDITIONAL`
- **Windows container / interval Windows:** `7600+`
- **Runtime prerequisite / condiție runtime:** `existing-key`
- **Value/operation descriptions / operații:** 1
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L4 · SET-VALUE · `TileInfo`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Drive`
- **Raw .reg data:** `"prop:*System.Computer.DecoratedFreeSpace;System.Volume.FileSystem"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Tile Info” în asocierile de fișiere și înregistrările shell la prop:*System.Computer.DecoratedFreeSpace;System.Volume.FileSystem (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Tile Info” option in file associations and shell registration to prop:*System.Computer.DecoratedFreeSpace;System.Volume.FileSystem (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

## Referințe / References

- No exact vendor URL is attached. The final runtime rule requires the exact live Registry target to exist before Melody enables the recipe.
