<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEditar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditar))
        Me.btnAñadir = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.cbIngrediente = New System.Windows.Forms.ComboBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grdEditar = New tia_gorda_dulces.SpeedGrilla()
        Me.SuspendLayout()
        '
        'btnAñadir
        '
        Me.btnAñadir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAñadir.Location = New System.Drawing.Point(12, 469)
        Me.btnAñadir.Name = "btnAñadir"
        Me.btnAñadir.Size = New System.Drawing.Size(75, 23)
        Me.btnAñadir.TabIndex = 1
        Me.btnAñadir.Text = "Añadir"
        Me.btnAñadir.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBorrar.Location = New System.Drawing.Point(280, 469)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(75, 23)
        Me.btnBorrar.TabIndex = 2
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'cbIngrediente
        '
        Me.cbIngrediente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbIngrediente.FormattingEnabled = True
        Me.cbIngrediente.Location = New System.Drawing.Point(93, 471)
        Me.cbIngrediente.Name = "cbIngrediente"
        Me.cbIngrediente.Size = New System.Drawing.Size(125, 21)
        Me.cbIngrediente.TabIndex = 4
        '
        'txtCantidad
        '
        Me.txtCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCantidad.Location = New System.Drawing.Point(224, 471)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(50, 20)
        Me.txtCantidad.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(90, 453)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Ingrediente:"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(221, 453)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Cantidad:"
        '
        'grdEditar
        '
        Me.grdEditar.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.None
        Me.grdEditar.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.SingleColumn
        Me.grdEditar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdEditar.AutoResize = False
        Me.grdEditar.bColor = System.Drawing.SystemColors.Window
        Me.grdEditar.bColorSel = System.Drawing.SystemColors.Highlight
        Me.grdEditar.bFColor = System.Drawing.SystemColors.WindowText
        Me.grdEditar.bFColorSel = System.Drawing.SystemColors.HighlightText
        Me.grdEditar.Col = 0
        Me.grdEditar.Cols = 10
        Me.grdEditar.DataMember = ""
        Me.grdEditar.DataSource = Nothing
        Me.grdEditar.EnableEdicion = True
        Me.grdEditar.Encabezado = ""
        Me.grdEditar.fColor = System.Drawing.SystemColors.Control
        Me.grdEditar.FixCols = 0
        Me.grdEditar.FixRows = 0
        Me.grdEditar.FuenteEncabezado = Nothing
        Me.grdEditar.FuentePieDePagina = Nothing
        Me.grdEditar.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.None
        Me.grdEditar.Location = New System.Drawing.Point(12, 12)
        Me.grdEditar.MenuActivado = False
        Me.grdEditar.Name = "grdEditar"
        Me.grdEditar.PieDePagina = "" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "Page {0} of {1}"
        Me.grdEditar.PintarFilaSel = True
        Me.grdEditar.Redraw = True
        Me.grdEditar.Row = 0
        Me.grdEditar.Rows = 50
        Me.grdEditar.Size = New System.Drawing.Size(343, 438)
        Me.grdEditar.TabIndex = 3
        '
        'frmEditar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 504)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.cbIngrediente)
        Me.Controls.Add(Me.grdEditar)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnAñadir)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEditar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar Receta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAñadir As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents grdEditar As SpeedGrilla
    Friend WithEvents cbIngrediente As ComboBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
