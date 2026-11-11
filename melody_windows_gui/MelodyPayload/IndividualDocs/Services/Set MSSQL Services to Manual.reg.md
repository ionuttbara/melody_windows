# Services/Set MSSQL Services to Manual.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `8ec3876ba88920571688d1a0bb6044747eb37dbb05acaf9cf0876eacda0765c4`
- **Recipe verdict / verdict rețetă:** `API`
- **Windows container / interval Windows:** `7600+`
- **Runtime prerequisite / condiție runtime:** `existing-key`
- **Value/operation descriptions / operații:** 8
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L4 · SET-VALUE · `Start`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\SQLWriter`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Starea de pornire declarată pentru serviciul/driverul „SQLWriter”: pornire la cerere/manuală (3). Windows poate proteja componenta sau o poate modifica la întreținere. Melody nu execută această operație Registry brută; configurarea este delegată API-ului sau paginii Windows dedicate.
- **What it configures / EN:** Start type configured for service/driver “SQLWriter”: manual / demand start (3). Windows may protect or service this component. Melody does not execute this raw Registry operation; configuration is delegated to the dedicated Windows API or page.
- **Final verdict / verdict final:** `API`
- **Certitudine / Evidence:** Service startup/removal must use Service Control Manager rather than raw registry mutation.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/winsvc/nf-winsvc-changeserviceconfiga`

### L7 · SET-VALUE · `Start`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\SQLTELEMETRY$SQLEXPRESS`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Starea de pornire declarată pentru serviciul/driverul „SQLTELEMETRY$SQLEXPRESS”: pornire la cerere/manuală (3). Windows poate proteja componenta sau o poate modifica la întreținere. Melody nu execută această operație Registry brută; configurarea este delegată API-ului sau paginii Windows dedicate.
- **What it configures / EN:** Start type configured for service/driver “SQLTELEMETRY$SQLEXPRESS”: manual / demand start (3). Windows may protect or service this component. Melody does not execute this raw Registry operation; configuration is delegated to the dedicated Windows API or page.
- **Final verdict / verdict final:** `API`
- **Certitudine / Evidence:** Service startup/removal must use Service Control Manager rather than raw registry mutation.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/winsvc/nf-winsvc-changeserviceconfiga`

### L10 · SET-VALUE · `Start`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\SQLTELEMETRY`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Starea de pornire declarată pentru serviciul/driverul „SQLTELEMETRY”: pornire la cerere/manuală (3). Windows poate proteja componenta sau o poate modifica la întreținere. Melody nu execută această operație Registry brută; configurarea este delegată API-ului sau paginii Windows dedicate.
- **What it configures / EN:** Start type configured for service/driver “SQLTELEMETRY”: manual / demand start (3). Windows may protect or service this component. Melody does not execute this raw Registry operation; configuration is delegated to the dedicated Windows API or page.
- **Final verdict / verdict final:** `API`
- **Certitudine / Evidence:** Service startup/removal must use Service Control Manager rather than raw registry mutation.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/winsvc/nf-winsvc-changeserviceconfiga`

### L13 · SET-VALUE · `Start`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\SQLBrowser`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Starea de pornire declarată pentru serviciul/driverul „SQLBrowser”: pornire la cerere/manuală (3). Windows poate proteja componenta sau o poate modifica la întreținere. Melody nu execută această operație Registry brută; configurarea este delegată API-ului sau paginii Windows dedicate.
- **What it configures / EN:** Start type configured for service/driver “SQLBrowser”: manual / demand start (3). Windows may protect or service this component. Melody does not execute this raw Registry operation; configuration is delegated to the dedicated Windows API or page.
- **Final verdict / verdict final:** `API`
- **Certitudine / Evidence:** Service startup/removal must use Service Control Manager rather than raw registry mutation.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/winsvc/nf-winsvc-changeserviceconfiga`

### L16 · SET-VALUE · `Start`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\SQLAgent$SQLEXPRESS`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Starea de pornire declarată pentru serviciul/driverul „SQLAgent$SQLEXPRESS”: pornire la cerere/manuală (3). Windows poate proteja componenta sau o poate modifica la întreținere. Melody nu execută această operație Registry brută; configurarea este delegată API-ului sau paginii Windows dedicate.
- **What it configures / EN:** Start type configured for service/driver “SQLAgent$SQLEXPRESS”: manual / demand start (3). Windows may protect or service this component. Melody does not execute this raw Registry operation; configuration is delegated to the dedicated Windows API or page.
- **Final verdict / verdict final:** `API`
- **Certitudine / Evidence:** Service startup/removal must use Service Control Manager rather than raw registry mutation.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/winsvc/nf-winsvc-changeserviceconfiga`

### L19 · SET-VALUE · `Start`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\SQLSERVERAGENT`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Starea de pornire declarată pentru serviciul/driverul „SQLSERVERAGENT”: pornire la cerere/manuală (3). Windows poate proteja componenta sau o poate modifica la întreținere. Melody nu execută această operație Registry brută; configurarea este delegată API-ului sau paginii Windows dedicate.
- **What it configures / EN:** Start type configured for service/driver “SQLSERVERAGENT”: manual / demand start (3). Windows may protect or service this component. Melody does not execute this raw Registry operation; configuration is delegated to the dedicated Windows API or page.
- **Final verdict / verdict final:** `API`
- **Certitudine / Evidence:** Service startup/removal must use Service Control Manager rather than raw registry mutation.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/winsvc/nf-winsvc-changeserviceconfiga`

### L22 · SET-VALUE · `Start`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\MSSQL$SQLEXPRESS`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Starea de pornire declarată pentru serviciul/driverul „MSSQL$SQLEXPRESS”: pornire la cerere/manuală (3). Windows poate proteja componenta sau o poate modifica la întreținere. Melody nu execută această operație Registry brută; configurarea este delegată API-ului sau paginii Windows dedicate.
- **What it configures / EN:** Start type configured for service/driver “MSSQL$SQLEXPRESS”: manual / demand start (3). Windows may protect or service this component. Melody does not execute this raw Registry operation; configuration is delegated to the dedicated Windows API or page.
- **Final verdict / verdict final:** `API`
- **Certitudine / Evidence:** Service startup/removal must use Service Control Manager rather than raw registry mutation.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/winsvc/nf-winsvc-changeserviceconfiga`

### L25 · SET-VALUE · `Start`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\MySQL80`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Starea de pornire declarată pentru serviciul/driverul „MySQL80”: pornire la cerere/manuală (3). Windows poate proteja componenta sau o poate modifica la întreținere. Melody nu execută această operație Registry brută; configurarea este delegată API-ului sau paginii Windows dedicate.
- **What it configures / EN:** Start type configured for service/driver “MySQL80”: manual / demand start (3). Windows may protect or service this component. Melody does not execute this raw Registry operation; configuration is delegated to the dedicated Windows API or page.
- **Final verdict / verdict final:** `API`
- **Certitudine / Evidence:** Service startup/removal must use Service Control Manager rather than raw registry mutation.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/api/winsvc/nf-winsvc-changeserviceconfiga`

## Referințe / References

- https://learn.microsoft.com/en-us/windows/win32/api/winsvc/nf-winsvc-changeserviceconfiga
