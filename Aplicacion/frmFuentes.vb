Option Strict On
Option Explicit On

Public Class frmFuentes

    Private Const cteModulo As String = "Fuentes"

    'Variable para controlar el número de instancias abiertas
    Private Shared objInstancia As frmFuentes = Nothing

    'Función que crea una sola instancia del formulario de Fuentes
    Public Shared Function Instancia() As frmFuentes

        If IsNothing(objInstancia) OrElse objInstancia.IsDisposed = True Then
            objInstancia = New frmFuentes()
        End If

        objInstancia.BringToFront()

        Return objInstancia

    End Function


    Private arrCamposFuentes() As String = {"FNT_Descripcion", "FNT_ID"}
    Private arrCabecerasFuentes() As String = {"Fuente", String.Empty}
    Private arrTiposDatosFuentes() As String = {"S", "I"}
    Private arrAnchurasFuentes() As Integer = {450, 0}

    Private TipoMantenimiento As eTiposMantenimiento
    Private IDFuente As Integer

    Private dtFuentes As DataTable = New DataTable("Fuentes")


#Region " CONTROLES "

    Private Sub RestaurarFormulario(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub CargarFormulario(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.IDFuente = 0
        Me.TipoMantenimiento = eTiposMantenimiento.NoAsignado

        mLLenarFuentes()

        grbFuente.Enabled = False

    End Sub

    Private Sub Cerrar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click
        Me.Dispose()
    End Sub


    Private Sub NavegarGrid(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgFuentes.CurrentCellChanged
        dtgFuentes.Select(dtgFuentes.CurrentRowIndex)

        Me.IDFuente = Convert.ToInt32(dtgFuentes.Item(dtgFuentes.CurrentRowIndex, 1))
        mLLenarFuenteDetalle(Me.IDFuente)
    End Sub

    Private Sub ModificarFuenteSeleccionada(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgFuentes.DoubleClick
        If cmdModificar.Enabled Then
            cmdModificar.PerformClick()
        End If
    End Sub

    Private Sub SeleccionarUnaFuente(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtgFuentes.MouseUp

        Dim objTest As DataGrid.HitTestInfo = dtgFuentes.HitTest(New Point(e.X, e.Y))

        ' Si es una celda
        If objTest.Type = DataGrid.HitTestType.Cell Then
            dtgFuentes.Select(objTest.Row)
            Me.IDFuente = Convert.ToInt32(dtgFuentes.Item(dtgFuentes.CurrentRowIndex, 1))
            mLLenarFuenteDetalle(Me.IDFuente)
        Else
            mLimpiarCampos()
            grbFuente.Enabled = False
        End If

        ' Habilitar los botones Modificar y Eliminar cuando se seleccione una celda. No valen las cabeceras.
        cmdModificar.Enabled = (objTest.Type = DataGrid.HitTestType.Cell)
        cmdEliminar.Enabled = (objTest.Type = DataGrid.HitTestType.Cell)

    End Sub


    Private Sub NuevaFuente(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        mLimpiarCampos()
        grbFuente.Enabled = True
        Me.TipoMantenimiento = eTiposMantenimiento.Alta
    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        grbFuente.Enabled = True
        Me.TipoMantenimiento = eTiposMantenimiento.Modificacion
    End Sub

    Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click
        If MessageBox.Show("Se va a Eliminar la Fuente seleccionada. ¿Estás seguro?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            If mEliminarFuente() Then
                mLLenarFuentes()
                mLimpiarCampos()
            End If
        End If
    End Sub

    Private Sub GuardarFisio(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        If mComprobarCampos() Then
            If mGuardarFuente() Then
                mLLenarFuentes()
            End If

            grbFuente.Enabled = False
        End If
    End Sub

#End Region

#Region " FUNCIONES "

    Private Sub mLLenarFuentes()

        Dim objBDatos As New AccesoBD_MySQL()
        Dim iNumFuentes As Integer
        Dim bOK As Boolean

        Try
            With objBDatos
                bOK = .AbrirConexion()

                If bOK Then
                    dtFuentes.Rows.Clear()
                    Dim arrParametros(0) As MySqlParameter

                    arrParametros(0) = New MySqlParameter()
                    With arrParametros(0)
                        .ParameterName = "iIDFuente"
                        .MySqlDbType = MySqlDbType.Int32
                        .Size = 4
                        .Value = DBNull.Value
                        .Direction = ParameterDirection.Input
                    End With

                    bOK = .EjecutarSP("spFuentes_LLenar", arrParametros, dtFuentes, iNumFuentes)

                    If bOK Then
                        If Not IsNothing(dtFuentes) Then
                            If iNumFuentes > 0 Then
                                dtgFuentes.SetDataBinding(dtFuentes, String.Empty)

                                NovafisDataGrid.EstiloGrid(arrCamposFuentes, arrCabecerasFuentes, arrTiposDatosFuentes, arrAnchurasFuentes, dtgFuentes, "Fuentes")
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

    Private Sub mLLenarFuenteDetalle(ByVal iIDFuente As Integer)

        Dim objBDatos As New AccesoBD_MySQL()
        Dim dtFuenteDetalle As New DataTable
        Dim iNumFuentes As Integer
        Dim bOK As Boolean

        Try
            With objBDatos
                bOK = .AbrirConexion()

                If bOK Then
                    Dim arrParametros(0) As MySqlParameter

                    arrParametros(0) = New MySqlParameter()
                    With arrParametros(0)
                        .ParameterName = "iIDFuente"
                        .MySqlDbType = MySqlDbType.Int32
                        .Size = 4
                        .Value = iIDFuente
                        .Direction = ParameterDirection.Input
                    End With

                    bOK = .EjecutarSP("spFuentes_LLenar", arrParametros, dtFuenteDetalle, iNumFuentes)

                    If bOK Then
                        If Not IsNothing(dtFuenteDetalle) Then
                            If iNumFuentes = 1 Then
                                Dim drFila As DataRow = dtFuenteDetalle.Rows(0)

                                txtFuente.Text = drFila("FNT_Descripcion").ToString.Trim
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


    Private Function mGuardarFuente() As Boolean

        Dim objBDatos As New AccesoBD_MySQL()
        Dim bOK As Boolean = False

        Try
            With objBDatos
                bOK = .AbrirConexion

                If bOK Then
                    Dim arrParametros(1) As MySqlParameter

                    arrParametros(0) = New MySqlParameter()
                    With arrParametros(0)
                        .ParameterName = "iIDFuente"
                        .MySqlDbType = MySqlDbType.Int32
                        .Size = 4
                        .Value = IIf(Me.TipoMantenimiento = eTiposMantenimiento.Alta, 0, Me.IDFuente)
                        .Direction = ParameterDirection.Input
                    End With

                    arrParametros(1) = New MySqlParameter()
                    With arrParametros(1)
                        .ParameterName = "sDescripcion"
                        .MySqlDbType = MySqlDbType.VarChar
                        .Size = 100
                        .Value = txtFuente.Text.Trim
                        .Direction = ParameterDirection.Input
                    End With

                    bOK = .EjecutarSP("spFuentes_Guardar", arrParametros)

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

    Private Function mEliminarFuente() As Boolean

        Dim objBDatos As New AccesoBD_MySQL()
        Dim bOK As Boolean = False

        Try
            With objBDatos
                bOK = .AbrirConexion

                If bOK Then
                    Dim arrParametros(0) As MySqlParameter

                    arrParametros(0) = New MySqlParameter()
                    With arrParametros(0)
                        .ParameterName = "iIDFuente"
                        .MySqlDbType = MySqlDbType.Int32
                        .Size = 4
                        .Value = Me.IDFuente
                        .Direction = ParameterDirection.Input
                    End With

                    bOK = .EjecutarSP("spFuentes_Eliminar", arrParametros)

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

        If txtFuente.Text.Trim.Length = 0 Then
            errFuentes.SetError(txtFuente, "La descripción de la Fuente es obligatoria")
            bOK = False
        Else
            errFuentes.SetError(txtFuente, String.Empty)
            bOK = True
        End If

        Return bOK

    End Function

    Private Sub mLimpiarCampos()

        Dim objControl As Control

        For Each objControl In grbFuente.Controls
            If TypeOf objControl Is TextBox Then
                CType(objControl, TextBox).Text = String.Empty
            End If
        Next objControl

    End Sub

#End Region

End Class