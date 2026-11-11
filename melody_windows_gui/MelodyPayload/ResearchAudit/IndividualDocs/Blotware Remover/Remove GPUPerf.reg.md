# Blotware Remover/Remove GPUPerf.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `ab2e8a838be3ed0d063132765871858aa22665134e9b7f99ed007eaa4d626a3a`
- **Recipe verdict / verdict rețetă:** `RETIRED`
- **Windows container / interval Windows:** `7600+`
- **Runtime prerequisite / condiție runtime:** `existing-key`
- **Value/operation descriptions / operații:** 2
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L3 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\WOW6432Node\AppID\{cd93979b-c14e-4c29-87a4-75e4f9fa5e0a}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „{cd93979b-c14e-4c29-87a4-75e4f9fa5e0a}” din asocierile de fișiere sau integrarea shell/COM, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “{cd93979b-c14e-4c29-87a4-75e4f9fa5e0a}” key in file associations or shell/COM integration, including all values and subkeys. Exact key semantics are unverified. The raw Registry recipe is retired from execution; this operation remains documented for reference only.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L5 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\AppID\{cd93979b-c14e-4c29-87a4-75e4f9fa5e0a}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „{cd93979b-c14e-4c29-87a4-75e4f9fa5e0a}” din asocierile de fișiere sau integrarea shell/COM, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “{cd93979b-c14e-4c29-87a4-75e4f9fa5e0a}” key in file associations or shell/COM integration, including all values and subkeys. Exact key semantics are unverified. The raw Registry recipe is retired from execution; this operation remains documented for reference only.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

## Referințe / References

- Raw Registry execution is retired because no supportable cross-version contract was established for the recipe.
