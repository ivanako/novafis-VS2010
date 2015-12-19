Option Strict On
Option Explicit On 

Public Class frmPacientes

    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Private Sub New()
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
    Friend WithEvents dtgPacientes As System.Windows.Forms.DataGrid
    Friend WithEvents tipPacientes As System.Windows.Forms.ToolTip
    Friend WithEvents cmdModificar As System.Windows.Forms.Button
    Friend WithEvents cmdCerrar As System.Windows.Forms.Button
    Friend WithEvents grbFiltro As System.Windows.Forms.GroupBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblApellido1 As System.Windows.Forms.Label
    Friend WithEvents lblApellido2 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido1 As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido2 As System.Windows.Forms.TextBox
    Friend WithEvents cmdNuevo As System.Windows.Forms.Button
    Friend WithEvents cmdRefrescar As System.Windows.Forms.Button
    Friend WithEvents cmdEliminar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.dtgPacientes = New System.Windows.Forms.DataGrid
        Me.cmdNuevo = New System.Windows.Forms.Button
        Me.tipPacientes = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdModificar = New System.Windows.Forms.Button
        Me.cmdCerrar = New System.Windows.Forms.Button
        Me.cmdRefrescar = New System.Windows.Forms.Button
        Me.cmdEliminar = New System.Windows.Forms.Button
        Me.grbFiltro = New System.Windows.Forms.GroupBox
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.lblNombre = New System.Windows.Forms.Label
        Me.lblApellido1 = New System.Windows.Forms.Label
        Me.lblApellido2 = New System.Windows.Forms.Label
        Me.txtApellido1 = New System.Windows.Forms.TextBox
        Me.txtApellido2 = New System.Windows.Forms.TextBox
        CType(Me.dtgPacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbFiltro.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtgPacientes
        '
        Me.dtgPacientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgPacientes.CaptionText = "Pacientes registrados"
        Me.dtgPacientes.DataMember = ""
        Me.dtgPacientes.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dtgPacientes.Location = New System.Drawing.Point(16, 128)
        Me.dtgPacientes.Name = "dtgPacientes"
        Me.dtgPacientes.ReadOnly = True
        Me.dtgPacientes.Size = New System.Drawing.Size(768, 280)
        Me.dtgPacientes.TabIndex = 1
        Me.dtgPacientes.TabStop = False
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdNuevo.Location = New System.Drawing.Point(800, 128)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(80, 32)
        Me.cmdNuevo.TabIndex = 2
        Me.cmdNuevo.Text = "Nuevo..."
        Me.tipPacientes.SetToolTip(Me.cmdNuevo, "Registrar nuevo Paciente")
        '
        'cmdModificar
        '
        Me.cmdModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdModificar.Location = New System.Drawing.Point(800, 176)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(80, 32)
        Me.cmdModificar.TabIndex = 3
        Me.cmdModificar.Text = "Modificar..."
        Me.tipPacientes.SetToolTip(Me.cmdModificar, "Modificar Paciente existente")
        '
        'cmdCerrar
        '
        Me.cmdCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCerrar.Location = New System.Drawing.Point(800, 376)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(80, 32)
        Me.cmdCerrar.TabIndex = 4
        Me.cmdCerrar.Text = "Cerrar"
        Me.tipPacientes.SetToolTip(Me.cmdCerrar, "Cerrar ventana de Pacientes")
        '
        'cmdRefrescar
        '
        Me.cmdRefrescar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdRefrescar.Location = New System.Drawing.Point(800, 272)
        Me.cmdRefrescar.Name = "cmdRefrescar"
        Me.cmdRefrescar.Size = New System.Drawing.Size(80, 32)
        Me.cmdRefrescar.TabIndex = 3
        Me.cmdRefrescar.Text = "Refrescar"
        Me.tipPacientes.SetToolTip(Me.cmdRefrescar, "Actualizar los pacientes registrados")
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdEliminar.Location = New System.Drawing.Point(800, 224)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(80, 32)
        Me.cmdEliminar.TabIndex = 3
        Me.cmdEliminar.Text = "Eliminar"
        Me.tipPacientes.SetToolTip(Me.cmdEliminar, "Eliminar paciente seleccionado")
        '
        'grbFiltro
        '
        Me.grbFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grbFiltro.Controls.Add(Me.txtNombre)
        Me.grbFiltro.Controls.Add(Me.lblNombre)
        Me.grbFiltro.Controls.Add(Me.lblApellido1)
        Me.grbFiltro.Controls.Add(Me.lblApellido2)
        Me.grbFiltro.Controls.Add(Me.txtApellido1)
        Me.grbFiltro.Controls.Add(Me.txtApellido2)
        Me.grbFiltro.Location = New System.Drawing.Point(16, 16)
        Me.grbFiltro.Name = "grbFiltro"
        Me.grbFiltro.Size = New System.Drawing.Size(872, 88)
        Me.grbFiltro.TabIndex = 0
        Me.grbFiltro.TabStop = False
        Me.grbFiltro.Text = "Filtro de Pacientes"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(16, 48)
        Me.txtNombre.MaxLength = 20
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(250, 21)
        Me.txtNombre.TabIndex = 0
        '
        'lblNombre
        '
        Me.lblNombre.Location = New System.Drawing.Point(24, 25)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(240, 16)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblApellido1
        '
        Me.lblApellido1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblApellido1.Location = New System.Drawing.Point(322, 25)
        Me.lblApellido1.Name = "lblApellido1"
        Me.lblApellido1.Size = New System.Drawing.Size(240, 16)
        Me.lblApellido1.TabIndex = 0
        Me.lblApellido1.Text = "Primer Apellido"
        Me.lblApellido1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblApellido2
        '
        Me.lblApellido2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblApellido2.Location = New System.Drawing.Point(618, 25)
        Me.lblApellido2.Name = "lblApellido2"
        Me.lblApellido2.Size = New System.Drawing.Size(240, 16)
        Me.lblApellido2.TabIndex = 0
        Me.lblApellido2.Text = "Segundo Apellido"
        Me.lblApellido2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtApellido1
        '
        Me.txtApellido1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtApellido1.Location = New System.Drawing.Point(312, 48)
        Me.txtApellido1.MaxLength = 20
        Me.txtApellido1.Name = "txtApellido1"
        Me.txtApellido1.Size = New System.Drawing.Size(250, 21)
        Me.txtApellido1.TabIndex = 1
        '
        'txtApellido2
        '
        Me.txtApellido2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtApellido2.Location = New System.Drawing.Point(608, 48)
        Me.txtApellido2.MaxLength = 20
        Me.txtApellido2.Name = "txtApellido2"
        Me.txtApellido2.Size = New System.Drawing.Size(250, 21)
        Me.txtApellido2.TabIndex = 2
        '
        'frmPacientes
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.cmdCerrar
        Me.ClientSize = New System.Drawing.Size(912, 429)
        Me.Controls.Add(Me.grbFiltro)
        Me.Controls.Add(Me.cmdNuevo)
        Me.Controls.Add(Me.dtgPacientes)
        Me.Controls.Add(Me.cmdModificar)
        Me.Controls.Add(Me.cmdCerrar)
        Me.Controls.Add(Me.cmdRefrescar)
        Me.Controls.Add(Me.cmdEliminar)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmPacientes"
        Me.Text = "Gestión de Pacientes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dtgPacientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbFiltro.ResumeLayout(False)
        Me.grbFiltro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Const cteModulo As String = "Pacientes"

    'Variable para controlar el número de instancias abiertas
    Private Shared objInstancia As frmPacientes = Nothing

    'Función que crea una sola instancia del formulario de Pacientes
    Public Shared Function Instancia() As frmPacientes

        If IsNothing(objInstancia) OrElse objInstancia.IsDisposed = True Then
            objInstancia = New frmPacientes()
        End If

        objInstancia.BringToFront()

        Return objInstancia

    End Function


    Private Const cte_Entidad As String = "Pacientes"

    Private arrCampos() As String = {"PAC_ID", "PAC_Nombre", "PAC_Apellido1", "PAC_Apellido2"}
    Private arrCabeceras() As String = {"Matrícula", "Nombre", "Apellido 1", "Apellido 2"}
    Private arrTiposDatos() As String = {"I", "S", "S", "S"}
    Private arrAnchuras() As Integer = {80, 200, 200, 200}


#Region " CONTROLES "

    Private Sub CargarFormulario(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'RecuperarPacientes()
        mLLenarPacientes()
    End Sub

    Private Sub RestaurarFormulario(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub CerrarFormulario(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        dtPacientes.Dispose()
    End Sub


    Private Sub Filtro(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.TextChanged, txtApellido1.TextChanged, txtApellido2.TextChanged
        mLLenarPacientes()
    End Sub

    Private Sub SeleccionarTexto(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre.Enter, txtApellido1.Enter, txtApellido2.Enter
        CType(sender, TextBox).SelectAll()
    End Sub


    Private Sub NavegarGrid(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgPacientes.CurrentCellChanged
        dtgPacientes.Select(dtgPacientes.CurrentRowIndex)
    End Sub

    Private Sub ModificarFila(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgPacientes.DoubleClick
        If cmdModificar.Enabled Then
            cmdModificar.PerformClick()
        End If
    End Sub

    Private Sub SeleccionarUnaFila(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtgPacientes.MouseUp

        Dim objTest As DataGrid.HitTestInfo = dtgPacientes.HitTest(New Point(e.X, e.Y))

        ' Si es una celda
        If objTest.Type = DataGrid.HitTestType.Cell Then
            dtgPacientes.Select(objTest.Row)
        End If

        ' Habilitar el botón Modificar cuando se seleccione una celda. No valen las cabeceras.
        cmdModificar.Enabled = (objTest.Type = DataGrid.HitTestType.Cell)
        cmdEliminar.Enabled = (objTest.Type = DataGrid.HitTestType.Cell)

    End Sub


    Private Sub RegistrarPaciente(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click

        Dim objPacientesDetalle As New frmPacientesDetalle()

        With objPacientesDetalle
            .IDPaciente = 0
            .TipoMant = eTiposMantenimiento.Alta

            If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                'RecuperarPacientes()
                mLLenarPacientes()
            End If
        End With

    End Sub

    Private Sub ModificarPaciente(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click

        Dim objPacientesDetalle As New frmPacientesDetalle()

        With objPacientesDetalle
            Dim sPaciente As String

            'Nombre
            If IsDBNull(dtgPacientes.Item(dtgPacientes.CurrentRowIndex, 1)) Then
                sPaciente = String.Empty
            Else
                sPaciente = dtgPacientes.Item(dtgPacientes.CurrentRowIndex, 1).ToString & Space(1)
            End If

            'Primer Apellido
            If IsDBNull(dtgPacientes.Item(dtgPacientes.CurrentRowIndex, 2)) Then
                sPaciente &= String.Empty
            Else
                sPaciente &= dtgPacientes.Item(dtgPacientes.CurrentRowIndex, 2).ToString & Space(1)
            End If

            'Segundo Apellido
            If IsDBNull(dtgPacientes.Item(dtgPacientes.CurrentRowIndex, 3)) Then
                sPaciente &= String.Empty
            Else
                sPaciente &= dtgPacientes.Item(dtgPacientes.CurrentRowIndex, 3).ToString & Space(1)
            End If

            .Text = "Paciente: " & sPaciente.Trim

            .IDPaciente = CType(dtgPacientes.Item(dtgPacientes.CurrentRowIndex, 0), Integer)
            .TipoMant = eTiposMantenimiento.Modificacion

            If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                mLLenarPacientes()
            End If
        End With

    End Sub

    Private Sub EliminarPaciente(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click

        If MessageBox.Show("Se va a Eliminar el Paciente seleccionado. ¿Estás seguro?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            Dim iIDPaciente As Integer = CType(dtgPacientes.Item(dtgPacientes.CurrentRowIndex, 0), Integer)

            If mEliminarPaciente(iIDPaciente) Then
                'RecuperarPacientes()
                mLLenarPacientes()
            End If
        End If

    End Sub

    Private Sub Refrescar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefrescar.Click

        txtNombre.Text = String.Empty
        txtApellido1.Text = String.Empty
        txtApellido2.Text = String.Empty

        'RecuperarPacientes()
        mLLenarPacientes()

    End Sub

    Private Sub Cerrar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click
        dtPacientes.Dispose()
        Me.Dispose()
    End Sub

#End Region


#Region " FUNCIONES "


    Private Sub mOKBotones()

        Dim bOK As Boolean

        bOK = (dtPacientes.Rows.Count > 0)

        cmdModificar.Enabled = bOK
        cmdEliminar.Enabled = bOK

    End Sub

    Private Function mEliminarPaciente(ByVal iIDPaciente As Integer) As Boolean

        Dim objBDatos As New AccesoBD_MySQL()
        Dim iNumFilas As Integer = 0
        Dim bOKTransaccion As Boolean = False
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
                            .ParameterName = "iIDPaciente"
                            .MySqlDbType = MySqlDbType.Int32
                            .Size = 4
                            .Value = iIDPaciente
                            .Direction = ParameterDirection.Input
                        End With

                        bOK = .EjecutarSP("spPacientes_Eliminar", arrParametros)

                        If bOK Then
                            bOK = .ConfirmarTransaccion
                            bOKTransaccion = bOK
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
            'Descargar objetos
            objBDatos.Dispose()

        End Try

        Return bOKTransaccion

    End Function

    Private Sub mLLenarPacientes()

        Dim sNombreCompleto As String = String.Empty
        Dim sNombre As String = txtNombre.Text.Trim
        Dim sApellido1 As String = txtApellido1.Text.Trim
        Dim sApellido2 As String = txtApellido2.Text.Trim

        Dim dtPacientes As DataTable = LLenarPacientes(sNombre, sApellido1, sApellido2, sNombreCompleto, eTiposRellenoPacientes.Pacientes)

        If Not IsNothing(dtPacientes) Then
            If dtPacientes.Rows.Count > 0 Then
                NovafisDataGrid.ColumnaSeleccion(dtPacientes)

                dtgPacientes.SetDataBinding(dtPacientes, String.Empty)
                NovafisDataGrid.EstiloGrid(arrCampos, arrCabeceras, arrTiposDatos, arrAnchuras, dtgPacientes, "Pacientes", True)
            Else
                dtgPacientes.SetDataBinding(Nothing, String.Empty)
            End If
        End If

        'Dim objBDatos As New AccesoBD_MySQL()
        'Dim dtPacientes As New DataTable("Pacientes")
        'Dim iNumPacientes As Integer = 0

        'Dim bOK As Boolean

        'Try
        '    With objBDatos
        '        bOK = .AbrirConexion()

        '        If bOK Then
        '            Dim arrParametros(4) As MySqlParameter

        '            arrParametros(0) = New MySqlParameter()
        '            With arrParametros(0)
        '                .ParameterName = "iTipo"
        '                .MySqlDbType = MySqlDbType.Byte
        '                .Size = 3
        '                .Value = eTiposRellenoPacientes.Pacientes
        '                .Direction = ParameterDirection.Input
        '            End With

        '            arrParametros(1) = New MySqlParameter()
        '            With arrParametros(1)
        '                .ParameterName = "sNombreCompleto"
        '                .MySqlDbType = MySqlDbType.VarChar
        '                .Size = 200
        '                .Value = String.Empty
        '                .Direction = ParameterDirection.Input
        '            End With

        '            arrParametros(2) = New MySqlParameter()
        '            With arrParametros(2)
        '                .ParameterName = "sNombre"
        '                .MySqlDbType = MySqlDbType.VarChar
        '                .Size = 50
        '                .Value = txtNombre.Text.Trim
        '                .Direction = ParameterDirection.Input
        '            End With

        '            arrParametros(3) = New MySqlParameter()
        '            With arrParametros(3)
        '                .ParameterName = "sApellido1"
        '                .MySqlDbType = MySqlDbType.VarChar
        '                .Size = 50
        '                .Value = txtApellido1.Text.Trim
        '                .Direction = ParameterDirection.Input
        '            End With

        '            arrParametros(4) = New MySqlParameter()
        '            With arrParametros(4)
        '                .ParameterName = "sApellido2"
        '                .MySqlDbType = MySqlDbType.VarChar
        '                .Size = 50
        '                .Value = txtApellido2.Text.Trim
        '                .Direction = ParameterDirection.Input
        '            End With

        '            bOK = .EjecutarSP("spPacientes_LLenar", arrParametros, dtPacientes, iNumPacientes)

        '            If bOK Then
        '                If Not IsNothing(dtPacientes) Then
        '                    If iNumPacientes > 0 Then
        '                        NovafisDataGrid.ColumnaSeleccion(dtPacientes)

        '                        dtgPacientes.SetDataBinding(dtPacientes, String.Empty)
        '                        NovafisDataGrid.EstiloGrid(arrCampos, arrCabeceras, arrTiposDatos, arrAnchuras, dtgPacientes, "Pacientes", True)
        '                    End If
        '                End If
        '            End If

        '            bOK = .CerrarConexion
        '        End If
        '    End With

        'Catch exError As Exception
        '    GestionarErrores(exError.Message, "Llenar Pacientes", MessageBoxIcon.Error, EventLogEntryType.Error)

        'Finally
        '    ' Descargar objetos
        '    dtPacientes.Dispose()
        '    objBDatos.Dispose()

        'End Try

    End Sub

    'Private Sub mLLenarPacientes(ByVal tblPacientes As DataTable)
    '    'dtgPacientes.DataSource = Nothing
    '    dtgPacientes.SetDataBinding(tblPacientes, String.Empty)
    '    NovafisDataGrid.EstiloGrid(arrCampos, arrCabeceras, arrTiposDatos, arrAnchuras, dtgPacientes, cte_Entidad)
    'End Sub

    Private Sub mFiltrarPacientes()

        Dim sFiltro As String = "PAC_Nombre LIKE '" & txtNombre.Text.Trim & "%' AND PAC_Apellido1 LIKE '" & txtApellido1.Text.Trim & "%'" & " AND PAC_Apellido2 LIKE '" & txtApellido2.Text.Trim & "%'"
        Dim sOrden As String = "PAC_Nombre"
        Dim arrPacientes As DataRow() = dtPacientes.Select(sFiltro, sOrden)

        Dim tblPacientes As DataTable = dtPacientes.Clone()
        Dim drFila As DataRow

        If arrPacientes.Length > 0 Then

            For Each drFila In arrPacientes
                tblPacientes.ImportRow(drFila)
            Next drFila
        End If

        mLLenarPacientes()
    End Sub

#End Region


End Class
