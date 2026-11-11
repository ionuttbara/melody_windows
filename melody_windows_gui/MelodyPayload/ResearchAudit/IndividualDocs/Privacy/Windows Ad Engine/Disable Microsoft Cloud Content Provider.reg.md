# Privacy/Windows Ad Engine/Disable Microsoft Cloud Content Provider.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `d57b134d6d6c121cec6feec604de146f904de02b28005b799dd68cd72ac74ab2`
- **Recipe verdict / verdict rețetă:** `CONDITIONAL`
- **Windows container / interval Windows:** `22000+`
- **Runtime prerequisite / condiție runtime:** `existing-key`
- **Value/operation descriptions / operații:** 28
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L4 · SET-VALUE · `ConfigureWindowsSpotlight`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Windows\CloudContent`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Configure Windows Spotlight” în ramura Policies / Microsoft / Windows la 2 (0x00000002) (REG_DWORD). Semnificația și forma operației sunt susținute de sursa indicată.
- **What it configures / EN:** Sets the “Configure Windows Spotlight” option in registry branch Policies / Microsoft / Windows to 2 (0x00000002) (REG_DWORD). The operation meaning and form are supported by the cited source.
- **Final verdict / verdict final:** `VERIFIED`
- **Certitudine / Evidence:** Microsoft Cloud Content/Spotlight policy mapping.
- **OS support / versiuni:** `14393+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-experience`

### L5 · SET-VALUE · `IncludeEnterpriseSpotlight`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Windows\CloudContent`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Include Enterprise Spotlight” în ramura Policies / Microsoft / Windows la 0 (0x00000000) (REG_DWORD). Semnificația și forma operației sunt susținute de sursa indicată.
- **What it configures / EN:** Sets the “Include Enterprise Spotlight” option in registry branch Policies / Microsoft / Windows to 0 (0x00000000) (REG_DWORD). The operation meaning and form are supported by the cited source.
- **Final verdict / verdict final:** `VERIFIED`
- **Certitudine / Evidence:** Microsoft Cloud Content/Spotlight policy mapping.
- **OS support / versiuni:** `14393+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-experience`

### L6 · SET-VALUE · `DisableWindowsSpotlightFeatures`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Windows\CloudContent`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Disable Windows Spotlight Features” în ramura Policies / Microsoft / Windows la 1 (0x00000001) (REG_DWORD). Semnificația și forma operației sunt susținute de sursa indicată.
- **What it configures / EN:** Sets the “Disable Windows Spotlight Features” option in registry branch Policies / Microsoft / Windows to 1 (0x00000001) (REG_DWORD). The operation meaning and form are supported by the cited source.
- **Final verdict / verdict final:** `VERIFIED`
- **Certitudine / Evidence:** Microsoft Cloud Content/Spotlight policy mapping.
- **OS support / versiuni:** `14393+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-experience`

### L7 · SET-VALUE · `DisableWindowsSpotlightWindowsWelcomeExperience`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Windows\CloudContent`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Disable Windows Spotlight Windows Welcome Experience” în ramura Policies / Microsoft / Windows la 1 (0x00000001) (REG_DWORD). Semnificația și forma operației sunt susținute de sursa indicată.
- **What it configures / EN:** Sets the “Disable Windows Spotlight Windows Welcome Experience” option in registry branch Policies / Microsoft / Windows to 1 (0x00000001) (REG_DWORD). The operation meaning and form are supported by the cited source.
- **Final verdict / verdict final:** `VERIFIED`
- **Certitudine / Evidence:** Microsoft Cloud Content/Spotlight policy mapping.
- **OS support / versiuni:** `15063+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-experience`

### L8 · SET-VALUE · `DisableWindowsSpotlightOnActionCenter`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Windows\CloudContent`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Disable Windows Spotlight On Action Center” în ramura Policies / Microsoft / Windows la 1 (0x00000001) (REG_DWORD). Semnificația și forma operației sunt susținute de sursa indicată.
- **What it configures / EN:** Sets the “Disable Windows Spotlight On Action Center” option in registry branch Policies / Microsoft / Windows to 1 (0x00000001) (REG_DWORD). The operation meaning and form are supported by the cited source.
- **Final verdict / verdict final:** `VERIFIED`
- **Certitudine / Evidence:** Microsoft Cloud Content/Spotlight policy mapping.
- **OS support / versiuni:** `15063+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-experience`

### L9 · SET-VALUE · `DisableWindowsSpotlightOnSettings`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Windows\CloudContent`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Disable Windows Spotlight On Settings” în ramura Policies / Microsoft / Windows la 1 (0x00000001) (REG_DWORD). Semnificația și forma operației sunt susținute de sursa indicată.
- **What it configures / EN:** Sets the “Disable Windows Spotlight On Settings” option in registry branch Policies / Microsoft / Windows to 1 (0x00000001) (REG_DWORD). The operation meaning and form are supported by the cited source.
- **Final verdict / verdict final:** `VERIFIED`
- **Certitudine / Evidence:** Microsoft Cloud Content/Spotlight policy mapping.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-experience`

### L10 · SET-VALUE · `DisableThirdPartySuggestions`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Windows\CloudContent`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Disable Third Party Suggestions” în ramura Policies / Microsoft / Windows la 1 (0x00000001) (REG_DWORD). Semnificația și forma operației sunt susținute de sursa indicată.
- **What it configures / EN:** Sets the “Disable Third Party Suggestions” option in registry branch Policies / Microsoft / Windows to 1 (0x00000001) (REG_DWORD). The operation meaning and form are supported by the cited source.
- **Final verdict / verdict final:** `VERIFIED`
- **Certitudine / Evidence:** Microsoft Cloud Content/Spotlight policy mapping.
- **OS support / versiuni:** `14393+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-experience`

### L11 · SET-VALUE · `DisableTailoredExperiencesWithDiagnosticData`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Windows\CloudContent`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Disable Tailored Experiences With Diagnostic Data” în ramura Policies / Microsoft / Windows la 1 (0x00000001) (REG_DWORD). Semnificația și forma operației sunt susținute de sursa indicată.
- **What it configures / EN:** Sets the “Disable Tailored Experiences With Diagnostic Data” option in registry branch Policies / Microsoft / Windows to 1 (0x00000001) (REG_DWORD). The operation meaning and form are supported by the cited source.
- **Final verdict / verdict final:** `VERIFIED`
- **Certitudine / Evidence:** Microsoft Cloud Content/Spotlight policy mapping.
- **OS support / versiuni:** `14393+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-experience`

### L12 · SET-VALUE · `DisableSoftLanding`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Windows\CloudContent`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Disable Soft Landing” în ramura Policies / Microsoft / Windows la 1 (0x00000001) (REG_DWORD). Semnificația și forma operației sunt susținute de sursa indicată.
- **What it configures / EN:** Sets the “Disable Soft Landing” option in registry branch Policies / Microsoft / Windows to 1 (0x00000001) (REG_DWORD). The operation meaning and form are supported by the cited source.
- **Final verdict / verdict final:** `VERIFIED`
- **Certitudine / Evidence:** Microsoft Cloud Content/Spotlight policy mapping.
- **OS support / versiuni:** `14393+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-experience`

### L13 · SET-VALUE · `DisableCloudOptimizedContent`

- **Registry key:** `HKEY_CURRENT_USER\Software\Policies\Microsoft\Windows\CloudContent`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Disable Cloud Optimized Content” în ramura Policies / Microsoft / Windows la 1 (0x00000001) (REG_DWORD). Semnificația și forma operației sunt susținute de sursa indicată.
- **What it configures / EN:** Sets the “Disable Cloud Optimized Content” option in registry branch Policies / Microsoft / Windows to 1 (0x00000001) (REG_DWORD). The operation meaning and form are supported by the cited source.
- **Final verdict / verdict final:** `VERIFIED`
- **Certitudine / Evidence:** Microsoft Cloud Content/Spotlight policy mapping.
- **OS support / versiuni:** `22000+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-experience`

### L16 · SET-VALUE · `ConfigureWindowsSpotlight`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\CloudContent`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Configure Windows Spotlight” în ramura Policies / Microsoft / Windows la 2 (0x00000002) (REG_DWORD). Semnificația și forma operației sunt susținute de sursa indicată.
- **What it configures / EN:** Sets the “Configure Windows Spotlight” option in registry branch Policies / Microsoft / Windows to 2 (0x00000002) (REG_DWORD). The operation meaning and form are supported by the cited source.
- **Final verdict / verdict final:** `VERIFIED`
- **Certitudine / Evidence:** Microsoft Cloud Content/Spotlight policy mapping.
- **OS support / versiuni:** `14393+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-experience`

### L17 · SET-VALUE · `IncludeEnterpriseSpotlight`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\CloudContent`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Include Enterprise Spotlight” în ramura Policies / Microsoft / Windows la 0 (0x00000000) (REG_DWORD). Semnificația și forma operației sunt susținute de sursa indicată.
- **What it configures / EN:** Sets the “Include Enterprise Spotlight” option in registry branch Policies / Microsoft / Windows to 0 (0x00000000) (REG_DWORD). The operation meaning and form are supported by the cited source.
- **Final verdict / verdict final:** `VERIFIED`
- **Certitudine / Evidence:** Microsoft Cloud Content/Spotlight policy mapping.
- **OS support / versiuni:** `14393+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-experience`

### L18 · SET-VALUE · `DisableWindowsSpotlightFeatures`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\CloudContent`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Disable Windows Spotlight Features” în ramura Policies / Microsoft / Windows la 1 (0x00000001) (REG_DWORD). Semnificația și forma operației sunt susținute de sursa indicată.
- **What it configures / EN:** Sets the “Disable Windows Spotlight Features” option in registry branch Policies / Microsoft / Windows to 1 (0x00000001) (REG_DWORD). The operation meaning and form are supported by the cited source.
- **Final verdict / verdict final:** `VERIFIED`
- **Certitudine / Evidence:** Microsoft Cloud Content/Spotlight policy mapping.
- **OS support / versiuni:** `14393+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-experience`

### L19 · SET-VALUE · `DisableWindowsSpotlightWindowsWelcomeExperience`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\CloudContent`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Disable Windows Spotlight Windows Welcome Experience” în ramura Policies / Microsoft / Windows la 1 (0x00000001) (REG_DWORD). Semnificația și forma operației sunt susținute de sursa indicată.
- **What it configures / EN:** Sets the “Disable Windows Spotlight Windows Welcome Experience” option in registry branch Policies / Microsoft / Windows to 1 (0x00000001) (REG_DWORD). The operation meaning and form are supported by the cited source.
- **Final verdict / verdict final:** `VERIFIED`
- **Certitudine / Evidence:** Microsoft Cloud Content/Spotlight policy mapping.
- **OS support / versiuni:** `15063+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-experience`

### L20 · SET-VALUE · `DisableWindowsSpotlightOnActionCenter`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\CloudContent`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Disable Windows Spotlight On Action Center” în ramura Policies / Microsoft / Windows la 1 (0x00000001) (REG_DWORD). Semnificația și forma operației sunt susținute de sursa indicată.
- **What it configures / EN:** Sets the “Disable Windows Spotlight On Action Center” option in registry branch Policies / Microsoft / Windows to 1 (0x00000001) (REG_DWORD). The operation meaning and form are supported by the cited source.
- **Final verdict / verdict final:** `VERIFIED`
- **Certitudine / Evidence:** Microsoft Cloud Content/Spotlight policy mapping.
- **OS support / versiuni:** `15063+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-experience`

### L21 · SET-VALUE · `DisableWindowsSpotlightOnSettings`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\CloudContent`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Disable Windows Spotlight On Settings” în ramura Policies / Microsoft / Windows la 1 (0x00000001) (REG_DWORD). Semnificația și forma operației sunt susținute de sursa indicată.
- **What it configures / EN:** Sets the “Disable Windows Spotlight On Settings” option in registry branch Policies / Microsoft / Windows to 1 (0x00000001) (REG_DWORD). The operation meaning and form are supported by the cited source.
- **Final verdict / verdict final:** `VERIFIED`
- **Certitudine / Evidence:** Microsoft Cloud Content/Spotlight policy mapping.
- **OS support / versiuni:** `17134+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-experience`

### L22 · SET-VALUE · `DisableThirdPartySuggestions`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\CloudContent`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Disable Third Party Suggestions” în ramura Policies / Microsoft / Windows la 1 (0x00000001) (REG_DWORD). Semnificația și forma operației sunt susținute de sursa indicată.
- **What it configures / EN:** Sets the “Disable Third Party Suggestions” option in registry branch Policies / Microsoft / Windows to 1 (0x00000001) (REG_DWORD). The operation meaning and form are supported by the cited source.
- **Final verdict / verdict final:** `VERIFIED`
- **Certitudine / Evidence:** Microsoft Cloud Content/Spotlight policy mapping.
- **OS support / versiuni:** `14393+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-experience`

### L23 · SET-VALUE · `DisableTailoredExperiencesWithDiagnosticData`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\CloudContent`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Disable Tailored Experiences With Diagnostic Data” în ramura Policies / Microsoft / Windows la 1 (0x00000001) (REG_DWORD). Semnificația și forma operației sunt susținute de sursa indicată.
- **What it configures / EN:** Sets the “Disable Tailored Experiences With Diagnostic Data” option in registry branch Policies / Microsoft / Windows to 1 (0x00000001) (REG_DWORD). The operation meaning and form are supported by the cited source.
- **Final verdict / verdict final:** `VERIFIED`
- **Certitudine / Evidence:** Microsoft Cloud Content/Spotlight policy mapping.
- **OS support / versiuni:** `14393+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-experience`

### L24 · SET-VALUE · `DisableSoftLanding`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\CloudContent`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Disable Soft Landing” în ramura Policies / Microsoft / Windows la 1 (0x00000001) (REG_DWORD). Semnificația și forma operației sunt susținute de sursa indicată.
- **What it configures / EN:** Sets the “Disable Soft Landing” option in registry branch Policies / Microsoft / Windows to 1 (0x00000001) (REG_DWORD). The operation meaning and form are supported by the cited source.
- **Final verdict / verdict final:** `VERIFIED`
- **Certitudine / Evidence:** Microsoft Cloud Content/Spotlight policy mapping.
- **OS support / versiuni:** `14393+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-experience`

### L25 · SET-VALUE · `DisableCloudOptimizedContent`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\CloudContent`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Disable Cloud Optimized Content” în ramura Policies / Microsoft / Windows la 1 (0x00000001) (REG_DWORD). Semnificația și forma operației sunt susținute de sursa indicată.
- **What it configures / EN:** Sets the “Disable Cloud Optimized Content” option in registry branch Policies / Microsoft / Windows to 1 (0x00000001) (REG_DWORD). The operation meaning and form are supported by the cited source.
- **Final verdict / verdict final:** `VERIFIED`
- **Certitudine / Evidence:** Microsoft Cloud Content/Spotlight policy mapping.
- **OS support / versiuni:** `22000+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-experience`

### L28 · SET-VALUE · `Intent`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\CloudExperienceHost\Intent\creative`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Intent” în ramura Microsoft / Windows / CurrentVersion la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Intent” option in registry branch Microsoft / Windows / CurrentVersion to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L31 · SET-VALUE · `Intent`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\CloudExperienceHost\Intent\entertainment`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Intent” în ramura Microsoft / Windows / CurrentVersion la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Intent” option in registry branch Microsoft / Windows / CurrentVersion to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L34 · SET-VALUE · `Intent`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\CloudExperienceHost\Intent\family`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Intent” în ramura Microsoft / Windows / CurrentVersion la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Intent” option in registry branch Microsoft / Windows / CurrentVersion to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L37 · SET-VALUE · `Intent`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\CloudExperienceHost\Intent\gaming`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Intent” în ramura Microsoft / Windows / CurrentVersion la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Intent” option in registry branch Microsoft / Windows / CurrentVersion to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L40 · SET-VALUE · `Intent`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\CloudExperienceHost\Intent\schoolwork`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Intent” în ramura Microsoft / Windows / CurrentVersion la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Intent” option in registry branch Microsoft / Windows / CurrentVersion to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L43 · SET-VALUE · `Intent`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\CloudExperienceHost\Intent\business`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Intent” în ramura Microsoft / Windows / CurrentVersion la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Intent” option in registry branch Microsoft / Windows / CurrentVersion to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L46 · SET-VALUE · `Intent`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\CloudExperienceHost\Intent\development`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Intent” în ramura Microsoft / Windows / CurrentVersion la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Intent” option in registry branch Microsoft / Windows / CurrentVersion to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L49 · SET-VALUE · `value`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\PolicyManager\default\Experience\DisableCloudOptimizedContent`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „value” în ramura Microsoft / PolicyManager / default la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “value” option in registry branch Microsoft / PolicyManager / default to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Internal/user setting; only an existing value is changed, preventing creation on unsupported builds.
- **OS support / versiuni:** `7600+`

## Referințe / References

- https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-experience
