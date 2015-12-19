
Public Module modGeneral

    Public Const cteVisorSucesos_Nodo As String = "Novafis"
    Public Const cteVisorSucesos_Origen As String = "Seguridad"

    ''' Lectura de un nodo concreto del archivo de configuracion (App.config)
    Friend Function LeerConfiguracion(ByVal sNodo As String) As String

        Dim objConfiguracion As New System.Configuration.AppSettingsReader()

        Dim sValor As String = String.Empty

        Try
            sValor = objConfiguracion.GetValue(sNodo, GetType(System.String)).ToString

        Catch exConfiguracion As InvalidOperationException

            'RegistrarError(exConfiguracion.Message, exConfiguracion.Source, MessageBoxIcon.Error, EventLogEntryType.Error)

        Catch exError As Exception

            'RegistrarError(exError.Message, exError.Source, MessageBoxIcon.Error, EventLogEntryType.Error)

        End Try

        Return sValor

    End Function


    Friend Sub GestionarErrores(ByVal sMensaje As String, ByVal msgIcono As MessageBoxIcon, ByVal logIcono As EventLogEntryType)

        ' Mostrar mensaje sólo en caso de error
        If logIcono = EventLogEntryType.Error Then
            MessageBox.Show(sMensaje, cteVisorSucesos_Origen, MessageBoxButtons.OK, msgIcono)
        End If

        'Comprobar, en primer lugar, si existe la categoría dentro del visor de sucesos
        If Not EventLog.Exists(cteVisorSucesos_Nodo) Then
            EventLog.CreateEventSource(cteVisorSucesos_Nodo, cteVisorSucesos_Nodo)
        End If

        'Comprobar si existe un origen dentro de la categoría que ya se supone que existe
        If Not EventLog.SourceExists(cteVisorSucesos_Origen) Then
            EventLog.CreateEventSource(cteVisorSucesos_Origen, cteVisorSucesos_Nodo)
        End If

        'Escribir el error
        EventLog.WriteEntry(cteVisorSucesos_Origen, sMensaje, logIcono)

    End Sub


End Module
