# RemoveSecHealthApp.ps1

- **Status:** UNAVAILABLE; destructive source script is now a hard STOP.
- **Original SHA-256:** `b29d37c2d89b1d20ae79863e55a8bd41ee430a6115d695435cf3f5976dc35d32` (exact retained bytes)
- **Safety reason:** Deletes/deprovisions the Windows Security UI app for multiple users and mutates AppX protection policy. Not approved.

## Original statements (inspection only)

- Line 1: `$remove_appx = @("SecHealthUI"); $provisioned = get-appxprovisionedpackage -online; $appxpackage = get-appxpackage -allusers; $eol = @()` — **UNAVAILABLE**
- Line 2: `$store = 'HKLM:\SOFTWARE\Microsoft\Windows\CurrentVersion\Appx\AppxAllUserStore'` — **UNAVAILABLE**
- Line 3: `$users = @('S-1-5-18'); if (test-path $store) {$users += $((dir $store -ea 0 |where {$_ -like '*S-1-5-21*'}).PSChildName)}` — **UNAVAILABLE**
- Line 4: `foreach ($choice in $remove_appx) { if ('' -eq $choice.Trim()) {continue}` — **UNAVAILABLE**
- Line 5: `foreach ($appx in $($provisioned |where {$_.PackageName -like "*$choice*"})) {` — **UNAVAILABLE**
- Line 6: `$next = !1; foreach ($no in $skip) {if ($appx.PackageName -like "*$no*") {$next = !0}} ; if ($next) {continue}` — **UNAVAILABLE**
- Line 7: `$PackageName = $appx.PackageName; $PackageFamilyName = ($appxpackage |where {$_.Name -eq $appx.DisplayName}).PackageFamilyName` — **UNAVAILABLE**
- Line 8: `ni "$store\Deprovisioned\$PackageFamilyName" -force >''; $PackageFamilyName` — **UNAVAILABLE**
- Line 9: `foreach ($sid in $users) {ni "$store\EndOfLife\$sid\$PackageName" -force >''} ; $eol += $PackageName` — **UNAVAILABLE**
- Line 10: `dism /online /set-nonremovableapppolicy /packagefamily:$PackageFamilyName /nonremovable:0 >''` — **UNAVAILABLE**
- Line 11: `remove-appxprovisionedpackage -packagename $PackageName -online -allusers >''` — **UNAVAILABLE**
- Line 12: `}` — **UNAVAILABLE**
- Line 13: `foreach ($appx in $($appxpackage |where {$_.PackageFullName -like "*$choice*"})) {` — **UNAVAILABLE**
- Line 14: `$next = !1; foreach ($no in $skip) {if ($appx.PackageFullName -like "*$no*") {$next = !0}} ; if ($next) {continue}` — **UNAVAILABLE**
- Line 15: `$PackageFullName = $appx.PackageFullName;` — **UNAVAILABLE**
- Line 16: `ni "$store\Deprovisioned\$appx.PackageFamilyName" -force >''; $PackageFullName` — **UNAVAILABLE**
- Line 17: `foreach ($sid in $users) {ni "$store\EndOfLife\$sid\$PackageFullName" -force >''} ; $eol += $PackageFullName` — **UNAVAILABLE**
- Line 18: `dism /online /set-nonremovableapppolicy /packagefamily:$PackageFamilyName /nonremovable:0 >''` — **UNAVAILABLE**
- Line 19: `remove-appxpackage -package $PackageFullName -allusers >''` — **UNAVAILABLE**
- Line 20: `}` — **UNAVAILABLE**
- Line 21: `}` — **UNAVAILABLE**

Original: CompatibilityAudit/Original-RemoveSecHealthApp.ps1.txt

- Microsoft servicing guidance (does not validate removal): https://learn.microsoft.com/en-us/troubleshoot/windows-client/shell-experience/modern-inbox-store-apps-troubleshooting-guidance
