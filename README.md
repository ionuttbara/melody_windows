# WARNING: 
When you run this script it will change  A LOT of windows preferences to the liking of autor of this script, Once executing the exe, it does start, it does not ask for anything and there is NO WAY TO ROLLABACK the changes. Proceed with extreme caution. Try in VM. Extract the source and use individual files. Before to open the app, extract with WinRAR or 7-Zip and remove the unwanted tweaks/registry files. There are organized in **MelodyScript.Settings** folder.

# Melody Script
<h1 align="center">
 <img src=https://github.com/jbara2002/melody_windows/assets/76656855/58afdbe0-afee-4afc-8ec9-2f4037d7e174> </img>
</h1>

<p align="center">
  <a href="#about">About</a> •
  <a href="#installation">Installation</a> •
  <a href="#sources">Sources</a> •
  <a href="#updating">Creating own version of Melody</a> •
  <a href="#license">License</a>
</p>

---

## About

<table>
<tr>
<td>

**Melody Tool for Windows ** is a bundled app for **Windows 7/8.x/10/11** which consists of several **high-quality** *tweaks* that aim to **disable telemetry**, **optimizing windows updates**, **optimizing for gaming and better input latency**, **solve some unwanted security vulnerabilities** and **decreases** the number of loaded **annoncy elements**, thus **loading** the Windows **faster and be for better productivity**.

</td>
</tr>
</table>

## Installation

##### Installation Steps
* **[Download]** the latest version of the settings.
* After downloading them wait a bit. After settings was applied the PC will reboot.


## Components of Melody

##### Windows Operating System Optimization
> In this part i had done a research about Windows Optimization, Tweaking and i read news about Microsoft's tactics to install unwanted software and add some telemetry, keylogger into Windows.
> The resolvation will be in system configuration: 99.7% Registry and 0.03 % Batch.
> I had rework some Winaero Tweaker's , O&O Shutup 10, W10 Privacy, WinSpyDisabler and BlackBird Application.

| Applied Tweak | Description | Required Windows Version |
| ------ | ------ |------ |
| StartAllBack | Integration of StartAllBack. 3rd Party Software. Fixing Windows inconsistency in UI. | Windows 10 or newer |
| Accesibilty Tweaks| Disables Narrator annoying and Keyboard Flags | Windows 11 |
| Holographic Tweaks| Optimizes Windows Holographic App | Windows 10 and 11 |
| Certificates from Microsoft| Microsoft is removing some certificates in Windows 10 versions.| Windows 10.0 version 1803 or newer|
| Apparence Optimization (registry)| Disables transparency and animations for Current User and SYSTEM USER (disables animations in WinLogonUI.exe)| Windows 10 or newer|
|Application Priority | Changed some Windows Services and Application Priority| none |
|App Permision| Set some UWP Apps Permission| Windows 10 1909|
|AutoPlay Handlers| Open Folder automaticly when a storage device was inserted | none
|Windows Quota| Disables Windows Quota | Windows NT|
|Disable WMI KeyLogger| Disables KeyLoggers (from Blackbird), and Windows Event Logger Keylogger and Logger|Windows 10 1507 or newer|
|Disk Optization| Manipulation of filesystem for security and performance| Windows 10 1507 or newer|
|Feature Manipulation| Added some "hidden features" in Windows 10| Windows 10 2004 or newer|
|Firewall Rules| Blocks unwanted applications to connect to the Internet (Notepad, csrss.exe etc.) and adds Telemetry Rules| Windows 10 1507 or newer|
|GPU Optimization| Adds system applications to run into iGPU for better battery life in laptops|Windows 10 2004|
|Input Tweaks|Latency Optimizations,Magnectic Cursor Fixes and more|Windows 10 1507 or newer|
|Internet Speed Optimization (registry)| Change values to increase stability of Internet Connections and latency | Windows 10 1507 or newer|
|Internet Speed Optimization (command) | Sets value for Network Adapters Driver for better ping and performance. Also it modifies the values which is helping to uncrease CPU Usage in loading.|Windows 10 1507 (cubic), Windows 10 1803 or newer (experimental)
|IRQ Priority| Better device performance and latency| Windows 11|
|Keyboard Flags| Disables shortcuts to go in Accesibility (Filter Keys, Sticky Keys)|Windows 10 or newer|
|MMCSS Tweaks| Disables MMCSS Service. For better system responsive. Causes audio shuttering in Windows 10. Increase stability in Windows 11.| Windows 10 or newer|
|No more Delay/Timeouts| Make things faster. System will load menus faster. Also the startup and shutting down will be faster. |Windows 10 or newer|
|Notepad Tweaks| Adds Word Wrap and the Status bar in Notepad for current user and the SYSTEM user. | Windows 10 or newer
|Power Tweaks| Disables Throlling|Windows 10 1709 or newer|
|PowerShell Execution Policy| Changes policies running script.| Windows 10 or newer|
|Push notifications| Disables Windows Security Pushes|Windows 10 or newer|
|Remove Explorer Junk| Removes some shell bloat| Windows 11
|Resource Management| CPU & GPU Prioritise | Windows 11|
|Services Optimizer| Optimize services (remove, disable, and set to manual) some Windows Services. Optimizes driver services. Disables AMDPPM for 3rd Gen. Mobile Ryzen Processor for thermal throlling (Disables Clock Speeds). ATTENTION! Search Services, VR Services and Sensor Services will be disabled. Can be enabled in services.msc, if you rebooted the pc.| Windows 10 1803 or newer|
|SVCHOST Split| Unsplit svchost.exe processes for ram comsumption savings.|Windows 10 1703 or newer|
|System Tweaks| Optimizes the system. Disables SmartScreen.|Windows 10 or newer
|Task Scheduler Tweaking| Remove some unwanted Windows Tasks, telemetry Office Tasks and blotware.|Windows 10 1809 or newer|
|TCP-IP Optimization| Optimizes network speed. | Windows 10 or newer|
|Windows Error Reporting| Disables Windows Error Reporting| Windows NT|
|Windows Kernel Optimizations| Optimizes Kernel.|Windows 11|
|Windows Sandbox Optimizations| Disables some software rendering in the app| Windows 10 2004 or newer|
|Windows Search Optimizations| Optimizes Index Algorithm, disables web search in Windows Search and telemetry|Windows 10 1507 & Windows 10 2004 or newer|
|Telemetry Data Collection| Disables Telemetry and Data Collection in Windows (registry part)| Windows 7/8/10/11 or newer|
|Windows Update - Disable Driver Searching| |Disables Driver Searching with Windows Update|| Windows NT|
|Windows Update - Derivery Optimization| Disables Delivery Optimization| Windows 10 or newer
|Windows Update| Optimizes Windows Update. Disables notifications and deferes some Quality Updates and Features Updates |Windows 10 or newer
|Xbox Gaming Optimization| Fixing errors with Teredo Connectivity (also in TCP-IP optimization) and disables GameBar| Windows 10 1511 or newer.
|Removal of Drive Indicator Icon in This PC | Removing drive indicator it will show infos in 3 rows instead of one. (name , size and file system type) | Windows 7 or newer
|Disablation of Windows Protected Printer Mode | Allowing installation of custom drivers of printers. | Windows 11 26016 or newer|

# Tweaks for 3rd party Software 
> In this part i have a research to disable 3rd party Updaters , metrics and telemetry.
> Some config!
urations are policies and be found to [admx.help].

| Applied Tweak | Description | Required Windows Version |
| ------ | ------ |------ |
|Office Tweaks| Disables Office Telemetry and data collection | Office 2013 or newer|
|Chrome Tweaks| Adds uBlock Origin Extension, Tweaking DNS Client of Browser | Chrome 96 or newer|
|Edge Tweaks| Adds uBlock Origin Extension, Tweaking DNS Client of Browser | Edge 92 or newer|
|Chromium Browser Updater Tweaks| Optimizes Update Pipeline |Chrome/Edge Updater 1.42 or newer|


# Optimization and organizing Context Menus

> In this part i will a list which elements are added / removed from Windows Context Menu. Always i use Classic Context Menu.

> Here is a simple table which it has the name of menu and the type of menu. For understanting , menu type is the location of the menu element.

Defined locations which Melody Script modifies:
- File (File right-click menu)
- Folder (Folder right-click menu)
- Directory (Director right-click menu, including folders + system folders such as This PC, Library Folders, System Folders such Control Panel and custom system created folders)
- Background (right click menu of desktop or an explorer window)
- Disk (Drive Context Menu (Disk drives such CD, DVD, HDD, SSD, USB , SD cards etc.))

| Context Menu Name | Menu Type | Description |
| ------ | ------ | ------ |
| Run app as... | File (.exe) | Used by some apps you an run an app as user/admin/trusted installer or as a file type |
| Configuration app as... | File (.exe) | Configuration of app running. You can add rules such running priority , allow/block internet access using Windows Firewall |
| Set GPU Usage to... | File (.exe, .pif) | Set default GPU Usage per app (integrated or dedicated GPU). Needs Hardware Acceleration Scheduler to be disabled. |
| MSI Extracting | File (.msi) | Extract files for .cab and .msi installation files |
| Register DLL and OCX files | File (.dll,.ocx) | Register/Unregister files |
| Restart Menu Component | Desktop | Advanced Shutdown Menu on Desktop right-click menu |
| Terminal | Background, Folder | Run as admin/normal user command prompt and powershell, provided an API which you can add Git, Powershell 7 and even Linux WSL in this menu. |
| Take onwership | Directory, File | Take onwership of files as current user. |
| File Management Menu | File | Add attributes of hiding , copy file content to clipboard and more | 

## Sources

Some privacy Tweaks (registry Settings) are provided by Microsoft (Policy Tweaks) Check out the website by clicking the <a href="https://admx.help">link</a>.
A smaller part of performance Tweaks are provied by AskVG website, winaero.com Website and reverse engienerring of Winaero Tweaker, O&O ShutUp10, W10 Privacy and Wise Care 365, applied in Windows Telemetry Data Collection Registry File.
Latency Tweaks are provided by me. Latency Service is a SFX version by TimerTool, which this tool isn't mine.
EarTrumpet Integration is created by me. The application is created by File-New-Project. (I forked the project).
Also Clipboard "Integration" is provided by me. The Application is created by Ditto. (provided with GNU GPL-3 License).


# Some bcdedit commands

There are some commands of BCDEDIT for Melody Script. There are removed since version 14.9 because in some Windows versions
 the commands are not running.
 So i will publish in this list all commands of **bcdedit configuration**:
 ```

bcdedit.exe /set linearaddress57 OptOut >nul
bcdedit.exe /set increaseuserva 268435328 >nul
bcdedit.exe /set firstmegabytepolicy UseAll >nul
bcdedit.exe /set avoidlowmemory 0x8000000 >nul
bcdedit.exe /set nolowmem Yes >nul
bcdedit.exe /set isolatedcontext No >nul
bcdedit.exe /set vsmlaunchtype Off >nul
bcdedit.exe /set vm No >nul
bcdedit.exe /set x2apicpolicy Enable >nul
bcdedit.exe /set configaccesspolicy Default >nul
bcdedit.exe /set MSI Default >nul
bcdedit.exe /set usephysicaldestination No >nul
bcdedit.exe /set usefirmwarepcisettings No >nul
bcdedit.exe /timeout 0 >nul
bcdedit.exe /set hypervisorlaunchtype off >nul
bcdedit.exe /set debug No >nul
bcdedit.exe /set sos Yes >nul
bcdedit.exe /set ems No >nul
bcdedit.exe /set noumex Yes >nul
bcdedit.exe /set onecpu No >nul
bcdedit.exe /set nx AlwaysOff >nul
bcdedit.exe /set extendedinput Yes >nul
bcdedit.exe /set forcefipscrypto No >nul
bcdedit.exe /set halbreakpoint No >nul
bcdedit.exe /set tpmbootentropy ForceDisable >nul
bcdedit.exe /set bootmenupolicy Legacy >nul
bcdedit.exe /set recoveryenabled NO >nul
bcdedit.exe /set graphicsmodedisabled No >nul
bcdedit.exe /set useplatformclock false >nul
bcdedit.exe /set tscsyncpolicy Enhanced >nul
bcdedit.exe /set disabledynamictick yes >nul
bcdedit.exe /set useplatformtick Yes >nul
bcdedit.exe /set NOINTEGRITYCHECKS OFF >nul
bcdedit.exe /set TESTSIGNING OFF >nul

 ```
This modifies next options:
 - disables test signing
 - disables HPET for better latency
 - disables annoying disk verification dialog
 - switches boot manager options to old good version (Windows 7-like)
 - disables Hyper-V Hypervisor (This is a workaround to KILL VBS)
 - policies for x86 apps
 - disables usage of uefi resources

## Updating

> You can create a own version of Melody by using the provided sources of cmds , registry files ,and apps integration.
> Also you can download the release version, open with 7-Zip and you can remove the registry files or adding.
> If you want to add registry/CMDs files you MUST to write the files in commands2.bat (the file will run to current USER) or in PowerRun2.bat (th file will run to the SYSTEM user).
> Stable version of Melody will launch every 3 months. First 2 weeks after release, the version will be revisioned. (added integration from beta or adding tweaks).
 ## Another Versions of Melody Script
 <a href="https://github.com/jbara2002/melody_android">Melody for Android </a>
  <a href="https://github.com/jbara2002/melody_apple">Melody for Apple Devices</a>
  <a href="https://github.com/jbara2002/melody_linux">Melody for Linux Distros</a>
## License
[![License: CC0-1.0](https://img.shields.io/badge/License-CC0%201.0-lightgrey.svg)](https://tldrlegal.com/license/creative-commons-cc0-1.0-universal)
