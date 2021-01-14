Public Class clsLdc
    Public Sub New()

    End Sub

#Region " Editar Datos "

    Public Sub Agregar(Id_ingrediente As Integer, Unidades As Integer, Total As Integer)
        Dim db As New OleDb.OleDbConnection(My.Resources.Cadena_Conexion)
        Dim dc As New OleDb.OleDbCommand($"INSERT INTO Compras (Id_ingrediente, Unidades, Total) VALUES('{Id_ingrediente}','{Unidades}','{Total}')", db)

        db.Open()

        dc.ExecuteNonQuery()

        db.Close()
    End Sub

    Public Sub Editar(ByVal Id As Integer, Id_ingrediente As Integer, Unidades As Integer, Total As Integer)
        If Id <> 0 Then
            'Solo ejecutar si hay un Id 
            Dim db As New OleDb.OleDbConnection(My.Resources.Cadena_Conexion)
            Dim dc As New OleDb.OleDbCommand($"UPDATE Compras SET Id_ingrediente='{Id_ingrediente}', Unidades='{Unidades}', Total='{Total}' WHERE ID={Id} ", db)

            db.Open()

            dc.ExecuteNonQuery()

            db.Close()
        End If
    End Sub
    Public Sub Borrar(ByVal Id As Integer)
        Dim db As New OleDb.OleDbConnection(My.Resources.Cadena_Conexion)
        Dim dc As New OleDb.OleDbCommand("DELETE FROM Compras WHERE ID =" & Id, db)
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
    ''' <param name="Ingrediente">Nombre del producto</param>
    ''' <returns></returns>
    Public Function Datos(ByVal Optional Id As Integer = 0, ByVal Optional Ingrediente As String = "") As DataTable
        Dim vFiltro As String = ""

        If Id <> 0 Then
            vFiltro = $" Id={Id} LIKE '%{Id}%'"
        Else
            If Ingrediente.Length Then vFiltro = $" Ingrediente LIKE '%{Ingrediente}%'"
        End If

        If vFiltro.Length Then vFiltro = " WHERE " & vFiltro
        Dim db As New OleDb.OleDbConnection(My.Resources.Cadena_Conexion)
        Dim dat As New OleDb.OleDbDataAdapter("SELECT * FROM vw_Ldc" & vFiltro, db)
        Dim dt As New DataTable("Datos")
        dat.Fill(dt)

        Return dt
    End Function
    Public Function Max_Id() As Integer
        Dim db As New OleDb.OleDbConnection(My.Resources.Cadena_Conexion)
        Dim cm As New OleDb.OleDbCommand("SELECT MAX(Id) FROM Clientes", db)

        Dim d As Object = Nothing

        cm.CommandType = CommandType.Text
        db.Open()
        d = cm.ExecuteScalar()

        Return CInt(d)
    End Function

#End Region
End Class

