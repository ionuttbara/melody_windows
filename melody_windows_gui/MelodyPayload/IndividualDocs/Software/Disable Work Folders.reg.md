# Software/Disable Work Folders.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `e3eb46ebb669316348fd0bd8a7c17a9c8b789be817da69249f8375c19c86c1e3`
- **Recipe verdict / verdict rețetă:** `CONDITIONAL`
- **Windows container / interval Windows:** `7600+`
- **Runtime prerequisite / condiție runtime:** `existing-key`
- **Value/operation descriptions / operații:** 12
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L4 · SET-VALUE · `AutoProvision`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\WorkFolders`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Auto Provision” în ramura Policies / Microsoft / Windows la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Auto Provision” option in registry branch Policies / Microsoft / Windows to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows policy-family value; exact target value must already exist unless separately documented above.
- **OS support / versiuni:** `7600+`

### L7 · SET-VALUE · `GoOfflineAction`

- **Registry key:** `HKEY_LOCAL_MACHINE\Software\Policies\Microsoft\Windows\NetCache`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Go Offline Action” în ramura Policies / Microsoft / Windows la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Go Offline Action” option in registry branch Policies / Microsoft / Windows to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows policy-family value; exact target value must already exist unless separately documented above.
- **OS support / versiuni:** `7600+`

### L8 · SET-VALUE · `Enabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\Software\Policies\Microsoft\Windows\NetCache`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Enabled” în ramura Policies / Microsoft / Windows la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Enabled” option in registry branch Policies / Microsoft / Windows to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows policy-family value; exact target value must already exist unless separately documented above.
- **OS support / versiuni:** `7600+`

### L9 · SET-VALUE · `BackgroundSyncEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\Software\Policies\Microsoft\Windows\NetCache`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Background Sync Enabled” în ramura Policies / Microsoft / Windows la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Background Sync Enabled” option in registry branch Policies / Microsoft / Windows to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows policy-family value; exact target value must already exist unless separately documented above.
- **OS support / versiuni:** `7600+`

### L10 · SET-VALUE · `EventLoggingLevel`

- **Registry key:** `HKEY_LOCAL_MACHINE\Software\Policies\Microsoft\Windows\NetCache`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Event Logging Level” în ramura Policies / Microsoft / Windows la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Event Logging Level” option in registry branch Policies / Microsoft / Windows to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows policy-family value; exact target value must already exist unless separately documented above.
- **OS support / versiuni:** `7600+`

### L11 · SET-VALUE · `NoCacheViewer`

- **Registry key:** `HKEY_LOCAL_MACHINE\Software\Policies\Microsoft\Windows\NetCache`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „No Cache Viewer” în ramura Policies / Microsoft / Windows la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “No Cache Viewer” option in registry branch Policies / Microsoft / Windows to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows policy-family value; exact target value must already exist unless separately documented above.
- **OS support / versiuni:** `7600+`

### L12 · SET-VALUE · `NoConfigCache`

- **Registry key:** `HKEY_LOCAL_MACHINE\Software\Policies\Microsoft\Windows\NetCache`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „No Config Cache” în ramura Policies / Microsoft / Windows la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “No Config Cache” option in registry branch Policies / Microsoft / Windows to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows policy-family value; exact target value must already exist unless separately documented above.
- **OS support / versiuni:** `7600+`

### L13 · SET-VALUE · `NoMakeAvailableOffline`

- **Registry key:** `HKEY_LOCAL_MACHINE\Software\Policies\Microsoft\Windows\NetCache`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „No Make Available Offline” în ramura Policies / Microsoft / Windows la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “No Make Available Offline” option in registry branch Policies / Microsoft / Windows to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows policy-family value; exact target value must already exist unless separately documented above.
- **OS support / versiuni:** `7600+`

### L14 · SET-VALUE · `WorkOfflineDisabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\Software\Policies\Microsoft\Windows\NetCache`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Work Offline Disabled” în ramura Policies / Microsoft / Windows la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Work Offline Disabled” option in registry branch Policies / Microsoft / Windows to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows policy-family value; exact target value must already exist unless separately documented above.
- **OS support / versiuni:** `7600+`

### L15 · SET-VALUE · `SyncAtLogoff`

- **Registry key:** `HKEY_LOCAL_MACHINE\Software\Policies\Microsoft\Windows\NetCache`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Sync At Logoff” în ramura Policies / Microsoft / Windows la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Sync At Logoff” option in registry branch Policies / Microsoft / Windows to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows policy-family value; exact target value must already exist unless separately documented above.
- **OS support / versiuni:** `7600+`

### L16 · SET-VALUE · `SyncAtLogon`

- **Registry key:** `HKEY_LOCAL_MACHINE\Software\Policies\Microsoft\Windows\NetCache`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Sync At Logon” în ramura Policies / Microsoft / Windows la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Sync At Logon” option in registry branch Policies / Microsoft / Windows to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows policy-family value; exact target value must already exist unless separately documented above.
- **OS support / versiuni:** `7600+`

### L17 · SET-VALUE · `NoReminders`

- **Registry key:** `HKEY_LOCAL_MACHINE\Software\Policies\Microsoft\Windows\NetCache`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „No Reminders” în ramura Policies / Microsoft / Windows la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “No Reminders” option in registry branch Policies / Microsoft / Windows to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows policy-family value; exact target value must already exist unless separately documented above.
- **OS support / versiuni:** `7600+`

## Referințe / References

- No exact vendor URL is attached. The final runtime rule requires the exact live Registry target to exist before Melody enables the recipe.
