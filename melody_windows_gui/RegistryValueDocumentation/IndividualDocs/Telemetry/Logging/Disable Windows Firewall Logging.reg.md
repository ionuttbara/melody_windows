# Telemetry/Logging/Disable Windows Firewall Logging.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `6344bf9536d3b2b48c3f41bef61382aec1c0e1f04cb31f60a8c475be04883fad`
- **Recipe verdict / verdict rețetă:** `RETIRED`
- **Windows container / interval Windows:** `7600+`
- **Runtime prerequisite / condiție runtime:** `existing-key`
- **Value/operation descriptions / operații:** 6
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L3 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\SharedAccess\Parameters\FirewallPolicy\PublicProfile\Logging`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „Logging” din configurația serviciilor sau driverelor, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “Logging” key in service or driver configuration, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L5 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\SharedAccess\Parameters\FirewallPolicy\StandardProfile\Logging`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „Logging” din configurația serviciilor sau driverelor, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “Logging” key in service or driver configuration, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L7 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\SharedAccess\Parameters\FirewallPolicy\DomainProfile\Logging`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „Logging” din configurația serviciilor sau driverelor, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “Logging” key in service or driver configuration, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L9 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\SharedAccess\Defaults\FirewallPolicy\PublicProfile\Logging`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „Logging” din configurația serviciilor sau driverelor, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “Logging” key in service or driver configuration, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L11 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\SharedAccess\Defaults\FirewallPolicy\StandardProfile\Logging`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „Logging” din configurația serviciilor sau driverelor, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “Logging” key in service or driver configuration, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

### L13 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\SharedAccess\Defaults\FirewallPolicy\DomainProfile\Logging`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Șterge integral cheia „Logging” din configurația serviciilor sau driverelor, inclusiv toate valorile și subcheile. Funcția concretă a cheii nu este verificată. Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Deletes the entire “Logging” key in service or driver configuration, including all values and subkeys. Exact key semantics are unverified. Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Deletion has no exact supported cross-version contract; retired rather than applying blindly.
- **OS support / versiuni:** `7600+`

## Referințe / References

- Raw Registry execution is retired because no supportable cross-version contract was established for the recipe.
