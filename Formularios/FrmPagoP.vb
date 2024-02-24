Imports System.Drawing.Printing
Imports System.Drawing

Public Class FrmPagoP
    Dim Fila1 As DtcRecibo.ComprobanteRow
    Dim FechIm As String



    Private Sub print_PrintPage(ByVal sender As Object, _
                     ByVal e As PrintPageEventArgs)
        Dim x As Single = 0.0F
        Dim y As Single = 50.0F
        'Dim width As Int32 = 198
        Dim width As Int32 = 280
        Dim height As Int32 = 50
        Dim Width1 As Int32 = 280
        Dim drawRect As New RectangleF(x, y, width, height)
        Dim xPos As Single = e.MarginBounds.Right
        Dim prFont As New Font("Arial", 8, FontStyle.Regular)
        Dim prFontT As New Font("Arial", 10, FontStyle.Bold)
        Dim prFontE As New Font("Arial", 12, FontStyle.Bold)
        Dim yPos As Single = prFont.GetHeight(e.Graphics)
        'Traigo los datos del encabezado
        misdatos = MiClase.traedataset("select linea1,linea2,linea3,linea4 from encabezado")
        Linea1 = misdatos.Tables(0).Rows(0).Item(0)
        Linea2 = misdatos.Tables(0).Rows(0).Item(1)
        Linea3 = misdatos.Tables(0).Rows(0).Item(2)
        Linea4 = misdatos.Tables(0).Rows(0).Item(3)

        e.Graphics.DrawString(Linea1, prFontE, Brushes.Black, New Rectangle(60, y + 15, width, 15))
        e.Graphics.DrawString(Linea2, prFont, Brushes.Black, New Rectangle(0, y + 35, width, 15))
        e.Graphics.DrawString(Linea3, prFont, Brushes.Black, New Rectangle(0, y + 50, width, 15))
        e.Graphics.DrawString(Linea4, prFont, Brushes.Black, New Rectangle(0, y + 65, width, 15))
        FechIm = "Fecha : " + Date.Today
        e.Graphics.DrawString(FechIm, prFont, Brushes.Black, New Rectangle(xPos, y + 80, width, 15))
        e.Graphics.DrawString(Clave, prFont, Brushes.Black, New Rectangle(xPos, y + 95, width, 15))

        Dim OurPen As Pen
        OurPen = New Pen(Color.Black, 1)
        e.Graphics.DrawLine(OurPen, 0, 160, width, 160)

        'Imprimo los datos del cliente
        y = 170
        e.Graphics.DrawString(TxtPro.Text, prFont, Brushes.Black, New Rectangle(0, y, width, 15))
        y = y + 15
        e.Graphics.DrawString(txtDirec.Text, prFont, Brushes.Black, New Rectangle(0, y, width, 15))
        y = y + 15
        e.Graphics.DrawString(TxtCiu.Text, prFont, Brushes.Black, New Rectangle(0, y, width, 15))
        y = y + 15
        e.Graphics.DrawString(TxtCuit.Text, prFont, Brushes.Black, New Rectangle(0, y, width, 15))
        e.Graphics.DrawLine(OurPen, 0, 230, width, 230)
        y = 240
        Dim PtoIm As String
        'imprimo  los Items
        Dim filas As Integer = DtgPag.Rows.Count
        Dim contador As Integer = 0
        For i As Integer = 0 To filas - 1
            
            Comprobante = Mid(Convert.ToString(DtgPag(0, i).Value), 1, 30)


            
            NumCom = Mid(Convert.ToString(DtgPag(1, i).Value), 1, 5)
            'Punit1 = Mid(Convert.ToString(Dtgart(2, i).Value), 1, 5)
            'End If
            
            'CanIm = Convert.ToString(Dtgart(1, i).Value)
            PtoIm = Mid(Convert.ToString(DtgPag(4, i).Value), 1, 7)
            'Ptotal = FormatNumber(Convert.ToDecimal(Dtgart(4, i).Value), 2)


            'DetCant = CanIm + " / " + PunIm
            e.Graphics.DrawString(Comprobante, prFont, Brushes.Black, New Rectangle(0, y, width, 15))
            y = y + 12
            e.Graphics.DrawString(NumCom, prFont, Brushes.Black, New Rectangle(xPos, y, Width1, 15))
            y = y + 15
            e.Graphics.DrawString(PtoIm, prFont, Brushes.Black, New Rectangle(0, y, width, 15))
            y = y + 18

        Next
        DetCant = ""
        Ptotal = "0"
        Articulo = ""
        e.Graphics.DrawString("TOTAL: " + Txttotal.Text, prFontT, Brushes.Black, New Rectangle(xPos, y, Width1, 15))
        y = y + 15
        'e.Graphics.DrawString("Cond.de Venta :" + Cventa, prFont, Brushes.Black, New Rectangle(0, y + 20, width, 15))
        'e.Graphics.DrawString("* GRACIAS POR SU COMPRA *", prFontT, Brushes.Black, New Rectangle(30, y + 40, width, 15))
        'y = y + 35
        e.Graphics.DrawString("-", prFontT, Brushes.Black, New Rectangle(0, y + 20, width, 15))

        e.HasMorePages = False

    End Sub

    Private Sub Blanquear()
        TxtPro.Text = ""
        txtDirec.Text = ""
        TxtCiu.Text = ""
        TxtCuit.Text = ""
        Txttotal.Text = ""
        'MskFecha.Text = ""
        MskFecha.Enabled = False
        CmdPagar.Enabled = False
        MskEnt.Enabled = False
        '     MiClase.cargardatagriview(DtgFac, "select ctactep.numero,tipo,fecha,importe,entrega,saldo from ctactep inner join tip_fac on ctactep.idtp=tip_fac.id where ctactep.idpr=" & 0 & "and blng=" & 2 & "")
        MiClase.eliminaactualizaregistra("delete from tpagop where pc=" & Pc & "")
        MiClase.eliminaactualizaregistra("delete from TCtaCteP where idpc=" & Pc & "")
        MiClase.eliminaactualizaregistra("delete from TCompr where idpc=" & Pc & "")
        MiClase.cargardatagriview(DtgPag, "select * from tpagop where pc=" & Pc & "")
        MiClase.eliminaactualizaregistra("delete from tcompr where idpc=" & Pc & "")
        'MiClase.cargardatagriview(DtgCom, "select * from tcompr where idpc=" & Pc & "")
        MiClase.cargardatagriview(DtgRec, "select * from  faccompras  where numero=" & 0 & " and idtp=" & 1000 & "")
    End Sub
    Private Sub Imprimir()
        'Cargo la datagridvies para el reporte
        'NumFac = 23
        IdTp = 11
        ' NumFac = 4
        MiClase.cargardatagriview(DtgRec, "select faccompras.idtp,fecha,esventa,total,blng,tipo,fnum,entrega,numero from faccompras inner join tip_fac on faccompras.idtp=tip_fac.id where faccompras.numero=" & NumFac & " and idtp=" & IdTp & "")
        Dim Mn As New DtcRecibo
        Dim fila As DtcRecibo.EncabezadoRow
        fila = Mn.Encabezado.NewEncabezadoRow
        'traigo los datos del encabezado
        misdatos = MiClase.traedataset("select linea1,linea2,linea3 from encabezado")
        Linea1 = misdatos.Tables(0).Rows(0).Item(0)
        Linea2 = misdatos.Tables(0).Rows(0).Item(1)
        Linea3 = misdatos.Tables(0).Rows(0).Item(2)
        DtgRec.AllowUserToAddRows = False
        For i As Integer = 0 To DtgRec.RowCount - 1
            '  If IsDBNull(Convert.ToString(DtgFac(1, i).Value)) Then
            ' Else
            ' fila.Fecha = Convert.ToString(DtgRec(1, i).Value)
            ' End If
            If IsDBNull(Convert.ToString(DtgRec(6, i).Value)) Then
            Else
                fila.Fnum = Convert.ToString(DtgRec(6, i).Value)
            End If
            fila.Linea1 = Linea1
            fila.Linea2 = Linea2
            fila.Linea3 = Linea3
            fila.Cliente = TxtPro.Text
            fila.Direccion = txtDirec.Text
            fila.Cuit = TxtCuit.Text
            fila.Ciudad = TxtCiu.Text
            fila.CIva = TxtCiva.Text
            fila.Numero = 23
        Next
        Mn.Encabezado.AddEncabezadoRow(fila)
        'Cargo los comprobantes


        misdatos = MiClase.traedataset("select sum(importe) from tcompr where idpc=" & Pc & "")
        Fila1.TotalCom = FormatNumber(misdatos.Tables(0).Rows(0).Item(0), 2)
        'Mn.Comprobante.AddComprobanteRow(Fila1)
        Dim Fila2 = Mn.Pagos.NewPagosRow
        MiClase.cargardatagriview(DtgPag, "select comprobante,numero,importe from tpagop")
        DtgPag.AllowUserToAddRows = False
        For u As Integer = 0 To DtgPag.RowCount - 1
            Fila2 = Mn.Pagos.NewPagosRow
            If IsDBNull(Convert.ToString(DtgPag(0, u).Value)) Then
            Else
                Fila2.Comprobante = Convert.ToString(DtgPag(0, u).Value)
            End If
            If IsDBNull(Convert.ToString(DtgPag(1, u).Value)) Then
            Else
                Fila2.Numero = Convert.ToString(DtgPag(1, u).Value)
            End If
            If IsDBNull(Convert.ToDecimal(DtgPag(2, u).Value)) Then
            Else
                Fila2.Importe = Convert.ToDecimal(DtgPag(2, u).Value)
            End If
            Mn.Pagos.AddPagosRow(Fila2)
        Next u
        misdatos = MiClase.traedataset("select sum(importe) from tpagop")
        Fila2.TotPag = FormatNumber(misdatos.Tables(0).Rows(0).Item(0), 2)
        Dim rpt As New CryOpago
        Reportes.CrystalReportViewer1.Visible = False
        rpt.SetDataSource(Mn)
        Reportes.CrystalReportViewer1.ReportSource = rpt
        Reportes.CrystalReportViewer1.PrintReport()
        'Reportes.Show()
    End Sub


    Private Sub Fnum()
        'Formateo el Numero de Comprobante
        'Num = "2569"
        If Num < 10 Then
            Lnum = "0000000" + Num
        ElseIf Num >= 10 And Num < 100 Then
            Lnum = "000000" + Num
        ElseIf Num >= 100 And Num < 1000 Then
            Lnum = "00000" + Num
        ElseIf Num >= 1000 And Num < 10000 Then
            Lnum = "0000" + Num
        ElseIf Num >= 10000 And Num < 100000 Then
            Lnum = "000" + Num
        ElseIf Num >= 100000 And Num < 1000000 Then
            Lnum = "00" + Num
        ElseIf Num >= 1000000 And Num < 10000000 Then
            Lnum = "0" + Num
        ElseIf Num >= 10000000 And Num < 100000000 Then
            Lnum = Num
        End If
        'formateo el numero de pv
        'Pv = "14"
        If Pv < 10 Then
            Lpv = "000" + Pv
        ElseIf Pv >= 10 And Pv < 100 Then
            Lpv = "00" + Pv
        ElseIf Pv >= 100 And Pv < 1000 Then
            Lpv = "0" + Pv
        ElseIf Pv >= 1000 And Pv < 10000 Then
            Pv = Lpv
        End If
        'formateo el numero de cliente
        If TxtPro.Text = "" Then
            Id = "1"
        End If
        'Idcl = "28"
        If Idcl < 10 Then
            LidCl = "000" + CStr(Idcl)
        ElseIf Idcl >= 10 And Idcl < 100 Then
            LidCl = "00" + CStr(Idcl)
        ElseIf Idcl >= 100 And Idcl < 1000 Then
            LidCl = "0" + CStr(Idcl)
        ElseIf Idcl >= 1000 And Idcl < 10000 Then
            LidCl = CStr(Idcl)
        End If
        'Formateo el Numero de Comprobante
        IdTp = "11"
        If IdTp < 10 Then
            LidTp = "0" + IdTp
        ElseIf IdTp >= 10 And IdTp < 100 Then
            LidTp = IdTp
        End If
        'formateo el numero de linea

        'txt.Text = LidTp + Lpv + Lnum + CStr(LidCl) + CStr(BlNg)
        Clave = Lpv + "-" + Lnum
    End Sub
    Private Sub Car_Pago()
        Try
            If LCom = 0 Then
                LCom = 1
            End If
            If TxtComp.Text = "" Then
                IdCom = 1
                TxtComp.Text = "Efectivo"
                TxtNum.Text = "0"
                MskEnt.Focus()
            End If
            Dim ImpTot As Decimal
            'ImpTot = MskEnt.Text
            ' ImpTot = Decimal.Parse(MskEnt.Text, System.Globalization.CultureInfo.GetCultureInfo("es-us"))
            ImpTot = MskEnt.Text
            MiClase.eliminaactualizaregistra("insert into tpagop  values(" & LCom & "," & Pc & "," & IdCom & ",'" & TxtComp.Text & " ', " & _
                     "" & TxtNum.Text & "," & Str(ImpTot) & ")")
            LCom = LCom + 1
            MiClase.cargardatagriview(DtgPag, "select comprobante,numero,importe,linea,idcom from tpagop where pc=" & Pc & " ")
            DtgPag.Font = New Font("Arial ", 12, FontStyle.Regular)
            DtgPag.ColumnHeadersVisible = False
            DtgPag.AllowUserToAddRows = False
            DtgPag.Columns(2).DefaultCellStyle.Format = "##,##0.00"
            DtgPag.Columns(3).Visible = False
            DtgPag.Columns(4).Visible = False
            TxtComp.Clear()
            TxtNum.Clear()
            MskEnt.Text = 0
            misdatos = MiClase.traedataset("select sum(importe) from tpagop")
            TotPago = FormatNumber(misdatos.Tables(0).Rows(0).Item(0), 2)
            Txttotal.Text = TotPago
            If Txttotal.Text > 0 Then
                CmdPagar.Enabled = True
            Else
                CmdPagar.Enabled = False
            End If
            TxtComp.Focus()
            TxtComp.SelectionStart = 0
            TxtComp.SelectionLength = TxtComp.Text.Length
        Catch ex As Exception

        End Try
    End Sub


    Private Sub FrmPagoP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Pv = "3"
        IdEnc = 1
        MiClase.eliminaactualizaregistra("delete from tpagop where pc=" & Pc & "")
        MiClase.eliminaactualizaregistra("delete from TCtaCteP where idpc=" & Pc & "")
        MiClase.eliminaactualizaregistra("delete from TCompr where idpc=" & Pc & "")
        MiClase.eliminaactualizaregistra("delete from tcheqcartera where idpc=" & Pc & "")
        misdatos = MiClase.traedataset("select fact,pvimp,puerneg from configuracion where pc=" & Pc & "")
        Fact = misdatos.Tables(0).Rows(0).Item(0)
        PuerNeg = Trim(misdatos.Tables(0).Rows(0).Item(2))
        EsNeg = Mid(PuerNeg, 1, 3)
    End Sub

    Private Sub CmdEfec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        IdCom = 1
        TxtComp.Text = "Efectivo"
        TxtNum.Text = "0"
        MskEnt.Focus()
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

    Private Sub TxtNum_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtNum.LostFocus
        If TxtNum.Text = "" Then
            TxtNum.Text = 0
        End If
    End Sub

    Private Sub TxtNum_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNum.TextChanged

    End Sub

    Private Sub MskFecha_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Return Then
            'CmdEfec.Enabled = True
            'CmdCh.Enabled = True
            IdCom = 1
            TxtComp.Text = "Efectivo"
            TxtNum.Text = "0"
            MskEnt.Text = 0
            MskEnt.Focus()
        End If
    End Sub

    Private Sub MskFecha_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs)

    End Sub

    Private Sub MskEnt_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MskEnt.GotFocus
        MskEnt.SelectionStart = 0
        MskEnt.SelectionLength = MskEnt.Text.Length
    End Sub

    Private Sub MskEnt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MskEnt.KeyDown
        If e.KeyCode = Keys.Return Then
            If MskEnt.Text = 0 Then
                Mensaje = MsgBox("El Importe tiene que Ser Mayor a Cero", MsgBoxStyle.MsgBoxRight, "Importe mayor a Cero!!!")
            Else
                Car_Pago()
            End If
        End If
    End Sub

    Private Sub MskEnt_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles MskEnt.MaskInputRejected

    End Sub

    Private Sub CmdCh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        EsPago = 6
        IdCom = 3
        FrmBpag.Show()
    End Sub

    Private Sub DtgPag_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DtgPag.CellClick
        misdatos = MiClase.traedataset("select linea from tpagop where linea=" & DtgPag.Rows(e.RowIndex).Cells(3).Value() & " and pc=" & Pc & "")
        Dln = misdatos.Tables(0).Rows(0).Item(0)
    End Sub



    Private Sub DtgPag_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DtgPag.KeyDown
        If e.KeyCode = Keys.Delete Then
            MiClase.eliminaactualizaregistra("delete from tpagop where linea=" & Dln & "and pc=" & Pc & "")
            MiClase.cargardatagriview(DtgPag, "select comprobante,numero,importe,linea,idcom from tpagop where pc=" & Pc & " ")
            DtgPag.Font = New Font("Arial ", 12, FontStyle.Regular)
            DtgPag.ColumnHeadersVisible = False
            DtgPag.AllowUserToAddRows = False
            DtgPag.Columns(2).DefaultCellStyle.Format = "##,##0.00"
            DtgPag.Columns(3).Visible = False
            TxtComp.Clear()
            TxtNum.Clear()
            misdatos = MiClase.traedataset("select isnull( sum(importe),0) from tpagop")
            TotPago = FormatNumber(misdatos.Tables(0).Rows(0).Item(0), 2)

        End If
    End Sub

    Private Sub TxtPro_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtPro.GotFocus
        TxtPro.SelectionStart = 0
        TxtPro.SelectionLength = TxtPro.Text.Length
    End Sub

    Private Sub TxtPro_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPro.KeyDown
        If e.KeyCode = Keys.Return Then
            txtDirec.Enabled = True
            txtDirec.Focus()
            TxtCiu.Enabled = True
            TxtCuit.Enabled = True
            TxtCiva.Enabled = True
            TxtCuit.Enabled = True
            CmdBCiu.Enabled = True
            CmdBciva.Enabled = True
        End If
    End Sub

    Private Sub txtDirec_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDirec.GotFocus
        txtDirec.SelectionStart = 0
        txtDirec.SelectionLength = txtDirec.Text.Length
    End Sub

    Private Sub txtDirec_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDirec.KeyDown
        If e.KeyCode = Keys.Return Then
            TxtCiu.Focus()
        End If
    End Sub

    Private Sub TxtCiu_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCiu.GotFocus
        TxtCiu.SelectionStart = 0
        TxtCiu.SelectionLength = TxtCiu.Text.Length
    End Sub

    Private Sub TxtCiu_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCiu.KeyDown
        If e.KeyCode = Keys.Return Then
            TxtCiva.Focus()
        End If
    End Sub

    Private Sub CmdBCiu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdBCiu.Click
        EsCiu = 3
        FrmbCiu.Show()
    End Sub

    Private Sub TxtCiva_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCiva.GotFocus
        TxtCiva.SelectionStart = 0
        TxtCiva.SelectionLength = TxtCiva.Text.Length
    End Sub

    Private Sub TxtCiva_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCiva.KeyDown
        If e.KeyCode = Keys.Return Then
            If IdCiva = 5 Or IdCiva = 0 Then
                TxtCuit.Mask = "##.###.###"
                LbCuit.Text = "DNI :"
            Else
                TxtCuit.Mask = "##-########-#"
                LbCuit.Text = "Cuit :"
            End If
            TxtCuit.Focus()
        End If
    End Sub

    Private Sub TxtCiva_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCiva.TextChanged

    End Sub

    Private Sub CmdBciva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdBciva.Click
        EsCv = 3
        FrmBciva.Show()
    End Sub

    Private Sub CmdbusCli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdbusCli.Click
        EsPr = 5
        FrmBpr.Show()
    End Sub

    Private Sub TxtCuit_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCuit.GotFocus
        TxtCuit.SelectionStart = 0
        TxtCuit.SelectionLength = TxtCuit.Text.Length
    End Sub

    Private Sub TxtCuit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCuit.KeyDown
        If e.KeyCode = Keys.Return Then
            TxtComp.Enabled = True
            TxtComp.Focus()
        End If
    End Sub

    Private Sub TxtCuit_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles TxtCuit.MaskInputRejected

    End Sub

    Private Sub TxtComp_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtComp.KeyDown
        If e.KeyCode = Keys.Return Then
            EsPago = 6
            FrmBpag.Show()
        End If
    End Sub

    Private Sub TxtComp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtComp.TextChanged

    End Sub

    Private Sub TxtPro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPro.TextChanged

    End Sub

    Private Sub txtDirec_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDirec.TextChanged

    End Sub

    Private Sub TxtCiu_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCiu.TextChanged

    End Sub

    Private Sub CmdPagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdPagar.Click
        IdTp = 11
        misdatos = MiClase.traedataset("select isnull( max(numero),0) from pagosp ")
        NumFac = misdatos.Tables(0).Rows(0).Item(0) + 1
        Num = misdatos.Tables(0).Rows(0).Item(0) + 1
        Fnum()
        Clave = Lpv + "-" + Lnum
        'cargo los pagos en la tabla pagos
        DtgPag.AllowUserToAddRows = False
        Dim fil As Integer = DtgPag.Rows.Count
        For u As Integer = 0 To fil - 1
            Comprobante = Trim(Convert.ToString(DtgPag(0, u).Value))
            NumPag = Convert.ToString(DtgPag(1, u).Value)
            ImPag = (Convert.ToString(DtgPag(2, u).Value))
            Dlin = Trim(Convert.ToString(DtgPag(3, u).Value))
            IdCom = Trim(Convert.ToString(DtgPag(4, u).Value))


            Fc = Date.Today
            Fc = Format(Date.Today, "dd/MM/yy")
            MiClase.eliminaactualizaregistra("insert into pagosp values(" & Num & "," & IdTp & ", " & _
                 "" & Dlin & "," & Id & "," & IdCom & ",'" & Fc & "','" & Comprobante & "'," & NumPag & "," & Str(ImPag) & ", " & _
                 "" & 1 & "," & BlNg & "," & Pc & "," & IdUs & ",'" & TxtPro.Text & "','" & txtDirec.Text & "'," & _
                 "'" & TxtCiu.Text & "','" & TxtCiva.Text & "','" & TxtCuit.Text & "')")
            Dlin = Dlin + 1
        Next u
        If EsNeg = "LPT" Then
            'Imp_TickP()
        ElseIf EsNeg = "COM" Then
            'Imp_tick()
        ElseIf EsNeg = "USB" Then
            Dim printDoc As New PrintDocument
            printDoc.PrinterSettings.PrinterName = "SAM4S GIANT-100"
            Dim printCta As New PrintDocument
            printCta.PrinterSettings.PrinterName = "SAM4S GIANT-100"
            AddHandler printDoc.PrintPage, AddressOf print_PrintPage
            printDoc.Print()    
        End If
        
        Blanquear()
    End Sub
End Class