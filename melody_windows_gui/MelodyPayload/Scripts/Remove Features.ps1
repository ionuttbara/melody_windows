# Carefully scoped and opt-in feature changes. No -Remove or OS servicing payload deletion.
$ErrorActionPreference = 'Stop'
if (-not (Get-Command Get-WindowsOptionalFeature -ErrorAction SilentlyContinue)) { throw 'DISM cmdlets are not available.' }
$available = @(Get-WindowsOptionalFeature -Online)
$target = @('TFTP','TelnetClient','SimpleTCP')
if (-not @($available | Where-Object { $_.FeatureName -in $target -and $_.State -eq 'Enabled' }).Count) { throw 'None of the approved optional features is enabled.' }
foreach ($name in $target) {
    $feature = $available | Where-Object { $_.FeatureName -eq $name } | Select-Object -First 1
    if (-not $feature) { Write-Host "Skip unavailable feature: $name"; continue }
    if ($feature.State -eq 'Enabled') { Disable-WindowsOptionalFeature -Online -FeatureName $name -NoRestart -ErrorAction Stop }
}
