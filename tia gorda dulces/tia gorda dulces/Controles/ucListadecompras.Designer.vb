<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucListadecompras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucListadecompras))
        Me.grdldc = New tia_gorda_dulces.SpeedGrilla()
        Me.lstLdc = New System.Windows.Forms.ListBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'grdldc
        '
        Me.grdldc.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.None
        Me.grdldc.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.SingleColumn
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
        Me.grdldc.Location = New System.Drawing.Point(3, 3)
        Me.grdldc.MenuActivado = False
        Me.grdldc.Name = "grdldc"
        Me.grdldc.PieDePagina = "" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "Page {0} of {1}"
        Me.grdldc.PintarFilaSel = True
        Me.grdldc.Redraw = True
        Me.grdldc.Row = 0
        Me.grdldc.Rows = 50
        Me.grdldc.Size = New System.Drawing.Size(617, 500)
        Me.grdldc.TabIndex = 0
        '
        'lstLdc
        '
        Me.lstLdc.FormattingEnabled = True
        Me.lstLdc.Location = New System.Drawing.Point(627, 4)
        Me.lstLdc.Name = "lstLdc"
        Me.lstLdc.Size = New System.Drawing.Size(334, 498)
        Me.lstLdc.TabIndex = 1
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(3, 509)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(103, 34)
        Me.btnAgregar.TabIndex = 2
        Me.btnAgregar.Text = "Agregar a la lista"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'ucListadecompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.lstLdc)
        Me.Controls.Add(Me.grdldc)
        Me.Name = "ucListadecompras"
        Me.Size = New System.Drawing.Size(964, 570)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grdldc As SpeedGrilla
    Friend WithEvents lstLdc As ListBox
    Friend WithEvents btnAgregar As Button
End Class
