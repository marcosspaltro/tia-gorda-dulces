Imports System.IO
Public Class frmClientes
    Private clCli As New clsClientes
    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim vTeclas() As Integer = {46}

        grdClientes.TeclasManejadas = vTeclas
        Cargar_LST()
    End Sub

    Private Sub Cargar_LST()
        Dim fId As Integer = 0
        Dim fNombre As String = ""

        If txtClientes.Text.Length Then
            fNombre = txtClientes.Text
            If IsNumeric(txtClientes.Text) Then fId = CInt(txtClientes.Text)
        End If

        Dim dt As DataTable = clCli.Datos(fId, fNombre)

        With grdClientes
            .MostrarDatos(dt, True)
            .ColW(0) = 60
            .ColW(1) = 150
            .FixCols = 1
        End With
    End Sub

    Private Sub grdClientes_Editado(f As Short, c As Short, a As Object) Handles grdClientes.Editado
        With grdClientes
            Dim vId As Integer = grdClientes.Texto(f, grdClientes.ColIndex("Id"))
            Dim vNombre As String
            Dim vDirección As String
            Dim vCelular As String
            Dim vInstagram As String
            vNombre = .Texto(f, .ColIndex("Nombre"))
            vDirección = .Texto(f, .ColIndex("Dirección"))
            vCelular = .Texto(f, .ColIndex("Celular"))
            vInstagram = .Texto(f, .ColIndex("Instagram"))

            Select Case c

                Case .ColIndex("Nombre")
                    .Texto(f, c) = a
                    If .EsUltimaF Then
                        .ActivarCelda(f, .ColIndex("Dirección"))
                    Else
                        clCli.Editar(vId, a, vDirección, vCelular, vInstagram)
                        .ActivarCelda(f, .ColIndex("Dirección"))
                    End If

                Case .ColIndex("Dirección")
                    .Texto(f, c) = a
                    If .Texto(f, c) = "" Then
                        .ErrorEnTxt()
                    Else
                        If .Texto(f, .ColIndex("Nombre")) = "" Then
                            .Texto(f, c) = ""
                            .ActivarCelda(f, .ColIndex("Nombre"))
                        Else
                            If .EsUltimaF Then
                                clCli.Agregar(vNombre, a, vCelular, vInstagram)
                                grdClientes.Texto(f, grdClientes.ColIndex("Id")) = clCli.Max_Id
                                .AgregarFila()
                                .ActivarCelda(f, .ColIndex("Celular"))
                            Else
                                clCli.Editar(vId, vNombre, a, vCelular, vInstagram)
                                .ActivarCelda(f, .ColIndex("Celular"))
                            End If
                        End If

                    End If

                Case .ColIndex("Celular")
                    .Texto(f, c) = a
                    If .Texto(f, c) = "" Then
                        .ErrorEnTxt()
                    Else
                        If .Texto(f, .ColIndex("Nombre")) = "" Then
                            .Texto(f, c) = ""
                            .ActivarCelda(f, .ColIndex("Nombre"))
                        Else
                            If .Texto(f, .ColIndex("Dirección")) = "" Then
                                .Texto(f, c) = ""
                                .ActivarCelda(f, .ColIndex("Dirección"))
                            Else
                                clCli.Editar(vId, vNombre, vDirección, a, vInstagram)
                                .ActivarCelda(f, .ColIndex("Instagram"))
                            End If
                        End If

                    End If
                Case .ColIndex("Instagram")
                    .Texto(f, c) = a
                    If .Texto(f, c) = "" Then
                        .ErrorEnTxt()
                    Else
                        If .Texto(f, .ColIndex("Nombre")) = "" Then
                            .Texto(f, c) = ""
                            .ActivarCelda(f, .ColIndex("Nombre"))
                        Else
                            If .Texto(f, .ColIndex("Dirección")) = "" Then
                                .Texto(f, c) = ""
                                .ActivarCelda(f, .ColIndex("Dirección"))
                            Else
                                clCli.Editar(vId, vNombre, vDirección, vCelular, a)
                                .ActivarCelda(f + 1, .ColIndex("Nombre"))
                            End If
                        End If

                    End If
            End Select
        End With

    End Sub
    Private Sub grdClientes_KeyUp(sender As Object, e As Short) Handles grdClientes.KeyUp
        Select Case e
            Case 46
                'Tecla Borrar/Delete
                If grdClientes.Texto(, 0) <> 0 Then
                    If MsgBox($"¿Esta seguro de borrar el Cliucto {grdClientes.Texto(, 0)}. {grdClientes.Texto(, 1)}?",
                          MsgBoxStyle.YesNoCancel + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "Borrar") = MsgBoxResult.Yes Then
                        'Borrar el registro
                        clCli.Borrar(grdClientes.Texto(, 0))
                        grdClientes.BorrarFila()
                    End If
                End If
            Case 32
                'Barra Espaciadora
        End Select
    End Sub

    Private Sub txtClientes_TextChanged(sender As Object, e As EventArgs) Handles txtClientes.TextChanged
        Cargar_LST()
    End Sub

    Private Sub grdClientes_Load(sender As Object, e As EventArgs) Handles grdClientes.Load

    End Sub
End Class