Option Strict On
Option Explicit On 

Public Class frmObservacionesDetalle

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
    Friend WithEvents lblPacienteRotulo As System.Windows.Forms.Label
    Friend WithEvents lblPaciente As System.Windows.Forms.Label
    Friend WithEvents lblObservacion As System.Windows.Forms.Label
    Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
    Friend WithEvents cmdCerrar As System.Windows.Forms.Button
    Friend WithEvents cmdGuardar As System.Windows.Forms.Button
    Friend WithEvents tipObservacionesDetalle As System.Windows.Forms.ToolTip
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblPacienteRotulo = New System.Windows.Forms.Label()
        Me.lblPaciente = New System.Windows.Forms.Label()
        Me.lblObservacion = New System.Windows.Forms.Label()
        Me.txtObservacion = New System.Windows.Forms.TextBox()
        Me.cmdCerrar = New System.Windows.Forms.Button()
        Me.cmdGuardar = New System.Windows.Forms.Button()
        Me.tipObservacionesDetalle = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblPacienteRotulo
        '
        Me.lblPacienteRotulo.AutoSize = True
        Me.lblPacienteRotulo.Location = New System.Drawing.Point(16, 16)
        Me.lblPacienteRotulo.Name = "lblPacienteRotulo"
        Me.lblPacienteRotulo.Size = New System.Drawing.Size(55, 13)
        Me.lblPacienteRotulo.TabIndex = 0
        Me.lblPacienteRotulo.Text = "Paciente"
        '
        'lblPaciente
        '
        Me.lblPaciente.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblPaciente.Location = New System.Drawing.Point(104, 16)
        Me.lblPaciente.Name = "lblPaciente"
        Me.lblPaciente.Size = New System.Drawing.Size(488, 23)
        Me.lblPaciente.TabIndex = 1
        '
        'lblObservacion
        '
        Me.lblObservacion.AutoSize = True
        Me.lblObservacion.Location = New System.Drawing.Point(16, 56)
        Me.lblObservacion.Name = "lblObservacion"
        Me.lblObservacion.Size = New System.Drawing.Size(83, 13)
        Me.lblObservacion.TabIndex = 2
        Me.lblObservacion.Text = "Observación:"
        '
        'txtObservacion
        '
        Me.txtObservacion.Location = New System.Drawing.Point(104, 56)
        Me.txtObservacion.MaxLength = 200
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservacion.Size = New System.Drawing.Size(488, 56)
        Me.txtObservacion.TabIndex = 3
        '
        'cmdCerrar
        '
        Me.cmdCerrar.Location = New System.Drawing.Point(512, 128)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(80, 32)
        Me.cmdCerrar.TabIndex = 5
        Me.cmdCerrar.Text = "Cerrar"
        Me.tipObservacionesDetalle.SetToolTip(Me.cmdCerrar, "Cerrar ventana actual")
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Location = New System.Drawing.Point(408, 128)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(80, 32)
        Me.cmdGuardar.TabIndex = 4
        Me.cmdGuardar.Text = "Guardar"
        Me.tipObservacionesDetalle.SetToolTip(Me.cmdGuardar, "Guardar Observación actual")
        '
        'frmObservacionesDetalle
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(610, 175)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdCerrar)
        Me.Controls.Add(Me.cmdGuardar)
        Me.Controls.Add(Me.txtObservacion)
        Me.Controls.Add(Me.lblObservacion)
        Me.Controls.Add(Me.lblPaciente)
        Me.Controls.Add(Me.lblPacienteRotulo)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmObservacionesDetalle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle de Observaciones"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Friend IDObservacion As Integer
    Friend IDPaciente As Integer
    Friend TipoMantenimiento As eTiposMantenimiento

    Private cteModulo As String = "Detalle de Observaciones"

    Private Sub CargarFormulario(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Select Case Me.TipoMantenimiento
            Case eTiposMantenimiento.Alta
                cmdGuardar.Enabled = False

            Case eTiposMantenimiento.Modificacion
                mLLenarObservacion()
        End Select

    End Sub

    Private Sub CambioTexto(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtObservacion.TextChanged
        mOKGuardar()
    End Sub

    Private Sub Guardar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        If mbGuardarObservacion() Then
            Me.DialogResult = DialogResult.OK
        Else
            Me.DialogResult = DialogResult.Cancel
        End If

        Me.Dispose()

    End Sub

    Private Sub Cerrar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click
        Me.Dispose()
    End Sub


    Private Sub mLLenarObservacion()

        Dim objBDatos As New AccesoBD_MySQL()
        Dim dtObservaciones As New DataTable()
        Dim iNumFilas As Integer
        Dim bOK As Boolean

        Try
            With objBDatos
                bOK = .AbrirConexion

                If bOK Then
                    Dim arrParametros(0) As MySqlParameter

                    arrParametros(0) = New MySqlParameter()
                    With arrParametros(0)
                        .ParameterName = "iIDObservacion"
                        .MySqlDbType = MySqlDbType.Int32
                        .Size = 4
                        .Value = Me.IDObservacion
                        .Direction = ParameterDirection.Input
                    End With

                    bOK = objBDatos.EjecutarSP("spObservaciones_LLenarDetalle", arrParametros, dtObservaciones, iNumFilas)

                    If bOK And Not IsNothing(dtObservaciones) Then
                        If iNumFilas = 1 Then
                            Dim drFila As DataRow = dtObservaciones.Rows(0)
                            txtObservacion.Text = drFila("PAO_Descripcion").ToString.Trim
                        End If
                    End If

                    bOK = .CerrarConexion
                End If
            End With

        Catch exError As Exception
            GestionarErrores(exError.Message, Me.Text, MessageBoxIcon.Error, EventLogEntryType.Error)

        Finally
            ' Descarga de objetos
            objBDatos.Dispose()

        End Try

    End Sub

    Private Function mbGuardarObservacion() As Boolean

        Dim objBDatos As New AccesoBD_MySQL()
        Dim sSQL As String = String.Empty
        Dim bOK As Boolean

        Try
            With objBDatos
                bOK = .AbrirConexion

                If bOK Then
                    bOK = .IniciarTransaccion

                    If bOK Then
                        Dim arrParametros(1) As MySqlParameter

                        arrParametros(0) = New MySqlParameter()
                        With arrParametros(0)
                            .ParameterName = "sObservacion"
                            .MySqlDbType = MySqlDbType.VarChar
                            .Size = 200
                            .Value = txtObservacion.Text.Trim
                            .Direction = ParameterDirection.Input
                        End With

                        Select Case Me.TipoMantenimiento
                            Case eTiposMantenimiento.Alta
                                arrParametros(1) = New MySqlParameter()
                                With arrParametros(1)
                                    .ParameterName = "iIDPaciente"
                                    .MySqlDbType = MySqlDbType.Int32
                                    .Size = 10
                                    .Value = Me.IDPaciente
                                    .Direction = ParameterDirection.Input
                                End With

                                bOK = .EjecutarSP("spObservaciones_Anadir", arrParametros)

                            Case eTiposMantenimiento.Modificacion
                                arrParametros(1) = New MySqlParameter()
                                With arrParametros(1)
                                    .ParameterName = "iIDObservacion"
                                    .MySqlDbType = MySqlDbType.Int32
                                    .Size = 10
                                    .Value = Me.IDObservacion
                                    .Direction = ParameterDirection.Input
                                End With

                                bOK = .EjecutarSP("spObservaciones_Modificar", arrParametros)

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


    Private Sub mOKGuardar()

        Dim bOK As Boolean

        bOK = (txtObservacion.Text.Trim.Length > 0)

        cmdGuardar.Enabled = bOK

    End Sub


End Class
