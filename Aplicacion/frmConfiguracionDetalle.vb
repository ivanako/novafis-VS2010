Option Strict On
Option Explicit On 

Public Class frmConfiguracionDetalle

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
    Friend WithEvents grbVigencia As System.Windows.Forms.GroupBox
    Friend WithEvents dtpVFInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblVFInicio As System.Windows.Forms.Label
    Friend WithEvents lblVFFin As System.Windows.Forms.Label
    Friend WithEvents dtpVFFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents grbHorario As System.Windows.Forms.GroupBox
    Friend WithEvents cmdGuardar As System.Windows.Forms.Button
    Friend WithEvents cmdCerrar As System.Windows.Forms.Button
    Friend WithEvents grbTarifa As System.Windows.Forms.GroupBox
    Friend WithEvents nudPrecio As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblPrecio As System.Windows.Forms.Label
    Friend WithEvents lblEuros As System.Windows.Forms.Label
    Friend WithEvents grbMañana As System.Windows.Forms.GroupBox
    Friend WithEvents dtpHInicioM As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpHFinM As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblHIniM As System.Windows.Forms.Label
    Friend WithEvents lblHFinM As System.Windows.Forms.Label
    Friend WithEvents grbTarde As System.Windows.Forms.GroupBox
    Friend WithEvents dtpHoraFinT As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblHFinT As System.Windows.Forms.Label
    Friend WithEvents lblHIniT As System.Windows.Forms.Label
    Friend WithEvents dtpHoraIniT As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkManana As System.Windows.Forms.CheckBox
    Friend WithEvents nudIntervaloM As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblIntervaloM As System.Windows.Forms.Label
    Friend WithEvents nudIntervaloT As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkTarde As System.Windows.Forms.CheckBox
    Friend WithEvents lblIntervaloT As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.grbVigencia = New System.Windows.Forms.GroupBox
        Me.lblVFInicio = New System.Windows.Forms.Label
        Me.dtpVFInicio = New System.Windows.Forms.DateTimePicker
        Me.lblVFFin = New System.Windows.Forms.Label
        Me.dtpVFFin = New System.Windows.Forms.DateTimePicker
        Me.grbHorario = New System.Windows.Forms.GroupBox
        Me.chkManana = New System.Windows.Forms.CheckBox
        Me.grbMañana = New System.Windows.Forms.GroupBox
        Me.nudIntervaloM = New System.Windows.Forms.NumericUpDown
        Me.lblIntervaloM = New System.Windows.Forms.Label
        Me.dtpHInicioM = New System.Windows.Forms.DateTimePicker
        Me.dtpHFinM = New System.Windows.Forms.DateTimePicker
        Me.lblHIniM = New System.Windows.Forms.Label
        Me.lblHFinM = New System.Windows.Forms.Label
        Me.grbTarde = New System.Windows.Forms.GroupBox
        Me.nudIntervaloT = New System.Windows.Forms.NumericUpDown
        Me.lblIntervaloT = New System.Windows.Forms.Label
        Me.dtpHoraFinT = New System.Windows.Forms.DateTimePicker
        Me.lblHFinT = New System.Windows.Forms.Label
        Me.lblHIniT = New System.Windows.Forms.Label
        Me.dtpHoraIniT = New System.Windows.Forms.DateTimePicker
        Me.cmdGuardar = New System.Windows.Forms.Button
        Me.cmdCerrar = New System.Windows.Forms.Button
        Me.grbTarifa = New System.Windows.Forms.GroupBox
        Me.nudPrecio = New System.Windows.Forms.NumericUpDown
        Me.lblPrecio = New System.Windows.Forms.Label
        Me.lblEuros = New System.Windows.Forms.Label
        Me.chkTarde = New System.Windows.Forms.CheckBox
        Me.grbVigencia.SuspendLayout()
        Me.grbHorario.SuspendLayout()
        Me.grbMañana.SuspendLayout()
        CType(Me.nudIntervaloM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbTarde.SuspendLayout()
        CType(Me.nudIntervaloT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbTarifa.SuspendLayout()
        CType(Me.nudPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grbVigencia
        '
        Me.grbVigencia.Controls.Add(Me.lblVFInicio)
        Me.grbVigencia.Controls.Add(Me.dtpVFInicio)
        Me.grbVigencia.Controls.Add(Me.lblVFFin)
        Me.grbVigencia.Controls.Add(Me.dtpVFFin)
        Me.grbVigencia.Location = New System.Drawing.Point(16, 8)
        Me.grbVigencia.Name = "grbVigencia"
        Me.grbVigencia.Size = New System.Drawing.Size(272, 88)
        Me.grbVigencia.TabIndex = 0
        Me.grbVigencia.TabStop = False
        Me.grbVigencia.Text = " Vigencia "
        '
        'lblVFInicio
        '
        Me.lblVFInicio.Location = New System.Drawing.Point(24, 24)
        Me.lblVFInicio.Name = "lblVFInicio"
        Me.lblVFInicio.Size = New System.Drawing.Size(104, 16)
        Me.lblVFInicio.TabIndex = 1
        Me.lblVFInicio.Text = "Fecha Inicio"
        Me.lblVFInicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpVFInicio
        '
        Me.dtpVFInicio.CustomFormat = "dd/MM/yyyy"
        Me.dtpVFInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpVFInicio.Location = New System.Drawing.Point(16, 48)
        Me.dtpVFInicio.Name = "dtpVFInicio"
        Me.dtpVFInicio.Size = New System.Drawing.Size(112, 21)
        Me.dtpVFInicio.TabIndex = 0
        '
        'lblVFFin
        '
        Me.lblVFFin.Location = New System.Drawing.Point(152, 24)
        Me.lblVFFin.Name = "lblVFFin"
        Me.lblVFFin.Size = New System.Drawing.Size(104, 16)
        Me.lblVFFin.TabIndex = 1
        Me.lblVFFin.Text = "Fecha Fin"
        Me.lblVFFin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpVFFin
        '
        Me.dtpVFFin.CustomFormat = "dd/MM/yyyy"
        Me.dtpVFFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpVFFin.Location = New System.Drawing.Point(144, 48)
        Me.dtpVFFin.Name = "dtpVFFin"
        Me.dtpVFFin.ShowCheckBox = True
        Me.dtpVFFin.Size = New System.Drawing.Size(112, 21)
        Me.dtpVFFin.TabIndex = 0
        '
        'grbHorario
        '
        Me.grbHorario.Controls.Add(Me.chkTarde)
        Me.grbHorario.Controls.Add(Me.chkManana)
        Me.grbHorario.Controls.Add(Me.grbMañana)
        Me.grbHorario.Controls.Add(Me.grbTarde)
        Me.grbHorario.Location = New System.Drawing.Point(16, 112)
        Me.grbHorario.Name = "grbHorario"
        Me.grbHorario.Size = New System.Drawing.Size(272, 274)
        Me.grbHorario.TabIndex = 1
        Me.grbHorario.TabStop = False
        Me.grbHorario.Text = " Horario "
        '
        'chkManana
        '
        Me.chkManana.Location = New System.Drawing.Point(32, 24)
        Me.chkManana.Name = "chkManana"
        Me.chkManana.Size = New System.Drawing.Size(72, 16)
        Me.chkManana.TabIndex = 0
        Me.chkManana.Text = "Mañana"
        '
        'grbMañana
        '
        Me.grbMañana.Controls.Add(Me.nudIntervaloM)
        Me.grbMañana.Controls.Add(Me.lblIntervaloM)
        Me.grbMañana.Controls.Add(Me.dtpHInicioM)
        Me.grbMañana.Controls.Add(Me.dtpHFinM)
        Me.grbMañana.Controls.Add(Me.lblHIniM)
        Me.grbMañana.Controls.Add(Me.lblHFinM)
        Me.grbMañana.Location = New System.Drawing.Point(16, 24)
        Me.grbMañana.Name = "grbMañana"
        Me.grbMañana.Size = New System.Drawing.Size(240, 112)
        Me.grbMañana.TabIndex = 6
        Me.grbMañana.TabStop = False
        '
        'nudIntervaloM
        '
        Me.nudIntervaloM.Location = New System.Drawing.Point(152, 81)
        Me.nudIntervaloM.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.nudIntervaloM.Name = "nudIntervaloM"
        Me.nudIntervaloM.Size = New System.Drawing.Size(72, 21)
        Me.nudIntervaloM.TabIndex = 10
        '
        'lblIntervaloM
        '
        Me.lblIntervaloM.AutoSize = True
        Me.lblIntervaloM.Location = New System.Drawing.Point(47, 84)
        Me.lblIntervaloM.Name = "lblIntervaloM"
        Me.lblIntervaloM.Size = New System.Drawing.Size(99, 13)
        Me.lblIntervaloM.TabIndex = 11
        Me.lblIntervaloM.Text = "Intervalo (min):"
        Me.lblIntervaloM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpHInicioM
        '
        Me.dtpHInicioM.CustomFormat = "HH:mm"
        Me.dtpHInicioM.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHInicioM.Location = New System.Drawing.Point(16, 48)
        Me.dtpHInicioM.Name = "dtpHInicioM"
        Me.dtpHInicioM.ShowUpDown = True
        Me.dtpHInicioM.Size = New System.Drawing.Size(72, 21)
        Me.dtpHInicioM.TabIndex = 0
        '
        'dtpHFinM
        '
        Me.dtpHFinM.CustomFormat = "HH:mm"
        Me.dtpHFinM.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHFinM.Location = New System.Drawing.Point(152, 48)
        Me.dtpHFinM.Name = "dtpHFinM"
        Me.dtpHFinM.ShowUpDown = True
        Me.dtpHFinM.Size = New System.Drawing.Size(72, 21)
        Me.dtpHFinM.TabIndex = 1
        '
        'lblHIniM
        '
        Me.lblHIniM.Location = New System.Drawing.Point(16, 24)
        Me.lblHIniM.Name = "lblHIniM"
        Me.lblHIniM.Size = New System.Drawing.Size(72, 16)
        Me.lblHIniM.TabIndex = 9
        Me.lblHIniM.Text = "Hora Inicio"
        Me.lblHIniM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHFinM
        '
        Me.lblHFinM.Location = New System.Drawing.Point(152, 24)
        Me.lblHFinM.Name = "lblHFinM"
        Me.lblHFinM.Size = New System.Drawing.Size(72, 16)
        Me.lblHFinM.TabIndex = 8
        Me.lblHFinM.Text = "Hora Fin"
        Me.lblHFinM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grbTarde
        '
        Me.grbTarde.Controls.Add(Me.nudIntervaloT)
        Me.grbTarde.Controls.Add(Me.lblIntervaloT)
        Me.grbTarde.Controls.Add(Me.dtpHoraFinT)
        Me.grbTarde.Controls.Add(Me.lblHFinT)
        Me.grbTarde.Controls.Add(Me.lblHIniT)
        Me.grbTarde.Controls.Add(Me.dtpHoraIniT)
        Me.grbTarde.Location = New System.Drawing.Point(16, 142)
        Me.grbTarde.Name = "grbTarde"
        Me.grbTarde.Size = New System.Drawing.Size(240, 115)
        Me.grbTarde.TabIndex = 7
        Me.grbTarde.TabStop = False
        '
        'nudIntervaloT
        '
        Me.nudIntervaloT.Location = New System.Drawing.Point(152, 83)
        Me.nudIntervaloT.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.nudIntervaloT.Name = "nudIntervaloT"
        Me.nudIntervaloT.Size = New System.Drawing.Size(72, 21)
        Me.nudIntervaloT.TabIndex = 12
        '
        'lblIntervaloT
        '
        Me.lblIntervaloT.AutoSize = True
        Me.lblIntervaloT.Location = New System.Drawing.Point(47, 86)
        Me.lblIntervaloT.Name = "lblIntervaloT"
        Me.lblIntervaloT.Size = New System.Drawing.Size(99, 13)
        Me.lblIntervaloT.TabIndex = 13
        Me.lblIntervaloT.Text = "Intervalo (min):"
        Me.lblIntervaloT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpHoraFinT
        '
        Me.dtpHoraFinT.CustomFormat = "HH:mm"
        Me.dtpHoraFinT.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHoraFinT.Location = New System.Drawing.Point(152, 48)
        Me.dtpHoraFinT.Name = "dtpHoraFinT"
        Me.dtpHoraFinT.ShowUpDown = True
        Me.dtpHoraFinT.Size = New System.Drawing.Size(72, 21)
        Me.dtpHoraFinT.TabIndex = 1
        '
        'lblHFinT
        '
        Me.lblHFinT.Location = New System.Drawing.Point(152, 24)
        Me.lblHFinT.Name = "lblHFinT"
        Me.lblHFinT.Size = New System.Drawing.Size(72, 16)
        Me.lblHFinT.TabIndex = 8
        Me.lblHFinT.Text = "Hora Fin"
        Me.lblHFinT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHIniT
        '
        Me.lblHIniT.Location = New System.Drawing.Point(16, 24)
        Me.lblHIniT.Name = "lblHIniT"
        Me.lblHIniT.Size = New System.Drawing.Size(72, 16)
        Me.lblHIniT.TabIndex = 9
        Me.lblHIniT.Text = "Hora Inicio"
        Me.lblHIniT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpHoraIniT
        '
        Me.dtpHoraIniT.CustomFormat = "HH:mm"
        Me.dtpHoraIniT.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHoraIniT.Location = New System.Drawing.Point(16, 48)
        Me.dtpHoraIniT.Name = "dtpHoraIniT"
        Me.dtpHoraIniT.ShowUpDown = True
        Me.dtpHoraIniT.Size = New System.Drawing.Size(72, 21)
        Me.dtpHoraIniT.TabIndex = 0
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Location = New System.Drawing.Point(128, 396)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(72, 24)
        Me.cmdGuardar.TabIndex = 3
        Me.cmdGuardar.Text = "Guardar"
        '
        'cmdCerrar
        '
        Me.cmdCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCerrar.Location = New System.Drawing.Point(216, 396)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(72, 24)
        Me.cmdCerrar.TabIndex = 4
        Me.cmdCerrar.Text = "Cerrar"
        '
        'grbTarifa
        '
        Me.grbTarifa.Controls.Add(Me.nudPrecio)
        Me.grbTarifa.Controls.Add(Me.lblPrecio)
        Me.grbTarifa.Controls.Add(Me.lblEuros)
        Me.grbTarifa.Location = New System.Drawing.Point(16, 112)
        Me.grbTarifa.Name = "grbTarifa"
        Me.grbTarifa.Size = New System.Drawing.Size(272, 56)
        Me.grbTarifa.TabIndex = 2
        Me.grbTarifa.TabStop = False
        Me.grbTarifa.Text = " Tarifa "
        '
        'nudPrecio
        '
        Me.nudPrecio.DecimalPlaces = 2
        Me.nudPrecio.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nudPrecio.Location = New System.Drawing.Point(144, 24)
        Me.nudPrecio.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.nudPrecio.Name = "nudPrecio"
        Me.nudPrecio.ReadOnly = True
        Me.nudPrecio.Size = New System.Drawing.Size(72, 21)
        Me.nudPrecio.TabIndex = 0
        Me.nudPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudPrecio.ThousandsSeparator = True
        '
        'lblPrecio
        '
        Me.lblPrecio.Location = New System.Drawing.Point(8, 24)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(112, 16)
        Me.lblPrecio.TabIndex = 5
        Me.lblPrecio.Text = "Precio por sesión:"
        Me.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEuros
        '
        Me.lblEuros.Location = New System.Drawing.Point(224, 24)
        Me.lblEuros.Name = "lblEuros"
        Me.lblEuros.Size = New System.Drawing.Size(40, 16)
        Me.lblEuros.TabIndex = 5
        Me.lblEuros.Text = "euros"
        Me.lblEuros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkTarde
        '
        Me.chkTarde.Location = New System.Drawing.Point(32, 141)
        Me.chkTarde.Name = "chkTarde"
        Me.chkTarde.Size = New System.Drawing.Size(64, 16)
        Me.chkTarde.TabIndex = 8
        Me.chkTarde.Text = "Tarde"
        '
        'frmConfiguracionDetalle
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.cmdCerrar
        Me.ClientSize = New System.Drawing.Size(298, 430)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdGuardar)
        Me.Controls.Add(Me.grbVigencia)
        Me.Controls.Add(Me.cmdCerrar)
        Me.Controls.Add(Me.grbHorario)
        Me.Controls.Add(Me.grbTarifa)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmConfiguracionDetalle"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuración jornada laboral"
        Me.grbVigencia.ResumeLayout(False)
        Me.grbHorario.ResumeLayout(False)
        Me.grbMañana.ResumeLayout(False)
        Me.grbMañana.PerformLayout()
        CType(Me.nudIntervaloM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbTarde.ResumeLayout(False)
        Me.grbTarde.PerformLayout()
        CType(Me.nudIntervaloT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbTarifa.ResumeLayout(False)
        CType(Me.nudPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Const cteModulo As String = "Configuración"

    Friend TipoConfiguracion As eTiposConfiguracion
    Friend TipoMantenimiento As eTiposMantenimiento

    Private iIDFisio As Integer
    Friend Property IDFisio() As Integer
        Get
            Return iIDFisio
        End Get
        Set(ByVal value As Integer)
            iIDFisio = value
        End Set
    End Property

    Private iIDJornada As Integer
    Friend Property IDJornada() As Integer
        Get
            Return iIDJornada
        End Get
        Set(ByVal value As Integer)
            iIDJornada = value
        End Set
    End Property

    Private iIDTarifa As Integer
    Friend Property IDTarifa() As Integer
        Get
            Return iIDTarifa
        End Get
        Set(ByVal value As Integer)
            iIDTarifa = value
        End Set
    End Property

    'Friend IDJornada As Integer
    'Friend IDTarifa As Integer


#Region " COMUN "

#Region " CONTROLES "

    Private Sub CargarFormulario(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Select Case Me.TipoConfiguracion
            Case eTiposConfiguracion.Jornada
                mConfigurarFormularioJornadas()

            Case eTiposConfiguracion.Tarifa
                mConfigurarFormularioTarifas()
        End Select

    End Sub


    Private Sub CambioFecha(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpVFInicio.ValueChanged, dtpVFFin.ValueChanged
        mOKGuardar()
    End Sub

    Private Sub GuardarConfiguracion(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click

        Dim bOK As Boolean

        If Me.TipoConfiguracion = eTiposConfiguracion.Jornada Then
            bOK = mbGuardarJornada()
        ElseIf Me.TipoConfiguracion = eTiposConfiguracion.Tarifa Then
            bOK = mbGuardarTarifa()
        End If

        If bOK Then
            With Me
                .DialogResult = Windows.Forms.DialogResult.OK
                .Dispose()
            End With
        End If

    End Sub

    Private Sub Cerrar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click
        With Me
            .DialogResult = Windows.Forms.DialogResult.Cancel
            .Dispose()
        End With
    End Sub

#End Region

#Region " FUNCIONES "

    Private Sub mOKGuardar()

        Dim bOK As Boolean = True

        If dtpVFFin.Checked Then
            bOK = (dtpVFInicio.Value <= dtpVFFin.Value)
        End If

        If bOK And Me.TipoConfiguracion = eTiposConfiguracion.Jornada Then
            bOK = (chkManana.CheckState = CheckState.Checked) Or (chkTarde.CheckState = CheckState.Checked)

            If bOK And chkManana.CheckState = CheckState.Checked Then
                bOK = (dtpHInicioM.Value < dtpHFinM.Value)
            End If

            If bOK And chkTarde.CheckState = CheckState.Checked Then
                bOK = (dtpHoraIniT.Value < dtpHoraFinT.Value)
            End If

            If bOK Then
                bOK = (nudIntervaloM.Value > 0)
            End If
        End If

        If bOK And Me.TipoConfiguracion = eTiposConfiguracion.Tarifa Then
            bOK = (nudPrecio.Value > 0)
        End If

        cmdGuardar.Enabled = bOK

    End Sub

#End Region

#End Region


#Region " JORNADAS LABORALES "

#Region " CONTROLES "

    Private Sub CambioHoraMañana(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpHInicioM.ValueChanged, dtpHFinM.ValueChanged
        mOKGuardar()
    End Sub

    Private Sub CambioHoraTarde(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpHoraIniT.ValueChanged, dtpHoraFinT.ValueChanged
        mOKGuardar()
    End Sub

    Private Sub CambioIntervalo(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudIntervaloM.ValueChanged, nudIntervaloT.ValueChanged
        mOKGuardar()
    End Sub

#End Region

#Region " FUNCIONES "

    Private Sub mConfigurarFormularioJornadas()

        grbTarifa.Visible = False

        Select Case Me.TipoMantenimiento
            Case eTiposMantenimiento.Alta
                With dtpVFInicio
                    .Value = DateTime.Today
                    '.Checked = False
                End With

                With dtpVFFin
                    .Value = DateTime.Today
                    .Checked = False
                End With

                With DateTime.Today
                    dtpHInicioM.Value = New DateTime(.Year, .Month, .Day, 9, 0, 0)
                    dtpHFinM.Value = New DateTime(.Year, .Month, .Day, 14, 0, 0)
                    dtpHoraIniT.Value = New DateTime(.Year, .Month, .Day, 16, 0, 0)
                    dtpHoraFinT.Value = New DateTime(.Year, .Month, .Day, 20, 0, 0)
                End With

                grbMañana.Enabled = False
                grbTarde.Enabled = False

            Case eTiposMantenimiento.Modificacion
                mLLenarJornada()

        End Select

    End Sub

    Private Sub mLLenarJornada()

        Dim objBDatos As New AccesoBD_MySQL()
        Dim dtJornada As DataTable = New DataTable("Jornada")
        Dim iNumJornadas As Integer = 0
        Dim bOK As Boolean

        Try
            With objBDatos
                bOK = .AbrirConexion()

                If bOK Then
                    Dim arrParametros(0) As MySqlParameter

                    arrParametros(0) = New MySqlParameter()
                    With arrParametros(0)
                        .ParameterName = "iIDJornada"
                        .MySqlDbType = MySqlDbType.Int32
                        .Size = 4
                        .Value = Me.IDJornada
                        .Direction = ParameterDirection.Input
                    End With

                    bOK = .EjecutarSP("spJornadas_LLenar", arrParametros, dtJornada, iNumJornadas)

                    If bOK And iNumJornadas = 1 Then
                        Dim drJornada As DataRow = dtJornada.Rows(0)

                        dtpVFInicio.Value = DateTime.Parse(drJornada("JOR_Fecha").ToString)
                        dtpVFFin.Checked = False

                        'If IsDBNull(drJornada("JOR_VigenciaFin")) Then
                        '    dtpVFFin.Checked = False
                        'Else
                        '    dtpVFFin.Value = DateTime.Parse(drJornada("JOR_VigenciaFin").ToString)
                        'End If

                        If Not IsDBNull(drJornada("JOR_HoraIniM")) Or Not IsDBNull(drJornada("JOR_HoraFinM")) Then
                            dtpHInicioM.Value = DateTime.Parse(drJornada("JOR_HoraIniM").ToString)
                            dtpHFinM.Value = DateTime.Parse(drJornada("JOR_HoraFinM").ToString)
                            nudIntervaloM.Value = Convert.ToInt32(drJornada("JOR_IntervaloM"))
                            chkManana.CheckState = CheckState.Checked
                            grbMañana.Enabled = True
                        Else
                            chkManana.CheckState = CheckState.Unchecked
                            grbMañana.Enabled = False
                        End If

                        If Not IsDBNull(drJornada("JOR_HoraIniT")) Or Not IsDBNull(drJornada("JOR_HoraFinT")) Then
                            dtpHoraIniT.Value = DateTime.Parse(drJornada("JOR_HoraIniT").ToString)
                            dtpHoraFinT.Value = DateTime.Parse(drJornada("JOR_HoraFinT").ToString)
                            nudIntervaloT.Value = Convert.ToInt32(drJornada("JOR_IntervaloT"))
                            chkTarde.CheckState = CheckState.Checked
                            grbTarde.Enabled = True
                        Else
                            chkTarde.CheckState = CheckState.Unchecked
                            grbTarde.Enabled = False
                        End If

                    End If

                    bOK = .CerrarConexion
                End If
            End With

        Catch exError As Exception
            Dim sOrigen As String = cteModulo & " Jornada"

            GestionarErrores(exError.Message, sOrigen, MessageBoxIcon.Error, EventLogEntryType.Error)

        Finally
            ' Descargar objetos
            dtJornada.Dispose()
            objBDatos.Dispose()

        End Try

    End Sub

    Private Function mbGuardarJornada() As Boolean

        Dim objBDatos As New AccesoBD_MySQL()
        Dim iNumFilas As Integer = 0
        Dim bOK As Boolean

        Try
            With objBDatos
                bOK = .AbrirConexion

                If bOK Then
                    bOK = .IniciarTransaccion

                    If bOK Then
                        Dim arrParametros(7) As MySqlParameter
                        Dim fFechaAux As DateTime = dtpVFInicio.Value
                        Dim fFechaFin As DateTime

                        'ReDim arrParametros(6)

                        If dtpVFFin.Checked Then
                            fFechaFin = dtpVFFin.Value
                        Else
                            fFechaFin = fFechaAux
                        End If

                        Do Until fFechaAux > fFechaFin
                            arrParametros(0) = New MySqlParameter()
                            With arrParametros(0)
                                .ParameterName = "fDia"
                                .MySqlDbType = MySqlDbType.Date
                                .Size = 8
                                .Value = fFechaAux
                                .Direction = ParameterDirection.Input
                            End With

                            arrParametros(1) = New MySqlParameter()
                            With arrParametros(1)
                                .ParameterName = "sHoraIniM"
                                .MySqlDbType = MySqlDbType.VarChar
                                .Size = 5
                                If chkManana.CheckState = CheckState.Checked Then
                                    .Value = dtpHInicioM.Value.ToString("HH:mm")
                                Else
                                    .Value = DBNull.Value
                                End If
                                .Direction = ParameterDirection.Input
                            End With

                            arrParametros(2) = New MySqlParameter()
                            With arrParametros(2)
                                .ParameterName = "sHoraFinM"
                                .MySqlDbType = MySqlDbType.VarChar
                                .Size = 5
                                If chkManana.CheckState = CheckState.Checked Then
                                    .Value = dtpHFinM.Value.ToString("HH:mm")
                                Else
                                    .Value = DBNull.Value
                                End If
                                .Direction = ParameterDirection.Input
                            End With

                            arrParametros(3) = New MySqlParameter()
                            With arrParametros(3)
                                .ParameterName = "sHoraIniT"
                                .MySqlDbType = MySqlDbType.VarChar
                                .Size = 5
                                If chkTarde.CheckState = CheckState.Checked Then
                                    .Value = dtpHoraIniT.Value.ToString("HH:mm")
                                Else
                                    .Value = DBNull.Value
                                End If
                                .Direction = ParameterDirection.Input
                            End With

                            arrParametros(4) = New MySqlParameter()
                            With arrParametros(4)
                                .ParameterName = "sHoraFinT"
                                .MySqlDbType = MySqlDbType.VarChar
                                .Size = 5
                                If chkTarde.CheckState = CheckState.Checked Then
                                    .Value = dtpHoraFinT.Value.ToString("HH:mm")
                                Else
                                    .Value = DBNull.Value
                                End If
                                .Direction = ParameterDirection.Input
                            End With

                            arrParametros(5) = New MySqlParameter()
                            With arrParametros(5)
                                .ParameterName = "iIntervaloM"
                                .MySqlDbType = MySqlDbType.Byte
                                .Size = 3
                                .Value = nudIntervaloM.Value
                                .Direction = ParameterDirection.Input
                            End With

                            arrParametros(6) = New MySqlParameter()
                            With arrParametros(6)
                                .ParameterName = "iIntervaloT"
                                .MySqlDbType = MySqlDbType.Byte
                                .Size = 3
                                .Value = nudIntervaloT.Value
                                .Direction = ParameterDirection.Input
                            End With

                            arrParametros(7) = New MySqlParameter()
                            With arrParametros(7)
                                .ParameterName = "iIDJornada"
                                .MySqlDbType = MySqlDbType.Int32
                                .Size = 10
                                If Me.IDJornada = 0 Then
                                    .Value = DBNull.Value
                                Else
                                    .Value = Me.IDJornada
                                End If
                                .Direction = ParameterDirection.Input
                            End With

                            'arrParametros(8) = New MySqlParameter()
                            'With arrParametros(8)
                            '    .ParameterName = "iIDFisio"
                            '    .MySqlDbType = MySqlDbType.Int32
                            '    .Size = 10
                            '    .Value = Me.IDFisio
                            '    .Direction = ParameterDirection.Input
                            'End With

                            bOK = .EjecutarSP("spJornadas_Guardar", arrParametros, iNumFilas)

                            '' Dependiendo del tipo de mantenimiento, INSERT o UPDATE
                            'Select Case Me.TipoMantenimiento
                            '    Case eTiposMantenimiento.Alta
                            '        bOK = .EjecutarSP("spJornadas_Anadir", arrParametros, iNumFilas)

                            '    Case eTiposMantenimiento.Modificacion
                            '        ReDim Preserve arrParametros(6)

                            '        arrParametros(6) = New MySqlParameter()
                            '        With arrParametros(6)
                            '            .ParameterName = "iIDJornada"
                            '            .MySqlDbType = MySqlDbType.Int32
                            '            .Size = 10
                            '            .Value = Me.IDJornada
                            '            .Direction = ParameterDirection.Input
                            '        End With

                            '        bOK = .EjecutarSP("spJornadas_Modificar", arrParametros, iNumFilas)
                            'End Select

                            If Not bOK Then Exit Do

                            fFechaAux = fFechaAux.AddDays(1)
                        Loop


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
            Dim sOrigen As String = cteModulo & " Jornada"

            GestionarErrores(exError.Message, sOrigen, MessageBoxIcon.Error, EventLogEntryType.Error)

            bOK = False

        Finally
            'Descargar objetos
            objBDatos.Dispose()

        End Try

        Return bOK

    End Function

#End Region

#End Region


#Region " TARIFAS "

#Region " CONTROLES "

    Private Sub CambioPrecio(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudPrecio.ValueChanged
        mOKGuardar()
    End Sub

#End Region

#Region " FUNCIONES "

    Private Sub mConfigurarFormularioTarifas()

        grbHorario.Visible = False

        Dim iSep As Integer
        Dim iSituacion As Integer

        iSep = cmdGuardar.Top - (grbHorario.Top + grbHorario.Height)
        iSituacion = grbTarifa.Top + grbTarifa.Height + iSep

        cmdGuardar.Top = iSituacion
        cmdCerrar.Top = iSituacion

        Me.Height = iSituacion + (2 * cmdGuardar.Height) + iSep

        Select Case Me.TipoMantenimiento
            Case eTiposMantenimiento.Alta
                With dtpVFInicio
                    .Value = DateTime.Today
                    .Checked = False
                End With

                With dtpVFFin
                    .Value = DateTime.Today
                    .Checked = False
                End With

            Case eTiposMantenimiento.Modificacion
                mLLenarTarifa()

        End Select

    End Sub

    Private Sub mLLenarTarifa()

        Dim objBDatos As New AccesoBD_MySQL()
        Dim dtTarifa As DataTable = New DataTable("Tarifa")
        Dim iNumTarifas As Integer = 0
        Dim bOK As Boolean

        Try
            With objBDatos
                bOK = .AbrirConexion()

                If bOK Then
                    Dim arrParametros(0) As MySqlParameter

                    arrParametros(0) = New MySqlParameter()
                    With arrParametros(0)
                        .ParameterName = "iIDTarifa"
                        .MySqlDbType = MySqlDbType.Int32
                        .Size = 4
                        .Value = Me.IDTarifa
                        .Direction = ParameterDirection.Input
                    End With

                    bOK = .EjecutarSP("spTarifas_LLenar", arrParametros, dtTarifa, iNumTarifas)

                    If bOK And iNumTarifas = 1 Then
                        Dim drJornada As DataRow = dtTarifa.Rows(0)

                        dtpVFInicio.Value = DateTime.Parse(drJornada("TAR_VigenciaIni").ToString)

                        If IsDBNull(drJornada("TAR_VigenciaFin")) Then
                            dtpVFFin.Value = dtpVFInicio.Value
                            dtpVFFin.Checked = False
                        Else
                            dtpVFFin.Value = DateTime.Parse(drJornada("TAR_VigenciaFin").ToString)
                        End If

                        nudPrecio.Value = Convert.ToDecimal(drJornada("TAR_Precio"))
                    End If

                    bOK = .CerrarConexion
                End If
            End With

        Catch exError As Exception
            Dim sOrigen As String = cteModulo & " Tarifa"

            GestionarErrores(exError.Message, sOrigen, MessageBoxIcon.Error, EventLogEntryType.Error)

        Finally
            ' Descargar objetos
            dtTarifa.Dispose()
            objBDatos.Dispose()

        End Try

    End Sub

    Private Function mbGuardarTarifa() As Boolean

        Dim objBDatos As New AccesoBD_MySQL()
        Dim iNumFilas As Integer = 0
        Dim bOK As Boolean

        Try
            With objBDatos
                bOK = .AbrirConexion

                If bOK Then
                    bOK = .IniciarTransaccion

                    If bOK Then
                        Dim arrParametros() As MySqlParameter

                        ReDim arrParametros(2)

                        arrParametros(0) = New MySqlParameter()
                        With arrParametros(0)
                            .ParameterName = "fVigenciaIni"
                            .MySqlDbType = MySqlDbType.Date
                            .Size = 8
                            .Value = dtpVFInicio.Value
                            .Direction = ParameterDirection.Input
                        End With

                        arrParametros(1) = New MySqlParameter()
                        With arrParametros(1)
                            .ParameterName = "fVigenciaFin"
                            .MySqlDbType = MySqlDbType.Date
                            .Size = 8
                            If dtpVFFin.Checked Then
                                .Value = dtpVFFin.Value
                            Else
                                .Value = DBNull.Value
                            End If
                            .Direction = ParameterDirection.Input
                        End With

                        arrParametros(2) = New MySqlParameter()
                        With arrParametros(2)
                            .ParameterName = "dPrecio"
                            .MySqlDbType = MySqlDbType.Decimal
                            .Size = 9
                            .Precision = 5
                            .Scale = 2
                            .Value = nudPrecio.Value
                            .Direction = ParameterDirection.Input
                        End With


                        Select Case Me.TipoMantenimiento
                            Case eTiposMantenimiento.Alta
                                bOK = .EjecutarSP("spTarifas_Anadir", arrParametros, iNumFilas)

                            Case eTiposMantenimiento.Modificacion
                                ReDim Preserve arrParametros(3)

                                arrParametros(3) = New MySqlParameter()
                                With arrParametros(3)
                                    .ParameterName = "iIDTarifa"
                                    .MySqlDbType = MySqlDbType.Int32
                                    .Size = 4
                                    .Value = Me.IDTarifa
                                    .Direction = ParameterDirection.Input
                                End With

                                bOK = .EjecutarSP("spTarifas_Modificar", arrParametros, iNumFilas)
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
            Dim sOrigen As String = cteModulo & " Tarifa"

            GestionarErrores(exError.Message, sOrigen, MessageBoxIcon.Error, EventLogEntryType.Error)

            bOK = False

        Finally
            'Descargar objetos
            objBDatos.Dispose()

        End Try

        Return bOK

    End Function

#End Region

#End Region


    Private Sub chkManana_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkManana.CheckStateChanged
        grbMañana.Enabled = (chkManana.CheckState = CheckState.Checked)
        mOKGuardar()
    End Sub

    Private Sub chkTarde_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTarde.CheckedChanged
        grbTarde.Enabled = (chkTarde.CheckState = CheckState.Checked)
        mOKGuardar()
    End Sub




End Class
