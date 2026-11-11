# System/Disable System Restore Point Creation Frequency.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `808a42000ff0b27b57412ad039a0a7e728974281a530561c82fb866348c71e8a`
- **Recipe verdict / verdict rețetă:** `VERIFIED`
- **Windows container / interval Windows:** `9200+`
- **Runtime prerequisite / condiție runtime:** `existing-key`
- **Value/operation descriptions / operații:** 1
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L4 · SET-VALUE · `SystemRestorePointCreationFrequency`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\SystemRestore`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „System Restore Point Creation Frequency” în ramura Microsoft / Windows NT / CurrentVersion la 0 (0x00000000) (REG_DWORD). Semnificația și forma operației sunt susținute de sursa indicată.
- **What it configures / EN:** Sets the “System Restore Point Creation Frequency” option in registry branch Microsoft / Windows NT / CurrentVersion to 0 (0x00000000) (REG_DWORD). The operation meaning and form are supported by the cited source.
- **Final verdict / verdict final:** `VERIFIED`
- **Certitudine / Evidence:** Microsoft documents this DWORD starting with Windows 8.
- **OS support / versiuni:** `9200+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/sr/createrestorepoint-systemrestore`

## Referințe / References

- https://learn.microsoft.com/en-us/windows/win32/sr/createrestorepoint-systemrestore
