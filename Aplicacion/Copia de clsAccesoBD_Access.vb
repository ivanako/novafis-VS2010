Option Strict On
Option Explicit On 

Imports System.Data.OleDb

Public Class AccesoBD_Access

    ' Constante identificadora de la clase
    Private Const cteModulo As String = "Acceso a Datos"

    ' Conexión utilizada para acceder a la BD
    Private m_objConexion As OleDbConnection

    ' Variable que guarda la transacción
    Private m_objTransaccion As OleDbTransaction

    ' Número de conexiones abiertas
    Private m_iNumConexiones As Short

    ' Numero de transacciones
    Private m_iNumTransacciones As Short

    ' Variable para controlar la descarga de la clase
    Private m_bEliminando As Boolean = False

#Region " CONEXION "

    ' Abre una conexión a través de un archivo UDL
    Public Function AbrirConexion() As Boolean

        Dim sRutaUDL As String
        Dim bOK As Boolean
        'Application.ExecutablePath()
        Try
            ' Comprobamos si el objeto está instanciado
            If m_objConexion Is Nothing Then
                'Ruta completa del fichero UDL (equivalente a App.Path)
                sRutaUDL = System.AppDomain.CurrentDomain.BaseDirectory()
                sRutaUDL &= LeerConfiguracion("FicheroUDL")

                ' Instanciar una nueva conexión
                'm_objConexion = New OleDbConnection("FILE NAME=" & sRutaUDL)
                m_objConexion = New OleDbConnection(LeerConfiguracion("CadenaConexionOLEDB"))

                ' Abrir la conexión
                m_objConexion.Open()

                ' Inicializa las conexiones o instancias a 1
                m_iNumConexiones = 1

                ' Inicializa a cero el número de transacciones
                m_iNumTransacciones = 0

            Else
                ' El objeto ya está instanciado y la conexión física abierta.
                ' por tanto incrementamos en uno el número de instancias o conexiones virtuales
                m_iNumConexiones = CShort(m_iNumConexiones + 1)
            End If

            bOK = True

        Catch exErrorBD As OleDbException
            ' Error de Base de Datos
            GestionarErrores("Error de Base de Datos:" & ControlChars.NewLine & exErrorBD.Message, cteModulo, MessageBoxIcon.Error, EventLogEntryType.Error)

            ' Si se ha llegado a abrir conexión, se cierra
            If Not IsNothing(m_objConexion) Then
                m_objConexion.Close()
                m_iNumConexiones = 0
            End If

            m_objConexion.Dispose()

            bOK = False

        Catch exError As Exception
            ' Error VB.NET
            GestionarErrores(exError.Message, cteModulo, MessageBoxIcon.Error, EventLogEntryType.Error)

            ' Si se ha llegado a abrir conexión, se cierra
            If Not IsNothing(m_objConexion) Then
                m_objConexion.Close()
                m_iNumConexiones = 0
            End If

            m_objConexion.Dispose()

            bOK = False

        Finally

        End Try

        Return bOK

    End Function


    Public Function CerrarConexion() As Boolean

        Dim bOK As Boolean

        Try
            ' Comprueba que sea la única instancia que está usando la conexión
            If m_iNumConexiones = 1 Then

                ' Si hay alguna transacción activa la deshace, porque será por
                ' un error que el usuario no lo haya hecho ya
                If m_iNumTransacciones > 0 Then
                    m_objTransaccion.Rollback()
                End If

                ' Cierra la conexión física
                m_objConexion.Close()

                ' Libera el objeto
                m_objConexion.Dispose()

                ' Controla el número de conexiones
                m_iNumConexiones = 0

            Else
                ' En caso contrario, disminuye en uno el número de instancias o conexiones
                ' que están usando la conexión física
                If m_iNumConexiones > 0 Then
                    m_iNumConexiones = CShort(m_iNumConexiones - 1)
                End If
            End If

            bOK = True

        Catch exErrorBD As OleDbException
            ' Error de Base de Datos
            GestionarErrores("Error de Base de Datos:" & ControlChars.NewLine & exErrorBD.Message, cteModulo, MessageBoxIcon.Error, EventLogEntryType.Error)

            ' Si hay transacción, deshacerla
            If Not IsNothing(m_objTransaccion) Then
                m_objTransaccion.Rollback()
                m_iNumTransacciones = 0
            End If

            ' Si se ha llegado a abrir conexión, se cierra
            If Not IsNothing(m_objConexion) Then
                m_objConexion.Close()
                m_iNumConexiones = 0
            End If

            m_objConexion.Dispose()

            bOK = False

        Catch exError As Exception
            ' Error VB.NET
            GestionarErrores(exError.Message, cteModulo, MessageBoxIcon.Error, EventLogEntryType.Error)

            ' Si hay transacción, deshacerla
            If Not IsNothing(m_objTransaccion) Then
                m_objTransaccion.Rollback()
                m_iNumTransacciones = 0
            End If

            ' Si se ha llegado a abrir conexión, se cierra
            If Not IsNothing(m_objConexion) Then
                m_objConexion.Close()
                m_iNumConexiones = 0
            End If

            m_objConexion.Dispose()

            bOK = False

        Finally

        End Try

        Return bOK

    End Function

#End Region

    ' Ejecuta un SP que devuelve una lista, la cual se mete en un DataTable
    ' Se usa para consultas de selección (SELECT)
    Public Overloads Function EjecutarSP(ByVal sNombreSP As String, ByRef arrParametros() As OleDbParameter, ByRef dtDatos As DataTable, ByRef iNumFilas As Integer) As Boolean

        Dim objComando As New OleDbCommand()
        Dim objAdaptador As New OleDbDataAdapter()

        Dim bOK As Boolean
        Dim iCont As Integer

        Try
            With objComando
                .Connection = m_objConexion      ' Asignar la conexión

                ' Por defecto 300 segundos
                '.CommandTimeout = 300

                ' Un procedimiento almacenado
                .CommandType = CommandType.StoredProcedure

                'Procedimiento almacenado a ejecutar
                .CommandText = sNombreSP

                ' Si hay transacción asignársela al comando
                If m_iNumTransacciones > 0 Then
                    .Transaction = m_objTransaccion
                End If

                If Not IsNothing(arrParametros) Then
                    ' Llenar la colección de parámetros del comando
                    For iCont = 0 To arrParametros.Length - 1
                        .Parameters.Add(arrParametros(iCont))
                    Next iCont
                End If

                ' Ejecutar el comando
                objAdaptador.SelectCommand = objComando
                iNumFilas = objAdaptador.Fill(dtDatos)

                If Not IsNothing(arrParametros) Then
                    For iCont = 0 To arrParametros.Length - 1
                        If arrParametros(iCont).Direction = ParameterDirection.Output Then
                            arrParametros(iCont).Value = .Parameters.Item(iCont).Value
                        End If
                    Next iCont
                End If
            End With

            bOK = True

        Catch exErrorBD As MySqlException
            ' Error de Base de Datos
            MessageBox.Show("Error al Abrir Conexión:" & ControlChars.NewLine & exErrorBD.Message, "Acceso a datos", MessageBoxButtons.OK, MessageBoxIcon.Error)

            ' Si se ha llegado a abrir alguna transacción, se cierra
            If Not IsNothing(m_objTransaccion) Then
                m_objTransaccion.Rollback()
                m_iNumTransacciones = 0
            End If

            ' Si se ha llegado a abrir conexión, se cierra
            If Not IsNothing(m_objConexion) Then
                m_objConexion.Close()
                m_iNumConexiones = 0
            End If

            m_objConexion.Dispose()

            bOK = False

        Catch exError As Exception
            ' Error VB.NET
            MessageBox.Show(exError.Message, "Acceso a datos", MessageBoxButtons.OK, MessageBoxIcon.Error)

            ' Si se ha llegado a abrir alguna transacción, se cierra
            If Not IsNothing(m_objTransaccion) Then
                m_objTransaccion.Rollback()
                m_iNumTransacciones = 0
            End If

            ' Si se ha llegado a abrir conexión, se cierra
            If Not IsNothing(m_objConexion) Then
                m_objConexion.Close()
                m_iNumConexiones = 0
            End If

            m_objConexion.Dispose()

            bOK = False

        Finally
            objComando.Dispose()

        End Try

        Return bOK

    End Function


#Region " CONSULTAS SQL "

    ' Ejecuta una consulta de T-SQL que devuelve una lista, la cual se mete en un DataTable
    ' Se usa para consultas de selección (SELECT)
    Public Overloads Function EjecutarConsultaSQL(ByVal sSQL As String, ByRef dtDatos As DataTable, Optional ByRef iNumFilas As Integer = 0) As Boolean

        Dim cmmComando As New OleDbCommand()
        Dim objAdaptador As New OleDbDataAdapter()
        Dim bOK As Boolean

        Try
            With cmmComando
                .Connection = m_objConexion      ' Asignar la conexión

                ' Se deja sin rellenar por si se quiere cambiar en el futuro.
                ' Por defecto son 30 segundos
                '.CommandTimeout = 30

                ' Texto a ejecutar
                .CommandType = CommandType.Text

                ' Asignar el texto al comando
                .CommandText = sSQL

                'Si hay alguna transacción abierta, asignársela al comando
                If m_iNumTransacciones > 0 Then
                    .Transaction = m_objTransaccion
                End If
            End With

            ' Asignar el comando al Adaptador
            objAdaptador.SelectCommand = cmmComando

            ' Ejecutar el comando
            iNumFilas = objAdaptador.Fill(dtDatos)

            bOK = True

        Catch exErrorBD As OleDbException
            ' Error de Base de Datos
            GestionarErrores("Error de Base de Datos:" & ControlChars.NewLine & exErrorBD.Message, cteModulo, MessageBoxIcon.Error, EventLogEntryType.Error)

            If Not IsNothing(m_objConexion) And m_iNumConexiones = 0 Then
                m_objConexion.Close()
                m_iNumConexiones = 0
            End If

            bOK = False

        Catch exError As Exception
            ' Error VB.NET
            GestionarErrores(exError.Message, cteModulo, MessageBoxIcon.Error, EventLogEntryType.Error)

            If Not IsNothing(m_objConexion) Then
                m_objConexion.Close()
                m_iNumConexiones = 0
            End If

            bOK = False

        Finally
            If Not IsNothing(objAdaptador) Then
                objAdaptador.Dispose()
            End If

            cmmComando.Dispose()

        End Try

        Return bOK

    End Function


    ' Ejecuta una consulta de T-SQL que devuelve un valor, en principio sin importar el tipo
    ' Se usa para cuando se devuelven agregados (COUNT, MAX, MIN, ...)
    Public Overloads Function EjecutarConsultaSQL(ByVal sSQL As String, ByRef sValor As String) As Boolean

        Dim cmmComando As New OleDbCommand()
        Dim bOK As Boolean

        Try
            With cmmComando
                .Connection = m_objConexion      ' Asignar la conexión

                ' Se deja sin rellenar por si se quiere cambiar en el futuro.
                ' Por defecto son 30 segundos
                '.CommandTimeout = 30

                ' Texto a ejecutar
                .CommandType = CommandType.Text

                ' Asignar el texto al comando
                .CommandText = sSQL

                'Si hay alguna transacción abierta, asignársela al comando
                If m_iNumTransacciones > 0 Then
                    .Transaction = m_objTransaccion
                End If

                'Devuelve el valor de la primera celda únicamente
                sValor = CType(.ExecuteScalar, String)
            End With

            bOK = True

        Catch exErrorBD As OleDbException
            ' Error de Base de Datos
            GestionarErrores("Error de Base de Datos:" & ControlChars.NewLine & exErrorBD.Message, cteModulo, MessageBoxIcon.Error, EventLogEntryType.Error)

            If Not IsNothing(m_objConexion) And m_iNumConexiones = 0 Then
                m_objConexion.Close()
                m_iNumConexiones = 0
            End If

            bOK = False

        Catch exError As Exception
            ' Error VB.NET
            GestionarErrores(exError.Message, cteModulo, MessageBoxIcon.Error, EventLogEntryType.Error)

            If Not IsNothing(m_objConexion) Then
                m_objConexion.Close()
                m_iNumConexiones = 0
            End If

            bOK = False

        Finally
            cmmComando.Dispose()

        End Try

        Return bOK

    End Function


    ' Ejecuta una consulta de T-SQL que no devuelve nada
    ' Se usa para consultas de modificación de datos: INSERT, UPDATE, DELETE
    Public Overloads Function EjecutarConsultaSQL(ByVal sSQL As String, Optional ByRef iNumFilas As Integer = 0) As Boolean

        Dim cmmComando As New OleDbCommand()
        Dim bOK As Boolean

        Try
            With cmmComando
                .Connection = m_objConexion      ' Asignar la conexión

                ' Se deja sin rellenar por si se quiere cambiar en el futuro.
                ' Por defecto son 30 segundos
                '.CommandTimeout = 30

                ' Texto a ejecutar
                .CommandType = CommandType.Text

                ' Asignar el texto al comando
                .CommandText = sSQL

                'Si hay alguna transacción abierta, asignársela al comando
                If m_iNumTransacciones > 0 Then
                    .Transaction = m_objTransaccion
                End If

                ' Devuelve el número de filas afectadas
                iNumFilas = .ExecuteNonQuery()
            End With

            bOK = True

        Catch exErrorBD As OleDbException
            ' Error de Base de Datos
            GestionarErrores("Error de Base de Datos:" & ControlChars.NewLine & exErrorBD.Message, cteModulo, MessageBoxIcon.Error, EventLogEntryType.Error)

            If Not IsNothing(m_objConexion) And m_iNumConexiones = 0 Then
                m_objConexion.Close()
                m_iNumConexiones = 0
            End If

            bOK = False

        Catch exError As Exception
            ' Error VB.NET
            GestionarErrores(exError.Message, cteModulo, MessageBoxIcon.Error, EventLogEntryType.Error)

            If Not IsNothing(m_objConexion) Then
                m_objConexion.Close()
                m_iNumConexiones = 0
            End If

            bOK = False

        Finally
            cmmComando.Dispose()

        End Try

        Return bOK

    End Function

#End Region


#Region " TRANSACCIONES "

    ' Abre una transacción
    Public Function IniciarTransaccion() As Boolean

        Dim bOK As Boolean

        Try
            If m_iNumTransacciones = 0 Then
                m_objTransaccion = m_objConexion.BeginTransaction()
            End If

            ' Aumenta en uno el número de transacciones abiertas
            m_iNumTransacciones = CShort(m_iNumTransacciones + 1)

            bOK = True

        Catch exErrorBD As OleDbException
            ' Error de Base de Datos
            GestionarErrores("Error de Base de Datos:" & ControlChars.NewLine & exErrorBD.Message, cteModulo, MessageBoxIcon.Error, EventLogEntryType.Error)

            If Not IsNothing(m_objTransaccion) Then
                m_objTransaccion.Rollback()
                m_iNumTransacciones = 0
            End If

            If Not IsNothing(m_objConexion) Then
                m_objConexion.Close()
                m_iNumConexiones = 0
            End If

            ' Libera el objeto
            'm_objConexion.Dispose()

            bOK = False

        Catch exError As Exception
            ' Error VB.NET
            GestionarErrores(exError.Message, cteModulo, MessageBoxIcon.Error, EventLogEntryType.Error)

            If Not IsNothing(m_objTransaccion) Then
                m_objTransaccion.Rollback()
                m_iNumTransacciones = 0
            End If

            If Not IsNothing(m_objConexion) Then
                m_objConexion.Close()
                m_iNumConexiones = 0
            End If

            ' Libera el objeto
            'm_objConexion.Dispose()

            bOK = False

        Finally

        End Try

        Return bOK

    End Function

    ' Ejecuta una transacción
    Public Function ConfirmarTransaccion() As Boolean

        Dim bOK As Boolean

        Try
            If m_iNumTransacciones = 1 Then
                m_objTransaccion.Commit()
            End If

            If m_iNumTransacciones <> 0 Then
                ' Descuenta una transacción
                m_iNumTransacciones = CShort(m_iNumTransacciones - 1)
            End If

            bOK = True

        Catch exErrorBD As OleDbException
            ' Error de Base de Datos
            GestionarErrores("Error de Base de Datos:" & ControlChars.NewLine & exErrorBD.Message, cteModulo, MessageBoxIcon.Error, EventLogEntryType.Error)

            If Not IsNothing(m_objTransaccion) Then
                m_objTransaccion.Rollback()
                m_iNumTransacciones = 0
            End If

            If Not IsNothing(m_objConexion) Then
                m_objConexion.Close()
                m_iNumConexiones = 0
            End If

            ' Libera el objeto
            'm_objConexion.Dispose()

            bOK = False

        Catch exError As Exception
            ' Error VB.NET
            GestionarErrores(exError.Message, cteModulo, MessageBoxIcon.Error, EventLogEntryType.Error)

            If Not IsNothing(m_objTransaccion) Then
                m_objTransaccion.Rollback()
                m_iNumTransacciones = 0
            End If

            If Not IsNothing(m_objConexion) Then
                m_objConexion.Close()
                m_iNumConexiones = 0
            End If

            ' Libera el objeto
            'm_objConexion.Dispose()

            bOK = False

        Finally

        End Try

        Return bOK

    End Function

    ' Aborta una transacción
    Public Function CancelarTransaccion() As Boolean

        Dim bOK As Boolean

        Try
            If m_iNumTransacciones = 1 Then
                m_objTransaccion.Rollback()
            End If

            If m_iNumTransacciones <> 0 Then
                ' Descuenta una transacción
                m_iNumTransacciones = CShort(m_iNumTransacciones - 1)
            End If

            bOK = True

        Catch exErrorBD As OleDbException
            ' Error de Base de Datos
            GestionarErrores("Error de Base de Datos:" & ControlChars.NewLine & exErrorBD.Message, cteModulo, MessageBoxIcon.Error, EventLogEntryType.Error)

            If Not IsNothing(m_objTransaccion) Then
                m_objTransaccion.Rollback()
                m_iNumTransacciones = 0
            End If

            If Not IsNothing(m_objConexion) Then
                m_objConexion.Close()
                m_iNumConexiones = 0
            End If

            ' Libera el objeto
            'm_objConexion.Dispose()

            bOK = False

        Catch exError As Exception
            ' Error VB.NET
            GestionarErrores(exError.Message, cteModulo, MessageBoxIcon.Error, EventLogEntryType.Error)

            If Not IsNothing(m_objTransaccion) Then
                m_objTransaccion.Rollback()
                m_iNumTransacciones = 0
            End If

            If Not IsNothing(m_objConexion) Then
                m_objConexion.Close()
                m_iNumConexiones = 0
            End If

            ' Libera el objeto
            'm_objConexion.Dispose()

            bOK = False

        Finally

        End Try

        Return bOK

    End Function

#End Region


#Region " DESCARGAR CLASE "

    ' Descarga la clase
    Public Overloads Sub Dispose()

        Dispose(True)

        ' Indicar al Garbage Collector que nosotros eliminamos las referencias usadas
        ' Con esto se evitan bucles de llamadas
        GC.SuppressFinalize(Me)

    End Sub

    Private Overloads Sub Dispose(ByVal bCerrar As Boolean)

        If Not m_bEliminando Then

            ' Eliminar todos los recursos
            If bCerrar Then
                If Not IsNothing(m_objConexion) Then
                    m_objConexion.Dispose()
                End If
            End If

            ' Colocar el flag por si otro hilo de ejecución
            ' intenta hacer lo mismo
            m_bEliminando = True
        End If

    End Sub

#End Region


End Class
