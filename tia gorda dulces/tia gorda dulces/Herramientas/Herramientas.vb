Module Herramientas

    ''' <summary>
    ''' Devuelve el Valor en una cadena con formato #. Texto
    ''' </summary>
    ''' <param name="s">Cadena a evaluar</param>
    ''' <returns>Integer</returns>
    Public Function Codigo_Seleccionado(ByVal s As String) As Integer
        Dim i As Integer
        If s.IndexOf(".") Then
            Dim n As String = s.Substring(0, s.IndexOf("."))
            If IsNumeric(n) Then i = CInt(n)
        End If
        Return i
    End Function

    ''' <summary>
    ''' Devuelve el Nombre en una cadena con formato #. Texto
    ''' </summary>
    ''' <param name="s">Cadena a evaluar</param>
    ''' <returns>String</returns>
    Public Function Nombre_Seleccionado(ByVal s As String) As String
        If s.IndexOf(".") > -1 Then
            s = s.Substring(s.IndexOf(".") + 2)
        End If
        Return s
    End Function
    Public Sub Llenar_List(ByRef lst As ListBox, ByVal Tabla As String, Optional ByVal ID As String = "", Optional ByVal Nombre As String = "", Optional ByVal Where As String = "", Optional ByVal Order As String = "")
        If Where.Length Then Where = " WHERE " & Where
        If Order.Length = 0 Then Order = ID


        Dim db As New OleDb.OleDbConnection(My.Resources.Cadena_Conexion)
        Dim dt As New DataTable("Datos")

        Dim cadena As String = String.Format("SELECT {0}, {1} FROM {2} {3} ORDER BY {4}", ID, Nombre, Tabla, Where, Order)

        If ID.Length = 0 Then
            cadena = "SELECT * FROM " & Tabla & Where
        End If

        Dim dat As New OleDb.OleDbDataAdapter(cadena, db)
        dat.Fill(dt)

        For Each f As DataRow In dt.Rows
            lst.Items.Add(String.Format("{0}. {1}", f.Item(0), f.Item(1).ToString.Trim))
        Next
    End Sub
    Public Sub Llenar_combobox(ByRef lst As ComboBox, ByVal Tabla As String, Optional ByVal ID As String = "", Optional ByVal Nombre As String = "", Optional ByVal Where As String = "", Optional ByVal Order As String = "")
        If Where.Length Then Where = " WHERE " & Where
        If Order.Length = 0 Then Order = ID


        Dim db As New OleDb.OleDbConnection(My.Resources.Cadena_Conexion)
        Dim dt As New DataTable("Datos")

        Dim cadena As String = String.Format("SELECT {0}, {1} FROM {2} {3} ORDER BY {4}", ID, Nombre, Tabla, Where, Order)

        If ID.Length = 0 Then
            cadena = "SELECT * FROM " & Tabla & Where
        End If

        Dim dat As New OleDb.OleDbDataAdapter(cadena, db)
        dat.Fill(dt)

        For Each f As DataRow In dt.Rows
            lst.Items.Add(String.Format("{0}. {1}", f.Item(0), f.Item(1).ToString.Trim))
        Next
    End Sub
    'Public Sub Llenar_List(ByRef lst As ComboBox, ByVal Tabla As String, Optional ByVal ID As String = "", Optional ByVal Nombre As String = "", Optional ByVal Where As String = "", Optional ByVal Order As String = "")
    '    If Where.Length Then Where = " WHERE " & Where
    '    If Order.Length = 0 Then Order = ID

    '    Dim dt As DataTable
    '    If ID.Length Then
    '        dt = dbM.Datos(String.Format("SELECT {0}, {1} FROM {2} {3} ORDER BY {4}", ID, Nombre, Tabla, Where, Order))
    '    Else
    '        dt = dbM.Datos("SELECT * FROM " & Tabla & Where)
    '    End If

    '    For Each f As DataRow In dt.Rows
    '        lst.Items.Add(String.Format("{0}. {1}", f.Item(0), f.Item(1).ToString.Trim))
    '    Next
    'End Sub

    Function llenarExcel(ByVal ElGrid As SpeedGrilla) As Boolean

        'Creamos las variables

        Dim exApp As New Microsoft.Office.Interop.Excel.Application

        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook

        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet

        Try

            'Añadimos el Libro al programa, y la hoja al libro

            exLibro = exApp.Workbooks.Add

            exHoja = exLibro.Worksheets.Add()

            ' ¿Cuantas columnas y cuantas filas?

            Dim NCol As Integer = ElGrid.Columnas.Count

            Dim NRow As Integer = ElGrid.Filas.Count

            'Aqui recorremos todas las filas, y por cada fila todas las columnas

            'y vamos escribiendo.

            For i As Integer = 1 To NCol

                exHoja.Cells.Item(1, i) = ElGrid.Columnas(i - 1).Name.ToString

            Next

            For Fila As Integer = 0 To NRow - 1

                For Col As Integer = 0 To NCol - 1

                    exHoja.Cells.Item(Fila + 2, Col + 1) = ElGrid.Texto(Col, Fila).Value

                Next

            Next

            'Titulo en negrita, Alineado al centro y que el tamaño de la columna

            'se ajuste al texto

            exHoja.Rows.Item(1).Font.Bold = 1

            exHoja.Rows.Item(1).HorizontalAlignment = 3

            exHoja.Columns.AutoFit()

            'Aplicación visible

            exApp.Application.Visible = True

            exHoja = Nothing

            exLibro = Nothing

            exApp = Nothing

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")

            Return False

        End Try

        Return True

    End Function

End Module
