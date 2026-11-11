# System/Enable Windows Script Hosting.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `e21500cd292543e75fbe5d33cc02e832dfb5616e71425f1858f4bb3f9d7668bb`
- **Recipe verdict / verdict rețetă:** `CORRECTED`
- **Windows container / interval Windows:** `7600+`
- **Runtime prerequisite / condiție runtime:** `existing-key`
- **Value/operation descriptions / operații:** 1
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L4 · SET-VALUE · `Enabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows Script Host\Settings`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Activează Windows Script Host prin valoarea DWORD Enabled=1. Operația originală a fost corectată la forma susținută de sursa indicată.
- **What it configures / EN:** Enables Windows Script Host through DWORD Enabled=1. The original operation was corrected to the form supported by the cited source.
- **Final verdict / verdict final:** `CORRECTED`
- **Certitudine / Evidence:** Enabled corrected from REG_SZ to REG_DWORD.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/troubleshoot/developer/visualstudio/cpp/language-compilers/disabling-windows-script-host`

## Referințe / References

- https://learn.microsoft.com/en-us/troubleshoot/developer/visualstudio/cpp/language-compilers/disabling-windows-script-host
