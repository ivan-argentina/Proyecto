Public Class FrmInProv
    Dim MiClase As New Conexion
    Private Sub Habilitar()
        txtDir.Enabled = True
        TxtCciu.Enabled = True
        TxtCiu.Enabled = True
        TxtCiva.Enabled = True
        TxtIva.Enabled = True
        TxtEmail.Enabled = True
        TxtEmail.MaxLength = 50
        TxtTel.Enabled = True
        TxtCel.Enabled = True
        MskCuit.Enabled = True
    End Sub
    Private Sub Blanquear()
        TxtProv.Clear()
        TxtProv.Focus()
        txtDir.Clear()
        txtDir.Enabled = False
        TxtCciu.Clear()
        TxtCciu.Enabled = False
        TxtCiu.Clear()
        TxtCiu.Enabled = False
        MskCuit.Clear()
        MskCuit.Enabled = False
        TxtCiva.Clear()
        TxtCiva.Enabled = False
        TxtIva.Clear()
        TxtIva.Enabled = False
        TxtEmail.Clear()
        TxtEmail.Enabled = False
        TxtTel.Clear()
        TxtTel.Enabled = False
        TxtCel.Clear()
        TxtCel.Enabled = False
        CmdBuscar.Enabled = True
        CmdModificar.Enabled = False
        CmdEliminar.Enabled = False
    End Sub

    Private Sub TxtProv_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtProv.Click
        Blanquear()
    End Sub

    Private Sub TxtProv_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtProv.GotFocus
        Habilitar()
    End Sub
    Private Sub TxtProv_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtProv.KeyDown
        If e.KeyCode = Keys.Return Then
            Habilitar()
            txtDir.Focus()
        End If
    End Sub
    Private Sub txtDir_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDir.KeyDown
        If e.KeyCode = Keys.Return Then
            FrmBciva.Show()
        End If
    End Sub
    Private Sub TxtCiu_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCiu.KeyDown
        If e.KeyCode = Keys.Return Then
            MskCuit.Focus()
        End If
    End Sub
    Private Sub TxtCciu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCciu.Click
        FrmbCiu.Show()
    End Sub

    Private Sub MskCuit_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MskCuit.GotFocus
        If TxtCiva.Text = 5 Then
            MskCuit.Mask = "##.###.###"
        Else
            MskCuit.Mask = "##-########-#"
        End If
    End Sub

    Private Sub MskCuit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MskCuit.KeyDown
        If e.KeyCode = Keys.Return Then
            Dim LCuit As Integer
            LCuit = Len(MskCuit.Text)
            If LCuit = 10 And TxtCiva.Text = 5 Then
                FrmbCiu.Show()
            ElseIf LCuit = 13 Then
                FrmbCiu.Show()
            Else
                Mensaje = MsgBox("El Numero No tiene la cantidad de Caracteres correcta", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Faltan Numeros!!!")
                If Mensaje = vbOK Then
                    MskCuit.Focus()
                End If

            End If
        End If
    End Sub

    Private Sub TxtEmail_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtEmail.KeyDown
        If e.KeyCode = Keys.Return Then
            TxtTel.Focus()
        End If
    End Sub


    Private Sub TxtEmail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtEmail.TextChanged

    End Sub

    Private Sub TxtTel_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtTel.KeyDown
        If e.KeyCode = Keys.Return Then
            TxtCel.Focus()
        End If
    End Sub

    Private Sub TxtCiva_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCiva.Click
        FrmBciva.Show()
    End Sub
    Private Sub TxtCel_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCel.KeyDown
        If e.KeyCode = Keys.Return Then
            If CmdModificar.Enabled = True Then
                CmdModificar.Focus()
            Else
                If TxtCiva.Text = "" Or TxtCciu.Text = "" Then
                    Mensaje = MsgBox("faltan Datos de Ingresar", MsgBoxStyle.OkOnly, "Verifique Datos!!!")
                    If Mensaje = vbOK Then
                        TxtCciu.Focus()
                    End If

                Else
                    'If EsPr = "1" Then
                    Sal = 0
                    If TxtTel.Text = "" Then
                        TxtTel.Text = 0
                    End If
                    If TxtEmail.Text = "" Then
                        TxtEmail.Text = 0
                    End If
                    If TxtCel.Text = "" Then
                        TxtCel.Text = 0
                    End If
                    MiClase.eliminaactualizaregistra("insert into proveedor values('" & TxtProv.Text & "','" & txtDir.Text & " ', " & _
                     "" & TxtCciu.Text & "," & TxtCiva.Text & ",'" & MskCuit.Text & "','" & TxtEmail.Text & "','" & TxtTel.Text & "','" & TxtCel.Text & "'," & Sal & ")")
                    Blanquear()
                End If
            End If
        End If
    End Sub

    Private Sub TxtCel_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCel.TextChanged

    End Sub


    Private Sub FrmInProv_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EsPr = "1"
        EsCv = 0
        EsCiu = 0
    End Sub

    Private Sub CmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdBuscar.Click
        FrmBpr.Show()
    End Sub

    Private Sub TxtProv_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtProv.TextChanged

    End Sub

    Private Sub CmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdModificar.Click
        MiClase.eliminaactualizaregistra("update proveedor set proveedor='" & TxtProv.Text & "',direccion='" & txtDir.Text & "', " & _
        "idciu=" & TxtCciu.Text & ",idciva=" & TxtCiva.Text & ",cuit='" & MskCuit.Text & "',email='" & TxtEmail.Text & "', " & _
        "telefono='" & TxtTel.Text & "',cel='" & TxtCel.Text & "' where id=" & Id & "")
        Blanquear()
    End Sub

    Private Sub CmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdEliminar.Click
        Mensaje = MsgBox("Desea Eliminar el Cliente: " & TxtProv.Text & "", MsgBoxStyle.YesNo, "Eliminar Cliente!!!")
        If Mensaje = MsgBoxResult.Yes Then
            MiClase.eliminaactualizaregistra("delete from proveedor where id=" & Id & "")
        End If
        Blanquear()
    End Sub

    Private Sub MskCuit_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles MskCuit.MaskInputRejected

    End Sub

    Private Sub TxtCiva_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCiva.KeyDown

    End Sub

    Private Sub TxtCiva_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCiva.TextChanged

    End Sub

    Private Sub txtDir_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDir.TextChanged

    End Sub

    Private Sub TxtCciu_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCciu.TextChanged

    End Sub
End Class