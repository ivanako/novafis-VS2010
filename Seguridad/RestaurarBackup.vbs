Dim objEjecutor
Dim sComando
Dim sFicheroSalida

sComando = "cmd /c mysql --user=root --password=walrus novafis4 < "
sFicheroSalida = "G:\ivanako\Novafis\febrero-2009\Backup_16092010_210642_nueva.sql"
sComando = sComando & sFicheroSalida

Set objEjecutor = WScript.CreateObject("WScript.Shell")
objEjecutor.Run(sComando)
Set objEjecutor = Nothing
