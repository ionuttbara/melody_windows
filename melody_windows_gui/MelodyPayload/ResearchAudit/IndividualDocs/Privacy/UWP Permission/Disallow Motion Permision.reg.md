# Privacy/UWP Permission/Disallow Motion Permision.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `7cee068b40601b5399477f30cc98908fc31df72dcf6cc765dc758b8a53b3b411`
- **Recipe verdict / verdict rețetă:** `VERIFIED`
- **Windows container / interval Windows:** `14393+`
- **Runtime prerequisite / condiție runtime:** `existing-key`
- **Value/operation descriptions / operații:** 2
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L4 · SET-VALUE · `LetAppsAccessMotion`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\AppPrivacy`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Politica de confidențialitate pentru senzorii de mișcare: accesul este refuzat obligatoriu (2). Se aplică aplicațiilor Windows și poate împiedica modificarea opțiunii de către utilizator. Semnificația și forma operației sunt susținute de sursa indicată.
- **What it configures / EN:** App privacy policy for motion sensors: force deny access (2). Applies to Windows apps and can prevent user overrides. The operation meaning and form are supported by the cited source.
- **Final verdict / verdict final:** `VERIFIED`
- **Certitudine / Evidence:** Microsoft App Privacy policy mapping; exact value is registry-backed by AppPrivacy.admx/Policy CSP.
- **OS support / versiuni:** `14393+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-privacy`

### L7 · SET-VALUE · `LetAppsAccessMotion`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Windows\AppPrivacy`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Încearcă să stabilească politica pentru senzorii de mișcare în HKCU; sursa oficială documentează calea HKLM pentru această politică. Nu presupune că HKCU are efect. Semnificația și forma operației sunt susținute de sursa indicată.
- **What it configures / EN:** Attempts to set the motion sensors policy in HKCU; vendor docs specify the HKLM policy path. Do not assume this HKCU entry takes effect. The operation meaning and form are supported by the cited source.
- **Final verdict / verdict final:** `VERIFIED`
- **Certitudine / Evidence:** Microsoft App Privacy policy mapping; exact value is registry-backed by AppPrivacy.admx/Policy CSP.
- **OS support / versiuni:** `14393+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-privacy`

## Referințe / References

- https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-privacy
