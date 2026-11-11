# Devices/Precision TouchPad Settings.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `d726c88cacfe0dbac92fad0c14447063399fb3c0c577dd1407a16ce4bf44f0e2`
- **Recipe verdict / verdict rețetă:** `CONDITIONAL`
- **Windows container / interval Windows:** `7600+`
- **Runtime prerequisite / condiție runtime:** `existing-key`
- **Value/operation descriptions / operații:** 18
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L4 · SET-VALUE · `AAPThreshold`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\PrecisionTouchPad`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „AAPThreshold” în ramura Microsoft / Windows / CurrentVersion la 2 (0x00000002) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “AAPThreshold” option in registry branch Microsoft / Windows / CurrentVersion to 2 (0x00000002) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L5 · SET-VALUE · `CursorSpeed`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\PrecisionTouchPad`
- **Raw .reg data:** `dword:0000000a`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Cursor Speed” în ramura Microsoft / Windows / CurrentVersion la 10 (0x0000000A) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Cursor Speed” option in registry branch Microsoft / Windows / CurrentVersion to 10 (0x0000000A) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L6 · SET-VALUE · `EnableEdgy`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\PrecisionTouchPad`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Enable Edgy” în ramura Microsoft / Windows / CurrentVersion la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Enable Edgy” option in registry branch Microsoft / Windows / CurrentVersion to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L7 · SET-VALUE · `LeaveOnWithMouse`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\PrecisionTouchPad`
- **Raw .reg data:** `dword:ffffffff`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Leave On With Mouse” în ramura Microsoft / Windows / CurrentVersion la 4294967295 (0xFFFFFFFF) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Leave On With Mouse” option in registry branch Microsoft / Windows / CurrentVersion to 4294967295 (0xFFFFFFFF) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L8 · SET-VALUE · `PanEnabled`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\PrecisionTouchPad`
- **Raw .reg data:** `dword:ffffffff`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Pan Enabled” în ramura Microsoft / Windows / CurrentVersion la 4294967295 (0xFFFFFFFF) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Pan Enabled” option in registry branch Microsoft / Windows / CurrentVersion to 4294967295 (0xFFFFFFFF) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L9 · SET-VALUE · `ScrollDirection`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\PrecisionTouchPad`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Scroll Direction” în ramura Microsoft / Windows / CurrentVersion la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Scroll Direction” option in registry branch Microsoft / Windows / CurrentVersion to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L10 · SET-VALUE · `ZoomEnabled`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\PrecisionTouchPad`
- **Raw .reg data:** `dword:ffffffff`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Zoom Enabled” în ramura Microsoft / Windows / CurrentVersion la 4294967295 (0xFFFFFFFF) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Zoom Enabled” option in registry branch Microsoft / Windows / CurrentVersion to 4294967295 (0xFFFFFFFF) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L11 · SET-VALUE · `ThreeFingerTapEnabled`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\PrecisionTouchPad`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Three Finger Tap Enabled” în ramura Microsoft / Windows / CurrentVersion la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Three Finger Tap Enabled” option in registry branch Microsoft / Windows / CurrentVersion to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L12 · SET-VALUE · `FourFingerSlideEnabled`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\PrecisionTouchPad`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Four Finger Slide Enabled” în ramura Microsoft / Windows / CurrentVersion la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Four Finger Slide Enabled” option in registry branch Microsoft / Windows / CurrentVersion to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L13 · SET-VALUE · `FourFingerTapEnabled`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\PrecisionTouchPad`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Four Finger Tap Enabled” în ramura Microsoft / Windows / CurrentVersion la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Four Finger Tap Enabled” option in registry branch Microsoft / Windows / CurrentVersion to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L14 · SET-VALUE · `ThreeFingerSlideEnabled`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\PrecisionTouchPad`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Three Finger Slide Enabled” în ramura Microsoft / Windows / CurrentVersion la 2 (0x00000002) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Three Finger Slide Enabled” option in registry branch Microsoft / Windows / CurrentVersion to 2 (0x00000002) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L15 · SET-VALUE · `FeedbackIntensity`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\PrecisionTouchPad`
- **Raw .reg data:** `dword:00000032`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Feedback Intensity” în ramura Microsoft / Windows / CurrentVersion la 50 (0x00000032) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Feedback Intensity” option in registry branch Microsoft / Windows / CurrentVersion to 50 (0x00000032) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L16 · SET-VALUE · `ClickForceSensitivity`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\PrecisionTouchPad`
- **Raw .reg data:** `dword:00000032`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Click Force Sensitivity” în ramura Microsoft / Windows / CurrentVersion la 50 (0x00000032) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Click Force Sensitivity” option in registry branch Microsoft / Windows / CurrentVersion to 50 (0x00000032) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L17 · SET-VALUE · `FeedbackEnabled`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\PrecisionTouchPad`
- **Raw .reg data:** `dword:ffffffff`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Feedback Enabled” în ramura Microsoft / Windows / CurrentVersion la 4294967295 (0xFFFFFFFF) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Feedback Enabled” option in registry branch Microsoft / Windows / CurrentVersion to 4294967295 (0xFFFFFFFF) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L18 · SET-VALUE · `HonorMouseAccelSetting`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\PrecisionTouchPad`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Honor Mouse Accel Setting” în ramura Microsoft / Windows / CurrentVersion la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Honor Mouse Accel Setting” option in registry branch Microsoft / Windows / CurrentVersion to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L19 · SET-VALUE · `RightClickZoneWidth`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\PrecisionTouchPad`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Right Click Zone Width” în ramura Microsoft / Windows / CurrentVersion la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Right Click Zone Width” option in registry branch Microsoft / Windows / CurrentVersion to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L20 · SET-VALUE · `RightClickZoneHeight`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\PrecisionTouchPad`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Right Click Zone Height” în ramura Microsoft / Windows / CurrentVersion la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Right Click Zone Height” option in registry branch Microsoft / Windows / CurrentVersion to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L23 · SET-VALUE · `Enabled`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\PrecisionTouchPad\Status`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Enabled” în ramura Microsoft / Windows / CurrentVersion la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Enabled” option in registry branch Microsoft / Windows / CurrentVersion to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

## Referințe / References

- No exact vendor URL is attached. The final runtime rule requires the exact live Registry target to exist before Melody enables the recipe.
