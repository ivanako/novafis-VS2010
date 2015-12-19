Option Strict Off
Option Explicit On 

Public Class frmPacientesDetalle

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
    Friend WithEvents panBotones As System.Windows.Forms.Panel
    Friend WithEvents panDetalles As System.Windows.Forms.Panel
    Friend WithEvents tabDetalles As System.Windows.Forms.TabControl
    Friend WithEvents cmdCerrar As System.Windows.Forms.Button
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblApellido1 As System.Windows.Forms.Label
    Friend WithEvents txtApellido1 As System.Windows.Forms.TextBox
    Friend WithEvents lblApellido2 As System.Windows.Forms.Label
    Friend WithEvents txtApellido2 As System.Windows.Forms.TextBox
    Friend WithEvents cmdGuardar As System.Windows.Forms.Button
    Friend WithEvents lblIdentificacion As System.Windows.Forms.Label
    Friend WithEvents lblIdClaro As System.Windows.Forms.Label
    Friend WithEvents lblFRegistro As System.Windows.Forms.Label
    Friend WithEvents dtpFRegistro As System.Windows.Forms.DateTimePicker
    Friend WithEvents grbSexo As System.Windows.Forms.GroupBox
    Friend WithEvents rdbHombre As System.Windows.Forms.RadioButton
    Friend WithEvents rdbMujer As System.Windows.Forms.RadioButton
    Friend WithEvents dtpFNacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFNacimiento As System.Windows.Forms.Label
    Friend WithEvents lblNMatricula As System.Windows.Forms.Label
    Friend WithEvents tipPacientesDetalles As System.Windows.Forms.ToolTip
    Friend WithEvents tbpDireccion As System.Windows.Forms.TabPage
    Friend WithEvents txtIdentificacion As System.Windows.Forms.TextBox
    Friend WithEvents lblConocer As System.Windows.Forms.Label
    Friend WithEvents txtConocer As System.Windows.Forms.TextBox
    Friend WithEvents txtVia As System.Windows.Forms.TextBox
    Friend WithEvents lblVia As System.Windows.Forms.Label
    Friend WithEvents lblBloque As System.Windows.Forms.Label
    Friend WithEvents txtBloque As System.Windows.Forms.TextBox
    Friend WithEvents txtPiso As System.Windows.Forms.TextBox
    Friend WithEvents lblPiso As System.Windows.Forms.Label
    Friend WithEvents txtEscalera As System.Windows.Forms.TextBox
    Friend WithEvents lblEscalera As System.Windows.Forms.Label
    Friend WithEvents txtPuerta As System.Windows.Forms.TextBox
    Friend WithEvents lblPuerta As System.Windows.Forms.Label
    Friend WithEvents txtCPostal As System.Windows.Forms.TextBox
    Friend WithEvents lblCPostal As System.Windows.Forms.Label
    Friend WithEvents txtCiudad As System.Windows.Forms.TextBox
    Friend WithEvents lblCiudad As System.Windows.Forms.Label
    Friend WithEvents lblProvincia As System.Windows.Forms.Label
    Friend WithEvents cboProvincias As System.Windows.Forms.ComboBox
    Friend WithEvents lblTelefono1 As System.Windows.Forms.Label
    Friend WithEvents txtTelefono1 As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono2 As System.Windows.Forms.TextBox
    Friend WithEvents lblTelefono2 As System.Windows.Forms.Label
    Friend WithEvents lblTelefono3 As System.Windows.Forms.Label
    Friend WithEvents txtTelefono3 As System.Windows.Forms.TextBox
    Friend WithEvents txtEMail As System.Windows.Forms.TextBox
    Friend WithEvents lblEMail As System.Windows.Forms.Label
    Friend WithEvents lblWeb As System.Windows.Forms.Label
    Friend WithEvents txtWeb As System.Windows.Forms.TextBox
    Friend WithEvents lblNumMatricula As System.Windows.Forms.Label
    Friend WithEvents lblNumero As System.Windows.Forms.Label
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents tbpTratamiento As System.Windows.Forms.TabPage
    Friend WithEvents dtgTratamiento As ScrolledDataGrid
    Friend WithEvents cmdModificarTrat As System.Windows.Forms.Button
    Friend WithEvents cmdNuevoTrat As System.Windows.Forms.Button
    Friend WithEvents tbpDPersonales As System.Windows.Forms.TabPage
    Friend WithEvents tbpAnulaciones As System.Windows.Forms.TabPage
    Friend WithEvents dtgAnulaciones As System.Windows.Forms.DataGrid
    Friend WithEvents cmdModificarAnul As System.Windows.Forms.Button
    Friend WithEvents cmdNuevaAnul As System.Windows.Forms.Button
    Friend WithEvents dtgObservaciones As System.Windows.Forms.DataGrid
    Friend WithEvents cmdNuevaObservacion As System.Windows.Forms.Button
    Friend WithEvents tbpObservaciones As System.Windows.Forms.TabPage
    Friend WithEvents cmdModificarObservacion As System.Windows.Forms.Button
    Friend WithEvents cmdEliminarObservacion As System.Windows.Forms.Button
    Friend WithEvents cboFisiosReferencia As System.Windows.Forms.ComboBox
    Friend WithEvents lblFisio As System.Windows.Forms.Label
    Friend WithEvents cboFuentes As System.Windows.Forms.ComboBox
    Friend WithEvents lblFuente As System.Windows.Forms.Label
    Friend WithEvents cmdEliminarTrat As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.panBotones = New System.Windows.Forms.Panel
        Me.cboFisiosReferencia = New System.Windows.Forms.ComboBox
        Me.lblFisio = New System.Windows.Forms.Label
        Me.cmdCerrar = New System.Windows.Forms.Button
        Me.cmdGuardar = New System.Windows.Forms.Button
        Me.panDetalles = New System.Windows.Forms.Panel
        Me.tabDetalles = New System.Windows.Forms.TabControl
        Me.tbpDPersonales = New System.Windows.Forms.TabPage
        Me.cboFuentes = New System.Windows.Forms.ComboBox
        Me.lblFuente = New System.Windows.Forms.Label
        Me.grbSexo = New System.Windows.Forms.GroupBox
        Me.rdbHombre = New System.Windows.Forms.RadioButton
        Me.rdbMujer = New System.Windows.Forms.RadioButton
        Me.dtpFRegistro = New System.Windows.Forms.DateTimePicker
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.lblNombre = New System.Windows.Forms.Label
        Me.lblApellido1 = New System.Windows.Forms.Label
        Me.txtApellido1 = New System.Windows.Forms.TextBox
        Me.lblApellido2 = New System.Windows.Forms.Label
        Me.txtApellido2 = New System.Windows.Forms.TextBox
        Me.lblIdentificacion = New System.Windows.Forms.Label
        Me.txtIdentificacion = New System.Windows.Forms.TextBox
        Me.lblIdClaro = New System.Windows.Forms.Label
        Me.lblFRegistro = New System.Windows.Forms.Label
        Me.dtpFNacimiento = New System.Windows.Forms.DateTimePicker
        Me.lblFNacimiento = New System.Windows.Forms.Label
        Me.lblNumMatricula = New System.Windows.Forms.Label
        Me.lblNMatricula = New System.Windows.Forms.Label
        Me.lblConocer = New System.Windows.Forms.Label
        Me.txtConocer = New System.Windows.Forms.TextBox
        Me.tbpDireccion = New System.Windows.Forms.TabPage
        Me.cboProvincias = New System.Windows.Forms.ComboBox
        Me.txtVia = New System.Windows.Forms.TextBox
        Me.lblVia = New System.Windows.Forms.Label
        Me.lblBloque = New System.Windows.Forms.Label
        Me.txtBloque = New System.Windows.Forms.TextBox
        Me.txtPiso = New System.Windows.Forms.TextBox
        Me.lblPiso = New System.Windows.Forms.Label
        Me.txtEscalera = New System.Windows.Forms.TextBox
        Me.lblEscalera = New System.Windows.Forms.Label
        Me.txtPuerta = New System.Windows.Forms.TextBox
        Me.lblPuerta = New System.Windows.Forms.Label
        Me.txtCPostal = New System.Windows.Forms.TextBox
        Me.lblCPostal = New System.Windows.Forms.Label
        Me.txtCiudad = New System.Windows.Forms.TextBox
        Me.lblCiudad = New System.Windows.Forms.Label
        Me.lblProvincia = New System.Windows.Forms.Label
        Me.lblTelefono1 = New System.Windows.Forms.Label
        Me.txtTelefono1 = New System.Windows.Forms.TextBox
        Me.txtTelefono2 = New System.Windows.Forms.TextBox
        Me.lblTelefono2 = New System.Windows.Forms.Label
        Me.lblTelefono3 = New System.Windows.Forms.Label
        Me.txtTelefono3 = New System.Windows.Forms.TextBox
        Me.txtEMail = New System.Windows.Forms.TextBox
        Me.lblEMail = New System.Windows.Forms.Label
        Me.lblWeb = New System.Windows.Forms.Label
        Me.txtWeb = New System.Windows.Forms.TextBox
        Me.lblNumero = New System.Windows.Forms.Label
        Me.txtNumero = New System.Windows.Forms.TextBox
        Me.tbpAnulaciones = New System.Windows.Forms.TabPage
        Me.cmdModificarAnul = New System.Windows.Forms.Button
        Me.cmdNuevaAnul = New System.Windows.Forms.Button
        Me.dtgAnulaciones = New System.Windows.Forms.DataGrid
        Me.tbpObservaciones = New System.Windows.Forms.TabPage
        Me.cmdModificarObservacion = New System.Windows.Forms.Button
        Me.cmdNuevaObservacion = New System.Windows.Forms.Button
        Me.dtgObservaciones = New System.Windows.Forms.DataGrid
        Me.cmdEliminarObservacion = New System.Windows.Forms.Button
        Me.tbpTratamiento = New System.Windows.Forms.TabPage
        Me.cmdModificarTrat = New System.Windows.Forms.Button
        Me.cmdNuevoTrat = New System.Windows.Forms.Button
        Me.cmdEliminarTrat = New System.Windows.Forms.Button
        Me.dtgTratamiento = New Novafis.ScrolledDataGrid
        Me.tipPacientesDetalles = New System.Windows.Forms.ToolTip(Me.components)
        Me.panBotones.SuspendLayout()
        Me.panDetalles.SuspendLayout()
        Me.tabDetalles.SuspendLayout()
        Me.tbpDPersonales.SuspendLayout()
        Me.grbSexo.SuspendLayout()
        Me.tbpDireccion.SuspendLayout()
        Me.tbpAnulaciones.SuspendLayout()
        CType(Me.dtgAnulaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpObservaciones.SuspendLayout()
        CType(Me.dtgObservaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpTratamiento.SuspendLayout()
        CType(Me.dtgTratamiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panBotones
        '
        Me.panBotones.Controls.Add(Me.cboFisiosReferencia)
        Me.panBotones.Controls.Add(Me.lblFisio)
        Me.panBotones.Controls.Add(Me.cmdCerrar)
        Me.panBotones.Controls.Add(Me.cmdGuardar)
        Me.panBotones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panBotones.Location = New System.Drawing.Point(0, 418)
        Me.panBotones.Name = "panBotones"
        Me.panBotones.Size = New System.Drawing.Size(656, 48)
        Me.panBotones.TabIndex = 1
        '
        'cboFisiosReferencia
        '
        Me.cboFisiosReferencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFisiosReferencia.Location = New System.Drawing.Point(143, 15)
        Me.cboFisiosReferencia.MaxDropDownItems = 10
        Me.cboFisiosReferencia.Name = "cboFisiosReferencia"
        Me.cboFisiosReferencia.Size = New System.Drawing.Size(165, 21)
        Me.cboFisiosReferencia.TabIndex = 13
        '
        'lblFisio
        '
        Me.lblFisio.Location = New System.Drawing.Point(12, 13)
        Me.lblFisio.Name = "lblFisio"
        Me.lblFisio.Size = New System.Drawing.Size(125, 23)
        Me.lblFisio.TabIndex = 12
        Me.lblFisio.Text = "Fisio de referencia:"
        Me.lblFisio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdCerrar
        '
        Me.cmdCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCerrar.Location = New System.Drawing.Point(560, 8)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(80, 32)
        Me.cmdCerrar.TabIndex = 1
        Me.cmdCerrar.Text = "Cerrar"
        Me.tipPacientesDetalles.SetToolTip(Me.cmdCerrar, "Cerrar la ventana actual")
        '
        'cmdGuardar
        '
        Me.cmdGuardar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.cmdGuardar.Location = New System.Drawing.Point(464, 8)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(80, 32)
        Me.cmdGuardar.TabIndex = 0
        Me.cmdGuardar.Text = "Guardar"
        Me.tipPacientesDetalles.SetToolTip(Me.cmdGuardar, "Guardar los detalles del paciente")
        '
        'panDetalles
        '
        Me.panDetalles.Controls.Add(Me.tabDetalles)
        Me.panDetalles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panDetalles.Location = New System.Drawing.Point(0, 0)
        Me.panDetalles.Name = "panDetalles"
        Me.panDetalles.Size = New System.Drawing.Size(656, 418)
        Me.panDetalles.TabIndex = 0
        '
        'tabDetalles
        '
        Me.tabDetalles.Controls.Add(Me.tbpDPersonales)
        Me.tabDetalles.Controls.Add(Me.tbpDireccion)
        Me.tabDetalles.Controls.Add(Me.tbpAnulaciones)
        Me.tabDetalles.Controls.Add(Me.tbpObservaciones)
        Me.tabDetalles.Controls.Add(Me.tbpTratamiento)
        Me.tabDetalles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabDetalles.Location = New System.Drawing.Point(0, 0)
        Me.tabDetalles.Name = "tabDetalles"
        Me.tabDetalles.SelectedIndex = 0
        Me.tabDetalles.Size = New System.Drawing.Size(656, 418)
        Me.tabDetalles.TabIndex = 0
        '
        'tbpDPersonales
        '
        Me.tbpDPersonales.Controls.Add(Me.cboFuentes)
        Me.tbpDPersonales.Controls.Add(Me.lblFuente)
        Me.tbpDPersonales.Controls.Add(Me.grbSexo)
        Me.tbpDPersonales.Controls.Add(Me.dtpFRegistro)
        Me.tbpDPersonales.Controls.Add(Me.txtNombre)
        Me.tbpDPersonales.Controls.Add(Me.lblNombre)
        Me.tbpDPersonales.Controls.Add(Me.lblApellido1)
        Me.tbpDPersonales.Controls.Add(Me.txtApellido1)
        Me.tbpDPersonales.Controls.Add(Me.lblApellido2)
        Me.tbpDPersonales.Controls.Add(Me.txtApellido2)
        Me.tbpDPersonales.Controls.Add(Me.lblIdentificacion)
        Me.tbpDPersonales.Controls.Add(Me.txtIdentificacion)
        Me.tbpDPersonales.Controls.Add(Me.lblIdClaro)
        Me.tbpDPersonales.Controls.Add(Me.lblFRegistro)
        Me.tbpDPersonales.Controls.Add(Me.dtpFNacimiento)
        Me.tbpDPersonales.Controls.Add(Me.lblFNacimiento)
        Me.tbpDPersonales.Controls.Add(Me.lblNumMatricula)
        Me.tbpDPersonales.Controls.Add(Me.lblNMatricula)
        Me.tbpDPersonales.Controls.Add(Me.lblConocer)
        Me.tbpDPersonales.Controls.Add(Me.txtConocer)
        Me.tbpDPersonales.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbpDPersonales.Location = New System.Drawing.Point(4, 22)
        Me.tbpDPersonales.Name = "tbpDPersonales"
        Me.tbpDPersonales.Size = New System.Drawing.Size(648, 392)
        Me.tbpDPersonales.TabIndex = 0
        Me.tbpDPersonales.Text = "Datos Personales"
        Me.tbpDPersonales.UseVisualStyleBackColor = True
        '
        'cboFuentes
        '
        Me.cboFuentes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFuentes.Location = New System.Drawing.Point(152, 355)
        Me.cboFuentes.MaxDropDownItems = 10
        Me.cboFuentes.Name = "cboFuentes"
        Me.cboFuentes.Size = New System.Drawing.Size(368, 21)
        Me.cboFuentes.TabIndex = 10
        '
        'lblFuente
        '
        Me.lblFuente.AutoSize = True
        Me.lblFuente.Location = New System.Drawing.Point(94, 358)
        Me.lblFuente.Name = "lblFuente"
        Me.lblFuente.Size = New System.Drawing.Size(50, 13)
        Me.lblFuente.TabIndex = 9
        Me.lblFuente.Text = "Fuente:"
        Me.lblFuente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grbSexo
        '
        Me.grbSexo.Controls.Add(Me.rdbHombre)
        Me.grbSexo.Controls.Add(Me.rdbMujer)
        Me.grbSexo.Location = New System.Drawing.Point(328, 160)
        Me.grbSexo.Name = "grbSexo"
        Me.grbSexo.Size = New System.Drawing.Size(192, 48)
        Me.grbSexo.TabIndex = 5
        Me.grbSexo.TabStop = False
        Me.grbSexo.Text = " Sexo "
        '
        'rdbHombre
        '
        Me.rdbHombre.Location = New System.Drawing.Point(24, 24)
        Me.rdbHombre.Name = "rdbHombre"
        Me.rdbHombre.Size = New System.Drawing.Size(72, 16)
        Me.rdbHombre.TabIndex = 0
        Me.rdbHombre.Text = "Hombre"
        '
        'rdbMujer
        '
        Me.rdbMujer.Location = New System.Drawing.Point(120, 24)
        Me.rdbMujer.Name = "rdbMujer"
        Me.rdbMujer.Size = New System.Drawing.Size(56, 16)
        Me.rdbMujer.TabIndex = 1
        Me.rdbMujer.Text = "Mujer"
        '
        'dtpFRegistro
        '
        Me.dtpFRegistro.CustomFormat = "dd/MM/yyyy"
        Me.dtpFRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFRegistro.Location = New System.Drawing.Point(152, 208)
        Me.dtpFRegistro.Name = "dtpFRegistro"
        Me.dtpFRegistro.Size = New System.Drawing.Size(152, 21)
        Me.dtpFRegistro.TabIndex = 6
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(152, 64)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(368, 21)
        Me.txtNombre.TabIndex = 1
        '
        'lblNombre
        '
        Me.lblNombre.Location = New System.Drawing.Point(32, 64)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(112, 16)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre:"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblApellido1
        '
        Me.lblApellido1.Location = New System.Drawing.Point(32, 96)
        Me.lblApellido1.Name = "lblApellido1"
        Me.lblApellido1.Size = New System.Drawing.Size(112, 16)
        Me.lblApellido1.TabIndex = 0
        Me.lblApellido1.Text = "Primer Apellido:"
        Me.lblApellido1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtApellido1
        '
        Me.txtApellido1.Location = New System.Drawing.Point(152, 96)
        Me.txtApellido1.MaxLength = 50
        Me.txtApellido1.Name = "txtApellido1"
        Me.txtApellido1.Size = New System.Drawing.Size(368, 21)
        Me.txtApellido1.TabIndex = 2
        '
        'lblApellido2
        '
        Me.lblApellido2.Location = New System.Drawing.Point(32, 128)
        Me.lblApellido2.Name = "lblApellido2"
        Me.lblApellido2.Size = New System.Drawing.Size(112, 16)
        Me.lblApellido2.TabIndex = 0
        Me.lblApellido2.Text = "Segundo Apellido:"
        Me.lblApellido2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtApellido2
        '
        Me.txtApellido2.Location = New System.Drawing.Point(152, 128)
        Me.txtApellido2.MaxLength = 50
        Me.txtApellido2.Name = "txtApellido2"
        Me.txtApellido2.Size = New System.Drawing.Size(368, 21)
        Me.txtApellido2.TabIndex = 3
        '
        'lblIdentificacion
        '
        Me.lblIdentificacion.Location = New System.Drawing.Point(32, 168)
        Me.lblIdentificacion.Name = "lblIdentificacion"
        Me.lblIdentificacion.Size = New System.Drawing.Size(112, 16)
        Me.lblIdentificacion.TabIndex = 0
        Me.lblIdentificacion.Text = "Identificación:"
        Me.lblIdentificacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtIdentificacion
        '
        Me.txtIdentificacion.Location = New System.Drawing.Point(152, 168)
        Me.txtIdentificacion.MaxLength = 20
        Me.txtIdentificacion.Name = "txtIdentificacion"
        Me.txtIdentificacion.Size = New System.Drawing.Size(152, 21)
        Me.txtIdentificacion.TabIndex = 4
        '
        'lblIdClaro
        '
        Me.lblIdClaro.Location = New System.Drawing.Point(32, 184)
        Me.lblIdClaro.Name = "lblIdClaro"
        Me.lblIdClaro.Size = New System.Drawing.Size(112, 16)
        Me.lblIdClaro.TabIndex = 0
        Me.lblIdClaro.Text = "(N.I.F., Pasaporte)"
        Me.lblIdClaro.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFRegistro
        '
        Me.lblFRegistro.Location = New System.Drawing.Point(32, 208)
        Me.lblFRegistro.Name = "lblFRegistro"
        Me.lblFRegistro.Size = New System.Drawing.Size(112, 16)
        Me.lblFRegistro.TabIndex = 0
        Me.lblFRegistro.Text = "Fecha Registro:"
        Me.lblFRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpFNacimiento
        '
        Me.dtpFNacimiento.CustomFormat = "dd/MM/yyyy"
        Me.dtpFNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFNacimiento.Location = New System.Drawing.Point(152, 240)
        Me.dtpFNacimiento.Name = "dtpFNacimiento"
        Me.dtpFNacimiento.ShowCheckBox = True
        Me.dtpFNacimiento.Size = New System.Drawing.Size(152, 21)
        Me.dtpFNacimiento.TabIndex = 7
        '
        'lblFNacimiento
        '
        Me.lblFNacimiento.Location = New System.Drawing.Point(32, 240)
        Me.lblFNacimiento.Name = "lblFNacimiento"
        Me.lblFNacimiento.Size = New System.Drawing.Size(112, 16)
        Me.lblFNacimiento.TabIndex = 0
        Me.lblFNacimiento.Text = "Fecha Nacimiento:"
        Me.lblFNacimiento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNumMatricula
        '
        Me.lblNumMatricula.Location = New System.Drawing.Point(8, 24)
        Me.lblNumMatricula.Name = "lblNumMatricula"
        Me.lblNumMatricula.Size = New System.Drawing.Size(136, 16)
        Me.lblNumMatricula.TabIndex = 0
        Me.lblNumMatricula.Text = "Número de Matrícula:"
        Me.lblNumMatricula.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNMatricula
        '
        Me.lblNMatricula.BackColor = System.Drawing.Color.White
        Me.lblNMatricula.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNMatricula.Location = New System.Drawing.Point(152, 24)
        Me.lblNMatricula.Name = "lblNMatricula"
        Me.lblNMatricula.Size = New System.Drawing.Size(176, 16)
        Me.lblNMatricula.TabIndex = 0
        Me.lblNMatricula.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblConocer
        '
        Me.lblConocer.Location = New System.Drawing.Point(24, 280)
        Me.lblConocer.Name = "lblConocer"
        Me.lblConocer.Size = New System.Drawing.Size(120, 16)
        Me.lblConocer.TabIndex = 0
        Me.lblConocer.Text = "¿Cómo nos conoció?"
        Me.lblConocer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtConocer
        '
        Me.txtConocer.Location = New System.Drawing.Point(152, 280)
        Me.txtConocer.MaxLength = 100
        Me.txtConocer.Multiline = True
        Me.txtConocer.Name = "txtConocer"
        Me.txtConocer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtConocer.Size = New System.Drawing.Size(368, 64)
        Me.txtConocer.TabIndex = 4
        '
        'tbpDireccion
        '
        Me.tbpDireccion.Controls.Add(Me.cboProvincias)
        Me.tbpDireccion.Controls.Add(Me.txtVia)
        Me.tbpDireccion.Controls.Add(Me.lblVia)
        Me.tbpDireccion.Controls.Add(Me.lblBloque)
        Me.tbpDireccion.Controls.Add(Me.txtBloque)
        Me.tbpDireccion.Controls.Add(Me.txtPiso)
        Me.tbpDireccion.Controls.Add(Me.lblPiso)
        Me.tbpDireccion.Controls.Add(Me.txtEscalera)
        Me.tbpDireccion.Controls.Add(Me.lblEscalera)
        Me.tbpDireccion.Controls.Add(Me.txtPuerta)
        Me.tbpDireccion.Controls.Add(Me.lblPuerta)
        Me.tbpDireccion.Controls.Add(Me.txtCPostal)
        Me.tbpDireccion.Controls.Add(Me.lblCPostal)
        Me.tbpDireccion.Controls.Add(Me.txtCiudad)
        Me.tbpDireccion.Controls.Add(Me.lblCiudad)
        Me.tbpDireccion.Controls.Add(Me.lblProvincia)
        Me.tbpDireccion.Controls.Add(Me.lblTelefono1)
        Me.tbpDireccion.Controls.Add(Me.txtTelefono1)
        Me.tbpDireccion.Controls.Add(Me.txtTelefono2)
        Me.tbpDireccion.Controls.Add(Me.lblTelefono2)
        Me.tbpDireccion.Controls.Add(Me.lblTelefono3)
        Me.tbpDireccion.Controls.Add(Me.txtTelefono3)
        Me.tbpDireccion.Controls.Add(Me.txtEMail)
        Me.tbpDireccion.Controls.Add(Me.lblEMail)
        Me.tbpDireccion.Controls.Add(Me.lblWeb)
        Me.tbpDireccion.Controls.Add(Me.txtWeb)
        Me.tbpDireccion.Controls.Add(Me.lblNumero)
        Me.tbpDireccion.Controls.Add(Me.txtNumero)
        Me.tbpDireccion.Location = New System.Drawing.Point(4, 22)
        Me.tbpDireccion.Name = "tbpDireccion"
        Me.tbpDireccion.Size = New System.Drawing.Size(648, 392)
        Me.tbpDireccion.TabIndex = 1
        Me.tbpDireccion.Text = "Dirección"
        Me.tbpDireccion.UseVisualStyleBackColor = True
        '
        'cboProvincias
        '
        Me.cboProvincias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProvincias.Location = New System.Drawing.Point(344, 176)
        Me.cboProvincias.MaxDropDownItems = 10
        Me.cboProvincias.Name = "cboProvincias"
        Me.cboProvincias.Size = New System.Drawing.Size(272, 21)
        Me.cboProvincias.TabIndex = 8
        '
        'txtVia
        '
        Me.txtVia.Location = New System.Drawing.Point(136, 40)
        Me.txtVia.MaxLength = 100
        Me.txtVia.Name = "txtVia"
        Me.txtVia.Size = New System.Drawing.Size(480, 21)
        Me.txtVia.TabIndex = 0
        '
        'lblVia
        '
        Me.lblVia.AutoSize = True
        Me.lblVia.Location = New System.Drawing.Point(56, 40)
        Me.lblVia.Name = "lblVia"
        Me.lblVia.Size = New System.Drawing.Size(74, 13)
        Me.lblVia.TabIndex = 2
        Me.lblVia.Text = "Vía pública:"
        Me.lblVia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBloque
        '
        Me.lblBloque.AutoSize = True
        Me.lblBloque.Location = New System.Drawing.Point(24, 72)
        Me.lblBloque.Name = "lblBloque"
        Me.lblBloque.Size = New System.Drawing.Size(104, 13)
        Me.lblBloque.TabIndex = 2
        Me.lblBloque.Text = "Bloque / Edificio:"
        Me.lblBloque.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBloque
        '
        Me.txtBloque.Location = New System.Drawing.Point(136, 72)
        Me.txtBloque.MaxLength = 50
        Me.txtBloque.Name = "txtBloque"
        Me.txtBloque.Size = New System.Drawing.Size(288, 21)
        Me.txtBloque.TabIndex = 1
        '
        'txtPiso
        '
        Me.txtPiso.Location = New System.Drawing.Point(344, 104)
        Me.txtPiso.MaxLength = 10
        Me.txtPiso.Name = "txtPiso"
        Me.txtPiso.Size = New System.Drawing.Size(80, 21)
        Me.txtPiso.TabIndex = 4
        '
        'lblPiso
        '
        Me.lblPiso.AutoSize = True
        Me.lblPiso.Location = New System.Drawing.Point(304, 104)
        Me.lblPiso.Name = "lblPiso"
        Me.lblPiso.Size = New System.Drawing.Size(35, 13)
        Me.lblPiso.TabIndex = 2
        Me.lblPiso.Text = "Piso:"
        Me.lblPiso.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtEscalera
        '
        Me.txtEscalera.Location = New System.Drawing.Point(136, 104)
        Me.txtEscalera.MaxLength = 20
        Me.txtEscalera.Name = "txtEscalera"
        Me.txtEscalera.Size = New System.Drawing.Size(136, 21)
        Me.txtEscalera.TabIndex = 3
        '
        'lblEscalera
        '
        Me.lblEscalera.AutoSize = True
        Me.lblEscalera.Location = New System.Drawing.Point(64, 104)
        Me.lblEscalera.Name = "lblEscalera"
        Me.lblEscalera.Size = New System.Drawing.Size(60, 13)
        Me.lblEscalera.TabIndex = 2
        Me.lblEscalera.Text = "Escalera:"
        Me.lblEscalera.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPuerta
        '
        Me.txtPuerta.Location = New System.Drawing.Point(504, 104)
        Me.txtPuerta.MaxLength = 20
        Me.txtPuerta.Name = "txtPuerta"
        Me.txtPuerta.Size = New System.Drawing.Size(112, 21)
        Me.txtPuerta.TabIndex = 5
        '
        'lblPuerta
        '
        Me.lblPuerta.AutoSize = True
        Me.lblPuerta.Location = New System.Drawing.Point(448, 104)
        Me.lblPuerta.Name = "lblPuerta"
        Me.lblPuerta.Size = New System.Drawing.Size(49, 13)
        Me.lblPuerta.TabIndex = 2
        Me.lblPuerta.Text = "Puerta:"
        Me.lblPuerta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCPostal
        '
        Me.txtCPostal.Location = New System.Drawing.Point(136, 176)
        Me.txtCPostal.MaxLength = 10
        Me.txtCPostal.Name = "txtCPostal"
        Me.txtCPostal.Size = New System.Drawing.Size(120, 21)
        Me.txtCPostal.TabIndex = 7
        '
        'lblCPostal
        '
        Me.lblCPostal.AutoSize = True
        Me.lblCPostal.Location = New System.Drawing.Point(40, 176)
        Me.lblCPostal.Name = "lblCPostal"
        Me.lblCPostal.Size = New System.Drawing.Size(90, 13)
        Me.lblCPostal.TabIndex = 2
        Me.lblCPostal.Text = "Código Postal:"
        Me.lblCPostal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCiudad
        '
        Me.txtCiudad.Location = New System.Drawing.Point(136, 144)
        Me.txtCiudad.MaxLength = 100
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.Size = New System.Drawing.Size(480, 21)
        Me.txtCiudad.TabIndex = 6
        '
        'lblCiudad
        '
        Me.lblCiudad.AutoSize = True
        Me.lblCiudad.Location = New System.Drawing.Point(80, 144)
        Me.lblCiudad.Name = "lblCiudad"
        Me.lblCiudad.Size = New System.Drawing.Size(52, 13)
        Me.lblCiudad.TabIndex = 2
        Me.lblCiudad.Text = "Ciudad:"
        Me.lblCiudad.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblProvincia
        '
        Me.lblProvincia.AutoSize = True
        Me.lblProvincia.Location = New System.Drawing.Point(272, 176)
        Me.lblProvincia.Name = "lblProvincia"
        Me.lblProvincia.Size = New System.Drawing.Size(64, 13)
        Me.lblProvincia.TabIndex = 2
        Me.lblProvincia.Text = "Provincia:"
        Me.lblProvincia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTelefono1
        '
        Me.lblTelefono1.AutoSize = True
        Me.lblTelefono1.Location = New System.Drawing.Point(56, 216)
        Me.lblTelefono1.Name = "lblTelefono1"
        Me.lblTelefono1.Size = New System.Drawing.Size(72, 13)
        Me.lblTelefono1.TabIndex = 2
        Me.lblTelefono1.Text = "Teléfono 1:"
        Me.lblTelefono1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTelefono1
        '
        Me.txtTelefono1.Location = New System.Drawing.Point(136, 216)
        Me.txtTelefono1.MaxLength = 20
        Me.txtTelefono1.Name = "txtTelefono1"
        Me.txtTelefono1.Size = New System.Drawing.Size(120, 21)
        Me.txtTelefono1.TabIndex = 9
        '
        'txtTelefono2
        '
        Me.txtTelefono2.Location = New System.Drawing.Point(136, 248)
        Me.txtTelefono2.MaxLength = 20
        Me.txtTelefono2.Name = "txtTelefono2"
        Me.txtTelefono2.Size = New System.Drawing.Size(120, 21)
        Me.txtTelefono2.TabIndex = 10
        '
        'lblTelefono2
        '
        Me.lblTelefono2.AutoSize = True
        Me.lblTelefono2.Location = New System.Drawing.Point(56, 248)
        Me.lblTelefono2.Name = "lblTelefono2"
        Me.lblTelefono2.Size = New System.Drawing.Size(72, 13)
        Me.lblTelefono2.TabIndex = 2
        Me.lblTelefono2.Text = "Teléfono 2:"
        Me.lblTelefono2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTelefono3
        '
        Me.lblTelefono3.AutoSize = True
        Me.lblTelefono3.Location = New System.Drawing.Point(56, 280)
        Me.lblTelefono3.Name = "lblTelefono3"
        Me.lblTelefono3.Size = New System.Drawing.Size(72, 13)
        Me.lblTelefono3.TabIndex = 2
        Me.lblTelefono3.Text = "Teléfono 3:"
        Me.lblTelefono3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTelefono3
        '
        Me.txtTelefono3.Location = New System.Drawing.Point(136, 280)
        Me.txtTelefono3.MaxLength = 20
        Me.txtTelefono3.Name = "txtTelefono3"
        Me.txtTelefono3.Size = New System.Drawing.Size(120, 21)
        Me.txtTelefono3.TabIndex = 11
        '
        'txtEMail
        '
        Me.txtEMail.Location = New System.Drawing.Point(344, 216)
        Me.txtEMail.MaxLength = 50
        Me.txtEMail.Name = "txtEMail"
        Me.txtEMail.Size = New System.Drawing.Size(272, 21)
        Me.txtEMail.TabIndex = 12
        '
        'lblEMail
        '
        Me.lblEMail.AutoSize = True
        Me.lblEMail.Location = New System.Drawing.Point(288, 216)
        Me.lblEMail.Name = "lblEMail"
        Me.lblEMail.Size = New System.Drawing.Size(48, 13)
        Me.lblEMail.TabIndex = 2
        Me.lblEMail.Text = "e-mail:"
        Me.lblEMail.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblWeb
        '
        Me.lblWeb.AutoSize = True
        Me.lblWeb.Location = New System.Drawing.Point(296, 248)
        Me.lblWeb.Name = "lblWeb"
        Me.lblWeb.Size = New System.Drawing.Size(37, 13)
        Me.lblWeb.TabIndex = 2
        Me.lblWeb.Text = "Web:"
        Me.lblWeb.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtWeb
        '
        Me.txtWeb.Location = New System.Drawing.Point(344, 248)
        Me.txtWeb.MaxLength = 100
        Me.txtWeb.Name = "txtWeb"
        Me.txtWeb.Size = New System.Drawing.Size(272, 21)
        Me.txtWeb.TabIndex = 13
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Location = New System.Drawing.Point(440, 72)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(57, 13)
        Me.lblNumero.TabIndex = 2
        Me.lblNumero.Text = "Número:"
        Me.lblNumero.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(504, 72)
        Me.txtNumero.MaxLength = 20
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(112, 21)
        Me.txtNumero.TabIndex = 2
        '
        'tbpAnulaciones
        '
        Me.tbpAnulaciones.Controls.Add(Me.cmdModificarAnul)
        Me.tbpAnulaciones.Controls.Add(Me.cmdNuevaAnul)
        Me.tbpAnulaciones.Controls.Add(Me.dtgAnulaciones)
        Me.tbpAnulaciones.Location = New System.Drawing.Point(4, 22)
        Me.tbpAnulaciones.Name = "tbpAnulaciones"
        Me.tbpAnulaciones.Size = New System.Drawing.Size(648, 392)
        Me.tbpAnulaciones.TabIndex = 3
        Me.tbpAnulaciones.Text = "Anulaciones"
        Me.tbpAnulaciones.UseVisualStyleBackColor = True
        '
        'cmdModificarAnul
        '
        Me.cmdModificarAnul.Location = New System.Drawing.Point(552, 344)
        Me.cmdModificarAnul.Name = "cmdModificarAnul"
        Me.cmdModificarAnul.Size = New System.Drawing.Size(80, 24)
        Me.cmdModificarAnul.TabIndex = 1
        Me.cmdModificarAnul.Text = "Modificar..."
        Me.tipPacientesDetalles.SetToolTip(Me.cmdModificarAnul, "Modificar Anulación seleccionada")
        '
        'cmdNuevaAnul
        '
        Me.cmdNuevaAnul.Location = New System.Drawing.Point(456, 344)
        Me.cmdNuevaAnul.Name = "cmdNuevaAnul"
        Me.cmdNuevaAnul.Size = New System.Drawing.Size(80, 24)
        Me.cmdNuevaAnul.TabIndex = 0
        Me.cmdNuevaAnul.Text = "Nueva..."
        Me.tipPacientesDetalles.SetToolTip(Me.cmdNuevaAnul, "Nueva Anulación")
        Me.cmdNuevaAnul.Visible = False
        '
        'dtgAnulaciones
        '
        Me.dtgAnulaciones.CaptionText = "Anulaciones del paciente"
        Me.dtgAnulaciones.DataMember = ""
        Me.dtgAnulaciones.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dtgAnulaciones.Location = New System.Drawing.Point(16, 16)
        Me.dtgAnulaciones.Name = "dtgAnulaciones"
        Me.dtgAnulaciones.ReadOnly = True
        Me.dtgAnulaciones.Size = New System.Drawing.Size(616, 312)
        Me.dtgAnulaciones.TabIndex = 1
        Me.dtgAnulaciones.TabStop = False
        '
        'tbpObservaciones
        '
        Me.tbpObservaciones.Controls.Add(Me.cmdModificarObservacion)
        Me.tbpObservaciones.Controls.Add(Me.cmdNuevaObservacion)
        Me.tbpObservaciones.Controls.Add(Me.dtgObservaciones)
        Me.tbpObservaciones.Controls.Add(Me.cmdEliminarObservacion)
        Me.tbpObservaciones.Location = New System.Drawing.Point(4, 22)
        Me.tbpObservaciones.Name = "tbpObservaciones"
        Me.tbpObservaciones.Size = New System.Drawing.Size(648, 392)
        Me.tbpObservaciones.TabIndex = 4
        Me.tbpObservaciones.Text = "Observaciones"
        Me.tbpObservaciones.UseVisualStyleBackColor = True
        '
        'cmdModificarObservacion
        '
        Me.cmdModificarObservacion.Location = New System.Drawing.Point(456, 344)
        Me.cmdModificarObservacion.Name = "cmdModificarObservacion"
        Me.cmdModificarObservacion.Size = New System.Drawing.Size(80, 24)
        Me.cmdModificarObservacion.TabIndex = 1
        Me.cmdModificarObservacion.Text = "Modificar..."
        Me.tipPacientesDetalles.SetToolTip(Me.cmdModificarObservacion, "Modificar Observación seleccionada")
        '
        'cmdNuevaObservacion
        '
        Me.cmdNuevaObservacion.Location = New System.Drawing.Point(360, 344)
        Me.cmdNuevaObservacion.Name = "cmdNuevaObservacion"
        Me.cmdNuevaObservacion.Size = New System.Drawing.Size(80, 24)
        Me.cmdNuevaObservacion.TabIndex = 0
        Me.cmdNuevaObservacion.Text = "Nueva..."
        Me.tipPacientesDetalles.SetToolTip(Me.cmdNuevaObservacion, "Nueva observación")
        '
        'dtgObservaciones
        '
        Me.dtgObservaciones.CaptionText = "Observaciones permanentes"
        Me.dtgObservaciones.DataMember = ""
        Me.dtgObservaciones.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dtgObservaciones.Location = New System.Drawing.Point(16, 16)
        Me.dtgObservaciones.Name = "dtgObservaciones"
        Me.dtgObservaciones.ReadOnly = True
        Me.dtgObservaciones.Size = New System.Drawing.Size(616, 312)
        Me.dtgObservaciones.TabIndex = 2
        Me.dtgObservaciones.TabStop = False
        '
        'cmdEliminarObservacion
        '
        Me.cmdEliminarObservacion.Location = New System.Drawing.Point(552, 344)
        Me.cmdEliminarObservacion.Name = "cmdEliminarObservacion"
        Me.cmdEliminarObservacion.Size = New System.Drawing.Size(80, 24)
        Me.cmdEliminarObservacion.TabIndex = 2
        Me.cmdEliminarObservacion.Text = "Eliminar"
        Me.tipPacientesDetalles.SetToolTip(Me.cmdEliminarObservacion, "Eliminar Observación seleccionada")
        '
        'tbpTratamiento
        '
        Me.tbpTratamiento.Controls.Add(Me.cmdModificarTrat)
        Me.tbpTratamiento.Controls.Add(Me.cmdNuevoTrat)
        Me.tbpTratamiento.Controls.Add(Me.cmdEliminarTrat)
        Me.tbpTratamiento.Controls.Add(Me.dtgTratamiento)
        Me.tbpTratamiento.Location = New System.Drawing.Point(4, 22)
        Me.tbpTratamiento.Name = "tbpTratamiento"
        Me.tbpTratamiento.Size = New System.Drawing.Size(648, 392)
        Me.tbpTratamiento.TabIndex = 2
        Me.tbpTratamiento.Text = "Tratamiento"
        Me.tbpTratamiento.UseVisualStyleBackColor = True
        '
        'cmdModificarTrat
        '
        Me.cmdModificarTrat.Location = New System.Drawing.Point(456, 344)
        Me.cmdModificarTrat.Name = "cmdModificarTrat"
        Me.cmdModificarTrat.Size = New System.Drawing.Size(80, 24)
        Me.cmdModificarTrat.TabIndex = 1
        Me.cmdModificarTrat.Text = "Modificar..."
        Me.tipPacientesDetalles.SetToolTip(Me.cmdModificarTrat, "Modificar sesión seleccionada del Tratamiento")
        '
        'cmdNuevoTrat
        '
        Me.cmdNuevoTrat.Location = New System.Drawing.Point(360, 344)
        Me.cmdNuevoTrat.Name = "cmdNuevoTrat"
        Me.cmdNuevoTrat.Size = New System.Drawing.Size(80, 24)
        Me.cmdNuevoTrat.TabIndex = 0
        Me.cmdNuevoTrat.Text = "Nuevo..."
        Me.tipPacientesDetalles.SetToolTip(Me.cmdNuevoTrat, "Nueva sesión del Tratamiento")
        '
        'cmdEliminarTrat
        '
        Me.cmdEliminarTrat.Location = New System.Drawing.Point(552, 344)
        Me.cmdEliminarTrat.Name = "cmdEliminarTrat"
        Me.cmdEliminarTrat.Size = New System.Drawing.Size(80, 24)
        Me.cmdEliminarTrat.TabIndex = 1
        Me.cmdEliminarTrat.Text = "Eliminar"
        Me.tipPacientesDetalles.SetToolTip(Me.cmdEliminarTrat, "Eliminar sesión seleccionada del Tratamiento")
        '
        'dtgTratamiento
        '
        Me.dtgTratamiento.CaptionText = "Historial del paciente"
        Me.dtgTratamiento.DataMember = ""
        Me.dtgTratamiento.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dtgTratamiento.Location = New System.Drawing.Point(16, 16)
        Me.dtgTratamiento.Name = "dtgTratamiento"
        Me.dtgTratamiento.ReadOnly = True
        Me.dtgTratamiento.Size = New System.Drawing.Size(616, 312)
        Me.dtgTratamiento.TabIndex = 0
        Me.dtgTratamiento.TabStop = False
        '
        'frmPacientesDetalle
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(656, 466)
        Me.ControlBox = False
        Me.Controls.Add(Me.panDetalles)
        Me.Controls.Add(Me.panBotones)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmPacientesDetalle"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalles"
        Me.panBotones.ResumeLayout(False)
        Me.panDetalles.ResumeLayout(False)
        Me.tabDetalles.ResumeLayout(False)
        Me.tbpDPersonales.ResumeLayout(False)
        Me.tbpDPersonales.PerformLayout()
        Me.grbSexo.ResumeLayout(False)
        Me.tbpDireccion.ResumeLayout(False)
        Me.tbpDireccion.PerformLayout()
        Me.tbpAnulaciones.ResumeLayout(False)
        CType(Me.dtgAnulaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpObservaciones.ResumeLayout(False)
        CType(Me.dtgObservaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpTratamiento.ResumeLayout(False)
        CType(Me.dtgTratamiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Const cteModulo As String = "Detalle Pacientes"

    Friend IDPaciente As Integer
    Friend TipoMant As eTiposMantenimiento
    Friend TratGuardado As Boolean

    Private mbGuardarCambios As Boolean


#Region " CONTROLES "

    Private Sub CargarFormulario(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mQuitarManejadores()
        mInicializarFormulario()
        mOKGuardar()
        mRestaurarManejadores()
    End Sub


    Private Sub CambioSolapa(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabDetalles.SelectedIndexChanged
        If tabDetalles.SelectedTab Is tbpDireccion Then
            AddHandler cboProvincias.SelectedIndexChanged, AddressOf Cambios
        Else
            RemoveHandler cboProvincias.SelectedIndexChanged, AddressOf Cambios
        End If

        If tabDetalles.SelectedTab Is tbpTratamiento Then
            If Not IsNothing(CType(dtgTratamiento.DataSource, DataTable)) Then
                dtgTratamiento.ScrollTo(CType(dtgTratamiento.DataSource, DataTable).Rows.Count - 1)
            End If
        End If
    End Sub


    Private Sub SeleccionarUnaFila(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtgTratamiento.MouseUp

        With dtgTratamiento
            Dim objTest As DataGrid.HitTestInfo = .HitTest(New Point(e.X, e.Y))

            ' Si es una celda
            If objTest.Type = DataGrid.HitTestType.Cell Then
                '.CurrentCell = New DataGridCell(objTest.Row, objTest.Column)
                .Select(objTest.Row)
            End If
        End With

    End Sub

    Private Sub GuardarDatosPaciente(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        If mbGuardarDatos() Then
            MessageBox.Show("Datos del Paciente guardados correctamente.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

            'RecuperarPacientes()

            With Me
                .DialogResult = Windows.Forms.DialogResult.OK
                .Dispose()
            End With
        End If
    End Sub


    Private Sub Cambios(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.TextChanged, txtApellido1.TextChanged, txtApellido2.TextChanged, txtIdentificacion.TextChanged, dtpFRegistro.ValueChanged, dtpFNacimiento.ValueChanged, txtConocer.TextChanged, rdbHombre.CheckedChanged, rdbMujer.CheckedChanged, txtVia.TextChanged, txtBloque.TextChanged, txtNumero.TextChanged, txtEscalera.TextChanged, txtPiso.TextChanged, txtPuerta.TextChanged, txtCiudad.TextChanged, txtCPostal.TextChanged, txtTelefono1.TextChanged, txtTelefono2.TextChanged, txtTelefono3.TextChanged, txtEMail.TextChanged, txtWeb.TextChanged, cboProvincias.SelectedIndexChanged

        mbGuardarCambios = True

        If sender.GetType Is GetType(TextBox) Then
            If CType(sender, TextBox).Name = "txtNombre" Or CType(sender, TextBox).Name = "txtApellido1" Or CType(sender, TextBox).Name = "txtApellido2" Then
                mOKGuardar()
            End If
        End If

    End Sub


    Private Sub Cerrar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click

        Me.DialogResult = Windows.Forms.DialogResult.Cancel

        If mbGuardarCambios And cmdGuardar.Enabled Then
            If MessageBox.Show("¿Guardar los cambios realizados?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                cmdGuardar.PerformClick()
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        End If

        CambioTablaPacientes = False

        Me.Dispose()

    End Sub

#End Region


#Region " FUNCIONES "

    Private Sub mInicializarFormulario()

        mbGuardarCambios = False

        'cmdGenerar.Enabled = (Me.TipoMant = eTiposMantenimiento.Alta)
        dtpFRegistro.Enabled = (Me.TipoMant = eTiposMantenimiento.Alta)

        mCargarFisios()
        mCargarFuentes()
        mCargarProvincias()

        Select Case Me.TipoMant
            Case eTiposMantenimiento.Alta
                lblNMatricula.Text = "No asignado"
                dtpFRegistro.Value = DateTime.Today
                dtpFNacimiento.Checked = False

                With tabDetalles.TabPages
                    .Remove(tbpAnulaciones)
                    .Remove(tbpObservaciones)
                    .Remove(tbpTratamiento)
                End With

                tabDetalles.SelectedTab = tbpDPersonales

            Case eTiposMantenimiento.Modificacion
                mLLenarDatosPaciente()
        End Select

        mOKModificarTratamiento()
        mOKModificarAnulacion()

    End Sub

    Private Sub mCargarProvincias()

        Dim objBDatos As New AccesoBD_MySQL()
        Dim dtProvincias As New DataTable()
        Dim iNumProvincias As Integer
        Dim bOK As Boolean

        Try
            With objBDatos
                bOK = .AbrirConexion

                If bOK Then
                    bOK = .EjecutarSP("spProvincias_LLenar", Nothing, dtProvincias, iNumProvincias)

                    If bOK And Not IsNothing(dtProvincias) Then
                        If iNumProvincias > 0 Then
                            With cboProvincias
                                .Items.Clear()

                                .DataSource = dtProvincias

                                .DisplayMember = "PRV_Provincia"
                                .ValueMember = "PRV_ID"

                                .SelectedIndex = 31 'Madrid
                            End With
                        End If
                    End If

                    bOK = .CerrarConexion
                End If
            End With

        Catch exError As Exception
            GestionarErrores(exError.Message, cteModulo, MessageBoxIcon.Error, EventLogEntryType.Error)

            bOK = False

        Finally
            objBDatos.Dispose()

        End Try

    End Sub

    Private Sub mCargarFisios()

        Dim dtFisios As DataTable = CargarFisios()
        Dim iNumFisios As Integer = dtFisios.Rows.Count

        If iNumFisios > 0 Then
            With cboFisiosReferencia
                .Items.Clear()

                .DataSource = dtFisios

                .DisplayMember = "FIS_Alias"
                .ValueMember = "FIS_ID"

                .SelectedIndex = 0
            End With
        End If

    End Sub

    Private Sub mCargarFuentes()

        Dim objBDatos As New AccesoBD_MySQL()
        Dim dtFuentes As New DataTable("Fuentes")
        Dim iNumFuentes As Integer
        Dim bOK As Boolean

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
                        .Value = DBNull.Value
                        .Direction = ParameterDirection.Input
                    End With

                    bOK = .EjecutarSP("spFuentes_LLenar", arrParametros, dtFuentes, iNumFuentes)

                    If bOK And Not IsNothing(dtFuentes) Then
                        Dim drFila As DataRow = dtFuentes.NewRow
                        drFila("FNT_ID") = 0
                        drFila("FNT_Descripcion") = cteNinguna

                        dtFuentes.Rows.Add(drFila)

                        Dim dvFuentes As New DataView(dtFuentes)
                        dvFuentes.Sort = "FNT_ID"

                        'dtFuentes = CType(dvFuentes, DataTable)

                        With cboFuentes
                            .Items.Clear()

                            .DataSource = dvFuentes.ToTable

                            .DisplayMember = "FNT_Descripcion"
                            .ValueMember = "FNT_ID"

                            .SelectedIndex = 0
                        End With
                    End If

                    bOK = .CerrarConexion
                End If
            End With

        Catch exError As Exception
            GestionarErrores(exError.Message, cteModulo, MessageBoxIcon.Error, EventLogEntryType.Error)

            bOK = False

        Finally
            objBDatos.Dispose()

        End Try

    End Sub

    ' Rellenar las distintas fichas del paciente
    Private Sub mLLenarDatosPaciente()

        Dim objBDatos As New AccesoBD_MySQL()
        Dim dtPaciente As New DataTable()
        Dim iNumFilas As Integer
        Dim bOK As Boolean

        Try
            With objBDatos
                bOK = .AbrirConexion()

                If bOK Then
                    Dim arrParametros(0) As MySqlParameter

                    arrParametros(0) = New MySqlParameter()
                    With arrParametros(0)
                        .ParameterName = "iIDPaciente"
                        .MySqlDbType = MySqlDbType.Int32
                        .Size = 4
                        .Value = Me.IDPaciente
                        .Direction = ParameterDirection.Input
                    End With

                    ' Llenar Datos Personales
                    bOK = .EjecutarSP("spPacientes_DPersonalesLLenar", arrParametros, dtPaciente, iNumFilas)

                    If bOK And Not IsNothing(dtPaciente) Then
                        If iNumFilas = 1 Then
                            Dim objFila As DataRow = dtPaciente.Rows(0)
                            Dim iIDFisio As Integer
                            Dim iIDFuente As Integer

                            txtNombre.Text = objFila("PAC_Nombre").ToString.Trim
                            txtApellido1.Text = objFila("PAC_Apellido1").ToString.Trim
                            txtApellido2.Text = objFila("PAC_Apellido2").ToString.Trim
                            txtIdentificacion.Text = objFila("PAC_Identificacion").ToString.Trim
                            dtpFRegistro.Value = Convert.ToDateTime(objFila("PAC_FechaRegistro"))
                            txtConocer.Text = objFila("PAC_Conocer").ToString.Trim

                            If IsDBNull(objFila("PAC_FechaNacimiento")) Then
                                dtpFNacimiento.Checked = False
                            Else
                                dtpFNacimiento.Value = Convert.ToDateTime(objFila("PAC_FechaNacimiento"))
                            End If

                            If Not IsDBNull(objFila("PAC_Sexo")) Then
                                If objFila("PAC_Sexo").ToString = cteHombre Then
                                    rdbHombre.Checked = True
                                Else
                                    rdbMujer.Checked = True
                                End If
                            End If

                            bOK = BuscarElementoCombo(CType(cboFisiosReferencia.DataSource, DataTable), objFila("FIS_ID").ToString.Trim, iIDFisio)

                            If bOK Then
                                cboFisiosReferencia.SelectedIndex = iIDFisio
                            End If

                            If Not IsDBNull(objFila("FNT_ID")) Then
                                bOK = BuscarElementoCombo(CType(cboFuentes.DataSource, DataTable), objFila("FNT_ID").ToString.Trim, iIDFuente)

                                If bOK Then
                                    cboFuentes.SelectedIndex = iIDFuente
                                End If
                            End If
                        End If
                    End If

                    If bOK Then
                        dtPaciente = New DataTable()

                        ' Llenar Dirección
                        bOK = .EjecutarSP("spPacientes_DireccionLLenar", arrParametros, dtPaciente, iNumFilas)

                        If bOK And Not IsNothing(dtPaciente) Then
                            If iNumFilas = 1 Then
                                Dim objFilaD As DataRow = dtPaciente.Rows(0)
                                Dim iIDProvincia As Integer

                                txtVia.Text = objFilaD("PAD_Via").ToString.Trim
                                txtNumero.Text = objFilaD("PAD_Numero").ToString.Trim
                                txtBloque.Text = objFilaD("PAD_Bloque").ToString.Trim
                                txtEscalera.Text = objFilaD("PAD_Escalera").ToString.Trim
                                txtPiso.Text = objFilaD("PAD_Piso").ToString.Trim
                                txtPuerta.Text = objFilaD("PAD_Puerta").ToString.Trim
                                txtCiudad.Text = objFilaD("PAD_Ciudad").ToString.Trim
                                txtCPostal.Text = objFilaD("PAD_CPostal").ToString.Trim
                                txtTelefono1.Text = objFilaD("PAD_Telefono1").ToString.Trim
                                txtTelefono2.Text = objFilaD("PAD_Telefono2").ToString.Trim
                                txtTelefono3.Text = objFilaD("PAD_Telefono3").ToString.Trim
                                txtEMail.Text = objFilaD("PAD_EMail").ToString.Trim
                                txtWeb.Text = objFilaD("PAD_Web").ToString.Trim

                                bOK = BuscarElementoCombo(CType(cboProvincias.DataSource, DataTable), objFilaD("PRV_ID").ToString.Trim, iIDProvincia)

                                If bOK Then
                                    cboProvincias.SelectedIndex = iIDProvincia
                                End If
                            End If
                        End If
                    End If

                    If bOK Then
                        bOK = mbLLenarTratamiento(objBDatos)
                    End If

                    If bOK Then
                        bOK = mbLLenarAnulaciones(objBDatos)
                    End If

                    If bOK Then
                        bOK = mbLLenarObservaciones(objBDatos)
                    End If

                    bOK = .CerrarConexion
                End If
            End With

        Catch exError As Exception
            GestionarErrores(exError.Message, cteModulo, MessageBoxIcon.Error, EventLogEntryType.Error)

            bOK = False

        Finally
            ' Descargar objetos
            dtPaciente.Dispose()
            objBDatos.Dispose()

            lblNMatricula.Text = Me.IDPaciente.ToString

            mOKGuardar()

        End Try

    End Sub

    Private Function mbGuardarDatos() As Boolean

        Dim objBDatos As New AccesoBD_MySQL()
        Dim iNumFilas As Integer = 0

        ' Variable de control global del proceso de guardado
        Dim bOKGuardar As Boolean = False

        Try
            Dim bOK As Boolean

            With objBDatos
                bOK = .AbrirConexion

                If bOK Then
                    bOK = .IniciarTransaccion

                    If bOK Then
                        Dim arrParametros() As MySqlParameter

                        ReDim arrParametros(10)

                        arrParametros(0) = New MySqlParameter()
                        With arrParametros(0)
                            .ParameterName = "sNombre"
                            .MySqlDbType = MySqlDbType.VarChar
                            .Size = 50
                            .Value = mQuitarAcentos(txtNombre.Text.Trim).ToUpper
                            .Direction = ParameterDirection.Input
                        End With

                        arrParametros(1) = New MySqlParameter()
                        With arrParametros(1)
                            .ParameterName = "sApellido1"
                            .MySqlDbType = MySqlDbType.VarChar
                            .Size = 50
                            .Value = mQuitarAcentos(txtApellido1.Text.Trim).ToUpper
                            .Direction = ParameterDirection.Input
                        End With

                        arrParametros(2) = New MySqlParameter()
                        With arrParametros(2)
                            .ParameterName = "sApellido2"
                            .MySqlDbType = MySqlDbType.VarChar
                            .Size = 50
                            .Value = mQuitarAcentos(txtApellido2.Text.Trim).ToUpper
                            .Direction = ParameterDirection.Input
                        End With

                        arrParametros(3) = New MySqlParameter()
                        With arrParametros(3)
                            .ParameterName = "sIdentificacion"
                            .MySqlDbType = MySqlDbType.VarChar
                            .Size = 20
                            .Value = txtIdentificacion.Text.Trim
                            .Direction = ParameterDirection.Input
                        End With

                        arrParametros(4) = New MySqlParameter()
                        With arrParametros(4)
                            .ParameterName = "fFRegistro"
                            .MySqlDbType = MySqlDbType.Date
                            .Size = 8
                            .Value = dtpFRegistro.Value
                            .Direction = ParameterDirection.Input
                        End With

                        arrParametros(5) = New MySqlParameter()
                        With arrParametros(5)
                            .ParameterName = "fFNacimiento"
                            .MySqlDbType = MySqlDbType.Date
                            .Size = 8
                            If dtpFNacimiento.Checked Then
                                .Value = dtpFNacimiento.Value
                            Else
                                .Value = DBNull.Value
                            End If
                            .Direction = ParameterDirection.Input
                        End With

                        arrParametros(6) = New MySqlParameter()
                        With arrParametros(6)
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

                        arrParametros(7) = New MySqlParameter()
                        With arrParametros(7)
                            .ParameterName = "sConocer"
                            .MySqlDbType = MySqlDbType.VarChar
                            .Size = 100
                            .Value = txtConocer.Text.Trim
                            .Direction = ParameterDirection.Input
                        End With

                        ' Cuidado con la dirección del parámetro
                        arrParametros(8) = New MySqlParameter()
                        With arrParametros(8)
                            .ParameterName = "iIDPaciente"
                            .MySqlDbType = MySqlDbType.Int32
                            .Size = 4
                            Select Case Me.TipoMant
                                Case eTiposMantenimiento.Alta
                                    .Direction = ParameterDirection.Output
                                Case eTiposMantenimiento.Modificacion
                                    .Direction = ParameterDirection.Input
                                    .Value = Me.IDPaciente
                            End Select
                        End With

                        arrParametros(9) = New MySqlParameter()
                        With arrParametros(9)
                            .ParameterName = "iIDFisio"
                            .MySqlDbType = MySqlDbType.Int32
                            .Size = 4
                            .Value = cboFisiosReferencia.SelectedValue
                            .Direction = ParameterDirection.Input
                        End With

                        arrParametros(10) = New MySqlParameter()
                        With arrParametros(10)
                            .ParameterName = "iIDFuente"
                            .MySqlDbType = MySqlDbType.Int32
                            .Size = 4
                            .Value = IIf(cboFuentes.SelectedValue = 0, DBNull.Value, cboFuentes.SelectedValue)
                            .Direction = ParameterDirection.Input
                        End With


                        Select Case Me.TipoMant
                            Case eTiposMantenimiento.Alta
                                ' Añadir los Datos Personales del Paciente
                                bOK = .EjecutarSP("spPacientes_DPersonalesAnadir", arrParametros, iNumFilas)
                            Case eTiposMantenimiento.Modificacion
                                ' Modificar los Datos Personales del Paciente
                                bOK = .EjecutarSP("spPacientes_DPersonalesModificar", arrParametros, iNumFilas)
                        End Select


                        If bOK Then
                            Me.IDPaciente = Convert.ToInt32(arrParametros(8).Value)

                            Erase arrParametros
                            ReDim arrParametros(14)

                            arrParametros(0) = New MySqlParameter()
                            With arrParametros(0)
                                .ParameterName = "iIDPaciente"
                                .MySqlDbType = MySqlDbType.Int32
                                .Size = 4
                                .Value = Me.IDPaciente
                                .Direction = ParameterDirection.Input
                            End With

                            arrParametros(1) = New MySqlParameter()
                            With arrParametros(1)
                                .ParameterName = "sVia"
                                .MySqlDbType = MySqlDbType.VarChar
                                .Size = 100
                                .Value = txtVia.Text.Trim
                                .Direction = ParameterDirection.Input
                            End With

                            arrParametros(2) = New MySqlParameter()
                            With arrParametros(2)
                                .ParameterName = "sNumero"
                                .MySqlDbType = MySqlDbType.VarChar
                                .Size = 20
                                .Value = txtNumero.Text.Trim
                                .Direction = ParameterDirection.Input
                            End With

                            arrParametros(3) = New MySqlParameter()
                            With arrParametros(3)
                                .ParameterName = "sBloque"
                                .MySqlDbType = MySqlDbType.VarChar
                                .Size = 50
                                .Value = txtBloque.Text.Trim
                                .Direction = ParameterDirection.Input
                            End With

                            arrParametros(4) = New MySqlParameter()
                            With arrParametros(4)
                                .ParameterName = "sPiso"
                                .MySqlDbType = MySqlDbType.VarChar
                                .Size = 10
                                .Value = txtPiso.Text.Trim
                                .Direction = ParameterDirection.Input
                            End With

                            arrParametros(5) = New MySqlParameter()
                            With arrParametros(5)
                                .ParameterName = "sEscalera"
                                .MySqlDbType = MySqlDbType.VarChar
                                .Size = 20
                                .Value = txtEscalera.Text.Trim
                                .Direction = ParameterDirection.Input
                            End With

                            arrParametros(6) = New MySqlParameter()
                            With arrParametros(6)
                                .ParameterName = "sPuerta"
                                .MySqlDbType = MySqlDbType.VarChar
                                .Size = 20
                                .Value = txtPuerta.Text.Trim
                                .Direction = ParameterDirection.Input
                            End With

                            arrParametros(7) = New MySqlParameter()
                            With arrParametros(7)
                                .ParameterName = "sCPostal"
                                .MySqlDbType = MySqlDbType.VarChar
                                .Size = 10
                                .Value = txtCPostal.Text.Trim
                                .Direction = ParameterDirection.Input
                            End With

                            arrParametros(8) = New MySqlParameter()
                            With arrParametros(8)
                                .ParameterName = "sTelefono1"
                                .MySqlDbType = MySqlDbType.VarChar
                                .Size = 20
                                .Value = txtTelefono1.Text.Trim
                                .Direction = ParameterDirection.Input
                            End With

                            arrParametros(9) = New MySqlParameter()
                            With arrParametros(9)
                                .ParameterName = "sTelefono2"
                                .MySqlDbType = MySqlDbType.VarChar
                                .Size = 20
                                .Value = txtTelefono2.Text.Trim
                                .Direction = ParameterDirection.Input
                            End With

                            arrParametros(10) = New MySqlParameter()
                            With arrParametros(10)
                                .ParameterName = "sTelefono3"
                                .MySqlDbType = MySqlDbType.VarChar
                                .Size = 20
                                .Value = txtTelefono3.Text.Trim
                                .Direction = ParameterDirection.Input
                            End With

                            arrParametros(11) = New MySqlParameter()
                            With arrParametros(11)
                                .ParameterName = "sEMail"
                                .MySqlDbType = MySqlDbType.VarChar
                                .Size = 50
                                .Value = txtEMail.Text.Trim
                                .Direction = ParameterDirection.Input
                            End With

                            arrParametros(12) = New MySqlParameter()
                            With arrParametros(12)
                                .ParameterName = "sWeb"
                                .MySqlDbType = MySqlDbType.VarChar
                                .Size = 100
                                .Value = txtWeb.Text.Trim
                                .Direction = ParameterDirection.Input
                            End With

                            arrParametros(13) = New MySqlParameter()
                            With arrParametros(13)
                                .ParameterName = "sCiudad"
                                .MySqlDbType = MySqlDbType.VarChar
                                .Size = 100
                                .Value = txtCiudad.Text.Trim
                                .Direction = ParameterDirection.Input
                            End With

                            arrParametros(14) = New MySqlParameter()
                            With arrParametros(14)
                                .ParameterName = "sIDProvincia"
                                .MySqlDbType = MySqlDbType.VarChar
                                .Size = 2
                                .Value = cboProvincias.SelectedValue
                                .Direction = ParameterDirection.Input
                            End With

                            Select Case Me.TipoMant
                                Case eTiposMantenimiento.Alta
                                    ' Añadir la Dirección del Paciente
                                    bOK = .EjecutarSP("spPacientes_DireccionAnadir", arrParametros, iNumFilas)
                                Case eTiposMantenimiento.Modificacion
                                    ' Modificar la Dirección del Paciente
                                    bOK = .EjecutarSP("spPacientes_DireccionModificar", arrParametros, iNumFilas)
                            End Select
                        End If

                        bOKGuardar = bOK

                        If bOK Then
                            bOK = .ConfirmarTransaccion
                        Else
                            bOK = .CancelarTransaccion
                        End If
                    End If

                    bOK = .CerrarConexion
                Else
                    bOKGuardar = False
                End If
            End With

        Catch exError As Exception
            GestionarErrores(exError.Message, cteModulo, MessageBoxIcon.Error, EventLogEntryType.Error)

            bOKGuardar = False

        End Try

        Return bOKGuardar

    End Function

    ' Control de la habilitación del botón Guardar
    Private Sub mOKGuardar()

        Dim bOKGuardar As Boolean = False

        If txtNombre.Text.Trim <> String.Empty Or txtApellido1.Text.Trim <> String.Empty Or txtApellido2.Text.Trim <> String.Empty Then
            bOKGuardar = True
        End If

        cmdGuardar.Enabled = bOKGuardar

    End Sub

    Private Sub mQuitarManejadores()

        Dim objControl As Control

        ' Recorrer la solapa Datos Personales
        For Each objControl In tbpDPersonales.Controls
            If objControl.GetType Is GetType(TextBox) Then
                RemoveHandler CType(objControl, TextBox).TextChanged, AddressOf Cambios
            End If

            If objControl.GetType Is GetType(DateTimePicker) Then
                RemoveHandler CType(objControl, DateTimePicker).ValueChanged, AddressOf Cambios
            End If
        Next objControl

        RemoveHandler rdbHombre.CheckedChanged, AddressOf Cambios
        RemoveHandler rdbMujer.CheckedChanged, AddressOf Cambios

        ' Recorrer la solapa Dirección
        For Each objControl In tbpDireccion.Controls
            If objControl.GetType Is GetType(TextBox) Then
                RemoveHandler CType(objControl, TextBox).TextChanged, AddressOf Cambios
            End If

            If objControl.GetType Is GetType(ComboBox) Then
                RemoveHandler CType(objControl, ComboBox).SelectedIndexChanged, AddressOf Cambios
            End If
        Next objControl

    End Sub

    Private Sub mRestaurarManejadores()

        Dim objControl As Control

        ' Recorrer la solapa Datos Personales
        For Each objControl In tbpDPersonales.Controls
            If objControl.GetType Is GetType(TextBox) Then
                AddHandler CType(objControl, TextBox).TextChanged, AddressOf Cambios
            End If

            If objControl.GetType Is GetType(DateTimePicker) Then
                AddHandler CType(objControl, DateTimePicker).ValueChanged, AddressOf Cambios
            End If
        Next objControl

        AddHandler rdbHombre.CheckedChanged, AddressOf Cambios
        AddHandler rdbMujer.CheckedChanged, AddressOf Cambios

        ' Recorrer la solapa Dirección
        For Each objControl In tbpDireccion.Controls
            If objControl.GetType Is GetType(TextBox) Then
                AddHandler CType(objControl, TextBox).TextChanged, AddressOf Cambios
            End If

            'If objControl.GetType Is GetType(ComboBox) Then
            '    AddHandler CType(objControl, ComboBox).SelectedIndexChanged, AddressOf CambioProvincia
            'End If
        Next objControl

    End Sub

#End Region


#Region " TRATAMIENTOS "

    ' Configuración del Grid de Tratamientos
    Private arrCamposTrat() As String = {"PAT_Fecha", "PAT_Descripcion", "EST_Descripcion", "PAT_Cobrado", "PAT_Deuda", "LES_Descripcion", "LOC_Descripcion", "PAT_Sesiones", "PAT_ID", "EST_ID"}
    Private arrCabecerasTrat() As String = {"Fecha", "Tratamiento", "Estado", "Pagado", "Deuda", "Lesión", "Localización", "Sesiones", String.Empty, String.Empty}
    Private arrTiposDatosTrat() As String = {"F", "S", "S", "M", "M", "S", "S", "I", "I", "I"}
    Private arrAnchurasTrat() As Integer = {80, 300, 100, 70, 70, 100, 100, 80, 0, 0}


    Private Sub ModificarTratamientoGrid(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgTratamiento.DoubleClick
        If cmdModificarTrat.Enabled Then
            cmdModificarTrat.PerformClick()
        End If
    End Sub

    Private Sub SeleccionarUnTratamiento(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtgTratamiento.MouseUp

        Dim objTest As DataGrid.HitTestInfo = dtgTratamiento.HitTest(New Point(e.X, e.Y))

        ' Si es una celda
        If objTest.Type = DataGrid.HitTestType.Cell Then
            dtgTratamiento.Select(objTest.Row)
        End If

        ' Habilitar el botón Modificar cuando se seleccione una celda. No valen las cabeceras.
        cmdModificarTrat.Enabled = (objTest.Type = DataGrid.HitTestType.Cell)

    End Sub


    Private Sub NuevoTratamiento(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevoTrat.Click
        mMantenimientoTratamiento(0, eTiposMantenimiento.Alta)
    End Sub

    Private Sub ModificarTratamiento(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificarTrat.Click
        Dim iIDTratamiento As Integer = CType(dtgTratamiento.Item(dtgTratamiento.CurrentRowIndex, 8), Integer)

        mMantenimientoTratamiento(iIDTratamiento, eTiposMantenimiento.Modificacion)
    End Sub

    Private Sub EliminarTratamiento(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminarTrat.Click
        If MessageBox.Show("¿Deseas eliminar la sesión de Tratamiento seleccionada?", cteModulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            mEliminarTratamiento()
        End If
    End Sub

    Private Sub mMantenimientoTratamiento(ByVal iIDTratamiento As Integer, ByVal iTipoMant As eTiposMantenimiento)

        Dim objTratDetalle As New frmTratamiento()
        Dim objTabla As DataTable
        Dim objVista As DataView
        Dim arrFilas() As DataRow

        objTabla = CType(dtgTratamiento.DataSource, DataTable)

        With objTratDetalle
            .IDPaciente = Me.IDPaciente
            .IDTratamiento = iIDTratamiento
            .IDFisioRef = CType(cboFisiosReferencia.SelectedValue, Integer)
            .TipoMantenimiento = iTipoMant

            If IsNothing(objTabla) Then
                '.PrimeraSesion = True
                .NumSesion = 0
                .Estado = eEstadosTratamiento.NoEstado
            Else
                Dim drFila As DataRow = objTabla.Rows(objTabla.Rows.Count - 1)

                '.PrimeraSesion = (Convert.ToInt32(drFila("EST_ID")) = 1)
                .NumSesion = Convert.ToInt32(drFila("PAT_Sesiones"))
                .Estado = CType(drFila("EST_ID"), eEstadosTratamiento)
            End If

            If .ShowDialog = DialogResult.OK Then
                Me.TratGuardado = True
                mbLLenarTratamiento(Nothing)
            End If
        End With
    End Sub

    Private Function mEliminarTratamiento() As Boolean

        Dim objBDatos As New AccesoBD_MySQL()
        Dim sSQL As String = String.Empty
        Dim bOK As Boolean

        Try
            With objBDatos
                bOK = .AbrirConexion

                If bOK Then
                    bOK = .IniciarTransaccion

                    If bOK Then
                        Dim arrParametros(0) As MySqlParameter
                        Dim iIDTratamiento As Integer = Convert.ToInt32((dtgTratamiento.Item(dtgTratamiento.CurrentRowIndex, 8)))

                        arrParametros(0) = New MySqlParameter()
                        With arrParametros(0)
                            .ParameterName = "iIDTratamiento"
                            .MySqlDbType = MySqlDbType.Int32
                            .Size = 10
                            .Value = iIDTratamiento
                            .Direction = ParameterDirection.Input
                        End With

                        bOK = .EjecutarSP("spTratamientos_Eliminar", arrParametros)

                        If bOK Then
                            bOK = .ConfirmarTransaccion
                            mbLLenarTratamiento(objBDatos)
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

    Private Function mbLLenarTratamiento(ByVal objBDatos As AccesoBD_MySQL) As Boolean

        Dim dtTratamientos As New DataTable("PacientesTratamiento")
        Dim sSQL As String = String.Empty
        Dim iNumFilas As Integer = 0
        Dim bCerrarConexion As Boolean = False
        Dim bOK As Boolean = False

        If IsNothing(objBDatos) Then
            objBDatos = New AccesoBD_MySQL()
            bOK = objBDatos.AbrirConexion
            bCerrarConexion = bOK
        End If

        ' Ficha Tratamiento
        Dim arrParametros(0) As MySqlParameter

        arrParametros(0) = New MySqlParameter()
        With arrParametros(0)
            .ParameterName = "iIDPaciente"
            .MySqlDbType = MySqlDbType.Int32
            .Size = 4
            .Value = Me.IDPaciente
            .Direction = ParameterDirection.Input
        End With

        bOK = objBDatos.EjecutarSP("spTratamientos_LLenar", arrParametros, dtTratamientos, iNumFilas)

        If bOK And Not IsNothing(dtTratamientos) Then
            If iNumFilas > 0 Then
                dtgTratamiento.SetDataBinding(dtTratamientos, String.Empty)

                NovafisDataGrid.EstiloGrid(arrCamposTrat, arrCabecerasTrat, arrTiposDatosTrat, arrAnchurasTrat, dtgTratamiento, "PacientesTratamiento", False)

                dtgTratamiento.ScrollTo(iNumFilas - 1)
            End If
        End If

        If bCerrarConexion Then
            bOK = objBDatos.CerrarConexion
        End If

        mOKModificarTratamiento()

        Return bOK

    End Function

    Private Sub mOKModificarTratamiento()

        Dim objTabla As New DataTable()
        Dim bOK As Boolean

        objTabla = CType(dtgTratamiento.DataSource, DataTable)

        bOK = Not IsNothing(objTabla)

        If bOK Then
            bOK = (objTabla.Rows.Count > 0)
            objTabla.Dispose()
        End If

        cmdModificarTrat.Enabled = bOK
        cmdEliminarTrat.Enabled = bOK

    End Sub

#End Region


#Region " ANULACIONES "

    ' Configuración del Grid de Anulaciones
    Private arrCamposAnul() As String = {"PAA_Fecha", "PAA_Motivo", "PAA_ID"}
    Private arrCabecerasAnul() As String = {"Fecha", "Motivo", String.Empty}
    Private arrTiposDatosAnul() As String = {"F", "S", "I"}
    Private arrAnchurasAnul() As Integer = {80, 400, 0}


    Private Sub ModificarAnulacionGrid(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgAnulaciones.DoubleClick
        If cmdModificarAnul.Enabled Then
            cmdModificarAnul.PerformClick()
        End If
    End Sub

    Private Sub SeleccionarUnaAnulacion(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtgAnulaciones.MouseUp

        Dim objTest As DataGrid.HitTestInfo = dtgAnulaciones.HitTest(New Point(e.X, e.Y))

        ' Si es una celda
        If objTest.Type = DataGrid.HitTestType.Cell Then
            dtgAnulaciones.Select(objTest.Row)
        End If

        ' Habilitar el botón Modificar cuando se seleccione una celda. No valen las cabeceras.
        cmdModificarAnul.Enabled = (objTest.Type = DataGrid.HitTestType.Cell)

    End Sub


    Private Sub NuevaAnulacion(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevaAnul.Click
        mMantenimientoAnulacion(0, eTiposMantenimiento.Alta)
    End Sub

    Private Sub ModificarAnulacion(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificarAnul.Click
        Dim iIDAnulacion As Integer = CType(dtgAnulaciones.Item(dtgAnulaciones.CurrentRowIndex, 2), Integer)

        mMantenimientoAnulacion(iIDAnulacion, eTiposMantenimiento.Modificacion)
    End Sub

    Private Sub mMantenimientoAnulacion(ByVal iIDAnulacion As Integer, ByVal iTipoMant As eTiposMantenimiento)

        Dim objAnulDetalle As New frmAnulaciones()

        With objAnulDetalle
            .Paciente = Me.Text.Replace("Paciente:", String.Empty).Trim
            .IDPaciente = Me.IDPaciente
            .IDAnulacion = iIDAnulacion
            .TipoMantenimiento = iTipoMant

            If .ShowDialog = DialogResult.OK Then
                mbLLenarAnulaciones(Nothing)
            End If
        End With

    End Sub


    Private Function mbLLenarAnulaciones(ByVal objBDatos As AccesoBD_MySQL) As Boolean

        Dim dtAnulaciones As New DataTable("PacientesAnulaciones")
        Dim sSQL As String = String.Empty
        Dim iNumFilas As Integer = 0
        Dim bCerrarConexion As Boolean = False
        Dim bOK As Boolean = False

        If IsNothing(objBDatos) Then
            objBDatos = New AccesoBD_MySQL()
            bOK = objBDatos.AbrirConexion
            bCerrarConexion = bOK
        End If

        ' Ficha Anulaciones
        Dim arrParametros(1) As MySqlParameter

        arrParametros(0) = New MySqlParameter()
        With arrParametros(0)
            .ParameterName = "iIDPaciente"
            .MySqlDbType = MySqlDbType.Int32
            .Size = 10
            .Value = Me.IDPaciente
            .Direction = ParameterDirection.Input
        End With

        arrParametros(1) = New MySqlParameter()
        With arrParametros(1)
            .ParameterName = "iIDAnulacion"
            .MySqlDbType = MySqlDbType.Int32
            .Size = 10
            .Value = DBNull.Value
            .Direction = ParameterDirection.Input
        End With

        bOK = objBDatos.EjecutarSP("spAnulaciones_LLenar", arrParametros, dtAnulaciones, iNumFilas)

        If bOK And Not IsNothing(dtAnulaciones) Then
            If iNumFilas > 0 Then
                dtgAnulaciones.SetDataBinding(dtAnulaciones, String.Empty)

                NovafisDataGrid.EstiloGrid(arrCamposAnul, arrCabecerasAnul, arrTiposDatosAnul, arrAnchurasAnul, dtgAnulaciones, "PacientesAnulaciones")
            End If
        End If

        If bCerrarConexion Then
            bOK = objBDatos.CerrarConexion
        End If

        mOKModificarAnulacion()

        Return bOK

    End Function

    Private Sub mOKModificarAnulacion()

        Dim objTabla As New DataTable()
        Dim bOK As Boolean

        objTabla = CType(dtgAnulaciones.DataSource, DataTable)

        bOK = Not IsNothing(objTabla)

        If bOK Then
            bOK = (objTabla.Rows.Count > 0)
            objTabla.Dispose()
        End If

        cmdModificarAnul.Enabled = bOK

    End Sub

#End Region


#Region " OBSERVACIONES "

    ' Configuración del Grid de Tratamientos
    Private arrCamposObs() As String = {"PAO_Descripcion", "PAO_ID"}
    Private arrCabecerasObs() As String = {"Observación", String.Empty}
    Private arrTiposDatosObs() As String = {"S", "I"}
    Private arrAnchurasObs() As Integer = {300, 0}


    Private Sub ModificarObservacionGrid(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgObservaciones.DoubleClick
        If cmdModificarObservacion.Enabled Then
            cmdModificarObservacion.PerformClick()
        End If
    End Sub

    Private Sub SeleccionarUnaObservacion(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtgObservaciones.MouseUp

        Dim objTest As DataGrid.HitTestInfo = dtgObservaciones.HitTest(New Point(e.X, e.Y))

        ' Si es una celda
        If objTest.Type = DataGrid.HitTestType.Cell Then
            dtgObservaciones.Select(objTest.Row)
        End If

        ' Habilitar el botón Modificar cuando se seleccione una celda. No valen las cabeceras.
        cmdModificarObservacion.Enabled = (objTest.Type = DataGrid.HitTestType.Cell)

    End Sub


    Private Sub NuevaObservacion(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevaObservacion.Click
        mMantenimientoObservacion(0, eTiposMantenimiento.Alta)
    End Sub

    Private Sub ModificarObservacion(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificarObservacion.Click
        Dim iIDObservacion As Integer = Convert.ToInt32((dtgObservaciones.Item(dtgObservaciones.CurrentRowIndex, 1)))

        mMantenimientoObservacion(iIDObservacion, eTiposMantenimiento.Modificacion)
    End Sub

    Private Sub EliminarObservacion(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminarObservacion.Click
        If MessageBox.Show("¿Deseas eliminar la Observación seleccionada?", cteModulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            mEliminarObservacion()
        End If
    End Sub


    Private Sub mMantenimientoObservacion(ByVal iIDObservacion As Integer, ByVal iTipoMant As eTiposMantenimiento)

        Dim objObsDetalle As New frmObservacionesDetalle()

        With objObsDetalle
            .IDPaciente = Me.IDPaciente
            .IDObservacion = iIDObservacion
            .TipoMantenimiento = iTipoMant
            .lblPaciente.Text = Me.Text.Replace("Paciente:", String.Empty).Trim

            If .ShowDialog = DialogResult.OK Then
                mbLLenarObservaciones(Nothing)
            End If
        End With
    End Sub


    Private Function mbLLenarObservaciones(ByVal objBDatos As AccesoBD_MySQL) As Boolean

        Dim dtObservaciones As New DataTable("PacientesObservaciones")
        Dim sSQL As String = String.Empty
        Dim iNumFilas As Integer = 0
        Dim bCerrarConexion As Boolean = False
        Dim bOK As Boolean = False

        If IsNothing(objBDatos) Then
            objBDatos = New AccesoBD_MySQL()
            bOK = objBDatos.AbrirConexion
            bCerrarConexion = bOK
        End If

        ' Ficha Observaciones
        Dim arrParametros(0) As MySqlParameter

        arrParametros(0) = New MySqlParameter()
        With arrParametros(0)
            .ParameterName = "iIDPaciente"
            .MySqlDbType = MySqlDbType.Int32
            .Size = 4
            .Value = Me.IDPaciente
            .Direction = ParameterDirection.Input
        End With

        bOK = objBDatos.EjecutarSP("spObservaciones_LLenar", arrParametros, dtObservaciones, iNumFilas)

        If bOK And Not IsNothing(dtObservaciones) Then
            If iNumFilas > 0 Then
                dtgObservaciones.SetDataBinding(dtObservaciones, String.Empty)

                NovafisDataGrid.EstiloGrid(arrCamposObs, arrCabecerasObs, arrTiposDatosObs, arrAnchurasObs, dtgObservaciones, "PacientesObservaciones")
            End If
        End If

        If bCerrarConexion Then
            bOK = objBDatos.CerrarConexion
        End If

        mOKGestionarObservaciones()

        Return bOK

    End Function

    Private Function mEliminarObservacion() As Boolean

        Dim objBDatos As New AccesoBD_MySQL()
        Dim sSQL As String = String.Empty
        Dim bOK As Boolean

        Try
            With objBDatos
                bOK = .AbrirConexion

                If bOK Then
                    bOK = .IniciarTransaccion

                    If bOK Then
                        Dim arrParametros(0) As MySqlParameter
                        Dim iIDObservacion As Integer = Convert.ToInt32((dtgObservaciones.Item(dtgObservaciones.CurrentRowIndex, 1)))

                        arrParametros(0) = New MySqlParameter()
                        With arrParametros(0)
                            .ParameterName = "iIDObservacion"
                            .MySqlDbType = MySqlDbType.Int32
                            .Size = 10
                            .Value = iIDObservacion
                            .Direction = ParameterDirection.Input
                        End With

                        bOK = .EjecutarSP("spObservaciones_Eliminar", arrParametros)

                        If bOK Then
                            bOK = .ConfirmarTransaccion
                            mbLLenarObservaciones(objBDatos)
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

    Private Sub mOKGestionarObservaciones()

        Dim objTabla As New DataTable()
        Dim bOK As Boolean

        objTabla = CType(dtgObservaciones.DataSource, DataTable)

        bOK = Not IsNothing(objTabla)

        If bOK Then
            bOK = (objTabla.Rows.Count > 0)
            objTabla.Dispose()
        End If

        cmdModificarObservacion.Enabled = bOK
        cmdEliminarObservacion.Enabled = bOK

    End Sub

#End Region


    Private Function mQuitarAcentos(ByVal sCadena As String) As String

        Dim sCadenaFormateada As New System.Text.StringBuilder
        Dim arrCadena As Char() = sCadena.ToCharArray

        For Each sCaracter As Char In arrCadena
            Dim iAscii As Integer = Asc(sCaracter)

            Select Case iAscii
                Case 193, 196, 225, 228 ' Á, Ä, á, ä
                    sCaracter = "A"
                Case 201, 203, 233, 235 ' É, Ë, é, ë
                    sCaracter = "E"
                Case 205, 207, 237, 239 ' Í, Ï, í, ï
                    sCaracter = "I"
                Case 211, 214, 243, 246 ' Ó, Ö, ó, ö
                    sCaracter = "O"
                Case 218, 220, 250, 252 ' Ú, Ü, ú, ü
                    sCaracter = "U"
            End Select

            sCadenaFormateada.Append(sCaracter)
        Next

        Return sCadenaFormateada.ToString

    End Function

End Class
