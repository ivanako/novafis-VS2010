Option Strict On
Option Explicit On

Public Class frmDeudas

    Private Const cteModulo As String = "Deudas"

    'Variable para controlar el número de instancias abiertas
    Private Shared objInstancia As frmDeudas = Nothing

    'Función que crea una sola instancia del formulario de Facturas
    Public Shared Function Instancia() As frmDeudas

        If IsNothing(objInstancia) OrElse objInstancia.IsDisposed = True Then
            objInstancia = New frmDeudas()
        End If

        objInstancia.BringToFront()

        Return objInstancia

    End Function

    Private arrCamposDeudas() As String = {"CIT_Fecha", "PAC_NombreCompleto", "CIT_Deuda"}
    Private arrCabecerasDeudas() As String = {"Fecha", "Paciente", "Importe (euros)"}
    Private arrTiposDatosDeudas() As String = {"F", "S", "M"}
    Private arrAnchurasDeudas() As Integer = {100, 300, 120}

    Private dtDeudas As DataTable = New DataTable("Deudas")

    Private Sub frmDeudas_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter
        mLLenarFacturas(dtpFechaRef.Value)
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub frmDeudas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpFechaRef.Value = DateTime.Today
        mLLenarFacturas(DateTime.Today)
    End Sub

    Private Sub dtpFechaRef_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaRef.ValueChanged
        mLLenarFacturas(dtpFechaRef.Value)
    End Sub

    Private Sub dtgDeudas_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgDeudas.CurrentCellChanged
        dtgDeudas.Select(dtgDeudas.CurrentRowIndex)
    End Sub

    Private Sub dtgDeudas_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtgDeudas.MouseUp
        Dim objTest As DataGrid.HitTestInfo = dtgDeudas.HitTest(New Point(e.X, e.Y))

        ' Si es una celda
        If objTest.Type = DataGrid.HitTestType.Cell Then
            dtgDeudas.Select(objTest.Row)
        End If
    End Sub

    Private Sub cmdCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click
        Me.Dispose()
    End Sub


    ''' <summary>
    ''' Recupera las deudas pendientes anteriores a una fecha de referencia
    ''' </summary>
    ''' <param name="fFechaRef">Fecha de referencia</param>
    ''' <remarks></remarks>
    Private Sub mLLenarFacturas(ByVal fFechaRef As DateTime)

        Dim objBDatos As New AccesoBD_MySQL()
        Dim iNumDeudas As Integer
        Dim bOK As Boolean

        Try
            With objBDatos
                bOK = .AbrirConexion()

                If bOK Then
                    dtDeudas.Rows.Clear()
                    Dim arrParametros(0) As MySqlParameter

                    arrParametros(0) = New MySqlParameter()
                    With arrParametros(0)
                        .ParameterName = "fFecha"
                        .MySqlDbType = MySqlDbType.Date
                        .Size = 8
                        .Value = dtpFechaRef.Value
                        .Direction = ParameterDirection.Input
                    End With

                    bOK = .EjecutarSP("spDeudas_Llenar", arrParametros, dtDeudas, iNumDeudas)

                    If bOK Then
                        If dtDeudas.Rows.Count > 0 Then
                            dtgDeudas.SetDataBinding(dtDeudas, String.Empty)

                            NovafisDataGrid.EstiloGrid(arrCamposDeudas, arrCabecerasDeudas, arrTiposDatosDeudas, arrAnchurasDeudas, dtgDeudas, cteModulo)
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

    End Sub


End Class