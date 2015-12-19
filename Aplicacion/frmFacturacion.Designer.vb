<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFacturacion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.dtgFacturas = New System.Windows.Forms.DataGrid
        Me.cmdGenerar = New System.Windows.Forms.Button
        Me.cmdNueva = New System.Windows.Forms.Button
        Me.cmdCerrar = New System.Windows.Forms.Button
        Me.errFacturas = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.tipFacturas = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdGuardar = New System.Windows.Forms.Button
        Me.grbFactura = New System.Windows.Forms.GroupBox
        Me.lblIdentificacion = New System.Windows.Forms.Label
        Me.txtIdentificacion = New System.Windows.Forms.TextBox
        Me.txtOtro = New System.Windows.Forms.TextBox
        Me.txtTratamiento = New System.Windows.Forms.TextBox
        Me.nudImporte = New System.Windows.Forms.NumericUpDown
        Me.nudSesiones = New System.Windows.Forms.NumericUpDown
        Me.rdbOtro = New System.Windows.Forms.RadioButton
        Me.cmdBuscarPacientes = New System.Windows.Forms.Button
        Me.rdbPaciente = New System.Windows.Forms.RadioButton
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker
        Me.txtPaciente = New System.Windows.Forms.TextBox
        Me.txtNumFactura = New System.Windows.Forms.TextBox
        Me.lblFecha = New System.Windows.Forms.Label
        Me.lblTratamiento = New System.Windows.Forms.Label
        Me.lblImporte = New System.Windows.Forms.Label
        Me.lblSesiones = New System.Windows.Forms.Label
        Me.lblNumFactura = New System.Windows.Forms.Label
        Me.cmdCancelar = New System.Windows.Forms.Button
        CType(Me.dtgFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbFactura.SuspendLayout()
        CType(Me.nudImporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSesiones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgFacturas
        '
        Me.dtgFacturas.CaptionText = "Facturas emitidas"
        Me.dtgFacturas.DataMember = ""
        Me.dtgFacturas.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dtgFacturas.Location = New System.Drawing.Point(14, 12)
        Me.dtgFacturas.Name = "dtgFacturas"
        Me.dtgFacturas.ReadOnly = True
        Me.dtgFacturas.Size = New System.Drawing.Size(566, 200)
        Me.dtgFacturas.TabIndex = 0
        Me.dtgFacturas.TabStop = False
        '
        'cmdGenerar
        '
        Me.cmdGenerar.Enabled = False
        Me.cmdGenerar.Location = New System.Drawing.Point(595, 50)
        Me.cmdGenerar.Name = "cmdGenerar"
        Me.cmdGenerar.Size = New System.Drawing.Size(93, 32)
        Me.cmdGenerar.TabIndex = 2
        Me.cmdGenerar.Text = "Generar"
        Me.tipFacturas.SetToolTip(Me.cmdGenerar, "Generar Factura seleccionada")
        '
        'cmdNueva
        '
        Me.cmdNueva.Location = New System.Drawing.Point(595, 12)
        Me.cmdNueva.Name = "cmdNueva"
        Me.cmdNueva.Size = New System.Drawing.Size(93, 32)
        Me.cmdNueva.TabIndex = 1
        Me.cmdNueva.Text = "Nueva"
        Me.tipFacturas.SetToolTip(Me.cmdNueva, "Rellenar datos de nueva Factura")
        '
        'cmdCerrar
        '
        Me.cmdCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCerrar.Location = New System.Drawing.Point(595, 180)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(93, 32)
        Me.cmdCerrar.TabIndex = 3
        Me.cmdCerrar.Text = "Cerrar"
        Me.tipFacturas.SetToolTip(Me.cmdCerrar, "Cerrar ventana de Facturación")
        '
        'errFacturas
        '
        Me.errFacturas.ContainerControl = Me
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Location = New System.Drawing.Point(575, 172)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(93, 34)
        Me.cmdGuardar.TabIndex = 9
        Me.cmdGuardar.Text = "Guardar"
        Me.tipFacturas.SetToolTip(Me.cmdGuardar, "Guardar y Generar Factura creada")
        '
        'grbFactura
        '
        Me.grbFactura.Controls.Add(Me.lblIdentificacion)
        Me.grbFactura.Controls.Add(Me.txtIdentificacion)
        Me.grbFactura.Controls.Add(Me.txtOtro)
        Me.grbFactura.Controls.Add(Me.txtTratamiento)
        Me.grbFactura.Controls.Add(Me.nudImporte)
        Me.grbFactura.Controls.Add(Me.nudSesiones)
        Me.grbFactura.Controls.Add(Me.rdbOtro)
        Me.grbFactura.Controls.Add(Me.cmdBuscarPacientes)
        Me.grbFactura.Controls.Add(Me.rdbPaciente)
        Me.grbFactura.Controls.Add(Me.dtpFecha)
        Me.grbFactura.Controls.Add(Me.txtPaciente)
        Me.grbFactura.Controls.Add(Me.txtNumFactura)
        Me.grbFactura.Controls.Add(Me.lblFecha)
        Me.grbFactura.Controls.Add(Me.lblTratamiento)
        Me.grbFactura.Controls.Add(Me.lblImporte)
        Me.grbFactura.Controls.Add(Me.lblSesiones)
        Me.grbFactura.Controls.Add(Me.lblNumFactura)
        Me.grbFactura.Controls.Add(Me.cmdCancelar)
        Me.grbFactura.Controls.Add(Me.cmdGuardar)
        Me.grbFactura.Location = New System.Drawing.Point(14, 229)
        Me.grbFactura.Name = "grbFactura"
        Me.grbFactura.Size = New System.Drawing.Size(674, 265)
        Me.grbFactura.TabIndex = 4
        Me.grbFactura.TabStop = False
        '
        'lblIdentificacion
        '
        Me.lblIdentificacion.AutoSize = True
        Me.lblIdentificacion.Location = New System.Drawing.Point(39, 134)
        Me.lblIdentificacion.Name = "lblIdentificacion"
        Me.lblIdentificacion.Size = New System.Drawing.Size(88, 13)
        Me.lblIdentificacion.TabIndex = 34
        Me.lblIdentificacion.Text = "Identificación:"
        Me.lblIdentificacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtIdentificacion
        '
        Me.txtIdentificacion.Location = New System.Drawing.Point(133, 131)
        Me.txtIdentificacion.MaxLength = 15
        Me.txtIdentificacion.Name = "txtIdentificacion"
        Me.txtIdentificacion.Size = New System.Drawing.Size(289, 21)
        Me.txtIdentificacion.TabIndex = 5
        '
        'txtOtro
        '
        Me.txtOtro.Location = New System.Drawing.Point(133, 88)
        Me.txtOtro.MaxLength = 100
        Me.txtOtro.Name = "txtOtro"
        Me.txtOtro.Size = New System.Drawing.Size(428, 21)
        Me.txtOtro.TabIndex = 4
        '
        'txtTratamiento
        '
        Me.txtTratamiento.Location = New System.Drawing.Point(133, 172)
        Me.txtTratamiento.MaxLength = 100
        Me.txtTratamiento.Multiline = True
        Me.txtTratamiento.Name = "txtTratamiento"
        Me.txtTratamiento.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTratamiento.Size = New System.Drawing.Size(428, 77)
        Me.txtTratamiento.TabIndex = 8
        '
        'nudImporte
        '
        Me.nudImporte.DecimalPlaces = 2
        Me.nudImporte.Location = New System.Drawing.Point(575, 131)
        Me.nudImporte.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudImporte.Name = "nudImporte"
        Me.nudImporte.Size = New System.Drawing.Size(93, 21)
        Me.nudImporte.TabIndex = 7
        Me.nudImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'nudSesiones
        '
        Me.nudSesiones.Location = New System.Drawing.Point(501, 131)
        Me.nudSesiones.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudSesiones.Name = "nudSesiones"
        Me.nudSesiones.Size = New System.Drawing.Size(60, 21)
        Me.nudSesiones.TabIndex = 6
        Me.nudSesiones.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'rdbOtro
        '
        Me.rdbOtro.AutoSize = True
        Me.rdbOtro.Location = New System.Drawing.Point(9, 89)
        Me.rdbOtro.Name = "rdbOtro"
        Me.rdbOtro.Size = New System.Drawing.Size(50, 17)
        Me.rdbOtro.TabIndex = 3
        Me.rdbOtro.TabStop = True
        Me.rdbOtro.Text = "Otro"
        Me.rdbOtro.UseVisualStyleBackColor = True
        '
        'cmdBuscarPacientes
        '
        Me.cmdBuscarPacientes.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBuscarPacientes.Location = New System.Drawing.Point(567, 51)
        Me.cmdBuscarPacientes.Name = "cmdBuscarPacientes"
        Me.cmdBuscarPacientes.Size = New System.Drawing.Size(24, 24)
        Me.cmdBuscarPacientes.TabIndex = 2
        Me.cmdBuscarPacientes.Text = "..."
        '
        'rdbPaciente
        '
        Me.rdbPaciente.AutoSize = True
        Me.rdbPaciente.Location = New System.Drawing.Point(9, 54)
        Me.rdbPaciente.Name = "rdbPaciente"
        Me.rdbPaciente.Size = New System.Drawing.Size(73, 17)
        Me.rdbPaciente.TabIndex = 1
        Me.rdbPaciente.TabStop = True
        Me.rdbPaciente.Text = "Paciente"
        Me.rdbPaciente.UseVisualStyleBackColor = True
        '
        'dtpFecha
        '
        Me.dtpFecha.CustomFormat = "dd/MM/yyyy"
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha.Location = New System.Drawing.Point(448, 13)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(113, 21)
        Me.dtpFecha.TabIndex = 0
        '
        'txtPaciente
        '
        Me.txtPaciente.Location = New System.Drawing.Point(133, 53)
        Me.txtPaciente.MaxLength = 100
        Me.txtPaciente.Name = "txtPaciente"
        Me.txtPaciente.ReadOnly = True
        Me.txtPaciente.Size = New System.Drawing.Size(428, 21)
        Me.txtPaciente.TabIndex = 26
        '
        'txtNumFactura
        '
        Me.txtNumFactura.Location = New System.Drawing.Point(133, 14)
        Me.txtNumFactura.MaxLength = 9
        Me.txtNumFactura.Name = "txtNumFactura"
        Me.txtNumFactura.ReadOnly = True
        Me.txtNumFactura.Size = New System.Drawing.Size(170, 21)
        Me.txtNumFactura.TabIndex = 26
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(397, 17)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(45, 13)
        Me.lblFecha.TabIndex = 25
        Me.lblFecha.Text = "Fecha:"
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTratamiento
        '
        Me.lblTratamiento.AutoSize = True
        Me.lblTratamiento.Location = New System.Drawing.Point(46, 175)
        Me.lblTratamiento.Name = "lblTratamiento"
        Me.lblTratamiento.Size = New System.Drawing.Size(81, 13)
        Me.lblTratamiento.TabIndex = 25
        Me.lblTratamiento.Text = "Tratamiento:"
        Me.lblTratamiento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblImporte
        '
        Me.lblImporte.Location = New System.Drawing.Point(575, 108)
        Me.lblImporte.Name = "lblImporte"
        Me.lblImporte.Size = New System.Drawing.Size(93, 20)
        Me.lblImporte.TabIndex = 25
        Me.lblImporte.Text = "Importe:"
        Me.lblImporte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSesiones
        '
        Me.lblSesiones.AutoSize = True
        Me.lblSesiones.Location = New System.Drawing.Point(432, 134)
        Me.lblSesiones.Name = "lblSesiones"
        Me.lblSesiones.Size = New System.Drawing.Size(63, 13)
        Me.lblSesiones.TabIndex = 25
        Me.lblSesiones.Text = "Sesiones:"
        Me.lblSesiones.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNumFactura
        '
        Me.lblNumFactura.AutoSize = True
        Me.lblNumFactura.Location = New System.Drawing.Point(6, 17)
        Me.lblNumFactura.Name = "lblNumFactura"
        Me.lblNumFactura.Size = New System.Drawing.Size(121, 13)
        Me.lblNumFactura.TabIndex = 25
        Me.lblNumFactura.Text = "Número de Factura:"
        Me.lblNumFactura.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(575, 217)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(93, 32)
        Me.cmdCancelar.TabIndex = 10
        Me.cmdCancelar.Text = "Cancelar"
        Me.tipFacturas.SetToolTip(Me.cmdCancelar, "Cancelar la creación de una nueva Factura")
        '
        'frmFacturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCerrar
        Me.ClientSize = New System.Drawing.Size(703, 506)
        Me.Controls.Add(Me.grbFactura)
        Me.Controls.Add(Me.cmdGenerar)
        Me.Controls.Add(Me.cmdNueva)
        Me.Controls.Add(Me.cmdCerrar)
        Me.Controls.Add(Me.dtgFacturas)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmFacturacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturación"
        CType(Me.dtgFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbFactura.ResumeLayout(False)
        Me.grbFactura.PerformLayout()
        CType(Me.nudImporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSesiones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtgFacturas As System.Windows.Forms.DataGrid
    Friend WithEvents cmdGenerar As System.Windows.Forms.Button
    Friend WithEvents cmdNueva As System.Windows.Forms.Button
    Friend WithEvents cmdCerrar As System.Windows.Forms.Button
    Friend WithEvents errFacturas As System.Windows.Forms.ErrorProvider
    Friend WithEvents tipFacturas As System.Windows.Forms.ToolTip
    Friend WithEvents grbFactura As System.Windows.Forms.GroupBox
    Friend WithEvents cmdGuardar As System.Windows.Forms.Button
    Friend WithEvents lblNumFactura As System.Windows.Forms.Label
    Friend WithEvents txtNumFactura As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents rdbPaciente As System.Windows.Forms.RadioButton
    Friend WithEvents txtPaciente As System.Windows.Forms.TextBox
    Friend WithEvents cmdBuscarPacientes As System.Windows.Forms.Button
    Friend WithEvents rdbOtro As System.Windows.Forms.RadioButton
    Friend WithEvents txtTratamiento As System.Windows.Forms.TextBox
    Friend WithEvents nudSesiones As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblTratamiento As System.Windows.Forms.Label
    Friend WithEvents lblSesiones As System.Windows.Forms.Label
    Friend WithEvents lblIdentificacion As System.Windows.Forms.Label
    Friend WithEvents txtIdentificacion As System.Windows.Forms.TextBox
    Friend WithEvents txtOtro As System.Windows.Forms.TextBox
    Friend WithEvents nudImporte As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblImporte As System.Windows.Forms.Label
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
End Class
