# RegistryUnifier.ps1

- **Status:** UNAVAILABLE
- **Reason:** A combined .reg bypasses Melody file-level compatibility checks; original helper is now a hard STOP.
- **Live SHA-256:** `c5df13542067bfebc067fe4d616bfa28a77e836ee551a2b0609a75158ea6b9b7`
- **Original SHA-256:** `b59df88f1ea2fad3da03aa6bc06dae98dcc34c4c6c6e946f881d3890c8089e35`

## Exact retained original statements

- Line 2: `$sourceFolder = "../Settings"     # Modify this with your source folder path` — not approved
- Line 3: `$outputFile = "../Output.reg" # Specify the output file path` — not approved
- Line 5: `$combinedContent = @()` — not approved
- Line 6: `$combinedContent += "Windows Registry Editor Version 5.00"` — not approved
- Line 7: `$regFiles = Get-ChildItem -Path $sourceFolder -Recurse -Filter "*.reg"` — not approved
- Line 9: `foreach ($file in $regFiles) {` — not approved
- Line 10: `$content = Get-Content -Path $file.FullName` — not approved
- Line 11: `$combinedContent += "; File: $($file.FullName)"` — not approved
- Line 12: `$combinedContent += $content[1..($content.Length - 1)]` — not approved
- Line 13: `}` — not approved
- Line 14: `$combinedContent | Set-Content -Path $outputFile -Encoding UTF8` — not approved
- Line 16: `Write-Host "Combined registry file created at: $outputFile"` — not approved

## Sources

Original source preserved in CompatibilityAudit/Original-RegistryUnifier.ps1.txt
Current payload is a hard STOP.
