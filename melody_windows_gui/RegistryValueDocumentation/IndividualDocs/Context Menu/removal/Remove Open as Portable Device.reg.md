# Context Menu/removal/Remove Open as Portable Device.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `a65b49827da7eba390e4d109669f45a34ffddc995a5432201a088184147aa9e0`
- **Recipe verdict / verdict rețetă:** `RETIRED`
- **Windows container / interval Windows:** `7600+`
- **Runtime prerequisite / condiție runtime:** `existing-key`
- **Value/operation descriptions / operații:** 3
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L5 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Drive\shellex\ContextMenuHandlers\{D6791A63-E7E2-4fee-BF52-5DED8E86E9B8}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Elimină ramura meniului contextual/shell „{D6791A63-E7E2-4fee-BF52-5DED8E86E9B8}”, inclusiv comenzile și subcheile sale; verifică dacă alte extensii depind de aceasta. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Removes context-menu/shell branch “{D6791A63-E7E2-4fee-BF52-5DED8E86E9B8}”, including commands and child keys; check whether other extensions depend on it. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Removal of built-in shell/COM registrations is version-specific and is retired rather than applied blindly.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L7 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\CLSID\{D6791A63-E7E2-4fee-BF52-5DED8E86E9B8}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{D6791A63-E7E2-4fee-BF52-5DED8E86E9B8}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{D6791A63-E7E2-4fee-BF52-5DED8E86E9B8}” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Removal of built-in shell/COM registrations is version-specific and is retired rather than applied blindly.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L9 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\Drive\shell\Optimize using PerfectDisk`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Elimină ramura meniului contextual/shell „Optimize using PerfectDisk”, inclusiv comenzile și subcheile sale; verifică dacă alte extensii depind de aceasta. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Removes context-menu/shell branch “Optimize using PerfectDisk”, including commands and child keys; check whether other extensions depend on it. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Removal of built-in shell/COM registrations is version-specific and is retired rather than applied blindly.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

## Referințe / References

- https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers
