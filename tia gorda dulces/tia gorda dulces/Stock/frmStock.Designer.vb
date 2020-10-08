<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStock))
        Me.grdStock = New Grilla2.SpeedGrilla()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.btnCompra = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'grdStock
        '
        Me.grdStock.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.None
        Me.grdStock.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.SingleColumn
        Me.grdStock.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdStock.AutoResize = False
        Me.grdStock.bColor = System.Drawing.SystemColors.Window
        Me.grdStock.bColorSel = System.Drawing.SystemColors.Highlight
        Me.grdStock.bFColor = System.Drawing.SystemColors.WindowText
        Me.grdStock.bFColorSel = System.Drawing.SystemColors.HighlightText
        Me.grdStock.Col = 0
        Me.grdStock.Cols = 10
        Me.grdStock.DataMember = ""
        Me.grdStock.DataSource = Nothing
        Me.grdStock.EnableEdicion = True
        Me.grdStock.Encabezado = ""
        Me.grdStock.fColor = System.Drawing.SystemColors.Control
        Me.grdStock.FixCols = 0
        Me.grdStock.FixRows = 0
        Me.grdStock.FuenteEncabezado = Nothing
        Me.grdStock.FuentePieDePagina = Nothing
        Me.grdStock.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.None
        Me.grdStock.Location = New System.Drawing.Point(12, 12)
        Me.grdStock.MenuActivado = False
        Me.grdStock.Name = "grdStock"
        Me.grdStock.PieDePagina = "" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "Page {0} of {1}"
        Me.grdStock.PintarFilaSel = True
        Me.grdStock.Redraw = True
        Me.grdStock.Row = 0
        Me.grdStock.Rows = 50
        Me.grdStock.Size = New System.Drawing.Size(776, 400)
        Me.grdStock.TabIndex = 0
        '
        'txtStock
        '
        Me.txtStock.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtStock.Location = New System.Drawing.Point(12, 418)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(231, 20)
        Me.txtStock.TabIndex = 2
        '
        'btnCompra
        '
        Me.btnCompra.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCompra.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCompra.Location = New System.Drawing.Point(655, 416)
        Me.btnCompra.Name = "btnCompra"
        Me.btnCompra.Size = New System.Drawing.Size(133, 23)
        Me.btnCompra.TabIndex = 3
        Me.btnCompra.Text = "Hacer lista de compra"
        Me.btnCompra.UseVisualStyleBackColor = True
        '
        'frmStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCompra)
        Me.Controls.Add(Me.txtStock)
        Me.Controls.Add(Me.grdStock)
        Me.Name = "frmStock"
        Me.Text = "frmStock"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grdStock As Grilla2.SpeedGrilla
    Friend WithEvents txtStock As TextBox
    Friend WithEvents btnCompra As Button
End Class