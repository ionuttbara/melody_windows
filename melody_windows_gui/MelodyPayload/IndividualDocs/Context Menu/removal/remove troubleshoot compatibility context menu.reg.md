# Context Menu/removal/remove troubleshoot compatibility context menu.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `970b0ba3a4c561025fe7f78d3c6f7b197f809dbe6cb30097c47d23dce8a70eaa`
- **Recipe verdict / verdict rețetă:** `RETIRED`
- **Windows container / interval Windows:** `7600+`
- **Runtime prerequisite / condiție runtime:** `existing-key`
- **Value/operation descriptions / operații:** 7
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L3 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\Msi.Package\shellex\ContextMenuHandlers\Compatibility`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Elimină ramura meniului contextual/shell „Compatibility”, inclusiv comenzile și subcheile sale; verifică dacă alte extensii depind de aceasta. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Removes context-menu/shell branch “Compatibility”, including commands and child keys; check whether other extensions depend on it. The raw Registry recipe is retired from execution; this operation remains documented for reference only.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Removal of built-in shell/COM registrations is version-specific and is retired rather than applied blindly.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L5 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Classes\cmdfile\shellex\ContextMenuHandlers\Compatibility`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Elimină ramura meniului contextual/shell „Compatibility”, inclusiv comenzile și subcheile sale; verifică dacă alte extensii depind de aceasta. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Removes context-menu/shell branch “Compatibility”, including commands and child keys; check whether other extensions depend on it. The raw Registry recipe is retired from execution; this operation remains documented for reference only.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Removal of built-in shell/COM registrations is version-specific and is retired rather than applied blindly.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L7 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Classes\exefile\shellex\ContextMenuHandlers\Compatibility`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Elimină ramura meniului contextual/shell „Compatibility”, inclusiv comenzile și subcheile sale; verifică dacă alte extensii depind de aceasta. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Removes context-menu/shell branch “Compatibility”, including commands and child keys; check whether other extensions depend on it. The raw Registry recipe is retired from execution; this operation remains documented for reference only.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Removal of built-in shell/COM registrations is version-specific and is retired rather than applied blindly.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L9 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Classes\batfile\shellex\ContextMenuHandlers\Compatibility`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Elimină ramura meniului contextual/shell „Compatibility”, inclusiv comenzile și subcheile sale; verifică dacă alte extensii depind de aceasta. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Removes context-menu/shell branch “Compatibility”, including commands and child keys; check whether other extensions depend on it. The raw Registry recipe is retired from execution; this operation remains documented for reference only.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Removal of built-in shell/COM registrations is version-specific and is retired rather than applied blindly.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L11 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\{1d27f844-3a1f-4410-85ac-14651078412d}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{1d27f844-3a1f-4410-85ac-14651078412d}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{1d27f844-3a1f-4410-85ac-14651078412d}” and all child keys. The exact object identity and functional impact are not confirmed. The raw Registry recipe is retired from execution; this operation remains documented for reference only.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Removal of built-in shell/COM registrations is version-specific and is retired rather than applied blindly.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L13 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CompatContextMenu.CompatContextMenu.1\CLSID`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „CLSID” din asocierile de fișiere și înregistrările shell, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “CLSID” key in file associations and shell registration, including all values and subkeys. Exact key semantics are unverified. The raw Registry recipe is retired from execution; this operation remains documented for reference only.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Removal of built-in shell/COM registrations is version-specific and is retired rather than applied blindly.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L15 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\MSILink\shellex\ContextMenuHandlers\{1d27f844-3a1f-4410-85ac-14651078412d}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Elimină ramura meniului contextual/shell „{1d27f844-3a1f-4410-85ac-14651078412d}”, inclusiv comenzile și subcheile sale; verifică dacă alte extensii depind de aceasta. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Removes context-menu/shell branch “{1d27f844-3a1f-4410-85ac-14651078412d}”, including commands and child keys; check whether other extensions depend on it. The raw Registry recipe is retired from execution; this operation remains documented for reference only.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Removal of built-in shell/COM registrations is version-specific and is retired rather than applied blindly.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

## Referințe / References

- https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers
