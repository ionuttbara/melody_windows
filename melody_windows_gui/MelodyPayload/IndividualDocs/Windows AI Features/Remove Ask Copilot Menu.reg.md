# Windows AI Features/Remove Ask Copilot Menu.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `29fc3c0af7b1d5136a71374fcf1170f3b257c8995f37526867e0d986940fe622`
- **Recipe verdict / verdict rețetă:** `CONDITIONAL`
- **Windows container / interval Windows:** `7600+`
- **Runtime prerequisite / condiție runtime:** `existing-key`
- **Value/operation descriptions / operații:** 1
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L4 · SET-VALUE · `{CB3B0003-8088-4EDE-8769-8B354AB2FF8C}`

- **Registry key:** `HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Shell Extensions\Blocked`
- **Raw .reg data:** `"Ask Copilot"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „CB3B0003 8088 4EDE 8769 8B354AB2FF8C” în ramura Microsoft / Windows / CurrentVersion la Ask Copilot (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “CB3B0003 8088 4EDE 8769 8B354AB2FF8C” option in registry branch Microsoft / Windows / CurrentVersion to Ask Copilot (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

## Referințe / References

- No exact vendor URL is attached. The final runtime rule requires the exact live Registry target to exist before Melody enables the recipe.
