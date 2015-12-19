Option Strict Off
Option Explicit On

Public Class frmFacturacion

    Private Const cteModulo As String = "Facturación"

    'Variable para controlar el número de instancias abiertas
    Private Shared objInstancia As frmFacturacion = Nothing

    'Función que crea una sola instancia del formulario de Facturas
    Public Shared Function Instancia() As frmFacturacion

        If IsNothing(objInstancia) OrElse objInstancia.IsDisposed = True Then
            objInstancia = New frmFacturacion()
        End If

        objInstancia.BringToFront()

        Return objInstancia

    End Function


    Private arrCamposFacturas() As String = {"SEL", "FAC_Fecha", "FAC_ID", "Paciente"}
    Private arrCabecerasFacturas() As String = {"Sel.", "Fecha", "Nº Factura", "Facturado"}
    Private arrTiposDatosFacturas() As String = {"B", "F", "S", "S"}
    Private arrAnchurasFacturas() As Integer = {50, 100, 100, 300}

    Private TipoMantenimiento As eTiposMantenimiento
    Private IDFactura As String

    Private dtFacturas As DataTable = New DataTable("Facturas")

    Private Sub RestaurarFormulario(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub CargarFormulario(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.TipoMantenimiento = eTiposMantenimiento.NoAsignado

        mLLenarFacturas()
        mLimpiarCampos()

        grbFactura.Enabled = False

    End Sub


    Private Sub cmdNueva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNueva.Click
        mLimpiarCampos()
        grbFactura.Enabled = True
    End Sub

    Private Sub cmdGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGenerar.Click
        mGenerarFactura()
    End Sub

    Private Sub Cerrar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click
        Me.Dispose()
    End Sub


    Private Sub NavegarGrid(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgFacturas.CurrentCellChanged
        dtgFacturas.Select(dtgFacturas.CurrentRowIndex)

        Me.IDFactura = dtgFacturas.Item(dtgFacturas.CurrentRowIndex, 2).ToString
        mLLenarFacturaDetalle(Me.IDFactura)
    End Sub

    Private Sub FijarUnaSeleccion(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtgFacturas.MouseDown

        Dim objHitTest As DataGrid.HitTestInfo
        Dim iCont As Integer
        Dim iRow As Integer
        Dim iCol As Integer

        ' Recuperar el objeto de click
        objHitTest = dtgFacturas.HitTest(e.X, e.Y)

        ' Recuperar filas y columnas
        iCol = objHitTest.Column
        iRow = objHitTest.Row

        ' Miramos si se ha pulsado en una celda de la columna de selección
        If objHitTest.Type = DataGrid.HitTestType.Cell Then ' And iCol = 0 Then
            Dim bSeleccionar As Boolean = Not CType(dtgFacturas.Item(iRow, 0), Boolean)

            If bSeleccionar Then
                ' Recorrer poniendo a falso las columnas
                For iCont = 0 To CType(dtgFacturas.DataSource, DataTable).Rows.Count - 1
                    If CBool(dtgFacturas.Item(iCont, 0)) Then
                        dtgFacturas.Item(iCont, 0) = False
                        Exit For
                    End If
                Next iCont

                ' Cambiar el valor a verdadero
                dtgFacturas.Item(iRow, 0) = True
            Else
                dtgFacturas.Item(iRow, 0) = False
            End If
        End If

        mOKGenerar()

    End Sub

    Private Sub SeleccionarUnaFila(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtgFacturas.MouseUp
        Dim objTest As DataGrid.HitTestInfo = dtgFacturas.HitTest(New Point(e.X, e.Y))

        ' Si es una celda
        If objTest.Type = DataGrid.HitTestType.Cell Then
            dtgFacturas.Select(objTest.Row)
        End If
    End Sub


    Private Sub cmdBuscarPacientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscarPacientes.Click

        Dim objBuscarPacientes As New frmBuscarPacientes()

        With objBuscarPacientes
            If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                Dim dtPaciente As DataTable = BuscarPaciente(.IdPaciente)

                If dtPaciente.Rows.Count = 1 Then
                    Dim drPaciente As DataRow = dtPaciente.Rows.Item(0)

                    txtPaciente.Text = drPaciente("PAC_NombreCompleto").ToString
                    txtPaciente.Tag = .IdPaciente
                    txtIdentificacion.Text = drPaciente("PAC_Identificacion").ToString
                    txtIdentificacion.ReadOnly = (txtIdentificacion.Text <> String.Empty)
                End If

                'Dim arrFilas As DataRow() = dtPacientes.Select("PAC_ID = " & .IDPaciente.ToString)

                'txtIdentificacion.Text = IIf(IsDBNull(arrFilas(0)("PAC_Identificacion")), String.Empty, arrFilas(0)("PAC_Identificacion")).ToString

                'txtIdentificacion.ReadOnly = (txtIdentificacion.Text <> String.Empty)
            End If
        End With

    End Sub

    Private Sub rdbPaciente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbPaciente.CheckedChanged
        cmdBuscarPacientes.Enabled = rdbPaciente.Checked
        txtIdentificacion.ReadOnly = True
        mComprobarCampos()
    End Sub

    Private Sub rdbOtro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbOtro.CheckedChanged
        txtOtro.ReadOnly = Not rdbOtro.Checked
        txtIdentificacion.ReadOnly = Not rdbOtro.Checked
        mComprobarCampos()
    End Sub

    Private Sub CambioNumeros(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudSesiones.ValueChanged, nudImporte.ValueChanged
        mComprobarCampos()
    End Sub

    Private Sub CambioTexto(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPaciente.TextChanged, txtOtro.TextChanged, txtTratamiento.TextChanged, txtIdentificacion.TextChanged
        mComprobarCampos()
    End Sub

    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        If mComprobarCampos() Then
            cmdGuardar.Enabled = False

            If mbGuardarFactura() Then
                mLLenarFacturas()
            End If

            mLimpiarCampos()
            grbFactura.Enabled = False
        Else

        End If
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        mLimpiarCampos()
        grbFactura.Enabled = False
    End Sub


    Private Sub mLLenarFacturas()

        Dim objBDatos As New AccesoBD_MySQL()
        Dim iNumFacturas As Integer
        Dim bOK As Boolean

        Try
            With objBDatos
                bOK = .AbrirConexion()

                If bOK Then
                    dtFacturas.Rows.Clear()
                    Dim arrParametros(0) As MySqlParameter

                    arrParametros(0) = New MySqlParameter()
                    With arrParametros(0)
                        .ParameterName = "sIDFactura"
                        .MySqlDbType = MySqlDbType.String
                        .Size = 9
                        .Value = DBNull.Value
                        .Direction = ParameterDirection.Input
                    End With

                    bOK = .EjecutarSP("spFacturas_LLenar", arrParametros, dtFacturas, iNumFacturas)

                    If bOK Then
                        If Not IsNothing(dtFacturas) Then
                            If iNumFacturas > 0 Then
                                ' Incluir la columna de Selección
                                If dtFacturas.Columns.Count <> 4 Then
                                    NovafisDataGrid.ColumnaSeleccion(dtFacturas)
                                End If

                                dtgFacturas.SetDataBinding(dtFacturas, String.Empty)

                                NovafisDataGrid.EstiloGrid(arrCamposFacturas, arrCabecerasFacturas, arrTiposDatosFacturas, arrAnchurasFacturas, dtgFacturas, "Facturas")
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

    Private Sub mLLenarFacturaDetalle(ByVal sIDFactura As String)

        Dim objBDatos As New AccesoBD_MySQL()
        Dim dtFacturaDetalle As New DataTable
        Dim iNumFacturas As Integer
        Dim bOK As Boolean

        Try
            With objBDatos
                bOK = .AbrirConexion()

                If bOK Then
                    Dim arrParametros(0) As MySqlParameter

                    arrParametros(0) = New MySqlParameter()
                    With arrParametros(0)
                        .ParameterName = "sIDFactura"
                        .MySqlDbType = MySqlDbType.String
                        .Size = 9
                        .Value = sIDFactura
                        .Direction = ParameterDirection.Input
                    End With

                    bOK = .EjecutarSP("spFacturas_LLenar", arrParametros, dtFacturaDetalle, iNumFacturas)

                    If bOK Then
                        If Not IsNothing(dtFacturaDetalle) Then
                            If iNumFacturas = 1 Then
                                Dim drFila As DataRow = dtFacturaDetalle.Rows(0)

                                txtNumFactura.Text = drFila("FAC_ID").ToString
                                dtpFecha.Value = CType(drFila("FAC_Fecha"), Date)

                                If IsDBNull(drFila("PAC_ID")) Then
                                    rdbPaciente.Checked = False
                                    rdbOtro.Checked = True
                                    txtOtro.Text = drFila("FAC_Receptor").ToString
                                Else
                                    rdbPaciente.Checked = True
                                    rdbOtro.Checked = False
                                    txtPaciente.Text = drFila("PAC_NombreCompleto").ToString
                                End If

                                txtIdentificacion.Text = drFila("FAC_Identificacion").ToString
                                nudSesiones.Value = CType(IIf(IsDBNull(drFila("FAC_Sesiones")), 0, drFila("FAC_Sesiones")), Decimal)
                                nudImporte.Value = CType(IIf(IsDBNull(drFila("FAC_Importe")), 0, drFila("FAC_Importe")), Decimal)
                                txtTratamiento.Text = drFila("FAC_Tratamiento").ToString.Trim
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

    Private Sub mOKGenerar()

        Dim bOK As Boolean = False

        If Not IsNothing(dtgFacturas.DataSource) Then
            If CType(dtgFacturas.DataSource, DataTable).Rows.Count > 0 Then
                For Each drFila As DataRow In CType(dtgFacturas.DataSource, DataTable).Rows
                    If CType(drFila("SEL"), Boolean) Then
                        bOK = True
                        Exit For
                    End If
                Next
            End If
        End If

        cmdGenerar.Enabled = bOK

    End Sub


    Private Function mComprobarCampos() As Boolean

        Dim bOK As Boolean = True

        If Not rdbPaciente.Checked And Not rdbOtro.Checked Then
            errFacturas.SetError(rdbPaciente, "Debe seleccionarse el Paciente u otra persona")
            errFacturas.SetError(rdbOtro, "Debe seleccionarse el Paciente u otra persona")
            bOK = False
        Else
            errFacturas.SetError(rdbPaciente, String.Empty)
            errFacturas.SetError(rdbOtro, String.Empty)
            bOK = True
        End If

        If bOK Then
            If txtPaciente.Text.Length = 0 And txtOtro.Text.Trim.Length = 0 Then
                errFacturas.SetError(txtPaciente, "Hay que especificar el Paciente a quien se le emite la factura")
                errFacturas.SetError(txtOtro, "Hay que especificar a nombre de quién se emite la factura")
                bOK = False
            Else
                errFacturas.SetError(txtPaciente, String.Empty)
                errFacturas.SetError(txtOtro, String.Empty)
                bOK = True
            End If
        End If

        If bOK Then
            If nudSesiones.Value = 0 Then
                errFacturas.SetError(nudSesiones, "El número de sesiones tiene que ser mayor que cero")
                bOK = False
            Else
                errFacturas.SetError(nudSesiones, String.Empty)
                bOK = True
            End If
        End If

        If bOK Then
            If nudImporte.Value = 0 Then
                errFacturas.SetError(nudImporte, "El importe de la factura tiene que ser mayor que cero")
                bOK = False
            Else
                errFacturas.SetError(nudImporte, String.Empty)
                bOK = True
            End If
        End If

        If bOK Then
            If txtIdentificacion.Text.Trim.Length = 0 Then
                errFacturas.SetError(txtIdentificacion, "Hay que especificar la identificación del Cliente")
                bOK = False
            Else
                errFacturas.SetError(txtIdentificacion, String.Empty)
                bOK = True
            End If
        End If

        If bOK Then
            If txtTratamiento.Text.Trim.Length = 0 Then
                errFacturas.SetError(txtTratamiento, "Hay que especificar el tratamiento aplicado")
                bOK = False
            Else
                errFacturas.SetError(txtTratamiento, String.Empty)
                bOK = True
            End If
        End If

        Return bOK

    End Function

    Private Sub mLimpiarCampos()

        RemoveHandler rdbPaciente.CheckedChanged, AddressOf rdbPaciente_CheckedChanged
        RemoveHandler rdbOtro.CheckedChanged, AddressOf rdbOtro_CheckedChanged

        RemoveHandler txtPaciente.TextChanged, AddressOf CambioTexto
        RemoveHandler txtOtro.TextChanged, AddressOf CambioTexto
        RemoveHandler txtIdentificacion.TextChanged, AddressOf CambioTexto
        RemoveHandler txtTratamiento.TextChanged, AddressOf CambioTexto

        RemoveHandler nudSesiones.ValueChanged, AddressOf CambioNumeros
        RemoveHandler nudImporte.ValueChanged, AddressOf CambioNumeros

        Me.IDFactura = String.Empty

        txtNumFactura.Text = String.Empty
        dtpFecha.Value = DateTime.Today

        rdbPaciente.Checked = False
        txtPaciente.Text = String.Empty
        cmdBuscarPacientes.Enabled = False

        rdbOtro.Checked = False
        txtOtro.Text = String.Empty
        txtOtro.ReadOnly = True

        txtIdentificacion.Text = String.Empty
        nudSesiones.Value = 0
        txtTratamiento.Text = String.Empty

        'cmdGuardar.Enabled = False

        AddHandler rdbPaciente.CheckedChanged, AddressOf rdbPaciente_CheckedChanged
        AddHandler rdbOtro.CheckedChanged, AddressOf rdbOtro_CheckedChanged

        AddHandler txtPaciente.TextChanged, AddressOf CambioTexto
        AddHandler txtOtro.TextChanged, AddressOf CambioTexto
        AddHandler txtIdentificacion.TextChanged, AddressOf CambioTexto
        AddHandler txtTratamiento.TextChanged, AddressOf CambioTexto

        AddHandler nudSesiones.ValueChanged, AddressOf CambioNumeros
        AddHandler nudImporte.ValueChanged, AddressOf CambioNumeros

    End Sub


    Private Function mbGuardarFactura() As Boolean

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
                        Dim arrParametros(7) As MySqlParameter

                        arrParametros(0) = New MySqlParameter()
                        With arrParametros(0)
                            .ParameterName = "fFecha"
                            .MySqlDbType = MySqlDbType.Date
                            .Size = 8
                            .Value = dtpFecha.Value
                            .Direction = ParameterDirection.Input
                        End With

                        arrParametros(1) = New MySqlParameter()
                        With arrParametros(1)
                            .ParameterName = "iIDPaciente"
                            .MySqlDbType = MySqlDbType.Int32
                            .Size = 4
                            .IsNullable = True
                            .Value = IIf(rdbPaciente.Checked, CType(txtPaciente.Tag, Integer), DBNull.Value)
                            .Direction = ParameterDirection.Input
                        End With

                        arrParametros(2) = New MySqlParameter()
                        With arrParametros(2)
                            .ParameterName = "sReceptor"
                            .MySqlDbType = MySqlDbType.VarChar
                            .Size = 100
                            .IsNullable = True
                            .Value = IIf(rdbOtro.Checked, txtOtro.Text, DBNull.Value)
                            .Direction = ParameterDirection.Input
                        End With

                        arrParametros(3) = New MySqlParameter()
                        With arrParametros(3)
                            .ParameterName = "sIdentificacion"
                            .MySqlDbType = MySqlDbType.VarChar
                            .Size = 20
                            .Value = txtIdentificacion.Text
                            .Direction = ParameterDirection.Input
                        End With

                        arrParametros(4) = New MySqlParameter()
                        With arrParametros(4)
                            .ParameterName = "iSesiones"
                            .MySqlDbType = MySqlDbType.Int32
                            .Size = 4
                            .Value = CType(nudSesiones.Value, Integer)
                            .Direction = ParameterDirection.Input
                        End With

                        arrParametros(5) = New MySqlParameter()
                        With arrParametros(5)
                            .ParameterName = "sTratamiento"
                            .MySqlDbType = MySqlDbType.VarChar
                            .Size = 100
                            .Value = txtTratamiento.Text
                            .Direction = ParameterDirection.Input
                        End With

                        arrParametros(6) = New MySqlParameter()
                        With arrParametros(6)
                            .ParameterName = "dImporte"
                            .MySqlDbType = MySqlDbType.Decimal
                            .Size = 9
                            .Precision = 5
                            .Scale = 2
                            .Value = nudImporte.Value
                            .Direction = ParameterDirection.Input
                        End With

                        arrParametros(7) = New MySqlParameter()
                        With arrParametros(7)
                            .ParameterName = "iIDFactura"
                            .MySqlDbType = MySqlDbType.VarChar
                            .Size = 9
                            .Direction = ParameterDirection.Output
                        End With

                        bOK = .EjecutarSP("spFacturas_Anadir", arrParametros)

                        If bOK Then
                            bOK = .ConfirmarTransaccion

                            If bOK Then
                                Me.IDFactura = arrParametros(7).Value
                                mGenerarFactura()
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

        Return bControl

    End Function

    Private Sub mGenerarFactura()

        Me.Cursor = Cursors.WaitCursor

        'Dim objWord As New Word.Application
        'Dim objDocumento As Word.Document
        'Dim objSeleccion As Word.Range

        Dim objWord As Object
        Dim objDocumento As Object
        Dim objSeleccion As Object

        objWord = CreateObject("Word.Application")


        'Dim sFichero As String = Application.StartupPath & "\Factura.dot"
        'Dim objPlantilla As New System.IO.FileInfo(sFichero)
        Dim objPlantilla As Object = Application.StartupPath & "\Factura.dot"


        ' Cargar la plantilla
        objDocumento = objWord.Documents.Add(objPlantilla)

        'objSeleccion = objDocumento.GoTo(What:=Word.WdGoToItem.wdGoToBookmark, Name:="Importe")

        objSeleccion = objDocumento.GoTo(What:=-1, Name:="NFactura")
        objSeleccion.Text = Me.IDFactura

        objSeleccion = objDocumento.GoTo(What:=-1, Name:="Paciente")
        objSeleccion.Text = IIf((txtPaciente.Text = String.Empty), txtOtro.Text.Trim, txtPaciente.Text).ToString

        objSeleccion = objDocumento.GoTo(What:=-1, Name:="Identificacion")
        objSeleccion.Text = txtIdentificacion.Text.Trim

        objSeleccion = objDocumento.GoTo(What:=-1, Name:="Importe")
        objSeleccion.Text = nudImporte.Value.ToString

        objSeleccion = objDocumento.GoTo(What:=-1, Name:="Sesiones")
        objSeleccion.Text = IIf((nudSesiones.Value = 1), "1 sesión", nudSesiones.Value & " sesiones").ToString

        objSeleccion = objDocumento.GoTo(What:=-1, Name:="Tratamiento")
        objSeleccion.Text = txtTratamiento.Text.Trim

        objSeleccion = objDocumento.GoTo(What:=-1, Name:="Fecha")
        'objSeleccion.Text = dtpFecha.Value.ToLongDateString
        objSeleccion.Text = Format(dtpFecha.Value, "dd 'de' MMMM 'de' yyyy")

        objWord.Visible = True

        objWord = Nothing

        Me.Cursor = Cursors.Default

    End Sub


End Class