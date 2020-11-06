<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditar))
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.grdEditar = New tia_gorda_dulces.SpeedGrilla()
        Me.SuspendLayout()
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.Location = New System.Drawing.Point(12, 458)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBorrar.Location = New System.Drawing.Point(276, 458)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(75, 23)
        Me.btnBorrar.TabIndex = 2
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(123, 459)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 4
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
        Me.grdEditar.Size = New System.Drawing.Size(339, 440)
        Me.grdEditar.TabIndex = 3
        '
        'frmEditar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 493)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.grdEditar)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnGuardar)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEditar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar Receta"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents grdEditar As SpeedGrilla
    Friend WithEvents ComboBox1 As ComboBox
End Class
