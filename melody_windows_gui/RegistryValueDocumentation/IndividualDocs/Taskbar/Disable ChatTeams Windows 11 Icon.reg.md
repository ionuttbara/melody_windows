# Taskbar/Disable ChatTeams Windows 11 Icon.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `4b426812460e69786a2b7316bada4b05c3761230ea38a328a758eecb53709ba1`
- **Recipe verdict / verdict rețetă:** `CORRECTED`
- **Windows container / interval Windows:** `22000+`
- **Runtime prerequisite / condiție runtime:** `existing-key`
- **Value/operation descriptions / operații:** 1
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L5 · SET-VALUE · `ChatIcon`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\Windows Chat`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Setează politica Windows Chat la Disabled (ChatIcon=3), ascunzând/dezactivând integrarea Chat gestionată de politică. Operația originală a fost corectată la forma susținută de sursa indicată.
- **What it configures / EN:** Sets the Windows Chat policy to Disabled (ChatIcon=3), hiding/disabling the policy-managed Chat integration. The original operation was corrected to the form supported by the cited source.
- **Final verdict / verdict final:** `CORRECTED`
- **Certitudine / Evidence:** Wrong TaskbarAl alignment value replaced by ConfigureChatIcon/ChatIcon=3.
- **OS support / versiuni:** `22000+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-experience`

## Referințe / References

- https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-experience
