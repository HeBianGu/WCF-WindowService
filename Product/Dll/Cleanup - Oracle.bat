@echo off
net stop HeBianGu.Oracle.WcfHostService
C:\Windows\Microsoft.NET\Framework\v4.0.30319\InstallUtil.exe /u F:\GitHub\WCF-WindowService\Product\Debug\HeBianGu.WCF.HostApp.Oracle.WindowService.exe
pause
