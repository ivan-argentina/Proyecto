Public Class FrmDetPag
    Private Sub Car_Pago()
        Dim ImpTot As Decimal
        If LCom = 0 Then
            LCom = 1
        End If
        If TxtNum.Text = "" Then
            TxtNum.Text = "0"
        End If
        If TxtComp.Text = "" Then
            TxtComp.Text = "Efectivo"
            TxtNum.Text = "0"
            IdCom = 1
            'ImpTot = MskEnt.Text
        End If
        ' ImpTot = Str(MskImp.Text)
        ImpTot = Decimal.Parse(MskEnt.Text, System.Globalization.CultureInfo.GetCultureInfo("es-es"))
        MiClase.eliminaactualizaregistra("insert into tpago  values(" & LCom & "," & Pc & "," & IdCom & ",'" & TxtComp.Text & " ', " & _
                 "" & TxtNum.Text & "," & Str(ImpTot) & ",'" & Date.Today & "')")
        LCom = LCom + 1
        MiClase.cargardatagriview(DtgPag, "select comprobante,numero,importe,linea,idcom,vencimiento from tpago where pc=" & Pc & " ")
        DtgPag.Font = New Font("Arial ", 12, FontStyle.Regular)
        DtgPag.ColumnHeadersVisible = False
        DtgPag.AllowUserToAddRows = False
        DtgPag.Columns(2).DefaultCellStyle.Format = "##,##0.00"
        DtgPag.Columns(3).Visible = False
        DtgPag.Columns(4).Visible = False
        DtgPag.Columns(5).Visible = False
        TxtComp.Clear()
        TxtNum.Clear()
        misdatos = MiClase.traedataset("select sum(importe) from tpago where pc=" & Pc & "")
        TotPago = misdatos.Tables(0).Rows(0).Item(0)
        'MskImp.Text = "0"
        '  MskEnt.Text = FormatNumber(txtTotal.Text - TotPago, 2)
        'MskImp.Focus()
        IdCom = 1
        TxtNum.Visible = True
        TxtComp.Enabled = False
        TxtNum.Enabled = False
        TxtNum.Text = ""
        MskEnt.Enabled = True
        TxtNum.Visible = False
        EsVenta = 0
        Cventa = "Contado"
        'Lb.Text = "Pago Efectivo"
        'DtcVenc.Value = Date.Today
        'DtcVenc.Enabled = False
        MskEnt.Focus()
        'CmdFactura.Enabled = True
        'CmdFactura.Focus()
    End Sub

    Private Sub CmdEfec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdEfec.Click
        
    End Sub

    Private Sub CmdCh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCh.Click
        
    End Sub

    Private Sub TxtNum_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtNum.KeyDown
        If e.KeyCode = Keys.Return Then
            MskEnt.Enabled = True
            MskEnt.Focus()
        End If
    End Sub

    Private Sub TxtNum_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNum.KeyPress
        Dim sep As Char
        sep = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar.Equals(sep) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub TxtNum_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNum.TextChanged

    End Sub

    Private Sub MskEnt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MskEnt.KeyDown
        If e.KeyCode = Keys.Return Then
            Car_Pago()
        End If
    End Sub



    Private Sub MskEnt_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles MskEnt.MaskInputRejected

    End Sub
End Class