Option Strict Off
Option Explicit On 

Public Class frmCitas

    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Private Sub New()
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
    Friend WithEvents cmdCerrar As System.Windows.Forms.Button
    Friend WithEvents dtgCitas As ScrolledDataGrid
    Friend WithEvents dtgNotas As System.Windows.Forms.DataGrid
    Friend WithEvents calFecha As System.Windows.Forms.MonthCalendar
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents tipCitas As System.Windows.Forms.ToolTip
    Friend WithEvents cmdEliminar As System.Windows.Forms.Button
    Friend WithEvents cmdPaciente As System.Windows.Forms.Button
    Friend WithEvents splContenedor As System.Windows.Forms.SplitContainer
    Friend WithEvents lblPaciente As System.Windows.Forms.Label
    Friend WithEvents txtPaciente As System.Windows.Forms.TextBox
    Friend WithEvents cboHoras As System.Windows.Forms.ComboBox
    Friend WithEvents lblHora As System.Windows.Forms.Label
    Friend WithEvents dtgPacientes As System.Windows.Forms.DataGrid
    Friend WithEvents cmdCitar As System.Windows.Forms.Button
    Friend WithEvents cboFisios As System.Windows.Forms.ComboBox
    Friend WithEvents lblFisio As System.Windows.Forms.Label
    Friend WithEvents grbFisios As System.Windows.Forms.GroupBox
    Friend WithEvents dgvPacientes As System.Windows.Forms.DataGridView
    Friend WithEvents cmdInforme As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.calFecha = New System.Windows.Forms.MonthCalendar()
        Me.cmdCerrar = New System.Windows.Forms.Button()
        Me.dtgNotas = New System.Windows.Forms.DataGrid()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.tipCitas = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.cmdPaciente = New System.Windows.Forms.Button()
        Me.cmdInforme = New System.Windows.Forms.Button()
        Me.cmdCitar = New System.Windows.Forms.Button()
        Me.splContenedor = New System.Windows.Forms.SplitContainer()
        Me.dtgCitas = New Novafis.ScrolledDataGrid()
        Me.dgvPacientes = New System.Windows.Forms.DataGridView()
        Me.dtgPacientes = New System.Windows.Forms.DataGrid()
        Me.cboHoras = New System.Windows.Forms.ComboBox()
        Me.txtPaciente = New System.Windows.Forms.TextBox()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.lblPaciente = New System.Windows.Forms.Label()
        Me.cboFisios = New System.Windows.Forms.ComboBox()
        Me.lblFisio = New System.Windows.Forms.Label()
        Me.grbFisios = New System.Windows.Forms.GroupBox()
        CType(Me.dtgNotas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.splContenedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splContenedor.Panel1.SuspendLayout()
        Me.splContenedor.Panel2.SuspendLayout()
        Me.splContenedor.SuspendLayout()
        CType(Me.dtgCitas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgPacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'calFecha
        '
        Me.calFecha.FirstDayOfWeek = System.Windows.Forms.Day.Monday
        Me.calFecha.Location = New System.Drawing.Point(16, 16)
        Me.calFecha.MaxSelectionCount = 1
        Me.calFecha.MinDate = New Date(2006, 5, 3, 0, 0, 0, 0)
        Me.calFecha.Name = "calFecha"
        Me.calFecha.TabIndex = 0
        '
        'cmdCerrar
        '
        Me.cmdCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCerrar.Location = New System.Drawing.Point(808, 86)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(80, 32)
        Me.cmdCerrar.TabIndex = 6
        Me.cmdCerrar.Text = "Cerrar"
        Me.tipCitas.SetToolTip(Me.cmdCerrar, "Cerrar la ventana actual")
        '
        'dtgNotas
        '
        Me.dtgNotas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgNotas.CaptionText = "Notas diarias"
        Me.dtgNotas.ColumnHeadersVisible = False
        Me.dtgNotas.DataMember = ""
        Me.dtgNotas.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dtgNotas.Location = New System.Drawing.Point(520, 16)
        Me.dtgNotas.Name = "dtgNotas"
        Me.dtgNotas.ReadOnly = True
        Me.dtgNotas.Size = New System.Drawing.Size(375, 160)
        Me.dtgNotas.TabIndex = 1
        '
        'lblFecha
        '
        Me.lblFecha.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFecha.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(232, 16)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(311, 24)
        Me.lblFecha.TabIndex = 8
        Me.lblFecha.Text = "Fecha"
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdEliminar.Enabled = False
        Me.cmdEliminar.Location = New System.Drawing.Point(808, 3)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(80, 32)
        Me.cmdEliminar.TabIndex = 1
        Me.cmdEliminar.Text = "Eliminar"
        Me.tipCitas.SetToolTip(Me.cmdEliminar, "Eliminar la cita seleccionada")
        '
        'cmdPaciente
        '
        Me.cmdPaciente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdPaciente.Enabled = False
        Me.cmdPaciente.Location = New System.Drawing.Point(808, 51)
        Me.cmdPaciente.Name = "cmdPaciente"
        Me.cmdPaciente.Size = New System.Drawing.Size(80, 32)
        Me.cmdPaciente.TabIndex = 2
        Me.cmdPaciente.Text = "Paciente..."
        Me.tipCitas.SetToolTip(Me.cmdPaciente, "Mostrar detalles del Paciente")
        '
        'cmdInforme
        '
        Me.cmdInforme.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdInforme.Enabled = False
        Me.cmdInforme.Location = New System.Drawing.Point(808, 99)
        Me.cmdInforme.Name = "cmdInforme"
        Me.cmdInforme.Size = New System.Drawing.Size(80, 32)
        Me.cmdInforme.TabIndex = 3
        Me.cmdInforme.Text = "Informe..."
        Me.tipCitas.SetToolTip(Me.cmdInforme, "Generar Informe de trabajo diario")
        '
        'cmdCitar
        '
        Me.cmdCitar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCitar.Enabled = False
        Me.cmdCitar.Location = New System.Drawing.Point(808, 34)
        Me.cmdCitar.Name = "cmdCitar"
        Me.cmdCitar.Size = New System.Drawing.Size(80, 32)
        Me.cmdCitar.TabIndex = 6
        Me.cmdCitar.Text = "Citar"
        Me.tipCitas.SetToolTip(Me.cmdCitar, "Dar cita al Paciente seleccionado")
        '
        'splContenedor
        '
        Me.splContenedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.splContenedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.splContenedor.Location = New System.Drawing.Point(0, 192)
        Me.splContenedor.Name = "splContenedor"
        Me.splContenedor.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splContenedor.Panel1
        '
        Me.splContenedor.Panel1.Controls.Add(Me.dtgCitas)
        Me.splContenedor.Panel1.Controls.Add(Me.cmdEliminar)
        Me.splContenedor.Panel1.Controls.Add(Me.cmdInforme)
        Me.splContenedor.Panel1.Controls.Add(Me.cmdPaciente)
        Me.splContenedor.Panel1MinSize = 60
        '
        'splContenedor.Panel2
        '
        Me.splContenedor.Panel2.Controls.Add(Me.dgvPacientes)
        Me.splContenedor.Panel2.Controls.Add(Me.dtgPacientes)
        Me.splContenedor.Panel2.Controls.Add(Me.cboHoras)
        Me.splContenedor.Panel2.Controls.Add(Me.txtPaciente)
        Me.splContenedor.Panel2.Controls.Add(Me.lblHora)
        Me.splContenedor.Panel2.Controls.Add(Me.lblPaciente)
        Me.splContenedor.Panel2.Controls.Add(Me.cmdCitar)
        Me.splContenedor.Panel2.Controls.Add(Me.cmdCerrar)
        Me.splContenedor.Panel2.Controls.Add(Me.cboFisios)
        Me.splContenedor.Panel2.Controls.Add(Me.lblFisio)
        Me.splContenedor.Panel2MinSize = 50
        Me.splContenedor.Size = New System.Drawing.Size(895, 308)
        Me.splContenedor.SplitterDistance = 171
        Me.splContenedor.TabIndex = 3
        '
        'dtgCitas
        '
        Me.dtgCitas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgCitas.CaptionText = "Citas programadas"
        Me.dtgCitas.DataMember = ""
        Me.dtgCitas.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dtgCitas.Location = New System.Drawing.Point(3, 3)
        Me.dtgCitas.Name = "dtgCitas"
        Me.dtgCitas.ReadOnly = True
        Me.dtgCitas.Size = New System.Drawing.Size(789, 161)
        Me.dtgCitas.TabIndex = 0
        Me.dtgCitas.TabStop = False
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
        Me.dgvPacientes.Location = New System.Drawing.Point(3, 33)
        Me.dgvPacientes.MultiSelect = False
        Me.dgvPacientes.Name = "dgvPacientes"
        Me.dgvPacientes.RowHeadersVisible = False
        Me.dgvPacientes.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.dgvPacientes.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvPacientes.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Black
        Me.dgvPacientes.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.dgvPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPacientes.Size = New System.Drawing.Size(789, 87)
        Me.dgvPacientes.TabIndex = 21
        '
        'dtgPacientes
        '
        Me.dtgPacientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgPacientes.CaptionText = "Pacientes"
        Me.dtgPacientes.DataMember = ""
        Me.dtgPacientes.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dtgPacientes.Location = New System.Drawing.Point(3, 34)
        Me.dtgPacientes.Name = "dtgPacientes"
        Me.dtgPacientes.ReadOnly = True
        Me.dtgPacientes.Size = New System.Drawing.Size(789, 86)
        Me.dtgPacientes.TabIndex = 11
        Me.dtgPacientes.Visible = False
        '
        'cboHoras
        '
        Me.cboHoras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboHoras.FormattingEnabled = True
        Me.cboHoras.Location = New System.Drawing.Point(671, 6)
        Me.cboHoras.Name = "cboHoras"
        Me.cboHoras.Size = New System.Drawing.Size(89, 21)
        Me.cboHoras.TabIndex = 10
        '
        'txtPaciente
        '
        Me.txtPaciente.Location = New System.Drawing.Point(69, 6)
        Me.txtPaciente.MaxLength = 50
        Me.txtPaciente.Name = "txtPaciente"
        Me.txtPaciente.Size = New System.Drawing.Size(250, 21)
        Me.txtPaciente.TabIndex = 9
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Location = New System.Drawing.Point(626, 9)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(39, 13)
        Me.lblHora.TabIndex = 8
        Me.lblHora.Text = "Hora:"
        Me.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPaciente
        '
        Me.lblPaciente.AutoSize = True
        Me.lblPaciente.Location = New System.Drawing.Point(3, 9)
        Me.lblPaciente.Name = "lblPaciente"
        Me.lblPaciente.Size = New System.Drawing.Size(60, 13)
        Me.lblPaciente.TabIndex = 8
        Me.lblPaciente.Text = "Paciente:"
        '
        'cboFisios
        '
        Me.cboFisios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFisios.Location = New System.Drawing.Point(462, 6)
        Me.cboFisios.MaxDropDownItems = 10
        Me.cboFisios.Name = "cboFisios"
        Me.cboFisios.Size = New System.Drawing.Size(136, 21)
        Me.cboFisios.TabIndex = 20
        '
        'lblFisio
        '
        Me.lblFisio.AutoSize = True
        Me.lblFisio.Location = New System.Drawing.Point(363, 9)
        Me.lblFisio.Name = "lblFisio"
        Me.lblFisio.Size = New System.Drawing.Size(93, 13)
        Me.lblFisio.TabIndex = 19
        Me.lblFisio.Text = "Fisio de la cita:"
        Me.lblFisio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grbFisios
        '
        Me.grbFisios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grbFisios.Location = New System.Drawing.Point(235, 59)
        Me.grbFisios.Name = "grbFisios"
        Me.grbFisios.Size = New System.Drawing.Size(268, 55)
        Me.grbFisios.TabIndex = 9
        Me.grbFisios.TabStop = False
        Me.grbFisios.Text = "Fisioterapeutas"
        Me.grbFisios.Visible = False
        '
        'frmCitas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(895, 501)
        Me.Controls.Add(Me.grbFisios)
        Me.Controls.Add(Me.splContenedor)
        Me.Controls.Add(Me.dtgNotas)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.calFecha)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmCitas"
        Me.Text = "Citas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dtgNotas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splContenedor.Panel1.ResumeLayout(False)
        Me.splContenedor.Panel2.ResumeLayout(False)
        Me.splContenedor.Panel2.PerformLayout()
        CType(Me.splContenedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splContenedor.ResumeLayout(False)
        CType(Me.dtgCitas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPacientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgPacientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Const cteModulo As String = "Citas"


    'Variable para controlar el número de instancias abiertas
    Private Shared objInstancia As frmCitas = Nothing

    'Función que crea una sola instancia del formulario de Pacientes
    Public Shared Function Instancia() As frmCitas

        If IsNothing(objInstancia) OrElse objInstancia.IsDisposed = True Then
            objInstancia = New frmCitas()
            'Else
            '    bFormCargado = True
        End If

        objInstancia.BringToFront()

        Return objInstancia

    End Function


    Private mParametrosJornada As New parametrosJornada


    Private mHoraInicio1 As String = String.Empty
    Private mHoraFin1 As String = String.Empty
    Private mHoraInicio2 As String = String.Empty
    Private mHoraFin2 As String = String.Empty
    Private mIntervaloM As Byte = 0
    Private mIntervaloT As Byte = 0

    Private mbRecargar As Boolean = False

    Private m_dtEsquema As DataTable
    Private m_dtHoras As DataTable

    Private arrHorasJornada As New ArrayList
    Private dsCitas As New DataSet("CitasJornada")

    Private m_iFilaSel As Integer

    Private mColorTituloNotas As New Drawing.Color  'Drawing.Color = dtgNotas.CaptionBackColor

    Private WithEvents tmrNotas As System.Timers.Timer = New Timers.Timer
    Private m_iContadorNotas As Integer = 0

    'Dim dtFisios As DataTable

    Private iIDFisio As Integer
    Friend Property IDFisio() As Integer
        Get
            Return iIDFisio
        End Get
        Set(ByVal value As Integer)
            iIDFisio = value
        End Set
    End Property

    Private sNombreFisio As String
    Friend Property NombreFisio() As String
        Get
            Return sNombreFisio
        End Get
        Set(ByVal value As String)
            sNombreFisio = value
        End Set
    End Property

    Private bFormCargado As Boolean
    Public Property FormCargado() As Boolean
        Get
            Return bFormCargado
        End Get
        Set(ByVal value As Boolean)
            bFormCargado = value
        End Set
    End Property


    Private Sub CargarFormulario(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        mColorTituloNotas = dtgNotas.CaptionBackColor
        m_iFilaSel = 0
        calFecha.SelectionStart = DateTime.Today

        GestionFecha()
        'mCargarFisios()

        mbRecargar = True
        Me.FormCargado = True

    End Sub

    Private Sub RestaurarFormulario(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter
        'If CambioTablaPacientes Then
        '    'mConstruirEsquema()
        '    'mLLenarPacientes(dtPacientes)
        '    txtPaciente.Text = String.Empty
        '    CambioTablaPacientes = False
        'End If

        Me.FormCargado = True
        txtPaciente.Text = String.Empty
        mCargarFisios()
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub ReformarFormulario(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub CerrarFormulario(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If Not IsNothing(m_dtEsquema) Then
            m_dtEsquema.Dispose()
        End If
    End Sub


    Private Sub calFecha_DateChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles calFecha.DateChanged

        ' Este evento salta cada 2 minutos, por configuración interna del control
        Dim fFechaSel As DateTime = e.Start

        If (fFechaSel.CompareTo(CType(lblFecha.Text, DateTime)) <> 0) Then
            m_iFilaSel = 0

            tmrNotas.Stop()
            dtgNotas.CaptionBackColor = mColorTituloNotas

            GestionFecha()
        End If
    End Sub


    Private Sub CrearCita(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgCitas.DoubleClick

        Dim objCitasDetalle As New frmCitasDetalle()
        Dim sHora As String = dtgCitas.Item(dtgCitas.CurrentRowIndex, 0).ToString
        Dim iIDCita As Integer = Convert.ToInt32(dtgCitas.Item(dtgCitas.CurrentRowIndex, 10))
        Dim iIDPaciente As Integer '= Convert.ToInt32(dtgCitas.Item(dtgCitas.CurrentRowIndex, 3))
        Dim sPaciente As String = dtgCitas.Item(dtgCitas.CurrentRowIndex, 1).ToString

        If IsDBNull(dtgCitas.Item(dtgCitas.CurrentRowIndex, 3)) Then
            iIDPaciente = 0
        Else
            iIDPaciente = Convert.ToInt32(dtgCitas.Item(dtgCitas.CurrentRowIndex, 3))
        End If

        m_iFilaSel = dtgCitas.CurrentRowIndex

        With objCitasDetalle
            If iIDCita = 0 Then
                .TipoMant = eTiposMantenimiento.Alta
                .IDCita = 0
                .IDPaciente = 0
                .lblFecha.Text = calFecha.SelectionStart '.ToShortDateString
                .lblHora.Text = sHora
            Else
                .TipoMant = eTiposMantenimiento.Modificacion
                .IDCita = iIDCita
            End If

            If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                mLLenarCitasJornada()
                'mConstruirEsquema()
            End If

            'mLLenarPacientes(dtPacientes)

            .Dispose()
        End With

    End Sub

    Private Sub HabilitarBotones(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtgCitas.MouseDown

        'Dim htHitTest As DataGrid.HitTestInfo
        'Dim iFila As Integer
        'Dim iCol As Integer
        'Dim bOK As Boolean

        '' Recuperar el objeto de click
        'htHitTest = dtgCitas.HitTest(e.X, e.Y)

        '' Recuperar filas y columnas
        'iCol = htHitTest.Column
        'iFila = htHitTest.Row

        '' Miramos el valor de la columna de Código de la cita
        'If iFila > -1 Then
        '    bOK = (Convert.ToInt32(dtgCitas.Item(iFila, 10)) > 0)
        'Else
        '    bOK = False
        'End If

        ''If htHitTest.Type = dtgCitas.HitTestType.Cell And iCol = 6 Then
        ''    ' Dar la vuelta al valor
        ''    dtgCitas.Item(iFila, iCol) = Not Convert.ToBoolean(dtgCitas.Item(iFila, iCol))
        ''End If

        'cmdEliminar.Enabled = bOK
        'cmdPaciente.Enabled = bOK

    End Sub

    Private Sub NavegarGrid(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgCitas.CurrentCellChanged

        Dim iFilaSel As Integer = dtgCitas.CurrentRowIndex

        dtgCitas.Select(iFilaSel)
        mOKPaciente(iFilaSel)

    End Sub

    Private Sub SeleccionarUnaCita(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtgCitas.MouseUp

        Dim objTest As DataGrid.HitTestInfo = dtgCitas.HitTest(New Point(e.X, e.Y))
        Dim bOK As Boolean = False

        ' Si es una celda
        If objTest.Type = DataGrid.HitTestType.Cell Then
            dtgCitas.Select(objTest.Row)

            bOK = (Convert.ToInt32(dtgCitas.Item(objTest.Row, 10)) > 0)
            m_iFilaSel = objTest.Row
        End If

        ' Habilitar los botones Eliminar y Paciente cuando la fila tenga una cita asociada
        cmdEliminar.Enabled = bOK
        cmdPaciente.Enabled = bOK

    End Sub


    Private Sub EliminarCita(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click
        If MessageBox.Show("¿Quieres eliminar la Cita seleccionada?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If mbEliminarCita() Then
                mLLenarCitasJornada()
                'mConstruirEsquema()
                cmdEliminar.Enabled = False
            End If
        End If
    End Sub

    Private Sub DetallesPaciente(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPaciente.Click

        Dim iIDPaciente As Integer
        Dim sNombrePaciente As String

        iIDPaciente = Convert.ToInt32(dtgCitas.Item(dtgCitas.CurrentRowIndex, 3))
        sNombrePaciente = (dtgCitas.Item(dtgCitas.CurrentRowIndex, 2)).ToString

        If iIDPaciente > 0 Or Not IsDBNull(iIDPaciente) Then
            Dim objPacientesDetalle As New frmPacientesDetalle()

            With objPacientesDetalle
                .TipoMant = eTiposMantenimiento.Modificacion
                .IDPaciente = iIDPaciente
                .Text = "Paciente: " & sNombrePaciente.Trim
                .tabDetalles.SelectedTab = .tbpTratamiento

                .ShowDialog()

                'If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                '    'mConstruirEsquema()
                '    'mLLenarPacientes()
                '    'mLLenarCitasJornada()
                'End If

                If .TratGuardado Then
                    dtgCitas.Item(dtgCitas.CurrentRowIndex, 9) = True
                End If
            End With
        End If
    End Sub

    Private Sub Cerrar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click
        If Not IsNothing(m_dtEsquema) Then
            m_dtEsquema.Dispose()
        End If

        Me.Dispose()
    End Sub


    Private Sub GestionFecha()

        ' Mostrar fecha en formato largo
        lblFecha.Text = calFecha.SelectionStart.ToLongDateString

        ' Si es sábado o domingo, no permitir la entrada de citas
        If calFecha.SelectionStart.DayOfWeek = DayOfWeek.Saturday Or calFecha.SelectionStart.DayOfWeek = DayOfWeek.Sunday Then
            lblFecha.ForeColor = Color.Red

            mHabilitarControles(False)

            'dtgCitas.DataSource = Nothing
            'dtgCitas.Enabled = False

            'dtgNotas.DataSource = Nothing
            'dtgNotas.Enabled = False

            'dtgPacientes.DataSource = Nothing
            'dtgPacientes.Enabled = False

            'cboHoras.DataSource = Nothing
            'cboHoras.Enabled = False

            'grbFisios.Enabled = False
            'splContenedor.Enabled = False
            'cmdCerrar.Enabled = True
        Else
            lblFecha.ForeColor = Color.Black

            'dtgCitas.Enabled = True
            'dtgNotas.Enabled = True
            'dtgPacientes.Enabled = True
            'cboHoras.Enabled = True
            'grbFisios.Enabled = True

            ' LLenar la cuadrícula de Notas Diarias
            mLLenarNotas()

            ' Obtener los parámetros de configuración del día seleccionado
            mLLenarCitasJornada()

            'reestructurarCitas()
            'If mbEstablecerJornada() Then
            '    mConstruirEsquema()
            '    mOKInforme()
            '    dtgCitas.Enabled = True

            '    mLLenarPacientes()
            '    'mLLenarPacientes(dtPacientes)
            'Else
            '    MessageBox.Show("No hay una jornada definida para la fecha seleccionada: " & calFecha.SelectionStart.ToShortDateString & ControlChars.NewLine & "Revisar la Configuración del sistema.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            '    dtgCitas.DataSource = Nothing
            '    dtgCitas.Enabled = False

            '    dtgPacientes.DataSource = Nothing
            '    dtgPacientes.Enabled = False
            'End If
        End If

    End Sub


    Private Sub mHabilitarControles(ByVal bHabilitar As Boolean)

        dtgNotas.Enabled = bHabilitar
        dtgCitas.Enabled = bHabilitar

        txtPaciente.ReadOnly = Not bHabilitar
        cboFisios.Enabled = bHabilitar
        cboHoras.Enabled = bHabilitar
        dtgPacientes.Enabled = bHabilitar

        If Not bHabilitar Then
            tmrNotas.Stop()
            dtgNotas.CaptionBackColor = mColorTituloNotas

            dtgNotas.DataSource = Nothing
            dtgCitas.DataSource = Nothing

            cboFisios.DataSource = Nothing
            cboHoras.DataSource = Nothing
            dtgPacientes.DataSource = Nothing
        End If

    End Sub

#Region " NOTAS "

    Private arrCamposNotas() As String = {"NOT_Descripcion", "NOT_ID"}
    Private arrCabecerasNotas() As String = {"Notas diarias", String.Empty}
    Private arrTiposDatosNotas() As String = {"S", "I"}
    Private arrAnchurasNotas() As Integer = {500, 0}

    Private Sub ModificarNotaSeleccionada(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgNotas.DoubleClick

        Dim objTabla As New DataTable()

        objTabla = CType(dtgNotas.DataSource, DataTable)

        If Not IsNothing(objTabla) Then
            If objTabla.Rows.Count > 0 Then
                Dim objNotas As New frmNotas()
                Dim iIDNota As Integer = Convert.ToInt32(dtgNotas.Item(dtgNotas.CurrentRowIndex, 1))

                With objNotas
                    .IDNota = iIDNota
                    .FechaNota = calFecha.SelectionStart
                    .TipoMant = eTiposMantenimiento.Modificacion

                    If .ShowDialog = DialogResult.OK Then
                        mLLenarNotas()
                    End If
                End With
            End If

            objTabla.Dispose()
        End If

        objTabla = Nothing

    End Sub

    Private Sub SeleccionarUnaNota(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtgNotas.MouseUp

        Dim objTest As DataGrid.HitTestInfo = dtgNotas.HitTest(New Point(e.X, e.Y))

        ' Si es una celda
        If objTest.Type = DataGrid.HitTestType.Cell Then
            dtgNotas.Select(objTest.Row)
        End If

    End Sub

    Private Sub mLLenarNotas()

        Dim objBDatos As New AccesoBD_MySQL()
        Dim dtNotas As New DataTable("Notas")
        Dim bOK As Boolean

        Try
            With objBDatos
                bOK = .AbrirConexion

                If bOK Then
                    Dim arrParametros(1) As MySqlParameter
                    Dim iNumFilas As Integer

                    arrParametros(0) = New MySqlParameter()
                    With arrParametros(0)
                        .ParameterName = "iIDNota"
                        .MySqlDbType = MySqlDbType.Int32
                        .Size = 10
                        .Value = DBNull.Value
                        .Direction = ParameterDirection.Input
                    End With

                    arrParametros(1) = New MySqlParameter()
                    With arrParametros(1)
                        .ParameterName = "fFecha"
                        .MySqlDbType = MySqlDbType.Date
                        .Size = 8
                        .Value = calFecha.SelectionStart '.ToShortDateString
                        .Direction = ParameterDirection.Input
                    End With

                    bOK = .EjecutarSP("spNotas_LLenar", arrParametros, dtNotas, iNumFilas)

                    If bOK And Not IsNothing(dtNotas) Then
                        If iNumFilas > 0 Then
                            dtgNotas.SetDataBinding(dtNotas, String.Empty)

                            NovafisDataGrid.EstiloGrid(arrCamposNotas, arrCabecerasNotas, arrTiposDatosNotas, arrAnchurasNotas, dtgNotas, "Notas")

                            dtgNotas.TableStyles(0).AlternatingBackColor = Color.LemonChiffon
                            dtgNotas.TableStyles(0).BackColor = Color.LemonChiffon

                            tmrNotas.Interval = 1000
                            tmrNotas.Start()
                        Else
                            dtgNotas.SetDataBinding(Nothing, String.Empty)
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

#End Region


#Region " CITAS "

    Private arrCamposCitas() As String = {"Hora", "Fisio", "Paciente", "Matricula", "Fuente", "Observacion", "Cobrado", "Deuda", "Anulada", "Pasada", "IDCita"}
    Private arrCabecerasCitas() As String = {"Hora", "Fisio", "Paciente", "Nº Ficha", "Fuente", "Observación", "C", "D", "A", "P", String.Empty}
    Private arrTiposDatosCitas() As String = {"S", "S", "S", "I", "S", "S", "B", "B", "B", "B", "I"}
    Private arrAnchurasCitas() As Integer = {50, 100, 250, 70, 200, 290, 20, 20, 20, 20, 0}


    ' Las citas mostradas están en función del Fisio seleccionado
    ' Para construir las citas del día, hay que seguir estos pasos:
    '   1 - Establecer jornada. Comprobar en la BD si hay jornada definida y, en caso afirmativo, obtener sus parámetros.
    '   2 - Esquema jornada. En función del paso anterior, construir la jornada actual, incluyendo un listado de todas las horas aparte.
    '   3 - Citas jornada. Recuperar las citas del día e incorporarlas al esquema.
    '   4 - Horas jornada. Eliminar de la lista de horas del día las horas ocupadas con una cita.
    Private Sub mLLenarCitasJornada()

        ' Paso 1
        If mbEstablecerJornada() Then
            ' Paso 2. Tabla con nombre "Citas" + NombreFisio, contiene el esquema de la jornada
            Dim dtCitasJornada As DataTable = mConstruirEsquema()

            ' Paso 3. Tabla con nombre "Citas"
            Dim dtCitas As DataTable = mCitasLLenar()

            ' Paso 4. Copiar todas las horas en una tabla, eliminar las citadas y mostrarlas en el combo
            Dim dtHorasLibres As DataTable = dsCitas.Tables.Item("Horas").Clone
            dtHorasLibres.TableName = "HorasLibres" '+ Me.NombreFisio

            For Each drHora As DataRow In dsCitas.Tables.Item("Horas").Rows
                dtHorasLibres.ImportRow(drHora)
            Next

            If dtCitas.Rows.Count > 0 Then
                Dim arrFilas As DataRow()


                ' Rellenar cada hora con su cita correspondiente
                For Each drFila As DataRow In dtCitas.Rows
                    Dim sFiltro As String

                    If dtHorasLibres.Rows.Contains(drFila("CIT_Hora").ToString) Then
                        dtHorasLibres.Rows.Remove(dtHorasLibres.Rows.Find(drFila("CIT_Hora").ToString))
                    End If

                    sFiltro = "Hora = '" & drFila("CIT_Hora").ToString & "'"
                    arrFilas = dtCitasJornada.Select(sFiltro)

                    arrFilas(0)("Fisio") = drFila("FIS_Alias").ToString
                    arrFilas(0)("Paciente") = drFila("Paciente").ToString
                    arrFilas(0)("Matricula") = drFila("PAC_ID").ToString
                    arrFilas(0)("Fuente") = drFila("FNT_Descripcion").ToString
                    arrFilas(0)("Observacion") = drFila("CIT_Observacion").ToString

                    If Convert.ToDecimal(drFila("CIT_Cobrado")) > 0 Then
                        arrFilas(0)("Cobrado") = True
                    Else
                        arrFilas(0)("Cobrado") = False
                    End If

                    If Convert.ToDecimal(drFila("CIT_Deuda")) > 0 Then
                        arrFilas(0)("Deuda") = True
                    Else
                        arrFilas(0)("Deuda") = False
                    End If

                    arrFilas(0)("Anulada") = Convert.ToBoolean(drFila("CIT_Anulada"))

                    If IsDBNull(drFila("PAT_Descripcion")) Then
                        arrFilas(0)("Pasada") = False
                    Else
                        If drFila("PAT_Descripcion").ToString = String.Empty Then
                            arrFilas(0)("Pasada") = False
                        Else
                            arrFilas(0)("Pasada") = True
                        End If
                    End If

                    arrFilas(0)("IDCita") = Convert.ToInt32(drFila("CIT_ID"))

                    dtCitasJornada.AcceptChanges()
                Next drFila

            End If

            ' Incluir la tabla de horas libres en el dataset con el nombre "HorasLibres" + Me.NombreFisio
            If dsCitas.Tables.Contains(dtHorasLibres.TableName) Then
                dsCitas.Tables.Remove(dtHorasLibres.TableName)
            End If

            dsCitas.Tables.Add(dtHorasLibres)


            ' Incluir la tabla de citas de la jornada en el DataSet con el nombre CitasNombreFisio
            If dsCitas.Tables.Contains(dtCitasJornada.TableName) Then
                dsCitas.Tables.Remove(dtCitasJornada.TableName)
            End If

            dsCitas.Tables.Add(dtCitasJornada)

            ' Mostrar las citas a través del DataGrid
            dtgCitas.SetDataBinding(dtCitasJornada, String.Empty)

            NovafisDataGrid.EstiloGrid(arrCamposCitas, arrCabecerasCitas, arrTiposDatosCitas, arrAnchurasCitas, dtgCitas, dtCitasJornada.TableName, True)

            dtgCitas.Enabled = True


            If dtCitasJornada.Rows.Count > 0 Then
                mCargarFisios()
                mLLenarHoras(Me.NombreFisio)
                dtgCitas.ScrollTo(m_iFilaSel)

                mDeseleccionarCitas()
                dtgCitas.CurrentRowIndex = m_iFilaSel
                dtgCitas.Select(m_iFilaSel)
            End If

            mOKPaciente(m_iFilaSel)

            mOKInforme()

            mLLenarPacientes()

            mHabilitarControles(True)
        Else

            MessageBox.Show("No hay una jornada definida para el día " & calFecha.SelectionStart.ToShortDateString & " y el fisio " & Me.NombreFisio & ControlChars.NewLine & "Revisar la Configuración del sistema.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            mHabilitarControles(False)
        End If

    End Sub


    ''' <summary>
    ''' Acceder a BD para saber si hay jornada definida para la fecha y fisio seleccionados y obtener las horas de la jornada
    ''' </summary>
    ''' <returns>Marca que indica si hay jornada definida o no</returns>
    ''' <remarks></remarks>
    Private Function mbEstablecerJornada() As Boolean

        Dim objBDatos As New AccesoBD_MySQL()
        Dim objJornada As New DataTable()
        Dim bOKControl As Boolean
        Dim bOK As Boolean = False

        Try
            ' Reiniciar los parámetros de la jornada
            mParametrosJornada = New parametrosJornada

            With objBDatos
                bOKControl = .AbrirConexion

                If bOKControl Then
                    Dim arrParametros(0) As MySqlParameter

                    arrParametros(0) = New MySqlParameter()
                    With arrParametros(0)
                        .ParameterName = "fFecha"
                        .MySqlDbType = MySqlDbType.Date
                        .Size = 8
                        .Value = calFecha.SelectionStart '.ToShortDateString
                        .Direction = ParameterDirection.Input
                    End With

                    'arrParametros(1) = New MySqlParameter()
                    'With arrParametros(1)
                    '    .ParameterName = "iIDFisio"
                    '    .MySqlDbType = MySqlDbType.Int32
                    '    .Size = 4
                    '    .Value = Me.IDFisio
                    '    .Direction = ParameterDirection.Input
                    'End With

                    bOKControl = .EjecutarSP("spCitas_JornadaEstablecer", arrParametros, objJornada)

                    If bOKControl And objJornada.Rows.Count = 1 Then
                        Dim drFila As DataRow = objJornada.Rows.Item(0)

                        With mParametrosJornada
                            .horaInicio1 = drFila("JOR_HoraIniM").ToString
                            .horaFinal1 = drFila("JOR_HoraFinM").ToString
                            .horaInicio2 = drFila("JOR_HoraIniT").ToString
                            .horaFinal2 = drFila("JOR_HoraFinT").ToString
                            .intervaloM = Convert.ToByte(drFila("JOR_IntervaloM"))
                            .intervaloT = Convert.ToByte(drFila("JOR_IntervaloT"))

                            bOK = .hayJornadaDefinida

                            If bOK Then
                                Dim dtHoras As DataTable = .obtenerHorasJornada(calFecha.SelectionStart)
                                dtHoras.TableName = "Horas" '+ Me.NombreFisio

                                ' Añadir la tabla de las horas al dataset, previo borrado, en caso de que ya exista
                                If dsCitas.Tables.Contains("Horas") Then
                                    dsCitas.Tables.Remove("Horas")
                                End If
                                'If dsCitas.Tables.Contains("Horas" + Me.NombreFisio) Then
                                '    dsCitas.Tables.Remove("Horas" + Me.NombreFisio)
                                'End If

                                dsCitas.Tables.Add(dtHoras)
                                '.horasJornada = .obtenerHorasJornada(calFecha.SelectionStart)
                            End If
                        End With
                    End If

                    bOKControl = .CerrarConexion
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

    Private Function mConstruirEsquema() As DataTable

        'Dim dtEsquema As New DataTable("Citas" + Me.NombreFisio)
        Dim dtEsquema As New DataTable("Citas")

        Dim drFila As DataRow

        'm_dtEsquema = New DataTable("Citas" + Me.NombreFisio)

        With dtEsquema
            .BeginInit()

            ' Columnas
            .Columns.Add("Hora", GetType(String))
            .Columns.Add("Fisio", GetType(String))
            .Columns.Add("Paciente", GetType(String))
            .Columns.Add("Matricula", GetType(Integer))
            .Columns.Add("Fuente", GetType(String))
            .Columns.Add("Observacion", GetType(String))
            .Columns.Add("Cobrado", GetType(Boolean))
            .Columns.Add("Deuda", GetType(Boolean))
            .Columns.Add("Anulada", GetType(Boolean))
            .Columns.Add("Pasada", GetType(Boolean))
            .Columns.Add("IDCita", GetType(Integer))

            .Columns("Hora").Unique = True

            ' Filas
            For Each drHora As DataRow In dsCitas.Tables.Item("Horas").Rows 'mParametrosJornada.horasJornada
                drFila = .NewRow()

                drFila("Hora") = drHora.Item("Hora").ToString
                drFila("Fisio") = String.Empty
                drFila("Paciente") = String.Empty
                drFila("Matricula") = DBNull.Value
                drFila("Fuente") = String.Empty
                drFila("Observacion") = String.Empty
                drFila("Cobrado") = False
                drFila("Deuda") = False
                drFila("Anulada") = False
                drFila("Pasada") = False
                drFila("IDCita") = 0

                .Rows.Add(drFila)
            Next

            .EndInit()
        End With

        Return dtEsquema


        'Dim dtCitas As DataTable = mCitasLLenar()

        'If Not IsNothing(dtCitas) Then
        '    If dtCitas.Rows.Count > 0 Then
        '        Dim arrFilas() As DataRow

        '        For Each drFila In dtCitas.Rows
        '            Dim sFiltro As String

        '            sFiltro = "Hora = '" & drFila("CIT_Hora").ToString & "'"
        '            arrFilas = m_dtEsquema.Select(sFiltro)

        '            'arrFilas(0)("Fisio") = drFila("FIS_Alias").ToString
        '            arrFilas(0)("Paciente") = drFila("Paciente").ToString
        '            arrFilas(0)("Matricula") = drFila("PAC_ID").ToString
        '            arrFilas(0)("Fuente") = drFila("FNT_Descripcion").ToString
        '            arrFilas(0)("Observacion") = drFila("CIT_Observacion").ToString

        '            If Convert.ToDecimal(drFila("CIT_Cobrado")) > 0 Then
        '                arrFilas(0)("Cobrado") = True
        '            Else
        '                arrFilas(0)("Cobrado") = False
        '            End If

        '            If Convert.ToDecimal(drFila("CIT_Deuda")) > 0 Then
        '                arrFilas(0)("Deuda") = True
        '            Else
        '                arrFilas(0)("Deuda") = False
        '            End If

        '            arrFilas(0)("Anulada") = Convert.ToBoolean(drFila("CIT_Anulada"))

        '            If IsDBNull(drFila("PAT_Descripcion")) Then
        '                arrFilas(0)("Pasada") = False
        '            Else
        '                If drFila("PAT_Descripcion").ToString = String.Empty Then
        '                    arrFilas(0)("Pasada") = False
        '                Else
        '                    arrFilas(0)("Pasada") = True
        '                End If
        '            End If

        '            arrFilas(0)("IDCita") = Convert.ToInt32(drFila("CIT_ID"))

        '            m_dtEsquema.AcceptChanges()
        '        Next drFila
        '    End If
        'End If

        'm_dtEsquema.EndInit()



        'dtgCitas.SetDataBinding(m_dtEsquema, String.Empty)

        'NovafisDataGrid.EstiloGrid(arrCamposCitas, arrCabecerasCitas, arrTiposDatosCitas, arrAnchurasCitas, dtgCitas, "Citas", True)

        'If m_dtEsquema.Rows.Count > 0 Then
        '    mLLenarHoras()
        '    dtgCitas.ScrollTo(m_iFilaSel)

        '    mDeseleccionarCitas()
        '    dtgCitas.CurrentRowIndex = m_iFilaSel
        '    dtgCitas.Select(m_iFilaSel)
        'End If

        'mOKPaciente(m_iFilaSel)

    End Function

    Private Function mCitasLLenar() As DataTable

        Dim objBDatos As New AccesoBD_MySQL()
        Dim dtCitas As New DataTable("Citas")
        Dim iNumFilas As Integer
        Dim bOK As Boolean

        Try
            With objBDatos
                bOK = .AbrirConexion

                If bOK Then
                    Dim arrParametros(0) As MySqlParameter

                    arrParametros(0) = New MySqlParameter()
                    With arrParametros(0)
                        .ParameterName = "fFecha"
                        .MySqlDbType = MySqlDbType.Date
                        .Size = 10
                        .Value = calFecha.SelectionStart '.ToShortDateString
                        .Direction = ParameterDirection.Input
                    End With

                    'arrParametros(1) = New MySqlParameter()
                    'With arrParametros(1)
                    '    .ParameterName = "iIDFisio"
                    '    .MySqlDbType = MySqlDbType.Int32
                    '    .Size = 4
                    '    .Value = Me.IDFisio
                    '    .Direction = ParameterDirection.Input
                    'End With

                    bOK = .EjecutarSP("spCitas_LLenar", arrParametros, dtCitas, iNumFilas)

                    bOK = .CerrarConexion
                End If
            End With

        Catch exError As Exception
            GestionarErrores(exError.Message, cteModulo, MessageBoxIcon.Error, EventLogEntryType.Error)

        Finally
            ' Descargar objetos
            objBDatos.Dispose()

        End Try

        Return dtCitas

    End Function



    Private Function mbEliminarCita() As Boolean

        Dim objBDatos As New AccesoBD_MySQL()
        Dim bOK As Boolean
        Dim bControl As Boolean

        Try
            bControl = False

            With objBDatos
                bOK = .AbrirConexion

                If bOK Then
                    bOK = .IniciarTransaccion

                    If bOK Then
                        Dim arrParametros(2) As MySqlParameter

                        arrParametros(0) = New MySqlParameter()
                        With arrParametros(0)
                            .ParameterName = "iIDCita"
                            .MySqlDbType = MySqlDbType.Int32
                            .Size = 10
                            .Value = Convert.ToInt32(dtgCitas.Item(dtgCitas.CurrentRowIndex, 10))
                            .Direction = ParameterDirection.Input
                        End With

                        arrParametros(1) = New MySqlParameter()
                        With arrParametros(1)
                            .ParameterName = "iIDPaciente"
                            .MySqlDbType = MySqlDbType.Int32
                            .Size = 10
                            .Value = Convert.ToInt32(dtgCitas.Item(dtgCitas.CurrentRowIndex, 3))
                            .Direction = ParameterDirection.Input
                        End With

                        arrParametros(2) = New MySqlParameter()
                        With arrParametros(2)
                            .ParameterName = "fFecha"
                            .MySqlDbType = MySqlDbType.Date
                            .Size = 8
                            .Value = DateTime.Parse(lblFecha.Text)
                            .Direction = ParameterDirection.Input
                        End With

                        bOK = .EjecutarSP("spCitas_Eliminar", arrParametros)

                        If bOK Then
                            bOK = .ConfirmarTransaccion
                            bControl = True
                        Else
                            bOK = .CancelarTransaccion
                        End If
                    End If
                End If

                bOK = .CerrarConexion
            End With

        Catch exError As Exception
            GestionarErrores(exError.Message, cteModulo, MessageBoxIcon.Error, EventLogEntryType.Error)

        Finally
            ' Descargar objetos
            objBDatos.Dispose()

        End Try

        Return bControl

    End Function

    Private Sub mOKInforme()

        Dim bOK As Boolean = False

        'For Each objFila As DataRow In dsCitas.Tables("Citas" + Me.NombreFisio).Rows ' m_dtEsquema.Rows
        For Each objFila As DataRow In dsCitas.Tables("Citas").Rows ' m_dtEsquema.Rows
            If Not objFila("Paciente").ToString.Equals(String.Empty) Then
                bOK = True
                Exit For
            End If
        Next objFila

        cmdInforme.Enabled = bOK

    End Sub

    Private Sub mDeseleccionarCitas()
        For iCont As Integer = 0 To CType(dtgCitas.DataSource, DataTable).Rows.Count - 1
            dtgCitas.UnSelect(iCont)
        Next iCont
    End Sub


#End Region

#Region " INFORME "

    Private Sub GenerarInforme(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInforme.Click
        mGenerarInforme()
    End Sub

    Private Sub mGenerarInforme()

        'Dim objExcel As New Excel.Application()
        Dim objExcel As Object
        Dim objLibro As Object 'Excel.Workbook
        Dim objHoja As Object 'Excel.Worksheet

        Dim objPlantilla As System.IO.FileInfo

        Dim objBDatos As New AccesoBD_MySQL()
        Dim objDatosInforme As New DataTable()
        Dim iNumFilas As Integer

        Dim iColumna As Integer
        Dim iFila As Integer
        Dim bOK As Boolean

        Me.Cursor = Cursors.WaitCursor

        Try
            With objBDatos
                bOK = .AbrirConexion

                If bOK Then
                    Dim arrParametros(0) As MySqlParameter

                    arrParametros(0) = New MySqlParameter()
                    With arrParametros(0)
                        .ParameterName = "fFecha"
                        .MySqlDbType = MySqlDbType.Date
                        .Size = 10
                        .Value = calFecha.SelectionStart '.ToShortDateString
                        .Direction = ParameterDirection.Input
                    End With

                    bOK = .EjecutarSP("spCitas_InfTrabajoDiario", arrParametros, objDatosInforme, iNumFilas)

                    bOK = .CerrarConexion
                End If
            End With

            If bOK And Not IsNothing(objDatosInforme) Then
                Dim sFichero As String = Application.StartupPath & "\TrabajoDiario.xlt" '& LeerConfiguracion("AuditoriaReservas")

                Dim objFila As DataRow
                Dim sZona As String

                Dim sLocalizacion As String
                Dim sLesion As String
                Dim sObservacion As String
                Dim sTratamiento As String

                objExcel = CreateObject("Excel.Application")

                objPlantilla = New System.IO.FileInfo(sFichero)

                ' Cargar la plantilla
                objLibro = objExcel.Workbooks.Add(objPlantilla)

                ' Recuperar la hoja de los datos
                'objHoja = CType(objLibro.Worksheets(1), Excel.Worksheet)
                objHoja = objLibro.Worksheets(1)

                'objExcel.Visible = True

                With objHoja.Application
                    ' Posicionarse en el marcador de la fecha
                    .Goto("Fecha")
                    .ActiveCell.Value = lblFecha.Text

                    .Goto("Hora")
                    iFila = .ActiveCell.Row
                    iColumna = .ActiveCell.Column
                End With

                For Each objFila In objDatosInforme.Rows
                    With objHoja
                        'Hora
                        .Cells(iFila, iColumna).Value = objFila("t_Hora").ToString

                        'Paciente
                        .Cells(iFila, iColumna + 1).Value = objFila("t_Paciente").ToString

                        'Localización
                        If objFila("t_Localizacion").ToString = cteNinguna Or objFila("t_Localizacion").ToString = String.Empty Then
                            sLocalizacion = String.Empty
                        Else
                            sLocalizacion = objFila("t_Localizacion").ToString
                        End If
                        'sLocalizacion = IIf((objFila("t_Localizacion").ToString = cteNinguna), String.Empty, "Loc.: " & objFila("t_Localizacion").ToString)

                        'Lesión
                        If objFila("t_Lesion").ToString = cteNinguna Or objFila("t_Lesion").ToString = String.Empty Then
                            sLesion = String.Empty
                        Else
                            sLesion = objFila("t_Lesion").ToString
                        End If
                        'sLesion = IIf((objFila("t_Lesion").ToString = cteNinguna), String.Empty, "Les.: " & objFila("t_Lesion").ToString)

                        'Observación
                        sObservacion = IIf(IsDBNull(objFila("t_Observacion")), String.Empty, "Obs.: " & objFila("t_Observacion").ToString)
                        'Tratamiento
                        sTratamiento = IIf(IsDBNull(objFila("t_Tratamiento")), String.Empty, "Trat.: " & objFila("t_Tratamiento").ToString)

                        sZona = "C" & iFila.ToString & ":H" & iFila.ToString
                        With .Range(sZona)
                            .Select()
                            .Merge()
                            .WrapText = True
                            .HorizontalAlignment = -4131 'Excel.XlHAlign.xlHAlignLeft
                            .VerticalAlignment = -4160 'Excel.XlVAlign.xlVAlignTop
                            .EntireRow.RowHeight = 30
                        End With

                        'Detalles
                        .Cells(iFila, iColumna + 2).Value = sLesion & Space(5) & sLocalizacion & Space(5) & sObservacion & ControlChars.Lf & sTratamiento
                    End With

                    iFila += 1
                Next objFila

                With objHoja
                    sZona = "A" & (iFila - (objDatosInforme.Rows.Count + 1)) & ":H" & (iFila - 1)

                    ' Establecer los bordes
                    With .Range(sZona)
                        'BORDES EXTERNOS 
                        'Inferior
                        .Borders(9).LineStyle = 1
                        'Izquierda
                        .Borders(7).LineStyle = 1
                        'Derecha
                        .Borders(10).LineStyle = 1
                        'Superior
                        .Borders(8).LineStyle = 1

                        'BORDES INTERNOS
                        'Horizontales
                        .Borders(12).LineStyle = 1 'Línea continua
                        'Verticales
                        .Borders(11).LineStyle = 1 'Línea continua

                        '.BorderAround()
                        '.Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                        '.Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                        '.Borders(Excel.XlBordersIndex.xlInsideHorizontal).LineStyle = Excel.XlLineStyle.xlContinuous
                        '.Borders(Excel.XlBordersIndex.xlInsideVertical).LineStyle = Excel.XlLineStyle.xlContinuous
                        '.Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                        '.Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                    End With

                    .Range("A1").Select()
                End With

                ' Mostrar la Exportación
                objExcel.Visible = True
            End If



            ' Descargar objetos COM
            'System.Runtime.InteropServices.Marshal.ReleaseComObject(objHoja)
            'System.Runtime.InteropServices.Marshal.ReleaseComObject(objLibro)
            'System.Runtime.InteropServices.Marshal.ReleaseComObject(objExcel)

        Catch exError As Exception
            GestionarErrores(exError.Message, Me.Text, MessageBoxIcon.Error, EventLogEntryType.Error)

        Finally
            ' Descargar objetos
            objHoja = Nothing
            objLibro = Nothing
            objExcel = Nothing
            objPlantilla = Nothing

        End Try

        Me.Cursor = Cursors.Default

    End Sub

#End Region



    Private Sub tmrNotas_Elapsed(ByVal sender As Object, ByVal e As System.Timers.ElapsedEventArgs) Handles tmrNotas.Elapsed
        dtgNotas.CaptionBackColor = IIf(dtgNotas.CaptionBackColor = mColorTituloNotas, Color.Red, mColorTituloNotas)
        m_iContadorNotas += 1

        If m_iContadorNotas = 10 Then
            tmrNotas.Stop()
            m_iContadorNotas = 0
        End If
    End Sub


    Private arrCamposPacientes() As String = {"SEL", "PAC_NombreCompleto", "FIS_Alias", "PAO_Descripcion", "PAC_ListaNegra", "PAC_ID"}
    Private arrCabecerasPacientes() As String = {"Sel.", "Paciente", "Fisio", "Observación permanente", "Lista Negra", String.Empty}
    Private arrTiposDatosPacientes() As String = {"B", "S", "S", "S", "B", "I"}
    Private arrAnchurasPacientes() As Integer = {50, 250, 100, 400, 80, 50}

    Private Sub txtPaciente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPaciente.TextChanged
        mLLenarPacientes()
    End Sub


    Private Sub mLLenarPacientes()

        Dim sNombreCompleto As String = txtPaciente.Text.Trim
        Dim sNombre As String = String.Empty
        Dim sApellido1 As String = String.Empty
        Dim sApellido2 As String = String.Empty

        Dim dtPacientes As DataTable = LLenarPacientes(sNombre, sApellido1, sApellido2, sNombreCompleto, eTiposRellenoPacientes.Citas)

        If Not IsNothing(dtPacientes) Then
            If dtPacientes.Rows.Count > 0 Then
                NovafisDataGrid.ColumnaSeleccion(dtPacientes)

                'dtgPacientes.SetDataBinding(dtPacientes, String.Empty)
                'NovafisDataGrid.EstiloGrid(arrCamposPacientes, arrCabecerasPacientes, arrTiposDatosPacientes, arrAnchurasPacientes, dtgPacientes, "Pacientes", False)




                dtPacientes.Columns("SEL").SetOrdinal(0)
                dtPacientes.Columns("PAC_ID").SetOrdinal(dtPacientes.Columns.Count - 1)

                dgvPacientes.DataSource = dtPacientes

                For Each colPacientes As DataGridViewColumn In dgvPacientes.Columns
                    If colPacientes.Index > 0 Then
                        colPacientes.ReadOnly = True
                    End If

                    colPacientes.HeaderText = arrCabecerasPacientes(colPacientes.Index)
                    colPacientes.Width = arrAnchurasPacientes(colPacientes.Index)

                    If colPacientes.Index = dgvPacientes.Columns.Count - 1 Then
                        colPacientes.Visible = False
                    End If
                Next

                For Each dgrPaciente As DataGridViewRow In dgvPacientes.Rows
                    Dim cellBlackList As DataGridViewCheckBoxCell = dgrPaciente.Cells(dgvPacientes.Columns.Count - 2)

                    Dim isBlackList As Boolean = CBool(cellBlackList.Value)

                    If isBlackList Then
                        dgrPaciente.DefaultCellStyle.ForeColor = Color.Red
                        dgrPaciente.DefaultCellStyle.SelectionForeColor = Color.Red
                    End If

                Next


                'For iCont As Integer = 0 To CType(dtgPacientes.DataSource, DataTable).Rows.Count - 1
                '    If CBool(dtgPacientes.Item(iCont, 4)) Then
                '        Dim objEstilo As New DataGridTableStyle()
                '        objEstilo.ForeColor = Color.Red
                '        dtgPacientes.st()
                '        Exit For
                '    End If
                'Next iCont
            Else
                dtgPacientes.SetDataBinding(Nothing, String.Empty)
            End If
        End If

    End Sub

    'Private Sub mLLenarPacientes(ByVal tblPacientes As DataTable)

    '    If tblPacientes.Columns.Count <> 9 Then
    '        NovafisDataGrid.ColumnaSeleccion(tblPacientes)
    '    End If

    '    dtgPacientes.SetDataBinding(tblPacientes, String.Empty)

    '    NovafisDataGrid.EstiloGrid(arrCamposPacientes, arrCabecerasPacientes, arrTiposDatosPacientes, arrAnchurasPacientes, dtgPacientes, "Pacientes", True)

    '    'txtPaciente.Text = String.Empty

    'End Sub

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

    Private Sub mLLenarHoras(ByVal sFisio As String)

        RemoveHandler cboHoras.SelectedIndexChanged, AddressOf CambiarHora

        'Dim drFilaHora As DataRow

        'm_dtHoras = New DataTable("Horas")

        'With m_dtHoras
        '    .BeginInit()

        '    ' Columnas
        '    .Columns.Add("Hora", GetType(String))
        '    .Columns("Hora").Unique = True

        '    For Each drFila As DataRow In m_dtEsquema.Rows
        '        If CType(drFila("IDCita"), Integer) = 0 Then
        '            drFilaHora = .NewRow
        '            drFilaHora("Hora") = drFila("Hora")

        '            .Rows.Add(drFilaHora)
        '        End If
        '    Next drFila

        '    .EndInit()
        'End With

        'Dim dtHorasLibre As DataTable = dsCitas.Tables.Item("HorasLibres" + sFisio)
        Dim dtHorasLibre As DataTable = dsCitas.Tables.Item("HorasLibres")

        If Not IsNothing(dtHorasLibre) Then
            With cboHoras
                '.Items.Clear()
                .DataSource = Nothing
                .DataSource = dtHorasLibre

                .DisplayMember = "Hora"
                .ValueMember = "Hora"

                If dtHorasLibre.Rows.Count > 0 Then
                    .SelectedIndex = 0
                End If
            End With
        End If

        mOKCita()

        AddHandler cboHoras.SelectedIndexChanged, AddressOf CambiarHora

    End Sub

    Private Sub dtgPacientes_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtgPacientes.MouseDown

        Dim objHitTest As DataGrid.HitTestInfo
        Dim iCont As Integer
        Dim iRow As Integer
        Dim iCol As Integer
        Dim bOK As Boolean

        ' Recuperar el objeto de click
        objHitTest = dtgPacientes.HitTest(e.X, e.Y)

        ' Recuperar filas y columnas
        iCol = objHitTest.Column
        iRow = objHitTest.Row

        ' Miramos si se ha pulsado en una celda de la columna de selección
        If objHitTest.Type = DataGrid.HitTestType.Cell Then ' And iCol = 0 Then
            Dim bSeleccionar As Boolean = Not dtgPacientes.Item(iRow, 0)

            If bSeleccionar Then
                ' Recorrer poniendo a falso las columnas
                For iCont = 0 To CType(dtgPacientes.DataSource, DataTable).Rows.Count - 1
                    If CBool(dtgPacientes.Item(iCont, 0)) Then
                        dtgPacientes.Item(iCont, 0) = False
                        Exit For
                    End If
                Next iCont

                ' Cambiar el valor a verdadero
                dtgPacientes.Item(iRow, 0) = True

                ' Obtener el Fisio de referencia para el Paciente seleccionado
                Dim iIDPaciente As Integer = dtgPacientes.Item(iRow, 4)
                Dim iIDFisio As Integer = iObtenerFisioReferencia(iIDPaciente)
                Dim iIndiceFisio As Integer = 0

                bOK = BuscarElementoCombo(CType(cboFisios.DataSource, DataTable), iIDFisio, iIndiceFisio)

                If bOK Then
                    cboFisios.SelectedIndex = iIndiceFisio
                End If
            Else
                dtgPacientes.Item(iRow, 0) = False
            End If
        End If

        mOKCita()

    End Sub

    Private Sub dtgPacientes_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtgPacientes.MouseUp

        Dim objTest As DataGrid.HitTestInfo = dtgPacientes.HitTest(New Point(e.X, e.Y))

        ' Si es una celda
        If objTest.Type = DataGrid.HitTestType.Cell Then
            dtgPacientes.Select(objTest.Row)
        End If

    End Sub


    Private Function mbGuardarCita() As Boolean

        Dim objBDatos As New AccesoBD_MySQL()
        Dim bOK As Boolean
        Dim bControl As Boolean = False

        Try
            With objBDatos
                bOK = .AbrirConexion

                If bOK Then
                    bOK = .IniciarTransaccion

                    If bOK Then
                        Dim arrParametros(10) As MySqlParameter

                        arrParametros(0) = New MySqlParameter()
                        With arrParametros(0)
                            .ParameterName = "iIDCita"
                            .MySqlDbType = MySqlDbType.Int32
                            .Size = 4
                            .Value = 0
                            .Direction = ParameterDirection.Input
                        End With

                        arrParametros(1) = New MySqlParameter()
                        With arrParametros(1)
                            .ParameterName = "fFecha"
                            .MySqlDbType = MySqlDbType.Date
                            .Size = 8
                            .Value = calFecha.SelectionStart
                            .Direction = ParameterDirection.Input
                        End With

                        arrParametros(2) = New MySqlParameter()
                        With arrParametros(2)
                            .ParameterName = "sHora"
                            .MySqlDbType = MySqlDbType.VarChar
                            .Size = 5
                            .Value = cboHoras.SelectedValue.ToString
                            .Direction = ParameterDirection.Input
                        End With

                        arrParametros(3) = New MySqlParameter()
                        With arrParametros(3)
                            .ParameterName = "iIDPaciente"
                            .MySqlDbType = MySqlDbType.Int32
                            .Size = 4
                            '.Value = Convert.ToInt32(dtgPacientes.Item(dtgPacientes.CurrentRowIndex, 5))
                            .Value = Convert.ToInt32(dgvPacientes.CurrentRow.Cells(dgvPacientes.Columns.Count - 1).Value)
                            .Direction = ParameterDirection.Input
                        End With

                        arrParametros(4) = New MySqlParameter()
                        With arrParametros(4)
                            .ParameterName = "sObservacion"
                            .MySqlDbType = MySqlDbType.VarChar
                            .Size = 200
                            '.Value = dtgPacientes.Item(dtgPacientes.CurrentRowIndex, 3).ToString
                            .Value = dgvPacientes.CurrentRow.Cells(3).Value.ToString
                            .Direction = ParameterDirection.Input
                        End With

                        arrParametros(5) = New MySqlParameter()
                        With arrParametros(5)
                            .ParameterName = "bAnular"
                            .MySqlDbType = MySqlDbType.Bit
                            .Size = 1
                            .Value = False
                            .Direction = ParameterDirection.Input
                        End With

                        arrParametros(6) = New MySqlParameter()
                        With arrParametros(6)
                            .ParameterName = "sMotivo"
                            .MySqlDbType = MySqlDbType.VarChar
                            .Size = 200
                            .Value = String.Empty
                            .Direction = ParameterDirection.Input
                        End With

                        arrParametros(7) = New MySqlParameter()
                        With arrParametros(7)
                            .ParameterName = "dCobrado"
                            .MySqlDbType = MySqlDbType.Decimal
                            .Size = 9
                            .Precision = 5
                            .Scale = 2
                            .Value = 0
                            .Direction = ParameterDirection.Input
                        End With

                        arrParametros(8) = New MySqlParameter()
                        With arrParametros(8)
                            .ParameterName = "dDeuda"
                            .MySqlDbType = MySqlDbType.Decimal
                            .Size = 9
                            .Precision = 5
                            .Scale = 2
                            .Value = 0
                            .Direction = ParameterDirection.Input
                        End With

                        arrParametros(9) = New MySqlParameter()
                        With arrParametros(9)
                            .ParameterName = "iIDFisio"
                            .MySqlDbType = MySqlDbType.Int32
                            .Size = 4
                            .Value = cboFisios.SelectedValue
                            .Direction = ParameterDirection.Input
                        End With

                        arrParametros(10) = New MySqlParameter()
                        With arrParametros(10)
                            .ParameterName = "iNumCitas"
                            .MySqlDbType = MySqlDbType.Int32
                            .Size = 4
                            '.Value = cboFisios.SelectedValue
                            .Direction = ParameterDirection.Output
                        End With

                        bOK = .EjecutarSP("spCitas_Guardar", arrParametros)

                        If bOK Then
                            bOK = .ConfirmarTransaccion
                            bControl = (arrParametros(10).Value = 0)
                        Else
                            bOK = .CancelarTransaccion
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

        Return bControl

    End Function

    Private Sub mOKCita()

        Dim bOK As Boolean = False

        If Not IsNothing(dtgPacientes.DataSource) Then
            For Each drFila As DataRow In CType(dtgPacientes.DataSource, DataTable).Rows
                If CType(drFila("SEL"), Boolean) Then
                    bOK = True
                    Exit For
                End If
            Next
        End If

        If bOK Then
            bOK = (cboHoras.Items.Count > 0)
        End If

        cmdCitar.Enabled = bOK

    End Sub

    Private Sub cmdCitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCitar.Click

        'Dim bListaNegra As Boolean = CBool(dtgPacientes.Item(dtgPacientes.CurrentRowIndex, 4))
        Dim bListaNegra As Boolean = CBool(dgvPacientes.CurrentRow.Cells(4).Value)

        Dim bCitar As Boolean = True

        ' Si el Paciente está en la Lista Negra
        If bListaNegra Then
            'Dim nombrePaciente As String = dtgPacientes.Item(dtgPacientes.CurrentRowIndex, 1).ToString
            Dim nombrePaciente As String = dgvPacientes.CurrentRow.Cells(1).Value.ToString
            If MessageBox.Show(String.Format("El paciente {0} está incluido en la lista negra. ¿Deseas proceder con la cita?", nombrePaciente), Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
                bCitar = False
            End If
        End If


        If bCitar Then
            If mbGuardarCita() Then
                txtPaciente.Text = String.Empty
                txtPaciente.Focus()

                mLLenarCitasJornada()
                'mConstruirEsquema()
            Else
                MessageBox.Show("El Paciente seleccionado ya tiene una cita a la misma hora con otro Fisio", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If

    End Sub


    Private Function iObtenerFisioReferencia(ByVal iIDPaciente As Integer) As Integer

        Dim objBDatos As New AccesoBD_MySQL()
        Dim bOK As Boolean
        Dim sIDFisio As String = String.Empty

        Try
            With objBDatos
                bOK = .AbrirConexion

                If bOK Then
                    Dim arrParametros(0) As MySqlParameter

                    arrParametros(0) = New MySqlParameter()
                    With arrParametros(0)
                        .ParameterName = "iIDPaciente"
                        .MySqlDbType = MySqlDbType.Int32
                        .Size = 4
                        .Value = iIDPaciente
                        .Direction = ParameterDirection.Input
                    End With

                    bOK = .EjecutarSP("spPacientes_FisioReferencia", arrParametros, sIDFisio)

                    bOK = .CerrarConexion
                End If
            End With

        Catch exError As Exception
            GestionarErrores(exError.Message, cteModulo, MessageBoxIcon.Error, EventLogEntryType.Error)
        End Try

        Return Convert.ToInt32(sIDFisio)

    End Function


    Private Sub CambiarHora(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboHoras.SelectedIndexChanged

        If Not IsNothing(CType(cboHoras.DataSource, DataTable)) Then
            Dim iCont As Integer = 0

            'For Each drFila As DataRow In dsCitas.Tables.Item("Citas" + Me.NombreFisio).Rows 'm_dtEsquema.Rows
            For Each drFila As DataRow In dsCitas.Tables.Item("Citas").Rows 'm_dtEsquema.Rows
                If drFila("Hora").ToString.CompareTo(cboHoras.SelectedValue.ToString) = 0 Then
                    m_iFilaSel = iCont
                    mOKPaciente(iCont)
                    Exit For
                End If

                iCont += 1
            Next drFila

            dtgCitas.ScrollTo(m_iFilaSel)
        End If

    End Sub

    Private Sub mOKPaciente(ByVal iFilaSel As Integer)

        Dim bOK As Boolean = False

        bOK = (Convert.ToInt32(dtgCitas.Item(iFilaSel, 10)) > 0)

        ' Habilitar los botones Eliminar y Paciente cuando la fila tenga una cita asociada
        cmdEliminar.Enabled = bOK
        cmdPaciente.Enabled = bOK

    End Sub



#Region " FISIOTERAPEUTAS "

    Friend Sub fisioChecked(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles RadioButton1.CheckedChanged

        'Dim rdbFisio As RadioButton = CType(sender, RadioButton)

        'Me.IDFisio = CInt(rdbFisio.Tag)
        'Me.NombreFisio = rdbFisio.Text

        'If rdbFisio.Checked Then
        '    rdbFisio.Font = New Font(Me.Font.FontFamily, 10, FontStyle.Bold) 'New Font(Me.Font, FontStyle.Bold)
        '    rdbFisio.ForeColor = Color.Blue
        '    'rdbFisio.BackColor = Color.Navy

        '    dtgCitas.CaptionText = "Citas programadas - " + rdbFisio.Text

        '    If Me.FormCargado Then
        '        GestionFecha()
        '        'mLLenarCitasJornada()
        '        'reestructurarCitas()
        '    End If
        'Else
        '    rdbFisio.Font = Me.Font
        '    rdbFisio.ForeColor = Color.Black
        '    'rdbFisio.BackColor = Me.BackColor
        'End If

        Me.FormCargado = True

    End Sub

    Private Sub cboFisios_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFisios.SelectedIndexChanged
        If Me.FormCargado Then
            'mLLenarHoras(cboFisios.Text)
        End If
    End Sub

    Private Sub mCargarFisios()

        'dtFisios = CargarFisios()

        If tblFisios.Rows.Count > 0 Then
            With cboFisios
                .DataSource = Nothing
                .Items.Clear()

                .DataSource = tblFisios

                .DisplayMember = "FIS_Alias"
                .ValueMember = "FIS_ID"

                .SelectedIndex = 0
            End With
        End If

    End Sub

#End Region

    Private Sub dgvPacientes_CellContentClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPacientes.CellContentClick
        Dim dgv As DataGridView = CType(sender, DataGridView)

        dgv.EndEdit()

        If e.RowIndex >= 0 And e.ColumnIndex = 0 Then
            mOKPacientes(dgv, e.RowIndex)
        End If
    End Sub

    'Private Sub dgvPacientes_CellMouseClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvPacientes.CellMouseClick
    '    Dim dgv As DataGridView = CType(sender, DataGridView)

    '    If e.RowIndex >= 0 Then
    '        mOKPacientes(dgv, e.RowIndex)
    '    End If

    'End Sub


    Private Sub mOKPacientes(ByVal dgv As DataGridView, ByVal rowIndex As Integer)
        Dim selCell As DataGridViewCheckBoxCell = CType(dgv.Item(0, rowIndex), DataGridViewCheckBoxCell)

        Dim isChecked As Boolean = CBool(selCell.Value)

        If isChecked Then
            For Each dgrPaciente As DataGridViewRow In dgv.Rows
                If dgrPaciente.Index <> rowIndex Then
                    'CBool(dgrPaciente.Cells(0).Value) = False
                    Dim cell As DataGridViewCheckBoxCell = dgrPaciente.Cells(0)
                    cell.Value = False
                End If
            Next
        End If

        cmdCitar.Enabled = isChecked
    End Sub

    'Private Sub dgvPacientes_CellValueChanged(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPacientes.CellValueChanged

    '    Dim dgv As DataGridView = CType(sender, DataGridView)

    '    If e.ColumnIndex = 0 And e.RowIndex >= 0 Then
    '        Dim isChecked As Boolean = CType(dgv(e.ColumnIndex, e.RowIndex).Value, Boolean)

    '        If isChecked Then
    '            'If check box is checked, uncheck all the rows, the current row would be checked later.
    '            For Each row As DataGridViewRow In dgv.Rows
    '                row.Cells(e.ColumnIndex).Value = False
    '            Next
    '        End If

    '        cmdCitar.Enabled = isChecked
    '    End If

    'End Sub
End Class
