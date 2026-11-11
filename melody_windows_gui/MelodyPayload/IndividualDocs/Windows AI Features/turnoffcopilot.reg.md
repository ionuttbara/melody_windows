# Windows AI Features/turnoffcopilot.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `62be38934e583e91f6defb4732a11b93944a167812e0823eff04ed93eb8a23dd`
- **Recipe verdict / verdict rețetă:** `CORRECTED`
- **Windows container / interval Windows:** `19044.3758+`
- **Runtime prerequisite / condiție runtime:** `copilot-policy`
- **Value/operation descriptions / operații:** 1
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L5 · SET-VALUE · `TurnOffWindowsCopilot`

- **Registry key:** `HKEY_CURRENT_USER\SOFTWARE\Policies\Microsoft\Windows\WindowsCopilot`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Dezactivează experiența Windows Copilot acolo unde politica TurnOffWindowsCopilot este suportată. Operația originală a fost corectată la forma susținută de sursa indicată.
- **What it configures / EN:** Disables the Windows Copilot experience where the TurnOffWindowsCopilot policy is supported. The original operation was corrected to the form supported by the cited source.
- **Final verdict / verdict final:** `CORRECTED`
- **Certitudine / Evidence:** Removed unsupported machine-scope duplicate and kept the documented user TurnOffWindowsCopilot=1 policy.
- **OS support / versiuni:** `19044+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-windowsai`

## Referințe / References

- https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-windowsai
