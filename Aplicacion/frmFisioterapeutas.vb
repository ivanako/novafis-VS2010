Option Strict Off
Option Explicit On

Public Class frmFisioterapeutas

    Private Const cteModulo As String = "Fisioterapeutas"

    'Variable para controlar el número de instancias abiertas
    Private Shared objInstancia As frmFisioterapeutas = Nothing

    'Función que crea una sola instancia del formulario de Fisioterapeutas
    Public Shared Function Instancia() As frmFisioterapeutas

        If IsNothing(objInstancia) OrElse objInstancia.IsDisposed = True Then
            objInstancia = New frmFisioterapeutas()
        End If

        objInstancia.BringToFront()

        Return objInstancia

    End Function


    Private arrCamposFisios() As String = {"FIS_NombreApellido", "FIS_Alias", "FIS_FechaAlta", "FIS_Estado", "FIS_ID"}
    Private arrCabecerasFisios() As String = {"Fisioterapeuta", "Alias", "Fecha de Alta", "Estado", String.Empty}
    Private arrTiposDatosFisios() As String = {"S", "S", "F", "S", "I"}
    Private arrAnchurasFisios() As Integer = {250, 100, 100, 50, 0}

    Private TipoMantenimiento As eTiposMantenimiento
    Private IDFisio As Integer

    'Private dtFisios As DataTable = New DataTable("Fisios")


#Region " CONTROLES "

    Private Sub RestaurarFormulario(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub CargarFormulario(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.IDFisio = 0
        Me.TipoMantenimiento = eTiposMantenimiento.NoAsignado

        mLLenarFisios()

        grbFisio.Enabled = False

    End Sub


    Private Sub Cerrar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click
        Me.Dispose()
    End Sub


    Private Sub NavegarGrid(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgFisios.CurrentCellChanged
        dtgFisios.Select(dtgFisios.CurrentRowIndex)

        Me.IDFisio = Convert.ToInt32(dtgFisios.Item(dtgFisios.CurrentRowIndex, 4))
        mLLenarFisioDetalle(Me.IDFisio)
    End Sub

    Private Sub ModificarFisioSeleccionado(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgFisios.DoubleClick
        If cmdModificar.Enabled Then
            cmdModificar.PerformClick()
        End If
    End Sub

    Private Sub SeleccionarUnFisio(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtgFisios.MouseUp

        Dim objTest As DataGrid.HitTestInfo = dtgFisios.HitTest(New Point(e.X, e.Y))

        ' Si es una celda
        If objTest.Type = DataGrid.HitTestType.Cell Then
            dtgFisios.Select(objTest.Row)
            Me.IDFisio = Convert.ToInt32(dtgFisios.Item(dtgFisios.CurrentRowIndex, 4))
            mLLenarFisioDetalle(Me.IDFisio)
        Else
            mLimpiarCampos()
            grbFisio.Enabled = False
        End If

        ' Habilitar los botones Modificar y Eliminar cuando se seleccione una celda. No valen las cabeceras.
        cmdModificar.Enabled = (objTest.Type = DataGrid.HitTestType.Cell)
        cmdEliminar.Enabled = (objTest.Type = DataGrid.HitTestType.Cell)

    End Sub


    Private Sub NuevoFisio(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        mLimpiarCampos()
        dtpFBaja.Checked = False
        grbFisio.Enabled = True
        Me.TipoMantenimiento = eTiposMantenimiento.Alta
    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        grbFisio.Enabled = True
        Me.TipoMantenimiento = eTiposMantenimiento.Modificacion
    End Sub

    Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click
        If MessageBox.Show("Se va a Eliminar el Fisioterapeuta seleccionado. ¿Estás seguro?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            If mEliminarFisio() Then
                mLLenarFisios()
                mLimpiarCampos()
            End If
        End If
    End Sub

    Private Sub GuardarFisio(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        If mComprobarCampos() Then
            If mGuardarFisio() Then
                mLLenarFisios()
            End If

            grbFisio.Enabled = False
        End If
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        mLimpiarCampos()
        grbFisio.Enabled = False
    End Sub

#End Region


#Region " FUNCIONES "

    Private Sub mLLenarFisios()

        'Dim dtFisios As DataTable = CargarFisios()
        tblFisios = CargarFisios()

        Dim iNumFisios As Integer = tblFisios.Rows.Count

        If iNumFisios > 0 Then
            dtgFisios.SetDataBinding(tblFisios, String.Empty)

            NovafisDataGrid.EstiloGrid(arrCamposFisios, arrCabecerasFisios, arrTiposDatosFisios, arrAnchurasFisios, dtgFisios, "Fisios")

            'Dim objEstilo As New DataGridTableStyle()
            '' Asignar el datasource para conseguir las columnas
            'objEstilo.MappingName = "Fisios"

            '' Rellenar las propiedades generales del datagrid
            'With objEstilo

            '    For Each drFisio As DataRow In dtFisios.Rows
            '        If IsDBNull(drFisio("FIS_FechaBaja")) Then
            '            .ForeColor = Color.Green
            '        Else
            '            .ForeColor = Color.Red
            '        End If
            '    Next

            '    .SelectionBackColor = Color.Black
            '    .SelectionForeColor = Color.White
            '    .RowHeadersVisible = False
            '    .AllowSorting = True
            'End With

            '' Si el datagrid ya tiene estilos eliminarlos
            'If dtgFisios.TableStyles.Count > 0 Then
            '    dtgFisios.TableStyles.Remove(dtgFisios.TableStyles(0))
            'End If

            '' Añadir el nuevo tablestyle al datagrid
            'dtgFisios.TableStyles.Add(objEstilo)

            '' Eliminar los objetos
            'objEstilo.Dispose()

        End If

    End Sub

    Private Sub mLLenarFisioDetalle(ByVal iIDFisio As Integer)

        Dim objBDatos As New AccesoBD_MySQL()
        Dim dtFisioDetalle As New DataTable
        Dim iNumFisios As Integer
        Dim bOK As Boolean

        Try
            With objBDatos
                bOK = .AbrirConexion()

                If bOK Then
                    Dim arrParametros(0) As MySqlParameter

                    arrParametros(0) = New MySqlParameter()
                    With arrParametros(0)
                        .ParameterName = "iIDFisio"
                        .MySqlDbType = MySqlDbType.Int32
                        .Size = 4
                        .Value = iIDFisio
                        .Direction = ParameterDirection.Input
                    End With

                    bOK = .EjecutarSP("spFisios_LLenar", arrParametros, dtFisioDetalle, iNumFisios)

                    If bOK Then
                        If Not IsNothing(dtFisioDetalle) Then
                            If iNumFisios = 1 Then
                                Dim drFila As DataRow = dtFisioDetalle.Rows(0)

                                txtNombre.Text = drFila("FIS_Nombre").ToString.Trim
                                txtApellido1.Text = drFila("FIS_Apellido1").ToString.Trim
                                txtApellido2.Text = drFila("FIS_Apellido2").ToString.Trim

                                txtIdentificacion.Text = drFila("FIS_Identificacion").ToString.Trim
                                txtAlias.Text = drFila("FIS_Alias").ToString.Trim
                                txtNumColegiado.Text = drFila("FIS_NumColegiado").ToString.Trim

                                dtpFAlta.Value = DateTime.Parse(drFila("FIS_FechaAlta").ToString)

                                If IsDBNull(drFila("FIS_FechaBaja")) Then
                                    dtpFBaja.Checked = False
                                Else
                                    dtpFBaja.Value = DateTime.Parse(drFila("FIS_FechaBaja").ToString)
                                    dtpFBaja.Checked = True
                                End If

                                If IsDBNull(drFila("FIS_Sexo")) Then
                                    rdbHombre.Checked = False
                                    rdbMujer.Checked = False
                                Else
                                    If drFila("FIS_Sexo").ToString = cteHombre Then
                                        rdbHombre.Checked = True
                                    Else
                                        rdbMujer.Checked = True
                                    End If
                                End If
                            End If
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


    Private Function mGuardarFisio() As Boolean

        Dim objBDatos As New AccesoBD_MySQL()
        Dim bOK As Boolean = False

        Try
            With objBDatos
                bOK = .AbrirConexion

                If bOK Then
                    bOK = .IniciarTransaccion

                    If bOK Then
                        Dim arrParametros(9) As MySqlParameter

                        arrParametros(0) = New MySqlParameter()
                        With arrParametros(0)
                            .ParameterName = "iIDFisio"
                            .MySqlDbType = MySqlDbType.Int32
                            .Size = 4
                            .Value = IIf(Me.TipoMantenimiento = eTiposMantenimiento.Alta, 0, Me.IDFisio)
                            .Direction = ParameterDirection.Input
                        End With

                        arrParametros(1) = New MySqlParameter()
                        With arrParametros(1)
                            .ParameterName = "sNombre"
                            .MySqlDbType = MySqlDbType.VarChar
                            .Size = 50
                            .Value = txtNombre.Text.Trim
                            .Direction = ParameterDirection.Input
                        End With

                        arrParametros(2) = New MySqlParameter()
                        With arrParametros(2)
                            .ParameterName = "sApellido1"
                            .MySqlDbType = MySqlDbType.VarChar
                            .Size = 50
                            .Value = txtApellido1.Text.Trim
                            .Direction = ParameterDirection.Input
                        End With

                        arrParametros(3) = New MySqlParameter()
                        With arrParametros(3)
                            .ParameterName = "sApellido2"
                            .MySqlDbType = MySqlDbType.VarChar
                            .Size = 50
                            .Value = txtApellido2.Text.Trim
                            .Direction = ParameterDirection.Input
                        End With

                        arrParametros(4) = New MySqlParameter()
                        With arrParametros(4)
                            .ParameterName = "sAlias"
                            .MySqlDbType = MySqlDbType.VarChar
                            .Size = 50
                            .Value = txtAlias.Text.Trim
                            .Direction = ParameterDirection.Input
                        End With

                        arrParametros(5) = New MySqlParameter()
                        With arrParametros(5)
                            .ParameterName = "sIdentificacion"
                            .MySqlDbType = MySqlDbType.VarChar
                            .Size = 20
                            .Value = txtIdentificacion.Text.Trim
                            .Direction = ParameterDirection.Input
                        End With

                        arrParametros(6) = New MySqlParameter()
                        With arrParametros(6)
                            .ParameterName = "fFechaAlta"
                            .MySqlDbType = MySqlDbType.Datetime
                            .Size = 8
                            .Value = dtpFAlta.Value
                            .Direction = ParameterDirection.Input
                        End With

                        arrParametros(7) = New MySqlParameter()
                        With arrParametros(7)
                            .ParameterName = "fFechaBaja"
                            .MySqlDbType = MySqlDbType.Datetime
                            .Size = 8
                            If dtpFBaja.Checked Then
                                .Value = dtpFBaja.Value
                            Else
                                .Value = DBNull.Value
                            End If
                            .Direction = ParameterDirection.Input
                        End With

                        arrParametros(8) = New MySqlParameter()
                        With arrParametros(8)
                            .ParameterName = "sNumColegiado"
                            .MySqlDbType = MySqlDbType.VarChar
                            .Size = 50
                            .Value = txtNumColegiado.Text.Trim
                            .Direction = ParameterDirection.Input
                        End With

                        arrParametros(9) = New MySqlParameter()
                        With arrParametros(9)
                            .ParameterName = "sSexo"
                            .MySqlDbType = MySqlDbType.VarChar
                            .Size = 1
                            If rdbHombre.Checked Then
                                .Value = rdbHombre.Text.Substring(0, 1)
                            Else
                                If rdbMujer.Checked Then
                                    .Value = rdbMujer.Text.Substring(0, 1)
                                Else
                                    .Value = DBNull.Value
                                End If
                            End If
                            .Direction = ParameterDirection.Input
                        End With

                        bOK = .EjecutarSP("spFisios_Guardar", arrParametros)

                        If bOK Then
                            bOK = .EjecutarSP("spFisios_ReorganizarIndices", Nothing)
                        End If

                        If bOK Then
                            bOK = .ConfirmarTransaccion
                        Else
                            bOK = .CancelarTransaccion
                        End If
                    End If

                    If bOK Then
                        bOK = .CerrarConexion
                    End If
                End If
            End With

        Catch exError As Exception
            GestionarErrores(exError.Message, cteModulo, MessageBoxIcon.Error, EventLogEntryType.Error)

            bOK = False

        Finally
            ' Descargar objetos
            objBDatos.Dispose()

        End Try

        Return bOK

    End Function

    Private Function mEliminarFisio() As Boolean

        Dim objBDatos As New AccesoBD_MySQL()
        Dim bOK As Boolean = False

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
                        .Value = Me.IDFisio
                        .Direction = ParameterDirection.Input
                    End With

                    bOK = .EjecutarSP("spFisios_Eliminar", arrParametros)

                    If bOK Then
                        bOK = .CerrarConexion
                    End If
                End If
            End With

        Catch exError As Exception
            GestionarErrores(exError.Message, cteModulo, MessageBoxIcon.Error, EventLogEntryType.Error)

            bOK = False

        Finally
            ' Descargar objetos
            objBDatos.Dispose()

        End Try

        Return bOK

    End Function

    Private Function mComprobarCampos() As Boolean

        Dim bOK As Boolean = True

        If txtNombre.Text.Trim.Length = 0 Then
            errFisios.SetError(txtNombre, "El Nombre del fisioterapeuta es obligatorio")
            bOK = False
        Else
            errFisios.SetError(txtNombre, String.Empty)
            bOK = True
        End If

        If bOK Then
            If txtApellido1.Text.Trim.Length = 0 Then
                errFisios.SetError(txtApellido1, "El Primer Apellido del fisioterapeuta es obligatorio")
                bOK = False
            Else
                errFisios.SetError(txtApellido1, String.Empty)
                bOK = True
            End If
        End If

        If bOK Then
            If txtAlias.Text.Trim.Length = 0 Then
                errFisios.SetError(txtAlias, "El Alias del fisioterapeuta es obligatorio")
                bOK = False
            Else
                errFisios.SetError(txtAlias, String.Empty)
                bOK = True
            End If
        End If

        Return bOK

    End Function

    Private Sub mLimpiarCampos()

        Dim objControl As Control

        For Each objControl In grbFisio.Controls
            If TypeOf objControl Is TextBox Then
                CType(objControl, TextBox).Text = String.Empty
            End If

            If TypeOf objControl Is DateTimePicker Then
                CType(objControl, DateTimePicker).Value = DateTime.Today
            End If
        Next objControl

        For Each objControl In grbSexo.Controls
            If TypeOf objControl Is RadioButton Then
                CType(objControl, RadioButton).Checked = False
            End If
        Next objControl

    End Sub

#End Region


End Class