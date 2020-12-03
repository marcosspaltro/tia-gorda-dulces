Imports System.IO
Public Class ClsRecetas

#Region " Devolver Datos "
    Public Function Datos(ByVal Optional Id As Integer = 0, ByVal Optional Nombre As String = "", ByVal Optional precio As Integer = 0) As DataTable
        Dim vFiltro As String = ""

        If Id <> 0 Then
            vFiltro = $" id_Producto={Id} OR  Nombre LIKE '%{Id}%'"
        Else
            If Nombre.Length Then vFiltro = $" Nombre LIKE '%{Nombre}%'"
        End If

        If vFiltro.Length Then vFiltro = " WHERE " & vFiltro

        Dim db As New OleDb.OleDbConnection(My.Resources.Cadena_Conexion)
        Dim dat As New OleDb.OleDbDataAdapter("SELECT * FROM vw_recetas" & vFiltro, db)

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
    Public Sub Agregar(ByVal cantidad As Integer, ByVal Id_Producto As Integer, ByVal id_ingrediente As Integer)
        Dim db As New OleDb.OleDbConnection(My.Resources.Cadena_Conexion)
        Dim dc As New OleDb.OleDbCommand($"INSERT INTO vw_Recetas (cantidad, Id_Producto, id_ingrediente) VALUES('{cantidad}', '{Id_Producto}', '{id_ingrediente}') ", db)
        db.Open()
        dc.ExecuteNonQuery()
        db.Close()
    End Sub

    Public Sub Editar(ByVal id As Integer, ByVal Id_Prod As Integer, ByVal cantidad As Integer, ByVal id_ingrediente As Integer)
        Dim db As New OleDb.OleDbConnection(My.Resources.Cadena_Conexion)
        Dim dc As New OleDb.OleDbCommand($"UPDATE vw_Recetas SET id_Producto={Id_Prod}, Cantidad = {cantidad},id_Ingrediente = {id_ingrediente} WHERE ID={id} ", db)
        db.Open()
        dc.ExecuteNonQuery()
        db.Close()

    End Sub

    Public Sub Borrar(ByVal Id As Integer)
        Dim db As New OleDb.OleDbConnection(My.Resources.Cadena_Conexion)
        Dim dc As New OleDb.OleDbCommand("DELETE FROM Recetas WHERE ID = " & Id, db)
        db.Open()
        dc.ExecuteNonQuery()
        db.Close()

    End Sub

    Public Function Nombre_Ingrediente(ByVal Id As Integer) As String
        Dim db As New OleDb.OleDbConnection(My.Resources.Cadena_Conexion)
        Dim dc As New OleDb.OleDbCommand("SELECT Ingrediente FROM vw_Recetas WHERE Id_Ingrediente=" & Id, db)

        db.Open()

        Dim s As Object
        s = dc.ExecuteScalar()

        If IsNothing(s) Then s = ""

        db.Close()
        Return s
    End Function

#End Region
End Class
