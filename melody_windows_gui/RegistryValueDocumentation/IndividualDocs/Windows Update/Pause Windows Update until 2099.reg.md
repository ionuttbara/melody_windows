# Windows Update/Pause Windows Update until 2099.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `d9e77876a672f2462c46fd3b85829842442b4b00abc2d5d5252e3e3782b7d466`
- **Recipe verdict / verdict rețetă:** `CONDITIONAL`
- **Windows container / interval Windows:** `7600+`
- **Runtime prerequisite / condiție runtime:** `existing-key`
- **Value/operation descriptions / operații:** 5
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L3 · SET-VALUE · `PauseFeatureUpdatesStartTime`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\WindowsUpdate\UX\Settings`
- **Raw .reg data:** `"2018-01-26T11:11:11Z"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Pause Feature Updates Start Time” în ramura Microsoft / WindowsUpdate / UX la 2018-01-26T11:11:11Z (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Pause Feature Updates Start Time” option in registry branch Microsoft / WindowsUpdate / UX to 2018-01-26T11:11:11Z (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L4 · SET-VALUE · `PauseQualityUpdatesStartTime`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\WindowsUpdate\UX\Settings`
- **Raw .reg data:** `"2018-01-26T11:11:11Z"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Pause Quality Updates Start Time” în ramura Microsoft / WindowsUpdate / UX la 2018-01-26T11:11:11Z (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Pause Quality Updates Start Time” option in registry branch Microsoft / WindowsUpdate / UX to 2018-01-26T11:11:11Z (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L5 · SET-VALUE · `PauseUpdatesExpiryTime`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\WindowsUpdate\UX\Settings`
- **Raw .reg data:** `"2099-11-11T16:38:59Z"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Pause Updates Expiry Time” în ramura Microsoft / WindowsUpdate / UX la 2099-11-11T16:38:59Z (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Pause Updates Expiry Time” option in registry branch Microsoft / WindowsUpdate / UX to 2099-11-11T16:38:59Z (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L6 · SET-VALUE · `PauseFeatureUpdatesEndTime`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\WindowsUpdate\UX\Settings`
- **Raw .reg data:** `"2099-11-11T11:11:11Z"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Pause Feature Updates End Time” în ramura Microsoft / WindowsUpdate / UX la 2099-11-11T11:11:11Z (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Pause Feature Updates End Time” option in registry branch Microsoft / WindowsUpdate / UX to 2099-11-11T11:11:11Z (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L7 · SET-VALUE · `PauseQualityUpdatesEndTime`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\WindowsUpdate\UX\Settings`
- **Raw .reg data:** `"2099-11-11T11:11:11Z"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Pause Quality Updates End Time” în ramura Microsoft / WindowsUpdate / UX la 2099-11-11T11:11:11Z (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Pause Quality Updates End Time” option in registry branch Microsoft / WindowsUpdate / UX to 2099-11-11T11:11:11Z (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

## Referințe / References

- No exact vendor URL is attached. The final runtime rule requires the exact live Registry target to exist before Melody enables the recipe.
