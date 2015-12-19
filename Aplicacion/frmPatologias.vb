Option Strict On
Option Explicit On 

Public Class frmPatologias

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
    Friend WithEvents grbLocalizaciones As System.Windows.Forms.GroupBox
    Friend WithEvents cmdNuevaLocalizacion As System.Windows.Forms.Button
    Friend WithEvents dtgLocalizaciones As System.Windows.Forms.DataGrid
    Friend WithEvents tipPatologias As System.Windows.Forms.ToolTip
    Friend WithEvents cmdModificarLocalizacion As System.Windows.Forms.Button
    Friend WithEvents grbLesiones As System.Windows.Forms.GroupBox
    Friend WithEvents cmdNuevaLesion As System.Windows.Forms.Button
    Friend WithEvents cmdModificarLesion As System.Windows.Forms.Button
    Friend WithEvents dtgLesiones As System.Windows.Forms.DataGrid
    Friend WithEvents cmdCerrar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.grbLocalizaciones = New System.Windows.Forms.GroupBox()
        Me.cmdNuevaLocalizacion = New System.Windows.Forms.Button()
        Me.cmdModificarLocalizacion = New System.Windows.Forms.Button()
        Me.dtgLocalizaciones = New System.Windows.Forms.DataGrid()
        Me.tipPatologias = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdNuevaLesion = New System.Windows.Forms.Button()
        Me.cmdModificarLesion = New System.Windows.Forms.Button()
        Me.grbLesiones = New System.Windows.Forms.GroupBox()
        Me.dtgLesiones = New System.Windows.Forms.DataGrid()
        Me.cmdCerrar = New System.Windows.Forms.Button()
        Me.grbLocalizaciones.SuspendLayout()
        CType(Me.dtgLocalizaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbLesiones.SuspendLayout()
        CType(Me.dtgLesiones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grbLocalizaciones
        '
        Me.grbLocalizaciones.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.grbLocalizaciones.Controls.AddRange(New System.Windows.Forms.Control() {Me.cmdNuevaLocalizacion, Me.cmdModificarLocalizacion, Me.dtgLocalizaciones})
        Me.grbLocalizaciones.Location = New System.Drawing.Point(16, 24)
        Me.grbLocalizaciones.Name = "grbLocalizaciones"
        Me.grbLocalizaciones.Size = New System.Drawing.Size(632, 256)
        Me.grbLocalizaciones.TabIndex = 7
        Me.grbLocalizaciones.TabStop = False
        Me.grbLocalizaciones.Text = " Localizaciones "
        '
        'cmdNuevaLocalizacion
        '
        Me.cmdNuevaLocalizacion.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.cmdNuevaLocalizacion.Location = New System.Drawing.Point(536, 30)
        Me.cmdNuevaLocalizacion.Name = "cmdNuevaLocalizacion"
        Me.cmdNuevaLocalizacion.Size = New System.Drawing.Size(80, 32)
        Me.cmdNuevaLocalizacion.TabIndex = 6
        Me.cmdNuevaLocalizacion.Text = "Nueva..."
        Me.tipPatologias.SetToolTip(Me.cmdNuevaLocalizacion, "Registrar nueva Localización")
        '
        'cmdModificarLocalizacion
        '
        Me.cmdModificarLocalizacion.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.cmdModificarLocalizacion.Location = New System.Drawing.Point(536, 78)
        Me.cmdModificarLocalizacion.Name = "cmdModificarLocalizacion"
        Me.cmdModificarLocalizacion.Size = New System.Drawing.Size(80, 32)
        Me.cmdModificarLocalizacion.TabIndex = 8
        Me.cmdModificarLocalizacion.Text = "Modificar..."
        Me.tipPatologias.SetToolTip(Me.cmdModificarLocalizacion, "Modificar Localización seleccionada")
        '
        'dtgLocalizaciones
        '
        Me.dtgLocalizaciones.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.dtgLocalizaciones.CaptionText = "Localizaciones"
        Me.dtgLocalizaciones.DataMember = ""
        Me.dtgLocalizaciones.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dtgLocalizaciones.Location = New System.Drawing.Point(16, 30)
        Me.dtgLocalizaciones.Name = "dtgLocalizaciones"
        Me.dtgLocalizaciones.ReadOnly = True
        Me.dtgLocalizaciones.Size = New System.Drawing.Size(504, 210)
        Me.dtgLocalizaciones.TabIndex = 1
        '
        'cmdNuevaLesion
        '
        Me.cmdNuevaLesion.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.cmdNuevaLesion.Location = New System.Drawing.Point(536, 31)
        Me.cmdNuevaLesion.Name = "cmdNuevaLesion"
        Me.cmdNuevaLesion.Size = New System.Drawing.Size(80, 32)
        Me.cmdNuevaLesion.TabIndex = 6
        Me.cmdNuevaLesion.Text = "Nueva..."
        Me.tipPatologias.SetToolTip(Me.cmdNuevaLesion, "Registrar nueva Lesión")
        '
        'cmdModificarLesion
        '
        Me.cmdModificarLesion.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.cmdModificarLesion.Location = New System.Drawing.Point(536, 79)
        Me.cmdModificarLesion.Name = "cmdModificarLesion"
        Me.cmdModificarLesion.Size = New System.Drawing.Size(80, 32)
        Me.cmdModificarLesion.TabIndex = 8
        Me.cmdModificarLesion.Text = "Modificar..."
        Me.tipPatologias.SetToolTip(Me.cmdModificarLesion, "Modificar Lesión seleccionada")
        '
        'grbLesiones
        '
        Me.grbLesiones.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.grbLesiones.Controls.AddRange(New System.Windows.Forms.Control() {Me.cmdNuevaLesion, Me.cmdModificarLesion, Me.dtgLesiones})
        Me.grbLesiones.Location = New System.Drawing.Point(16, 320)
        Me.grbLesiones.Name = "grbLesiones"
        Me.grbLesiones.Size = New System.Drawing.Size(632, 256)
        Me.grbLesiones.TabIndex = 7
        Me.grbLesiones.TabStop = False
        Me.grbLesiones.Text = " Lesiones "
        '
        'dtgLesiones
        '
        Me.dtgLesiones.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.dtgLesiones.CaptionText = "Lesiones"
        Me.dtgLesiones.DataMember = ""
        Me.dtgLesiones.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dtgLesiones.Location = New System.Drawing.Point(16, 31)
        Me.dtgLesiones.Name = "dtgLesiones"
        Me.dtgLesiones.ReadOnly = True
        Me.dtgLesiones.Size = New System.Drawing.Size(504, 209)
        Me.dtgLesiones.TabIndex = 1
        '
        'cmdCerrar
        '
        Me.cmdCerrar.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.cmdCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCerrar.Location = New System.Drawing.Point(568, 592)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(80, 32)
        Me.cmdCerrar.TabIndex = 8
        Me.cmdCerrar.Text = "Cerrar"
        '
        'frmPatologias
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.cmdCerrar
        Me.ClientSize = New System.Drawing.Size(672, 637)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.cmdCerrar, Me.grbLocalizaciones, Me.grbLesiones})
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmPatologias"
        Me.Text = "Localizaciones y Lesiones"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grbLocalizaciones.ResumeLayout(False)
        CType(Me.dtgLocalizaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbLesiones.ResumeLayout(False)
        CType(Me.dtgLesiones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Const cteModulo As String = "Localizaciones y Lesiones"

    'Variable para controlar el número de instancias abiertas
    Private Shared objInstancia As frmPatologias = Nothing

    'Función que crea una sola instancia del formulario de Patologías
    Public Shared Function Instancia() As frmPatologias

        If IsNothing(objInstancia) OrElse objInstancia.IsDisposed = True Then
            objInstancia = New frmPatologias()
        End If

        objInstancia.BringToFront()

        Return objInstancia

    End Function


#Region " COMUN "

    Private Sub CargarFormulario(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mLLenarLocalizaciones()
        mLLenarLesiones()
    End Sub

    Private Sub Cerrar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click
        Me.Dispose()
    End Sub

#End Region


#Region " LOCALIZACIONES "

    Private arrCamposLocalizaciones() As String = {"LOC_Descripcion", "LOC_ID"}
    Private arrCabecerasLocalizaciones() As String = {"Descripción", String.Empty}
    Private arrTiposDatosLocalizaciones() As String = {"S", "I"}
    Private arrAnchurasLocalizaciones() As Integer = {500, 0}

#Region " CONTROLES "

    Private Sub ModificarLocalizacionSeleccionada(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgLocalizaciones.DoubleClick
        If cmdModificarLocalizacion.Enabled Then
            cmdModificarLocalizacion.PerformClick()
        End If
    End Sub

    Private Sub SeleccionarUnaLocalizacion(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtgLocalizaciones.MouseUp

        Dim objTest As DataGrid.HitTestInfo = dtgLocalizaciones.HitTest(New Point(e.X, e.Y))

        ' Si es una celda
        If objTest.Type = DataGrid.HitTestType.Cell Then
            dtgLocalizaciones.Select(objTest.Row)
        End If

        ' Habilitar el botón Modificar (Localizaciones) cuando se seleccione una celda. No valen las cabeceras.
        cmdModificarLocalizacion.Enabled = (objTest.Type = DataGrid.HitTestType.Cell)

    End Sub


    Private Sub NuevaLocalizacion(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevaLocalizacion.Click
        mConfigurarDetalleLocalizaciones(eTiposMantenimiento.Alta, 0)
    End Sub

    Private Sub ModificarLocalizacion(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificarLocalizacion.Click
        Dim iIDLocalizacion As Integer = Convert.ToInt32(dtgLocalizaciones.Item(dtgLocalizaciones.CurrentRowIndex, 1))
        mConfigurarDetalleLocalizaciones(eTiposMantenimiento.Modificacion, iIDLocalizacion)
    End Sub

#End Region

#Region " FUNCIONES "

    Private Sub mLLenarLocalizaciones()

        Dim objBDatos As New AccesoBD_MySQL()
        Dim dtLocalizaciones As DataTable = New DataTable("Localizaciones")
        Dim iNumLocalizaciones As Integer
        Dim bOK As Boolean

        Try
            With objBDatos
                bOK = .AbrirConexion()

                If bOK Then
                    Dim arrParametros(0) As MySqlParameter

                    arrParametros(0) = New MySqlParameter()
                    With arrParametros(0)
                        .ParameterName = "iIDLocalizacion"
                        .MySqlDbType = MySqlDbType.Int32
                        .Size = 4
                        .Value = DBNull.Value
                        .Direction = ParameterDirection.Input
                    End With

                    bOK = .EjecutarSP("spLocalizaciones_LLenar", arrParametros, dtLocalizaciones, iNumLocalizaciones)

                    If bOK Then
                        If Not IsNothing(dtLocalizaciones) Then
                            If iNumLocalizaciones > 0 Then
                                dtgLocalizaciones.SetDataBinding(dtLocalizaciones, String.Empty)

                                NovafisDataGrid.EstiloGrid(arrCamposLocalizaciones, arrCabecerasLocalizaciones, arrTiposDatosLocalizaciones, arrAnchurasLocalizaciones, dtgLocalizaciones, "Localizaciones")
                            End If
                        End If
                    End If

                    bOK = .CerrarConexion
                End If
            End With

        Catch exError As Exception
            GestionarErrores(exError.Message, cteModulo, MessageBoxIcon.Error, EventLogEntryType.Error)

            bOK = False

        Finally
            ' Descargar objetos
            dtLocalizaciones.Dispose()
            objBDatos.Dispose()

            mOKModificarLocalizacion()
        End Try

    End Sub

    Private Sub mConfigurarDetalleLocalizaciones(ByVal iTipoMant As eTiposMantenimiento, ByVal iIDLocalizacion As Integer)

        Dim objLocalizacionesDetalle As New frmPatologiasDetalle()

        With objLocalizacionesDetalle
            .IDLocalizacion = iIDLocalizacion
            .TipoPatologia = eTiposPatologia.Localizacion
            .TipoMantenimiento = iTipoMant
            .Text = "Detalle de Localizaciones"
            .lblPatologia.Text = "Localización:"

            If .ShowDialog() = DialogResult.OK Then
                mLLenarLocalizaciones()
            End If
        End With

    End Sub

    Private Sub mOKModificarLocalizacion()

        Dim objTabla As New DataTable()
        Dim bOK As Boolean

        objTabla = CType(dtgLocalizaciones.DataSource, DataTable)

        bOK = Not IsNothing(objTabla)

        If bOK Then
            bOK = (objTabla.Rows.Count > 0)
            objTabla.Dispose()
        End If

        cmdModificarLocalizacion.Enabled = bOK

    End Sub

#End Region

#End Region


#Region " LESIONES "

    Private arrCamposLesiones() As String = {"LES_Descripcion", "LES_ID"}
    Private arrCabecerasLesiones() As String = {"Descripción", String.Empty}
    Private arrTiposDatosLesiones() As String = {"S", "I"}
    Private arrAnchurasLesiones() As Integer = {500, 0}

#Region " CONTROLES "

    Private Sub ModificarLesionSeleccionada(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgLesiones.DoubleClick
        If cmdModificarLesion.Enabled Then
            cmdModificarLesion.PerformClick()
        End If
    End Sub

    Private Sub SeleccionarUnaLesion(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtgLesiones.MouseUp

        Dim objTest As DataGrid.HitTestInfo = dtgLesiones.HitTest(New Point(e.X, e.Y))

        ' Si es una celda
        If objTest.Type = DataGrid.HitTestType.Cell Then
            dtgLesiones.Select(objTest.Row)
        End If

        ' Habilitar el botón Modificar (Lesiones) cuando se seleccione una celda. No valen las cabeceras.
        cmdModificarLesion.Enabled = (objTest.Type = DataGrid.HitTestType.Cell)

    End Sub


    Private Sub NuevaLesion(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevaLesion.Click
        mConfigurarDetalleLesiones(eTiposMantenimiento.Alta, 0)
    End Sub

    Private Sub ModificarLesion(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificarLesion.Click
        Dim iIDLesion As Integer = Convert.ToInt32(dtgLesiones.Item(dtgLesiones.CurrentRowIndex, 1))
        mConfigurarDetalleLesiones(eTiposMantenimiento.Modificacion, iIDLesion)
    End Sub

#End Region

#Region " FUNCIONES "

    Private Sub mLLenarLesiones()

        Dim objBDatos As New AccesoBD_MySQL()
        Dim dtLesiones As DataTable = New DataTable("Lesiones")
        Dim iNumLesiones As Integer
        Dim bOK As Boolean

        Try
            With objBDatos
                bOK = .AbrirConexion()

                If bOK Then
                    Dim arrParametros(0) As MySqlParameter

                    arrParametros(0) = New MySqlParameter()
                    With arrParametros(0)
                        .ParameterName = "iIDLesion"
                        .MySqlDbType = MySqlDbType.Int32
                        .Size = 4
                        .Value = DBNull.Value
                        .Direction = ParameterDirection.Input
                    End With

                    bOK = .EjecutarSP("spLesiones_LLenar", arrParametros, dtLesiones, iNumLesiones)

                    If bOK Then
                        If Not IsNothing(dtLesiones) Then
                            If iNumLesiones > 0 Then
                                dtgLesiones.SetDataBinding(dtLesiones, String.Empty)

                                NovafisDataGrid.EstiloGrid(arrCamposLesiones, arrCabecerasLesiones, arrTiposDatosLesiones, arrAnchurasLesiones, dtgLesiones, "Lesiones")
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
            dtLesiones.Dispose()
            objBDatos.Dispose()

            mOKModificarTarifa()
        End Try

    End Sub

    Private Sub mConfigurarDetalleLesiones(ByVal iTipoMant As eTiposMantenimiento, ByVal iIDLesion As Integer)

        Dim objTarifasDetalle As New frmPatologiasDetalle()

        With objTarifasDetalle
            .IDLesion = iIDLesion
            .TipoPatologia = eTiposPatologia.Lesion
            .TipoMantenimiento = iTipoMant
            .Text = "Detalle de Lesiones"
            .lblPatologia.Text = "Lesión:"

            If .ShowDialog() = DialogResult.OK Then
                mLLenarLesiones()
            End If
        End With

    End Sub

    Private Sub mOKModificarTarifa()

        Dim objTabla As New DataTable()
        Dim bOK As Boolean

        objTabla = CType(dtgLesiones.DataSource, DataTable)

        bOK = Not IsNothing(objTabla)

        If bOK Then
            bOK = (objTabla.Rows.Count > 0)
            objTabla.Dispose()
        End If

        cmdModificarLesion.Enabled = bOK

    End Sub

#End Region

#End Region


End Class
