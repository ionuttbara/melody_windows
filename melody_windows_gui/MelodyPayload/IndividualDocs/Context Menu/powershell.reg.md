# Context Menu/powershell.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `77d590f20df7d145b10466f38da4b3afc881afcbe26d64c1056b7b88f0d7dfd9`
- **Recipe verdict / verdict rețetă:** `CONDITIONAL`
- **Windows container / interval Windows:** `7600+`
- **Runtime prerequisite / condiție runtime:** `shell`
- **Value/operation descriptions / operații:** 4
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L5 · SET-VALUE · `(Default)`

- **Registry key:** `HKEY_CLASSES_ROOT\.ps1`
- **Raw .reg data:** `"Gallery.Inc.Code.PowerShell"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează valoarea implicită în asocierile de fișiere sau integrarea shell/COM la Gallery.Inc.Code.PowerShell (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets default value in file associations or shell/COM integration to Gallery.Inc.Code.PowerShell (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L8 · SET-VALUE · `(Default)`

- **Registry key:** `HKEY_CLASSES_ROOT\Gallery.Inc.Code.Powershell`
- **Raw .reg data:** `"PowerShell Script"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează valoarea implicită în asocierile de fișiere sau integrarea shell/COM la PowerShell Script (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets default value in file associations or shell/COM integration to PowerShell Script (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L11 · SET-VALUE · `(Default)`

- **Registry key:** `HKEY_CLASSES_ROOT\Gallery.Inc.Code.Powershell\DefaultIcon`
- **Raw .reg data:** `"\"C:\\Windows\\System32\\WindowsPowerShell\\v1.0\\powershell.exe,0\"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează valoarea implicită în asocierile de fișiere sau integrarea shell/COM la \"C:\\Windows\\System32\\WindowsPowerShell\\v1.0\\powershell.exe,0\ (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets default value in file associations or shell/COM integration to \"C:\\Windows\\System32\\WindowsPowerShell\\v1.0\\powershell.exe,0\ (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L18 · SET-VALUE · `(Default)`

- **Registry key:** `HKEY_CLASSES_ROOT\Gallery.Inc.Code.Powershell\shell\open\command`
- **Raw .reg data:** `"\"C:\\Windows\\System32\\WindowsPowerShell\\v1.0\\powershell.exe\" -noLogo -ExecutionPolicy unrestricted -file \"%1\""`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează comanda de lansare a acestei acțiuni shell: "C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe" -noLogo -ExecutionPolicy unrestricted -file "%1". Poate executa programe la selecția utilizatorului; nu executa automat. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the shell action command line: "C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe" -noLogo -ExecutionPolicy unrestricted -file "%1". It may launch programs when the user selects the action; never run automatically. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

## Referințe / References

- https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers
