@echo off
net stop WCFHostService
C:\Windows\Microsoft.NET\Framework\v4.0.30319\InstallUtil.exe /u F:\GitHub\WCF-WindowService\Product\Debug\HeBianGu.WCF.HostApp.WindowsService.exe
pause
