# Microsoft Office/current office 2016 tweaks.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `f2109ab9928243a86a14dc9d788f9f385c2eb9aa0062fd44abdbb65923c7ea33`
- **Recipe verdict / verdict rețetă:** `CONDITIONAL`
- **Windows container / interval Windows:** `7600+`
- **Runtime prerequisite / condiție runtime:** `office16`
- **Value/operation descriptions / operații:** 177
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L6 · SET-VALUE · `dontshowwhatsnew`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Access`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „dontshowwhatsnew” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “dontshowwhatsnew” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L9 · SET-VALUE · `use2007compatiblecache`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Access\settings`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „use2007compatiblecache” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “use2007compatiblecache” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L12 · SET-VALUE · `sentcostumerdata`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Common`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „sentcostumerdata” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “sentcostumerdata” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L13 · SET-VALUE · `SendCustomerDataOptInReason`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Common`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Send Customer Data Opt In Reason” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Send Customer Data Opt In Reason” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L14 · SET-VALUE · `SendCustomerDataOptIn`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Common`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Send Customer Data Opt In” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Send Customer Data Opt In” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L15 · SET-VALUE · `qmenable`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Common`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „qmenable” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “qmenable” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L16 · SET-VALUE · `sendcustomerdata`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Common`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „sendcustomerdata” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “sendcustomerdata” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L17 · SET-VALUE · `updatereliabilitydata`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Common`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „updatereliabilitydata” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “updatereliabilitydata” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L18 · SET-VALUE · `insiderslabbehavior`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Common`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „insiderslabbehavior” în politicile Microsoft Office la 2 (0x00000002) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “insiderslabbehavior” option in Microsoft Office policies to 2 (0x00000002) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L25 · SET-VALUE · `disablecontentsafety`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Common\ai\contentsafety\general`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „disablecontentsafety” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “disablecontentsafety” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L26 · SET-VALUE · `allowedsexualcontent`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Common\ai\contentsafety\general`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „allowedsexualcontent” în politicile Microsoft Office la 2 (0x00000002) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “allowedsexualcontent” option in Microsoft Office policies to 2 (0x00000002) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L27 · SET-VALUE · `allowedviolentcontent`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Common\ai\contentsafety\general`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „allowedviolentcontent” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “allowedviolentcontent” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L28 · SET-VALUE · `allowedselfharmcontent`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Common\ai\contentsafety\general`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „allowedselfharmcontent” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “allowedselfharmcontent” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L29 · SET-VALUE · `allowedhatecontent`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Common\ai\contentsafety\general`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „allowedhatecontent” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “allowedhatecontent” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L34 · SET-VALUE · `disabletraining`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Common\ai\training\general`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „disabletraining” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “disabletraining” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L39 · SET-VALUE · `disabletrainingofadaptivefloatie`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Common\ai\training\specific\adaptivefloatie`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „disabletrainingofadaptivefloatie” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “disabletrainingofadaptivefloatie” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L42 · SET-VALUE · `disableshipasserts`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Common\alerts`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „disableshipasserts” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “disableshipasserts” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L43 · SET-VALUE · `noalertreporting`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Common\alerts`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „noalertreporting” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “noalertreporting” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L46 · SET-VALUE · `replacetext`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Common\autocorrect`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „replacetext” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “replacetext” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L47 · SET-VALUE · `capitalizesentence`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Common\autocorrect`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „capitalizesentence” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “capitalizesentence” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L48 · SET-VALUE · `capitalizenamesofdays`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Common\autocorrect`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „capitalizenamesofdays” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “capitalizenamesofdays” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L49 · SET-VALUE · `correcttwoinitialcapitals`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Common\autocorrect`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „correcttwoinitialcapitals” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “correcttwoinitialcapitals” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L52 · SET-VALUE · `sendtelemetry`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Common\clienttelemetry`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „sendtelemetry” în politicile Microsoft Office la 3 (0x00000003) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “sendtelemetry” option in Microsoft Office policies to 3 (0x00000003) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L55 · SET-VALUE · `configuregetdiagnostics`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Common\diagnostics`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „configuregetdiagnostics” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “configuregetdiagnostics” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L58 · SET-VALUE · `updatereliabilitydata`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Common\Feedback`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „updatereliabilitydata” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “updatereliabilitydata” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L59 · SET-VALUE · `includeemail`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Common\Feedback`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „includeemail” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “includeemail” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L60 · SET-VALUE · `includescreenshot`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Common\Feedback`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „includescreenshot” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “includescreenshot” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L61 · SET-VALUE · `enabled`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Common\Feedback`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „enabled” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “enabled” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L62 · SET-VALUE · `surveyenabled`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Common\Feedback`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „surveyenabled” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “surveyenabled” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L63 · SET-VALUE · `feedbackincludelog`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Common\Feedback`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „feedbackincludelog” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “feedbackincludelog” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L66 · SET-VALUE · `disableresourceidnamemapping`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Common\fileio`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „disableresourceidnamemapping” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “disableresourceidnamemapping” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L69 · SET-VALUE · `PreferCloudSaveLocations`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Common`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Prefer Cloud Save Locations” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Prefer Cloud Save Locations” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L70 · SET-VALUE · `disablecomingsoon`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Common`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „disablecomingsoon” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “disablecomingsoon” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L71 · SET-VALUE · `disablebackgrounds`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Common`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „disablebackgrounds” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “disablebackgrounds” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L72 · SET-VALUE · `signinoptions`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Common`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „signinoptions” în politicile Microsoft Office la 3 (0x00000003) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “signinoptions” option in Microsoft Office policies to 3 (0x00000003) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L73 · SET-VALUE · `shownfirstrunoptin`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Common`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „shownfirstrunoptin” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “shownfirstrunoptin” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L74 · SET-VALUE · `skydrivesigninoption`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Common`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „skydrivesigninoption” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “skydrivesigninoption” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L75 · SET-VALUE · `optindisable`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Common`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „optindisable” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “optindisable” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L76 · SET-VALUE · `disableboottoofficestart`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Common`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „disableboottoofficestart” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “disableboottoofficestart” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L77 · SET-VALUE · `notrack`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Common`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „notrack” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “notrack” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L78 · SET-VALUE · `recommendeddocumentsenabled`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Common`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „recommendeddocumentsenabled” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “recommendeddocumentsenabled” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L81 · SET-VALUE · `disableanimations`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Common\graphics`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „disableanimations” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “disableanimations” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L86 · SET-VALUE · `disablescreenclippings`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Common\insert media\screenshot`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „disablescreenclippings” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “disablescreenclippings” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L89 · SET-VALUE · `disablelinksopenright`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Common\internet`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „disablelinksopenright” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “disablelinksopenright” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L92 · SET-VALUE · `hidemanageaccountlink`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Common\licensing`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „hidemanageaccountlink” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “hidemanageaccountlink” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L95 · SET-VALUE · `ignorereplyspelling`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Common\mailsettings`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „ignorereplyspelling” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “ignorereplyspelling” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L98 · SET-VALUE · `disconnectedstate`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Common\privacy`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „disconnectedstate” în politicile Microsoft Office la 2 (0x00000002) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “disconnectedstate” option in Microsoft Office policies to 2 (0x00000002) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L99 · SET-VALUE · `usercontentdisabled`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Common\privacy`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „usercontentdisabled” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “usercontentdisabled” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L100 · SET-VALUE · `downloadcontentdisabled`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Common\privacy`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „downloadcontentdisabled” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “downloadcontentdisabled” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L101 · SET-VALUE · `controllerconnectedservicesenabled`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Common\privacy`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „controllerconnectedservicesenabled” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “controllerconnectedservicesenabled” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L104 · SET-VALUE · `ptwoptin`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Common\ptwatson`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „ptwoptin” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “ptwoptin” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L109 · SET-VALUE · `useonline`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Common\research\translation`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „useonline” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “useonline” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L110 · SET-VALUE · `usemt`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Common\research\translation`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „usemt” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “usemt” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L113 · SET-VALUE · `disableshipasserts`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Common\shipasserts`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „disableshipasserts” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “disableshipasserts” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L116 · SET-VALUE · `signinoptions`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Common\signin`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „signinoptions” în politicile Microsoft Office la 3 (0x00000003) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “signinoptions” option in Microsoft Office policies to 3 (0x00000003) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L119 · SET-VALUE · `policytipsenabled`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\dlp`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „policytipsenabled” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “policytipsenabled” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L122 · SET-VALUE · `dontshowwhatsnew`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\excel`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „dontshowwhatsnew” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “dontshowwhatsnew” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L125 · SET-VALUE · `rungrammar`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\excel\Options`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „rungrammar” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “rungrammar” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L126 · SET-VALUE · `nosmarttagrecognition`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\excel\Options`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „nosmarttagrecognition” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “nosmarttagrecognition” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L127 · SET-VALUE · `showstats`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\excel\Options`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „showstats” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “showstats” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L128 · SET-VALUE · `transformtosway`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\excel\Options`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „transformtosway” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “transformtosway” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L129 · SET-VALUE · `alertifnotdefault`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\excel\Options`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „alertifnotdefault” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “alertifnotdefault” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L130 · SET-VALUE · `linkedinresumeassistant`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\excel\Options`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „linkedinresumeassistant” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “linkedinresumeassistant” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L131 · SET-VALUE · `livepreview`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\excel\Options`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „livepreview” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “livepreview” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L132 · SET-VALUE · `autogrammar`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\excel\Options`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „autogrammar” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “autogrammar” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L133 · SET-VALUE · `EnableLogging`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\excel\Options`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Enable Logging” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Enable Logging” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L134 · SET-VALUE · `disableboottoofficestart`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\excel\Options`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „disableboottoofficestart” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “disableboottoofficestart” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L137 · SET-VALUE · `fcorrectkeyboard_64_1`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\excel\Options\Assist`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „fcorrectkeyboard 64 1” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “fcorrectkeyboard 64 1” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L138 · SET-VALUE · `ffraction_96_1`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\excel\Options\Assist`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „ffraction 96 1” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “ffraction 96 1” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L139 · SET-VALUE · `femdash_112_1`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\excel\Options\Assist`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „femdash 112 1” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “femdash 112 1” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L142 · SET-VALUE · `disablefrompowerbidatasetorganizationname`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\excel\power bi`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „disablefrompowerbidatasetorganizationname” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “disablefrompowerbidatasetorganizationname” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L147 · SET-VALUE · `enableonload`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\excel\Security\filevalidation`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „enableonload” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “enableonload” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L150 · SET-VALUE · `disableinternetfilesinpv`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\excel\Security\protectedview`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „disableinternetfilesinpv” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “disableinternetfilesinpv” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L151 · SET-VALUE · `disableunsafelocationsinpv`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\excel\Security\protectedview`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „disableunsafelocationsinpv” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “disableunsafelocationsinpv” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L152 · SET-VALUE · `disableattachmentsinpv`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\excel\Security\protectedview`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „disableattachmentsinpv” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “disableattachmentsinpv” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L155 · SET-VALUE · `disabletrusteddocuments`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\excel\Security\trusted documents`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „disabletrusteddocuments” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “disabletrusteddocuments” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L156 · SET-VALUE · `disablenetworktrusteddocuments`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\excel\Security\trusted documents`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „disablenetworktrusteddocuments” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “disablenetworktrusteddocuments” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L159 · SET-VALUE · `enabled`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Feedback`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „enabled” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “enabled” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L160 · SET-VALUE · `includescreenshot`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Feedback`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „includescreenshot” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “includescreenshot” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L161 · SET-VALUE · `includeemail`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Feedback`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „includeemail” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “includeemail” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L162 · SET-VALUE · `feedbackincludelog`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Feedback`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „feedbackincludelog” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “feedbackincludelog” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L163 · SET-VALUE · `surveyenabled`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Feedback`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „surveyenabled” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “surveyenabled” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L164 · SET-VALUE · `updatereliabilitydata`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Feedback`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „updatereliabilitydata” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “updatereliabilitydata” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L167 · SET-VALUE · `disablemovie`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\firstrun`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „disablemovie” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “disablemovie” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L168 · SET-VALUE · `bootedrtm`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\firstrun`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „bootedrtm” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “bootedrtm” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L171 · SET-VALUE · `disablescreenshotautohyperlink`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\gfx`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „disablescreenshotautohyperlink” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “disablescreenshotautohyperlink” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L174 · SET-VALUE · `disableautomaticsendtracking`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Lync`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „disableautomaticsendtracking” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “disableautomaticsendtracking” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L181 · SET-VALUE · `disableboottoofficestart`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\ms project\options\general`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „disableboottoofficestart” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “disableboottoofficestart” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L184 · SET-VALUE · `dontshowwhatsnew`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\onenote`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „dontshowwhatsnew” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “dontshowwhatsnew” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L187 · SET-VALUE · `disablesupportdiagnostics`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\onenote\general`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „disablesupportdiagnostics” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “disablesupportdiagnostics” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L192 · SET-VALUE · `autolink`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\onenote\options\linkednotes`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „autolink” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “autolink” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L195 · SET-VALUE · `msoridonenotedisablememorywindow`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\onenote\options\other`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „msoridonenotedisablememorywindow” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “msoridonenotedisablememorywindow” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L196 · SET-VALUE · `runsystemtrayapp`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\onenote\options\other`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „runsystemtrayapp” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “runsystemtrayapp” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L197 · SET-VALUE · `measurementunit`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\onenote\options\other`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „measurementunit” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “measurementunit” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L198 · SET-VALUE · `disablescreenclippings`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\onenote\options\other`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „disablescreenclippings” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “disablescreenclippings” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L199 · SET-VALUE · `disablescreenclippingballoon`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\onenote\options\other`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „disablescreenclippingballoon” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “disablescreenclippingballoon” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L200 · SET-VALUE · `ismemorywindowdisabled`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\onenote\options\other`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „ismemorywindowdisabled” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “ismemorywindowdisabled” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L203 · SET-VALUE · `disablesendemailtoonenote`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\onenote\options\outlookandweb`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „disablesendemailtoonenote” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “disablesendemailtoonenote” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L206 · SET-VALUE · `disablecomapi`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\onenote\security`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „disablecomapi” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “disablecomapi” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L209 · SET-VALUE · `enablelogging`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\osm`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „enablelogging” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “enablelogging” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L210 · SET-VALUE · `enablefileobfuscation`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\osm`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „enablefileobfuscation” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “enablefileobfuscation” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L211 · SET-VALUE · `enableupload`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\osm`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „enableupload” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “enableupload” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L214 · SET-VALUE · `wdsolution`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\osm\preventedapplications`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „wdsolution” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “wdsolution” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L215 · SET-VALUE · `xlsolution`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\osm\preventedapplications`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „xlsolution” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “xlsolution” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L216 · SET-VALUE · `pptsolution`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\osm\preventedapplications`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „pptsolution” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “pptsolution” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L217 · SET-VALUE · `olksolution`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\osm\preventedapplications`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „olksolution” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “olksolution” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L218 · SET-VALUE · `accesssolution`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\osm\preventedapplications`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „accesssolution” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “accesssolution” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L219 · SET-VALUE · `projectsolution`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\osm\preventedapplications`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „projectsolution” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “projectsolution” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L220 · SET-VALUE · `publishersolution`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\osm\preventedapplications`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „publishersolution” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “publishersolution” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L221 · SET-VALUE · `visiosolution`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\osm\preventedapplications`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „visiosolution” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “visiosolution” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L222 · SET-VALUE · `onenotesolution`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\osm\preventedapplications`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „onenotesolution” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “onenotesolution” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L225 · SET-VALUE · `documentfiles`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\osm\preventedsolutiontypes`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „documentfiles” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “documentfiles” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L226 · SET-VALUE · `templatefiles`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\osm\preventedsolutiontypes`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „templatefiles” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “templatefiles” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L227 · SET-VALUE · `comaddins`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\osm\preventedsolutiontypes`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „comaddins” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “comaddins” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L228 · SET-VALUE · `appaddins`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\osm\preventedsolutiontypes`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „appaddins” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “appaddins” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L229 · SET-VALUE · `agave`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\osm\preventedsolutiontypes`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „agave” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “agave” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L232 · SET-VALUE · `EnableLogging`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Outlook`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Enable Logging” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Enable Logging” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L233 · SET-VALUE · `dontshowwhatsnew`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Outlook`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „dontshowwhatsnew” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “dontshowwhatsnew” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L238 · SET-VALUE · `DisableOutlookMobileHyperlink`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Outlook\options\General`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Disable Outlook Mobile Hyperlink” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Disable Outlook Mobile Hyperlink” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L241 · SET-VALUE · `check`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Outlook\options\spelling`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „check” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “check” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L244 · SET-VALUE · `InitEncrypt`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Outlook\Security`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Init Encrypt” în politicile Microsoft Office la 2 (0x00000002) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Init Encrypt” option in Microsoft Office policies to 2 (0x00000002) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L245 · SET-VALUE · `InitSign`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Outlook\Security`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Init Sign” în politicile Microsoft Office la 2 (0x00000002) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Init Sign” option in Microsoft Office policies to 2 (0x00000002) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L248 · SET-VALUE · `dontshowwhatsnew`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Powerpoint`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „dontshowwhatsnew” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “dontshowwhatsnew” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L251 · SET-VALUE · `rungrammar`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Powerpoint\Options`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „rungrammar” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “rungrammar” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L252 · SET-VALUE · `nosmarttagrecognition`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Powerpoint\Options`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „nosmarttagrecognition” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “nosmarttagrecognition” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L253 · SET-VALUE · `showstats`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Powerpoint\Options`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „showstats” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “showstats” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L254 · SET-VALUE · `transformtosway`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Powerpoint\Options`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „transformtosway” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “transformtosway” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L255 · SET-VALUE · `alertifnotdefault`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Powerpoint\Options`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „alertifnotdefault” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “alertifnotdefault” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L256 · SET-VALUE · `linkedinresumeassistant`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Powerpoint\Options`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „linkedinresumeassistant” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “linkedinresumeassistant” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L257 · SET-VALUE · `livepreview`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Powerpoint\Options`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „livepreview” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “livepreview” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L258 · SET-VALUE · `autogrammar`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Powerpoint\Options`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „autogrammar” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “autogrammar” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L259 · SET-VALUE · `EnableLogging`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Powerpoint\Options`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Enable Logging” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Enable Logging” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L260 · SET-VALUE · `background spell checking`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Powerpoint\Options`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „background spell checking” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “background spell checking” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L261 · SET-VALUE · `dontshowwhatsnew`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Powerpoint\Options`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „dontshowwhatsnew” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “dontshowwhatsnew” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L262 · SET-VALUE · `disableboottoofficestart`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Powerpoint\Options`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „disableboottoofficestart” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “disableboottoofficestart” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L265 · SET-VALUE · `fcorrectkeyboard_64_1`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Powerpoint\Options\Assist`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „fcorrectkeyboard 64 1” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “fcorrectkeyboard 64 1” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L266 · SET-VALUE · `ffraction_96_1`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Powerpoint\Options\Assist`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „ffraction 96 1” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “ffraction 96 1” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L267 · SET-VALUE · `femdash_112_1`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Powerpoint\Options\Assist`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „femdash 112 1” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “femdash 112 1” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L272 · SET-VALUE · `disableinternetfilesinpv`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Powerpoint\Security\protectedview`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „disableinternetfilesinpv” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “disableinternetfilesinpv” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L273 · SET-VALUE · `disableunsafelocationsinpv`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Powerpoint\Security\protectedview`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „disableunsafelocationsinpv” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “disableunsafelocationsinpv” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L274 · SET-VALUE · `disableattachmentsinpv`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Powerpoint\Security\protectedview`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „disableattachmentsinpv” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “disableattachmentsinpv” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L277 · SET-VALUE · `disabletrusteddocuments`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Powerpoint\Security\trusted documents`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „disabletrusteddocuments” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “disabletrusteddocuments” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L278 · SET-VALUE · `disablenetworktrusteddocuments`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Powerpoint\Security\trusted documents`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „disablenetworktrusteddocuments” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “disablenetworktrusteddocuments” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L283 · SET-VALUE · `usestartupdlg`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\publisher\preferences`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „usestartupdlg” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “usestartupdlg” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L284 · SET-VALUE · `disableboottoofficestart`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\publisher\preferences`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „disableboottoofficestart” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “disableboottoofficestart” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L287 · SET-VALUE · `preventfirstlaunchafterinstall`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\teams`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „preventfirstlaunchafterinstall” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “preventfirstlaunchafterinstall” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L290 · SET-VALUE · `dontshowwhatsnew`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\visio`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „dontshowwhatsnew” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “dontshowwhatsnew” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L293 · SET-VALUE · `disableboottoofficestart`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\visio\application`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „disableboottoofficestart” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “disableboottoofficestart” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L296 · SET-VALUE · `dontshowwhatsnew`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Word`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „dontshowwhatsnew” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “dontshowwhatsnew” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L299 · SET-VALUE · `rungrammar`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Word\Options`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „rungrammar” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “rungrammar” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L300 · SET-VALUE · `nosmarttagrecognition`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Word\Options`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „nosmarttagrecognition” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “nosmarttagrecognition” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L301 · SET-VALUE · `showstats`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Word\Options`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „showstats” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “showstats” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L302 · SET-VALUE · `transformtosway`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Word\Options`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „transformtosway” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “transformtosway” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L303 · SET-VALUE · `alertifnotdefault`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Word\Options`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „alertifnotdefault” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “alertifnotdefault” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L304 · SET-VALUE · `linkedinresumeassistant`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Word\Options`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „linkedinresumeassistant” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “linkedinresumeassistant” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L305 · SET-VALUE · `livepreview`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Word\Options`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „livepreview” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “livepreview” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L306 · SET-VALUE · `onlinevideo`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Word\Options`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „onlinevideo” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “onlinevideo” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L307 · SET-VALUE · `DontUpdateLinks`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Word\Options`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Dont Update Links” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Dont Update Links” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L308 · SET-VALUE · `EnableLogging`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Word\Options`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Enable Logging” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Enable Logging” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L309 · SET-VALUE · `autogrammar`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Word\Options`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „autogrammar” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “autogrammar” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L310 · SET-VALUE · `dontshowwhatsnew`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Word\Options`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „dontshowwhatsnew” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “dontshowwhatsnew” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L311 · SET-VALUE · `stopreadaloudeyesoffexperience`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Word\Options`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „stopreadaloudeyesoffexperience” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “stopreadaloudeyesoffexperience” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L312 · SET-VALUE · `disableboottoofficestart`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Word\Options`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „disableboottoofficestart” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “disableboottoofficestart” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L313 · SET-VALUE · `langautodetect`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Word\Options`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „langautodetect” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “langautodetect” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L316 · SET-VALUE · `fcorrectkeyboard_64_1`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Word\Options\Assist`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „fcorrectkeyboard 64 1” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “fcorrectkeyboard 64 1” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L317 · SET-VALUE · `ffraction_96_1`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Word\Options\Assist`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „ffraction 96 1” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “ffraction 96 1” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L318 · SET-VALUE · `femdash_112_1`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Word\Options\Assist`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „femdash 112 1” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “femdash 112 1” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L321 · SET-VALUE · `disablewarningonincludefieldsupdate`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Word\Security`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „disablewarningonincludefieldsupdate” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “disablewarningonincludefieldsupdate” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L322 · SET-VALUE · `vbawarnings`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Word\Security`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „vbawarnings” în politicile Microsoft Office la 3 (0x00000003) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “vbawarnings” option in Microsoft Office policies to 3 (0x00000003) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L323 · SET-VALUE · `vbadigsigtrustedpublishers`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Word\Security`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „vbadigsigtrustedpublishers” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “vbadigsigtrustedpublishers” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L324 · SET-VALUE · `vbarequirelmtrustedpublisher`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Word\Security`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „vbarequirelmtrustedpublisher” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “vbarequirelmtrustedpublisher” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L325 · SET-VALUE · `vbarequiredigsigwithcodesigningeku`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Word\Security`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „vbarequiredigsigwithcodesigningeku” în politicile Microsoft Office la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “vbarequiredigsigwithcodesigningeku” option in Microsoft Office policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L328 · SET-VALUE · `disableinternetfilesinpv`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Word\Security\protectedview`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „disableinternetfilesinpv” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “disableinternetfilesinpv” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L329 · SET-VALUE · `disableunsafelocationsinpv`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Word\Security\protectedview`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „disableunsafelocationsinpv” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “disableunsafelocationsinpv” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L330 · SET-VALUE · `disableattachmentsinpv`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Word\Security\protectedview`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „disableattachmentsinpv” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “disableattachmentsinpv” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L333 · SET-VALUE · `disabletrusteddocuments`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Word\Security\trusted documents`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „disabletrusteddocuments” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “disabletrusteddocuments” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

### L334 · SET-VALUE · `disablenetworktrusteddocuments`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Office\16.0\Word\Security\trusted documents`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „disablenetworktrusteddocuments” în politicile Microsoft Office la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “disablenetworktrusteddocuments” option in Microsoft Office policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Office registry/policy setting; only applied when the corresponding Office major version/value exists.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked`

## Referințe / References

- https://learn.microsoft.com/en-us/deployoffice/security/internet-macros-blocked
