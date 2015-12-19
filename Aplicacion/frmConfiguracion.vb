Option Strict On
Option Explicit On 


Public Class frmConfiguracion

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
    Friend WithEvents grbJornadas As System.Windows.Forms.GroupBox
    Friend WithEvents cmdNuevaJornada As System.Windows.Forms.Button
    Friend WithEvents cmdModificarJornada As System.Windows.Forms.Button
    Friend WithEvents cmdNuevaTarifa As System.Windows.Forms.Button
    Friend WithEvents grbTarifas As System.Windows.Forms.GroupBox
    Friend WithEvents tipConfiguracion As System.Windows.Forms.ToolTip
    Friend WithEvents cmdModificarTarifa As System.Windows.Forms.Button
    Friend WithEvents dtgTarifas As System.Windows.Forms.DataGrid
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaFin As System.Windows.Forms.Label
    Friend WithEvents lblFechaIni As System.Windows.Forms.Label
    Friend WithEvents dtpFechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtgJornadas As System.Windows.Forms.DataGrid
    Friend WithEvents cmdCerrar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.tipConfiguracion = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdNuevaJornada = New System.Windows.Forms.Button()
        Me.cmdModificarJornada = New System.Windows.Forms.Button()
        Me.cmdNuevaTarifa = New System.Windows.Forms.Button()
        Me.cmdModificarTarifa = New System.Windows.Forms.Button()
        Me.cmdCerrar = New System.Windows.Forms.Button()
        Me.grbJornadas = New System.Windows.Forms.GroupBox()
        Me.dtpFechaIni = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaFin = New System.Windows.Forms.Label()
        Me.lblFechaIni = New System.Windows.Forms.Label()
        Me.grbTarifas = New System.Windows.Forms.GroupBox()
        Me.dtgTarifas = New System.Windows.Forms.DataGrid()
        Me.dtgJornadas = New System.Windows.Forms.DataGrid()
        Me.grbJornadas.SuspendLayout()
        Me.grbTarifas.SuspendLayout()
        CType(Me.dtgTarifas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgJornadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdNuevaJornada
        '
        Me.cmdNuevaJornada.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdNuevaJornada.Location = New System.Drawing.Point(512, 61)
        Me.cmdNuevaJornada.Name = "cmdNuevaJornada"
        Me.cmdNuevaJornada.Size = New System.Drawing.Size(80, 32)
        Me.cmdNuevaJornada.TabIndex = 3
        Me.cmdNuevaJornada.Text = "Nueva..."
        Me.tipConfiguracion.SetToolTip(Me.cmdNuevaJornada, "Configurar nueva Jornada Laboral")
        '
        'cmdModificarJornada
        '
        Me.cmdModificarJornada.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdModificarJornada.Enabled = False
        Me.cmdModificarJornada.Location = New System.Drawing.Point(512, 109)
        Me.cmdModificarJornada.Name = "cmdModificarJornada"
        Me.cmdModificarJornada.Size = New System.Drawing.Size(80, 32)
        Me.cmdModificarJornada.TabIndex = 4
        Me.cmdModificarJornada.Text = "Modificar..."
        Me.tipConfiguracion.SetToolTip(Me.cmdModificarJornada, "Modifcar Jornada Laboral seleccionada")
        '
        'cmdNuevaTarifa
        '
        Me.cmdNuevaTarifa.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdNuevaTarifa.Location = New System.Drawing.Point(512, 32)
        Me.cmdNuevaTarifa.Name = "cmdNuevaTarifa"
        Me.cmdNuevaTarifa.Size = New System.Drawing.Size(80, 32)
        Me.cmdNuevaTarifa.TabIndex = 1
        Me.cmdNuevaTarifa.Text = "Nueva..."
        Me.tipConfiguracion.SetToolTip(Me.cmdNuevaTarifa, "Configurar nueva Tarifa")
        '
        'cmdModificarTarifa
        '
        Me.cmdModificarTarifa.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdModificarTarifa.Location = New System.Drawing.Point(512, 80)
        Me.cmdModificarTarifa.Name = "cmdModificarTarifa"
        Me.cmdModificarTarifa.Size = New System.Drawing.Size(80, 32)
        Me.cmdModificarTarifa.TabIndex = 2
        Me.cmdModificarTarifa.Text = "Modificar..."
        Me.tipConfiguracion.SetToolTip(Me.cmdModificarTarifa, "Modifcar Tarifa seleccionada")
        '
        'cmdCerrar
        '
        Me.cmdCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCerrar.Location = New System.Drawing.Point(544, 608)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(80, 32)
        Me.cmdCerrar.TabIndex = 2
        Me.cmdCerrar.Text = "Cerrar"
        Me.tipConfiguracion.SetToolTip(Me.cmdCerrar, "Cerrar ventana Configuración")
        '
        'grbJornadas
        '
        Me.grbJornadas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grbJornadas.Controls.Add(Me.dtgJornadas)
        Me.grbJornadas.Controls.Add(Me.dtpFechaIni)
        Me.grbJornadas.Controls.Add(Me.dtpFechaFin)
        Me.grbJornadas.Controls.Add(Me.lblFechaFin)
        Me.grbJornadas.Controls.Add(Me.lblFechaIni)
        Me.grbJornadas.Controls.Add(Me.cmdNuevaJornada)
        Me.grbJornadas.Controls.Add(Me.cmdModificarJornada)
        Me.grbJornadas.Location = New System.Drawing.Point(16, 16)
        Me.grbJornadas.Name = "grbJornadas"
        Me.grbJornadas.Size = New System.Drawing.Size(608, 376)
        Me.grbJornadas.TabIndex = 0
        Me.grbJornadas.TabStop = False
        Me.grbJornadas.Text = " Jornadas Laborales"
        '
        'dtpFechaIni
        '
        Me.dtpFechaIni.Checked = False
        Me.dtpFechaIni.CustomFormat = "dd/MM/yyyy"
        Me.dtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaIni.Location = New System.Drawing.Point(97, 22)
        Me.dtpFechaIni.MinDate = New Date(2006, 5, 3, 0, 0, 0, 0)
        Me.dtpFechaIni.Name = "dtpFechaIni"
        Me.dtpFechaIni.ShowCheckBox = True
        Me.dtpFechaIni.Size = New System.Drawing.Size(115, 21)
        Me.dtpFechaIni.TabIndex = 0
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Checked = False
        Me.dtpFechaFin.CustomFormat = "dd/MM/yyyy"
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaFin.Location = New System.Drawing.Point(309, 22)
        Me.dtpFechaFin.MinDate = New Date(2006, 5, 3, 0, 0, 0, 0)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.ShowCheckBox = True
        Me.dtpFechaFin.Size = New System.Drawing.Size(115, 21)
        Me.dtpFechaFin.TabIndex = 1
        '
        'lblFechaFin
        '
        Me.lblFechaFin.AutoSize = True
        Me.lblFechaFin.Location = New System.Drawing.Point(240, 26)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(63, 13)
        Me.lblFechaFin.TabIndex = 9
        Me.lblFechaFin.Text = "Fecha fin:"
        '
        'lblFechaIni
        '
        Me.lblFechaIni.AutoSize = True
        Me.lblFechaIni.Location = New System.Drawing.Point(13, 26)
        Me.lblFechaIni.Name = "lblFechaIni"
        Me.lblFechaIni.Size = New System.Drawing.Size(78, 13)
        Me.lblFechaIni.TabIndex = 9
        Me.lblFechaIni.Text = "Fecha inicio:"
        '
        'grbTarifas
        '
        Me.grbTarifas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grbTarifas.Controls.Add(Me.cmdNuevaTarifa)
        Me.grbTarifas.Controls.Add(Me.cmdModificarTarifa)
        Me.grbTarifas.Controls.Add(Me.dtgTarifas)
        Me.grbTarifas.Location = New System.Drawing.Point(16, 398)
        Me.grbTarifas.Name = "grbTarifas"
        Me.grbTarifas.Size = New System.Drawing.Size(608, 192)
        Me.grbTarifas.TabIndex = 1
        Me.grbTarifas.TabStop = False
        Me.grbTarifas.Text = " Tarifas "
        '
        'dtgTarifas
        '
        Me.dtgTarifas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgTarifas.CaptionText = "Tarifas"
        Me.dtgTarifas.DataMember = ""
        Me.dtgTarifas.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dtgTarifas.Location = New System.Drawing.Point(16, 32)
        Me.dtgTarifas.Name = "dtgTarifas"
        Me.dtgTarifas.ReadOnly = True
        Me.dtgTarifas.Size = New System.Drawing.Size(480, 147)
        Me.dtgTarifas.TabIndex = 0
        '
        'dtgJornadas
        '
        Me.dtgJornadas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgJornadas.CaptionText = "Jornadas Laborales"
        Me.dtgJornadas.DataMember = ""
        Me.dtgJornadas.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dtgJornadas.Location = New System.Drawing.Point(16, 61)
        Me.dtgJornadas.Name = "dtgJornadas"
        Me.dtgJornadas.ReadOnly = True
        Me.dtgJornadas.Size = New System.Drawing.Size(480, 292)
        Me.dtgJornadas.TabIndex = 10
        '
        'frmConfiguracion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.cmdCerrar
        Me.ClientSize = New System.Drawing.Size(640, 661)
        Me.Controls.Add(Me.cmdCerrar)
        Me.Controls.Add(Me.grbJornadas)
        Me.Controls.Add(Me.grbTarifas)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmConfiguracion"
        Me.Text = "Jornadas Laborales"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grbJornadas.ResumeLayout(False)
        Me.grbJornadas.PerformLayout()
        Me.grbTarifas.ResumeLayout(False)
        CType(Me.dtgTarifas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgJornadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    'Variable para controlar el número de instancias abiertas
    Private Shared objInstancia As frmConfiguracion = Nothing

    'Función que crea una sola instancia del formulario de Pacientes
    Public Shared Function Instancia() As frmConfiguracion

        If IsNothing(objInstancia) OrElse objInstancia.IsDisposed = True Then
            objInstancia = New frmConfiguracion()
        End If

        objInstancia.BringToFront()

        Return objInstancia

    End Function

    Friend Sub SelectingFisio(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TabControlCancelEventArgs)
        'MessageBox.Show("índice: " + e.TabPage.Tag.ToString)
        Me.IDFisio = CInt(e.TabPage.Tag)
        Me.NombreFisio = e.TabPage.Text
        cmdModificarJornada.Enabled = False
    End Sub

    Friend Sub DrawingTabPage(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DrawItemEventArgs)

        Dim tpgFisio As TabPage = CType(sender, TabControl).TabPages(e.Index)
        Dim objRectangulo As Rectangle = CType(sender, TabControl).GetTabRect(e.Index)

        Dim sfLetra As New StringFormat
        sfLetra.Alignment = StringAlignment.Center
        sfLetra.LineAlignment = StringAlignment.Center

        If Convert.ToBoolean(e.State And DrawItemState.Selected) Then
            Dim fuente As New Font(Me.Font.FontFamily, 10, FontStyle.Bold) 'New Font(CType(sender, TabControl).Font, FontStyle.Bold)
            'e.Graphics.FillRectangle(Brushes.Transparent, objRectangulo)
            e.Graphics.DrawString(tpgFisio.Text, fuente, New SolidBrush(Color.Blue), objRectangulo, sfLetra)
        Else
            'e.Graphics.FillRectangle(Brushes.Navy, objRectangulo)
            e.Graphics.DrawString(tpgFisio.Text, e.Font, New SolidBrush(Color.Black), objRectangulo, sfLetra)
        End If

    End Sub

    'Friend Sub ModificarJornadaSeleccionada(ByVal sender As Object, ByVal e As System.EventArgs) 'Handles dtgJornadas.DoubleClick
    '    If cmdModificarJornada.Enabled Then
    '        Dim dtgFisioJornada As DataGrid = CType(sender, DataGrid)
    '        Me.IDJornada = Convert.ToInt32(dtgFisioJornada.Item(dtgFisioJornada.CurrentRowIndex, 7))
    '        mConfigurarDetalleJornadas(eTiposMantenimiento.Modificacion, Me.IDJornada)
    '        'cmdModificarJornada.PerformClick()
    '    End If
    'End Sub

    'Friend Sub SeleccionarUnaJornada(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) 'Handles dtgJornadas.MouseUp

    '    Dim dtgFisioJornada As DataGrid = CType(sender, DataGrid)
    '    Dim objTest As DataGrid.HitTestInfo = dtgFisioJornada.HitTest(New Point(e.X, e.Y))

    '    ' Si es una celda
    '    If objTest.Type = DataGrid.HitTestType.Cell Then
    '        Me.IDJornada = Convert.ToInt32(dtgFisioJornada.Item(dtgFisioJornada.CurrentRowIndex, 7))
    '        dtgFisioJornada.Select(objTest.Row)
    '    End If

    '    ' Habilitar el botón Modificar (Jornadas) cuando se seleccione una celda. No valen las cabeceras.
    '    cmdModificarJornada.Enabled = (objTest.Type = DataGrid.HitTestType.Cell)

    'End Sub

#Region " JORNADAS LABORALES "

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

    Private iIDJornada As Integer = 0
    Private Property IDJornada() As Integer
        Get
            Return iIDJornada
        End Get
        Set(ByVal value As Integer)
            iIDJornada = value
        End Set
    End Property

    Private arrCamposJornadas() As String = {"JOR_Fecha", "JOR_HoraIniM", "JOR_HoraFinM", "JOR_IntervaloM", "JOR_HoraIniT", "JOR_HoraFinT", "JOR_IntervaloT", "JOR_ID", "FIS_ID"}
    Private arrCabecerasJornadas() As String = {"Día", "Hora Inicio 1", "Hora Fin 1", "Intervalo (min)", "Hora Inicio 2", "Hora Fin 2", "Intervalo (min)", String.Empty, String.Empty}
    Private arrTiposDatosJornadas() As String = {"F", "S", "S", "I", "S", "S", "I", "I", "I"}
    Private arrAnchurasJornadas() As Integer = {110, 90, 90, 100, 90, 90, 100, 0, 0}

    Private TablaJornadas As DataTable = New DataTable("Jornadas")

#Region " CONTROLES "

    Private Sub ModificarJornadaSeleccionada(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgJornadas.DoubleClick
        If cmdModificarJornada.Enabled Then
            Me.IDJornada = Convert.ToInt32(dtgJornadas.Item(dtgJornadas.CurrentRowIndex, 7))
            cmdModificarJornada.PerformClick()
        End If
    End Sub

    Private Sub SeleccionarUnaJornada(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtgJornadas.MouseUp

        Dim objTest As DataGrid.HitTestInfo = dtgJornadas.HitTest(New Point(e.X, e.Y))

        ' Si es una celda
        If objTest.Type = DataGrid.HitTestType.Cell Then
            Me.IDJornada = Convert.ToInt32(dtgJornadas.Item(dtgJornadas.CurrentRowIndex, 7))
            dtgJornadas.Select(objTest.Row)
        End If

        ' Habilitar el botón Modificar (Jornadas) cuando se seleccione una celda. No valen las cabeceras.
        cmdModificarJornada.Enabled = (objTest.Type = DataGrid.HitTestType.Cell)

    End Sub


    Private Sub NuevaJornada(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevaJornada.Click
        mConfigurarDetalleJornadas(eTiposMantenimiento.Alta, 0)
    End Sub

    Private Sub ModificarJornada(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificarJornada.Click
        'Dim iIDJornada As Integer = Convert.ToInt32(dtgJornadas.Item(dtgJornadas.CurrentRowIndex, 7))
        mConfigurarDetalleJornadas(eTiposMantenimiento.Modificacion, Me.IDJornada)
    End Sub

#End Region

#Region " FUNCIONES "

    Private Sub mLLenarJornadas()

        Dim objBDatos As New AccesoBD_MySQL()
        Dim iNumJornadas As Integer
        Dim bOK As Boolean

        'RemoveHandler dtpFechaIni.ValueChanged, AddressOf FiltrarFechas
        'RemoveHandler dtpFechaFin.ValueChanged, AddressOf FiltrarFechas

        'dtpFechaIni.Value = dtpFechaIni.MinDate
        'dtpFechaFin.Value = DateTime.Today.AddMonths(1)

        'AddHandler dtpFechaIni.ValueChanged, AddressOf FiltrarFechas
        'AddHandler dtpFechaFin.ValueChanged, AddressOf FiltrarFechas

        Try
            TablaJornadas.Clear()

            With objBDatos
                bOK = .AbrirConexion()

                If bOK Then
                    Dim arrParametros(0) As MySqlParameter

                    arrParametros(0) = New MySqlParameter()
                    With arrParametros(0)
                        .ParameterName = "iIDJornada"
                        .MySqlDbType = MySqlDbType.Int32
                        .Size = 4
                        .Value = DBNull.Value
                        .Direction = ParameterDirection.Input
                    End With

                    bOK = .EjecutarSP("spJornadas_LLenar", arrParametros, TablaJornadas, iNumJornadas)


                    If bOK Then
                        If Not IsNothing(TablaJornadas) Then
                            If iNumJornadas > 0 Then
                                'Dim tabFisios As TabControl = CType(grbJornadas.Controls(grbJornadas.Controls.Count - 1), TabControl)

                                'For Each tpgFisio As TabPage In tabFisios.TabPages
                                '    Dim dtJornadasFisio As DataTable = TablaJornadas.Clone
                                '    dtJornadasFisio.TableName = "Jornadas" + Me.NombreFisio
                                '    Dim arrJornadas As DataRow() = TablaJornadas.Select("FIS_ID = " + CInt(tpgFisio.Tag).ToString)

                                '    For Each drJornadaFisio As DataRow In arrJornadas
                                '        dtJornadasFisio.ImportRow(drJornadaFisio)
                                '    Next

                                '    Dim dtgJornadasFisio As DataGrid = CType(tpgFisio.Controls(0), DataGrid)
                                '    dtgJornadasFisio.SetDataBinding(dtJornadasFisio, String.Empty)

                                '    NovafisDataGrid.EstiloGrid(arrCamposJornadas, arrCabecerasJornadas, arrTiposDatosJornadas, arrAnchurasJornadas, dtgJornadasFisio, dtJornadasFisio.TableName)

                                '    dtJornadasFisio.Dispose()
                                'Next

                                dtgJornadas.SetDataBinding(TablaJornadas, String.Empty)
                                NovafisDataGrid.EstiloGrid(arrCamposJornadas, arrCabecerasJornadas, arrTiposDatosJornadas, arrAnchurasJornadas, dtgJornadas, "Jornadas")
                            End If
                        End If
                    End If

                    bOK = .CerrarConexion

                    If bOK Then
                        RemoveHandler dtpFechaIni.ValueChanged, AddressOf FiltrarFechas
                        RemoveHandler dtpFechaFin.ValueChanged, AddressOf FiltrarFechas

                        dtpFechaIni.Value = dtpFechaIni.MinDate
                        dtpFechaIni.Checked = False

                        dtpFechaFin.Value = DateTime.Today.AddMonths(1)
                        dtpFechaFin.Checked = False

                        AddHandler dtpFechaIni.ValueChanged, AddressOf FiltrarFechas
                        AddHandler dtpFechaFin.ValueChanged, AddressOf FiltrarFechas
                    End If
                End If
            End With

        Catch exError As Exception
            bOK = False

        Finally
            ' Descargar objetos
            TablaJornadas.Dispose()
            objBDatos.Dispose()

            'mOKModificarJornada()
        End Try

    End Sub

    Private Sub mConfigurarDetalleJornadas(ByVal iTipoMant As eTiposMantenimiento, ByVal iIDJornada As Integer)

        Dim objJornadasDetalle As New frmConfiguracionDetalle()

        With objJornadasDetalle
            '.IDFisio = Me.IDFisio
            .IDJornada = iIDJornada
            .TipoConfiguracion = eTiposConfiguracion.Jornada
            .TipoMantenimiento = iTipoMant
            '.Text += " - " + Me.NombreFisio.ToUpper

            If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                mLLenarJornadas()
            End If
        End With

    End Sub

    Private Sub mOKModificarJornada()

        'Dim objTabla As New DataTable()
        Dim bOK As Boolean

        'objTabla = CType(dtgJornadas.DataSource, DataTable)

        bOK = Not IsNothing(TablaJornadas)

        If bOK Then
            bOK = (TablaJornadas.Rows.Count > 0)
            'objTabla.Dispose()
        End If

        cmdModificarJornada.Enabled = bOK

    End Sub

#End Region

#End Region


#Region " TARIFAS "

    Private arrCamposTarifas() As String = {"TAR_VigenciaIni", "TAR_VigenciaFin", "TAR_Precio", "TAR_ID"}
    Private arrCabecerasTarifas() As String = {"Inicio Vigencia", "Fin Vigencia", "Precio (euros) ", String.Empty}
    Private arrTiposDatosTarifas() As String = {"F", "F", "M", "I"}
    Private arrAnchurasTarifas() As Integer = {110, 110, 120, 0}

#Region " CONTROLES "

    Private Sub ModificarTarifaSeleccionada(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgTarifas.DoubleClick
        If cmdModificarTarifa.Enabled Then
            cmdModificarTarifa.PerformClick()
        End If
    End Sub

    Private Sub SeleccionarUnaTarifa(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtgTarifas.MouseUp

        Dim objTest As DataGrid.HitTestInfo = dtgTarifas.HitTest(New Point(e.X, e.Y))

        ' Si es una celda
        If objTest.Type = DataGrid.HitTestType.Cell Then
            dtgTarifas.Select(objTest.Row)
        End If

        ' Habilitar el botón Modificar (Tarifas) cuando se seleccione una celda. No valen las cabeceras.
        cmdModificarTarifa.Enabled = (objTest.Type = DataGrid.HitTestType.Cell)

    End Sub


    Private Sub NuevaTarifa(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevaTarifa.Click
        mConfigurarDetalleTarifas(eTiposMantenimiento.Alta, 0)
    End Sub

    Private Sub ModificarTarifa(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificarTarifa.Click
        Dim iIDTarifa As Integer = Convert.ToInt32(dtgTarifas.Item(dtgTarifas.CurrentRowIndex, 3))
        mConfigurarDetalleTarifas(eTiposMantenimiento.Modificacion, iIDTarifa)
    End Sub

#End Region

#Region " FUNCIONES "

    Private Sub mLLenarTarifas()

        Dim objBDatos As New AccesoBD_MySQL()
        Dim dtTarifas As DataTable = New DataTable("Tarifas")
        Dim iNumTarifas As Integer
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
                        .Value = DBNull.Value
                        .Direction = ParameterDirection.Input
                    End With

                    bOK = .EjecutarSP("spTarifas_LLenar", arrParametros, dtTarifas, iNumTarifas)

                    If bOK Then
                        If Not IsNothing(dtTarifas) Then
                            If iNumTarifas > 0 Then
                                dtgTarifas.SetDataBinding(dtTarifas, String.Empty)

                                NovafisDataGrid.EstiloGrid(arrCamposTarifas, arrCabecerasTarifas, arrTiposDatosTarifas, arrAnchurasTarifas, dtgTarifas, "Tarifas")
                            End If
                        End If
                    End If

                    bOK = .CerrarConexion
                End If
            End With

        Catch exError As Exception
            bOK = False

        Finally
            ' Descargar objetos
            dtTarifas.Dispose()
            objBDatos.Dispose()

            mOKModificarTarifa()
        End Try

    End Sub

    Private Sub mConfigurarDetalleTarifas(ByVal iTipoMant As eTiposMantenimiento, ByVal iIDTarifa As Integer)

        Dim objTarifasDetalle As New frmConfiguracionDetalle()

        With objTarifasDetalle
            .IDTarifa = iIDTarifa
            .TipoConfiguracion = eTiposConfiguracion.Tarifa
            .TipoMantenimiento = iTipoMant

            If .ShowDialog() = DialogResult.OK Then
                mLLenarTarifas()
            End If
        End With

    End Sub

    Private Sub mOKModificarTarifa()

        Dim objTabla As New DataTable()
        Dim bOK As Boolean

        objTabla = CType(dtgTarifas.DataSource, DataTable)

        bOK = Not IsNothing(objTabla)

        If bOK Then
            bOK = (objTabla.Rows.Count > 0)
            objTabla.Dispose()
        End If

        cmdModificarTarifa.Enabled = bOK

    End Sub

#End Region


#End Region


#Region " COMUN "

    Private Sub CargarFormulario(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mLLenarJornadas()
        mLLenarTarifas()
    End Sub

    Private Sub Cerrar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click
        Me.Dispose()
    End Sub

#End Region


    Private Sub FiltrarFechas(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaIni.ValueChanged, dtpFechaFin.ValueChanged

        If TablaJornadas.Rows.Count > 0 Then
            'Dim tabFisios As TabControl = CType(grbJornadas.Controls(grbJornadas.Controls.Count - 1), TabControl)

            Dim sFiltroFecha As String = String.Empty

            'If dtpFechaIni.Checked And dtpFechaFin.Checked Then
            '    sFiltro = "JOR_Fecha >= '" & dtpFechaIni.Value.ToShortDateString & "' AND JOR_Fecha <= '" & dtpFechaFin.Value.ToShortDateString & "'"
            'End If

            If dtpFechaIni.Checked Then
                sFiltroFecha = "JOR_Fecha >= '" & dtpFechaIni.Value.ToShortDateString & "'"
            End If

            If dtpFechaFin.Checked Then
                If sFiltroFecha = String.Empty Then
                    sFiltroFecha = "JOR_Fecha <= '" & dtpFechaFin.Value.ToShortDateString & "'"
                Else
                    sFiltroFecha += " AND JOR_Fecha <= '" & dtpFechaFin.Value.ToShortDateString & "'"
                End If
            End If

            'For Each tpgFisio As TabPage In tabFisios.TabPages
            '    Dim dtJornadasFisio As DataTable = TablaJornadas.Clone
            '    dtJornadasFisio.TableName = "Jornadas" + tpgFisio.Text.ToUpper

            '    Dim sFiltroFisio As String = "FIS_ID = " + CInt(tpgFisio.Tag).ToString
            '    If Not sFiltroFecha.Equals(String.Empty) Then
            '        sFiltroFisio += " AND " + sFiltroFecha
            '    End If

            '    Dim arrJornadas As DataRow() = TablaJornadas.Select(sFiltroFisio, "JOR_Fecha")

            '    For Each drJornadaFisio As DataRow In arrJornadas
            '        dtJornadasFisio.ImportRow(drJornadaFisio)
            '    Next

            '    Dim dtgJornadasFisio As DataGrid = CType(tpgFisio.Controls(0), DataGrid)
            '    dtgJornadasFisio.SetDataBinding(dtJornadasFisio, String.Empty)
            '    NovafisDataGrid.EstiloGrid(arrCamposJornadas, arrCabecerasJornadas, arrTiposDatosJornadas, arrAnchurasJornadas, dtgJornadasFisio, dtJornadasFisio.TableName)

            '    dtJornadasFisio.Dispose()
            'Next

            Dim arrJornadas As DataRow() = TablaJornadas.Select(sFiltroFecha, "JOR_Fecha")

            If arrJornadas.Length > 0 Then
                Dim dtIntervaloJornadas As New DataTable("Intervalo")
                dtIntervaloJornadas = TablaJornadas.Clone

                For Each drFila As DataRow In arrJornadas
                    dtIntervaloJornadas.ImportRow(drFila)
                Next drFila

                dtgJornadas.SetDataBinding(dtIntervaloJornadas, String.Empty)

                'NovafisDataGrid.EstiloGrid(arrCamposJornadas, arrCabecerasJornadas, arrTiposDatosJornadas, arrAnchurasJornadas, dtgJornadas, "Jornadas")
            End If
        End If

    End Sub

End Class
