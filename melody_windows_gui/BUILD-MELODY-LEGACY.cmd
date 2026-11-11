@echo off
setlocal EnableExtensions
cd /d "%~dp0"
echo Melody 16.0-rcD legacy source build for Windows 7/8 and Windows 10 early builds 10240/10586
 echo Requires Visual Studio 2019 with .NET Framework 4.0 targeting pack.
set "VSWHERE=%ProgramFiles(x86)%\Microsoft Visual Studio\Installer\vswhere.exe"
if not exist "%VSWHERE%" (echo vswhere.exe missing & exit /b 2)
set "MSBUILD="
for /f "usebackq tokens=*" %%i in (`"%VSWHERE%" -version "[16.0,17.0)" -products * -requires Microsoft.Component.MSBuild -find MSBuild\**\Bin\MSBuild.exe`) do set "MSBUILD=%%i"
if not defined MSBUILD (
  echo Visual Studio 2019 MSBuild not found. Use VS2019 and its .NET 4.0 targeting pack.
  exit /b 3
)
"%MSBUILD%" "%~dp0Melody.Legacy.csproj" /t:Rebuild /m /p:Configuration=Release /p:Platform=x64
if errorlevel 1 exit /b 1
 echo Built: artifacts\x64\LegacyRelease\Melody.exe
