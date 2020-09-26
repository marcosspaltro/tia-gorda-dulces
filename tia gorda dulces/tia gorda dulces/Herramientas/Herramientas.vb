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
End Module