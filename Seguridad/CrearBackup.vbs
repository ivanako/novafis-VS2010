Dim objEjecutor
Dim sComando
Dim sFicheroSalida
Dim sFechaHora

sFechaHora = FormatDateTime(Now(), vbGeneralDate)
sFechaHora = Replace(sFechaHora, "/", "")
sFechaHora = Replace(sFechaHora, ":", "")
sFechaHora = Replace(sFechaHora, " ", "_")

sComando = "cmd /c mysqldump --user=root --password=walrus --opt --routines novafis2 > "
sFicheroSalida = "C:\Novafis\CopiasSeguridad\Backup_" & sFechaHora & ".sql"
sComando = sComando & sFicheroSalida

Set objEjecutor = WScript.CreateObject("WScript.Shell")
objEjecutor.Run(sComando)
Set objEjecutor = Nothing
