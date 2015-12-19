Option Strict On
Option Explicit On 

Public Class frmCitasDetalle

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
    Friend WithEvents lblFechaCartel As System.Windows.Forms.Label
    Friend WithEvents lblHoraCartel As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents lblHora As System.Windows.Forms.Label
    Friend WithEvents lblPaciente As System.Windows.Forms.Label
    Friend WithEvents txtPaciente As System.Windows.Forms.TextBox
    Friend WithEvents cmdBPacientes As System.Windows.Forms.Button
    Friend WithEvents chkAnular As System.Windows.Forms.CheckBox
    Friend WithEvents txtAnulacion As System.Windows.Forms.TextBox
    Friend WithEvents grbContabilidad As System.Windows.Forms.GroupBox
    Friend WithEvents nudCobrado As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblCobrado As System.Windows.Forms.Label
    Friend WithEvents lblEuros1 As System.Windows.Forms.Label
    Friend WithEvents lblDeuda As System.Windows.Forms.Label
    Friend WithEvents lblEuros2 As System.Windows.Forms.Label
    Friend WithEvents nudDeuda As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
    Friend WithEvents lblObservacion As System.Windows.Forms.Label
    Friend WithEvents cmdGuardar As System.Windows.Forms.Button
    Friend WithEvents cmdCerrar As System.Windows.Forms.Button
    Friend WithEvents cmdPaciente As System.Windows.Forms.Button
    Friend WithEvents cboFisios As System.Windows.Forms.ComboBox
    Friend WithEvents lblFisio As System.Windows.Forms.Label
    Friend WithEvents tipCitasDetalle As System.Windows.Forms.ToolTip
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblFechaCartel = New System.Windows.Forms.Label()
        Me.lblHoraCartel = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.lblPaciente = New System.Windows.Forms.Label()
        Me.txtPaciente = New System.Windows.Forms.TextBox()
        Me.cmdBPacientes = New System.Windows.Forms.Button()
        Me.chkAnular = New System.Windows.Forms.CheckBox()
        Me.txtAnulacion = New System.Windows.Forms.TextBox()
        Me.grbContabilidad = New System.Windows.Forms.GroupBox()
        Me.nudDeuda = New System.Windows.Forms.NumericUpDown()
        Me.nudCobrado = New System.Windows.Forms.NumericUpDown()
        Me.lblCobrado = New System.Windows.Forms.Label()
        Me.lblEuros1 = New System.Windows.Forms.Label()
        Me.lblDeuda = New System.Windows.Forms.Label()
        Me.lblEuros2 = New System.Windows.Forms.Label()
        Me.txtObservacion = New System.Windows.Forms.TextBox()
        Me.lblObservacion = New System.Windows.Forms.Label()
        Me.cmdGuardar = New System.Windows.Forms.Button()
        Me.cmdCerrar = New System.Windows.Forms.Button()
        Me.cmdPaciente = New System.Windows.Forms.Button()
        Me.tipCitasDetalle = New System.Windows.Forms.ToolTip(Me.components)
        Me.cboFisios = New System.Windows.Forms.ComboBox()
        Me.lblFisio = New System.Windows.Forms.Label()
        Me.grbContabilidad.SuspendLayout()
        CType(Me.nudDeuda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCobrado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFechaCartel
        '
        Me.lblFechaCartel.Location = New System.Drawing.Point(32, 16)
        Me.lblFechaCartel.Name = "lblFechaCartel"
        Me.lblFechaCartel.Size = New System.Drawing.Size(48, 16)
        Me.lblFechaCartel.TabIndex = 7
        Me.lblFechaCartel.Text = "Fecha:"
        Me.lblFechaCartel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblHoraCartel
        '
        Me.lblHoraCartel.Location = New System.Drawing.Point(312, 16)
        Me.lblHoraCartel.Name = "lblHoraCartel"
        Me.lblHoraCartel.Size = New System.Drawing.Size(56, 16)
        Me.lblHoraCartel.TabIndex = 7
        Me.lblHoraCartel.Text = "Hora:"
        Me.lblHoraCartel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFecha
        '
        Me.lblFecha.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblFecha.Location = New System.Drawing.Point(88, 16)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(88, 16)
        Me.lblFecha.TabIndex = 7
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblHora
        '
        Me.lblHora.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblHora.Location = New System.Drawing.Point(376, 16)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(80, 16)
        Me.lblHora.TabIndex = 7
        Me.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPaciente
        '
        Me.lblPaciente.Location = New System.Drawing.Point(16, 56)
        Me.lblPaciente.Name = "lblPaciente"
        Me.lblPaciente.Size = New System.Drawing.Size(64, 16)
        Me.lblPaciente.TabIndex = 7
        Me.lblPaciente.Text = "Paciente:"
        Me.lblPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPaciente
        '
        Me.txtPaciente.Location = New System.Drawing.Point(88, 56)
        Me.txtPaciente.MaxLength = 50
        Me.txtPaciente.Name = "txtPaciente"
        Me.txtPaciente.ReadOnly = True
        Me.txtPaciente.Size = New System.Drawing.Size(368, 21)
        Me.txtPaciente.TabIndex = 9
        '
        'cmdBPacientes
        '
        Me.cmdBPacientes.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBPacientes.Location = New System.Drawing.Point(464, 56)
        Me.cmdBPacientes.Name = "cmdBPacientes"
        Me.cmdBPacientes.Size = New System.Drawing.Size(24, 24)
        Me.cmdBPacientes.TabIndex = 10
        Me.cmdBPacientes.Text = "..."
        Me.tipCitasDetalle.SetToolTip(Me.cmdBPacientes, "Mostrar ventana para seleccionar un Paciente")
        '
        'chkAnular
        '
        Me.chkAnular.Location = New System.Drawing.Point(280, 96)
        Me.chkAnular.Name = "chkAnular"
        Me.chkAnular.Size = New System.Drawing.Size(168, 24)
        Me.chkAnular.TabIndex = 11
        Me.chkAnular.Text = "Anular cita"
        '
        'txtAnulacion
        '
        Me.txtAnulacion.Location = New System.Drawing.Point(280, 128)
        Me.txtAnulacion.MaxLength = 200
        Me.txtAnulacion.Multiline = True
        Me.txtAnulacion.Name = "txtAnulacion"
        Me.txtAnulacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAnulacion.Size = New System.Drawing.Size(208, 72)
        Me.txtAnulacion.TabIndex = 12
        '
        'grbContabilidad
        '
        Me.grbContabilidad.Controls.Add(Me.nudDeuda)
        Me.grbContabilidad.Controls.Add(Me.nudCobrado)
        Me.grbContabilidad.Controls.Add(Me.lblCobrado)
        Me.grbContabilidad.Controls.Add(Me.lblEuros1)
        Me.grbContabilidad.Controls.Add(Me.lblDeuda)
        Me.grbContabilidad.Controls.Add(Me.lblEuros2)
        Me.grbContabilidad.Location = New System.Drawing.Point(24, 96)
        Me.grbContabilidad.Name = "grbContabilidad"
        Me.grbContabilidad.Size = New System.Drawing.Size(232, 104)
        Me.grbContabilidad.TabIndex = 13
        Me.grbContabilidad.TabStop = False
        Me.grbContabilidad.Text = " Contabilidad "
        '
        'nudDeuda
        '
        Me.nudDeuda.DecimalPlaces = 2
        Me.nudDeuda.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nudDeuda.Location = New System.Drawing.Point(96, 64)
        Me.nudDeuda.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.nudDeuda.Name = "nudDeuda"
        Me.nudDeuda.Size = New System.Drawing.Size(72, 21)
        Me.nudDeuda.TabIndex = 6
        Me.nudDeuda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudDeuda.ThousandsSeparator = True
        '
        'nudCobrado
        '
        Me.nudCobrado.DecimalPlaces = 2
        Me.nudCobrado.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nudCobrado.Location = New System.Drawing.Point(96, 32)
        Me.nudCobrado.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.nudCobrado.Name = "nudCobrado"
        Me.nudCobrado.Size = New System.Drawing.Size(72, 21)
        Me.nudCobrado.TabIndex = 0
        Me.nudCobrado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudCobrado.ThousandsSeparator = True
        '
        'lblCobrado
        '
        Me.lblCobrado.Location = New System.Drawing.Point(16, 32)
        Me.lblCobrado.Name = "lblCobrado"
        Me.lblCobrado.Size = New System.Drawing.Size(64, 16)
        Me.lblCobrado.TabIndex = 5
        Me.lblCobrado.Text = "Cobrado:"
        Me.lblCobrado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEuros1
        '
        Me.lblEuros1.Location = New System.Drawing.Point(176, 32)
        Me.lblEuros1.Name = "lblEuros1"
        Me.lblEuros1.Size = New System.Drawing.Size(40, 16)
        Me.lblEuros1.TabIndex = 5
        Me.lblEuros1.Text = "euros"
        Me.lblEuros1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDeuda
        '
        Me.lblDeuda.Location = New System.Drawing.Point(16, 64)
        Me.lblDeuda.Name = "lblDeuda"
        Me.lblDeuda.Size = New System.Drawing.Size(64, 16)
        Me.lblDeuda.TabIndex = 5
        Me.lblDeuda.Text = "Deuda:"
        Me.lblDeuda.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEuros2
        '
        Me.lblEuros2.Location = New System.Drawing.Point(176, 64)
        Me.lblEuros2.Name = "lblEuros2"
        Me.lblEuros2.Size = New System.Drawing.Size(40, 16)
        Me.lblEuros2.TabIndex = 5
        Me.lblEuros2.Text = "euros"
        Me.lblEuros2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtObservacion
        '
        Me.txtObservacion.Location = New System.Drawing.Point(24, 253)
        Me.txtObservacion.MaxLength = 200
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservacion.Size = New System.Drawing.Size(464, 48)
        Me.txtObservacion.TabIndex = 14
        '
        'lblObservacion
        '
        Me.lblObservacion.Location = New System.Drawing.Point(21, 227)
        Me.lblObservacion.Name = "lblObservacion"
        Me.lblObservacion.Size = New System.Drawing.Size(131, 15)
        Me.lblObservacion.TabIndex = 7
        Me.lblObservacion.Text = "Observación diaria"
        Me.lblObservacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Location = New System.Drawing.Point(328, 317)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(72, 24)
        Me.cmdGuardar.TabIndex = 15
        Me.cmdGuardar.Text = "Guardar"
        Me.tipCitasDetalle.SetToolTip(Me.cmdGuardar, "Guarda los datos de la Cita")
        '
        'cmdCerrar
        '
        Me.cmdCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCerrar.Location = New System.Drawing.Point(416, 317)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(72, 24)
        Me.cmdCerrar.TabIndex = 16
        Me.cmdCerrar.Text = "Cerrar"
        Me.tipCitasDetalle.SetToolTip(Me.cmdCerrar, "Cierra la ventana actual")
        '
        'cmdPaciente
        '
        Me.cmdPaciente.Location = New System.Drawing.Point(24, 317)
        Me.cmdPaciente.Name = "cmdPaciente"
        Me.cmdPaciente.Size = New System.Drawing.Size(72, 24)
        Me.cmdPaciente.TabIndex = 15
        Me.cmdPaciente.Text = "Paciente..."
        Me.tipCitasDetalle.SetToolTip(Me.cmdPaciente, "Muestra la ficha del Paciente seleccionado")
        '
        'cboFisios
        '
        Me.cboFisios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFisios.Location = New System.Drawing.Point(352, 222)
        Me.cboFisios.MaxDropDownItems = 10
        Me.cboFisios.Name = "cboFisios"
        Me.cboFisios.Size = New System.Drawing.Size(136, 21)
        Me.cboFisios.TabIndex = 18
        '
        'lblFisio
        '
        Me.lblFisio.AutoSize = True
        Me.lblFisio.Location = New System.Drawing.Point(253, 225)
        Me.lblFisio.Name = "lblFisio"
        Me.lblFisio.Size = New System.Drawing.Size(93, 13)
        Me.lblFisio.TabIndex = 17
        Me.lblFisio.Text = "Fisio de la cita:"
        Me.lblFisio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmCitasDetalle
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(506, 356)
        Me.ControlBox = False
        Me.Controls.Add(Me.cboFisios)
        Me.Controls.Add(Me.lblFisio)
        Me.Controls.Add(Me.cmdGuardar)
        Me.Controls.Add(Me.cmdCerrar)
        Me.Controls.Add(Me.txtObservacion)
        Me.Controls.Add(Me.grbContabilidad)
        Me.Controls.Add(Me.txtAnulacion)
        Me.Controls.Add(Me.chkAnular)
        Me.Controls.Add(Me.cmdBPacientes)
        Me.Controls.Add(Me.txtPaciente)
        Me.Controls.Add(Me.lblFechaCartel)
        Me.Controls.Add(Me.lblHoraCartel)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.lblPaciente)
        Me.Controls.Add(Me.lblObservacion)
        Me.Controls.Add(Me.cmdPaciente)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmCitasDetalle"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle de la cita"
        Me.grbContabilidad.ResumeLayout(False)
        CType(Me.nudDeuda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCobrado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Const cteModulo As String = "Detalle de Cita"

    Friend TipoMant As eTiposMantenimiento
    Friend IDCita As Integer
    Friend IDPaciente As Integer


    Private Sub CargarFormulario(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        mCargarFisios()

        Select Case Me.TipoMant
            Case eTiposMantenimiento.Alta
                chkAnular.Checked = False

            Case eTiposMantenimiento.Modificacion
                mLLenarCita()
        End Select

        txtAnulacion.ReadOnly = Not chkAnular.Checked

        mOKGuardar()

    End Sub

    Private Sub BuscarPacientes(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBPacientes.Click

        Dim objBuscarPacientes As New frmBuscarPacientes()

        With objBuscarPacientes
            If .ShowDialog() = DialogResult.OK Then
                Dim dDeuda As Decimal

                txtPaciente.Text = .NombrePaciente
                Me.IDPaciente = .IdPaciente

                mComprobarDeuda()
            End If
        End With

        mOKGuardar()

    End Sub

    Private Sub AnularCita(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAnular.CheckedChanged
        txtAnulacion.ReadOnly = Not chkAnular.Checked
    End Sub

    Private Sub GuardarCita(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click

        With Me
            If mbGuardarCita() Then
                .DialogResult = DialogResult.OK
                '.Dispose()
            Else
                .DialogResult = DialogResult.Cancel
            End If
        End With

    End Sub

    Private Sub CerrarFormulario(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click
        Me.Dispose()
    End Sub


    Private Sub mLLenarCita()

        Dim objBDatos As New AccesoBD_MySQL()
        Dim dtCita As New DataTable()
        Dim bOK As Boolean

        Try
            With objBDatos
                bOK = .AbrirConexion

                If bOK Then
                    Dim arrParametros(0) As MySqlParameter
                    Dim iNumFilas As Integer

                    arrParametros(0) = New MySqlParameter()
                    With arrParametros(0)
                        .ParameterName = "iIDCita"
                        .MySqlDbType = MySqlDbType.Int32
                        .Size = 11
                        .Value = Me.IDCita
                        .Direction = ParameterDirection.Input
                    End With

                    bOK = .EjecutarSP("spCitas_LLenarDetalle", arrParametros, dtCita, iNumFilas)

                    If bOK And Not IsNothing(dtCita) Then
                        If iNumFilas = 1 Then
                            Dim drFila As DataRow
                            'Dim dDeuda As Decimal

                            drFila = dtCita.Rows(0)

                            lblFecha.Text = Format(drFila("CIT_Fecha"), "dd/MM/yyyy")
                            lblHora.Text = drFila("CIT_Hora").ToString
                            txtPaciente.Text = drFila("Paciente").ToString
                            Me.IDPaciente = Convert.ToInt32(drFila("PAC_ID"))

                            nudCobrado.Value = Convert.ToDecimal(drFila("CIT_Cobrado"))
                            nudDeuda.Value = Convert.ToDecimal(drFila("CIT_Deuda"))
                            txtObservacion.Text = drFila("CIT_Observacion").ToString

                            chkAnular.Checked = Convert.ToBoolean(drFila("CIT_Anulada"))

                            If IsDBNull(drFila("CIT_MotivoAnulacion")) Then
                                txtAnulacion.Text = String.Empty
                            Else
                                txtAnulacion.Text = drFila("CIT_MotivoAnulacion").ToString
                            End If

                            Dim iIndiceFisio As Integer

                            bOK = BuscarElementoCombo(CType(cboFisios.DataSource, DataTable), drFila("FIS_ID").ToString, iIndiceFisio)

                            If bOK Then
                                cboFisios.SelectedIndex = iIndiceFisio
                            End If

                            ' Después de llenar los datos de la cita, comprobar si el paciente es un puto moroso
                            mComprobarDeuda()
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


    Private Function mbGuardarCita() As Boolean

        Dim objBDatos As New AccesoBD_MySQL()
        Dim dtCita As New DataTable()
        Dim bOK As Boolean
        Dim bControl As Boolean

        Try
            bControl = False

            With objBDatos
                bOK = .AbrirConexion

                If bOK Then
                    bOK = .IniciarTransaccion

                    If bOK Then
                        Dim arrParametros(9) As MySqlParameter

                        arrParametros(0) = New MySqlParameter()
                        With arrParametros(0)
                            .ParameterName = "iIDCita"
                            .MySqlDbType = MySqlDbType.Int32
                            .Size = 11
                            .Value = Me.IDCita
                            .Direction = ParameterDirection.Input
                        End With

                        arrParametros(1) = New MySqlParameter()
                        With arrParametros(1)
                            .ParameterName = "fFecha"
                            .MySqlDbType = MySqlDbType.Date
                            .Size = 8
                            .Value = DateTime.Parse(lblFecha.Text)
                            .Direction = ParameterDirection.Input
                        End With

                        arrParametros(2) = New MySqlParameter()
                        With arrParametros(2)
                            .ParameterName = "sHora"
                            .MySqlDbType = MySqlDbType.VarChar
                            .Size = 5
                            .Value = lblHora.Text
                            .Direction = ParameterDirection.Input
                        End With

                        arrParametros(3) = New MySqlParameter()
                        With arrParametros(3)
                            .ParameterName = "iIDPaciente"
                            .MySqlDbType = MySqlDbType.Int32
                            .Size = 11
                            .Value = Me.IDPaciente
                            .Direction = ParameterDirection.Input
                        End With

                        arrParametros(4) = New MySqlParameter()
                        With arrParametros(4)
                            .ParameterName = "sObservacion"
                            .MySqlDbType = MySqlDbType.VarChar
                            .Size = 200
                            .Value = txtObservacion.Text.Trim
                            .Direction = ParameterDirection.Input
                        End With

                        arrParametros(5) = New MySqlParameter()
                        With arrParametros(5)
                            .ParameterName = "bAnular"
                            .MySqlDbType = MySqlDbType.Bit
                            .Size = 1
                            .Value = chkAnular.Checked
                            .Direction = ParameterDirection.Input
                        End With

                        arrParametros(6) = New MySqlParameter()
                        With arrParametros(6)
                            .ParameterName = "sMotivo"
                            .MySqlDbType = MySqlDbType.VarChar
                            .Size = 200
                            If chkAnular.Checked Then
                                .Value = txtAnulacion.Text.Trim
                            Else
                                .Value = String.Empty
                            End If
                            .Direction = ParameterDirection.Input
                        End With

                        arrParametros(7) = New MySqlParameter()
                        With arrParametros(7)
                            .ParameterName = "dCobrado"
                            .MySqlDbType = MySqlDbType.Decimal
                            .Size = 9
                            .Precision = 5
                            .Scale = 2
                            .Value = nudCobrado.Value
                            .Direction = ParameterDirection.Input
                        End With

                        arrParametros(8) = New MySqlParameter()
                        With arrParametros(8)
                            .ParameterName = "dDeuda"
                            .MySqlDbType = MySqlDbType.Decimal
                            .Size = 9
                            .Precision = 5
                            .Scale = 2
                            .Value = nudDeuda.Value
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

                        bOK = .EjecutarSP("spCitas_Guardar", arrParametros)

                        If bOK Then
                            bOK = .ConfirmarTransaccion
                            bControl = True
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


    Private Sub mOKGuardar()

        Dim bOK As Boolean

        bOK = (Me.IDPaciente > 0)

        cmdGuardar.Enabled = bOK
        cmdPaciente.Enabled = bOK

    End Sub

    Private Sub cmdPaciente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPaciente.Click

        Dim objPacientesDetalle As New frmPacientesDetalle()

        With objPacientesDetalle
            .Text = "Paciente: " & txtPaciente.Text.Trim
            .IDPaciente = Me.IDPaciente
            .TipoMant = eTiposMantenimiento.Modificacion

            .ShowDialog()
        End With

    End Sub

    Private Sub mComprobarDeuda()

        Dim objBDatos As New AccesoBD_MySQL()
        Dim drFila As DataRow
        Dim bOK As Boolean

        Try
            With objBDatos
                bOK = .AbrirConexion

                If bOK Then
                    Dim arrParametros(4) As MySqlParameter

                    arrParametros(0) = New MySqlParameter()
                    With arrParametros(0)
                        .ParameterName = "iIDPaciente"
                        .MySqlDbType = MySqlDbType.Int32
                        .Size = 4
                        .Value = Me.IDPaciente
                        .Direction = ParameterDirection.Input
                    End With

                    arrParametros(1) = New MySqlParameter()
                    With arrParametros(1)
                        .ParameterName = "fFecha"
                        .MySqlDbType = MySqlDbType.Date
                        .Size = 8
                        .Value = DateTime.Parse(lblFecha.Text)
                        .Direction = ParameterDirection.Input
                    End With

                    arrParametros(2) = New MySqlParameter()
                    With arrParametros(2)
                        .ParameterName = "dDeuda"
                        .MySqlDbType = MySqlDbType.Decimal
                        .Size = 8
                        .Direction = ParameterDirection.Output
                    End With

                    arrParametros(3) = New MySqlParameter()
                    With arrParametros(3)
                        .ParameterName = "fFechaDeuda"
                        .MySqlDbType = MySqlDbType.Date
                        .Size = 8
                        .Direction = ParameterDirection.Output
                    End With

                    arrParametros(4) = New MySqlParameter()
                    With arrParametros(4)
                        .ParameterName = "sObs"
                        .MySqlDbType = MySqlDbType.VarChar
                        .Size = 500
                        .Direction = ParameterDirection.Output
                    End With

                    bOK = .EjecutarSP("spCitas_ComprobarDeuda", arrParametros)

                    If bOK Then
                        Dim sCabecera As String = "El paciente " & txtPaciente.Text & ControlChars.NewLine
                        Dim sMensaje As String = String.Empty

                        Dim dDeuda As Decimal '= Convert.ToDecimal(arrParametros(2).Value)
                        dDeuda = Convert.ToDecimal(IIf(IsDBNull(arrParametros(2).Value), 0, arrParametros(2).Value))

                        If dDeuda > 0 Then
                            Dim sFechaDeuda As String = DateTime.Parse(arrParametros(3).Value.ToString).ToShortDateString
                            sMensaje = "tiene una deuda pendiente de " & Math.Abs(dDeuda) & " euros del día " & sFechaDeuda

                            'MessageBox.Show("El paciente " & txtPaciente.Text & ControlChars.NewLine & "tiene una deuda de " & Math.Abs(dDeuda) & " euros del día " & sFechaDeuda, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            'MessageBox.Show("El paciente " & txtPaciente.Text & " tiene una deuda anterior a la fecha " & lblFecha.Text, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If

                        Dim sObservaciones As String
                        sObservaciones = IIf(IsDBNull(arrParametros(4).Value), String.Empty, arrParametros(4).Value).ToString

                        If sObservaciones.Trim.Length > 0 Then
                            If sMensaje <> String.Empty Then
                                sMensaje &= ControlChars.NewLine & "y "
                            End If
                            sMensaje &= "presenta las siguientes observaciones permanentes:" & ControlChars.NewLine & sObservaciones
                        End If

                        If sMensaje.Length > 0 Then
                            MessageBox.Show(sCabecera & sMensaje, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
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

    Private Sub mCargarFisios()

        Dim dtFisios As DataTable = CargarFisios()
        Dim iNumFisios As Integer = dtFisios.Rows.Count

        If iNumFisios > 0 Then
            With cboFisios
                .Items.Clear()

                .DataSource = dtFisios

                .DisplayMember = "FIS_Alias"
                .ValueMember = "FIS_ID"

                .SelectedIndex = 0
            End With
        End If

    End Sub


End Class
