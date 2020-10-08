<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucRecetas
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbIngrediente = New System.Windows.Forms.ComboBox()
        Me.btnAgregarIng = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAñadir = New System.Windows.Forms.Button()
        Me.lstReceta = New System.Windows.Forms.ListBox()
        Me.cbMedida = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'txtCantidad
        '
        Me.txtCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCantidad.Location = New System.Drawing.Point(199, 340)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(60, 20)
        Me.txtCantidad.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 364)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ingrediente"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(196, 363)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cantidad"
        '
        'cbIngrediente
        '
        Me.cbIngrediente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbIngrediente.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbIngrediente.FormattingEnabled = True
        Me.cbIngrediente.Location = New System.Drawing.Point(3, 340)
        Me.cbIngrediente.Name = "cbIngrediente"
        Me.cbIngrediente.Size = New System.Drawing.Size(190, 21)
        Me.cbIngrediente.TabIndex = 4
        Me.cbIngrediente.Text = "Elegir Ingrediente"
        '
        'btnAgregarIng
        '
        Me.btnAgregarIng.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarIng.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAgregarIng.Location = New System.Drawing.Point(3, 379)
        Me.btnAgregarIng.Name = "btnAgregarIng"
        Me.btnAgregarIng.Size = New System.Drawing.Size(152, 23)
        Me.btnAgregarIng.TabIndex = 5
        Me.btnAgregarIng.Text = "Crear nuevo ingrediente"
        Me.btnAgregarIng.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(262, 363)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Medida"
        '
        'btnAñadir
        '
        Me.btnAñadir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAñadir.Location = New System.Drawing.Point(199, 379)
        Me.btnAñadir.Name = "btnAñadir"
        Me.btnAñadir.Size = New System.Drawing.Size(152, 23)
        Me.btnAñadir.TabIndex = 8
        Me.btnAñadir.Text = "Añadir ingrediente"
        Me.btnAñadir.UseVisualStyleBackColor = True
        '
        'lstReceta
        '
        Me.lstReceta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstReceta.FormattingEnabled = True
        Me.lstReceta.Location = New System.Drawing.Point(3, 3)
        Me.lstReceta.Name = "lstReceta"
        Me.lstReceta.Size = New System.Drawing.Size(419, 316)
        Me.lstReceta.TabIndex = 9
        '
        'cbMedida
        '
        Me.cbMedida.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbMedida.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbMedida.FormattingEnabled = True
        Me.cbMedida.Location = New System.Drawing.Point(265, 339)
        Me.cbMedida.Name = "cbMedida"
        Me.cbMedida.Size = New System.Drawing.Size(59, 21)
        Me.cbMedida.TabIndex = 10
        '
        'ucRecetas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cbMedida)
        Me.Controls.Add(Me.lstReceta)
        Me.Controls.Add(Me.btnAñadir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnAgregarIng)
        Me.Controls.Add(Me.cbIngrediente)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCantidad)
        Me.Name = "ucRecetas"
        Me.Size = New System.Drawing.Size(425, 442)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbIngrediente As ComboBox
    Friend WithEvents btnAgregarIng As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAñadir As Button
    Friend WithEvents lstReceta As ListBox
    Friend WithEvents cbMedida As ComboBox
End Class
