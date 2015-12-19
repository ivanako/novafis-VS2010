Option Strict On
Option Explicit On 

Public Class frmNotas

    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents dtgNotas As System.Windows.Forms.DataGrid
    Friend WithEvents grbNota As System.Windows.Forms.GroupBox
    Friend WithEvents cmdGuardar As System.Windows.Forms.Button
    Friend WithEvents txtNota As System.Windows.Forms.TextBox
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblNota As System.Windows.Forms.Label
    Friend WithEvents cmdNueva As System.Windows.Forms.Button
    Friend WithEvents cmdModificar As System.Windows.Forms.Button
    Friend WithEvents cmdEliminar As System.Windows.Forms.Button
    Friend WithEvents cmdCerrar As System.Windows.Forms.Button
    Friend WithEvents tipNotas As System.Windows.Forms.ToolTip
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.tipNotas = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdGuardar = New System.Windows.Forms.Button
        Me.cmdNueva = New System.Windows.Forms.Button
        Me.cmdModificar = New System.Windows.Forms.Button
        Me.cmdEliminar = New System.Windows.Forms.Button
        Me.cmdCerrar = New System.Windows.Forms.Button
        Me.dtgNotas = New System.Windows.Forms.DataGrid
        Me.grbNota = New System.Windows.Forms.GroupBox
        Me.txtNota = New System.Windows.Forms.TextBox
        Me.lblFecha = New System.Windows.Forms.Label
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker
        Me.lblNota = New System.Windows.Forms.Label
        CType(Me.dtgNotas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbNota.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Location = New System.Drawing.Point(464, 101)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(93, 34)
        Me.cmdGuardar.TabIndex = 2
        Me.cmdGuardar.Text = "Guardar"
        Me.tipNotas.SetToolTip(Me.cmdGuardar, "Guardar Nota diaria")
        '
        'cmdNueva
        '
        Me.cmdNueva.Location = New System.Drawing.Point(12, 227)
        Me.cmdNueva.Name = "cmdNueva"
        Me.cmdNueva.Size = New System.Drawing.Size(93, 32)
        Me.cmdNueva.TabIndex = 1
        Me.cmdNueva.Text = "Nueva"
        Me.tipNotas.SetToolTip(Me.cmdNueva, "Escribir una nueva nota diaria")
        '
        'cmdModificar
        '
        Me.cmdModificar.Enabled = False
        Me.cmdModificar.Location = New System.Drawing.Point(120, 227)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(93, 32)
        Me.cmdModificar.TabIndex = 2
        Me.cmdModificar.Text = "Modificar"
        Me.tipNotas.SetToolTip(Me.cmdModificar, "Modificar la Nota diaria seleccionada")
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Enabled = False
        Me.cmdEliminar.Location = New System.Drawing.Point(228, 227)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(93, 32)
        Me.cmdEliminar.TabIndex = 3
        Me.cmdEliminar.Text = "Eliminar"
        Me.tipNotas.SetToolTip(Me.cmdEliminar, "Eliminar la Nota diaria seleccionada")
        '
        'cmdCerrar
        '
        Me.cmdCerrar.Location = New System.Drawing.Point(485, 226)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(93, 34)
        Me.cmdCerrar.TabIndex = 4
        Me.cmdCerrar.Text = "Cerrar"
        Me.tipNotas.SetToolTip(Me.cmdCerrar, "Cerrar ventana de Notas")
        '
        'dtgNotas
        '
        Me.dtgNotas.CaptionText = "Notas diarias"
        Me.dtgNotas.DataMember = ""
        Me.dtgNotas.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dtgNotas.Location = New System.Drawing.Point(12, 12)
        Me.dtgNotas.Name = "dtgNotas"
        Me.dtgNotas.ReadOnly = True
        Me.dtgNotas.Size = New System.Drawing.Size(566, 200)
        Me.dtgNotas.TabIndex = 0
        Me.dtgNotas.TabStop = False
        '
        'grbNota
        '
        Me.grbNota.Controls.Add(Me.cmdGuardar)
        Me.grbNota.Controls.Add(Me.txtNota)
        Me.grbNota.Controls.Add(Me.lblFecha)
        Me.grbNota.Controls.Add(Me.dtpFecha)
        Me.grbNota.Controls.Add(Me.lblNota)
        Me.grbNota.Enabled = False
        Me.grbNota.Location = New System.Drawing.Point(12, 274)
        Me.grbNota.Name = "grbNota"
        Me.grbNota.Size = New System.Drawing.Size(566, 151)
        Me.grbNota.TabIndex = 5
        Me.grbNota.TabStop = False
        '
        'txtNota
        '
        Me.txtNota.Location = New System.Drawing.Point(78, 55)
        Me.txtNota.MaxLength = 100
        Me.txtNota.Multiline = True
        Me.txtNota.Name = "txtNota"
        Me.txtNota.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNota.Size = New System.Drawing.Size(296, 80)
        Me.txtNota.TabIndex = 1
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(27, 19)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(45, 13)
        Me.lblFecha.TabIndex = 13
        Me.lblFecha.Text = "Fecha:"
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpFecha
        '
        Me.dtpFecha.CustomFormat = ""
        Me.dtpFecha.Location = New System.Drawing.Point(78, 15)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(296, 21)
        Me.dtpFecha.TabIndex = 0
        '
        'lblNota
        '
        Me.lblNota.AutoSize = True
        Me.lblNota.Location = New System.Drawing.Point(7, 58)
        Me.lblNota.Name = "lblNota"
        Me.lblNota.Size = New System.Drawing.Size(70, 13)
        Me.lblNota.TabIndex = 12
        Me.lblNota.Text = "Contenido:"
        Me.lblNota.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmNotas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(593, 439)
        Me.Controls.Add(Me.cmdCerrar)
        Me.Controls.Add(Me.cmdEliminar)
        Me.Controls.Add(Me.cmdModificar)
        Me.Controls.Add(Me.cmdNueva)
        Me.Controls.Add(Me.grbNota)
        Me.Controls.Add(Me.dtgNotas)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmNotas"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Notas"
        CType(Me.dtgNotas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbNota.ResumeLayout(False)
        Me.grbNota.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Const cteModulo As String = "Notas"

    'Variable para controlar el número de instancias abiertas
    Private Shared objInstancia As frmNotas = Nothing

    'Función que crea una sola instancia del formulario de Notas
    Public Shared Function Instancia() As frmNotas

        If IsNothing(objInstancia) OrElse objInstancia.IsDisposed = True Then
            objInstancia = New frmNotas()
        End If

        objInstancia.BringToFront()

        Return objInstancia

    End Function

    Friend IDNota As Integer
    Friend FechaNota As DateTime
    Friend TipoMant As eTiposMantenimiento

    Private arrCamposNotas() As String = {"SEL", "NOT_Fecha", "NOT_Descripcion", "NOT_ID"}
    Private arrCabecerasNotas() As String = {"Sel.", "Fecha", "Nota", String.Empty}
    Private arrTiposDatosNotas() As String = {"B", "F", "S", "I"}
    Private arrAnchurasNotas() As Integer = {50, 100, 390, 0}

    Private dtNotas As DataTable = New DataTable("Notas")


    Private Sub CargarFormulario(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mLLenarNotas()
        'mInicializarFormulario()
        mOKGuardar()
    End Sub

    Private Sub CambiarTamañoFormulario(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.WindowState = FormWindowState.Normal
    End Sub


    Private Sub NavegarGrid(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgNotas.CurrentCellChanged
        dtgNotas.Select(dtgNotas.CurrentRowIndex)

        Me.IDNota = Integer.Parse(dtgNotas.Item(dtgNotas.CurrentRowIndex, 3).ToString)
        mLLenarNotaDetalle() '(Me.IDNota)
    End Sub

    Private Sub FijarUnaSeleccion(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtgNotas.MouseDown

        Dim objHitTest As DataGrid.HitTestInfo
        Dim iCont As Integer
        Dim iRow As Integer
        Dim iCol As Integer

        ' Recuperar el objeto de click
        objHitTest = dtgNotas.HitTest(e.X, e.Y)

        ' Recuperar filas y columnas
        iCol = objHitTest.Column
        iRow = objHitTest.Row

        ' Miramos si se ha pulsado en una celda de la columna de selección
        If objHitTest.Type = DataGrid.HitTestType.Cell Then ' And iCol = 0 Then
            Dim bSeleccionar As Boolean = Not CType(dtgNotas.Item(iRow, 0), Boolean)

            If bSeleccionar Then
                ' Recorrer poniendo a falso las columnas
                For iCont = 0 To CType(dtgNotas.DataSource, DataTable).Rows.Count - 1
                    If CBool(dtgNotas.Item(iCont, 0)) Then
                        dtgNotas.Item(iCont, 0) = False
                        Exit For
                    End If
                Next iCont

                ' Cambiar el valor a verdadero
                dtgNotas.Item(iRow, 0) = True
            Else
                dtgNotas.Item(iRow, 0) = False
            End If
        End If

        mHabilitarBotones()

        grbNota.Enabled = False
    End Sub

    Private Sub SeleccionarUnaFila(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtgNotas.MouseUp
        Dim objTest As DataGrid.HitTestInfo = dtgNotas.HitTest(New Point(e.X, e.Y))

        ' Si es una celda
        If objTest.Type = DataGrid.HitTestType.Cell Then
            dtgNotas.Select(objTest.Row)
        End If
    End Sub


    Private Sub cmdNueva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNueva.Click
        Me.TipoMant = eTiposMantenimiento.Alta
        dtpFecha.Value = DateTime.Today
        txtNota.Text = String.Empty
        grbNota.Enabled = True
    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        Me.TipoMant = eTiposMantenimiento.Modificacion
        grbNota.Enabled = True
    End Sub


    Private Sub Cerrar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click
        Me.Dispose()
    End Sub

    Private Sub CambiarNota(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNota.TextChanged
        mOKGuardar()
    End Sub


    Private Sub GuardarNota(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click

        If mbGuardarNota() Then
            mLLenarNotas()
        End If

        'If mbGuardarNota() Then
        '    Me.DialogResult = DialogResult.OK
        'Else
        '    Me.DialogResult = DialogResult.Cancel
        'End If

    End Sub



    Private Sub mLLenarNotas()

        Dim objBDatos As New AccesoBD_MySQL()
        Dim iNumNotas As Integer
        Dim bOK As Boolean

        Try
            With objBDatos
                bOK = .AbrirConexion()

                If bOK Then
                    dtNotas.Rows.Clear()
                    Dim arrParametros(1) As MySqlParameter

                    arrParametros(0) = New MySqlParameter()
                    With arrParametros(0)
                        .ParameterName = "iIDNota"
                        .MySqlDbType = MySqlDbType.Int32
                        .Size = 4
                        .Value = DBNull.Value
                        .Direction = ParameterDirection.Input
                    End With

                    arrParametros(1) = New MySqlParameter()
                    With arrParametros(1)
                        .ParameterName = "fFecha"
                        .MySqlDbType = MySqlDbType.Date
                        .Size = 8
                        .Value = DBNull.Value
                        .Direction = ParameterDirection.Input
                    End With

                    bOK = .EjecutarSP("spNotas_LLenar", arrParametros, dtNotas, iNumNotas)

                    If bOK Then
                        If iNumNotas > 0 Then
                            ' Incluir la columna de Selección
                            If dtNotas.Columns.Count <> 4 Then
                                NovafisDataGrid.ColumnaSeleccion(dtNotas)
                            End If

                            dtgNotas.SetDataBinding(dtNotas, String.Empty)

                            NovafisDataGrid.EstiloGrid(arrCamposNotas, arrCabecerasNotas, arrTiposDatosNotas, arrAnchurasNotas, dtgNotas, "Notas")
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
            objBDatos.Dispose()

        End Try

    End Sub

    Private Sub mLLenarNotaDetalle()

        Dim arrNotas() As DataRow = dtNotas.Select("NOT_ID = " & Me.IDNota)

        If arrNotas.Length = 1 Then
            dtpFecha.Value = DateTime.Parse(arrNotas(0)("NOT_Fecha").ToString())
            txtNota.Text = arrNotas(0)("NOT_Descripcion").ToString.Trim
        End If

    End Sub

    Private Sub mInicializarFormulario()

        Select Case Me.TipoMant
            Case eTiposMantenimiento.Alta
                dtpFecha.Value = DateTime.Today
                txtNota.Text = String.Empty

            Case eTiposMantenimiento.Modificacion
                'mLLenarNota()
        End Select

    End Sub

    Private Function mbGuardarNota() As Boolean

        Dim objBDatos As New AccesoBD_MySQL()
        Dim bOK As Boolean

        Try
            With objBDatos
                bOK = .AbrirConexion

                If bOK Then
                    bOK = .IniciarTransaccion

                    If bOK Then
                        Dim arrParametros() As MySqlParameter

                        ReDim arrParametros(1)

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
                            .ParameterName = "sNota"
                            .MySqlDbType = MySqlDbType.VarChar
                            .Size = 100
                            .Value = txtNota.Text.Trim
                            .Direction = ParameterDirection.Input
                        End With

                        Select Case Me.TipoMant
                            Case eTiposMantenimiento.Alta
                                bOK = .EjecutarSP("spNotas_Anadir", arrParametros)

                            Case eTiposMantenimiento.Modificacion
                                ReDim Preserve arrParametros(2)

                                arrParametros(2) = New MySqlParameter()
                                With arrParametros(2)
                                    .ParameterName = "iIDNota"
                                    .MySqlDbType = MySqlDbType.Int32
                                    .Size = 10
                                    .Value = Me.IDNota
                                    .Direction = ParameterDirection.Input
                                End With

                                bOK = .EjecutarSP("spNotas_Modificar", arrParametros)

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
            GestionarErrores(exError.Message, cteModulo, MessageBoxIcon.Error, EventLogEntryType.Error)

            bOK = False

        Finally
            ' Descargar objetos
            objBDatos.Dispose()

        End Try

        Return bOK

    End Function

    Private Function mbEliminarNota() As Boolean

        Dim objBDatos As New AccesoBD_MySQL()
        Dim bOK As Boolean

        Try
            With objBDatos
                bOK = .AbrirConexion

                If bOK Then
                    bOK = .IniciarTransaccion

                    If bOK Then
                        Dim arrParametros(0) As MySqlParameter

                        arrParametros(0) = New MySqlParameter()
                        With arrParametros(0)
                            .ParameterName = "iIDNota"
                            .MySqlDbType = MySqlDbType.Int32
                            .Size = 4
                            .Value = Me.IDNota
                            .Direction = ParameterDirection.Input
                        End With

                        bOK = .EjecutarSP("spNotas_Eliminar", arrParametros)

                        If bOK Then
                            bOK = .ConfirmarTransaccion()
                        Else
                            bOK = .CancelarTransaccion()
                        End If
                    End If

                    bOK = .CerrarConexion()
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

    Private Sub mOKGuardar()

        Dim bOK As Boolean

        bOK = (txtNota.Text.Trim.Length > 0)

        cmdGuardar.Enabled = bOK

    End Sub

    Private Sub mHabilitarBotones()

        Dim bOK As Boolean = False

        If Not IsNothing(dtgNotas.DataSource) Then
            If CType(dtgNotas.DataSource, DataTable).Rows.Count > 0 Then
                For Each drFila As DataRow In CType(dtgNotas.DataSource, DataTable).Rows
                    If CType(drFila("SEL"), Boolean) Then
                        bOK = True
                        Exit For
                    End If
                Next
            End If
        End If

        cmdModificar.Enabled = bOK
        cmdEliminar.Enabled = bOK

    End Sub


    Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click
        If MessageBox.Show("Se va a eliminar la nota seleccionada", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            If mbEliminarNota() Then
                mLLenarNotas()
            End If
        End If
    End Sub

End Class
