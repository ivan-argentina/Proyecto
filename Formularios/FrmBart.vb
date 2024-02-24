Public Class FrmBart

    Private Sub TxtBarra_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtBarra.KeyDown
        If e.KeyCode = Keys.Return Then

            Dim Largo As Integer
            Dim Primero As Integer
            Dim BarId As Integer
            Dim Entero As Integer
            Dim Decim As Integer


            If IsNumeric(TxtBarra.Text) Then
                Barra = TxtBarra.Text
                TxtBarra.Text = Barra
                Largo = Len(Barra)
                Primero = Mid(Barra, 1, 1)
                If Largo = 13 And Primero = 2 Then
                    BarId = Mid(Barra, 3, 4)
                    Entero = Mid(Barra, 8, 3)
                    Decim = Mid(Barra, 11, 3)
                    Tot = FormatNumber(Entero + "." + Decim)
                Else
                    ' BarId = Barra
                End If
                Dim dsdataset As New DataSet
                dsdataset = MiClase.traedataset("select barra from articulos where barra=" & Barra & "")
                Dim totalregistros As Integer = dsdataset.Tables(0).Rows.Count
                If totalregistros = 0 Then
                    MsgBox("Este codigo de barra no existe, Debes agregarlo a la base de datos", MsgBoxStyle.Critical)

                Else
                    misdatos = MiClase.traedataset("select barra,articulo,pfinal,idpr,idfm,idmr,idact,alic,idiv,abu from articulos where barra=" & Barra & "")
                    LbArticulo.Text = Trim(misdatos.Tables(0).Rows(0).Item(1))
                    LbPrecio.Text = FormatNumber(misdatos.Tables(0).Rows(0).Item(2))
                End If
            End If
        End If

    End Sub


    Private Sub TxtBarra_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBarra.TextChanged

    End Sub
End Class