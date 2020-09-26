Public Class frmMain
    Dim frProd As New frmProductos

    Private Sub mnuProductos_Click(sender As Object, e As EventArgs) Handles mnuProductos.Click
        frmProductos.MdiParent = Me
        frmProductos.Show()
        frmProductos.WindowState = FormWindowState.Minimized
        frmProductos.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub mnuClientes_Click(sender As Object, e As EventArgs) Handles mnuClientes.Click
        frmClientes.MdiParent = Me
        frmClientes.Show()
        frmClientes.WindowState = FormWindowState.Minimized
        frmClientes.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub mnuHistorial_Click(sender As Object, e As EventArgs) Handles mnuHistorial.Click
        frmHistorial.MdiParent = Me
        frmHistorial.Show()
        frmHistorial.WindowState = FormWindowState.Minimized
        frmHistorial.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub StockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuStock.Click
        frmStock.MdiParent = Me
        frmStock.Show()
        frmStock.WindowState = FormWindowState.Minimized
        frmStock.WindowState = FormWindowState.Maximized
    End Sub
End Class
