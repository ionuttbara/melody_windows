# Safe, opt-in subset. No device drivers, browser, PowerShell or printer removal.
$ErrorActionPreference = 'Stop'
if ([Environment]::OSVersion.Version.Build -lt 10240) { throw 'Capabilities require Windows 10 or later.' }
if (-not (Get-Command Get-WindowsCapability -ErrorAction SilentlyContinue)) { throw 'DISM capability cmdlets are unavailable.' }
$approved = @('StepsRecorder~~~~0.0.1.0', 'MathRecognizer~~~~0.0.1.0')
$installed = @(Get-WindowsCapability -Online | Where-Object { $_.State -eq 'Installed' })
if (-not @($installed | Where-Object { $_.Name -in $approved }).Count) { throw 'No approved installed capability exists on this system.' }
foreach ($name in $approved) {
    $match = @($installed | Where-Object { $_.Name -eq $name })
    if ($match.Count -eq 0) { Write-Host "Skip missing capability: $name"; continue }
    Remove-WindowsCapability -Online -Name $name -ErrorAction Stop
}
