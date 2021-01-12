<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLDC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLDC))
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.lstLdc = New System.Windows.Forms.ListBox()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.grdldc = New tia_gorda_dulces.SpeedGrilla()
        Me.SuspendLayout()
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAgregar.Location = New System.Drawing.Point(12, 434)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(120, 24)
        Me.btnAgregar.TabIndex = 5
        Me.btnAgregar.Text = "Agregar a la lista"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'lstLdc
        '
        Me.lstLdc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstLdc.FormattingEnabled = True
        Me.lstLdc.Location = New System.Drawing.Point(605, 9)
        Me.lstLdc.Name = "lstLdc"
        Me.lstLdc.Size = New System.Drawing.Size(203, 420)
        Me.lstLdc.TabIndex = 4
        '
        'btnBorrar
        '
        Me.btnBorrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBorrar.Location = New System.Drawing.Point(138, 435)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(120, 24)
        Me.btnBorrar.TabIndex = 6
        Me.btnBorrar.Text = "Eliminar de  la lista"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'grdldc
        '
        Me.grdldc.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.None
        Me.grdldc.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.SingleColumn
        Me.grdldc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdldc.AutoResize = False
        Me.grdldc.bColor = System.Drawing.SystemColors.Window
        Me.grdldc.bColorSel = System.Drawing.SystemColors.Highlight
        Me.grdldc.bFColor = System.Drawing.SystemColors.WindowText
        Me.grdldc.bFColorSel = System.Drawing.SystemColors.HighlightText
        Me.grdldc.Col = 0
        Me.grdldc.Cols = 10
        Me.grdldc.DataMember = ""
        Me.grdldc.DataSource = Nothing
        Me.grdldc.EnableEdicion = True
        Me.grdldc.Encabezado = ""
        Me.grdldc.fColor = System.Drawing.SystemColors.Control
        Me.grdldc.FixCols = 0
        Me.grdldc.FixRows = 0
        Me.grdldc.FuenteEncabezado = Nothing
        Me.grdldc.FuentePieDePagina = Nothing
        Me.grdldc.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.None
        Me.grdldc.Location = New System.Drawing.Point(12, 9)
        Me.grdldc.MenuActivado = False
        Me.grdldc.Name = "grdldc"
        Me.grdldc.PieDePagina = "" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "Page {0} of {1}"
        Me.grdldc.PintarFilaSel = True
        Me.grdldc.Redraw = True
        Me.grdldc.Row = 0
        Me.grdldc.Rows = 50
        Me.grdldc.Size = New System.Drawing.Size(587, 420)
        Me.grdldc.TabIndex = 3
        '
        'frmLDC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 470)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.lstLdc)
        Me.Controls.Add(Me.grdldc)
        Me.Name = "frmLDC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLDC"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAgregar As Button
    Friend WithEvents lstLdc As ListBox
    Friend WithEvents grdldc As SpeedGrilla
    Friend WithEvents btnBorrar As Button
End Class
