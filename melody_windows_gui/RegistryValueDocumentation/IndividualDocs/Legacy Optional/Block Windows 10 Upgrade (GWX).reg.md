# Legacy Optional/Block Windows 10 Upgrade (GWX).reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `ba363dfae3eb77ab5bf142af87fa2ec42c95ef06b4caf43851de61b218bce1ff`
- **Recipe verdict / verdict rețetă:** `CORRECTED`
- **Windows container / interval Windows:** `7601–9600`
- **Runtime prerequisite / condiție runtime:** `gwx-legacy`
- **Value/operation descriptions / operații:** 2
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L5 · SET-VALUE · `DisableOSUpgrade`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Blochează oferta de upgrade al sistemului de operare la Windows 10 pe Windows 7 SP1/8.1. Operația originală a fost corectată la forma susținută de sursa indicată.
- **What it configures / EN:** Blocks the Windows 10 operating-system upgrade offer on Windows 7 SP1/8.1. The original operation was corrected to the form supported by the cited source.
- **Final verdict / verdict final:** `CORRECTED`
- **Certitudine / Evidence:** Historical GWX recipe corrected to include Microsoft documented DisableOSUpgrade; only Windows 7 SP1 and Windows 8.1 are eligible.
- **OS support / versiuni:** `7601–9600`
- **Source / sursă:** `https://support.microsoft.com/en-us/topic/windows-update-client-for-windows-8-1-june-2015-18a2bef1-de63-4ce3-49d3-bd1978696514`

### L8 · SET-VALUE · `DisableGwx`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\GWX`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Dezactivează aplicația/notificarea istorică Get Windows 10 (GWX) pe sistemele eligibile. Operația originală a fost corectată la forma susținută de sursa indicată.
- **What it configures / EN:** Disables the historical Get Windows 10 (GWX) app/notification on eligible systems. The original operation was corrected to the form supported by the cited source.
- **Final verdict / verdict final:** `CORRECTED`
- **Certitudine / Evidence:** Historical GWX recipe corrected to include Microsoft documented DisableOSUpgrade; only Windows 7 SP1 and Windows 8.1 are eligible.
- **OS support / versiuni:** `7601–9600`
- **Source / sursă:** `https://support.microsoft.com/en-us/topic/windows-update-client-for-windows-8-1-june-2015-18a2bef1-de63-4ce3-49d3-bd1978696514`

## Referințe / References

- https://support.microsoft.com/en-us/topic/windows-update-client-for-windows-8-1-june-2015-18a2bef1-de63-4ce3-49d3-bd1978696514
