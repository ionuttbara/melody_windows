# Windows Update/Disable Feature Updates.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `159f9f417bc8531d0f0d0b0230603850863c765112644c862a44ace365b22529`
- **Recipe verdict / verdict rețetă:** `RETIRED`
- **Windows container / interval Windows:** `19041+`
- **Runtime prerequisite / condiție runtime:** `existing-key`
- **Value/operation descriptions / operații:** 18
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L6 · SET-VALUE · `AutoRestartDeadlinePeriodInDaysForFeatureUpdates`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate`
- **Raw .reg data:** `dword:00000007`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Auto Restart Deadline Period In Days For Feature Updates” în politicile Windows Update la 7 (0x00000007) (REG_DWORD). Rețeta Registry brută este retrasă din execuție; operația rămâne documentată doar ca referință.
- **What it configures / EN:** Sets the “Auto Restart Deadline Period In Days For Feature Updates” option in Windows Update policies to 7 (0x00000007) (REG_DWORD). Validated for Melody 16.0 and enabled when the Windows build and component prerequisites match.
- **Final verdict / verdict final:** `RETIRED`
- **Certitudine / Evidence:** Windows Update value lacks a confirmed exact version floor in this audit; retired rather than applied in void.
- **OS support / versiuni:** `10240+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-update`

### L7 · SET-VALUE · `ConfigureDeadlineForFeatureUpdates`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate`
- **Raw .reg data:** `dword:00000007`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Configure Deadline For Feature Updates” în politicile Windows Update la 7 (0x00000007) (REG_DWORD). Semnificația și forma operației sunt susținute de sursa indicată.
- **What it configures / EN:** Sets the “Configure Deadline For Feature Updates” option in Windows Update policies to 7 (0x00000007) (REG_DWORD). The operation meaning and form are supported by the cited source.
- **Final verdict / verdict final:** `VERIFIED`
- **Certitudine / Evidence:** Documented Windows Update policy family with a known Windows floor.
- **OS support / versiuni:** `18362+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-update`

### L8 · SET-VALUE · `ConfigureDeadlineGracePeriodForFeatureUpdates`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate`
- **Raw .reg data:** `dword:00000007`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Configure Deadline Grace Period For Feature Updates” în politicile Windows Update la 7 (0x00000007) (REG_DWORD). Semnificația și forma operației sunt susținute de sursa indicată.
- **What it configures / EN:** Sets the “Configure Deadline Grace Period For Feature Updates” option in Windows Update policies to 7 (0x00000007) (REG_DWORD). The operation meaning and form are supported by the cited source.
- **Final verdict / verdict final:** `VERIFIED`
- **Certitudine / Evidence:** Documented Windows Update policy family with a known Windows floor.
- **OS support / versiuni:** `18362+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-update`

### L9 · SET-VALUE · `DeferFeatureUpdates`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Defer Feature Updates” în politicile Windows Update la 1 (0x00000001) (REG_DWORD). Semnificația și forma operației sunt susținute de sursa indicată.
- **What it configures / EN:** Sets the “Defer Feature Updates” option in Windows Update policies to 1 (0x00000001) (REG_DWORD). The operation meaning and form are supported by the cited source.
- **Final verdict / verdict final:** `VERIFIED`
- **Certitudine / Evidence:** Documented Windows Update policy family with a known Windows floor.
- **OS support / versiuni:** `14393+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-update`

### L10 · SET-VALUE · `DeferFeatureUpdatesPeriodInDays`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate`
- **Raw .reg data:** `dword:00000007`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Defer Feature Updates Period In Days” în politicile Windows Update la 7 (0x00000007) (REG_DWORD). Semnificația și forma operației sunt susținute de sursa indicată.
- **What it configures / EN:** Sets the “Defer Feature Updates Period In Days” option in Windows Update policies to 7 (0x00000007) (REG_DWORD). The operation meaning and form are supported by the cited source.
- **Final verdict / verdict final:** `VERIFIED`
- **Certitudine / Evidence:** Documented Windows Update policy family with a known Windows floor.
- **OS support / versiuni:** `14393+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-update`

### L11 · SET-VALUE · `PauseFeatureUpdatesStartTime`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate`
- **Raw .reg data:** `""`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Pause Feature Updates Start Time” în politicile Windows Update la (REG_SZ). Semnificația și forma operației sunt susținute de sursa indicată.
- **What it configures / EN:** Sets the “Pause Feature Updates Start Time” option in Windows Update policies to (REG_SZ). The operation meaning and form are supported by the cited source.
- **Final verdict / verdict final:** `VERIFIED`
- **Certitudine / Evidence:** Documented Windows Update policy family with a known Windows floor.
- **OS support / versiuni:** `16299+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-update`

### L12 · SET-VALUE · `TargetReleaseVersion`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Target Release Version” în politicile Windows Update la 1 (0x00000001) (REG_DWORD). Semnificația și forma operației sunt susținute de sursa indicată.
- **What it configures / EN:** Sets the “Target Release Version” option in Windows Update policies to 1 (0x00000001) (REG_DWORD). The operation meaning and form are supported by the cited source.
- **Final verdict / verdict final:** `VERIFIED`
- **Certitudine / Evidence:** Documented Windows Update policy family with a known Windows floor.
- **OS support / versiuni:** `19041+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-update`

### L13 · SET-VALUE · `TargetReleaseVersionInfo`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate`
- **Raw .reg data:** `"21H1"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Target Release Version Info” în politicile Windows Update la 21H1 (REG_SZ). Semnificația și forma operației sunt susținute de sursa indicată.
- **What it configures / EN:** Sets the “Target Release Version Info” option in Windows Update policies to 21H1 (REG_SZ). The operation meaning and form are supported by the cited source.
- **Final verdict / verdict final:** `VERIFIED`
- **Certitudine / Evidence:** Documented Windows Update policy family with a known Windows floor.
- **OS support / versiuni:** `19041+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-update`

### L14 · SET-VALUE · `ProductVersion`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate`
- **Raw .reg data:** `"Windows 10"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Product Version” în politicile Windows Update la Windows 10 (REG_SZ). Semnificația și forma operației sunt susținute de sursa indicată.
- **What it configures / EN:** Sets the “Product Version” option in Windows Update policies to Windows 10 (REG_SZ). The operation meaning and form are supported by the cited source.
- **Final verdict / verdict final:** `VERIFIED`
- **Certitudine / Evidence:** Documented Windows Update policy family with a known Windows floor.
- **OS support / versiuni:** `19041+`
- **Source / sursă:** `https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-update`

### L17 · SET-VALUE · `value`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\PolicyManager\default\Update\ConfigureDeadlineGracePeriodForFeatureUpdates`
- **Raw .reg data:** `dword:00000007`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „value” în ramura Microsoft / PolicyManager / default la 7 (0x00000007) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “value” option in registry branch Microsoft / PolicyManager / default to 7 (0x00000007) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Internal/user setting; only an existing value is changed, preventing creation on unsupported builds.
- **OS support / versiuni:** `7600+`

### L19 · SET-VALUE · `value`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\PolicyManager\default\Update\EngagedRestartTransitionScheduleForFeatureUpdates`
- **Raw .reg data:** `dword:00000008`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „value” în ramura Microsoft / PolicyManager / default la 8 (0x00000008) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “value” option in registry branch Microsoft / PolicyManager / default to 8 (0x00000008) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Internal/user setting; only an existing value is changed, preventing creation on unsupported builds.
- **OS support / versiuni:** `7600+`

### L21 · SET-VALUE · `value`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\PolicyManager\default\Update\EngagedRestartSnoozeScheduleForFeatureUpdates`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „value” în ramura Microsoft / PolicyManager / default la 3 (0x00000003) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “value” option in registry branch Microsoft / PolicyManager / default to 3 (0x00000003) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Internal/user setting; only an existing value is changed, preventing creation on unsupported builds.
- **OS support / versiuni:** `7600+`

### L23 · SET-VALUE · `value`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\PolicyManager\default\Update\EngagedRestartDeadlineForFeatureUpdates`
- **Raw .reg data:** `dword:0000000e`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „value” în ramura Microsoft / PolicyManager / default la 14 (0x0000000E) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “value” option in registry branch Microsoft / PolicyManager / default to 14 (0x0000000E) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Internal/user setting; only an existing value is changed, preventing creation on unsupported builds.
- **OS support / versiuni:** `7600+`

### L25 · SET-VALUE · `value`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\PolicyManager\default\Update\AutoRestartDeadlinePeriodInDaysForFeatureUpdates`
- **Raw .reg data:** `dword:00000007`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „value” în ramura Microsoft / PolicyManager / default la 7 (0x00000007) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “value” option in registry branch Microsoft / PolicyManager / default to 7 (0x00000007) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Internal/user setting; only an existing value is changed, preventing creation on unsupported builds.
- **OS support / versiuni:** `7600+`

### L27 · SET-VALUE · `value`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\PolicyManager\default\Update\ConfigureDeadlineForFeatureUpdates`
- **Raw .reg data:** `dword:00000007`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „value” în ramura Microsoft / PolicyManager / default la 7 (0x00000007) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “value” option in registry branch Microsoft / PolicyManager / default to 7 (0x00000007) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Internal/user setting; only an existing value is changed, preventing creation on unsupported builds.
- **OS support / versiuni:** `7600+`

### L29 · SET-VALUE · `value`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\PolicyManager\default\Update\DeferFeatureUpdatesPeriodInDays`
- **Raw .reg data:** `dword:00000007`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „value” în ramura Microsoft / PolicyManager / default la 7 (0x00000007) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “value” option in registry branch Microsoft / PolicyManager / default to 7 (0x00000007) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Internal/user setting; only an existing value is changed, preventing creation on unsupported builds.
- **OS support / versiuni:** `7600+`

### L31 · SET-VALUE · `value`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\PolicyManager\default\Update\PauseFeatureUpdates`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „value” în ramura Microsoft / PolicyManager / default la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “value” option in registry branch Microsoft / PolicyManager / default to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Internal/user setting; only an existing value is changed, preventing creation on unsupported builds.
- **OS support / versiuni:** `7600+`

### L33 · SET-VALUE · `value`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\PolicyManager\default\Update\SetPolicyDrivenUpdateSourceForFeatureUpdates`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „value” în ramura Microsoft / PolicyManager / default la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “value” option in registry branch Microsoft / PolicyManager / default to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Internal/user setting; only an existing value is changed, preventing creation on unsupported builds.
- **OS support / versiuni:** `7600+`

## Referințe / References

- https://learn.microsoft.com/en-us/windows/client-management/mdm/policy-csp-update
