Public Class frmListaNegra

    Private Const cteModulo As String = "Lista Negra"

    'Variable para controlar el número de instancias abiertas
    Private Shared objInstancia As frmListaNegra = Nothing

    'Función que crea una sola instancia del formulario de Pacientes
    Public Shared Function Instancia() As frmListaNegra

        If IsNothing(objInstancia) OrElse objInstancia.IsDisposed = True Then
            objInstancia = New frmListaNegra()
        End If

        objInstancia.BringToFront()

        Return objInstancia

    End Function





    Private Sub frmListaNegra_Enter(sender As System.Object, e As System.EventArgs) Handles MyBase.Enter
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub frmListaNegra_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim colPacientes As AutoCompleteStringCollection = listaPacientes()

        With txtPacientes
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.CustomSource
            .AutoCompleteCustomSource = colPacientes
        End With

        llenarListaNegra()

        grbPaciente.Enabled = False
    End Sub

    Private Sub dtgListaNegra_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles dtgListaNegra.MouseDown

        Dim objHitTest As DataGrid.HitTestInfo
        Dim iCont As Integer
        Dim iRow As Integer
        Dim iCol As Integer

        ' Recuperar el objeto de click
        objHitTest = dtgListaNegra.HitTest(e.X, e.Y)

        ' Recuperar filas y columnas
        iCol = objHitTest.Column
        iRow = objHitTest.Row

        ' Miramos si se ha pulsado en una celda de la columna de selección
        If objHitTest.Type = DataGrid.HitTestType.Cell Then ' And iCol = 0 Then
            Dim bSeleccionar As Boolean = Not CType(dtgListaNegra.Item(iRow, 0), Boolean)

            If bSeleccionar Then
                ' Recorrer poniendo a falso las columnas
                For iCont = 0 To CType(dtgListaNegra.DataSource, DataTable).Rows.Count - 1
                    If CBool(dtgListaNegra.Item(iCont, 0)) Then
                        dtgListaNegra.Item(iCont, 0) = False
                        Exit For
                    End If
                Next iCont

                ' Cambiar el valor a verdadero
                dtgListaNegra.Item(iRow, 0) = True
            Else
                dtgListaNegra.Item(iRow, 0) = False
            End If
        End If

        mOKEliminar()
    End Sub

    Private Sub dtgListaNegra_MouseUp(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles dtgListaNegra.MouseUp
        Dim objTest As DataGrid.HitTestInfo = dtgListaNegra.HitTest(New Point(e.X, e.Y))

        ' Si es una celda
        If objTest.Type = DataGrid.HitTestType.Cell Then
            dtgListaNegra.Select(objTest.Row)
        End If
    End Sub

    Private Sub cmdAnadir_Click(sender As System.Object, e As System.EventArgs) Handles cmdAnadir.Click
        grbPaciente.Enabled = True
        txtPacientes.Text = String.Empty
        txtPacientes.Focus()
        cmdGuardar.Enabled = False
        cmdAnadir.Enabled = False
    End Sub

    Private Sub cmdEliminar_Click(sender As System.Object, e As System.EventArgs) Handles cmdEliminar.Click
        Dim idPaciente As Integer = Integer.Parse(dtgListaNegra.Item(dtgListaNegra.CurrentRowIndex, 2).ToString)

        If MessageBox.Show("Se va eliminar un Paciente de la Lista Negra", "Lista Negra", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            actualizarListaNegra(idPaciente, False)
        End If

    End Sub

    Private Sub cmdCerrar_Click(sender As System.Object, e As System.EventArgs) Handles cmdCerrar.Click
        Me.Dispose()
    End Sub




    Private Sub txtPacientes_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtPacientes.KeyDown
        If e.KeyData = Keys.Enter Or e.KeyData = Keys.LButton Then
            txtPacientes.Tag = txtPacientes.Text.Substring(txtPacientes.Text.Length - 10).Trim
            txtPacientes.Text = txtPacientes.Text.Substring(0, txtPacientes.Text.Length - 10).Trim
            txtPacientes.Select(0, 0)

            cmdGuardar.Enabled = (txtPacientes.Text.Length > 0)
        End If
    End Sub

    Private Sub cmdGuardar_Click(sender As System.Object, e As System.EventArgs) Handles cmdGuardar.Click
        actualizarListaNegra(txtPacientes.Tag.ToString, True)
    End Sub

    Private Sub cmdCancelar_Click(sender As System.Object, e As System.EventArgs) Handles cmdCancelar.Click
        txtPacientes.Text = String.Empty
        txtPacientes.Tag = Nothing
        cmdGuardar.Enabled = False
        grbPaciente.Enabled = False
        cmdAnadir.Enabled = True
    End Sub


    Private arrCamposListaNegra() As String = {"SEL", "PAC_NombreCompleto", "PAC_ID"}
    Private arrCabecerasListaNegra() As String = {"Sel.", "Paciente", String.Empty}
    Private arrTiposDatosListaNegra() As String = {"B", "S", "I"}
    Private arrAnchurasListaNegra() As Integer = {50, 300, 0}

    ''' <summary>
    ''' Obtiene la lista de los Pacientes registrados
    ''' </summary>
    ''' <returns>Colección de Pacientes</returns>
    ''' <remarks></remarks>
    Private Function listaPacientes() As AutoCompleteStringCollection

        Dim colPacientes As New AutoCompleteStringCollection

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
                        .Value = eTiposRellenoPacientes.ListaNegra
                        .Direction = ParameterDirection.Input
                    End With

                    arrParametros(1) = New MySqlParameter()
                    With arrParametros(1)
                        .ParameterName = "sNombreCompleto"
                        .MySqlDbType = MySqlDbType.VarChar
                        .Size = 200
                        .Value = String.Empty
                        .Direction = ParameterDirection.Input
                    End With

                    arrParametros(2) = New MySqlParameter()
                    With arrParametros(2)
                        .ParameterName = "sNombre"
                        .MySqlDbType = MySqlDbType.VarChar
                        .Size = 50
                        .Value = String.Empty
                        .Direction = ParameterDirection.Input
                    End With

                    arrParametros(3) = New MySqlParameter()
                    With arrParametros(3)
                        .ParameterName = "sApellido1"
                        .MySqlDbType = MySqlDbType.VarChar
                        .Size = 50
                        .Value = String.Empty
                        .Direction = ParameterDirection.Input
                    End With

                    arrParametros(4) = New MySqlParameter()
                    With arrParametros(4)
                        .ParameterName = "sApellido2"
                        .MySqlDbType = MySqlDbType.VarChar
                        .Size = 50
                        .Value = String.Empty
                        .Direction = ParameterDirection.Input
                    End With

                    bOK = .EjecutarSP("spPacientes_LLenar", arrParametros, dtPacientes, iNumPacientes)

                    bOK = .CerrarConexion
                End If
            End With

            If dtPacientes.Rows.Count > 0 Then
                For Each drPaciente As DataRow In dtPacientes.Rows
                    Dim nombrePaciente As New System.Text.StringBuilder
                    nombrePaciente.Append(drPaciente(1).ToString())
                    nombrePaciente.Append(New String(" ", 200))
                    nombrePaciente.Append(drPaciente(0).ToString())

                    colPacientes.Add(nombrePaciente.ToString())
                Next drPaciente
            End If

        Catch exError As Exception
            GestionarErrores(exError.Message, "Llenar Pacientes", MessageBoxIcon.Error, EventLogEntryType.Error)

        Finally
            ' Descargar objetos
            dtPacientes.Dispose()
            objBDatos.Dispose()

        End Try

        Return colPacientes

    End Function

    Private Sub llenarListaNegra()

        Dim objBDatos As New AccesoBD_MySQL()
        Dim iNumPacientes As Integer
        Dim bOK As Boolean

        Dim dtListaNegra As New DataTable("ListaNegra")

        Try
            With objBDatos
                bOK = .AbrirConexion()

                If bOK Then

                    bOK = .EjecutarSP("spPacientes_ListaNegra_Llenar", Nothing, dtListaNegra, iNumPacientes)

                    If bOK Then
                        If iNumPacientes > 0 Then
                            ' Incluir la columna de Selección
                            'If dtFacturas.Columns.Count <> 4 Then
                            NovafisDataGrid.ColumnaSeleccion(dtListaNegra)
                            'End If

                            dtgListaNegra.SetDataBinding(dtListaNegra, String.Empty)

                            NovafisDataGrid.EstiloGrid(arrCamposListaNegra, arrCabecerasListaNegra, arrTiposDatosListaNegra, arrAnchurasListaNegra, dtgListaNegra, "ListaNegra")
                        End If
                    End If

                    bOK = .CerrarConexion
                End If
            End With

        Catch exError As Exception
            GestionarErrores(exError.Message, cteModulo, MessageBoxIcon.Error, EventLogEntryType.Error)

            bOK = False

        Finally
            ' Descargar objetos
            'dtFisios.Dispose()
            objBDatos.Dispose()

        End Try
    End Sub

    Private Sub actualizarListaNegra(ByVal idPaciente As Integer, ByVal bAnadir As Boolean)

        Dim objBDatos As New AccesoBD_MySQL()
        Dim bOK As Boolean
        Dim bControl As Boolean

        cmdGuardar.Enabled = False

        Try
            bControl = False

            With objBDatos
                bOK = .AbrirConexion

                If bOK Then
                    bOK = .IniciarTransaccion

                    If bOK Then
                        Dim arrParametros(1) As MySqlParameter

                        arrParametros(0) = New MySqlParameter()
                        With arrParametros(0)
                            .ParameterName = "iIDPaciente"
                            .MySqlDbType = MySqlDbType.Int32
                            .Size = 4
                            .Value = idPaciente
                            .Direction = ParameterDirection.Input
                        End With

                        arrParametros(1) = New MySqlParameter()
                        With arrParametros(1)
                            .ParameterName = "bAccion"
                            .MySqlDbType = MySqlDbType.Byte
                            .Size = 1
                            .Value = IIf(bAnadir, 1, 0)
                            .Direction = ParameterDirection.Input
                        End With

                        bOK = .EjecutarSP("spPacientes_ListaNegra_Guardar", arrParametros)

                        If bOK Then
                            bOK = .ConfirmarTransaccion

                            If bOK Then
                                txtPacientes.Text = String.Empty
                                txtPacientes.Tag = Nothing
                                cmdGuardar.Enabled = False
                                grbPaciente.Enabled = False
                                cmdAnadir.Enabled = True

                                llenarListaNegra()
                            End If

                            bControl = True
                        Else
                            bOK = .CancelarTransaccion
                        End If
                    End If

                    bOK = .CerrarConexion
                End If
            End With

        Catch exError As Exception
            GestionarErrores(exError.Message, cteModulo, MessageBoxIcon.Error, EventLogEntryType.Error)

        End Try

        'Return bControl

    End Sub

    Private Sub mOKEliminar()

        Dim bOK As Boolean = False

        If Not IsNothing(dtgListaNegra.DataSource) Then
            If CType(dtgListaNegra.DataSource, DataTable).Rows.Count > 0 Then
                For Each drFila As DataRow In CType(dtgListaNegra.DataSource, DataTable).Rows
                    If CType(drFila("SEL"), Boolean) Then
                        bOK = True
                        Exit For
                    End If
                Next
            End If
        End If

        cmdEliminar.Enabled = bOK

    End Sub


End Class