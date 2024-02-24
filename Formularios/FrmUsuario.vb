Public Class FrmUsuario
    Private Sub Verif_Us()
        Usuario = Trim(CmbUsuario.Text)
        If Usuario = "" Then
            Mensaje = MsgBox("No Selecciono Ningun Cajero", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "No Selecciono Cajero!!!")
        Else
            Usuario = Trim(CmbUsuario.SelectedValue(0))
            IdUs = CmbUsuario.SelectedValue(1)
            Psw = Trim(TxtClave.Text)
        End If
        misdatos = MiClase.traedataset("select id,cajero,psw,idpr from cajeros where id=" & IdUs & "")
        IdUs = FormatNumber(misdatos.Tables(0).Rows(0).Item(0))
        UsuCar = Trim(misdatos.Tables(0).Rows(0).Item(1))
        PswCar = Trim(misdatos.Tables(0).Rows(0).Item(2))
        Pr = misdatos.Tables(0).Rows(0).Item(3)
        If Usuario = UsuCar Then
        Else
            Mensaje = MsgBox("Este Usuario No Existe en la Base de Datos", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Usuario Inexistente!!!")
        End If
        If Psw = PswCar Then
            FrmInicio.Show()
        Else
            Mensaje = MsgBox("Esta Clave no esta Autorizada para este usuario", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Clave Inexistente!!!")
        End If
    End Sub
    Private Sub FrmUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MiClase.cargar_Combo(CmbUsuario, "select cajero,id,psw from cajeros")
    End Sub
    Private Sub TxtClave_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtClave.KeyDown
        If e.KeyCode = Keys.Return Then
            Verif_Us()
        End If
    End Sub

    Private Sub TxtClave_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtClave.TextChanged

    End Sub

    Private Sub CmbUsuario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbUsuario.KeyDown
        If e.KeyCode = Keys.Return Then
            TxtClave.Focus()
        End If
    End Sub

   

    Private Sub CmdEntrar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdEntrar.Click
        Verif_Us()
    End Sub
End Class