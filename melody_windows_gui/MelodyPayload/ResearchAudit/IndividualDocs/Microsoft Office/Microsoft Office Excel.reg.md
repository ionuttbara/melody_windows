# Microsoft Office/Microsoft Office Excel.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `955fd4cc0fc4f3f74f94c5021d151b4a2cbbdd1d77c6334f23164348244bcdb4`
- **Recipe verdict / verdict rețetă:** `CONDITIONAL`
- **Windows container / interval Windows:** `7600+`
- **Runtime prerequisite / condiție runtime:** `office16`
- **Value/operation descriptions / operații:** 19
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L4 · SET-VALUE · `dontshowwhatsnew`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\excel`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „dontshowwhatsnew” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “dontshowwhatsnew” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L7 · SET-VALUE · `disableboottoofficestart`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Excel\Options`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „disableboottoofficestart” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “disableboottoofficestart” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L8 · SET-VALUE · `rungrammar`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Excel\Options`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „rungrammar” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “rungrammar” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L9 · SET-VALUE · `nosmarttagrecognition`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Excel\Options`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „nosmarttagrecognition” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “nosmarttagrecognition” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L10 · SET-VALUE · `showstats`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Excel\Options`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „showstats” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “showstats” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L11 · SET-VALUE · `transformtosway`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Excel\Options`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „transformtosway” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “transformtosway” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L12 · SET-VALUE · `alertifnotdefault`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Excel\Options`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „alertifnotdefault” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “alertifnotdefault” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L13 · SET-VALUE · `linkedinresumeassistant`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Excel\Options`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „linkedinresumeassistant” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “linkedinresumeassistant” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L14 · SET-VALUE · `livepreview`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Excel\Options`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „livepreview” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “livepreview” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L15 · SET-VALUE · `autogrammar`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Excel\Options`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „autogrammar” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “autogrammar” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L16 · SET-VALUE · `EnableLogging`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Excel\Options`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Enable Logging” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Enable Logging” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L19 · SET-VALUE · `fcorrectkeyboard_64_1`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Excel\Options\Assist`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „fcorrectkeyboard 64 1” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “fcorrectkeyboard 64 1” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L20 · SET-VALUE · `ffraction_96_1`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Excel\Options\Assist`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „ffraction 96 1” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “ffraction 96 1” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L21 · SET-VALUE · `femdash_112_1`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Excel\Options\Assist`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „femdash 112 1” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “femdash 112 1” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L24 · SET-VALUE · `disableinternetfilesinpv`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Excel\Security\protectedview`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „disableinternetfilesinpv” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “disableinternetfilesinpv” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L25 · SET-VALUE · `disableunsafelocationsinpv`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Excel\Security\protectedview`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „disableunsafelocationsinpv” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “disableunsafelocationsinpv” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L26 · SET-VALUE · `disableattachmentsinpv`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Excel\Security\protectedview`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „disableattachmentsinpv” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “disableattachmentsinpv” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L29 · SET-VALUE · `disablenetworktrusteddocuments`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Excel\Security\Trusted Documents`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „disablenetworktrusteddocuments” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “disablenetworktrusteddocuments” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L30 · SET-VALUE · `disabletrusteddocuments`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Excel\Security\Trusted Documents`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „disabletrusteddocuments” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “disabletrusteddocuments” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

## Referințe / References

- https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked
