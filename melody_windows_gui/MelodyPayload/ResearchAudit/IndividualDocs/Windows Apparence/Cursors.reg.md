# Windows Apparence/Cursors.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `c7615d5484d5dddddd76f679ca80a97c4a6af337af4abe53e3518096ab34997a`
- **Recipe verdict / verdict rețetă:** `CONDITIONAL`
- **Windows container / interval Windows:** `7600+`
- **Runtime prerequisite / condiție runtime:** `existing-key`
- **Value/operation descriptions / operații:** 18
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L4 · SET-VALUE · `AppStarting`

- **Registry key:** `HKEY_CURRENT_USER\Control Panel\Cursors`
- **Raw .reg data:** `hex(2):00,00`
- **Type / tip:** `REG_EXPAND_SZ`
- **Ce face / RO:** Configurează opțiunea „App Starting” în cursorul mouse-ului la date hexazecimale; de verificat textul extins / hex data, verify expanded text (REG_EXPAND_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “App Starting” option in mouse cursor configuration to date hexazecimale; de verificat textul extins / hex data, verify expanded text (REG_EXPAND_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Legacy Windows setting; only existing keys/values are changed on the detected system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/sysinfo/registry`

### L5 · SET-VALUE · `Arrow`

- **Registry key:** `HKEY_CURRENT_USER\Control Panel\Cursors`
- **Raw .reg data:** `hex(2):00,00`
- **Type / tip:** `REG_EXPAND_SZ`
- **Ce face / RO:** Configurează opțiunea „Arrow” în cursorul mouse-ului la date hexazecimale; de verificat textul extins / hex data, verify expanded text (REG_EXPAND_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Arrow” option in mouse cursor configuration to date hexazecimale; de verificat textul extins / hex data, verify expanded text (REG_EXPAND_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Legacy Windows setting; only existing keys/values are changed on the detected system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/sysinfo/registry`

### L6 · SET-VALUE · `ContactVisualization`

- **Registry key:** `HKEY_CURRENT_USER\Control Panel\Cursors`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Contact Visualization” în cursorul mouse-ului la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Contact Visualization” option in mouse cursor configuration to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Legacy Windows setting; only existing keys/values are changed on the detected system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/sysinfo/registry`

### L7 · SET-VALUE · `Crosshair`

- **Registry key:** `HKEY_CURRENT_USER\Control Panel\Cursors`
- **Raw .reg data:** `""`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Crosshair” în cursorul mouse-ului la (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Crosshair” option in mouse cursor configuration to (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Legacy Windows setting; only existing keys/values are changed on the detected system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/sysinfo/registry`

### L8 · SET-VALUE · `GestureVisualization`

- **Registry key:** `HKEY_CURRENT_USER\Control Panel\Cursors`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Gesture Visualization” în cursorul mouse-ului la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Gesture Visualization” option in mouse cursor configuration to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Legacy Windows setting; only existing keys/values are changed on the detected system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/sysinfo/registry`

### L9 · SET-VALUE · `Hand`

- **Registry key:** `HKEY_CURRENT_USER\Control Panel\Cursors`
- **Raw .reg data:** `hex(2):00,00`
- **Type / tip:** `REG_EXPAND_SZ`
- **Ce face / RO:** Configurează opțiunea „Hand” în cursorul mouse-ului la date hexazecimale; de verificat textul extins / hex data, verify expanded text (REG_EXPAND_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Hand” option in mouse cursor configuration to date hexazecimale; de verificat textul extins / hex data, verify expanded text (REG_EXPAND_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Legacy Windows setting; only existing keys/values are changed on the detected system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/sysinfo/registry`

### L10 · SET-VALUE · `Help`

- **Registry key:** `HKEY_CURRENT_USER\Control Panel\Cursors`
- **Raw .reg data:** `hex(2):00,00`
- **Type / tip:** `REG_EXPAND_SZ`
- **Ce face / RO:** Configurează opțiunea „Help” în cursorul mouse-ului la date hexazecimale; de verificat textul extins / hex data, verify expanded text (REG_EXPAND_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Help” option in mouse cursor configuration to date hexazecimale; de verificat textul extins / hex data, verify expanded text (REG_EXPAND_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Legacy Windows setting; only existing keys/values are changed on the detected system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/sysinfo/registry`

### L11 · SET-VALUE · `IBeam`

- **Registry key:** `HKEY_CURRENT_USER\Control Panel\Cursors`
- **Raw .reg data:** `""`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „IBeam” în cursorul mouse-ului la (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “IBeam” option in mouse cursor configuration to (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Legacy Windows setting; only existing keys/values are changed on the detected system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/sysinfo/registry`

### L12 · SET-VALUE · `No`

- **Registry key:** `HKEY_CURRENT_USER\Control Panel\Cursors`
- **Raw .reg data:** `hex(2):00,00`
- **Type / tip:** `REG_EXPAND_SZ`
- **Ce face / RO:** Configurează opțiunea „No” în cursorul mouse-ului la date hexazecimale; de verificat textul extins / hex data, verify expanded text (REG_EXPAND_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “No” option in mouse cursor configuration to date hexazecimale; de verificat textul extins / hex data, verify expanded text (REG_EXPAND_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Legacy Windows setting; only existing keys/values are changed on the detected system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/sysinfo/registry`

### L13 · SET-VALUE · `NWPen`

- **Registry key:** `HKEY_CURRENT_USER\Control Panel\Cursors`
- **Raw .reg data:** `hex(2):00,00`
- **Type / tip:** `REG_EXPAND_SZ`
- **Ce face / RO:** Configurează opțiunea „NWPen” în cursorul mouse-ului la date hexazecimale; de verificat textul extins / hex data, verify expanded text (REG_EXPAND_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “NWPen” option in mouse cursor configuration to date hexazecimale; de verificat textul extins / hex data, verify expanded text (REG_EXPAND_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Legacy Windows setting; only existing keys/values are changed on the detected system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/sysinfo/registry`

### L14 · SET-VALUE · `Scheme Source`

- **Registry key:** `HKEY_CURRENT_USER\Control Panel\Cursors`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Scheme Source” în cursorul mouse-ului la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Scheme Source” option in mouse cursor configuration to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Legacy Windows setting; only existing keys/values are changed on the detected system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/sysinfo/registry`

### L15 · SET-VALUE · `SizeAll`

- **Registry key:** `HKEY_CURRENT_USER\Control Panel\Cursors`
- **Raw .reg data:** `hex(2):00,00`
- **Type / tip:** `REG_EXPAND_SZ`
- **Ce face / RO:** Configurează opțiunea „Size All” în cursorul mouse-ului la date hexazecimale; de verificat textul extins / hex data, verify expanded text (REG_EXPAND_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Size All” option in mouse cursor configuration to date hexazecimale; de verificat textul extins / hex data, verify expanded text (REG_EXPAND_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Legacy Windows setting; only existing keys/values are changed on the detected system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/sysinfo/registry`

### L16 · SET-VALUE · `SizeNESW`

- **Registry key:** `HKEY_CURRENT_USER\Control Panel\Cursors`
- **Raw .reg data:** `hex(2):00,00`
- **Type / tip:** `REG_EXPAND_SZ`
- **Ce face / RO:** Configurează opțiunea „Size NESW” în cursorul mouse-ului la date hexazecimale; de verificat textul extins / hex data, verify expanded text (REG_EXPAND_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Size NESW” option in mouse cursor configuration to date hexazecimale; de verificat textul extins / hex data, verify expanded text (REG_EXPAND_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Legacy Windows setting; only existing keys/values are changed on the detected system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/sysinfo/registry`

### L17 · SET-VALUE · `SizeNS`

- **Registry key:** `HKEY_CURRENT_USER\Control Panel\Cursors`
- **Raw .reg data:** `hex(2):00,00`
- **Type / tip:** `REG_EXPAND_SZ`
- **Ce face / RO:** Configurează opțiunea „Size NS” în cursorul mouse-ului la date hexazecimale; de verificat textul extins / hex data, verify expanded text (REG_EXPAND_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Size NS” option in mouse cursor configuration to date hexazecimale; de verificat textul extins / hex data, verify expanded text (REG_EXPAND_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Legacy Windows setting; only existing keys/values are changed on the detected system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/sysinfo/registry`

### L18 · SET-VALUE · `SizeNWSE`

- **Registry key:** `HKEY_CURRENT_USER\Control Panel\Cursors`
- **Raw .reg data:** `hex(2):00,00`
- **Type / tip:** `REG_EXPAND_SZ`
- **Ce face / RO:** Configurează opțiunea „Size NWSE” în cursorul mouse-ului la date hexazecimale; de verificat textul extins / hex data, verify expanded text (REG_EXPAND_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Size NWSE” option in mouse cursor configuration to date hexazecimale; de verificat textul extins / hex data, verify expanded text (REG_EXPAND_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Legacy Windows setting; only existing keys/values are changed on the detected system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/sysinfo/registry`

### L19 · SET-VALUE · `SizeWE`

- **Registry key:** `HKEY_CURRENT_USER\Control Panel\Cursors`
- **Raw .reg data:** `hex(2):00,00`
- **Type / tip:** `REG_EXPAND_SZ`
- **Ce face / RO:** Configurează opțiunea „Size WE” în cursorul mouse-ului la date hexazecimale; de verificat textul extins / hex data, verify expanded text (REG_EXPAND_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Size WE” option in mouse cursor configuration to date hexazecimale; de verificat textul extins / hex data, verify expanded text (REG_EXPAND_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Legacy Windows setting; only existing keys/values are changed on the detected system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/sysinfo/registry`

### L20 · SET-VALUE · `UpArrow`

- **Registry key:** `HKEY_CURRENT_USER\Control Panel\Cursors`
- **Raw .reg data:** `hex(2):00,00`
- **Type / tip:** `REG_EXPAND_SZ`
- **Ce face / RO:** Configurează opțiunea „Up Arrow” în cursorul mouse-ului la date hexazecimale; de verificat textul extins / hex data, verify expanded text (REG_EXPAND_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Up Arrow” option in mouse cursor configuration to date hexazecimale; de verificat textul extins / hex data, verify expanded text (REG_EXPAND_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Legacy Windows setting; only existing keys/values are changed on the detected system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/sysinfo/registry`

### L21 · SET-VALUE · `Wait`

- **Registry key:** `HKEY_CURRENT_USER\Control Panel\Cursors`
- **Raw .reg data:** `hex(2):00,00`
- **Type / tip:** `REG_EXPAND_SZ`
- **Ce face / RO:** Configurează opțiunea „Wait” în cursorul mouse-ului la date hexazecimale; de verificat textul extins / hex data, verify expanded text (REG_EXPAND_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Wait” option in mouse cursor configuration to date hexazecimale; de verificat textul extins / hex data, verify expanded text (REG_EXPAND_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Legacy Windows setting; only existing keys/values are changed on the detected system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/sysinfo/registry`

## Referințe / References

- https://learn.microsoft.com/en-us/windows/win32/sysinfo/registry
