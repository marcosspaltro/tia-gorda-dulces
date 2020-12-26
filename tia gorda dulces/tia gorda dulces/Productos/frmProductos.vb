Imports System.IO

Public Class frmProductos
    Private clProd As New clsProductos
    Private clRecetas As New clsRecetas
    Private Sub frmProductos_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim vTeclas() As Integer = {46}

        grdProductos.TeclasManejadas = vTeclas
        Cargar_LST()
    End Sub

    Private Sub Cargar_LST()
        Dim fId As Integer = 0
        Dim fNombre As String = ""

        If txtProductos.Text.Length Then
            fNombre = txtProductos.Text
            If IsNumeric(txtProductos.Text) Then fId = CInt(txtProductos.Text)
        End If

        Dim dt As DataTable = clProd.Datos(fId, fNombre)

        With grdProductos
            .MostrarDatos(dt, True)
            .ColW(0) = 60
            .ColW(1) = 150
            .FixCols = 1
        End With
    End Sub

    Private Sub grdProductos_Editado(f As Short, c As Short, a As Object) Handles grdProductos.Editado
        With grdProductos
            Dim vId As Integer = grdProductos.Texto(f, grdProductos.ColIndex("Id"))
            Dim vNombre As String
            Dim vPrecio As integer
            vNombre = .Texto(f, .ColIndex("Nombre"))
            vPrecio = .Texto(f, .ColIndex("precioxunidad"))

            Dim id_prod As String = grdProductos.Texto(f, grdProductos.ColIndex("id"))
            Select Case c

                Case .ColIndex("nombre")
                    If .EsUltimaF Then
                        .Texto(f, c) = a
                        .ActivarCelda(f, .ColIndex("precioxunidad"))
                    Else
                        .Texto(f, c) = a
                        clProd.Editar(vId, a, vPrecio)
                        .ActivarCelda(f + 1, c)
                    End If

                Case .ColIndex("precioxunidad")
                    .Texto(f, c) = a
                    If .Texto(f, c) < 0 Then
                        .ErrorEnTxt()
                    Else
                        If .EsUltimaF Then
                            If .Texto(f, .ColIndex("Nombre")) = "" Then

                                .ActivarCelda(f, .ColIndex("Nombre"))
                            Else
                                clProd.Agregar(vNombre, a)
                                grdProductos.Texto(f, grdProductos.ColIndex("Id")) = clProd.Max_Id
                                .AgregarFila()
                                .ActivarCelda(f + 1, .ColIndex("Nombre"))


                            End If
                        Else
                            clProd.Editar(vId, vNombre, a)
                            .ActivarCelda(f + 1, .ColIndex("precioxunidad"))
                        End If
                    End If
            End Select
        End With

    End Sub
    Private Sub grdProductos_KeyUp(sender As Object, e As Short) Handles grdProductos.KeyUp
        Select Case e
            Case 46
                'Tecla Borrar/Delete
                If grdProductos.Texto(, 0) <> 0 Then
                    If MsgBox($"¿Esta seguro de borrar el producto {grdProductos.Texto(, 0)}. {grdProductos.Texto(, 1)}?",
                          MsgBoxStyle.YesNoCancel + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "Borrar") = MsgBoxResult.Yes Then
                        'Borrar el registro
                        clProd.Borrar(grdProductos.Texto(, 0))
                        grdProductos.BorrarFila()
                    End If
                End If
            Case 32
                'Barra Espaciadora
        End Select
    End Sub

    Private Sub txtProductos_TextChanged(sender As Object, e As EventArgs) Handles txtProductos.TextChanged
        Cargar_LST()
    End Sub

    Private Sub grdProductos_Changed(sender As Object, e As EventArgs) Handles grdProductos.TabIndexChanged
    End Sub
    Private Sub Cargar_Receta(ByVal Tabla As String, Optional ByVal ID As String = "", Optional ByVal Nombre As String = "", Optional ByVal Where As String = "", Optional ByVal Order As String = "")
        If Where.Length Then Where = " WHERE " & Where
        If Order.Length = 0 Then Order = ID
        Dim f As Short
        Dim id_prod As String = grdProductos.Texto(f, grdProductos.ColIndex("id"))
        btnEditar.Text = id_prod

        Dim db As New OleDb.OleDbConnection(My.Resources.Cadena_Conexion)
        Dim dt As New DataTable("Datos")

        Dim cadena As String = String.Format("SELECT {1}, {0} FROM {2} {3} ORDER BY {4}", ID, Nombre, Tabla, Where, Order)

        If ID.Length = 0 Then
            cadena = "SELECT * FROM " & Tabla & Where
        End If

        Dim dat As New OleDb.OleDbDataAdapter(cadena, db)
        dat.Fill(dt)

        For Each i As DataRow In dt.Rows
            lstReceta.Items.Add(String.Format("{0}. {1}", i.Item(0), i.Item(1).ToString.Trim))
        Next
    End Sub

    Public Sub grdProductos_CambioFila(Fila As Short) Handles grdProductos.CambioFila
        Dim prod As String = grdProductos.Texto(Fila, 0)
        lstReceta.Items.Clear()
        Llenar_List(lstReceta, "vw_Recetas",,, "id_producto =" + prod)
        lblindex.Text = prod
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If grdProductos.Texto = "" Then

        Else
            Dim id As String = lblindex.Text
            frmEditar.Show()
            Dim dt As DataTable = clRecetas.Datos(id)

            With frmEditar.grdEditar
                .MostrarDatos(dt, True)
                .ColW(0) = 100
                .FixCols = 1
                .ColW(2) = 0
                .ColW(3) = 0
                .ColW(4) = 0
                frmEditar.Text = grdProductos.Texto
            End With
        End If
    End Sub
    Public Sub recargarlst()
        grdProductos.Siguiente_Fila()
        grdProductos.Anterior_Fila()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        llenarExcel(grdProductos)
    End Sub
End Class