# Privacy/UWP Permission/Allow Webcam and Microphone Permission.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `bdbb11b5cef3dc3bc44fb082db52b3634fc7752085e8f9c665215f7d158dbe77`
- **Recipe verdict / verdict rețetă:** `CONDITIONAL`
- **Windows container / interval Windows:** `14393+`
- **Runtime prerequisite / condiție runtime:** `existing-key`
- **Value/operation descriptions / operații:** 8
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L4 · SET-VALUE · `Value`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\CapabilityAccessManager\ConsentStore\webcam`
- **Raw .reg data:** `"Allow"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Value” în ramura Microsoft / Windows / CurrentVersion la Allow (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Value” option in registry branch Microsoft / Windows / CurrentVersion to Allow (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Internal/user setting; only an existing value is changed, preventing creation on unsupported builds.
- **OS support / versiuni:** `7600+`

### L7 · SET-VALUE · `Value`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\CapabilityAccessManager\ConsentStore\webcam`
- **Raw .reg data:** `"Allow"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Value” în ramura Microsoft / Windows / CurrentVersion la Allow (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Value” option in registry branch Microsoft / Windows / CurrentVersion to Allow (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Internal/user setting; only an existing value is changed, preventing creation on unsupported builds.
- **OS support / versiuni:** `7600+`

### L10 · DELETE-VALUE · `LetAppsAccessCamera`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Windows\AppPrivacy`
- **Raw .reg data:** `-`
- **Type / tip:** `VALUE DELETE`
- **Ce face / RO:** Elimină opțiunea „Let Apps Access Camera” din permisiunile aplicațiilor Windows; NU echivalează automat cu dezactivarea funcției și poate restabili o valoare implicită. Semnificația și forma operației sunt susținute de sursa indicată.
- **What it configures / EN:** Removes the “Let Apps Access Camera” option from Windows app permissions; this does NOT necessarily disable the feature and may restore a default behavior. The operation meaning and form are supported by the cited source.
- **Final verdict / verdict final:** `VERIFIED`
- **Certitudine / Evidence:** Microsoft App Privacy policy mapping; exact value is registry-backed by AppPrivacy.admx/Policy CSP.
- **OS support / versiuni:** `14393+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-privacy`

### L11 · DELETE-VALUE · `LetAppsAccessMicrophone`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Windows\AppPrivacy`
- **Raw .reg data:** `-`
- **Type / tip:** `VALUE DELETE`
- **Ce face / RO:** Elimină opțiunea „Let Apps Access Microphone” din permisiunile aplicațiilor Windows; NU echivalează automat cu dezactivarea funcției și poate restabili o valoare implicită. Semnificația și forma operației sunt susținute de sursa indicată.
- **What it configures / EN:** Removes the “Let Apps Access Microphone” option from Windows app permissions; this does NOT necessarily disable the feature and may restore a default behavior. The operation meaning and form are supported by the cited source.
- **Final verdict / verdict final:** `VERIFIED`
- **Certitudine / Evidence:** Microsoft App Privacy policy mapping; exact value is registry-backed by AppPrivacy.admx/Policy CSP.
- **OS support / versiuni:** `14393+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-privacy`

### L14 · DELETE-VALUE · `LetAppsAccessCamera`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\AppPrivacy`
- **Raw .reg data:** `-`
- **Type / tip:** `VALUE DELETE`
- **Ce face / RO:** Elimină opțiunea „Let Apps Access Camera” din permisiunile aplicațiilor Windows; NU echivalează automat cu dezactivarea funcției și poate restabili o valoare implicită. Semnificația și forma operației sunt susținute de sursa indicată.
- **What it configures / EN:** Removes the “Let Apps Access Camera” option from Windows app permissions; this does NOT necessarily disable the feature and may restore a default behavior. The operation meaning and form are supported by the cited source.
- **Final verdict / verdict final:** `VERIFIED`
- **Certitudine / Evidence:** Microsoft App Privacy policy mapping; exact value is registry-backed by AppPrivacy.admx/Policy CSP.
- **OS support / versiuni:** `14393+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-privacy`

### L15 · DELETE-VALUE · `LetAppsAccessMicrophone`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\AppPrivacy`
- **Raw .reg data:** `-`
- **Type / tip:** `VALUE DELETE`
- **Ce face / RO:** Elimină opțiunea „Let Apps Access Microphone” din permisiunile aplicațiilor Windows; NU echivalează automat cu dezactivarea funcției și poate restabili o valoare implicită. Semnificația și forma operației sunt susținute de sursa indicată.
- **What it configures / EN:** Removes the “Let Apps Access Microphone” option from Windows app permissions; this does NOT necessarily disable the feature and may restore a default behavior. The operation meaning and form are supported by the cited source.
- **Final verdict / verdict final:** `VERIFIED`
- **Certitudine / Evidence:** Microsoft App Privacy policy mapping; exact value is registry-backed by AppPrivacy.admx/Policy CSP.
- **OS support / versiuni:** `14393+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-privacy`

### L18 · SET-VALUE · `Value`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\CapabilityAccessManager\ConsentStore\microphone`
- **Raw .reg data:** `"Allow"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Value” în ramura Microsoft / Windows / CurrentVersion la Allow (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Value” option in registry branch Microsoft / Windows / CurrentVersion to Allow (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Internal/user setting; only an existing value is changed, preventing creation on unsupported builds.
- **OS support / versiuni:** `7600+`

### L21 · SET-VALUE · `Value`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\CapabilityAccessManager\ConsentStore\microphone`
- **Raw .reg data:** `"Allow"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Value” în ramura Microsoft / Windows / CurrentVersion la Allow (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Value” option in registry branch Microsoft / Windows / CurrentVersion to Allow (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Internal/user setting; only an existing value is changed, preventing creation on unsupported builds.
- **OS support / versiuni:** `7600+`

## Referințe / References

- https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-privacy
