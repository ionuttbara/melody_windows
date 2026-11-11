# Browser Configuration/Chrome/Google Chrome Extensions.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `308668671554da12d20ed197d7b50422ea30b7062290f5cc394bd823f106bb53`
- **Recipe verdict / verdict rețetă:** `CONDITIONAL`
- **Windows container / interval Windows:** `7600+`
- **Runtime prerequisite / condiție runtime:** `browser-chrome`
- **Value/operation descriptions / operații:** 5
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L3 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome\ExtensionInstallForcelist`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „ExtensionInstallForcelist” din politicile Google Chrome, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Deletes the entire “ExtensionInstallForcelist” key in Google Chrome policies, including all values and subkeys. Exact key semantics are unverified. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L6 · SET-VALUE · `1`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome\ExtensionInstallForcelist`
- **Raw .reg data:** `"ddkjiahejlhfcafbddmgiahcphecmpfh"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „1” în politicile Google Chrome la ddkjiahejlhfcafbddmgiahcphecmpfh (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “1” option in Google Chrome policies to ddkjiahejlhfcafbddmgiahcphecmpfh (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L7 · SET-VALUE · `2`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome\ExtensionInstallForcelist`
- **Raw .reg data:** `"gebbhagfogifgggkldgodflihgfeippi"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „2” în politicile Google Chrome la gebbhagfogifgggkldgodflihgfeippi (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “2” option in Google Chrome policies to gebbhagfogifgggkldgodflihgfeippi (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L8 · SET-VALUE · `3`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome\ExtensionInstallForcelist`
- **Raw .reg data:** `"oobhedhmcdceknhbgjaeikeoaphaajlf"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „3” în politicile Google Chrome la oobhedhmcdceknhbgjaeikeoaphaajlf (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “3” option in Google Chrome policies to oobhedhmcdceknhbgjaeikeoaphaajlf (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L9 · SET-VALUE · `4`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome\ExtensionInstallForcelist`
- **Raw .reg data:** `"fihnjjcciajhdojfnbdddfaoknhalnja"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „4” în politicile Google Chrome la fihnjjcciajhdojfnbdddfaoknhalnja (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “4” option in Google Chrome policies to fihnjjcciajhdojfnbdddfaoknhalnja (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

## Referințe / References

- https://chromeenterprise.google/policies/
