@echo off
setlocal EnableExtensions
cd /d "%~dp0"

echo ============================================================
echo   Melody 16.0-rcD - standalone Release build
echo   This script builds ONLY Melody.sln / Melody.csproj
echo ============================================================
echo.

if exist "artifacts" rmdir /s /q "artifacts"
if exist "obj" rmdir /s /q "obj"

set "VSWHERE=%ProgramFiles(x86)%\Microsoft Visual Studio\Installer\vswhere.exe"
if not exist "%VSWHERE%" (
  echo ERROR: Visual Studio 2022 / vswhere.exe was not found.
  echo Install the .NET desktop development workload and .NET Framework 4.8 targeting pack.
  pause
  exit /b 2
)

for /f "usebackq tokens=*" %%i in (`"%VSWHERE%" -latest -products * -requires Microsoft.Component.MSBuild -find MSBuild\**\Bin\MSBuild.exe`) do set "MSBUILD=%%i"
if not defined MSBUILD (
  echo ERROR: MSBuild was not found.
  pause
  exit /b 3
)

"%MSBUILD%" "%~dp0Melody.sln" /t:Rebuild /m /p:Configuration=Release /p:Platform=x64
if errorlevel 1 (
  echo.
  echo Melody build FAILED.
  pause
  exit /b 1
)

echo.
echo SUCCESS: "%~dp0artifacts\x64\Release\Melody.exe"
echo The window title must be: Melody 16.0-rcD
pause
