# Browser Configuration/Edge/Disable Microsoft Edge Copilot and AI.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `ac357a2fbe6c3f63277f06dcddf45f91e86d151bd1083798a35d10c8b08db585`
- **Recipe verdict / verdict rețetă:** `CONDITIONAL`
- **Windows container / interval Windows:** `10240+`
- **Runtime prerequisite / condiție runtime:** `browser-edge`
- **Value/operation descriptions / operații:** 7
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L5 · SET-VALUE · `HubsSidebarEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Hubs Sidebar Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Hubs Sidebar Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L7 · SET-VALUE · `CopilotPageContext`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Copilot Page Context” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Copilot Page Context” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L9 · SET-VALUE · `ComposeInlineEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Compose Inline Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Compose Inline Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L11 · SET-VALUE · `GenAILocalFoundationalModelSettings`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Gen AILocal Foundational Model Settings” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Gen AILocal Foundational Model Settings” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L13 · SET-VALUE · `AIGenThemesEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „AIGen Themes Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “AIGen Themes Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L15 · SET-VALUE · `EdgeHistoryAISearchEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Edge History AISearch Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Edge History AISearch Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L17 · SET-VALUE · `BuiltInAIAPIsEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Built In AIAPIs Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Built In AIAPIs Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

## Referințe / References

- https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies
