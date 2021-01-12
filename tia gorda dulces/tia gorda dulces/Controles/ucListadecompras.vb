Public Class ucListadecompras
    Private clLdc As New clsLdc
    Private Sub ucListadecompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar_LST()
    End Sub

    Private Sub Cargar_LST()
        Dim fId As Integer = 0
        Dim fNombre As String = ""


        Dim dt As DataTable = clLdc.Datos(fId, fNombre)

        With grdldc
            .MostrarDatos(dt, True)

        End With
    End Sub

    Private Sub grdldc_Load(sender As Object, e As EventArgs) Handles grdldc.Load

    End Sub

    Private Sub lstLdc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstLdc.SelectedIndexChanged

    End Sub
End Class
