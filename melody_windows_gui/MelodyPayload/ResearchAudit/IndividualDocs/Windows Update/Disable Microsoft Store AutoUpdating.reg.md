# Windows Update/Disable Microsoft Store AutoUpdating.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `1b3c61cab203451ee5577a466e58eb686e5be76911aeb4b216cdfe126ce31473`
- **Recipe verdict / verdict rețetă:** `VERIFIED`
- **Windows container / interval Windows:** `9200+`
- **Runtime prerequisite / condiție runtime:** `existing-key`
- **Value/operation descriptions / operații:** 1
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L6 · SET-VALUE · `AutoDownload`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\WindowsStore`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Dezactivează descărcarea și instalarea automată a actualizărilor aplicațiilor Microsoft Store prin AutoDownload=2. Semnificația și forma operației sunt susținute de sursa indicată.
- **What it configures / EN:** Turns off automatic download and installation of Microsoft Store app updates through AutoDownload=2. The operation meaning and form are supported by the cited source.
- **Final verdict / verdict final:** `VERIFIED`
- **Certitudine / Evidence:** Microsoft documents WindowsStore AutoDownload=2 for turning off automatic Store app update download/install; the policy originated for Windows 8.
- **OS support / versiuni:** `9200+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/privacy/manage-connections-from-windows-operating-system-components-to-microsoft-services`

## Referințe / References

- https://learn.microsoft.com/en-us/windows/privacy/manage-connections-from-windows-operating-system-components-to-microsoft-services
