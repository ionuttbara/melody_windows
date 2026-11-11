# Windows Update/Delivery Optimization.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `738a72e61a378e0c40b445623554935465b37faa1614b786377edee186cd88f5`
- **Recipe verdict / verdict rețetă:** `CORRECTED`
- **Windows container / interval Windows:** `10586+`
- **Runtime prerequisite / condiție runtime:** `existing-key`
- **Value/operation descriptions / operații:** 1
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L5 · SET-VALUE · `DODownloadMode`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\DeliveryOptimization`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează Delivery Optimization în modul HTTP-only (0), fără cache peer-to-peer. Operația originală a fost corectată la forma susținută de sursa indicată.
- **What it configures / EN:** Sets Delivery Optimization to HTTP-only mode (0), disabling peer-to-peer caching. The original operation was corrected to the form supported by the cited source.
- **Final verdict / verdict final:** `CORRECTED`
- **Certitudine / Evidence:** Replaced duplicate internal Delivery Optimization values with the documented DODownloadMode=0 policy.
- **OS support / versiuni:** `10586+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/deployment/do/waas-delivery-optimization-reference`

## Referințe / References

- https://learn.microsoft.com/en-us/windows/deployment/do/waas-delivery-optimization-reference
