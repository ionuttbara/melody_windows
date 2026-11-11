# Legacy Optional/Windows Sandbox Policy.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `ac801f70ffb56e3cddfbbec944e49333b5809db679b02ebb0d13665514cd9ddf`
- **Recipe verdict / verdict rețetă:** `CONDITIONAL`
- **Windows container / interval Windows:** `19041.4950+`
- **Runtime prerequisite / condiție runtime:** `sandbox`
- **Value/operation descriptions / operații:** 3
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L5 · SET-VALUE · `AllowVGPU`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\Sandbox`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Politica Windows Sandbox dezactivează accelerarea GPU virtualizată (valoarea 0); mediul trebuie repornit pentru aplicare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Windows Sandbox policy disables virtualized GPU acceleration (value 0); the sandbox must be restarted. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Documented Windows Sandbox policy; optional feature and supported edition required.
- **OS support / versiuni:** `19041+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-windowssandbox`

### L6 · SET-VALUE · `AllowNetworking`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\Sandbox`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Politica Windows Sandbox dezactivează rețeaua în containerul izolat (valoarea 0); mediul trebuie repornit pentru aplicare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Windows Sandbox policy disables network connectivity inside the sandbox (value 0); the sandbox must be restarted. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Documented Windows Sandbox policy; optional feature and supported edition required.
- **OS support / versiuni:** `19041+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-windowssandbox`

### L7 · SET-VALUE · `AllowClipboardRedirection`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\Sandbox`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Politica Windows Sandbox permite transferul clipboard între gazdă și Sandbox (valoarea 1); mediul trebuie repornit pentru aplicare. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Windows Sandbox policy allows clipboard redirection between host and sandbox (value 1); the sandbox must be restarted. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Documented Windows Sandbox policy; optional feature and supported edition required.
- **OS support / versiuni:** `19041+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-windowssandbox`

## Referințe / References

- https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-windowssandbox
