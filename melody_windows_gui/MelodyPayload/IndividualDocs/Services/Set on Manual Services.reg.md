# Services/Set on Manual Services.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `5256dac8c67d0ba8f71409131b40ad646d2031b6d62f18e613f8f83c8bb0d409`
- **Recipe verdict / verdict rețetă:** `API`
- **Windows container / interval Windows:** `7600+`
- **Runtime prerequisite / condiție runtime:** `existing-key`
- **Value/operation descriptions / operații:** 9
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L4 · SET-VALUE · `Start`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\DoSvc`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Starea de pornire declarată pentru serviciul/driverul „DoSvc”: pornire la cerere/manuală (3). Windows poate proteja componenta sau o poate modifica la întreținere. Melody nu execută această operație Registry brută; configurarea este delegată API-ului sau paginii Windows dedicate.
- **What it configures / EN:** Start type configured for service/driver “DoSvc”: manual / demand start (3). Windows may protect or service this component. Melody does not execute this raw Registry operation; configuration is delegated to the dedicated Windows API or page.
- **Final verdict / verdict final:** `API`
- **Certitudine / Evidence:** Service startup/removal must use Service Control Manager rather than raw registry mutation.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/winsvc/nf-winsvc-changeserviceconfiga`

### L7 · SET-VALUE · `Start`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\BITS`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Starea de pornire declarată pentru serviciul/driverul „BITS”: pornire la cerere/manuală (3). Windows poate proteja componenta sau o poate modifica la întreținere. Melody nu execută această operație Registry brută; configurarea este delegată API-ului sau paginii Windows dedicate.
- **What it configures / EN:** Start type configured for service/driver “BITS”: manual / demand start (3). Windows may protect or service this component. Melody does not execute this raw Registry operation; configuration is delegated to the dedicated Windows API or page.
- **Final verdict / verdict final:** `API`
- **Certitudine / Evidence:** Service startup/removal must use Service Control Manager rather than raw registry mutation.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/winsvc/nf-winsvc-changeserviceconfiga`

### L10 · SET-VALUE · `Start`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\FDResPub`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Starea de pornire declarată pentru serviciul/driverul „FDResPub”: pornire automată (2). Windows poate proteja componenta sau o poate modifica la întreținere. Melody nu execută această operație Registry brută; configurarea este delegată API-ului sau paginii Windows dedicate.
- **What it configures / EN:** Start type configured for service/driver “FDResPub”: automatic start (2). Windows may protect or service this component. Melody does not execute this raw Registry operation; configuration is delegated to the dedicated Windows API or page.
- **Final verdict / verdict final:** `API`
- **Certitudine / Evidence:** Service startup/removal must use Service Control Manager rather than raw registry mutation.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/winsvc/nf-winsvc-changeserviceconfiga`

### L13 · SET-VALUE · `Start`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\sppsvc`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Starea de pornire declarată pentru serviciul/driverul „sppsvc”: pornire la cerere/manuală (3). Windows poate proteja componenta sau o poate modifica la întreținere. Melody nu execută această operație Registry brută; configurarea este delegată API-ului sau paginii Windows dedicate.
- **What it configures / EN:** Start type configured for service/driver “sppsvc”: manual / demand start (3). Windows may protect or service this component. Melody does not execute this raw Registry operation; configuration is delegated to the dedicated Windows API or page.
- **Final verdict / verdict final:** `API`
- **Certitudine / Evidence:** Service startup/removal must use Service Control Manager rather than raw registry mutation.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/winsvc/nf-winsvc-changeserviceconfiga`

### L16 · SET-VALUE · `Start`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\StorSvc`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Starea de pornire declarată pentru serviciul/driverul „StorSvc”: pornire la cerere/manuală (3). Windows poate proteja componenta sau o poate modifica la întreținere. Melody nu execută această operație Registry brută; configurarea este delegată API-ului sau paginii Windows dedicate.
- **What it configures / EN:** Start type configured for service/driver “StorSvc”: manual / demand start (3). Windows may protect or service this component. Melody does not execute this raw Registry operation; configuration is delegated to the dedicated Windows API or page.
- **Final verdict / verdict final:** `API`
- **Certitudine / Evidence:** Service startup/removal must use Service Control Manager rather than raw registry mutation.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/winsvc/nf-winsvc-changeserviceconfiga`

### L19 · SET-VALUE · `Start`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\cbdhsvc`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Starea de pornire declarată pentru serviciul/driverul „cbdhsvc”: pornire la cerere/manuală (3). Windows poate proteja componenta sau o poate modifica la întreținere. Melody nu execută această operație Registry brută; configurarea este delegată API-ului sau paginii Windows dedicate.
- **What it configures / EN:** Start type configured for service/driver “cbdhsvc”: manual / demand start (3). Windows may protect or service this component. Melody does not execute this raw Registry operation; configuration is delegated to the dedicated Windows API or page.
- **Final verdict / verdict final:** `API`
- **Certitudine / Evidence:** Service startup/removal must use Service Control Manager rather than raw registry mutation.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/winsvc/nf-winsvc-changeserviceconfiga`

### L22 · SET-VALUE · `Start`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\AviraPhantomVPN`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Starea de pornire declarată pentru serviciul/driverul „AviraPhantomVPN”: pornire la cerere/manuală (3). Windows poate proteja componenta sau o poate modifica la întreținere. Melody nu execută această operație Registry brută; configurarea este delegată API-ului sau paginii Windows dedicate.
- **What it configures / EN:** Start type configured for service/driver “AviraPhantomVPN”: manual / demand start (3). Windows may protect or service this component. Melody does not execute this raw Registry operation; configuration is delegated to the dedicated Windows API or page.
- **Final verdict / verdict final:** `API`
- **Certitudine / Evidence:** Service startup/removal must use Service Control Manager rather than raw registry mutation.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/winsvc/nf-winsvc-changeserviceconfiga`

### L25 · SET-VALUE · `Start`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\DispBrokerDesktopSvc`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Starea de pornire declarată pentru serviciul/driverul „DispBrokerDesktopSvc”: pornire la cerere/manuală (3). Windows poate proteja componenta sau o poate modifica la întreținere. Melody nu execută această operație Registry brută; configurarea este delegată API-ului sau paginii Windows dedicate.
- **What it configures / EN:** Start type configured for service/driver “DispBrokerDesktopSvc”: manual / demand start (3). Windows may protect or service this component. Melody does not execute this raw Registry operation; configuration is delegated to the dedicated Windows API or page.
- **Final verdict / verdict final:** `API`
- **Certitudine / Evidence:** Service startup/removal must use Service Control Manager rather than raw registry mutation.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/winsvc/nf-winsvc-changeserviceconfiga`

### L28 · SET-VALUE · `Start`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\DisplayEnhancementService`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Starea de pornire declarată pentru serviciul/driverul „DisplayEnhancementService”: pornire la cerere/manuală (3). Windows poate proteja componenta sau o poate modifica la întreținere. Melody nu execută această operație Registry brută; configurarea este delegată API-ului sau paginii Windows dedicate.
- **What it configures / EN:** Start type configured for service/driver “DisplayEnhancementService”: manual / demand start (3). Windows may protect or service this component. Melody does not execute this raw Registry operation; configuration is delegated to the dedicated Windows API or page.
- **Final verdict / verdict final:** `API`
- **Certitudine / Evidence:** Service startup/removal must use Service Control Manager rather than raw registry mutation.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/winsvc/nf-winsvc-changeserviceconfiga`

## Referințe / References

- https://learn.microsoft.com/en-us/windows/win32/api/winsvc/nf-winsvc-changeserviceconfiga
