Public Class frmEditar
    Private clRecetas As New clsRecetas
    Private Sub frmEditar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Llenar_combobox(cbIngrediente, "stock")
        Dim vTeclas() As Integer = {46}

        grdEditar.TeclasManejadas = vTeclas
    End Sub
    Private Sub Cargar_LST()

        Dim dt As DataTable = clRecetas.Datos()

        With grdEditar
            .MostrarDatos(dt, True)
            .ColW(0) = 100
            .FixCols = 1
        End With
    End Sub

    Private Sub grdEditar_Editado(f As Short, c As Short, a As Object) Handles grdEditar.Editado
        With grdEditar
            Dim vId As Integer = grdEditar.Texto(f, .ColIndex("Id"))
            Dim vId_prod As Integer = grdEditar.Texto(f, .ColIndex("Id_producto"))
            Dim vid_ingrediente As Integer = .Texto(f, .ColIndex("id_ingrediente"))
            Dim vcantidad As Integer = .Texto(f, .ColIndex("cantidad"))

            Select Case c

                Case .ColIndex("cantidad")
                    If .EsUltimaF Then
                        .Texto(f, c) = a
                        .ActivarCelda(f, .ColIndex("id_ingrediente"))
                    Else
                        .Texto(f, c) = a
                        clRecetas.Editar(vId, vId_prod, a, vid_ingrediente)
                        .ActivarCelda(f + 1, c)
                    End If

                Case .ColIndex("id_Ingrediente")
                    Dim vNombre As String = clRecetas.Nombre_Ingrediente(a)
                    If .EsUltimaF Then
                        If vNombre.Length Then
                            .Texto(f, c) = a
                            .Texto(f, grdEditar.ColIndex("Id_producto")) = frmProductos.lblindex.Text
                            vId_prod = .Texto(f, .ColIndex("id_producto"))
                            clRecetas.Agregar(vcantidad, vId_prod, a)
                            .AgregarFila()
                            .ActivarCelda(f + 1, .ColIndex("cantidad"))
                            cargar_grd(f)
                            frmProductos.recargarlst()
                        Else
                            .ErrorEnTxt()
                        End If
                    Else
                        If vNombre.Length Then
                            .Texto(f, c) = a
                            clRecetas.Editar(vId, vId_prod, vcantidad, a)
                            .ActivarCelda(f + 1, .ColIndex("cantidad"))
                            cargar_grd(f)
                            frmProductos.grdProductos.Siguiente_Fila()
                            frmProductos.grdProductos.Anterior_Fila()
                        Else
                            .ErrorEnTxt()
                        End If
                    End If

            End Select
        End With
    End Sub
    Private Sub grdEditar_KeyUp(sender As Object, e As Short) Handles grdEditar.KeyUp
        Select Case e
            Case 46
                If grdEditar.Texto(, grdEditar.ColIndex("id")) <> 0 Then
                    If MsgBox($"¿Esta seguro de borrar el ingrediente {grdEditar.Texto(, 0)}. {grdEditar.Texto(, 1)}?",
                  MsgBoxStyle.YesNoCancel + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "Borrar") = MsgBoxResult.Yes Then
                        'Borrar el registro
                        clRecetas.Borrar(grdEditar.Texto(, grdEditar.ColIndex("id")))
                        grdEditar.BorrarFila()
                    End If
                End If
        End Select
    End Sub
    Private Sub cargar_grd(ByVal fila As Int16)
        Dim id As Integer = grdEditar.Texto(fila, grdEditar.ColIndex("id_producto"))
        Dim dt As DataTable = clRecetas.Datos(id)
        grdEditar.MostrarDatos(dt, True)
        grdEditar.ColW(2) = 0
        grdEditar.ColW(3) = 0
        grdEditar.ColW(4) = 0
    End Sub

    Private Sub frmEditar_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp

    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        If grdEditar.Texto(, grdEditar.ColIndex("id")) <> 0 Then
            If MsgBox($"¿Esta seguro de borrar el ingrediente {grdEditar.Texto(, 0)}. {grdEditar.Texto(, 1)}?",
                  MsgBoxStyle.YesNoCancel + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "Borrar") = MsgBoxResult.Yes Then
                'Borrar el registro
                clRecetas.Borrar(grdEditar.Texto(, grdEditar.ColIndex("id")))
                grdEditar.BorrarFila()
            End If
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click
        If Not cbIngrediente.Text = "" Then
            Dim id As String = cbIngrediente.Text.Substring(0, cbIngrediente.Text.IndexOf("."))
            Dim f As Integer = grdEditar.Filas.Count - 1
            grdEditar.Texto(f, grdEditar.ColIndex("id_ingrediente")) = id
            grdEditar.Texto(f, grdEditar.ColIndex("cantidad")) = txtCantidad.Text
            grdEditar.Texto(f, grdEditar.ColIndex("Id_producto")) = frmProductos.lblindex.Text
            Dim vId_prod As Integer = grdEditar.Texto(f, grdEditar.ColIndex("Id_producto"))
            Dim vid_ingrediente As Integer = grdEditar.Texto(grdEditar.Filas.Count - 1, grdEditar.ColIndex("id_ingrediente"))
            Dim vcantidad As Integer = grdEditar.Texto(grdEditar.Filas.Count - 1, grdEditar.ColIndex("cantidad"))
            clRecetas.Agregar(vcantidad, vId_prod, vid_ingrediente)
            grdEditar.AgregarFila()
            cbIngrediente.Text = ""
            txtCantidad.Text = ""
            cargar_grd(f)
            frmProductos.recargarlst()
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub
End Class