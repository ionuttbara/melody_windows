# Browser Configuration/Chrome/Google Chrome Report Extension.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `39a785eff1e96f43c27405fa83583861f1172aae102c2dfd3cdb7320f1b39faa`
- **Recipe verdict / verdict rețetă:** `CONDITIONAL`
- **Windows container / interval Windows:** `7600+`
- **Runtime prerequisite / condiție runtime:** `chrome-report`
- **Value/operation descriptions / operații:** 18
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L4 · SET-VALUE · `report_policy_data`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Google\Chrome\3rdparty\extensions\emahakmocgideepebncgnmlmliepgpgb\Policy`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „report policy data” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “report policy data” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L5 · SET-VALUE · `report_machine_id_data`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Google\Chrome\3rdparty\extensions\emahakmocgideepebncgnmlmliepgpgb\Policy`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „report machine id data” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “report machine id data” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L6 · SET-VALUE · `report_extensions_data`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Google\Chrome\3rdparty\extensions\emahakmocgideepebncgnmlmliepgpgb\Policy`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „report extensions data” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “report extensions data” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L7 · SET-VALUE · `report_version_data`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Google\Chrome\3rdparty\extensions\emahakmocgideepebncgnmlmliepgpgb\Policy`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „report version data” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “report version data” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L8 · SET-VALUE · `report_safe_browsing_data`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Google\Chrome\3rdparty\extensions\emahakmocgideepebncgnmlmliepgpgb\Policy`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „report safe browsing data” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “report safe browsing data” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L9 · SET-VALUE · `report_system_telemetry_data`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Google\Chrome\3rdparty\extensions\emahakmocgideepebncgnmlmliepgpgb\Policy`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „report system telemetry data” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “report system telemetry data” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L10 · SET-VALUE · `report_user_browsing_data`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Google\Chrome\3rdparty\extensions\emahakmocgideepebncgnmlmliepgpgb\Policy`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „report user browsing data” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “report user browsing data” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L11 · SET-VALUE · `report_user_id_data`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Google\Chrome\3rdparty\extensions\emahakmocgideepebncgnmlmliepgpgb\Policy`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „report user id data” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “report user id data” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L12 · SET-VALUE · `log_to_eventlog`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Google\Chrome\3rdparty\extensions\emahakmocgideepebncgnmlmliepgpgb\Policy`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „log to eventlog” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “log to eventlog” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L16 · SET-VALUE · `report_policy_data`

- **Registry key:** `HKEY_LOCAL_MACHINE\Software\Policies\Google\Chrome\3rdparty\extensions\emahakmocgideepebncgnmlmliepgpgb\Policy`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „report policy data” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “report policy data” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L17 · SET-VALUE · `report_machine_id_data`

- **Registry key:** `HKEY_LOCAL_MACHINE\Software\Policies\Google\Chrome\3rdparty\extensions\emahakmocgideepebncgnmlmliepgpgb\Policy`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „report machine id data” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “report machine id data” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L18 · SET-VALUE · `report_extensions_data`

- **Registry key:** `HKEY_LOCAL_MACHINE\Software\Policies\Google\Chrome\3rdparty\extensions\emahakmocgideepebncgnmlmliepgpgb\Policy`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „report extensions data” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “report extensions data” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L19 · SET-VALUE · `report_version_data`

- **Registry key:** `HKEY_LOCAL_MACHINE\Software\Policies\Google\Chrome\3rdparty\extensions\emahakmocgideepebncgnmlmliepgpgb\Policy`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „report version data” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “report version data” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L20 · SET-VALUE · `report_safe_browsing_data`

- **Registry key:** `HKEY_LOCAL_MACHINE\Software\Policies\Google\Chrome\3rdparty\extensions\emahakmocgideepebncgnmlmliepgpgb\Policy`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „report safe browsing data” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “report safe browsing data” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L21 · SET-VALUE · `report_system_telemetry_data`

- **Registry key:** `HKEY_LOCAL_MACHINE\Software\Policies\Google\Chrome\3rdparty\extensions\emahakmocgideepebncgnmlmliepgpgb\Policy`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „report system telemetry data” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “report system telemetry data” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L22 · SET-VALUE · `report_user_browsing_data`

- **Registry key:** `HKEY_LOCAL_MACHINE\Software\Policies\Google\Chrome\3rdparty\extensions\emahakmocgideepebncgnmlmliepgpgb\Policy`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „report user browsing data” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “report user browsing data” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L23 · SET-VALUE · `report_user_id_data`

- **Registry key:** `HKEY_LOCAL_MACHINE\Software\Policies\Google\Chrome\3rdparty\extensions\emahakmocgideepebncgnmlmliepgpgb\Policy`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „report user id data” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “report user id data” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L24 · SET-VALUE · `log_to_eventlog`

- **Registry key:** `HKEY_LOCAL_MACHINE\Software\Policies\Google\Chrome\3rdparty\extensions\emahakmocgideepebncgnmlmliepgpgb\Policy`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „log to eventlog” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “log to eventlog” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

## Referințe / References

- https://chromeenterprise.google/policies/
