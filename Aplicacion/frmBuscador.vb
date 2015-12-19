Option Strict On
Option Explicit On

Public Class frmBuscador

    'Variable para controlar el número de instancias abiertas
    Private Shared objInstancia As frmBuscador = Nothing

    'Función que crea una sola instancia del formulario de Pacientes
    Public Shared Function Instancia() As frmBuscador

        If IsNothing(objInstancia) OrElse objInstancia.IsDisposed = True Then
            objInstancia = New frmBuscador()
        End If

        objInstancia.BringToFront()

        Return objInstancia

    End Function

    Private Const cteModulo As String = "Buscador"

    Private arrCamposBuscador() As String = {"PAC_NombreCompleto", "PAC_ID"}
    Private arrCabecerasBuscador() As String = {"Paciente", String.Empty}
    Private arrTiposDatosBuscador() As String = {"S", "I"}
    Private arrAnchurasBuscador() As Integer = {300, 0}

    Private Sub frmBuscador_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub frmBuscador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mCargarFuentes()
    End Sub

    Private Sub CambioCampo(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.TextChanged, txtApellido1.TextChanged, txtApellido2.TextChanged, txtIdentificacion.TextChanged, txtTelefono.TextChanged, txtConocer.TextChanged, cboFuentes.SelectedIndexChanged
        'mOKBuscar()
    End Sub

    Private Sub dtgPacientes_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgPacientes.CurrentCellChanged
        dtgPacientes.Select(dtgPacientes.CurrentRowIndex)
    End Sub

    Private Sub dtgPacientes_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgPacientes.DoubleClick
        If cmdPaciente.Enabled Then
            cmdPaciente.PerformClick()
        End If
    End Sub

    Private Sub dtgPacientes_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtgPacientes.MouseUp

        Dim objTest As DataGrid.HitTestInfo = dtgPacientes.HitTest(New Point(e.X, e.Y))

        ' Si es una celda
        If objTest.Type = DataGrid.HitTestType.Cell Then
            dtgPacientes.Select(objTest.Row)
        End If

        ' Habilitar el botón Modificar cuando se seleccione una celda. No valen las cabeceras.
        cmdPaciente.Enabled = (objTest.Type = DataGrid.HitTestType.Cell)
    End Sub

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        mFiltrarPacientes()
    End Sub

    Private Sub cmdPaciente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPaciente.Click
        Dim objPacientesDetalle As New frmPacientesDetalle()

        With objPacientesDetalle
            .Text = "Paciente: " & dtgPacientes.Item(dtgPacientes.CurrentRowIndex, 0).ToString

            .IDPaciente = CType(dtgPacientes.Item(dtgPacientes.CurrentRowIndex, 1), Integer)
            .TipoMant = eTiposMantenimiento.Modificacion

            .ShowDialog()
        End With
    End Sub

    Private Sub cmdCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click
        Me.Dispose()
    End Sub


    Private Sub mCargarFuentes()

        Dim objBDatos As New AccesoBD_MySQL()
        Dim dtFuentes As New DataTable("Fuentes")
        Dim iNumFuentes As Integer
        Dim bOK As Boolean

        Try
            With objBDatos
                bOK = .AbrirConexion

                If bOK Then
                    Dim arrParametros(0) As MySqlParameter

                    arrParametros(0) = New MySqlParameter()
                    With arrParametros(0)
                        .ParameterName = "iIDFuente"
                        .MySqlDbType = MySqlDbType.Int32
                        .Size = 4
                        .Value = DBNull.Value
                        .Direction = ParameterDirection.Input
                    End With

                    bOK = .EjecutarSP("spFuentes_LLenar", arrParametros, dtFuentes, iNumFuentes)

                    If bOK And Not IsNothing(dtFuentes) Then
                        Dim drFila As DataRow = dtFuentes.NewRow
                        drFila("FNT_ID") = 0
                        drFila("FNT_Descripcion") = cteNinguna

                        dtFuentes.Rows.Add(drFila)

                        Dim dvFuentes As New DataView(dtFuentes)
                        dvFuentes.Sort = "FNT_ID"

                        'dtFuentes = CType(dvFuentes, DataTable)

                        With cboFuentes
                            .Items.Clear()

                            .DataSource = dvFuentes.ToTable

                            .DisplayMember = "FNT_Descripcion"
                            .ValueMember = "FNT_ID"

                            .SelectedIndex = 0
                        End With
                    End If

                    bOK = .CerrarConexion
                End If
            End With

        Catch exError As Exception
            GestionarErrores(exError.Message, cteModulo, MessageBoxIcon.Error, EventLogEntryType.Error)

            bOK = False

        Finally
            objBDatos.Dispose()

        End Try

    End Sub

    Private Sub mOKBuscar()

        Dim bOK As Boolean

        bOK = Not (txtNombre.Text.Trim = String.Empty)

        If Not bOK Then
            bOK = Not (txtApellido1.Text.Trim = String.Empty)
        End If

        If Not bOK Then
            bOK = Not (txtApellido2.Text.Trim = String.Empty)
        End If

        If Not bOK Then
            bOK = Not (txtIdentificacion.Text.Trim = String.Empty)
        End If

        If Not bOK Then
            bOK = Not (txtTelefono.Text.Trim = String.Empty)
        End If

        If Not bOK Then
            bOK = Not (txtConocer.Text.Trim = String.Empty)
        End If

        If Not bOK Then
            bOK = (cboFuentes.SelectedIndex > 0)
        End If

        cmdBuscar.Enabled = bOK

    End Sub

    Private Sub mFiltrarPacientes()

        Dim objBDatos As New AccesoBD_MySQL()
        Dim dtPacientes As New DataTable("Pacientes")
        Dim iNumFilas As Integer
        Dim bOK As Boolean

        Dim sConsulta As String = String.Empty
        sConsulta += "SELECT P.PAC_ID, P.PAC_NombreCompleto "
        sConsulta += "FROM Pacientes P, PacientesDireccion PD "
        sConsulta += "WHERE P.PAC_ID = PD.PAC_ID "

        ' Nombre y Apellidos
        sConsulta += "AND P.PAC_Nombre like '" + txtNombre.Text.Trim + "%' "
        sConsulta += "AND P.PAC_Apellido1 like '" + txtApellido1.Text.Trim + "%' "
        sConsulta += "AND P.PAC_Apellido2 like '" + txtApellido2.Text.Trim + "%' "

        ' Identificación
        sConsulta += "AND P.PAC_Identificacion like '" + txtIdentificacion.Text.Trim + "%' "
        ' Números de teléfono
        If txtTelefono.Text.Trim <> String.Empty Then
            sConsulta += "AND (PD.PAD_Telefono1 like '" + txtTelefono.Text.Trim + "%' OR PD.PAD_Telefono2 like '" + txtTelefono.Text.Trim + "%' OR PD.PAD_Telefono3 like '" + txtTelefono.Text.Trim + "%') "
        End If

        ' ¿Cómo nos conoció?
        sConsulta += "AND P.PAC_Conocer like '%" + txtConocer.Text.Trim + "%' "
        ' Fuente
        If cboFuentes.SelectedIndex > 0 Then
            sConsulta += "AND P.FNT_ID = " + cboFuentes.SelectedIndex.ToString
        End If

        ' Ordenación
        sConsulta += " ORDER BY P.PAC_NombreCompleto"

        With objBDatos
            bOK = .AbrirConexion()

            If bOK Then
                bOK = .EjecutarConsultaSQL(sConsulta, dtPacientes, iNumFilas)

                If iNumFilas > 0 Then
                    dtgPacientes.SetDataBinding(dtPacientes, String.Empty)
                    NovafisDataGrid.EstiloGrid(arrCamposBuscador, arrCabecerasBuscador, arrTiposDatosBuscador, arrAnchurasBuscador, dtgPacientes, "Pacientes")
                Else
                    dtgPacientes.SetDataBinding(Nothing, String.Empty)
                End If

                dtgPacientes.CaptionText = "Pacientes (" + iNumFilas.ToString + ")"
                bOK = .CerrarConexion()
            End If
        End With

    End Sub

End Class