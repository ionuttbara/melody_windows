$ErrorActionPreference = 'Stop'
$build = [Environment]::OSVersion.Version.Build
if ($build -lt 15063) { throw 'Service-host process splitting was introduced in Windows 10 1703 (build 15063).' }
$memory = (Get-WmiObject Win32_OperatingSystem).TotalVisibleMemorySize
if ($memory -le 0) { throw 'Physical RAM could not be detected.' }
# This is a system-wide advanced option; do not change per-service isolation exemptions.
$threshold = [math]::Min([long]$memory + 1024000L, [long][uint32]::MaxValue)
# Prevent redundant writes when the target threshold is already active.
$existing = Get-ItemProperty -Path 'HKLM:\SYSTEM\CurrentControlSet\Control' -Name 'SvcHostSplitThresholdInKB' -ErrorAction SilentlyContinue
if ($existing -and [uint32]$existing.SvcHostSplitThresholdInKB -eq [uint32]$threshold) { throw 'Already configured: split threshold is unchanged.' }
Set-ItemProperty -Path 'HKLM:\SYSTEM\CurrentControlSet\Control' -Name 'SvcHostSplitThresholdInKB' -Value ([int64]$threshold) -Type DWord
Write-Host ('SvcHostSplitThresholdInKB = ' + $threshold)
