Option Strict On
Option Explicit On 

Public Class frmBuscarPacientes

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
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents cmdNuevo As System.Windows.Forms.Button
    Friend WithEvents txtPaciente As System.Windows.Forms.TextBox
    Friend WithEvents lblPaciente As System.Windows.Forms.Label
    Friend WithEvents lvwPacientes As System.Windows.Forms.ListView
    Friend WithEvents dgvPacientes As System.Windows.Forms.DataGridView
    Friend WithEvents tipBuscarPacientes As System.Windows.Forms.ToolTip
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.tipBuscarPacientes = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtPaciente = New System.Windows.Forms.TextBox()
        Me.lblPaciente = New System.Windows.Forms.Label()
        Me.lvwPacientes = New System.Windows.Forms.ListView()
        Me.dgvPacientes = New System.Windows.Forms.DataGridView()
        CType(Me.dgvPacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(422, 256)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(80, 32)
        Me.cmdCancelar.TabIndex = 7
        Me.cmdCancelar.Text = "Cancelar"
        Me.tipBuscarPacientes.SetToolTip(Me.cmdCancelar, "Cerrar ventana actual")
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Enabled = False
        Me.cmdAceptar.Location = New System.Drawing.Point(422, 216)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(80, 32)
        Me.cmdAceptar.TabIndex = 7
        Me.cmdAceptar.Text = "Aceptar"
        Me.tipBuscarPacientes.SetToolTip(Me.cmdAceptar, "Establecer Paciente para la Cita")
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Location = New System.Drawing.Point(422, 40)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(80, 32)
        Me.cmdNuevo.TabIndex = 7
        Me.cmdNuevo.Text = "Nuevo..."
        Me.tipBuscarPacientes.SetToolTip(Me.cmdNuevo, "Crear nuevo Paciente")
        '
        'txtPaciente
        '
        Me.txtPaciente.Location = New System.Drawing.Point(69, 12)
        Me.txtPaciente.MaxLength = 50
        Me.txtPaciente.Name = "txtPaciente"
        Me.txtPaciente.Size = New System.Drawing.Size(337, 21)
        Me.txtPaciente.TabIndex = 11
        '
        'lblPaciente
        '
        Me.lblPaciente.AutoSize = True
        Me.lblPaciente.Location = New System.Drawing.Point(3, 15)
        Me.lblPaciente.Name = "lblPaciente"
        Me.lblPaciente.Size = New System.Drawing.Size(60, 13)
        Me.lblPaciente.TabIndex = 10
        Me.lblPaciente.Text = "Paciente:"
        '
        'lvwPacientes
        '
        Me.lvwPacientes.CheckBoxes = True
        Me.lvwPacientes.FullRowSelect = True
        Me.lvwPacientes.GridLines = True
        Me.lvwPacientes.Location = New System.Drawing.Point(12, 48)
        Me.lvwPacientes.MultiSelect = False
        Me.lvwPacientes.Name = "lvwPacientes"
        Me.lvwPacientes.Size = New System.Drawing.Size(394, 240)
        Me.lvwPacientes.TabIndex = 12
        Me.lvwPacientes.UseCompatibleStateImageBehavior = False
        Me.lvwPacientes.View = System.Windows.Forms.View.List
        Me.lvwPacientes.Visible = False
        '
        'dgvPacientes
        '
        Me.dgvPacientes.AllowUserToAddRows = False
        Me.dgvPacientes.AllowUserToDeleteRows = False
        Me.dgvPacientes.AllowUserToResizeRows = False
        Me.dgvPacientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPacientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPacientes.Location = New System.Drawing.Point(12, 48)
        Me.dgvPacientes.MultiSelect = False
        Me.dgvPacientes.Name = "dgvPacientes"
        Me.dgvPacientes.RowHeadersVisible = False
        Me.dgvPacientes.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.dgvPacientes.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvPacientes.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Black
        Me.dgvPacientes.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.dgvPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPacientes.Size = New System.Drawing.Size(394, 240)
        Me.dgvPacientes.TabIndex = 22
        '
        'frmBuscarPacientes
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(514, 301)
        Me.Controls.Add(Me.dgvPacientes)
        Me.Controls.Add(Me.lvwPacientes)
        Me.Controls.Add(Me.txtPaciente)
        Me.Controls.Add(Me.lblPaciente)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdNuevo)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmBuscarPacientes"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Búsqueda de pacientes"
        CType(Me.dgvPacientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Friend IdPaciente As Integer
    Friend NombrePaciente As String

    Private Sub frmBuscarPacientes_Enter(sender As Object, e As System.EventArgs) Handles Me.Enter
        txtPaciente.Focus()
    End Sub


    Private Sub CargarFormulario(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mLLenarPacientes()
        txtPaciente.Focus()
    End Sub


    Private Sub txtPaciente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPaciente.TextChanged
        'mFiltrarPacientes()
        mLLenarPacientes()
    End Sub


    'Private Sub MarcarPaciente(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs)

    '    ' Sólo se puede marcar un Paciente de la lista
    '    If chlPacientes.CheckedItems.Count > 0 Then
    '        If e.NewValue = CheckState.Checked Then
    '            With chlPacientes
    '                Dim iCont As Integer

    '                For iCont = 0 To .CheckedIndices.Count - 1
    '                    .SetItemCheckState(.CheckedIndices(iCont), CheckState.Unchecked)
    '                Next iCont
    '            End With
    '        End If
    '    End If

    'End Sub

    Private Sub chlPacientes_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        mOKAceptar()
    End Sub


    Private Sub NuevoPaciente(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click

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

    Private Sub Aceptar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

        Dim bCitar As Boolean = True

        Dim bListaNegra As Boolean = CBool(dgvPacientes.CurrentRow.Cells(2).Value)

        Me.IdPaciente = Integer.Parse(dgvPacientes.CurrentRow.Cells(3).Value.ToString)
        Me.NombrePaciente = dgvPacientes.CurrentRow.Cells(1).Value.ToString


        ' Si el Paciente está en la Lista Negra
        If bListaNegra Then
            If MessageBox.Show(String.Format("El paciente {0} está incluido en la lista negra. ¿Deseas proceder con la cita?", NombrePaciente), Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
                bCitar = False
            End If
        End If


        If bCitar Then
            '.IdPaciente = Convert.ToInt32(chlPacientes.SelectedValue)
            '.NombrePaciente = chlPacientes.GetItemText(chlPacientes.CheckedItems(0))
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Dispose()
        End If


        'With Me
        '    For Each item As ListViewItem In lvwPacientes.CheckedItems
        '        'If item.Checked Then
        '        .IdPaciente = Integer.Parse(item.Tag.ToString)
        '        .NombrePaciente = item.Text
        '        'End If

        '        If item.ForeColor = Color.Red Then
        '            'MessageBox.Show(String.Format("El paciente {0} está incluido en la lista negra", .NombrePaciente), .Text, MessageBoxButtons.OK)
        '            If MessageBox.Show(String.Format("El paciente {0} está incluido en la lista negra. ¿Deseas proceder con la cita?", .NombrePaciente), Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
        '                bCitar = False
        '            End If
        '        End If
        '    Next

        '    If bCitar Then
        '        '.IdPaciente = Convert.ToInt32(chlPacientes.SelectedValue)
        '        '.NombrePaciente = chlPacientes.GetItemText(chlPacientes.CheckedItems(0))
        '        .DialogResult = Windows.Forms.DialogResult.OK
        '        .Dispose()
        '    End If
        'End With

    End Sub

    Private Sub Cancelar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        With Me
            .DialogResult = Windows.Forms.DialogResult.Cancel
            .Dispose()
        End With
    End Sub


    Private Sub mOKAceptar()

        Dim iCont As Integer
        Dim bOK As Boolean = False

        'For iCont = 0 To chlPacientes.Items.Count - 1
        '    If chlPacientes.GetItemChecked(iCont) Then
        '        bOK = True
        '        Exit For
        '    End If
        'Next iCont

        bOK = (lvwPacientes.CheckedItems.Count > 0)

        cmdAceptar.Enabled = bOK

    End Sub

    Private arrCabecerasPacientes() As String = {"Sel.", "Paciente", String.Empty, String.Empty}
    Private arrAnchurasPacientes() As Integer = {50, 300, 50, 50}

    Private Sub mLLenarPacientes()

        Dim sNombreCompleto As String = txtPaciente.Text.Trim
        Dim sNombre As String = String.Empty
        Dim sApellido1 As String = String.Empty
        Dim sApellido2 As String = String.Empty

        Dim dtPacientes As DataTable = LLenarPacientes(sNombre, sApellido1, sApellido2, sNombreCompleto, eTiposRellenoPacientes.Citas)
        Dim pac As New Paciente
        pac.IdPaciente = 0

        If Not IsNothing(dtPacientes) Then
            lvwPacientes.Items.Clear()

            If dtPacientes.Rows.Count > 0 Then
                NovafisDataGrid.ColumnaSeleccion(dtPacientes)

                'With chlPacientes
                '    .DataSource = dtPacientes
                '    .DisplayMember = "PAC_NombreCompleto"
                '    .ValueMember = "PAC_ID"
                'End With

                dtPacientes.Columns.Remove("FIS_Alias")
                dtPacientes.Columns.Remove("PAO_Descripcion")
                'dtPacientes.Columns.Remove("PAC_ListaNegra")

                dtPacientes.Columns("SEL").SetOrdinal(0)
                dtPacientes.Columns("PAC_ID").SetOrdinal(dtPacientes.Columns.Count - 1)


                dgvPacientes.DataSource = dtPacientes

                For Each colPacientes As DataGridViewColumn In dgvPacientes.Columns
                    If colPacientes.Index > 0 Then
                        colPacientes.ReadOnly = True
                    End If

                    colPacientes.HeaderText = arrCabecerasPacientes(colPacientes.Index)
                    colPacientes.Width = arrAnchurasPacientes(colPacientes.Index)

                    If colPacientes.Index > 1 Then
                        colPacientes.Visible = False
                    End If
                Next

                For Each dgrPaciente As DataGridViewRow In dgvPacientes.Rows
                    Dim cellBlackList As DataGridViewCheckBoxCell = CType(dgrPaciente.Cells(dgvPacientes.Columns.Count - 2), DataGridViewCheckBoxCell)

                    Dim isBlackList As Boolean = CBool(cellBlackList.Value)

                    If isBlackList Then
                        dgrPaciente.DefaultCellStyle.ForeColor = Color.Red
                        dgrPaciente.DefaultCellStyle.SelectionForeColor = Color.Red
                    End If
                Next

                'For Each drPaciente As DataRow In dtPacientes.Rows
                '    Dim itemPaciente As New ListViewItem
                '    itemPaciente.Text = drPaciente("PAC_NombreCompleto").ToString
                '    itemPaciente.Tag = drPaciente("PAC_ID").ToString

                '    If CBool(drPaciente("PAC_ListaNegra")) Then
                '        itemPaciente.ForeColor = Color.Red
                '    End If

                '    lvwPacientes.Items.Add(itemPaciente)
                'Next
                'Else
                '    chlPacientes.DataSource = Nothing
            End If
        End If

        'With chlPacientes
        '    .DataSource = tblPacientes
        '    .DisplayMember = "PAC_NombreCompleto"
        '    .ValueMember = "PAC_ID"
        'End With

    End Sub

    'Private Sub mFiltrarPacientes()

    '    Dim sFiltro As String = "PAC_NombreCompleto LIKE '" & txtPaciente.Text.Trim & "%'"
    '    Dim sOrden As String = String.Empty
    '    Dim arrPacientes As DataRow() = dtPacientes.Select(sFiltro, sOrden)

    '    Dim tblPacientes As DataTable = dtPacientes.Clone()
    '    Dim drFila As DataRow

    '    If arrPacientes.Length > 0 Then
    '        For Each drFila In arrPacientes
    '            tblPacientes.ImportRow(drFila)
    '        Next drFila
    '    End If

    '    mLLenarPacientes(tblPacientes)
    'End Sub


    'Private Sub lvwPacientes_ItemCheck(sender As Object, e As System.Windows.Forms.ItemCheckEventArgs) Handles lvwPacientes.ItemCheck

    '    If lvwPacientes.CheckedItems.Count > 0 Then
    '        If e.NewValue = CheckState.Checked Then
    '            With lvwPacientes
    '                For Each item As ListViewItem In lvwPacientes.Items
    '                    item.Checked = False
    '                Next
    '            End With
    '        End If
    '    End If

    '    cmdAceptar.Enabled = (e.NewValue = CheckState.Checked)
    'End Sub

    Private Sub dgvPacientes_CellContentClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPacientes.CellContentClick
        Dim dgv As DataGridView = CType(sender, DataGridView)

        dgv.EndEdit()

        If e.RowIndex >= 0 And e.ColumnIndex = 0 Then
            mOKPacientes(dgv, e.RowIndex)
        End If
    End Sub

    Private Sub mOKPacientes(ByVal dgv As DataGridView, ByVal rowIndex As Integer)
        Dim selCell As DataGridViewCheckBoxCell = CType(dgv.Item(0, rowIndex), DataGridViewCheckBoxCell)

        Dim isChecked As Boolean = CBool(selCell.Value)

        If isChecked Then
            For Each dgrPaciente As DataGridViewRow In dgv.Rows
                If dgrPaciente.Index <> rowIndex Then
                    'CBool(dgrPaciente.Cells(0).Value) = False
                    Dim cell As DataGridViewCheckBoxCell = CType(dgrPaciente.Cells(0), DataGridViewCheckBoxCell)
                    cell.Value = False
                End If
            Next
        End If

        cmdAceptar.Enabled = isChecked
    End Sub

End Class
