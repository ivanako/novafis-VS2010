<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFuentes
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
        Me.errFuentes = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.grbFuente = New System.Windows.Forms.GroupBox
        Me.cmdGuardar = New System.Windows.Forms.Button
        Me.txtFuente = New System.Windows.Forms.TextBox
        Me.lblFuente = New System.Windows.Forms.Label
        Me.cmdModificar = New System.Windows.Forms.Button
        Me.cmdEliminar = New System.Windows.Forms.Button
        Me.cmdNuevo = New System.Windows.Forms.Button
        Me.cmdCerrar = New System.Windows.Forms.Button
        Me.tipFuentes = New System.Windows.Forms.ToolTip(Me.components)
        Me.dtgFuentes = New System.Windows.Forms.DataGrid
        CType(Me.errFuentes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbFuente.SuspendLayout()
        CType(Me.dtgFuentes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'errFuentes
        '
        Me.errFuentes.ContainerControl = Me
        '
        'grbFuente
        '
        Me.grbFuente.Controls.Add(Me.cmdGuardar)
        Me.grbFuente.Controls.Add(Me.txtFuente)
        Me.grbFuente.Controls.Add(Me.lblFuente)
        Me.grbFuente.Location = New System.Drawing.Point(14, 239)
        Me.grbFuente.Name = "grbFuente"
        Me.grbFuente.Size = New System.Drawing.Size(593, 99)
        Me.grbFuente.TabIndex = 11
        Me.grbFuente.TabStop = False
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Location = New System.Drawing.Point(494, 51)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(93, 32)
        Me.cmdGuardar.TabIndex = 8
        Me.cmdGuardar.Text = "Guardar"
        Me.tipFuentes.SetToolTip(Me.cmdGuardar, "Guardar los cambios de la Fuente seleccionada")
        '
        'txtFuente
        '
        Me.txtFuente.Location = New System.Drawing.Point(65, 18)
        Me.txtFuente.MaxLength = 100
        Me.txtFuente.Name = "txtFuente"
        Me.txtFuente.Size = New System.Drawing.Size(522, 21)
        Me.txtFuente.TabIndex = 0
        '
        'lblFuente
        '
        Me.lblFuente.AutoSize = True
        Me.lblFuente.Location = New System.Drawing.Point(9, 21)
        Me.lblFuente.Name = "lblFuente"
        Me.lblFuente.Size = New System.Drawing.Size(50, 13)
        Me.lblFuente.TabIndex = 24
        Me.lblFuente.Text = "Fuente:"
        Me.lblFuente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdModificar
        '
        Me.cmdModificar.Enabled = False
        Me.cmdModificar.Location = New System.Drawing.Point(514, 61)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(93, 32)
        Me.cmdModificar.TabIndex = 8
        Me.cmdModificar.Text = "Modificar"
        Me.tipFuentes.SetToolTip(Me.cmdModificar, "Modificar Fuente existente")
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Enabled = False
        Me.cmdEliminar.Location = New System.Drawing.Point(514, 99)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(93, 32)
        Me.cmdEliminar.TabIndex = 9
        Me.cmdEliminar.Text = "Eliminar"
        Me.tipFuentes.SetToolTip(Me.cmdEliminar, "Eliminar Fuente existente")
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Location = New System.Drawing.Point(514, 23)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(93, 32)
        Me.cmdNuevo.TabIndex = 7
        Me.cmdNuevo.Text = "Nuevo"
        Me.tipFuentes.SetToolTip(Me.cmdNuevo, "Registrar nueva Fuente")
        '
        'cmdCerrar
        '
        Me.cmdCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCerrar.Location = New System.Drawing.Point(514, 191)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(93, 32)
        Me.cmdCerrar.TabIndex = 10
        Me.cmdCerrar.Text = "Cerrar"
        Me.tipFuentes.SetToolTip(Me.cmdCerrar, "Cerrar ventana de Fuentes")
        '
        'dtgFuentes
        '
        Me.dtgFuentes.CaptionText = "Fuentes"
        Me.dtgFuentes.DataMember = ""
        Me.dtgFuentes.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dtgFuentes.Location = New System.Drawing.Point(14, 23)
        Me.dtgFuentes.Name = "dtgFuentes"
        Me.dtgFuentes.ReadOnly = True
        Me.dtgFuentes.Size = New System.Drawing.Size(485, 200)
        Me.dtgFuentes.TabIndex = 6
        Me.dtgFuentes.TabStop = False
        '
        'frmFuentes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 359)
        Me.Controls.Add(Me.grbFuente)
        Me.Controls.Add(Me.cmdModificar)
        Me.Controls.Add(Me.cmdEliminar)
        Me.Controls.Add(Me.cmdNuevo)
        Me.Controls.Add(Me.cmdCerrar)
        Me.Controls.Add(Me.dtgFuentes)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmFuentes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fuentes disponibles"
        CType(Me.errFuentes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbFuente.ResumeLayout(False)
        Me.grbFuente.PerformLayout()
        CType(Me.dtgFuentes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents errFuentes As System.Windows.Forms.ErrorProvider
    Friend WithEvents grbFuente As System.Windows.Forms.GroupBox
    Friend WithEvents cmdGuardar As System.Windows.Forms.Button
    Friend WithEvents tipFuentes As System.Windows.Forms.ToolTip
    Friend WithEvents txtFuente As System.Windows.Forms.TextBox
    Friend WithEvents lblFuente As System.Windows.Forms.Label
    Friend WithEvents cmdModificar As System.Windows.Forms.Button
    Friend WithEvents cmdEliminar As System.Windows.Forms.Button
    Friend WithEvents cmdNuevo As System.Windows.Forms.Button
    Friend WithEvents cmdCerrar As System.Windows.Forms.Button
    Friend WithEvents dtgFuentes As System.Windows.Forms.DataGrid
End Class
