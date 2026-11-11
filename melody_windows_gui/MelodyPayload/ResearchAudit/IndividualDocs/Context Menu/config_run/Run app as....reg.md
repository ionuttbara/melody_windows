# Context Menu/config_run/Run app as....reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `f696cb60f2b406c0a00b3b47dcaa51142f0bcf28ba96e9f9a938185578eafa68`
- **Recipe verdict / verdict rețetă:** `CONDITIONAL`
- **Windows container / interval Windows:** `7600+`
- **Runtime prerequisite / condiție runtime:** `shell`
- **Value/operation descriptions / operații:** 8
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L4 · SET-VALUE · `MUIVerb`

- **Registry key:** `HKEY_CLASSES_ROOT\exefile\shell\AppRunConfigAs`
- **Raw .reg data:** `"Run App As..."`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează eticheta vizibilă sau referința localizată a comenzii din meniul contextual la „Run App As...”. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the visible/localized shell command label to “Run App As...”. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L5 · SET-VALUE · `SubCommands`

- **Registry key:** `HKEY_CLASSES_ROOT\exefile\shell\AppRunConfigAs`
- **Raw .reg data:** `""`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Stabilește lista și ordinea subcomenzilor într-un meniu contextual în cascadă; fiecare comandă trebuie să fie înregistrată separat. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Defines the list and order of verbs in a cascading context menu; each verb must also be registered. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L6 · SET-VALUE · `Icon`

- **Registry key:** `HKEY_CLASSES_ROOT\exefile\shell\AppRunConfigAs`
- **Raw .reg data:** `"taskmgr.exe,1"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Stochează resursa grafică pentru intrarea de meniu/înregistrarea shell: taskmgr.exe,1. Nu execută niciun program. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Stores the icon resource for a shell/menu item: taskmgr.exe,1. It does not execute a program. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L9 · SET-VALUE · `MUIVerb`

- **Registry key:** `HKEY_CLASSES_ROOT\exefile\Shell\AppRunConfigAs\shell\TrusterdIns`
- **Raw .reg data:** `"Run as trustedinstaller..."`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează eticheta vizibilă sau referința localizată a comenzii din meniul contextual la „Run as trustedinstaller...”. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the visible/localized shell command label to “Run as trustedinstaller...”. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L10 · SET-VALUE · `HasLUAShield`

- **Registry key:** `HKEY_CLASSES_ROOT\exefile\Shell\AppRunConfigAs\shell\TrusterdIns`
- **Raw .reg data:** `""`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Has LUAShield” în asocierile de fișiere sau integrarea shell/COM la (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Has LUAShield” option in file associations or shell/COM integration to (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L11 · SET-VALUE · `Icon`

- **Registry key:** `HKEY_CLASSES_ROOT\exefile\Shell\AppRunConfigAs\shell\TrusterdIns`
- **Raw .reg data:** `"powershell.exe,0"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Stochează resursa grafică pentru intrarea de meniu/înregistrarea shell: powershell.exe,0. Nu execută niciun program. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Stores the icon resource for a shell/menu item: powershell.exe,0. It does not execute a program. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L13 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\exefile\shell\setdesktopwallpaper`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Elimină ramura meniului contextual/shell „setdesktopwallpaper”, inclusiv comenzile și subcheile sale; verifică dacă alte extensii depind de aceasta. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Removes context-menu/shell branch “setdesktopwallpaper”, including commands and child keys; check whether other extensions depend on it. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L16 · SET-VALUE · `(Default)`

- **Registry key:** `HKEY_CLASSES_ROOT\exefile\Shell\AppRunConfigAs\shell\TrusterdIns\command`
- **Raw .reg data:** `"C:\\Windows\\System32\\WindowsPowerShell\\v1.0\\powershell.exe -win 1 -nop -c iex((10..40|%%{(gp 'Registry::HKCR\\RunAsTI' $_ -ea 0).$_})-join[char]10); # --%% \"%L\""`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează comanda de lansare a acestei acțiuni shell: C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe -win 1 -nop -c iex((10..40|%%{(gp 'Registry::HKCR\RunAsTI' $_ -ea 0).$_})-join[char]10); # --%% "%L". Poate executa programe la selecția utilizatorului; nu executa automat. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the shell action command line: C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe -win 1 -nop -c iex((10..40|%%{(gp 'Registry::HKCR\RunAsTI' $_ -ea 0).$_})-join[char]10); # --%% "%L". It may launch programs when the user selects the action; never run automatically. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

## Referințe / References

- https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers
