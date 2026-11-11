# System/Windows Settings Page Visibility.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `a6fce67c404111761aba583ee6047b607ab2de6d68b0596002772a19b49f2e4a`
- **Recipe verdict / verdict rețetă:** `CONDITIONAL`
- **Windows container / interval Windows:** `7600+`
- **Runtime prerequisite / condiție runtime:** `existing-key`
- **Value/operation descriptions / operații:** 1
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L4 · SET-VALUE · `SettingsPageVisibility`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Explorer`
- **Raw .reg data:** `"hide:quiethours;tabletmode;remotedesktop;datausage;maps;workplace;sync;speech;gaming-gamebar;gaming-gamedvr;privacy;privacy-speech;privacy-speechtyping;privacy-feedback;privacy-activityhistory;privacy-location;privacy-voiceactivation;privacy-accountinfo;privacy-calendar;privacy-callhistory;privacy-phone;privacy-email;privacy-eyetracker;privacy-tasks;privacy-messaging;privacy-radios;privacy-customdevices;privacy-appdiagnostics;privacy-automaticfiledownloads;privacy-phonecalls;windowsdefender;backup;troubleshoot;findmydevice;delivery-optimization;delivery-optimization-activity;delivery-optimization-advanced;maps-downloadmaps;appsforwebsites;videoplayback;sync;deviceusage;home;backup"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Settings Page Visibility” în ramura Microsoft / Windows / CurrentVersion la hide:quiethours;tabletmode;remotedesktop;datausage;maps;workplace;sync;speech;gaming-gamebar;gaming-gamedvr;privacy;privacy-speech;privacy-speechtyping;privacy-feedback;privacy-activityhistory;privacy-location;privacy-voiceactivation;privacy-accountinfo;privacy-calendar;privacy-callhistory;privacy-phone;privacy-email;privacy-eyetracker;privacy-tasks;privacy-messaging;privacy-radios;privacy-customdevices;privacy-appdiagnostics;privacy-automaticfiledownloads;privacy-phonecalls;windowsdefender;backup;troubleshoot;findmydevice;delivery-optimization;delivery-optimization-activity;delivery-optimization-advanced;maps-downloadmaps;appsforwebsites;videoplayback;sync;deviceusage;home;backup (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Settings Page Visibility” option in registry branch Microsoft / Windows / CurrentVersion to hide:quiethours;tabletmode;remotedesktop;datausage;maps;workplace;sync;speech;gaming-gamebar;gaming-gamedvr;privacy;privacy-speech;privacy-speechtyping;privacy-feedback;privacy-activityhistory;privacy-location;privacy-voiceactivation;privacy-accountinfo;privacy-calendar;privacy-callhistory;privacy-phone;privacy-email;privacy-eyetracker;privacy-tasks;privacy-messaging;privacy-radios;privacy-customdevices;privacy-appdiagnostics;privacy-automaticfiledownloads;privacy-phonecalls;windowsdefender;backup;troubleshoot;findmydevice;delivery-optimization;delivery-optimization-activity;delivery-optimization-advanced;maps-downloadmaps;appsforwebsites;videoplayback;sync;deviceusage;home;backup (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Explorer policy family; apply only when the target/value exists on this Windows build.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-admx-windowsexplorer`

## Referințe / References

- https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-admx-windowsexplorer
