# Browser Configuration/Brave.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `a49d31897f35d8f6a95d05195b5594588bf49b373c4b1d7e00d060afaf42a82d`
- **Recipe verdict / verdict rețetă:** `CONDITIONAL`
- **Windows container / interval Windows:** `7600+`
- **Runtime prerequisite / condiție runtime:** `browser-brave`
- **Value/operation descriptions / operații:** 172
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L4 · SET-VALUE · `UiAutomationProviderEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Ui Automation Provider Enabled” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Ui Automation Provider Enabled” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L5 · SET-VALUE · `ScreenCaptureAllowed`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Screen Capture Allowed” în politicile Brave la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Screen Capture Allowed” option in Brave policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L6 · SET-VALUE · `DataUrlInSvgUseEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Data Url In Svg Use Enabled” în politicile Brave la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Data Url In Svg Use Enabled” option in Brave policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L7 · SET-VALUE · `DefaultGeolocationSetting`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Default Geolocation Setting” în politicile Brave la 2 (0x00000002) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Geolocation Setting” option in Brave policies to 2 (0x00000002) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L8 · SET-VALUE · `DefaultWindowManagementSetting`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Default Window Management Setting” în politicile Brave la 3 (0x00000003) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Window Management Setting” option in Brave policies to 3 (0x00000003) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L9 · SET-VALUE · `DefaultWebUsbGuardSetting`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Default Web Usb Guard Setting” în politicile Brave la 3 (0x00000003) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Web Usb Guard Setting” option in Brave policies to 3 (0x00000003) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L10 · SET-VALUE · `DefaultWebHidGuardSetting`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Default Web Hid Guard Setting” în politicile Brave la 3 (0x00000003) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Web Hid Guard Setting” option in Brave policies to 3 (0x00000003) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L11 · SET-VALUE · `DefaultWebBluetoothGuardSetting`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Default Web Bluetooth Guard Setting” în politicile Brave la 3 (0x00000003) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Web Bluetooth Guard Setting” option in Brave policies to 3 (0x00000003) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L12 · SET-VALUE · `DefaultSerialGuardSetting`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Default Serial Guard Setting” în politicile Brave la 3 (0x00000003) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Serial Guard Setting” option in Brave policies to 3 (0x00000003) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L13 · SET-VALUE · `DefaultSensorsSetting`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Default Sensors Setting” în politicile Brave la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Sensors Setting” option in Brave policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L14 · SET-VALUE · `DefaultNotificationsSetting`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Default Notifications Setting” în politicile Brave la 3 (0x00000003) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Notifications Setting” option in Brave policies to 3 (0x00000003) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L15 · SET-VALUE · `DefaultLocalFontsSetting`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Default Local Fonts Setting” în politicile Brave la 3 (0x00000003) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Local Fonts Setting” option in Brave policies to 3 (0x00000003) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L16 · SET-VALUE · `DefaultJavaScriptJitSetting`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Default Java Script Jit Setting” în politicile Brave la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Java Script Jit Setting” option in Brave policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L17 · SET-VALUE · `DefaultInsecureContentSetting`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Default Insecure Content Setting” în politicile Brave la 3 (0x00000003) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Insecure Content Setting” option in Brave policies to 3 (0x00000003) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L18 · SET-VALUE · `DefaultSearchProviderEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Default Search Provider Enabled” în politicile Brave la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Search Provider Enabled” option in Brave policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L19 · SET-VALUE · `DefaultSearchProviderImageURLPostParams`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `"content={google:imageThumbnail},url={google:imageURL},sbisrc={google:imageSearchSource}"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Default Search Provider Image URLPost Params” în politicile Brave la content={google:imageThumbnail},url={google:imageURL},sbisrc={google:imageSearchSource} (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Search Provider Image URLPost Params” option in Brave policies to content={google:imageThumbnail},url={google:imageURL},sbisrc={google:imageSearchSource} (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L20 · SET-VALUE · `DefaultSearchProviderKeyword`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `"googl"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Default Search Provider Keyword” în politicile Brave la googl (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Search Provider Keyword” option in Brave policies to googl (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L21 · SET-VALUE · `DefaultSearchProviderName`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `"Google"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Default Search Provider Name” în politicile Brave la Google (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Search Provider Name” option in Brave policies to Google (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L22 · SET-VALUE · `DefaultSearchProviderSuggestURL`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `"{google:baseURL}complete/search?output=chrome&q={searchTerms}"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Default Search Provider Suggest URL” în politicile Brave la {google:baseURL}complete/search?output=chrome&q={searchTerms} (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Search Provider Suggest URL” option in Brave policies to {google:baseURL}complete/search?output=chrome&q={searchTerms} (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L23 · SET-VALUE · `DefaultSearchProviderSearchURLPostParams`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `"q={searchTerms},ie=utf-8,oe=utf-8"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Default Search Provider Search URLPost Params” în politicile Brave la q={searchTerms},ie=utf-8,oe=utf-8 (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Search Provider Search URLPost Params” option in Brave policies to q={searchTerms},ie=utf-8,oe=utf-8 (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L24 · SET-VALUE · `DefaultSearchProviderSearchURL`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `"{google:baseURL}search?q={searchTerms}&{google:RLZ}{google:originalQueryForSuggestion}{google:assistedQueryStats}{google:searchFieldtrialParameter}{google:searchClient}{google:sourceId}ie={inputEncoding}"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Default Search Provider Search URL” în politicile Brave la {google:baseURL}search?q={searchTerms}&{google:RLZ}{google:originalQueryForSuggestion}{google:assistedQueryStats}{google:searchFieldtrialParameter}{google:searchClient}{google:sourceId}ie={inputEncoding} (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Search Provider Search URL” option in Brave policies to {google:baseURL}search?q={searchTerms}&{google:RLZ}{google:originalQueryForSuggestion}{google:assistedQueryStats}{google:searchFieldtrialParameter}{google:searchClient}{google:sourceId}ie={inputEncoding} (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L25 · SET-VALUE · `DefaultSearchProviderSuggestURLPostParams`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `"q={searchTerms},ie=utf-8,oe=utf-8"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Default Search Provider Suggest URLPost Params” în politicile Brave la q={searchTerms},ie=utf-8,oe=utf-8 (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Search Provider Suggest URLPost Params” option in Brave policies to q={searchTerms},ie=utf-8,oe=utf-8 (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L26 · SET-VALUE · `SafeBrowsingEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Safe Browsing Enabled” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Safe Browsing Enabled” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L27 · SET-VALUE · `RendererCodeIntegrityEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Renderer Code Integrity Enabled” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Renderer Code Integrity Enabled” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L28 · SET-VALUE · `ProxyServerMode`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Proxy Server Mode” în politicile Brave la 3 (0x00000003) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Proxy Server Mode” option in Brave policies to 3 (0x00000003) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L29 · SET-VALUE · `InsecureFormsWarningsEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Insecure Forms Warnings Enabled” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Insecure Forms Warnings Enabled” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L30 · SET-VALUE · `DefaultWindowPlacementSetting`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Default Window Placement Setting” în politicile Brave la 3 (0x00000003) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Window Placement Setting” option in Brave policies to 3 (0x00000003) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L31 · SET-VALUE · `DefaultMediaStreamSetting`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Default Media Stream Setting” în politicile Brave la 3 (0x00000003) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Media Stream Setting” option in Brave policies to 3 (0x00000003) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L32 · SET-VALUE · `ExtensionManifestV2Availability`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Extension Manifest V2Availability” în politicile Brave la 2 (0x00000002) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Extension Manifest V2Availability” option in Brave policies to 2 (0x00000002) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L33 · SET-VALUE · `ExtensionUnpublishedAvailability`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Extension Unpublished Availability” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Extension Unpublished Availability” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L34 · SET-VALUE · `CreateThemesSettings`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Create Themes Settings” în politicile Brave la 2 (0x00000002) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Create Themes Settings” option in Brave policies to 2 (0x00000002) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L35 · SET-VALUE · `DevToolsGenAiSettings`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Dev Tools Gen Ai Settings” în politicile Brave la 2 (0x00000002) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Dev Tools Gen Ai Settings” option in Brave policies to 2 (0x00000002) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L36 · SET-VALUE · `GenAILocalFoundationalModelSettings`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Gen AILocal Foundational Model Settings” în politicile Brave la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Gen AILocal Foundational Model Settings” option in Brave policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L37 · SET-VALUE · `HelpMeWriteSettings`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Help Me Write Settings” în politicile Brave la 2 (0x00000002) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Help Me Write Settings” option in Brave policies to 2 (0x00000002) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L38 · SET-VALUE · `HistorySearchSettings`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „History Search Settings” în politicile Brave la 2 (0x00000002) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “History Search Settings” option in Brave policies to 2 (0x00000002) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L39 · SET-VALUE · `TabOrganizerSettings`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Tab Organizer Settings” în politicile Brave la 2 (0x00000002) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Tab Organizer Settings” option in Brave policies to 2 (0x00000002) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L40 · SET-VALUE · `EnableMediaRouter`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Enable Media Router” în politicile Brave la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Enable Media Router” option in Brave policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L41 · SET-VALUE · `MediaRouterCastAllowAllIPs`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Media Router Cast Allow All IPs” în politicile Brave la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Media Router Cast Allow All IPs” option in Brave policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L42 · SET-VALUE · `ShowCastIconInToolbar`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Show Cast Icon In Toolbar” în politicile Brave la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Show Cast Icon In Toolbar” option in Brave policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L43 · SET-VALUE · `ShowCastSessionsStartedByOtherDevices`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Show Cast Sessions Started By Other Devices” în politicile Brave la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Show Cast Sessions Started By Other Devices” option in Brave policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L44 · SET-VALUE · `AccessCodeCastEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Access Code Cast Enabled” în politicile Brave la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Access Code Cast Enabled” option in Brave policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L45 · SET-VALUE · `CloudAPAuthEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Cloud APAuth Enabled” în politicile Brave la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Cloud APAuth Enabled” option in Brave policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L46 · SET-VALUE · `CompressionDictionaryTransportEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Compression Dictionary Transport Enabled” în politicile Brave la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Compression Dictionary Transport Enabled” option in Brave policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L47 · SET-VALUE · `AccessControlAllowMethodsInCORSPreflightSpecConformant`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Access Control Allow Methods In CORSPreflight Spec Conformant” în politicile Brave la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Access Control Allow Methods In CORSPreflight Spec Conformant” option in Brave policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L48 · SET-VALUE · `IPv6ReachabilityOverrideEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „IPv6Reachability Override Enabled” în politicile Brave la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “IPv6Reachability Override Enabled” option in Brave policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L49 · SET-VALUE · `ZstdContentEncodingEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Zstd Content Encoding Enabled” în politicile Brave la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Zstd Content Encoding Enabled” option in Brave policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L50 · SET-VALUE · `DeletingUndecryptablePasswordsEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Deleting Undecryptable Passwords Enabled” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Deleting Undecryptable Passwords Enabled” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L51 · SET-VALUE · `PasswordLeakDetectionEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Password Leak Detection Enabled” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Password Leak Detection Enabled” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L52 · SET-VALUE · `PrintHeaderFooter`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Print Header Footer” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Print Header Footer” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L53 · SET-VALUE · `PrintingEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Printing Enabled” în politicile Brave la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Printing Enabled” option in Brave policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L54 · SET-VALUE · `PrintingLPACSandboxEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Printing LPACSandbox Enabled” în politicile Brave la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Printing LPACSandbox Enabled” option in Brave policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L55 · SET-VALUE · `PrivacySandboxAdMeasurementEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Privacy Sandbox Ad Measurement Enabled” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Privacy Sandbox Ad Measurement Enabled” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L56 · SET-VALUE · `PrivacySandboxAdTopicsEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Privacy Sandbox Ad Topics Enabled” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Privacy Sandbox Ad Topics Enabled” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L57 · SET-VALUE · `PrivacySandboxPromptEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Privacy Sandbox Prompt Enabled” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Privacy Sandbox Prompt Enabled” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L58 · SET-VALUE · `PrivacySandboxSiteEnabledAdsEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Privacy Sandbox Site Enabled Ads Enabled” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Privacy Sandbox Site Enabled Ads Enabled” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L59 · SET-VALUE · `PrivateNetworkAccessRestrictionsEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Private Network Access Restrictions Enabled” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Private Network Access Restrictions Enabled” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L60 · SET-VALUE · `AdvancedProtectionDeepScanningEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Advanced Protection Deep Scanning Enabled” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Advanced Protection Deep Scanning Enabled” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L61 · SET-VALUE · `DefaultPluginsSetting`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Default Plugins Setting” în politicile Brave la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Plugins Setting” option in Brave policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L62 · SET-VALUE · `DisableSSLRecordSplitting`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Disable SSLRecord Splitting” în politicile Brave la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Disable SSLRecord Splitting” option in Brave policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L63 · SET-VALUE · `DnsPrefetchingEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Dns Prefetching Enabled” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Dns Prefetching Enabled” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L64 · SET-VALUE · `OptimizationGuideFetchingEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Optimization Guide Fetching Enabled” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Optimization Guide Fetching Enabled” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L65 · SET-VALUE · `SafeBrowsingSurveysEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Safe Browsing Surveys Enabled” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Safe Browsing Surveys Enabled” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L66 · SET-VALUE · `SafeBrowsingProxiedRealTimeChecksAllowed`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Safe Browsing Proxied Real Time Checks Allowed” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Safe Browsing Proxied Real Time Checks Allowed” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L67 · SET-VALUE · `SafeBrowsingExtendedReportingEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Safe Browsing Extended Reporting Enabled” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Safe Browsing Extended Reporting Enabled” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L68 · SET-VALUE · `SafeBrowsingProtectionLevel`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Safe Browsing Protection Level” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Safe Browsing Protection Level” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L69 · SET-VALUE · `DisableSafeBrowsingProceedAnyway`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Disable Safe Browsing Proceed Anyway” în politicile Brave la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Disable Safe Browsing Proceed Anyway” option in Brave policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L70 · SET-VALUE · `PasswordProtectionWarningTrigger`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Password Protection Warning Trigger” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Password Protection Warning Trigger” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L71 · SET-VALUE · `SafeBrowsingDeepScanningEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Safe Browsing Deep Scanning Enabled” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Safe Browsing Deep Scanning Enabled” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L72 · SET-VALUE · `HomepageIsNewTabPage`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Homepage Is New Tab Page” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Homepage Is New Tab Page” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L73 · SET-VALUE · `HomepageLocation`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `"google.com"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Homepage Location” în politicile Brave la google.com (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Homepage Location” option in Brave policies to google.com (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L74 · SET-VALUE · `NewTabPageLocation`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `"google.com"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „New Tab Page Location” în politicile Brave la google.com (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “New Tab Page Location” option in Brave policies to google.com (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L75 · SET-VALUE · `RestoreOnStartup`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000004`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Restore On Startup” în politicile Brave la 4 (0x00000004) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Restore On Startup” option in Brave policies to 4 (0x00000004) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L76 · SET-VALUE · `ShowHomeButton`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Show Home Button” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Show Home Button” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L77 · SET-VALUE · `AbusiveExperienceInterventionEnforce`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Abusive Experience Intervention Enforce” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Abusive Experience Intervention Enforce” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L78 · SET-VALUE · `AccessibilityImageLabelsEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Accessibility Image Labels Enabled” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Accessibility Image Labels Enabled” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L79 · SET-VALUE · `AdditionalDnsQueryTypesEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Additional Dns Query Types Enabled” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Additional Dns Query Types Enabled” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L80 · SET-VALUE · `AdsSettingForIntrusiveAdsSites`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Ads Setting For Intrusive Ads Sites” în politicile Brave la 2 (0x00000002) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Ads Setting For Intrusive Ads Sites” option in Brave policies to 2 (0x00000002) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L81 · SET-VALUE · `AdvancedProtectionAllowed`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Advanced Protection Allowed” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Advanced Protection Allowed” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L82 · SET-VALUE · `AllowBackForwardCacheForCacheControlNoStorePageEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Allow Back Forward Cache For Cache Control No Store Page Enabled” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Allow Back Forward Cache For Cache Control No Store Page Enabled” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L83 · SET-VALUE · `AllowDinosaurEasterEgg`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Allow Dinosaur Easter Egg” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Allow Dinosaur Easter Egg” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L84 · SET-VALUE · `AllowFileSelectionDialogs`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Allow File Selection Dialogs” în politicile Brave la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Allow File Selection Dialogs” option in Brave policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L85 · SET-VALUE · `AlternateErrorPagesEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Alternate Error Pages Enabled” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Alternate Error Pages Enabled” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L86 · SET-VALUE · `ApplicationBoundEncryptionEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Application Bound Encryption Enabled” în politicile Brave la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Application Bound Encryption Enabled” option in Brave policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L87 · SET-VALUE · `AudioCaptureAllowed`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Audio Capture Allowed” în politicile Brave la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Audio Capture Allowed” option in Brave policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L88 · SET-VALUE · `AudioProcessHighPriorityEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Audio Process High Priority Enabled” în politicile Brave la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Audio Process High Priority Enabled” option in Brave policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L89 · SET-VALUE · `AudioSandboxEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Audio Sandbox Enabled” în politicile Brave la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Audio Sandbox Enabled” option in Brave policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L90 · SET-VALUE · `AutoplayAllowed`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Autoplay Allowed” în politicile Brave la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Autoplay Allowed” option in Brave policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L91 · SET-VALUE · `BackgroundModeEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Background Mode Enabled” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Background Mode Enabled” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L92 · SET-VALUE · `BatterySaverModeAvailability`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Battery Saver Mode Availability” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Battery Saver Mode Availability” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L93 · SET-VALUE · `BrowserGuestModeEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Browser Guest Mode Enabled” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Browser Guest Mode Enabled” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L94 · SET-VALUE · `BrowserGuestModeEnforced`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Browser Guest Mode Enforced” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Browser Guest Mode Enforced” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L95 · SET-VALUE · `BrowserLabsEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Browser Labs Enabled” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Browser Labs Enabled” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L96 · SET-VALUE · `BrowserNetworkTimeQueriesEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Browser Network Time Queries Enabled” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Browser Network Time Queries Enabled” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L97 · SET-VALUE · `BrowserSignin`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Browser Signin” în politicile Brave la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Browser Signin” option in Brave policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L98 · SET-VALUE · `BuiltInDnsClientEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Built In Dns Client Enabled” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Built In Dns Client Enabled” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L99 · SET-VALUE · `CSSCustomStateDeprecatedSyntaxEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „CSSCustom State Deprecated Syntax Enabled” în politicile Brave la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “CSSCustom State Deprecated Syntax Enabled” option in Brave policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L100 · SET-VALUE · `CORSNonWildcardRequestHeadersSupport`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „CORSNon Wildcard Request Headers Support” în politicile Brave la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “CORSNon Wildcard Request Headers Support” option in Brave policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L101 · SET-VALUE · `ChromeForTestingAllowed`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Chrome For Testing Allowed” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Chrome For Testing Allowed” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L102 · SET-VALUE · `ChromeVariations`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Chrome Variations” în politicile Brave la 2 (0x00000002) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Chrome Variations” option in Brave policies to 2 (0x00000002) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L103 · SET-VALUE · `ClickToCallEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Click To Call Enabled” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Click To Call Enabled” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L104 · SET-VALUE · `CloudManagementEnrollmentMandatory`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Cloud Management Enrollment Mandatory” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Cloud Management Enrollment Mandatory” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L105 · SET-VALUE · `CloudPolicyOverridesPlatformPolicy`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Cloud Policy Overrides Platform Policy” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Cloud Policy Overrides Platform Policy” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L106 · SET-VALUE · `CloudUserPolicyMerge`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Cloud User Policy Merge” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Cloud User Policy Merge” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L107 · SET-VALUE · `CloudUserPolicyOverridesCloudMachinePolicy`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Cloud User Policy Overrides Cloud Machine Policy” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Cloud User Policy Overrides Cloud Machine Policy” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L108 · SET-VALUE · `CommandLineFlagSecurityWarningsEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Command Line Flag Security Warnings Enabled” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Command Line Flag Security Warnings Enabled” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L109 · SET-VALUE · `ComponentUpdatesEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Component Updates Enabled” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Component Updates Enabled” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L110 · SET-VALUE · `DNSInterceptionChecksEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „DNSInterception Checks Enabled” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “DNSInterception Checks Enabled” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L111 · SET-VALUE · `DefaultBrowserSettingEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Default Browser Setting Enabled” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Browser Setting Enabled” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L112 · SET-VALUE · `DesktopSharingHubEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Desktop Sharing Hub Enabled” în politicile Brave la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Desktop Sharing Hub Enabled” option in Brave policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L113 · SET-VALUE · `DomainReliabilityAllowed`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Domain Reliability Allowed” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Domain Reliability Allowed” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L114 · SET-VALUE · `DownloadRestrictions`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Download Restrictions” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Download Restrictions” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L115 · SET-VALUE · `DynamicCodeSettings`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Dynamic Code Settings” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Dynamic Code Settings” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L116 · SET-VALUE · `FeedbackSurveysEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Feedback Surveys Enabled” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Feedback Surveys Enabled” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L117 · SET-VALUE · `ForceGoogleSafeSearch`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Force Google Safe Search” în politicile Brave la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Force Google Safe Search” option in Brave policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L118 · SET-VALUE · `ForcePermissionPolicyUnloadDefaultEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Force Permission Policy Unload Default Enabled” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Force Permission Policy Unload Default Enabled” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L119 · SET-VALUE · `ForceYouTubeRestrict`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Force You Tube Restrict” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Force You Tube Restrict” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L120 · SET-VALUE · `FullscreenAllowed`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Fullscreen Allowed” în politicile Brave la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Fullscreen Allowed” option in Brave policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L121 · SET-VALUE · `GloballyScopeHTTPAuthCacheEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Globally Scope HTTPAuth Cache Enabled” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Globally Scope HTTPAuth Cache Enabled” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L122 · SET-VALUE · `GoogleSearchSidePanelEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Google Search Side Panel Enabled” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Google Search Side Panel Enabled” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L123 · SET-VALUE · `HardwareAccelerationModeEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Hardware Acceleration Mode Enabled” în politicile Brave la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Hardware Acceleration Mode Enabled” option in Brave policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L124 · SET-VALUE · `HeadlessMode`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Headless Mode” în politicile Brave la 2 (0x00000002) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Headless Mode” option in Brave policies to 2 (0x00000002) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L125 · SET-VALUE · `HideWebStoreIcon`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Hide Web Store Icon” în politicile Brave la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Hide Web Store Icon” option in Brave policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L126 · SET-VALUE · `HighEfficiencyModeEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „High Efficiency Mode Enabled” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “High Efficiency Mode Enabled” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L127 · SET-VALUE · `HistoryClustersVisible`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „History Clusters Visible” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “History Clusters Visible” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L128 · SET-VALUE · `HttpsUpgradesEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Https Upgrades Enabled” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Https Upgrades Enabled” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L129 · SET-VALUE · `IntensiveWakeUpThrottlingEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Intensive Wake Up Throttling Enabled” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Intensive Wake Up Throttling Enabled” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L130 · SET-VALUE · `IntranetRedirectBehavior`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Intranet Redirect Behavior” în politicile Brave la 2 (0x00000002) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Intranet Redirect Behavior” option in Brave policies to 2 (0x00000002) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L131 · SET-VALUE · `KeyboardFocusableScrollersEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Keyboard Focusable Scrollers Enabled” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Keyboard Focusable Scrollers Enabled” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L132 · SET-VALUE · `LensDesktopNTPSearchEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Lens Desktop NTPSearch Enabled” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Lens Desktop NTPSearch Enabled” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L133 · SET-VALUE · `LensRegionSearchEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Lens Region Search Enabled” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Lens Region Search Enabled” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L134 · SET-VALUE · `MediaRecommendationsEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Media Recommendations Enabled” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Media Recommendations Enabled” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L135 · SET-VALUE · `MetricsReportingEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Metrics Reporting Enabled” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Metrics Reporting Enabled” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L136 · SET-VALUE · `NTPCardsVisible`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „NTPCards Visible” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “NTPCards Visible” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L137 · SET-VALUE · `NetworkPredictionOptions`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Network Prediction Options” în politicile Brave la 2 (0x00000002) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Network Prediction Options” option in Brave policies to 2 (0x00000002) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L138 · SET-VALUE · `NetworkServiceSandboxEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Network Service Sandbox Enabled” în politicile Brave la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Network Service Sandbox Enabled” option in Brave policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L139 · SET-VALUE · `PaymentMethodQueryEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Payment Method Query Enabled” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Payment Method Query Enabled” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L140 · SET-VALUE · `PrefixedVideoFullscreenApiAvailability`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `"enabled"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Prefixed Video Fullscreen Api Availability” în politicile Brave la enabled (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Prefixed Video Fullscreen Api Availability” option in Brave policies to enabled (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L141 · SET-VALUE · `PromotionalTabsEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Promotional Tabs Enabled” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Promotional Tabs Enabled” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L142 · SET-VALUE · `PromotionsEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Promotions Enabled” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Promotions Enabled” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L143 · SET-VALUE · `QRCodeGeneratorEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „QRCode Generator Enabled” în politicile Brave la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “QRCode Generator Enabled” option in Brave policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L144 · SET-VALUE · `QuicAllowed`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Quic Allowed” în politicile Brave la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Quic Allowed” option in Brave policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L145 · SET-VALUE · `RendererAppContainerEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Renderer App Container Enabled” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Renderer App Container Enabled” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L146 · SET-VALUE · `RequireOnlineRevocationChecksForLocalAnchors`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Require Online Revocation Checks For Local Anchors” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Require Online Revocation Checks For Local Anchors” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L147 · SET-VALUE · `RoamingProfileSupportEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Roaming Profile Support Enabled” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Roaming Profile Support Enabled” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L148 · SET-VALUE · `SafeBrowsingForTrustedSourcesEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Safe Browsing For Trusted Sources Enabled” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Safe Browsing For Trusted Sources Enabled” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L149 · SET-VALUE · `SandboxExternalProtocolBlocked`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Sandbox External Protocol Blocked” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Sandbox External Protocol Blocked” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L150 · SET-VALUE · `SafeSitesFilterBehavior`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Safe Sites Filter Behavior” în politicile Brave la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Safe Sites Filter Behavior” option in Brave policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L151 · SET-VALUE · `ScrollToTextFragmentEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Scroll To Text Fragment Enabled” în politicile Brave la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Scroll To Text Fragment Enabled” option in Brave policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L152 · SET-VALUE · `SharedClipboardEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Shared Clipboard Enabled” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Shared Clipboard Enabled” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L153 · SET-VALUE · `ShoppingListEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Shopping List Enabled” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Shopping List Enabled” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L154 · SET-VALUE · `ShowFullUrlsInAddressBar`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Show Full Urls In Address Bar” în politicile Brave la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Show Full Urls In Address Bar” option in Brave policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L155 · SET-VALUE · `SideSearchEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Side Search Enabled” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Side Search Enabled” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L156 · SET-VALUE · `SpellCheckServiceEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Spell Check Service Enabled” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Spell Check Service Enabled” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L157 · SET-VALUE · `SpellcheckEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Spellcheck Enabled” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Spellcheck Enabled” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L158 · SET-VALUE · `StandardizedBrowserZoomEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Standardized Browser Zoom Enabled” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Standardized Browser Zoom Enabled” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L159 · SET-VALUE · `SuppressUnsupportedOSWarning`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Suppress Unsupported OSWarning” în politicile Brave la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Suppress Unsupported OSWarning” option in Brave policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L160 · SET-VALUE · `TaskManagerEndProcessEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Task Manager End Process Enabled” în politicile Brave la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Task Manager End Process Enabled” option in Brave policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L161 · SET-VALUE · `ToolbarAvatarLabelSettings`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Toolbar Avatar Label Settings” în politicile Brave la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Toolbar Avatar Label Settings” option in Brave policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L162 · SET-VALUE · `TranslateEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Translate Enabled” în politicile Brave la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Translate Enabled” option in Brave policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L163 · SET-VALUE · `UrlKeyedAnonymizedDataCollectionEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Url Keyed Anonymized Data Collection Enabled” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Url Keyed Anonymized Data Collection Enabled” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L164 · SET-VALUE · `UserAgentReduction`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „User Agent Reduction” în politicile Brave la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “User Agent Reduction” option in Brave policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L165 · SET-VALUE · `UserFeedbackAllowed`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „User Feedback Allowed” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “User Feedback Allowed” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L166 · SET-VALUE · `VideoCaptureAllowed`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Video Capture Allowed” în politicile Brave la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Video Capture Allowed” option in Brave policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L167 · SET-VALUE · `WPADQuickCheckEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „WPADQuick Check Enabled” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “WPADQuick Check Enabled” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L168 · SET-VALUE · `WebRtcEventLogCollectionAllowed`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Web Rtc Event Log Collection Allowed” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Web Rtc Event Log Collection Allowed” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L169 · SET-VALUE · `WebRtcIPHandling`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `"default"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Web Rtc IPHandling” în politicile Brave la default (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Web Rtc IPHandling” option in Brave policies to default (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L170 · SET-VALUE · `WebRtcTextLogCollectionAllowed`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Web Rtc Text Log Collection Allowed” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Web Rtc Text Log Collection Allowed” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L171 · SET-VALUE · `WindowOcclusionEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Window Occlusion Enabled” în politicile Brave la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Window Occlusion Enabled” option in Brave policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L172 · SET-VALUE · `IPFSEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „IPFSEnabled” în politicile Brave la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “IPFSEnabled” option in Brave policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L173 · SET-VALUE · `BraveWalletDisabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Brave Wallet Disabled” în politicile Brave la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Brave Wallet Disabled” option in Brave policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L174 · SET-VALUE · `BraveVPNDisabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Brave VPNDisabled” în politicile Brave la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Brave VPNDisabled” option in Brave policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

### L175 · SET-VALUE · `BraveAIChatEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\BraveSoftware\Brave`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Brave AIChat Enabled” în politicile Brave la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Brave AIChat Enabled” option in Brave policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Brave/Chromium enterprise policy; only when Brave is installed and policy is supported.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy`

## Referințe / References

- https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy
