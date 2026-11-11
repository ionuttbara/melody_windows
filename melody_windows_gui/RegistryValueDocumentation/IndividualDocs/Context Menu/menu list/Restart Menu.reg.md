# Context Menu/menu list/Restart Menu.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `b5840dc2784478c6105abac55dc6dfdaaed783d4552b4c261ac5ceee0fb76b89`
- **Recipe verdict / verdict rețetă:** `CONDITIONAL`
- **Windows container / interval Windows:** `7600+`
- **Runtime prerequisite / condiție runtime:** `shell`
- **Value/operation descriptions / operații:** 42
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L3 · DELETE-KEY · `(default / implicit)`

- **Registry key:** `HKEY_CLASSES_ROOT\DesktopBackground\Shell\RestartB`
- **Raw .reg data:** ``
- **Type / tip:** `KEY DELETE`
- **Ce face / RO:** Elimină ramura meniului contextual/shell „RestartB”, inclusiv comenzile și subcheile sale; verifică dacă alte extensii depind de aceasta. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Removes context-menu/shell branch “RestartB”, including commands and child keys; check whether other extensions depend on it. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L6 · SET-VALUE · `MUIVerb`

- **Registry key:** `HKEY_CLASSES_ROOT\DesktopBackground\Shell\RestartB`
- **Raw .reg data:** `"Device Shutdown"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează eticheta vizibilă sau referința localizată a comenzii din meniul contextual la „Device Shutdown”. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the visible/localized shell command label to “Device Shutdown”. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L7 · SET-VALUE · `Icon`

- **Registry key:** `HKEY_CLASSES_ROOT\DesktopBackground\Shell\RestartB`
- **Raw .reg data:** `"shell32.dll,-16739"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Stochează resursa grafică pentru intrarea de meniu/înregistrarea shell: shell32.dll,-16739. Nu execută niciun program. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Stores the icon resource for a shell/menu item: shell32.dll,-16739. It does not execute a program. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L8 · SET-VALUE · `Position`

- **Registry key:** `HKEY_CLASSES_ROOT\DesktopBackground\Shell\RestartB`
- **Raw .reg data:** `"Bottom"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Position” în asocierile de fișiere sau integrarea shell/COM la Bottom (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Position” option in file associations or shell/COM integration to Bottom (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L9 · SET-VALUE · `SubCommands`

- **Registry key:** `HKEY_CLASSES_ROOT\DesktopBackground\Shell\RestartB`
- **Raw .reg data:** `""`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Stabilește lista și ordinea subcomenzilor într-un meniu contextual în cascadă; fiecare comandă trebuie să fie înregistrată separat. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Defines the list and order of verbs in a cascading context menu; each verb must also be registered. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L12 · SET-VALUE · `MUIVerb`

- **Registry key:** `HKEY_CLASSES_ROOT\DesktopBackground\Shell\RestartB\shell\001flyout`
- **Raw .reg data:** `"Shut Down PC"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează eticheta vizibilă sau referința localizată a comenzii din meniul contextual la „Shut Down PC”. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the visible/localized shell command label to “Shut Down PC”. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L15 · SET-VALUE · `(Default)`

- **Registry key:** `HKEY_CLASSES_ROOT\DesktopBackground\Shell\RestartB\shell\001flyout\command`
- **Raw .reg data:** `"shutdown /s /f /t 0"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează comanda de lansare a acestei acțiuni shell: shutdown /s /f /t 0. Poate executa programe la selecția utilizatorului; nu executa automat. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the shell action command line: shutdown /s /f /t 0. It may launch programs when the user selects the action; never run automatically. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L18 · SET-VALUE · `MUIVerb`

- **Registry key:** `HKEY_CLASSES_ROOT\DesktopBackground\Shell\RestartB\shell\002flyout`
- **Raw .reg data:** `"Restart PC"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează eticheta vizibilă sau referința localizată a comenzii din meniul contextual la „Restart PC”. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the visible/localized shell command label to “Restart PC”. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L19 · SET-VALUE · `CommandFlags`

- **Registry key:** `HKEY_CLASSES_ROOT\DesktopBackground\Shell\RestartB\shell\002flyout`
- **Raw .reg data:** `dword:00000020`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Command Flags” în asocierile de fișiere sau integrarea shell/COM la 32 (0x00000020) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Command Flags” option in file associations or shell/COM integration to 32 (0x00000020) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L22 · SET-VALUE · `(Default)`

- **Registry key:** `HKEY_CLASSES_ROOT\DesktopBackground\Shell\RestartB\shell\002flyout\command`
- **Raw .reg data:** `"shutdown /r /t 0"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează comanda de lansare a acestei acțiuni shell: shutdown /r /t 0. Poate executa programe la selecția utilizatorului; nu executa automat. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the shell action command line: shutdown /r /t 0. It may launch programs when the user selects the action; never run automatically. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L25 · SET-VALUE · `MUIVerb`

- **Registry key:** `HKEY_CLASSES_ROOT\DesktopBackground\Shell\RestartB\shell\003flyout`
- **Raw .reg data:** `"Restart PC. After reboot , re-open unclosed apps."`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează eticheta vizibilă sau referința localizată a comenzii din meniul contextual la „Restart PC. After reboot , re-open unclosed apps.”. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the visible/localized shell command label to “Restart PC. After reboot , re-open unclosed apps.”. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L26 · SET-VALUE · `CommandFlags`

- **Registry key:** `HKEY_CLASSES_ROOT\DesktopBackground\Shell\RestartB\shell\003flyout`
- **Raw .reg data:** `dword:00000020`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Command Flags” în asocierile de fișiere sau integrarea shell/COM la 32 (0x00000020) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Command Flags” option in file associations or shell/COM integration to 32 (0x00000020) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L29 · SET-VALUE · `(Default)`

- **Registry key:** `HKEY_CLASSES_ROOT\DesktopBackground\Shell\RestartB\shell\003flyout\command`
- **Raw .reg data:** `"shutdown /g /t 0"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează comanda de lansare a acestei acțiuni shell: shutdown /g /t 0. Poate executa programe la selecția utilizatorului; nu executa automat. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the shell action command line: shutdown /g /t 0. It may launch programs when the user selects the action; never run automatically. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L32 · SET-VALUE · `MUIVerb`

- **Registry key:** `HKEY_CLASSES_ROOT\DesktopBackground\Shell\RestartB\shell\004flyout`
- **Raw .reg data:** `"Restart to Advanced Startup Options"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează eticheta vizibilă sau referința localizată a comenzii din meniul contextual la „Restart to Advanced Startup Options”. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the visible/localized shell command label to “Restart to Advanced Startup Options”. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L33 · SET-VALUE · `HasLUAShield`

- **Registry key:** `HKEY_CLASSES_ROOT\DesktopBackground\Shell\RestartB\shell\004flyout`
- **Raw .reg data:** `""`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Has LUAShield” în asocierile de fișiere sau integrarea shell/COM la (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Has LUAShield” option in file associations or shell/COM integration to (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L36 · SET-VALUE · `(Default)`

- **Registry key:** `HKEY_CLASSES_ROOT\DesktopBackground\Shell\RestartB\shell\004flyout\command`
- **Raw .reg data:** `"shutdown /r /o /f /t 0"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează comanda de lansare a acestei acțiuni shell: shutdown /r /o /f /t 0. Poate executa programe la selecția utilizatorului; nu executa automat. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the shell action command line: shutdown /r /o /f /t 0. It may launch programs when the user selects the action; never run automatically. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L39 · SET-VALUE · `MUIVerb`

- **Registry key:** `HKEY_CLASSES_ROOT\DesktopBackground\Shell\RestartB\shell\005flyout`
- **Raw .reg data:** `"Restart to UEFI/BIOS"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează eticheta vizibilă sau referința localizată a comenzii din meniul contextual la „Restart to UEFI/BIOS”. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the visible/localized shell command label to “Restart to UEFI/BIOS”. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L40 · SET-VALUE · `HasLUAShield`

- **Registry key:** `HKEY_CLASSES_ROOT\DesktopBackground\Shell\RestartB\shell\005flyout`
- **Raw .reg data:** `""`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Has LUAShield” în asocierile de fișiere sau integrarea shell/COM la (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Has LUAShield” option in file associations or shell/COM integration to (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L43 · SET-VALUE · `(Default)`

- **Registry key:** `HKEY_CLASSES_ROOT\DesktopBackground\Shell\RestartB\shell\005flyout\command`
- **Raw .reg data:** `"shutdown /r /fw /f /t 0"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează comanda de lansare a acestei acțiuni shell: shutdown /r /fw /f /t 0. Poate executa programe la selecția utilizatorului; nu executa automat. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the shell action command line: shutdown /r /fw /f /t 0. It may launch programs when the user selects the action; never run automatically. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L46 · SET-VALUE · `(Default)`

- **Registry key:** `HKEY_CLASSES_ROOT\DesktopBackground\Shell\RestartB\shell\006-NormalMode`
- **Raw .reg data:** `"Restart to normal mode (Exit to Safe Mode)"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează descrierea sau legarea implicită a înregistrării shell/COM la „Restart to normal mode (Exit to Safe Mode)”. Sensul exact depinde de subcheia părinte. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the default label/binding for this shell/COM registration to “Restart to normal mode (Exit to Safe Mode)”. Exact meaning depends on the parent subkey. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L47 · SET-VALUE · `HasLUAShield`

- **Registry key:** `HKEY_CLASSES_ROOT\DesktopBackground\Shell\RestartB\shell\006-NormalMode`
- **Raw .reg data:** `""`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Has LUAShield” în asocierile de fișiere sau integrarea shell/COM la (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Has LUAShield” option in file associations or shell/COM integration to (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L50 · SET-VALUE · `(Default)`

- **Registry key:** `HKEY_CLASSES_ROOT\DesktopBackground\Shell\RestartB\shell\006-NormalMode\command`
- **Raw .reg data:** `"powershell -windowstyle hidden -command \"Start-Process cmd -ArgumentList '/s,/c,bcdedit /deletevalue {current} safeboot & bcdedit /deletevalue {current} safebootalternateshell & shutdown -r -t 00 -f' -Verb runAs\""`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează comanda de lansare a acestei acțiuni shell: powershell -windowstyle hidden -command "Start-Process cmd -ArgumentList '/s,/c,bcdedit /deletevalue {current} safeboot & bcdedit /deletevalue {current} safebootalternateshell & shutdown -r -t 00 -f' -Verb runAs". Poate executa programe la selecția utilizatorului; nu executa automat. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the shell action command line: powershell -windowstyle hidden -command "Start-Process cmd -ArgumentList '/s,/c,bcdedit /deletevalue {current} safeboot & bcdedit /deletevalue {current} safebootalternateshell & shutdown -r -t 00 -f' -Verb runAs". It may launch programs when the user selects the action; never run automatically. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L53 · SET-VALUE · `(Default)`

- **Registry key:** `HKEY_CLASSES_ROOT\DesktopBackground\Shell\RestartB\shell\006-SafeMode`
- **Raw .reg data:** `"Restart in Safe Mode"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează descrierea sau legarea implicită a înregistrării shell/COM la „Restart in Safe Mode”. Sensul exact depinde de subcheia părinte. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the default label/binding for this shell/COM registration to “Restart in Safe Mode”. Exact meaning depends on the parent subkey. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L54 · SET-VALUE · `HasLUAShield`

- **Registry key:** `HKEY_CLASSES_ROOT\DesktopBackground\Shell\RestartB\shell\006-SafeMode`
- **Raw .reg data:** `""`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Has LUAShield” în asocierile de fișiere sau integrarea shell/COM la (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Has LUAShield” option in file associations or shell/COM integration to (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L57 · SET-VALUE · `(Default)`

- **Registry key:** `HKEY_CLASSES_ROOT\DesktopBackground\Shell\RestartB\shell\006-SafeMode\command`
- **Raw .reg data:** `"powershell -windowstyle hidden -command \"Start-Process cmd -ArgumentList '/s,/c,bcdedit /set {current} safeboot minimal & bcdedit /deletevalue {current} safebootalternateshell & shutdown -r -t 00 -f' -Verb runAs\""`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează comanda de lansare a acestei acțiuni shell: powershell -windowstyle hidden -command "Start-Process cmd -ArgumentList '/s,/c,bcdedit /set {current} safeboot minimal & bcdedit /deletevalue {current} safebootalternateshell & shutdown -r -t 00 -f' -Verb runAs". Poate executa programe la selecția utilizatorului; nu executa automat. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the shell action command line: powershell -windowstyle hidden -command "Start-Process cmd -ArgumentList '/s,/c,bcdedit /set {current} safeboot minimal & bcdedit /deletevalue {current} safebootalternateshell & shutdown -r -t 00 -f' -Verb runAs". It may launch programs when the user selects the action; never run automatically. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L60 · SET-VALUE · `(Default)`

- **Registry key:** `HKEY_CLASSES_ROOT\DesktopBackground\Shell\RestartB\shell\006-SafeModeNetworking`
- **Raw .reg data:** `"Restart in Safe Mode with Networking"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează descrierea sau legarea implicită a înregistrării shell/COM la „Restart in Safe Mode with Networking”. Sensul exact depinde de subcheia părinte. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the default label/binding for this shell/COM registration to “Restart in Safe Mode with Networking”. Exact meaning depends on the parent subkey. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L61 · SET-VALUE · `HasLUAShield`

- **Registry key:** `HKEY_CLASSES_ROOT\DesktopBackground\Shell\RestartB\shell\006-SafeModeNetworking`
- **Raw .reg data:** `""`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Has LUAShield” în asocierile de fișiere sau integrarea shell/COM la (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Has LUAShield” option in file associations or shell/COM integration to (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L64 · SET-VALUE · `(Default)`

- **Registry key:** `HKEY_CLASSES_ROOT\DesktopBackground\Shell\RestartB\shell\006-SafeModeNetworking\command`
- **Raw .reg data:** `"powershell -windowstyle hidden -command \"Start-Process cmd -ArgumentList '/s,/c,bcdedit /set {current} safeboot network & bcdedit /deletevalue {current} safebootalternateshell & shutdown -r -t 00 -f' -Verb runAs\""`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează comanda de lansare a acestei acțiuni shell: powershell -windowstyle hidden -command "Start-Process cmd -ArgumentList '/s,/c,bcdedit /set {current} safeboot network & bcdedit /deletevalue {current} safebootalternateshell & shutdown -r -t 00 -f' -Verb runAs". Poate executa programe la selecția utilizatorului; nu executa automat. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the shell action command line: powershell -windowstyle hidden -command "Start-Process cmd -ArgumentList '/s,/c,bcdedit /set {current} safeboot network & bcdedit /deletevalue {current} safebootalternateshell & shutdown -r -t 00 -f' -Verb runAs". It may launch programs when the user selects the action; never run automatically. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L67 · SET-VALUE · `(Default)`

- **Registry key:** `HKEY_CLASSES_ROOT\DesktopBackground\Shell\RestartB\shell\006-SafeModeCommandPrompt`
- **Raw .reg data:** `"Restart in Safe Mode with Command Prompt"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează descrierea sau legarea implicită a înregistrării shell/COM la „Restart in Safe Mode with Command Prompt”. Sensul exact depinde de subcheia părinte. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the default label/binding for this shell/COM registration to “Restart in Safe Mode with Command Prompt”. Exact meaning depends on the parent subkey. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L68 · SET-VALUE · `HasLUAShield`

- **Registry key:** `HKEY_CLASSES_ROOT\DesktopBackground\Shell\RestartB\shell\006-SafeModeCommandPrompt`
- **Raw .reg data:** `""`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Has LUAShield” în asocierile de fișiere sau integrarea shell/COM la (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Has LUAShield” option in file associations or shell/COM integration to (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L71 · SET-VALUE · `(Default)`

- **Registry key:** `HKEY_CLASSES_ROOT\DesktopBackground\Shell\RestartB\shell\006-SafeModeCommandPrompt\command`
- **Raw .reg data:** `"powershell -windowstyle hidden -command \"Start-Process cmd -ArgumentList '/s,/c,bcdedit /set {current} safeboot minimal & bcdedit /set {current} safebootalternateshell yes & shutdown -r -t 00 -f' -Verb runAs\""`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează comanda de lansare a acestei acțiuni shell: powershell -windowstyle hidden -command "Start-Process cmd -ArgumentList '/s,/c,bcdedit /set {current} safeboot minimal & bcdedit /set {current} safebootalternateshell yes & shutdown -r -t 00 -f' -Verb runAs". Poate executa programe la selecția utilizatorului; nu executa automat. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the shell action command line: powershell -windowstyle hidden -command "Start-Process cmd -ArgumentList '/s,/c,bcdedit /set {current} safeboot minimal & bcdedit /set {current} safebootalternateshell yes & shutdown -r -t 00 -f' -Verb runAs". It may launch programs when the user selects the action; never run automatically. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L74 · SET-VALUE · `Icon`

- **Registry key:** `HKEY_CLASSES_ROOT\DesktopBackground\Shell\RestartB\shell\007-TurnOffDisplay`
- **Raw .reg data:** `"imageres.dll,-109"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Stochează resursa grafică pentru intrarea de meniu/înregistrarea shell: imageres.dll,-109. Nu execută niciun program. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Stores the icon resource for a shell/menu item: imageres.dll,-109. It does not execute a program. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L75 · SET-VALUE · `MUIVerb`

- **Registry key:** `HKEY_CLASSES_ROOT\DesktopBackground\Shell\RestartB\shell\007-TurnOffDisplay`
- **Raw .reg data:** `"Turn off display"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează eticheta vizibilă sau referința localizată a comenzii din meniul contextual la „Turn off display”. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the visible/localized shell command label to “Turn off display”. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L76 · SET-VALUE · `Position`

- **Registry key:** `HKEY_CLASSES_ROOT\DesktopBackground\Shell\RestartB\shell\007-TurnOffDisplay`
- **Raw .reg data:** `"Bottom"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Position” în asocierile de fișiere sau integrarea shell/COM la Bottom (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Position” option in file associations or shell/COM integration to Bottom (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L77 · SET-VALUE · `SubCommands`

- **Registry key:** `HKEY_CLASSES_ROOT\DesktopBackground\Shell\RestartB\shell\007-TurnOffDisplay`
- **Raw .reg data:** `""`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Stabilește lista și ordinea subcomenzilor într-un meniu contextual în cascadă; fiecare comandă trebuie să fie înregistrată separat. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Defines the list and order of verbs in a cascading context menu; each verb must also be registered. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L82 · SET-VALUE · `Icon`

- **Registry key:** `HKEY_CLASSES_ROOT\DesktopBackground\Shell\RestartB\shell\007-TurnOffDisplay\shell\01menu`
- **Raw .reg data:** `"powercpl.dll,-513"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Stochează resursa grafică pentru intrarea de meniu/înregistrarea shell: powercpl.dll,-513. Nu execută niciun program. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Stores the icon resource for a shell/menu item: powercpl.dll,-513. It does not execute a program. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L83 · SET-VALUE · `MUIVerb`

- **Registry key:** `HKEY_CLASSES_ROOT\DesktopBackground\Shell\RestartB\shell\007-TurnOffDisplay\shell\01menu`
- **Raw .reg data:** `"Turn off display"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează eticheta vizibilă sau referința localizată a comenzii din meniul contextual la „Turn off display”. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the visible/localized shell command label to “Turn off display”. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L86 · SET-VALUE · `(Default)`

- **Registry key:** `HKEY_CLASSES_ROOT\DesktopBackground\Shell\RestartB\shell\007-TurnOffDisplay\shell\01menu\command`
- **Raw .reg data:** `"cmd /c \"powershell.exe -Command \"(Add-Type '[DllImport(\\\"user32.dll\\\")]public static extern int SendMessage(int hWnd,int hMsg,int wParam,int lParam);' -Name a -Pas)::SendMessage(-1,0x0112,0xF170,2)\"\""`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează comanda de lansare a acestei acțiuni shell: cmd /c "powershell.exe -Command "(Add-Type '[DllImport(\"user32.dll\")]public static extern int SendMessage(int hWnd,int hMsg,int wParam,int lParam);' -Name a -Pas)::SendMessage(-1,0x0112,0xF170,2)"". Poate executa programe la selecția utilizatorului; nu executa automat. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the shell action command line: cmd /c "powershell.exe -Command "(Add-Type '[DllImport(\"user32.dll\")]public static extern int SendMessage(int hWnd,int hMsg,int wParam,int lParam);' -Name a -Pas)::SendMessage(-1,0x0112,0xF170,2)"". It may launch programs when the user selects the action; never run automatically. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L89 · SET-VALUE · `MUIVerb`

- **Registry key:** `HKEY_CLASSES_ROOT\DesktopBackground\Shell\RestartB\shell\007-TurnOffDisplay\shell\02menu`
- **Raw .reg data:** `"Lock computer and Turn off display"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează eticheta vizibilă sau referința localizată a comenzii din meniul contextual la „Lock computer and Turn off display”. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the visible/localized shell command label to “Lock computer and Turn off display”. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L90 · SET-VALUE · `CommandFlags`

- **Registry key:** `HKEY_CLASSES_ROOT\DesktopBackground\Shell\RestartB\shell\007-TurnOffDisplay\shell\02menu`
- **Raw .reg data:** `dword:00000020`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Command Flags” în asocierile de fișiere sau integrarea shell/COM la 32 (0x00000020) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Command Flags” option in file associations or shell/COM integration to 32 (0x00000020) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L91 · SET-VALUE · `Icon`

- **Registry key:** `HKEY_CLASSES_ROOT\DesktopBackground\Shell\RestartB\shell\007-TurnOffDisplay\shell\02menu`
- **Raw .reg data:** `"imageres.dll,-59"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Stochează resursa grafică pentru intrarea de meniu/înregistrarea shell: imageres.dll,-59. Nu execută niciun program. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Stores the icon resource for a shell/menu item: imageres.dll,-59. It does not execute a program. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L94 · SET-VALUE · `(Default)`

- **Registry key:** `HKEY_CLASSES_ROOT\DesktopBackground\Shell\RestartB\shell\007-TurnOffDisplay\shell\02menu\command`
- **Raw .reg data:** `"cmd /c \"powershell.exe -Command \"(Add-Type '[DllImport(\\\"user32.dll\\\")]public static extern int SendMessage(int hWnd,int hMsg,int wParam,int lParam);' -Name a -Pas)::SendMessage(-1,0x0112,0xF170,2)\" & rundll32.exe user32.dll, LockWorkStation\""`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează comanda de lansare a acestei acțiuni shell: cmd /c "powershell.exe -Command "(Add-Type '[DllImport(\"user32.dll\")]public static extern int SendMessage(int hWnd,int hMsg,int wParam,int lParam);' -Name a -Pas)::SendMessage(-1,0x0112,0xF170,2)" & rundll32.exe user32.dll, LockWorkStation". Poate executa programe la selecția utilizatorului; nu executa automat. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the shell action command line: cmd /c "powershell.exe -Command "(Add-Type '[DllImport(\"user32.dll\")]public static extern int SendMessage(int hWnd,int hMsg,int wParam,int lParam);' -Name a -Pas)::SendMessage(-1,0x0112,0xF170,2)" & rundll32.exe user32.dll, LockWorkStation". It may launch programs when the user selects the action; never run automatically. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

## Referințe / References

- https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers
