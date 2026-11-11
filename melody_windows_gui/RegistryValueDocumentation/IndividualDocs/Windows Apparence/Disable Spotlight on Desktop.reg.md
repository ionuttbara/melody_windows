# Windows Apparence/Disable Spotlight on Desktop.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `9671b30da45570afbd81fb980f8982532cf218a3fa3227a040d4f2e83517e0a7`
- **Recipe verdict / verdict rețetă:** `CORRECTED`
- **Windows container / interval Windows:** `22000+`
- **Runtime prerequisite / condiție runtime:** `existing-key`
- **Value/operation descriptions / operații:** 1
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L4 · SET-VALUE · `DisableSpotlightCollectionOnDesktop`

- **Registry key:** `HKEY_CURRENT_USER\SOFTWARE\Policies\Microsoft\Windows\CloudContent`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Dezactivează colecția Windows Spotlight pe desktop pentru utilizatorul curent. Operația originală a fost corectată la forma susținută de sursa indicată.
- **What it configures / EN:** Disables the Windows Spotlight collection on the desktop for the current user. The original operation was corrected to the form supported by the cited source.
- **Final verdict / verdict final:** `CORRECTED`
- **Certitudine / Evidence:** Desktop Spotlight policy corrected to the documented user policy hive.
- **OS support / versiuni:** `22000+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-experience`

## Referințe / References

- https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-experience
