<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.mnustrip = New System.Windows.Forms.MenuStrip()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProductos = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStock = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHistorial = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnustrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnustrip
        '
        Me.mnustrip.BackColor = System.Drawing.SystemColors.Control
        Me.mnustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosToolStripMenuItem, Me.ClientesToolStripMenuItem})
        Me.mnustrip.Location = New System.Drawing.Point(0, 0)
        Me.mnustrip.Name = "mnustrip"
        Me.mnustrip.Size = New System.Drawing.Size(1035, 24)
        Me.mnustrip.TabIndex = 1
        Me.mnustrip.Text = "mnuStrip"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuProductos, Me.mnuStock})
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'mnuProductos
        '
        Me.mnuProductos.Name = "mnuProductos"
        Me.mnuProductos.Size = New System.Drawing.Size(161, 22)
        Me.mnuProductos.Text = "Editar Productos"
        '
        'mnuStock
        '
        Me.mnuStock.Name = "mnuStock"
        Me.mnuStock.Size = New System.Drawing.Size(161, 22)
        Me.mnuStock.Text = "Stock"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClientes, Me.mnuHistorial})
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.ClientesToolStripMenuItem.Text = "Ventas"
        '
        'mnuClientes
        '
        Me.mnuClientes.Name = "mnuClientes"
        Me.mnuClientes.Size = New System.Drawing.Size(118, 22)
        Me.mnuClientes.Text = "Clientes"
        '
        'mnuHistorial
        '
        Me.mnuHistorial.Name = "mnuHistorial"
        Me.mnuHistorial.Size = New System.Drawing.Size(118, 22)
        Me.mnuHistorial.Text = "Historial"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(1035, 613)
        Me.Controls.Add(Me.mnustrip)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mnustrip
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tia gorda dulces"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mnustrip.ResumeLayout(False)
        Me.mnustrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnustrip As MenuStrip
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuStock As ToolStripMenuItem
    Friend WithEvents mnuProductos As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuClientes As ToolStripMenuItem
    Friend WithEvents mnuHistorial As ToolStripMenuItem
End Class
