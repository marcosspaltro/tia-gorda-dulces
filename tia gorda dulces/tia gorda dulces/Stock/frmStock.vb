Imports System.IO
Public Class frmStock
    Private clStock As New clsStock
    Private Sub frmStock_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim vTeclas() As Integer = {46}

        grdStock.TeclasManejadas = vTeclas
        Cargar_LST()
    End Sub

    Private Sub Cargar_LST()
        Dim fId As Integer = 0
        Dim fNombre As String = ""

        If txtStock.Text.Length Then
            fNombre = txtStock.Text
            If IsNumeric(txtStock.Text) Then fId = CInt(txtStock.Text)
        End If

        Dim dt As DataTable = clStock.Datos(fId, fNombre)

        With grdStock
            .MostrarDatos(dt, True)
            .ColW(0) = 60
            .ColW(1) = 150
            .FixCols = 1
        End With
    End Sub

    Private Sub grdStock_Editado(f As Short, c As Short, a As Object) Handles grdStock.Editado
        With grdStock
            Dim vId As Integer = grdStock.Texto(f, grdStock.ColIndex("Id"))
            Dim vIngrediente As String
            Dim vPrecioxunidad As Integer
            Dim vCantidadxUnidad As Integer
            Dim vStock As Integer
            Dim vLugardeCompra As String
            vIngrediente = .Texto(f, .ColIndex("Ingrediente"))
            vPrecioxunidad = .Texto(f, .ColIndex("Precioxunidad"))
            vCantidadxUnidad = .Texto(f, .ColIndex("CantidadxUnidad"))
            vStock = .Texto(f, .ColIndex("Stock"))
            vLugardeCompra = .Texto(f, .ColIndex("LugardeCompra"))
            Select Case c

                Case .ColIndex("Ingrediente")
                    If .EsUltimaF Then
                        .Texto(f, c) = a
                        .ActivarCelda(f, .ColIndex("Precioxunidad"))
                    Else
                        .Texto(f, c) = a
                        clStock.Editar(vId, a, vPrecioxunidad, vCantidadxUnidad, vStock, vLugardeCompra)
                        .ActivarCelda(f, .ColIndex("Precioxunidad"))
                    End If

                Case .ColIndex("Precioxunidad")
                    .Texto(f, c) = a
                    If .Texto(f, c) < 0 Then
                        .ErrorEnTxt()
                    Else
                        If .Texto(f, .ColIndex("Ingrediente")) = "" Then
                            .Texto(f, c) = ""
                            .ActivarCelda(f, .ColIndex("Ingrediente"))
                        Else
                            If .EsUltimaF Then
                                .ActivarCelda(f, .ColIndex("CantidadxUnidad"))
                            Else
                                clStock.Editar(vId, vIngrediente, a, vCantidadxUnidad, vStock, vLugardeCompra)
                                .ActivarCelda(f, .ColIndex("CantidadxUnidad"))
                            End If
                        End If
                    End If

                Case .ColIndex("CantidadxUnidad")
                    .Texto(f, c) = a
                    If .Texto(f, c) < 0 Then
                        .ErrorEnTxt()
                    Else
                        If .Texto(f, .ColIndex("Ingrediente")) = "" Then
                            .Texto(f, c) = ""
                            .ActivarCelda(f, .ColIndex("Ingrediente"))
                        Else
                            If .Texto(f, .ColIndex("Precioxunidad")) < 0 Then
                                .Texto(f, c) = ""
                                .ActivarCelda(f, .ColIndex("Precioxunidad"))
                            Else
                                If .EsUltimaF Then
                                    clStock.Agregar(vIngrediente, vPrecioxunidad, a, vStock, vLugardeCompra)
                                    grdStock.Texto(f, grdStock.ColIndex("Id")) = clStock.Max_Id
                                    .AgregarFila()
                                    .ActivarCelda(f, .ColIndex("Stock"))
                                Else
                                    clStock.Editar(vId, vIngrediente, vPrecioxunidad, a, vStock, vLugardeCompra)
                                    .ActivarCelda(f, .ColIndex("Stock"))
                                End If
                            End If
                            End If
                    End If

                Case .ColIndex("Stock")
                    .Texto(f, c) = a
                    If .Texto(f, c) < 0 Then
                        .ErrorEnTxt()
                    Else
                        If .Texto(f, .ColIndex("Ingrediente")) = "" Then
                            .Texto(f, c) = ""
                            .ActivarCelda(f, .ColIndex("Ingrediente"))
                        Else
                            If .Texto(f, .ColIndex("Precioxunidad")) < 0 Then
                                .Texto(f, c) = ""
                                .ActivarCelda(f, .ColIndex("Precioxunidad"))
                            Else
                                If .Texto(f, .ColIndex("CantidadxUnidad")) < 0 Then
                                    .Texto(f, c) = ""
                                    .ActivarCelda(f, .ColIndex("CantidadxUnidad"))
                                Else
                                    clStock.Editar(vId, vIngrediente, vPrecioxunidad, vCantidadxUnidad, a, vLugardeCompra)
                                    .ActivarCelda(f, .ColIndex("LugardeCompra"))
                                End If
                            End If
                        End If
                    End If
                Case .ColIndex("LugardeCompra")
                    .Texto(f, c) = a
                    If .Texto(f, c) = "" Then
                        .ErrorEnTxt()
                    Else
                        If .Texto(f, .ColIndex("Ingrediente")) = "" Then
                            .Texto(f, c) = ""
                            .ActivarCelda(f, .ColIndex("Ingrediente"))
                        Else
                            If .Texto(f, .ColIndex("Precioxunidad")) < 0 Then
                                .Texto(f, c) = ""
                                .ActivarCelda(f, .ColIndex("Precioxunidad"))
                            Else
                                If .Texto(f, .ColIndex("CantidadxUnidad")) < 0 Then
                                    .Texto(f, c) = ""
                                    .ActivarCelda(f, .ColIndex("CantidadxUnidad"))
                                Else
                                    clStock.Editar(vId, vIngrediente, vPrecioxunidad, vCantidadxUnidad, vStock, a)
                                    .ActivarCelda(f + 1, .ColIndex("Ingrediente"))
                                End If
                            End If
                        End If
                    End If

            End Select
        End With

    End Sub
    Private Sub grdStock_KeyUp(sender As Object, e As Short) Handles grdStock.KeyUp
        Select Case e
            Case 46
                'Tecla Borrar/Delete
                If grdStock.Texto(, 0) <> 0 Then
                    If MsgBox($"¿Esta seguro de borrar el Cliucto {grdStock.Texto(, 0)}. {grdStock.Texto(, 1)}?",
                          MsgBoxStyle.YesNoCancel + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "Borrar") = MsgBoxResult.Yes Then
                        'Borrar el registro
                        clStock.Borrar(grdStock.Texto(, 0))
                        grdStock.BorrarFila()
                    End If
                End If
            Case 32
                'Barra Espaciadora
        End Select
    End Sub

    Private Sub txtStock_TextChanged(sender As Object, e As EventArgs) Handles txtStock.TextChanged
        Cargar_LST()
    End Sub

    Private Sub btnCompra_Click(sender As Object, e As EventArgs) Handles btnCompra.Click
        frmLDC.Show()
    End Sub
End Class