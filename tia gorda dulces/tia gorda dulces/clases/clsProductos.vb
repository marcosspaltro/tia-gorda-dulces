Public Class clsProductos

#Region " Devolver Datos "
    Public Function Datos(ByVal Optional Id As Integer = 0, ByVal Optional Nombre As String = "") As DataTable
        Dim vFiltro As String = ""

        If Id <> 0 Then
            vFiltro = $" Id={Id} OR  Nombre LIKE '%{Id}%'"
        Else
            If Nombre.Length Then vFiltro = $" Nombre LIKE '%{Nombre}%'"
        End If

        If vFiltro.Length Then vFiltro = " WHERE " & vFiltro

        Dim db As New OleDb.OleDbConnection(My.Resources.Cadena_Conexion)
        Dim dat As New OleDb.OleDbDataAdapter("SELECT * FROM Productos" & vFiltro, db)

        Dim dt As New DataTable("Datos")
        dat.Fill(dt)

        Return dt
    End Function

    Public Function Max_Id() As Integer
        Dim db As New OleDb.OleDbConnection(My.Resources.Cadena_Conexion)
        Dim cm As New OleDb.OleDbCommand("SELECT MAX(Id) FROM Productos", db)

        Dim d As Object = Nothing

        cm.CommandType = CommandType.Text
        db.Open()
        d = cm.ExecuteScalar()

        Return CInt(d)
    End Function

#End Region

#Region " Editar Datos"
    Public Sub Agregar(ByVal nombre_Nuevo As String)
        Dim db As New OleDb.OleDbConnection(My.Resources.Cadena_Conexion)
        Dim dc As New OleDb.OleDbCommand($"INSERT INTO Productos (Nombre) VALUES('{nombre_Nuevo}') ", db)
        db.Open()
        dc.ExecuteNonQuery()
        db.Close()
    End Sub

    Public Sub Editar(ByVal id As Integer, ByVal Nombre_Nuevo As String)
        Dim db As New OleDb.OleDbConnection(My.Resources.Cadena_Conexion)
        Dim dc As New OleDb.OleDbCommand($"UPDATE Productos SET Nombre='{Nombre_Nuevo}' WHERE ID={id} ", db)
        db.Open()
        dc.ExecuteNonQuery()
        db.Close()

    End Sub

    Public Sub Borrar(ByVal Id As Integer)
        Dim db As New OleDb.OleDbConnection(My.Resources.Cadena_Conexion)
        Dim dc As New OleDb.OleDbCommand("DELETE FROM Productos WHERE ID =" & Id, db)
        db.Open()
        dc.ExecuteNonQuery()
        db.Close()

    End Sub

#End Region
End Class
