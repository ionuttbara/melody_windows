# Windows Apparence/Windows Region Settings.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `d841d049dba80e3c142ff8332a30afba42dbc1e0983efa7fc40c06da4340f306`
- **Recipe verdict / verdict rețetă:** `CONDITIONAL`
- **Windows container / interval Windows:** `7600+`
- **Runtime prerequisite / condiție runtime:** `existing-key`
- **Value/operation descriptions / operații:** 55
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L6 · SET-VALUE · `iFirstDayOfWeek`

- **Registry key:** `HKEY_CURRENT_USER\Control Panel\International`
- **Raw .reg data:** `"0"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „i First Day Of Week” în formatele regionale și lingvistice la 0 (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “i First Day Of Week” option in locale and regional formats to 0 (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L9 · SET-VALUE · `s1159`

- **Registry key:** `HKEY_CURRENT_USER\Control Panel\International`
- **Raw .reg data:** `"AM"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „s1159” în formatele regionale și lingvistice la AM (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “s1159” option in locale and regional formats to AM (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L10 · SET-VALUE · `s2359`

- **Registry key:** `HKEY_CURRENT_USER\Control Panel\International`
- **Raw .reg data:** `"PM"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „s2359” în formatele regionale și lingvistice la PM (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “s2359” option in locale and regional formats to PM (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L11 · SET-VALUE · `sCurrency`

- **Registry key:** `HKEY_CURRENT_USER\Control Panel\International`
- **Raw .reg data:** `"$"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „s Currency” în formatele regionale și lingvistice la $ (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “s Currency” option in locale and regional formats to $ (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L12 · SET-VALUE · `sDate`

- **Registry key:** `HKEY_CURRENT_USER\Control Panel\International`
- **Raw .reg data:** `"."`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „s Date” în formatele regionale și lingvistice la . (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “s Date” option in locale and regional formats to . (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L13 · SET-VALUE · `sDecimal`

- **Registry key:** `HKEY_CURRENT_USER\Control Panel\International`
- **Raw .reg data:** `","`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „s Decimal” în formatele regionale și lingvistice la , (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “s Decimal” option in locale and regional formats to , (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L14 · SET-VALUE · `sGrouping`

- **Registry key:** `HKEY_CURRENT_USER\Control Panel\International`
- **Raw .reg data:** `"3;0"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „s Grouping” în formatele regionale și lingvistice la 3;0 (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “s Grouping” option in locale and regional formats to 3;0 (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L15 · SET-VALUE · `sList`

- **Registry key:** `HKEY_CURRENT_USER\Control Panel\International`
- **Raw .reg data:** `"."`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „s List” în formatele regionale și lingvistice la . (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “s List” option in locale and regional formats to . (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L16 · SET-VALUE · `sLongDate`

- **Registry key:** `HKEY_CURRENT_USER\Control Panel\International`
- **Raw .reg data:** `"dddd, dd.MM.yyyy"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „s Long Date” în formatele regionale și lingvistice la dddd, dd.MM.yyyy (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “s Long Date” option in locale and regional formats to dddd, dd.MM.yyyy (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L17 · SET-VALUE · `sMonDecimalSep`

- **Registry key:** `HKEY_CURRENT_USER\Control Panel\International`
- **Raw .reg data:** `"."`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „s Mon Decimal Sep” în formatele regionale și lingvistice la . (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “s Mon Decimal Sep” option in locale and regional formats to . (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L18 · SET-VALUE · `sMonGrouping`

- **Registry key:** `HKEY_CURRENT_USER\Control Panel\International`
- **Raw .reg data:** `"3;0"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „s Mon Grouping” în formatele regionale și lingvistice la 3;0 (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “s Mon Grouping” option in locale and regional formats to 3;0 (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L19 · SET-VALUE · `sMonThousandSep`

- **Registry key:** `HKEY_CURRENT_USER\Control Panel\International`
- **Raw .reg data:** `","`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „s Mon Thousand Sep” în formatele regionale și lingvistice la , (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “s Mon Thousand Sep” option in locale and regional formats to , (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L20 · SET-VALUE · `sNativeDigits`

- **Registry key:** `HKEY_CURRENT_USER\Control Panel\International`
- **Raw .reg data:** `"0123456789"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „s Native Digits” în formatele regionale și lingvistice la 0123456789 (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “s Native Digits” option in locale and regional formats to 0123456789 (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L21 · SET-VALUE · `sNegativeSign`

- **Registry key:** `HKEY_CURRENT_USER\Control Panel\International`
- **Raw .reg data:** `"-"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „s Negative Sign” în formatele regionale și lingvistice la - (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “s Negative Sign” option in locale and regional formats to - (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L22 · SET-VALUE · `sPositiveSign`

- **Registry key:** `HKEY_CURRENT_USER\Control Panel\International`
- **Raw .reg data:** `""`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „s Positive Sign” în formatele regionale și lingvistice la (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “s Positive Sign” option in locale and regional formats to (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L23 · SET-VALUE · `sShortDate`

- **Registry key:** `HKEY_CURRENT_USER\Control Panel\International`
- **Raw .reg data:** `"d.M.yyyy"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „s Short Date” în formatele regionale și lingvistice la d.M.yyyy (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “s Short Date” option in locale and regional formats to d.M.yyyy (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L24 · SET-VALUE · `sThousand`

- **Registry key:** `HKEY_CURRENT_USER\Control Panel\International`
- **Raw .reg data:** `"."`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „s Thousand” în formatele regionale și lingvistice la . (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “s Thousand” option in locale and regional formats to . (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L25 · SET-VALUE · `sTime`

- **Registry key:** `HKEY_CURRENT_USER\Control Panel\International`
- **Raw .reg data:** `":"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „s Time” în formatele regionale și lingvistice la : (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “s Time” option in locale and regional formats to : (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L26 · SET-VALUE · `sTimeFormat`

- **Registry key:** `HKEY_CURRENT_USER\Control Panel\International`
- **Raw .reg data:** `"HH:mm:ss"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „s Time Format” în formatele regionale și lingvistice la HH:mm:ss (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “s Time Format” option in locale and regional formats to HH:mm:ss (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L27 · SET-VALUE · `sShortTime`

- **Registry key:** `HKEY_CURRENT_USER\Control Panel\International`
- **Raw .reg data:** `"HH:mm"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „s Short Time” în formatele regionale și lingvistice la HH:mm (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “s Short Time” option in locale and regional formats to HH:mm (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L28 · SET-VALUE · `iFirstDayOfWeek`

- **Registry key:** `HKEY_CURRENT_USER\Control Panel\International`
- **Raw .reg data:** `"0"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „i First Day Of Week” în formatele regionale și lingvistice la 0 (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “i First Day Of Week” option in locale and regional formats to 0 (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L29 · SET-VALUE · `iLZero`

- **Registry key:** `HKEY_CURRENT_USER\Control Panel\International`
- **Raw .reg data:** `"1"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „i LZero” în formatele regionale și lingvistice la 1 (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “i LZero” option in locale and regional formats to 1 (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L30 · SET-VALUE · `iMeasure`

- **Registry key:** `HKEY_CURRENT_USER\Control Panel\International`
- **Raw .reg data:** `"0"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „i Measure” în formatele regionale și lingvistice la 0 (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “i Measure” option in locale and regional formats to 0 (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L31 · SET-VALUE · `iNegCurr`

- **Registry key:** `HKEY_CURRENT_USER\Control Panel\International`
- **Raw .reg data:** `"0"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „i Neg Curr” în formatele regionale și lingvistice la 0 (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “i Neg Curr” option in locale and regional formats to 0 (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L34 · SET-VALUE · `iFirstDayOfWeek`

- **Registry key:** `HKEY_USERS\.DEFAULT\Control Panel\International`
- **Raw .reg data:** `"0"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „i First Day Of Week” în formatele regionale și lingvistice la 0 (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “i First Day Of Week” option in locale and regional formats to 0 (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L37 · SET-VALUE · `s1159`

- **Registry key:** `HKEY_USERS\.DEFAULT\Control Panel\International`
- **Raw .reg data:** `"AM"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „s1159” în formatele regionale și lingvistice la AM (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “s1159” option in locale and regional formats to AM (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L38 · SET-VALUE · `s2359`

- **Registry key:** `HKEY_USERS\.DEFAULT\Control Panel\International`
- **Raw .reg data:** `"PM"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „s2359” în formatele regionale și lingvistice la PM (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “s2359” option in locale and regional formats to PM (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L39 · SET-VALUE · `sCurrency`

- **Registry key:** `HKEY_USERS\.DEFAULT\Control Panel\International`
- **Raw .reg data:** `"$"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „s Currency” în formatele regionale și lingvistice la $ (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “s Currency” option in locale and regional formats to $ (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L40 · SET-VALUE · `sDate`

- **Registry key:** `HKEY_USERS\.DEFAULT\Control Panel\International`
- **Raw .reg data:** `"."`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „s Date” în formatele regionale și lingvistice la . (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “s Date” option in locale and regional formats to . (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L41 · SET-VALUE · `sDecimal`

- **Registry key:** `HKEY_USERS\.DEFAULT\Control Panel\International`
- **Raw .reg data:** `","`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „s Decimal” în formatele regionale și lingvistice la , (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “s Decimal” option in locale and regional formats to , (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L42 · SET-VALUE · `sGrouping`

- **Registry key:** `HKEY_USERS\.DEFAULT\Control Panel\International`
- **Raw .reg data:** `"3;0"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „s Grouping” în formatele regionale și lingvistice la 3;0 (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “s Grouping” option in locale and regional formats to 3;0 (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L43 · SET-VALUE · `sList`

- **Registry key:** `HKEY_USERS\.DEFAULT\Control Panel\International`
- **Raw .reg data:** `"."`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „s List” în formatele regionale și lingvistice la . (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “s List” option in locale and regional formats to . (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L44 · SET-VALUE · `sLongDate`

- **Registry key:** `HKEY_USERS\.DEFAULT\Control Panel\International`
- **Raw .reg data:** `"dddd, dd.MM.yyyy"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „s Long Date” în formatele regionale și lingvistice la dddd, dd.MM.yyyy (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “s Long Date” option in locale and regional formats to dddd, dd.MM.yyyy (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L45 · SET-VALUE · `sMonDecimalSep`

- **Registry key:** `HKEY_USERS\.DEFAULT\Control Panel\International`
- **Raw .reg data:** `"."`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „s Mon Decimal Sep” în formatele regionale și lingvistice la . (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “s Mon Decimal Sep” option in locale and regional formats to . (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L46 · SET-VALUE · `sMonGrouping`

- **Registry key:** `HKEY_USERS\.DEFAULT\Control Panel\International`
- **Raw .reg data:** `"3;0"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „s Mon Grouping” în formatele regionale și lingvistice la 3;0 (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “s Mon Grouping” option in locale and regional formats to 3;0 (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L47 · SET-VALUE · `sMonThousandSep`

- **Registry key:** `HKEY_USERS\.DEFAULT\Control Panel\International`
- **Raw .reg data:** `","`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „s Mon Thousand Sep” în formatele regionale și lingvistice la , (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “s Mon Thousand Sep” option in locale and regional formats to , (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L48 · SET-VALUE · `sNativeDigits`

- **Registry key:** `HKEY_USERS\.DEFAULT\Control Panel\International`
- **Raw .reg data:** `"0123456789"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „s Native Digits” în formatele regionale și lingvistice la 0123456789 (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “s Native Digits” option in locale and regional formats to 0123456789 (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L49 · SET-VALUE · `sNegativeSign`

- **Registry key:** `HKEY_USERS\.DEFAULT\Control Panel\International`
- **Raw .reg data:** `"-"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „s Negative Sign” în formatele regionale și lingvistice la - (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “s Negative Sign” option in locale and regional formats to - (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L50 · SET-VALUE · `sPositiveSign`

- **Registry key:** `HKEY_USERS\.DEFAULT\Control Panel\International`
- **Raw .reg data:** `""`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „s Positive Sign” în formatele regionale și lingvistice la (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “s Positive Sign” option in locale and regional formats to (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L51 · SET-VALUE · `sShortDate`

- **Registry key:** `HKEY_USERS\.DEFAULT\Control Panel\International`
- **Raw .reg data:** `"dd.MM.yyyy"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „s Short Date” în formatele regionale și lingvistice la dd.MM.yyyy (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “s Short Date” option in locale and regional formats to dd.MM.yyyy (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L52 · SET-VALUE · `sThousand`

- **Registry key:** `HKEY_USERS\.DEFAULT\Control Panel\International`
- **Raw .reg data:** `"."`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „s Thousand” în formatele regionale și lingvistice la . (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “s Thousand” option in locale and regional formats to . (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L53 · SET-VALUE · `sTime`

- **Registry key:** `HKEY_USERS\.DEFAULT\Control Panel\International`
- **Raw .reg data:** `":"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „s Time” în formatele regionale și lingvistice la : (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “s Time” option in locale and regional formats to : (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L54 · SET-VALUE · `sTimeFormat`

- **Registry key:** `HKEY_USERS\.DEFAULT\Control Panel\International`
- **Raw .reg data:** `"HH:mm:ss"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „s Time Format” în formatele regionale și lingvistice la HH:mm:ss (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “s Time Format” option in locale and regional formats to HH:mm:ss (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L55 · SET-VALUE · `sShortTime`

- **Registry key:** `HKEY_USERS\.DEFAULT\Control Panel\International`
- **Raw .reg data:** `"HH:mm"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „s Short Time” în formatele regionale și lingvistice la HH:mm (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “s Short Time” option in locale and regional formats to HH:mm (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L56 · SET-VALUE · `iFirstDayOfWeek`

- **Registry key:** `HKEY_USERS\.DEFAULT\Control Panel\International`
- **Raw .reg data:** `"0"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „i First Day Of Week” în formatele regionale și lingvistice la 0 (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “i First Day Of Week” option in locale and regional formats to 0 (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L57 · SET-VALUE · `iLZero`

- **Registry key:** `HKEY_USERS\.DEFAULT\Control Panel\International`
- **Raw .reg data:** `"1"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „i LZero” în formatele regionale și lingvistice la 1 (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “i LZero” option in locale and regional formats to 1 (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L58 · SET-VALUE · `iMeasure`

- **Registry key:** `HKEY_USERS\.DEFAULT\Control Panel\International`
- **Raw .reg data:** `"0"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „i Measure” în formatele regionale și lingvistice la 0 (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “i Measure” option in locale and regional formats to 0 (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L59 · SET-VALUE · `iNegCurr`

- **Registry key:** `HKEY_USERS\.DEFAULT\Control Panel\International`
- **Raw .reg data:** `"0"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „i Neg Curr” în formatele regionale și lingvistice la 0 (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “i Neg Curr” option in locale and regional formats to 0 (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** No universal contract was found; safe final behavior is existing-value-only, so Melody cannot create this setting on an unsupported build.
- **OS support / versiuni:** `7600+`

### L62 · SET-VALUE · `ShowAutoCorrection`

- **Registry key:** `HKEY_CURRENT_USER\Control Panel\International\User Profile`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Show Auto Correction” în formatele regionale și lingvistice la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Show Auto Correction” option in locale and regional formats to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L63 · SET-VALUE · `ShowTextPrediction`

- **Registry key:** `HKEY_CURRENT_USER\Control Panel\International\User Profile`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Show Text Prediction” în formatele regionale și lingvistice la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Show Text Prediction” option in locale and regional formats to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L64 · SET-VALUE · `ShowCasing`

- **Registry key:** `HKEY_CURRENT_USER\Control Panel\International\User Profile`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Show Casing” în formatele regionale și lingvistice la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Show Casing” option in locale and regional formats to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L65 · SET-VALUE · `ShowShiftLock`

- **Registry key:** `HKEY_CURRENT_USER\Control Panel\International\User Profile`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Show Shift Lock” în formatele regionale și lingvistice la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Show Shift Lock” option in locale and regional formats to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L66 · SET-VALUE · `HttpAcceptLanguageOptOut`

- **Registry key:** `HKEY_CURRENT_USER\Control Panel\International\User Profile`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Http Accept Language Opt Out” în formatele regionale și lingvistice la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Http Accept Language Opt Out” option in locale and regional formats to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L67 · SET-VALUE · `DiagTrackAuthorization`

- **Registry key:** `HKEY_CURRENT_USER\Control Panel\International\User Profile`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Diag Track Authorization” în formatele regionale și lingvistice la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Diag Track Authorization” option in locale and regional formats to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

### L68 · DELETE-VALUE · `UploadPermissionReceived`

- **Registry key:** `HKEY_CURRENT_USER\Control Panel\International\User Profile`
- **Raw .reg data:** `-`
- **Type / tip:** `VALUE DELETE`
- **Ce face / RO:** Elimină opțiunea „Upload Permission Received” din formatele regionale și lingvistice; NU echivalează automat cu dezactivarea funcției și poate restabili o valoare implicită. Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Removes the “Upload Permission Received” option from locale and regional formats; this does NOT necessarily disable the feature and may restore a default behavior. Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Windows user preference; final rule requires the exact value to already exist on the detected build.
- **OS support / versiuni:** `7600+`

## Referințe / References

- No exact vendor URL is attached. The final runtime rule requires the exact live Registry target to exist before Melody enables the recipe.
