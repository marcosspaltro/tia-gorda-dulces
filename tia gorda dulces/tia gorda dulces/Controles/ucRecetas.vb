Public Class ucRecetas
    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click
        lstReceta.Items.Add(cbIngrediente.Text + "*" + txtCantidad.Text + "*" + cbMedida.Text)
    End Sub

    Private Sub cbIngrediente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbIngrediente.SelectedIndexChanged

    End Sub

    Private Sub ucRecetas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New OleDb.OleDbConnection(My.Resources.Cadena_Conexion)
        Dim dt As New DataTable("Datos")
        For Each f As DataRow In dt.Rows
            cbIngrediente.Items.Add(String.Format("{0}. {1}", f.Item(0), f.Item(1).ToString.Trim))
        Next
    End Sub

    Private Sub cbMedida_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMedida.SelectedIndexChanged
        cbMedida.Items.Add("g")
        cbMedida.Items.Add("ml")
        cbMedida.Items.Add("u")
    End Sub
End Class
