@ECHO OFF
REM The following directory is for .NET 4.0
set DOTNETFX4=%SystemRoot%\Microsoft.NET\Framework\v4.0.30319
set PATH=%PATH%;%DOTNETFX4%
echo %~dp0
echo UnInstalling serviceName...
echo ---------------------------------------------------
net stop "serviceName"
InstallUtil.exe -u  %~dp0\HDC.Job.Container.exe
echo ---------------------------------------------------
echo Done.
pause