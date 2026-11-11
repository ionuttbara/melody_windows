# Windows Explorer/Disable Common Dialog History.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `cd43671e09d210d2931d255e0cbd0c1e84aaf19d3f8bf807ea0aa4d74b7aac2c`
- **Recipe verdict / verdict rețetă:** `CORRECTED`
- **Windows container / interval Windows:** `7600+`
- **Runtime prerequisite / condiție runtime:** `existing-key`
- **Value/operation descriptions / operații:** 1
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L5 · SET-VALUE · `NoFileMru`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Comdlg32`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Dezactivează lista MRU din dialogurile comune Open/Save prin politica NoFileMru=1. Operația originală a fost corectată la forma susținută de sursa indicată.
- **What it configures / EN:** Disables the MRU list in common Open/Save dialogs through the NoFileMru=1 policy. The original operation was corrected to the form supported by the cited source.
- **Final verdict / verdict final:** `CORRECTED`
- **Certitudine / Evidence:** NoFileMru corrected to REG_DWORD 1; deleting it did the opposite of the recipe name.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/previous-versions/windows/desktop/policy/adhering-to-system-policy-settings`

## Referințe / References

- https://learn.microsoft.com/en-us/previous-versions/windows/desktop/policy/adhering-to-system-policy-settings
