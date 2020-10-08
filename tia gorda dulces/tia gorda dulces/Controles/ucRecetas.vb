Public Class ucRecetas
    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click
        lstReceta.Items.Add(cbIngrediente.Text + "*" + txtCantidad.Text + "*" + cbMedida.Text)
    End Sub
End Class
