# Context Menu/menu list/TerminalBehaivofMelodyMenu.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `599c1dfcc967a92adf2921f0a0097d34db2f06205d94ded909d1f0bb622be1b5`
- **Recipe verdict / verdict rețetă:** `CONDITIONAL`
- **Windows container / interval Windows:** `7600+`
- **Runtime prerequisite / condiție runtime:** `shell`
- **Value/operation descriptions / operații:** 56
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L5 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\Directory\shell\cmd`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Elimină ramura meniului contextual/shell „cmd”, inclusiv comenzile și subcheile sale; verifică dacă alte extensii depind de aceasta. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Removes context-menu/shell branch “cmd”, including commands and child keys; check whether other extensions depend on it. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L7 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\Directory\shell\Powershell`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Elimină ramura meniului contextual/shell „Powershell”, inclusiv comenzile și subcheile sale; verifică dacă alte extensii depind de aceasta. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Removes context-menu/shell branch “Powershell”, including commands and child keys; check whether other extensions depend on it. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L9 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\Directory\shell\WSL`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Elimină ramura meniului contextual/shell „WSL”, inclusiv comenzile și subcheile sale; verifică dacă alte extensii depind de aceasta. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Removes context-menu/shell branch “WSL”, including commands and child keys; check whether other extensions depend on it. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L11 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\Directory\Background\shell\OpenWindowsTerminalProfiles`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Elimină ramura meniului contextual/shell „OpenWindowsTerminalProfiles”, inclusiv comenzile și subcheile sale; verifică dacă alte extensii depind de aceasta. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Removes context-menu/shell branch “OpenWindowsTerminalProfiles”, including commands and child keys; check whether other extensions depend on it. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L13 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\Directory\shell\cmd`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Elimină ramura meniului contextual/shell „cmd”, inclusiv comenzile și subcheile sale; verifică dacă alte extensii depind de aceasta. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Removes context-menu/shell branch “cmd”, including commands and child keys; check whether other extensions depend on it. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L15 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\Directory\Background\shell\Powershell`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Elimină ramura meniului contextual/shell „Powershell”, inclusiv comenzile și subcheile sale; verifică dacă alte extensii depind de aceasta. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Removes context-menu/shell branch “Powershell”, including commands and child keys; check whether other extensions depend on it. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L17 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\Directory\Background\shell\WSL`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Elimină ramura meniului contextual/shell „WSL”, inclusiv comenzile și subcheile sale; verifică dacă alte extensii depind de aceasta. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Removes context-menu/shell branch “WSL”, including commands and child keys; check whether other extensions depend on it. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L19 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\Drive\shell\cmd`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Elimină ramura meniului contextual/shell „cmd”, inclusiv comenzile și subcheile sale; verifică dacă alte extensii depind de aceasta. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Removes context-menu/shell branch “cmd”, including commands and child keys; check whether other extensions depend on it. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L21 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\Drive\shell\Powershell`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Elimină ramura meniului contextual/shell „Powershell”, inclusiv comenzile și subcheile sale; verifică dacă alte extensii depind de aceasta. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Removes context-menu/shell branch “Powershell”, including commands and child keys; check whether other extensions depend on it. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L23 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\Drive\shell\WSL`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Elimină ramura meniului contextual/shell „WSL”, inclusiv comenzile și subcheile sale; verifică dacă alte extensii depind de aceasta. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Removes context-menu/shell branch “WSL”, including commands and child keys; check whether other extensions depend on it. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L26 · SET-VALUE · `{9F156763-7844-4DC4-B2B1-901F640F5155}`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Shell Extensions\Blocked`
- **Raw .reg data:** `""`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „9F156763 7844 4DC4 B2B1 901F640F5155” în ramura Microsoft / Windows / CurrentVersion la (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “9F156763 7844 4DC4 B2B1 901F640F5155” option in registry branch Microsoft / Windows / CurrentVersion to (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L34 · SET-VALUE · `MUIVerb`

- **Registry key:** `HKEY_CLASSES_ROOT\Drive\shell\GalleryTerminalBehaivor`
- **Raw .reg data:** `"Open terminal in place..."`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează eticheta vizibilă sau referința localizată a comenzii din meniul contextual la „Open terminal in place...”. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the visible/localized shell command label to “Open terminal in place...”. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L35 · SET-VALUE · `Icon`

- **Registry key:** `HKEY_CLASSES_ROOT\Drive\shell\GalleryTerminalBehaivor`
- **Raw .reg data:** `"cmd.exe"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Stochează resursa grafică pentru intrarea de meniu/înregistrarea shell: cmd.exe. Nu execută niciun program. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Stores the icon resource for a shell/menu item: cmd.exe. It does not execute a program. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L36 · SET-VALUE · `Position`

- **Registry key:** `HKEY_CLASSES_ROOT\Drive\shell\GalleryTerminalBehaivor`
- **Raw .reg data:** `"Middle"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Position” în asocierile de fișiere sau integrarea shell/COM la Middle (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Position” option in file associations or shell/COM integration to Middle (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L37 · SET-VALUE · `SubCommands`

- **Registry key:** `HKEY_CLASSES_ROOT\Drive\shell\GalleryTerminalBehaivor`
- **Raw .reg data:** `""`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Stabilește lista și ordinea subcomenzilor într-un meniu contextual în cascadă; fiecare comandă trebuie să fie înregistrată separat. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Defines the list and order of verbs in a cascading context menu; each verb must also be registered. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L40 · SET-VALUE · `(Default)`

- **Registry key:** `HKEY_CLASSES_ROOT\Drive\shell\GalleryTerminalBehaivor\shell\Powershell`
- **Raw .reg data:** `"Open PowerShell 5 Window here..."`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează descrierea sau legarea implicită a înregistrării shell/COM la „Open PowerShell 5 Window here...”. Sensul exact depinde de subcheia părinte. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the default label/binding for this shell/COM registration to “Open PowerShell 5 Window here...”. Exact meaning depends on the parent subkey. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L41 · DELETE-VALUE · `Extended`

- **Registry key:** `HKEY_CLASSES_ROOT\Drive\shell\GalleryTerminalBehaivor\shell\Powershell`
- **Raw .reg data:** `-`
- **Type / tip:** `VALUE DELETE`
- **Ce face / RO:** Elimină opțiunea „Extended” din asocierile de fișiere sau integrarea shell/COM; NU echivalează automat cu dezactivarea funcției și poate restabili o valoare implicită. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Removes the “Extended” option from file associations or shell/COM integration; this does NOT necessarily disable the feature and may restore a default behavior. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L42 · SET-VALUE · `Icon`

- **Registry key:** `HKEY_CLASSES_ROOT\Drive\shell\GalleryTerminalBehaivor\shell\Powershell`
- **Raw .reg data:** `"powershell.exe"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Stochează resursa grafică pentru intrarea de meniu/înregistrarea shell: powershell.exe. Nu execută niciun program. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Stores the icon resource for a shell/menu item: powershell.exe. It does not execute a program. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L43 · SET-VALUE · `NoWorkingDirectory`

- **Registry key:** `HKEY_CLASSES_ROOT\Drive\shell\GalleryTerminalBehaivor\shell\Powershell`
- **Raw .reg data:** `""`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „No Working Directory” în asocierile de fișiere sau integrarea shell/COM la (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “No Working Directory” option in file associations or shell/COM integration to (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L44 · SET-VALUE · `ShowBasedOnVelocityId`

- **Registry key:** `HKEY_CLASSES_ROOT\Drive\shell\GalleryTerminalBehaivor\shell\Powershell`
- **Raw .reg data:** `dword:00639bc8`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Show Based On Velocity Id” în asocierile de fișiere sau integrarea shell/COM la 6527944 (0x00639BC8) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Show Based On Velocity Id” option in file associations or shell/COM integration to 6527944 (0x00639BC8) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L47 · SET-VALUE · `(Default)`

- **Registry key:** `HKEY_CLASSES_ROOT\Drive\shell\GalleryTerminalBehaivor\shell\Powershell\command`
- **Raw .reg data:** `"powershell.exe -noexit -command Set-Location -literalPath '%V'"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează comanda de lansare a acestei acțiuni shell: powershell.exe -noexit -command Set-Location -literalPath '%V'. Poate executa programe la selecția utilizatorului; nu executa automat. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the shell action command line: powershell.exe -noexit -command Set-Location -literalPath '%V'. It may launch programs when the user selects the action; never run automatically. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L50 · SET-VALUE · `(Default)`

- **Registry key:** `HKEY_CLASSES_ROOT\Drive\shell\GalleryTerminalBehaivor\shell\cmd2`
- **Raw .reg data:** `"Open CMD Window here..."`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează descrierea sau legarea implicită a înregistrării shell/COM la „Open CMD Window here...”. Sensul exact depinde de subcheia părinte. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the default label/binding for this shell/COM registration to “Open CMD Window here...”. Exact meaning depends on the parent subkey. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L51 · DELETE-VALUE · `Extended`

- **Registry key:** `HKEY_CLASSES_ROOT\Drive\shell\GalleryTerminalBehaivor\shell\cmd2`
- **Raw .reg data:** `-`
- **Type / tip:** `VALUE DELETE`
- **Ce face / RO:** Elimină opțiunea „Extended” din asocierile de fișiere sau integrarea shell/COM; NU echivalează automat cu dezactivarea funcției și poate restabili o valoare implicită. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Removes the “Extended” option from file associations or shell/COM integration; this does NOT necessarily disable the feature and may restore a default behavior. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L52 · SET-VALUE · `Icon`

- **Registry key:** `HKEY_CLASSES_ROOT\Drive\shell\GalleryTerminalBehaivor\shell\cmd2`
- **Raw .reg data:** `"imageres.dll,-5323"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Stochează resursa grafică pentru intrarea de meniu/înregistrarea shell: imageres.dll,-5323. Nu execută niciun program. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Stores the icon resource for a shell/menu item: imageres.dll,-5323. It does not execute a program. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L53 · SET-VALUE · `NoWorkingDirectory`

- **Registry key:** `HKEY_CLASSES_ROOT\Drive\shell\GalleryTerminalBehaivor\shell\cmd2`
- **Raw .reg data:** `""`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „No Working Directory” în asocierile de fișiere sau integrarea shell/COM la (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “No Working Directory” option in file associations or shell/COM integration to (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L56 · SET-VALUE · `(Default)`

- **Registry key:** `HKEY_CLASSES_ROOT\Drive\shell\GalleryTerminalBehaivor\shell\cmd2\command`
- **Raw .reg data:** `"cmd.exe /s /k pushd \"%V\""`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează comanda de lansare a acestei acțiuni shell: cmd.exe /s /k pushd "%V". Poate executa programe la selecția utilizatorului; nu executa automat. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the shell action command line: cmd.exe /s /k pushd "%V". It may launch programs when the user selects the action; never run automatically. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L62 · SET-VALUE · `MUIVerb`

- **Registry key:** `HKEY_CLASSES_ROOT\Directory\shell\GalleryTerminalBehaivor`
- **Raw .reg data:** `"Open terminal in place..."`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează eticheta vizibilă sau referința localizată a comenzii din meniul contextual la „Open terminal in place...”. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the visible/localized shell command label to “Open terminal in place...”. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L63 · SET-VALUE · `Icon`

- **Registry key:** `HKEY_CLASSES_ROOT\Directory\shell\GalleryTerminalBehaivor`
- **Raw .reg data:** `"cmd.exe"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Stochează resursa grafică pentru intrarea de meniu/înregistrarea shell: cmd.exe. Nu execută niciun program. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Stores the icon resource for a shell/menu item: cmd.exe. It does not execute a program. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L64 · SET-VALUE · `Position`

- **Registry key:** `HKEY_CLASSES_ROOT\Directory\shell\GalleryTerminalBehaivor`
- **Raw .reg data:** `"Middle"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Position” în asocierile de fișiere sau integrarea shell/COM la Middle (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Position” option in file associations or shell/COM integration to Middle (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L65 · SET-VALUE · `SubCommands`

- **Registry key:** `HKEY_CLASSES_ROOT\Directory\shell\GalleryTerminalBehaivor`
- **Raw .reg data:** `""`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Stabilește lista și ordinea subcomenzilor într-un meniu contextual în cascadă; fiecare comandă trebuie să fie înregistrată separat. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Defines the list and order of verbs in a cascading context menu; each verb must also be registered. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L68 · SET-VALUE · `(Default)`

- **Registry key:** `HKEY_CLASSES_ROOT\Directory\shell\GalleryTerminalBehaivor\shell\Powershell`
- **Raw .reg data:** `"Open PowerShell 5 Window here..."`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează descrierea sau legarea implicită a înregistrării shell/COM la „Open PowerShell 5 Window here...”. Sensul exact depinde de subcheia părinte. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the default label/binding for this shell/COM registration to “Open PowerShell 5 Window here...”. Exact meaning depends on the parent subkey. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L69 · DELETE-VALUE · `Extended`

- **Registry key:** `HKEY_CLASSES_ROOT\Directory\shell\GalleryTerminalBehaivor\shell\Powershell`
- **Raw .reg data:** `-`
- **Type / tip:** `VALUE DELETE`
- **Ce face / RO:** Elimină opțiunea „Extended” din asocierile de fișiere sau integrarea shell/COM; NU echivalează automat cu dezactivarea funcției și poate restabili o valoare implicită. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Removes the “Extended” option from file associations or shell/COM integration; this does NOT necessarily disable the feature and may restore a default behavior. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L70 · SET-VALUE · `Icon`

- **Registry key:** `HKEY_CLASSES_ROOT\Directory\shell\GalleryTerminalBehaivor\shell\Powershell`
- **Raw .reg data:** `"powershell.exe"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Stochează resursa grafică pentru intrarea de meniu/înregistrarea shell: powershell.exe. Nu execută niciun program. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Stores the icon resource for a shell/menu item: powershell.exe. It does not execute a program. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L71 · SET-VALUE · `NoWorkingDirectory`

- **Registry key:** `HKEY_CLASSES_ROOT\Directory\shell\GalleryTerminalBehaivor\shell\Powershell`
- **Raw .reg data:** `""`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „No Working Directory” în asocierile de fișiere sau integrarea shell/COM la (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “No Working Directory” option in file associations or shell/COM integration to (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L72 · SET-VALUE · `ShowBasedOnVelocityId`

- **Registry key:** `HKEY_CLASSES_ROOT\Directory\shell\GalleryTerminalBehaivor\shell\Powershell`
- **Raw .reg data:** `dword:00639bc8`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Show Based On Velocity Id” în asocierile de fișiere sau integrarea shell/COM la 6527944 (0x00639BC8) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Show Based On Velocity Id” option in file associations or shell/COM integration to 6527944 (0x00639BC8) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L75 · SET-VALUE · `(Default)`

- **Registry key:** `HKEY_CLASSES_ROOT\Directory\shell\GalleryTerminalBehaivor\shell\Powershell\command`
- **Raw .reg data:** `"powershell.exe -noexit -command Set-Location -literalPath '%V'"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează comanda de lansare a acestei acțiuni shell: powershell.exe -noexit -command Set-Location -literalPath '%V'. Poate executa programe la selecția utilizatorului; nu executa automat. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the shell action command line: powershell.exe -noexit -command Set-Location -literalPath '%V'. It may launch programs when the user selects the action; never run automatically. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L78 · SET-VALUE · `(Default)`

- **Registry key:** `HKEY_CLASSES_ROOT\Directory\shell\GalleryTerminalBehaivor\shell\cmd2`
- **Raw .reg data:** `"Open CMD Window here..."`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează descrierea sau legarea implicită a înregistrării shell/COM la „Open CMD Window here...”. Sensul exact depinde de subcheia părinte. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the default label/binding for this shell/COM registration to “Open CMD Window here...”. Exact meaning depends on the parent subkey. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L79 · DELETE-VALUE · `Extended`

- **Registry key:** `HKEY_CLASSES_ROOT\Directory\shell\GalleryTerminalBehaivor\shell\cmd2`
- **Raw .reg data:** `-`
- **Type / tip:** `VALUE DELETE`
- **Ce face / RO:** Elimină opțiunea „Extended” din asocierile de fișiere sau integrarea shell/COM; NU echivalează automat cu dezactivarea funcției și poate restabili o valoare implicită. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Removes the “Extended” option from file associations or shell/COM integration; this does NOT necessarily disable the feature and may restore a default behavior. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L80 · SET-VALUE · `Icon`

- **Registry key:** `HKEY_CLASSES_ROOT\Directory\shell\GalleryTerminalBehaivor\shell\cmd2`
- **Raw .reg data:** `"imageres.dll,-5323"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Stochează resursa grafică pentru intrarea de meniu/înregistrarea shell: imageres.dll,-5323. Nu execută niciun program. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Stores the icon resource for a shell/menu item: imageres.dll,-5323. It does not execute a program. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L81 · SET-VALUE · `NoWorkingDirectory`

- **Registry key:** `HKEY_CLASSES_ROOT\Directory\shell\GalleryTerminalBehaivor\shell\cmd2`
- **Raw .reg data:** `""`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „No Working Directory” în asocierile de fișiere sau integrarea shell/COM la (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “No Working Directory” option in file associations or shell/COM integration to (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L84 · SET-VALUE · `(Default)`

- **Registry key:** `HKEY_CLASSES_ROOT\Directory\shell\GalleryTerminalBehaivor\shell\cmd2\command`
- **Raw .reg data:** `"cmd.exe /s /k pushd \"%V\""`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează comanda de lansare a acestei acțiuni shell: cmd.exe /s /k pushd "%V". Poate executa programe la selecția utilizatorului; nu executa automat. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the shell action command line: cmd.exe /s /k pushd "%V". It may launch programs when the user selects the action; never run automatically. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L90 · SET-VALUE · `MUIVerb`

- **Registry key:** `HKEY_CLASSES_ROOT\Directory\Background\shell\GalleryTerminalBehaivor`
- **Raw .reg data:** `"Open terminal in place..."`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează eticheta vizibilă sau referința localizată a comenzii din meniul contextual la „Open terminal in place...”. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the visible/localized shell command label to “Open terminal in place...”. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L91 · SET-VALUE · `Icon`

- **Registry key:** `HKEY_CLASSES_ROOT\Directory\Background\shell\GalleryTerminalBehaivor`
- **Raw .reg data:** `"cmd.exe"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Stochează resursa grafică pentru intrarea de meniu/înregistrarea shell: cmd.exe. Nu execută niciun program. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Stores the icon resource for a shell/menu item: cmd.exe. It does not execute a program. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L92 · SET-VALUE · `Position`

- **Registry key:** `HKEY_CLASSES_ROOT\Directory\Background\shell\GalleryTerminalBehaivor`
- **Raw .reg data:** `"Middle"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Position” în asocierile de fișiere sau integrarea shell/COM la Middle (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Position” option in file associations or shell/COM integration to Middle (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L93 · SET-VALUE · `SubCommands`

- **Registry key:** `HKEY_CLASSES_ROOT\Directory\Background\shell\GalleryTerminalBehaivor`
- **Raw .reg data:** `""`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Stabilește lista și ordinea subcomenzilor într-un meniu contextual în cascadă; fiecare comandă trebuie să fie înregistrată separat. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Defines the list and order of verbs in a cascading context menu; each verb must also be registered. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L96 · SET-VALUE · `(Default)`

- **Registry key:** `HKEY_CLASSES_ROOT\Directory\Background\shell\GalleryTerminalBehaivor\shell\Powershell`
- **Raw .reg data:** `"Open PowerShell 5 Window here..."`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează descrierea sau legarea implicită a înregistrării shell/COM la „Open PowerShell 5 Window here...”. Sensul exact depinde de subcheia părinte. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the default label/binding for this shell/COM registration to “Open PowerShell 5 Window here...”. Exact meaning depends on the parent subkey. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L97 · DELETE-VALUE · `Extended`

- **Registry key:** `HKEY_CLASSES_ROOT\Directory\Background\shell\GalleryTerminalBehaivor\shell\Powershell`
- **Raw .reg data:** `-`
- **Type / tip:** `VALUE DELETE`
- **Ce face / RO:** Elimină opțiunea „Extended” din asocierile de fișiere sau integrarea shell/COM; NU echivalează automat cu dezactivarea funcției și poate restabili o valoare implicită. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Removes the “Extended” option from file associations or shell/COM integration; this does NOT necessarily disable the feature and may restore a default behavior. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L98 · SET-VALUE · `Icon`

- **Registry key:** `HKEY_CLASSES_ROOT\Directory\Background\shell\GalleryTerminalBehaivor\shell\Powershell`
- **Raw .reg data:** `"powershell.exe"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Stochează resursa grafică pentru intrarea de meniu/înregistrarea shell: powershell.exe. Nu execută niciun program. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Stores the icon resource for a shell/menu item: powershell.exe. It does not execute a program. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L99 · SET-VALUE · `NoWorkingDirectory`

- **Registry key:** `HKEY_CLASSES_ROOT\Directory\Background\shell\GalleryTerminalBehaivor\shell\Powershell`
- **Raw .reg data:** `""`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „No Working Directory” în asocierile de fișiere sau integrarea shell/COM la (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “No Working Directory” option in file associations or shell/COM integration to (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L100 · SET-VALUE · `ShowBasedOnVelocityId`

- **Registry key:** `HKEY_CLASSES_ROOT\Directory\Background\shell\GalleryTerminalBehaivor\shell\Powershell`
- **Raw .reg data:** `dword:00639bc8`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Show Based On Velocity Id” în asocierile de fișiere sau integrarea shell/COM la 6527944 (0x00639BC8) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Show Based On Velocity Id” option in file associations or shell/COM integration to 6527944 (0x00639BC8) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L103 · SET-VALUE · `(Default)`

- **Registry key:** `HKEY_CLASSES_ROOT\Directory\Background\shell\GalleryTerminalBehaivor\shell\Powershell\command`
- **Raw .reg data:** `"powershell.exe -noexit -command Set-Location -literalPath '%V'"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează comanda de lansare a acestei acțiuni shell: powershell.exe -noexit -command Set-Location -literalPath '%V'. Poate executa programe la selecția utilizatorului; nu executa automat. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the shell action command line: powershell.exe -noexit -command Set-Location -literalPath '%V'. It may launch programs when the user selects the action; never run automatically. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L106 · SET-VALUE · `(Default)`

- **Registry key:** `HKEY_CLASSES_ROOT\Directory\Background\shell\GalleryTerminalBehaivor\shell\cmd2`
- **Raw .reg data:** `"Open CMD Window here..."`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează descrierea sau legarea implicită a înregistrării shell/COM la „Open CMD Window here...”. Sensul exact depinde de subcheia părinte. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the default label/binding for this shell/COM registration to “Open CMD Window here...”. Exact meaning depends on the parent subkey. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L107 · DELETE-VALUE · `Extended`

- **Registry key:** `HKEY_CLASSES_ROOT\Directory\Background\shell\GalleryTerminalBehaivor\shell\cmd2`
- **Raw .reg data:** `-`
- **Type / tip:** `VALUE DELETE`
- **Ce face / RO:** Elimină opțiunea „Extended” din asocierile de fișiere sau integrarea shell/COM; NU echivalează automat cu dezactivarea funcției și poate restabili o valoare implicită. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Removes the “Extended” option from file associations or shell/COM integration; this does NOT necessarily disable the feature and may restore a default behavior. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L108 · SET-VALUE · `Icon`

- **Registry key:** `HKEY_CLASSES_ROOT\Directory\Background\shell\GalleryTerminalBehaivor\shell\cmd2`
- **Raw .reg data:** `"imageres.dll,-5323"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Stochează resursa grafică pentru intrarea de meniu/înregistrarea shell: imageres.dll,-5323. Nu execută niciun program. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Stores the icon resource for a shell/menu item: imageres.dll,-5323. It does not execute a program. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L109 · SET-VALUE · `NoWorkingDirectory`

- **Registry key:** `HKEY_CLASSES_ROOT\Directory\Background\shell\GalleryTerminalBehaivor\shell\cmd2`
- **Raw .reg data:** `""`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „No Working Directory” în asocierile de fișiere sau integrarea shell/COM la (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “No Working Directory” option in file associations or shell/COM integration to (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L112 · SET-VALUE · `(Default)`

- **Registry key:** `HKEY_CLASSES_ROOT\Directory\Background\shell\GalleryTerminalBehaivor\shell\cmd2\command`
- **Raw .reg data:** `"cmd.exe /s /k pushd \"%V\""`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează comanda de lansare a acestei acțiuni shell: cmd.exe /s /k pushd "%V". Poate executa programe la selecția utilizatorului; nu executa automat. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the shell action command line: cmd.exe /s /k pushd "%V". It may launch programs when the user selects the action; never run automatically. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

## Referințe / References

- https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers
