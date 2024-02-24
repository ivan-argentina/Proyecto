Imports System.Text
Imports System
Imports System.IO.Ports
Imports Microsoft.VisualBasic
Imports FiscalNET
Imports System.Drawing.Printing
Imports System.Drawing

Public Class FrmPago




    Dim EsDpag As Integer
    Dim EsAct As Integer
    Dim eeac As Decimal
    Dim contador As Integer = 0
    Dim ImpTot As Decimal
    Dim FecCom As Date
    Dim EstPag As Integer
    'Dim Chk As DataGridViewCheckBoxColumn = New DataGridViewCheckBoxColumn(False)


    Private Sub Car_Pago()
        Dim TxTT As Decimal
        ' Dim TxTT1 As Decimal
        If MskEnt.Text = "" Then
            MskEnt.Text = 0
        End If
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
        End If
        ' ImpTot = Decimal.Parse(MskEnt.Text, System.Globalization.CultureInfo.GetCultureInfo("es-us"))
        ImpTot = MskEnt.Text
        Fcp = DtcFecha.Value
        Fcp = Format(DtcFecha.Value, "dd/MM/yy")

        MiClase.eliminaactualizaregistra("insert into tpago  values(" & LCom & "," & Pc & "," & IdCom & ",'" & TxtComp.Text & " ', " & _
                 "" & TxtNum.Text & "," & Str(ImpTot) & ",'" & Fc & "'," & Str(MskEnt.Text) & ")")
        misdatos = MiClase.traedataset("select isnull(sum(importe),0) from tpago where pc=" & Pc & "")
        TxTT = misdatos.Tables(0).Rows(0).Item(0)
        TotPago = misdatos.Tables(0).Rows(0).Item(0)
        'mskEntrega.Text = FormatNumber(misdatos.Tables(0).Rows(0).Item(0), 2)
        LCom = LCom + 1
        MiClase.cargardatagriview(DtgPag, "select comprobante,numero,importe,linea,idcom,vencimiento from tpago where pc=" & Pc & " ")
        DtgPag.AllowUserToAddRows = False
        DtgPag.Font = New Font("Arial ", 12, FontStyle.Regular)
        DtgPag.ColumnHeadersVisible = False
        DtgPag.AllowUserToAddRows = False
        DtgPag.Columns(2).DefaultCellStyle.Format = "##,##0.00"
        DtgPag.Columns(3).Visible = False
        DtgPag.Columns(4).Visible = False
        DtgPag.Columns(5).Visible = False
        'TxtComp.Clear()
        TxtNum.Text = 0
        TxtComp.Text = "Efectivo"
        TxtComp.Enabled = False
        TxtNum.Enabled = False
        MskEnt.Clear()
        MskEnt.Enabled = True
        MskEnt.Focus()
        IdCom = 1
        EsVenta = 0
        Cventa = "Contado"
        'CmdEfec.Enabled = False
        'CmdCh.Enabled = True
        CmdPagar.Enabled = False
        CmdTarjeta.Enabled = True
        'End If
    End Sub



    Private Sub Imprimir1()
        Dim printDoc As New PrintDocument
        Dim printCta As New PrintDocument
        Mensaje = MsgBox("Desea Imprimir El Recibo", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir Recibo!!!")
        If Mensaje = MsgBoxResult.Yes Then
            misdatos = MiClase.traedataset("select impresora from configuracion where pc=" & Pc & "")
            Impresora = Trim(misdatos.Tables(0).Rows(0).Item(0))
            printCta.PrinterSettings.PrinterName = Impresora
            AddHandler printDoc.PrintPage, AddressOf print_PrintCliFC
            printDoc.Print()
        End If
    End Sub

    Private Sub print_PrintCliFC(ByVal sender As Object, _
                   ByVal e As PrintPageEventArgs)
        Dim PCom As String
        Dim x As Single = 0.0F
        Dim y As Single = 50.0F
        'Dim width As Int32 = 198

        Dim width As Int32 = 280
        Dim height As Int32 = 55
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
        Linea3 = Trim(misdatos.Tables(0).Rows(0).Item(2))
        Linea4 = Trim(misdatos.Tables(0).Rows(0).Item(3))
        
        e.Graphics.DrawString(Linea1, prFontE, Brushes.Black, New Rectangle(0, y + 15, width, 15))
        e.Graphics.DrawString(Linea2, prFont, Brushes.Black, New Rectangle(0, y + 35, width, 15))
        e.Graphics.DrawString(Linea3, prFont, Brushes.Black, New Rectangle(0, y + 50, width, 15))
        e.Graphics.DrawString(Linea4, prFont, Brushes.Black, New Rectangle(0, y + 65, width, 15))
        CliTick = TxtCli.Text
        DirTick = txtDirec.Text
        CiuTick = TxtCiu.Text
        CuitTick = TxtCuit.Text
        PCom = "Recibo X"

        Dim OurPen As Pen
        OurPen = New Pen(Color.Black, 1)
        e.Graphics.DrawLine(OurPen, 0, 190, width, 190)
        Fecha = Format(Now, "dd/MM/yyyy")
        '  e.Graphics.DrawString(PCom, prFontE, Brushes.Black, New Rectangle(0, y + 140, width, 15))
        FechIm = "Fecha : " + Fecha
        e.Graphics.DrawString(Clave, prFont, Brushes.Black, New Rectangle(xPos, y + 143, width, 15))
        e.Graphics.DrawString(Fecha, prFont, Brushes.Black, New Rectangle(xPos, y + 158, width, 15))
        e.Graphics.DrawString(PCom, prFontE, Brushes.Black, New Rectangle(0, y + 143, width, 15))
        e.Graphics.DrawLine(OurPen, 0, 226, width, 226)



        'Imprimo los datos del cliente
        y = 230
        e.Graphics.DrawString(CliTick, prFont, Brushes.Black, New Rectangle(0, y, width, 15))
        y = y + 15
        e.Graphics.DrawString(DirTick, prFont, Brushes.Black, New Rectangle(0, y, width, 15))
        y = y + 15
        e.Graphics.DrawString(CiuTick, prFont, Brushes.Black, New Rectangle(0, y, width, 15))
        y = y + 15
        e.Graphics.DrawString(CuitTick, prFont, Brushes.Black, New Rectangle(0, y, width, 15))
        e.Graphics.DrawLine(OurPen, 0, 290, width, 290)
        DtgPag.AllowUserToAddRows = False
        Dim fil As Integer = DtgPag.Rows.Count
        For u As Integer = 0 To fil - 1
            Comprobante = Trim(Convert.ToString(DtgPag(0, u).Value))
            NumPag = Convert.ToString(DtgPag(1, u).Value)
            ImPag = (Convert.ToString(DtgPag(2, u).Value))
            Dlin = Trim(Convert.ToString(DtgPag(3, u).Value))
            IdCom = Trim(Convert.ToString(DtgPag(4, u).Value))
            FechCh = Convert.ToString(DtgPag(5, u).Value)
            y = 300
            e.Graphics.DrawString(Comprobante + "-" + Str(NumPag), prFont, Brushes.Black, New Rectangle(0, y, width, 15))
            e.Graphics.DrawString(ImPag, prFont, Brushes.Black, New Rectangle(230, y, 500, 15))
            y = y + 12
        Next
        y = y + 15


        y = 300
        '  CantProd = 0


        y = y + 15
        e.Graphics.DrawString("Cajero :" + UsuCar, prFont, Brushes.Black, New Rectangle(0, y + 20, width, 15))
        y = y + 15
        e.HasMorePages = False
    End Sub


    Private Sub ActCom()
        If EsAct = 0 Then
            '        EntAc1 = MskEntrega.Text
            'Busco la nota de Credito

            '+++HASTA ACA+++++++++++++++


        Else
            Mensaje = MsgBox("Ya se Actualizaron los  comprobante", MsgBoxStyle.OkOnly, "Ya se actualizaron los Comprobantes!!!")
        End If
    End Sub

    Private Sub Imprimir()
        'Cargo la datagridvies para el reporte
        'NumFac = 23
        IdTp = 5
        MiClase.cargardatagriview(DtgRec, "select fac_cta.idtp,fecha,haber,blng,tipo,lnum,numero from fac_cta inner join tip_fac on fac_cta.idtp=tip_fac.id where fac_cta.numero=" & Num & " and idtp=" & IdTp & "")
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
            If IsDBNull(Convert.ToString(DtgRec(1, i).Value)) Then
            Else
                fila.Fecha = Convert.ToString(DtgRec(1, i).Value)
            End If
            If IsDBNull(Convert.ToString(DtgRec(5, i).Value)) Then
            Else
                fila.Fnum = Trim(Convert.ToString(DtgRec(5, i).Value))
            End If
            fila.Linea1 = Linea1
            fila.Linea2 = Linea2
            fila.Linea3 = Linea3
            fila.Cliente = TxtCli.Text
            fila.Direccion = txtDirec.Text
            fila.Cuit = TxtCuit.Text
            fila.Ciudad = TxtCiu.Text
            fila.CIva = Civa
            fila.Numero = 23
        Next
        Mn.Encabezado.AddEncabezadoRow(fila)
        'Cargo los comprobantes
        Dim Fila1 As DtcRecibo.ComprobanteRow
        MiClase.cargardatagriview(DtgCom, "select numcom,fechcom,importe,cuota from tcompr where idpc=" & Pc & "")
        DtgCom.AllowUserToAddRows = False
        For i As Integer = 0 To DtgCom.RowCount - 1
            Fila1 = Mn.Comprobante.NewComprobanteRow
            If IsDBNull(Convert.ToString(DtgCom(0, i).Value)) Then
            Else
                Fila1.Numero = Convert.ToString(DtgCom(0, i).Value)
            End If
            If IsDBNull(Convert.ToString(DtgCom(1, i).Value)) Then
            Else
                Fila1.Fecha = Convert.ToString(DtgCom(1, i).Value)
            End If
            If IsDBNull(Convert.ToDecimal(DtgCom(2, i).Value)) Then
            Else
                Fila1.Importe = FormatNumber(Convert.ToDecimal(DtgCom(2, i).Value), 2)
            End If
            Mn.Comprobante.AddComprobanteRow(Fila1)
            misdatos = MiClase.traedataset("select sum(importe) from tcompr where idpc=" & Pc & "")
            Fila1.TotalCom = FormatNumber(misdatos.Tables(0).Rows(0).Item(0), 2)
        Next i

        'Mn.Comprobante.AddComprobanteRow(Fila1)
        Dim Fila2 = Mn.Pagos.NewPagosRow
        MiClase.cargardatagriview(DtgPag, "select comprobante,numero,importe from tpago")
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
        misdatos = MiClase.traedataset("select sum(importe) from tpago")
        Fila2.TotPag = FormatNumber(misdatos.Tables(0).Rows(0).Item(0), 2)
        Reportes.CrystalReportViewer1.Visible = False
        Dim rpt As New CryRecibo
        rpt.SetDataSource(Mn)
        Reportes.CrystalReportViewer1.ReportSource = rpt
        'Reportes.Show()
        Reportes.CrystalReportViewer1.PrintReport()

        'Reportes.Show()
        'Reportes.Close()
    End Sub




    Private Sub Imprimir_old()
        'Cargo la datagridvies para el reporte
        'NumFac = 23
        IdTp = 5
        MiClase.cargardatagriview(DtgRec, "select facturas.idtp,fecha,esventa,total,blng,tipo,fnum,entrega,numero,idtp from facturas inner join tip_fac on facturas.idtp=tip_fac.id where facturas.numero=" & NumFac & " and idtp=" & IdTp & "")
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
            If IsDBNull(Convert.ToString(DtgRec(1, i).Value)) Then
            Else
                fila.Fecha = Convert.ToString(DtgRec(1, i).Value)
            End If
            If IsDBNull(Convert.ToString(DtgRec(6, i).Value)) Then
            Else
                fila.Fnum = Convert.ToString(DtgRec(6, i).Value)
            End If
            fila.Linea1 = Linea1
            fila.Linea2 = Linea2
            fila.Linea3 = Linea3
            fila.Cliente = TxtCli.Text
            fila.Direccion = txtDirec.Text
            fila.Cuit = TxtCuit.Text
            fila.Ciudad = TxtCiu.Text
            fila.CIva = Civa
            fila.Numero = 23
        Next
        Mn.Encabezado.AddEncabezadoRow(fila)
        'Cargo los comprobantes
        'Dim Fila1 As DtcRecibo.ComprobanteRow
        'Dim Fila2 = Mn.Pagos.NewPagosRow
        Dim Fila1 = Mn.Comprobante.NewComprobanteRow
        MiClase.cargardatagriview(DtgCom, "select numcom,fechcom,importe from tcompr where idpc=" & Pc & "")
        DtgCom.AllowUserToAddRows = False
        For i As Integer = 0 To DtgCom.RowCount - 1
            Fila1 = Mn.Comprobante.NewComprobanteRow
            If IsDBNull(Convert.ToString(DtgCom(0, i).Value)) Then
            Else
                Fila1.Numero = Convert.ToString(DtgCom(0, i).Value)
            End If
            If IsDBNull(Convert.ToString(DtgCom(1, i).Value)) Then
            Else
                Fila1.Fecha = Convert.ToString(DtgCom(1, i).Value)
            End If
            If IsDBNull(Convert.ToDecimal(DtgCom(2, i).Value)) Then
            Else
                Fila1.Importe = FormatNumber(Convert.ToDecimal(DtgCom(2, i).Value), 2)
            End If
            Mn.Comprobante.AddComprobanteRow(Fila1)
        Next i
        misdatos = MiClase.traedataset("select sum(importe) from tcompr where idpc=" & Pc & "")
        Fila1.TotalCom = FormatNumber(misdatos.Tables(0).Rows(0).Item(0), 2)
        'Mn.Comprobante.AddComprobanteRow(Fila1)
        Dim Fila2 = Mn.Pagos.NewPagosRow
        MiClase.cargardatagriview(DtgPag, "select comprobante,numero,importe from tpago")
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
        misdatos = MiClase.traedataset("select sum(importe) from tpago")
        Fila2.TotPag = FormatNumber(misdatos.Tables(0).Rows(0).Item(0), 2)
        Reportes.CrystalReportViewer1.Visible = False
        Dim rpt As New CryRecibo
        rpt.SetDataSource(Mn)
        Reportes.CrystalReportViewer1.ReportSource = rpt
        Reportes.CrystalReportViewer1.PrintReport()
        'Reportes.Show()
        'Reportes.Close()
    End Sub


    Private Sub Fnum()
        'Formateo el Numero de Comprobante
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
            Lpv = Pv
        End If
        'formateo el numero de cliente
        If TxtCli.Text = "" Then
            Idcl = "1"
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
        IdTp = "5"
        If IdTp < 10 Then
            LidTp = "0" + IdTp
        ElseIf IdTp >= 10 And IdTp < 100 Then
            LidTp = IdTp
        End If
        'formateo el numero de linea

        'txt.Text = LidTp + Lpv + Lnum + CStr(LidCl) + CStr(BlNg)
        Clave = Lpv + "-" + Lnum
    End Sub
    Private Sub Blanquear()
        'DtgFac.Columns.Remove(Chk)
        TxtCli.Text = ""
        txtDirec.Text = ""
        TxtCiu.Text = ""
        TxtCuit.Text = ""
        TxtComp.Clear()
        MskEntrega_old.Text = ""
        MskEnt.Text = 0
        MskEntrega_old.Enabled = False
        CmdPagar.Enabled = False
        MskEnt.Enabled = False
        CmdEfec.Enabled = False
        CmdCh.Enabled = False
        CmdTarjeta.Enabled = False
        MskTotal.Clear()
        TxtSaldo.Clear()
        MiClase.eliminaactualizaregistra("delete from tpago where pc=" & Pc & "")
        MiClase.cargardatagriview(DtgPag, "select * from tpago where pc=" & Pc & "")
        MiClase.eliminaactualizaregistra("delete from tcompr where idpc=" & Pc & "")
        MiClase.cargardatagriview(DtgCom, "select * from tcompr where idpc=" & Pc & "")
        MiClase.cargardatagriview(DtgRec, "select * from  facturas  where numero=" & 0 & " and idtp=" & 1000 & "")
    End Sub


    Private Sub TxtCli_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCli.Click
        Blanquear()
    End Sub

    Private Sub TxtCli_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCli.GotFocus
        TxtCli.SelectionStart = 0
        TxtCli.SelectionLength = TxtCli.Text.Length
    End Sub
    Private Sub TxtCli_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCli.KeyDown
        If e.KeyCode = Keys.Return Then
            If IsNumeric(TxtCli.Text) Then
                misdatos = MiClase.traedataset("select id,cliente,direccion from clientes where id=" & TxtCli.Text & "")
                Dim totclF As Integer = misdatos.Tables(0).Rows.Count
                If totclF = 0 Then
                    Mensaje = MsgBox("Este Cliente No Existe", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Cliente Inexistente!!!")
                    If Mensaje = MsgBoxResult.Ok Then
                        TxtCli.Focus()
                        TxtCli.SelectionStart = 0
                        TxtCli.SelectionLength = TxtCli.Text.Length
                    End If
                Else
                    misdatos = MiClase.traedataset("select clientes.id,cliente,direccion,ciudad,cuit,c_iva,idciu,idciva,email,telefono,cel,cpostal,idpr,provincia,email,salcli from clientes inner join ciudad on clientes.idciu=ciudad.id inner join c_de_iva on clientes.idciva = c_de_iva.id inner join provincias on clientes.idpr=provincias.id where clientes.id = " & TxtCli.Text & " ")
                    Idcl = misdatos.Tables(0).Rows(0).Item(0)
                    TxtCli.Text = misdatos.Tables(0).Rows(0).Item(1)
                    txtDirec.Text = misdatos.Tables(0).Rows(0).Item(2)
                    TxtCiu.Text = misdatos.Tables(0).Rows(0).Item(3)
                    TxtCuit.Text = misdatos.Tables(0).Rows(0).Item(4)
                    Civa = misdatos.Tables(0).Rows(0).Item(5)
                    IdCiva = misdatos.Tables(0).Rows(0).Item(7)
                    TxtSaldo.Text = FormatNumber(misdatos.Tables(0).Rows(0).Item(15), 2)
                    CmdEfec.Enabled = True
                    CmdTarjeta.Enabled = True
                    TxtComp.Enabled = True
                    TxtComp.Text = "Efectivo"
                    TxtComp.Enabled = False
                    TxtNum.Enabled = True
                    DtcFecha.Enabled = True
                    MskEnt.Enabled = True
                    MskEnt.Focus()
                End If
            Else
                EsCl = 6
                BCli = TxtCli.Text
                FrmBcl.Show()
            End If

        End If
    End Sub

    Private Sub FrmPago_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Pv = "3"
        IdEnc = 1
        MiClase.eliminaactualizaregistra("delete from tpago where pc=" & Pc & "")
        MiClase.eliminaactualizaregistra("delete from tcompr where idpc=" & Pc & "")
        MiClase.eliminaactualizaregistra("delete from tctacte where idpc=" & Pc & "")

        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")
    End Sub




    Private Sub CmdEfec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdEfec.Click
        EsPago = 1
        TxtComp.Text = "Efectivo"
        TxtNum.Text = "0"
        MskEnt.Enabled = True
        MskEnt.Focus()
        CmdEfec.Enabled = False
        CmdCh.Enabled = True
    End Sub

    Private Sub CmdCh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCh.Click
        EsPago = 2
        FrmBpag.Show()
        CmdEfec.Enabled = True
        DtcFecha.Enabled = True
        MskEnt.Enabled = True
        CmdCh.Enabled = False
        CmdTarjeta.Enabled = True
    End Sub

    Private Sub TxtNum_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtNum.GotFocus
        TxtNum.SelectionStart = 0
        TxtNum.SelectionLength = TxtNum.Text.Length
    End Sub

    Private Sub TxtNum_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtNum.KeyDown
        If e.KeyCode = Keys.Return Then
            DtcFecha.Focus()
        End If
    End Sub

    Private Sub TxtNum_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNum.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub MskEnt_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MskEnt.Click
        CmdEfec.Enabled = True
        CmdTarjeta.Enabled = True
        IdCom = 1
        TxtComp.Text = "Efectivo"
        TxtNum.Text = "0"
        ' MskEnt.Text = 0

    End Sub

    Private Sub MskEnt_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MskEnt.GotFocus
        MskEnt.SelectionStart = 0
        MskEnt.SelectionLength = MskEnt.Text.Length
    End Sub

    Private Sub MskEnt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MskEnt.KeyDown
        If e.KeyCode = Keys.Return Then
            Car_Pago()
            misdatos = MiClase.traedataset("select sum(importe) from tpago where pc=" & Pc & "")
            TotPago = FormatNumber(misdatos.Tables(0).Rows(0).Item(0), 2)
            MskTotal.Text = TotPago
        End If
        CmdPagar.Enabled = True
    End Sub

    Private Sub MskEnt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MskEnt.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = False
        End If
    End Sub

    Private Sub MskEnt_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MskEnt.LostFocus
        Me.MskEnt.Text = Format(valor, "###0.00") 'esto te dato 1050.00
    End Sub

    Private Sub MskEnt_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles MskEnt.MaskInputRejected

    End Sub

    Private Sub DtgPag_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DtgPag.CellClick
        misdatos = MiClase.traedataset("select linea from tpago where linea=" & DtgPag.Rows(e.RowIndex).Cells(3).Value() & " and pc=" & Pc & "")
        Dln = misdatos.Tables(0).Rows(0).Item(0)
    End Sub

    Private Sub DtgPag_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DtgPag.CellContentClick

    End Sub

    Private Sub DtgPag_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DtgPag.KeyDown
        If e.KeyCode = Keys.Delete Then
            MiClase.eliminaactualizaregistra("delete from tpago where linea=" & Dln & "and pc=" & Pc & "")
            MiClase.cargardatagriview(DtgPag, "select comprobante,numero,importe,linea,idcom from tpago where pc=" & Pc & " ")
            DtgPag.Font = New Font("Arial ", 12, FontStyle.Regular)
            DtgPag.ColumnHeadersVisible = False
            DtgPag.AllowUserToAddRows = False
            DtgPag.Columns(2).DefaultCellStyle.Format = "##,##0.00"
            DtgPag.Columns(3).Visible = False
            TxtComp.Clear()
            TxtNum.Clear()
            misdatos = MiClase.traedataset("select isnull( sum(importe),0) from tpago where pc=" & Pc & "")
            TotPago = FormatNumber(misdatos.Tables(0).Rows(0).Item(0), 2)
            MskEntrega_old.Text = TotPago
            If MskEntrega_old.Text > 0 Then
                CmdPagar.Enabled = True
            Else
                CmdPagar.Enabled = False
            End If

        End If
    End Sub
    Private Sub CmdPagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdPagar.Click
        'Car_Pago()
        'Traigo el Numero del recibo
        misdatos = MiClase.traedataset("select isnull( max(numero),0) from fac_cta where idtp=" & 5 & "")
        NumFac = misdatos.Tables(0).Rows(0).Item(0) + 1
        Num = misdatos.Tables(0).Rows(0).Item(0) + 1
        IdTp = 5
        'EntAnt = MskTotal.Text
        Fnum()
        Clave = Lpv + "-" + Lnum
        'cargo los pagos en la tabla pagos
        DtgPag.AllowUserToAddRows = False
        Dim fil As Integer = DtgPag.Rows.Count
        For u As Integer = 0 To fil - 1
            If IsDBNull(Convert.ToString(DtgPag(0, u).Value)) Then
            Else
                Comprobante = Trim(Convert.ToString(DtgPag(0, u).Value))
            End If
            If IsDBNull(Convert.ToString(DtgPag(1, u).Value)) Then
            Else
                NumPag = Convert.ToString(DtgPag(1, u).Value)
            End If
            If IsDBNull(Convert.ToString(DtgPag(2, u).Value)) Then
            Else
                ImPag = (Convert.ToString(DtgPag(2, u).Value))
            End If
            If IsDBNull(Convert.ToString(DtgPag(3, u).Value)) Then
            Else
                Dlin = Trim(Convert.ToString(DtgPag(3, u).Value))
            End If
            If IsDBNull(Convert.ToString(DtgPag(4, u).Value)) Then
            Else
                IdCom = Trim(Convert.ToString(DtgPag(4, u).Value))
            End If
            If IsDBNull(Convert.ToString(DtgPag(5, u).Value)) Then
            Else
                FechCh = Convert.ToString(DtgPag(5, u).Value)
            End If
            Fcp = Date.Today
            Fcp = Format(Date.Today, "dd/MM/yy")
            MiClase.eliminaactualizaregistra("insert into pagos values(" & Num & "," & 5 & ", " & _
                 "" & Dlin & "," & Idcl & "," & IdCom & ",'" & Fcp & "','" & Comprobante & "'," & NumPag & "," & Str(ImPag) & ", " & _
                 "" & 1 & "," & BlNg & "," & Pc & "," & IdUs & ")")
            EstPag = 0
            If IdCom = 3 Then
                FcD = FechCh
                FcD = Format(FechCh, "dd/MM/yy")
                MiClase.eliminaactualizaregistra("insert into che_cartera values(" & Idcl & ",'" & TxtCli.Text & "', " & _
                "'" & Comprobante & "'," & NumPag & ",'" & Fcp & "'," & Str(ImPag) & "," & 0 & "," & IdUs & ")")
            End If
        Next u
        '***************
        EntAnt = MskTotal.Text
        MiClase.eliminaactualizaregistra("insert into fac_cta values(" & NumFac & "," & IdTp & ", " & _
          "" & Idcl & ",'" & TxtCli.Text & "','" & txtDirec.Text & "','" & TxtCiu.Text & "','" & Civa & "','" & Fcp & "', " & _
          "" & Str(0) & "," & Str(EntAnt) & "," & Str(0) & ",'" & Clave & "'," & BlNg & "," & IdUs & ")")
        ToTT = MskTotal.Text
        Cpostal = 0

        MiClase.eliminaactualizaregistra("insert into facturas values(" & NumFac & "," & IdTp & ", " & _
        "" & 1 & "," & IdEnc & "," & Idcl & ",'" & Fc & "'," & EsVenta & ",'" & Cventa & "'," & Str(NetT) & ", " & _
        "" & Str(IvT) & "," & Str(Iint) & "," & Str(ToTT) & "," & 1 & "," & Str(Alic) & ",'" & Fc & "','" & Clave & "'," & 0 & ", " & _
        "'" & 0 & "','" & 0 & "','" & TxtCli.Text & "','" & txtDirec.Text & "','" & TxtCiu.Text & "'," & _
        "'" & Civa & "','" & TxtCuit.Text & "'," & IdCiva & ",'" & Cpostal & "'," & IdPrv & "," & IdUs & ")")


        'Grabo el saldo en la tabla cliente
        misdatos = MiClase.traedataset("select salcli from clientes where id=" & Idcl & "")
        TotalE = FormatNumber(misdatos.Tables(0).Rows(0).Item(0))
        TotalF = TotalE - MskTotal.Text
        MiClase.eliminaactualizaregistra("update clientes set salcli =" & Str(TotalF) & "where id=" & Idcl & "")
        '+++++++++++++++++++
        Imprimir1()
        Blanquear()
    End Sub

    Private Sub CmdTarjeta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdTarjeta.Click
        EsDpag = 1
        EsPago = 0
        IdCom = 2
        CmdEfec.Enabled = True
        MskEnt.Enabled = True
        CmdEfec.Enabled = True
        DtcFecha.Enabled = True
        'CmdCh.Enabled = True
        CmdTarjeta.Enabled = False
        TxtComp.Enabled = True
        TxtComp.Clear()
        TxtComp.Focus()
    End Sub



    Private Sub DtcFecha_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DtcFecha.KeyDown
        If e.KeyCode = Keys.Return Then
            MskEnt.Focus()
        End If
    End Sub

    Private Sub DtcFecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DtcFecha.ValueChanged

    End Sub

    Private Sub TxtComp_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtComp.KeyDown
        If e.KeyCode = Keys.Return Then
            EsCl = "3"
            Btar = TxtComp.Text
            FrmBpag.Show()
        End If
    End Sub

    Private Sub TxtComp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtComp.TextChanged

    End Sub

    Private Sub TxtCli_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCli.TextChanged

    End Sub
End Class
