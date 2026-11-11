# Browser Configuration/Edge/Microsoft Edge Extensions.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `86319aebfa37ccb4bda809942ce17408f113fc05ad62cc31a8a9c698d316b034`
- **Recipe verdict / verdict rețetă:** `CONDITIONAL`
- **Windows container / interval Windows:** `10240+`
- **Runtime prerequisite / condiție runtime:** `browser-edge`
- **Value/operation descriptions / operații:** 6
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L3 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge\ExtensionInstallForcelist`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „ExtensionInstallForcelist” din politicile Microsoft Edge, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Deletes the entire “ExtensionInstallForcelist” key in Microsoft Edge policies, including all values and subkeys. Exact key semantics are unverified. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L6 · SET-VALUE · `1`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge\ExtensionInstallForcelist`
- **Raw .reg data:** `"ddkjiahejlhfcafbddmgiahcphecmpfh;https://clients2.google.com/service/update2/crx"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „1” în politicile Microsoft Edge la ddkjiahejlhfcafbddmgiahcphecmpfh;https://clients2.google.com/service/update2/crx (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “1” option in Microsoft Edge policies to ddkjiahejlhfcafbddmgiahcphecmpfh;https://clients2.google.com/service/update2/crx (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L7 · SET-VALUE · `2`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge\ExtensionInstallForcelist`
- **Raw .reg data:** `"gebbhagfogifgggkldgodflihgfeippi;https://clients2.google.com/service/update2/crx"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „2” în politicile Microsoft Edge la gebbhagfogifgggkldgodflihgfeippi;https://clients2.google.com/service/update2/crx (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “2” option in Microsoft Edge policies to gebbhagfogifgggkldgodflihgfeippi;https://clients2.google.com/service/update2/crx (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L8 · SET-VALUE · `3`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge\ExtensionInstallForcelist`
- **Raw .reg data:** `"donbcfbmhbcapadipfkeojnmajbakjdc;https://clients2.google.com/service/update2/crx"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „3” în politicile Microsoft Edge la donbcfbmhbcapadipfkeojnmajbakjdc;https://clients2.google.com/service/update2/crx (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “3” option in Microsoft Edge policies to donbcfbmhbcapadipfkeojnmajbakjdc;https://clients2.google.com/service/update2/crx (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L9 · SET-VALUE · `4`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge\ExtensionInstallForcelist`
- **Raw .reg data:** `"oobhedhmcdceknhbgjaeikeoaphaajlf;https://clients2.google.com/service/update2/crx"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „4” în politicile Microsoft Edge la oobhedhmcdceknhbgjaeikeoaphaajlf;https://clients2.google.com/service/update2/crx (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “4” option in Microsoft Edge policies to oobhedhmcdceknhbgjaeikeoaphaajlf;https://clients2.google.com/service/update2/crx (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L10 · SET-VALUE · `5`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge\ExtensionInstallForcelist`
- **Raw .reg data:** `"fihnjjcciajhdojfnbdddfaoknhalnja;https://clients2.google.com/service/update2/crx"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „5” în politicile Microsoft Edge la fihnjjcciajhdojfnbdddfaoknhalnja;https://clients2.google.com/service/update2/crx (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “5” option in Microsoft Edge policies to fihnjjcciajhdojfnbdddfaoknhalnja;https://clients2.google.com/service/update2/crx (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

## Referințe / References

- https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies
