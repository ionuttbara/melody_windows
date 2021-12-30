:: start the program by setting location in melody application folder
takeown /f C:\Windows\Cursors
cacls C:\Windows\Cursors /E /P %username%:F
del /F /Q "C:\Windows\Cursors"
takeown /f C:\Windows\Media
cacls C:\Windows\Media /E /P %username%:F
del /F /Q "C:\Windows\Media"
reg add "HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\melody" /v DisplayName /t reg_sz /d "melody (n-EAS)" /f
pushd "%CD%"
sc delete WerSvc
sc delete Wecsvc
sc delete MsKeyboardFilter
sc delete GraphicsPerfSvc
sc delete DiagTrack
sc delete TroubleshootingSvc
sc delete RemoteRegistry
sc delete shpamsvc
sc delete UevAgentService
sc delete MSiSCSI
sc delete NetTcpPortSharing
sc delete diagnosticshub.standardcollector.service
sc delete diagsvc
sc delete dmwappushservice
sc delete edgeupdate

::Search

sc delete WSearch

::Remote Desktop Native

sc delete tsusbflt
sc delete tsusbhub
sc delete TsUsbGD
sc delete TermService
sc delete SessionEnv

::Networking Services

sc delete PNRPsvc
sc delete p2psvc
sc delete p2pimsvc
sc delete PeerDistSvc
sc delete PerfHost
sc delete PNRPAutoReg
sc delete ALG
sc delete Fax
sc delete SNMPTrap
sc delete autotimesvc
sc delete LanmanWorkstation
sc delete LanmanServer
sc delete webthreatdefsvc
sc delete webthreatdefusersvc_63b8d
sc delete InventorySvc
sc delete MapsBroker
sc delete pla

::VR Services

sc delete perceptionsimulation
sc delete SharedRealitySvc
sc delete spectrum
sc delete MixedRealityOpenXRSvc

::Retail Demo

sc delete RetailDemo

::Virtual Machine

sc delete HvHost
sc delete vmickvpexchange
sc delete vmicguestinterface
sc delete vmicshutdown
sc delete vmicheartbeat
sc delete vmicvmsession
sc delete vmicrdv
sc delete vmictimesync
sc delete vmicvss
sc delete VMAuthdService start=demand
sc delete VMnetDHCP start= demand
sc delete VMware NAT Service start= demand
sc delete VMUSBArbService start= demand
sc delete VMwareHostd start= demand
sc delete wcncsvc

::Blotware


sc delete lfsvc
sc config GoogleChromeBetaElevationService start= demand
sc config gupdate start= demand
sc config gupdatem start= demand
sc config GamingServices start= demand
sc config sppsvc start= demand
sc config DoSvc start= demand
sc config CDPSvc start= demand
sc config ClickToRunSvc start= demand
sc config DtsApo4Service start= demand
sc config TrkWks start= demand
sc delete VacSvc
sc delete VSStandardCollectorService150
sc config ss_conn_service start= demand
sc config ss_conn_service2 start= demand
sc config AudioEndpointBuilder start= demand
sc delete RpcLocator
sc delete Sense
sc delete TapiSrv
sc delete KtmRm
sc delete SEMgrSvc
sc delete SCardSvr
sc delete ScDeviceEnum
sc delete AppVClient
sc delete SysMain
sc delete SSDPSRV
sc config IKEEXT start= demand
sc delete FontCache3.0.0.0
sc delete WinRM
sc delete AxInstSV
sc delete WpcMonSvc
sc delete pla
sc delete COMSysApp
sc delete AGMService
sc delete AGSService


::TabletPC

sc delete SensorDataService
sc delete SensrSvc
sc delete SensorService
sc delete SmsRouter
sc delete PhoneSvc

::Data


sc delete DusmSvc

CD /D "%~dp0"

:: Remove HyperV Tools

melody /o /c HyperV /r
melody /o /c Microsoft-Hyper-V /r
melody /o /c Microsoft-Windows-ApiSetSchemaExtension-HyperV /r
melody /o /c Microsoft-Windows-HyperV-OptionalFeature /r

:: Virtual Machine Support

melody /o /c Microsoft-OneCore-UtilityVm /r


:: Remove Containers
melody /o /c Containers /r
melody /o /c Microsoft-OneCore-Containers /r
melody /o /c Microsoft-OneCore-UtilityVM-Containers /r
melody /o /c Microsoft-UtilityVM-Containers /r
melody /o /c Microsoft-Windows-OneCore-Containers /r

::Linux Subsystem

melody /o /c Microsoft-Windows-Lxss /r

:: Networking


melody /o /c Microsoft-WindowsCore-Network-FlowSteering /r
melody /o /c Microsoft-Windows-TFTP-Client-Opt /r
melody /o /c Microsoft-Windows-SMB /r
melody /o /c Microsoft-Windows-Smb /r
melody /o /c Microsoft-Windows-SimpleTCP /r
melody /o /c Microsoft-Windows-OfflineFile /r
melody /o /c Microsoft-Windows-NFS /r
melody /o /c Microsoft-Windows-NetworkDiagnostics /r
melody /o /c Microsoft-Windows-Telnet /r
melody /o /c Microsoft-Windows-PeerDist /r
melody /o /c Microsoft-Windows-MultiPoint /r
melody /o /c MultiPoint /r
melody /o /c Microsoft-Windows-ClientForNFS-Infrastructure-OptGroup /r
melody /o /c Microsoft-Windows-TFTP-Client /r
melody /o /c Microsoft-Windows-ConfigCI /r


:: Language

melody /o /c LanguageFeatures-WordBreaking /r
melody /o /c Microsoft-Windows-LanguageFeatures /r
melody /o /c Microsoft-Windows-WinOcr-Opt /r
melody /o /c Microsoft-Windows-TextPrediction-Dictionaries /r
melody /o /c Microsoft-Windows-Spelling /r
melody /o /c Microsoft-Windows-Hyphenation /r
melody /o /c Microsoft-Windows-HgsClient /r
melody /o /c Microsoft-Onecore-Identity-TenantRestrictions /r

:: Search

melody /o /c Microsoft-Windows-SearchEngine /r
melody /o /c WindowsSearchEngineSKU /r

:: Remove Desktop 

melody /o /c RemoteDesktopServices /r
melody /o /c Microsoft-Windows-RDC- /r
melody /o /c Microsoft-Windows-Remote /r
melody /o /c Microsoft-Windows-IIS /r
melody /o /c Microsoft-Windows-CoreSystem-RemoteFS-Client /r

:: MSMQ

melody /o /c Microsoft-Windows-msmq /r
melody /o /c Microsoft-Windows-MSMQ /r
melody /o /c MSMQ-Driver /r
melody /o /c Microsoft-Windows-COM-MSMQ /r



:: Help

melody /o /c Microsoft-Windows-Help /r


:: Browser

melody /o /c Microsoft-Windows-Internet /r
melody /o /c Microsoft-Windows-Browser /r


:: Telemetry

melody /o /c Microsoft-Windows-CEIPEnable /r
melody /o /c Microsoft-Windows-FodMetadata /r
melody /o /c Microsoft-Windows-ErrorReporting /r
melody /o /c Microsoft-Windows-EnterpriseClientSync /r
melody /o /c Microsoft-Windows-DiagnosticInfrastructure /r
melody /o /c DiskIo-QoS /r
melody /o /c Microsoft-Windows-TerminalServices-RemoteApplications-Client-Package /r
melody /o /c Microsoft-Windows-TerminalServices-AppCompat-Opt /r
melody /o /c Microsoft-Windows-TerminalServices-AppServerClient-Opt /r
melody /o /c Microsoft-Windows-AppServerClient-OptGroup /r
melody /o /c Microsoft-Windows-MediaPlayback-OC /r

:: Shell

melody /o /c Microsoft-Composable-PlatformExtension-DragDropCommon /r
melody /o /c Networking-MPSSVC /r
melody /o /c Microsoft-Windows-Management-SecureAssessment /r

::OneDrive
melody /o /c Microsoft-Windows-WinSATMediaFiles /r


::PWA

melody /o /c Microsoft-Windows-FlipGridPWA /r
melody /o /c Microsoft-Windows-OutlookPWA /r

:: System 

melody /o /c Microsoft-Windows-ScreenSavers /r
melody /o /c Microsoft-Windows-RecoveryDrive /r
melody /o /c Microsoft-Windows-RecDisc /r
melody /o /c Microsoft-Windows-DirectoryServices-ADAM-Tools-Opt /r
melody /o /c Microsoft-Windows-SensorDataService /r
melody /o /c Microsoft-Windows-NewTabPageHost /r
melody /o /c Microsoft-Windows-TabShellExperience /r
melody /o /c Microsoft-Windows-Identity-Foundation /r
melody /o /c Microsoft-Windows-PhotoBasic- /r
melody /o /c Microsoft-Windows-WinOcr /r
melody /o /c Microsoft-Windows-Holographic /r
melody /o /c Microsoft-OneCore-Fonts /r
melody /o /c Microsoft-Windows-Accessories /r
melody /o /c Microsoft-Windows-Media-Streaming /r
melody /o /c Microsoft-Windows-Embedded /r
melody /o /c Microsoft-Windows-Client-EmbeddedExp /r

:: Virtualization

melody /o /c Microsoft-Windows-DeviceGuard /r
melody /o /c Microsoft-OneCore-VirtualizationBasedSecurity /r


:: Priting

melody /o /c Microsoft-Windows-Printing- /r

:: IoT

melody /o /c Microsoft-OneCore-WindowsIoT /r
melody /o /c Microsoft-IoTUAP-ShellExt-Tools /r

::Device Update Center

melody /o /c Microsoft-OneCore-DeviceUpdateCenter /r

:: Data Center

melody /o /c Microsoft-Windows-DataCenterBridging /r


:: Server Features

melody /o /c Microsoft-Windows-FCI-Client /r
melody /o /c Microsoft-Windows-Dedup-ChunkLibrary /r
melody /o /c Microsoft-Windows-AppManagement-UEV /r
melody /o /c Microsoft-Windows-AppManagement-AppV /r
melody /o /c Microsoft-Windows-DirectoryServices-ADAM-Client- /r
melody /o /c Microsoft-Windows-PAW /r
melody /o /c Microsoft-Windows-ProjFS-OptionalFeature /r
::Laptop

melody /o /c Microsoft-Windows-MobilePC-Client-Premium /r
melody /o /c Server-Help /r


pause