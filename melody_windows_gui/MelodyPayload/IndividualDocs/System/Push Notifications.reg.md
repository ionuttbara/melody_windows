# System/Push Notifications.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `395064eb6d86ddb9eb04049961e1cdbee7d6a999e8553946ef093ace1b4f0a89`
- **Recipe verdict / verdict rețetă:** `API`
- **Windows container / interval Windows:** `7600+`
- **Runtime prerequisite / condiție runtime:** `existing-key`
- **Value/operation descriptions / operații:** 15
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L4 · SET-VALUE · `NOC_GLOBAL_SETTING_ALLOW_CRITICAL_TOASTS_ABOVE_LOCK`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Notifications\Settings`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „NOC GLOBAL SETTING ALLOW CRITICAL TOASTS ABOVE LOCK” în ramura Microsoft / Windows / CurrentVersion la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “NOC GLOBAL SETTING ALLOW CRITICAL TOASTS ABOVE LOCK” option in registry branch Microsoft / Windows / CurrentVersion to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L5 · SET-VALUE · `NOC_GLOBAL_SETTING_ALLOW_NOTIFICATION_SOUND`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Notifications\Settings`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „NOC GLOBAL SETTING ALLOW NOTIFICATION SOUND” în ramura Microsoft / Windows / CurrentVersion la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “NOC GLOBAL SETTING ALLOW NOTIFICATION SOUND” option in registry branch Microsoft / Windows / CurrentVersion to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L8 · SET-VALUE · `Enabled`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Notifications\Settings\windows.immersivecontrolpanel_cw5n1h2txyewy!microsoft.windows.immersivecontrolpanel`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Enabled” în ramura Microsoft / Windows / CurrentVersion la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Enabled” option in registry branch Microsoft / Windows / CurrentVersion to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L11 · SET-VALUE · `Enabled`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Notifications\Settings\Windows.SystemToast.AutoPlay`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Enabled” în ramura Microsoft / Windows / CurrentVersion la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Enabled” option in registry branch Microsoft / Windows / CurrentVersion to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L14 · SET-VALUE · `Enabled`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Notifications\Settings\Windows.SystemToast.SecurityAndMaintenance`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Enabled” în ramura Microsoft / Windows / CurrentVersion la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Enabled” option in registry branch Microsoft / Windows / CurrentVersion to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L17 · SET-VALUE · `Enabled`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Notifications\Settings\Windows.SystemToast.StartupApp`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Enabled” în ramura Microsoft / Windows / CurrentVersion la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Enabled” option in registry branch Microsoft / Windows / CurrentVersion to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L20 · SET-VALUE · `NoToastApplicationNotification`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Windows\CurrentVersion\PushNotifications`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „No Toast Application Notification” în ramura Policies / Microsoft / Windows la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “No Toast Application Notification” option in registry branch Policies / Microsoft / Windows to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows policy-family value; exact target value must already exist unless separately documented above.
- **OS support / versiuni:** `7600+`

### L23 · SET-VALUE · `NoCloudApplicationNotification`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\CurrentVersion\PushNotifications`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „No Cloud Application Notification” în ramura Policies / Microsoft / Windows la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “No Cloud Application Notification” option in registry branch Policies / Microsoft / Windows to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows policy-family value; exact target value must already exist unless separately documented above.
- **OS support / versiuni:** `7600+`

### L26 · SET-VALUE · `NoTileApplicationNotification`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\PushNotifications`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „No Tile Application Notification” în ramura Microsoft / Windows / CurrentVersion la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “No Tile Application Notification” option in registry branch Microsoft / Windows / CurrentVersion to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L29 · SET-VALUE · `NotifyOnWeakCharger`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\Shell\USB`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Notify On Weak Charger” în ramura Microsoft / Shell / USB la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Notify On Weak Charger” option in registry branch Microsoft / Shell / USB to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L30 · SET-VALUE · `NotifyOnUsbErrors`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\Shell\USB`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Notify On Usb Errors” în ramura Microsoft / Shell / USB la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Notify On Usb Errors” option in registry branch Microsoft / Shell / USB to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L33 · SET-VALUE · `Start`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\WpnUserService`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Starea de pornire declarată pentru serviciul/driverul „WpnUserService”: pornire automată (2). Windows poate proteja componenta sau o poate modifica la întreținere. Melody nu execută această operație Registry brută; configurarea este delegată API-ului sau paginii Windows dedicate.
- **What it configures / EN:** Start type configured for service/driver “WpnUserService”: automatic start (2). Windows may protect or service this component. Melody does not execute this raw Registry operation; configuration is delegated to the dedicated Windows API or page.
- **Final verdict / verdict final:** `API`
- **Certitudine / Evidence:** Service startup/removal must use Service Control Manager rather than raw registry mutation.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/winsvc/nf-winsvc-changeserviceconfiga`

### L36 · SET-VALUE · `NOC_GLOBAL_SETTING_ALLOW_HMD_NOTIFICATIONS`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Notifications\Settings`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „NOC GLOBAL SETTING ALLOW HMD NOTIFICATIONS” în ramura Microsoft / Windows / CurrentVersion la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “NOC GLOBAL SETTING ALLOW HMD NOTIFICATIONS” option in registry branch Microsoft / Windows / CurrentVersion to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L39 · SET-VALUE · `Enable`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Windows\CurrentVersion\QuietHours`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Enable” în ramura Policies / Microsoft / Windows la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Enable” option in registry branch Policies / Microsoft / Windows to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows policy-family value; exact target value must already exist unless separately documented above.
- **OS support / versiuni:** `7600+`

### L40 · SET-VALUE · `AllowCalls`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Windows\CurrentVersion\QuietHours`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Allow Calls” în ramura Policies / Microsoft / Windows la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Allow Calls” option in registry branch Policies / Microsoft / Windows to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows policy-family value; exact target value must already exist unless separately documented above.
- **OS support / versiuni:** `7600+`

## Referințe / References

- https://learn.microsoft.com/en-us/windows/win32/api/winsvc/nf-winsvc-changeserviceconfiga
