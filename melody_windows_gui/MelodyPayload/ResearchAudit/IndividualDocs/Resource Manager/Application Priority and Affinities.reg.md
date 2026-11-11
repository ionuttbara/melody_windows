# Resource Manager/Application Priority and Affinities.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `31cc312c0af5888601ba38671df701b89e218f6825cb64b18d443b016341f6be`
- **Recipe verdict / verdict rețetă:** `CONDITIONAL`
- **Windows container / interval Windows:** `7600+`
- **Runtime prerequisite / condiție runtime:** `none / niciuna`
- **Value/operation descriptions / operații:** 20
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L21 · SET-VALUE · `CpuPriorityClass`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\csrss.exe\PerfOptions`
- **Raw .reg data:** `dword:00000004`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Înregistrează o clasă de prioritate CPU la lansarea „csrss.exe”, valoare numerică 4 (0x00000004). Maparea numerică exactă și suportul pe OS nu sunt confirmate. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Configures CPU priority class at launch of “csrss.exe”, numeric value 4 (0x00000004). Exact numeric mapping and OS support have not been confirmed. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L22 · SET-VALUE · `IoPriority`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\csrss.exe\PerfOptions`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Io Priority” în opțiunile de lansare pentru executabile la 3 (0x00000003) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Io Priority” option in image-file execution options to 3 (0x00000003) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L26 · SET-VALUE · `CpuPriorityClass`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\chrome.exe\PerfOptions`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Înregistrează o clasă de prioritate CPU la lansarea „chrome.exe”, valoare numerică 3 (0x00000003). Maparea numerică exactă și suportul pe OS nu sunt confirmate. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Configures CPU priority class at launch of “chrome.exe”, numeric value 3 (0x00000003). Exact numeric mapping and OS support have not been confirmed. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L29 · SET-VALUE · `CpuPriorityClass`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\winword.exe\PerfOptions`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Înregistrează o clasă de prioritate CPU la lansarea „winword.exe”, valoare numerică 3 (0x00000003). Maparea numerică exactă și suportul pe OS nu sunt confirmate. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Configures CPU priority class at launch of “winword.exe”, numeric value 3 (0x00000003). Exact numeric mapping and OS support have not been confirmed. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L32 · SET-VALUE · `CpuPriorityClass`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\powerpnt.exe\PerfOptions`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Înregistrează o clasă de prioritate CPU la lansarea „powerpnt.exe”, valoare numerică 3 (0x00000003). Maparea numerică exactă și suportul pe OS nu sunt confirmate. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Configures CPU priority class at launch of “powerpnt.exe”, numeric value 3 (0x00000003). Exact numeric mapping and OS support have not been confirmed. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L35 · SET-VALUE · `CpuPriorityClass`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\onenote.exe\PerfOptions`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Înregistrează o clasă de prioritate CPU la lansarea „onenote.exe”, valoare numerică 3 (0x00000003). Maparea numerică exactă și suportul pe OS nu sunt confirmate. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Configures CPU priority class at launch of “onenote.exe”, numeric value 3 (0x00000003). Exact numeric mapping and OS support have not been confirmed. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L38 · SET-VALUE · `CpuPriorityClass`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\Steam.exe\PerfOptions`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Înregistrează o clasă de prioritate CPU la lansarea „Steam.exe”, valoare numerică 3 (0x00000003). Maparea numerică exactă și suportul pe OS nu sunt confirmate. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Configures CPU priority class at launch of “Steam.exe”, numeric value 3 (0x00000003). Exact numeric mapping and OS support have not been confirmed. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L41 · SET-VALUE · `CpuPriorityClass`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\gomag_TMD.exe\PerfOptions`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Înregistrează o clasă de prioritate CPU la lansarea „gomag_TMD.exe”, valoare numerică 3 (0x00000003). Maparea numerică exactă și suportul pe OS nu sunt confirmate. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Configures CPU priority class at launch of “gomag_TMD.exe”, numeric value 3 (0x00000003). Exact numeric mapping and OS support have not been confirmed. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L44 · SET-VALUE · `CpuPriorityClass`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\brave.exe\PerfOptions`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Înregistrează o clasă de prioritate CPU la lansarea „brave.exe”, valoare numerică 3 (0x00000003). Maparea numerică exactă și suportul pe OS nu sunt confirmate. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Configures CPU priority class at launch of “brave.exe”, numeric value 3 (0x00000003). Exact numeric mapping and OS support have not been confirmed. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L47 · SET-VALUE · `CpuPriorityClass`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\wspace32.exe\PerfOptions`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Înregistrează o clasă de prioritate CPU la lansarea „wspace32.exe”, valoare numerică 3 (0x00000003). Maparea numerică exactă și suportul pe OS nu sunt confirmate. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Configures CPU priority class at launch of “wspace32.exe”, numeric value 3 (0x00000003). Exact numeric mapping and OS support have not been confirmed. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L50 · SET-VALUE · `CpuPriorityClass`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\wspace64.exe\PerfOptions`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Înregistrează o clasă de prioritate CPU la lansarea „wspace64.exe”, valoare numerică 3 (0x00000003). Maparea numerică exactă și suportul pe OS nu sunt confirmate. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Configures CPU priority class at launch of “wspace64.exe”, numeric value 3 (0x00000003). Exact numeric mapping and OS support have not been confirmed. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L53 · SET-VALUE · `CpuPriorityClass`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\Capture.exe\PerfOptions`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Înregistrează o clasă de prioritate CPU la lansarea „Capture.exe”, valoare numerică 3 (0x00000003). Maparea numerică exactă și suportul pe OS nu sunt confirmate. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Configures CPU priority class at launch of “Capture.exe”, numeric value 3 (0x00000003). Exact numeric mapping and OS support have not been confirmed. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L56 · SET-VALUE · `CpuPriorityClass`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\sublime_text.exe\PerfOptions`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Înregistrează o clasă de prioritate CPU la lansarea „sublime_text.exe”, valoare numerică 3 (0x00000003). Maparea numerică exactă și suportul pe OS nu sunt confirmate. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Configures CPU priority class at launch of “sublime_text.exe”, numeric value 3 (0x00000003). Exact numeric mapping and OS support have not been confirmed. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L59 · SET-VALUE · `CpuPriorityClass`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\audiodg.exe\PerfOptions`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Înregistrează o clasă de prioritate CPU la lansarea „audiodg.exe”, valoare numerică 3 (0x00000003). Maparea numerică exactă și suportul pe OS nu sunt confirmate. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Configures CPU priority class at launch of “audiodg.exe”, numeric value 3 (0x00000003). Exact numeric mapping and OS support have not been confirmed. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L62 · SET-VALUE · `CpuPriorityClass`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\ImageViewer.exe\PerfOptions`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Înregistrează o clasă de prioritate CPU la lansarea „ImageViewer.exe”, valoare numerică 3 (0x00000003). Maparea numerică exactă și suportul pe OS nu sunt confirmate. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Configures CPU priority class at launch of “ImageViewer.exe”, numeric value 3 (0x00000003). Exact numeric mapping and OS support have not been confirmed. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L65 · SET-VALUE · `CpuPriorityClass`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\MediaPlayer.exe\PerfOptions`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Înregistrează o clasă de prioritate CPU la lansarea „MediaPlayer.exe”, valoare numerică 3 (0x00000003). Maparea numerică exactă și suportul pe OS nu sunt confirmate. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Configures CPU priority class at launch of “MediaPlayer.exe”, numeric value 3 (0x00000003). Exact numeric mapping and OS support have not been confirmed. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L68 · SET-VALUE · `CpuPriorityClass`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\explorer.exe\PerfOptions`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Înregistrează o clasă de prioritate CPU la lansarea „explorer.exe”, valoare numerică 3 (0x00000003). Maparea numerică exactă și suportul pe OS nu sunt confirmate. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Configures CPU priority class at launch of “explorer.exe”, numeric value 3 (0x00000003). Exact numeric mapping and OS support have not been confirmed. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L71 · SET-VALUE · `Debugger`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\CompatTelRunner.exe`
- **Raw .reg data:** `"C:\\WINDOWS\\system32\\systray.exe"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Debugger” în opțiunile de lansare pentru executabile la C:\WINDOWS\system32\systray.exe (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Debugger” option in image-file execution options to C:\WINDOWS\system32\systray.exe (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L74 · SET-VALUE · `Debugger`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\EOSNotify.exe`
- **Raw .reg data:** `"C:\\WINDOWS\\system32\\systray.exe"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Debugger” în opțiunile de lansare pentru executabile la C:\WINDOWS\system32\systray.exe (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Debugger” option in image-file execution options to C:\WINDOWS\system32\systray.exe (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L77 · SET-VALUE · `Debugger`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\wermgr.exe`
- **Raw .reg data:** `"C:\\WINDOWS\\system32\\systray.exe"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Debugger” în opțiunile de lansare pentru executabile la C:\WINDOWS\system32\systray.exe (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Debugger” option in image-file execution options to C:\WINDOWS\system32\systray.exe (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

## Referințe / References

- No exact vendor URL is attached. The final runtime rule requires the exact live Registry target to exist before Melody enables the recipe.
