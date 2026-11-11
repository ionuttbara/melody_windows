# Register Windows as MDM Enrollment.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `23a9c544d24ce807a73dc5e95992b9868970f6e76fc5182ae021718d4ab7056f`
- **Recipe verdict / verdict rețetă:** `CONDITIONAL`
- **Windows container / interval Windows:** `10240+`
- **Runtime prerequisite / condiție runtime:** `existing-key`
- **Value/operation descriptions / operații:** 8
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L5 · SET-VALUE · `EnrollmentState`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Enrollments\FFFFFFFF-FFFF-FFFF-FFFF-FFFFFFFFFFFF`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Enrollment State” în ramura Microsoft / Enrollments / FFFFFFFF-FFFF-FFFF-FFFF-FFFFFFFFFFFF la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Enrollment State” option in registry branch Microsoft / Enrollments / FFFFFFFF-FFFF-FFFF-FFFF-FFFFFFFFFFFF to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `10240+`

### L6 · SET-VALUE · `EnrollmentType`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Enrollments\FFFFFFFF-FFFF-FFFF-FFFF-FFFFFFFFFFFF`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Enrollment Type” în ramura Microsoft / Enrollments / FFFFFFFF-FFFF-FFFF-FFFF-FFFFFFFFFFFF la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Enrollment Type” option in registry branch Microsoft / Enrollments / FFFFFFFF-FFFF-FFFF-FFFF-FFFFFFFFFFFF to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `10240+`

### L7 · SET-VALUE · `IsFederated`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Enrollments\FFFFFFFF-FFFF-FFFF-FFFF-FFFFFFFFFFFF`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Is Federated” în ramura Microsoft / Enrollments / FFFFFFFF-FFFF-FFFF-FFFF-FFFFFFFFFFFF la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Is Federated” option in registry branch Microsoft / Enrollments / FFFFFFFF-FFFF-FFFF-FFFF-FFFFFFFFFFFF to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `10240+`

### L10 · SET-VALUE · `Flags`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Provisioning\OMADM\Accounts\FFFFFFFF-FFFF-FFFF-FFFF-FFFFFFFFFFFF`
- **Raw .reg data:** `dword:00d6fb7f`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Flags” în ramura Microsoft / Provisioning / OMADM la 14089087 (0x00D6FB7F) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Flags” option in registry branch Microsoft / Provisioning / OMADM to 14089087 (0x00D6FB7F) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `10240+`

### L11 · SET-VALUE · `AcctUId`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Provisioning\OMADM\Accounts\FFFFFFFF-FFFF-FFFF-FFFF-FFFFFFFFFFFF`
- **Raw .reg data:** `"0x000000000000000000000000000000000000000000000000000000000000000000000000"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Acct UId” în ramura Microsoft / Provisioning / OMADM la 0x000000000000000000000000000000000000000000000000000000000000000000000000 (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Acct UId” option in registry branch Microsoft / Provisioning / OMADM to 0x000000000000000000000000000000000000000000000000000000000000000000000000 (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `10240+`

### L12 · SET-VALUE · `RoamingCount`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Provisioning\OMADM\Accounts\FFFFFFFF-FFFF-FFFF-FFFF-FFFFFFFFFFFF`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Roaming Count” în ramura Microsoft / Provisioning / OMADM la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Roaming Count” option in registry branch Microsoft / Provisioning / OMADM to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `10240+`

### L13 · SET-VALUE · `SslClientCertReference`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Provisioning\OMADM\Accounts\FFFFFFFF-FFFF-FFFF-FFFF-FFFFFFFFFFFF`
- **Raw .reg data:** `"MY;User;0000000000000000000000000000000000000000"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Ssl Client Cert Reference” în ramura Microsoft / Provisioning / OMADM la MY;User;0000000000000000000000000000000000000000 (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Ssl Client Cert Reference” option in registry branch Microsoft / Provisioning / OMADM to MY;User;0000000000000000000000000000000000000000 (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `10240+`

### L14 · SET-VALUE · `ProtoVer`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Provisioning\OMADM\Accounts\FFFFFFFF-FFFF-FFFF-FFFF-FFFFFFFFFFFF`
- **Raw .reg data:** `"1.2"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Proto Ver” în ramura Microsoft / Provisioning / OMADM la 1.2 (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Proto Ver” option in registry branch Microsoft / Provisioning / OMADM to 1.2 (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `10240+`

## Referințe / References

- No exact vendor URL is attached. The final runtime rule requires the exact live Registry target to exist before Melody enables the recipe.
