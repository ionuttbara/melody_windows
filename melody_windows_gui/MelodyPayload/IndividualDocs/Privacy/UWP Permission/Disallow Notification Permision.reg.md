# Privacy/UWP Permission/Disallow Notification Permision.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `0d66d175c050f7af1f809cb249050a864e5bcae21d0df4bfd02f2da6a730217a`
- **Recipe verdict / verdict rețetă:** `CONDITIONAL`
- **Windows container / interval Windows:** `15063+`
- **Runtime prerequisite / condiție runtime:** `existing-key`
- **Value/operation descriptions / operații:** 4
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L4 · SET-VALUE · `LetAppsAccessNotifications`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\AppPrivacy`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Politica de confidențialitate pentru notificări: accesul este refuzat obligatoriu (2). Se aplică aplicațiilor Windows și poate împiedica modificarea opțiunii de către utilizator. Semnificația și forma operației sunt susținute de sursa indicată.
- **What it configures / EN:** App privacy policy for notifications: force deny access (2). Applies to Windows apps and can prevent user overrides. The operation meaning and form are supported by the cited source.
- **Final verdict / verdict final:** `VERIFIED`
- **Certitudine / Evidence:** Microsoft App Privacy policy mapping; exact value is registry-backed by AppPrivacy.admx/Policy CSP.
- **OS support / versiuni:** `15063+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-privacy`

### L7 · SET-VALUE · `LetAppsAccessNotifications`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Windows\AppPrivacy`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Încearcă să stabilească politica pentru notificări în HKCU; sursa oficială documentează calea HKLM pentru această politică. Nu presupune că HKCU are efect. Semnificația și forma operației sunt susținute de sursa indicată.
- **What it configures / EN:** Attempts to set the notifications policy in HKCU; vendor docs specify the HKLM policy path. Do not assume this HKCU entry takes effect. The operation meaning and form are supported by the cited source.
- **Final verdict / verdict final:** `VERIFIED`
- **Certitudine / Evidence:** Microsoft App Privacy policy mapping; exact value is registry-backed by AppPrivacy.admx/Policy CSP.
- **OS support / versiuni:** `15063+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-privacy`

### L10 · SET-VALUE · `Value`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\CapabilityAccessManager\ConsentStore\userNotificationListener`
- **Raw .reg data:** `"Deny"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Value” în ramura Microsoft / Windows / CurrentVersion la Deny (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Value” option in registry branch Microsoft / Windows / CurrentVersion to Deny (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Internal/user setting; only an existing value is changed, preventing creation on unsupported builds.
- **OS support / versiuni:** `7600+`

### L13 · SET-VALUE · `Value`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\CapabilityAccessManager\ConsentStore\userNotificationListener`
- **Raw .reg data:** `"Deny"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Value” în ramura Microsoft / Windows / CurrentVersion la Deny (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Value” option in registry branch Microsoft / Windows / CurrentVersion to Deny (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Internal/user setting; only an existing value is changed, preventing creation on unsupported builds.
- **OS support / versiuni:** `7600+`

## Referințe / References

- https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-privacy
