# Blotware Remover/Control Panel Applet/Remove Unwanted Control Panel Elements.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `ed569576651dadcb76f19b7f970836fd4c0c14d9188fdb25d2a92bc3fa65c599`
- **Recipe verdict / verdict rețetă:** `RETIRED`
- **Windows container / interval Windows:** `7600+`
- **Runtime prerequisite / condiție runtime:** `none / niciuna`
- **Value/operation descriptions / operații:** 54
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L5 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\CLSID\{871C5380-42A0-1069-A2EA-08002B30309D}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{871C5380-42A0-1069-A2EA-08002B30309D}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{871C5380-42A0-1069-A2EA-08002B30309D}” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L7 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Desktop\NameSpace\{26EE0668-A00A-44D7-9371-BEB064C98683}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Elimină înregistrarea de spațiu de nume Explorer „{26EE0668-A00A-44D7-9371-BEB064C98683}” împreună cu subcheile; elementul UI asociat nu este identificat independent. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Removes Explorer namespace registration “{26EE0668-A00A-44D7-9371-BEB064C98683}” and its child keys; associated UI item has not been independently identified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L9 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Desktop\NameSpace\{9343812e-1c37-4a49-a12e-4b2d810d956b}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Elimină înregistrarea de spațiu de nume Explorer „{9343812e-1c37-4a49-a12e-4b2d810d956b}” împreună cu subcheile; elementul UI asociat nu este identificat independent. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Removes Explorer namespace registration “{9343812e-1c37-4a49-a12e-4b2d810d956b}” and its child keys; associated UI item has not been independently identified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L11 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Desktop\NameSpace\{2559a1f8-21d7-11d4-bdaf-00c04f60b9f0}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Elimină înregistrarea de spațiu de nume Explorer „{2559a1f8-21d7-11d4-bdaf-00c04f60b9f0}” împreună cu subcheile; elementul UI asociat nu este identificat independent. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Removes Explorer namespace registration “{2559a1f8-21d7-11d4-bdaf-00c04f60b9f0}” and its child keys; associated UI item has not been independently identified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L13 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\WOW6432Node\CLSID\{2559a1f5-21d7-11d4-bdaf-00c04f60b9f0}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{2559a1f5-21d7-11d4-bdaf-00c04f60b9f0}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{2559a1f5-21d7-11d4-bdaf-00c04f60b9f0}” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L15 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\CLSID\{2559a1f5-21d7-11d4-bdaf-00c04f60b9f0}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{2559a1f5-21d7-11d4-bdaf-00c04f60b9f0}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{2559a1f5-21d7-11d4-bdaf-00c04f60b9f0}” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L18 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\Drive\shellex\ContextMenuHandlers\{fbeb8a05-beee-4442-804e-409d6c4515e9}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Elimină ramura meniului contextual/shell „{fbeb8a05-beee-4442-804e-409d6c4515e9}”, inclusiv comenzile și subcheile sale; verifică dacă alte extensii depind de aceasta. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Removes context-menu/shell branch “{fbeb8a05-beee-4442-804e-409d6c4515e9}”, including commands and child keys; check whether other extensions depend on it. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L20 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\WOW6432Node\CLSID\{D555645E-D4F8-4c29-A827-D93C859C4F2A}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{D555645E-D4F8-4c29-A827-D93C859C4F2A}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{D555645E-D4F8-4c29-A827-D93C859C4F2A}” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L22 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\WOW6432Node\CLSID\{9C60DE1E-E5FC-40f4-A487-}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{9C60DE1E-E5FC-40f4-A487-}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{9C60DE1E-E5FC-40f4-A487-}” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L25 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\WOW6432Node\CLSID\{E44E5D18-0652-4508-A4E2-8A090067BCB0}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{E44E5D18-0652-4508-A4E2-8A090067BCB0}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{E44E5D18-0652-4508-A4E2-8A090067BCB0}” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L27 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\WOW6432Node\CLSID\{17cd9488-1228-4b2f-88ce-4298e93e0966}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{17cd9488-1228-4b2f-88ce-4298e93e0966}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{17cd9488-1228-4b2f-88ce-4298e93e0966}” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L29 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\CLSID\{D555645E-D4F8-4c29-A827-D93C859C4F2A}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{D555645E-D4F8-4c29-A827-D93C859C4F2A}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{D555645E-D4F8-4c29-A827-D93C859C4F2A}” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L31 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\CLSID\{9C60DE1E-E5FC-40f4-A487-460851A8D915}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{9C60DE1E-E5FC-40f4-A487-460851A8D915}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{9C60DE1E-E5FC-40f4-A487-460851A8D915}” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L33 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\CLSID\{E44E5D18-0652-4508-A4E2-8A090067BCB0}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{E44E5D18-0652-4508-A4E2-8A090067BCB0}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{E44E5D18-0652-4508-A4E2-8A090067BCB0}” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L35 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\CLSID\{17cd9488-1228-4b2f-88ce-4298e93e0966}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{17cd9488-1228-4b2f-88ce-4298e93e0966}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{17cd9488-1228-4b2f-88ce-4298e93e0966}” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L39 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\CLSID\{B98A2BEA-7D42-4558-8BD1-832F41BAC6FD}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{B98A2BEA-7D42-4558-8BD1-832F41BAC6FD}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{B98A2BEA-7D42-4558-8BD1-832F41BAC6FD}” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L41 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\CLSID\{C49E32C6-BC8B-11d2-85D4-00105A1F8304}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{C49E32C6-BC8B-11d2-85D4-00105A1F8304}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{C49E32C6-BC8B-11d2-85D4-00105A1F8304}” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L43 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\CLSID\{d1934e71-740b-47cf-b051-6551e5b80fd5}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{d1934e71-740b-47cf-b051-6551e5b80fd5}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{d1934e71-740b-47cf-b051-6551e5b80fd5}” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L46 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\CLSID\{ca767aa8-9157-4604-b64b-40747123d5f2}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{ca767aa8-9157-4604-b64b-40747123d5f2}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{ca767aa8-9157-4604-b64b-40747123d5f2}” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L51 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\WOW6432Node\CLSID\{B98A2BEA-7D42-4558-8BD1-832F41BAC6FD}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{B98A2BEA-7D42-4558-8BD1-832F41BAC6FD}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{B98A2BEA-7D42-4558-8BD1-832F41BAC6FD}” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L53 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\WOW6432Node\CLSID\{C49E32C6-BC8B-11d2-85D4-00105A1F8304}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{C49E32C6-BC8B-11d2-85D4-00105A1F8304}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{C49E32C6-BC8B-11d2-85D4-00105A1F8304}” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L55 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\WOW6432Node\CLSID\{d1934e71-740b-47cf-b051-6551e5b80fd5}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{d1934e71-740b-47cf-b051-6551e5b80fd5}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{d1934e71-740b-47cf-b051-6551e5b80fd5}” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L58 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\WOW6432Node\CLSID\{ca767aa8-9157-4604-b64b-40747123d5f2}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{ca767aa8-9157-4604-b64b-40747123d5f2}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{ca767aa8-9157-4604-b64b-40747123d5f2}” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L62 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\CLSID\{40419485-C444-4567-851A-2DD7BFA1684D}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{40419485-C444-4567-851A-2DD7BFA1684D}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{40419485-C444-4567-851A-2DD7BFA1684D}” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L64 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\DeviceDisplayObject\InterfaceClass\{2C7089AA-2E0E-11D1-B114-00C04FC2AAE4}\Shell\Modem`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „Modem” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “Modem” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L67 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\CLSID\{5ea4f148-308c-46d7-98a9-49041b1dd468}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{5ea4f148-308c-46d7-98a9-49041b1dd468}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{5ea4f148-308c-46d7-98a9-49041b1dd468}” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L69 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\DeviceDisplayObject\InterfaceClass\{BA1BB692-9B7A-4833-9A1E-525ED134E7E2}\Shell\Sensor`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „Sensor” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “Sensor” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L73 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\CLSID\{80F3F1D5-FECA-45F3-BC32-752C152E456E}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{80F3F1D5-FECA-45F3-BC32-752C152E456E}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{80F3F1D5-FECA-45F3-BC32-752C152E456E}” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L75 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\CLSID\{F82DF8F7-8B9F-442E-A48C-818EA735FF9B}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{F82DF8F7-8B9F-442E-A48C-818EA735FF9B}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{F82DF8F7-8B9F-442E-A48C-818EA735FF9B}” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L79 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\CLSID\{87D66A43-7B11-4A28-9811-C86EE395ACF7}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{87D66A43-7B11-4A28-9811-C86EE395ACF7}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{87D66A43-7B11-4A28-9811-C86EE395ACF7}” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L82 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\CLSID\{9FE63AFD-59CF-4419-9775-ABCC3849F861}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{9FE63AFD-59CF-4419-9775-ABCC3849F861}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{9FE63AFD-59CF-4419-9775-ABCC3849F861}” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L85 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\CLSID\{D17D1D6D-CC3F-4815-8FE3-607E7D5D10B3}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{D17D1D6D-CC3F-4815-8FE3-607E7D5D10B3}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{D17D1D6D-CC3F-4815-8FE3-607E7D5D10B3}” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L89 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\CLSID\{D20EA4E1-3957-11d2-A40B-0C5020524153}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{D20EA4E1-3957-11d2-A40B-0C5020524153}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{D20EA4E1-3957-11d2-A40B-0C5020524153}” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L93 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\CLSID\{F942C606-0914-47AB-BE56-1321B8035096}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{F942C606-0914-47AB-BE56-1321B8035096}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{F942C606-0914-47AB-BE56-1321B8035096}” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L98 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\WOW6432Node\CLSID\{40419485-C444-4567-851A-2DD7BFA1684D}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{40419485-C444-4567-851A-2DD7BFA1684D}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{40419485-C444-4567-851A-2DD7BFA1684D}” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L100 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\WOW6432Node\DeviceDisplayObject\InterfaceClass\{2C7089AA-2E0E-11D1-B114-00C04FC2AAE4}\Shell\Modem`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „Modem” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “Modem” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L103 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\WOW6432Node\CLSID\{5ea4f148-308c-46d7-98a9-49041b1dd468}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{5ea4f148-308c-46d7-98a9-49041b1dd468}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{5ea4f148-308c-46d7-98a9-49041b1dd468}” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L105 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\WOW6432Node\DeviceDisplayObject\InterfaceClass\{BA1BB692-9B7A-4833-9A1E-525ED134E7E2}\Shell\Sensor`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „Sensor” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “Sensor” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L110 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\WOW6432Node\CLSID\{87D66A43-7B11-4A28-9811-C86EE395ACF7}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{87D66A43-7B11-4A28-9811-C86EE395ACF7}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{87D66A43-7B11-4A28-9811-C86EE395ACF7}” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L113 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\WOW6432Node\CLSID\{9FE63AFD-59CF-4419-9775-ABCC3849F861}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{9FE63AFD-59CF-4419-9775-ABCC3849F861}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{9FE63AFD-59CF-4419-9775-ABCC3849F861}” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L116 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\WOW6432Node\CLSID\{D17D1D6D-CC3F-4815-8FE3-607E7D5D10B3}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{D17D1D6D-CC3F-4815-8FE3-607E7D5D10B3}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{D17D1D6D-CC3F-4815-8FE3-607E7D5D10B3}” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L120 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\WOW6432Node\CLSID\{D20EA4E1-3957-11d2-A40B-0C5020524153}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{D20EA4E1-3957-11d2-A40B-0C5020524153}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{D20EA4E1-3957-11d2-A40B-0C5020524153}” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L124 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\WOW6432Node\CLSID\{F942C606-0914-47AB-BE56-1321B8035096}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{F942C606-0914-47AB-BE56-1321B8035096}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{F942C606-0914-47AB-BE56-1321B8035096}” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L128 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\WOW6432Node\CLSID\{5C03E1B1-EB13-4DF1-8943-2FE8E7D5F309}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{5C03E1B1-EB13-4DF1-8943-2FE8E7D5F309}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{5C03E1B1-EB13-4DF1-8943-2FE8E7D5F309}” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L130 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\CLSID\{5C03E1B1-EB13-4DF1-8943-2FE8E7D5F309}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{5C03E1B1-EB13-4DF1-8943-2FE8E7D5F309}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{5C03E1B1-EB13-4DF1-8943-2FE8E7D5F309}” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L134 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\ControlPanel\NameSpace\{A8A91A66-3A7D-4424-8D24-04E180695C7A}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Elimină înregistrarea de spațiu de nume Explorer „{A8A91A66-3A7D-4424-8D24-04E180695C7A}” împreună cu subcheile; elementul UI asociat nu este identificat independent. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Removes Explorer namespace registration “{A8A91A66-3A7D-4424-8D24-04E180695C7A}” and its child keys; associated UI item has not been independently identified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L138 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\CLSID\{0DF44EAA-FF21-4412-828E-260A8728E7F1}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{0DF44EAA-FF21-4412-828E-260A8728E7F1}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{0DF44EAA-FF21-4412-828E-260A8728E7F1}” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L140 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\WOW6432Node\CLSID\{0DF44EAA-FF21-4412-828E-260A8728E7F1}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{0DF44EAA-FF21-4412-828E-260A8728E7F1}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{0DF44EAA-FF21-4412-828E-260A8728E7F1}” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L143 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\CLSID\{BD84B380-8CA2-1069-AB1D-08000948F534}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{BD84B380-8CA2-1069-AB1D-08000948F534}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{BD84B380-8CA2-1069-AB1D-08000948F534}” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L145 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\WOW6432Node\CLSID\{BD84B380-8CA2-1069-AB1D-08000948F534}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge înregistrarea COM/shell sau asocierea de interfață „{BD84B380-8CA2-1069-AB1D-08000948F534}” și toate subcheile. Identitatea exactă a obiectului și impactul funcțional nu sunt verificate. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes COM/shell or interface registration “{BD84B380-8CA2-1069-AB1D-08000948F534}” and all child keys. The exact object identity and functional impact are not confirmed. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L148 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Explorer\ControlPanel\NameSpace\{241D7C96-F8BF-4F85-B01F-E2B043341A4B}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Elimină înregistrarea de spațiu de nume Explorer „{241D7C96-F8BF-4F85-B01F-E2B043341A4B}” împreună cu subcheile; elementul UI asociat nu este identificat independent. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Removes Explorer namespace registration “{241D7C96-F8BF-4F85-B01F-E2B043341A4B}” and its child keys; associated UI item has not been independently identified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L150 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\ControlPanel\NameSpace\{241D7C96-F8BF-4F85-B01F-E2B043341A4B}`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Elimină înregistrarea de spațiu de nume Explorer „{241D7C96-F8BF-4F85-B01F-E2B043341A4B}” împreună cu subcheile; elementul UI asociat nu este identificat independent. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Removes Explorer namespace registration “{241D7C96-F8BF-4F85-B01F-E2B043341A4B}” and its child keys; associated UI item has not been independently identified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

### L152 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\ShellIconOverlayIdentifiers\EnhancedStorageShell`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „EnhancedStorageShell” din Explorer și interfața shell, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “EnhancedStorageShell” key in File Explorer and Windows shell, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L154 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\Folder\shell\opennewprocess`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Elimină ramura meniului contextual/shell „opennewprocess”, inclusiv comenzile și subcheile sale; verifică dacă alte extensii depind de aceasta. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Removes context-menu/shell branch “opennewprocess”, including commands and child keys; check whether other extensions depend on it. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Direct shell/COM/WinRT registration deletion is version-specific; final verdict is RETIRED, not unverified.
- **OS support / versiuni:** `7600+`

## Referințe / References

- Raw Registry execution is retired because no supportable cross-version contract was established for the recipe.
