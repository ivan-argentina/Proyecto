Public Class FrmBCh
    Dim Chk As DataGridViewCheckBoxColumn = New DataGridViewCheckBoxColumn(False)
    Dim Lcoun As Integer

    Private Sub Refrescar()
        MiClase.cargardatagriview(DtgCheque, "select banco,numero,venc,importe,estado,id,idcl,cliente from tcheqcartera where estado=" & 0 & " order by venc")
        DtgCheque.Font = New Font("Arial ", 12, FontStyle.Regular)
        DtgCheque.Columns(0).Width = 180
        DtgCheque.Columns(2).DefaultCellStyle.Format = "dd/MM/yy"
        DtgCheque.Columns(2).HeaderText = "Vencim."
        DtgCheque.Columns(2).Width = 80
        DtgCheque.Columns(3).DefaultCellStyle.Format = "##,##0.00"
        DtgCheque.AllowUserToAddRows = False
        DtgCheque.Columns(4).Visible = False
        DtgCheque.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        DtgCheque.Columns.Add(Chk)
        Chk.HeaderText = "Est."
        Chk.Width = 50
        DtgCheque.Columns(4).Visible = False
        DtgCheque.Columns(5).Visible = False
        DtgCheque.Columns(6).Visible = False
        DtgCheque.Columns(7).Visible = False
    End Sub
    Private Sub FrmBCh_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            misdatos = MiClase.traedataset("select isnull(count(id),0) from tcheqcartera")
            Lcoun = misdatos.Tables(0).Rows(0).Item(0)
            If Lcoun = 0 Then
                MiClase.cargardatagriview(DtgCheque, "select id,idcl,cliente,banco,numero,venc,importe,estado from che_cartera where estado =" & 0 & "")
                DtgCheque.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
                DtgCheque.AllowUserToAddRows = False
                Dim filas As Integer = DtgCheque.Rows.Count
                For i As Integer = 0 To filas - 1
                    If IsDBNull(Convert.ToDouble(DtgCheque(0, i).Value)) Then
                    Else
                        IdCh = Convert.ToDouble(DtgCheque(0, i).Value)
                    End If
                    If IsDBNull(Convert.ToDouble(DtgCheque(1, i).Value)) Then
                    Else
                        Idcl = Convert.ToDouble(DtgCheque(1, i).Value)
                    End If
                    If IsDBNull(Convert.ToString(DtgCheque(2, i).Value)) Then
                    Else
                        PCli = Trim(Convert.ToString(DtgCheque(2, i).Value))
                    End If
                    If IsDBNull(Convert.ToString(DtgCheque(3, i).Value)) Then
                    Else
                        Pban = Trim(Convert.ToString(DtgCheque(3, i).Value))
                    End If
                    If IsDBNull(Convert.ToDouble(DtgCheque(4, i).Value)) Then
                    Else
                        Num = Trim(Convert.ToDouble(DtgCheque(4, i).Value))
                    End If
                    If IsDBNull(Convert.ToDateTime(DtgCheque(5, i).Value)) Then
                    Else
                        VenCuo = Convert.ToDateTime(DtgCheque(5, i).Value)
                    End If
                    If IsDBNull(Convert.ToDecimal(DtgCheque(6, i).Value)) Then
                    Else
                        Importe = Trim(Convert.ToDecimal(DtgCheque(6, i).Value))
                    End If
                    If IsDBNull(Convert.ToDouble(DtgCheque(7, i).Value)) Then
                    Else
                        EsAr = Trim(Convert.ToDouble(DtgCheque(7, i).Value))
                    End If
                    Fc = VenCuo
                    Fc = Format(VenCuo, "dd/MM/yy")
                    MiClase.eliminaactualizaregistra("insert into tcheqcartera values('" & IdCh & "'," & Idcl & "," & _
                      "'" & PCli & "','" & Pban & "'," & Num & ",'" & Fc & "'," & Str(Importe) & "," & EsAr & "," & Pc & ")")

                Next
                Refrescar()
            Else
                Refrescar()
            End If
        Catch ex As Exception

        End Try
    End Sub

   

    Private Sub TxtComp_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtComp.KeyDown
        If e.KeyCode = Keys.Return Then
            EsPago = 7
            FrmBpag.Show()
        End If
    End Sub

    Private Sub TxtComp_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtComp.LostFocus
      
    End Sub

    Private Sub TxtComp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtComp.TextChanged

    End Sub

    Private Sub DtgCheque_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DtgCheque.CellContentClick

    End Sub

    Private Sub TxtNum_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtNum.KeyDown
        If e.KeyCode = Keys.Return Then
            DtcFecha.Enabled = True
            DtcFecha.Focus()
        End If
    End Sub

    Private Sub TxtNum_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNum.TextChanged

    End Sub

    Private Sub DtcFecha_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DtcFecha.KeyDown
        If e.KeyCode = Keys.Return Then
            MskEnt.Enabled = True
            MskEnt.Focus()
        End If
    End Sub

    Private Sub DtcFecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DtcFecha.ValueChanged

    End Sub

    Private Sub MskEnt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MskEnt.KeyDown
        If e.KeyCode = Keys.Return Then
            Try
                Dim Cli As String
                Cli = "0"
                Comprobante = TxtComp.Text
                NumPag = TxtNum.Text
                FechCh = DtcFecha.Text
                ImPag = MskEnt.Text
                Idcl = 0

                MiClase.eliminaactualizaregistra("insert into che_cartera values(" & Idcl & ",'" & Cli & "', " & _
                  "'" & Comprobante & "'," & NumPag & ",'" & FechCh & "'," & Str(ImPag) & "," & 0 & "," & IdUs & ")")
                misdatos = MiClase.traedataset("select isnull(max(id),0) from tcheqcartera where idpc=" & Pc & "")
                IdCh3 = FormatNumber(misdatos.Tables(0).Rows(0).Item(0) + 1)

                MiClase.eliminaactualizaregistra("insert into tcheqcartera values(" & IdCh3 & "," & Idcl & "," & _
                          "'" & Cli & "','" & Comprobante & "'," & NumPag & ",'" & FechCh & "'," & Str(ImPag) & "," & EsAr & "," & Pc & ")")
                DtgCheque.Columns.Remove(Chk)
                Refrescar()
                IdCh3 = 0
                TxtComp.Clear()
                Comprobante = ""
                MskEnt.Text = 0
                ImPag = 0
                DtcFecha.Value = Date.Today
                TxtNum.Clear()
                TxtNum.Enabled = False
                DtcFecha.Enabled = False
                MskEnt.Enabled = False
            Catch ex As Exception
                If TxtComp.Text = "" Then
                    Mensaje = MsgBox("Tiene que elegir un banco", MsgBoxStyle.OkOnly, "Eliga Banco!!!")
                End If
                If TxtNum.Text = "" Then
                    TxtNum.Text = 0
                End If
                If MskEnt.Text = "" Then
                    Mensaje = MsgBox("Tiene que Ingresar el Importe del Cheque", MsgBoxStyle.OkOnly, "Ingresar Importe!!!")
                End If
            End Try
        End If
    End Sub

    Private Sub MskEnt_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles MskEnt.MaskInputRejected

    End Sub
End Class