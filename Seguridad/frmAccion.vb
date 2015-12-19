Option Strict On
Option Explicit On 

Imports System.Diagnostics

Public Class frmAccion

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
    Friend WithEvents grbAccion As System.Windows.Forms.GroupBox
    Friend WithEvents radCrear As System.Windows.Forms.RadioButton
    Friend WithEvents radRestaurar As System.Windows.Forms.RadioButton
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents cmdSiguiente As System.Windows.Forms.Button
    Friend WithEvents tipAccion As System.Windows.Forms.ToolTip
    Friend WithEvents grbRestaurar As System.Windows.Forms.GroupBox
    Friend WithEvents lblBackup As System.Windows.Forms.Label
    Friend WithEvents txtBackup As System.Windows.Forms.TextBox
    Friend WithEvents cmdExaminar As System.Windows.Forms.Button
    Friend WithEvents cmdRestaurar As System.Windows.Forms.Button
    Friend WithEvents cmdCrear As System.Windows.Forms.Button
    Friend WithEvents grbCrear As System.Windows.Forms.GroupBox
    Friend WithEvents cmdBuscarDirectorio As System.Windows.Forms.Button
    Friend WithEvents txtCrear As System.Windows.Forms.TextBox
    Friend WithEvents lblCrear As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmAccion))
        Me.grbAccion = New System.Windows.Forms.GroupBox()
        Me.radCrear = New System.Windows.Forms.RadioButton()
        Me.radRestaurar = New System.Windows.Forms.RadioButton()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdSiguiente = New System.Windows.Forms.Button()
        Me.tipAccion = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdRestaurar = New System.Windows.Forms.Button()
        Me.cmdCrear = New System.Windows.Forms.Button()
        Me.cmdBuscarDirectorio = New System.Windows.Forms.Button()
        Me.grbRestaurar = New System.Windows.Forms.GroupBox()
        Me.cmdExaminar = New System.Windows.Forms.Button()
        Me.txtBackup = New System.Windows.Forms.TextBox()
        Me.lblBackup = New System.Windows.Forms.Label()
        Me.grbCrear = New System.Windows.Forms.GroupBox()
        Me.txtCrear = New System.Windows.Forms.TextBox()
        Me.lblCrear = New System.Windows.Forms.Label()
        Me.grbAccion.SuspendLayout()
        Me.grbRestaurar.SuspendLayout()
        Me.grbCrear.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbAccion
        '
        Me.grbAccion.Controls.AddRange(New System.Windows.Forms.Control() {Me.radCrear, Me.radRestaurar})
        Me.grbAccion.Location = New System.Drawing.Point(24, 24)
        Me.grbAccion.Name = "grbAccion"
        Me.grbAccion.Size = New System.Drawing.Size(440, 104)
        Me.grbAccion.TabIndex = 0
        Me.grbAccion.TabStop = False
        Me.grbAccion.Text = " Elegir una Acción a realizar "
        '
        'radCrear
        '
        Me.radCrear.Location = New System.Drawing.Point(16, 32)
        Me.radCrear.Name = "radCrear"
        Me.radCrear.Size = New System.Drawing.Size(232, 24)
        Me.radCrear.TabIndex = 0
        Me.radCrear.Text = "Crear una copia de seguridad"
        '
        'radRestaurar
        '
        Me.radRestaurar.Location = New System.Drawing.Point(16, 64)
        Me.radRestaurar.Name = "radRestaurar"
        Me.radRestaurar.Size = New System.Drawing.Size(232, 24)
        Me.radRestaurar.TabIndex = 0
        Me.radRestaurar.Text = "Restaurar una copia de seguridad"
        '
        'cmdSalir
        '
        Me.cmdSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdSalir.Location = New System.Drawing.Point(384, 144)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(80, 32)
        Me.cmdSalir.TabIndex = 5
        Me.cmdSalir.Text = "Salir"
        '
        'cmdSiguiente
        '
        Me.cmdSiguiente.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdSiguiente.Enabled = False
        Me.cmdSiguiente.Location = New System.Drawing.Point(288, 144)
        Me.cmdSiguiente.Name = "cmdSiguiente"
        Me.cmdSiguiente.Size = New System.Drawing.Size(80, 32)
        Me.cmdSiguiente.TabIndex = 4
        Me.cmdSiguiente.Text = "Siguiente"
        Me.tipAccion.SetToolTip(Me.cmdSiguiente, "Mostrar siguiente paso")
        '
        'cmdRestaurar
        '
        Me.cmdRestaurar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdRestaurar.Enabled = False
        Me.cmdRestaurar.Location = New System.Drawing.Point(288, 144)
        Me.cmdRestaurar.Name = "cmdRestaurar"
        Me.cmdRestaurar.Size = New System.Drawing.Size(80, 32)
        Me.cmdRestaurar.TabIndex = 4
        Me.cmdRestaurar.Text = "Restaurar"
        Me.tipAccion.SetToolTip(Me.cmdRestaurar, "Restaurar la copia de seguridad seleccionada")
        '
        'cmdCrear
        '
        Me.cmdCrear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCrear.Enabled = False
        Me.cmdCrear.Location = New System.Drawing.Point(288, 144)
        Me.cmdCrear.Name = "cmdCrear"
        Me.cmdCrear.Size = New System.Drawing.Size(80, 32)
        Me.cmdCrear.TabIndex = 4
        Me.cmdCrear.Text = "Crear"
        Me.tipAccion.SetToolTip(Me.cmdCrear, "Crear una copia de seguridad")
        '
        'cmdBuscarDirectorio
        '
        Me.cmdBuscarDirectorio.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBuscarDirectorio.Location = New System.Drawing.Point(392, 64)
        Me.cmdBuscarDirectorio.Name = "cmdBuscarDirectorio"
        Me.cmdBuscarDirectorio.Size = New System.Drawing.Size(32, 24)
        Me.cmdBuscarDirectorio.TabIndex = 2
        Me.cmdBuscarDirectorio.Text = "..."
        Me.tipAccion.SetToolTip(Me.cmdBuscarDirectorio, "Directorio destino de la copia de seguridad")
        '
        'grbRestaurar
        '
        Me.grbRestaurar.Controls.AddRange(New System.Windows.Forms.Control() {Me.cmdExaminar, Me.txtBackup, Me.lblBackup})
        Me.grbRestaurar.Location = New System.Drawing.Point(24, 24)
        Me.grbRestaurar.Name = "grbRestaurar"
        Me.grbRestaurar.Size = New System.Drawing.Size(440, 104)
        Me.grbRestaurar.TabIndex = 6
        Me.grbRestaurar.TabStop = False
        Me.grbRestaurar.Text = " Restaurar copia de seguridad "
        '
        'cmdExaminar
        '
        Me.cmdExaminar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExaminar.Location = New System.Drawing.Point(392, 64)
        Me.cmdExaminar.Name = "cmdExaminar"
        Me.cmdExaminar.Size = New System.Drawing.Size(32, 24)
        Me.cmdExaminar.TabIndex = 2
        Me.cmdExaminar.Text = "..."
        '
        'txtBackup
        '
        Me.txtBackup.Location = New System.Drawing.Point(16, 56)
        Me.txtBackup.Multiline = True
        Me.txtBackup.Name = "txtBackup"
        Me.txtBackup.ReadOnly = True
        Me.txtBackup.Size = New System.Drawing.Size(368, 32)
        Me.txtBackup.TabIndex = 1
        Me.txtBackup.Text = ""
        '
        'lblBackup
        '
        Me.lblBackup.AutoSize = True
        Me.lblBackup.Location = New System.Drawing.Point(16, 32)
        Me.lblBackup.Name = "lblBackup"
        Me.lblBackup.Size = New System.Drawing.Size(179, 14)
        Me.lblBackup.TabIndex = 0
        Me.lblBackup.Text = "Ruta de la copia de seguridad:"
        '
        'grbCrear
        '
        Me.grbCrear.Controls.AddRange(New System.Windows.Forms.Control() {Me.cmdBuscarDirectorio, Me.txtCrear, Me.lblCrear})
        Me.grbCrear.Location = New System.Drawing.Point(24, 24)
        Me.grbCrear.Name = "grbCrear"
        Me.grbCrear.Size = New System.Drawing.Size(440, 104)
        Me.grbCrear.TabIndex = 6
        Me.grbCrear.TabStop = False
        Me.grbCrear.Text = " Crear copia de seguridad "
        '
        'txtCrear
        '
        Me.txtCrear.Location = New System.Drawing.Point(16, 56)
        Me.txtCrear.Multiline = True
        Me.txtCrear.Name = "txtCrear"
        Me.txtCrear.ReadOnly = True
        Me.txtCrear.Size = New System.Drawing.Size(368, 32)
        Me.txtCrear.TabIndex = 1
        Me.txtCrear.Text = ""
        '
        'lblCrear
        '
        Me.lblCrear.AutoSize = True
        Me.lblCrear.Location = New System.Drawing.Point(16, 32)
        Me.lblCrear.Name = "lblCrear"
        Me.lblCrear.Size = New System.Drawing.Size(253, 14)
        Me.lblCrear.TabIndex = 0
        Me.lblCrear.Text = "Directorio destino de la copia de seguridad:"
        '
        'frmAccion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.cmdSalir
        Me.ClientSize = New System.Drawing.Size(482, 199)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.cmdSalir, Me.cmdCrear, Me.grbCrear, Me.cmdSiguiente, Me.cmdRestaurar, Me.grbRestaurar, Me.grbAccion})
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmAccion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seguridad"
        Me.grbAccion.ResumeLayout(False)
        Me.grbRestaurar.ResumeLayout(False)
        Me.grbCrear.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub CargarFormulario(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        grbAccion.BringToFront()
        cmdSiguiente.BringToFront()
    End Sub


    Private Sub OpcionCrear(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radCrear.CheckedChanged
        mOKSiguiente()
    End Sub

    Private Sub OpcionRestaurar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radRestaurar.CheckedChanged
        mOKSiguiente()
    End Sub


    Private Sub cmdSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSiguiente.Click

        If radCrear.Checked Then
            grbCrear.BringToFront()
            cmdCrear.BringToFront()
        End If

        If radRestaurar.Checked Then
            grbRestaurar.BringToFront()
            cmdRestaurar.BringToFront()
        End If

    End Sub

    Private Sub Salir(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        mSalir()
    End Sub


    Private Sub mSalir()

        If MessageBox.Show("¿Salir de la aplicación?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub

    Private Sub mOKSiguiente()

        Dim bOK As Boolean

        bOK = (radCrear.Checked) Or (radRestaurar.Checked)

        cmdSiguiente.Enabled = bOK

    End Sub



#Region " RESTAURAR COPIA SEGURIDAD"

    Private Sub BuscarCopiaSeguridad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExaminar.Click

        Dim objExaminar As New OpenFileDialog()

        With objExaminar
            .InitialDirectory = LeerConfiguracion("RutaBackups")
            .Filter = "Copias de seguridad (*.sql)|*.sql"

            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                txtBackup.Text = .FileName
            End If
        End With

    End Sub

    Private Sub txtBackup_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBackup.TextChanged
        mOKRestaurar()
    End Sub

    Private Sub Restaurar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRestaurar.Click

        Try
            Dim objProceso As New Process()

            Dim sUsuario As String = LeerConfiguracion("Usuario")
            Dim sClave As String = LeerConfiguracion("Clave")
            Dim sBaseDatos As String = LeerConfiguracion("BaseDatos")

            Dim sArgumentos As String

            sArgumentos = "/c mysql --user=" & sUsuario & " --password=" & sClave & Space(1) & sBaseDatos & " < " & txtBackup.Text

            With objProceso
                With objProceso.StartInfo
                    .FileName = "cmd"
                    '.Arguments = "/c mysql --user=root --password=pepito novafis < D:\IVAN\Audio\copia_seguridad_10072006_141300.sql"
                    .Arguments = sArgumentos

                    .WindowStyle = ProcessWindowStyle.Hidden
                    .CreateNoWindow = True
                    .UseShellExecute = False
                End With

                .Start()
                .WaitForExit()

                .Close()
            End With

            GestionarErrores("Restauración realizada correctamente", MessageBoxIcon.Information, EventLogEntryType.Information)

        Catch exError As Exception
            GestionarErrores("Restauración fallida: " & exError.Message, MessageBoxIcon.Error, EventLogEntryType.Error)

        End Try

    End Sub

    Private Sub mOKRestaurar()

        Dim bOK As Boolean

        bOK = (txtBackup.Text.Trim.Length > 0)

        cmdRestaurar.Enabled = bOK

    End Sub

#End Region


#Region " CREAR COPIA SEGURIDAD "

    Private Sub BuscarDirectorio(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscarDirectorio.Click

        Dim objBuscador As New FolderBrowser()

        If objBuscador.ShowDialog = DialogResult.OK Then
            txtCrear.Text = objBuscador.DirectoryPath
        End If

        objBuscador.Dispose()

    End Sub

    Private Sub txtCrear_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCrear.TextChanged
        mOKCrear()
    End Sub

    Private Sub CrearBackup(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCrear.Click

        Try
            Dim objProceso As New Process()

            Dim sUsuario As String = LeerConfiguracion("Usuario")
            Dim sClave As String = LeerConfiguracion("Clave")
            Dim sBaseDatos As String = LeerConfiguracion("BaseDatos")

            Dim sArgumentos As String
            Dim sFechaHoraFormato As String

            sFechaHoraFormato = DateTime.Now.ToString.Replace("/", String.Empty)
            sFechaHoraFormato = sFechaHoraFormato.Replace(":", String.Empty)
            sFechaHoraFormato = sFechaHoraFormato.Replace(" ", "_")

            sArgumentos = "/c mysqldump --user=" & sUsuario & " --password=" & sClave & " --opt --routines " & sBaseDatos & " > " & txtCrear.Text & "\Backup_" & sFechaHoraFormato & ".sql"

            With objProceso
                With objProceso.StartInfo
                    .FileName = "cmd"
                    .Arguments = sArgumentos

                    .WindowStyle = ProcessWindowStyle.Hidden
                    .CreateNoWindow = True
                    .UseShellExecute = False
                End With

                .Start()
                .WaitForExit()

                .Close()
            End With

            GestionarErrores("Copia de seguridad realizada correctamente", MessageBoxIcon.Information, EventLogEntryType.Information)

        Catch exError As Exception
            GestionarErrores("Copia de seguridad fallida: " & exError.Message, MessageBoxIcon.Error, EventLogEntryType.Error)

        End Try

    End Sub

    Private Sub mOKCrear()

        Dim bOK As Boolean

        bOK = (txtCrear.Text.Trim.Length > 0)

        cmdCrear.Enabled = bOK

    End Sub

#End Region


End Class
