# Privacy/UWP Permission/Disallow Voice Activation.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `7d452b4e24a6c985ac7fa496b48cdf4025045a5a0023c8927eb8fc49fba8b767`
- **Recipe verdict / verdict rețetă:** `VERIFIED`
- **Windows container / interval Windows:** `19041+`
- **Runtime prerequisite / condiție runtime:** `existing-key`
- **Value/operation descriptions / operații:** 4
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L4 · SET-VALUE · `LetAppsActivateWithVoice`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\AppPrivacy`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Let Apps Activate With Voice” în permisiunile aplicațiilor Windows la 2 (0x00000002) (REG_DWORD). Semnificația și forma operației sunt susținute de sursa indicată.
- **What it configures / EN:** Sets the “Let Apps Activate With Voice” option in Windows app permissions to 2 (0x00000002) (REG_DWORD). The operation meaning and form are supported by the cited source.
- **Final verdict / verdict final:** `VERIFIED`
- **Certitudine / Evidence:** Microsoft App Privacy policy mapping; exact value is registry-backed by AppPrivacy.admx/Policy CSP.
- **OS support / versiuni:** `19041+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-privacy`

### L5 · SET-VALUE · `LetAppsActivateWithVoiceAboveLock`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\AppPrivacy`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Let Apps Activate With Voice Above Lock” în permisiunile aplicațiilor Windows la 2 (0x00000002) (REG_DWORD). Semnificația și forma operației sunt susținute de sursa indicată.
- **What it configures / EN:** Sets the “Let Apps Activate With Voice Above Lock” option in Windows app permissions to 2 (0x00000002) (REG_DWORD). The operation meaning and form are supported by the cited source.
- **Final verdict / verdict final:** `VERIFIED`
- **Certitudine / Evidence:** Microsoft App Privacy policy mapping; exact value is registry-backed by AppPrivacy.admx/Policy CSP.
- **OS support / versiuni:** `19041+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-privacy`

### L8 · SET-VALUE · `LetAppsActivateWithVoice`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Windows\AppPrivacy`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Let Apps Activate With Voice” în permisiunile aplicațiilor Windows la 2 (0x00000002) (REG_DWORD). Semnificația și forma operației sunt susținute de sursa indicată.
- **What it configures / EN:** Sets the “Let Apps Activate With Voice” option in Windows app permissions to 2 (0x00000002) (REG_DWORD). The operation meaning and form are supported by the cited source.
- **Final verdict / verdict final:** `VERIFIED`
- **Certitudine / Evidence:** Microsoft App Privacy policy mapping; exact value is registry-backed by AppPrivacy.admx/Policy CSP.
- **OS support / versiuni:** `19041+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-privacy`

### L9 · SET-VALUE · `LetAppsActivateWithVoiceAboveLock`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Windows\AppPrivacy`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Let Apps Activate With Voice Above Lock” în permisiunile aplicațiilor Windows la 2 (0x00000002) (REG_DWORD). Semnificația și forma operației sunt susținute de sursa indicată.
- **What it configures / EN:** Sets the “Let Apps Activate With Voice Above Lock” option in Windows app permissions to 2 (0x00000002) (REG_DWORD). The operation meaning and form are supported by the cited source.
- **Final verdict / verdict final:** `VERIFIED`
- **Certitudine / Evidence:** Microsoft App Privacy policy mapping; exact value is registry-backed by AppPrivacy.admx/Policy CSP.
- **OS support / versiuni:** `19041+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-privacy`

## Referințe / References

- https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-privacy
