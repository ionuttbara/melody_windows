# Blotware Remover/Custom Control Panel Applet/msconfig applet.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `1e6e2dfd568ce26408647d178cf99cd2b4458214c464e6c2b82d3f235bdb5abc`
- **Recipe verdict / verdict rețetă:** `CONDITIONAL`
- **Windows container / interval Windows:** `7600+`
- **Runtime prerequisite / condiție runtime:** `existing-key`
- **Value/operation descriptions / operații:** 4
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L4 · SET-VALUE · `(Default)`

- **Registry key:** `HKEY_CLASSES_ROOT\CLSID\{ADEAD0A2-0A48-49cf-8416-FF0000000001}`
- **Raw .reg data:** `"System Configuration (msconfig)"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează descrierea sau legarea implicită a înregistrării shell/COM la „System Configuration (msconfig)”. Sensul exact depinde de subcheia părinte. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the default label/binding for this shell/COM registration to “System Configuration (msconfig)”. Exact meaning depends on the parent subkey. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L5 · SET-VALUE · `InfoTip`

- **Registry key:** `HKEY_CLASSES_ROOT\CLSID\{ADEAD0A2-0A48-49cf-8416-FF0000000001}`
- **Raw .reg data:** `"Configure advanced system."`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Info Tip” în asocierile de fișiere sau integrarea shell/COM la Configure advanced system. (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Info Tip” option in file associations or shell/COM integration to Configure advanced system. (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L8 · SET-VALUE · `(Default)`

- **Registry key:** `HKEY_CLASSES_ROOT\CLSID\{ADEAD0A2-0A48-49cf-8416-FF0000000001}\DefaultIcon`
- **Raw .reg data:** `"C:\\Windows\\System32\\msconfig.exe,0"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează descrierea sau legarea implicită a înregistrării shell/COM la „C:\Windows\System32\msconfig.exe,0”. Sensul exact depinde de subcheia părinte. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the default label/binding for this shell/COM registration to “C:\Windows\System32\msconfig.exe,0”. Exact meaning depends on the parent subkey. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L11 · SET-VALUE · `(Default)`

- **Registry key:** `HKEY_CLASSES_ROOT\CLSID\{ADEAD0A2-0A48-49cf-8416-FF0000000001}\Shell\Open\Command`
- **Raw .reg data:** `"msconfig.exe"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Setează comanda de lansare a acestei acțiuni shell: msconfig.exe. Poate executa programe la selecția utilizatorului; nu executa automat. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the shell action command line: msconfig.exe. It may launch programs when the user selects the action; never run automatically. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

## Referințe / References

- No exact vendor URL is attached. The final runtime rule requires the exact live Registry target to exist before Melody enables the recipe.
