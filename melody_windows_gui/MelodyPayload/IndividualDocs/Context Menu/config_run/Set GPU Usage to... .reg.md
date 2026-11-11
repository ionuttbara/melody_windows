# Context Menu/config_run/Set GPU Usage to... .reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `ebcbee26d0993a8783179126d7bd18f0d4dde390bd97aac97e87acbdbcf98bfe`
- **Recipe verdict / verdict rețetă:** `CONDITIONAL`
- **Windows container / interval Windows:** `7600+`
- **Runtime prerequisite / condiție runtime:** `shell`
- **Value/operation descriptions / operații:** 12
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

- **Registry key:** `HKEY_CLASSES_ROOT\exefile\Shell\AppRunConfig\shell\GPU`
- **Raw .reg data:** `"Set GPU usage..."`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează eticheta vizibilă sau referința localizată a comenzii din meniul contextual la „Set GPU usage...”. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the visible/localized shell command label to “Set GPU usage...”. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L10 · SET-VALUE · `SubCommands`

- **Registry key:** `HKEY_CLASSES_ROOT\exefile\Shell\AppRunConfig\shell\GPU`
- **Raw .reg data:** `""`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Stabilește lista și ordinea subcomenzilor într-un meniu contextual în cascadă; fiecare comandă trebuie să fie înregistrată separat. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Defines the list and order of verbs in a cascading context menu; each verb must also be registered. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L11 · SET-VALUE · `Icon`

- **Registry key:** `HKEY_CLASSES_ROOT\exefile\Shell\AppRunConfig\shell\GPU`
- **Raw .reg data:** `"dxdiag.exe"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Stochează resursa grafică pentru intrarea de meniu/înregistrarea shell: dxdiag.exe. Nu execută niciun program. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Stores the icon resource for a shell/menu item: dxdiag.exe. It does not execute a program. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L14 · SET-VALUE · `(Default)`

- **Registry key:** `HKEY_CLASSES_ROOT\exefile\Shell\AppRunConfig\shell\GPU\shell\001flyout`
- **Raw .reg data:** `"Set to Dedicated GPU"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează descrierea sau legarea implicită a înregistrării shell/COM la „Set to Dedicated GPU”. Sensul exact depinde de subcheia părinte. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the default label/binding for this shell/COM registration to “Set to Dedicated GPU”. Exact meaning depends on the parent subkey. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L17 · SET-VALUE · `(Default)`

- **Registry key:** `HKEY_CLASSES_ROOT\exefile\Shell\AppRunConfig\shell\GPU\shell\002flyout`
- **Raw .reg data:** `"Set to Integrated GPU"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează descrierea sau legarea implicită a înregistrării shell/COM la „Set to Integrated GPU”. Sensul exact depinde de subcheia părinte. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the default label/binding for this shell/COM registration to “Set to Integrated GPU”. Exact meaning depends on the parent subkey. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L20 · SET-VALUE · `(Default)`

- **Registry key:** `HKEY_CLASSES_ROOT\exefile\Shell\AppRunConfig\shell\GPU\shell\003flyout`
- **Raw .reg data:** `"Reset GPU usage..."`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează descrierea sau legarea implicită a înregistrării shell/COM la „Reset GPU usage...”. Sensul exact depinde de subcheia părinte. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the default label/binding for this shell/COM registration to “Reset GPU usage...”. Exact meaning depends on the parent subkey. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L23 · SET-VALUE · `(Default)`

- **Registry key:** `HKEY_CLASSES_ROOT\exefile\Shell\AppRunConfig\shell\GPU\shell\001flyout\command`
- **Raw .reg data:** `"C:\\Windows\\System32\\REG.exe ADD HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\DirectX\\UserGpuPreferences /f /v \"%1\" /d GpuPreference=2;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează comanda de lansare a acestei acțiuni shell: C:\Windows\System32\REG.exe ADD HKEY_CURRENT_USER\SOFTWARE\Microsoft\DirectX\UserGpuPreferences /f /v "%1" /d GpuPreference=2;. Poate executa programe la selecția utilizatorului; nu executa automat. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the shell action command line: C:\Windows\System32\REG.exe ADD HKEY_CURRENT_USER\SOFTWARE\Microsoft\DirectX\UserGpuPreferences /f /v "%1" /d GpuPreference=2;. It may launch programs when the user selects the action; never run automatically. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L26 · SET-VALUE · `(Default)`

- **Registry key:** `HKEY_CLASSES_ROOT\exefile\Shell\AppRunConfig\shell\GPU\shell\002flyout\command`
- **Raw .reg data:** `"C:\\Windows\\System32\\REG.exe ADD HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\DirectX\\UserGpuPreferences /f /v \"%1\" /d GpuPreference=1;"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează comanda de lansare a acestei acțiuni shell: C:\Windows\System32\REG.exe ADD HKEY_CURRENT_USER\SOFTWARE\Microsoft\DirectX\UserGpuPreferences /f /v "%1" /d GpuPreference=1;. Poate executa programe la selecția utilizatorului; nu executa automat. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the shell action command line: C:\Windows\System32\REG.exe ADD HKEY_CURRENT_USER\SOFTWARE\Microsoft\DirectX\UserGpuPreferences /f /v "%1" /d GpuPreference=1;. It may launch programs when the user selects the action; never run automatically. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

### L29 · SET-VALUE · `(Default)`

- **Registry key:** `HKEY_CLASSES_ROOT\exefile\Shell\AppRunConfig\shell\GPU\shell\003flyout\command`
- **Raw .reg data:** `"C:\\Windows\\System32\\REG.exe DELETE HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\DirectX\\UserGpuPreferences /v \"%1\" /f"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează comanda de lansare a acestei acțiuni shell: C:\Windows\System32\REG.exe DELETE HKEY_CURRENT_USER\SOFTWARE\Microsoft\DirectX\UserGpuPreferences /v "%1" /f. Poate executa programe la selecția utilizatorului; nu executa automat. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the shell action command line: C:\Windows\System32\REG.exe DELETE HKEY_CURRENT_USER\SOFTWARE\Microsoft\DirectX\UserGpuPreferences /v "%1" /f. It may launch programs when the user selects the action; never run automatically. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Shell verb/cascading-menu registration; command prerequisites are checked and the recipe remains opt-in.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers`

## Referințe / References

- https://learn.microsoft.com/en-us/windows/win32/shell/context-menu-handlers
