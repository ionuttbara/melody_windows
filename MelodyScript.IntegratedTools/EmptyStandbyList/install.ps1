#Requires -RunAsAdministrator

Write-Host "Starting Installation..."
Write-Host "Waiting three seconds to see if you cancel"
Start-Sleep -s 3

$windowsFolder = "C:\Windows"
$currentFolder = Get-Location
$taskname = "EmptyStandbyList"
$XMLfile = '.\EmptyStandbyList.xml'
$User= "NT AUTHORITY\SYSTEM"

#if files already exist, skip them
if(!(Test-Path $windowsFolder\EmptyStandbyList.exe)){
    copy $currentFolder\EmptyStandbyList.exe $windowsFolder\EmptyStandbyList.exe
}

#if task exists, skip
if (Get-ScheduledTask -TaskName "EmptyStandbyList" -ErrorAction SilentlyContinue) {
    Write-Host "Task already exists"
    } else {
    Write-Host "Creating Task"
Register-ScheduledTask -Xml (Get-Content 'EmptyStandbyList.xml' | out-string) -TaskName "EmptyStandbyList" -User $User
Enable-ScheduledTask -TaskName 'EmptyStandbyList'
}
