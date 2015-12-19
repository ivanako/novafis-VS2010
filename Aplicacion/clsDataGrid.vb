Option Strict On
Option Explicit On 

Public Class NovafisDataGrid

    Public Shared Sub EstiloGrid(ByVal arrColumnas() As String, ByVal arrCabeceras() As String, ByVal arrTiposDatos() As String, ByVal arrAnchuras() As Integer, ByRef objDataGrid As DataGrid, ByVal sNombreTabla As String, Optional ByVal bOrdenar As Boolean = True)

        ' Poner el estilo al Grid
        Dim objEstilo As New DataGridTableStyle()
        Dim objColumnaBoolean As DataGridBoolColumn
        Dim objColumnaTexto As DataGridTextBoxColumn

        Dim iCont As Integer

        ' Asignar el datasource para conseguir las columnas
        objEstilo.MappingName = sNombreTabla

        ' Rellenar las propiedades generales del datagrid
        With objEstilo
            .SelectionBackColor = Color.Black
            .SelectionForeColor = Color.White
            .RowHeadersVisible = False
            .AllowSorting = bOrdenar
        End With

        ' Crear los estilos y mapeos según el tipo de cada columna
        For iCont = 0 To arrColumnas.Length - 1

            Select Case arrTiposDatos(iCont)
                Case "S"
                    ' Columna tipo string
                    ' Si el grid es de sólo lectura usamos otra clase
                    If objDataGrid.ReadOnly Then
                        objColumnaTexto = New NovafisColumnaDataGrid()
                    Else
                        objColumnaTexto = New DataGridTextBoxColumn()
                    End If

                    With objColumnaTexto
                        .MappingName = arrColumnas(iCont)
                        .HeaderText = arrCabeceras(iCont)
                        .Alignment = HorizontalAlignment.Left
                        .ReadOnly = True
                        .NullText = String.Empty
                        If arrAnchuras(iCont) <> -1 Then
                            .Width = arrAnchuras(iCont)
                        End If
                    End With

                    objEstilo.GridColumnStyles.Add(objColumnaTexto)

                    ' Columna tipo fecha
                Case "F"
                    ' // Si el grid es de sólo lectura usamos otra clase
                    If objDataGrid.ReadOnly Then
                        objColumnaTexto = New NovafisColumnaDataGrid()
                    Else
                        objColumnaTexto = New DataGridTextBoxColumn()
                    End If


                    With objColumnaTexto
                        .MappingName = arrColumnas(iCont)
                        .HeaderText = arrCabeceras(iCont)
                        .Alignment = HorizontalAlignment.Left
                        .Format = "dd/MM/yyyy"
                        .ReadOnly = True
                        .NullText = String.Empty
                        If arrAnchuras(iCont) <> -1 Then
                            .Width = arrAnchuras(iCont)
                        End If
                    End With

                    objEstilo.GridColumnStyles.Add(objColumnaTexto)

                    ' // Columna tipo importe
                Case "M", "N"
                    ' // Si el grid es de sólo lectura usamos otra clase
                    If objDataGrid.ReadOnly Then
                        objColumnaTexto = New NovafisColumnaDataGrid()
                    Else
                        objColumnaTexto = New DataGridTextBoxColumn()
                    End If

                    With objColumnaTexto
                        .MappingName = arrColumnas(iCont)
                        .HeaderText = arrCabeceras(iCont)
                        .Alignment = HorizontalAlignment.Right
                        .Format = "#,##0.00"
                        .ReadOnly = True
                        .NullText = String.Empty
                        If arrAnchuras(iCont) <> -1 Then
                            .Width = arrAnchuras(iCont)
                        End If
                    End With

                    objEstilo.GridColumnStyles.Add(objColumnaTexto)

                    '****************************************************
                    'EXCEPCION
                    'Le damos formato de 8 decimanles
                    '****************************************************
                Case "DE"
                    ' // Si el grid es de sólo lectura usamos otra clase
                    If objDataGrid.ReadOnly Then
                        objColumnaTexto = New NovafisColumnaDataGrid()
                    Else
                        objColumnaTexto = New DataGridTextBoxColumn()
                    End If

                    With objColumnaTexto
                        .MappingName = arrColumnas(iCont)
                        .HeaderText = arrCabeceras(iCont)
                        .Alignment = HorizontalAlignment.Right
                        .Format = "#,##0.00000000"
                        .ReadOnly = True
                        .NullText = String.Empty
                        If arrAnchuras(iCont) <> -1 Then
                            .Width = arrAnchuras(iCont)
                        End If
                    End With

                    objEstilo.GridColumnStyles.Add(objColumnaTexto)

                    '****************************************************
                    'EXCEPCION
                    'Le damos formato de 3 decimanles
                    '****************************************************
                Case "D"
                    ' // Si el grid es de sólo lectura usamos otra clase
                    If objDataGrid.ReadOnly Then
                        objColumnaTexto = New NovafisColumnaDataGrid()
                    Else
                        objColumnaTexto = New DataGridTextBoxColumn()
                    End If

                    With objColumnaTexto
                        .MappingName = arrColumnas(iCont)
                        .HeaderText = arrCabeceras(iCont)
                        .Alignment = HorizontalAlignment.Right
                        .Format = "#,##0.000"
                        .ReadOnly = True
                        .NullText = String.Empty
                        If arrAnchuras(iCont) <> -1 Then
                            .Width = arrAnchuras(iCont)
                        End If
                    End With

                    objEstilo.GridColumnStyles.Add(objColumnaTexto)


                    ' // Columna tipo importe entero
                Case "I"
                    ' // Si el grid es de sólo lectura usamos otra clase
                    If objDataGrid.ReadOnly Then
                        objColumnaTexto = New NovafisColumnaDataGrid()
                    Else
                        objColumnaTexto = New DataGridTextBoxColumn()
                    End If

                    With objColumnaTexto
                        .MappingName = arrColumnas(iCont)
                        .HeaderText = arrCabeceras(iCont)
                        .Alignment = HorizontalAlignment.Right
                        .Format = "#,##0"
                        .ReadOnly = True
                        .NullText = String.Empty
                        If arrAnchuras(iCont) <> -1 Then
                            .Width = arrAnchuras(iCont)
                        End If
                    End With

                    objEstilo.GridColumnStyles.Add(objColumnaTexto)

                    ' // Columna tipo boolean
                Case "B"

                    objColumnaBoolean = New DataGridBoolColumn()
                    With objColumnaBoolean
                        .MappingName = arrColumnas(iCont)
                        .HeaderText = arrCabeceras(iCont)
                        .Alignment = HorizontalAlignment.Center
                        ' // Columna de selección de fila
                        If arrColumnas(iCont) = "SEL" Then
                            .ReadOnly = False
                        Else
                            .ReadOnly = True
                        End If
                        .NullText = String.Empty
                        If arrAnchuras(iCont) <> -1 Then
                            .Width = arrAnchuras(iCont)
                        End If
                    End With

                    objEstilo.GridColumnStyles.Add(objColumnaBoolean)
            End Select

        Next iCont

        ' Si el datagrid ya tiene estilos eliminarlos
        If objDataGrid.TableStyles.Count > 0 Then
            objDataGrid.TableStyles.Remove(objDataGrid.TableStyles(0))
        End If

        ' Añadir el nuevo tablestyle al datagrid
        objDataGrid.TableStyles.Add(objEstilo)

        ' Eliminar los objetos
        objEstilo.Dispose()

    End Sub

    ' // Inicializar el dataTable de un DataGrid con la información del array
    ' // de inicialización
    Public Shared Function InicializaTabla(ByVal arrNombreColumnas() As String, ByVal sNombre As String) As DataTable

        Dim dtTabla As DataTable = New DataTable(sNombre)
        Dim arrColumnas(arrNombreColumnas.Length - 1) As DataColumn
        Dim iCont As Integer



        For iCont = 0 To arrColumnas.Length - 1
            '' // Columnas
            'arrColumnas(iCont) = New DataColumn()
            'arrColumnas(iCont).ColumnName = arrNombreColumnas(iCont)

            '' // Si no hay modo selección engañamos al tablestyle para
            '' // que no muestre la columna
            'If arrNombreColumnas(iCont).ToString = "SEL" Then
            '    'If sModo <> cGeneral.cteModoSeleccionar1 And sModo <> cGeneral.cteModoSeleccionarN Then
            '    arrColumnas(iCont).ColumnName = "SEL"
            '    'End If
            'End If

            'dtTabla.Columns.Add(arrColumnas(iCont))

            arrColumnas(iCont) = New DataColumn()
            arrColumnas(iCont).ColumnName = arrNombreColumnas(iCont)

            dtTabla.Columns.Add(arrColumnas(iCont))
        Next iCont

        ' Destruir objetos
        Array.Clear(arrColumnas, 0, arrColumnas.Length)

        dtTabla.Dispose()

        Return dtTabla

    End Function

    ''' <summary>
    ''' Añade una columna de selección a un DataTable
    ''' </summary>
    ''' <param name="dtTabla">DataTable al que se le añade una columna de selección</param>
    ''' <remarks></remarks>
    Public Shared Sub ColumnaSeleccion(ByRef dtTabla As DataTable)

        Dim dcColumna As New DataColumn("SEL")

        With dcColumna
            .DataType = GetType(System.Boolean)
            .AllowDBNull = True
            .DefaultValue = False
            .ReadOnly = False
        End With

        ' Añadir la columna de selección al datatable
        dtTabla.Columns.Add(dcColumna)

        ' Eliminar la columna
        dcColumna.Dispose()

    End Sub

End Class


Friend Class NovafisColumnaDataGrid
    ' Clase para manejar que el DataGrid no permita seleccionar las columnas
    Inherits DataGridTextBoxColumn

    Protected Overloads Overrides Sub Edit(ByVal source As System.Windows.Forms.CurrencyManager, ByVal rowNum As Integer, ByVal bounds As System.Drawing.Rectangle, ByVal [readOnly] As Boolean, ByVal instantText As String, ByVal cellIsVisible As Boolean)
        Return
    End Sub

    'Protected Overrides Sub Paint(g As System.Drawing.Graphics, bounds As System.Drawing.Rectangle, source As System.Windows.Forms.CurrencyManager, rowNum As Integer, backBrush As System.Drawing.Brush, foreBrush As System.Drawing.Brush, alignToRight As Boolean)
    '    MyBase.Paint(g, bounds, source, rowNum, backBrush, foreBrush, alignToRight)

    'End Sub
End Class

Public Class ScrolledDataGrid
    Inherits DataGrid

    ''' <summary>
    ''' Allows to set the selected row and scroll to it
    ''' </summary>
    ''' <param name="rowNumber">Row position inside the data grid</param>
    ''' <remarks></remarks>
    Public Sub ScrollTo(ByVal rowNumber As Integer)
        If Not IsNothing(Me.DataSource) Then
            For iCont As Integer = 0 To CType(Me.DataSource, DataTable).Rows.Count - 1
                Me.UnSelect(iCont)
            Next iCont

            GridVScrolled(Me, New ScrollEventArgs(ScrollEventType.LargeIncrement, rowNumber))
            Me.Select(rowNumber)
        End If
    End Sub

End Class