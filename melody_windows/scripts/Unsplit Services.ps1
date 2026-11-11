$Host.UI.RawUI.WindowTitle = "Unsplitter"
Set-Location -Path $PSScriptRoot
$os = Get-WmiObject -Class Win32_OperatingSystem
$mem = $os.TotalVisibleMemorySize
$ram = $mem + 1024000
Set-ItemProperty -Path "HKLM:\SYSTEM\CurrentControlSet\Control" -Name "SvcHostSplitThresholdInKB" -Value $ram -Type DWord