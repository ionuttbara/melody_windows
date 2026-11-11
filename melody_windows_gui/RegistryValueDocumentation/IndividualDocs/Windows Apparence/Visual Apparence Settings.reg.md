# Windows Apparence/Visual Apparence Settings.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `4e71c655eb6ba4b2ac1a927596aa8fc537351aaf6feb730e246fe13bc9f7469e`
- **Recipe verdict / verdict rețetă:** `CONDITIONAL`
- **Windows container / interval Windows:** `7600+`
- **Runtime prerequisite / condiție runtime:** `existing-key`
- **Value/operation descriptions / operații:** 15
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L6 · SET-VALUE · `DragFullWindows`

- **Registry key:** `HKEY_USERS\.DEFAULT\Control Panel\Desktop`
- **Raw .reg data:** `"1"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Drag Full Windows” în opțiunile desktopului la 1 (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Drag Full Windows” option in desktop settings to 1 (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L7 · SET-VALUE · `FontSmoothing`

- **Registry key:** `HKEY_USERS\.DEFAULT\Control Panel\Desktop`
- **Raw .reg data:** `"2"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Font Smoothing” în opțiunile desktopului la 2 (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Font Smoothing” option in desktop settings to 2 (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L8 · SET-VALUE · `FontSmoothingType`

- **Registry key:** `HKEY_USERS\.DEFAULT\Control Panel\Desktop`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Font Smoothing Type” în opțiunile desktopului la 2 (0x00000002) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Font Smoothing Type” option in desktop settings to 2 (0x00000002) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L9 · SET-VALUE · `UserPreferencesMask`

- **Registry key:** `HKEY_USERS\.DEFAULT\Control Panel\Desktop`
- **Raw .reg data:** `hex:90,12,01,80,10,00,00,00`
- **Type / tip:** `REG_BINARY`
- **Ce face / RO:** Configurează opțiunea „User Preferences Mask” în opțiunile desktopului la date binare / binary bytes (REG_BINARY). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “User Preferences Mask” option in desktop settings to date binare / binary bytes (REG_BINARY). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L10 · SET-VALUE · `RestorePreviousStateRecalcBehavior`

- **Registry key:** `HKEY_USERS\.DEFAULT\Control Panel\Desktop`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Restore Previous State Recalc Behavior” în opțiunile desktopului la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Restore Previous State Recalc Behavior” option in desktop settings to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L13 · SET-VALUE · `DragFullWindows`

- **Registry key:** `HKEY_CURRENT_USER\Control Panel\Desktop`
- **Raw .reg data:** `"1"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Drag Full Windows” în opțiunile desktopului la 1 (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Drag Full Windows” option in desktop settings to 1 (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L14 · SET-VALUE · `FontSmoothing`

- **Registry key:** `HKEY_CURRENT_USER\Control Panel\Desktop`
- **Raw .reg data:** `"2"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Font Smoothing” în opțiunile desktopului la 2 (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Font Smoothing” option in desktop settings to 2 (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L15 · SET-VALUE · `FontSmoothingType`

- **Registry key:** `HKEY_CURRENT_USER\Control Panel\Desktop`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Font Smoothing Type” în opțiunile desktopului la 2 (0x00000002) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Font Smoothing Type” option in desktop settings to 2 (0x00000002) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L16 · SET-VALUE · `UserPreferencesMask`

- **Registry key:** `HKEY_CURRENT_USER\Control Panel\Desktop`
- **Raw .reg data:** `hex:98,12,03,80,10,00,00,00`
- **Type / tip:** `REG_BINARY`
- **Ce face / RO:** Configurează opțiunea „User Preferences Mask” în opțiunile desktopului la date binare / binary bytes (REG_BINARY). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “User Preferences Mask” option in desktop settings to date binare / binary bytes (REG_BINARY). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L17 · SET-VALUE · `MouseWheelRouting`

- **Registry key:** `HKEY_CURRENT_USER\Control Panel\Desktop`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Mouse Wheel Routing” în opțiunile desktopului la 2 (0x00000002) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Mouse Wheel Routing” option in desktop settings to 2 (0x00000002) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L18 · SET-VALUE · `RestorePreviousStateRecalcBehavior`

- **Registry key:** `HKEY_CURRENT_USER\Control Panel\Desktop`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Restore Previous State Recalc Behavior” în opțiunile desktopului la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Restore Previous State Recalc Behavior” option in desktop settings to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L21 · SET-VALUE · `VisualFxSetting`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\VisualEffects`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Visual Fx Setting” în Explorer și interfața shell la 3 (0x00000003) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Visual Fx Setting” option in File Explorer and Windows shell to 3 (0x00000003) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L24 · SET-VALUE · `VisualFxSetting`

- **Registry key:** `HKEY_USERS\.DEFAULT\Software\Microsoft\Windows\CurrentVersion\Explorer\VisualEffects`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Visual Fx Setting” în Explorer și interfața shell la 3 (0x00000003) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Visual Fx Setting” option in File Explorer and Windows shell to 3 (0x00000003) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L27 · SET-VALUE · `DefaultDropEffect`

- **Registry key:** `HKEY_CLASSES_ROOT\*`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Default Drop Effect” în asocierile de fișiere sau integrarea shell/COM la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Drop Effect” option in file associations or shell/COM integration to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L30 · SET-VALUE · `DefaultDropEffect`

- **Registry key:** `HKEY_CLASSES_ROOT\AllFilesystemObjects`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Default Drop Effect” în asocierile de fișiere sau integrarea shell/COM la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Drop Effect” option in file associations or shell/COM integration to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

## Referințe / References

- No exact vendor URL is attached. The final runtime rule requires the exact live Registry target to exist before Melody enables the recipe.
