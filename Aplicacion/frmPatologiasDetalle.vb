Option Strict On
Option Explicit On 

Public Class frmPatologiasDetalle

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
    Friend WithEvents lblPatologia As System.Windows.Forms.Label
    Friend WithEvents txtPatologia As System.Windows.Forms.TextBox
    Friend WithEvents cmdGuardar As System.Windows.Forms.Button
    Friend WithEvents cmdCerrar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblPatologia = New System.Windows.Forms.Label()
        Me.txtPatologia = New System.Windows.Forms.TextBox()
        Me.cmdGuardar = New System.Windows.Forms.Button()
        Me.cmdCerrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPatologia
        '
        Me.lblPatologia.AutoSize = True
        Me.lblPatologia.Location = New System.Drawing.Point(16, 16)
        Me.lblPatologia.Name = "lblPatologia"
        Me.lblPatologia.Size = New System.Drawing.Size(56, 14)
        Me.lblPatologia.TabIndex = 0
        Me.lblPatologia.Text = "Patología"
        '
        'txtPatologia
        '
        Me.txtPatologia.Location = New System.Drawing.Point(16, 40)
        Me.txtPatologia.MaxLength = 100
        Me.txtPatologia.Multiline = True
        Me.txtPatologia.Name = "txtPatologia"
        Me.txtPatologia.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPatologia.Size = New System.Drawing.Size(376, 40)
        Me.txtPatologia.TabIndex = 1
        Me.txtPatologia.Text = ""
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Enabled = False
        Me.cmdGuardar.Location = New System.Drawing.Point(232, 104)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(72, 24)
        Me.cmdGuardar.TabIndex = 5
        Me.cmdGuardar.Text = "Guardar"
        '
        'cmdCerrar
        '
        Me.cmdCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCerrar.Location = New System.Drawing.Point(320, 104)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(72, 24)
        Me.cmdCerrar.TabIndex = 6
        Me.cmdCerrar.Text = "Cerrar"
        '
        'frmPatologiasDetalle
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.cmdCerrar
        Me.ClientSize = New System.Drawing.Size(408, 149)
        Me.ControlBox = False
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.cmdGuardar, Me.cmdCerrar, Me.txtPatologia, Me.lblPatologia})
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmPatologiasDetalle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPatologiasDetalle"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Const cteModulo As String = "Patología"

    Friend TipoPatologia As eTiposPatologia
    Friend TipoMantenimiento As eTiposMantenimiento

    Friend IDLocalizacion As Integer
    Friend IDLesion As Integer


#Region " COMUN "

#Region " CONTROLES "

    Private Sub CargarFormulario(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Select Case Me.TipoPatologia
            Case eTiposPatologia.Localizacion
                mConfigurarFormularioLocalizaciones()

            Case eTiposPatologia.Lesion
                mConfigurarFormularioLesiones()
        End Select

    End Sub


    Private Sub CambioTexto(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPatologia.TextChanged
        mOKGuardar()
    End Sub


    Private Sub GuardarConfiguracion(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click

        Dim bOK As Boolean

        If Me.TipoPatologia = eTiposPatologia.Localizacion Then
            bOK = GuardarLocalizacion(Me.TipoMantenimiento, txtPatologia.Text.Trim, Me.IDLocalizacion)
        ElseIf Me.TipoPatologia = eTiposPatologia.Lesion Then
            bOK = GuardarLesion(Me.TipoMantenimiento, txtPatologia.Text.Trim, Me.IDLesion)
        End If

        If bOK Then
            With Me
                .DialogResult = DialogResult.OK
                .Dispose()
            End With
        End If

    End Sub

    Private Sub Cerrar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click
        With Me
            .DialogResult = DialogResult.Cancel
            .Dispose()
        End With
    End Sub

#End Region

#Region " FUNCIONES "

    Private Sub mOKGuardar()

        Dim bOK As Boolean

        bOK = (txtPatologia.Text.Trim.Length > 0)

        cmdGuardar.Enabled = bOK

    End Sub

#End Region

#End Region


#Region " LOCALIZACIONES "

#Region " FUNCIONES "

    Private Sub mConfigurarFormularioLocalizaciones()

        Select Case Me.TipoMantenimiento
            Case eTiposMantenimiento.Alta
                txtPatologia.Text = String.Empty

            Case eTiposMantenimiento.Modificacion
                mLLenarLocalizacion()

        End Select

    End Sub

    Private Sub mLLenarLocalizacion()

        Dim objBDatos As New AccesoBD_MySQL()
        Dim dtLocalizacion As DataTable = New DataTable("Localizacion")
        Dim iNumLocalizaciones As Integer = 0
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
                        .Value = Me.IDLocalizacion
                        .Direction = ParameterDirection.Input
                    End With

                    bOK = .EjecutarSP("spLocalizaciones_LLenar", arrParametros, dtLocalizacion, iNumLocalizaciones)

                    If bOK And iNumLocalizaciones = 1 Then
                        Dim drLocalizacion As DataRow = dtLocalizacion.Rows(0)
                        txtPatologia.Text = drLocalizacion("LOC_Descripcion").ToString
                    End If

                    bOK = .CerrarConexion
                End If
            End With

        Catch exError As Exception
            Dim sOrigen As String = cteModulo & " - Localización"

            GestionarErrores(exError.Message, sOrigen, MessageBoxIcon.Error, EventLogEntryType.Error)

        Finally
            ' Descargar objetos
            dtLocalizacion.Dispose()
            objBDatos.Dispose()

        End Try

    End Sub


#End Region

#End Region


#Region " LESIONES "

#Region " FUNCIONES "

    Private Sub mConfigurarFormularioLesiones()

        Select Case Me.TipoMantenimiento
            Case eTiposMantenimiento.Alta
                txtPatologia.Text = String.Empty

            Case eTiposMantenimiento.Modificacion
                mLLenarLesion()

        End Select

    End Sub

    Private Sub mLLenarLesion()

        Dim objBDatos As New AccesoBD_MySQL()
        Dim dtLesion As DataTable = New DataTable("Lesion")
        Dim iNumLesiones As Integer = 0
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
                        .Value = Me.IDLesion
                        .Direction = ParameterDirection.Input
                    End With

                    bOK = .EjecutarSP("spLesiones_LLenar", arrParametros, dtLesion, iNumLesiones)

                    If bOK And iNumLesiones = 1 Then
                        Dim drLesion As DataRow = dtLesion.Rows(0)
                        txtPatologia.Text = drLesion("LES_Descripcion").ToString
                    End If

                    bOK = .CerrarConexion
                End If
            End With

        Catch exError As Exception
            Dim sOrigen As String = cteModulo & " - Lesión"

            GestionarErrores(exError.Message, sOrigen, MessageBoxIcon.Error, EventLogEntryType.Error)

        Finally
            ' Descargar objetos
            dtLesion.Dispose()
            objBDatos.Dispose()

        End Try

    End Sub

#End Region

#End Region


End Class
