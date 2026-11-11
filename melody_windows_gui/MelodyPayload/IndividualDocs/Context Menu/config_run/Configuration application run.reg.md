# Context Menu/config_run/Configuration application run.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `fdbce3b28ed491017ca5bfef6a8be8f3f850630cbd4ed414049d7e36e791a89d`
- **Recipe verdict / verdict rețetă:** `CONDITIONAL`
- **Windows container / interval Windows:** `7600+`
- **Runtime prerequisite / condiție runtime:** `shell`
- **Value/operation descriptions / operații:** 31
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L4 · SET-VALUE · `MUIVerb`

- **Registry key:** `HKEY_CLASSES_ROOT\exefile\shell\AppRunConfig`
- **Raw .reg data:** `"Config Application Run"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează eticheta vizibilă sau referința localizată a comenzii din meniul contextual la „Config Application Run”. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the visible/localized shell command label to “Config Application Run”. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L5 · SET-VALUE · `SubCommands`

- **Registry key:** `HKEY_CLASSES_ROOT\exefile\shell\AppRunConfig`
- **Raw .reg data:** `""`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Stabilește lista și ordinea subcomenzilor într-un meniu contextual în cascadă; fiecare comandă trebuie să fie înregistrată separat. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Defines the list and order of verbs in a cascading context menu; each verb must also be registered. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L6 · SET-VALUE · `Icon`

- **Registry key:** `HKEY_CLASSES_ROOT\exefile\shell\AppRunConfig`
- **Raw .reg data:** `"taskmgr.exe,1"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Stochează resursa grafică pentru intrarea de meniu/înregistrarea shell: taskmgr.exe,1. Nu execută niciun program. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Stores the icon resource for a shell/menu item: taskmgr.exe,1. It does not execute a program. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L9 · SET-VALUE · `MUIVerb`

- **Registry key:** `HKEY_CLASSES_ROOT\exefile\Shell\AppRunConfig\shell\RunPrio`
- **Raw .reg data:** `"Run with Priority"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează eticheta vizibilă sau referința localizată a comenzii din meniul contextual la „Run with Priority”. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the visible/localized shell command label to “Run with Priority”. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L10 · SET-VALUE · `SubCommands`

- **Registry key:** `HKEY_CLASSES_ROOT\exefile\Shell\AppRunConfig\shell\RunPrio`
- **Raw .reg data:** `""`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Stabilește lista și ordinea subcomenzilor într-un meniu contextual în cascadă; fiecare comandă trebuie să fie înregistrată separat. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Defines the list and order of verbs in a cascading context menu; each verb must also be registered. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L11 · SET-VALUE · `Icon`

- **Registry key:** `HKEY_CLASSES_ROOT\exefile\Shell\AppRunConfig\shell\RunPrio`
- **Raw .reg data:** `"taskmgr.exe"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Stochează resursa grafică pentru intrarea de meniu/înregistrarea shell: taskmgr.exe. Nu execută niciun program. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Stores the icon resource for a shell/menu item: taskmgr.exe. It does not execute a program. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L18 · SET-VALUE · `(Default)`

- **Registry key:** `HKEY_CLASSES_ROOT\exefile\shell\AppRunConfig\shell\WindowsFirewall`
- **Raw .reg data:** `""`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează descrierea sau legarea implicită a înregistrării shell/COM la „”. Sensul exact depinde de subcheia părinte. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the default label/binding for this shell/COM registration to “”. Exact meaning depends on the parent subkey. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L19 · SET-VALUE · `MUIVerb`

- **Registry key:** `HKEY_CLASSES_ROOT\exefile\shell\AppRunConfig\shell\WindowsFirewall`
- **Raw .reg data:** `"Configure Internet Access..."`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează eticheta vizibilă sau referința localizată a comenzii din meniul contextual la „Configure Internet Access...”. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the visible/localized shell command label to “Configure Internet Access...”. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L20 · SET-VALUE · `icon`

- **Registry key:** `HKEY_CLASSES_ROOT\exefile\shell\AppRunConfig\shell\WindowsFirewall`
- **Raw .reg data:** `"%SystemRoot%\\system32\\FirewallControlPanel.dll,0"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Stochează resursa grafică pentru intrarea de meniu/înregistrarea shell: %SystemRoot%\system32\FirewallControlPanel.dll,0. Nu execută niciun program. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Stores the icon resource for a shell/menu item: %SystemRoot%\system32\FirewallControlPanel.dll,0. It does not execute a program. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L21 · SET-VALUE · `subcommands`

- **Registry key:** `HKEY_CLASSES_ROOT\exefile\shell\AppRunConfig\shell\WindowsFirewall`
- **Raw .reg data:** `""`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Stabilește lista și ordinea subcomenzilor într-un meniu contextual în cascadă; fiecare comandă trebuie să fie înregistrată separat. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Defines the list and order of verbs in a cascading context menu; each verb must also be registered. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L24 · SET-VALUE · `(Default)`

- **Registry key:** `HKEY_CLASSES_ROOT\exefile\shell\AppRunConfig\shell\WindowsFirewall\Shell`
- **Raw .reg data:** `""`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează descrierea sau legarea implicită a înregistrării shell/COM la „”. Sensul exact depinde de subcheia părinte. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the default label/binding for this shell/COM registration to “”. Exact meaning depends on the parent subkey. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L28 · SET-VALUE · `(Default)`

- **Registry key:** `HKEY_CLASSES_ROOT\exefile\shell\AppRunConfig\shell\WindowsFirewall\Shell\block`
- **Raw .reg data:** `""`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează descrierea sau legarea implicită a înregistrării shell/COM la „”. Sensul exact depinde de subcheia părinte. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the default label/binding for this shell/COM registration to “”. Exact meaning depends on the parent subkey. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L29 · SET-VALUE · `MUIVerb`

- **Registry key:** `HKEY_CLASSES_ROOT\exefile\shell\AppRunConfig\shell\WindowsFirewall\Shell\block`
- **Raw .reg data:** `"Block internet access"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează eticheta vizibilă sau referința localizată a comenzii din meniul contextual la „Block internet access”. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the visible/localized shell command label to “Block internet access”. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L30 · SET-VALUE · `icon`

- **Registry key:** `HKEY_CLASSES_ROOT\exefile\shell\AppRunConfig\shell\WindowsFirewall\Shell\block`
- **Raw .reg data:** `"%SystemRoot%\\system32\\imageres.dll,100"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Stochează resursa grafică pentru intrarea de meniu/înregistrarea shell: %SystemRoot%\system32\imageres.dll,100. Nu execută niciun program. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Stores the icon resource for a shell/menu item: %SystemRoot%\system32\imageres.dll,100. It does not execute a program. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L33 · SET-VALUE · `(Default)`

- **Registry key:** `HKEY_CLASSES_ROOT\exefile\shell\AppRunConfig\shell\WindowsFirewall\Shell\block\command`
- **Raw .reg data:** `"\"C:\\Windows\\System32\\WindowsPowerShell\\v1.0\\powershell.exe\" -Executionpolicy ByPass -WindowStyle Hidden -NoLogo -Command \"start powershell -Verb runas -ArgumentList \\\"-NoLogo -WindowStyle Hidden -command `\\\"New-NetFirewallRule -DisplayName ([System.IO.Path]::GetFilenameWithoutExtension('%1')) -Name '%1' -Enabled True -Direction Outbound -Action Block -Program '%1'`\\\"\\\"\""`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează comanda de lansare a acestei acțiuni shell: "C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe" -Executionpolicy ByPass -WindowStyle Hidden -NoLogo -Command "start powershell -Verb runas -ArgumentList \"-NoLogo -WindowStyle Hidden -command `\"New-NetFirewallRule -DisplayName ([System.IO.Path]::GetFilenameWithoutExtension('%1')) -Name '%1' -Enabled True -Direction Outbound -Action Block -Program '%1'`\"\"". Poate executa programe la selecția utilizatorului; nu executa automat. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the shell action command line: "C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe" -Executionpolicy ByPass -WindowStyle Hidden -NoLogo -Command "start powershell -Verb runas -ArgumentList \"-NoLogo -WindowStyle Hidden -command `\"New-NetFirewallRule -DisplayName ([System.IO.Path]::GetFilenameWithoutExtension('%1')) -Name '%1' -Enabled True -Direction Outbound -Action Block -Program '%1'`\"\"". It may launch programs when the user selects the action; never run automatically. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L36 · SET-VALUE · `(Default)`

- **Registry key:** `HKEY_CLASSES_ROOT\exefile\shell\AppRunConfig\shell\WindowsFirewall\Shell\Remove`
- **Raw .reg data:** `""`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează descrierea sau legarea implicită a înregistrării shell/COM la „”. Sensul exact depinde de subcheia părinte. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the default label/binding for this shell/COM registration to “”. Exact meaning depends on the parent subkey. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L37 · SET-VALUE · `MUIVerb`

- **Registry key:** `HKEY_CLASSES_ROOT\exefile\shell\AppRunConfig\shell\WindowsFirewall\Shell\Remove`
- **Raw .reg data:** `"Restore the internet access"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează eticheta vizibilă sau referința localizată a comenzii din meniul contextual la „Restore the internet access”. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the visible/localized shell command label to “Restore the internet access”. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L38 · SET-VALUE · `icon`

- **Registry key:** `HKEY_CLASSES_ROOT\exefile\shell\AppRunConfig\shell\WindowsFirewall\Shell\Remove`
- **Raw .reg data:** `"%SystemRoot%\\system32\\imageres.dll,101"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Stochează resursa grafică pentru intrarea de meniu/înregistrarea shell: %SystemRoot%\system32\imageres.dll,101. Nu execută niciun program. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Stores the icon resource for a shell/menu item: %SystemRoot%\system32\imageres.dll,101. It does not execute a program. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L41 · SET-VALUE · `(Default)`

- **Registry key:** `HKEY_CLASSES_ROOT\exefile\shell\AppRunConfig\shell\WindowsFirewall\Shell\Remove\command`
- **Raw .reg data:** `"\"C:\\Windows\\System32\\WindowsPowerShell\\v1.0\\powershell.exe\" -Executionpolicy ByPass -WindowStyle Hidden -NoLogo -Command \"start powershell -Verb runas -ArgumentList \\\"-NoLogo -WindowStyle Hidden -command `\\\"Remove-NetFirewallRule -Name '%1'`\\\"\\\"\""`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează comanda de lansare a acestei acțiuni shell: "C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe" -Executionpolicy ByPass -WindowStyle Hidden -NoLogo -Command "start powershell -Verb runas -ArgumentList \"-NoLogo -WindowStyle Hidden -command `\"Remove-NetFirewallRule -Name '%1'`\"\"". Poate executa programe la selecția utilizatorului; nu executa automat. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the shell action command line: "C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe" -Executionpolicy ByPass -WindowStyle Hidden -NoLogo -Command "start powershell -Verb runas -ArgumentList \"-NoLogo -WindowStyle Hidden -command `\"Remove-NetFirewallRule -Name '%1'`\"\"". It may launch programs when the user selects the action; never run automatically. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L47 · SET-VALUE · `(Default)`

- **Registry key:** `HKEY_CLASSES_ROOT\exefile\Shell\AppRunConfig\shell\RunPrio\shell\001flyout`
- **Raw .reg data:** `"Realtime"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează descrierea sau legarea implicită a înregistrării shell/COM la „Realtime”. Sensul exact depinde de subcheia părinte. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the default label/binding for this shell/COM registration to “Realtime”. Exact meaning depends on the parent subkey. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L50 · SET-VALUE · `(Default)`

- **Registry key:** `HKEY_CLASSES_ROOT\exefile\Shell\AppRunConfig\shell\RunPrio\shell\001flyout\command`
- **Raw .reg data:** `"cmd.exe /c start \"\" /Realtime \"%1\""`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează comanda de lansare a acestei acțiuni shell: cmd.exe /c start "" /Realtime "%1". Poate executa programe la selecția utilizatorului; nu executa automat. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the shell action command line: cmd.exe /c start "" /Realtime "%1". It may launch programs when the user selects the action; never run automatically. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L54 · SET-VALUE · `(Default)`

- **Registry key:** `HKEY_CLASSES_ROOT\exefile\Shell\AppRunConfig\shell\RunPrio\shell\002flyout`
- **Raw .reg data:** `"High"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează descrierea sau legarea implicită a înregistrării shell/COM la „High”. Sensul exact depinde de subcheia părinte. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the default label/binding for this shell/COM registration to “High”. Exact meaning depends on the parent subkey. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L57 · SET-VALUE · `(Default)`

- **Registry key:** `HKEY_CLASSES_ROOT\exefile\Shell\AppRunConfig\shell\RunPrio\shell\002flyout\command`
- **Raw .reg data:** `"cmd.exe /c start \"\" /High \"%1\""`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează comanda de lansare a acestei acțiuni shell: cmd.exe /c start "" /High "%1". Poate executa programe la selecția utilizatorului; nu executa automat. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the shell action command line: cmd.exe /c start "" /High "%1". It may launch programs when the user selects the action; never run automatically. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L61 · SET-VALUE · `(Default)`

- **Registry key:** `HKEY_CLASSES_ROOT\exefile\Shell\AppRunConfig\shell\RunPrio\shell\003flyout`
- **Raw .reg data:** `"Above normal"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează descrierea sau legarea implicită a înregistrării shell/COM la „Above normal”. Sensul exact depinde de subcheia părinte. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the default label/binding for this shell/COM registration to “Above normal”. Exact meaning depends on the parent subkey. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L64 · SET-VALUE · `(Default)`

- **Registry key:** `HKEY_CLASSES_ROOT\exefile\Shell\AppRunConfig\shell\RunPrio\shell\003flyout\command`
- **Raw .reg data:** `"cmd.exe /c start \"\" /AboveNormal \"%1\""`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează comanda de lansare a acestei acțiuni shell: cmd.exe /c start "" /AboveNormal "%1". Poate executa programe la selecția utilizatorului; nu executa automat. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the shell action command line: cmd.exe /c start "" /AboveNormal "%1". It may launch programs when the user selects the action; never run automatically. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L68 · SET-VALUE · `(Default)`

- **Registry key:** `HKEY_CLASSES_ROOT\exefile\Shell\AppRunConfig\shell\RunPrio\shell\004flyout`
- **Raw .reg data:** `"Normal"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează descrierea sau legarea implicită a înregistrării shell/COM la „Normal”. Sensul exact depinde de subcheia părinte. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the default label/binding for this shell/COM registration to “Normal”. Exact meaning depends on the parent subkey. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L71 · SET-VALUE · `(Default)`

- **Registry key:** `HKEY_CLASSES_ROOT\exefile\Shell\AppRunConfig\shell\RunPrio\shell\004flyout\command`
- **Raw .reg data:** `"cmd.exe /c start \"\" /Normal \"%1\""`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează comanda de lansare a acestei acțiuni shell: cmd.exe /c start "" /Normal "%1". Poate executa programe la selecția utilizatorului; nu executa automat. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the shell action command line: cmd.exe /c start "" /Normal "%1". It may launch programs when the user selects the action; never run automatically. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L75 · SET-VALUE · `(Default)`

- **Registry key:** `HKEY_CLASSES_ROOT\exefile\Shell\AppRunConfig\shell\RunPrio\shell\005flyout`
- **Raw .reg data:** `"Below normal"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează descrierea sau legarea implicită a înregistrării shell/COM la „Below normal”. Sensul exact depinde de subcheia părinte. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the default label/binding for this shell/COM registration to “Below normal”. Exact meaning depends on the parent subkey. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L78 · SET-VALUE · `(Default)`

- **Registry key:** `HKEY_CLASSES_ROOT\exefile\Shell\AppRunConfig\shell\RunPrio\shell\005flyout\command`
- **Raw .reg data:** `"cmd.exe /c start \"\" /BelowNormal \"%1\""`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează comanda de lansare a acestei acțiuni shell: cmd.exe /c start "" /BelowNormal "%1". Poate executa programe la selecția utilizatorului; nu executa automat. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the shell action command line: cmd.exe /c start "" /BelowNormal "%1". It may launch programs when the user selects the action; never run automatically. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L82 · SET-VALUE · `(Default)`

- **Registry key:** `HKEY_CLASSES_ROOT\exefile\Shell\AppRunConfig\shell\RunPrio\shell\006flyout`
- **Raw .reg data:** `"Low"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează descrierea sau legarea implicită a înregistrării shell/COM la „Low”. Sensul exact depinde de subcheia părinte. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the default label/binding for this shell/COM registration to “Low”. Exact meaning depends on the parent subkey. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L85 · SET-VALUE · `(Default)`

- **Registry key:** `HKEY_CLASSES_ROOT\exefile\Shell\AppRunConfig\shell\RunPrio\shell\006flyout\command`
- **Raw .reg data:** `"cmd.exe /c start \"\" /Low \"%1\""`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează comanda de lansare a acestei acțiuni shell: cmd.exe /c start "" /Low "%1". Poate executa programe la selecția utilizatorului; nu executa automat. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the shell action command line: cmd.exe /c start "" /Low "%1". It may launch programs when the user selects the action; never run automatically. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

## Referințe / References

- https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers
