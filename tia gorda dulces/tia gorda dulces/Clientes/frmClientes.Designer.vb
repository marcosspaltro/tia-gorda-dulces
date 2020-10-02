<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClientes))
        Me.grdClientes = New Grilla2.SpeedGrilla()
        Me.txtClientes = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'grdClientes
        '
        Me.grdClientes.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.None
        Me.grdClientes.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.SingleColumn
        Me.grdClientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdClientes.AutoResize = False
        Me.grdClientes.bColor = System.Drawing.SystemColors.Window
        Me.grdClientes.bColorSel = System.Drawing.SystemColors.Highlight
        Me.grdClientes.bFColor = System.Drawing.SystemColors.WindowText
        Me.grdClientes.bFColorSel = System.Drawing.SystemColors.HighlightText
        Me.grdClientes.Col = 0
        Me.grdClientes.Cols = 10
        Me.grdClientes.DataMember = ""
        Me.grdClientes.DataSource = Nothing
        Me.grdClientes.EnableEdicion = True
        Me.grdClientes.Encabezado = ""
        Me.grdClientes.fColor = System.Drawing.SystemColors.Control
        Me.grdClientes.FixCols = 0
        Me.grdClientes.FixRows = 0
        Me.grdClientes.FuenteEncabezado = Nothing
        Me.grdClientes.FuentePieDePagina = Nothing
        Me.grdClientes.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.None
        Me.grdClientes.Location = New System.Drawing.Point(12, 12)
        Me.grdClientes.MenuActivado = False
        Me.grdClientes.Name = "grdClientes"
        Me.grdClientes.PieDePagina = "" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "Page {0} of {1}"
        Me.grdClientes.PintarFilaSel = True
        Me.grdClientes.Redraw = True
        Me.grdClientes.Row = 0
        Me.grdClientes.Rows = 50
        Me.grdClientes.Size = New System.Drawing.Size(776, 400)
        Me.grdClientes.TabIndex = 0
        '
        'txtClientes
        '
        Me.txtClientes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtClientes.Location = New System.Drawing.Point(12, 418)
        Me.txtClientes.Name = "txtClientes"
        Me.txtClientes.Size = New System.Drawing.Size(231, 20)
        Me.txtClientes.TabIndex = 2
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtClientes)
        Me.Controls.Add(Me.grdClientes)
        Me.Name = "frmClientes"
        Me.Text = "frmClientes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grdClientes As Grilla2.SpeedGrilla
    Friend WithEvents txtClientes As TextBox
End Class
