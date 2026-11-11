# Software/CMD Tweaks.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `c2843a38e9171c2c7d718db5fa6d4389b3c0155fe242ac300cd85d8319d52360`
- **Recipe verdict / verdict rețetă:** `CONDITIONAL`
- **Windows container / interval Windows:** `7600+`
- **Runtime prerequisite / condiție runtime:** `existing-key`
- **Value/operation descriptions / operații:** 2
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L5 · SET-VALUE · `CompletionChar`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\Command Processor`
- **Raw .reg data:** `dword:00000009`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Completion Char” în ramura Software / Microsoft / Command Processor la 9 (0x00000009) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Completion Char” option in registry branch Software / Microsoft / Command Processor to 9 (0x00000009) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Legacy Windows setting; only existing keys/values are changed on the detected system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/sysinfo/registry`

### L6 · SET-VALUE · `PathCompletionChar`

- **Registry key:** `HKEY_CURRENT_USER\Software\Microsoft\Command Processor`
- **Raw .reg data:** `dword:00000009`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Path Completion Char” în ramura Software / Microsoft / Command Processor la 9 (0x00000009) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Path Completion Char” option in registry branch Software / Microsoft / Command Processor to 9 (0x00000009) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Legacy Windows setting; only existing keys/values are changed on the detected system.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/sysinfo/registry`

## Referințe / References

- https://learn.microsoft.com/en-us/windows/win32/sysinfo/registry
