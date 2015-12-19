<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFisioterapeutas
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
        Me.dtgFisios = New System.Windows.Forms.DataGrid
        Me.cmdCerrar = New System.Windows.Forms.Button
        Me.cmdNuevo = New System.Windows.Forms.Button
        Me.tipFisios = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdEliminar = New System.Windows.Forms.Button
        Me.cmdGuardar = New System.Windows.Forms.Button
        Me.cmdModificar = New System.Windows.Forms.Button
        Me.grbFisio = New System.Windows.Forms.GroupBox
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.grbSexo = New System.Windows.Forms.GroupBox
        Me.rdbHombre = New System.Windows.Forms.RadioButton
        Me.rdbMujer = New System.Windows.Forms.RadioButton
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.lblNombre = New System.Windows.Forms.Label
        Me.lblApellido1 = New System.Windows.Forms.Label
        Me.txtApellido1 = New System.Windows.Forms.TextBox
        Me.lblApellido2 = New System.Windows.Forms.Label
        Me.txtApellido2 = New System.Windows.Forms.TextBox
        Me.lblAlias = New System.Windows.Forms.Label
        Me.lblNumColegiado = New System.Windows.Forms.Label
        Me.lblIdentificacion = New System.Windows.Forms.Label
        Me.txtAlias = New System.Windows.Forms.TextBox
        Me.txtNumColegiado = New System.Windows.Forms.TextBox
        Me.txtIdentificacion = New System.Windows.Forms.TextBox
        Me.lblIdClaro = New System.Windows.Forms.Label
        Me.lblFBaja = New System.Windows.Forms.Label
        Me.lblFAlta = New System.Windows.Forms.Label
        Me.dtpFBaja = New System.Windows.Forms.DateTimePicker
        Me.dtpFAlta = New System.Windows.Forms.DateTimePicker
        Me.errFisios = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.dtgFisios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbFisio.SuspendLayout()
        Me.grbSexo.SuspendLayout()
        CType(Me.errFisios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgFisios
        '
        Me.dtgFisios.CaptionText = "Fisioterapeutas"
        Me.dtgFisios.DataMember = ""
        Me.dtgFisios.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dtgFisios.Location = New System.Drawing.Point(12, 12)
        Me.dtgFisios.Name = "dtgFisios"
        Me.dtgFisios.ReadOnly = True
        Me.dtgFisios.Size = New System.Drawing.Size(519, 200)
        Me.dtgFisios.TabIndex = 0
        Me.dtgFisios.TabStop = False
        '
        'cmdCerrar
        '
        Me.cmdCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCerrar.Location = New System.Drawing.Point(537, 180)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(93, 32)
        Me.cmdCerrar.TabIndex = 4
        Me.cmdCerrar.Text = "Cerrar"
        Me.tipFisios.SetToolTip(Me.cmdCerrar, "Cerrar ventana de Fisioterapeutas")
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Location = New System.Drawing.Point(537, 12)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(93, 32)
        Me.cmdNuevo.TabIndex = 1
        Me.cmdNuevo.Text = "Nuevo"
        Me.tipFisios.SetToolTip(Me.cmdNuevo, "Registrar nuevo Fisioterapeuta")
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Enabled = False
        Me.cmdEliminar.Location = New System.Drawing.Point(537, 88)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(93, 32)
        Me.cmdEliminar.TabIndex = 3
        Me.cmdEliminar.Text = "Eliminar"
        Me.tipFisios.SetToolTip(Me.cmdEliminar, "Eliminar Fisioterapeuta existente")
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Location = New System.Drawing.Point(510, 246)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(93, 32)
        Me.cmdGuardar.TabIndex = 10
        Me.cmdGuardar.Text = "Guardar"
        Me.tipFisios.SetToolTip(Me.cmdGuardar, "Guardar los cambios del Fisioterapeuta seleccionado")
        '
        'cmdModificar
        '
        Me.cmdModificar.Enabled = False
        Me.cmdModificar.Location = New System.Drawing.Point(537, 50)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(93, 32)
        Me.cmdModificar.TabIndex = 2
        Me.cmdModificar.Text = "Modificar"
        Me.tipFisios.SetToolTip(Me.cmdModificar, "Modificar Fisioterapeuta existente")
        '
        'grbFisio
        '
        Me.grbFisio.Controls.Add(Me.cmdCancelar)
        Me.grbFisio.Controls.Add(Me.cmdGuardar)
        Me.grbFisio.Controls.Add(Me.grbSexo)
        Me.grbFisio.Controls.Add(Me.txtNombre)
        Me.grbFisio.Controls.Add(Me.lblNombre)
        Me.grbFisio.Controls.Add(Me.lblApellido1)
        Me.grbFisio.Controls.Add(Me.txtApellido1)
        Me.grbFisio.Controls.Add(Me.lblApellido2)
        Me.grbFisio.Controls.Add(Me.txtApellido2)
        Me.grbFisio.Controls.Add(Me.lblAlias)
        Me.grbFisio.Controls.Add(Me.lblNumColegiado)
        Me.grbFisio.Controls.Add(Me.lblIdentificacion)
        Me.grbFisio.Controls.Add(Me.txtAlias)
        Me.grbFisio.Controls.Add(Me.txtNumColegiado)
        Me.grbFisio.Controls.Add(Me.txtIdentificacion)
        Me.grbFisio.Controls.Add(Me.lblIdClaro)
        Me.grbFisio.Controls.Add(Me.lblFBaja)
        Me.grbFisio.Controls.Add(Me.lblFAlta)
        Me.grbFisio.Controls.Add(Me.dtpFBaja)
        Me.grbFisio.Controls.Add(Me.dtpFAlta)
        Me.grbFisio.Location = New System.Drawing.Point(12, 228)
        Me.grbFisio.Name = "grbFisio"
        Me.grbFisio.Size = New System.Drawing.Size(618, 298)
        Me.grbFisio.TabIndex = 5
        Me.grbFisio.TabStop = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(396, 246)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(93, 32)
        Me.cmdCancelar.TabIndex = 9
        Me.cmdCancelar.Text = "Cancelar"
        '
        'grbSexo
        '
        Me.grbSexo.Controls.Add(Me.rdbHombre)
        Me.grbSexo.Controls.Add(Me.rdbMujer)
        Me.grbSexo.Location = New System.Drawing.Point(353, 177)
        Me.grbSexo.Name = "grbSexo"
        Me.grbSexo.Size = New System.Drawing.Size(250, 48)
        Me.grbSexo.TabIndex = 7
        Me.grbSexo.TabStop = False
        Me.grbSexo.Text = " Sexo "
        '
        'rdbHombre
        '
        Me.rdbHombre.Location = New System.Drawing.Point(41, 19)
        Me.rdbHombre.Name = "rdbHombre"
        Me.rdbHombre.Size = New System.Drawing.Size(84, 16)
        Me.rdbHombre.TabIndex = 0
        Me.rdbHombre.Text = "Hombre"
        '
        'rdbMujer
        '
        Me.rdbMujer.Location = New System.Drawing.Point(147, 17)
        Me.rdbMujer.Name = "rdbMujer"
        Me.rdbMujer.Size = New System.Drawing.Size(65, 21)
        Me.rdbMujer.TabIndex = 1
        Me.rdbMujer.Text = "Mujer"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(148, 15)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(455, 21)
        Me.txtNombre.TabIndex = 0
        '
        'lblNombre
        '
        Me.lblNombre.Location = New System.Drawing.Point(8, 15)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(131, 16)
        Me.lblNombre.TabIndex = 24
        Me.lblNombre.Text = "Nombre:"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblApellido1
        '
        Me.lblApellido1.Location = New System.Drawing.Point(8, 47)
        Me.lblApellido1.Name = "lblApellido1"
        Me.lblApellido1.Size = New System.Drawing.Size(131, 16)
        Me.lblApellido1.TabIndex = 19
        Me.lblApellido1.Text = "Primer Apellido:"
        Me.lblApellido1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtApellido1
        '
        Me.txtApellido1.Location = New System.Drawing.Point(148, 47)
        Me.txtApellido1.MaxLength = 50
        Me.txtApellido1.Name = "txtApellido1"
        Me.txtApellido1.Size = New System.Drawing.Size(455, 21)
        Me.txtApellido1.TabIndex = 1
        '
        'lblApellido2
        '
        Me.lblApellido2.Location = New System.Drawing.Point(8, 79)
        Me.lblApellido2.Name = "lblApellido2"
        Me.lblApellido2.Size = New System.Drawing.Size(131, 16)
        Me.lblApellido2.TabIndex = 23
        Me.lblApellido2.Text = "Segundo Apellido:"
        Me.lblApellido2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtApellido2
        '
        Me.txtApellido2.Location = New System.Drawing.Point(148, 79)
        Me.txtApellido2.MaxLength = 50
        Me.txtApellido2.Name = "txtApellido2"
        Me.txtApellido2.Size = New System.Drawing.Size(455, 21)
        Me.txtApellido2.TabIndex = 2
        '
        'lblAlias
        '
        Me.lblAlias.Location = New System.Drawing.Point(350, 128)
        Me.lblAlias.Name = "lblAlias"
        Me.lblAlias.Size = New System.Drawing.Size(44, 20)
        Me.lblAlias.TabIndex = 20
        Me.lblAlias.Text = "Alias:"
        Me.lblAlias.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNumColegiado
        '
        Me.lblNumColegiado.Location = New System.Drawing.Point(48, 246)
        Me.lblNumColegiado.Name = "lblNumColegiado"
        Me.lblNumColegiado.Size = New System.Drawing.Size(91, 33)
        Me.lblNumColegiado.TabIndex = 22
        Me.lblNumColegiado.Text = "Número de Colegiado:"
        Me.lblNumColegiado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblIdentificacion
        '
        Me.lblIdentificacion.Location = New System.Drawing.Point(8, 130)
        Me.lblIdentificacion.Name = "lblIdentificacion"
        Me.lblIdentificacion.Size = New System.Drawing.Size(131, 16)
        Me.lblIdentificacion.TabIndex = 21
        Me.lblIdentificacion.Text = "Identificación:"
        Me.lblIdentificacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAlias
        '
        Me.txtAlias.Location = New System.Drawing.Point(400, 129)
        Me.txtAlias.MaxLength = 50
        Me.txtAlias.Name = "txtAlias"
        Me.txtAlias.Size = New System.Drawing.Size(203, 21)
        Me.txtAlias.TabIndex = 4
        '
        'txtNumColegiado
        '
        Me.txtNumColegiado.Location = New System.Drawing.Point(148, 253)
        Me.txtNumColegiado.MaxLength = 50
        Me.txtNumColegiado.Name = "txtNumColegiado"
        Me.txtNumColegiado.Size = New System.Drawing.Size(177, 21)
        Me.txtNumColegiado.TabIndex = 8
        '
        'txtIdentificacion
        '
        Me.txtIdentificacion.Location = New System.Drawing.Point(148, 129)
        Me.txtIdentificacion.MaxLength = 20
        Me.txtIdentificacion.Name = "txtIdentificacion"
        Me.txtIdentificacion.Size = New System.Drawing.Size(177, 21)
        Me.txtIdentificacion.TabIndex = 3
        '
        'lblIdClaro
        '
        Me.lblIdClaro.Location = New System.Drawing.Point(8, 146)
        Me.lblIdClaro.Name = "lblIdClaro"
        Me.lblIdClaro.Size = New System.Drawing.Size(131, 16)
        Me.lblIdClaro.TabIndex = 26
        Me.lblIdClaro.Text = "(N.I.F., Pasaporte)"
        Me.lblIdClaro.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFBaja
        '
        Me.lblFBaja.Location = New System.Drawing.Point(8, 209)
        Me.lblFBaja.Name = "lblFBaja"
        Me.lblFBaja.Size = New System.Drawing.Size(131, 16)
        Me.lblFBaja.TabIndex = 25
        Me.lblFBaja.Text = "Fecha Baja:"
        Me.lblFBaja.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFAlta
        '
        Me.lblFAlta.Location = New System.Drawing.Point(8, 179)
        Me.lblFAlta.Name = "lblFAlta"
        Me.lblFAlta.Size = New System.Drawing.Size(131, 16)
        Me.lblFAlta.TabIndex = 25
        Me.lblFAlta.Text = "Fecha Alta:"
        Me.lblFAlta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpFBaja
        '
        Me.dtpFBaja.Checked = False
        Me.dtpFBaja.CustomFormat = "dd/MM/yyyy"
        Me.dtpFBaja.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFBaja.Location = New System.Drawing.Point(148, 207)
        Me.dtpFBaja.Name = "dtpFBaja"
        Me.dtpFBaja.ShowCheckBox = True
        Me.dtpFBaja.Size = New System.Drawing.Size(177, 21)
        Me.dtpFBaja.TabIndex = 6
        '
        'dtpFAlta
        '
        Me.dtpFAlta.CustomFormat = "dd/MM/yyyy"
        Me.dtpFAlta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFAlta.Location = New System.Drawing.Point(148, 179)
        Me.dtpFAlta.Name = "dtpFAlta"
        Me.dtpFAlta.Size = New System.Drawing.Size(177, 21)
        Me.dtpFAlta.TabIndex = 5
        '
        'errFisios
        '
        Me.errFisios.ContainerControl = Me
        '
        'frmFisioterapeutas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCerrar
        Me.ClientSize = New System.Drawing.Size(639, 538)
        Me.Controls.Add(Me.grbFisio)
        Me.Controls.Add(Me.cmdModificar)
        Me.Controls.Add(Me.cmdEliminar)
        Me.Controls.Add(Me.cmdNuevo)
        Me.Controls.Add(Me.cmdCerrar)
        Me.Controls.Add(Me.dtgFisios)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmFisioterapeutas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión de Fisioterapeutas"
        CType(Me.dtgFisios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbFisio.ResumeLayout(False)
        Me.grbFisio.PerformLayout()
        Me.grbSexo.ResumeLayout(False)
        CType(Me.errFisios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtgFisios As System.Windows.Forms.DataGrid
    Friend WithEvents cmdCerrar As System.Windows.Forms.Button
    Friend WithEvents cmdNuevo As System.Windows.Forms.Button
    Friend WithEvents tipFisios As System.Windows.Forms.ToolTip
    Friend WithEvents cmdEliminar As System.Windows.Forms.Button
    Friend WithEvents grbFisio As System.Windows.Forms.GroupBox
    Friend WithEvents grbSexo As System.Windows.Forms.GroupBox
    Friend WithEvents rdbHombre As System.Windows.Forms.RadioButton
    Friend WithEvents rdbMujer As System.Windows.Forms.RadioButton
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblApellido1 As System.Windows.Forms.Label
    Friend WithEvents txtApellido1 As System.Windows.Forms.TextBox
    Friend WithEvents lblApellido2 As System.Windows.Forms.Label
    Friend WithEvents txtApellido2 As System.Windows.Forms.TextBox
    Friend WithEvents lblAlias As System.Windows.Forms.Label
    Friend WithEvents lblNumColegiado As System.Windows.Forms.Label
    Friend WithEvents lblIdentificacion As System.Windows.Forms.Label
    Friend WithEvents txtAlias As System.Windows.Forms.TextBox
    Friend WithEvents txtNumColegiado As System.Windows.Forms.TextBox
    Friend WithEvents txtIdentificacion As System.Windows.Forms.TextBox
    Friend WithEvents lblIdClaro As System.Windows.Forms.Label
    Friend WithEvents lblFAlta As System.Windows.Forms.Label
    Friend WithEvents dtpFAlta As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmdGuardar As System.Windows.Forms.Button
    Friend WithEvents errFisios As System.Windows.Forms.ErrorProvider
    Friend WithEvents cmdModificar As System.Windows.Forms.Button
    Friend WithEvents lblFBaja As System.Windows.Forms.Label
    Friend WithEvents dtpFBaja As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
End Class
