Option Strict On
Option Explicit On 

Public Class frmAnulaciones

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
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtMotivo As System.Windows.Forms.TextBox
    Friend WithEvents cmdCerrar As System.Windows.Forms.Button
    Friend WithEvents cmdGuardar As System.Windows.Forms.Button
    Friend WithEvents lblPaciente As System.Windows.Forms.Label
    Friend WithEvents txtPaciente As System.Windows.Forms.TextBox
    Friend WithEvents tipAnulaciones As System.Windows.Forms.ToolTip
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.txtMotivo = New System.Windows.Forms.TextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.cmdCerrar = New System.Windows.Forms.Button()
        Me.cmdGuardar = New System.Windows.Forms.Button()
        Me.lblPaciente = New System.Windows.Forms.Label()
        Me.txtPaciente = New System.Windows.Forms.TextBox()
        Me.tipAnulaciones = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(496, 16)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(42, 14)
        Me.lblFecha.TabIndex = 5
        Me.lblFecha.Text = "Fecha:"
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(24, 56)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(132, 14)
        Me.lblDescripcion.TabIndex = 4
        Me.lblDescripcion.Text = "Motivo de la Anulación"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMotivo
        '
        Me.txtMotivo.Location = New System.Drawing.Point(24, 80)
        Me.txtMotivo.MaxLength = 1000
        Me.txtMotivo.Multiline = True
        Me.txtMotivo.Name = "txtMotivo"
        Me.txtMotivo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMotivo.Size = New System.Drawing.Size(632, 72)
        Me.txtMotivo.TabIndex = 1
        Me.txtMotivo.Text = ""
        '
        'dtpFecha
        '
        Me.dtpFecha.CustomFormat = "dd/MM/yyyy"
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha.Location = New System.Drawing.Point(544, 16)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(112, 21)
        Me.dtpFecha.TabIndex = 0
        '
        'cmdCerrar
        '
        Me.cmdCerrar.Location = New System.Drawing.Point(576, 168)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(80, 32)
        Me.cmdCerrar.TabIndex = 3
        Me.cmdCerrar.Text = "Cerrar"
        Me.tipAnulaciones.SetToolTip(Me.cmdCerrar, "Cerrar ventana de Anulaciones")
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Location = New System.Drawing.Point(472, 168)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(80, 32)
        Me.cmdGuardar.TabIndex = 2
        Me.cmdGuardar.Text = "Guardar"
        Me.tipAnulaciones.SetToolTip(Me.cmdGuardar, "Guardar Anulación")
        '
        'lblPaciente
        '
        Me.lblPaciente.AutoSize = True
        Me.lblPaciente.Location = New System.Drawing.Point(24, 16)
        Me.lblPaciente.Name = "lblPaciente"
        Me.lblPaciente.Size = New System.Drawing.Size(57, 14)
        Me.lblPaciente.TabIndex = 5
        Me.lblPaciente.Text = "Paciente:"
        Me.lblPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPaciente
        '
        Me.txtPaciente.Location = New System.Drawing.Point(88, 16)
        Me.txtPaciente.MaxLength = 150
        Me.txtPaciente.Name = "txtPaciente"
        Me.txtPaciente.ReadOnly = True
        Me.txtPaciente.Size = New System.Drawing.Size(392, 21)
        Me.txtPaciente.TabIndex = 11
        Me.txtPaciente.Text = ""
        '
        'frmAnulaciones
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(674, 223)
        Me.ControlBox = False
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtPaciente, Me.cmdCerrar, Me.cmdGuardar, Me.lblFecha, Me.lblDescripcion, Me.txtMotivo, Me.dtpFecha, Me.lblPaciente})
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmAnulaciones"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Anulaciones"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private cteModulo As String = "Detalle de Anulaciones"

    Friend Paciente As String
    Friend IDPaciente As Integer
    Friend IDAnulacion As Integer
    Friend TipoMantenimiento As eTiposMantenimiento


#Region " CONTROLES "

    Private Sub CargarFormulario(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mInicializarFormulario()
    End Sub


    Private Sub CambioMotivo(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMotivo.TextChanged
        mOKGuardar()
    End Sub


    Private Sub GuardarAnulacion(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click

        If mbGuardarAnulacion() Then
            Me.DialogResult = DialogResult.OK
        Else
            Me.DialogResult = DialogResult.Cancel
        End If

        Me.Dispose()

    End Sub

    Private Sub Cerrar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click
        With Me
            .DialogResult = DialogResult.Cancel
            .Dispose()
        End With
    End Sub

#End Region


#Region " FUNCIONES "

    Private Sub mInicializarFormulario()

        txtPaciente.Text = Me.Paciente

        Select Case Me.TipoMantenimiento
            Case eTiposMantenimiento.Alta
                dtpFecha.Value = DateTime.Today

            Case eTiposMantenimiento.Modificacion
                mCargarAnulacion()
        End Select

    End Sub

    Private Sub mCargarAnulacion()

        Dim objBDatos As New AccesoBD_MySQL()
        Dim dtAnulacion As New DataTable()
        Dim sSQL As String = String.Empty
        Dim iNumFilas As Integer = 1
        Dim bOK As Boolean

        Try
            With objBDatos
                bOK = .AbrirConexion

                If bOK Then
                    Dim arrParametros(1) As MySqlParameter

                    arrParametros(0) = New MySqlParameter()
                    With arrParametros(0)
                        .ParameterName = "iIDPaciente"
                        .MySqlDbType = MySqlDbType.Int32
                        .Size = 10
                        .Value = Me.IDPaciente
                        .Direction = ParameterDirection.Input
                    End With

                    arrParametros(1) = New MySqlParameter()
                    With arrParametros(1)
                        .ParameterName = "iIDAnulacion"
                        .MySqlDbType = MySqlDbType.Int32
                        .Size = 10
                        .Value = Me.IDAnulacion
                        .Direction = ParameterDirection.Input
                    End With

                    bOK = objBDatos.EjecutarSP("spAnulaciones_LLenar", arrParametros, dtAnulacion, iNumFilas)

                    If bOK And Not IsNothing(dtAnulacion) Then
                        If iNumFilas = 1 Then
                            Dim drFilas As DataRow = dtAnulacion.Rows(0)
                            Dim iIndice As Integer
                            Dim bOKCombo As Boolean

                            txtPaciente.Text = Me.Paciente
                            dtpFecha.Value = DateTime.Parse(drFilas("PAA_Fecha").ToString)
                            txtMotivo.Text = drFilas("PAA_Motivo").ToString.Trim
                        End If
                    End If

                    bOK = .CerrarConexion
                End If
            End With

        Catch exError As Exception
            GestionarErrores(exError.Message, cteModulo, MessageBoxIcon.Error, EventLogEntryType.Error)

        Finally
            ' Descargar objetos
            dtAnulacion.Dispose()
            objBDatos.Dispose()

            mOKGuardar()

        End Try

    End Sub

    Private Sub mOKGuardar()

        Dim bOK As Boolean

        bOK = (txtMotivo.Text.Trim.Length > 0)

        cmdGuardar.Enabled = bOK

    End Sub

    Private Function mbGuardarAnulacion() As Boolean

        Dim objBDatos As New AccesoBD_MySQL()
        Dim sSQL As String = String.Empty
        Dim bOK As Boolean

        Try
            With objBDatos
                bOK = .AbrirConexion

                If bOK Then
                    bOK = .IniciarTransaccion

                    If bOK Then
                        Dim arrParametros(2) As MySqlParameter

                        arrParametros(0) = New MySqlParameter()
                        With arrParametros(0)
                            .ParameterName = "fFecha"
                            .MySqlDbType = MySqlDbType.Date
                            .Size = 8
                            .Value = dtpFecha.Value
                            .Direction = ParameterDirection.Input
                        End With

                        arrParametros(1) = New MySqlParameter()
                        With arrParametros(1)
                            .ParameterName = "sMotivo"
                            .MySqlDbType = MySqlDbType.VarChar
                            .Size = 1000
                            .Value = txtMotivo.Text.Trim
                            .Direction = ParameterDirection.Input
                        End With

                        Select Case Me.TipoMantenimiento
                            Case eTiposMantenimiento.Alta
                                arrParametros(2) = New MySqlParameter()
                                With arrParametros(2)
                                    .ParameterName = "iIDPaciente"
                                    .MySqlDbType = MySqlDbType.Int32
                                    .Size = 10
                                    .Value = Me.IDPaciente
                                    .Direction = ParameterDirection.Input
                                End With

                                bOK = .EjecutarSP("spAnulaciones_Anadir", arrParametros)

                            Case eTiposMantenimiento.Modificacion
                                arrParametros(2) = New MySqlParameter()
                                With arrParametros(2)
                                    .ParameterName = "iIDAnulacion"
                                    .MySqlDbType = MySqlDbType.Int32
                                    .Size = 10
                                    .Value = Me.IDAnulacion
                                    .Direction = ParameterDirection.Input
                                End With

                                bOK = .EjecutarSP("spAnulaciones_Modificar", arrParametros)

                        End Select

                        If bOK Then
                            bOK = .ConfirmarTransaccion
                        Else
                            bOK = .CancelarTransaccion
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
            objBDatos.Dispose()

        End Try

        Return bOK

    End Function

#End Region

End Class
