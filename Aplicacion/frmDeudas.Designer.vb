<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeudas
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
        Me.dtgDeudas = New System.Windows.Forms.DataGrid
        Me.dtpFechaRef = New System.Windows.Forms.DateTimePicker
        Me.lblFechaRef = New System.Windows.Forms.Label
        Me.cmdCerrar = New System.Windows.Forms.Button
        CType(Me.dtgDeudas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgDeudas
        '
        Me.dtgDeudas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgDeudas.CaptionText = "Deudas pendientes"
        Me.dtgDeudas.DataMember = ""
        Me.dtgDeudas.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dtgDeudas.Location = New System.Drawing.Point(12, 41)
        Me.dtgDeudas.Name = "dtgDeudas"
        Me.dtgDeudas.ReadOnly = True
        Me.dtgDeudas.Size = New System.Drawing.Size(540, 237)
        Me.dtgDeudas.TabIndex = 1
        Me.dtgDeudas.TabStop = False
        '
        'dtpFechaRef
        '
        Me.dtpFechaRef.CustomFormat = "dd/MM/yyyy"
        Me.dtpFechaRef.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaRef.Location = New System.Drawing.Point(143, 5)
        Me.dtpFechaRef.Name = "dtpFechaRef"
        Me.dtpFechaRef.Size = New System.Drawing.Size(100, 21)
        Me.dtpFechaRef.TabIndex = 2
        '
        'lblFechaRef
        '
        Me.lblFechaRef.AutoSize = True
        Me.lblFechaRef.Location = New System.Drawing.Point(12, 9)
        Me.lblFechaRef.Name = "lblFechaRef"
        Me.lblFechaRef.Size = New System.Drawing.Size(125, 13)
        Me.lblFechaRef.TabIndex = 3
        Me.lblFechaRef.Text = "Fecha de referencia:"
        '
        'cmdCerrar
        '
        Me.cmdCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCerrar.Location = New System.Drawing.Point(459, 298)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(93, 32)
        Me.cmdCerrar.TabIndex = 4
        Me.cmdCerrar.Text = "Cerrar"
        '
        'frmDeudas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 342)
        Me.Controls.Add(Me.cmdCerrar)
        Me.Controls.Add(Me.lblFechaRef)
        Me.Controls.Add(Me.dtpFechaRef)
        Me.Controls.Add(Me.dtgDeudas)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmDeudas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Deudas pendientes"
        CType(Me.dtgDeudas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtgDeudas As System.Windows.Forms.DataGrid
    Friend WithEvents dtpFechaRef As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaRef As System.Windows.Forms.Label
    Friend WithEvents cmdCerrar As System.Windows.Forms.Button
End Class
