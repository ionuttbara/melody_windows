# a string list which it has listed features to be disabled.

$flist = @("TFTP", "TIFFIFilter", "Containers", "MediaPlayback", "SimpleTCP", "WorkFolders-Client", "Client-ProjFS", "MicrosoftWindowsPowerShellV2", "MicrosoftWindowsPowerShellV2Root", "TelnetClient", "SearchEngine-Client-Package", "Printing-XPSServices-Features", "Windows-Defender-Default-Definitions", "Printing-PrintToPDFServices-Features","DirectoryServices-ADAM-Client","SearchEngine-Client-Package","SmbDirect","MSRDC-Infrastructure","Printing-Foundation-Features","Printing-Foundation-InternetPrinting-Client","Microsoft-RemoteDesktopConnection")

foreach ($feature in $flist) {
    if ((Get-WindowsOptionalFeature -Online -FeatureName $feature).State -eq 'Enabled') {
        Write-Output "Disabling feature $feature"
        Disable-WindowsOptionalFeature -Online -FeatureName $feature -NoRestart
    }
}
