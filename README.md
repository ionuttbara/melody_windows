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

##### Re-enable System Restore
* Melody Script is disabling System Restore due of a Windows bug of creating automatic system points. If you want to add it back just go to registry editor and remove this key
```
HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows NT\SystemRestore
```

## Components of Melody

##### Windows Operating System Optimization
> In this part i had done a research about Windows Optimization, Tweaking and i read news about Microsoft's tactics to install unwanted software and add some telemetry, keylogger into Windows.
> The resolvation will be in system configuration: 99.7% Registry and 0.03 % Batch.
> I had rework some Winaero Tweaker's , O&O Shutup 10, W10 Privacy, WinSpyDisabler and BlackBird Application.

- Windows Appearence Tweaks

| Applied Tweak | Description |
| ------ | ------ |
| Windows Appearence | Disables animations and transparency. Adds regional configuration from (English (World)) and disable Windows Feeds Update. |
| DWM Tweaks | Disables DWM Input processing for better input latency. Tweaks DWM to be snappier |
| Dark mode | Enable system-wide and app-wide dark mode. Sets wallpaper to black color. |
| Hiding Scrollbar | Disables Hides Scrollbar |
| Disable Immersive Shell elements | **(Windows 10 only)** Tweaks to revert to legacy |

- Windows Update Tweaks

| Applied Tweak | Description |
| ------ | ------ |
| Disable MRT Inclusion in Windows Updates | Removes Malware Removal Tool from Windows Updates lists. |
| Pauses Windows Update until 2099 | Pause updates (via good-way) |
| Microsoft Store Apps Auto Updating | Disables Store Apps Auto-Updates |
| Disables FoD Metadata | Disables Driver Updates and installation of Driver Software from Windows Update and Microsoft Store |
| Speech Model Data Update Disablation | **(Windows 10 with Installed Cortana Only)** Speech Model Updating Disabling |
| Disablation of Delivery Optimization | Disables Delivery Optimization (Updates Peer to peer). Replaces BITS and WebClient in 24H2. |


- Windows Search Tweaks

| Applied Tweak | Description |
| ------ | ------ |
| Disable WebSearch | Disables Bing on Windows Search |
| Cloud Search | Disables search in PC with organizational Microsoft Account Connected |
| Disable SearchBox Highlights| Disable icons on searchbox |
| Disable Search History | Disables Search History in Windows Search |
| Hidding Search in Taskbar | |
| Disablation service | Disables Windows search service (maybe you're using Everything). Can be enabled from *services.msc*. |


- Windows Explorer Tweaks


- Virtualization Tweaks

| Applied Tweak | Description |
| ------ | ------ |
| App-V Virtualization Disabling | |
| VBS Disablation| Disables Virtualization Based Security |


- Telemetry Disablation

| Applied Tweak | Description |
| ------ | ------ |
| Windows Error Reporting Online Reports and switched to local reports | Disabling online error reportings on crash apps and moving dumps to folder dumps created in ```C:\dumps``` folder. |
| Input telemetry | Removes Microsoft's keyloggers. |
| Smart Screen | Disables and kills SmartScreen (like Windows Defender Remover) |
| Disabling Messaging Cloud Sync | |
| Windows EventLog and WMI Logger Optimizations | Removing loggers to get maximum disk performance (for HDD and eMMC disks without harming system). Also stops creating of WinEVT files. |
| Disable Diagnostic Data | Disable Windows Diagnostic Data Collection, Windows Feedback Surveys and Dr. Whatson. |
| Disable Windows Data Collection (Telemetry) | Disables Telemetry elements for KMS, Storage Health, SQM CEIP , Experimentation and Account Sycronization |


- Tasks and Services

Removes Services and Tasks to get PC to boot faster and get lower RAM usage. Go to <a href=https://github.com/ionuttbara/melody_windows/tree/main/MelodyScript.Settings/Tasks>MelodyScript.Settings\Tasks </a> to check what tasks are removed and <a href=https://github.com/ionuttbara/melody_windows/tree/main/MelodyScript.Settings/Services> MelodyScript.Settings\Services </a> for Services.

- Taskbar





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
| StartAllBack Configurations | Revert to Windows 7 UI Explorer and optimize some menus in Start and more zones | StartIsBack 3.5 or newer |


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
| Removing and cleaning context menu| All | Removes bloatware elements from menus to make context menu faster |
| Restart and kill component | Desktop | Refresh processes such explorer.exe and windows stock start menu. also menu which kills all unresponsive apps and background apps (background apps can be added by you own list). |

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
 - disables usage of UEFI resources

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
