# Browser Configuration/Edge/Microsoft Edge Tweaks.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `4422a2df7a79e516b557feb7b01fd22bee3c7a00651370d204f2976fe8d14678`
- **Recipe verdict / verdict rețetă:** `CONDITIONAL`
- **Windows container / interval Windows:** `10240+`
- **Runtime prerequisite / condiție runtime:** `browser-edge`
- **Value/operation descriptions / operații:** 304
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L4 · SET-VALUE · `PreventTyposquattingPromptOverride`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Prevent Typosquatting Prompt Override” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Prevent Typosquatting Prompt Override” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L5 · SET-VALUE · `EdgeWorkspacesEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Edge Workspaces Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Edge Workspaces Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L6 · SET-VALUE · `GamerModeEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Gamer Mode Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Gamer Mode Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L7 · SET-VALUE · `WindowsHelloForHTTPAuthEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Windows Hello For HTTPAuth Enabled” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Windows Hello For HTTPAuth Enabled” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L8 · SET-VALUE · `BasicAuthOverHttpEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Basic Auth Over Http Enabled” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Basic Auth Over Http Enabled” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L9 · SET-VALUE · `GuidedSwitchEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Guided Switch Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Guided Switch Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L10 · SET-VALUE · `LinkedAccountEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Linked Account Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Linked Account Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L11 · SET-VALUE · `ProactiveAuthWorkflowEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Proactive Auth Workflow Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Proactive Auth Workflow Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L12 · SET-VALUE · `SwitchIntranetSitesToWorkProfile`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Switch Intranet Sites To Work Profile” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Switch Intranet Sites To Work Profile” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L13 · SET-VALUE · `SwitchSitesOnIEModeSiteListToWorkProfile`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Switch Sites On IEMode Site List To Work Profile” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Switch Sites On IEMode Site List To Work Profile” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L14 · SET-VALUE · `WAMAuthBelowWin10RS3Enabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „WAMAuth Below Win10RS3Enabled” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “WAMAuth Below Win10RS3Enabled” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L15 · SET-VALUE · `ImmersiveReaderGrammarToolsEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Immersive Reader Grammar Tools Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Immersive Reader Grammar Tools Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L16 · SET-VALUE · `ImmersiveReaderPictureDictionaryEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Immersive Reader Picture Dictionary Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Immersive Reader Picture Dictionary Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L17 · SET-VALUE · `EdgeManagementUserPolicyOverridesCloudMachinePolicy`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Edge Management User Policy Overrides Cloud Machine Policy” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Edge Management User Policy Overrides Cloud Machine Policy” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L18 · SET-VALUE · `EdgeManagementPolicyOverridesPlatformPolicy`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Edge Management Policy Overrides Platform Policy” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Edge Management Policy Overrides Platform Policy” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L19 · SET-VALUE · `EdgeManagementExtensionsFeedbackEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Edge Management Extensions Feedback Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Edge Management Extensions Feedback Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L20 · SET-VALUE · `EdgeManagementEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Edge Management Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Edge Management Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L21 · SET-VALUE · `MAMEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „MAMEnabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “MAMEnabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L22 · SET-VALUE · `ZstdContentEncodingEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Zstd Content Encoding Enabled” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Zstd Content Encoding Enabled” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L23 · SET-VALUE · `CompressionDictionaryTransportEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Compression Dictionary Transport Enabled” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Compression Dictionary Transport Enabled” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L24 · SET-VALUE · `BlockTruncatedCookies`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Block Truncated Cookies” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Block Truncated Cookies” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L25 · SET-VALUE · `PasswordGeneratorEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Password Generator Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Password Generator Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L26 · SET-VALUE · `PasswordManagerEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Password Manager Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Password Manager Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L27 · SET-VALUE · `PasswordManagerRestrictLengthEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Password Manager Restrict Length Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Password Manager Restrict Length Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L28 · SET-VALUE · `PasswordMonitorAllowed`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Password Monitor Allowed” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Password Monitor Allowed” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L29 · SET-VALUE · `PasswordProtectionWarningTrigger`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Password Protection Warning Trigger” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Password Protection Warning Trigger” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L30 · SET-VALUE · `PrimaryPasswordSetting`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Primary Password Setting” în politicile Microsoft Edge la 3 (0x00000003) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Primary Password Setting” option in Microsoft Edge policies to 3 (0x00000003) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L31 · SET-VALUE · `EfficiencyMode`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Efficiency Mode” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Efficiency Mode” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L32 · SET-VALUE · `EfficiencyModeEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Efficiency Mode Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Efficiency Mode Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L33 · SET-VALUE · `EfficiencyModeOnPowerEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Efficiency Mode On Power Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Efficiency Mode On Power Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L34 · SET-VALUE · `PerformanceDetectorEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Performance Detector Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Performance Detector Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L35 · SET-VALUE · `PinBrowserEssentialsToolbarButton`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Pin Browser Essentials Toolbar Button” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Pin Browser Essentials Toolbar Button” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L36 · SET-VALUE · `StartupBoostEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Startup Boost Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Startup Boost Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L37 · SET-VALUE · `PrintingEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Printing Enabled” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Printing Enabled” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L38 · SET-VALUE · `PrintingBackgroundGraphicsDefault`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `"enabled"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Printing Background Graphics Default” în politicile Microsoft Edge la enabled (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Printing Background Graphics Default” option in Microsoft Edge policies to enabled (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L39 · SET-VALUE · `PrintStickySettings`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Print Sticky Settings” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Print Sticky Settings” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L40 · SET-VALUE · `PrintRasterizationMode`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Print Rasterization Mode” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Print Rasterization Mode” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L41 · SET-VALUE · `PrintPreviewUseSystemDefaultPrinter`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Print Preview Use System Default Printer” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Print Preview Use System Default Printer” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L42 · SET-VALUE · `PrintHeaderFooter`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Print Header Footer” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Print Header Footer” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L43 · SET-VALUE · `InsecurePrivateNetworkRequestsAllowed`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Insecure Private Network Requests Allowed” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Insecure Private Network Requests Allowed” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L44 · SET-VALUE · `RelatedWebsiteSetsEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Related Website Sets Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Related Website Sets Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L45 · SET-VALUE · `SleepingTabsEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Sleeping Tabs Enabled” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Sleeping Tabs Enabled” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L46 · SET-VALUE · `AutoDiscardSleepingTabsEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Auto Discard Sleeping Tabs Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Auto Discard Sleeping Tabs Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L47 · SET-VALUE · `NewSmartScreenLibraryEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „New Smart Screen Library Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “New Smart Screen Library Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L48 · SET-VALUE · `PreventSmartScreenPromptOverride`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Prevent Smart Screen Prompt Override” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Prevent Smart Screen Prompt Override” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L49 · SET-VALUE · `PreventSmartScreenPromptOverrideForFiles`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Prevent Smart Screen Prompt Override For Files” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Prevent Smart Screen Prompt Override For Files” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L50 · SET-VALUE · `SmartScreenDnsRequestsEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Smart Screen Dns Requests Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Smart Screen Dns Requests Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L51 · SET-VALUE · `SmartScreenEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Smart Screen Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Smart Screen Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L52 · SET-VALUE · `SmartScreenForTrustedDownloadsEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Smart Screen For Trusted Downloads Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Smart Screen For Trusted Downloads Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L53 · SET-VALUE · `SmartScreenPuaEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Smart Screen Pua Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Smart Screen Pua Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L54 · SET-VALUE · `NewTabPageQuickLinksEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „New Tab Page Quick Links Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “New Tab Page Quick Links Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L55 · SET-VALUE · `NewTabPageCompanyLogoEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „New Tab Page Company Logo Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “New Tab Page Company Logo Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L56 · SET-VALUE · `NewTabPageBingChatEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „New Tab Page Bing Chat Enabled” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “New Tab Page Bing Chat Enabled” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L57 · SET-VALUE · `NewTabPageAppLauncherEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „New Tab Page App Launcher Enabled” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “New Tab Page App Launcher Enabled” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L58 · SET-VALUE · `ApplicationGuardFavoritesSyncEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Application Guard Favorites Sync Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Application Guard Favorites Sync Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L59 · SET-VALUE · `ApplicationGuardPassiveModeEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Application Guard Passive Mode Enabled” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Application Guard Passive Mode Enabled” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L60 · SET-VALUE · `ApplicationGuardTrafficIdentificationEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Application Guard Traffic Identification Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Application Guard Traffic Identification Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L61 · SET-VALUE · `ApplicationGuardUploadBlockingEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Application Guard Upload Blocking Enabled” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Application Guard Upload Blocking Enabled” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L62 · SET-VALUE · `EnableMediaRouter`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Enable Media Router” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Enable Media Router” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L63 · SET-VALUE · `ShowCastIconInToolbar`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Show Cast Icon In Toolbar” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Show Cast Icon In Toolbar” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L64 · SET-VALUE · `EdgeDisableDialProtocolForCastDiscovery`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Edge Disable Dial Protocol For Cast Discovery” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Edge Disable Dial Protocol For Cast Discovery” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L65 · SET-VALUE · `DefaultAutomaticDownloadsSetting`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Default Automatic Downloads Setting” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Automatic Downloads Setting” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L66 · SET-VALUE · `DefaultCookiesSetting`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Default Cookies Setting” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Cookies Setting” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L67 · SET-VALUE · `DefaultFileSystemReadGuardSetting`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Default File System Read Guard Setting” în politicile Microsoft Edge la 3 (0x00000003) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default File System Read Guard Setting” option in Microsoft Edge policies to 3 (0x00000003) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L68 · SET-VALUE · `DefaultFileSystemWriteGuardSetting`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Default File System Write Guard Setting” în politicile Microsoft Edge la 3 (0x00000003) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default File System Write Guard Setting” option in Microsoft Edge policies to 3 (0x00000003) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L69 · SET-VALUE · `DefaultGeolocationSetting`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Default Geolocation Setting” în politicile Microsoft Edge la 2 (0x00000002) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Geolocation Setting” option in Microsoft Edge policies to 2 (0x00000002) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L70 · SET-VALUE · `DefaultImagesSetting`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Default Images Setting” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Images Setting” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L71 · SET-VALUE · `DefaultInsecureContentSetting`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Default Insecure Content Setting” în politicile Microsoft Edge la 3 (0x00000003) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Insecure Content Setting” option in Microsoft Edge policies to 3 (0x00000003) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L72 · SET-VALUE · `DefaultJavaScriptJitSetting`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Default Java Script Jit Setting” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Java Script Jit Setting” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L73 · SET-VALUE · `DefaultNotificationsSetting`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Default Notifications Setting” în politicile Microsoft Edge la 3 (0x00000003) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Notifications Setting” option in Microsoft Edge policies to 3 (0x00000003) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L74 · SET-VALUE · `DefaultPluginsSetting`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Default Plugins Setting” în politicile Microsoft Edge la 3 (0x00000003) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Plugins Setting” option in Microsoft Edge policies to 3 (0x00000003) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L75 · SET-VALUE · `DefaultPopupsSetting`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Default Popups Setting” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Popups Setting” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L76 · SET-VALUE · `DefaultWebBluetoothGuardSetting`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Default Web Bluetooth Guard Setting” în politicile Microsoft Edge la 3 (0x00000003) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Web Bluetooth Guard Setting” option in Microsoft Edge policies to 3 (0x00000003) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L77 · SET-VALUE · `DefaultWebHidGuardSetting`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Default Web Hid Guard Setting” în politicile Microsoft Edge la 3 (0x00000003) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Web Hid Guard Setting” option in Microsoft Edge policies to 3 (0x00000003) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L78 · SET-VALUE · `DefaultWebUsbGuardSetting`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Default Web Usb Guard Setting” în politicile Microsoft Edge la 3 (0x00000003) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Web Usb Guard Setting” option in Microsoft Edge policies to 3 (0x00000003) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L79 · SET-VALUE · `DefaultWindowManagementSetting`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Default Window Management Setting” în politicile Microsoft Edge la 3 (0x00000003) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Window Management Setting” option in Microsoft Edge policies to 3 (0x00000003) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L80 · SET-VALUE · `IntranetFileLinksEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Intranet File Links Enabled” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Intranet File Links Enabled” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L81 · SET-VALUE · `LegacySameSiteCookieBehaviorEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Legacy Same Site Cookie Behavior Enabled” în politicile Microsoft Edge la 2 (0x00000002) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Legacy Same Site Cookie Behavior Enabled” option in Microsoft Edge policies to 2 (0x00000002) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L82 · SET-VALUE · `DefaultSearchProviderEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Default Search Provider Enabled” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Search Provider Enabled” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L83 · SET-VALUE · `DefaultSearchProviderImageURL`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `"{google:baseURL}searchbyimage/upload"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Default Search Provider Image URL” în politicile Microsoft Edge la {google:baseURL}searchbyimage/upload (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Search Provider Image URL” option in Microsoft Edge policies to {google:baseURL}searchbyimage/upload (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L84 · SET-VALUE · `DefaultSearchProviderImageURLPostParams`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `"encoded_image={google:imageThumbnail},image_url={google:imageURL},sbisrc={google:imageSearchSource},original_width={google:imageOriginalWidth},original_height={google:imageOriginalHeight}"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Default Search Provider Image URLPost Params” în politicile Microsoft Edge la encoded_image={google:imageThumbnail},image_url={google:imageURL},sbisrc={google:imageSearchSource},original_width={google:imageOriginalWidth},original_height={google:imageOriginalHeight} (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Search Provider Image URLPost Params” option in Microsoft Edge policies to encoded_image={google:imageThumbnail},image_url={google:imageURL},sbisrc={google:imageSearchSource},original_width={google:imageOriginalWidth},original_height={google:imageOriginalHeight} (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L85 · SET-VALUE · `DefaultSearchProviderSearchURL`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `"{google:baseURL}search?q={searchTerms}&{google:RLZ}{google:originalQueryForSuggestion}{google:assistedQueryStats}{google:searchFieldtrialParameter}{google:searchClient}{google:sourceId}ie={inputEncoding}"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Default Search Provider Search URL” în politicile Microsoft Edge la {google:baseURL}search?q={searchTerms}&{google:RLZ}{google:originalQueryForSuggestion}{google:assistedQueryStats}{google:searchFieldtrialParameter}{google:searchClient}{google:sourceId}ie={inputEncoding} (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Search Provider Search URL” option in Microsoft Edge policies to {google:baseURL}search?q={searchTerms}&{google:RLZ}{google:originalQueryForSuggestion}{google:assistedQueryStats}{google:searchFieldtrialParameter}{google:searchClient}{google:sourceId}ie={inputEncoding} (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L86 · SET-VALUE · `DefaultSearchProviderSuggestURL`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `"{google:baseURL}complete/search?output=chrome&q={searchTerms}"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Default Search Provider Suggest URL” în politicile Microsoft Edge la {google:baseURL}complete/search?output=chrome&q={searchTerms} (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Search Provider Suggest URL” option in Microsoft Edge policies to {google:baseURL}complete/search?output=chrome&q={searchTerms} (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L87 · SET-VALUE · `NewTabPageSearchBox`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `"redirect"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „New Tab Page Search Box” în politicile Microsoft Edge la redirect (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “New Tab Page Search Box” option in Microsoft Edge policies to redirect (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L88 · SET-VALUE · `DefaultSearchProviderName`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `"Google"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Default Search Provider Name” în politicile Microsoft Edge la Google (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Search Provider Name” option in Microsoft Edge policies to Google (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L89 · SET-VALUE · `DefaultSearchProviderKeyword`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `"googl"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Default Search Provider Keyword” în politicile Microsoft Edge la googl (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Search Provider Keyword” option in Microsoft Edge policies to googl (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L90 · SET-VALUE · `TyposquattingCheckerEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Typosquatting Checker Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Typosquatting Checker Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L91 · SET-VALUE · `AccessibilityImageLabelsEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Accessibility Image Labels Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Accessibility Image Labels Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L92 · SET-VALUE · `AdditionalSearchBoxEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Additional Search Box Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Additional Search Box Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L93 · SET-VALUE · `AddressBarMicrosoftSearchInBingProviderEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Address Bar Microsoft Search In Bing Provider Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Address Bar Microsoft Search In Bing Provider Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L94 · SET-VALUE · `AdsSettingForIntrusiveAdsSites`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Ads Setting For Intrusive Ads Sites” în politicile Microsoft Edge la 2 (0x00000002) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Ads Setting For Intrusive Ads Sites” option in Microsoft Edge policies to 2 (0x00000002) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L95 · SET-VALUE · `AdsTransparencyEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Ads Transparency Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Ads Transparency Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L96 · SET-VALUE · `AllowBackForwardCacheForCacheControlNoStorePageEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Allow Back Forward Cache For Cache Control No Store Page Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Allow Back Forward Cache For Cache Control No Store Page Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L97 · SET-VALUE · `AllowDeletingBrowserHistory`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Allow Deleting Browser History” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Allow Deleting Browser History” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L98 · SET-VALUE · `AllowFileSelectionDialogs`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Allow File Selection Dialogs” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Allow File Selection Dialogs” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L99 · SET-VALUE · `AllowGamesMenu`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Allow Games Menu” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Allow Games Menu” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L100 · SET-VALUE · `AllowSurfGame`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Allow Surf Game” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Allow Surf Game” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L101 · SET-VALUE · `AllowSystemNotifications`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Allow System Notifications” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Allow System Notifications” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L102 · SET-VALUE · `AlternateErrorPagesEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Alternate Error Pages Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Alternate Error Pages Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L103 · SET-VALUE · `AlwaysOpenPdfExternally`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Always Open Pdf Externally” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Always Open Pdf Externally” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L104 · SET-VALUE · `AppCacheForceEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „App Cache Force Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “App Cache Force Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L105 · SET-VALUE · `AskBeforeCloseEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Ask Before Close Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Ask Before Close Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L106 · SET-VALUE · `AudioCaptureAllowed`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Audio Capture Allowed” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Audio Capture Allowed” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L107 · SET-VALUE · `AudioProcessHighPriorityEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Audio Process High Priority Enabled” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Audio Process High Priority Enabled” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L108 · SET-VALUE · `AudioSandboxEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Audio Sandbox Enabled” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Audio Sandbox Enabled” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L109 · SET-VALUE · `AutoImportAtFirstRun`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000004`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Auto Import At First Run” în politicile Microsoft Edge la 4 (0x00000004) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Auto Import At First Run” option in Microsoft Edge policies to 4 (0x00000004) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L110 · SET-VALUE · `AutoLaunchProtocolsComponentEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Auto Launch Protocols Component Enabled” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Auto Launch Protocols Component Enabled” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L111 · SET-VALUE · `AutofillAddressEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Autofill Address Enabled” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Autofill Address Enabled” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L112 · SET-VALUE · `AutofillCreditCardEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Autofill Credit Card Enabled” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Autofill Credit Card Enabled” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L113 · SET-VALUE · `AutofillMembershipsEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Autofill Memberships Enabled” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Autofill Memberships Enabled” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L114 · SET-VALUE · `AutomaticHttpsDefault`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Automatic Https Default” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Automatic Https Default” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L115 · SET-VALUE · `AutoplayAllowed`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Autoplay Allowed” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Autoplay Allowed” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L116 · SET-VALUE · `BackgroundModeEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Background Mode Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Background Mode Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L117 · SET-VALUE · `BackgroundTemplateListUpdatesEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Background Template List Updates Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Background Template List Updates Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L118 · SET-VALUE · `BeforeunloadEventCancelByPreventDefaultEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Beforeunload Event Cancel By Prevent Default Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Beforeunload Event Cancel By Prevent Default Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L119 · SET-VALUE · `BingAdsSuppression`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Bing Ads Suppression” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Bing Ads Suppression” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L120 · SET-VALUE · `BlockThirdPartyCookies`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Block Third Party Cookies” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Block Third Party Cookies” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L121 · SET-VALUE · `BrowserCodeIntegritySetting`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Browser Code Integrity Setting” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Browser Code Integrity Setting” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L122 · SET-VALUE · `BrowserGuestModeEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Browser Guest Mode Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Browser Guest Mode Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L123 · SET-VALUE · `BrowserLegacyExtensionPointsBlockingEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Browser Legacy Extension Points Blocking Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Browser Legacy Extension Points Blocking Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L124 · SET-VALUE · `BrowserNetworkTimeQueriesEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Browser Network Time Queries Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Browser Network Time Queries Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L125 · SET-VALUE · `BrowserSignin`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Browser Signin” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Browser Signin” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L126 · SET-VALUE · `BuiltInDnsClientEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Built In Dns Client Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Built In Dns Client Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L127 · SET-VALUE · `ClearCachedImagesAndFilesOnExit`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Clear Cached Images And Files On Exit” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Clear Cached Images And Files On Exit” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L128 · SET-VALUE · `ClickOnceEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Click Once Enabled” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Click Once Enabled” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L129 · SET-VALUE · `CommandLineFlagSecurityWarningsEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Command Line Flag Security Warnings Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Command Line Flag Security Warnings Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L130 · SET-VALUE · `ComponentUpdatesEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Component Updates Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Component Updates Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L131 · SET-VALUE · `ConfigureDoNotTrack`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Configure Do Not Track” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Configure Do Not Track” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L132 · SET-VALUE · `ConfigureFriendlyURLFormat`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Configure Friendly URLFormat” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Configure Friendly URLFormat” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L133 · SET-VALUE · `ConfigureOnlineTextToSpeech`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Configure Online Text To Speech” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Configure Online Text To Speech” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L134 · SET-VALUE · `ConfigureShare`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Configure Share” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Configure Share” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L135 · SET-VALUE · `CopilotCDPPageContext`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Copilot CDPPage Context” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Copilot CDPPage Context” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L136 · SET-VALUE · `CrossOriginWebAssemblyModuleSharingEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Cross Origin Web Assembly Module Sharing Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Cross Origin Web Assembly Module Sharing Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L137 · SET-VALUE · `CryptoWalletEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Crypto Wallet Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Crypto Wallet Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L138 · SET-VALUE · `DNSInterceptionChecksEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „DNSInterception Checks Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “DNSInterception Checks Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L139 · SET-VALUE · `DefaultBrowserSettingEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Default Browser Setting Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Browser Setting Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L140 · SET-VALUE · `DefaultBrowserSettingsCampaignEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Default Browser Settings Campaign Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Browser Settings Campaign Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L141 · SET-VALUE · `DefaultClipboardSetting`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Default Clipboard Setting” în politicile Microsoft Edge la 3 (0x00000003) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Clipboard Setting” option in Microsoft Edge policies to 3 (0x00000003) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L142 · SET-VALUE · `DefaultSearchProviderContextMenuAccessAllowed`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Default Search Provider Context Menu Access Allowed” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Search Provider Context Menu Access Allowed” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L143 · SET-VALUE · `DefaultSensorsSetting`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Default Sensors Setting” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Sensors Setting” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L144 · SET-VALUE · `DefaultSerialGuardSetting`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Default Serial Guard Setting” în politicile Microsoft Edge la 3 (0x00000003) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Serial Guard Setting” option in Microsoft Edge policies to 3 (0x00000003) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L145 · SET-VALUE · `DefaultShareAdditionalOSRegionSetting`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Default Share Additional OSRegion Setting” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Share Additional OSRegion Setting” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L146 · SET-VALUE · `DeleteDataOnMigration`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Delete Data On Migration” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Delete Data On Migration” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L147 · SET-VALUE · `DiagnosticData`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Diagnostic Data” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Diagnostic Data” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L148 · SET-VALUE · `DirectInvokeEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Direct Invoke Enabled” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Direct Invoke Enabled” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L149 · SET-VALUE · `Disable3DAPIs`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Disable3DAPIs” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Disable3DAPIs” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L150 · SET-VALUE · `DisableScreenshots`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Disable Screenshots” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Disable Screenshots” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L151 · SET-VALUE · `DiscoverPageContextEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Discover Page Context Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Discover Page Context Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L152 · SET-VALUE · `DownloadRestrictions`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Download Restrictions” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Download Restrictions” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L153 · SET-VALUE · `Edge3PSerpTelemetryEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Edge3PSerp Telemetry Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Edge3PSerp Telemetry Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L154 · SET-VALUE · `EdgeAssetDeliveryServiceEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Edge Asset Delivery Service Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Edge Asset Delivery Service Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L155 · SET-VALUE · `EdgeCollectionsEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Edge Collections Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Edge Collections Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L156 · SET-VALUE · `EdgeDiscoverEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Edge Discover Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Edge Discover Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L157 · SET-VALUE · `EdgeEDropEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Edge EDrop Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Edge EDrop Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L158 · SET-VALUE · `EdgeEnhanceImagesEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Edge Enhance Images Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Edge Enhance Images Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L159 · SET-VALUE · `EdgeFollowEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Edge Follow Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Edge Follow Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L160 · SET-VALUE · `EdgeOpenInSidebarEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Edge Open In Sidebar Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Edge Open In Sidebar Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L161 · SET-VALUE · `EdgeShoppingAssistantEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Edge Shopping Assistant Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Edge Shopping Assistant Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L162 · SET-VALUE · `EdgeWalletCheckoutEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Edge Wallet Checkout Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Edge Wallet Checkout Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L163 · SET-VALUE · `EdgeWalletEtreeEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Edge Wallet Etree Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Edge Wallet Etree Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L164 · SET-VALUE · `EnableDomainActionsDownload`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Enable Domain Actions Download” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Enable Domain Actions Download” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L165 · SET-VALUE · `EnableOnlineRevocationChecks`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Enable Online Revocation Checks” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Enable Online Revocation Checks” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L166 · SET-VALUE · `EnhanceSecurityModeAllowUserBypass`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Enhance Security Mode Allow User Bypass” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Enhance Security Mode Allow User Bypass” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L167 · SET-VALUE · `EnhanceSecurityModeBypassIntranet`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Enhance Security Mode Bypass Intranet” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Enhance Security Mode Bypass Intranet” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L168 · SET-VALUE · `EnhanceSecurityModeIndicatorUIEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Enhance Security Mode Indicator UIEnabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Enhance Security Mode Indicator UIEnabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L169 · SET-VALUE · `EnhanceSecurityModeOptOutUXEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Enhance Security Mode Opt Out UXEnabled” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Enhance Security Mode Opt Out UXEnabled” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L170 · SET-VALUE · `EnterpriseHardwarePlatformAPIEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Enterprise Hardware Platform APIEnabled” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Enterprise Hardware Platform APIEnabled” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L171 · SET-VALUE · `ExperimentationAndConfigurationServiceControl`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Experimentation And Configuration Service Control” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Experimentation And Configuration Service Control” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L172 · SET-VALUE · `FamilySafetySettingsEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Family Safety Settings Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Family Safety Settings Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L173 · SET-VALUE · `FavoritesBarEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Favorites Bar Enabled” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Favorites Bar Enabled” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L174 · SET-VALUE · `ForceBingSafeSearch`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Force Bing Safe Search” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Force Bing Safe Search” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L175 · SET-VALUE · `ForceBuiltInPushMessagingClient`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Force Built In Push Messaging Client” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Force Built In Push Messaging Client” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L176 · SET-VALUE · `ForceGoogleSafeSearch`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Force Google Safe Search” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Force Google Safe Search” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L177 · SET-VALUE · `ForceNetworkInProcess`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Force Network In Process” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Force Network In Process” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L178 · SET-VALUE · `ForcePermissionPolicyUnloadDefaultEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Force Permission Policy Unload Default Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Force Permission Policy Unload Default Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L179 · SET-VALUE · `ForceYouTubeRestrict`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Force You Tube Restrict” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Force You Tube Restrict” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L180 · SET-VALUE · `FullscreenAllowed`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Fullscreen Allowed” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Fullscreen Allowed” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L181 · SET-VALUE · `GloballyScopeHTTPAuthCacheEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Globally Scope HTTPAuth Cache Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Globally Scope HTTPAuth Cache Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L182 · SET-VALUE · `HardwareAccelerationModeEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Hardware Acceleration Mode Enabled” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Hardware Acceleration Mode Enabled” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L183 · SET-VALUE · `HideFirstRunExperience`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Hide First Run Experience” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Hide First Run Experience” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L184 · SET-VALUE · `HideInternetExplorerRedirectUXForIncompatibleSitesEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Hide Internet Explorer Redirect UXFor Incompatible Sites Enabled” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Hide Internet Explorer Redirect UXFor Incompatible Sites Enabled” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L185 · SET-VALUE · `HideRestoreDialogEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Hide Restore Dialog Enabled” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Hide Restore Dialog Enabled” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L186 · SET-VALUE · `ImportOnEachLaunch`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Import On Each Launch” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Import On Each Launch” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L187 · SET-VALUE · `InsecureFormsWarningsEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Insecure Forms Warnings Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Insecure Forms Warnings Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L188 · SET-VALUE · `InternetExplorerIntegrationEnhancedHangDetection`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Internet Explorer Integration Enhanced Hang Detection” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Internet Explorer Integration Enhanced Hang Detection” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L189 · SET-VALUE · `InternetExplorerIntegrationComplexNavDataTypes`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Internet Explorer Integration Complex Nav Data Types” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Internet Explorer Integration Complex Nav Data Types” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L190 · SET-VALUE · `InternetExplorerIntegrationLevel`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Internet Explorer Integration Level” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Internet Explorer Integration Level” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L191 · SET-VALUE · `InternetExplorerIntegrationLocalFileShowContextMenu`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Internet Explorer Integration Local File Show Context Menu” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Internet Explorer Integration Local File Show Context Menu” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L192 · SET-VALUE · `InternetExplorerIntegrationTestingAllowed`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Internet Explorer Integration Testing Allowed” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Internet Explorer Integration Testing Allowed” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L193 · SET-VALUE · `InternetExplorerModeClearDataOnExitEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Internet Explorer Mode Clear Data On Exit Enabled” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Internet Explorer Mode Clear Data On Exit Enabled” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L194 · SET-VALUE · `InternetExplorerModeEnableSavePageAs`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Internet Explorer Mode Enable Save Page As” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Internet Explorer Mode Enable Save Page As” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L195 · SET-VALUE · `IntranetRedirectBehavior`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Intranet Redirect Behavior” în politicile Microsoft Edge la 2 (0x00000002) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Intranet Redirect Behavior” option in Microsoft Edge policies to 2 (0x00000002) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L196 · SET-VALUE · `LiveCaptionsAllowed`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Live Captions Allowed” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Live Captions Allowed” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L197 · SET-VALUE · `LocalBrowserDataShareEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Local Browser Data Share Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Local Browser Data Share Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L198 · SET-VALUE · `LocalProvidersEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Local Providers Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Local Providers Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L199 · SET-VALUE · `MathSolverEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Math Solver Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Math Solver Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L200 · SET-VALUE · `MediaRouterCastAllowAllIPs`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Media Router Cast Allow All IPs” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Media Router Cast Allow All IPs” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L201 · SET-VALUE · `MetricsReportingEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Metrics Reporting Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Metrics Reporting Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L202 · SET-VALUE · `MicrosoftEdgeInsiderPromotionEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Microsoft Edge Insider Promotion Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Microsoft Edge Insider Promotion Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L203 · SET-VALUE · `MicrosoftEditorProofingEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Microsoft Editor Proofing Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Microsoft Editor Proofing Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L204 · SET-VALUE · `MicrosoftEditorSynonymsEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Microsoft Editor Synonyms Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Microsoft Editor Synonyms Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L205 · SET-VALUE · `MicrosoftOfficeMenuEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Microsoft Office Menu Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Microsoft Office Menu Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L206 · SET-VALUE · `MouseGestureEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Mouse Gesture Enabled” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Mouse Gesture Enabled” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L207 · SET-VALUE · `MutationEventsEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Mutation Events Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Mutation Events Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L208 · SET-VALUE · `NetworkPredictionOptions`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Network Prediction Options” în politicile Microsoft Edge la 2 (0x00000002) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Network Prediction Options” option in Microsoft Edge policies to 2 (0x00000002) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L209 · SET-VALUE · `NetworkServiceSandboxEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Network Service Sandbox Enabled” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Network Service Sandbox Enabled” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L210 · SET-VALUE · `NewPDFReaderEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „New PDFReader Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “New PDFReader Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L211 · SET-VALUE · `NonRemovableProfileEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Non Removable Profile Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Non Removable Profile Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L212 · SET-VALUE · `OutlookHubMenuEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Outlook Hub Menu Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Outlook Hub Menu Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L213 · SET-VALUE · `PDFXFAEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „PDFXFAEnabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “PDFXFAEnabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L214 · SET-VALUE · `PersonalizationReportingEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Personalization Reporting Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Personalization Reporting Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L215 · SET-VALUE · `PictureInPictureOverlayEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Picture In Picture Overlay Enabled” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Picture In Picture Overlay Enabled” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L216 · SET-VALUE · `PinningWizardAllowed`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Pinning Wizard Allowed” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Pinning Wizard Allowed” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L217 · SET-VALUE · `QRCodeGeneratorEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „QRCode Generator Enabled” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “QRCode Generator Enabled” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L218 · SET-VALUE · `QuicAllowed`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Quic Allowed” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Quic Allowed” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L219 · SET-VALUE · `QuickSearchShowMiniMenu`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Quick Search Show Mini Menu” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Quick Search Show Mini Menu” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L220 · SET-VALUE · `QuickViewOfficeFilesEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Quick View Office Files Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Quick View Office Files Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L221 · SET-VALUE · `ReadAloudEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Read Aloud Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Read Aloud Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L222 · SET-VALUE · `RedirectSitesFromInternetExplorerPreventBHOInstall`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Redirect Sites From Internet Explorer Prevent BHOInstall” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Redirect Sites From Internet Explorer Prevent BHOInstall” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L223 · SET-VALUE · `RemoteDebuggingAllowed`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Remote Debugging Allowed” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Remote Debugging Allowed” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L224 · SET-VALUE · `RendererCodeIntegrityEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Renderer Code Integrity Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Renderer Code Integrity Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L225 · SET-VALUE · `RendererAppContainerEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Renderer App Container Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Renderer App Container Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L226 · SET-VALUE · `ResolveNavigationErrorsUseWebService`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Resolve Navigation Errors Use Web Service” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Resolve Navigation Errors Use Web Service” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L227 · SET-VALUE · `RestorePdfView`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Restore Pdf View” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Restore Pdf View” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L228 · SET-VALUE · `RoamingProfileSupportEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Roaming Profile Support Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Roaming Profile Support Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L229 · SET-VALUE · `RunAllFlashInAllowMode`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Run All Flash In Allow Mode” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Run All Flash In Allow Mode” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L230 · SET-VALUE · `SSLErrorOverrideAllowed`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „SSLError Override Allowed” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “SSLError Override Allowed” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L231 · SET-VALUE · `SandboxExternalProtocolBlocked`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Sandbox External Protocol Blocked” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Sandbox External Protocol Blocked” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L232 · SET-VALUE · `ScreenCaptureAllowed`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Screen Capture Allowed” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Screen Capture Allowed” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L233 · SET-VALUE · `SearchFiltersEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Search Filters Enabled” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Search Filters Enabled” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L234 · SET-VALUE · `SearchForImageEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Search For Image Enabled” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Search For Image Enabled” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L235 · SET-VALUE · `SearchInSidebarEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Search In Sidebar Enabled” în politicile Microsoft Edge la 2 (0x00000002) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Search In Sidebar Enabled” option in Microsoft Edge policies to 2 (0x00000002) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L236 · SET-VALUE · `SearchSuggestEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Search Suggest Enabled” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Search Suggest Enabled” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L237 · SET-VALUE · `SearchbarAllowed`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Searchbar Allowed” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Searchbar Allowed” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L238 · SET-VALUE · `SearchbarIsEnabledOnStartup`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Searchbar Is Enabled On Startup” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Searchbar Is Enabled On Startup” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L239 · SET-VALUE · `SendIntranetToInternetExplorer`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Send Intranet To Internet Explorer” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Send Intranet To Internet Explorer” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L240 · SET-VALUE · `SendSiteInfoToImproveServices`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Send Site Info To Improve Services” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Send Site Info To Improve Services” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L241 · SET-VALUE · `ShadowStackCrashRollbackBehavior`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Shadow Stack Crash Rollback Behavior” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Shadow Stack Crash Rollback Behavior” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L242 · SET-VALUE · `SharedLinksEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Shared Links Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Shared Links Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L243 · SET-VALUE · `ShowAcrobatSubscriptionButton`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Show Acrobat Subscription Button” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Show Acrobat Subscription Button” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L244 · SET-VALUE · `ShowDownloadsToolbarButton`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Show Downloads Toolbar Button” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Show Downloads Toolbar Button” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L245 · SET-VALUE · `ShowHistoryThumbnails`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Show History Thumbnails” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Show History Thumbnails” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L246 · SET-VALUE · `ShowMicrosoftRewards`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Show Microsoft Rewards” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Show Microsoft Rewards” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L247 · SET-VALUE · `ShowOfficeShortcutInFavoritesBar`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Show Office Shortcut In Favorites Bar” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Show Office Shortcut In Favorites Bar” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L248 · SET-VALUE · `ShowRecommendationsEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Show Recommendations Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Show Recommendations Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L249 · SET-VALUE · `SitePerProcess`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Site Per Process” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Site Per Process” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L250 · SET-VALUE · `SiteSafetyServicesEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Site Safety Services Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Site Safety Services Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L251 · SET-VALUE · `SpeechRecognitionEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Speech Recognition Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Speech Recognition Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L252 · SET-VALUE · `SpellcheckEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Spellcheck Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Spellcheck Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L253 · SET-VALUE · `StandaloneHubsSidebarEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Standalone Hubs Sidebar Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Standalone Hubs Sidebar Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L254 · SET-VALUE · `SuperDragDropEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Super Drag Drop Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Super Drag Drop Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L255 · SET-VALUE · `SuppressUnsupportedOSWarning`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Suppress Unsupported OSWarning” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Suppress Unsupported OSWarning” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L256 · SET-VALUE · `TabFreezingEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Tab Freezing Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Tab Freezing Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L257 · SET-VALUE · `TabServicesEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Tab Services Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Tab Services Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L258 · SET-VALUE · `TaskManagerEndProcessEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Task Manager End Process Enabled” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Task Manager End Process Enabled” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L259 · SET-VALUE · `TextPredictionEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Text Prediction Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Text Prediction Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L260 · SET-VALUE · `TrackingPrevention`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Tracking Prevention” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Tracking Prevention” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L261 · SET-VALUE · `TranslateEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Translate Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Translate Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L262 · SET-VALUE · `TravelAssistanceEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Travel Assistance Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Travel Assistance Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L263 · SET-VALUE · `U2fSecurityKeyApiEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „U2f Security Key Api Enabled” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “U2f Security Key Api Enabled” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L264 · SET-VALUE · `TripleDESEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Triple DESEnabled” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Triple DESEnabled” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L265 · SET-VALUE · `UploadFromPhoneEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Upload From Phone Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Upload From Phone Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L266 · SET-VALUE · `UrlDiagnosticDataEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Url Diagnostic Data Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Url Diagnostic Data Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L267 · SET-VALUE · `UserAgentClientHintsGREASEUpdateEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „User Agent Client Hints GREASEUpdate Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “User Agent Client Hints GREASEUpdate Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L268 · SET-VALUE · `UserAgentReduction`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „User Agent Reduction” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “User Agent Reduction” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L269 · SET-VALUE · `UserFeedbackAllowed`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „User Feedback Allowed” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “User Feedback Allowed” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L270 · SET-VALUE · `VideoCaptureAllowed`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Video Capture Allowed” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Video Capture Allowed” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L271 · SET-VALUE · `VisualSearchEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Visual Search Enabled” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Visual Search Enabled” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L272 · SET-VALUE · `WPADQuickCheckEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „WPADQuick Check Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “WPADQuick Check Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L273 · SET-VALUE · `WalletDonationEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Wallet Donation Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Wallet Donation Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L274 · SET-VALUE · `WebRtcRespectOsRoutingTableEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Web Rtc Respect Os Routing Table Enabled” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Web Rtc Respect Os Routing Table Enabled” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L275 · SET-VALUE · `WebWidgetAllowed`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Web Widget Allowed” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Web Widget Allowed” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L276 · SET-VALUE · `WebWidgetIsEnabledOnStartup`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Web Widget Is Enabled On Startup” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Web Widget Is Enabled On Startup” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L277 · SET-VALUE · `WinHttpProxyResolverEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Win Http Proxy Resolver Enabled” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Win Http Proxy Resolver Enabled” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L278 · SET-VALUE · `WindowOcclusionEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Window Occlusion Enabled” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Window Occlusion Enabled” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L279 · SET-VALUE · `RemoveDesktopShortcutDefault`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Remove Desktop Shortcut Default” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Remove Desktop Shortcut Default” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L280 · SET-VALUE · `SpotlightExperiencesAndRecommendationsEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Spotlight Experiences And Recommendations Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Spotlight Experiences And Recommendations Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L281 · SET-VALUE · `AllowCrossOriginAuthPrompt`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Allow Cross Origin Auth Prompt” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Allow Cross Origin Auth Prompt” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L282 · SET-VALUE · `DisableAuthNegotiateCnameLookup`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Disable Auth Negotiate Cname Lookup” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Disable Auth Negotiate Cname Lookup” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L283 · SET-VALUE · `NativeMessagingUserLevelHosts`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Native Messaging User Level Hosts” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Native Messaging User Level Hosts” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L284 · SET-VALUE · `UseSystemPrintDialog`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Use System Print Dialog” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Use System Print Dialog” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L285 · SET-VALUE · `RestoreOnStartup`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000004`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Restore On Startup” în politicile Microsoft Edge la 4 (0x00000004) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Restore On Startup” option in Microsoft Edge policies to 4 (0x00000004) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L286 · SET-VALUE · `HomepageLocation`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `"www.google.com"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Homepage Location” în politicile Microsoft Edge la www.google.com (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Homepage Location” option in Microsoft Edge policies to www.google.com (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L287 · SET-VALUE · `NewTabPageLocation`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `"www.google.com"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „New Tab Page Location” în politicile Microsoft Edge la www.google.com (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “New Tab Page Location” option in Microsoft Edge policies to www.google.com (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L288 · SET-VALUE · `NewTabPagePrerenderEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „New Tab Page Prerender Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “New Tab Page Prerender Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L289 · SET-VALUE · `NewTabPageHideDefaultTopSites`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „New Tab Page Hide Default Top Sites” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “New Tab Page Hide Default Top Sites” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L290 · SET-VALUE · `InternetExplorerIntegrationLocalFileAllowed`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Internet Explorer Integration Local File Allowed” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Internet Explorer Integration Local File Allowed” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L291 · SET-VALUE · `VerticalTabsAllowed`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Vertical Tabs Allowed” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Vertical Tabs Allowed” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L292 · SET-VALUE · `IntensiveWakeUpThrottlingEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Intensive Wake Up Throttling Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Intensive Wake Up Throttling Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L293 · SET-VALUE · `DnsOverHttpsMode`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `"off"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Dns Over Https Mode” în politicile Microsoft Edge la off (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Dns Over Https Mode” option in Microsoft Edge policies to off (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L294 · SET-VALUE · `TargetBlankImpliesNoOpener`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Target Blank Implies No Opener” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Target Blank Implies No Opener” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L295 · SET-VALUE · `ForceEphemeralProfiles`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Force Ephemeral Profiles” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Force Ephemeral Profiles” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L296 · SET-VALUE · `GoToIntranetSiteForSingleWordEntryInAddressBar`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Go To Intranet Site For Single Word Entry In Address Bar” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Go To Intranet Site For Single Word Entry In Address Bar” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L297 · SET-VALUE · `RelaunchNotification`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Relaunch Notification” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Relaunch Notification” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L298 · SET-VALUE · `PromotionalTabsEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Promotional Tabs Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Promotional Tabs Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L299 · SET-VALUE · `TotalMemoryLimitMb`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00008192`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Total Memory Limit Mb” în politicile Microsoft Edge la 33170 (0x00008192) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Total Memory Limit Mb” option in Microsoft Edge policies to 33170 (0x00008192) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L300 · SET-VALUE · `DefaultJavaScriptSetting`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Default Java Script Setting” în politicile Microsoft Edge la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Java Script Setting” option in Microsoft Edge policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L301 · SET-VALUE · `NewTabPageContentEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „New Tab Page Content Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “New Tab Page Content Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L302 · SET-VALUE · `NewTabPageAllowedBackgroundTypes`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „New Tab Page Allowed Background Types” în politicile Microsoft Edge la 3 (0x00000003) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “New Tab Page Allowed Background Types” option in Microsoft Edge policies to 3 (0x00000003) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L303 · SET-VALUE · `DevToolsGenAiSettings`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Dev Tools Gen Ai Settings” în politicile Microsoft Edge la 2 (0x00000002) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Dev Tools Gen Ai Settings” option in Microsoft Edge policies to 2 (0x00000002) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L304 · SET-VALUE · `ShareBrowsingHistoryWithCopilotSearchAllowed`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Share Browsing History With Copilot Search Allowed” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Share Browsing History With Copilot Search Allowed” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L305 · SET-VALUE · `Microsoft365CopilotChatIconEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Microsoft365Copilot Chat Icon Enabled” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Microsoft365Copilot Chat Icon Enabled” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L306 · SET-VALUE · `EdgeEntraCopilotPageContext`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Edge Entra Copilot Page Context” în politicile Microsoft Edge la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Edge Entra Copilot Page Context” option in Microsoft Edge policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

### L309 · SET-VALUE · `1`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge\RestoreOnStartupURLs`
- **Raw .reg data:** `"www.google.com"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „1” în politicile Microsoft Edge la www.google.com (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “1” option in Microsoft Edge policies to www.google.com (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Microsoft Edge policy; only when Edge is installed and the policy is supported by that Edge version.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies`

## Referințe / References

- https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies
