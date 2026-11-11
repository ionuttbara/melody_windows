# Microsoft Office/Microsoft Office (365) Update Settings.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `1ac75ffb0e685369829a944c14ddba10b4c141ad2bb4a0a3b5780b83713645e7`
- **Recipe verdict / verdict rețetă:** `CONDITIONAL`
- **Windows container / interval Windows:** `7600+`
- **Runtime prerequisite / condiție runtime:** `existing-key`
- **Value/operation descriptions / operații:** 10
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L4 · SET-VALUE · `preventbinginstall`

- **Registry key:** `HKEY_LOCAL_MACHINE\software\policies\microsoft\office\15.0\common\officeupdate`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „preventbinginstall” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “preventbinginstall” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L5 · SET-VALUE · `preventteamsinstall`

- **Registry key:** `HKEY_LOCAL_MACHINE\software\policies\microsoft\office\15.0\common\officeupdate`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „preventteamsinstall” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “preventteamsinstall” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L6 · SET-VALUE · `enableautomaticupdates`

- **Registry key:** `HKEY_LOCAL_MACHINE\software\policies\microsoft\office\15.0\common\officeupdate`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „enableautomaticupdates” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “enableautomaticupdates” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L7 · SET-VALUE · `hideenabledisableupdates`

- **Registry key:** `HKEY_LOCAL_MACHINE\software\policies\microsoft\office\15.0\common\officeupdate`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „hideenabledisableupdates” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “hideenabledisableupdates” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L8 · SET-VALUE · `hideupdatenotifications`

- **Registry key:** `HKEY_LOCAL_MACHINE\software\policies\microsoft\office\15.0\common\officeupdate`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „hideupdatenotifications” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “hideupdatenotifications” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L11 · SET-VALUE · `preventbinginstall`

- **Registry key:** `HKEY_LOCAL_MACHINE\software\policies\microsoft\office\16.0\common\officeupdate`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „preventbinginstall” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “preventbinginstall” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L12 · SET-VALUE · `preventteamsinstall`

- **Registry key:** `HKEY_LOCAL_MACHINE\software\policies\microsoft\office\16.0\common\officeupdate`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „preventteamsinstall” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “preventteamsinstall” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L13 · SET-VALUE · `enableautomaticupdates`

- **Registry key:** `HKEY_LOCAL_MACHINE\software\policies\microsoft\office\16.0\common\officeupdate`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „enableautomaticupdates” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “enableautomaticupdates” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L14 · SET-VALUE · `hideenabledisableupdates`

- **Registry key:** `HKEY_LOCAL_MACHINE\software\policies\microsoft\office\16.0\common\officeupdate`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „hideenabledisableupdates” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “hideenabledisableupdates” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L15 · SET-VALUE · `hideupdatenotifications`

- **Registry key:** `HKEY_LOCAL_MACHINE\software\policies\microsoft\office\16.0\common\officeupdate`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „hideupdatenotifications” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “hideupdatenotifications” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

## Referințe / References

- https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked
