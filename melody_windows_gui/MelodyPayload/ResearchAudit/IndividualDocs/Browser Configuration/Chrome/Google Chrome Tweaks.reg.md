# Browser Configuration/Chrome/Google Chrome Tweaks.reg

> Final bilingual Registry dossier / Fișă Registry bilingvă finală. Compatibility, execution verdict and real-machine testing are tracked separately.

## Proveniență / Provenance

- **Current `.reg` SHA-256:** `1a8aaa875eac0e9d585b8e81e06044a05a6caa5ec2e8db258e0c3f5cfe259dc6`
- **Recipe verdict / verdict rețetă:** `CONDITIONAL`
- **Windows container / interval Windows:** `7600+`
- **Runtime prerequisite / condiție runtime:** `browser-chrome`
- **Value/operation descriptions / operații:** 174
- **Tested on real Windows / testat pe Windows real:** not recorded by this audit / neînregistrat de acest audit

## Operații / Operations

### L4 · SET-VALUE · `DefaultSearchProviderEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Default Search Provider Enabled” în politicile Google Chrome la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Search Provider Enabled” option in Google Chrome policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L5 · SET-VALUE · `DefaultSearchProviderImageURLPostParams`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `"content={google:imageThumbnail},url={google:imageURL},sbisrc={google:imageSearchSource}"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Default Search Provider Image URLPost Params” în politicile Google Chrome la content={google:imageThumbnail},url={google:imageURL},sbisrc={google:imageSearchSource} (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Search Provider Image URLPost Params” option in Google Chrome policies to content={google:imageThumbnail},url={google:imageURL},sbisrc={google:imageSearchSource} (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L6 · SET-VALUE · `DefaultSearchProviderKeyword`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `"googl"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Default Search Provider Keyword” în politicile Google Chrome la googl (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Search Provider Keyword” option in Google Chrome policies to googl (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L7 · SET-VALUE · `DefaultSearchProviderName`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `"Google"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Default Search Provider Name” în politicile Google Chrome la Google (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Search Provider Name” option in Google Chrome policies to Google (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L8 · SET-VALUE · `DefaultSearchProviderSuggestURL`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `"{google:baseURL}complete/search?output=chrome&q={searchTerms}"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Default Search Provider Suggest URL” în politicile Google Chrome la {google:baseURL}complete/search?output=chrome&q={searchTerms} (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Search Provider Suggest URL” option in Google Chrome policies to {google:baseURL}complete/search?output=chrome&q={searchTerms} (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L9 · SET-VALUE · `DefaultSearchProviderSearchURLPostParams`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `"q={searchTerms},ie=utf-8,oe=utf-8"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Default Search Provider Search URLPost Params” în politicile Google Chrome la q={searchTerms},ie=utf-8,oe=utf-8 (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Search Provider Search URLPost Params” option in Google Chrome policies to q={searchTerms},ie=utf-8,oe=utf-8 (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L10 · SET-VALUE · `DefaultSearchProviderSearchURL`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `"{google:baseURL}search?q={searchTerms}&{google:RLZ}{google:originalQueryForSuggestion}{google:assistedQueryStats}{google:searchFieldtrialParameter}{google:searchClient}{google:sourceId}ie={inputEncoding}"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Default Search Provider Search URL” în politicile Google Chrome la {google:baseURL}search?q={searchTerms}&{google:RLZ}{google:originalQueryForSuggestion}{google:assistedQueryStats}{google:searchFieldtrialParameter}{google:searchClient}{google:sourceId}ie={inputEncoding} (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Search Provider Search URL” option in Google Chrome policies to {google:baseURL}search?q={searchTerms}&{google:RLZ}{google:originalQueryForSuggestion}{google:assistedQueryStats}{google:searchFieldtrialParameter}{google:searchClient}{google:sourceId}ie={inputEncoding} (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L11 · SET-VALUE · `DefaultSearchProviderSuggestURLPostParams`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `"q={searchTerms},ie=utf-8,oe=utf-8"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Default Search Provider Suggest URLPost Params” în politicile Google Chrome la q={searchTerms},ie=utf-8,oe=utf-8 (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Search Provider Suggest URLPost Params” option in Google Chrome policies to q={searchTerms},ie=utf-8,oe=utf-8 (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L12 · SET-VALUE · `HelpMeWriteSettings`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Help Me Write Settings” în politicile Google Chrome la 2 (0x00000002) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Help Me Write Settings” option in Google Chrome policies to 2 (0x00000002) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L13 · SET-VALUE · `LensRegionSearchEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Lens Region Search Enabled” în politicile Google Chrome la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Lens Region Search Enabled” option in Google Chrome policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L14 · SET-VALUE · `LensOverlaySettings`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Lens Overlay Settings” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Lens Overlay Settings” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L15 · SET-VALUE · `HistorySearchSettings`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „History Search Settings” în politicile Google Chrome la 2 (0x00000002) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “History Search Settings” option in Google Chrome policies to 2 (0x00000002) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L16 · SET-VALUE · `TabOrganizerSettings`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Tab Organizer Settings” în politicile Google Chrome la 2 (0x00000002) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Tab Organizer Settings” option in Google Chrome policies to 2 (0x00000002) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L17 · SET-VALUE · `EnableMediaRouter`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Enable Media Router” în politicile Google Chrome la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Enable Media Router” option in Google Chrome policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L18 · SET-VALUE · `GenAiDefaultSettings`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Gen Ai Default Settings” în politicile Google Chrome la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Gen Ai Default Settings” option in Google Chrome policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L19 · SET-VALUE · `HelpMeWriteSettings`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Help Me Write Settings” în politicile Google Chrome la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Help Me Write Settings” option in Google Chrome policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L20 · SET-VALUE · `CreateThemesSettings`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Create Themes Settings” în politicile Google Chrome la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Create Themes Settings” option in Google Chrome policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L21 · SET-VALUE · `HistorySearchSettings`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „History Search Settings” în politicile Google Chrome la 2 (0x00000002) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “History Search Settings” option in Google Chrome policies to 2 (0x00000002) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L22 · SET-VALUE · `DevToolsGenAiSettings`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Dev Tools Gen Ai Settings” în politicile Google Chrome la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Dev Tools Gen Ai Settings” option in Google Chrome policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L23 · SET-VALUE · `TabCompareSettings`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Tab Compare Settings” în politicile Google Chrome la 2 (0x00000002) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Tab Compare Settings” option in Google Chrome policies to 2 (0x00000002) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L24 · SET-VALUE · `GenAILocalFoundationalModelSettings`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Gen AILocal Foundational Model Settings” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Gen AILocal Foundational Model Settings” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L25 · SET-VALUE · `MediaRouterCastAllowAllIPs`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Media Router Cast Allow All IPs” în politicile Google Chrome la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Media Router Cast Allow All IPs” option in Google Chrome policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L26 · SET-VALUE · `ShowCastIconInToolbar`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Show Cast Icon In Toolbar” în politicile Google Chrome la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Show Cast Icon In Toolbar” option in Google Chrome policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L27 · SET-VALUE · `ShowCastSessionsStartedByOtherDevices`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Show Cast Sessions Started By Other Devices” în politicile Google Chrome la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Show Cast Sessions Started By Other Devices” option in Google Chrome policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L28 · SET-VALUE · `AccessCodeCastEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Access Code Cast Enabled” în politicile Google Chrome la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Access Code Cast Enabled” option in Google Chrome policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L29 · SET-VALUE · `CloudAPAuthEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Cloud APAuth Enabled” în politicile Google Chrome la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Cloud APAuth Enabled” option in Google Chrome policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L30 · SET-VALUE · `CompressionDictionaryTransportEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Compression Dictionary Transport Enabled” în politicile Google Chrome la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Compression Dictionary Transport Enabled” option in Google Chrome policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L31 · SET-VALUE · `AccessControlAllowMethodsInCORSPreflightSpecConformant`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Access Control Allow Methods In CORSPreflight Spec Conformant” în politicile Google Chrome la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Access Control Allow Methods In CORSPreflight Spec Conformant” option in Google Chrome policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L32 · SET-VALUE · `IPv6ReachabilityOverrideEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „IPv6Reachability Override Enabled” în politicile Google Chrome la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “IPv6Reachability Override Enabled” option in Google Chrome policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L33 · SET-VALUE · `ZstdContentEncodingEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Zstd Content Encoding Enabled” în politicile Google Chrome la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Zstd Content Encoding Enabled” option in Google Chrome policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L34 · SET-VALUE · `DeletingUndecryptablePasswordsEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Deleting Undecryptable Passwords Enabled” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Deleting Undecryptable Passwords Enabled” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L35 · SET-VALUE · `PasswordLeakDetectionEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Password Leak Detection Enabled” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Password Leak Detection Enabled” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L36 · SET-VALUE · `PrintHeaderFooter`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Print Header Footer” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Print Header Footer” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L37 · SET-VALUE · `PrintingEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Printing Enabled” în politicile Google Chrome la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Printing Enabled” option in Google Chrome policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L38 · SET-VALUE · `PrintingLPACSandboxEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Printing LPACSandbox Enabled” în politicile Google Chrome la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Printing LPACSandbox Enabled” option in Google Chrome policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L39 · SET-VALUE · `PrivacySandboxAdMeasurementEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Privacy Sandbox Ad Measurement Enabled” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Privacy Sandbox Ad Measurement Enabled” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L40 · SET-VALUE · `PrivacySandboxAdTopicsEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Privacy Sandbox Ad Topics Enabled” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Privacy Sandbox Ad Topics Enabled” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L41 · SET-VALUE · `PrivacySandboxPromptEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Privacy Sandbox Prompt Enabled” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Privacy Sandbox Prompt Enabled” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L42 · SET-VALUE · `PrivacySandboxSiteEnabledAdsEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Privacy Sandbox Site Enabled Ads Enabled” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Privacy Sandbox Site Enabled Ads Enabled” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L43 · SET-VALUE · `ExtensionManifestV2Availability`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Extension Manifest V2Availability” în politicile Google Chrome la 2 (0x00000002) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Extension Manifest V2Availability” option in Google Chrome policies to 2 (0x00000002) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L44 · SET-VALUE · `ExtensionUnpublishedAvailability`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Extension Unpublished Availability” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Extension Unpublished Availability” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L45 · SET-VALUE · `CloudProfileReportingEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Cloud Profile Reporting Enabled” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Cloud Profile Reporting Enabled” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L46 · SET-VALUE · `CreateThemesSettings`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Create Themes Settings” în politicile Google Chrome la 2 (0x00000002) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Create Themes Settings” option in Google Chrome policies to 2 (0x00000002) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L47 · SET-VALUE · `DevToolsGenAiSettings`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Dev Tools Gen Ai Settings” în politicile Google Chrome la 2 (0x00000002) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Dev Tools Gen Ai Settings” option in Google Chrome policies to 2 (0x00000002) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L48 · SET-VALUE · `GenAILocalFoundationalModelSettings`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Gen AILocal Foundational Model Settings” în politicile Google Chrome la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Gen AILocal Foundational Model Settings” option in Google Chrome policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L49 · SET-VALUE · `WPADQuickCheckEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „WPADQuick Check Enabled” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “WPADQuick Check Enabled” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L50 · SET-VALUE · `WebRtcEventLogCollectionAllowed`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Web Rtc Event Log Collection Allowed” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Web Rtc Event Log Collection Allowed” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L51 · SET-VALUE · `WebRtcIPHandling`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `"default"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Web Rtc IPHandling” în politicile Google Chrome la default (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Web Rtc IPHandling” option in Google Chrome policies to default (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L52 · SET-VALUE · `WebRtcTextLogCollectionAllowed`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Web Rtc Text Log Collection Allowed” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Web Rtc Text Log Collection Allowed” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L53 · SET-VALUE · `DefaultLocalFontsSetting`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Default Local Fonts Setting” în politicile Google Chrome la 3 (0x00000003) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Local Fonts Setting” option in Google Chrome policies to 3 (0x00000003) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L54 · SET-VALUE · `DefaultInsecureContentSetting`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Default Insecure Content Setting” în politicile Google Chrome la 3 (0x00000003) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Insecure Content Setting” option in Google Chrome policies to 3 (0x00000003) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L55 · SET-VALUE · `PrivateNetworkAccessRestrictionsEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Private Network Access Restrictions Enabled” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Private Network Access Restrictions Enabled” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L56 · SET-VALUE · `AdvancedProtectionDeepScanningEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Advanced Protection Deep Scanning Enabled” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Advanced Protection Deep Scanning Enabled” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L57 · SET-VALUE · `DefaultPluginsSetting`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Default Plugins Setting” în politicile Google Chrome la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Plugins Setting” option in Google Chrome policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L58 · SET-VALUE · `DisableSSLRecordSplitting`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Disable SSLRecord Splitting” în politicile Google Chrome la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Disable SSLRecord Splitting” option in Google Chrome policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L59 · SET-VALUE · `DnsPrefetchingEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Dns Prefetching Enabled” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Dns Prefetching Enabled” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L60 · SET-VALUE · `OptimizationGuideFetchingEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Optimization Guide Fetching Enabled” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Optimization Guide Fetching Enabled” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L61 · SET-VALUE · `SafeBrowsingSurveysEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Safe Browsing Surveys Enabled” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Safe Browsing Surveys Enabled” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L62 · SET-VALUE · `SafeBrowsingProxiedRealTimeChecksAllowed`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Safe Browsing Proxied Real Time Checks Allowed” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Safe Browsing Proxied Real Time Checks Allowed” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L63 · SET-VALUE · `SafeBrowsingExtendedReportingEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Safe Browsing Extended Reporting Enabled” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Safe Browsing Extended Reporting Enabled” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L64 · SET-VALUE · `SafeBrowsingProtectionLevel`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Safe Browsing Protection Level” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Safe Browsing Protection Level” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L65 · SET-VALUE · `DisableSafeBrowsingProceedAnyway`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Disable Safe Browsing Proceed Anyway” în politicile Google Chrome la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Disable Safe Browsing Proceed Anyway” option in Google Chrome policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L66 · SET-VALUE · `PasswordProtectionWarningTrigger`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Password Protection Warning Trigger” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Password Protection Warning Trigger” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L67 · SET-VALUE · `SafeBrowsingDeepScanningEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Safe Browsing Deep Scanning Enabled” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Safe Browsing Deep Scanning Enabled” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L68 · SET-VALUE · `HomepageIsNewTabPage`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Homepage Is New Tab Page” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Homepage Is New Tab Page” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L69 · SET-VALUE · `HomepageLocation`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `"google.com"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Homepage Location” în politicile Google Chrome la google.com (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Homepage Location” option in Google Chrome policies to google.com (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L70 · SET-VALUE · `NewTabPageLocation`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `"google.com"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „New Tab Page Location” în politicile Google Chrome la google.com (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “New Tab Page Location” option in Google Chrome policies to google.com (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L71 · SET-VALUE · `RestoreOnStartup`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Restore On Startup” în politicile Google Chrome la 3 (0x00000003) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Restore On Startup” option in Google Chrome policies to 3 (0x00000003) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L72 · SET-VALUE · `ShowHomeButton`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Show Home Button” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Show Home Button” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L73 · SET-VALUE · `AbusiveExperienceInterventionEnforce`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Abusive Experience Intervention Enforce” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Abusive Experience Intervention Enforce” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L74 · SET-VALUE · `AccessibilityImageLabelsEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Accessibility Image Labels Enabled” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Accessibility Image Labels Enabled” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L75 · SET-VALUE · `AdditionalDnsQueryTypesEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Additional Dns Query Types Enabled” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Additional Dns Query Types Enabled” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L76 · SET-VALUE · `AdsSettingForIntrusiveAdsSites`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Ads Setting For Intrusive Ads Sites” în politicile Google Chrome la 2 (0x00000002) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Ads Setting For Intrusive Ads Sites” option in Google Chrome policies to 2 (0x00000002) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L77 · SET-VALUE · `AdvancedProtectionAllowed`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Advanced Protection Allowed” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Advanced Protection Allowed” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L78 · SET-VALUE · `AllowBackForwardCacheForCacheControlNoStorePageEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Allow Back Forward Cache For Cache Control No Store Page Enabled” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Allow Back Forward Cache For Cache Control No Store Page Enabled” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L79 · SET-VALUE · `AllowDinosaurEasterEgg`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Allow Dinosaur Easter Egg” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Allow Dinosaur Easter Egg” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L80 · SET-VALUE · `AllowFileSelectionDialogs`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Allow File Selection Dialogs” în politicile Google Chrome la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Allow File Selection Dialogs” option in Google Chrome policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L81 · SET-VALUE · `AlternateErrorPagesEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Alternate Error Pages Enabled” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Alternate Error Pages Enabled” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L82 · SET-VALUE · `ApplicationBoundEncryptionEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Application Bound Encryption Enabled” în politicile Google Chrome la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Application Bound Encryption Enabled” option in Google Chrome policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L83 · SET-VALUE · `AudioCaptureAllowed`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Audio Capture Allowed” în politicile Google Chrome la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Audio Capture Allowed” option in Google Chrome policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L84 · SET-VALUE · `AudioProcessHighPriorityEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Audio Process High Priority Enabled” în politicile Google Chrome la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Audio Process High Priority Enabled” option in Google Chrome policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L85 · SET-VALUE · `AudioSandboxEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Audio Sandbox Enabled” în politicile Google Chrome la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Audio Sandbox Enabled” option in Google Chrome policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L86 · SET-VALUE · `AutoplayAllowed`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Autoplay Allowed” în politicile Google Chrome la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Autoplay Allowed” option in Google Chrome policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L87 · SET-VALUE · `BackgroundModeEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Background Mode Enabled” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Background Mode Enabled” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L88 · SET-VALUE · `BatterySaverModeAvailability`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Battery Saver Mode Availability” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Battery Saver Mode Availability” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L89 · SET-VALUE · `BrowserGuestModeEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Browser Guest Mode Enabled” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Browser Guest Mode Enabled” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L90 · SET-VALUE · `BrowserGuestModeEnforced`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Browser Guest Mode Enforced” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Browser Guest Mode Enforced” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L91 · SET-VALUE · `BrowserLabsEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Browser Labs Enabled” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Browser Labs Enabled” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L92 · SET-VALUE · `BrowserNetworkTimeQueriesEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Browser Network Time Queries Enabled” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Browser Network Time Queries Enabled” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L93 · SET-VALUE · `BrowserSignin`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Browser Signin” în politicile Google Chrome la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Browser Signin” option in Google Chrome policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L94 · SET-VALUE · `BuiltInDnsClientEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Built In Dns Client Enabled” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Built In Dns Client Enabled” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L95 · SET-VALUE · `CSSCustomStateDeprecatedSyntaxEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „CSSCustom State Deprecated Syntax Enabled” în politicile Google Chrome la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “CSSCustom State Deprecated Syntax Enabled” option in Google Chrome policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L96 · SET-VALUE · `CORSNonWildcardRequestHeadersSupport`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „CORSNon Wildcard Request Headers Support” în politicile Google Chrome la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “CORSNon Wildcard Request Headers Support” option in Google Chrome policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L97 · SET-VALUE · `ChromeForTestingAllowed`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Chrome For Testing Allowed” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Chrome For Testing Allowed” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L98 · SET-VALUE · `ChromeVariations`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Chrome Variations” în politicile Google Chrome la 2 (0x00000002) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Chrome Variations” option in Google Chrome policies to 2 (0x00000002) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L99 · SET-VALUE · `ClickToCallEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Click To Call Enabled” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Click To Call Enabled” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L100 · SET-VALUE · `CloudManagementEnrollmentMandatory`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Cloud Management Enrollment Mandatory” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Cloud Management Enrollment Mandatory” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L101 · SET-VALUE · `CloudPolicyOverridesPlatformPolicy`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Cloud Policy Overrides Platform Policy” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Cloud Policy Overrides Platform Policy” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L102 · SET-VALUE · `CloudUserPolicyMerge`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Cloud User Policy Merge” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Cloud User Policy Merge” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L103 · SET-VALUE · `CloudUserPolicyOverridesCloudMachinePolicy`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Cloud User Policy Overrides Cloud Machine Policy” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Cloud User Policy Overrides Cloud Machine Policy” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L104 · SET-VALUE · `CommandLineFlagSecurityWarningsEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Command Line Flag Security Warnings Enabled” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Command Line Flag Security Warnings Enabled” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L105 · SET-VALUE · `ComponentUpdatesEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Component Updates Enabled” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Component Updates Enabled” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L106 · SET-VALUE · `DNSInterceptionChecksEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „DNSInterception Checks Enabled” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “DNSInterception Checks Enabled” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L107 · SET-VALUE · `DefaultBrowserSettingEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Default Browser Setting Enabled” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Browser Setting Enabled” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L108 · SET-VALUE · `DesktopSharingHubEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Desktop Sharing Hub Enabled” în politicile Google Chrome la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Desktop Sharing Hub Enabled” option in Google Chrome policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L109 · SET-VALUE · `DomainReliabilityAllowed`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Domain Reliability Allowed” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Domain Reliability Allowed” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L110 · SET-VALUE · `DownloadRestrictions`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Download Restrictions” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Download Restrictions” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L111 · SET-VALUE · `DynamicCodeSettings`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Dynamic Code Settings” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Dynamic Code Settings” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L112 · SET-VALUE · `FeedbackSurveysEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Feedback Surveys Enabled” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Feedback Surveys Enabled” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L113 · SET-VALUE · `ForceGoogleSafeSearch`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Force Google Safe Search” în politicile Google Chrome la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Force Google Safe Search” option in Google Chrome policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L114 · SET-VALUE · `ForcePermissionPolicyUnloadDefaultEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Force Permission Policy Unload Default Enabled” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Force Permission Policy Unload Default Enabled” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L115 · SET-VALUE · `ForceYouTubeRestrict`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Force You Tube Restrict” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Force You Tube Restrict” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L116 · SET-VALUE · `FullscreenAllowed`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Fullscreen Allowed” în politicile Google Chrome la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Fullscreen Allowed” option in Google Chrome policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L117 · SET-VALUE · `GloballyScopeHTTPAuthCacheEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Globally Scope HTTPAuth Cache Enabled” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Globally Scope HTTPAuth Cache Enabled” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L118 · SET-VALUE · `GoogleSearchSidePanelEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Google Search Side Panel Enabled” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Google Search Side Panel Enabled” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L119 · SET-VALUE · `HardwareAccelerationModeEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Hardware Acceleration Mode Enabled” în politicile Google Chrome la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Hardware Acceleration Mode Enabled” option in Google Chrome policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L120 · SET-VALUE · `HeadlessMode`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Headless Mode” în politicile Google Chrome la 2 (0x00000002) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Headless Mode” option in Google Chrome policies to 2 (0x00000002) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L121 · SET-VALUE · `HideWebStoreIcon`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Hide Web Store Icon” în politicile Google Chrome la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Hide Web Store Icon” option in Google Chrome policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L122 · SET-VALUE · `HighEfficiencyModeEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „High Efficiency Mode Enabled” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “High Efficiency Mode Enabled” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L123 · SET-VALUE · `HistoryClustersVisible`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „History Clusters Visible” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “History Clusters Visible” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L124 · SET-VALUE · `HttpsUpgradesEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Https Upgrades Enabled” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Https Upgrades Enabled” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L125 · SET-VALUE · `IntensiveWakeUpThrottlingEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Intensive Wake Up Throttling Enabled” în politicile Google Chrome la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Intensive Wake Up Throttling Enabled” option in Google Chrome policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L126 · SET-VALUE · `IntranetRedirectBehavior`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Intranet Redirect Behavior” în politicile Google Chrome la 2 (0x00000002) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Intranet Redirect Behavior” option in Google Chrome policies to 2 (0x00000002) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L127 · SET-VALUE · `KeyboardFocusableScrollersEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Keyboard Focusable Scrollers Enabled” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Keyboard Focusable Scrollers Enabled” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L128 · SET-VALUE · `LensDesktopNTPSearchEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Lens Desktop NTPSearch Enabled” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Lens Desktop NTPSearch Enabled” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L129 · SET-VALUE · `LensRegionSearchEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Lens Region Search Enabled” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Lens Region Search Enabled” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L130 · SET-VALUE · `MediaRecommendationsEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Media Recommendations Enabled” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Media Recommendations Enabled” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L131 · SET-VALUE · `MetricsReportingEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Metrics Reporting Enabled” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Metrics Reporting Enabled” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L132 · SET-VALUE · `NTPCardsVisible`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „NTPCards Visible” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “NTPCards Visible” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L133 · SET-VALUE · `NetworkPredictionOptions`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Network Prediction Options” în politicile Google Chrome la 2 (0x00000002) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Network Prediction Options” option in Google Chrome policies to 2 (0x00000002) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L134 · SET-VALUE · `NetworkServiceSandboxEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Network Service Sandbox Enabled” în politicile Google Chrome la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Network Service Sandbox Enabled” option in Google Chrome policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L135 · SET-VALUE · `PaymentMethodQueryEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Payment Method Query Enabled” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Payment Method Query Enabled” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L136 · SET-VALUE · `PrefixedVideoFullscreenApiAvailability`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `"enabled"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „Prefixed Video Fullscreen Api Availability” în politicile Google Chrome la enabled (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Prefixed Video Fullscreen Api Availability” option in Google Chrome policies to enabled (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L137 · SET-VALUE · `PromotionalTabsEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Promotional Tabs Enabled” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Promotional Tabs Enabled” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L138 · SET-VALUE · `PromotionsEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Promotions Enabled” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Promotions Enabled” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L139 · SET-VALUE · `QRCodeGeneratorEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „QRCode Generator Enabled” în politicile Google Chrome la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “QRCode Generator Enabled” option in Google Chrome policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L140 · SET-VALUE · `QuicAllowed`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Quic Allowed” în politicile Google Chrome la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Quic Allowed” option in Google Chrome policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L141 · SET-VALUE · `RendererAppContainerEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Renderer App Container Enabled” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Renderer App Container Enabled” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L142 · SET-VALUE · `RequireOnlineRevocationChecksForLocalAnchors`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Require Online Revocation Checks For Local Anchors” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Require Online Revocation Checks For Local Anchors” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L143 · SET-VALUE · `RoamingProfileSupportEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Roaming Profile Support Enabled” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Roaming Profile Support Enabled” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L144 · SET-VALUE · `SafeBrowsingForTrustedSourcesEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Safe Browsing For Trusted Sources Enabled” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Safe Browsing For Trusted Sources Enabled” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L145 · SET-VALUE · `SandboxExternalProtocolBlocked`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Sandbox External Protocol Blocked” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Sandbox External Protocol Blocked” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L146 · SET-VALUE · `SafeSitesFilterBehavior`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Safe Sites Filter Behavior” în politicile Google Chrome la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Safe Sites Filter Behavior” option in Google Chrome policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L147 · SET-VALUE · `ScrollToTextFragmentEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Scroll To Text Fragment Enabled” în politicile Google Chrome la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Scroll To Text Fragment Enabled” option in Google Chrome policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L148 · SET-VALUE · `SharedClipboardEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Shared Clipboard Enabled” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Shared Clipboard Enabled” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L149 · SET-VALUE · `ShoppingListEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Shopping List Enabled” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Shopping List Enabled” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L150 · SET-VALUE · `ShowFullUrlsInAddressBar`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Show Full Urls In Address Bar” în politicile Google Chrome la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Show Full Urls In Address Bar” option in Google Chrome policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L151 · SET-VALUE · `SideSearchEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Side Search Enabled” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Side Search Enabled” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L152 · SET-VALUE · `SpellCheckServiceEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Spell Check Service Enabled” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Spell Check Service Enabled” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L153 · SET-VALUE · `SpellcheckEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Spellcheck Enabled” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Spellcheck Enabled” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L154 · SET-VALUE · `StandardizedBrowserZoomEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Standardized Browser Zoom Enabled” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Standardized Browser Zoom Enabled” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L155 · SET-VALUE · `SuppressUnsupportedOSWarning`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Suppress Unsupported OSWarning” în politicile Google Chrome la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Suppress Unsupported OSWarning” option in Google Chrome policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L156 · SET-VALUE · `TaskManagerEndProcessEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Task Manager End Process Enabled” în politicile Google Chrome la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Task Manager End Process Enabled” option in Google Chrome policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L157 · SET-VALUE · `ToolbarAvatarLabelSettings`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Toolbar Avatar Label Settings” în politicile Google Chrome la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Toolbar Avatar Label Settings” option in Google Chrome policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L158 · SET-VALUE · `TranslateEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Translate Enabled” în politicile Google Chrome la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Translate Enabled” option in Google Chrome policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L159 · SET-VALUE · `UrlKeyedAnonymizedDataCollectionEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Url Keyed Anonymized Data Collection Enabled” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Url Keyed Anonymized Data Collection Enabled” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L160 · SET-VALUE · `UserAgentReduction`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „User Agent Reduction” în politicile Google Chrome la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “User Agent Reduction” option in Google Chrome policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L161 · SET-VALUE · `UserFeedbackAllowed`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „User Feedback Allowed” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “User Feedback Allowed” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L162 · SET-VALUE · `SafeBrowsingEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Safe Browsing Enabled” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Safe Browsing Enabled” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L163 · SET-VALUE · `RendererCodeIntegrityEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Renderer Code Integrity Enabled” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Renderer Code Integrity Enabled” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L164 · SET-VALUE · `InsecureFormsWarningsEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Insecure Forms Warnings Enabled” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Insecure Forms Warnings Enabled” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L165 · SET-VALUE · `DefaultWindowPlacementSetting`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Default Window Placement Setting” în politicile Google Chrome la 3 (0x00000003) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Window Placement Setting” option in Google Chrome policies to 3 (0x00000003) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L166 · SET-VALUE · `UiAutomationProviderEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000000`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Ui Automation Provider Enabled” în politicile Google Chrome la 0 (0x00000000) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Ui Automation Provider Enabled” option in Google Chrome policies to 0 (0x00000000) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L167 · SET-VALUE · `ScreenCaptureAllowed`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Screen Capture Allowed” în politicile Google Chrome la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Screen Capture Allowed” option in Google Chrome policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L168 · SET-VALUE · `DataUrlInSvgUseEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Data Url In Svg Use Enabled” în politicile Google Chrome la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Data Url In Svg Use Enabled” option in Google Chrome policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L169 · SET-VALUE · `DefaultGeolocationSetting`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000002`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Default Geolocation Setting” în politicile Google Chrome la 2 (0x00000002) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Geolocation Setting” option in Google Chrome policies to 2 (0x00000002) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L170 · SET-VALUE · `DefaultWindowManagementSetting`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Default Window Management Setting” în politicile Google Chrome la 3 (0x00000003) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Window Management Setting” option in Google Chrome policies to 3 (0x00000003) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L171 · SET-VALUE · `DefaultWebUsbGuardSetting`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Default Web Usb Guard Setting” în politicile Google Chrome la 3 (0x00000003) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Web Usb Guard Setting” option in Google Chrome policies to 3 (0x00000003) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L172 · SET-VALUE · `DefaultWebHidGuardSetting`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Default Web Hid Guard Setting” în politicile Google Chrome la 3 (0x00000003) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Web Hid Guard Setting” option in Google Chrome policies to 3 (0x00000003) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L173 · SET-VALUE · `DefaultWebBluetoothGuardSetting`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Default Web Bluetooth Guard Setting” în politicile Google Chrome la 3 (0x00000003) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Web Bluetooth Guard Setting” option in Google Chrome policies to 3 (0x00000003) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L174 · SET-VALUE · `DefaultSerialGuardSetting`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Default Serial Guard Setting” în politicile Google Chrome la 3 (0x00000003) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Serial Guard Setting” option in Google Chrome policies to 3 (0x00000003) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L175 · SET-VALUE · `DefaultNotificationsSetting`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000003`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Default Notifications Setting” în politicile Google Chrome la 3 (0x00000003) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Default Notifications Setting” option in Google Chrome policies to 3 (0x00000003) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L176 · SET-VALUE · `WindowOcclusionEnabled`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome`
- **Raw .reg data:** `dword:00000001`
- **Type / tip:** `REG_DWORD`
- **Ce face / RO:** Configurează opțiunea „Window Occlusion Enabled” în politicile Google Chrome la 1 (0x00000001) (REG_DWORD). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “Window Occlusion Enabled” option in Google Chrome policies to 1 (0x00000001) (REG_DWORD). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

### L180 · SET-VALUE · `1`

- **Registry key:** `HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome\ClearBrowsingDataOnExitList`
- **Raw .reg data:** `"cached_images_and_files"`
- **Type / tip:** `REG_SZ`
- **Ce face / RO:** Configurează opțiunea „1” în politicile Google Chrome la cached_images_and_files (REG_SZ). Melody modifică această țintă numai dacă cheia și, pentru operațiile pe valori, valoarea exactă există deja pe sistemul detectat; nu creează o țintă necunoscută.
- **What it configures / EN:** Sets the “1” option in Google Chrome policies to cached_images_and_files (REG_SZ). Melody changes this target only when the key and, for value operations, the exact value already exists on the detected system; it does not create an unknown target.
- **Final verdict / verdict final:** `CONDITIONAL`
- **Certitudine / Evidence:** Chrome enterprise policy; only when Chrome is installed and the policy is supported by that browser version.
- **OS support / versiuni:** `7600+`
- **Source / sursă:** `https://chromeenterprise.google/policies/`

## Referințe / References

- https://chromeenterprise.google/policies/
