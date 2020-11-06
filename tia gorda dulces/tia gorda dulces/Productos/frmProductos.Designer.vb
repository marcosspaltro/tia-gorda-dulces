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
        Me.lstReceta = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.lblindex = New System.Windows.Forms.Label()
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
        Me.grdProductos.Size = New System.Drawing.Size(787, 516)
        Me.grdProductos.TabIndex = 0
        '
        'txtProductos
        '
        Me.txtProductos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtProductos.Location = New System.Drawing.Point(13, 559)
        Me.txtProductos.Name = "txtProductos"
        Me.txtProductos.Size = New System.Drawing.Size(231, 20)
        Me.txtProductos.TabIndex = 1
        '
        'lstReceta
        '
        Me.lstReceta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstReceta.FormattingEnabled = True
        Me.lstReceta.Location = New System.Drawing.Point(860, 61)
        Me.lstReceta.Name = "lstReceta"
        Me.lstReceta.Size = New System.Drawing.Size(281, 342)
        Me.lstReceta.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(855, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Receta:"
        '
        'btnEditar
        '
        Me.btnEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEditar.Location = New System.Drawing.Point(860, 409)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(95, 23)
        Me.btnEditar.TabIndex = 4
        Me.btnEditar.Text = "Editar Receta"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'lblindex
        '
        Me.lblindex.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblindex.AutoSize = True
        Me.lblindex.Location = New System.Drawing.Point(1141, 414)
        Me.lblindex.Name = "lblindex"
        Me.lblindex.Size = New System.Drawing.Size(0, 13)
        Me.lblindex.TabIndex = 5
        '
        'frmProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1212, 591)
        Me.Controls.Add(Me.lblindex)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstReceta)
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
    Friend WithEvents lstReceta As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnEditar As Button
    Friend WithEvents lblindex As Label
End Class