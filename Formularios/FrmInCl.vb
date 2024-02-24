Public Class FrmInCl
    Private Sub Habilitar()
        TxtDireccion.Enabled = True
        TxtCciu.Enabled = True
        TxtCiudad.Enabled = True
        TxtCiva.Enabled = True
        TxtIva.Enabled = True
        TxtEmail.Enabled = True
        TxtEmail.MaxLength = 50
        TxtTelefono.Enabled = True
        TxtCpostal.Enabled = True
        TxtProv.Enabled = True
        txtCel.Enabled = True
        MskCuit.Enabled = True
        DtcNc.Enabled = True
        MskSaldo.Enabled = True
    End Sub
    Private Sub Verif_Cuit()
        'Verifica si el tamaño es el correcto.
        Cuit = MskCuit.Text
        If Len(Cuit) = 13 Then
            Dim XA, XB, XC, XD, XE, XF, XG, XH, XI, XJ, X, Control As Integer

            'Individualiza y multiplica los dígitos.
            XA = Val(Mid$(Cuit, 1, 1)) * 5
            XB = Val(Mid$(Cuit, 2, 1)) * 4
            XC = Val(Mid$(Cuit, 4, 1)) * 3
            XD = Val(Mid$(Cuit, 5, 1)) * 2
            XE = Val(Mid$(Cuit, 6, 1)) * 7
            XF = Val(Mid$(Cuit, 7, 1)) * 6
            XG = Val(Mid$(Cuit, 8, 1)) * 5
            XH = Val(Mid$(Cuit, 9, 1)) * 4
            XI = Val(Mid$(Cuit, 10, 1)) * 3
            XJ = Val(Mid$(Cuit, 11, 1)) * 2

            'Suma los resultantes.
            x = XA + XB + XC + XD + XE + XF + XG + XH + XI + XJ

            'Calcula el dígito de control.
            Control = (11 - (x Mod 11)) Mod 11
            'If esmod = "0" Then
            'MskNciu.SetFocus()
            'ElseIf esmod = "1" Then
            '   TxtCiudad.SetFocus()
            'End If
            'Verifica si el dígito de control ingresado difiere con el calculado.
            If Control <> Val(Mid$(Cuit, 13, 1)) Then

                'Presenta la ventana de aviso.
                'Mensaje = MsgBox("El CUIT ingresado es incorrecto. Verifíquelo e intente nuevamente." + Chr$(13) + Chr$(13) + "CUIT Ingresado: " + Cuit + Chr$(13) + "CUIT Estimativo: " + Left(Cuit, 12) + Trim$(Str$(Control)), vbOKOnly + vbCritical, "CUIT ERRONEO")
                Mensaje = MsgBox("El Cuit Ingresado es Incorrecto", MsgBoxStyle.Critical, "Cuit Incorrecto!!!")
                If Mensaje = MsgBoxResult.Ok Then
                    MskCuit.Focus()
                End If
            Else
                DtcNc.Focus()
            End If

        End If
    End Sub
    Private Sub Blanquear()
        TxtNombre.Clear()
        TxtNombre.Focus()
        TxtDireccion.Clear()
        TxtDireccion.Enabled = False
        TxtCCiu.Clear()
        TxtCCiu.Enabled = False
        TxtCiudad.Clear()
        TxtCiudad.Enabled = False
        MskCuit.Clear()
        MskCuit.Enabled = False
        txtCiva.Clear()
        txtCiva.Enabled = False
        TxtIva.Clear()
        TxtIva.Enabled = False
        TxtEmail.Clear()
        TxtEmail.Enabled = False
        TxtTelefono.Clear()
        TxtTelefono.Enabled = False
        txtCel.Clear()
        txtCel.Enabled = False
        TxtCpostal.Clear()
        TxtCpostal.Enabled = False
        TxtProv.Clear()
        TxtProv.Enabled = False
        IdPrv = 0
        DtcNc.Value = Date.Today
        DtcNc.Enabled = False
        MskSaldo.Clear()
        MskSaldo.Enabled = False
        CmdBuscar.Enabled = True
        CmdModificar.Enabled = False
        CmdEliminar.Enabled = False
    End Sub
    Private Sub TxtNombre_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtNombre.Click
        Blanquear()
    End Sub

    Private Sub TxtNombre_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtNombre.GotFocus
        
    End Sub

    Private Sub TxtNombre_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtNombre.KeyDown
        If e.KeyCode = Keys.Return Then
            Habilitar()
            TxtDireccion.Focus()
        End If
    End Sub

    Private Sub TxtDireccion_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtDireccion.GotFocus
        Habilitar()
    End Sub

    Private Sub TxtDireccion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDireccion.KeyDown
        If e.KeyCode = Keys.Return Then
            FrmBciva.Show()
        End If
    End Sub

    Private Sub TxtDireccion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDireccion.TextChanged

    End Sub

    Private Sub FrmInCl_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        EsCl = 2
        'EsPr = 2
        EsCv = 2
        EsCiu = 2
        EsPrv = 0
    End Sub

    Private Sub MskCuit_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MskCuit.GotFocus
        If txtCiva.Text = 5 Then
            LbCuit.Text = "D.N.I."
            MskCuit.Mask = "##.###.###"
        Else
            LbCuit.Text = "Cuit"
            MskCuit.Mask = "##-########-#"
        End If
    End Sub

    Private Sub MskCuit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MskCuit.KeyDown
        If e.KeyCode = Keys.Return Then

            Dim LCuit As Integer
            LCuit = Len(MskCuit.Text)
            If LCuit = 10 And txtCiva.Text = 5 Then
                DtcNc.Focus()
            ElseIf LCuit = 13 Then
                Verif_Cuit()
                'DtcNc.Focus()
            Else
                'Mensaje = MsgBox("El Numero No tiene la cantidad de Caracteres correcta", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Faltan Numeros!!!")
                'If Mensaje = vbOK Then
                'MskCuit.Focus()
                'End If

            End If
        End If
    End Sub

   

    Private Sub txtCiva_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCiva.Click
        FrmBciva.Show()
    End Sub

    Private Sub txtCiva_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCiva.TextChanged

    End Sub

    Private Sub TxtTelefono_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtTelefono.KeyDown
        If e.KeyCode = Keys.Return Then
            txtCel.Focus()
        End If
    End Sub


    Private Sub TxtEmail_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtEmail.KeyDown
        If e.KeyCode = Keys.Return Then
            TxtTelefono.Focus()
        End If
    End Sub

    Private Sub TxtEmail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtEmail.TextChanged

    End Sub

    Private Sub CmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdBuscar.Click
        BCli = TxtNombre.Text
        FrmBcl.Show()
    End Sub

    Private Sub CmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdModificar.Click
        If MskSaldo.Text = "" Then
            MskSaldo.Text = 0
        End If
        MiClase.eliminaactualizaregistra("update clientes set cliente ='" & TxtNombre.Text & "',direccion='" & TxtDireccion.Text & "', " & _
        "idciu=" & TxtCCiu.Text & ",idciva=" & txtCiva.Text & ",cuit='" & MskCuit.Text & "',email='" & TxtEmail.Text & "', " & _
        "telefono='" & TxtTelefono.Text & "',cel='" & txtCel.Text & "',cpostal='" & TxtCpostal.Text & "',idpr=" & IdPrv & ", " & _
        "fec_nac='" & DtcNc.Text & "',saldo=" & MskSaldo.Text & " where id=" & Id & "")
        Blanquear()
    End Sub

    Private Sub CmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdEliminar.Click
        Mensaje = MsgBox("Desea Eliminar el Cliente: " & TxtNombre.Text & "", MsgBoxStyle.YesNo, "Eliminar Cliente!!!")
        If Mensaje = MsgBoxResult.Yes Then
            MiClase.eliminaactualizaregistra("delete from clientes where id=" & Id & "")
        End If
        Blanquear()
    End Sub


    Private Sub TxtCCiu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCCiu.Click
        FrmbCiu.Show()
    End Sub

    Private Sub TxtCpostal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCpostal.KeyDown
        If e.KeyCode = Keys.Return Then
            FrmBprov.Show()
        End If
    End Sub

    Private Sub TxtProv_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtProv.Click
        FrmBprov.Show()
    End Sub


    Private Sub DtcNac_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Return Then
            FrmbCiu.Show()
        End If
    End Sub

    Private Sub DtcNc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DtcNc.KeyDown
        If e.KeyCode = Keys.Return Then
            FrmbCiu.Show()
        End If
    End Sub


    Private Sub DtcNc_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DtcNc.ValueChanged

    End Sub

    Private Sub MskCuit_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles MskCuit.MaskInputRejected

    End Sub

    Private Sub TxtIva_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtIva.TextChanged

    End Sub

    Private Sub TxtNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNombre.TextChanged

    End Sub

    Private Sub MskSaldo_CausesValidationChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MskSaldo.CausesValidationChanged

    End Sub

    Private Sub MskSaldo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MskSaldo.KeyDown
        If e.KeyCode = Keys.Return Then
            If CmdModificar.Enabled = True Then
                CmdModificar.Focus()
            Else
                If txtCiva.Text = "" Or TxtCCiu.Text = "" Then
                    Mensaje = MsgBox("faltan Datos de Ingresar", MsgBoxStyle.OkOnly, "Verifique Datos!!!")
                    If Mensaje = vbOK Then
                        TxtCCiu.Focus()
                    End If

                Else
                    If TxtCpostal.Text = "" Then
                        TxtCpostal.Text = "0"
                    End If
                    If MskSaldo.Text = "" Then
                        MskSaldo.Text = 0
                    End If
                    MiClase.eliminaactualizaregistra("insert into clientes  values('" & TxtNombre.Text & "','" & TxtDireccion.Text & " ', " & _
                     "" & TxtCCiu.Text & "," & txtCiva.Text & ",'" & MskCuit.Text & "','" & TxtEmail.Text & "','" & TxtTelefono.Text & "', " & _
                     "'" & txtCel.Text & "'," & 0 & ",'" & TxtCpostal.Text & "'," & IdPrv & ",'" & DtcNc.Text & "'," & MskSaldo.Text & ")")
                    Blanquear()
                End If
            End If
        End If
    End Sub


    Private Sub MskSaldo_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles MskSaldo.MaskInputRejected

    End Sub

    Private Sub txtCel_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCel.KeyDown
        If e.KeyCode = Keys.Return Then
            MskSaldo.Focus()
        End If
    End Sub

    Private Sub txtCel_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCel.TextChanged

    End Sub
End Class