# Software/Task Manager.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `f0ab767a1b112500fe90583ade6722bf9f3a60d3fe20772bf440859215c17042`
- **Recipe verdict / verdict rețetă:** `CONDITIONAL`
- **Windows container / interval Windows:** `7600+`
- **Runtime prerequisite / condiție runtime:** `existing-key`
- **Value/operation descriptions / operații:** 2
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L4 · SET-VALUE · `UsrColumnSettings`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\Windows NT\CurrentVersion\TaskManager`
- **Raw .reg data:** `hex:1c,0c,00,00,34,04,00,00,00,00,00,00,8d,00,00,00,01,00,00,00,1d,0c,00,00,35,04,00,00,00,00,00,00,23,00,00,00,01,00,00,00,1e,0c,00,00,36,04,00,00,00,00,00,00,3c,00,00,00,01,00,00,00,1f,0c,00,00,39,04,00,00,00,00,00,00,4e,00,00,00,01,00,00,00,20,0c,00,00,37,04,00,00,00,00,00,00,4e,00,00,00,01,00,00,00`
- **Type / tip:** `REG_BINARY`
- **Ce face / RO:** Configurează opțiunea „Usr Column Settings” în ramura Microsoft / Windows NT / CurrentVersion la date binare / binary bytes (REG_BINARY). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Usr Column Settings” option in registry branch Microsoft / Windows NT / CurrentVersion to date binare / binary bytes (REG_BINARY). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L9 · SET-VALUE · `Preferences`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\Windows NT\CurrentVersion\TaskManager`
- **Raw .reg data:** `hex:30,03,00,00,e8,03,00,00,01,00,00,00,01,00,00,00,eb,00,00,00,b4,00,00,00,0c,06,00,00,18,03,00,00,01,00,00,00,01,00,00,00,00,00,00,00,00,00,00,00,01,00,00,00,00,00,00,00,01,00,00,00,00,00,00,00,00,00,00,00,01,00,00,00,02,00,00,00,04,00,00,00,09,00,00,00,0f,00,00,00,11,00,00,00,1b,00,00,00,1d,00,00,00,ff,ff,ff,ff,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,7b,00,00,00,32,00,00,00,40,00,00,00,27,00,00,00,46,00,00,00,3c,00,00,00,3c,00,00,00,10,02,00,00,53,01,00,00,53,01,00,00,53,01,00,00,53,01,00,00,81,00,00,00,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,00,00,00,00,01,00,00,00,02,00,00,00,03,00,00,00,04,00,00,00,05,00,00,00,06,00,00,00,07,00,00,00,08,00,00,00,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,09,00,00,00,04,00,00,00,01,00,00,00,00,00,00,00,02,00,00,00,03,00,00,00,04,00,00,00,0b,00,00,00,0c,00,00,00,ff,ff,ff,ff,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,63,00,60,00,3c,00,5a,00,46,00,46,00,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,00,00,00,00,00,00,01,00,00,00,02,00,00,00,03,00,00,00,04,00,00,00,05,00,00,00,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,ff,06,00,00,00,00,00,00,00,ff,ff,ff,ff,04,00,00,00,ff,ff,ff,ff,7e,00,00,00,28,00,00,00,49,01,00,00,4f,00,00,00,c5,00,00,00,00,00,00,00,01,00,00,00,02,00,00,00,03,00,00,00,04,00,00,00,00,00,00,00,ff,ff,ff`
- **Type / tip:** `REG_BINARY`
- **Ce face / RO:** Configurează opțiunea „Preferences” în ramura Microsoft / Windows NT / CurrentVersion la date binare / binary bytes (REG_BINARY). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Preferences” option in registry branch Microsoft / Windows NT / CurrentVersion to date binare / binary bytes (REG_BINARY). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

## Referințe / References

- No exact vendor URL is attached. The final runtime rule requires the exact live Registry target to exist before Melody enables the recipe.
