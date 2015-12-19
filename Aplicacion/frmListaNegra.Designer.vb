<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaNegra
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.dtgListaNegra = New System.Windows.Forms.DataGrid()
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.cmdAnadir = New System.Windows.Forms.Button()
        Me.tipListaNegra = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdCerrar = New System.Windows.Forms.Button()
        Me.grbPaciente = New System.Windows.Forms.GroupBox()
        Me.lblPaciente = New System.Windows.Forms.Label()
        Me.txtPacientes = New System.Windows.Forms.TextBox()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdGuardar = New System.Windows.Forms.Button()
        CType(Me.dtgListaNegra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbPaciente.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtgListaNegra
        '
        Me.dtgListaNegra.CaptionText = "Lista negra"
        Me.dtgListaNegra.DataMember = ""
        Me.dtgListaNegra.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dtgListaNegra.Location = New System.Drawing.Point(12, 12)
        Me.dtgListaNegra.Name = "dtgListaNegra"
        Me.dtgListaNegra.ReadOnly = True
        Me.dtgListaNegra.Size = New System.Drawing.Size(566, 360)
        Me.dtgListaNegra.TabIndex = 1
        Me.dtgListaNegra.TabStop = False
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Enabled = False
        Me.cmdEliminar.Location = New System.Drawing.Point(608, 50)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(93, 32)
        Me.cmdEliminar.TabIndex = 4
        Me.cmdEliminar.Text = "Eliminar"
        Me.tipListaNegra.SetToolTip(Me.cmdEliminar, "Eliminar un Paciente de la Lista Negra")
        '
        'cmdAnadir
        '
        Me.cmdAnadir.Location = New System.Drawing.Point(608, 12)
        Me.cmdAnadir.Name = "cmdAnadir"
        Me.cmdAnadir.Size = New System.Drawing.Size(93, 32)
        Me.cmdAnadir.TabIndex = 3
        Me.cmdAnadir.Text = "Añadir"
        Me.tipListaNegra.SetToolTip(Me.cmdAnadir, "Añadir un Paciente a la Lista Negra")
        '
        'cmdCerrar
        '
        Me.cmdCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCerrar.Location = New System.Drawing.Point(608, 340)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(93, 32)
        Me.cmdCerrar.TabIndex = 5
        Me.cmdCerrar.Text = "Cerrar"
        Me.tipListaNegra.SetToolTip(Me.cmdCerrar, "Cerrar formulario de Lista Negra")
        '
        'grbPaciente
        '
        Me.grbPaciente.Controls.Add(Me.cmdGuardar)
        Me.grbPaciente.Controls.Add(Me.cmdCancelar)
        Me.grbPaciente.Controls.Add(Me.txtPacientes)
        Me.grbPaciente.Controls.Add(Me.lblPaciente)
        Me.grbPaciente.Location = New System.Drawing.Point(12, 399)
        Me.grbPaciente.Name = "grbPaciente"
        Me.grbPaciente.Size = New System.Drawing.Size(566, 114)
        Me.grbPaciente.TabIndex = 8
        Me.grbPaciente.TabStop = False
        '
        'lblPaciente
        '
        Me.lblPaciente.AutoSize = True
        Me.lblPaciente.Location = New System.Drawing.Point(6, 33)
        Me.lblPaciente.Name = "lblPaciente"
        Me.lblPaciente.Size = New System.Drawing.Size(55, 13)
        Me.lblPaciente.TabIndex = 7
        Me.lblPaciente.Text = "Paciente"
        '
        'txtPacientes
        '
        Me.txtPacientes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtPacientes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtPacientes.Location = New System.Drawing.Point(67, 30)
        Me.txtPacientes.Name = "txtPacientes"
        Me.txtPacientes.Size = New System.Drawing.Size(466, 21)
        Me.txtPacientes.TabIndex = 8
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(440, 57)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(93, 32)
        Me.cmdCancelar.TabIndex = 9
        Me.cmdCancelar.Text = "Cancelar"
        Me.tipListaNegra.SetToolTip(Me.cmdCancelar, "Abortar la acción de Añadir Paciente a la lista negra")
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Location = New System.Drawing.Point(341, 57)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(93, 32)
        Me.cmdGuardar.TabIndex = 10
        Me.cmdGuardar.Text = "Guardar"
        Me.tipListaNegra.SetToolTip(Me.cmdGuardar, "Guardar Paciente en la lista negra")
        '
        'frmListaNegra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCerrar
        Me.ClientSize = New System.Drawing.Size(722, 537)
        Me.Controls.Add(Me.grbPaciente)
        Me.Controls.Add(Me.cmdCerrar)
        Me.Controls.Add(Me.cmdEliminar)
        Me.Controls.Add(Me.cmdAnadir)
        Me.Controls.Add(Me.dtgListaNegra)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmListaNegra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista negra"
        CType(Me.dtgListaNegra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbPaciente.ResumeLayout(False)
        Me.grbPaciente.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtgListaNegra As System.Windows.Forms.DataGrid
    Friend WithEvents cmdEliminar As System.Windows.Forms.Button
    Friend WithEvents cmdAnadir As System.Windows.Forms.Button
    Friend WithEvents tipListaNegra As System.Windows.Forms.ToolTip
    Friend WithEvents cmdCerrar As System.Windows.Forms.Button
    Friend WithEvents grbPaciente As System.Windows.Forms.GroupBox
    Friend WithEvents cmdGuardar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents txtPacientes As System.Windows.Forms.TextBox
    Friend WithEvents lblPaciente As System.Windows.Forms.Label
End Class
