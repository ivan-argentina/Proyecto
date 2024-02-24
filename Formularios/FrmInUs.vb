Public Class FrmInUs
    Dim Prioridad As String
    Private Sub Blanquear()
        TxtUsuario.Text = ""
        TxtClave.Text = ""
        CmbPr.Text = ""
        CmdModificar.Enabled = False
        CmdEliminar.Enabled = False
        TxtUsuario.Focus()
    End Sub
    Private Sub TxtUsuario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtUsuario.KeyDown
        If e.KeyCode = Keys.Return Then
            TxtClave.Focus()
        End If
    End Sub


    Private Sub TxtUsuario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtUsuario.TextChanged

    End Sub

    Private Sub TxtClave_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtClave.KeyDown
        If e.KeyCode = Keys.Return Then
            CmbPr.Focus()
        End If
    End Sub

    Private Sub TxtClave_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtClave.TextChanged

    End Sub

    Private Sub CmbPr_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbPr.KeyDown
        If e.KeyCode = Keys.Return Then
            If CmdModificar.Enabled = True Then
                CmdModificar.Focus()
            Else
                If CmbPr.Text = "Maxima" Then
                    Pr = 0
                ElseIf CmbPr.Text = "Minima" Then
                    Pr = 1
                Else
                    Mensaje = MsgBox("Prioridad Inexistente ", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Prioridad Inexistente!!!")
                End If
                If TxtUsuario.Text = "" Then
                    Mensaje = MsgBox("Tiene que ingresar un Usuario ", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Usuario Inexistente!!!")
                End If
                If TxtClave.Text = "" Then
                    Mensaje = MsgBox("Tiene que ingresar Una Clave ", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Clave Inexistente!!!")
                End If
                If CmbPr.Text = "" Then
                    Mensaje = MsgBox("Tiene que elegir una prioridad ", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Prioridad Inexistente!!!")
                End If
                MiClase.eliminaactualizaregistra("insert into cajeros values('" & TxtUsuario.Text & "','" & TxtClave.Text & "'," & Pr & ",'" & CmbPr.Text & "')")
                Blanquear()
            End If
        End If
    End Sub

    Private Sub CmbPr_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbPr.Leave
        If CmbPr.Text = "" Then
            CmbPr.Text = "Maxima"
        End If
        Prioridad = Trim(CmbPr.Text)
    End Sub

    Private Sub CmbPr_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbPr.SelectedIndexChanged


    End Sub

    Private Sub CmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdModificar.Click
        If Prioridad = "Maxima" Then
            Pr = 0
        ElseIf Prioridad = "Minima" Then
            Pr = 1
        Else
            Mensaje = MsgBox("Prioridad Inexistente ", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Prioridad Inexistente!!!")
        End If
        If TxtUsuario.Text = "" Then
            Mensaje = MsgBox("Tiene que ingresar un Usuario ", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Usuario Inexistente!!!")
        End If
        If TxtClave.Text = "" Then
            Mensaje = MsgBox("Tiene que ingresar Una Clave ", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Clave Inexistente!!!")
        End If
        If CmbPr.Text = "" Then
            Mensaje = MsgBox("Tiene que elegir una prioridad ", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Prioridad Inexistente!!!")
        End If
        MiClase.eliminaactualizaregistra("update cajeros set cajero='" & TxtUsuario.Text & "',psw='" & TxtClave.Text & "', " & _
                                        "idpr=" & IdPr & ",prioridad='" & CmbPr.Text & "'where id=" & IdUs & "")
        Blanquear()
    End Sub

    Private Sub CmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdEliminar.Click
        Mensaje = MsgBox("Desea Eliminar Este Usuario: ", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "Eliminar Usuario!!!")
        If Mensaje = MsgBoxResult.Yes Then
            MiClase.eliminaactualizaregistra("delete from cajeros where id=" & IdUs & "")
        End If
        Blanquear()
    End Sub

    Private Sub CmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdBuscar.Click
        FrmBus.Show()
    End Sub
End Class