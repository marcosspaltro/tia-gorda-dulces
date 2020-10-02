Imports System.IO

Public Class frmProductos
    Private clProd As New clsProductos
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

    Private Sub grdProductos_Load(sender As Object, e As EventArgs) Handles grdProductos.Load

    End Sub
    ''q funcione edicion de stock
    ''frm stock y cls
    ''diseño opciones de busqueda,y como funcionaría
End Class