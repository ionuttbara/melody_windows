# Windows Search/Disable Cloud Search.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `8c4b0f2f2068fba2baa916ca6f5af99810231ddf911fb081dc872ccfa4e3415f`
- **Recipe verdict / verdict rețetă:** `CORRECTED`
- **Windows container / interval Windows:** `16299+`
- **Runtime prerequisite / condiție runtime:** `existing-key`
- **Value/operation descriptions / operații:** 1
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L5 · SET-VALUE · `AllowCloudSearch`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\Windows Search`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Dezactivează căutarea în surse cloud precum OneDrive și SharePoint prin politica AllowCloudSearch=0. Operația originală a fost corectată la forma susținută de sursa indicată.
- **What it configures / EN:** Disables searching cloud sources such as OneDrive and SharePoint through AllowCloudSearch=0. The original operation was corrected to the form supported by the cited source.
- **Final verdict / verdict final:** `CORRECTED`
- **Certitudine / Evidence:** Replaced private SearchSettings values with the documented AllowCloudSearch=0 policy.
- **OS support / versiuni:** `16299+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-search`

## Referințe / References

- https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-search
