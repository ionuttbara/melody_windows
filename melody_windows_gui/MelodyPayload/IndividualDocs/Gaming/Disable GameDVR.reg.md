# Gaming/Disable GameDVR.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `3a9d370b67040ad77d6e90016f92e3495f16c53cb0a6d902d40e0331e537857d`
- **Recipe verdict / verdict rețetă:** `CORRECTED`
- **Windows container / interval Windows:** `10240+`
- **Runtime prerequisite / condiție runtime:** `existing-key`
- **Value/operation descriptions / operații:** 1
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L5 · SET-VALUE · `AllowGameDVR`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\GameDVR`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Dezactivează Windows Game Recording and Broadcasting prin politica Microsoft AllowGameDVR=0. Operația originală a fost corectată la forma susținută de sursa indicată.
- **What it configures / EN:** Disables Windows Game Recording and Broadcasting through the Microsoft AllowGameDVR=0 policy. The original operation was corrected to the form supported by the cited source.
- **Final verdict / verdict final:** `CORRECTED`
- **Certitudine / Evidence:** Replaced multiple private GameConfigStore/PolicyManager values with the documented AllowGameDVR=0 policy.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-applicationmanagement`

## Referințe / References

- https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-applicationmanagement
