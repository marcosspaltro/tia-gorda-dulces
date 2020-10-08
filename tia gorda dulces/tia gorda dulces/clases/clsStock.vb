Public Class clsStock
    Public Sub New()

    End Sub

#Region " Editar Datos "

    Public Sub Agregar(Ingrediente As String, Precioxunidad As Integer, Cantidadxunidad As Integer, Stock As Integer, Lugardecompra As String)
        Dim db As New OleDb.OleDbConnection(My.Resources.Cadena_Conexion)
        Dim dc As New OleDb.OleDbCommand($"INSERT INTO Stock (Ingrediente, Precioxunidad, Cantidadxunidad, Stock, Lugardecompra) VALUES('{Ingrediente}','{Precioxunidad}','{Cantidadxunidad}','{Stock}','{Lugardecompra}')", db)

        db.Open()

        dc.ExecuteNonQuery()

        db.Close()
    End Sub

    Public Sub Editar(ByVal Id As Integer, ByVal Ingrediente As String, Precioxunidad As Integer, Cantidadxunidad As Integer, ByVal Stock As Integer, ByVal Lugardecompra As String)
        If Id <> 0 Then
            'Solo ejecutar si hay un Id 
            Dim db As New OleDb.OleDbConnection(My.Resources.Cadena_Conexion)
            Dim dc As New OleDb.OleDbCommand($"UPDATE Stock SET Ingrediente='{Ingrediente}', Precioxunidad='{Precioxunidad}', Cantidadxunidad='{Cantidadxunidad}', Stock='{Stock}', Lugardecompra='{Lugardecompra}'
                                            WHERE ID={Id}", db)

            db.Open()

            dc.ExecuteNonQuery()

            db.Close()
        End If
    End Sub

    Public Sub Borrar(ByVal Id As Integer)
        Dim db As New OleDb.OleDbConnection(My.Resources.Cadena_Conexion)
        Dim dc As New OleDb.OleDbCommand("DELETE FROM Stock WHERE ID=" & Id, db)

        db.Open()

        dc.ExecuteNonQuery()

        db.Close()
    End Sub

#End Region
#Region " Devolver Datos "

    ''' <summary>
    ''' Devuelve los datos de la vista vw_Stock
    ''' </summary>
    ''' <param name="Id">Id del registro</param>
    ''' <param name="Id_Producto">Codigo de producto</param>
    ''' <param name="Nombre">Nombre del producto</param>
    ''' <returns></returns>
    Public Function Datos(ByVal Optional Id As Integer = 0, ByVal Optional Fecha As String = "", ByVal Optional Id_Producto As Integer = 0, ByVal Optional Nombre As String = "") As DataTable
        Dim vFiltro As String = ""

        If Id <> 0 Then
            vFiltro = $" Id={Id} OR Id_Producto={Id_Producto} OR Nombre LIKE '%{Id}%'"
        Else
            If Nombre.Length Then vFiltro = $" Nombre LIKE '%{Nombre}%'"
        End If

        If Fecha.Length Then
            If vFiltro.Length Then
                vFiltro = vFiltro & " OR " & Fecha
            Else
                vFiltro = Fecha
            End If
        End If
        If vFiltro.Length Then vFiltro = " WHERE " & vFiltro
        Dim db As New OleDb.OleDbConnection(My.Resources.Cadena_Conexion)
        Dim dat As New OleDb.OleDbDataAdapter("SELECT * FROM Stock" & vFiltro, db)
        Dim dt As New DataTable("Datos")
        dat.Fill(dt)

        Return dt
    End Function

    Public Function Nombre_Producto(ByVal Id As Integer) As String
        Dim db As New OleDb.OleDbConnection(My.Resources.Cadena_Conexion)
        Dim dc As New OleDb.OleDbCommand("SELECT Nombre FROM Productos WHERE Id=" & Id, db)

        db.Open()

        Dim s As Object
        s = dc.ExecuteScalar()

        If IsNothing(s) Then s = ""

        db.Close()
        Return s
    End Function

    Public Function Max_Id() As Integer
        Dim db As New OleDb.OleDbConnection(My.Resources.Cadena_Conexion)
        Dim cm As New OleDb.OleDbCommand("SELECT MAX(Id) FROM Stock", db)

        Dim d As Object = Nothing

        cm.CommandType = CommandType.Text
        db.Open()
        d = cm.ExecuteScalar()

        Return CInt(d)
    End Function
#End Region
End Class