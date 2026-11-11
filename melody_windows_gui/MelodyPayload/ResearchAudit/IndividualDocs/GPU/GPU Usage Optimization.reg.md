# GPU/GPU Usage Optimization.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `7da31201c6c848566c40b9a5c56174f98f81e93fff9e5060ef6d0374094d7b12`
- **Recipe verdict / verdict rețetă:** `CONDITIONAL`
- **Windows container / interval Windows:** `17134+`
- **Runtime prerequisite / condiție runtime:** `existing-exe`
- **Value/operation descriptions / operații:** 573
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L4 · SET-VALUE · `C:\\Windows\\System32\\WindowsPowerShell\\v1.0\\powershell.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"AutoHDREnable=0;GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\WindowsPowerShell\\v1.0\\powershell.exe” cu datele AutoHDREnable=0;GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\WindowsPowerShell\\v1.0\\powershell.exe”: AutoHDREnable=0;GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L5 · SET-VALUE · `C:\\Windows\\System32\\rundll32.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\rundll32.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\rundll32.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L6 · SET-VALUE · `C:\\Windows\\System32\\bdeunlock.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\bdeunlock.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\bdeunlock.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L7 · SET-VALUE · `C:\\Windows\\System32\\bdechangepin.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\bdechangepin.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\bdechangepin.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L8 · SET-VALUE · `C:\\Windows\\System32\\ClipDLS.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\ClipDLS.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\ClipDLS.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L9 · SET-VALUE · `C:\\Windows\\System32\\ScriptRunner.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\ScriptRunner.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\ScriptRunner.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L10 · SET-VALUE · `C:\\Windows\\System32\\ApplySettingsTemplateCatalog.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\ApplySettingsTemplateCatalog.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\ApplySettingsTemplateCatalog.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L11 · SET-VALUE · `C:\\Windows\\System32\\Microsoft.Uev.CscUnpinTool.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\Microsoft.Uev.CscUnpinTool.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\Microsoft.Uev.CscUnpinTool.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L12 · SET-VALUE · `C:\\Windows\\System32\\UevAppMonitor.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\UevAppMonitor.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\UevAppMonitor.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L13 · SET-VALUE · `C:\\Windows\\System32\\Microsoft.Uev.SyncController.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\Microsoft.Uev.SyncController.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\Microsoft.Uev.SyncController.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L14 · SET-VALUE · `C:\\Windows\\System32\\chgport.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\chgport.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\chgport.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L15 · SET-VALUE · `C:\\Windows\\System32\\chgusr.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\chgusr.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\chgusr.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L16 · SET-VALUE · `C:\\Windows\\System32\\query.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\query.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\query.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L17 · SET-VALUE · `C:\\Windows\\System32\\logoff.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\logoff.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\logoff.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L18 · SET-VALUE · `C:\\Windows\\System32\\qappsrv.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\qappsrv.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\qappsrv.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L19 · SET-VALUE · `C:\\Windows\\System32\\qprocess.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\qprocess.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\qprocess.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L20 · SET-VALUE · `C:\\Windows\\System32\\reset.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\reset.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\reset.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L21 · SET-VALUE · `C:\\Windows\\System32\\rwinsta.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\rwinsta.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\rwinsta.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L22 · SET-VALUE · `C:\\Windows\\System32\\tscon.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\tscon.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\tscon.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L23 · SET-VALUE · `C:\\Windows\\System32\\tsdiscon.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\tsdiscon.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\tsdiscon.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L24 · SET-VALUE · `C:\\Windows\\System32\\tskill.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\tskill.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\tskill.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L25 · SET-VALUE · `C:\\Windows\\System32\\msg.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\msg.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\msg.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L26 · SET-VALUE · `C:\\Windows\\System32\\quser.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\quser.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\quser.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L27 · SET-VALUE · `C:\\Windows\\System32\\qwinsta.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\qwinsta.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\qwinsta.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L28 · SET-VALUE · `C:\\Windows\\System32\\baaupdate.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\baaupdate.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\baaupdate.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L29 · SET-VALUE · `C:\\Windows\\System32\\logagent.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\logagent.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\logagent.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L30 · SET-VALUE · `C:\\Windows\\System32\\mfpmp.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\mfpmp.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\mfpmp.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L31 · SET-VALUE · `C:\\Windows\\System32\\PackageInspector.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\PackageInspector.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\PackageInspector.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L32 · SET-VALUE · `C:\\Windows\\System32\\manage-bde.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\manage-bde.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\manage-bde.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L33 · SET-VALUE · `C:\\Windows\\System32\\PresentationSettings.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\PresentationSettings.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\PresentationSettings.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L34 · SET-VALUE · `C:\\Windows\\System32\\AgentService.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\AgentService.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\AgentService.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L35 · SET-VALUE · `C:\\Windows\\System32\\repair-bde.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\repair-bde.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\repair-bde.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L36 · SET-VALUE · `C:\\Windows\\System32\\ClipRenew.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\ClipRenew.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\ClipRenew.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L37 · SET-VALUE · `C:\\Windows\\System32\\gpscript.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\gpscript.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\gpscript.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L38 · SET-VALUE · `C:\\Windows\\System32\\CustomShellHost.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\CustomShellHost.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\CustomShellHost.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L39 · SET-VALUE · `C:\\Windows\\System32\\AssignedAccessGuard.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\AssignedAccessGuard.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\AssignedAccessGuard.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L40 · SET-VALUE · `C:\\Windows\\System32\\mavinject.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\mavinject.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\mavinject.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L41 · SET-VALUE · `C:\\Windows\\System32\\BitLockerDeviceEncryption.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\BitLockerDeviceEncryption.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\BitLockerDeviceEncryption.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L42 · SET-VALUE · `C:\\Windows\\System32\\rdpinit.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\rdpinit.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\rdpinit.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L43 · SET-VALUE · `C:\\Windows\\System32\\rdpshell.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\rdpshell.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\rdpshell.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L44 · SET-VALUE · `C:\\Windows\\System32\\AppVClient.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\AppVClient.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\AppVClient.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L45 · SET-VALUE · `C:\\Windows\\System32\\BdeHdCfg.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\BdeHdCfg.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\BdeHdCfg.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L46 · SET-VALUE · `C:\\Windows\\System32\\CameraSettingsUIHost.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\CameraSettingsUIHost.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\CameraSettingsUIHost.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L47 · SET-VALUE · `C:\\Windows\\System32\\RemoteAppLifetimeManager.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\RemoteAppLifetimeManager.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\RemoteAppLifetimeManager.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L48 · SET-VALUE · `C:\\Windows\\System32\\rdpsign.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\rdpsign.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\rdpsign.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L49 · SET-VALUE · `C:\\Windows\\System32\\fveprompt.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\fveprompt.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\fveprompt.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L50 · SET-VALUE · `C:\\Windows\\System32\\iotstartup.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\iotstartup.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\iotstartup.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L51 · SET-VALUE · `C:\\Windows\\System32\\fvenotify.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\fvenotify.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\fvenotify.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L52 · SET-VALUE · `C:\\Windows\\System32\\WPDShextAutoplay.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\WPDShextAutoplay.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\WPDShextAutoplay.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L53 · SET-VALUE · `C:\\Windows\\System32\\BdeUISrv.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\BdeUISrv.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\BdeUISrv.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L54 · SET-VALUE · `C:\\Windows\\System32\\WindowsPowerShell\\v1.0\\powershell.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\WindowsPowerShell\\v1.0\\powershell.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\WindowsPowerShell\\v1.0\\powershell.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L55 · SET-VALUE · `C:\\Windows\\System32\\wbadmin.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\wbadmin.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\wbadmin.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L56 · SET-VALUE · `C:\\Windows\\System32\\wbengine.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\wbengine.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\wbengine.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L57 · SET-VALUE · `C:\\Windows\\System32\\bootim.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\bootim.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\bootim.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L58 · SET-VALUE · `C:\\Windows\\System32\\WinBioDataModelOOBE.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\WinBioDataModelOOBE.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\WinBioDataModelOOBE.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L61 · SET-VALUE · `C:\\Windows\\System32\\PresentationHost.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\PresentationHost.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\PresentationHost.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L62 · SET-VALUE · `C:\\Windows\\System32\\rstrui.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\rstrui.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\rstrui.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L63 · SET-VALUE · `C:\\Windows\\System32\\srdelayed.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\srdelayed.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\srdelayed.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L64 · SET-VALUE · `C:\\Windows\\System32\\SrTasks.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\SrTasks.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\SrTasks.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L65 · SET-VALUE · `C:\\Windows\\System32\\SpaceAgent.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\SpaceAgent.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\SpaceAgent.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L66 · SET-VALUE · `C:\\Windows\\System32\\provlaunch.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\provlaunch.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\provlaunch.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L67 · SET-VALUE · `C:\\Windows\\System32\\EduPrintProv.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\EduPrintProv.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\EduPrintProv.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L68 · SET-VALUE · `C:\\Windows\\System32\\UNP\\UNPUXHost.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\UNP\\UNPUXHost.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\UNP\\UNPUXHost.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L69 · SET-VALUE · `C:\\Windows\\System32\\UNP\\UNPUXLauncher.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\UNP\\UNPUXLauncher.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\UNP\\UNPUXLauncher.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L70 · SET-VALUE · `C:\\Windows\\System32\\UNP\\UpdateNotificationMgr.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\UNP\\UpdateNotificationMgr.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\UNP\\UpdateNotificationMgr.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L71 · SET-VALUE · `C:\\Windows\\System32\\Spectrum.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\Spectrum.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\Spectrum.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L72 · SET-VALUE · `C:\\Windows\\System32\\SIHClient.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\SIHClient.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\SIHClient.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L73 · SET-VALUE · `C:\\Windows\\System32\\xwizard.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\xwizard.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\xwizard.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L74 · SET-VALUE · `C:\\Windows\\System32\\takeown.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\takeown.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\takeown.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L75 · SET-VALUE · `C:\\Windows\\System32\\vssadmin.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\vssadmin.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\vssadmin.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L76 · SET-VALUE · `C:\\Windows\\System32\\where.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\where.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\where.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L77 · SET-VALUE · `C:\\Windows\\System32\\cacls.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\cacls.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\cacls.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L78 · SET-VALUE · `C:\\Windows\\System32\\eventcreate.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\eventcreate.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\eventcreate.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L79 · SET-VALUE · `C:\\Windows\\System32\\fsavailux.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\fsavailux.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\fsavailux.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L80 · SET-VALUE · `C:\\Windows\\System32\\ftp.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\ftp.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\ftp.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L81 · SET-VALUE · `C:\\Windows\\System32\\grpconv.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\grpconv.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\grpconv.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L82 · SET-VALUE · `C:\\Windows\\System32\\runas.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\runas.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\runas.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L83 · SET-VALUE · `C:\\Windows\\System32\\systeminfo.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\systeminfo.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\systeminfo.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L84 · SET-VALUE · `C:\\Windows\\System32\\taskkill.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\taskkill.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\taskkill.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L85 · SET-VALUE · `C:\\Windows\\System32\\tasklist.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\tasklist.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\tasklist.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L86 · SET-VALUE · `C:\\Windows\\System32\\timeout.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\timeout.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\timeout.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L87 · SET-VALUE · `C:\\Windows\\System32\\waitfor.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\waitfor.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\waitfor.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L88 · SET-VALUE · `C:\\Windows\\System32\\whoami.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\whoami.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\whoami.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L89 · SET-VALUE · `C:\\Windows\\System32\\mstsc.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\mstsc.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\mstsc.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L90 · SET-VALUE · `C:\\Windows\\System32\\TSTheme.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\TSTheme.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\TSTheme.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L91 · SET-VALUE · `C:\\Windows\\System32\\wkspbroker.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\wkspbroker.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\wkspbroker.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L92 · SET-VALUE · `C:\\Windows\\System32\\TSWbPrxy.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\TSWbPrxy.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\TSWbPrxy.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L93 · SET-VALUE · `C:\\Windows\\System32\\RdpSa.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\RdpSa.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\RdpSa.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L94 · SET-VALUE · `C:\\Windows\\System32\\RdpSaProxy.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\RdpSaProxy.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\RdpSaProxy.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L95 · SET-VALUE · `C:\\Windows\\System32\\RdpSaUacHelper.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\RdpSaUacHelper.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\RdpSaUacHelper.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L96 · SET-VALUE · `C:\\Windows\\System32\\sessionmsg.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\sessionmsg.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\sessionmsg.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L97 · SET-VALUE · `C:\\Windows\\System32\\TieringEngineService.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\TieringEngineService.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\TieringEngineService.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L98 · SET-VALUE · `C:\\Windows\\System32\\rdpclip.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\rdpclip.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\rdpclip.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L99 · SET-VALUE · `C:\\Windows\\System32\\rdpinput.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\rdpinput.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\rdpinput.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L100 · SET-VALUE · `C:\\Windows\\System32\\TapiUnattend.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\TapiUnattend.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\TapiUnattend.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L101 · SET-VALUE · `C:\\Windows\\System32\\dialer.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\dialer.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\dialer.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L102 · SET-VALUE · `C:\\Windows\\System32\\tcmsetup.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\tcmsetup.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\tcmsetup.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L103 · SET-VALUE · `C:\\Windows\\System32\\MultiDigiMon.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\MultiDigiMon.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\MultiDigiMon.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L104 · SET-VALUE · `C:\\Windows\\System32\\tabcal.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\tabcal.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\tabcal.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L105 · SET-VALUE · `C:\\Windows\\System32\\FsIso.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\FsIso.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\FsIso.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L106 · SET-VALUE · `C:\\Windows\\System32\\dvdplay.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\dvdplay.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\dvdplay.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L107 · SET-VALUE · `C:\\Windows\\System32\\calc.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\calc.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\calc.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L108 · SET-VALUE · `C:\\Windows\\System32\\charmap.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\charmap.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\charmap.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L109 · SET-VALUE · `C:\\Windows\\System32\\credwiz.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\credwiz.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\credwiz.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L110 · SET-VALUE · `C:\\Windows\\System32\\certreq.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\certreq.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\certreq.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L111 · SET-VALUE · `C:\\Windows\\System32\\certutil.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\certutil.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\certutil.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L112 · SET-VALUE · `C:\\Windows\\System32\\klist.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\klist.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\klist.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L113 · SET-VALUE · `C:\\Windows\\System32\\ksetup.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\ksetup.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\ksetup.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L114 · SET-VALUE · `C:\\Windows\\System32\\nltest.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\nltest.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\nltest.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L115 · SET-VALUE · `C:\\Windows\\System32\\regini.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\regini.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\regini.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L116 · SET-VALUE · `C:\\Windows\\System32\\regsvr32.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\regsvr32.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\regsvr32.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L117 · SET-VALUE · `C:\\Windows\\System32\\setspn.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\setspn.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\setspn.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L118 · SET-VALUE · `C:\\Windows\\System32\\regedt32.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\regedt32.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\regedt32.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L119 · SET-VALUE · `C:\\Windows\\System32\\ResetEngine.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\ResetEngine.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\ResetEngine.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L120 · SET-VALUE · `C:\\Windows\\System32\\SysResetErr.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\SysResetErr.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\SysResetErr.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L121 · SET-VALUE · `C:\\Windows\\System32\\systemreset.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\systemreset.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\systemreset.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L122 · SET-VALUE · `C:\\Windows\\System32\\SystemResetPlatform\\SystemResetPlatform.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\SystemResetPlatform\\SystemResetPlatform.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\SystemResetPlatform\\SystemResetPlatform.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L123 · SET-VALUE · `C:\\Windows\\System32\\migwiz\\mighost.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\migwiz\\mighost.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\migwiz\\mighost.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L124 · SET-VALUE · `C:\\Windows\\System32\\pwlauncher.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\pwlauncher.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\pwlauncher.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L125 · SET-VALUE · `C:\\Windows\\System32\\fodhelper.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\fodhelper.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\fodhelper.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L126 · SET-VALUE · `C:\\Windows\\System32\\Fondue.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\Fondue.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\Fondue.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L127 · SET-VALUE · `C:\\Windows\\System32\\OptionalFeatures.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\OptionalFeatures.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\OptionalFeatures.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L128 · SET-VALUE · `C:\\Windows\\System32\\CheckNetIsolation.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\CheckNetIsolation.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\CheckNetIsolation.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L129 · SET-VALUE · `C:\\Windows\\System32\\msiexec.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\msiexec.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\msiexec.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L130 · SET-VALUE · `C:\\Windows\\System32\\mblctr.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\mblctr.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\mblctr.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L131 · SET-VALUE · `C:\\Windows\\System32\\msconfig.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\msconfig.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\msconfig.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L132 · SET-VALUE · `C:\\Windows\\System32\\mmc.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\mmc.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\mmc.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L133 · SET-VALUE · `C:\\Windows\\System32\\WindowsActionDialog.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\WindowsActionDialog.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\WindowsActionDialog.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L134 · SET-VALUE · `C:\\Windows\\System32\\cliconfg.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\cliconfg.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\cliconfg.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L135 · SET-VALUE · `C:\\Windows\\System32\\odbcad32.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\odbcad32.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\odbcad32.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L136 · SET-VALUE · `C:\\Windows\\System32\\odbcconf.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\odbcconf.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\odbcconf.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L137 · SET-VALUE · `C:\\Windows\\System32\\iscsicpl.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\iscsicpl.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\iscsicpl.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L138 · SET-VALUE · `C:\\Windows\\System32\\iscsicli.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\iscsicli.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\iscsicli.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L139 · SET-VALUE · `C:\\Windows\\System32\\IESettingSync.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\IESettingSync.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\IESettingSync.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L140 · SET-VALUE · `C:\\Windows\\System32\\ie4uinit.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\ie4uinit.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\ie4uinit.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L141 · SET-VALUE · `C:\\Windows\\System32\\ie4ushowIE.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\ie4ushowIE.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\ie4ushowIE.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L142 · SET-VALUE · `C:\\Windows\\System32\\F12\\IEChooser.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\F12\\IEChooser.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\F12\\IEChooser.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L143 · SET-VALUE · `C:\\Windows\\System32\\ieUnatt.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\ieUnatt.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\ieUnatt.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L144 · SET-VALUE · `C:\\Windows\\System32\\iexpress.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\iexpress.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\iexpress.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L145 · SET-VALUE · `C:\\Windows\\System32\\wextract.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\wextract.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\wextract.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L146 · SET-VALUE · `C:\\Windows\\System32\\mshta.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\mshta.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\mshta.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L147 · SET-VALUE · `C:\\Windows\\System32\\wiaacmgr.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\wiaacmgr.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\wiaacmgr.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L148 · SET-VALUE · `C:\\Windows\\System32\\wiawow64.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\wiawow64.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\wiawow64.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L149 · SET-VALUE · `C:\\Windows\\System32\\bridgeunattend.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\bridgeunattend.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\bridgeunattend.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L150 · SET-VALUE · `C:\\Windows\\System32\\eventvwr.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\eventvwr.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\eventvwr.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L151 · SET-VALUE · `C:\\Windows\\System32\\gpresult.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\gpresult.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\gpresult.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L152 · SET-VALUE · `C:\\Windows\\System32\\gpupdate.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\gpupdate.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\gpupdate.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L153 · SET-VALUE · `C:\\Windows\\System32\\esentutl.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\esentutl.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\esentutl.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L154 · SET-VALUE · `C:\\Windows\\System32\\eudcedit.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\eudcedit.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\eudcedit.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L155 · SET-VALUE · `C:\\Windows\\System32\\wecutil.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\wecutil.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\wecutil.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L156 · SET-VALUE · `C:\\Windows\\System32\\easinvoker.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\easinvoker.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\easinvoker.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L157 · SET-VALUE · `C:\\Windows\\System32\\EhStorAuthn.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\EhStorAuthn.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\EhStorAuthn.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L158 · SET-VALUE · `C:\\Windows\\System32\\DpiScaling.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\DpiScaling.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\DpiScaling.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L159 · SET-VALUE · `C:\\Windows\\System32\\Dxpserver.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\Dxpserver.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\Dxpserver.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L160 · SET-VALUE · `C:\\Windows\\System32\\DeviceProperties.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\DeviceProperties.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\DeviceProperties.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L161 · SET-VALUE · `C:\\Windows\\System32\\DisplaySwitch.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\DisplaySwitch.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\DisplaySwitch.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L162 · SET-VALUE · `C:\\Windows\\System32\\SystemSettingsRemoveDevice.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\SystemSettingsRemoveDevice.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\SystemSettingsRemoveDevice.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L163 · SET-VALUE · `C:\\Windows\\System32\\SyncHost.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\SyncHost.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\SyncHost.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L164 · SET-VALUE · `C:\\Windows\\System32\\DevicePairingWizard.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\DevicePairingWizard.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\DevicePairingWizard.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L165 · SET-VALUE · `C:\\Windows\\System32\\ComputerDefaults.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\ComputerDefaults.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\ComputerDefaults.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L166 · SET-VALUE · `C:\\Windows\\System32\\DataExchangeHost.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\DataExchangeHost.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\DataExchangeHost.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L167 · SET-VALUE · `C:\\Windows\\System32\\CompMgmtLauncher.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\CompMgmtLauncher.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\CompMgmtLauncher.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L168 · SET-VALUE · `C:\\Windows\\System32\\convert.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\convert.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\convert.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L169 · SET-VALUE · `C:\\Windows\\System32\\find.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\find.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\find.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L170 · SET-VALUE · `C:\\Windows\\System32\\ktmutil.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\ktmutil.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\ktmutil.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L171 · SET-VALUE · `C:\\Windows\\System32\\label.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\label.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\label.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L172 · SET-VALUE · `C:\\Windows\\System32\\openfiles.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\openfiles.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\openfiles.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L173 · SET-VALUE · `C:\\Windows\\System32\\replace.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\replace.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\replace.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L174 · SET-VALUE · `C:\\Windows\\System32\\Robocopy.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\Robocopy.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\Robocopy.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L175 · SET-VALUE · `C:\\Windows\\System32\\stordiag.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\stordiag.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\stordiag.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L176 · SET-VALUE · `C:\\Windows\\System32\\choice.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\choice.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\choice.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L177 · SET-VALUE · `C:\\Windows\\System32\\clip.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\clip.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\clip.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L178 · SET-VALUE · `C:\\Windows\\System32\\doskey.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\doskey.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\doskey.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L179 · SET-VALUE · `C:\\Windows\\System32\\forfiles.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\forfiles.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\forfiles.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L180 · SET-VALUE · `C:\\Windows\\System32\\print.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\print.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\print.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L181 · SET-VALUE · `C:\\Windows\\System32\\subst.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\subst.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\subst.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L182 · SET-VALUE · `C:\\Windows\\System32\\cttune.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\cttune.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\cttune.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L183 · SET-VALUE · `C:\\Windows\\System32\\cttunesvr.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\cttunesvr.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\cttunesvr.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L184 · SET-VALUE · `C:\\Windows\\System32\\help.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\help.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\help.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L185 · SET-VALUE · `C:\\Windows\\System32\\msdtc.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\msdtc.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\msdtc.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L186 · SET-VALUE · `C:\\Windows\\System32\\CastSrv.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\CastSrv.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\CastSrv.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L187 · SET-VALUE · `C:\\Windows\\System32\\UserDataSource.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\UserDataSource.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\UserDataSource.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L188 · SET-VALUE · `C:\\Windows\\System32\\curl.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\curl.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\curl.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L189 · SET-VALUE · `C:\\Windows\\System32\\tar.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\tar.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\tar.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L190 · SET-VALUE · `C:\\Windows\\System32\\spaceman.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\spaceman.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\spaceman.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L191 · SET-VALUE · `C:\\Windows\\System32\\spaceutil.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\spaceutil.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\spaceutil.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L192 · SET-VALUE · `C:\\Windows\\System32\\EDPCleanup.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\EDPCleanup.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\EDPCleanup.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L193 · SET-VALUE · `C:\\Windows\\System32\\MDMAppInstaller.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\MDMAppInstaller.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\MDMAppInstaller.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L194 · SET-VALUE · `C:\\Windows\\System32\\ARP.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\ARP.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\ARP.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L195 · SET-VALUE · `C:\\Windows\\System32\\finger.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\finger.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\finger.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L196 · SET-VALUE · `C:\\Windows\\System32\\HOSTNAME.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\HOSTNAME.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\HOSTNAME.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L197 · SET-VALUE · `C:\\Windows\\System32\\MRINFO.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\MRINFO.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\MRINFO.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L198 · SET-VALUE · `C:\\Windows\\System32\\NETSTAT.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\NETSTAT.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\NETSTAT.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L199 · SET-VALUE · `C:\\Windows\\System32\\ROUTE.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\ROUTE.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\ROUTE.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L200 · SET-VALUE · `C:\\Windows\\System32\\sort.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\sort.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\sort.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L201 · SET-VALUE · `C:\\Windows\\System32\\TCPSVCS.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\TCPSVCS.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\TCPSVCS.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L202 · SET-VALUE · `C:\\Windows\\System32\\xcopy.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\xcopy.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\xcopy.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L203 · SET-VALUE · `C:\\Windows\\System32\\auditpol.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\auditpol.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\auditpol.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L204 · SET-VALUE · `C:\\Windows\\System32\\mountvol.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\mountvol.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\mountvol.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L205 · SET-VALUE · `C:\\Windows\\System32\\net.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\net.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\net.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L206 · SET-VALUE · `C:\\Windows\\System32\\net1.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\net1.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\net1.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L207 · SET-VALUE · `C:\\Windows\\System32\\netsh.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\netsh.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\netsh.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L208 · SET-VALUE · `C:\\Windows\\System32\\PATHPING.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\PATHPING.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\PATHPING.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L209 · SET-VALUE · `C:\\Windows\\System32\\PING.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\PING.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\PING.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L210 · SET-VALUE · `C:\\Windows\\System32\\reg.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\reg.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\reg.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L211 · SET-VALUE · `C:\\Windows\\System32\\sc.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\sc.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\sc.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L212 · SET-VALUE · `C:\\Windows\\System32\\setx.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\setx.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\setx.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L213 · SET-VALUE · `C:\\Windows\\System32\\TRACERT.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\TRACERT.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\TRACERT.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L214 · SET-VALUE · `C:\\Windows\\System32\\attrib.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\attrib.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\attrib.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L215 · SET-VALUE · `C:\\Windows\\System32\\ClipUp.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\ClipUp.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\ClipUp.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L216 · SET-VALUE · `C:\\Windows\\System32\\diskusage.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\diskusage.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\diskusage.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L217 · SET-VALUE · `C:\\Windows\\System32\\findstr.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\findstr.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\findstr.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L218 · SET-VALUE · `C:\\Windows\\System32\\icacls.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\icacls.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\icacls.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L219 · SET-VALUE · `C:\\Windows\\System32\\ipconfig.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\ipconfig.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\ipconfig.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L220 · SET-VALUE · `C:\\Windows\\System32\\CIDiag.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\CIDiag.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\CIDiag.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L221 · SET-VALUE · `C:\\Windows\\System32\\comp.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\comp.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\comp.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L222 · SET-VALUE · `C:\\Windows\\System32\\fc.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\fc.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\fc.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L223 · SET-VALUE · `C:\\Windows\\System32\\fsutil.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\fsutil.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\fsutil.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L224 · SET-VALUE · `C:\\Windows\\System32\\recover.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\recover.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\recover.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L225 · SET-VALUE · `C:\\Windows\\System32\\sdclt.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\sdclt.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\sdclt.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L226 · SET-VALUE · `C:\\Windows\\System32\\PerceptionSimulation\\PerceptionSimulationService.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\PerceptionSimulation\\PerceptionSimulationService.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\PerceptionSimulation\\PerceptionSimulationService.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L227 · SET-VALUE · `C:\\Windows\\System32\\tcblaunch.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\tcblaunch.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\tcblaunch.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L228 · SET-VALUE · `C:\\Windows\\System32\\securekernel.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\securekernel.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\securekernel.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L229 · SET-VALUE · `C:\\Windows\\System32\\SgrmBroker.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\SgrmBroker.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\SgrmBroker.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L230 · SET-VALUE · `C:\\Windows\\System32\\SgrmLpac.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\SgrmLpac.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\SgrmLpac.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L231 · SET-VALUE · `C:\\Windows\\System32\\upnpcont.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\upnpcont.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\upnpcont.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L232 · SET-VALUE · `C:\\Windows\\System32\\BioIso.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\BioIso.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\BioIso.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L233 · SET-VALUE · `C:\\Windows\\System32\\NgcIso.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\NgcIso.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\NgcIso.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L234 · SET-VALUE · `C:\\Windows\\System32\\dusmtask.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\dusmtask.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\dusmtask.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L235 · SET-VALUE · `C:\\Windows\\System32\\WinBioPlugIns\\FaceFodUninstaller.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\WinBioPlugIns\\FaceFodUninstaller.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\WinBioPlugIns\\FaceFodUninstaller.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L236 · SET-VALUE · `C:\\Windows\\System32\\oobe\\oobeldr.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\oobe\\oobeldr.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\oobe\\oobeldr.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L237 · SET-VALUE · `C:\\Windows\\System32\\oobe\\windeploy.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\oobe\\windeploy.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\oobe\\windeploy.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L238 · SET-VALUE · `C:\\Windows\\System32\\oobe\\audit.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\oobe\\audit.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\oobe\\audit.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L239 · SET-VALUE · `C:\\Windows\\System32\\oobe\\AuditShD.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\oobe\\AuditShD.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\oobe\\AuditShD.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L240 · SET-VALUE · `C:\\Windows\\System32\\MBR2GPT.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\MBR2GPT.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\MBR2GPT.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L241 · SET-VALUE · `C:\\Windows\\System32\\oobe\\Setup.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\oobe\\Setup.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\oobe\\Setup.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L242 · SET-VALUE · `C:\\Windows\\System32\\poqexec.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\poqexec.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\poqexec.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L243 · SET-VALUE · `C:\\Windows\\System32\\PkgMgr.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\PkgMgr.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\PkgMgr.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L244 · SET-VALUE · `C:\\Windows\\System32\\Dism\\DismHost.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\Dism\\DismHost.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\Dism\\DismHost.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L245 · SET-VALUE · `C:\\Windows\\System32\\cmdkey.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\cmdkey.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\cmdkey.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L246 · SET-VALUE · `C:\\Windows\\System32\\dpapimig.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\dpapimig.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\dpapimig.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L247 · SET-VALUE · `C:\\Windows\\System32\\LsaIso.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\LsaIso.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\LsaIso.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L248 · SET-VALUE · `C:\\Windows\\System32\\cscript.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\cscript.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\cscript.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L249 · SET-VALUE · `C:\\Windows\\System32\\RmClient.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\RmClient.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\RmClient.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L250 · SET-VALUE · `C:\\Windows\\System32\\SecEdit.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\SecEdit.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\SecEdit.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L251 · SET-VALUE · `C:\\Windows\\System32\\wscript.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\wscript.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\wscript.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L252 · SET-VALUE · `C:\\Windows\\System32\\icsunattend.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\icsunattend.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\icsunattend.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L253 · SET-VALUE · `C:\\Windows\\System32\\NetHost.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\NetHost.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\NetHost.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L254 · SET-VALUE · `C:\\Windows\\System32\\cmmon32.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\cmmon32.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\cmmon32.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L255 · SET-VALUE · `C:\\Windows\\System32\\cmstp.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\cmstp.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\cmstp.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L256 · SET-VALUE · `C:\\Windows\\System32\\cmdl32.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\cmdl32.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\cmdl32.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L257 · SET-VALUE · `C:\\Windows\\System32\\rasautou.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\rasautou.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\rasautou.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L258 · SET-VALUE · `C:\\Windows\\System32\\rasdial.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\rasdial.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\rasdial.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L259 · SET-VALUE · `C:\\Windows\\System32\\rasphone.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\rasphone.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\rasphone.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L260 · SET-VALUE · `C:\\Windows\\System32\\ntprint.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\ntprint.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\ntprint.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L261 · SET-VALUE · `C:\\Windows\\System32\\printui.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\printui.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\printui.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L262 · SET-VALUE · `C:\\Windows\\System32\\DeviceEject.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\DeviceEject.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\DeviceEject.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L263 · SET-VALUE · `C:\\Windows\\System32\\powercfg.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\powercfg.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\powercfg.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L264 · SET-VALUE · `C:\\Windows\\System32\\sigverif.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\sigverif.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\sigverif.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L265 · SET-VALUE · `C:\\Windows\\System32\\drvinst.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\drvinst.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\drvinst.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L266 · SET-VALUE · `C:\\Windows\\System32\\hdwwiz.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\hdwwiz.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\hdwwiz.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L267 · SET-VALUE · `C:\\Windows\\System32\\pnputil.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\pnputil.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\pnputil.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L268 · SET-VALUE · `C:\\Windows\\System32\\wowreg32.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\wowreg32.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\wowreg32.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L269 · SET-VALUE · `C:\\Windows\\System32\\InfDefault-`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\InfDefault-” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\InfDefault-”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L270 · SET-VALUE · `C:\\Windows\\System32\\ndadmin.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\ndadmin.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\ndadmin.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L271 · SET-VALUE · `C:\\Windows\\System32\\newdev.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\newdev.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\newdev.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L272 · SET-VALUE · `C:\\Windows\\System32\\driverquery.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\driverquery.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\driverquery.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L273 · SET-VALUE · `C:\\Windows\\System32\\PnPUnattend.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\PnPUnattend.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\PnPUnattend.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L274 · SET-VALUE · `C:\\Windows\\System32\\oobe\\FirstLogonAnim.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\oobe\\FirstLogonAnim.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\oobe\\FirstLogonAnim.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L275 · SET-VALUE · `C:\\Windows\\System32\\oobe\\msoobe.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\oobe\\msoobe.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\oobe\\msoobe.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L276 · SET-VALUE · `C:\\Windows\\System32\\oobe\\UserOOBEBroker.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\oobe\\UserOOBEBroker.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\oobe\\UserOOBEBroker.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L277 · SET-VALUE · `C:\\Windows\\System32\\netbtugc.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\netbtugc.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\netbtugc.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L278 · SET-VALUE · `C:\\Windows\\System32\\netiougc.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\netiougc.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\netiougc.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L279 · SET-VALUE · `C:\\Windows\\System32\\nbtstat.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\nbtstat.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\nbtstat.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L280 · SET-VALUE · `C:\\Windows\\System32\\NetCfgNotifyObjectHost.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\NetCfgNotifyObjectHost.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\NetCfgNotifyObjectHost.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L281 · SET-VALUE · `C:\\Windows\\System32\\djoin.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\djoin.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\djoin.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L282 · SET-VALUE · `C:\\Windows\\System32\\getmac.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\getmac.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\getmac.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L283 · SET-VALUE · `C:\\Windows\\System32\\shrpubw.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\shrpubw.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\shrpubw.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L284 · SET-VALUE · `C:\\Windows\\System32\\SystemPropertiesAdvanced.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\SystemPropertiesAdvanced.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\SystemPropertiesAdvanced.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L285 · SET-VALUE · `C:\\Windows\\System32\\SystemPropertiesComputerName.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\SystemPropertiesComputerName.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\SystemPropertiesComputerName.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L286 · SET-VALUE · `C:\\Windows\\System32\\SystemPropertiesDataExecutionPrevention.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\SystemPropertiesDataExecutionPrevention.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\SystemPropertiesDataExecutionPrevention.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L287 · SET-VALUE · `C:\\Windows\\System32\\SystemPropertiesHardware.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\SystemPropertiesHardware.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\SystemPropertiesHardware.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L288 · SET-VALUE · `C:\\Windows\\System32\\SystemPropertiesPerformance.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\SystemPropertiesPerformance.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\SystemPropertiesPerformance.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L289 · SET-VALUE · `C:\\Windows\\System32\\SystemPropertiesProtection.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\SystemPropertiesProtection.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\SystemPropertiesProtection.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L290 · SET-VALUE · `C:\\Windows\\System32\\SystemPropertiesRemote.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\SystemPropertiesRemote.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\SystemPropertiesRemote.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L291 · SET-VALUE · `C:\\Windows\\System32\\winver.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\winver.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\winver.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L292 · SET-VALUE · `C:\\Windows\\System32\\sxstrace.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\sxstrace.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\sxstrace.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L293 · SET-VALUE · `C:\\Windows\\System32\\Sysprep\\sysprep.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\Sysprep\\sysprep.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\Sysprep\\sysprep.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L294 · SET-VALUE · `C:\\Windows\\System32\\WSCollect.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\WSCollect.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\WSCollect.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L295 · SET-VALUE · `C:\\Windows\\System32\\WSReset.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\WSReset.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\WSReset.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L296 · SET-VALUE · `C:\\Windows\\System32\\changepk.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\changepk.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\changepk.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L297 · SET-VALUE · `C:\\Windows\\System32\\LicensingUI.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\LicensingUI.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\LicensingUI.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L298 · SET-VALUE · `C:\\Windows\\System32\\phoneactivate.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\phoneactivate.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\phoneactivate.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L299 · SET-VALUE · `C:\\Windows\\System32\\UpgradeResultsUI.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\UpgradeResultsUI.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\UpgradeResultsUI.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L300 · SET-VALUE · `C:\\Windows\\System32\\GenValObj.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\GenValObj.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\GenValObj.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L301 · SET-VALUE · `C:\\Windows\\System32\\slui.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\slui.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\slui.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L302 · SET-VALUE · `C:\\Windows\\System32\\SppExtComObj.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\SppExtComObj.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\SppExtComObj.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L303 · SET-VALUE · `C:\\Windows\\System32\\sppsvc.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\sppsvc.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\sppsvc.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L304 · SET-VALUE · `C:\\Windows\\System32\\Speech\\SpeechUX\\SpeechUXWiz.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\Speech\\SpeechUX\\SpeechUXWiz.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\Speech\\SpeechUX\\SpeechUXWiz.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L305 · SET-VALUE · `C:\\Windows\\System32\\snmptrap.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\snmptrap.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\snmptrap.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L306 · SET-VALUE · `C:\\Windows\\System32\\immersivetpmvscmgrsvr.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\immersivetpmvscmgrsvr.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\immersivetpmvscmgrsvr.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L307 · SET-VALUE · `C:\\Windows\\System32\\rmttpmvscmgrsvr.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\rmttpmvscmgrsvr.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\rmttpmvscmgrsvr.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L308 · SET-VALUE · `C:\\Windows\\System32\\tpmvscmgr.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\tpmvscmgr.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\tpmvscmgr.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L309 · SET-VALUE · `C:\\Windows\\System32\\tpmvscmgrsvr.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\tpmvscmgrsvr.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\tpmvscmgrsvr.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L310 · SET-VALUE · `C:\\Windows\\System32\\OpenWith.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\OpenWith.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\OpenWith.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L311 · SET-VALUE · `C:\\Windows\\System32\\ThumbnailExtractionHost.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\ThumbnailExtractionHost.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\ThumbnailExtractionHost.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L312 · SET-VALUE · `C:\\Windows\\System32\\verclsid.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\verclsid.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\verclsid.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L313 · SET-VALUE · `C:\\Windows\\System32\\WallpaperHost.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\WallpaperHost.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\WallpaperHost.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L314 · SET-VALUE · `C:\\Windows\\System32\\prevhost.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\prevhost.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\prevhost.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L315 · SET-VALUE · `C:\\Windows\\System32\\rundll32.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\rundll32.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\rundll32.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L316 · SET-VALUE · `C:\\Windows\\System32\\mcbuilder.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\mcbuilder.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\mcbuilder.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L317 · SET-VALUE · `C:\\Windows\\System32\\MSchedExe.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\MSchedExe.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\MSchedExe.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L318 · SET-VALUE · `C:\\Windows\\System32\\WUDFCompanionHost.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\WUDFCompanionHost.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\WUDFCompanionHost.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L319 · SET-VALUE · `C:\\Windows\\System32\\WUDFHost.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\WUDFHost.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\WUDFHost.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L320 · SET-VALUE · `C:\\Windows\\System32\\AxInstUI.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\AxInstUI.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\AxInstUI.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L321 · SET-VALUE · `C:\\Windows\\System32\\consent.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\consent.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\consent.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L322 · SET-VALUE · `C:\\Windows\\System32\\LanguageComponentsInstallerComHandler.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\LanguageComponentsInstallerComHandler.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\LanguageComponentsInstallerComHandler.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L323 · SET-VALUE · `C:\\Windows\\System32\\LockAppHost.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\LockAppHost.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\LockAppHost.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L324 · SET-VALUE · `C:\\Windows\\System32\\la57setup.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\la57setup.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\la57setup.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L325 · SET-VALUE · `C:\\Windows\\System32\\lpk-`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\lpk-” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\lpk-”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L326 · SET-VALUE · `C:\\Windows\\System32\\lpksetup.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\lpksetup.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\lpksetup.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L327 · SET-VALUE · `C:\\Windows\\System32\\lpremove.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\lpremove.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\lpremove.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L328 · SET-VALUE · `C:\\Windows\\System32\\DsmUserTask.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\DsmUserTask.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\DsmUserTask.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L329 · SET-VALUE · `C:\\Windows\\System32\\netcfg.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\netcfg.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\netcfg.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L330 · SET-VALUE · `C:\\Windows\\System32\\runonce.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\runonce.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\runonce.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L331 · SET-VALUE · `C:\\Windows\\System32\\secinit.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\secinit.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\secinit.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L332 · SET-VALUE · `C:\\Windows\\System32\\colorcpl.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\colorcpl.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\colorcpl.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L333 · SET-VALUE · `C:\\Windows\\System32\\dccw.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\dccw.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\dccw.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L334 · SET-VALUE · `C:\\Windows\\System32\\Dism.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\Dism.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\Dism.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L335 · SET-VALUE · `C:\\Windows\\System32\\proquota.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\proquota.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\proquota.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L336 · SET-VALUE · `C:\\Windows\\System32\\UserAccountControlSettings.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\UserAccountControlSettings.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\UserAccountControlSettings.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L337 · SET-VALUE · `C:\\Windows\\System32\\shutdown.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\shutdown.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\shutdown.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L338 · SET-VALUE · `C:\\Windows\\System32\\efsui.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\efsui.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\efsui.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L339 · SET-VALUE · `C:\\Windows\\System32\\cipher.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\cipher.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\cipher.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L340 · SET-VALUE · `C:\\Windows\\System32\\edpnotify.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\edpnotify.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\edpnotify.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L341 · SET-VALUE · `C:\\Windows\\System32\\MicrosoftEdgeCP.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\MicrosoftEdgeCP.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\MicrosoftEdgeCP.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L342 · SET-VALUE · `C:\\Windows\\System32\\rekeywiz.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\rekeywiz.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\rekeywiz.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L343 · SET-VALUE · `C:\\Windows\\System32\\dnscacheugc.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\dnscacheugc.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\dnscacheugc.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L344 · SET-VALUE · `C:\\Windows\\System32\\nslookup.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\nslookup.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\nslookup.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L345 · SET-VALUE · `C:\\Windows\\System32\\lodctr.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\lodctr.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\lodctr.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L346 · SET-VALUE · `C:\\Windows\\System32\\unlodctr.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\unlodctr.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\unlodctr.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L347 · SET-VALUE · `C:\\Windows\\System32\\ddodiag.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\ddodiag.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\ddodiag.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L348 · SET-VALUE · `C:\\Windows\\System32\\omadmclient.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\omadmclient.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\omadmclient.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L349 · SET-VALUE · `C:\\Windows\\System32\\omadmprc.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\omadmprc.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\omadmprc.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L350 · SET-VALUE · `C:\\Windows\\System32\\DmOmaCpMo.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\DmOmaCpMo.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\DmOmaCpMo.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L351 · SET-VALUE · `C:\\Windows\\System32\\coredpussvr.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\coredpussvr.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\coredpussvr.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L352 · SET-VALUE · `C:\\Windows\\System32\\DeviceEnroller.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\DeviceEnroller.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\DeviceEnroller.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L353 · SET-VALUE · `C:\\Windows\\System32\\dmcertinst.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\dmcertinst.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\dmcertinst.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L354 · SET-VALUE · `C:\\Windows\\System32\\dmcfghost.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\dmcfghost.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\dmcfghost.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L355 · SET-VALUE · `C:\\Windows\\System32\\CredentialUIBroker.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\CredentialUIBroker.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\CredentialUIBroker.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L356 · SET-VALUE · `C:\\Windows\\System32\\SensorDataService.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\SensorDataService.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\SensorDataService.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L357 · SET-VALUE · `C:\\Windows\\System32\\SecurityHealthHost.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\SecurityHealthHost.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\SecurityHealthHost.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L358 · SET-VALUE · `C:\\Windows\\System32\\prproc.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\prproc.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\prproc.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L359 · SET-VALUE · `C:\\Windows\\System32\\SecurityHealthService.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\SecurityHealthService.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\SecurityHealthService.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L360 · SET-VALUE · `C:\\Windows\\System32\\Windows.Media.BackgroundPlayback.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\Windows.Media.BackgroundPlayback.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\Windows.Media.BackgroundPlayback.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L361 · SET-VALUE · `C:\\Windows\\System32\\sfc.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\sfc.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\sfc.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L362 · SET-VALUE · `C:\\Windows\\System32\\wusa.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\wusa.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\wusa.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L363 · SET-VALUE · `C:\\Windows\\System32\\wbem\\wbemtest.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\wbem\\wbemtest.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\wbem\\wbemtest.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L364 · SET-VALUE · `C:\\Windows\\System32\\wbem\\scrcons.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\wbem\\scrcons.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\wbem\\scrcons.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L365 · SET-VALUE · `C:\\Windows\\System32\\ApplyTrustOffline.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\ApplyTrustOffline.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\ApplyTrustOffline.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L366 · SET-VALUE · `C:\\Windows\\System32\\CustomInstallExec.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\CustomInstallExec.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\CustomInstallExec.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L367 · SET-VALUE · `C:\\Windows\\System32\\deploymentcsphelper.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\deploymentcsphelper.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\deploymentcsphelper.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L368 · SET-VALUE · `C:\\Windows\\System32\\expand.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\expand.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\expand.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L369 · SET-VALUE · `C:\\Windows\\System32\\ReAgentc.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\ReAgentc.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\ReAgentc.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L370 · SET-VALUE · `C:\\Windows\\System32\\RelPost.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\RelPost.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\RelPost.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L371 · SET-VALUE · `C:\\Windows\\System32\\MuiUnattend.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\MuiUnattend.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\MuiUnattend.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L372 · SET-VALUE · `C:\\Windows\\System32\\dxdiag.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\dxdiag.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\dxdiag.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L373 · SET-VALUE · `C:\\Windows\\System32\\fontdrvhost.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\fontdrvhost.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\fontdrvhost.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L374 · SET-VALUE · `C:\\Windows\\System32\\winlogon.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\winlogon.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\winlogon.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L376 · SET-VALUE · `C:\\Windows\\System32\\ucsvc.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\ucsvc.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\ucsvc.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L377 · SET-VALUE · `C:\\Windows\\System32\\fltMC.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\fltMC.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\fltMC.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L378 · SET-VALUE · `C:\\Windows\\System32\\lsass.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\lsass.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\lsass.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L379 · SET-VALUE · `C:\\Windows\\System32\\ntoskrnl.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\ntoskrnl.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\ntoskrnl.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L380 · SET-VALUE · `C:\\Windows\\System32\\services.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\services.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\services.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L381 · SET-VALUE · `C:\\Windows\\System32\\smss.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\smss.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\smss.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L382 · SET-VALUE · `C:\\Windows\\System32\\csrss.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\csrss.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\csrss.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L383 · SET-VALUE · `C:\\Windows\\System32\\Boot\\winload.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\Boot\\winload.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\Boot\\winload.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L384 · SET-VALUE · `C:\\Windows\\System32\\AggregatorHost.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\AggregatorHost.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\AggregatorHost.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L385 · SET-VALUE · `C:\\Windows\\System32\\dtdump.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\dtdump.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\dtdump.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L386 · SET-VALUE · `C:\\Windows\\System32\\runexehelper.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\runexehelper.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\runexehelper.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L387 · SET-VALUE · `C:\\Windows\\System32\\rdrleakdiag.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\rdrleakdiag.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\rdrleakdiag.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L388 · SET-VALUE · `C:\\Windows\\System32\\wpr.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\wpr.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\wpr.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L389 · SET-VALUE · `C:\\Windows\\System32\\pacjsworker.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\pacjsworker.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\pacjsworker.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L390 · SET-VALUE · `C:\\Windows\\System32\\userinit.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\userinit.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\userinit.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L391 · SET-VALUE · `C:\\Windows\\System32\\wininit.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\wininit.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\wininit.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L392 · SET-VALUE · `C:\\Windows\\System32\\DeviceCensus.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\DeviceCensus.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\DeviceCensus.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L393 · SET-VALUE · `C:\\Windows\\System32\\dllhost.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\dllhost.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\dllhost.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L394 · SET-VALUE · `C:\\Windows\\System32\\conhost.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\conhost.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\conhost.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L395 · SET-VALUE · `C:\\Windows\\System32\\extrac32.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\extrac32.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\extrac32.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L396 · SET-VALUE · `C:\\Windows\\System32\\makecab.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\makecab.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\makecab.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L397 · SET-VALUE · `C:\\Windows\\System32\\svchost.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\svchost.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\svchost.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L398 · SET-VALUE · `C:\\Windows\\System32\\compact.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\compact.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\compact.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L399 · SET-VALUE · `C:\\Windows\\System32\\dwm.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\dwm.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\dwm.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L400 · SET-VALUE · `C:\\Windows\\System32\\dcomcnfg.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\dcomcnfg.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\dcomcnfg.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L401 · SET-VALUE · `C:\\Windows\\System32\\Locator.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\Locator.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\Locator.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L402 · SET-VALUE · `C:\\Windows\\System32\\Com\\MigRegDB.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\Com\\MigRegDB.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\Com\\MigRegDB.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L403 · SET-VALUE · `C:\\Windows\\System32\\RpcPing.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\RpcPing.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\RpcPing.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L404 · SET-VALUE · `C:\\Windows\\System32\\mtstocom.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\mtstocom.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\mtstocom.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L405 · SET-VALUE · `C:\\Windows\\System32\\Com\\comrepl.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\Com\\comrepl.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\Com\\comrepl.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L406 · SET-VALUE · `C:\\Windows\\System32\\dllhst3g.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\dllhst3g.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\dllhst3g.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L407 · SET-VALUE · `C:\\Windows\\System32\\setupcl.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\setupcl.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\setupcl.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L408 · SET-VALUE · `C:\\Windows\\System32\\setupugc.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\setupugc.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\setupugc.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L409 · SET-VALUE · `C:\\Windows\\System32\\wimserv.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\wimserv.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\wimserv.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L410 · SET-VALUE · `C:\\Windows\\System32\\chkdsk.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\chkdsk.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\chkdsk.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L411 · SET-VALUE · `C:\\Windows\\System32\\chkntfs.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\chkntfs.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\chkntfs.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L412 · SET-VALUE · `C:\\Windows\\System32\\wsqmcons.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\wsqmcons.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\wsqmcons.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L413 · SET-VALUE · `C:\\Windows\\System32\\autochk.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\autochk.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\autochk.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L414 · SET-VALUE · `C:\\Windows\\System32\\browser_broker.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\browser_broker.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\browser_broker.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L415 · SET-VALUE · `C:\\Windows\\System32\\browserexport.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\browserexport.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\browserexport.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L416 · SET-VALUE · `C:\\Windows\\System32\\Boot\\winresume.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\Boot\\winresume.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\Boot\\winresume.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L417 · SET-VALUE · `C:\\Windows\\System32\\winresume.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\winresume.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\winresume.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L418 · SET-VALUE · `C:\\Windows\\System32\\winload.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\winload.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\winload.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L419 · SET-VALUE · `C:\\Windows\\System32\\bthudtask.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\bthudtask.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\bthudtask.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L420 · SET-VALUE · `C:\\Windows\\System32\\fsquirt.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\fsquirt.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\fsquirt.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L421 · SET-VALUE · `C:\\Windows\\System32\\bitsadmin.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\bitsadmin.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\bitsadmin.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L422 · SET-VALUE · `C:\\Windows\\System32\\refsutil.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\refsutil.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\refsutil.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L423 · SET-VALUE · `C:\\Windows\\System32\\appidcertstorecheck.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\appidcertstorecheck.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\appidcertstorecheck.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L424 · SET-VALUE · `C:\\Windows\\System32\\appidpolicyconverter.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\appidpolicyconverter.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\appidpolicyconverter.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L425 · SET-VALUE · `C:\\Windows\\System32\\SndVol.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\SndVol.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\SndVol.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L426 · SET-VALUE · `C:\\Windows\\System32\\sdbinst.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\sdbinst.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\sdbinst.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L427 · SET-VALUE · `C:\\Windows\\System32\\pcalua.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\pcalua.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\pcalua.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L428 · SET-VALUE · `C:\\Windows\\System32\\LaunchTM.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\LaunchTM.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\LaunchTM.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L429 · SET-VALUE · `C:\\Windows\\System32\\pcaui.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\pcaui.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\pcaui.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L430 · SET-VALUE · `C:\\Windows\\System32\\Taskmgr.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\Taskmgr.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\Taskmgr.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L431 · SET-VALUE · `C:\\Windows\\System32\\Utilman.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\Utilman.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\Utilman.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L432 · SET-VALUE · `C:\\Windows\\System32\\EaseOfAccessDialog.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\EaseOfAccessDialog.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\EaseOfAccessDialog.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L433 · SET-VALUE · `C:\\Windows\\System32\\Narrator.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\Narrator.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\Narrator.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L434 · SET-VALUE · `C:\\Windows\\System32\\osk.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\osk.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\osk.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L435 · SET-VALUE · `C:\\Windows\\System32\\sethc.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\sethc.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\sethc.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L436 · SET-VALUE · `C:\\Windows\\System32\\AtBroker.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\AtBroker.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\AtBroker.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L437 · SET-VALUE · `C:\\Windows\\System32\\Magnify.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\Magnify.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\Magnify.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L438 · SET-VALUE · `C:\\Windows\\System32\\EoAExperiences.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\EoAExperiences.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\EoAExperiences.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L439 · SET-VALUE · `C:\\Windows\\System32\\CloudExperienceHostBroker.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\CloudExperienceHostBroker.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\CloudExperienceHostBroker.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L440 · SET-VALUE · `C:\\Windows\\System32\\ApplicationFrameHost.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\ApplicationFrameHost.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\ApplicationFrameHost.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L441 · SET-VALUE · `C:\\Windows\\System32\\ShellAppRuntime.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\ShellAppRuntime.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\ShellAppRuntime.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L442 · SET-VALUE · `C:\\Windows\\System32\\desktopimgdownldr.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\desktopimgdownldr.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\desktopimgdownldr.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L443 · SET-VALUE · `C:\\Windows\\System32\\SystemSettingsAdminFlows.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\SystemSettingsAdminFlows.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\SystemSettingsAdminFlows.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L444 · SET-VALUE · `C:\\Windows\\System32\\VSSVC.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\VSSVC.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\VSSVC.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L445 · SET-VALUE · `C:\\Windows\\System32\\convertvhd.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\convertvhd.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\convertvhd.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L446 · SET-VALUE · `C:\\Windows\\System32\\wuauclt.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\wuauclt.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\wuauclt.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L447 · SET-VALUE · `C:\\Windows\\System32\\MusNotifyIcon.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\MusNotifyIcon.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\MusNotifyIcon.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L448 · SET-VALUE · `C:\\Windows\\System32\\WindowsUpdateElevatedInstaller.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\WindowsUpdateElevatedInstaller.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\WindowsUpdateElevatedInstaller.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L449 · SET-VALUE · `C:\\Windows\\System32\\MusNotification.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\MusNotification.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\MusNotification.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L450 · SET-VALUE · `C:\\Windows\\System32\\MusNotificationUx.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\MusNotificationUx.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\MusNotificationUx.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L451 · SET-VALUE · `C:\\Windows\\System32\\MoNotificationUx.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\MoNotificationUx.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\MoNotificationUx.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L452 · SET-VALUE · `C:\\Windows\\System32\\UsoClient.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\UsoClient.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\UsoClient.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L453 · SET-VALUE · `C:\\Windows\\System32\\Speech_OneCore\\common\\SpeechModelDownload.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\Speech_OneCore\\common\\SpeechModelDownload.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\Speech_OneCore\\common\\SpeechModelDownload.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L454 · SET-VALUE · `C:\\Windows\\System32\\Speech_OneCore\\common\\SpeechRuntime.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\Speech_OneCore\\common\\SpeechRuntime.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\Speech_OneCore\\common\\SpeechRuntime.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L455 · SET-VALUE · `C:\\Windows\\System32\\DeviceCredentialDeployment.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\DeviceCredentialDeployment.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\DeviceCredentialDeployment.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L456 · SET-VALUE · `C:\\Windows\\System32\\LegacyNetUXHost.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\LegacyNetUXHost.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\LegacyNetUXHost.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L457 · SET-VALUE · `C:\\Windows\\System32\\wevtutil.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\wevtutil.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\wevtutil.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L458 · SET-VALUE · `C:\\Windows\\System32\\dasHost.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\dasHost.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\dasHost.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L459 · SET-VALUE · `C:\\Windows\\System32\\DiskSnapshot.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\DiskSnapshot.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\DiskSnapshot.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L460 · SET-VALUE · `C:\\Windows\\System32\\verifier.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\verifier.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\verifier.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L461 · SET-VALUE · `C:\\Windows\\System32\\Register-CimProvider.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\Register-CimProvider.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\Register-CimProvider.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L462 · SET-VALUE · `C:\\Windows\\System32\\wbem\\WinMgmt.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\wbem\\WinMgmt.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\wbem\\WinMgmt.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L463 · SET-VALUE · `C:\\Windows\\System32\\wbem\\WmiPrvSE.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\wbem\\WmiPrvSE.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\wbem\\WmiPrvSE.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L464 · SET-VALUE · `C:\\Windows\\System32\\winrs.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\winrs.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\winrs.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L465 · SET-VALUE · `C:\\Windows\\System32\\winrshost.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\winrshost.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\winrshost.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L466 · SET-VALUE · `C:\\Windows\\System32\\wbem\\WMIC.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\wbem\\WMIC.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\wbem\\WMIC.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L467 · SET-VALUE · `C:\\Windows\\System32\\WSManHTTPConfig.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\WSManHTTPConfig.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\WSManHTTPConfig.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L468 · SET-VALUE · `C:\\Windows\\System32\\wsmprovhost.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\wsmprovhost.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\wsmprovhost.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L469 · SET-VALUE · `C:\\Windows\\System32\\LogonUI.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\LogonUI.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\LogonUI.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L470 · SET-VALUE · `C:\\Windows\\System32\\mpnotify.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\mpnotify.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\mpnotify.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L471 · SET-VALUE · `C:\\Windows\\System32\\wlrmdr.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\wlrmdr.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\wlrmdr.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L472 · SET-VALUE · `C:\\Windows\\System32\\diskpart.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\diskpart.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\diskpart.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L473 · SET-VALUE · `C:\\Windows\\System32\\diskraid.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\diskraid.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\diskraid.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L474 · SET-VALUE · `C:\\Windows\\System32\\vds.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\vds.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\vds.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L475 · SET-VALUE · `C:\\Windows\\System32\\vdsldr.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\vdsldr.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\vdsldr.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L476 · SET-VALUE · `C:\\Windows\\System32\\fixmapi.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\fixmapi.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\fixmapi.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L477 · SET-VALUE · `C:\\Windows\\System32\\Netplwiz.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\Netplwiz.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\Netplwiz.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L478 · SET-VALUE · `C:\\Windows\\System32\\PasswordOnWakeSettingFlyout.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\PasswordOnWakeSettingFlyout.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\PasswordOnWakeSettingFlyout.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L479 · SET-VALUE · `C:\\Windows\\System32\\UserAccountBroker.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\UserAccountBroker.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\UserAccountBroker.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L480 · SET-VALUE · `C:\\Windows\\System32\\LaunchWinApp.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\LaunchWinApp.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\LaunchWinApp.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L481 · SET-VALUE · `C:\\Windows\\System32\\verifiergui.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\verifiergui.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\verifiergui.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L482 · SET-VALUE · `C:\\Windows\\System32\\tzsync.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\tzsync.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\tzsync.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L483 · SET-VALUE · `C:\\Windows\\System32\\wksprt.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\wksprt.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\wksprt.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L484 · SET-VALUE · `C:\\Windows\\System32\\InputSwitchToastHandler.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\InputSwitchToastHandler.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\InputSwitchToastHandler.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L485 · SET-VALUE · `C:\\Windows\\System32\\UIMgrBroker.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\UIMgrBroker.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\UIMgrBroker.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L486 · SET-VALUE · `C:\\Windows\\System32\\ctfmon.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\ctfmon.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\ctfmon.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L487 · SET-VALUE · `C:\\Windows\\System32\\taskhostw.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\taskhostw.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\taskhostw.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L488 · SET-VALUE · `C:\\Windows\\System32\\at.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\at.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\at.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L489 · SET-VALUE · `C:\\Windows\\System32\\schtasks.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\schtasks.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\schtasks.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L490 · SET-VALUE · `C:\\Windows\\System32\\alg.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\alg.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\alg.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L491 · SET-VALUE · `C:\\Windows\\System32\\cmd.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\cmd.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\cmd.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L492 · SET-VALUE · `C:\\Windows\\System32\\PackagedCWALauncher.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\PackagedCWALauncher.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\PackagedCWALauncher.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L493 · SET-VALUE · `C:\\Windows\\System32\\mmgaserver.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\mmgaserver.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\mmgaserver.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L494 · SET-VALUE · `C:\\Windows\\System32\\AuthHost.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\AuthHost.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\AuthHost.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L495 · SET-VALUE · `C:\\Windows\\System32\\backgroundTaskHost.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\backgroundTaskHost.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\backgroundTaskHost.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L496 · SET-VALUE · `C:\\Windows\\System32\\VaultCmd.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\VaultCmd.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\VaultCmd.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L497 · SET-VALUE · `C:\\Windows\\System32\\licensingdiag.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\licensingdiag.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\licensingdiag.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L498 · SET-VALUE · `C:\\Windows\\System32\\CertEnrollCtrl.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\CertEnrollCtrl.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\CertEnrollCtrl.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L499 · SET-VALUE · `C:\\Windows\\System32\\RuntimeBroker.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\RuntimeBroker.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\RuntimeBroker.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L500 · SET-VALUE · `C:\\Windows\\System32\\BackgroundTransferHost.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\BackgroundTransferHost.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\BackgroundTransferHost.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L501 · SET-VALUE · `C:\\Windows\\System32\\ByteCodeGenerator.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\ByteCodeGenerator.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\ByteCodeGenerator.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L502 · SET-VALUE · `C:\\Windows\\System32\\WWAHost.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\WWAHost.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\WWAHost.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L503 · SET-VALUE · `C:\\Windows\\System32\\WaaSMedicAgent.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\WaaSMedicAgent.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\WaaSMedicAgent.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L504 · SET-VALUE · `C:\\Windows\\System32\\upfc.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\upfc.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\upfc.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L505 · SET-VALUE · `C:\\Windows\\System32\\wuapihost.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\wuapihost.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\wuapihost.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L506 · SET-VALUE · `C:\\Windows\\System32\\ttdinject.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\ttdinject.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\ttdinject.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L507 · SET-VALUE · `C:\\Windows\\System32\\tttracer.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\tttracer.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\tttracer.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L508 · SET-VALUE · `C:\\Windows\\System32\\sihost.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\sihost.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\sihost.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L509 · SET-VALUE · `C:\\Windows\\System32\\pospaymentsworker.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\pospaymentsworker.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\pospaymentsworker.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L510 · SET-VALUE · `C:\\Windows\\System32\\RemotePosWorker.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\RemotePosWorker.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\RemotePosWorker.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L511 · SET-VALUE · `C:\\Windows\\System32\\LicenseManagerShellext.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\LicenseManagerShellext.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\LicenseManagerShellext.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L512 · SET-VALUE · `C:\\Windows\\System32\\ISM.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\ISM.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\ISM.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L513 · SET-VALUE · `C:\\Windows\\System32\\SearchFilterHost.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\SearchFilterHost.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\SearchFilterHost.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L514 · SET-VALUE · `C:\\Windows\\System32\\SearchIndexer.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\SearchIndexer.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\SearchIndexer.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L515 · SET-VALUE · `C:\\Windows\\System32\\SearchProtocolHost.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\SearchProtocolHost.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\SearchProtocolHost.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L516 · SET-VALUE · `C:\\Windows\\System32\\directxdatabaseupdater.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\directxdatabaseupdater.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\directxdatabaseupdater.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L517 · SET-VALUE · `C:\\Windows\\System32\\dispdiag.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\dispdiag.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\dispdiag.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L518 · SET-VALUE · `C:\\Windows\\System32\\Windows.WARP.JITService.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\Windows.WARP.JITService.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\Windows.WARP.JITService.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L519 · SET-VALUE · `C:\\Windows\\System32\\dxgiadaptercache.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\dxgiadaptercache.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\dxgiadaptercache.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L520 · SET-VALUE · `C:\\Windows\\System32\\MicrosoftEdgeSH.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\MicrosoftEdgeSH.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\MicrosoftEdgeSH.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L521 · SET-VALUE · `C:\\Windows\\System32\\TokenBrokerCookies.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\TokenBrokerCookies.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\TokenBrokerCookies.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L522 · SET-VALUE · `C:\\Windows\\System32\\AppHostRegistrationVerifier.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\AppHostRegistrationVerifier.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\AppHostRegistrationVerifier.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L523 · SET-VALUE · `C:\\Windows\\System32\\dstokenclean.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\dstokenclean.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\dstokenclean.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L524 · SET-VALUE · `C:\\Windows\\System32\\WinRTNetMUAHostServer.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\WinRTNetMUAHostServer.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\WinRTNetMUAHostServer.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L525 · SET-VALUE · `C:\\Windows\\System32\\PickerHost.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\PickerHost.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\PickerHost.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L526 · SET-VALUE · `C:\\Windows\\System32\\SystemUWPLauncher.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\SystemUWPLauncher.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\SystemUWPLauncher.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L527 · SET-VALUE · `C:\\Windows\\System32\\DataStoreCacheDumpTool.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\DataStoreCacheDumpTool.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\DataStoreCacheDumpTool.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L528 · SET-VALUE · `C:\\Windows\\System32\\CredentialEnrollmentManager.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\CredentialEnrollmentManager.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\CredentialEnrollmentManager.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L529 · SET-VALUE · `C:\\Windows\\System32\\wlanext.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\wlanext.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\wlanext.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L530 · SET-VALUE · `C:\\Windows\\System32\\LockScreenContentServer.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\LockScreenContentServer.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\LockScreenContentServer.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L531 · SET-VALUE · `C:\\Windows\\System32\\SlideToShutDown.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\SlideToShutDown.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\SlideToShutDown.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L532 · SET-VALUE · `C:\\Windows\\System32\\systray.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\systray.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\systray.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L533 · SET-VALUE · `C:\\Windows\\System32\\RunLegacyCPLElevated.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\RunLegacyCPLElevated.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\RunLegacyCPLElevated.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L534 · SET-VALUE · `C:\\Windows\\System32\\control.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\control.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\control.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L535 · SET-VALUE · `C:\\Windows\\System32\\fontview.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\fontview.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\fontview.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L536 · SET-VALUE · `C:\\Windows\\System32\\wifitask.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\wifitask.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\wifitask.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L537 · SET-VALUE · `C:\\Windows\\System32\\tzutil.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\tzutil.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\tzutil.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L538 · SET-VALUE · `C:\\Windows\\System32\\w32tm.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\w32tm.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\w32tm.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L539 · SET-VALUE · `C:\\Windows\\System32\\dmclient.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\dmclient.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\dmclient.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L540 · SET-VALUE · `C:\\Windows\\System32\\dsregcmd.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\dsregcmd.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\dsregcmd.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L541 · SET-VALUE · `C:\\Windows\\System32\\UtcDecoderHost.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\UtcDecoderHost.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\UtcDecoderHost.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L542 · SET-VALUE · `C:\\Windows\\System32\\TpmTool.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\TpmTool.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\TpmTool.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L543 · SET-VALUE · `C:\\Windows\\System32\\HealthAttestationClientAgent.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\HealthAttestationClientAgent.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\HealthAttestationClientAgent.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L544 · SET-VALUE · `C:\\Windows\\System32\\TpmInit.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\TpmInit.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\TpmInit.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L545 · SET-VALUE · `C:\\Windows\\System32\\CloudNotifications.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\CloudNotifications.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\CloudNotifications.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L546 · SET-VALUE · `C:\\Windows\\System32\\SystemSettingsBroker.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\SystemSettingsBroker.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\SystemSettingsBroker.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L547 · SET-VALUE · `C:\\Windows\\System32\\wbem\\mofcomp.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\wbem\\mofcomp.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\wbem\\mofcomp.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L548 · SET-VALUE · `C:\\Windows\\System32\\wbem\\unsecapp.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\wbem\\unsecapp.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\wbem\\unsecapp.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L549 · SET-VALUE · `C:\\Windows\\System32\\wbem\\WMIADAP.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\wbem\\WMIADAP.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\wbem\\WMIADAP.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L550 · SET-VALUE · `C:\\Windows\\System32\\wbem\\WmiApSrv.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\wbem\\WmiApSrv.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\wbem\\WmiApSrv.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L551 · SET-VALUE · `C:\\Windows\\System32\\RMActivate.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\RMActivate.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\RMActivate.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L552 · SET-VALUE · `C:\\Windows\\System32\\RMActivate_isv.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\RMActivate_isv.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\RMActivate_isv.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L553 · SET-VALUE · `C:\\Windows\\System32\\RMActivate_ssp.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\RMActivate_ssp.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\RMActivate_ssp.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L554 · SET-VALUE · `C:\\Windows\\System32\\RMActivate_ssp_isv.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\RMActivate_ssp_isv.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\RMActivate_ssp_isv.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L555 · SET-VALUE · `C:\\Windows\\System32\\printfilterpipelinesvc.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\printfilterpipelinesvc.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\printfilterpipelinesvc.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L556 · SET-VALUE · `C:\\Windows\\System32\\provtool.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\provtool.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\provtool.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L557 · SET-VALUE · `C:\\Windows\\System32\\PrintIsolationHost.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\PrintIsolationHost.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\PrintIsolationHost.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L558 · SET-VALUE · `C:\\Windows\\System32\\spoolsv.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\spoolsv.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\spoolsv.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L559 · SET-VALUE · `C:\\Windows\\System32\\PinEnrollmentBroker.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\PinEnrollmentBroker.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\PinEnrollmentBroker.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L560 · SET-VALUE · `C:\\Windows\\System32\\WpcTok.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\WpcTok.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\WpcTok.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L561 · SET-VALUE · `C:\\Windows\\System32\\WpcMon.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\WpcMon.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\WpcMon.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L562 · SET-VALUE · `C:\\Windows\\System32\\ApproveChildRequest.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\ApproveChildRequest.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\ApproveChildRequest.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L563 · SET-VALUE · `C:\\Windows\\System32\\ofdeploy.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\ofdeploy.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\ofdeploy.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L564 · SET-VALUE · `C:\\Windows\\System32\\DmNotificationBroker.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\DmNotificationBroker.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\DmNotificationBroker.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L565 · SET-VALUE · `C:\\Windows\\System32\\MDMAgent.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\MDMAgent.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\MDMAgent.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L566 · SET-VALUE · `C:\\Windows\\System32\\MicrosoftEdgeBCHost.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\MicrosoftEdgeBCHost.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\MicrosoftEdgeBCHost.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L567 · SET-VALUE · `C:\\Windows\\System32\\Eap3Host.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\Eap3Host.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\Eap3Host.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L568 · SET-VALUE · `C:\\Windows\\System32\\bcdboot.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\bcdboot.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\bcdboot.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L569 · SET-VALUE · `C:\\Windows\\System32\\bcdedit.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\bcdedit.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\bcdedit.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L570 · SET-VALUE · `C:\\Windows\\System32\\bootsect.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\bootsect.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\bootsect.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L571 · SET-VALUE · `C:\\Windows\\System32\\audiodg.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\audiodg.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\audiodg.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L572 · SET-VALUE · `C:\\Windows\\System32\\SpatialAudioLicenseSrv.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\SpatialAudioLicenseSrv.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\SpatialAudioLicenseSrv.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L573 · SET-VALUE · `C:\\Windows\\System32\\CompPkgSrv.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\CompPkgSrv.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\CompPkgSrv.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L574 · SET-VALUE · `C:\\Windows\\System32\\agentactivationruntimestarter.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\agentactivationruntimestarter.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\agentactivationruntimestarter.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L575 · SET-VALUE · `C:\\Windows\\System32\\IcsEntitlementHost.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\IcsEntitlementHost.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\IcsEntitlementHost.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L576 · SET-VALUE · `C:\\Windows\\System32\\XblGameSaveTask.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\XblGameSaveTask.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\XblGameSaveTask.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L577 · SET-VALUE · `C:\\Windows\\System32\\notepad.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\notepad.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\notepad.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L578 · SET-VALUE · `C:\\Windows\\System32\\TsWpfWrp.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\System32\\TsWpfWrp.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\System32\\TsWpfWrp.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

### L579 · SET-VALUE · `C:\\Windows\\explorer.exe`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\DirectX\UserGpuPreferences`
- **Raw .reg data:** `"GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Înregistrează preferința grafică per executabil „C:\\Windows\\explorer.exe” cu datele GpuPreference=1;. Pentru aplicarea reală trebuie verificate formatul și dispozitivele GPU disponibile. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Writes a per-executable graphics preference for “C:\\Windows\\explorer.exe”: GpuPreference=1;. Actual behavior depends on the preference schema and available GPUs. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Per-app graphics preference; Windows 10 1803+ graphics preference generation and executable-presence check required.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference`

## Referințe / References

- https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_gpu_preference
