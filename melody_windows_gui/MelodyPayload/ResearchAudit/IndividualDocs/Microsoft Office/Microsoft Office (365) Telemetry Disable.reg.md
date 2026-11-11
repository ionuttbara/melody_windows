# Microsoft Office/Microsoft Office (365) Telemetry Disable.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `7144cadb94ea392fa57f5efe6b21b4b270e81e601d8f9741f1472780066d09dc`
- **Recipe verdict / verdict rețetă:** `CONDITIONAL`
- **Windows container / interval Windows:** `7600+`
- **Runtime prerequisite / condiție runtime:** `office16`
- **Value/operation descriptions / operații:** 63
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L4 · SET-VALUE · `DisableTelemetry`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\Office\Common\ClientTelemetry`
- **Raw .reg data:** `dword:00027100`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Disable Telemetry” în preferințele Microsoft Office la 160000 (0x00027100) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Disable Telemetry” option in Microsoft Office preferences to 160000 (0x00027100) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L7 · SET-VALUE · `DisableTelemetry`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\Office\16.0\Common\ClientTelemetry`
- **Raw .reg data:** `dword:00027100`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Disable Telemetry” în preferințele Microsoft Office la 160000 (0x00027100) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Disable Telemetry” option in Microsoft Office preferences to 160000 (0x00027100) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L10 · SET-VALUE · `sendtelemetry`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Common\clienttelemetry`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „sendtelemetry” în politicile Microsoft Office la 3 (0x00000003) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “sendtelemetry” option in Microsoft Office policies to 3 (0x00000003) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L13 · SET-VALUE · `sendtelemetry`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\15.0\Common\clienttelemetry`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „sendtelemetry” în politicile Microsoft Office la 3 (0x00000003) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “sendtelemetry” option in Microsoft Office policies to 3 (0x00000003) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L16 · SET-VALUE · `enablelogging`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\osm`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „enablelogging” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “enablelogging” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L17 · SET-VALUE · `enablefileobfuscation`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\osm`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „enablefileobfuscation” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “enablefileobfuscation” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L18 · SET-VALUE · `enableupload`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\osm`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „enableupload” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “enableupload” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L21 · SET-VALUE · `accesssolution`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\microsoft\office\16.0\osm\preventedapplications`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „accesssolution” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “accesssolution” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L22 · SET-VALUE · `olksolution`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\microsoft\office\16.0\osm\preventedapplications`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „olksolution” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “olksolution” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L23 · SET-VALUE · `onenotesolution`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\microsoft\office\16.0\osm\preventedapplications`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „onenotesolution” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “onenotesolution” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L24 · SET-VALUE · `pptsolution`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\microsoft\office\16.0\osm\preventedapplications`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „pptsolution” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “pptsolution” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L25 · SET-VALUE · `projectsolution`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\microsoft\office\16.0\osm\preventedapplications`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „projectsolution” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “projectsolution” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L26 · SET-VALUE · `publishersolution`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\microsoft\office\16.0\osm\preventedapplications`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „publishersolution” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “publishersolution” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L27 · SET-VALUE · `visiosolution`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\microsoft\office\16.0\osm\preventedapplications`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „visiosolution” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “visiosolution” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L28 · SET-VALUE · `wdsolution`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\microsoft\office\16.0\osm\preventedapplications`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „wdsolution” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “wdsolution” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L29 · SET-VALUE · `xlsolution`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\microsoft\office\16.0\osm\preventedapplications`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „xlsolution” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “xlsolution” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L32 · SET-VALUE · `agave`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\microsoft\office\16.0\osm\preventedsolutiontypes`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „agave” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “agave” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L33 · SET-VALUE · `appaddins`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\microsoft\office\16.0\osm\preventedsolutiontypes`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „appaddins” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “appaddins” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L34 · SET-VALUE · `comaddins`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\microsoft\office\16.0\osm\preventedsolutiontypes`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „comaddins” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “comaddins” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L35 · SET-VALUE · `documentfiles`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\microsoft\office\16.0\osm\preventedsolutiontypes`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „documentfiles” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “documentfiles” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L36 · SET-VALUE · `templatefiles`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\microsoft\office\16.0\osm\preventedsolutiontypes`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „templatefiles” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “templatefiles” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L39 · SET-VALUE · `accesssolution`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\microsoft\office\15.0\osm\preventedapplications`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „accesssolution” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “accesssolution” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L40 · SET-VALUE · `olksolution`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\microsoft\office\15.0\osm\preventedapplications`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „olksolution” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “olksolution” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L41 · SET-VALUE · `onenotesolution`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\microsoft\office\15.0\osm\preventedapplications`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „onenotesolution” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “onenotesolution” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L42 · SET-VALUE · `pptsolution`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\microsoft\office\15.0\osm\preventedapplications`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „pptsolution” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “pptsolution” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L43 · SET-VALUE · `projectsolution`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\microsoft\office\15.0\osm\preventedapplications`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „projectsolution” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “projectsolution” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L44 · SET-VALUE · `publishersolution`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\microsoft\office\15.0\osm\preventedapplications`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „publishersolution” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “publishersolution” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L45 · SET-VALUE · `visiosolution`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\microsoft\office\15.0\osm\preventedapplications`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „visiosolution” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “visiosolution” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L46 · SET-VALUE · `wdsolution`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\microsoft\office\15.0\osm\preventedapplications`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „wdsolution” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “wdsolution” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L47 · SET-VALUE · `xlsolution`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\microsoft\office\15.0\osm\preventedapplications`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „xlsolution” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “xlsolution” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L50 · SET-VALUE · `agave`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\microsoft\office\15.0\osm\preventedsolutiontypes`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „agave” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “agave” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L51 · SET-VALUE · `appaddins`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\microsoft\office\15.0\osm\preventedsolutiontypes`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „appaddins” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “appaddins” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L52 · SET-VALUE · `comaddins`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\microsoft\office\15.0\osm\preventedsolutiontypes`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „comaddins” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “comaddins” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L53 · SET-VALUE · `documentfiles`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\microsoft\office\15.0\osm\preventedsolutiontypes`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „documentfiles” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “documentfiles” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L54 · SET-VALUE · `templatefiles`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\microsoft\office\15.0\osm\preventedsolutiontypes`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „templatefiles” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “templatefiles” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L57 · SET-VALUE · `enablelogging`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\15.0\osm`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „enablelogging” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “enablelogging” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L58 · SET-VALUE · `enablefileobfuscation`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\15.0\osm`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „enablefileobfuscation” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “enablefileobfuscation” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L59 · SET-VALUE · `enableupload`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\15.0\osm`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „enableupload” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “enableupload” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L62 · SET-VALUE · `sentcostumerdata`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Common`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „sentcostumerdata” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “sentcostumerdata” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L63 · SET-VALUE · `SendCustomerDataOptInReason`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Common`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Send Customer Data Opt In Reason” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Send Customer Data Opt In Reason” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L64 · SET-VALUE · `SendCustomerDataOptIn`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Common`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Send Customer Data Opt In” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Send Customer Data Opt In” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L65 · SET-VALUE · `qmenable`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Common`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „qmenable” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “qmenable” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L66 · SET-VALUE · `updatereliabilitydata`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Common`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „updatereliabilitydata” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “updatereliabilitydata” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L69 · SET-VALUE · `sentcostumerdata`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\Office\16.0\Common`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „sentcostumerdata” în preferințele Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “sentcostumerdata” option in Microsoft Office preferences to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L70 · SET-VALUE · `SendCustomerDataOptInReason`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\Office\16.0\Common`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Send Customer Data Opt In Reason” în preferințele Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Send Customer Data Opt In Reason” option in Microsoft Office preferences to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L71 · SET-VALUE · `SendCustomerDataOptIn`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\Office\16.0\Common`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Send Customer Data Opt In” în preferințele Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Send Customer Data Opt In” option in Microsoft Office preferences to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L72 · SET-VALUE · `qmenable`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\Office\16.0\Common`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „qmenable” în preferințele Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “qmenable” option in Microsoft Office preferences to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L73 · SET-VALUE · `updatereliabilitydata`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\Office\16.0\Common`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „updatereliabilitydata” în preferințele Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “updatereliabilitydata” option in Microsoft Office preferences to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L76 · SET-VALUE · `sentcostumerdata`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\15.0\Common`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „sentcostumerdata” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “sentcostumerdata” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L77 · SET-VALUE · `SendCustomerDataOptInReason`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\15.0\Common`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Send Customer Data Opt In Reason” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Send Customer Data Opt In Reason” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L78 · SET-VALUE · `SendCustomerDataOptIn`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\15.0\Common`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Send Customer Data Opt In” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Send Customer Data Opt In” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L79 · SET-VALUE · `qmenable`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\15.0\Common`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „qmenable” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “qmenable” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L80 · SET-VALUE · `updatereliabilitydata`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\15.0\Common`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „updatereliabilitydata” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “updatereliabilitydata” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L83 · SET-VALUE · `sentcostumerdata`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\Office\15.0\Common`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „sentcostumerdata” în preferințele Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “sentcostumerdata” option in Microsoft Office preferences to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L84 · SET-VALUE · `SendCustomerDataOptInReason`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\Office\15.0\Common`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Send Customer Data Opt In Reason” în preferințele Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Send Customer Data Opt In Reason” option in Microsoft Office preferences to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L85 · SET-VALUE · `SendCustomerDataOptIn`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\Office\15.0\Common`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Send Customer Data Opt In” în preferințele Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Send Customer Data Opt In” option in Microsoft Office preferences to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L86 · SET-VALUE · `qmenable`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\Office\15.0\Common`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „qmenable” în preferințele Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “qmenable” option in Microsoft Office preferences to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L87 · SET-VALUE · `updatereliabilitydata`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\Office\15.0\Common`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „updatereliabilitydata” în preferințele Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “updatereliabilitydata” option in Microsoft Office preferences to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L90 · SET-VALUE · `MotherboardUUID`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\Office\Common\ClientTelemetry`
- **Raw .reg data:** `"-"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Motherboard UUID” în preferințele Microsoft Office la - (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Motherboard UUID” option in Microsoft Office preferences to - (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L91 · SET-VALUE · `DisableTelemetry`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\Office\Common\ClientTelemetry`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Disable Telemetry” în preferințele Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Disable Telemetry” option in Microsoft Office preferences to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L92 · SET-VALUE · `VerboseLogging`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\Office\Common\ClientTelemetry`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Verbose Logging” în preferințele Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Verbose Logging” option in Microsoft Office preferences to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L95 · SET-VALUE · `ptwoptin`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\15.0\Common\ptwatson`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „ptwoptin” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “ptwoptin” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L98 · SET-VALUE · `ptwoptin`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Common\ptwatson`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „ptwoptin” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “ptwoptin” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

## Referințe / References

- https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked
