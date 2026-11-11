# Taskbar/Remove_Recommended_section_from_Start_Menu_for_all_users.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `1107daa825ae156e84e20651dd19b7b04b3e1d60d88cfa26b743748f0d906822`
- **Recipe verdict / verdict rețetă:** `CONDITIONAL`
- **Windows container / interval Windows:** `22000+`
- **Runtime prerequisite / condiție runtime:** `existing-key`
- **Value/operation descriptions / operații:** 2
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L4 · DELETE-VALUE · `HideRecommendedSection`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Windows\Explorer`
- **Raw .reg data:** `-`
- **Type / tip:** `VALUE DELETE`
- **Ce face / RO:** Elimină opțiunea „Hide Recommended Section” din ramura Policies / Microsoft / Windows; NU echivalează automat cu dezactivarea funcției și poate restabili o valoare implicită. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Removes the “Hide Recommended Section” option from registry branch Policies / Microsoft / Windows; this does NOT necessarily disable the feature and may restore a default behavior. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Explorer policy family; apply only when the target/value exists on this Windows build.
- **OS support / versiuni:** `22000+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-admx-windowsexplorer`

### L7 · SET-VALUE · `HideRecommendedSection`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\Explorer`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Politică meniul Start: ascunde secțiunea Recomandate. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Start menu policy: hides Recommended section. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Explorer policy family; apply only when the target/value exists on this Windows build.
- **OS support / versiuni:** `22000+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-admx-windowsexplorer`

## Referințe / References

- https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-admx-windowsexplorer
