# Privacy/UWP Permission/Disallow Syncronication with Devices.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `d3b269951ec14828d4a9b4eaff33e102b2b6ac6df1e9b829a496a085067d1d23`
- **Recipe verdict / verdict rețetă:** `VERIFIED`
- **Windows container / interval Windows:** `14393+`
- **Runtime prerequisite / condiție runtime:** `existing-key`
- **Value/operation descriptions / operații:** 2
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L4 · SET-VALUE · `LetAppsSyncWithDevices`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Windows\AppPrivacy`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Let Apps Sync With Devices” în permisiunile aplicațiilor Windows la 2 (0x00000002) (REG_DWORD). Semnificația și forma operației sunt susținute de sursa indicată.
- **What it configures / EN:** Sets the “Let Apps Sync With Devices” option in Windows app permissions to 2 (0x00000002) (REG_DWORD). The operation meaning and form are supported by the cited source.
- **Final verdict / verdict final:** `VERIFIED`
- **Certitudine / Evidence:** Microsoft App Privacy policy mapping; exact value is registry-backed by AppPrivacy.admx/Policy CSP.
- **OS support / versiuni:** `14393+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-privacy`

### L7 · SET-VALUE · `LetAppsSyncWithDevices`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\AppPrivacy`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Permisiunea aplicațiilor de a sincroniza dispozitive: refuză sincronizarea. Semnificația și forma operației sunt susținute de sursa indicată.
- **What it configures / EN:** App device synchronization permission: force denies synchronization. The operation meaning and form are supported by the cited source.
- **Final verdict / verdict final:** `VERIFIED`
- **Certitudine / Evidence:** Microsoft App Privacy policy mapping; exact value is registry-backed by AppPrivacy.admx/Policy CSP.
- **OS support / versiuni:** `14393+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-privacy`

## Referințe / References

- https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-privacy
