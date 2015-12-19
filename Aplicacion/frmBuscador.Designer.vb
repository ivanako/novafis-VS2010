<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscador
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
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.lblNombre = New System.Windows.Forms.Label
        Me.lblApellido1 = New System.Windows.Forms.Label
        Me.txtApellido1 = New System.Windows.Forms.TextBox
        Me.lblApellido2 = New System.Windows.Forms.Label
        Me.txtApellido2 = New System.Windows.Forms.TextBox
        Me.lblIdentificacion = New System.Windows.Forms.Label
        Me.txtIdentificacion = New System.Windows.Forms.TextBox
        Me.lblIdClaro = New System.Windows.Forms.Label
        Me.lblTelefono = New System.Windows.Forms.Label
        Me.txtTelefono = New System.Windows.Forms.TextBox
        Me.lblConocer = New System.Windows.Forms.Label
        Me.txtConocer = New System.Windows.Forms.TextBox
        Me.cboFuentes = New System.Windows.Forms.ComboBox
        Me.lblFuente = New System.Windows.Forms.Label
        Me.dtgPacientes = New System.Windows.Forms.DataGrid
        Me.cmdCerrar = New System.Windows.Forms.Button
        Me.cmdBuscar = New System.Windows.Forms.Button
        Me.cmdPaciente = New System.Windows.Forms.Button
        CType(Me.dtgPacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(148, 9)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(476, 21)
        Me.txtNombre.TabIndex = 0
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(85, 12)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(57, 13)
        Me.lblNombre.TabIndex = 5
        Me.lblNombre.Text = "Nombre:"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblApellido1
        '
        Me.lblApellido1.AutoSize = True
        Me.lblApellido1.Location = New System.Drawing.Point(43, 44)
        Me.lblApellido1.Name = "lblApellido1"
        Me.lblApellido1.Size = New System.Drawing.Size(99, 13)
        Me.lblApellido1.TabIndex = 6
        Me.lblApellido1.Text = "Primer Apellido:"
        Me.lblApellido1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtApellido1
        '
        Me.txtApellido1.Location = New System.Drawing.Point(148, 41)
        Me.txtApellido1.MaxLength = 50
        Me.txtApellido1.Name = "txtApellido1"
        Me.txtApellido1.Size = New System.Drawing.Size(476, 21)
        Me.txtApellido1.TabIndex = 1
        '
        'lblApellido2
        '
        Me.lblApellido2.AutoSize = True
        Me.lblApellido2.Location = New System.Drawing.Point(31, 76)
        Me.lblApellido2.Name = "lblApellido2"
        Me.lblApellido2.Size = New System.Drawing.Size(111, 13)
        Me.lblApellido2.TabIndex = 4
        Me.lblApellido2.Text = "Segundo Apellido:"
        Me.lblApellido2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtApellido2
        '
        Me.txtApellido2.Location = New System.Drawing.Point(148, 73)
        Me.txtApellido2.MaxLength = 50
        Me.txtApellido2.Name = "txtApellido2"
        Me.txtApellido2.Size = New System.Drawing.Size(476, 21)
        Me.txtApellido2.TabIndex = 2
        '
        'lblIdentificacion
        '
        Me.lblIdentificacion.AutoSize = True
        Me.lblIdentificacion.Location = New System.Drawing.Point(54, 103)
        Me.lblIdentificacion.Name = "lblIdentificacion"
        Me.lblIdentificacion.Size = New System.Drawing.Size(88, 13)
        Me.lblIdentificacion.TabIndex = 11
        Me.lblIdentificacion.Text = "Identificación:"
        Me.lblIdentificacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtIdentificacion
        '
        Me.txtIdentificacion.Location = New System.Drawing.Point(148, 108)
        Me.txtIdentificacion.MaxLength = 20
        Me.txtIdentificacion.Name = "txtIdentificacion"
        Me.txtIdentificacion.Size = New System.Drawing.Size(209, 21)
        Me.txtIdentificacion.TabIndex = 3
        '
        'lblIdClaro
        '
        Me.lblIdClaro.AutoSize = True
        Me.lblIdClaro.Location = New System.Drawing.Point(29, 116)
        Me.lblIdClaro.Name = "lblIdClaro"
        Me.lblIdClaro.Size = New System.Drawing.Size(113, 13)
        Me.lblIdClaro.TabIndex = 10
        Me.lblIdClaro.Text = "(N.I.F., Pasaporte)"
        Me.lblIdClaro.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(437, 111)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(61, 13)
        Me.lblTelefono.TabIndex = 13
        Me.lblTelefono.Text = "Teléfono:"
        Me.lblTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(504, 108)
        Me.txtTelefono.MaxLength = 20
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(120, 21)
        Me.txtTelefono.TabIndex = 4
        '
        'lblConocer
        '
        Me.lblConocer.AutoSize = True
        Me.lblConocer.Location = New System.Drawing.Point(18, 144)
        Me.lblConocer.Name = "lblConocer"
        Me.lblConocer.Size = New System.Drawing.Size(124, 13)
        Me.lblConocer.TabIndex = 15
        Me.lblConocer.Text = "¿Cómo nos conoció?"
        Me.lblConocer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtConocer
        '
        Me.txtConocer.Location = New System.Drawing.Point(148, 144)
        Me.txtConocer.MaxLength = 100
        Me.txtConocer.Multiline = True
        Me.txtConocer.Name = "txtConocer"
        Me.txtConocer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtConocer.Size = New System.Drawing.Size(476, 64)
        Me.txtConocer.TabIndex = 5
        '
        'cboFuentes
        '
        Me.cboFuentes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFuentes.Location = New System.Drawing.Point(148, 223)
        Me.cboFuentes.MaxDropDownItems = 10
        Me.cboFuentes.Name = "cboFuentes"
        Me.cboFuentes.Size = New System.Drawing.Size(476, 21)
        Me.cboFuentes.TabIndex = 6
        '
        'lblFuente
        '
        Me.lblFuente.AutoSize = True
        Me.lblFuente.Location = New System.Drawing.Point(90, 226)
        Me.lblFuente.Name = "lblFuente"
        Me.lblFuente.Size = New System.Drawing.Size(50, 13)
        Me.lblFuente.TabIndex = 17
        Me.lblFuente.Text = "Fuente:"
        Me.lblFuente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtgPacientes
        '
        Me.dtgPacientes.CaptionText = "Pacientes"
        Me.dtgPacientes.DataMember = ""
        Me.dtgPacientes.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dtgPacientes.Location = New System.Drawing.Point(12, 264)
        Me.dtgPacientes.Name = "dtgPacientes"
        Me.dtgPacientes.ReadOnly = True
        Me.dtgPacientes.Size = New System.Drawing.Size(504, 200)
        Me.dtgPacientes.TabIndex = 19
        Me.dtgPacientes.TabStop = False
        '
        'cmdCerrar
        '
        Me.cmdCerrar.Location = New System.Drawing.Point(531, 432)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(93, 32)
        Me.cmdCerrar.TabIndex = 9
        Me.cmdCerrar.Text = "Cerrar"
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Location = New System.Drawing.Point(531, 264)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(93, 34)
        Me.cmdBuscar.TabIndex = 7
        Me.cmdBuscar.Text = "Buscar"
        '
        'cmdPaciente
        '
        Me.cmdPaciente.Enabled = False
        Me.cmdPaciente.Location = New System.Drawing.Point(531, 313)
        Me.cmdPaciente.Name = "cmdPaciente"
        Me.cmdPaciente.Size = New System.Drawing.Size(93, 34)
        Me.cmdPaciente.TabIndex = 8
        Me.cmdPaciente.Text = "Paciente..."
        '
        'frmBuscador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 494)
        Me.Controls.Add(Me.cmdCerrar)
        Me.Controls.Add(Me.cmdPaciente)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.dtgPacientes)
        Me.Controls.Add(Me.cboFuentes)
        Me.Controls.Add(Me.lblFuente)
        Me.Controls.Add(Me.lblConocer)
        Me.Controls.Add(Me.txtConocer)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.lblIdentificacion)
        Me.Controls.Add(Me.txtIdentificacion)
        Me.Controls.Add(Me.lblIdClaro)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblApellido1)
        Me.Controls.Add(Me.txtApellido1)
        Me.Controls.Add(Me.lblApellido2)
        Me.Controls.Add(Me.txtApellido2)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmBuscador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscador de Pacientes"
        CType(Me.dtgPacientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblApellido1 As System.Windows.Forms.Label
    Friend WithEvents txtApellido1 As System.Windows.Forms.TextBox
    Friend WithEvents lblApellido2 As System.Windows.Forms.Label
    Friend WithEvents txtApellido2 As System.Windows.Forms.TextBox
    Friend WithEvents lblIdentificacion As System.Windows.Forms.Label
    Friend WithEvents txtIdentificacion As System.Windows.Forms.TextBox
    Friend WithEvents lblIdClaro As System.Windows.Forms.Label
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents lblConocer As System.Windows.Forms.Label
    Friend WithEvents txtConocer As System.Windows.Forms.TextBox
    Friend WithEvents cboFuentes As System.Windows.Forms.ComboBox
    Friend WithEvents lblFuente As System.Windows.Forms.Label
    Friend WithEvents dtgPacientes As System.Windows.Forms.DataGrid
    Friend WithEvents cmdCerrar As System.Windows.Forms.Button
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents cmdPaciente As System.Windows.Forms.Button
End Class
