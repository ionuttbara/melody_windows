# Browser Configuration/Firefox.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `08567963d032a4d010d78d88578d05ae60e173d2a04813362cb7d08b42632e4c`
- **Recipe verdict / verdict rețetă:** `CONDITIONAL`
- **Windows container / interval Windows:** `7600+`
- **Runtime prerequisite / condiție runtime:** `browser-firefox`
- **Value/operation descriptions / operații:** 108
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L5 · SET-VALUE · `ShowHomeButton`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Show Home Button” în politicile Mozilla Firefox la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Show Home Button” option in Mozilla Firefox policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L6 · SET-VALUE · `AllowFileSelectionDialogs`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Allow File Selection Dialogs” în politicile Mozilla Firefox la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Allow File Selection Dialogs” option in Mozilla Firefox policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L7 · SET-VALUE · `AppAutoUpdate`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „App Auto Update” în politicile Mozilla Firefox la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “App Auto Update” option in Mozilla Firefox policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L8 · SET-VALUE · `BlockAboutSupport`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Block About Support” în politicile Mozilla Firefox la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Block About Support” option in Mozilla Firefox policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L9 · SET-VALUE · `DisableAppUpdate`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Disable App Update” în politicile Mozilla Firefox la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Disable App Update” option in Mozilla Firefox policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L10 · SET-VALUE · `DisableBuiltinPDFViewer`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Disable Builtin PDFViewer” în politicile Mozilla Firefox la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Disable Builtin PDFViewer” option in Mozilla Firefox policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L11 · SET-VALUE · `DisableFirefoxAccounts`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Disable Firefox Accounts” în politicile Mozilla Firefox la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Disable Firefox Accounts” option in Mozilla Firefox policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L12 · SET-VALUE · `DisableFirefoxScreenshots`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Disable Firefox Screenshots” în politicile Mozilla Firefox la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Disable Firefox Screenshots” option in Mozilla Firefox policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L13 · SET-VALUE · `DisableForgetButton`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Disable Forget Button” în politicile Mozilla Firefox la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Disable Forget Button” option in Mozilla Firefox policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L14 · SET-VALUE · `DisableMasterPasswordCreation`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Disable Master Password Creation” în politicile Mozilla Firefox la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Disable Master Password Creation” option in Mozilla Firefox policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L15 · SET-VALUE · `DisablePocket`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Disable Pocket” în politicile Mozilla Firefox la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Disable Pocket” option in Mozilla Firefox policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L16 · SET-VALUE · `DisableProfileImport`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Disable Profile Import” în politicile Mozilla Firefox la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Disable Profile Import” option in Mozilla Firefox policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L17 · SET-VALUE · `DisableProfileRefresh`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Disable Profile Refresh” în politicile Mozilla Firefox la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Disable Profile Refresh” option in Mozilla Firefox policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L18 · SET-VALUE · `DisableSafeMode`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Disable Safe Mode” în politicile Mozilla Firefox la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Disable Safe Mode” option in Mozilla Firefox policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L19 · SET-VALUE · `DisableSetDesktopBackground`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Disable Set Desktop Background” în politicile Mozilla Firefox la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Disable Set Desktop Background” option in Mozilla Firefox policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L20 · SET-VALUE · `DisableThirdPartyModuleBlocking`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Disable Third Party Module Blocking” în politicile Mozilla Firefox la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Disable Third Party Module Blocking” option in Mozilla Firefox policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L21 · SET-VALUE · `HardwareAcceleration`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Hardware Acceleration” în politicile Mozilla Firefox la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Hardware Acceleration” option in Mozilla Firefox policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L22 · SET-VALUE · `LegacyProfiles`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Legacy Profiles” în politicile Mozilla Firefox la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Legacy Profiles” option in Mozilla Firefox policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L23 · SET-VALUE · `ManualAppUpdateOnly`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Manual App Update Only” în politicile Mozilla Firefox la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Manual App Update Only” option in Mozilla Firefox policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L24 · SET-VALUE · `NewTabPage`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „New Tab Page” în politicile Mozilla Firefox la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “New Tab Page” option in Mozilla Firefox policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L25 · SET-VALUE · `NoDefaultBookmarks`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „No Default Bookmarks” în politicile Mozilla Firefox la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “No Default Bookmarks” option in Mozilla Firefox policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L26 · SET-VALUE · `OfferToSaveLogins`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Offer To Save Logins” în politicile Mozilla Firefox la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Offer To Save Logins” option in Mozilla Firefox policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L27 · SET-VALUE · `UseSystemPrintDialog`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Use System Print Dialog” în politicile Mozilla Firefox la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Use System Print Dialog” option in Mozilla Firefox policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L28 · SET-VALUE · `BackgroundAppUpdate`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Background App Update” în politicile Mozilla Firefox la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Background App Update” option in Mozilla Firefox policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L29 · SET-VALUE · `DisableFeedbackCommands`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Disable Feedback Commands” în politicile Mozilla Firefox la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Disable Feedback Commands” option in Mozilla Firefox policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L30 · SET-VALUE · `DisableTelemetry`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Disable Telemetry” în politicile Mozilla Firefox la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Disable Telemetry” option in Mozilla Firefox policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L31 · SET-VALUE · `SkipTermsOfUse`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Skip Terms Of Use” în politicile Mozilla Firefox la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Skip Terms Of Use” option in Mozilla Firefox policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L32 · SET-VALUE · `NetworkPrediction`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Network Prediction” în politicile Mozilla Firefox la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Network Prediction” option in Mozilla Firefox policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L33 · SET-VALUE · `DontCheckDefaultBrowser`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Dont Check Default Browser” în politicile Mozilla Firefox la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Dont Check Default Browser” option in Mozilla Firefox policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L34 · SET-VALUE · `DisableFirefoxStudies`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Disable Firefox Studies” în politicile Mozilla Firefox la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Disable Firefox Studies” option in Mozilla Firefox policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L37 · SET-VALUE · `Default`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\Cookies`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Default” în politicile Mozilla Firefox la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default” option in Mozilla Firefox policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L40 · SET-VALUE · `SafeBrowsing`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\DisableSecurityBypass`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Safe Browsing” în politicile Mozilla Firefox la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Safe Browsing” option in Mozilla Firefox policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L41 · SET-VALUE · `InvalidCertificate`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\DisableSecurityBypass`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Invalid Certificate” în politicile Mozilla Firefox la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Invalid Certificate” option in Mozilla Firefox policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L44 · SET-VALUE · `Enabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\DNSOverHTTPS`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Enabled” în politicile Mozilla Firefox la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Enabled” option in Mozilla Firefox policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L47 · SET-VALUE · `Cryptomining`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\EnableTrackingProtection`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Cryptomining” în politicile Mozilla Firefox la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Cryptomining” option in Mozilla Firefox policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L48 · SET-VALUE · `Value`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\EnableTrackingProtection`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Value” în politicile Mozilla Firefox la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Value” option in Mozilla Firefox policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L49 · SET-VALUE · `Fingerprinting`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\EnableTrackingProtection`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Fingerprinting” în politicile Mozilla Firefox la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Fingerprinting” option in Mozilla Firefox policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L50 · SET-VALUE · `Locked`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\EnableTrackingProtection`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Locked” în politicile Mozilla Firefox la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Locked” option in Mozilla Firefox policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L51 · SET-VALUE · `EmailTracking`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\EnableTrackingProtection`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Email Tracking” în politicile Mozilla Firefox la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Email Tracking” option in Mozilla Firefox policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L52 · SET-VALUE · `Category`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\EnableTrackingProtection`
- **Raw .reg data:** `"standard"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Category” în politicile Mozilla Firefox la standard (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Category” option in Mozilla Firefox policies to standard (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L53 · SET-VALUE · `SuspectedFingerprinting`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\EnableTrackingProtection`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Suspected Fingerprinting” în politicile Mozilla Firefox la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Suspected Fingerprinting” option in Mozilla Firefox policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L56 · SET-VALUE · `uBlockOrigin@raymondhill.net`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\Extensions`
- **Raw .reg data:** `"https://addons.mozilla.org/firefox/downloads/file/4578681/ublock_origin-1.66.4.xpi"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „u Block Origin@raymondhill.net” în politicile Mozilla Firefox la https://addons.mozilla.org/firefox/downloads/file/4578681/ublock_origin-1.66.4.xpi (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “u Block Origin@raymondhill.net” option in Mozilla Firefox policies to https://addons.mozilla.org/firefox/downloads/file/4578681/ublock_origin-1.66.4.xpi (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L59 · SET-VALUE · `1`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\Extensions\Install`
- **Raw .reg data:** `hex(2):68,00,74,00,74,00,70,00,73,00,3a,00,2f,00,2f,00,61,00,64,00,64,00,6f,00,6e,00,73,00,2e,00,6d,00,6f,00,7a,00,69,00,6c,00,6c,00,61,00,2e,00,6f,00,72,00,67,00,2f,00,65,00,6e,00,2d,00,55,00,53,00,2f,00,66,00,69,00,72,00,65,00,66,00,6f,00,78,00,2f,00,61,00,64,00,64,00,6f,00,6e,00,2f,00,75,00,62,00,6c,00,6f,00,63,00,6b,00,2d,00,6f,00,72,00,69,00,67,00,69,00,6e,00,2f,00,00,00`
- **Type / tip:** `REG_EXPAND_SZ`
- **Ce face / RO:** Configurează opțiunea „1” în politicile Mozilla Firefox la date hexazecimale; de verificat textul extins / hex data, verify expanded text (REG_EXPAND_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “1” option in Mozilla Firefox policies to date hexazecimale; de verificat textul extins / hex data, verify expanded text (REG_EXPAND_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L67 · SET-VALUE · `Search`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\FirefoxHome`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Search” în politicile Mozilla Firefox la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Search” option in Mozilla Firefox policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L68 · SET-VALUE · `TopSites`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\FirefoxHome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Top Sites” în politicile Mozilla Firefox la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Top Sites” option in Mozilla Firefox policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L69 · SET-VALUE · `SponsoredTopSites`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\FirefoxHome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Sponsored Top Sites” în politicile Mozilla Firefox la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Sponsored Top Sites” option in Mozilla Firefox policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L70 · SET-VALUE · `Highlights`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\FirefoxHome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Highlights” în politicile Mozilla Firefox la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Highlights” option in Mozilla Firefox policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L71 · SET-VALUE · `Pocket`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\FirefoxHome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Pocket” în politicile Mozilla Firefox la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Pocket” option in Mozilla Firefox policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L72 · SET-VALUE · `SponsoredPocket`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\FirefoxHome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Sponsored Pocket” în politicile Mozilla Firefox la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Sponsored Pocket” option in Mozilla Firefox policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L73 · SET-VALUE · `Snippets`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\FirefoxHome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Snippets” în politicile Mozilla Firefox la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Snippets” option in Mozilla Firefox policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L74 · SET-VALUE · `Locked`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\FirefoxHome`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Locked” în politicile Mozilla Firefox la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Locked” option in Mozilla Firefox policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L77 · SET-VALUE · `Locked`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\FirefoxSuggest`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Locked” în politicile Mozilla Firefox la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Locked” option in Mozilla Firefox policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L78 · SET-VALUE · `ImproveSuggest`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\FirefoxSuggest`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Improve Suggest” în politicile Mozilla Firefox la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Improve Suggest” option in Mozilla Firefox policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L79 · SET-VALUE · `SponsoredSuggestions`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\FirefoxSuggest`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Sponsored Suggestions” în politicile Mozilla Firefox la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Sponsored Suggestions” option in Mozilla Firefox policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L80 · SET-VALUE · `WebSuggestions`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\FirefoxSuggest`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Web Suggestions” în politicile Mozilla Firefox la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Web Suggestions” option in Mozilla Firefox policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L83 · SET-VALUE · `Default`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\FlashPlugin`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Default” în politicile Mozilla Firefox la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default” option in Mozilla Firefox policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L84 · SET-VALUE · `Locked`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\FlashPlugin`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Locked” în politicile Mozilla Firefox la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Locked” option in Mozilla Firefox policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L87 · SET-VALUE · `StartPage`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\Homepage`
- **Raw .reg data:** `"homepage"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Start Page” în politicile Mozilla Firefox la homepage (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Start Page” option in Mozilla Firefox policies to homepage (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L88 · SET-VALUE · `URL`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\Homepage`
- **Raw .reg data:** `"https://www.google.com"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „URL” în politicile Mozilla Firefox la https://www.google.com (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “URL” option in Mozilla Firefox policies to https://www.google.com (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L89 · SET-VALUE · `Locked`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\Homepage`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Locked” în politicile Mozilla Firefox la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Locked” option in Mozilla Firefox policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L92 · SET-VALUE · `Default`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\InstallAddonsPermission`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Default” în politicile Mozilla Firefox la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default” option in Mozilla Firefox policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L95 · SET-VALUE · `Enabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\PDFjs`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Enabled” în politicile Mozilla Firefox la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Enabled” option in Mozilla Firefox policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L96 · SET-VALUE · `EnablePermissions`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\PDFjs`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Enable Permissions” în politicile Mozilla Firefox la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Enable Permissions” option in Mozilla Firefox policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L101 · SET-VALUE · `BlockNewRequests`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\Permissions\Camera`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Block New Requests” în politicile Mozilla Firefox la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Block New Requests” option in Mozilla Firefox policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L104 · SET-VALUE · `BlockNewRequests`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\Permissions\Location`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Block New Requests” în politicile Mozilla Firefox la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Block New Requests” option in Mozilla Firefox policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L107 · SET-VALUE · `BlockNewRequests`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\Permissions\Microphone`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Block New Requests” în politicile Mozilla Firefox la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Block New Requests” option in Mozilla Firefox policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L110 · SET-VALUE · `Enabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\PictureInPicture`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Enabled” în politicile Mozilla Firefox la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Enabled” option in Mozilla Firefox policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L113 · SET-VALUE · `browser.cache.disk.enable`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\Preferences`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „browser.cache.disk.enable” în politicile Mozilla Firefox la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “browser.cache.disk.enable” option in Mozilla Firefox policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L114 · SET-VALUE · `browser.fixup.dns_first_for_single_words`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\Preferences`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „browser.fixup.dns first for single words” în politicile Mozilla Firefox la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “browser.fixup.dns first for single words” option in Mozilla Firefox policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L115 · SET-VALUE · `browser.safebrowsing.malware.enabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\Preferences`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „browser.safebrowsing.malware.enabled” în politicile Mozilla Firefox la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “browser.safebrowsing.malware.enabled” option in Mozilla Firefox policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L116 · SET-VALUE · `browser.safebrowsing.phishing.enabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\Preferences`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „browser.safebrowsing.phishing.enabled” în politicile Mozilla Firefox la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “browser.safebrowsing.phishing.enabled” option in Mozilla Firefox policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L117 · SET-VALUE · `browser.search.update`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\Preferences`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „browser.search.update” în politicile Mozilla Firefox la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “browser.search.update” option in Mozilla Firefox policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L118 · SET-VALUE · `app.update.auto`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\Preferences`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „app.update.auto” în politicile Mozilla Firefox la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “app.update.auto” option in Mozilla Firefox policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L119 · SET-VALUE · `browser.tabs.warnOnClose`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\Preferences`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „browser.tabs.warn On Close” în politicile Mozilla Firefox la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “browser.tabs.warn On Close” option in Mozilla Firefox policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L120 · SET-VALUE · `browser.taskbar.previews.enable`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\Preferences`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „browser.taskbar.previews.enable” în politicile Mozilla Firefox la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “browser.taskbar.previews.enable” option in Mozilla Firefox policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L121 · SET-VALUE · `datareporting.policy.dataSubmissionPolicyBypassNotification`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\Preferences`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „datareporting.policy.data Submission Policy Bypass Notification” în politicile Mozilla Firefox la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “datareporting.policy.data Submission Policy Bypass Notification” option in Mozilla Firefox policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L122 · SET-VALUE · `dom.disable_window_flip`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\Preferences`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „dom.disable window flip” în politicile Mozilla Firefox la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “dom.disable window flip” option in Mozilla Firefox policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L123 · SET-VALUE · `extensions.htmlaboutaddons.recommendations.enabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\Preferences`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „extensions.htmlaboutaddons.recommendations.enabled” în politicile Mozilla Firefox la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “extensions.htmlaboutaddons.recommendations.enabled” option in Mozilla Firefox policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L124 · SET-VALUE · `geo.enabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\Preferences`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „geo.enabled” în politicile Mozilla Firefox la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “geo.enabled” option in Mozilla Firefox policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L125 · SET-VALUE · `security.ssl.errorReporting.enabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\Preferences`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „security.ssl.error Reporting.enabled” în politicile Mozilla Firefox la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “security.ssl.error Reporting.enabled” option in Mozilla Firefox policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L126 · SET-VALUE · `browser.tabs.groups.smart.enabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\Preferences`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „browser.tabs.groups.smart.enabled” în politicile Mozilla Firefox la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “browser.tabs.groups.smart.enabled” option in Mozilla Firefox policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L127 · SET-VALUE · `layout.spellcheckDefault`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\Preferences`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „layout.spellcheck Default” în politicile Mozilla Firefox la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “layout.spellcheck Default” option in Mozilla Firefox policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L128 · SET-VALUE · `browser.search.showTrending`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\Preferences`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „browser.search.show Trending” în politicile Mozilla Firefox la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “browser.search.show Trending” option in Mozilla Firefox policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L129 · SET-VALUE · `network.trr.mode`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\Preferences`
- **Raw .reg data:** `dword:00000005`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „network.trr.mode” în politicile Mozilla Firefox la 5 (0x00000005) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “network.trr.mode” option in Mozilla Firefox policies to 5 (0x00000005) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L130 · SET-VALUE · `browser.newtabpage.activity-stream.feeds.telemetry`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\Preferences`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „browser.newtabpage.activity stream.feeds.telemetry” în politicile Mozilla Firefox la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “browser.newtabpage.activity stream.feeds.telemetry” option in Mozilla Firefox policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L131 · SET-VALUE · `browser.newtabpage.activity-stream.telemetry`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\Preferences`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „browser.newtabpage.activity stream.telemetry” în politicile Mozilla Firefox la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “browser.newtabpage.activity stream.telemetry” option in Mozilla Firefox policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L132 · SET-VALUE · `nimbus.telemetry.targetingContextEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\Preferences`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „nimbus.telemetry.targeting Context Enabled” în politicile Mozilla Firefox la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “nimbus.telemetry.targeting Context Enabled” option in Mozilla Firefox policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L133 · SET-VALUE · `toolkit.telemetry.shutdownPingSender.enabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\Preferences`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „toolkit.telemetry.shutdown Ping Sender.enabled” în politicile Mozilla Firefox la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “toolkit.telemetry.shutdown Ping Sender.enabled” option in Mozilla Firefox policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L134 · SET-VALUE · `toolkit.telemetry.server`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\Preferences`
- **Raw .reg data:** `"0"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „toolkit.telemetry.server” în politicile Mozilla Firefox la 0 (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “toolkit.telemetry.server” option in Mozilla Firefox policies to 0 (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L135 · SET-VALUE · `toolkit.telemetry.newProfilePing.enabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\Preferences`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „toolkit.telemetry.new Profile Ping.enabled” în politicile Mozilla Firefox la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “toolkit.telemetry.new Profile Ping.enabled” option in Mozilla Firefox policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L136 · SET-VALUE · `toolkit.telemetry.firstShutdownPing.enabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\Preferences`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „toolkit.telemetry.first Shutdown Ping.enabled” în politicile Mozilla Firefox la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “toolkit.telemetry.first Shutdown Ping.enabled” option in Mozilla Firefox policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L137 · SET-VALUE · `toolkit.telemetry.dap.helper.url`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\Preferences`
- **Raw .reg data:** `"0"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „toolkit.telemetry.dap.helper.url” în politicile Mozilla Firefox la 0 (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “toolkit.telemetry.dap.helper.url” option in Mozilla Firefox policies to 0 (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L140 · SET-VALUE · `Cache`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\SanitizeOnShutdown`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Cache” în politicile Mozilla Firefox la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Cache” option in Mozilla Firefox policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L141 · SET-VALUE · `OfflineApps`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\SanitizeOnShutdown`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Offline Apps” în politicile Mozilla Firefox la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Offline Apps” option in Mozilla Firefox policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L144 · SET-VALUE · `Locked`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\UserMessaging`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Locked” în politicile Mozilla Firefox la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Locked” option in Mozilla Firefox policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L145 · SET-VALUE · `UrlbarInterventions`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\UserMessaging`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Urlbar Interventions” în politicile Mozilla Firefox la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Urlbar Interventions” option in Mozilla Firefox policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L146 · SET-VALUE · `WhatsNew`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\UserMessaging`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Whats New” în politicile Mozilla Firefox la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Whats New” option in Mozilla Firefox policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L147 · SET-VALUE · `ExtensionRecommendations`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\UserMessaging`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Extension Recommendations” în politicile Mozilla Firefox la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Extension Recommendations” option in Mozilla Firefox policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L148 · SET-VALUE · `FeatureRecommendations`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\UserMessaging`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Feature Recommendations” în politicile Mozilla Firefox la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Feature Recommendations” option in Mozilla Firefox policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L149 · SET-VALUE · `FirefoxLabs`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\UserMessaging`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Firefox Labs” în politicile Mozilla Firefox la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Firefox Labs” option in Mozilla Firefox policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L150 · SET-VALUE · `MoreFromMozilla`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\UserMessaging`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „More From Mozilla” în politicile Mozilla Firefox la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “More From Mozilla” option in Mozilla Firefox policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L151 · SET-VALUE · `SkipOnboarding`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\UserMessaging`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Skip Onboarding” în politicile Mozilla Firefox la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Skip Onboarding” option in Mozilla Firefox policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L155 · SET-VALUE · `DisableTelemetry`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Disable Telemetry” în politicile Mozilla Firefox la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Disable Telemetry” option in Mozilla Firefox policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L156 · SET-VALUE · `DataSubmissionEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Data Submission Enabled” în politicile Mozilla Firefox la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Data Submission Enabled” option in Mozilla Firefox policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L157 · SET-VALUE · `DisableAppUpdate`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Disable App Update” în politicile Mozilla Firefox la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Disable App Update” option in Mozilla Firefox policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L158 · SET-VALUE · `Updates`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Updates” în politicile Mozilla Firefox la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Updates” option in Mozilla Firefox policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L159 · SET-VALUE · `UpdateAutoConfigURL`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox`
- **Raw .reg data:** `""`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Update Auto Config URL” în politicile Mozilla Firefox la (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Update Auto Config URL” option in Mozilla Firefox policies to (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

### L162 · SET-VALUE · `1`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Mozilla\Firefox\Extensions\Install`
- **Raw .reg data:** `"https://addons.mozilla.org/firefox/addon/ublock-origin/"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „1” în politicile Mozilla Firefox la https://addons.mozilla.org/firefox/addon/ublock-origin/ (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “1” option in Mozilla Firefox policies to https://addons.mozilla.org/firefox/addon/ublock-origin/ (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Firefox enterprise policy; only when Firefox is installed and policy template supports the value.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://mozilla.github.io/policy-templates/`

## Referințe / References

- https://mozilla.github.io/policy-templates/
