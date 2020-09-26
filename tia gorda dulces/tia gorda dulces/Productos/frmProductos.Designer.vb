<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProductos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductos))
        Me.grdProductos = New Grilla2.SpeedGrilla()
        Me.txtProductos = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'grdProductos
        '
        Me.grdProductos.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.None
        Me.grdProductos.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.SingleColumn
        Me.grdProductos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdProductos.AutoResize = False
        Me.grdProductos.bColor = System.Drawing.SystemColors.Window
        Me.grdProductos.bColorSel = System.Drawing.SystemColors.Highlight
        Me.grdProductos.bFColor = System.Drawing.SystemColors.WindowText
        Me.grdProductos.bFColorSel = System.Drawing.SystemColors.HighlightText
        Me.grdProductos.Col = 0
        Me.grdProductos.Cols = 10
        Me.grdProductos.DataMember = ""
        Me.grdProductos.DataSource = Nothing
        Me.grdProductos.EnableEdicion = True
        Me.grdProductos.Encabezado = ""
        Me.grdProductos.fColor = System.Drawing.SystemColors.Control
        Me.grdProductos.FixCols = 0
        Me.grdProductos.FixRows = 0
        Me.grdProductos.FuenteEncabezado = Nothing
        Me.grdProductos.FuentePieDePagina = Nothing
        Me.grdProductos.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.None
        Me.grdProductos.Location = New System.Drawing.Point(12, 12)
        Me.grdProductos.MenuActivado = False
        Me.grdProductos.Name = "grdProductos"
        Me.grdProductos.PieDePagina = "" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "Page {0} of {1}"
        Me.grdProductos.PintarFilaSel = True
        Me.grdProductos.Redraw = True
        Me.grdProductos.Row = 0
        Me.grdProductos.Rows = 50
        Me.grdProductos.Size = New System.Drawing.Size(776, 400)
        Me.grdProductos.TabIndex = 0
        '
        'txtProductos
        '
        Me.txtProductos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtProductos.Location = New System.Drawing.Point(13, 418)
        Me.txtProductos.Name = "txtProductos"
        Me.txtProductos.Size = New System.Drawing.Size(231, 20)
        Me.txtProductos.TabIndex = 1
        '
        'frmProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtProductos)
        Me.Controls.Add(Me.grdProductos)
        Me.Name = "frmProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Productos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grdProductos As Grilla2.SpeedGrilla
    Friend WithEvents txtProductos As TextBox
End Class