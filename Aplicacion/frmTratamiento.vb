Option Strict On
Option Explicit On 

Public Class frmTratamiento

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
    Friend WithEvents tipTratamiento As System.Windows.Forms.ToolTip
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents txtDescTratamiento As System.Windows.Forms.TextBox
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents cboEstado As System.Windows.Forms.ComboBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblSesiones As System.Windows.Forms.Label
    Friend WithEvents nudSesiones As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmdCerrar As System.Windows.Forms.Button
    Friend WithEvents cmdGuardar As System.Windows.Forms.Button
    Friend WithEvents grbLocalizacion As System.Windows.Forms.GroupBox
    Friend WithEvents cboLocalizaciones As System.Windows.Forms.ComboBox
    Friend WithEvents grbLesion As System.Windows.Forms.GroupBox
    Friend WithEvents cboLesiones As System.Windows.Forms.ComboBox
    Friend WithEvents radLesExistente As System.Windows.Forms.RadioButton
    Friend WithEvents radLocExistente As System.Windows.Forms.RadioButton
    Friend WithEvents radLocNueva As System.Windows.Forms.RadioButton
    Friend WithEvents radLesNueva As System.Windows.Forms.RadioButton
    Friend WithEvents txtLocNueva As System.Windows.Forms.TextBox
    Friend WithEvents cboFisios As System.Windows.Forms.ComboBox
    Friend WithEvents lblFisio As System.Windows.Forms.Label
    Friend WithEvents txtLesNueva As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.tipTratamiento = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdCerrar = New System.Windows.Forms.Button()
        Me.cmdGuardar = New System.Windows.Forms.Button()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.txtDescTratamiento = New System.Windows.Forms.TextBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.cboEstado = New System.Windows.Forms.ComboBox()
        Me.lblSesiones = New System.Windows.Forms.Label()
        Me.nudSesiones = New System.Windows.Forms.NumericUpDown()
        Me.grbLocalizacion = New System.Windows.Forms.GroupBox()
        Me.txtLocNueva = New System.Windows.Forms.TextBox()
        Me.radLocExistente = New System.Windows.Forms.RadioButton()
        Me.cboLocalizaciones = New System.Windows.Forms.ComboBox()
        Me.radLocNueva = New System.Windows.Forms.RadioButton()
        Me.grbLesion = New System.Windows.Forms.GroupBox()
        Me.txtLesNueva = New System.Windows.Forms.TextBox()
        Me.radLesNueva = New System.Windows.Forms.RadioButton()
        Me.radLesExistente = New System.Windows.Forms.RadioButton()
        Me.cboLesiones = New System.Windows.Forms.ComboBox()
        Me.cboFisios = New System.Windows.Forms.ComboBox()
        Me.lblFisio = New System.Windows.Forms.Label()
        CType(Me.nudSesiones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbLocalizacion.SuspendLayout()
        Me.grbLesion.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdCerrar
        '
        Me.cmdCerrar.Location = New System.Drawing.Point(472, 377)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(80, 32)
        Me.cmdCerrar.TabIndex = 8
        Me.cmdCerrar.Text = "Cerrar"
        Me.tipTratamiento.SetToolTip(Me.cmdCerrar, "Cerrar ventana de Tratamiento")
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Enabled = False
        Me.cmdGuardar.Location = New System.Drawing.Point(368, 377)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(80, 32)
        Me.cmdGuardar.TabIndex = 7
        Me.cmdGuardar.Text = "Guardar"
        Me.tipTratamiento.SetToolTip(Me.cmdGuardar, "Guardar Tratamiento de la sesión actual")
        '
        'dtpFecha
        '
        Me.dtpFecha.CustomFormat = "dd/MM/yyyy"
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha.Location = New System.Drawing.Point(92, 20)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(96, 21)
        Me.dtpFecha.TabIndex = 0
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(34, 24)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(45, 13)
        Me.lblFecha.TabIndex = 1
        Me.lblFecha.Text = "Fecha:"
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(16, 89)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(172, 13)
        Me.lblDescripcion.TabIndex = 1
        Me.lblDescripcion.Text = "Descripción del Tratamiento:"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDescTratamiento
        '
        Me.txtDescTratamiento.Location = New System.Drawing.Point(16, 113)
        Me.txtDescTratamiento.MaxLength = 1000
        Me.txtDescTratamiento.Multiline = True
        Me.txtDescTratamiento.Name = "txtDescTratamiento"
        Me.txtDescTratamiento.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescTratamiento.Size = New System.Drawing.Size(536, 72)
        Me.txtDescTratamiento.TabIndex = 2
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(320, 24)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(50, 13)
        Me.lblEstado.TabIndex = 1
        Me.lblEstado.Text = "Estado:"
        Me.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboEstado
        '
        Me.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEstado.Location = New System.Drawing.Point(376, 21)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(176, 21)
        Me.cboEstado.TabIndex = 1
        '
        'lblSesiones
        '
        Me.lblSesiones.AutoSize = True
        Me.lblSesiones.Location = New System.Drawing.Point(16, 55)
        Me.lblSesiones.Name = "lblSesiones"
        Me.lblSesiones.Size = New System.Drawing.Size(63, 13)
        Me.lblSesiones.TabIndex = 6
        Me.lblSesiones.Text = "Sesiones:"
        Me.lblSesiones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudSesiones
        '
        Me.nudSesiones.Location = New System.Drawing.Point(92, 53)
        Me.nudSesiones.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudSesiones.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudSesiones.Name = "nudSesiones"
        Me.nudSesiones.ReadOnly = True
        Me.nudSesiones.Size = New System.Drawing.Size(96, 21)
        Me.nudSesiones.TabIndex = 6
        Me.nudSesiones.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudSesiones.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'grbLocalizacion
        '
        Me.grbLocalizacion.Controls.Add(Me.txtLocNueva)
        Me.grbLocalizacion.Controls.Add(Me.radLocExistente)
        Me.grbLocalizacion.Controls.Add(Me.cboLocalizaciones)
        Me.grbLocalizacion.Controls.Add(Me.radLocNueva)
        Me.grbLocalizacion.Location = New System.Drawing.Point(16, 201)
        Me.grbLocalizacion.Name = "grbLocalizacion"
        Me.grbLocalizacion.Size = New System.Drawing.Size(256, 160)
        Me.grbLocalizacion.TabIndex = 11
        Me.grbLocalizacion.TabStop = False
        Me.grbLocalizacion.Text = " Localización"
        '
        'txtLocNueva
        '
        Me.txtLocNueva.Location = New System.Drawing.Point(16, 96)
        Me.txtLocNueva.MaxLength = 100
        Me.txtLocNueva.Multiline = True
        Me.txtLocNueva.Name = "txtLocNueva"
        Me.txtLocNueva.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLocNueva.Size = New System.Drawing.Size(224, 48)
        Me.txtLocNueva.TabIndex = 14
        '
        'radLocExistente
        '
        Me.radLocExistente.Location = New System.Drawing.Point(16, 24)
        Me.radLocExistente.Name = "radLocExistente"
        Me.radLocExistente.Size = New System.Drawing.Size(16, 24)
        Me.radLocExistente.TabIndex = 13
        '
        'cboLocalizaciones
        '
        Me.cboLocalizaciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLocalizaciones.Location = New System.Drawing.Point(40, 24)
        Me.cboLocalizaciones.Name = "cboLocalizaciones"
        Me.cboLocalizaciones.Size = New System.Drawing.Size(200, 21)
        Me.cboLocalizaciones.TabIndex = 10
        '
        'radLocNueva
        '
        Me.radLocNueva.Location = New System.Drawing.Point(16, 64)
        Me.radLocNueva.Name = "radLocNueva"
        Me.radLocNueva.Size = New System.Drawing.Size(144, 24)
        Me.radLocNueva.TabIndex = 13
        Me.radLocNueva.Text = "Nueva localización"
        '
        'grbLesion
        '
        Me.grbLesion.Controls.Add(Me.txtLesNueva)
        Me.grbLesion.Controls.Add(Me.radLesNueva)
        Me.grbLesion.Controls.Add(Me.radLesExistente)
        Me.grbLesion.Controls.Add(Me.cboLesiones)
        Me.grbLesion.Location = New System.Drawing.Point(296, 201)
        Me.grbLesion.Name = "grbLesion"
        Me.grbLesion.Size = New System.Drawing.Size(256, 160)
        Me.grbLesion.TabIndex = 12
        Me.grbLesion.TabStop = False
        Me.grbLesion.Text = " Lesión "
        '
        'txtLesNueva
        '
        Me.txtLesNueva.Location = New System.Drawing.Point(16, 96)
        Me.txtLesNueva.MaxLength = 100
        Me.txtLesNueva.Multiline = True
        Me.txtLesNueva.Name = "txtLesNueva"
        Me.txtLesNueva.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLesNueva.Size = New System.Drawing.Size(224, 48)
        Me.txtLesNueva.TabIndex = 15
        '
        'radLesNueva
        '
        Me.radLesNueva.Location = New System.Drawing.Point(16, 64)
        Me.radLesNueva.Name = "radLesNueva"
        Me.radLesNueva.Size = New System.Drawing.Size(144, 24)
        Me.radLesNueva.TabIndex = 14
        Me.radLesNueva.Text = "Nueva lesión"
        '
        'radLesExistente
        '
        Me.radLesExistente.Location = New System.Drawing.Point(16, 24)
        Me.radLesExistente.Name = "radLesExistente"
        Me.radLesExistente.Size = New System.Drawing.Size(16, 24)
        Me.radLesExistente.TabIndex = 12
        '
        'cboLesiones
        '
        Me.cboLesiones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLesiones.Location = New System.Drawing.Point(40, 24)
        Me.cboLesiones.Name = "cboLesiones"
        Me.cboLesiones.Size = New System.Drawing.Size(200, 21)
        Me.cboLesiones.TabIndex = 11
        '
        'cboFisios
        '
        Me.cboFisios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFisios.Location = New System.Drawing.Point(376, 52)
        Me.cboFisios.Name = "cboFisios"
        Me.cboFisios.Size = New System.Drawing.Size(176, 21)
        Me.cboFisios.TabIndex = 1
        '
        'lblFisio
        '
        Me.lblFisio.AutoSize = True
        Me.lblFisio.Location = New System.Drawing.Point(278, 55)
        Me.lblFisio.Name = "lblFisio"
        Me.lblFisio.Size = New System.Drawing.Size(92, 13)
        Me.lblFisio.TabIndex = 1
        Me.lblFisio.Text = "Fisioterapeuta:"
        Me.lblFisio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmTratamiento
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(578, 429)
        Me.ControlBox = False
        Me.Controls.Add(Me.grbLesion)
        Me.Controls.Add(Me.grbLocalizacion)
        Me.Controls.Add(Me.cmdCerrar)
        Me.Controls.Add(Me.nudSesiones)
        Me.Controls.Add(Me.lblSesiones)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.lblFisio)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.cboFisios)
        Me.Controls.Add(Me.cboEstado)
        Me.Controls.Add(Me.txtDescTratamiento)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.cmdGuardar)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmTratamiento"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tratamiento"
        CType(Me.nudSesiones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbLocalizacion.ResumeLayout(False)
        Me.grbLocalizacion.PerformLayout()
        Me.grbLesion.ResumeLayout(False)
        Me.grbLesion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private cteModulo As String = "Detalle de Tratamientos"

    Friend IDPaciente As Integer
    Friend IDTratamiento As Integer
    Friend IDFisioRef As Integer
    Friend TipoMantenimiento As eTiposMantenimiento

    'Friend PrimeraSesion As Boolean
    Friend NumSesion As Integer
    Friend Estado As eEstadosTratamiento


#Region " CONTROLES "

    Private Sub CargarFormulario(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mCargarEstados()
        mCargarLocalizaciones()
        mCargarLesiones()
        mInicializarFormulario()
    End Sub


    Private Sub CambioLocalizacionExistente(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radLocExistente.CheckedChanged
        cboLocalizaciones.Enabled = radLocExistente.Checked
    End Sub

    Private Sub CambioLesionExistente(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radLesExistente.CheckedChanged
        cboLesiones.Enabled = radLesExistente.Checked
    End Sub

    Private Sub radLocNueva_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radLocNueva.CheckedChanged
        txtLocNueva.ReadOnly = Not radLocNueva.Checked
        mOKGuardar()
    End Sub

    Private Sub radLesNueva_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radLesNueva.CheckedChanged
        txtLesNueva.ReadOnly = Not radLesNueva.Checked
        mOKGuardar()
    End Sub


    Private Sub GuardarSesion(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click

        If radLocNueva.Checked Then
            Dim iIDNuevaLoc As Integer
            Dim bOK As Boolean

            bOK = GuardarLocalizacion(eTiposMantenimiento.Alta, txtLocNueva.Text.Trim, 0, iIDNuevaLoc)

            If bOK And iIDNuevaLoc > 0 Then
                txtLocNueva.Tag = iIDNuevaLoc
            End If
        End If

        If radLesNueva.Checked Then
            Dim iIDNuevaLes As Integer
            Dim bOK As Boolean

            bOK = GuardarLesion(eTiposMantenimiento.Alta, txtLesNueva.Text.Trim, 0, iIDNuevaLes)

            If bOK And iIDNuevaLes > 0 Then
                txtLesNueva.Tag = iIDNuevaLes
            End If
        End If

        If mbGuardarSesion() Then
            Me.DialogResult = DialogResult.OK
        Else
            Me.DialogResult = DialogResult.Cancel
        End If

        Me.Dispose()

    End Sub

    Private Sub cmdCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click
        With Me
            .DialogResult = DialogResult.Cancel
            .Dispose()
        End With
    End Sub

    Private Sub txtDescTratamiento_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescTratamiento.TextChanged
        mOKGuardar()
    End Sub

    Private Sub txtLocNueva_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLocNueva.TextChanged
        mOKGuardar()
    End Sub

    Private Sub txtLesNueva_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLesNueva.TextChanged
        mOKGuardar()
    End Sub

#End Region


#Region " FUNCIONES "

    Private Sub mInicializarFormulario()

        Dim bOK As Boolean
        Dim iIndice As Integer

        radLocExistente.Checked = True
        radLesExistente.Checked = True

        txtLocNueva.ReadOnly = True
        txtLesNueva.ReadOnly = True

        mCargarFisios()

        Select Case Me.TipoMantenimiento
            Case eTiposMantenimiento.Alta
                dtpFecha.Value = DateTime.Today

                Select Case Me.Estado
                    Case eEstadosTratamiento.NoEstado, eEstadosTratamiento.Inicio
                        cboEstado.SelectedIndex = CType(Me.Estado, Integer)
                        nudSesiones.Value = Me.NumSesion + 1

                    Case eEstadosTratamiento.Continuacion
                        cboEstado.SelectedIndex = CType(Me.Estado, Integer) - 1
                        nudSesiones.Value = Me.NumSesion + 1

                    Case eEstadosTratamiento.Alta, eEstadosTratamiento.IniFin, eEstadosTratamiento.IniNoc
                        cboEstado.SelectedIndex = 0
                        nudSesiones.Value = 1

                End Select

                bOK = BuscarElementoCombo(CType(cboFisios.DataSource, DataTable), Me.IDFisioRef.ToString, iIndice)

                If bOK Then
                    cboFisios.SelectedIndex = iIndice
                End If

            Case eTiposMantenimiento.Modificacion
                mCargarSesion()
        End Select

    End Sub

    Private Sub mCargarFisios()

        Dim dtFisios As DataTable = CargarFisios()
        Dim iNumFisios As Integer = dtFisios.Rows.Count

        If iNumFisios > 0 Then
            With cboFisios
                .Items.Clear()

                .DataSource = dtFisios

                .DisplayMember = "FIS_Alias"
                .ValueMember = "FIS_ID"

                .SelectedIndex = 0
            End With
        End If

    End Sub

    Private Sub mCargarEstados()

        Dim objBDatos As New AccesoBD_MySQL()
        Dim dtEstados As New DataTable("Estados")
        Dim iNumEstados As Integer = 0
        Dim sSQL As String = String.Empty
        Dim bOK As Boolean

        Try
            With objBDatos
                bOK = .AbrirConexion

                If bOK Then
                    bOK = objBDatos.EjecutarSP("spEstados_LLenar", Nothing, dtEstados, iNumEstados)

                    If bOK And Not IsNothing(dtEstados) Then
                        With cboEstado
                            .DataSource = dtEstados
                            .DisplayMember = "EST_Descripcion"
                            .ValueMember = "EST_ID"
                            '.SelectedIndex = 0
                        End With
                    End If

                    bOK = .CerrarConexion
                End If
            End With

        Catch exError As Exception
            GestionarErrores(exError.Message, cteModulo, MessageBoxIcon.Error, EventLogEntryType.Error)

        Finally
            ' Descargar objetos
            objBDatos.Dispose()

        End Try

    End Sub

    Private Sub mCargarLocalizaciones()

        Dim objBDatos As New AccesoBD_MySQL()
        Dim dtLocalizaciones As New DataTable()
        Dim iNumLocalizaciones As Integer = 0
        Dim sSQL As String = String.Empty
        Dim bOK As Boolean

        Try
            With objBDatos
                bOK = .AbrirConexion

                If bOK Then
                    Dim arrParametros(0) As MySqlParameter

                    arrParametros(0) = New MySqlParameter()
                    With arrParametros(0)
                        .ParameterName = "iIDLocalizacion"
                        .MySqlDbType = MySqlDbType.Int32
                        .Size = 10
                        .Value = DBNull.Value
                        .Direction = ParameterDirection.Input
                    End With

                    bOK = objBDatos.EjecutarSP("spLocalizaciones_LLenar", arrParametros, dtLocalizaciones, iNumLocalizaciones)

                    If bOK And Not IsNothing(dtLocalizaciones) Then
                        If iNumLocalizaciones > 0 Then
                            With cboLocalizaciones
                                .DataSource = dtLocalizaciones
                                .DisplayMember = "LOC_Descripcion"
                                .ValueMember = "LOC_ID"
                                .SelectedIndex = 0
                            End With
                        End If
                    End If

                    bOK = .CerrarConexion
                End If
            End With

        Catch exError As Exception
            GestionarErrores(exError.Message, cteModulo, MessageBoxIcon.Error, EventLogEntryType.Error)

        Finally
            ' Descargar objetos
            objBDatos.Dispose()

        End Try

    End Sub

    Private Sub mCargarLesiones()

        Dim objBDatos As New AccesoBD_MySQL()
        Dim dtLesiones As New DataTable()
        Dim iNumLesiones As Integer = 0
        Dim sSQL As String = String.Empty
        Dim bOK As Boolean

        Try
            With objBDatos
                bOK = .AbrirConexion

                If bOK Then
                    Dim arrParametros(0) As MySqlParameter

                    arrParametros(0) = New MySqlParameter()
                    With arrParametros(0)
                        .ParameterName = "iIDLesion"
                        .MySqlDbType = MySqlDbType.Int32
                        .Size = 10
                        .Value = DBNull.Value
                        .Direction = ParameterDirection.Input
                    End With

                    bOK = objBDatos.EjecutarSP("spLesiones_LLenar", arrParametros, dtLesiones, iNumLesiones)

                    If bOK And Not IsNothing(dtLesiones) Then
                        If iNumLesiones > 0 Then
                            With cboLesiones
                                .DataSource = dtLesiones
                                .DisplayMember = "LES_Descripcion"
                                .ValueMember = "LES_ID"
                                .SelectedIndex = 0
                            End With
                        End If
                    End If

                    bOK = .CerrarConexion
                End If
            End With

        Catch exError As Exception
            GestionarErrores(exError.Message, cteModulo, MessageBoxIcon.Error, EventLogEntryType.Error)

        Finally
            ' Descargar objetos
            objBDatos.Dispose()

        End Try

    End Sub

    Private Sub mCargarSesion()

        Dim objBDatos As New AccesoBD_MySQL()
        Dim dtSesion As New DataTable()
        Dim sSQL As String = String.Empty
        Dim iNumFilas As Integer = 1
        Dim bOK As Boolean

        Try
            With objBDatos
                bOK = .AbrirConexion

                If bOK Then
                    Dim arrParametros(0) As MySqlParameter

                    arrParametros(0) = New MySqlParameter()
                    With arrParametros(0)
                        .ParameterName = "iIDTratamiento"
                        .MySqlDbType = MySqlDbType.Int32
                        .Size = 10
                        .Value = Me.IDTratamiento
                        .Direction = ParameterDirection.Input
                    End With

                    bOK = objBDatos.EjecutarSP("spTratamientos_LLenarDetalle", arrParametros, dtSesion, iNumFilas)

                    If bOK And Not IsNothing(dtSesion) Then
                        If iNumFilas = 1 Then
                            Dim drFilas As DataRow = dtSesion.Rows(0)
                            Dim iIndice As Integer
                            Dim bOKCombo As Boolean

                            dtpFecha.Value = DateTime.Parse(drFilas("PAT_Fecha").ToString)
                            txtDescTratamiento.Text = drFilas("PAT_Descripcion").ToString.Trim
                            'nudCobrado.Value = Convert.ToDecimal(drFilas("PAT_Cobrado"))
                            'nudDeuda.Value = Convert.ToDecimal(drFilas("PAT_Deuda"))
                            nudSesiones.Value = Convert.ToInt32(drFilas("PAT_Sesiones"))

                            ' Seleccionar el estado
                            bOKCombo = BuscarElementoCombo(CType(cboEstado.DataSource, DataTable), drFilas("EST_ID").ToString.Trim, iIndice)

                            If bOKCombo Then
                                cboEstado.SelectedIndex = iIndice
                            End If

                            ' Seleccionar la Localización
                            bOKCombo = BuscarElementoCombo(CType(cboLocalizaciones.DataSource, DataTable), drFilas("LOC_ID").ToString.Trim, iIndice)

                            If bOKCombo Then
                                cboLocalizaciones.SelectedIndex = iIndice
                            End If

                            ' Seleccionar la Lesión
                            bOKCombo = BuscarElementoCombo(CType(cboLesiones.DataSource, DataTable), drFilas("LES_ID").ToString.Trim, iIndice)

                            If bOKCombo Then
                                cboLesiones.SelectedIndex = iIndice
                            End If

                            ' Seleccionar el Fisio
                            bOKCombo = BuscarElementoCombo(CType(cboFisios.DataSource, DataTable), drFilas("FIS_ID").ToString.Trim, iIndice)

                            If bOKCombo Then
                                cboFisios.SelectedIndex = iIndice
                            End If
                        End If
                    End If

                    bOK = .CerrarConexion
                End If
            End With

        Catch exError As Exception
            GestionarErrores(exError.Message, cteModulo, MessageBoxIcon.Error, EventLogEntryType.Error)

        Finally
            ' Descargar objetos
            dtSesion.Dispose()
            objBDatos.Dispose()

        End Try

    End Sub

    Private Function mbGuardarSesion() As Boolean

        Dim objBDatos As New AccesoBD_MySQL()
        Dim sSQL As String = String.Empty
        Dim bOK As Boolean

        Try
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
                            .ParameterName = "sDescripcion"
                            .MySqlDbType = MySqlDbType.VarChar
                            .Size = 1000
                            .Value = txtDescTratamiento.Text.Trim
                            .Direction = ParameterDirection.Input
                        End With

                        arrParametros(2) = New MySqlParameter()
                        With arrParametros(2)
                            .ParameterName = "iIDEstado"
                            .MySqlDbType = MySqlDbType.Int16
                            .Size = 3
                            .Value = cboEstado.SelectedValue
                            .Direction = ParameterDirection.Input
                        End With

                        'arrParametros(3) = New MySqlParameter()
                        'With arrParametros(3)
                        '    .ParameterName = "dCobrado"
                        '    .MySqlDbType = MySqlDbType.Decimal
                        '    .Precision = 5
                        '    .Scale = 2
                        '    .Value = nudCobrado.Value
                        '    .Direction = ParameterDirection.Input
                        'End With

                        'arrParametros(4) = New MySqlParameter()
                        'With arrParametros(4)
                        '    .ParameterName = "dDeuda"
                        '    .MySqlDbType = MySqlDbType.Decimal
                        '    .Precision = 5
                        '    .Scale = 2
                        '    .Value = nudDeuda.Value
                        '    .Direction = ParameterDirection.Input
                        'End With

                        arrParametros(3) = New MySqlParameter()
                        With arrParametros(3)
                            .ParameterName = "iIDLocalizacion"
                            .MySqlDbType = MySqlDbType.Int32
                            .Size = 10
                            If radLocExistente.Checked Then
                                .Value = cboLocalizaciones.SelectedValue
                            Else
                                .Value = txtLocNueva.Tag
                            End If
                            .Direction = ParameterDirection.Input
                        End With

                        arrParametros(4) = New MySqlParameter()
                        With arrParametros(4)
                            .ParameterName = "iIDLesion"
                            .MySqlDbType = MySqlDbType.Int32
                            .Size = 10
                            If radLesExistente.Checked Then
                                .Value = cboLesiones.SelectedValue
                            Else
                                .Value = txtLesNueva.Tag
                            End If
                            .Direction = ParameterDirection.Input
                        End With

                        arrParametros(5) = New MySqlParameter()
                        With arrParametros(5)
                            .ParameterName = "iSesiones"
                            .MySqlDbType = MySqlDbType.Int24
                            .Size = 5
                            .Value = nudSesiones.Value
                            .Direction = ParameterDirection.Input
                        End With

                        arrParametros(6) = New MySqlParameter()
                        With arrParametros(6)
                            .ParameterName = "iIDFisio"
                            .MySqlDbType = MySqlDbType.Int32
                            .Size = 4
                            .Value = cboFisios.SelectedValue
                            .Direction = ParameterDirection.Input
                        End With

                        Select Case Me.TipoMantenimiento
                            Case eTiposMantenimiento.Alta
                                arrParametros(7) = New MySqlParameter()
                                With arrParametros(7)
                                    .ParameterName = "iIDPaciente"
                                    .MySqlDbType = MySqlDbType.Int32
                                    .Size = 4
                                    .Value = Me.IDPaciente
                                    .Direction = ParameterDirection.Input
                                End With

                                bOK = .EjecutarSP("spTratamientos_Anadir", arrParametros)

                            Case eTiposMantenimiento.Modificacion
                                arrParametros(7) = New MySqlParameter()
                                With arrParametros(7)
                                    .ParameterName = "iIDTratamiento"
                                    .MySqlDbType = MySqlDbType.Int32
                                    .Size = 4
                                    .Value = Me.IDTratamiento
                                    .Direction = ParameterDirection.Input
                                End With

                                bOK = .EjecutarSP("spTratamientos_Modificar", arrParametros)

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

    Private Sub mOKGuardar()

        Dim bOK As Boolean

        bOK = (txtDescTratamiento.Text.Trim.Length > 0)

        If bOK Then
            If radLocNueva.Checked Then
                bOK = (txtLocNueva.Text.Trim.Length > 0)
            End If
        End If

        If bOK Then
            If radLesNueva.Checked Then
                bOK = (txtLesNueva.Text.Trim.Length > 0)
            End If
        End If

        cmdGuardar.Enabled = bOK

    End Sub

#End Region


End Class
