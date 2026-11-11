# Network/Winshock.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `39fddf32e8b5684843051ec2ac3250fdeaa0b0b417f0a1044a5d84be995177d7`
- **Recipe verdict / verdict rețetă:** `RETIRED`
- **Windows container / interval Windows:** `7600+`
- **Runtime prerequisite / condiție runtime:** `existing-key`
- **Value/operation descriptions / operații:** 3
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L6 · SET-VALUE · `UseDelayedAcceptance`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters\Winsock`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Use Delayed Acceptance” în configurația serviciilor sau driverelor la 0 (0x00000000) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “Use Delayed Acceptance” option in service or driver configuration to 0 (0x00000000) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Raw TCP/driver tuning is not portable across Windows/NIC versions; use supported networking APIs/cmdlets instead.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-server/networking/technologies/network-subsystem/net-sub-performance-tuning-nics`

### L7 · SET-VALUE · `MaxSockAddrLength`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters\Winsock`
- **Raw .reg data:** `dword:00000010`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Max Sock Addr Length” în configurația serviciilor sau driverelor la 16 (0x00000010) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “Max Sock Addr Length” option in service or driver configuration to 16 (0x00000010) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Raw TCP/driver tuning is not portable across Windows/NIC versions; use supported networking APIs/cmdlets instead.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-server/networking/technologies/network-subsystem/net-sub-performance-tuning-nics`

### L8 · SET-VALUE · `MinSockAddrLength`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters\Winsock`
- **Raw .reg data:** `dword:00000010`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Min Sock Addr Length” în configurația serviciilor sau driverelor la 16 (0x00000010) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “Min Sock Addr Length” option in service or driver configuration to 16 (0x00000010) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Raw TCP/driver tuning is not portable across Windows/NIC versions; use supported networking APIs/cmdlets instead.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows-server/networking/technologies/network-subsystem/net-sub-performance-tuning-nics`

## Referințe / References

- https://learn.microsoft.com/en-us/windows-server/networking/technologies/network-subsystem/net-sub-performance-tuning-nics
