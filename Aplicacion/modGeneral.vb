
Public Module modGeneral

    Public Const cteVisorSucesos_Nodo As String = "Novafis"

    Friend Const cteNinguna As String = "<Ninguna>"

    Friend Const cteHombre As String = "H"
    Friend Const cteMujer As String = "M"

    Friend cteFechaNula As Date = New Date(1900, 1, 1) '"01/01/1900"

    Friend dtPacientes As DataTable = New DataTable("Pacientes")
    Friend CambioTablaPacientes As Boolean = False

    Friend tblFisios = New DataTable("Fisios")

    Public Enum eTiposMantenimiento
        NoAsignado = 0
        Alta = 1
        Modificacion = 2
        Eliminacion = 3
        Visualizacion = 4
    End Enum


    Public Enum eTiposConfiguracion
        Jornada = 1
        Tarifa = 2
    End Enum

    Public Enum eTiposPatologia
        Localizacion = 1
        Lesion = 2
    End Enum


    Public Enum eTiposRellenoPacientes
        Todos = 0
        Pacientes = 1
        Citas = 2
        ListaNegra = 3
    End Enum

    Public Enum eEstadosTratamiento
        NoEstado = 0
        Inicio = 1
        Continuacion = 2
        Alta = 3
        IniFin = 4
        IniNoc = 5
    End Enum

    ''' <summary>
    ''' Estructura que guarda los parámetros de la jornada en función de la fecha y el fisio seleccionados
    ''' </summary>
    ''' <remarks></remarks>
    Structure parametrosJornada
        ''' <summary>
        ''' Hora de inicio de la primera parte de la jornada (generalmente la mañana)
        ''' </summary>
        ''' <remarks></remarks>
        Public horaInicio1 As String
        ''' <summary>
        ''' Hora de finalización de la primera parte de la jornada (generalmente la mañana)
        ''' </summary>
        ''' <remarks></remarks>
        Public horaFinal1 As String
        ''' <summary>
        ''' Hora de inicio de la segunda parte de la jornada (generalmente la tarde)
        ''' </summary>
        ''' <remarks></remarks>
        Public horaInicio2 As String
        ''' <summary>
        ''' Hora de finalización de la segunda parte de la jornada (generalmente la tarde)
        ''' </summary>
        ''' <remarks></remarks>
        Public horaFinal2 As String
        ''' <summary>
        ''' Duración en minutos de cada sesión durante la primera parte de la jornada (generalmente la mañana)
        ''' </summary>
        ''' <remarks></remarks>
        Public intervaloM As Byte
        ''' <summary>
        ''' Duración en minutos de cada sesión durante la seguna parte de la jornada (generalmente la tarde)
        ''' </summary>
        ''' <remarks></remarks>
        Public intervaloT As Byte

        ''' <summary>
        ''' Almacena todas las horas a las que se pueden citar pacientes
        ''' </summary>
        ''' <remarks></remarks>
        'Public horasJornada As DataTable

        ''' <summary>
        ''' Comprueba si la jornada está definida
        ''' </summary>
        ''' <returns>Marca que indica si la jornada está definida o no</returns>
        ''' <remarks></remarks>
        Public Function hayJornadaDefinida() As Boolean

            Dim bOK As Boolean = False

            ' Comprobar si la mañana está definida
            bOK = (Not Me.horaInicio1.Equals(String.Empty) And Not Me.horaFinal1.Equals(String.Empty) And Me.intervaloM > 0)

            If Not bOK Then
                ' Comprobar si la tarde está definida
                bOK = (Not Me.horaInicio2.Equals(String.Empty) And Not Me.horaFinal2.Equals(String.Empty) And Me.intervaloT > 0)
            End If

            Return bOK

        End Function

        ''' <summary>
        ''' Recupera todas las horas a las que se pueden citar pacientes
        ''' </summary>
        ''' <param name="fechaSeleccionada">Día correspondiente a la jornada</param>
        ''' <returns>ArrayList con todas las horas de la jornada en formato HH:mm</returns>
        ''' <remarks></remarks>
        Public Function obtenerHorasJornada(ByVal fechaSeleccionada As Date) As DataTable

            Dim dtHorasJornada As New DataTable("HorasJornada")

            Dim fHoraInicio1 As DateTime
            Dim fHoraFin1 As DateTime
            Dim fHoraInicio2 As DateTime
            Dim fHoraFin2 As DateTime
            Dim fAux As DateTime

            ' Generar fecha de inicio del primer tramo de la jornada
            If Me.horaInicio1.Equals(String.Empty) Then
                fHoraInicio1 = DateTime.Parse(cteFechaNula)
            Else
                fHoraInicio1 = New DateTime(fechaSeleccionada.Year, fechaSeleccionada.Month, fechaSeleccionada.Day, Convert.ToInt32(Me.horaInicio1.Substring(0, 2)), Convert.ToInt32(Me.horaInicio1.Substring(3, 2)), 0)
            End If

            ' Generar fecha de finalización del primer tramo de la jornada
            If Me.horaFinal1.Equals(String.Empty) Then
                fHoraFin1 = DateTime.Parse(cteFechaNula)
            Else
                fHoraFin1 = New DateTime(fechaSeleccionada.Year, fechaSeleccionada.Month, fechaSeleccionada.Day, Convert.ToInt32(Me.horaFinal1.Substring(0, 2)), Convert.ToInt32(Me.horaFinal1.Substring(3, 2)), 0)
            End If


            ' Generar fecha de inicio del segundo tramo de la jornada
            If Me.horaInicio2.Equals(String.Empty) Then
                fHoraInicio2 = DateTime.Parse(cteFechaNula)
            Else
                fHoraInicio2 = New DateTime(fechaSeleccionada.Year, fechaSeleccionada.Month, fechaSeleccionada.Day, Convert.ToInt32(Me.horaInicio2.Substring(0, 2)), Convert.ToInt32(Me.horaInicio2.Substring(3, 2)), 0)
            End If

            ' Generar fecha de finalización del segundo tramo de la jornada
            If Me.horaFinal2.Equals(String.Empty) Then
                fHoraFin2 = DateTime.Parse(cteFechaNula)
            Else
                fHoraFin2 = New DateTime(fechaSeleccionada.Year, fechaSeleccionada.Month, fechaSeleccionada.Day, Convert.ToInt32(Me.horaFinal2.Substring(0, 2)), Convert.ToInt32(Me.horaFinal2.Substring(3, 2)), 0)
            End If

            With dtHorasJornada
                .BeginInit()

                ' Columnas
                .Columns.Add("Hora", GetType(String))
                .Columns("Hora").Unique = True

                .PrimaryKey = New DataColumn(0) {.Columns.Item(0)}

                Dim drFilaHora As DataRow

                ' Horas de la mañana
                If fHoraInicio1.CompareTo(cteFechaNula) > 0 Then
                    fAux = fHoraInicio1

                    Do Until fAux > fHoraFin1
                        drFilaHora = .NewRow
                        drFilaHora("Hora") = fAux.ToString("HH:mm")
                        .Rows.Add(drFilaHora)

                        'arrHorasJornada.Add(fAux.ToString("HH:mm"))
                        fAux = fAux.AddMinutes(Me.intervaloM)
                    Loop
                End If

                ' Horas de la tarde
                If fHoraInicio2.CompareTo(cteFechaNula) > 0 Then
                    fAux = fHoraInicio2

                    Do Until fAux > fHoraFin2
                        drFilaHora = .NewRow
                        drFilaHora("Hora") = fAux.ToString("HH:mm")
                        .Rows.Add(drFilaHora)

                        'arrHorasJornada.Add(fAux.ToString("HH:mm"))
                        fAux = fAux.AddMinutes(Me.intervaloT)
                    Loop
                End If

                .EndInit()
            End With

            Return dtHorasJornada

        End Function

    End Structure


    Public Sub Main()
        ' Punto de entrada

        ' Eliminar las copias de seguridad de más de 7 días de antigüedad
        'ComprobarCopiasSeguridad()

        ' Llenar la tabla pública de pacientes
        'RecuperarPacientes()
        CambioTablaPacientes = False

        tblFisios = CargarFisios()

        Application.Run(New mdiPrincipal)

    End Sub


    ''' <summary>
    ''' Para que no se acumulen las copias de seguridad, eliminar las que tengan más de 7 días
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ComprobarCopiasSeguridad()

        Dim objCarpeta As System.IO.Directory
        Dim objArchivo As System.IO.FileInfo

        Dim sRutaOrigen As String = LeerConfiguracion("RutaBackups")
        Dim sArchivo As String

        Try
            ' Examinar las copias de seguridad
            For Each sArchivo In IO.Directory.GetFiles(sRutaOrigen, "*.sql")
                objArchivo = New System.IO.FileInfo(sArchivo)

                If objArchivo.Exists Then
                    ' Si la copia de seguridad tiene más de 7 de antigüedad respecto a la fecha actual
                    If DateDiff(DateInterval.Day, objArchivo.CreationTime, DateTime.Now) > 7 Then
                        objArchivo.Delete()
                    End If
                End If
            Next sArchivo

        Catch exError As Exception
            GestionarErrores(exError.Message, "Main", MessageBoxIcon.Error, EventLogEntryType.Error)
        End Try

    End Sub

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


    Public Function BuscarElementoCombo(ByVal objLista As DataTable, ByVal sDato As String, ByRef iIndice As Integer) As Boolean

        Dim objFila As DataRow
        Dim iCont As Integer = 0
        Dim bOK As Boolean

        iIndice = -1

        For Each objFila In objLista.Rows
            If objFila(0).ToString = sDato Then
                iIndice = iCont
                Exit For
            End If

            iCont += 1
        Next

        bOK = (iIndice >= 0)

        Return bOK

    End Function

    Public Sub GestionarErrores(ByVal sMensaje As String, ByVal sModuloOrigen As String, ByVal msgIcono As MessageBoxIcon, ByVal logIcono As EventLogEntryType)

        ' Mostrar mensaje sólo en caso de error
        If logIcono = EventLogEntryType.Error Then
            MessageBox.Show(sMensaje, sModuloOrigen, MessageBoxButtons.OK, msgIcono)
        End If

        'Comprobar, en primer lugar, si existe la categoría dentro del visor de sucesos
        If Not EventLog.Exists(cteVisorSucesos_Nodo) Then
            EventLog.CreateEventSource(cteVisorSucesos_Nodo, cteVisorSucesos_Nodo)
        End If

        'Comprobar si existe un origen dentro de la categoría que ya se supone que existe
        If Not EventLog.SourceExists(sModuloOrigen) Then
            EventLog.CreateEventSource(sModuloOrigen, cteVisorSucesos_Nodo)
        End If

        'Escribir el error
        EventLog.WriteEntry(sModuloOrigen, sMensaje, logIcono)

    End Sub

    ''' <summary>
    ''' Devuelve los pacientes registrados, según un filtro especificado
    ''' </summary>
    ''' <param name="sNombre">Nombre del paciente</param>
    ''' <param name="sApellido1">Primer apellido</param>
    ''' <param name="sApellido2">Segundo apellido</param>
    ''' <param name="sNombreCompleto">Nombre completo del paciente</param>
    ''' <param name="iTipoRelleno">Tipo de relleno de los pacientes: Pacientes (1), Citas (2)</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Friend Function LLenarPacientes(ByVal sNombre As String, ByVal sApellido1 As String, ByVal sApellido2 As String, ByVal sNombreCompleto As String, ByVal iTipoRelleno As eTiposRellenoPacientes) As DataTable

        Dim dtPacientes As New DataTable("Pacientes")

        Dim objBDatos As New AccesoBD_MySQL()
        Dim iNumPacientes As Integer
        Dim bOKControl As Boolean = False
        Dim bOK As Boolean

        Try
            With objBDatos
                bOK = .AbrirConexion()

                If bOK Then
                    Dim arrParametros(4) As MySqlParameter

                    arrParametros(0) = New MySqlParameter()
                    With arrParametros(0)
                        .ParameterName = "iTipo"
                        .MySqlDbType = MySqlDbType.Byte
                        .Size = 3
                        .Value = iTipoRelleno
                        .Direction = ParameterDirection.Input
                    End With

                    arrParametros(1) = New MySqlParameter()
                    With arrParametros(1)
                        .ParameterName = "sNombreCompleto"
                        .MySqlDbType = MySqlDbType.VarChar
                        .Size = 200
                        .Value = sNombreCompleto
                        .Direction = ParameterDirection.Input
                    End With

                    arrParametros(2) = New MySqlParameter()
                    With arrParametros(2)
                        .ParameterName = "sNombre"
                        .MySqlDbType = MySqlDbType.VarChar
                        .Size = 50
                        .Value = sNombre
                        .Direction = ParameterDirection.Input
                    End With

                    arrParametros(3) = New MySqlParameter()
                    With arrParametros(3)
                        .ParameterName = "sApellido1"
                        .MySqlDbType = MySqlDbType.VarChar
                        .Size = 50
                        .Value = sApellido1
                        .Direction = ParameterDirection.Input
                    End With

                    arrParametros(4) = New MySqlParameter()
                    With arrParametros(4)
                        .ParameterName = "sApellido2"
                        .MySqlDbType = MySqlDbType.VarChar
                        .Size = 50
                        .Value = sApellido2
                        .Direction = ParameterDirection.Input
                    End With

                    bOK = .EjecutarSP("spPacientes_LLenar", arrParametros, dtPacientes, iNumPacientes)

                    'If bOK Then
                    '    If Not IsNothing(dtPacientes) Then
                    '        If iNumPacientes > 0 Then
                    '            NovafisDataGrid.ColumnaSeleccion(dtPacientes)

                    '            dtgPacientes.SetDataBinding(dtPacientes, String.Empty)
                    '            NovafisDataGrid.EstiloGrid(arrCamposPacientes, arrCabecerasPacientes, arrTiposDatosPacientes, arrAnchurasPacientes, dtgPacientes, "Pacientes", False)
                    '        End If
                    '    End If
                    'End If

                    bOK = .CerrarConexion
                End If
            End With

        Catch exError As Exception
            GestionarErrores(exError.Message, "Llenar Pacientes", MessageBoxIcon.Error, EventLogEntryType.Error)

        Finally
            ' Descargar objetos
            dtPacientes.Dispose()
            objBDatos.Dispose()

        End Try

        Return dtPacientes

    End Function


    ''' <summary>
    ''' Recupera el Paciente con el identificador especificado
    ''' </summary>
    ''' <param name="iIDPaciente">Identificador del Paciente</param>
    ''' <returns>DataTable de 1 registro con los datos básicos del Paciente</returns>
    ''' <remarks></remarks>
    Friend Function BuscarPaciente(ByVal iIDPaciente As String) As DataTable

        Dim dtPaciente As New DataTable("Paciente")

        Dim objBDatos As New AccesoBD_MySQL()
        Dim iNumPacientes As Integer
        Dim bOKControl As Boolean = False
        Dim bOK As Boolean

        Try
            With objBDatos
                bOK = .AbrirConexion()

                If bOK Then
                    Dim arrParametros(0) As MySqlParameter

                    arrParametros(0) = New MySqlParameter()
                    With arrParametros(0)
                        .ParameterName = "idPaciente"
                        .MySqlDbType = MySqlDbType.Int32
                        .Size = 4
                        .Value = iIDPaciente
                        .Direction = ParameterDirection.Input
                    End With


                    bOK = .EjecutarSP("spPacientes_Buscar", arrParametros, dtPaciente, iNumPacientes)

                    bOK = .CerrarConexion
                End If
            End With

        Catch exError As Exception
            GestionarErrores(exError.Message, "Llenar Pacientes", MessageBoxIcon.Error, EventLogEntryType.Error)

        Finally
            ' Descargar objetos
            dtPaciente.Dispose()
            objBDatos.Dispose()

        End Try

        Return dtPaciente

    End Function


    Friend Function GuardarLocalizacion(ByVal iTipoMantenimiento As eTiposMantenimiento, ByVal sLocalizacion As String, ByVal iIDLocalizacion As Integer, Optional ByRef iIDNuevaLoc As Integer = 0) As Boolean

        Dim objBDatos As New AccesoBD_MySQL()
        Dim iNumFilas As Integer = 0
        Dim bOK As Boolean

        Try
            With objBDatos
                bOK = .AbrirConexion

                If bOK Then
                    bOK = .IniciarTransaccion

                    If bOK Then
                        Dim arrParametros(1) As MySqlParameter

                        'ReDim arrParametros(0)

                        arrParametros(0) = New MySqlParameter()
                        With arrParametros(0)
                            .ParameterName = "sLocalizacion"
                            .MySqlDbType = MySqlDbType.VarChar
                            .Size = 100
                            .Value = sLocalizacion
                            .Direction = ParameterDirection.Input
                        End With

                        ' Dependiendo del tipo de mantenimiento, INSERT o UPDATE
                        Select Case iTipoMantenimiento
                            Case eTiposMantenimiento.Alta
                                arrParametros(1) = New MySqlParameter()
                                With arrParametros(1)
                                    .ParameterName = "iIDLocalizacion"
                                    .MySqlDbType = MySqlDbType.Int32
                                    .Size = 4
                                    .Direction = ParameterDirection.Output
                                End With

                                bOK = .EjecutarSP("spLocalizaciones_Anadir", arrParametros)

                                If bOK Then
                                    iIDNuevaLoc = arrParametros(1).Value
                                End If

                            Case eTiposMantenimiento.Modificacion
                                'ReDim Preserve arrParametros(1)

                                arrParametros(1) = New MySqlParameter()
                                With arrParametros(1)
                                    .ParameterName = "iIDLocalizacion"
                                    .MySqlDbType = MySqlDbType.Int32
                                    .Size = 4
                                    .Value = iIDLocalizacion
                                    .Direction = ParameterDirection.Input
                                End With

                                bOK = .EjecutarSP("spLocalizaciones_Modificar", arrParametros)
                        End Select

                        If bOK Then
                            bOK = .ConfirmarTransaccion
                        Else
                            bOK = .CancelarTransaccion
                        End If
                    End If

                    bOK = .CerrarConexion
                End If
            End With

        Catch exError As Exception
            GestionarErrores(exError.Message, "Patología - Localización", MessageBoxIcon.Error, EventLogEntryType.Error)

            bOK = False

        Finally
            'Descargar objetos
            objBDatos.Dispose()

        End Try

        Return bOK

    End Function


    Friend Function GuardarLesion(ByVal iTipoMantenimiento As eTiposMantenimiento, ByVal sLesion As String, ByVal iIDLesion As Integer, Optional ByRef iIDNuevaLes As Integer = 0) As Boolean

        Dim objBDatos As New AccesoBD_MySQL()
        Dim iNumFilas As Integer = 0
        Dim bOK As Boolean

        Try
            With objBDatos
                bOK = .AbrirConexion

                If bOK Then
                    bOK = .IniciarTransaccion

                    If bOK Then
                        Dim arrParametros(1) As MySqlParameter

                        'ReDim arrParametros(0)

                        arrParametros(0) = New MySqlParameter()
                        With arrParametros(0)
                            .ParameterName = "sLesion"
                            .MySqlDbType = MySqlDbType.VarChar
                            .Size = 100
                            .Value = sLesion
                            .Direction = ParameterDirection.Input
                        End With

                        ' Dependiendo del tipo de mantenimiento, INSERT o UPDATE
                        Select Case iTipoMantenimiento
                            Case eTiposMantenimiento.Alta
                                arrParametros(1) = New MySqlParameter()
                                With arrParametros(1)
                                    .ParameterName = "iIDLesion"
                                    .MySqlDbType = MySqlDbType.Int32
                                    .Size = 4
                                    .Direction = ParameterDirection.Output
                                End With

                                bOK = .EjecutarSP("spLesiones_Anadir", arrParametros)

                                If bOK Then
                                    iIDNuevaLes = arrParametros(1).Value
                                End If

                            Case eTiposMantenimiento.Modificacion
                                'ReDim Preserve arrParametros(1)

                                arrParametros(1) = New MySqlParameter()
                                With arrParametros(1)
                                    .ParameterName = "iIDLesion"
                                    .MySqlDbType = MySqlDbType.Int32
                                    .Size = 4
                                    .Value = iIDLesion
                                    .Direction = ParameterDirection.Input
                                End With

                                bOK = .EjecutarSP("spLesiones_Modificar", arrParametros)
                        End Select

                        If bOK Then
                            bOK = .ConfirmarTransaccion
                        Else
                            bOK = .CancelarTransaccion
                        End If
                    End If

                    bOK = .CerrarConexion
                End If
            End With

        Catch exError As Exception
            GestionarErrores(exError.Message, "Patología - Lesión", MessageBoxIcon.Error, EventLogEntryType.Error)

            bOK = False

        Finally
            'Descargar objetos
            objBDatos.Dispose()

        End Try

        Return bOK

    End Function

    ''' <summary>
    ''' Recuperar los Pacientes de la BD
    ''' </summary>
    ''' <remarks></remarks>
    Friend Sub RecuperarPacientes()

        Dim objBDatos As New AccesoBD_MySQL()
        Dim iNumPacientes As Integer
        Dim bOKControl As Boolean = False
        Dim bOK As Boolean

        Try
            With objBDatos
                bOK = .AbrirConexion()

                If bOK Then
                    Dim arrParametros(0) As MySqlParameter

                    arrParametros(0) = New MySqlParameter()
                    With arrParametros(0)
                        .ParameterName = "iTipo"
                        .MySqlDbType = MySqlDbType.Byte
                        .Size = 3
                        .Value = eTiposRellenoPacientes.Todos
                        .Direction = ParameterDirection.Input
                    End With

                    dtPacientes.Rows.Clear()

                    bOK = .EjecutarSP("spPacientes_LLenar", arrParametros, dtPacientes, iNumPacientes)

                    If bOK Then
                        CambioTablaPacientes = True
                    End If

                    'If bOK Then
                    '    If iNumPacientes > 0 Then
                    '        bOKControl = True
                    '    End If
                    'End If

                    bOK = .CerrarConexion
                End If
            End With

        Catch exError As Exception
            GestionarErrores(exError.Message, "General", MessageBoxIcon.Error, EventLogEntryType.Error)

        End Try

    End Sub


    Friend Function CargarFisios() As DataTable

        Dim objBDatos As New AccesoBD_MySQL()
        Dim dtFisios As New DataTable("Fisios")
        Dim iNumFisios As Integer
        Dim bOK As Boolean

        Try
            With objBDatos
                bOK = .AbrirConexion

                If bOK Then
                    Dim arrParametros(0) As MySqlParameter

                    arrParametros(0) = New MySqlParameter()
                    With arrParametros(0)
                        .ParameterName = "iIDFisio"
                        .MySqlDbType = MySqlDbType.Int32
                        .Size = 4
                        .Value = DBNull.Value
                        .Direction = ParameterDirection.Input
                    End With

                    bOK = .EjecutarSP("spFisios_LLenar", arrParametros, dtFisios, iNumFisios)

                    bOK = .CerrarConexion
                End If
            End With

        Catch exError As Exception
            GestionarErrores(exError.Message, "General", MessageBoxIcon.Error, EventLogEntryType.Error)

            bOK = False

        Finally
            objBDatos.Dispose()

        End Try

        Return dtFisios

    End Function



End Module
