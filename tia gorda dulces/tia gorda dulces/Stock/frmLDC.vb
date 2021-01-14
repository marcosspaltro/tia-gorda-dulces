Public Class frmLDC
    Private clLdc As New clsLdc
    Private Sub frmLDC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar_LST()
        Dim vTeclas() As Integer = {46}

        grdldc.TeclasManejadas = vTeclas
        Llenar_List(lstLdc, "Stock")
    End Sub

    Private Sub Cargar_LST()
        Dim fId As Integer = 0
        Dim fId_Ingrediente As String = ""


        Dim dt As DataTable = clLdc.Datos(fId, fId_Ingrediente)

        With grdldc
            .MostrarDatos(dt, True)
            .ColW(0) = 0
            .ColW(1) = 40
            .FixCols = 1
            .ColW(2) = 100
            .ColW(3) = 80
            .ColW(4) = 80
            .ColW(5) = 55
            .ColW(6) = 40
        End With
    End Sub

    Private Sub grdldc_Load(sender As Object, e As EventArgs) Handles grdldc.Load

    End Sub

    Private Sub lstLdc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstLdc.SelectedIndexChanged

    End Sub
    Private Sub grdLdc_Editado(f As Short, c As Short, a As Object) Handles grdldc.Editado
        With grdldc
            Dim vId As Integer = grdldc.Texto(f, grdldc.ColIndex("Id"))
            Dim vId_ingrediente As Integer = .Texto(f, .ColIndex("Id_ingrediente"))
            Dim vUnidades As Integer = .Texto(f, .ColIndex("Unidades"))
            Dim vValor As Integer = .Texto(f, .ColIndex("precioxunidad"))
            Dim vTotal As Integer = vUnidades * vValor
            Select Case c

                Case .ColIndex("Id_Ingrediente")
                    If .EsUltimaF Then
                        .Texto(f, c) = a
                        clLdc.Agregar(a, vUnidades, vTotal)
                        Cargar_LST()
                        .ActivarCelda(f, .ColIndex("Unidades"))
                    Else
                        .Texto(f, c) = a
                        clLdc.Editar(vId, a, vUnidades, vTotal)
                        .ActivarCelda(f + 1, c)
                    End If

                Case .ColIndex("Unidades")
                    .Texto(f, c) = a
                    If .Texto(f, c) < 0 Then
                        .ErrorEnTxt()
                    Else
                        If .EsUltimaF Then
                            If .Texto(f, .ColIndex("Id_Ingrediente")) = "" Then
                                .ActivarCelda(f, .ColIndex("Id_Ingrediente"))
                            Else

                            End If
                        Else
                            clLdc.Editar(vId, vId_ingrediente, a, vTotal)
                            Cargar_LST()
                            .ActivarCelda(f + 1, c)
                        End If
                    End If
            End Select
        End With
    End Sub
    Private Sub grdLdc_KeyUp(sender As Object, e As Short) Handles grdldc.KeyUp
        Select Case e
            Case 46
                'Tecla Borrar/Delete
                If grdldc.Texto(, 0) <> 0 Then
                    If MsgBox($"¿Esta seguro de borrar el producto {grdldc.Texto(, 0)}. {grdldc.Texto(, 2)}?",
                          MsgBoxStyle.YesNoCancel + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "Borrar") = MsgBoxResult.Yes Then
                        'Borrar el registro
                        clLdc.Borrar(grdldc.Texto(, 0))
                        grdldc.BorrarFila()
                    End If
                End If
        End Select
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        If grdldc.Texto(, grdldc.ColIndex("id")) <> 0 Then
            If MsgBox($"¿Esta seguro de borrar de la lista de compra: {grdldc.Texto(, 0)}. {grdldc.Texto(, 2)}?",
                  MsgBoxStyle.YesNoCancel + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "Borrar") = MsgBoxResult.Yes Then
                'Borrar el registro
                clLdc.Borrar(grdldc.Texto(, grdldc.ColIndex("id")))
                grdldc.BorrarFila()
            End If
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If Not lstLdc.SelectedIndex = -1 Then
            Dim id As String = lstLdc.Text.Substring(0, lstLdc.Text.IndexOf("."))
            Dim f As Integer = grdldc.Filas.Count - 1
            grdldc.Texto(f, grdldc.ColIndex("id_ingrediente")) = id
            grdldc.Texto(f, grdldc.ColIndex("Unidades")) = "0"
            Dim vId_ingrediente As Integer = grdldc.Texto(f, grdldc.ColIndex("Id_ingrediente"))
            Dim vUnidades As Integer = grdldc.Texto(grdldc.Filas.Count - 1, grdldc.ColIndex("Unidades"))
            Dim vValor As Integer = grdldc.Texto(f, grdldc.ColIndex("precioxunidad"))
            Dim vTotal As Integer = vUnidades * vValor
            clLdc.Agregar(vId_ingrediente, vUnidades, vTotal)
            grdldc.AgregarFila()
            lstLdc.SelectedIndex = -1
            Cargar_LST()
        End If
    End Sub
End Class