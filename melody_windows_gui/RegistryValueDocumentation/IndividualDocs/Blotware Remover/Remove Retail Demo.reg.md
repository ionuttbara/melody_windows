# Blotware Remover/Remove Retail Demo.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `8dc3c1bc16cf4a03ef448c9d692c29ffd9010b2fe89556928699befa1625906d`
- **Recipe verdict / verdict rețetă:** `RETIRED`
- **Windows container / interval Windows:** `7600+`
- **Runtime prerequisite / condiție runtime:** `none / niciuna`
- **Value/operation descriptions / operații:** 65
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L5 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\RetailDemo`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „RetailDemo” din ramura CurrentControlSet / Control / RetailDemo, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “RetailDemo” key in registry branch CurrentControlSet / Control / RetailDemo, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L7 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\AppXjj5q94522tr3azgc4pv1grpyk9t831ve`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „AppXjj5q94522tr3azgc4pv1grpyk9t831ve” din asocierile de fișiere sau integrarea shell/COM, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “AppXjj5q94522tr3azgc4pv1grpyk9t831ve” key in file associations or shell/COM integration, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L9 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\AppID\{ac793c1d-eb2f-4ffd-b1ec-7af1aaaf3325}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „{ac793c1d-eb2f-4ffd-b1ec-7af1aaaf3325}” din asocierile de fișiere sau integrarea shell/COM, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “{ac793c1d-eb2f-4ffd-b1ec-7af1aaaf3325}” key in file associations or shell/COM integration, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L11 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\AppID\{C2EA2356-994C-45AF-BDAE-10796F73BC47}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „{C2EA2356-994C-45AF-BDAE-10796F73BC47}” din asocierile de fișiere sau integrarea shell/COM, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “{C2EA2356-994C-45AF-BDAE-10796F73BC47}” key in file associations or shell/COM integration, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L13 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\CLSID\{1e46246f-b2ad-4a86-9e08-d0f9e01ee05d}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{1e46246f-b2ad-4a86-9e08-d0f9e01ee05d}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{1e46246f-b2ad-4a86-9e08-d0f9e01ee05d}” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L15 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\CLSID\{61f77d5e-afe9-400b-a5e6-e9e80fc8e601}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{61f77d5e-afe9-400b-a5e6-e9e80fc8e601}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{61f77d5e-afe9-400b-a5e6-e9e80fc8e601}” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L17 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\CLSID\{94FBC195-CB86-4142-9A6A-8E9CCF0D4F4D}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{94FBC195-CB86-4142-9A6A-8E9CCF0D4F4D}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{94FBC195-CB86-4142-9A6A-8E9CCF0D4F4D}” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L19 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\CLSID\{a6e02196-c1bf-4989-8a94-144eee4a9bb2}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{a6e02196-c1bf-4989-8a94-144eee4a9bb2}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{a6e02196-c1bf-4989-8a94-144eee4a9bb2}” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L21 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\CLSID\{FB046C65-10C7-4994-ABE4-E3F7FD710B2E}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{FB046C65-10C7-4994-ABE4-E3F7FD710B2E}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{FB046C65-10C7-4994-ABE4-E3F7FD710B2E}” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L23 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\Interface\{15D8726E-26CE-495A-817E-3AD7B022FCFA}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „{15D8726E-26CE-495A-817E-3AD7B022FCFA}” din asocierile de fișiere sau integrarea shell/COM, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “{15D8726E-26CE-495A-817E-3AD7B022FCFA}” key in file associations or shell/COM integration, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L25 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\Interface\{1FD12909-E6DD-4983-A4C6-50B395961110}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „{1FD12909-E6DD-4983-A4C6-50B395961110}” din asocierile de fișiere sau integrarea shell/COM, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “{1FD12909-E6DD-4983-A4C6-50B395961110}” key in file associations or shell/COM integration, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L27 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\Interface\{8ba5a5ed-e0c5-4ce6-a1e8-9263e099746f}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „{8ba5a5ed-e0c5-4ce6-a1e8-9263e099746f}” din asocierile de fișiere sau integrarea shell/COM, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “{8ba5a5ed-e0c5-4ce6-a1e8-9263e099746f}” key in file associations or shell/COM integration, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L29 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\Interface\{faedbd4d-20b6-43a9-b67c-577127c8d12b}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „{faedbd4d-20b6-43a9-b67c-577127c8d12b}” din asocierile de fișiere sau integrarea shell/COM, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “{faedbd4d-20b6-43a9-b67c-577127c8d12b}” key in file associations or shell/COM integration, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L31 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\ms-retaildemo-launchbioenrollment`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „ms-retaildemo-launchbioenrollment” din asocierile de fișiere sau integrarea shell/COM, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “ms-retaildemo-launchbioenrollment” key in file associations or shell/COM integration, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L33 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\ms-retaildemo-launchstart`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „ms-retaildemo-launchstart” din asocierile de fișiere sau integrarea shell/COM, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “ms-retaildemo-launchstart” key in file associations or shell/COM integration, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L35 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\WOW6432Node\AppID\{ac793c1d-eb2f-4ffd-b1ec-7af1aaaf3325}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „{ac793c1d-eb2f-4ffd-b1ec-7af1aaaf3325}” din asocierile de fișiere sau integrarea shell/COM, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “{ac793c1d-eb2f-4ffd-b1ec-7af1aaaf3325}” key in file associations or shell/COM integration, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L37 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\WOW6432Node\AppID\{C2EA2356-994C-45AF-BDAE-10796F73BC47}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „{C2EA2356-994C-45AF-BDAE-10796F73BC47}” din asocierile de fișiere sau integrarea shell/COM, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “{C2EA2356-994C-45AF-BDAE-10796F73BC47}” key in file associations or shell/COM integration, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L39 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\WOW6432Node\CLSID\{FB046C65-10C7-4994-ABE4-E3F7FD710B2E}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{FB046C65-10C7-4994-ABE4-E3F7FD710B2E}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{FB046C65-10C7-4994-ABE4-E3F7FD710B2E}” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L41 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\WOW6432Node\Interface\{15D8726E-26CE-495A-817E-3AD7B022FCFA}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „{15D8726E-26CE-495A-817E-3AD7B022FCFA}” din asocierile de fișiere sau integrarea shell/COM, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “{15D8726E-26CE-495A-817E-3AD7B022FCFA}” key in file associations or shell/COM integration, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L43 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\WOW6432Node\Interface\{1FD12909-E6DD-4983-A4C6-50B395961110}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „{1FD12909-E6DD-4983-A4C6-50B395961110}” din asocierile de fișiere sau integrarea shell/COM, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “{1FD12909-E6DD-4983-A4C6-50B395961110}” key in file associations or shell/COM integration, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L45 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\WOW6432Node\Interface\{8ba5a5ed-e0c5-4ce6-a1e8-9263e099746f}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „{8ba5a5ed-e0c5-4ce6-a1e8-9263e099746f}” din asocierile de fișiere sau integrarea shell/COM, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “{8ba5a5ed-e0c5-4ce6-a1e8-9263e099746f}” key in file associations or shell/COM integration, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L47 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\WOW6432Node\Interface\{faedbd4d-20b6-43a9-b67c-577127c8d12b}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „{faedbd4d-20b6-43a9-b67c-577127c8d12b}” din asocierile de fișiere sau integrarea shell/COM, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “{faedbd4d-20b6-43a9-b67c-577127c8d12b}” key in file associations or shell/COM integration, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L49 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Classes\AppID\{ac793c1d-eb2f-4ffd-b1ec-7af1aaaf3325}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „{ac793c1d-eb2f-4ffd-b1ec-7af1aaaf3325}” din asocierile de fișiere și înregistrările shell, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “{ac793c1d-eb2f-4ffd-b1ec-7af1aaaf3325}” key in file associations and shell registration, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L51 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Classes\AppID\{C2EA2356-994C-45AF-BDAE-10796F73BC47}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „{C2EA2356-994C-45AF-BDAE-10796F73BC47}” din asocierile de fișiere și înregistrările shell, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “{C2EA2356-994C-45AF-BDAE-10796F73BC47}” key in file associations and shell registration, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L53 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\{1e46246f-b2ad-4a86-9e08-d0f9e01ee05d}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{1e46246f-b2ad-4a86-9e08-d0f9e01ee05d}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{1e46246f-b2ad-4a86-9e08-d0f9e01ee05d}” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L55 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\{61f77d5e-afe9-400b-a5e6-e9e80fc8e601}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{61f77d5e-afe9-400b-a5e6-e9e80fc8e601}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{61f77d5e-afe9-400b-a5e6-e9e80fc8e601}” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L57 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\{94FBC195-CB86-4142-9A6A-8E9CCF0D4F4D}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{94FBC195-CB86-4142-9A6A-8E9CCF0D4F4D}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{94FBC195-CB86-4142-9A6A-8E9CCF0D4F4D}” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L59 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\{a6e02196-c1bf-4989-8a94-144eee4a9bb2}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{a6e02196-c1bf-4989-8a94-144eee4a9bb2}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{a6e02196-c1bf-4989-8a94-144eee4a9bb2}” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L61 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\{FB046C65-10C7-4994-ABE4-E3F7FD710B2E}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{FB046C65-10C7-4994-ABE4-E3F7FD710B2E}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{FB046C65-10C7-4994-ABE4-E3F7FD710B2E}” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L63 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Interface\{15D8726E-26CE-495A-817E-3AD7B022FCFA}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „{15D8726E-26CE-495A-817E-3AD7B022FCFA}” din asocierile de fișiere și înregistrările shell, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “{15D8726E-26CE-495A-817E-3AD7B022FCFA}” key in file associations and shell registration, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L65 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Interface\{1FD12909-E6DD-4983-A4C6-50B395961110}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „{1FD12909-E6DD-4983-A4C6-50B395961110}” din asocierile de fișiere și înregistrările shell, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “{1FD12909-E6DD-4983-A4C6-50B395961110}” key in file associations and shell registration, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L67 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Interface\{8ba5a5ed-e0c5-4ce6-a1e8-9263e099746f}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „{8ba5a5ed-e0c5-4ce6-a1e8-9263e099746f}” din asocierile de fișiere și înregistrările shell, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “{8ba5a5ed-e0c5-4ce6-a1e8-9263e099746f}” key in file associations and shell registration, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L69 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Interface\{faedbd4d-20b6-43a9-b67c-577127c8d12b}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „{faedbd4d-20b6-43a9-b67c-577127c8d12b}” din asocierile de fișiere și înregistrările shell, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “{faedbd4d-20b6-43a9-b67c-577127c8d12b}” key in file associations and shell registration, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L71 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Classes\ms-retaildemo-launchstart`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „ms-retaildemo-launchstart” din asocierile de fișiere și înregistrările shell, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “ms-retaildemo-launchstart” key in file associations and shell registration, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L73 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Classes\ms-retaildemo-launchbioenrollment`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „ms-retaildemo-launchbioenrollment” din asocierile de fișiere și înregistrările shell, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “ms-retaildemo-launchbioenrollment” key in file associations and shell registration, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L75 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Classes\WOW6432Node\AppID\{ac793c1d-eb2f-4ffd-b1ec-7af1aaaf3325}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „{ac793c1d-eb2f-4ffd-b1ec-7af1aaaf3325}” din asocierile de fișiere și înregistrările shell, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “{ac793c1d-eb2f-4ffd-b1ec-7af1aaaf3325}” key in file associations and shell registration, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L77 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Classes\WOW6432Node\AppID\{C2EA2356-994C-45AF-BDAE-10796F73BC47}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „{C2EA2356-994C-45AF-BDAE-10796F73BC47}” din asocierile de fișiere și înregistrările shell, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “{C2EA2356-994C-45AF-BDAE-10796F73BC47}” key in file associations and shell registration, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L79 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Classes\WOW6432Node\CLSID\{FB046C65-10C7-4994-ABE4-E3F7FD710B2E}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{FB046C65-10C7-4994-ABE4-E3F7FD710B2E}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{FB046C65-10C7-4994-ABE4-E3F7FD710B2E}” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L81 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Classes\WOW6432Node\Interface\{15D8726E-26CE-495A-817E-3AD7B022FCFA}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „{15D8726E-26CE-495A-817E-3AD7B022FCFA}” din asocierile de fișiere și înregistrările shell, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “{15D8726E-26CE-495A-817E-3AD7B022FCFA}” key in file associations and shell registration, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L83 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Classes\WOW6432Node\Interface\{1FD12909-E6DD-4983-A4C6-50B395961110}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „{1FD12909-E6DD-4983-A4C6-50B395961110}” din asocierile de fișiere și înregistrările shell, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “{1FD12909-E6DD-4983-A4C6-50B395961110}” key in file associations and shell registration, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L85 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Classes\WOW6432Node\Interface\{8ba5a5ed-e0c5-4ce6-a1e8-9263e099746f}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „{8ba5a5ed-e0c5-4ce6-a1e8-9263e099746f}” din asocierile de fișiere și înregistrările shell, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “{8ba5a5ed-e0c5-4ce6-a1e8-9263e099746f}” key in file associations and shell registration, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L87 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Classes\WOW6432Node\Interface\{faedbd4d-20b6-43a9-b67c-577127c8d12b}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „{faedbd4d-20b6-43a9-b67c-577127c8d12b}” din asocierile de fișiere și înregistrările shell, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “{faedbd4d-20b6-43a9-b67c-577127c8d12b}” key in file associations and shell registration, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L89 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Internet Explorer\ProtocolExecute\ms-retaildemo-launchbioenrollment`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „ms-retaildemo-launchbioenrollment” din ramura Microsoft / Internet Explorer / ProtocolExecute, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “ms-retaildemo-launchbioenrollment” key in registry branch Microsoft / Internet Explorer / ProtocolExecute, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L91 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Internet Explorer\ProtocolExecute\ms-retaildemo-launchstart`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „ms-retaildemo-launchstart” din ramura Microsoft / Internet Explorer / ProtocolExecute, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “ms-retaildemo-launchstart” key in registry branch Microsoft / Internet Explorer / ProtocolExecute, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L93 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\FolderDescriptions\{12D4C69E-24AD-4923-BE19-31321C43A767}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „{12D4C69E-24AD-4923-BE19-31321C43A767}” din Explorer și interfața shell, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “{12D4C69E-24AD-4923-BE19-31321C43A767}” key in File Explorer and Windows shell, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L95 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\VolumeCaches\RetailDemo Offline Content`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „RetailDemo Offline Content” din Explorer și interfața shell, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “RetailDemo Offline Content” key in File Explorer and Windows shell, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L97 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\CLSID\{0886dae5-13ba-49d6-a6ef-d0922e502d96}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{0886dae5-13ba-49d6-a6ef-d0922e502d96}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{0886dae5-13ba-49d6-a6ef-d0922e502d96}” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L99 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\WOW6432Node\CLSID\{0886dae5-13ba-49d6-a6ef-d0922e502d96}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{0886dae5-13ba-49d6-a6ef-d0922e502d96}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{0886dae5-13ba-49d6-a6ef-d0922e502d96}” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L101 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\WindowsRuntime\ActivatableClassId\RetailDemo.Internal.RetailDemoSetup`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea Windows Runtime „RetailDemo.Internal.RetailDemoSetup”; componenta exactă asociată nu a fost identificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes Windows Runtime registration “RetailDemo.Internal.RetailDemoSetup”; the exact corresponding component has not been identified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L103 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\WindowsRuntime\ActivatableClassId\RetailDemo.Internal.RetailInfoSetter`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea Windows Runtime „RetailDemo.Internal.RetailInfoSetter”; componenta exactă asociată nu a fost identificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes Windows Runtime registration “RetailDemo.Internal.RetailInfoSetter”; the exact corresponding component has not been identified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L105 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\WindowsRuntime\ActivatableClassId\RetailDemo.Internal.WindowsHelloHelper`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea Windows Runtime „RetailDemo.Internal.WindowsHelloHelper”; componenta exactă asociată nu a fost identificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes Windows Runtime registration “RetailDemo.Internal.WindowsHelloHelper”; the exact corresponding component has not been identified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L107 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\WindowsRuntime\ActivatableClassId\CloudExperienceHostBroker.RetailDemo.ConfigureRetailDemo`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea Windows Runtime „CloudExperienceHostBroker.RetailDemo.ConfigureRetailDemo”; componenta exactă asociată nu a fost identificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes Windows Runtime registration “CloudExperienceHostBroker.RetailDemo.ConfigureRetailDemo”; the exact corresponding component has not been identified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L109 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\WOW6432Node\CLSID\{119b14a0-eb11-40c7-9a3c-e6a8904827d2}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{119b14a0-eb11-40c7-9a3c-e6a8904827d2}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{119b14a0-eb11-40c7-9a3c-e6a8904827d2}” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L111 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\WOW6432Node\CLSID\{1a9ca6d5-2488-46b1-b439-218f2314a059}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{1a9ca6d5-2488-46b1-b439-218f2314a059}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{1a9ca6d5-2488-46b1-b439-218f2314a059}” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L113 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\WOW6432Node\CLSID\{A5890610-900C-4115-BAFF-767E05E10F1F}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{A5890610-900C-4115-BAFF-767E05E10F1F}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{A5890610-900C-4115-BAFF-767E05E10F1F}” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L115 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\WOW6432Node\CLSID\{CD607C8B-17CA-4D2E-BA26-B748553BB0B2}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{CD607C8B-17CA-4D2E-BA26-B748553BB0B2}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{CD607C8B-17CA-4D2E-BA26-B748553BB0B2}” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L117 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\WOW6432Node\CLSID\{DE8DEA9C-CC35-4A6E-8A17-F0C611F249A4}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{DE8DEA9C-CC35-4A6E-8A17-F0C611F249A4}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{DE8DEA9C-CC35-4A6E-8A17-F0C611F249A4}” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L119 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\WOW6432Node\CLSID\{EBB236B1-F57F-480D-9DE9-B15A87298EEC}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{EBB236B1-F57F-480D-9DE9-B15A87298EEC}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{EBB236B1-F57F-480D-9DE9-B15A87298EEC}” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L121 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\WOW6432Node\AppID\{0886dae5-13ba-49d6-a6ef-d0922e502d96}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „{0886dae5-13ba-49d6-a6ef-d0922e502d96}” din asocierile de fișiere sau integrarea shell/COM, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “{0886dae5-13ba-49d6-a6ef-d0922e502d96}” key in file associations or shell/COM integration, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L125 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\CLSID\{119b14a0-eb11-40c7-9a3c-e6a8904827d2}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{119b14a0-eb11-40c7-9a3c-e6a8904827d2}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{119b14a0-eb11-40c7-9a3c-e6a8904827d2}” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L127 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\CLSID\{1a9ca6d5-2488-46b1-b439-218f2314a059}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{1a9ca6d5-2488-46b1-b439-218f2314a059}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{1a9ca6d5-2488-46b1-b439-218f2314a059}” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L129 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\CLSID\{A5890610-900C-4115-BAFF-767E05E10F1F}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{A5890610-900C-4115-BAFF-767E05E10F1F}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{A5890610-900C-4115-BAFF-767E05E10F1F}” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L131 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\CLSID\{CD607C8B-17CA-4D2E-BA26-B748553BB0B2}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{CD607C8B-17CA-4D2E-BA26-B748553BB0B2}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{CD607C8B-17CA-4D2E-BA26-B748553BB0B2}” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L133 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\CLSID\{DE8DEA9C-CC35-4A6E-8A17-F0C611F249A4}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{DE8DEA9C-CC35-4A6E-8A17-F0C611F249A4}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{DE8DEA9C-CC35-4A6E-8A17-F0C611F249A4}” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L135 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\CLSID\{EBB236B1-F57F-480D-9DE9-B15A87298EEC}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{EBB236B1-F57F-480D-9DE9-B15A87298EEC}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{EBB236B1-F57F-480D-9DE9-B15A87298EEC}” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

## Referințe / References

- Raw Registry execution is retired because no supportable cross-version contract was established for the recipe.
