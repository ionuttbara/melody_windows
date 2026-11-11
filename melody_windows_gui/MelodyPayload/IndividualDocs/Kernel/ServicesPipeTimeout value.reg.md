# Kernel/ServicesPipeTimeout value.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `04344c6803b99f50f6ea473e98e259632cc8678d4be46cc4ad80f777eebef2f0`
- **Recipe verdict / verdict rețetă:** `RETIRED`
- **Windows container / interval Windows:** `7600+`
- **Runtime prerequisite / condiție runtime:** `existing-key`
- **Value/operation descriptions / operații:** 1
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L4 · SET-VALUE · `ServicesPipeTimeout`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control`
- **Raw .reg data:** `dword:00007530`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Services Pipe Timeout” în ramura SYSTEM / CurrentControlSet / Control la 30000 (0x00007530) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “Services Pipe Timeout” option in registry branch SYSTEM / CurrentControlSet / Control to 30000 (0x00007530) (REG_DWORD). The raw Registry recipe is retired from execution; this operation remains documented for reference only.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** 30,000 ms approximates the normal service timeout; recipe has no demonstrated optimization benefit.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/troubleshoot/windows-server/system-management-components/service-not-start-events-7000-7011-time-out-error`

## Referințe / References

- https://learn.microsoft.com/en-us/troubleshoot/windows-server/system-management-components/service-not-start-events-7000-7011-time-out-error
