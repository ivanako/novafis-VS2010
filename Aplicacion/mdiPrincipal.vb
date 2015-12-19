Option Strict Off
Option Explicit On 

Public Class mdiPrincipal
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
    Friend WithEvents mnuVentanas As System.Windows.Forms.MenuItem
    Friend WithEvents mnuGranMenu As System.Windows.Forms.MainMenu
    Friend WithEvents mnuPrincipal As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPri_Pacientes As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPri_Citas As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPri_Sep1 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPri_Salir As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAcc_Configuracion As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAccesorios As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAcc_Patologias As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPri_Fisios As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAcc_Fuentes As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAcc_Facturacion As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAcc_Deudas As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAcc_Buscador As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAcc_ListaNegra As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAcc_Notas As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdiPrincipal))
        Me.mnuGranMenu = New System.Windows.Forms.MainMenu(Me.components)
        Me.mnuPrincipal = New System.Windows.Forms.MenuItem()
        Me.mnuPri_Citas = New System.Windows.Forms.MenuItem()
        Me.mnuPri_Pacientes = New System.Windows.Forms.MenuItem()
        Me.mnuPri_Fisios = New System.Windows.Forms.MenuItem()
        Me.mnuPri_Sep1 = New System.Windows.Forms.MenuItem()
        Me.mnuPri_Salir = New System.Windows.Forms.MenuItem()
        Me.mnuAccesorios = New System.Windows.Forms.MenuItem()
        Me.mnuAcc_Configuracion = New System.Windows.Forms.MenuItem()
        Me.mnuAcc_Patologias = New System.Windows.Forms.MenuItem()
        Me.mnuAcc_Notas = New System.Windows.Forms.MenuItem()
        Me.mnuAcc_Fuentes = New System.Windows.Forms.MenuItem()
        Me.mnuAcc_Facturacion = New System.Windows.Forms.MenuItem()
        Me.mnuAcc_Deudas = New System.Windows.Forms.MenuItem()
        Me.mnuAcc_Buscador = New System.Windows.Forms.MenuItem()
        Me.mnuAcc_ListaNegra = New System.Windows.Forms.MenuItem()
        Me.mnuVentanas = New System.Windows.Forms.MenuItem()
        Me.SuspendLayout()
        '
        'mnuGranMenu
        '
        Me.mnuGranMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuPrincipal, Me.mnuAccesorios, Me.mnuVentanas})
        '
        'mnuPrincipal
        '
        Me.mnuPrincipal.Index = 0
        Me.mnuPrincipal.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuPri_Citas, Me.mnuPri_Pacientes, Me.mnuPri_Fisios, Me.mnuPri_Sep1, Me.mnuPri_Salir})
        Me.mnuPrincipal.Text = "Principal"
        '
        'mnuPri_Citas
        '
        Me.mnuPri_Citas.Index = 0
        Me.mnuPri_Citas.Text = "Citas..."
        '
        'mnuPri_Pacientes
        '
        Me.mnuPri_Pacientes.Index = 1
        Me.mnuPri_Pacientes.Text = "Pacientes..."
        '
        'mnuPri_Fisios
        '
        Me.mnuPri_Fisios.Index = 2
        Me.mnuPri_Fisios.Text = "Fisioterapeutas..."
        '
        'mnuPri_Sep1
        '
        Me.mnuPri_Sep1.Index = 3
        Me.mnuPri_Sep1.Text = "-"
        '
        'mnuPri_Salir
        '
        Me.mnuPri_Salir.Index = 4
        Me.mnuPri_Salir.Text = "Salir"
        '
        'mnuAccesorios
        '
        Me.mnuAccesorios.Index = 1
        Me.mnuAccesorios.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuAcc_Configuracion, Me.mnuAcc_Patologias, Me.mnuAcc_Notas, Me.mnuAcc_Fuentes, Me.mnuAcc_Facturacion, Me.mnuAcc_Deudas, Me.mnuAcc_Buscador, Me.mnuAcc_ListaNegra})
        Me.mnuAccesorios.Text = "Accesorios"
        '
        'mnuAcc_Configuracion
        '
        Me.mnuAcc_Configuracion.Index = 0
        Me.mnuAcc_Configuracion.Text = "Configuración..."
        '
        'mnuAcc_Patologias
        '
        Me.mnuAcc_Patologias.Index = 1
        Me.mnuAcc_Patologias.Text = "Localizaciones y Lesiones..."
        '
        'mnuAcc_Notas
        '
        Me.mnuAcc_Notas.Index = 2
        Me.mnuAcc_Notas.Text = "Notas diarias..."
        '
        'mnuAcc_Fuentes
        '
        Me.mnuAcc_Fuentes.Index = 3
        Me.mnuAcc_Fuentes.Text = "Fuentes..."
        '
        'mnuAcc_Facturacion
        '
        Me.mnuAcc_Facturacion.Index = 4
        Me.mnuAcc_Facturacion.Text = "Facturación..."
        '
        'mnuAcc_Deudas
        '
        Me.mnuAcc_Deudas.Index = 5
        Me.mnuAcc_Deudas.Text = "Deudas pendientes..."
        '
        'mnuAcc_Buscador
        '
        Me.mnuAcc_Buscador.Index = 6
        Me.mnuAcc_Buscador.Text = "Buscador..."
        '
        'mnuAcc_ListaNegra
        '
        Me.mnuAcc_ListaNegra.Index = 7
        Me.mnuAcc_ListaNegra.Text = "Lista negra..."
        '
        'mnuVentanas
        '
        Me.mnuVentanas.Index = 2
        Me.mnuVentanas.MdiList = True
        Me.mnuVentanas.Text = "Ventanas"
        '
        'mdiPrincipal
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(488, 333)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Menu = Me.mnuGranMenu
        Me.Name = "mdiPrincipal"
        Me.Text = "NOVAFIS FISIOTERAPIA"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub CargarFormulario(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Citas(sender, e)
        'Dim objCitas As frmCitas = frmCitas.Instancia

        'With objCitas
        '    .MdiParent = Me
        '    .Show()
        'End With

        'Dim objPacientes As frmPacientes = frmPacientes.Instancia

        'With objPacientes
        '    .MdiParent = Me
        '    .Show()
        'End With

    End Sub


    Private Sub MantenimientoPacientes(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPri_Pacientes.Click

        Dim objPacientes As frmPacientes = frmPacientes.Instancia

        With objPacientes
            .MdiParent = Me
            .Show()
        End With

    End Sub

    Private Sub Citas(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPri_Citas.Click

        Dim objCitas As frmCitas = frmCitas.Instancia

        With objCitas
            .MdiParent = Me

            'Dim dtFisios As DataTable = CargarFisios()

            If tblFisios.Rows.Count > 0 Then
                Dim bPrimero As Boolean = True
                Dim iPosHorizontal As Integer = 10

                For Each drFisio As DataRow In tblFisios.Rows
                    Dim rdbFisio As New RadioButton
                    rdbFisio.Name = "chkFisio" + drFisio("FIS_Alias").ToString
                    rdbFisio.Text = drFisio("FIS_Alias").ToString.ToUpper.Trim
                    rdbFisio.Tag = drFisio("FIS_ID")
                    rdbFisio.Location = New Point(iPosHorizontal, 20)
                    rdbFisio.AutoSize = True

                    AddHandler rdbFisio.CheckedChanged, AddressOf .fisioChecked

                    rdbFisio.Checked = bPrimero

                    .grbFisios.Controls.Add(rdbFisio)

                    If bPrimero Then
                        .IDFisio = CInt(drFisio("FIS_ID"))
                        .NombreFisio = drFisio("FIS_Alias").ToString
                    End If

                    bPrimero = False
                    iPosHorizontal += 100
                Next
            End If

            .FormCargado = False

            '.grbJornadas.Controls.Add(tabFisios)

            .Show()
        End With

    End Sub

    Private Sub MantenimientoFisios(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPri_Fisios.Click

        Dim objFisios As frmFisioterapeutas = frmFisioterapeutas.Instancia

        With objFisios
            .MdiParent = Me
            .Show()
        End With

    End Sub


    Private Sub Configuracion(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAcc_Configuracion.Click

        Dim objJornadas As frmConfiguracion = frmConfiguracion.Instancia

        With objJornadas
            .MdiParent = Me

            '' Crear control de pestañas
            'Dim tabFisios As New TabControl
            'tabFisios.Name = "tabFisios"
            'tabFisios.Location = New Point(16, 61)
            'tabFisios.Size = New Size(480, 300)
            'tabFisios.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            'tabFisios.DrawMode = TabDrawMode.OwnerDrawFixed
            'tabFisios.Padding = New Point(15, 5)
            'AddHandler tabFisios.Selecting, AddressOf .SelectingFisio
            'AddHandler tabFisios.DrawItem, AddressOf .DrawingTabPage

            'Dim dtFisios As DataTable = CargarFisios()

            'If dtFisios.Rows.Count > 0 Then
            '    Dim bPrimero As Boolean = True

            '    For Each drFisio As DataRow In dtFisios.Rows
            '        Dim tpgFisio As New TabPage
            '        tpgFisio.Name = "tpgFisio" + drFisio("FIS_Alias").ToString
            '        tpgFisio.Text = drFisio("FIS_Alias").ToString.ToUpper
            '        tpgFisio.Tag = drFisio("FIS_ID")

            '        Dim dtgFisio As New DataGrid
            '        dtgFisio.Name = "dtgJornadas" + drFisio("FIS_Alias").ToString
            '        dtgFisio.CaptionText = "Jornadas Laborales"
            '        dtgFisio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            '        dtgFisio.ReadOnly = True
            '        dtgFisio.Location = New Point(5, 5)
            '        dtgFisio.Size = New Size(190, 90)
            '        AddHandler dtgFisio.MouseUp, AddressOf .SeleccionarUnaJornada
            '        AddHandler dtgFisio.DoubleClick, AddressOf .ModificarJornadaSeleccionada

            '        tpgFisio.Controls.Add(dtgFisio)
            '        tabFisios.Controls.Add(tpgFisio)

            '        If bPrimero Then
            '            .IDFisio = CInt(drFisio("FIS_ID"))
            '            .NombreFisio = drFisio("FIS_Alias").ToString
            '        End If

            '        bPrimero = False
            '    Next
            'End If

            '.grbJornadas.Controls.Add(tabFisios)

            .Show()
        End With

    End Sub


    Private Sub MenuSalir(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPri_Salir.Click
        mSalirAplicacion()
    End Sub

    Private Sub CerrarMDI(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = Not mSalirAplicacion()
    End Sub


    Private Function mSalirAplicacion() As Boolean

        If MessageBox.Show("¿Desea salir de la Aplicación?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        Else
            Return False
        End If

    End Function



    Private Sub Localizaciones_Lesiones(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAcc_Patologias.Click

        Dim objPatologias As frmPatologias = frmPatologias.Instancia

        With objPatologias
            .MdiParent = Me
            .Show()
        End With

    End Sub

    Private Sub NotasDiarias(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAcc_Notas.Click

        Dim objNotas As frmNotas = frmNotas.Instancia

        With objNotas
            .MdiParent = Me
            .TipoMant = eTiposMantenimiento.Alta
            .Show()
        End With

    End Sub

    Private Sub mnuAcc_Fuentes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAcc_Fuentes.Click

        Dim objFuentes As frmFuentes = frmFuentes.Instancia

        With objFuentes
            .MdiParent = Me
            .Show()
        End With

    End Sub

    Private Sub mnuAcc_Facturacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAcc_Facturacion.Click

        Dim objFacturacion As frmFacturacion = frmFacturacion.Instancia

        With objFacturacion
            .MdiParent = Me
            .Show()
        End With

    End Sub

    Private Sub mnuAcc_Deudas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAcc_Deudas.Click

        Dim objDeudas As frmDeudas = frmDeudas.Instancia

        With objDeudas
            .MdiParent = Me
            .Show()
        End With

    End Sub

    Private Sub mnuAcc_Buscador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAcc_Buscador.Click

        Dim objBuscador As frmBuscador = frmBuscador.Instancia

        With objBuscador
            .MdiParent = Me
            .Show()
        End With

    End Sub

    Private Sub mnuAcc_ListaNegra_Click(sender As System.Object, e As System.EventArgs) Handles mnuAcc_ListaNegra.Click

        Dim objListaNegra As frmListaNegra = frmListaNegra.Instancia

        With objListaNegra
            .MdiParent = Me
            .Show()
        End With

    End Sub

End Class
