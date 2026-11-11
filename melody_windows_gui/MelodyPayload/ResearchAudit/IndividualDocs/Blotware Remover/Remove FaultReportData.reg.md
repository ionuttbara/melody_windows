# Blotware Remover/Remove FaultReportData.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `3993820ec76e10cf928e2e64b017e6b7a9d74d4fa6c82eb1694544e6559bb71b`
- **Recipe verdict / verdict rețetă:** `RETIRED`
- **Windows container / interval Windows:** `7600+`
- **Runtime prerequisite / condiție runtime:** `existing-key`
- **Value/operation descriptions / operații:** 10
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L5 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\FaultrepDataCollectionInProc`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „FaultrepDataCollectionInProc” din asocierile de fișiere sau integrarea shell/COM, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “FaultrepDataCollectionInProc” key in file associations or shell/COM integration, including all values and subkeys. Exact key semantics are unverified. The raw Registry recipe is retired from execution; this operation remains documented for reference only.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L7 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\FaultrepElevatedDataCollection`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „FaultrepElevatedDataCollection” din asocierile de fișiere sau integrarea shell/COM, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “FaultrepElevatedDataCollection” key in file associations or shell/COM integration, including all values and subkeys. Exact key semantics are unverified. The raw Registry recipe is retired from execution; this operation remains documented for reference only.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L9 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Classes\FaultrepDataCollectionInProc`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „FaultrepDataCollectionInProc” din asocierile de fișiere și înregistrările shell, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “FaultrepDataCollectionInProc” key in file associations and shell registration, including all values and subkeys. Exact key semantics are unverified. The raw Registry recipe is retired from execution; this operation remains documented for reference only.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L11 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Classes\FaultrepElevatedDataCollection`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „FaultrepElevatedDataCollection” din asocierile de fișiere și înregistrările shell, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “FaultrepElevatedDataCollection” key in file associations and shell registration, including all values and subkeys. Exact key semantics are unverified. The raw Registry recipe is retired from execution; this operation remains documented for reference only.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L15 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\WOW6432Node\CLSID\{6E3D2E94-E6D8-4afd-AFDE-ABD26CA88BF5}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{6E3D2E94-E6D8-4afd-AFDE-ABD26CA88BF5}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{6E3D2E94-E6D8-4afd-AFDE-ABD26CA88BF5}” and all child keys. The exact object identity and functional impact are not confirmed. The raw Registry recipe is retired from execution; this operation remains documented for reference only.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L17 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\{6E3D2E94-E6D8-4afd-AFDE-ABD26CA88BF5}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{6E3D2E94-E6D8-4afd-AFDE-ABD26CA88BF5}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{6E3D2E94-E6D8-4afd-AFDE-ABD26CA88BF5}” and all child keys. The exact object identity and functional impact are not confirmed. The raw Registry recipe is retired from execution; this operation remains documented for reference only.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L19 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Classes\WOW6432Node\CLSID\{6E3D2E94-E6D8-4afd-AFDE-ABD26CA88BF5}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{6E3D2E94-E6D8-4afd-AFDE-ABD26CA88BF5}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{6E3D2E94-E6D8-4afd-AFDE-ABD26CA88BF5}” and all child keys. The exact object identity and functional impact are not confirmed. The raw Registry recipe is retired from execution; this operation remains documented for reference only.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L23 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\WOW6432Node\CLSID\{2C256447-3F0D-4CBB-9D12-575BB20CDA0A}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{2C256447-3F0D-4CBB-9D12-575BB20CDA0A}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{2C256447-3F0D-4CBB-9D12-575BB20CDA0A}” and all child keys. The exact object identity and functional impact are not confirmed. The raw Registry recipe is retired from execution; this operation remains documented for reference only.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L25 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Classes\CLSID\{2C256447-3F0D-4CBB-9D12-575BB20CDA0A}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{2C256447-3F0D-4CBB-9D12-575BB20CDA0A}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{2C256447-3F0D-4CBB-9D12-575BB20CDA0A}” and all child keys. The exact object identity and functional impact are not confirmed. The raw Registry recipe is retired from execution; this operation remains documented for reference only.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L27 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Classes\WOW6432Node\CLSID\{2C256447-3F0D-4CBB-9D12-575BB20CDA0A}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{2C256447-3F0D-4CBB-9D12-575BB20CDA0A}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{2C256447-3F0D-4CBB-9D12-575BB20CDA0A}” and all child keys. The exact object identity and functional impact are not confirmed. The raw Registry recipe is retired from execution; this operation remains documented for reference only.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

## Referințe / References

- Raw Registry execution is retired because no supportable cross-version contract was established for the recipe.
