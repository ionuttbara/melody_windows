# Windows AI Features/Disable Windows Recall.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `89dc9c2fb8f2355d46fd36a640f573416999e31ccf22c0fa80bfcd686718449b`
- **Recipe verdict / verdict rețetă:** `CONDITIONAL`
- **Windows container / interval Windows:** `26100.3915+`
- **Runtime prerequisite / condiție runtime:** `recall`
- **Value/operation descriptions / operații:** 2
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L6 · SET-VALUE · `AllowRecallEnablement`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\WindowsAI`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Allow Recall Enablement” în politicile Windows AI / Recall la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Allow Recall Enablement” option in Windows AI / Recall policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Documented Windows AI policy; Recall component/support prerequisites required.
- **OS support / versiuni:** `26100+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-windowsai`

### L7 · SET-VALUE · `DisableAIDataAnalysis`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\WindowsAI`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Politica Recall interzice salvarea de instantanee Recall și poate șterge instantaneele existente. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** The Recall policy prevents Recall snapshots from being saved and may delete existing snapshots. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Documented Windows AI policy; Recall component/support prerequisites required.
- **OS support / versiuni:** `26100+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-windowsai`

## Referințe / References

- https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-windowsai
