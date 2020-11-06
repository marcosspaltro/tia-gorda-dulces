Public Class clsLdc
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

#End Region
End Class

