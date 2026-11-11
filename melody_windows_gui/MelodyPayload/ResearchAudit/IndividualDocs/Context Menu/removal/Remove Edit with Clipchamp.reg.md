# Context Menu/removal/Remove Edit with Clipchamp.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `b4b03114907e38bc77df1a8b35f920b9fda88616bd4d36df851caa814572ac75`
- **Recipe verdict / verdict rețetă:** `RETIRED`
- **Windows container / interval Windows:** `22000+`
- **Runtime prerequisite / condiție runtime:** `existing-key`
- **Value/operation descriptions / operații:** 4
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L3 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\CLSID\{AF679D58-078E-48D4-A1E3-474F10DF76B8}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{AF679D58-078E-48D4-A1E3-474F10DF76B8}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{AF679D58-078E-48D4-A1E3-474F10DF76B8}” and all child keys. The exact object identity and functional impact are not confirmed. The raw Registry recipe is retired from execution; this operation remains documented for reference only.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Removal of built-in shell/COM registrations is version-specific and is retired rather than applied blindly.
- **OS support / versiuni:** `22000+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L5 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\WOW6432Node\CLSID\{8AB635F8-9A67-4698-AB99-784AD929F3B4}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{8AB635F8-9A67-4698-AB99-784AD929F3B4}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{8AB635F8-9A67-4698-AB99-784AD929F3B4}” and all child keys. The exact object identity and functional impact are not confirmed. The raw Registry recipe is retired from execution; this operation remains documented for reference only.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Removal of built-in shell/COM registrations is version-specific and is retired rather than applied blindly.
- **OS support / versiuni:** `22000+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L7 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\CLSID\{8AB635F8-9A67-4698-AB99-784AD929F3B4}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{8AB635F8-9A67-4698-AB99-784AD929F3B4}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{8AB635F8-9A67-4698-AB99-784AD929F3B4}” and all child keys. The exact object identity and functional impact are not confirmed. The raw Registry recipe is retired from execution; this operation remains documented for reference only.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Removal of built-in shell/COM registrations is version-specific and is retired rather than applied blindly.
- **OS support / versiuni:** `22000+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L9 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\WOW6432Node\CLSID\{AF679D58-078E-48D4-A1E3-474F10DF76B8}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{AF679D58-078E-48D4-A1E3-474F10DF76B8}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{AF679D58-078E-48D4-A1E3-474F10DF76B8}” and all child keys. The exact object identity and functional impact are not confirmed. The raw Registry recipe is retired from execution; this operation remains documented for reference only.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Removal of built-in shell/COM registrations is version-specific and is retired rather than applied blindly.
- **OS support / versiuni:** `22000+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

## Referințe / References

- https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers
