# Devices/enable more details in details pane.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `ffd681835802f1b37fabdc628abc5a45f113be717b3c8905de78645cdaca3862`
- **Recipe verdict / verdict rețetă:** `CONDITIONAL`
- **Windows container / interval Windows:** `7600+`
- **Runtime prerequisite / condiție runtime:** `existing-key`
- **Value/operation descriptions / operații:** 3
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L4 · SET-VALUE · `PreviewDetails`

- **Registry key:** `HKEY_CLASSES_ROOT\dllfile`
- **Raw .reg data:** `"prop:System.FileVersion;System.Size;System.Kind;prop:System.Copyright;System.FileAttributes;System.SharingStatus;System.DateCreated;System.DateModified"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Preview Details” în asocierile de fișiere sau integrarea shell/COM la prop:System.FileVersion;System.Size;System.Kind;prop:System.Copyright;System.FileAttributes;System.SharingStatus;System.DateCreated;System.DateModified (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Preview Details” option in file associations or shell/COM integration to prop:System.FileVersion;System.Size;System.Kind;prop:System.Copyright;System.FileAttributes;System.SharingStatus;System.DateCreated;System.DateModified (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L7 · SET-VALUE · `PreviewDetails`

- **Registry key:** `HKEY_CLASSES_ROOT\exefile`
- **Raw .reg data:** `"prop:System.FileVersion;System.Size;System.Kind;prop:System.Copyright;System.FileAttributes;System.SharingStatus;System.DateCreated;System.DateModified"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Preview Details” în asocierile de fișiere sau integrarea shell/COM la prop:System.FileVersion;System.Size;System.Kind;prop:System.Copyright;System.FileAttributes;System.SharingStatus;System.DateCreated;System.DateModified (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Preview Details” option in file associations or shell/COM integration to prop:System.FileVersion;System.Size;System.Kind;prop:System.Copyright;System.FileAttributes;System.SharingStatus;System.DateCreated;System.DateModified (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L10 · SET-VALUE · `PreviewDetails`

- **Registry key:** `HKEY_CLASSES_ROOT\ocxfile`
- **Raw .reg data:** `"prop:System.FileVersion;System.Size;System.Kind;prop:System.Copyright;System.FileAttributes;System.SharingStatus;System.DateCreated;System.DateModified"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Preview Details” în asocierile de fișiere sau integrarea shell/COM la prop:System.FileVersion;System.Size;System.Kind;prop:System.Copyright;System.FileAttributes;System.SharingStatus;System.DateCreated;System.DateModified (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Preview Details” option in file associations or shell/COM integration to prop:System.FileVersion;System.Size;System.Kind;prop:System.Copyright;System.FileAttributes;System.SharingStatus;System.DateCreated;System.DateModified (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

## Referințe / References

- No exact vendor URL is attached. The final runtime rule requires the exact live Registry target to exist before Melody enables the recipe.
