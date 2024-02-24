Imports System
Imports System.IO.Ports
Imports Microsoft.VisualBasic
Imports FiscalNET

Public Class FrmFactura
    'Variables Factura electronica
    Dim TipDoc As String
    Dim Prueba As String
    Dim Cbte As String
    Dim tipo As String
    Dim Dif As Integer
    Dim Fc As Date
    Dim FcAc As Date = Date.Now
    Dim Tocken As String
    Dim Sign As String
    Dim Pv As String
    Dim Certif As String
    Dim ClavePiv As String
    Dim Ser As Integer
    Dim Pv1 As Integer
    Dim NumDbto As Integer
    Dim Linea13 As String
    Dim Linea14 As String
    'Dim Certificado As String
    Dim concepto, tipo_doc, nro_doc, _
     cbt_desde, cbt_hasta, imp_total, imp_tot_conc, imp_neto, _
     imp_iva, imp_trib, imp_op_ex, fecha_cbte, fecha_venc_pago, _
     fecha_serv_desde, fecha_serv_hasta, _
     moneda_id, moneda_ctz
    Dim VtoCae As String
    Dim Cuit_Em As String
    Dim fecha, cbte_nro, cae
    Dim fecha_vto_cae As String
    Dim id, Desc, base_imp, alic, importe
    Dim Dcuit As String
    Dim Mcuit As String
    Dim Icuit As String
    Dim IdAlic As Integer
    Dim CAli As String
    Dim Empresa As String
    Dim DirEm As String
    Dim CiuEm As String
    Dim IbEm As String
    Dim CivEm As String
    Dim InAcEm As String
    Dim CuitEm As String
    Dim Ob1 As String
    Dim Ob2 As String
    Dim Ob3 As String
    Dim Numcop As Integer
    Dim Bit As String
    Dim PBinar As String
    Dim PBinFi As String
    Dim Simp As String
    Dim TImp As String
    Dim CImp As String
    Dim PImp As String
    Dim Pbin As String
    'variables hasar 715
    Dim Ihasar As HasarTicket = New HasarTicket
    Dim Direccion As String
    Dim Cliente As String
    'Variables Epson tmu-220
    Dim ifiscal As EpsonTicket = New EpsonTicket
    Dim strVar1, strVar2 As String
    Dim LetrCierr As String
    Dim letrNc As String
    Dim LetrComp As String
    Dim Prns As String
    Dim Fis As String
    Dim N1, N2, N3, N4 As String
    Dim IdCuota As Integer
    Dim NCom As Integer
    Dim TotCta As Decimal
    Dim Dpr As String
    Dim Dfis As String
    Dim EntNc As Decimal
    Dim Fvto As String
    'Private WithEvents RS232 As New System.IO.Ports.SerialPort
    Dim Fech As Date
    Dim CanIm As String
    Dim PunIm As String
    Dim PtoIm As String
    Dim Scmd As String
    Dim Item As String
    Dim Item1 As String
    Dim ImpTot As Decimal
    Dim Recibi As String
    Dim CerrNeg As String
    Dim CerRec As String
    Dim CerVuel As String
    Dim TotCom As Decimal
    Dim EntCom As Decimal
    Dim Vuelto As Decimal
    Dim TotVuel As String
    Dim BarId As String
    Dim Largo As Integer
    Dim Primero As Integer
    Dim Entero As String
    Dim Decim As String
    Dim EsCant As Integer

    'Private WithEvents serial As SerialPort = New System.IO.Ports.SerialPort("Com2", 9600, Parity.None, 8, StopBits.One)

    Private WithEvents serial As SerialPort = New System.IO.Ports.SerialPort(PuerNeg, 9600, Parity.None, 8, StopBits.One)


    Private Sub Imp_tick()
        Dim TotNeg As String
        Dim NumFac As String
        misdatos = MiClase.traedataset("select linea1,linea2,linea3 from encabezado")
        Linea1 = Trim(misdatos.Tables(0).Rows(0).Item(0))
        Linea2 = Trim(misdatos.Tables(0).Rows(0).Item(1))
        Linea3 = Trim(misdatos.Tables(0).Rows(0).Item(2))
        serial.PortName = PuerNeg
        'serial.Open()
        'If serial.IsOpen = False Then
        'Mensaje = MsgBox("El Impresor esta Apagado o Desconectado ", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Problema con el impresor!!!")
        'Else
        serial.Open()
        'End If
        'If Not serial.IsOpen Then
        'serial.Open()
        'End If
        If serial.IsOpen Then
            Linea1 = Chr(27) + "!" + Chr(32) + Linea1
            serial.WriteLine(Linea1)
            Linea2 = Chr(27) + "!" + Chr(1) + Linea2
            serial.WriteLine(Linea2)
            serial.WriteLine(Linea3)
            serial.WriteLine("----------------------------------------")
            '    Fech = Date.Today
            '   Fech = Format(Date.Today, "dd/MM/yy")
            FcD = Date.Today
            FcD = Format(Date.Today, "dd/MM/yy")
            serial.WriteLine("Fecha: " + FcD + "              TICKET")
            NumFac = "N:" + Clave
            NumFac = (NumFac.PadLeft(40))  ' Displays "BBQ and Slaw".
            serial.WriteLine(NumFac)
            serial.WriteLine("----------------------------------------")
            If TxtCli.Text = "" Then
            Else
                serial.WriteLine(Trim(TxtCli.Text))
                serial.WriteLine(Trim(TxtDir.Text))
                serial.WriteLine(Trim(TxtCiudad.Text))
                serial.WriteLine("----------------------------------------")
            End If
            'imprimo  los Items
            Dim filas As Integer = Dtgart.Rows.Count
            Dim contador As Integer = 0
            For i As Integer = 0 To filas - 1
                If IsDBNull(Convert.ToString(Dtgart(0, i).Value)) Then
                Else
                    Articulo = Mid(Convert.ToString(Dtgart(0, i).Value), 1, 30)
                End If

                If IsDBNull(Convert.ToString(Dtgart(1, i).Value)) Then
                Else
                    PunIm = Mid(Convert.ToString(Dtgart(1, i).Value), 1, 5)
                    Punit1 = Mid(Convert.ToString(Dtgart(1, i).Value), 1, 5)
                End If
                If IsDBNull(Convert.ToString(Dtgart(2, i).Value)) Then
                Else
                    CanIm = Convert.ToString(Dtgart(2, i).Value)
                    Canti = Convert.ToString(Dtgart(2, i).Value)
                End If
                If IsDBNull(Convert.ToString(Dtgart(4, i).Value)) Then
                Else
                    PtoIm = Mid(Convert.ToString(Dtgart(4, i).Value), 1, 7)
                    Ptotal = Convert.ToDecimal(Dtgart(4, i).Value)
                End If
                'formato Cantidad
                If Canti < 10 Then
                    CanIm = Mid(CanIm, 1, 4)
                ElseIf Canti >= 10 And Canti <= 100 Then
                    CanIm = Mid(CanIm, 1, 5)
                ElseIf Canti > 100 And Canti <= 1000 Then
                    CanIm = Mid(CanIm, 1, 6)
                ElseIf Canti > 1000 And Canti <= 10000 Then
                    CanIm = Mid(CanIm, 1, 7)
                ElseIf Canti > 10000 And Canti <= 100000 Then
                    CanIm = Mid(CanIm, 1, 8)
                End If
                'Formato P.Unitario
                If Punit1 < 10 Then
                    PunIm = Mid(PunIm, 1, 4)
                ElseIf Punit1 > 10 And Punit1 <= 100 Then
                    PunIm = Mid(PunIm, 1, 6)
                ElseIf Punit1 > 100 And Punit1 <= 1000 Then
                    PunIm = Mid(PunIm, 1, 7)
                ElseIf Punit1 > 1000 And Punit1 <= 10000 Then
                    PunIm = Mid(PunIm, 1, 8)
                ElseIf Punit1 > 10000 And Punit1 <= 100000 Then
                    PunIm = Mid(CanIm, 1, 11)
                End If
                'TxtTo.Text = PtoIm
                'TxtTo.TextAlign = HorizontalAlignment.Right
                'TxtTo.Text = (PtoIm.PadLeft(10))  ' Displays "BBQ and Slaw".
                'Formato P.Total
                If Ptotal < 10 Then
                    PtoIm = Mid(PtoIm, 1, 4)
                ElseIf Ptotal > 10 And Ptotal <= 100 Then
                    PtoIm = Mid(PtoIm, 1, 5)
                ElseIf Ptotal > 100 And Ptotal <= 1000 Then
                    PtoIm = Mid(PtoIm, 1, 6)
                ElseIf Ptotal > 1000 And Ptotal <= 10000 Then
                    PtoIm = Mid(PtoIm, 1, 7)
                ElseIf Ptotal > 10000 And Ptotal <= 100000 Then
                    PtoIm = Mid(PtoIm, 1, 8)
                End If
                'TxtTo.Text = (PtoIm.PadLeft(10))  ' Displays "BBQ and Slaw".
                TxtTo.Text = (PtoIm.PadLeft(10))  ' Displays "BBQ and Slaw".
                'TxtTo.TextAlign = HorizontalAlignment.Right
                Item = CanIm + "X" + PunIm
                Item1 = Articulo + TxtTo.Text
                serial.WriteLine(Item)
                serial.WriteLine(Item1)
            Next
            ' End If
            serial.WriteLine("")
            'Total del comprrobante

            misdatos = MiClase.traedataset("select sum(ptotalm) from t_detalfac where idpc=" & Pc & "")
            TotNeg = FormatNumber(misdatos.Tables(0).Rows(0).Item(0), 2)
            TotCom = FormatNumber(misdatos.Tables(0).Rows(0).Item(0), 2)
            TotNeg = (TotNeg.PadLeft(9))  ' Displays "BBQ and Slaw".
            CerrNeg = "TOTAL :" + TotNeg
            CerrNeg = Chr(27) + "!" + Chr(32) + CerrNeg
            serial.WriteLine(CerrNeg)
            'ingreso de dinero
            If EsVenta = 1 Then
                Recibi = 0
                TotVuel = 0
                EntCom = 0
                TotCom = 0
            Else
                misdatos = MiClase.traedataset("select sum(importe) from tpago where pc=" & Pc & "")
                Recibi = FormatNumber(misdatos.Tables(0).Rows(0).Item(0), 2)
                EntCom = FormatNumber(misdatos.Tables(0).Rows(0).Item(0), 2)
            End If
            Recibi = (Recibi.PadLeft(29))  ' Displays "BBQ and Slaw".
            CerRec = "RECIBIMOS :" + Recibi
            CerRec = Chr(27) + "!" + Chr(1) + CerRec
            serial.WriteLine(CerRec)
            'Vuelto

            Vuelto = EntCom - TotCom
            TotVuel = Str(Vuelto)
            TotVuel = (TotVuel.PadLeft(32))  ' Displays "BBQ and Slaw".
            CerVuel = "Vuelto :" + TotVuel
            serial.WriteLine(CerVuel)

            serial.WriteLine("Cond.de Venta :" + Cventa)
            serial.WriteLine("Cajero :" + UsuCar)
            serial.WriteLine("*Gracias Por Su Compra*")
            Scmd = Chr(29) & Chr(86) & Chr(66) & Chr(1)
            serial.WriteLine(Scmd)
            serial.Close()
        End If
        
    End Sub
    Private Sub FacHasFm()
        If IdCiva = 1 Or IdCiva = 3 Or IdCiva = 4 Then
            Dcuit = Mid(MskCuit.Text, 13, 1)
            Mcuit = Mid(MskCuit.Text, 4, 8)
            Icuit = Mid(MskCuit.Text, 1, 2)
            Cuit = Icuit + Mcuit + Dcuit
        ElseIf IdCiva = 5 Then
            Dcuit = Mid(MskCuit.Text, 8, 3)
            Mcuit = Mid(MskCuit.Text, 4, 3)
            Icuit = Mid(MskCuit.Text, 1, 2)
            Cuit = Icuit + Mcuit + Dcuit
        End If

        If IdCiva = 1 Then
            IdIv = "I"
            TipDoc = "C"
            LetrCierr = "A"
        ElseIf IdCiva = 3 Then
            IdIv = "E"
            TipDoc = "C"
            LetrCierr = "B"
        ElseIf IdCiva = 4 Then
            IdIv = "M"
            TipDoc = "C"
            LetrCierr = "B"
        ElseIf IdCiva = 5 Then
            IdIv = "C"
            TipDoc = "2"
            LetrCierr = "B"
        End If
        nError = Ihasar.IF_OPEN(PuerImp, 9600)
        Ihasar.SerialNumber = "27-0163848-435"
        Ihasar.Printer = "h321"
        Cliente = Mid(Trim(TxtCli.Text), 1, 50)
        Direccion = Mid(Trim(TxtDir.Text) + " - " + Trim(TxtCiudad.Text), 1, 40)
        For nError As Integer = -1 To 0
            nError = Ihasar.IF_WRITE("@SetCustomerData|'" & Cliente & "'|" & Cuit & "|" & IdIv & "|" & TipDoc & "|" & Direccion & "")
            RespHasar2()
            RespHasar1()
        Next
        For nError As Integer = -1 To 0
            If nError = 0 Then
                If CmbMenu.Text = "Factura" Then
                    nError = Ihasar.IF_WRITE("@OpenFiscalReceipt|" & LetrCierr & "|T")
                    RespHasar1()
                    RespHasar2()
                ElseIf CmbMenu.Text = "Nota De Credito" Then
                    If TxtNCr.Text = "" Then
                        Mensaje = MsgBox("Tiene que Ingresar el Numero de Factura Original", MsgBoxStyle.YesNo, "Falta Informacion!!!")
                        If Mensaje = MsgBoxResult.Ok Then
                            TxtNCr.Focus()
                        End If
                    Else
                        nError = Ihasar.IF_WRITE("@SetEmbarkNumber|1|" & TxtNCr.Text & "")
                    End If
                    If IdCiva = 1 Then
                        letrNc = "R"
                    Else
                        letrNc = "S"
                    End If
                    nError = Ihasar.IF_WRITE("@OpenDNFH|" & letrNc & "|T")
                    RespHasar1()
                    RespHasar2()
                End If
            End If
        Next
        'Cargo el Item
        ' Agrego detalles de cada item de la factura:
        If nError = 0 Then
            Dim fil As Integer = Dtgart.Rows.Count
            Dim contador As Integer = 0
            For i As Integer = 0 To fil - 1
                If IsDBNull(Convert.ToString(Dtgart(0, i).Value)) Then
                Else
                    Articulo = Mid(Trim(Convert.ToString(Dtgart(0, i).Value)), 1, 20)
                End If

                If IsDBNull(Convert.ToString(Dtgart(1, i).Value)) Then
                Else
                    Punt = Convert.ToDecimal(Dtgart(1, i).Value)
                End If

                If IsDBNull(Convert.ToString(Dtgart(2, i).Value)) Then
                Else
                    Cantidad = Convert.ToDecimal(Dtgart(2, i).Value)
                End If
                If IsDBNull(Convert.ToString(Dtgart(3, i).Value)) Then
                Else
                    Descu = Convert.ToDecimal(Dtgart(3, i).Value)
                End If
                If IsDBNull(Convert.ToString(Dtgart(4, i).Value)) Then
                Else
                    Ptotal = Convert.ToDecimal(Dtgart(4, i).Value)
                End If
                If IsDBNull(Convert.ToString(Dtgart(5, i).Value)) Then
                Else
                    LinCom = (Dtgart(5, i).Value)
                End If
                If IsDBNull(Convert.ToString(Dtgart(6, i).Value)) Then
                Else
                    BarFac = Convert.ToString((Dtgart(6, i).Value))
                End If
                If IsDBNull(Convert.ToString(Dtgart(10, i).Value)) Then
                Else
                    Alic1 = Convert.ToDouble(Dtgart(10, i).Value)
                End If
                If IsDBNull(Convert.ToString(Dtgart(11, i).Value)) Then
                Else
                    IdAlic = Convert.ToDecimal(Dtgart(11, i).Value)
                End If
                For nError As Integer = -1 To 0
                    alic = Alic1 * "1.00"
                    nError = Ihasar.IF_WRITE("@PrintLineItem|" & Articulo & "|" & Cantidad & "|" & Punt & "|" & alic & "|M|0.0|1|T")
                    If Descu > 0 Then
                        TotDesc = Ptotal * Descu / 100
                        nError = Ihasar.IF_WRITE("@LastItemDiscount|Descuento % " & FormatNumber(Descu, 2) & " |" & TotDesc & "|m|0|T")
                    End If
                    RespHasar1()
                    RespHasar2()
                Next
            Next
        End If
        'Cierro la Factura
        For nError As Integer = -1 To 0
            If nError = 0 Then
                If CmbMenu.Text = "Factura" Then
                    If IdCom = 5 Then
                        'facturo la financiacion
                        Dim TotCta1 As Decimal
                        misdatos = MiClase.traedataset("select isnull(sum(importe),0) from tcuotas where pc=" & Pc & "")
                        TotCta = FormatNumber(misdatos.Tables(0).Rows(0).Item(0))
                        TotCta1 = TotCta - txtTotal.Text

                        ' nError = Ihasar.IF_WRITE("@PrintLineItem|" & Articulo & "|" & Cantidad & "|" & Punt & "|" & alic & "|M|0.0|1|T")
                        nError = Ihasar.IF_WRITE("@LastItemDiscount|Recargo por Financiacion  |" & TotCta1 & "|M|0|T")
                    End If


                    Dim Descgral As Decimal
                    Dim TotDesG As Decimal
                    If MskDescGral.Text = "" Then
                        MskDescGral.Text = "0"
                    End If
                    Descgral = MskDescGral.Text
                    nError = Ihasar.IF_WRITE("@Subtotal|P|Texto|0")
                    TotDesG = (Convert.ToDecimal(Ihasar.IF_READ(4)))
                    If Descgral > 0 Then
                        TotDesG = FormatNumber(TotDesG * Descgral / 100, 2)
                        nError = Ihasar.IF_WRITE("@GeneralDiscount|Descuento General|" & TotDesG & "|m|0|T")
                    End If
                    nError = Ihasar.IF_WRITE("@Subtotal|P|Texto|0")
                    ToTT = (Convert.ToDecimal(Ihasar.IF_READ(4)))
                    IvT = (Convert.ToDecimal(Ihasar.IF_READ(5)))
                    NetT = ToTT - IvT
                    nError = Ihasar.IF_WRITE("@SetHeaderTrailer|12|Cond.de Venta : " & Cventa & "")
                    nError = Ihasar.IF_WRITE("@TotalTender|Efectivo|" & MskImp.Text & "|T|0")
                    nError = Ihasar.IF_WRITE("@CloseFiscalReceipt")
                    RespHasar1()
                    RespHasar2()
                    If IdCiva = 1 Then
                        tipo_cbte = 1
                    Else
                        tipo_cbte = 6
                    End If
                    'cbte_nro = (CStr(Ihasar.IF_READ(3)))
                    'nError = Ihasar.IF_WRITE("@GetDateTime|")
                    'fecha = (CStr(Ihasar.IF_READ(3)))
                ElseIf CmbMenu.Text = "Nota De Credito" Then
                    If IdCiva = 1 Then
                        tipo_cbte = 3
                    Else
                        tipo_cbte = 8
                    End If
                    nError = Ihasar.IF_WRITE("@Subtotal|P|Texto|0")
                    ToTT = (Convert.ToDecimal(Ihasar.IF_READ(4)) * -1)
                    IvT = (Convert.ToDecimal(Ihasar.IF_READ(5)) * -1)
                    NetT = ToTT - IvT
                    nError = Ihasar.IF_WRITE("@CloseDNFH")
                End If
                cbte_nro = (CStr(Ihasar.IF_READ(3)))
                NCom = (CStr(Ihasar.IF_READ(3)))
                nError = Ihasar.IF_WRITE("@GetDateTime|")
                fecha = (CStr(Ihasar.IF_READ(3)))
                nError = Ihasar.IF_WRITE("@Getinitdata|")
                Pv = (CStr(Ihasar.IF_READ(7)))
                Clave = Pv + "-" + cbte_nro
                Guar_Fac()
                CtaCuo()
                nError = Ihasar.IF_CLOSE()
                Blanquear()
                TxtArticulo.Focus()
            End If
        Next
    End Sub
    Private Sub CtaCuo()
        If CmbMenu.Text = "Nota De Credito" And EsVenta = 1 Then
            'Dim EntCta As Decimal
            'Dim SalCta As Decimal
            EntNc = txtTotal.Text
            'EntNc = Decimal.Parse(txtTotal.Text, System.Globalization.CultureInfo.GetCultureInfo("es-us"))
            Dim filas As Integer = DtgNc.Rows.Count
            For i As Integer = 0 To filas - 1
                If IsDBNull(Convert.ToString(DtgNc(0, i).Value)) Then
                Else
                    Lnum = Trim(Convert.ToString(DtgNc(0, i).Value))
                End If
                If IsDBNull(Convert.ToString(DtgNc(1, i).Value)) Then
                Else
                    'fecha = Convert.ToString(DtgNc(1, i).Value)
                End If
                If IsDBNull(Convert.ToString(DtgNc(2, i).Value)) Then
                Else
                    importe = Convert.ToDecimal(DtgNc(2, i).Value)
                End If
                If IsDBNull(Convert.ToString(DtgNc(3, i).Value)) Then
                Else
                    Entrega = Convert.ToDecimal(DtgNc(3, i).Value)
                End If
                If IsDBNull(DtgNc(4, i).Value) Then
                Else
                    Saldo = Convert.ToDecimal(DtgNc(4, i).Value)
                End If
                If IsDBNull(Convert.ToString(DtgNc(5, i).Value)) Then
                Else
                    NumFac = Convert.ToString(DtgNc(5, i).Value)
                End If
                If IsDBNull(Convert.ToString(DtgNc(6, i).Value)) Then
                Else
                    IdTp = Convert.ToDouble(DtgNc(6, i).Value)
                End If
                If IsDBNull(Convert.ToString(DtgNc(7, i).Value)) Then
                Else
                    Cuota = Convert.ToDecimal(DtgNc(7, i).Value)
                End If
                If IsDBNull(Convert.ToString(DtgNc(9, i).Value)) Then
                Else
                    IdCl1 = Convert.ToString(DtgNc(9, i).Value)
                End If
                If EntNc >= Saldo Then
                    EntNc = EntNc - Saldo
                    Saldo = 0
                    MiClase.eliminaactualizaregistra("update ctacte set saldo=" & Str(Saldo) & " where numero=" & NumFac & " and idtp=" & IdTp & " and cuota=" & Cuota & "")
                ElseIf EntNc < Saldo Then
                    Saldo = Saldo - EntNc
                    EntNc = 0
                    MiClase.eliminaactualizaregistra("update ctacte set saldo=" & Str(Saldo) & " where numero=" & NumFac & " and idtp=" & IdTp & " and cuota=" & Cuota & "")
                End If
            Next
        End If

        'Grabo para la Cuenta Corriente

        If EsVenta = 1 And CmbMenu.Text = "Factura" And IdCom = 4 Then
            ' Dim TotFac As Decimal
            ' TotFac = txtTotal.Text
            'TotFac = Decimal.Parse(txtTotal.Text, System.Globalization.CultureInfo.GetCultureInfo("es-es"))
            VenCuo = (DateAdd(DateInterval.Day, 30, DtcFech.Value))
            misdatos = MiClase.traedataset("select fecha from facturas where numero=" & cbte_nro & " and idtp=" & tipo_cbte & "")
            DtcFech.Value = misdatos.Tables(0).Rows(0).Item(0)
            VenCuo = DateAdd(DateInterval.Month, 1, DtcFech.Value)
            FcD = VenCuo
            FcD = Format(VenCuo, "dd/MM/yy")
            MiClase.eliminaactualizaregistra("insert into ctacte values(" & cbte_nro & "," & tipo_cbte & "," & NumCuo & ", " & _
             "" & Idcl & "," & IdEnc & ",'" & fecha & "','" & FcD & "'," & Str(ToTT) & "," & Str(Entrega) & "," & Str(ToTT) & "," & BlNg & ",'" & Clave & "'," & IdUs & ")")
        End If
        If EsVenta = 1 Then
            If MskEntrega.Text = "" Then
                MskEntrega.Text = 0
            End If
            ToTT = ToTT - MskEntrega.Text
            MiClase.eliminaactualizaregistra("insert into fac_cta values(" & cbte_nro & "," & tipo_cbte & ", " & _
            "" & Idcl & ",'" & TxtCli.Text & "','" & TxtDir.Text & "','" & TxtCiudad.Text & "','" & TxtcIva.Text & "','" & fecha & "', " & _
           "" & Str(ToTT) & "," & 0 & "," & Str(ToTT) & ",'" & Clave & "'," & BlNg & "," & IdUs & ")")
            '********************************************
            misdatos = MiClase.traedataset("select isnull( (salcli),0) from clientes where id=" & Idcl & "")
            Saldo = misdatos.Tables(0).Rows(0).Item(0)
            'If txtTotal.Text = "" Then
            'txtTotal.Text = 0
            'End If
            Saldo = Saldo + txtTotal.Text - MskEntrega.Text
            MiClase.eliminaactualizaregistra("update clientes set salcli='" & Str(Saldo) & "'where id=" & Idcl & "")
            If MskEntrega.Text > 0 Then
                Comprobante = "Efectivo"
                ImPag = MskEntrega.Text
                NumPag = 0
                MiClase.eliminaactualizaregistra("insert into pagos values(" & cbte_nro & "," & 14 & ", " & _
                  "" & Dln & "," & Idcl & "," & IdCom & ",'" & fecha & "','" & Comprobante & "'," & NumPag & "," & ImPag & ", " & _
                  "" & 1 & "," & BlNg & "," & Pc & ")")
            End If
            If IdCom = 5 Then
                ImpCuot()
            End If
        End If
        Dln = 0
        IdCom = 1
    End Sub
    Private Sub RespEpson1()
        Dim VAR As Integer
        'ciclo para respuesta impresor
        Vf = 16
        For VAR = Vf To Vi Step -1
            Prns = ifiscal.IF_ERROR1(VAR)
            If VAR = 15 And Prns = 1 Then
                MsgBox("Impresora sin papel,Hata que no Coloque papel no podra Emitir Comprobante", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Impresora sin papel")
            ElseIf VAR = 13 And Prns = 1 Then
                MsgBox("Gaveta de dinero abierta", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Cierre la Gaveta")
            ElseIf VAR = 12 And Prns = 1 Then
                MsgBox("Papel validación presente", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Papel para validación presente")
            ElseIf VAR = 11 And Prns = 1 Then
                MsgBox("Toma de hojas para validación preparada", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Toma de hojas para validación preparada")
            ElseIf VAR = 10 And Prns = 1 Then
                MsgBox("Hoja suelta frontal preparada", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Hoja suelta frontal preparada")
            ElseIf VAR = 9 And Prns = 1 Then
                MsgBox("Toma de hojas sueltas frontal preparada", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Toma de hojas sueltas frontal preparada")
            ElseIf VAR = 8 And Prns = 1 Then
                MsgBox("Buffer de impresora vacío", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Buffer de impresora vacío")
            ElseIf VAR = 7 And Prns = 1 Then
                MsgBox("Buffer de impresora lleno", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Buffer de impresora lleno ")
            ElseIf VAR = 6 And Prns = 1 Then
                MsgBox("Poco papel para comprobantes", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Poco papel para comprobantes.")
            ElseIf VAR = 5 And Prns = 1 Then
                MsgBox("Poco papel para la cinta de auditoria", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Poco papel para la cinta de auditoria")
            ElseIf VAR = 4 And Prns = 1 Then
                MsgBox("Impresora fuera de línea", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Impresora fuera de línea")
            ElseIf VAR = 4 And Prns = 1 Then
                MsgBox("Error/falla de impresora", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, " se ha cortado el enlace entre el Controlador Fiscal y la Impresora Fiscal ")
            End If
        Next VAR
    End Sub
    Private Sub RespHasar1()
        Dim VAR As Integer
        'ciclo para respuesta impresor
        Vf = 16
        For VAR = Vf To Vi Step -1
            Prns = Ihasar.IF_ERROR1(VAR)
            If VAR = 15 And Prns = 1 Then
                '        MsgBox("Impresora sin papel,Hata que no Coloque papel no podra Emitir Comprobante", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Impresora sin papel")
            ElseIf VAR = 13 And Prns = 1 Then
                '    MsgBox("Gaveta de dinero abierta", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Cierre la Gaveta")
            ElseIf VAR = 12 And Prns = 1 Then
                '   MsgBox("Papel validación presente", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Papel para validación presente")
            ElseIf VAR = 11 And Prns = 1 Then
                '  MsgBox("Toma de hojas para validación preparada", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Toma de hojas para validación preparada")
            ElseIf VAR = 10 And Prns = 1 Then
                ' MsgBox("Hoja suelta frontal preparada", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Hoja suelta frontal preparada")
            ElseIf VAR = 9 And Prns = 1 Then
                Mensaje = MsgBox("Tapa de impresora abierta", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Toma de hojas sueltas frontal preparada")
            ElseIf VAR = 8 And Prns = 1 Then
                '        MsgBox("Buffer de impresora vacío", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Buffer de impresora vacío")
            ElseIf VAR = 7 And Prns = 1 Then
                Mensaje = MsgBox("Buffer de impresora lleno", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Buffer de impresora lleno ")
            ElseIf VAR = 6 And Prns = 1 Then
                Mensaje = MsgBox("Poco papel para comprobantes", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Poco papel para comprobantes.")
            ElseIf VAR = 5 And Prns = 1 Then
                Mensaje = MsgBox("Poco papel para la cinta de auditoria", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Poco papel para la cinta de auditoria")
            ElseIf VAR = 4 And Prns = 1 Then
                Mensaje = MsgBox("Impresora fuera de línea", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Impresora fuera de línea")
                If Mensaje = MsgBoxResult.Ok Then
                    For prns As Integer = 0 To 1
                        'If VAR = 4 And prns = 1 Then

                        'End If
                    Next
                End If
            ElseIf VAR = 3 And Prns = 1 Then
                Mensaje = MsgBox("Error/falla de impresora", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, " se ha cortado el enlace entre el Controlador Fiscal y la Impresora Fiscal ")
                If Mensaje = MsgBoxResult.Ok Then
                    ' For prns As Integer = 0 To 1

                    ' Next
                End If
            End If
        Next VAR
    End Sub
    Private Sub RespHasar2()
        Dim VAR As Integer
        Vf = 16
        'Ciclo para respuestas fiscales
        For VAR = Vf To Vi Step -1
            Fis = Ihasar.IF_ERROR2(VAR)
            If VAR = 12 And Fis = 1 Then
                MsgBox("Error en ingreso de fecha", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Lame al Servicio Tecnico")
                If Mensaje = MsgBoxResult.Ok Then
                    TxtArticulo.Focus()
                    nError = -1
                End If
            ElseIf VAR = 9 And Fis = 1 Then
                Mensaje = MsgBox("La Memoria Esta a Punto de llenarse", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Llame al Servicio Tecnico")
            ElseIf VAR = 8 And Fis = 1 Then
                Mensaje = MsgBox("La memoria fiscal Esta llena, esta Bloqueada o dada de baja", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Llame al Servicio Tecnico")
            ElseIf VAR = 7 And Fis = 1 Then
                Mensaje = MsgBox("Desbordamiento de Totales", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Desbordamiento de Totales")
            ElseIf VAR = 6 And Fis = 1 Then
                Mensaje = MsgBox("Comando no Valido para Estado Fiscal", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "No Esta enviando datos Correctos")
                If Mensaje = MsgBoxResult.Ok Then
                    nError = Ihasar.IF_WRITE("@Cancel|")
                End If
            ElseIf VAR = 5 And Fis = 1 Then
                Mensaje = MsgBox(" Campo de datos Inválido. (ej. datos no numéricos en un campo numérico)", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Faltan datos en algun campo")
                If Mensaje = MsgBoxResult.Ok Then
                    If Mensaje = MsgBoxResult.Ok Then
                        nError = Ihasar.IF_WRITE("@Cancel|")
                    End If
                End If
            ElseIf VAR = 4 And Fis = 1 Then
                Mensaje = MsgBox("Comando No Reconocido por el Impresor Fiscal", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Comando No Reconocido")
                If Mensaje = MsgBoxResult.Ok Then
                    If Mensaje = MsgBoxResult.Ok Then
                        nError = Ihasar.IF_WRITE("@Cancel|")
                    End If
                End If
            ElseIf VAR = 3 And Fis = 1 Then
                Mensaje = MsgBox("La batería que alimenta la Memoria de Trabajo y el Reloj de Tiempo Real está baja. Se debe llamar al Técnico Fiscal antes de los 30 días", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Llame al Servicio Tecnico")
            ElseIf VAR = 2 And Fis = 1 Then
                Mensaje = MsgBox("Error en chequeo de memoria de trabajo", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Llame al Servicio Tecnico")
            ElseIf VAR = 1 And Fis = 1 Then
                Mensaje = MsgBox("Error en chequeo de memoria fiscal", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Llame al Servicio Tecnico")
            End If
        Next VAR
    End Sub
    Private Sub RespEpson2()
        Dim VAR As Integer
        Vf = 16
        'Ciclo para respuestas fiscales
        For VAR = Vf To Vi Step -1
            Fis = ifiscal.IF_ERROR2(VAR)
            If VAR = 12 And Fis = 1 Then
                MsgBox("Necesita hacerse un cierre de la Jornada Fiscal ya que han pasado 24 horas sin realizar un cierre ‘Z’", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Llame al Servicio Tecnico")
                If Mensaje = MsgBoxResult.Ok Then
                    TxtArticulo.Focus()
                End If
            ElseIf VAR = 9 And Fis = 1 Then
                MsgBox("La Memoria Esta a Punto de llenarse", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Llame al Servicio Tecnico")
            ElseIf VAR = 8 And Fis = 1 Then
                MsgBox("La memoria fiscal Esta llena", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Llame al Servicio Tecnico")
            ElseIf VAR = 7 And Fis = 1 Then
                MsgBox("Desbordamiento de Totales", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Desbordamiento de Totales")
            ElseIf VAR = 6 And Fis = 1 Then
                MsgBox("Comando no Valido para Estado Fiscal", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "No Esta enviando datos Correctos")
            ElseIf VAR = 5 And Fis = 1 Then
                MsgBox(" Un campo de datos del comando recibido del Host tenía datos no válidos (ej. datos no numéricos en un campo numérico)", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Faltan datos en algun campo")
            ElseIf VAR = 4 And Fis = 1 Then
                MsgBox("Comando No Reconocido por el Impresor Fiscal", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Comando No Reconocido")
                MsgBox(" Un campo de datos del comando recibido del Host tenía datos no válidos (ej. datos no numéricos en un campo numérico)", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Faltan datos en algun campo")
            ElseIf VAR = 3 And Fis = 1 Then
                MsgBox("La batería que alimenta la Memoria de Trabajo y el Reloj de Tiempo Real está baja. Se debe llamar al Técnico Fiscal antes de los 30 días", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Llame al Servicio Tecnico")
            ElseIf VAR = 2 And Fis = 1 Then
                MsgBox("Error de Comprobación de Memoria de Trabajo. En el encendido fracasó la verificación de suma de la Memoria de Trabajo. No funcionará el Impresor Fiscal", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Llame al Servicio Tecnico")
            ElseIf VAR = 1 And Fis = 1 Then
                MsgBox("Error de comprobación de Memoria Fiscal. En el encendido, fracasó la verificación de suma dela Memoria Fiscal. No funcionará el Impresor Fiscal", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Llame al Servicio Tecnico")
            End If
        Next VAR
        
    End Sub
    Private Sub FacHasar()
        If IdCiva = 1 Or IdCiva = 3 Or IdCiva = 4 Then
            Dcuit = Mid(MskCuit.Text, 13, 1)
            Mcuit = Mid(MskCuit.Text, 4, 8)
            Icuit = Mid(MskCuit.Text, 1, 2)
            Cuit = Icuit + Mcuit + Dcuit
        ElseIf IdCiva = 5 Then
            Dcuit = Mid(MskCuit.Text, 8, 3)
            Mcuit = Mid(MskCuit.Text, 4, 3)
            Icuit = Mid(MskCuit.Text, 1, 2)
            Cuit = Icuit + Mcuit + Dcuit
        End If

        If IdCiva = 1 Then
            IdIv = "I"
            TipDoc = "C"
            LetrCierr = "A"
        ElseIf IdCiva = 3 Then
            IdIv = "E"
            TipDoc = "C"
            LetrCierr = "B"
        ElseIf IdCiva = 4 Then
            IdIv = "M"
            TipDoc = "C"
            LetrCierr = "B"
        ElseIf IdCiva = 5 Then
            IdIv = "C"
            TipDoc = "2"
            LetrCierr = "B"
        End If
        If LetrCierr = "" Then
            LetrCierr = "B"
        End If
        nError = Ihasar.IF_OPEN(PuerImp, 9600)
        Ihasar.SerialNumber = "27-0163848-435"
        Ihasar.Printer = "h715"
        Cliente = Mid(Trim(TxtCli.Text), 1, 30)
        Direccion = Mid(Trim(TxtDir.Text) + " - " + Trim(TxtCiudad.Text), 1, 40)
        If TxtCli.Text = "" Then
        Else
            nError = Ihasar.IF_WRITE("@SetCustomerData|'" & Cliente & "'|" & Cuit & "|" & IdIv & "|" & TipDoc & "|" & Direccion & "")
        End If
        RespHasar2()
        RespHasar1()

        If nError = 0 Then
            If CmbMenu.Text = "Factura" Then
                nError = Ihasar.IF_WRITE("@OpenFiscalReceipt|" & LetrCierr & "|T")
                RespHasar1()
                RespHasar2()
            ElseIf CmbMenu.Text = "Nota De Credito" Then
                If TxtNCr.Text = "" Then
                    Mensaje = MsgBox("Tiene que Ingresar el Numero de Factura Original", MsgBoxStyle.YesNo, "Falta Informacion!!!")
                    If Mensaje = MsgBoxResult.Ok Then
                        TxtNCr.Focus()
                    End If
                Else
                    nError = Ihasar.IF_WRITE("@SetEmbarkNumber|1|" & TxtNCr.Text & "")
                End If
                If IdCiva = 1 Then
                    letrNc = "R"
                Else
                    letrNc = "S"
                End If
                nError = Ihasar.IF_WRITE("@OpenDNFH|" & letrNc & "|T")
                RespHasar1()
                RespHasar2()
            End If
        End If
        'Cargo el Item
        ' Agrego detalles de cada item de la factura:
        If nError = 0 Then
            Dim fil As Integer = Dtgart.Rows.Count
            Dim contador As Integer = 0
            For i As Integer = 0 To fil - 1
                If IsDBNull(Convert.ToString(Dtgart(0, i).Value)) Then
                Else
                    Articulo = Mid(Trim(Convert.ToString(Dtgart(0, i).Value)), 1, 50)
                End If

                If IsDBNull(Convert.ToString(Dtgart(1, i).Value)) Then
                Else
                    Punt = Convert.ToDecimal(Dtgart(1, i).Value)
                End If

                If IsDBNull(Convert.ToString(Dtgart(2, i).Value)) Then
                Else
                    Cantidad = Convert.ToDecimal(Dtgart(2, i).Value)
                End If
                If IsDBNull(Convert.ToString(Dtgart(3, i).Value)) Then
                Else
                    Descu = Convert.ToDecimal(Dtgart(3, i).Value)
                End If
                If IsDBNull(Convert.ToString(Dtgart(4, i).Value)) Then
                Else
                    Ptotal = Convert.ToDecimal(Dtgart(4, i).Value)
                End If
                If IsDBNull(Convert.ToString(Dtgart(4, i).Value)) Then
                Else
                    LinCom = (Dtgart(4, i).Value)
                End If
                If IsDBNull(Convert.ToString(Dtgart(5, i).Value)) Then
                Else
                    BarFac = Convert.ToString((Dtgart(5, i).Value))
                End If
                If IsDBNull(Convert.ToString(Dtgart(9, i).Value)) Then
                Else
                    Alic1 = Convert.ToDouble(Dtgart(9, i).Value)
                End If
                If IsDBNull(Convert.ToString(Dtgart(10, i).Value)) Then
                Else
                    IdAlic = Convert.ToDecimal(Dtgart(10, i).Value)
                End If
                Articulo = Mid(Trim(Articulo), 1, 20)
                nError = Ihasar.IF_WRITE("@PrintLineItem|" & Articulo & "|" & Cantidad & "|" & Punt & "|" & IdAlic & "|M|0.0|0|T")
                If Descu > 0 Then
                    TotDesc = Ptotal * Descu / 100
                    nError = Ihasar.IF_WRITE("@LastItemDiscount|Descuento % " & FormatNumber(Descu, 2) & " |" & TotDesc & "|m|0|T")
                End If
                RespHasar1()
                RespHasar2()
            Next
        End If
        'Cierro la Factura
        If nError = 0 Then
            If CmbMenu.Text = "Factura" Then
                Dim Descgral As Decimal
                Dim TotDesG As Decimal
                If MskDescGral.Text = "" Then
                    MskDescGral.Text = "0"
                End If
                ' Descgral = MskDescGral.Text
                Descgral = MskDescGral.Text
                'Descgral = Decimal.Parse(MskDescGral.Text, System.Globalization.CultureInfo.GetCultureInfo("es-us"))
                nError = Ihasar.IF_WRITE("@Subtotal|P|Texto|0")

                ' Dim TotDesg1 As Decimal
                TxtTot.Text = (Convert.ToString(Ihasar.IF_READ(4)))
                'TotDesG = Decimal.Parse(TxtTot.Text, System.Globalization.CultureInfo.GetCultureInfo("es-us"))
                TotDesG = TxtTot.Text
                If Descgral > 0 Then
                    TotDesG = TotDesG * Descgral / 100
                    ' MskDescGral.Text = " % " + MskDescGral.Text
                    nError = Ihasar.IF_WRITE("@GeneralDiscount|Descuento|" & TotDesG & "|m|0|T")
                End If

                nError = Ihasar.IF_WRITE("@Subtotal|P|Texto|0")
                ToTT = Ihasar.IF_READ(4)
                IvT = Ihasar.IF_READ(5)
                NetT = ToTT - IvT
                nError = Ihasar.IF_WRITE("@SetHeaderTrailer|12|Cond.de Venta : " & Cventa & "")
                nError = Ihasar.IF_WRITE("@SetHeaderTrailer|13|Usuario : " & UsuCar & "")
                'nError = Ihasar.IF_WRITE("@TotalTender|Efectivo|200.0|T|0")
                '        Dim Vuelto As String
                '       Vuelto = CDec(Ihasar.IF_READ(2)) 'If EsVenta = 1 Then
                'misdatos = MiClase.traedataset("select linea13,linea14 from configuracion where pc=" & Pc & "")
                'Linea13 = misdatos.Tables(0).Rows(0).Item(0)
                'Linea14 = misdatos.Tables(0).Rows(0).Item(1)
                'ElseIf EsVenta = 0 Then
                '   Linea13 = ""
                '  Linea14 = ""
                'End If
                'nError = Ihasar.IF_WRITE("@SetHeaderTrailer|13|" & Linea13 & "")
                'nError = Ihasar.IF_WRITE("@SetHeaderTrailer|14|" & Linea14 & "")
                'nError = Ihasar.IF_WRITE("@TotalTender|Efectivo|" & MskImp.Text & "|T|0")
                ' misdatos = MiClase.traedataset("select sum(total) from tpago where pc=" & Pc & "")
                ' TotDesG = FormatNumber(misdatos.Tables(0).Rows(0).Item(0), 2)
                'nError = Ihasar.IF_WRITE("@Subtotal|P|Subtotal|0|")
                '  TotCom = 50.0
                ' Dim Vuelto As String
                'Vuelto = CDec(Ihasar.IF_READ(3)) 'If EsVenta = 1 Then
                'nError = Ihasar.IF_WRITE("@TotalTender|Efectivo|" & TotCom & "|T|0")
                'Vuelto = CDec(Ihasar.IF_READ(3))
                nError = Ihasar.IF_WRITE("@CloseFiscalReceipt")
                RespHasar1()
                RespHasar2()
                If IdCiva = 1 Then
                    tipo_cbte = 1
                Else
                    tipo_cbte = 6
                End If
            ElseIf CmbMenu.Text = "Nota De Credito" Then
                If IdCiva = 1 Then
                    tipo_cbte = 3
                Else
                    tipo_cbte = 8
                End If
                nError = Ihasar.IF_WRITE("@Subtotal|P|Texto|0")
                ToTT = CDec(Ihasar.IF_READ(4) * -1 / 100)
                IvT = CDec(Ihasar.IF_READ(5) * -1 / 100)
                NetT = ToTT - IvT
                nError = Ihasar.IF_WRITE("@CloseDNFH")
            End If
            cbte_nro = (CStr(Ihasar.IF_READ(3)))
            nError = Ihasar.IF_WRITE("@GetDateTime|")
            fecha = (CStr(Ihasar.IF_READ(3)))

            nError = Ihasar.IF_WRITE("@Getinitdata|")
            Pv = (CStr(Ihasar.IF_READ(7)))
            Clave = Pv + "-" + cbte_nro
            Guar_Fac()
            CtaCuo()
            nError = Ihasar.IF_CLOSE()
            Blanquear()
            TxtArticulo.Focus()
        End If
    End Sub
    Private Sub FacEpson()
        'Imprimo la Factura
        If CmbMenu.Text = "Factura" Then
            LetrComp = "T"
        ElseIf CmbMenu.Text = "Nota De Credito" Then
            LetrComp = "M"
        End If
        'If EsCom = 1 Then
        If IdCiva = 1 Or IdCiva = 3 Or IdCiva = 4 Then
            Dcuit = Mid(MskCuit.Text, 13, 1)
            Mcuit = Mid(MskCuit.Text, 4, 8)
            Icuit = Mid(MskCuit.Text, 1, 2)
            Cuit = Icuit + Mcuit + Dcuit
            TipCu = "CUIT"
            If IdCiva = 1 Then
                IdIv = "I"
                LetrCierr = "A"
            ElseIf IdCiva = 3 Then
                IdIv = "M"
                LetrCierr = "B"
            ElseIf IdCiva = 4 Then
                IdIv = "M"
                LetrCierr = "B"
            End If
        ElseIf IdCiva = 5 Then
            Dcuit = Mid(MskCuit.Text, 8, 3)
            Mcuit = Mid(MskCuit.Text, 4, 3)
            Icuit = Mid(MskCuit.Text, 1, 2)
            Cuit = Icuit + Mcuit + Dcuit
            IdIv = "F"
            TipCu = "DNI"
            LetrCierr = "B"
        End If
        nError = ifiscal.IF_OPEN(PuerImp, 9600)
        ifiscal.SerialNumber = "27-0163848-435"
        nError = ifiscal.IF_WRITE("@FACTABRE|" & LetrComp & "|C|A|1|P|10|I|" & IdIv & "|" & TxtCli.Text & "||" & TipCu & "|" & Cuit & "|N|" & TxtDir.Text & "|" & TxtCiudad.Text & " ||||C")
        Prns = ifiscal.IF_ERROR1(16)
        Fis = ifiscal.IF_ERROR2(16)
        If Prns <> 0 Then
            RespEpson1()
        End If
        If Fis <> 0 Then
            RespEpson2()
        End If
        'Cargo el Item
        ' Agrego detalles de cada item de la factura:
        Dim fil As Integer = Dtgart.Rows.Count
        Dim contador As Integer = 0
        For i As Integer = 0 To fil - 1
            If IsDBNull(Convert.ToString(Dtgart(0, i).Value)) Then
            Else
                Articulo = Convert.ToString(Dtgart(0, i).Value)
            End If

            If IsDBNull(Convert.ToString(Dtgart(1, i).Value)) Then
            Else
                Punt = Convert.ToDecimal(Dtgart(1, i).Value)
            End If

            If IsDBNull(Convert.ToString(Dtgart(2, i).Value)) Then
            Else
                Cantidad = Convert.ToDecimal(Dtgart(2, i).Value)
            End If

            If IsDBNull(Convert.ToString(Dtgart(3, i).Value)) Then
            Else
                Ptotal = Convert.ToDecimal(Dtgart(3, i).Value)
            End If
            If IsDBNull(Convert.ToString(Dtgart(4, i).Value)) Then
            Else
                LinCom = (Dtgart(4, i).Value)
            End If
            If IsDBNull(Convert.ToString(Dtgart(5, i).Value)) Then
            Else
                BarFac = Convert.ToString((Dtgart(5, i).Value))
            End If
            If IsDBNull(Convert.ToString(Dtgart(9, i).Value)) Then
            Else
                Alic1 = Convert.ToDouble(Dtgart(9, i).Value)
            End If
            If IsDBNull(Convert.ToString(Dtgart(10, i).Value)) Then
            Else
                IdAlic = Convert.ToDecimal(Dtgart(10, i).Value)
            End If
            If IdCiva = "1" Then
                AlicDisc = Alic1 / 100 + 1
                Punt1 = FormatNumber(Punt / AlicDisc, 2)
            Else
                Punt1 = Punt
            End If
            nError = ifiscal.IF_WRITE("@FACTITEM|" & Articulo & "|" & Cantidad & "|" & Punt1 & "|" & Alic1 & "|M|1|0||||0|0")
            If Fis <> 0 Then
                RespEpson2()
            End If
        Next

        If CmbMenu.Text = "Factura" Then
            nError = ifiscal.IF_WRITE("@FACTPAGO|PAGO|" & MskImp.Text & "|T")
            If Prns <> 0 Then
                RespEpson1()
            End If
            If Fis <> 0 Then
                RespEpson2()
            End If
        End If
        'Dim NN As Decimal
        nError = ifiscal.IF_WRITE("@FACTSUBTOTAL|P|Subtotal")
        ToTT = (Convert.ToDecimal(ifiscal.IF_READ(5)) / 100)
        NetT = (Convert.ToDecimal(ifiscal.IF_READ(10)) / 100)
        IvT = (Convert.ToDecimal(ifiscal.IF_READ(6)) / 100)
        nError = ifiscal.IF_WRITE("@PONEENCABEZADO|11|C.de Venta: " & Cventa & "")
        nError = ifiscal.IF_WRITE("@FACTCIERRA|" & LetrComp & "|" & LetrCierr & "|FINAL")
        cbte_nro = (CStr(ifiscal.IF_READ(3)))
        If Prns <> 0 Then
            RespEpson1()
        End If
        If Fis <> 0 Then
            RespEpson2()
        End If
        nError = ifiscal.IF_WRITE("@PIDEFECHORA|")
        fecha = ifiscal.IF_READ(3)
        nError = ifiscal.IF_WRITE("@ESTADO|C")
        Pv = ifiscal.IF_READ(4)

        'nError = ifiscal.IF_WRITE("@ESTADO|A")
        If CmbMenu.Text = "Factura" Then
            If IdCiva = 1 Then
                tipo_cbte = 1
                nError = ifiscal.IF_WRITE("@ESTADO|A")
                cbte_nro = (CStr(ifiscal.IF_READ(6)))
            Else
                tipo_cbte = 6
                nError = ifiscal.IF_WRITE("@ESTADO|A")
                cbte_nro = (CStr(ifiscal.IF_READ(5)))
            End If
        ElseIf CmbMenu.Text = "Nota De Credito" Then
            '    Punt = Punt * -1
            '   Ptotal = Ptotal * -1
            NetT = NetT * -1
            IvT = IvT * -1
            Iint = Iint * -1
            ToTT = ToTT * -1
            If IdCiva = 1 Then
                tipo_cbte = 3
            Else
                tipo_cbte = 8
            End If
        End If
        Clave = Pv + "-" + cbte_nro
        Guar_Fac()
        CtaCuo()
        nError = ifiscal.IF_CLOSE()
        'End If
    End Sub
    Private Sub FacManual()
        Guar_Fac()
    End Sub
    Private Sub Guar_Fac()
        'Cargo  los Items
        Dim filas As Integer = Dtgart.Rows.Count
        Dim contador As Integer = 0
        For i As Integer = 0 To filas - 1
            'If filas = 0 Then
            'Else
            If IsDBNull(Convert.ToString(Dtgart(0, i).Value)) Then
            Else
                Articulo = Convert.ToString(Dtgart(0, i).Value)
            End If

            If IsDBNull(Convert.ToString(Dtgart(1, i).Value)) Then
            Else
                Punt = Convert.ToDecimal(Dtgart(1, i).Value)
            End If

            If IsDBNull(Convert.ToString(Dtgart(2, i).Value)) Then
            Else
                Cantidad = Convert.ToDecimal(Dtgart(2, i).Value)
            End If
            If IsDBNull(Convert.ToString(Dtgart(3, i).Value)) Then
            Else
                Descu = Convert.ToDecimal(Dtgart(3, i).Value)
            End If

            If IsDBNull(Convert.ToString(Dtgart(4, i).Value)) Then
            Else
                Ptotal = Convert.ToDecimal(Dtgart(4, i).Value)
            End If
            If IsDBNull(Convert.ToString(Dtgart(5, i).Value)) Then
            Else
                LinCom = (Dtgart(5, i).Value)
            End If
            If IsDBNull(Convert.ToString(Dtgart(6, i).Value)) Then
            Else
                BarFac = Convert.ToDecimal(Dtgart(6, i).Value)
            End If
            If IsDBNull(Convert.ToString(Dtgart(7, i).Value)) Then
            Else
                IdPr = Convert.ToDecimal(Dtgart(7, i).Value)
            End If
            If IsDBNull(Convert.ToString(Dtgart(8, i).Value)) Then
            Else
                IdMr = Convert.ToDecimal(Dtgart(8, i).Value)
            End If
            If IsDBNull(Convert.ToString(Dtgart(9, i).Value)) Then
            Else
                IdFm = Convert.ToDecimal(Dtgart(9, i).Value)
            End If
            If IsDBNull(Convert.ToString(Dtgart(10, i).Value)) Then
            Else
                alic = Convert.ToDecimal(Dtgart(10, i).Value)
            End If
            If IsDBNull(Convert.ToString(Dtgart(11, i).Value)) Then
            Else
                IdAlic = Convert.ToDecimal(Dtgart(11, i).Value)
            End If
            If Fact = 1 Or Fact = 2 Then
            Else
                ' Fnum()
            End If
            If CmbMenu.Text = "Nota De Credito" Then
                Punt = Punt * -1
                Ptotal = Ptotal * -1
            End If
            If CmbMenu.Text = "Factura Manual" Then
                If IdCiva = 1 Then
                    tipo_cbte = 1
                Else
                    tipo_cbte = 6
                End If
                Dim DesAic As Decimal
                fecha = DtcFecha.Text
                ToTT = txtTotal.Text
                DesAic = alic / 100 + 1
                NetT = FormatNumber(ToTT / DesAic)
                IvT = FormatNumber(ToTT - NetT)
            End If

            'Grabo el detalle de factura
            MiClase.eliminaactualizaregistra("insert into detal_fac values(" & cbte_nro & "," & tipo_cbte & " ," & LinCom & "," & Pv & ",'" & fecha & "', " & _
            "" & BarFac & ",'" & Articulo & "'," & Str(Punt) & "," & Str(Cantidad) & "," & Str(Ptotal) & "," & IdFm & "," & IdMr & "," & IdPr & ", " & _
           "" & Str(alic) & "," & Idcl & "," & IdEnc & "," & EsVenta & ",'" & Cventa & "'," & IdAlic & "," & BlNg & ",'" & Clave & "'," & IdAct & "," & IdUs & ")")
            LinCom = LinCom + 1
            'Descuento el Stock
            If BarFac = 0 Then
            Else
                Barra = BarFac
                Largo = Len(Barra)
                Primero = Mid(Barra, 1, 1)
                If Largo = 13 And Primero = 2 Then
                Else
                    misdatos = MiClase.traedataset("select isnull((stock),0) from articulos where barra=" & BarFac & "")
                    If CmbMenu.Text = "Remito" Or CmbMenu.Text = "Factura" Then
                        Stock = misdatos.Tables(0).Rows(0).Item(0) - Cantidad
                    ElseIf CmbMenu.Text = "Nota De Credito" And TsNc.Text = "Articulo" Then
                        Stock = misdatos.Tables(0).Rows(0).Item(0) + Cantidad
                    End If
                    MiClase.eliminaactualizaregistra("update articulos set stock = " & Stock & " where barra=" & BarFac & "")
                End If
            End If

        Next
        MiClase.eliminaactualizaregistra("insert into facturas values(" & cbte_nro & "," & tipo_cbte & ", " & _
          "" & Pv & "," & IdEnc & "," & Idcl & ",'" & fecha & "'," & EsVenta & ",'" & Cventa & "'," & Str(NetT) & ", " & _
          "" & Str(IvT) & "," & Str(Iint) & "," & Str(ToTT) & "," & BlNg & "," & Str(alic) & ",'" & fecha & "','" & Clave & "'," & 0 & ", " & _
          "'" & TxtOb.Text & "','" & TxtOb1.Text & "','" & TxtCli.Text & "','" & TxtDir.Text & "','" & TxtCiudad.Text & "'," & _
          "'" & TxtcIva.Text & "','" & MskCuit.Text & "'," & IdCiva & ",'" & Cpostal & "'," & IdPrv & "," & IdUs & ")")
        'Cargo los pagos
        Dim fil As Integer = DtgPag.Rows.Count
        Dim cont As Integer = 0
        For i As Integer = 0 To fil - 1
            If IsDBNull(Convert.ToString(DtgPag(0, i).Value)) Then
            Else
                Comprobante = Trim(Convert.ToString(DtgPag(0, i).Value))
            End If

            If IsDBNull(Convert.ToDouble(DtgPag(1, i).Value)) Then
            Else
                NumPag = Convert.ToDouble(DtgPag(1, i).Value)
            End If
            If IsDBNull(Convert.ToDecimal(DtgPag(2, i).Value)) Then
            Else
                ImPag = Convert.ToDecimal(DtgPag(2, i).Value)
            End If
            If IsDBNull(Convert.ToDouble(DtgPag(3, i).Value)) Then
            Else
                Dln = Convert.ToDouble(DtgPag(3, i).Value)
            End If
            If IsDBNull(Convert.ToDouble(DtgPag(4, i).Value)) Then
            Else
                IdCom = Convert.ToDouble(DtgPag(4, i).Value)
            End If
            If IsDBNull(Convert.ToString(DtgPag(5, i).Value)) Then
            Else
                FechCh = Convert.ToString(DtgPag(5, i).Value)
            End If
            MiClase.eliminaactualizaregistra("insert into pagos values(" & cbte_nro & "," & tipo_cbte & ", " & _
            "" & Dln & "," & Idcl & "," & IdCom & ",'" & fecha & "','" & Comprobante & "'," & NumPag & "," & Str(ImPag) & ", " & _
            "" & 1 & "," & BlNg & "," & Pc & "," & IdUs & ")")
            If IdCom = 3 Then
                MiClase.eliminaactualizaregistra("insert into che_cartera values(" & Idcl & ",'" & TxtCli.Text & "', " & _
                "'" & Comprobante & "'," & NumPag & ",'" & FechCh & "'," & Str(ImPag) & "," & 0 & "," & IdUs & ")")
            End If
        Next
        ' Blanquear()
        'CmbMenu.Text = "Factura"
    End Sub
    Private Sub Cer()
        Console.WriteLine("DEMO Interfaz PyAfipWs WSFEv1 para vb.net")
        ' Crear objeto interface Web Service Autenticación y Autorización
        WSAA = CreateObject("WSAA")
        Console.WriteLine(WSAA.Version)
        'Try
        Console.WriteLine("Generar un Ticket de Requerimiento de Acceso (TRA) para WSFEv1")
        tra = WSAA.CreateTRA("wsfe")
        Console.WriteLine(tra)
        ' Especificar la ubicacion de los archivos certificado y clave privada
        Path = Environment.CurrentDirectory() + "\"
        ' Certificado: certificado es el firmado por la AFIP
        ' ClavePrivada: la clave privada usada para crear el certificado
        misdatos = MiClase.traedataset("select certificado,claveprivada,servidor from configuracion where pc=" & Pc & "")
        Certif = Trim(misdatos.Tables(0).Rows(0).Item(0))
        ClavePiv = Trim(misdatos.Tables(0).Rows(0).Item(1))
        Ser = Trim(misdatos.Tables(0).Rows(0).Item(2))
        'certificado = "\reingart.crt" ' certificado de prueba
        'claveprivada = "\reingart.key" ' clave privada de prueba
        certificado = Certif
        claveprivada = ClavePiv
        Console.WriteLine("Generar el mensaje firmado (CMS)")
        cms = WSAA.SignTRA(tra, Path + certificado, Path + claveprivada)
        Console.WriteLine(cms)
        Console.WriteLine("Llamar al web service para autenticar:")
        If Ser = 0 Then
            proxy = "" '"usuario:clave@localhost:8000"
            wsdl = "https://wsaahomo.afip.gov.ar/ws/services/LoginCms?wsdl"
            WSAA.Conectar(cache, wsdl, proxy) ' Homologación
            ta = WSAA.LoginCMS(cms)
        ElseIf Ser = 1 Then
            proxy = "" '"usuario:clave@localhost:8000"
            wsdl = "https://wsaa.afip.gov.ar/ws/services/LoginCms?wsdl"
            WSAA.Conectar(cache, wsdl, proxy) ' Homologación
            ta = WSAA.LoginCMS(cms)
        End If
        ' Imprimir el ticket de acceso, ToKen y Sign de autorización
        'MsgBox(WSAA.Token, vbInformation, "WSAA Token")
        'MsgBox(WSAA.Sign, vbInformation, "WSAA Sign")
        MiClase.eliminaactualizaregistra("delete from ticket ")
        MiClase.eliminaactualizaregistra("insert into ticket values('" & WSAA.token & "','" & WSAA.sign & "','" & Date.Now & "')")

    End Sub
    Private Sub Crear_Pdf()
        'Crear_Pdf()
        'Creo La Factura
        Dim PyFEPDF As Object
        ' On Error GoTo ManejoErrortr
        'Dim Cbt_nro As Integer
        'Cbt_nro = 1
        Dim Font As String
        Dim Size As Integer

        ' Crear objeto interface para generación de F.E. en PDF
        PyFEPDF = CreateObject("PyFEPDF")
        Debug.Print(PyFEPDF.Version)
        Debug.Print(PyFEPDF.InstallDir)

        ' CUIT del emisor
        PyFEPDF.CUIT = Cuit_Em

        'If IdCiva = "1" Then
        'tipo_cbte = 1
        'Else
        'tipo_cbte = 6       ' Factura A
        'End If
        If EsCom = 1 Then
            If IdCiva = 1 Then
                tipo_cbte = "1"
            Else
                tipo_cbte = "6"
            End If
        ElseIf EsCom = 2 Then
            If IdCiva = 1 Then
                tipo_cbte = "3"
            Else
                tipo_cbte = "8"
            End If


        End If
        'punto_vta = 4000    ' prefijo
        punto_vta = Pv
        ' cbte_nro = 12345678 ' número de factura
        fecha = fecha
        concepto = 3
        ' datos del cliente:
        If IdCiva = 1 Then
            tipo_doc = 80 : nro_doc = MskCuit.Text
        Else
            tipo_doc = 96 : nro_doc = MskCuit.Text
        End If
        Dim Nombre_Cliente, nombre, x1, y1, x2, y2, bonif, despacho, dato_a, dato_b, dato_c, dato_d, dato_e, u_mtx, cod_mtx, codigo, ds, qty, umed, precio, iva_id, idioma_cbte, Domicilio_Cliente, pais_dst_cmp, id_impositivo, descuento, imp_subtotal, obs_generales, obs_comerciales, forma_pago, motivo_obs, incoterms As String
        Dim Cliente_Localidad As String

        Nombre_Cliente = TxtCli.Text
        Domicilio_Cliente = TxtDir.Text
        Cliente_Localidad = TxtCiudad.Text
        pais_dst_cmp = 16 ' código para exportación
        id_impositivo = TxtcIva.Text  '
        ' totales del comprobante:
        misdatos = MiClase.traedataset("select sum(neto),sum(iva),sum(total) from totalic ")
        NetT = misdatos.Tables(0).Rows(0).Item(0)
        IvT = misdatos.Tables(0).Rows(0).Item(1)
        ToTT = misdatos.Tables(0).Rows(0).Item(2)
        If IdCiva = "1" Then
            imp_total = ToTT : imp_tot_conc = "0.00"
            imp_neto = NetT : imp_iva = IvT
            imp_trib = "0.00" : imp_op_ex = "0.00" : imp_subtotal = NetT
            descuento = "0.00"
            fecha_cbte = fecha : fecha_venc_pago = fecha
            ' Fechas del período del servicio facturado
            fecha_serv_desde = fecha : fecha_serv_hasta = fecha
            moneda_id = "PES" : moneda_ctz = "1.000"
        Else
            imp_total = ToTT : imp_tot_conc = "0.00"
            imp_neto = 0 : imp_iva = 0
            imp_trib = "0.00" : imp_op_ex = "0.00" : imp_subtotal = NetT
            descuento = "0.00"
            fecha_cbte = fecha : fecha_venc_pago = fecha
            ' Fechas del período del servicio facturado
            fecha_serv_desde = fecha : fecha_serv_hasta = fecha
            moneda_id = "PES" : moneda_ctz = "1.000"
        End If
        obs_generales = TxtOb.Text
        obs_comerciales = TxtOb1.Text
        moneda_id = "012"
        moneda_ctz = 0.5
        forma_pago = Cventa
        cae = cae
        fecha_vto_cae = VtoCae

        ' Creo la factura (internamente en la interfaz)
        'motivo_obs = 0
        idioma_cbte = "1"
        incoterms = 0


        ok = PyFEPDF.CrearFactura(concepto, tipo_doc, nro_doc, tipo_cbte, punto_vta, cbte_nro, imp_total, imp_tot_conc, imp_neto, imp_iva, imp_trib, imp_op_ex, fecha_cbte, fecha_venc_pago, fecha_serv_desde, fecha_serv_hasta, moneda_id, moneda_ctz, cae, VtoCae, id_impositivo, Nombre_Cliente, Domicilio_Cliente, pais_dst_cmp, obs_comerciales, obs_generales, forma_pago, incoterms, idioma_cbte, motivo_obs, descuento)
        ok = PyFEPDF.EstablecerParametro("localidad_cliente", TxtCiudad.Text)
        'ok = PyFEPDF.EstablecerParametro("provincia_cliente", "Buenos Aires")
        'Acumulo los totales por alicuota
        misdatos = MiClase.traedataset("select isnull(max(id),0) from alic_iva")
        MaxFl = misdatos.Tables(0).Rows(0).Item(0)
        Dim filas As Integer = MaxFl
        For i As Integer = 0 To filas - 1
            misdatos = MiClase.traedataset("select isnull(sum(total),0) from totalic where idiva=" & i & "")
            Tot = misdatos.Tables(0).Rows(0).Item(0)
            If Tot > 0 Then
                misdatos = MiClase.traedataset("select sum(neto),sum(iva),sum(total) from totalic where idiva=" & i & "")
                Net = misdatos.Tables(0).Rows(0).Item(0)
                Iv = misdatos.Tables(0).Rows(0).Item(1)
                Tot = misdatos.Tables(0).Rows(0).Item(2)
                iva_id = i
                base_imp = Net  ' importe neto sujeto a esta alícuota
                importe = Iv    ' importe liquidado de iva
                ok = PyFEPDF.AgregarIva(iva_id, base_imp, importe)
                Net = "0"
                Iv = "0"
            End If

        Next
        ' Agrego detalles de cada item de la factura:
        Dim fil As Integer = Dtgart.Rows.Count
        Dim contador As Integer = 0
        For i As Integer = 0 To fil - 1
            If IsDBNull(Convert.ToString(Dtgart(0, i).Value)) Then
            Else
                Articulo = Convert.ToString(Dtgart(0, i).Value)
            End If

            If IsDBNull(Convert.ToString(Dtgart(1, i).Value)) Then
            Else
                Punt = Convert.ToDecimal(Dtgart(1, i).Value)
            End If

            If IsDBNull(Convert.ToString(Dtgart(2, i).Value)) Then
            Else
                Cantidad = Convert.ToDecimal(Dtgart(2, i).Value)
            End If

            If IsDBNull(Convert.ToString(Dtgart(3, i).Value)) Then
            Else
                Ptotal = Convert.ToDecimal(Dtgart(3, i).Value)
            End If
            If IsDBNull(Convert.ToString(Dtgart(4, i).Value)) Then
            Else
                LinCom = (Dtgart(4, i).Value)
            End If
            If IsDBNull(Convert.ToString(Dtgart(5, i).Value)) Then
            Else
                BarFac = Convert.ToString((Dtgart(5, i).Value))
            End If
            If IsDBNull(Convert.ToString(Dtgart(9, i).Value)) Then
            Else
                Alic1 = Convert.ToDecimal(Dtgart(9, i).Value)
            End If
            If IsDBNull(Convert.ToString(Dtgart(10, i).Value)) Then
            Else
                IdAlic = Convert.ToDecimal(Dtgart(10, i).Value)
            End If
            If IdCiva = "1" Then
                AlicDisc = Alic1 / 100 + 1
                Punt = FormatNumber(Punt / AlicDisc, 2)
            End If
            Ptotal = Punt * Cantidad
            'u_mtx = 123456              ' unidades
            u_mtx = 12345678
            cod_mtx = BarFac    ' código de barras
            codigo = BarFac             ' codigo interno a imprimir (ej. "articulo")
            ds = Articulo
            qty = Cantidad             ' cantidad
            umed = 7                    ' código de unidad de medida (ej. 7 para "unidades")
            precio = Punt                ' precio neto (A) o iva incluido (B)
            bonif = 0                   ' importe de descuentos
            iva_id = ""                   ' código para alícuota del 21%
            imp_iva = Alic1                  ' importe liquidado de iva
            importe = Ptotal                ' importe total del item
            despacho = "Nº 123456"      ' numero de despacho de importación
            dato_a = ""          ' primer dato adicional del item
            dato_b = ""
            dato_c = ""
            dato_d = ""
            dato_e = ""           ' ultimo dato adicional del item
            ok = PyFEPDF.AgregarDetalleItem(u_mtx, cod_mtx, codigo, ds, qty, umed, _
                    precio, bonif, IdAlic, imp_iva, importe, despacho, _
                    dato_a, dato_b, dato_c, dato_d, dato_e)
        Next
        'Traigo los datos de la empresa vendedora
        misdatos = MiClase.traedataset("select empresa,direccion,ciudad,ib,civa,in_act,ob1,ob2,ob3,numcop,cuit_em from configuracion where pc=" & Pc & "")
        Empresa = Trim(misdatos.Tables(0).Rows(0).Item(0))
        DirEm = Trim(misdatos.Tables(0).Rows(0).Item(1))
        CiuEm = Trim(misdatos.Tables(0).Rows(0).Item(2))
        IbEm = Trim(misdatos.Tables(0).Rows(0).Item(3))
        CivEm = Trim(misdatos.Tables(0).Rows(0).Item(4))
        InAcEm = Trim(misdatos.Tables(0).Rows(0).Item(5))
        Ob1 = Trim(misdatos.Tables(0).Rows(0).Item(6))
        Ob2 = Trim(misdatos.Tables(0).Rows(0).Item(7))
        Ob3 = Trim(misdatos.Tables(0).Rows(0).Item(8))
        Numcop = Trim(misdatos.Tables(0).Rows(0).Item(9))
        CuitEm = Trim(misdatos.Tables(0).Rows(0).Item(10))
        ' Agrego datos adicionales fijos:
        ok = PyFEPDF.AgregarDato("logo", PyFEPDF.InstallDir + "\plantillas\logo.png")
        'ok = PyFEPDF.AgregarDato("logo", "D:\Proyectos.Net\Super\Super\bin\Debug\logo.png")
        'Bibliotecas\Imágenes
        'C:\Gestion\logo.png'
        ok = PyFEPDF.AgregarDato("EMPRESA", Empresa)
        ok = PyFEPDF.AgregarDato("MEMBRETE1", DirEm)
        ok = PyFEPDF.AgregarDato("MEMBRETE2", CiuEm)
        ok = PyFEPDF.AgregarDato("CUIT", "Cuit: " + CuitEm)
        ok = PyFEPDF.AgregarDato("IIBB", "I.Brutos: " + IbEm)
        ok = PyFEPDF.AgregarDato("IVA", "Condición de Iva: " + CivEm)
        ok = PyFEPDF.AgregarDato("INICIO", "Inicio de Actividad: " + InAcEm)
        ok = PyFEPDF.AgregarDato("ObservacionesGenerales1", "a")
        ok = PyFEPDF.AgregarDato("ObservacionesGenerales2", "b")
        ok = PyFEPDF.AgregarDato("ObservacionesGenerales3", "c")

        ' Cargo el formato desde el archivo CSV (opcional)
        ' (carga todos los campos a utilizar desde la planilla)
        ok = PyFEPDF.CargarFormato(PyFEPDF.InstallDir + "\factura.csv")
        Dim Bold, italic, underline, foreground, background, align, prioridad, papel, orientacion, num_copias, lineas_max, qty_pos, salida, imprimir As String
        ' Agrego campos manualmente (opcional):
        nombre = "prueba" : tipo = "T"           ' "T" texto, "L" lineas, "I" imagen, etc.
        x1 = 50 : y1 = 150 : x2 = 150 : y2 = 255  ' coordenadas (en milimetros)
        Font = "Arial" : Size = 20 : Bold = 1 : italic = 1 : underline = 1 ' tipo de letra
        foreground = "000000" : background = "FFFFFF"    ' colores de frente y fondo
        align = "C" ' Alineación: Centrado, Izquierda, Derecha
        prioridad = 2 ' Orden Z, menor prioridad se dibuja primero (para superposiciones)
        ' Creo plantilla para esta factura (papel A4 vertical):
        papel = "A4" ' o "letter" para carta, "legal" para oficio
        orientacion = "portrait" ' o landscape (apaisado)
        ok = PyFEPDF.CrearPlantilla(papel, orientacion)
        num_copias = Numcop   ' original, duplicado y triplicado
        lineas_max = 24 ' cantidad de linas de items por página
        qty_pos = "izq" ' (cantidad a la izquierda de la descripción del artículo)
        ' Proceso la plantilla
        ok = PyFEPDF.ProcesarPlantilla(num_copias, lineas_max, qty_pos)
        ' Genero el PDF de salida según la plantilla procesada
        salida = "C:\PyAfipWs\factura.pdf"
        ok = PyFEPDF.GenerarPDF(salida)

        ' Abro el visor de PDF y muestro lo generado
        ' (es necesario tener instalado Acrobat Reader o similar)
        imprimir = False
        'imprimir = False  ' cambiar a True para que lo envie directo a la impresora
        ok = PyFEPDF.MostrarPDF(salida, imprimir)
        'Dim SalAr As String
        Dim NomArc As String
        If IdCiva = 1 Then
            NomArc = Trim("A" + CStr(cbte_nro) + "-" + (TxtCli.Text))
        Else
            NomArc = "B" + CStr(cbte_nro) + "-" + (TxtCli.Text)

        End If
        'SalAr = "C:\" & NomArc & ".pdf"
        'SalAr = "C:\'" & (NomArc) + ".pdf" & "'"
        'Txt1.Text = "Prueba.pdf"
        'ok = PyFEPDF.GenerarPDF("& txt1.Text &")
        'My.Computer.FileSystem.CopyFile("C:\PyAfipWs\factura.pdf", "C:\Users\Usuario\Documents\Facturas\factura.pdf")
        My.Computer.FileSystem.CopyFile("C:\PyAfipWs\factura.pdf", "C:\PyAfipWs\Facturas\factura.pdf")
        Dim ArcOld As String
        'Dim ArcNue As String
        ArcOld = "factura.pdf"
        'Txt1.Text = "Prueba.pdf"
        'My.Computer.FileSystem.RenameFile("C:\Users\Usuario\Documents\Facturas\" + ArcOld, (NomArc))
        My.Computer.FileSystem.RenameFile("C:\PyAfipWs\Facturas\" + ArcOld, (NomArc) + ".pdf")
        'C:\PyAfipWs\Facturas
    End Sub
    Private Sub Fac_Elec()
        Dim WSFEv1 As Object
        'traigo los datos de la configuracion
        misdatos = MiClase.traedataset("select cuit_em,pv,servidor from configuracion where pc=" & Pc & "")
        Cuit_Em = misdatos.Tables(0).Rows(0).Item(0)
        punto_vta = misdatos.Tables(0).Rows(0).Item(1)
        Pv = misdatos.Tables(0).Rows(0).Item(1)
        Ser = misdatos.Tables(0).Rows(0).Item(2)
        '   ***********************++
        Console.WriteLine("Crear objeto interface Web Service de Factura Electrónica de Mercado Interno")
        WSFEv1 = CreateObject("WSFEv1")

        'Try
        Console.WriteLine(WSFEv1.Version)
        Console.WriteLine(WSFEv1.InstallDir)
        misdatos = MiClase.traedataset("select tocken,sign from ticket")
        Tocken = RTrim(misdatos.Tables(0).Rows(0).Item(0))
        Sign = RTrim(misdatos.Tables(0).Rows(0).Item(1))
        WSFEv1.token = Tocken
        WSFEv1.sign = Sign
        'Dl = Trim(Dl)
        ' CUIT del emisor (debe estar registrado en la AFIP)
        'WSFEv1.Cuit = "20267565393"
        WSFEv1.cuit = Cuit_Em

        If Ser = 0 Then 'servidor testing
            ' Conectar al Servicio Web de Facturación
            proxy = "" ' "usuario:clave@localhost:8000"
            'wsdl = "https://wswhomo.afip.gov.ar/wsfev1/service.asmx?WSDL"
            wsdl = "https://wswhomo.afip.gov.ar/wsfev1/service.asmx?WSDL"
            cache = "" 'Path
            ok = WSFEv1.Conectar(cache, wsdl, proxy) ' homologación
        ElseIf Ser = 1 Then
            proxy = "" ' "usuario:clave@localhost:8000"
            wsdl = "https://servicios1.afip.gov.ar/wsfev1/service.asmx?WSDL"
            cache = "" 'Path
            ok = WSFEv1.Conectar(cache, wsdl, proxy) ' homologación
        End If

        REM ' mostrar bitácora de depuración:
        Console.WriteLine(WSFEv1.DebugLog)

        REM ' Llamo a un servicio nulo, para obtener el estado del servidor (opcional)
        WSFEv1.Dummy()
        Console.WriteLine("appserver status" & WSFEv1.AppServerStatus)
        Console.WriteLine("dbserver status" & WSFEv1.DbServerStatus)
        Console.WriteLine("authserver status" & WSFEv1.AuthServerStatus)

        REM ' Establezco los valores de la factura a autorizar:

        If EsCom = 1 Then
            If IdCiva = 1 Then
                tipo_cbte = "1"
            Else
                tipo_cbte = "6"
            End If
        ElseIf EsCom = 2 Then
            If IdCiva = "1" Then
                tipo_cbte = "3"
            Else
                tipo_cbte = "8"
            End If
        End If

        cbte_nro = WSFEv1.CompUltimoAutorizado(tipo_cbte, punto_vta)

        If cbte_nro = "" Then
            cbte_nro = 0                ' no hay comprobantes emitidos
        Else
            cbte_nro = CLng(cbte_nro)   ' convertir a entero largo
        End If
        fecha = Format(Now, "yyyyMMdd")
        concepto = 1
        If IdCiva = 5 Then
            Dcuit = Mid(MskCuit.Text, 8, 3)
            Mcuit = Mid(MskCuit.Text, 4, 3)
            Icuit = Mid(MskCuit.Text, 1, 2)
            Cuit = Icuit + Mcuit + Dcuit
            'tipo_doc = 80 : nro_doc = "33693450239"
            tipo_doc = 96 : nro_doc = Cuit

        Else
            Dcuit = Mid(MskCuit.Text, 13, 1)
            Mcuit = Mid(MskCuit.Text, 4, 8)
            Icuit = Mid(MskCuit.Text, 1, 2)
            Cuit = Icuit + Mcuit + Dcuit
            tipo_doc = 80 : nro_doc = Cuit

        End If

        cbte_nro = cbte_nro + 1
        'Acumulo los totales por alicuota
        Lin = 0
        misdatos = MiClase.traedataset("select isnull(max(id),0) from alic_iva")
        MaxFl = misdatos.Tables(0).Rows(0).Item(0)
        Dim filas As Integer = MaxFl
        For i As Integer = 3 To filas - 1
            misdatos = MiClase.traedataset("select isnull(sum(ptotal),0) from t_detalfac where idiv=" & i & "and idpc=" & Pc & "")
            Tot = misdatos.Tables(0).Rows(0).Item(0)
            Tot1 = misdatos.Tables(0).Rows(0).Item(0)
            If Tot > 0 Then
                misdatos = MiClase.traedataset("select id,alic from alic_iva where id=" & i & "")
                AlIv = misdatos.Tables(0).Rows(0).Item(1)
                AlicDisc = AlIv / 100 + 1
                Net = FormatNumber(Tot / AlicDisc, 2)
                Iv = Tot1 - Net
                MiClase.eliminaactualizaregistra("insert into totalic values(" & Lin & "," & i & "," & Str(AlIv) & "," & Str(Net) & "," & Str(Iv) & "," & Str(Tot1) & "," & Pc & " )")
                Lin = Lin + 1
            End If

        Next
        misdatos = MiClase.traedataset("select sum(neto),sum(iva),sum(total) from totalic")
        Net = misdatos.Tables(0).Rows(0).Item(0)
        NetT = misdatos.Tables(0).Rows(0).Item(0)
        Iv = misdatos.Tables(0).Rows(0).Item(1)
        IvT = misdatos.Tables(0).Rows(0).Item(1)
        Tot = misdatos.Tables(0).Rows(0).Item(2)
        'NetT = Net
        'IvT = Iv
        cbt_desde = cbte_nro : cbt_hasta = cbte_nro
        imp_total = Tot : imp_tot_conc = "0.00" : imp_neto = Net
        imp_iva = Iv : imp_trib = "0.00" : imp_op_ex = "0.00"
        fecha_cbte = fecha : fecha_venc_pago = ""
        ' Fechas del período del servicio facturado (solo si concepto = 1?)
        fecha_serv_desde = "" : fecha_serv_hasta = ""
        moneda_id = "PES" : moneda_ctz = "1.000"
        ' imp_trib = "1.000"
        ok = WSFEv1.CrearFactura(concepto, tipo_doc, nro_doc, tipo_cbte, punto_vta, _
             cbt_desde, cbt_hasta, imp_total, imp_tot_conc, imp_neto, _
             imp_iva, imp_trib, imp_op_ex, fecha_cbte, fecha_venc_pago, _
             fecha_serv_desde, fecha_serv_hasta, _
             moneda_id, moneda_ctz)
        ' Agrego los comprobantes asociados:
        If False Then ' solo nc/nd
            REM tipo = 19
            REM pto_vta = 2
            REM nro = 1234
            REM ok = WSFEv1.AgregarCmpAsoc(tipo, pto_vta, nro)
        End If

        'Grabo varias alicuotas de iva
        MiClase.cargardatagriview(DtgTotAlic, "select idiva,alic,neto,iva,total from  totalic ")
        DtgTotAlic.AllowUserToAddRows = False
        Dim fils As Integer = DtgTotAlic.Rows.Count
        For i As Integer = 0 To fils - 1
            misdatos = MiClase.traedataset("select idiva,alic,neto,iva,total from totalic")
            IdAlic = Convert.ToString(DtgTotAlic(0, i).Value)
            alic = Convert.ToString(DtgTotAlic(1, i).Value)
            Net = Convert.ToString(DtgTotAlic(2, i).Value)
            Iv = Convert.ToString(DtgTotAlic(3, i).Value)
            Tot = Convert.ToString(DtgTotAlic(4, i).Value)
            ok = WSFEv1.AgregarIva(IdAlic, Net, Iv)
        Next
        'hasta aca***************
        ' Habilito reprocesamiento automático (predeterminado):
        WSFEv1.Reprocesar = True

        ' Solicito CAE:
        cae = WSFEv1.CAESolicitar()

        ' Imprimo pedido y respuesta XML para depuración (errores de formato)
        Console.WriteLine(WSFEv1.XmlRequest)
        Console.WriteLine(WSFEv1.XmlResponse)
        TxtReq.Text = WSFEv1.xmlrequest
        TxtP.Text = WSFEv1.XmlResponse
        Dlin = Len(TxtReq.Text)
        MiClase.eliminaactualizaregistra("insert into respuesta values(" & cbte_nro & "," & tipo_cbte & ",'" & TxtReq.Text & "','" & TxtP.Text & "')")
        Console.WriteLine("Resultado" & WSFEv1.Resultado)
        Console.WriteLine("CAE", WSFEv1.CAE)
        Console.WriteLine("Numero de comprobante:" & WSFEv1.CbteNro)
        Console.WriteLine("Reprocesar:" & WSFEv1.Reprocesar)
        Console.WriteLine("Reproceso:" & WSFEv1.Reproceso)
        Console.WriteLine("EmisionTipo:" & WSFEv1.EmisionTipo)

        MsgBox("Resultado:" & WSFEv1.Resultado & " CAE: " & cae & " Venc: " & WSFEv1.Vencimiento & " Reproceso: " & WSFEv1.Reproceso, vbInformation + vbOKOnly)
        If cae > "0" Then
            cae = WSFEv1.cae
            fecha_vto_cae = WSFEv1.vencimiento
            VtoCae = WSFEv1.vencimiento
            Crear_Pdf()
            Guar_Fac()
        End If
        'Else
        'MsgBox("No Obtubo respuesta del servidor", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Respuesta del Servidor")
        'End If
        If WSFEv1.ErrMsg <> "" Then
            MsgBox(WSFEv1.ErrMsg, vbExclamation, "Errores")
        End If

        If WSFEv1.Obs <> "" Then
            MsgBox(WSFEv1.Obs, vbExclamation, "Observaciones")
        End If
        ' Muestro los errores
        If WSFEv1.Traceback <> "" Then
            MsgBox(WSFEv1.Traceback, vbExclamation, "Error")
        End If

        ' End Try
    End Sub

    Private Sub ImpRem()
        Reportes.CrystalReportViewer1.Visible = False
        Dim Mn As New DtcRemito
        Dim Fila As DtcRemito.RemitoRow
        Fila = Mn.Remito.NewRemitoRow
        'Dim Fila1 As DtcRemito.RemitoRow
        'Fila1 = Mn.Remito.NewRemitoRow
        'traigo los datos del e ncabezado
        misdatos = MiClase.traedataset("select linea1,linea2,linea3 from encabezado")
        Linea1 = misdatos.Tables(0).Rows(0).Item(0)
        Linea2 = misdatos.Tables(0).Rows(0).Item(1)
        Linea3 = misdatos.Tables(0).Rows(0).Item(2)
        Fila.Linea1 = Linea1
        Fila.Linea2 = Linea2
        Fila.Linea3 = Linea3
        Fila.Numero = Lnum
        Fila.Fecha = Date.Today
        Fila.Cliente = TxtCli.Text
        Fila.Direccion = TxtDir.Text
        Fila.Ciudad = TxtCiudad.Text
        Fila.Cuit = MskCuit.Text
        Fila.CDe_Iva = TxtcIva.Text
        Fila.Cde_Venta = Cventa
        Fila.IdCl = Idcl
        Fila.Total = txtTotal.Text
        Fila.Obs = TxtOb.Text
        Fila.Obs1 = TxtOb1.Text
        Mn.Remito.AddRemitoRow(Fila)
        ' Mn.Remito.AddRemitoRow(Fila)
        'detalle de remito
        Dim Fila1 As DtcRemito.DetalleRow
        'Fila1 = Mn.Remito.new
        'FilDt = Mn.Remito.NewRemitoRow
        MiClase.cargardatagriview(Dtgart, "select articulo,punit,cantidad,ptotal,linea,barra,idpr,idmr,idfm,alic,unidad from t_detalFac order by linea asc ")
        Dtgart.AllowUserToAddRows = False
        For i As Integer = 0 To Dtgart.RowCount - 1
            Fila1 = Mn.Detalle.NewDetalleRow
            Fila1.Articulo = Dtgart(0, i).Value
            Fila1.PUnit = FormatNumber(Dtgart(1, i).Value, 2)
            Fila1.Cantidad = FormatNumber(Dtgart(2, i).Value, 2)
            Fila1.PTotal = FormatNumber(Dtgart(3, i).Value, 2)
            Fila1.IdAr = Dtgart(5, i).Value
            Fila1.Unidad = Dtgart(10, i).Value
            Mn.Detalle.AddDetalleRow(Fila1)
        Next
        'Dim MCuo As New DtcRemito
        'Dim FilDet As DtcRemito.CuotasRow
        ''Dim FilDet As DtcCuotas.CuotasRow
        ' DtgCuotas.AllowUserToAddRows = False
        ' For i As Integer = 0 To DtgCuotas.RowCount - 1
        ' FilDet = MCuo.Cuotas.NewCuotasRow
        ' FilDet.Numero = DtgCuotas(0, i).Value
        ' FilDet.Vencimiento = DtgCuotas(1, i).Value
        ' FilDet.Importe = DtgCuotas(2, i).Value
        ' MCuo.Cuotas.AddCuotasRow(FilDet)
        ' Next
        If IdTp = "4" Then
            Dim rpt As New CryRemito
            rpt.SetDataSource(Mn)
            Reportes.CrystalReportViewer1.ReportSource = rpt
            Reportes.CrystalReportViewer1.PrintReport()
            'Reportes.Show()
        ElseIf IdTp = "7" Then
            Dim RpP As New CryPresupuesto
            RpP.SetDataSource(Mn)
            Reportes.CrystalReportViewer1.ReportSource = RpP
            Reportes.CrystalReportViewer1.PrintReport()
            'Reportes.Show()
        End If
    End Sub
    Private Sub RespImp()
        CmdFactura.Enabled = False
        'Imprimo los Item
        Dim filas As Integer = Dtgart.Rows.Count
        Dim contador As Integer = 0
        For i As Integer = 0 To filas - 1
            If IsDBNull(Convert.ToString(Dtgart(0, i).Value)) Then
            Else
                Articulo = Convert.ToString(Dtgart(0, i).Value)
            End If

            If IsDBNull(Convert.ToString(Dtgart(1, i).Value)) Then
            Else
                Punt = Convert.ToDecimal(Dtgart(1, i).Value)
            End If

            If IsDBNull(Convert.ToString(Dtgart(2, i).Value)) Then
            Else
            End If

            If IsDBNull(Convert.ToString(Dtgart(9, i).Value)) Then
            Else
                'MskAlic.Text = Convert.ToDecimal(Dtgart(9, i).Value)
            End If
            'Imprimo el Item
            '   comando = "B" & Chr(28) & Articulo & Chr(28) & Cantidad & Chr(28) & Punt & Chr(28) & Alic & Chr(28) & "M" & Chr(28) & "0.00" & Chr(28) & "0" & Chr(28) & "T"
            '   ret = MandaPaqueteFiscal(handler, comando)
            '  ret = UltimaRespuesta(handler, respuesta)
            '  RsImp = Mid((respuesta.ToString), 1, 4)
            '  RsFis = Mid((respuesta.ToString), 6, 4)
            '  ResIm()
            '  ResFis()
        Next
        'Descuento General
        'comando = "T" & Chr(28) & "Pago Efectivo:" & Chr(28) & "1.50" & Chr(28) & "m" & Chr(28) & "0" & Chr(28) & "T"
        'ret = MandaPaqueteFiscal(handler, comando)
        'ret = UltimaRespuesta(handler, respuesta)
        'RsImp = Mid((respuesta.ToString), 1, 4)
        'RsFis = Mid((respuesta.ToString), 6, 4)
        'Rt = (respuesta.ToString)
        'ResIm()
        'ResFis()
        'Sub Total
        'comando = "C" & Chr(28) & "P" & Chr(28) & "0" & Chr(28) & "0"
        'ret = MandaPaqueteFiscal(handler, comando)
        'ret = UltimaRespuesta(handler, respuesta)
        'RsImp = Mid((respuesta.ToString), 1, 4)
        'RsFis = Mid((respuesta.ToString), 6, 4)
        'Rt = (respuesta.ToString)
        'ResIm()
        'ResFis()
        'Calculo el Vuelto en los controladores con version mas nueva se puede agregar un campo para nombre de tarjeta
        'comando = "D" & Chr(28) & "Pago" & Chr(28) & MskImp.Text & Chr(28) & "T" & Chr(28) & "0"
        'ret = MandaPaqueteFiscal(handler, comando)
        'ret = UltimaRespuesta(handler, respuesta)
        'RsImp = Mid((respuesta.ToString), 1, 4)
        'RsFis = Mid((respuesta.ToString), 6, 4)
        'Rt = (respuesta.ToString)
        'Cierro el ticket
        'comando = "E"
        'ret = MandaPaqueteFiscal(handler, comando)
        'ret = UltimaRespuesta(handler, respuesta)
        'Rt = (respuesta.ToString)
        'RsImp = Mid((respuesta.ToString), 1, 4)
        'RsFis = Mid((respuesta.ToString), 6, 4)
        'ResIm()
        'ResFis()




        'Hago comprobante en negro
        'Traigo el Numero del Comprobante
        'misdatos = MiClase.traedataset("select isnull( max(numero),0) from facturas where idtp=" & 4 & "")
        'NumFac = misdatos.Tables(0).Rows(0).Item(0) + 1
        'Num = misdatos.Tables(0).Rows(0).Item(0) + 1
        'Grabo en la tabla Det_fac
        'Try

        'For i As Integer = 0 To filas - 1
        'If IsDBNull(Convert.ToString(Dtgart(0, i).Value)) Then
        'Else
        'Articulo = Convert.ToString(Dtgart(0, i).Value)
        'End If

        'If IsDBNull(Convert.ToString(Dtgart(1, i).Value)) Then
        'Else
        'Punt = Convert.ToString(Dtgart(1, i).Value)
        'End If

        '        If IsDBNull(Convert.ToString(Dtgart(2, i).Value)) Then
        '        Else
        '        Cantidad = Convert.ToString(Dtgart(2, i).Value)
        '        End If

        '        If IsDBNull(Convert.ToString(Dtgart(3, i).Value)) Then
        '        Else
        '        Ptotal = Convert.ToString(Dtgart(3, i).Value)
        '        End If

        '       If IsDBNull(Convert.ToString(Dtgart(4, i).Value)) Then
        '       Else
        '       Linea = Convert.ToString(Dtgart(4, i).Value)
        '       End If

        '        If IsDBNull(Convert.ToString(Dtgart(5, i).Value)) Then
        '        Else
        '        TxtBarra.Text = Convert.ToString(Dtgart(5, i).Value)
        '        End If

        '        If IsDBNull(Convert.ToString(Dtgart(6, i).Value)) Then
        '        Else
        '        IdPr = Convert.ToString(Dtgart(6, i).Value)
        '        End If
        '
        '       If IsDBNull(Convert.ToString(Dtgart(7, i).Value)) Then
        '      Else
        '      IdMr = Convert.ToString(Dtgart(7, i).Value)
        '      End If
        '
        '        If IsDBNull(Convert.ToString(Dtgart(8, i).Value)) Then
        '        Else
        '        IdFm = Convert.ToString(Dtgart(8, i).Value)
        '        End If
        '
        'If IsDBNull(Convert.ToString(Dtgart(9, i).Value)) Then
        'Else
        'Alic = Convert.ToString(Dtgart(9, i).Value)
        'End If
        'MiClase.eliminaactualizaregistra("insert into detal_fac values(" & NumFac & "," & Linea & "," & _
        ' "" & IdTp & "," & TxtBarra.Text & ",'" & Articulo & "'," & Punt & "," & Cantidad & "," & Ptotal & ", " & _
        ' "" & Idcl & "," & IdPr & "," & IdFm & "," & IdMr & "," & BlNg & "," & Alic & ",'" & Date.Today & "')")
        'Next
        ''Grabo la Factura
        'Fnum()
        'AlIv = Alic / 100 + 1
        'Neto = FormatNumber(txtTotal.Text / AlIv, 2)
        'Iva = FormatNumber(txtTotal.Text - Neto, 2)
        'Fech = Date.Today
        'FecVen = Fech.Date.Date.AddDays(30)
        'MiClase.eliminaactualizaregistra("insert into facturas values(" & Clave & "," & NumFac & "," & IdTp & ", " & _
        '  "" & Pv & "," & IdEnc & "," & Idcl & ",'" & Date.Today & "'," & EsVenta & ",'" & Cventa & "'," & Neto & ", " & _
        '  "" & Iva & "," & Iint & "," & txtTotal.Text & "," & BlNg & "," & Alic & ",'" & FecVen & "','" & Lnum & "'," & 0 & ")")
        ''Grabo para la Cuenta Corriente
        'If EsVenta = 1 Then
        ' MiClase.eliminaactualizaregistra("insert into ctacte values(" & Clave & "," & NumFac & "," & IdTp & ", " & _
        '  "" & Idcl & "," & IdEnc & ",'" & Date.Today & "','" & FecVen & "'," & txtTotal.Text & "," & Entrega & "," & txtTotal.Text & "," & BlNg & ",'" & Lnum & "')")
        ' misdatos = MiClase.traedataset("select isnull( (saldo),0) from clientes where id=" & Idcl & "")
        'Saldo = misdatos.Tables(0).Rows(0).Item(0)
        'Saldo = Saldo + txtTotal.Text
        'MiClase.eliminaactualizaregistra("update clientes set saldo='" & Saldo & "'where id=" & Idcl & "")
        'End If
        'Blanquear()
        'Catch ex As Exception

        '        End Try
    End Sub
    
    Private Sub Fnum()
        'Formateo el Numero de Comprobante
        If NumDbto > 0 Then
            Num = NumDbto
        Else
            Num = cbte_nro
        End If
        'Num = NumFac
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
        TxtPv.Text = Lpv
        TxtNumFac.Text = Lnum
        Clave = Lpv + "-" + Lnum
    End Sub

    Private Sub Blanquear()
        Panel1.Visible = False
        Txtbarra.Text = ""
        TxtCli.Text = ""
        TxtDir.Text = ""
        TxtDir.Enabled = False
        TxtCiudad.Text = ""
        TxtCiudad.Enabled = False
        TxtcIva.Text = ""
        TxtcIva.Enabled = False
        MskCuit.Text = ""
        MskCuit.Enabled = False
        MskCantidad.Mask = ""
        TxtCpostal.Text = ""
        TxtArticulo.Text = ""
        MskCantidad.Text = ""
        MskPunit.Text = ""
        MskCantidad.Text = ""
        MskPtotal.Text = ""
        MskEntrega.Text = ""
        MskCuotas.Text = ""
        TxtProv.Text = ""
        MskDescGral.Text = ""
        TxtProv.Enabled = False
        Panel2.Visible = False
        MskCantidad.Enabled = False
        MskPtotal.Enabled = False
        MskCuit.Enabled = False
        CmdBuscar.Enabled = True
        txtTotal.Text = ""
        MskImp.Text = ""
        'Txtvuelto.Text = ""
        'TxtArticulo.Focus()
        Ord = 0
        cbt_desde = 0
        cbt_hasta = 0
        imp_total = 0
        imp_tot_conc = 0
        imp_neto = 0
        imp_iva = 0
        imp_trib = 0
        imp_op_ex = 0
        fecha_cbte = 0
        fecha_venc_pago = 0
        fecha_serv_desde = 0
        fecha_serv_hasta = 0
        moneda_id = 0
        moneda_ctz = 0
        Punt = 0
        Ptotal = 0
        Net = 0
        IvT = 0
        Iint = 0
        ToTT = 0
        TxtNCr.Text = ""
        TxtNCr.Visible = False
        TotFac = 0
        TotPago = 0
        MiClase.eliminaactualizaregistra("delete from tpago where pc=" & Pc & "")
        MiClase.eliminaactualizaregistra("delete from t_detalfac where idpc=" & Pc & "")
        MiClase.eliminaactualizaregistra("delete from totalic")
        MiClase.eliminaactualizaregistra("delete from tcuotas where pc=" & Pc & "")
        MiClase.cargardatagriview(DtgCuotas, "select * from  tcuotas where pc=" & Pc & " ")
        MiClase.cargardatagriview(Dtgart, "select articulo,punit,cantidad,ptotal,linea,barra,idpr,idmr,idfm,alic from t_detalFac where idpc=" & Pc & " order by linea desc ")
        TxtNCr.Text = 0
        MiClase.cargardatagriview(DtgNc, "select ctacte.lnum,fecha,importe,entrega,saldo,numero,idtp,cuota,fecven,idcl from ctacte where numero=" & TxtNCr.Text & "and idtp=" & 1000 & "order by cuota desc")
        misdatos = MiClase.traedataset("select fact,pvimp from configuracion where pc=" & Pc & "")
        Fact = misdatos.Tables(0).Rows(0).Item(0)
        MiClase.cargardatagriview(DtgPag, "select comprobante,numero,importe,linea,idcom from tpago where pc=" & Pc & " ")
        MiClase.cargardatagriview(DtgPag, "select comprobante,numero,importe,linea,idcom from tpago where pc=" & Pc & " ")
        DtgPag.Font = New Font("Arial ", 12, FontStyle.Regular)
        DtgPag.ColumnHeadersVisible = False
        DtgPag.AllowUserToAddRows = False
        DtgPag.Columns(2).DefaultCellStyle.Format = "##,##0.00"
        DtgPag.Columns(3).Visible = False
        DtgPag.Columns(4).Visible = False
        TxtPag.Clear()
        TxtNCh.Clear()
        misdatos = MiClase.traedataset("select sum(importe) from tpago")
        'TotPago = misdatos.Tables(0).Rows(0).Item(0)
        'MskImp.Text = "0"
        'MskImp.Text = FormatNumber(txtTotal.Text - TotPago, 2)
        CmbMenu.Text = "Factura"
        TsNc.Visible = False
        TsNc.Text = "Articulo"
        DtgPag.AllowUserToAddRows = False
        IdCom = 0
        Entrega = 0
        IdCom = 0
        Idcl = "0"
        MiClase.cargardatagriview(DtgRem, "select lnum,fecha,importe,numero,estado from tremcta where estado=" & 1 & "")
        DtgRem.AllowUserToAddRows = False
        Dim fis As Integer = DtgRem.Rows.Count
        For i As Integer = 0 To fis - 1
            If IsDBNull(Convert.ToString(DtgRem(3, i).Value)) Then
            Else
                Num = Convert.ToString(DtgRem(3, i).Value)
            End If
            MiClase.eliminaactualizaregistra("update facturas set esventa=" & 2 & " where idcl=" & Idcl & "and idtp=" & 4 & "and numero=" & Num & "and blng=" & 1 & " ")
            MiClase.eliminaactualizaregistra("update ctacte set saldo=" & 0 & " where idcl=" & Idcl & "and idtp=" & 4 & "and numero=" & Num & "and blng=" & 1 & " ")
        Next
        ifiscal.SerialNumber = ""
    End Sub
    Private Sub Guardar()
        If IdCom = 5 Then
            TxtArticulo.Text = "Costo Financiero"
            Cantidad = 1
            Descu = 0
            PtotalM = 0
            TxtBarra.Text = 0
            IdPr = 1
            IdMr = 1
            IdFm = 1
            Alic1 = 21
            IdIva = 5
            AbUn = 0
            Punit1 = NetCuo
            Ptotal = NetCuo
            MskCantidad.Text = 1
        Else

            '  Punit1 = MskPunit.Text
            '  Cantidad = MskCantidad.Text
            '  Ptotal = MskPtotal.Text
            If MskDescuento.Text = "" Then
                MskDescuento.Text = 0
            End If
            Descu = MskDescuento.Text
            If MskDescuento.Text = "" Then
                MskDescuento.Text = 0
            End If
            'Descu = MskDescuento.Text
            Descu = Decimal.Parse(MskDescuento.Text, System.Globalization.CultureInfo.GetCultureInfo("es-us"))
        End If
        If Punit1 = 0 Or MskCantidad.Text = 0 Or Ptotal = 0 Then
            Mensaje = MsgBox("No Puede haber Importes en 0", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Fala Informacion!!!")
        Else

            If Descu > 0 Then
                PtotalM = Ptotal * Descu / 100
                PtotalM = FormatNumber(Ptotal - PtotalM, 2)
            Else
                PtotalM = Ptotal
            End If
            If TxtBarra.Text = "" Then
                TxtBarra.Text = 0
            End If
            If Alic1 = 0 Then
                Alic1 = 21
            End If
            If AbUn = "" Then
                AbUn = 0
            End If
            If IdAct = 0 Then
                IdAct = 1
            End If
            misdatos = MiClase.traedataset("select isnull(max(linea),0) from t_detalfac")
            Linea = misdatos.Tables(0).Rows(0).Item(0) + 1
            If IdTp = 4 Then
                If Linea = 37 Then
                    Mensaje = MsgBox("LLego al Limite de Lineas debe Cerrar el Comprobante", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Limite de Lineas")
                Else
                    MiClase.eliminaactualizaregistra("insert into t_detalfac values(" & Linea & "," & Pc & ",'" & TxtArticulo.Text & "'," & Str(Punit1) & "," & Str(Cantidad) & "," & Str(Descu) & "," & Str(Ptotal) & "," & Str(PtotalM) & "," & TxtBarra.Text & "," & IdPr & "," & IdMr & "," & IdFm & "," & BlNg & "," & Str(Alic1) & "," & IdIva & ",'" & AbUn & "'," & IdAct & ")")
                    '            Linea = Linea + 1
                    Dtgart.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
                    MiClase.cargardatagriview(Dtgart, "select articulo,punit,cantidad,descu,ptotal,linea,barra,idpr,idmr,idfm,alic,idiv,ptotalm,idact from t_detalFac where idpc=" & Pc & " order by linea ")
                    Dtgart.Font = New Font("Arial ", 14, FontStyle.Regular)
                    Dtgart.ColumnHeadersVisible = False
                    Dtgart.AllowUserToAddRows = False
                    'Dtgart.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    Dtgart.Columns(0).Width = 360
                    Dtgart.Columns(1).DefaultCellStyle.Format = "##,##0.00"
                    Dtgart.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                    Dtgart.Columns(2).DefaultCellStyle.Format = "##,##0.00"
                    Dtgart.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                    Dtgart.Columns(3).DefaultCellStyle.Format = "##,##0.00"
                    Dtgart.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                    Dtgart.Columns(4).DefaultCellStyle.Format = "##,##0.00"
                    Dtgart.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                    Dtgart.Columns(12).DefaultCellStyle.Format = "##,##0.00"
                    Dtgart.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                    Dtgart.Columns(4).Visible = False
                    Dtgart.Columns(5).Visible = False
                    Dtgart.Columns(6).Visible = False
                    Dtgart.Columns(7).Visible = False
                    Dtgart.Columns(8).Visible = False
                    Dtgart.Columns(9).Visible = False
                    Dtgart.Columns(10).Visible = False
                    Dtgart.Columns(11).Visible = False
                    misdatos = MiClase.traedataset("select sum(ptotalm) from t_detalfac where idpc=" & Pc & "")
                    txtTotal.Text = FormatNumber(misdatos.Tables(0).Rows(0).Item(0), 2)
                    TxtArticulo.Text = ""
                    MskCantidad.Text = ""
                    MskPunit.Text = ""
                    MskDescuento.Text = 0
                    MskPtotal.Text = ""
                    MskPunit.Enabled = False
                    MskCantidad.Enabled = False
                    MskDescuento.Enabled = False
                    MskPtotal.Enabled = False
                    PtotalM = 0
                    EsCant = 0
                    LbCan.Visible = False
                    TxtArticulo.Focus()
                    ''If IdTp = 4 Then
                    'If Linea = 15 Then
                    'Mensaje = MsgBox("LLego al Limite de Lineas debe Cerrar el Comprobante", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Limite de Lineas")
                    'If Mensaje = vbOK Then

                End If
                End If
                ' End If
            End If
    End Sub

    Private Sub FrmFactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")
        IdCom = 0
        EsAr = "1"
        EsCl = "3"
        Linea = 0
        IdEnc = 1
        EsCv = 1
        EsCiu = 1
        MiClase.eliminaactualizaregistra("delete from t_detalfac where idpc=" & Pc & "")
        MiClase.eliminaactualizaregistra("delete from tcuotas where pc=" & Pc & "")
        MiClase.eliminaactualizaregistra("delete from totalic where pc=" & Pc & "")
        MiClase.eliminaactualizaregistra("delete from tpago where pc=" & Pc & "")
        MiClase.eliminaactualizaregistra("delete from tremcta where idpc=" & Pc & "")
        misdatos = MiClase.traedataset("select fact,pvimp,puerneg from configuracion where pc=" & Pc & "")
        Fact = misdatos.Tables(0).Rows(0).Item(0)
        PuerNeg = Trim(misdatos.Tables(0).Rows(0).Item(2))
        ' TxtCli.Enabled = False
        TxtArticulo.Enabled = True
        TxtArticulo.Focus()
        If BlNg = 0 Then
            CblNg.Visible = False
            CmbMenu.Items.Add("Factura")
            CmbMenu.Items.Add("Nota De Credito")
            CmbMenu.Items.Add("Factura Manual")
            'traido el ticket de la factura electronica
            If Fact = 0 Then
                CmdCer.Visible = True
                CmbRepZ.Visible = False
                misdatos = MiClase.traedataset("select fecha from ticket")
                Fc = misdatos.Tables(0).Rows(0).Item(0)
                Dif = DateDiff(DateInterval.Hour, Fc, FcAc)
                If Dif > 10 Then
                    Cer()
                End If
                'impresor fiscal epson
            ElseIf Fact = 1 Then
                CmdCer.Visible = False
                CmbRepZ.Visible = True
                misdatos = MiClase.traedataset("select puerto,puerneg from configuracion where pc=" & Pc & "")
                PuerImp = misdatos.Tables(0).Rows(0).Item(0)
                nError = ifiscal.IF_OPEN(PuerImp, 9600)
                'nError = ifiscal.IF_WRITE("@estado|N")
                If nError = -1 Then
                    Mensaje = MsgBox("Se Perdio la conexion con el Impresor fiscal, puede estar apagado o desconectado", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Error de conexion!!!")
                    If Mensaje = vbOK Then
                        Me.Hide()
                    End If
                End If
                nError = ifiscal.IF_CLOSE()
                'Impresor Fiscal Hasar ticket
            ElseIf Fact = 2 Then
                CmdCer.Visible = False
                CmbRepZ.Visible = True
                misdatos = MiClase.traedataset("select puerto from configuracion where pc=" & Pc & "")
                PuerImp = Trim(misdatos.Tables(0).Rows(0).Item(0))
                nError = Ihasar.IF_OPEN(PuerImp, 9600)
                Ihasar.SerialNumber = "27-0163848-435"
                RespHasar1()
                RespHasar2()
                nError = Ihasar.IF_WRITE("@StatusRequest|")
                Dpr = Ihasar.IF_READ(4)
                nError = Ihasar.IF_WRITE("@StatusRequest|")
                Dfis = Ihasar.IF_READ(2)
                If Dfis = "3600" Then
                    'Mensaje = MsgBox("El Impresor fiscal Tiene Un Comprobante Abierto, Debe Cancelarlo", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Documento Abierto!!!")
                    nError = Ihasar.IF_WRITE("@Cancel|")
                End If
                If Dpr = "0" Then
                    MsgBox("Error en la Memoria fiscal, No Esta Formateada", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Llame al Servicio Tecnico")
                ElseIf Dpr = "016" Then
                    MsgBox("El Controlador Fiscal Esta Bloqueado", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Llame al Servicio Tecnico")
                End If
                nError = Ihasar.IF_CLOSE
                'Impresor Fiscal Hasar Factura
            ElseIf Fact = 3 Then
                CmdCer.Visible = False
                CmbRepZ.Visible = True
                misdatos = MiClase.traedataset("select puerto from configuracion where pc=" & Pc & "")
                PuerImp = Trim(misdatos.Tables(0).Rows(0).Item(0))
                nError = Ihasar.IF_OPEN(PuerImp, 9600)
                Ihasar.SerialNumber = "27-0163848-435"
                nError = Ihasar.IF_WRITE("@StatusRequest|")
                Dpr = Ihasar.IF_READ(4)
                nError = Ihasar.IF_WRITE("@StatusRequest|")
                Dfis = Ihasar.IF_READ(2)
                RespHasar1()
                RespHasar2()
                If Dfis = "3600" Then
                    Mensaje = MsgBox("El Impresor fiscal Tiene Un Comprobante Abierto, Debe Cancelarlo", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Documento Abierto!!!")
                    nError = Ihasar.IF_WRITE("@Cancel|")
                End If
                If Dpr = "0" Then
                    MsgBox("Error en la Memoria fiscal, No Esta Formateada", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Llame al Servicio Tecnico")
                ElseIf Dpr = "016" Then
                    MsgBox("El Controlador Fiscal Esta Bloqueado", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Llame al Servicio Tecnico")
                End If
                nError = Ihasar.IF_CLOSE
            End If
            CmbMenu.Text = "Factura"
        ElseIf BlNg = 1 Then
            CmdCer.Visible = False
            CmbRepZ.Visible = False
            CblNg.Visible = True
            CmbMenu.Items.Add("Remito")
            CmbMenu.Items.Add("Presupuesto")
            CmbMenu.Text = "Remito"
            misdatos = MiClase.traedataset("select pvr from configuracion where pc=" & Pc & "")
            Pv = misdatos.Tables(0).Rows(0).Item(0)
            IdTp = 4
            '    CmbMenu.Enabled = False
        End If
        EsCant = 0

    End Sub

    Private Sub CmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdBuscar.Click
        If CmbMenu.Text = "Nota De Credito" And TxtNCr.Text = "" Then
            Mensaje = MsgBox("Tiene que Ingresar el Numero Original de la Factura", MsgBoxStyle.OkOnly, "Ingresar El Numero de Factura.!!!")
            If Mensaje = MsgBoxResult.Ok Then
                TxtNCr.Visible = True
                TxtNCr.Focus()
            End If
        ElseIf CmbMenu.Text = "Factura Manual" And TxtNumFac.Text = "" Then
            Mensaje = MsgBox("Tiene que Ingresar el Numero  o Punto de Venta de la Factura", MsgBoxStyle.OkOnly, "Ingresar El Numero de Factura.!!!")
            If Mensaje = MsgBoxResult.Ok Then
                Grupo.Visible = True
                TxtPv.Focus()
            End If
        Else
            EsCl = "3"
            FrmBcl.Show()
        End If

        
    End Sub

    Private Sub CmdBart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdBart.Click
        IdCom = 0
        EsAr = 1
        FrmBarticulos.Show()

    End Sub

    Private Sub MskPunit_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MskPunit.GotFocus
        MskPunit.SelectionStart = 0
        MskPunit.SelectionLength = MskPunit.Text.Length
    End Sub

    Private Sub MskPunit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MskPunit.KeyDown
        'If Not ((e.KeyValue >= 48 And e.KeyValue <= 57) OrElse (e.KeyValue >= 96 And e.KeyValue <= 105) OrElse (e.KeyValue = 8) OrElse (e.KeyValue = 190) OrElse (e.KeyValue = 13)) Then
        ' e.Handled = True
        ' MsgBox("Permite solamente Numeros")
        ' MskPunit.Text = vbNullChar
        'End If
        If e.KeyCode = Keys.Return Then
            MskCantidad.Focus()
        End If
    End Sub

    Private Sub mskpunit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MskPunit.KeyPress
        'Dim sep As Char
        'sep = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        ' If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar.Equals(sep) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = False
        End If
    End Sub

    Private Sub MskPunit_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MskPunit.LostFocus
        Punit1 = Decimal.Parse(MskPunit.Text, System.Globalization.CultureInfo.GetCultureInfo("es-us"))
        'Punit1 = Str(MskPunit.Text)
    End Sub

    Private Sub MskPunit_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles MskPunit.MaskInputRejected

    End Sub

    Private Sub MskCantidad_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MskCantidad.GotFocus
        '   MskPunit.Text = Decimal.Parse(Punit1, System.Globalization.CultureInfo.GetCultureInfo("es-us"))
        'MskPunit.Text = Str(Punit1)
        MskCantidad.SelectionStart = 0
        MskCantidad.SelectionLength = MskCantidad.Text.Length
    End Sub

    Private Sub MskCantidad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MskCantidad.KeyDown
        'If Not ((e.KeyValue >= 48 And e.KeyValue <= 57) OrElse (e.KeyValue >= 96 And e.KeyValue <= 105) OrElse (e.KeyValue = 8) OrElse (e.KeyValue = 190) OrElse (e.KeyValue = 13)) Then
        ' e.Handled = True
        ' MsgBox("Permite solamente Numeros")
        ' MskCantidad.Text = vbNullChar
        If e.KeyCode = Keys.Return Then
            If EsCant = 0 Then
                MskDescuento.Enabled = True
                MskDescuento.Focus()
            ElseIf EsCant = 1 Then
                Punit1 = MskPunit.Text
                Cantidad = MskCantidad.Text
                Ptotal = MskPunit.Text * Cantidad
                PtotalM = MskPunit.Text * Cantidad
                Guardar()
            End If
        End If
    End Sub

    Private Sub mskcantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MskCantidad.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = False
        End If
    End Sub


    Private Sub MskCantidad_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MskCantidad.LostFocus
        Try

            'Punit1 = Decimal.Parse(MskPunit.Text, System.Globalization.CultureInfo.GetCultureInfo("es-es"))
            Cantidad = Decimal.Parse(MskCantidad.Text, System.Globalization.CultureInfo.GetCultureInfo("es-us"))
            Ptotal = FormatNumber(Punit1 * Cantidad, 2)
            MskPtotal.Text = Str(Ptotal)
            ' MskPunit.Text = 0
            ' MskPunit.Text = Str(Punit1)
            ' MskCantidad.Text = Str(Cantidad)
        Catch ex As Exception
            Mensaje = MsgBox("Se Han Ingresados Caracteres Erroneos: ", MsgBoxStyle.OkOnly, "Informacion Fallida!!!")
            If Mensaje = MsgBoxResult.Ok Then
                MskPunit.Focus()
                MskPtotal.Text = 0
            End If
        End Try

        'End If

    End Sub

    Private Sub TxtArticulo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtArticulo.Click
        Panel1.Visible = False
        Panel2.Visible = False
        IdCom = 0
    End Sub

    Private Sub TxtArticulo_GiveFeedback(ByVal sender As Object, ByVal e As System.Windows.Forms.GiveFeedbackEventArgs) Handles TxtArticulo.GiveFeedback

    End Sub
    Private Sub TxtArticulo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtArticulo.GotFocus
        TxtArticulo.SelectionStart = 0
        TxtArticulo.SelectionLength = TxtArticulo.Text.Length
    End Sub

    Private Sub TxtArticulo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtArticulo.KeyDown
        If e.KeyCode = Keys.Return Then
            If CmbMenu.Text = "Presupuesto" Then
                EsCom = 0
            ElseIf CmbMenu.Text = "Factura" Then
                EsCom = 1
            ElseIf CmbMenu.Text = "Factura Manual" Then
                EsCom = 1
            ElseIf CmbMenu.Text = "Remito" Then
                EsCom = 1
            ElseIf CmbMenu.Text = "Nota de Credito" Then
                EsCom = 2
            End If
            If TxtArticulo.Text = "" Then
                FrmBarticulos.Show()
            End If
            'Descrimino el Codigo de Barra de la balanza
            If TxtArticulo.Text = "" Then
            Else
                Barra = TxtArticulo.Text
                TxtBarra.Text = Barra
                Largo = Len(Barra)
                Primero = Mid(Barra, 1, 1)
                If Largo = 13 And Primero = 2 Then
                    BarId = Mid(Barra, 3, 4)
                    Entero = Mid(Barra, 8, 3)
                    Decim = Mid(Barra, 11, 3)
                    Tot = FormatNumber(Entero + "." + Decim)
                Else
                    BarId = Barra
                End If
                Dim dsdataset As New DataSet
                dsdataset = MiClase.traedataset("select barra from articulos where barra=" & BarId & "")
                Dim totalregistros As Integer = dsdataset.Tables(0).Rows.Count
                If totalregistros = 0 Then
                    MsgBox("Este codigo de barra no existe, Debes agregarlo a la base de datos", MsgBoxStyle.Critical)

                Else
                    TxtArticulo.Focus()
                    misdatos = MiClase.traedataset("select barra,articulo,pfinal,idpr,idfm,idmr,idact,alic,idiv from articulos where barra=" & BarId & "")
                    TxtArticulo.Text = Trim(misdatos.Tables(0).Rows(0).Item(1))
                    MskPunit.Text = FormatNumber(misdatos.Tables(0).Rows(0).Item(2))
                    Punit1 = FormatNumber(misdatos.Tables(0).Rows(0).Item(2))
                    IdPr = FormatNumber(misdatos.Tables(0).Rows(0).Item(3))
                    IdMr = FormatNumber(misdatos.Tables(0).Rows(0).Item(4))
                    IdFm = FormatNumber(misdatos.Tables(0).Rows(0).Item(5))
                    IdAct = FormatNumber(misdatos.Tables(0).Rows(0).Item(6))
                    Alic1 = FormatNumber(misdatos.Tables(0).Rows(0).Item(7))
                    IdIva = FormatNumber(misdatos.Tables(0).Rows(0).Item(8))
                    
                    If MskCantidad.Text = "" Then
                        MskCantidad.Text = 1
                    End If
                    If Largo = 13 And Primero = 2 Then
                        MskCantidad.Text = FormatNumber(Tot / MskPunit.Text, 2)
                        txtTotal.Text = Tot
                        Ptotal = Tot
                    Else
                        MskCantidad.Text = 1
                        Cantidad = MskCantidad.Text
                        Tot = Punit1 * MskCantidad.Text
                        MskPtotal.Text = Tot
                        Ptotal = Tot
                    End If
                    ''''''''''''''''''''''
                    If EsCant = 1 Then
                        MskCantidad.Focus()
                    Else
                        Guardar()
                    End If
                 

                    End If
            End If
        ElseIf e.KeyCode = Keys.F4 Then
            If CmbMenu.Text = "Presupuesto" Then
                EsCom = 0
                DtgPag.Visible = False
                Group.Visible = True
                Lb.Text = "Pago Efectivo"
            ElseIf CmbMenu.Text = "Factura" Then
                MskImp.Text = txtTotal.Text
                EsCom = 1
                IdCom = 1
                DtgPag.Visible = True
                Group.Visible = False
                Lb.Text = "Pago Efectivo"
            ElseIf CmbMenu.Text = "Remito" Then
                MskImp.Text = txtTotal.Text
                EsCom = 1
                IdCom = 1
                DtgPag.Visible = True
                Group.Visible = False
                Lb.Text = "Pago Efectivo"
            ElseIf CmbMenu.Text = "Factura Manual" Then
                MskDescGral.Enabled = False
                EsCom = 1
                IdCom = 1
                DtgPag.Visible = True
                Group.Visible = False
                Lb.Text = "Pago Efectivo"
            ElseIf CmbMenu.Text = "Nota De Credito" Then
                MskDescGral.Enabled = False
                EsCom = 2
                IdCom = 1
                DtgPag.Visible = True
                Group.Visible = False
                Lb.Text = "Pago Efectivo"
            End If
            If EsCom = 0 Then
                Panel1.Visible = True
                GroupBox4.Enabled = False
                TxtOb.Focus()
                'Group.Visible = True
                CmdFactura.Enabled = True
            ElseIf EsCom = 1 Then
                Panel1.Visible = True
                TxtNCh.Visible = False
                'Group.Visible = True
                GroupBox4.Enabled = True
                EsVenta = 0
                Cventa = "Contado"
                If TxtCli.Text = "" Then
                    CmdCta.Enabled = False
                Else
                    CmdCta.Enabled = True
                End If
                MskImp.Focus()
                If TxtCli.Text = "" Then
                    CmdCta.Enabled = False
                End If
                MskImp.Enabled = True
                MskImp.Focus()
            ElseIf EsCom = 2 Then
                Panel1.Visible = True
                TxtNCh.Visible = False
                'Group.Visible = False
                GroupBox4.Enabled = True
                EsVenta = 0
                Cventa = "Contado"
                MskImp.Enabled = False
                CmdFactura.Enabled = True
                CmdTarjeta.Enabled = False
                CmdCheque.Enabled = False
                BtnFin.Enabled = False
                CmdFactura.Focus()
            End If
        ElseIf e.KeyCode = Keys.F1 Then
            EsCant = 1
            If EsCant = 0 Then
                LbCan.Visible = False
                Guardar()
            ElseIf EsCant = 1 Then
                MskCantidad.Enabled = True
                '        MskCantidad.Focus()
                LbCan.Visible = True
            End If
            EsCant = 1
        End If


    End Sub

    Private Sub TxtCli_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCli.Click
        Panel1.Visible = False
        'Blanquear()
    End Sub
    Private Sub MskPtotal_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MskPtotal.GotFocus
        MskPtotal.SelectionStart = 0
        MskPtotal.SelectionLength = MskPtotal.Text.Length
    End Sub

    Private Sub MskPtotal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MskPtotal.KeyDown
        If e.KeyCode = Keys.Return Then
            Guardar()
        End If
    End Sub
    Private Sub CmdTarjeta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub MskImp_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MskImp.GotFocus
        '  MskImp.Text = txtTotal.Text
        MskImp.SelectionStart = 0
        MskImp.SelectionLength = MskImp.Text.Length
    End Sub
    Private Sub Car_Pago()
        If LCom = 0 Then
            LCom = 1
        End If
        If TxtNCh.Text = "" Then
            TxtNCh.Text = "0"
        End If
        If TxtPag.Text = "" Then
            TxtPag.Text = "Efectivo"
            TxtNCh.Text = "0"
            IdCom = 1
            ' ImpTot = MskImp.Text
        End If
        ' ImpTot = Str(MskImp.Text)
        '  ImpTot = Decimal.Parse(MskImp.Text, System.Globalization.CultureInfo.GetCultureInfo("es-es"))
        '  ImpTot = MskImp.Text
        ' Fc = Date.Today
        ' Fc = Format(Date.Today, "dd/MM/yy")

        MiClase.eliminaactualizaregistra("insert into tpago  values(" & LCom & "," & Pc & "," & IdCom & ",'" & TxtPag.Text & " ', " & _
                 "" & TxtNCh.Text & "," & Str(ImpTot) & ",'" & DtcVenc.Text & "'," & Str(MskImp.Text) & ")")
        LCom = LCom + 1
        MiClase.cargardatagriview(DtgPag, "select comprobante,numero,importe,linea,idcom,vencimiento from tpago where pc=" & Pc & " ")
        DtgPag.Font = New Font("Arial ", 12, FontStyle.Regular)
        DtgPag.ColumnHeadersVisible = False
        DtgPag.AllowUserToAddRows = False
        DtgPag.Columns(2).DefaultCellStyle.Format = "##,##0.00"
        DtgPag.Columns(3).Visible = False
        DtgPag.Columns(4).Visible = False
        DtgPag.Columns(5).Visible = False
        TxtPag.Clear()
        TxtNCh.Clear()
        misdatos = MiClase.traedataset("select sum(importe) from tpago where pc=" & Pc & "")
        TotPago = misdatos.Tables(0).Rows(0).Item(0)
        MskImp.Text = FormatNumber(txtTotal.Text - TotPago, 2)
        IdCom = 1
        txtNumero.Visible = True
        TxtPag.Enabled = False
        txtNumero.Enabled = False
        txtNumero.Text = ""
        MskImp.Enabled = True
        TxtNCh.Visible = False
        EsVenta = 0
        Cventa = "Contado"
        Lb.Text = "Pago Efectivo"
        DtcVenc.Value = Date.Today
        DtcVenc.Enabled = False
        MskImp.Focus()
        CmdFactura.Enabled = True
    End Sub
    Private Sub Car_Pago1()
        Dim ImpTot As Decimal
        If LCom = 0 Then
            LCom = 1
        End If
        If TxtNCh.Text = "" Then
            TxtNCh.Text = "0"
        End If
        If TxtPag.Text = "" Then
            TxtPag.Text = "Efectivo"
            TxtNCh.Text = "0"
            IdCom = 1
            ImpTot = MskImp.Text
        End If
        ImpTot = MskImp.Text

        MiClase.eliminaactualizaregistra("insert into tpago  values(" & LCom & "," & Pc & "," & IdCom & ",'" & TxtPag.Text & " ', " & _
                 "" & TxtNCh.Text & "," & ImpTot & ")")
        LCom = LCom + 1
        MiClase.cargardatagriview(DtgPag, "select comprobante,numero,importe,linea,idcom from tpago where pc=" & Pc & " ")
        DtgPag.Font = New Font("Arial ", 12, FontStyle.Regular)
        DtgPag.ColumnHeadersVisible = False
        DtgPag.AllowUserToAddRows = False
        DtgPag.Columns(2).DefaultCellStyle.Format = "##,##0.00"
        DtgPag.Columns(3).Visible = False
        DtgPag.Columns(4).Visible = False
        TxtPag.Clear()
        TxtNCh.Clear()
        misdatos = MiClase.traedataset("select sum(importe) from tpago where pc=" & Pc & "")
        TotPago = misdatos.Tables(0).Rows(0).Item(0)
        MskImp.Text = FormatNumber(txtTotal.Text - TotPago, 2)
        MskImp.Focus()
        CmdFactura.Enabled = True
    End Sub
    Private Sub MskImp_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MskImp.KeyDown
        If e.KeyCode = Keys.Return Then
            TotFac = txtTotal.Text
            TotPago = MskImp.Text
            If TotPago = TotFac Then
                ImpTot = TotFac
                EsPag = 0
                Car_Pago()
            ElseIf TotPago < TotFac Then
                EsPag = 0
                Car_Pago()
            ElseIf TotPago > TotFac Then
                Dim DD As Decimal
                DD = TotPago - TotFac
                ImpTot = TotFac
                '        Mensaje = MsgBox("El Pago es mayor al importe de la factura", MsgBoxStyle.YesNo, "Desea Cargar el Pago!!!")
                '       If Mensaje = MsgBoxResult.Yes Then
                Car_Pago()
                'End If
            End If
            MskDescGral.Focus()
        End If
    End Sub

    'Private Sub CmbTarjeta_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbTarjeta.KeyDown
    '   If e.KeyCode = Keys.Return Then
    '      txtNumero.Focus()
    ' End If
    'End Sub
    Private Sub txtNumero_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNumero.GotFocus
        txtNumero.SelectionStart = 0
        txtNumero.SelectionLength = txtNumero.Text.Length
    End Sub

    Private Sub txtNumero_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNumero.KeyDown
        If e.KeyCode = Keys.Return Then
            MskImp.Focus()
        End If
    End Sub
    Private Sub Dtgart_CellClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dtgart.CellClick
        misdatos = MiClase.traedataset("select linea from t_detalfac where linea=" & Dtgart.Rows(e.RowIndex).Cells(5).Value() & " ")
        Dlin = misdatos.Tables(0).Rows(0).Item(0)
    End Sub

    Private Sub Dtgart_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Dtgart.KeyDown
        If e.KeyCode = Keys.Delete Then
            MiClase.eliminaactualizaregistra("delete from t_detalfac where linea=" & Dlin & "and idpc=" & Pc & "")
            Dtgart.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
            MiClase.cargardatagriview(Dtgart, "select articulo,punit,cantidad,descu,ptotal,linea,barra,idpr,idmr,idfm,alic,idiv,ptotalm,idact from t_detalFac where idpc=" & Pc & " order by linea ")
            Dtgart.Font = New Font("Arial ", 14, FontStyle.Regular)
            Dtgart.ColumnHeadersVisible = False
            Dtgart.AllowUserToAddRows = False
            'Dtgart.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Dtgart.Columns(0).Width = 360
            Dtgart.Columns(1).DefaultCellStyle.Format = "##,##0.00"
            Dtgart.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            Dtgart.Columns(2).DefaultCellStyle.Format = "##,##0.00"
            Dtgart.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            Dtgart.Columns(3).DefaultCellStyle.Format = "##,##0.00"
            Dtgart.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            Dtgart.Columns(4).DefaultCellStyle.Format = "##,##0.00"
            Dtgart.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            Dtgart.Columns(12).DefaultCellStyle.Format = "##,##0.00"
            Dtgart.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            Dtgart.Columns(4).Visible = False
            Dtgart.Columns(5).Visible = False
            Dtgart.Columns(6).Visible = False
            Dtgart.Columns(7).Visible = False
            Dtgart.Columns(8).Visible = False
            Dtgart.Columns(9).Visible = False
            Dtgart.Columns(10).Visible = False
            Dtgart.Columns(11).Visible = False
            misdatos = MiClase.traedataset("select isnull(sum(ptotalm),0) from t_detalfac where idpc=" & Pc & "")
            txtTotal.Text = FormatNumber(misdatos.Tables(0).Rows(0).Item(0), 2)
            TxtArticulo.Text = ""
            MskCantidad.Text = ""
            MskPunit.Text = ""
            MskDescuento.Text = 0
            MskPtotal.Text = ""
            MskPunit.Enabled = False
            MskCantidad.Enabled = False
            MskDescuento.Enabled = False
            MskPtotal.Enabled = False
            PtotalM = 0
            TxtArticulo.Focus()
            'MiClase.cargardatagriview(Dtgart, "select articulo,punit,cantidad,ptotal,linea from t_detalFac order by linea desc ")
            'Dtgart.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
            'MiClase.cargardatagriview(Dtgart, "select articulo,punit,cantidad,ptotal,linea from t_detalFac order by linea desc ")
            'Dtgart.Font = New Font("Arial ", 14, FontStyle.Regular)
            'Dtgart.ColumnHeadersVisible = False
            'Dtgart.AllowUserToAddRows = False
            'Dtgart.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            'Dtgart.Columns(1).DefaultCellStyle.Format = "##,##0.00"
            'Dtgart.Columns(2).DefaultCellStyle.Format = "##,##0.00"
            'Dtgart.Columns(3).DefaultCellStyle.Format = "##,##0.00"
            'Dtgart.Columns(4).Visible = False
            'misdatos = MiClase.traedataset("select  isnull(sum(ptotal),0) from t_detalfac")
            'txtTotal.Text = FormatNumber(misdatos.Tables(0).Rows(0).Item(0), 2)
            TxtArticulo.Focus()
        End If
    End Sub
    Private Sub CmdFactura_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmdFactura.GotFocus
        'If MskImp.Text = "" Then
        ' MskImp.Text = txtTotal.Text
        ' Else
        ' Txtvuelto.Text = FormatNumber(MskImp.Text - txtTotal.Text)
        ' Me.MskImp.Text = Format(CType(Me.MskImp.Text, Decimal), "#,##0.00")
        ' End If
    End Sub

    Private Sub CmdTarjeta_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdTarjeta.Click
        EsPago = 5
        FrmBpag.Show()
        TxtPag.Enabled = True
        txtNumero.Enabled = True
        txtNumero.Visible = True
        MskImp.Enabled = True
        Lbtar.Text = "Tarjeta :"
        txtNumero.Text = ""
        TxtNCh.Visible = False
        TxtNCh.Text = ""
        EsVenta = 0
        Cventa = "Contado"
        IdCom = 2
        IdCuota = 0
        Lb.Text = "pago Con Tarjeta"
        Panel2.Visible = False
    End Sub

    Private Sub CmdCheque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCheque.Click
        EsPago = 1
        FrmBpag.Show()
        TxtPag.Enabled = True
        TxtPag.Visible = True
        txtNumero.Enabled = False
        txtNumero.Visible = False
        Lbtar.Text = "Cheque :"
        txtNumero.Text = ""
        TxtNCh.Visible = True
        EsVenta = 0
        Cventa = "Contado"
        IdCom = 3
        Lb.Text = "Pago Con Cheque"
        IdCuota = 0
        Panel2.Visible = False
    End Sub

    Private Sub Cmdefectivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmdefectivo.Click
        IdCom = 1
        txtNumero.Visible = True
        TxtPag.Enabled = False
        txtNumero.Enabled = False
        txtNumero.Text = ""
        MskImp.Enabled = True
        TxtNCh.Visible = False
        EsVenta = 0
        Cventa = "Contado"
        Lb.Text = "Pago Efectivo"
        Panel2.Visible = False
        MskImp.Focus()
    End Sub

    Private Sub CmdCta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCta.Click
        TxtPag.Enabled = False
        txtNumero.Enabled = False
        txtNumero.Text = ""
        MskImp.Text = ""
        MskImp.Enabled = False
        TxtNCh.Visible = False
        CmdFactura.Enabled = True
        EsVenta = 1
        Cventa = "Cta.Cte"
        CmdFactura.Focus()
        IdCom = 4
        Lb.Text = "Cta.Cte."
        IdCuota = 0
        Panel2.Visible = False
        If CmbMenu.Text = "Nota De Credito" And EsVenta = 1 Then
            If IdCiva = 1 Then
                IdTp = 1
            Else
                IdTp = 6
            End If
            'EntCta = Decimal.Parse(txtTotal.Text, System.Globalization.CultureInfo.GetCultureInfo("es-es"))
            MiClase.cargardatagriview(DtgNc, "select ctacte.lnum,fecha,importe,entrega,saldo,numero,idtp,cuota,fecven,idcl from ctacte where numero=" & Val(TxtNCr.Text) & "and idtp=" & Val(IdTp) & "order by cuota desc")
            DtgNc.AllowUserToAddRows = False
            Dim filas As Integer = DtgNc.Rows.Count
            For i As Integer = 0 To filas - 1
                If IsDBNull(Convert.ToString(DtgNc(0, i).Value)) Then
                Else
                    Lnum = Trim(Convert.ToString(DtgNc(0, i).Value))
                End If
                If IsDBNull(Convert.ToString(DtgNc(1, i).Value)) Then
                Else
                    fecha = Convert.ToString(DtgNc(1, i).Value)
                End If
                If IsDBNull(Convert.ToString(DtgNc(2, i).Value)) Then
                Else
                    importe = Convert.ToDecimal(DtgNc(2, i).Value)
                End If
                If IsDBNull(Convert.ToString(DtgNc(3, i).Value)) Then
                Else
                    Entrega = Convert.ToDecimal(DtgNc(3, i).Value)
                End If
                If IsDBNull(DtgNc(4, i).Value) Then
                Else
                    Saldo = Convert.ToDecimal(DtgNc(4, i).Value)
                End If
                If IsDBNull(Convert.ToString(DtgNc(5, i).Value)) Then
                Else
                    NumFac = Convert.ToString(DtgNc(5, i).Value)
                End If
                If IsDBNull(Convert.ToString(DtgNc(6, i).Value)) Then
                Else
                    IdTp = Convert.ToDouble(DtgNc(6, i).Value)
                End If
                If IsDBNull(Convert.ToString(DtgNc(7, i).Value)) Then
                Else
                    Cuota = Convert.ToDecimal(DtgNc(7, i).Value)
                End If
                If IsDBNull(Convert.ToString(DtgNc(9, i).Value)) Then
                Else
                    IdCl1 = Convert.ToString(DtgNc(9, i).Value)
                End If
            Next
            If filas = 0 Then
                Mensaje = MsgBox("No Hay Factura en Cta.Cte", MsgBoxStyle.OkOnly, "Asociar Factura!!!")
                If Mensaje = MsgBoxResult.Ok Then
                    TxtArticulo.Focus()
                End If
            End If
            If Idcl = IdCl1 Then
            Else
                Mensaje = MsgBox("Este cliente no pertence a la factura en Cta.Cte", MsgBoxStyle.OkOnly, "cliente no Asociado Factura!!!")
                If Mensaje = MsgBoxResult.Ok Then
                    TxtArticulo.Focus()
                End If
            End If
           
        End If




    End Sub

  

    Private Sub MskImp_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles MskImp.MaskInputRejected
       
    End Sub

    Private Sub TxtCli_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCli.GotFocus

    End Sub

    Private Sub TxtCli_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCli.KeyDown
        If e.KeyCode = Keys.F1 Then
            TxtDir.Enabled = True
            TxtcIva.Enabled = True
            MskCuit.Enabled = True
            TxtCiudad.Enabled = True
        ElseIf e.KeyCode = Keys.Return Then
            If CmbMenu.Text = "Nota De Credito" And TxtNCr.Text = "" Then
                Mensaje = MsgBox("Tiene que Ingresar el Numero Original de la Factura", MsgBoxStyle.OkOnly, "Ingresar El Numero de Factura.!!!")
                If Mensaje = MsgBoxResult.Ok Then
                    TxtNCr.Visible = True
                    TxtNCr.Focus()
                End If
            ElseIf CmbMenu.Text = "Factura Manual" And TxtNumFac.Text = "" Then
                Mensaje = MsgBox("Tiene que Ingresar el Numero  o Punto de Venta de la Factura", MsgBoxStyle.OkOnly, "Ingresar El Numero de Factura.!!!")
                If Mensaje = MsgBoxResult.Ok Then
                    Grupo.Visible = True
                    TxtPv.Focus()
                End If
            Else
                EsCl = "3"
                FrmBcl.Show()
            End If

            'TxtDir.Focus()
        End If
    End Sub



    Private Sub TxtNCh_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtNCh.KeyDown
        If e.KeyCode = Keys.Return Then
            DtcVenc.Enabled = True
            DtcVenc.Focus()
        End If
    End Sub

    Private Sub TxtNCh_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNCh.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtNumero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumero.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtNumero_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumero.TextChanged

    End Sub

    Private Sub mskptotal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MskPtotal.KeyPress
        Dim sep As Char
        sep = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar.Equals(sep) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub CmdFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdFactura.Click
        'DtcFc.Text = Date.Today
        CmdFactura.Enabled = False
        If IdCom = 5 Then
            misdatos = MiClase.traedataset("select isnull(sum(importe),0) from tcuotas where pc=" & Pc & "")
            TotCta = FormatNumber(misdatos.Tables(0).Rows(0).Item(0))
            TotCuo = NetCuo
            Guardar()
        End If
        'If EsCom = 1 Or EsCom = 2 Then 'factura
        If BlNg = 0 Then
            'Factura electronica
            If Fact = 0 Then
                Fac_Elec()
                'factura epson
            ElseIf Fact = 1 Then
                FacEpson()
                'Factura hasar
            ElseIf Fact = 2 Then
                FacHasar()
            ElseIf Fact = 3 Then
                FacHasFm()
                'Factura Manual
            ElseIf Fact = 10 Then
                FacManual()
            End If

        ElseIf BlNg = 1 Then
            If CmbMenu.Text = "Remito" Then
                IdTp = 4
                misdatos = MiClase.traedataset("select isnull(max(numero),0) from facturas where idtp=" & 4 & "")
                cbte_nro = misdatos.Tables(0).Rows(0).Item(0) + 1

            ElseIf CmbMenu.Text = "Presupuesto" Then
                misdatos = MiClase.traedataset("select isnull(max(numero),0) from facturas where idtp=" & 13 & "")
                cbte_nro = misdatos.Tables(0).Rows(0).Item(0) + 1
                IdTp = 7
            End If
            'End If 'aca
            ''Grabo la Factura
            Fnum()
            'AlIv = alic / 100 + 1
            'Neto = FormatNumber(txtTotal.Text / AlIv, 2)
            'Iva = FormatNumber(txtTotal.Text - Neto, 2)
            ' Total = txtTotal.Text
            Fech = Date.Today
            FecVen = Fech.Date.Date.AddDays(30)
            If TxtOb.Text = "" Then
                TxtOb.Text = "."
            End If
            If TxtOb1.Text = "" Then
                TxtOb1.Text = "."
            End If
            'Cargo  los Items
            Dim filas As Integer = Dtgart.Rows.Count
            Dim contador As Integer = 0
            For i As Integer = 0 To filas - 1
                If IsDBNull(Convert.ToString(Dtgart(0, i).Value)) Then
                Else
                    Articulo = Convert.ToString(Dtgart(0, i).Value)
                End If

                If IsDBNull(Convert.ToString(Dtgart(1, i).Value)) Then
                Else
                    Punt1 = Convert.ToDecimal(Dtgart(1, i).Value)
                End If

                If IsDBNull(Convert.ToString(Dtgart(2, i).Value)) Then
                Else
                    Cantidad = Convert.ToDecimal(Dtgart(2, i).Value)
                End If
                If IsDBNull(Convert.ToString(Dtgart(4, i).Value)) Then
                Else
                    Ptotal = Convert.ToDecimal(Dtgart(4, i).Value)
                End If
                If IsDBNull(Convert.ToString(Dtgart(5, i).Value)) Then
                Else
                    LinCom = (Dtgart(5, i).Value)
                End If
                If IsDBNull(Convert.ToString(Dtgart(6, i).Value)) Then
                Else
                    BarFac = Convert.ToDecimal(Dtgart(6, i).Value)
                End If
                If IsDBNull(Convert.ToString(Dtgart(7, i).Value)) Then
                Else
                    IdPr = Convert.ToDecimal(Dtgart(7, i).Value)
                End If
                If IsDBNull(Convert.ToString(Dtgart(8, i).Value)) Then
                Else
                    IdMr = Convert.ToDecimal(Dtgart(8, i).Value)
                End If
                If IsDBNull(Convert.ToString(Dtgart(9, i).Value)) Then
                Else
                    IdFm = Convert.ToDecimal(Dtgart(9, i).Value)
                End If
                If IsDBNull(Convert.ToString(Dtgart(10, i).Value)) Then
                Else
                    alic = Convert.ToDecimal(Dtgart(10, i).Value)
                End If
                If IsDBNull(Convert.ToString(Dtgart(11, i).Value)) Then
                Else
                    IdAlic = Convert.ToDecimal(Dtgart(11, i).Value)
                End If
                If IsDBNull(Convert.ToString(Dtgart(12, i).Value)) Then
                Else
                    PtotalM = Convert.ToDecimal(Dtgart(12, i).Value)
                End If
                If IsDBNull(Convert.ToString(Dtgart(13, i).Value)) Then
                Else
                    IdAct = Convert.ToString(Dtgart(13, i).Value)
                End If
                FcD = Date.Today
                FcD = Format(Date.Today, "dd/MM/yy")
                '  Fnum()
                'Grabo el detalle de factura
                MiClase.eliminaactualizaregistra("insert into detal_fac values(" & cbte_nro & "," & IdTp & " ," & LinCom & "," & Pv & ",'" & FcD & "', " & _
                "" & BarFac & ",'" & Articulo & "'," & Str(Punit1) & "," & Str(Cantidad) & "," & Str(Ptotal) & "," & IdFm & "," & IdMr & "," & IdPr & ", " & _
               "" & Str(alic) & "," & Idcl & "," & IdEnc & "," & EsVenta & ",'" & Cventa & "'," & IdAlic & "," & BlNg & ",'" & Clave & "'," & IdAct & "," & IdUs & ")")
                LinCom = LinCom + 1
                'Descuelnto el Stock
                If CmbMenu.Text = "Remito" Then
                    If BarFac = 0 Then
                    Else
                        Barra = BarFac
                        Largo = Len(Barra)
                        Primero = Mid(Barra, 1, 1)
                        If Largo = 13 And Primero = 2 Then
                        Else
                            misdatos = MiClase.traedataset("select isnull((stock),0) from articulos where barra=" & BarFac & "")
                            Stock = misdatos.Tables(0).Rows(0).Item(0) - Cantidad
                            MiClase.eliminaactualizaregistra("update articulos set stock = " & Stock & " where barra=" & BarFac & "")
                        End If
                    End If
                End If
            Next
            misdatos = MiClase.traedataset("select isnull( sum(importe),0) from tcuotas")
            TotalGral = FormatNumber(misdatos.Tables(0).Rows(0).Item(0), 2)

            FcH = FecVen
            FcH = Format(FecVen, "dd/MM/yy")
            MiClase.eliminaactualizaregistra("insert into facturas values(" & cbte_nro & "," & IdTp & ", " & _
             "" & Pv & "," & IdEnc & "," & Idcl & ",'" & FcD & "'," & EsVenta & ",'" & Cventa & "'," & Str(NetT) & ", " & _
             "" & Str(IvT) & "," & Str(Iint) & "," & Str(txtTotal.Text) & "," & BlNg & "," & Str(alic) & ",'" & FcH & "','" & Clave & "'," & 0 & ", " & _
             "'" & TxtOb.Text & "','" & TxtOb1.Text & "','" & TxtCli.Text & "','" & TxtDir.Text & "','" & TxtCiudad.Text & "'," & _
             "'" & TxtcIva.Text & "','" & MskCuit.Text & "'," & IdCiva & ",'" & TxtCpostal.Text & "'," & IdPrv & "," & IdUs & ")")

            'Grabo para la Cuenta Corriente
            If EsVenta = 1 And IdCuota = 0 Then
                '  If Str(EsVenta) = 1 Then
                TTotal = txtTotal.Text
                'TTotal = Decimal.Parse(txtTotal.Text, System.Globalization.CultureInfo.GetCultureInfo("es-es"))
                'FecVen = (DateAdd(DateInterval.Day, 30, Date.Today))
                Fc = DtcFech.Value
                Fc = Format(DtcFech.Value, "dd/MM/yy")
                FecVen = Mid(DateAdd(DateInterval.Month, 1, Fc), 1, 10)
                MiClase.eliminaactualizaregistra("insert into ctacte values(" & cbte_nro & "," & IdTp & "," & NumCuo & ", " & _
                 "" & Idcl & "," & IdEnc & ",'" & FcD & "','" & FcH & "'," & Str(TTotal) & "," & Str(Entrega) & "," & Str(TTotal) & "," & BlNg & ",'" & Clave & "'," & IdUs & ")")

                ' ToTT = TtoTT - MskEntrega.Text
                MiClase.eliminaactualizaregistra("insert into fac_cta values(" & cbte_nro & "," & IdTp & ", " & _
                "" & Idcl & ",'" & TxtCli.Text & "','" & TxtDir.Text & "','" & TxtCiudad.Text & "','" & TxtcIva.Text & "','" & FcD & "', " & _
               "" & Str(TTotal) & "," & 0 & "," & Str(TTotal) & ",'" & Clave & "'," & BlNg & "," & IdUs & ")")

                misdatos = MiClase.traedataset("select isnull( (salcli),0) from clientes where id=" & Idcl & "")
                Saldo = misdatos.Tables(0).Rows(0).Item(0)
                Saldo = Saldo + txtTotal.Text
                MiClase.eliminaactualizaregistra("update clientes set salcli='" & Saldo & "'where id=" & Idcl & "")
                If MskEntrega.Text = "" Then
                    MskEntrega.Text = 0
                End If
            End If

            'Cargo los pagos
            If EsVenta = 0 Then
                Dim fil As Integer = DtgPag.Rows.Count
                Dim cont As Integer = 0
                For i As Integer = 0 To fil - 1
                    If IsDBNull(Convert.ToString(DtgPag(0, i).Value)) Then
                    Else
                        Comprobante = Convert.ToString(DtgPag(0, i).Value)
                    End If

                    If IsDBNull(Convert.ToDouble(DtgPag(1, i).Value)) Then
                    Else
                        NumPag = Convert.ToDouble(DtgPag(1, i).Value)
                    End If
                    If IsDBNull(Convert.ToDecimal(DtgPag(2, i).Value)) Then
                    Else
                        ImPag = Convert.ToDecimal(DtgPag(2, i).Value)
                    End If
                    If IsDBNull(Convert.ToDouble(DtgPag(3, i).Value)) Then
                    Else
                        Dln = Convert.ToDouble(DtgPag(3, i).Value)
                    End If
                    If IsDBNull(Convert.ToDouble(DtgPag(4, i).Value)) Then
                    Else
                        IdCom = Convert.ToDouble(DtgPag(4, i).Value)
                    End If
                    If IsDBNull(Convert.ToString(DtgPag(5, i).Value)) Then
                    Else
                        FechCh = Convert.ToString(DtgPag(5, i).Value)
                    End If
                    MiClase.eliminaactualizaregistra("insert into pagos values(" & cbte_nro & "," & IdTp & ", " & _
                    "" & Dln & "," & Idcl & "," & IdCom & ",'" & FcD & "','" & Comprobante & "'," & NumPag & "," & Str(ImPag) & ", " & _
                    "" & 1 & "," & BlNg & "," & Pc & "," & IdUs & ")")
                    If IdCom = 3 Then
                        MiClase.eliminaactualizaregistra("insert into che_cartera values(" & Idcl & ",'" & TxtCli.Text & "', " & _
                        "'" & Comprobante & "'," & NumPag & ",'" & FechCh & "'," & Str(ImPag) & "," & 0 & "," & IdUs & ")")
                    End If
                Next
            End If
            'Imprimo el remito
            If IdTp = 4 Or IdTp = 7 Then
                Imp_tick()
            End If
        End If 'aca
        Blanquear()
        TxtArticulo.Focus()
        ' End If
        'ElseIf EsCom = "0" Then 'presupuesto

        ' BlNg = 2
        EsVenta = "0"
        Cventa = "Contado"
        'End If
        If TxtCli.Text = "" Then
            IdCiva = "5"
        End If

    End Sub

    Private Sub CArticulos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CArticulos.Click
        FrmInArticulos.Show()
    End Sub

    Private Sub CmdFactura_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmdFactura.KeyDown
        If e.Control And e.KeyCode = Keys.A Then
            If BlNg = 0 Then
                BlNg = 1
                CblNg.Visible = True
            ElseIf BlNg = 1 Then
                BlNg = 0
                CblNg.Visible = False
            End If
        End If
    End Sub

    Private Sub TxtDir_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDir.KeyDown
        If e.KeyCode = Keys.Return Then
            FrmBciva.Show()
        End If
    End Sub

    Private Sub TxtDir_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDir.TextChanged

    End Sub

    Private Sub Ccli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ccli.Click
        FrmInCl.Show()
    End Sub




    Private Sub TxtOb_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtOb.KeyDown

        If e.KeyCode = Keys.Return Then
            TxtOb1.Focus()
        End If
    End Sub

    Private Sub TxtOb_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtOb.TextChanged

    End Sub

    Private Sub TxtOb1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtOb1.KeyDown
        If e.KeyCode = Keys.Return Then
            If EsCom = 1 Then
                MskImp.Focus()
            Else
                CmdFactura.Focus()
            End If
        End If
    End Sub

    Private Sub TxtOb1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtOb1.TextChanged

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        FrmBPres.Show()
    End Sub

    Private Sub MskCuit_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MskCuit.GotFocus
        'MskCuit.Mask = "##-########-#"
    End Sub

    Private Sub MskCuit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MskCuit.KeyDown
        If e.KeyCode = Keys.Return Then
            FrmbCiu.Show()
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim token As String
        Dim Sign As String
        Console.WriteLine("DEMO Interfaz PyAfipWs WSFEv1 para vb.net")
        ' Crear objeto interface Web Service Autenticación y Autorización
        WSAA = CreateObject("WSAA")
        Console.WriteLine(WSAA.Version)
        'Try
        Console.WriteLine("Generar un Ticket de Requerimiento de Acceso (TRA) para WSFEv1")
        tra = WSAA.CreateTRA("wsfe")
        Console.WriteLine(tra)
        ' Especificar la ubicacion de los archivos certificado y clave privada
        Path = Environment.CurrentDirectory() + "\"
        ' Certificado: certificado es el firmado por la AFIP
        ' ClavePrivada: la clave privada usada para crear el certificado
        certificado = "\colombo.crt" ' certificado de prueba
        claveprivada = "\colombo.key" ' clave privada de prueba

        Console.WriteLine("Generar el mensaje firmado (CMS)")
        cms = WSAA.SignTRA(tra, Path + certificado, Path + claveprivada)
        Console.WriteLine(cms)
        Console.WriteLine("Llamar al web service para autenticar:")
        proxy = "" '"usuario:clave@localhost:8000"
        wsdl = "https://wsaahomo.afip.gov.ar/ws/services/LoginCms?wsdl"
        WSAA.Conectar(cache, wsdl, proxy) ' Homologación
        ta = WSAA.LoginCMS(cms)

        ' Imprimir el ticket de acceso, ToKen y Sign de autorización
        'MsgBox(WSAA.Token, vbInformation, "WSAA Token")
        'MsgBox(WSAA.Sign, vbInformation, "WSAA Sign")
        MiClase.eliminaactualizaregistra("delete from ticket ")
        token = WSAA.token
        Sign = WSAA.sign
        MiClase.eliminaactualizaregistra("insert into ticket values('" & token & "','" & Sign & "','" & Date.Now & "')")

    End Sub




    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCer.Click
        Cer()
    End Sub




    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim Servidor As String
        Dim usuario As String
        ' Dim remitente As String
        ' Dim Destinatario As String
        ' Dim Archivo As String
        '  Dim motivo As String
        '  Dim Mensaje As String
        '  Dim puerto As String
        '  Dim DD As String
        '  Dim DD1 As String
        '  Dim PyI25 As Object

        Dim PyEmail As Object

        PyEmail = CreateObject("PyEmail")
        Puerto = "995"
        ' Primer paso: conexión al servidor (por unica vez)
        Servidor = "smtp.live.com"
        usuario = "genarito04@hotmail.com"
        Clave = "GracielaIvan12"
        ok = PyEmail.Conectar(Servidor, usuario, Clave, Puerto)
        If Not ok Then
            MsgBox(PyEmail.Traceback, vbCritical, PyEmail.Excepcion)
        End If
        ' Envio el o los correos (repetir por cada FE)
        'remitente = "facelec62@gmail.com"
        'Destinatario = "genarito04@hotmail.com"
        'Mensaje = "Se envia factura electronica adjunta"
        'archivo = "C:\FACTURA.PDF"
        'motivo = "a"
        'ok = PyEmail.Enviar(remitente, motivo, destinatario, Mensaje, archivo)

        ' Muestro mensaje de error si el envio no fue correcto:
        If Not ok Then
            MsgBox(PyEmail.Traceback, vbCritical, PyEmail.Excepcion)
        End If
    End Sub


    Private Sub ImpCuot()
        Mensaje = MsgBox("Desea Imprimir el Detalle de Cuotas", MsgBoxStyle.YesNo, "Detalle de Cuotas!!!")
        If Mensaje = MsgBoxResult.Yes Then
            Dim Mn As New DtcCuotas
            Dim Fila As DtcCuotas.EncabRow
            Fila = Mn.Encab.NewEncabRow
            misdatos = MiClase.traedataset("select linea1,linea2,linea3 from encabezado")
            Linea1 = misdatos.Tables(0).Rows(0).Item(0)
            Linea2 = misdatos.Tables(0).Rows(0).Item(1)
            Linea3 = misdatos.Tables(0).Rows(0).Item(2)
            Fila.Linea1 = Linea1
            Fila.Linea2 = Linea2
            Fila.Linea3 = Linea3
            Fila.Cliente = TxtCli.Text
            Fila.Direccion = TxtDir.Text
            Fila.Ciudad = TxtCiudad.Text
            Fila.Cuit = MskCuit.Text
            Mn.Encab.AddEncabRow(Fila)
            Dim FilDet As DtcCuotas.CuotasRow
            DtgCuotas.AllowUserToAddRows = False
            For i As Integer = 0 To DtgCuotas.RowCount - 1
                FilDet = Mn.Cuotas.NewCuotasRow
                FilDet.Numero = DtgCuotas(0, i).Value
                FilDet.Vencimiento = DtgCuotas(1, i).Value
                FilDet.Importe = DtgCuotas(2, i).Value
                Mn.Cuotas.AddCuotasRow(FilDet)
            Next
            Dim rpt As New CryCuota
            rpt.SetDataSource(Mn)
            Reportes.CrystalReportViewer1.ReportSource = rpt
            Dim bottomForm As New Form
            bottomForm = Reportes
            Reportes.Height = 500
            Reportes.Width = 700
            bottomForm.WindowState = FormWindowState.Normal
            Reportes.Show()
        End If
    End Sub
    Private Sub CmbRepZ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbRepZ.Click
        Mensaje = MsgBox("Desea Imprimir El Reporte Z", MsgBoxStyle.OkCancel + MsgBoxStyle.Exclamation, "Reporte Z")
        If Mensaje = MsgBoxResult.Ok Then
            If Fact = 1 Then
                ifiscal.SerialNumber = "27-0163848-435"
                nError = ifiscal.IF_OPEN(PuerImp, 9600)
                nError = ifiscal.IF_WRITE("@CIERREZ|")
                Prns = ifiscal.IF_ERROR1(16)
                Fis = ifiscal.IF_ERROR2(16)
                If Prns <> 0 Then
                    RespEpson1()
                End If
                If Fis <> 0 Then
                    RespEpson2()
                End If
            ElseIf Fact = 2 Then
                nError = Ihasar.IF_OPEN(PuerImp, 9600)
                Ihasar.SerialNumber = "27-0163848-435"
                nError = Ihasar.IF_WRITE("@DailyClose|Z")
                RespHasar1()
                RespHasar2()
            End If
        End If
    End Sub
    Private Sub TxtNCr_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtNCr.KeyDown
        If e.KeyCode = Keys.Enter Then
            TsNc.Focus()
        End If
    End Sub

    Private Sub TxtNCr_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNCr.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub CmbMenu_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbMenu.KeyDown
        If e.KeyCode = Keys.Return Then
            If CmbMenu.Text = "Nota De Credito" And Fact = 2 Or Fact = 3 Then
                Grupo.Visible = False
                TxtNCr.Visible = True
                TsNc.Visible = True
                TxtNCr.Focus()
            ElseIf CmbMenu.Text = "Factura" And Fact = 2 Or Fact = 3 Then
                Grupo.Visible = False
                TxtNCr.Visible = False
                TxtArticulo.Focus()
            ElseIf CmbMenu.Text = "Factura Manual" Then
                TxtNCr.Visible = False
                Grupo.Visible = True
                TxtPv.Focus()
            End If
        End If
    End Sub


    Private Sub TxtPv_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPv.KeyDown
        If e.KeyCode = Keys.Return Then
            TxtNumFac.Focus()
        End If
    End Sub

    Private Sub TxtPv_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPv.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TxtNumFac_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtNumFac.KeyDown
        If e.KeyCode = Keys.Enter Then
            DtcFecha.Focus()
        End If
    End Sub

    Private Sub TxtNumFac_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNumFac.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TxtNumFac_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtNumFac.LostFocus
        cbte_nro = TxtNumFac.Text
        Pv = TxtPv.Text
        Fnum()
        Fact = 10
    End Sub


    Private Sub TxtPv_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtPv.LostFocus
        If TxtPv.Text = "" Then
            Mensaje = MsgBox("Tiene que Ingresar el Numero de Punto de Venta de la Factura", MsgBoxStyle.OkOnly, "Ingresar El Numero de Factura.!!!")
            If Mensaje = MsgBoxResult.Ok Then
                TxtPv.Focus()
            End If
        End If
    End Sub

    Private Sub TxtPv_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPv.TextChanged

    End Sub

    Private Sub TxtArticulo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtArticulo.TextChanged

    End Sub

    Private Sub TxtNumFac_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNumFac.TextChanged

    End Sub

    Private Sub TxtCli_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCli.TextChanged

    End Sub

    Private Sub DtcFecha_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DtcFecha.KeyDown
        If e.KeyCode = Keys.Return Then
            CmdBuscar.Focus()
        End If
    End Sub
    Private Sub DtgPag_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DtgPag.CellClick
        misdatos = MiClase.traedataset("select linea from tpago where linea=" & DtgPag.Rows(e.RowIndex).Cells(3).Value() & " and pc=" & Pc & "")
        Dln = misdatos.Tables(0).Rows(0).Item(0)
    End Sub

    Private Sub DtgPag_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DtgPag.CellContentClick

    End Sub

    Private Sub Dtgart_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dtgart.CellContentClick

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
            TxtPag.Clear()
            TxtNCh.Clear()
            misdatos = MiClase.traedataset("select isnull( sum(importe),0) from tpago")
            TotPago = misdatos.Tables(0).Rows(0).Item(0)
            'MskImp.Text = "0"
            MskImp.Text = FormatNumber(txtTotal.Text - TotPago, 2)
            MskImp.Focus()
            If Dlin = 0 Then
                CmdFactura.Enabled = False
            Else
                CmdFactura.Enabled = True
            End If
        End If
    End Sub

    Private Sub MskEntrega_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MskEntrega.DoubleClick
        MiClase.eliminaactualizaregistra("delete  from  tcuotas where pc=" & Pc & "")
        MiClase.cargardatagriview(DtgCuotas, "select numero,vencimiento,importe,pc from tcuotas where pc=" & Pc & "")
        MskCuotas.Text = 0
        MskEntrega.Text = 0
        CmdFactura.Enabled = False
    End Sub

    Private Sub MskEntrega_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MskEntrega.GotFocus
        MskEntrega.SelectionStart = 0
        MskEntrega.SelectionLength = MskEntrega.Text.Length
    End Sub

    Private Sub MskEntrega_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MskEntrega.KeyDown
        If Not ((e.KeyValue >= 48 And e.KeyValue <= 57) OrElse (e.KeyValue >= 96 And e.KeyValue <= 105) OrElse (e.KeyValue = 8) OrElse (e.KeyValue = 190) OrElse (e.KeyValue = 13)) Then
            e.Handled = True
            MsgBox("Permite solamente Numeros")
            MskEntrega.Text = vbNullChar
        ElseIf e.KeyCode = Keys.Return Then
            MskCuotas.Focus()
        End If
    End Sub

    Private Sub MskEntrega_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MskEntrega.KeyPress
        'Dim sep As Char
        'sep = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        'If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar.Equals(sep) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub MskEntrega_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles MskEntrega.MaskInputRejected

    End Sub

    Private Sub BtnFin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFin.Click
        IdCuota = 1
        EsVenta = 1
        Cventa = "Financiado"
        IdCom = 5
        MskImp.Text = 0
        Lb.Text = "Financiado"
        Panel2.Visible = True
        DtcDesde.Value = Date.Today
        DtcDesde.Focus()
    End Sub

    Private Sub MskCuotas_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MskCuotas.DoubleClick
        MiClase.eliminaactualizaregistra("delete  from  tcuotas where pc=" & Pc & "")
        MiClase.cargardatagriview(DtgCuotas, "select numero,vencimiento,importe,pc from tcuotas where pc=" & Pc & "")
        MskCuotas.Text = 0
        MskEntrega.Text = 0
        CmdFactura.Enabled = False
    End Sub

    Private Sub MskCuotas_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MskCuotas.GotFocus
        MskCuotas.SelectionStart = 0
        MskCuotas.SelectionLength = MskCuotas.Text.Length
    End Sub

    Private Sub MskCuotas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MskCuotas.KeyDown
        If e.KeyCode = Keys.Return Then
            Try
                misdatos = MiClase.traedataset("select count(numero) from tcuotas")
                Verif = misdatos.Tables(0).Rows(0).Item(0)
                If Verif > 0 Then
                    MiClase.eliminaactualizaregistra("delete from tcuotas")
                    MiClase.eliminaactualizaregistra("delete from t_detalfac where barra=" & 0 & "")
                    MiClase.cargardatagriview(Dtgart, "select articulo,punit,cantidad,descu,ptotal,linea,barra,idpr,idmr,idfm,alic,idiv,ptotalm from t_detalFac where idpc=" & Pc & " order by linea ")
                End If

                misdatos = MiClase.traedataset("select isnull((interes),0) from intereses")
                interes = misdatos.Tables(0).Rows(0).Item(0)
                If MskEntrega.Text = "" Then
                    MskEntrega.Text = "0"
                End If
                If MskCuotas.Text = "" Or MskCuotas.Text = 0 Then
                    Mensaje = MsgBox("La Cantidad de Cuotas debe ser 1 o Superior", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Fala Informacion!!!")
                    If Mensaje = MsgBoxResult.Ok Then
                        MskCuotas.Focus()
                    End If
                Else
                    'TTotal = Decimal.Parse(txtTotal.Text, System.Globalization.CultureInfo.GetCultureInfo("es-es"))
                    TTotal = txtTotal.Text
                    'Entrega = Decimal.Parse(MskEntrega.Text, System.Globalization.CultureInfo.GetCultureInfo("es-us"))
                    Entrega = MskEntrega.Text
                    SalCuo = TTotal - Entrega
                    DiasFin = MskCuotas.Text * 30
                    Dim Dias As Integer
                    Dias = DateDiff(DateInterval.Day, Date.Today, DtcDesde.Value)
                    ' DiasFin = DiasFin + Dias
                    Dim Fech As Date = Today
                    'Dim Int As Integer
                    'Fech = (DateAdd(DateInterval.Day, Int, Date.Today))
                    'dd = (DateAdd(DateInterval.Day, Inter, fecha))
                    DiasFin = DiasFin + Dias
                    interes = FormatNumber(interes / 30, 2)
                    TotInt = FormatNumber(interes * DiasFin)
                    '  TotInt = interes * MskCuotas.Text
                    NetCuo = FormatNumber(SalCuo * TotInt / 100, 2)
                    TotCuo = NetCuo + SalCuo
                    Cuota = TotCuo / MskCuotas.Text
                    Dim Vto As Date
                    Dim Inter As Integer
                    Dim filas As Integer = MskCuotas.Text
                    Dim contador As Integer = 0
                    Dim fecha As Date = DtcDesde.Value
                    ' Inter = 30
                    For i As Integer = 0 To filas - 1
                        contador = contador + 1
                        Vto = (DateAdd(DateInterval.Day, Inter, DtcDesde.Value))
                        FcD = Vto
                        FcD = Format(Vto, "dd/MM/yy")
                        'Fvto = Vto
                        'Fvto = Format(Vto, "dd/MM/yy")
                        Inter = Inter + 30
                        MiClase.eliminaactualizaregistra("insert into tcuotas values(" & contador & ",'" & FcD & "', " & Str(Cuota) & "," & Pc & "," & IdTp & "," & Idcl & ")")
                        If contador = MskCuotas.Text Then
                            filas = -1
                        End If
                    Next
                End If
                MiClase.cargardatagriview(DtgCuotas, "select numero,vencimiento,importe,pc from tcuotas where pc=" & Pc & "")
                DtgCuotas.Font = New Font("Arial ", 12, FontStyle.Regular)
                DtgCuotas.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                DtgCuotas.Columns(2).DefaultCellStyle.Format = "##,##0.00"
                DtgCuotas.Columns(0).Width = 60
                DtgCuotas.AllowUserToAddRows = False
                DtgCuotas.Columns(0).HeaderText = "Cuota"
                DtgCuotas.Columns(1).HeaderText = "Vencimiento"
                DtgCuotas.Columns(2).HeaderText = "Importe"
                DtgCuotas.Columns(1).DefaultCellStyle.Format = "dd/MM/yy"
                DtgCuotas.Columns(3).Visible = False
                CmdFactura.Enabled = True
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub MskCuotas_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles MskCuotas.MaskInputRejected

    End Sub

    Private Sub DtgCuotas_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DtgCuotas.CellContentClick

    End Sub

    Private Sub DtgCuotas_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DtgCuotas.CellEndEdit
        Try
            currentrow = CType((e.RowIndex.ToString()), Integer) ''Obtiene la fila actual
            If DtgCuotas.Columns(e.ColumnIndex).Name = "importe" Then
                'Si en la columna de la celda familia se hace clic y escribe algo y esta vacio, al terminar la edicion se registrara este dato
                If IsDBNull(Convert.ToString(DtgCuotas(1, currentrow).Value)) Then

                Else
                    MiClase.eliminaactualizaregistra("update tcuotas set importe= " & Convert.ToDouble(DtgCuotas(2, currentrow).Value) & "where numero= " & Convert.ToDouble(DtgCuotas(0, currentrow).Value) & "and pc= " & Convert.ToDouble(DtgCuotas(3, currentrow).Value) & " ")
                    'where numero= " & Convert.ToDouble(DtgCuotas(0, currentrow).Value) & ")
                    Dim dts As New DataSet
                    dts = MiClase.traedataset("Select numero,vencimiento,importe from tcuotas where pc= " & Convert.ToDouble(DtgCuotas(3, currentrow).Value) & " ")
                    'DtgCuotas(2, currentrow).Value = dts.Tables(0).Rows(0).Item(0).ToString
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DtcDesde_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DtcDesde.KeyDown
        If e.KeyCode = Keys.Return Then
            MskEntrega.Focus()
        End If
    End Sub

    Private Sub DtcDesde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DtcDesde.ValueChanged

    End Sub

    Private Sub MskCantidad_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles MskCantidad.MaskInputRejected

    End Sub

    Private Sub MskDescuento_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MskDescuento.GotFocus
        MskDescuento.Text = 0
        MskDescuento.SelectionStart = 0
        MskDescuento.SelectionLength = MskDescuento.Text.Length
    End Sub

    Private Sub MskDescuento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MskDescuento.KeyDown
        'If Not ((e.KeyValue >= 48 And e.KeyValue <= 57) OrElse (e.KeyValue >= 96 And e.KeyValue <= 105) OrElse (e.KeyValue = 8) OrElse (e.KeyValue = 190) OrElse (e.KeyValue = 13)) Then
        'e.Handled = True
        'MsgBox("Permite solamente Numeros")
        'MskDescuento.Text = vbNullChar
        If e.KeyCode = Keys.Return Then
            MskPtotal.Focus()
        End If
    End Sub

    Private Sub MskDescuento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MskDescuento.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = False
        End If
    End Sub

    Private Sub MskDescuento_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles MskDescuento.MaskInputRejected

    End Sub

    Private Sub MskDescGral_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MskDescGral.GotFocus
        ' MskDescGral.Text = 0
        MskDescGral.SelectionStart = 0
        MskDescGral.SelectionLength = MskDescGral.Text.Length
    End Sub

    Private Sub MskDescGral_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MskDescGral.KeyDown
        If e.KeyCode = Keys.Return Then
            CmdFactura.Focus()
        End If
    End Sub

    Private Sub MskDescGral_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MskDescGral.KeyPress
        'Dim sep As Char
        'sep = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        'If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar.Equals(sep) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = False
        End If
    End Sub

    Private Sub MskDescGral_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles MskDescGral.Leave
        If MskDescGral.Text = "" Then
            MskDescGral.Text = 0
        End If
    End Sub
    Private Sub TsNc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TsNc.KeyDown
        If e.KeyCode = Keys.Return Then
            If CmbMenu.Text = "Nota De Credito" And TxtNCr.Text = "" Then
                Mensaje = MsgBox("Tiene que Ingresar el Numero Original de la Factura", MsgBoxStyle.OkOnly, "Ingresar El Numero de Factura.!!!")
                If Mensaje = MsgBoxResult.Ok Then
                    TxtNCr.Visible = True
                    TxtNCr.Focus()
                End If
            ElseIf CmbMenu.Text = "Factura Manual" And TxtNumFac.Text = "" Then
                Mensaje = MsgBox("Tiene que Ingresar el Numero  o Punto de Venta de la Factura", MsgBoxStyle.OkOnly, "Ingresar El Numero de Factura.!!!")
                If Mensaje = MsgBoxResult.Ok Then
                    Grupo.Visible = True
                    TxtPv.Focus()
                End If
            Else
                EsCl = "3"
                FrmBcl.Show()
            End If
        End If
    End Sub

    Private Sub CmbMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbMenu.Click

    End Sub

    Private Sub CmbMenu_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbMenu.LostFocus
        If CmbMenu.Text = "Nota De Credito" And Fact = 2 Or Fact = 3 Then
            Grupo.Visible = False
            TxtNCr.Visible = True
            TsNc.Visible = True
            TxtNCr.Focus()
        ElseIf CmbMenu.Text = "Factura" And Fact = 2 Or Fact = 3 Then
            Grupo.Visible = False
            TxtNCr.Visible = False
            TxtArticulo.Focus()
        ElseIf CmbMenu.Text = "Factura Manual" Then
            TxtNCr.Visible = False
            Grupo.Visible = True
            TxtPv.Focus()
        End If
    End Sub

    Private Sub MskPtotal_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles MskPtotal.MaskInputRejected

    End Sub

    Private Sub LbNum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LbNum.Click

    End Sub

    Private Sub TxtNCh_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNCh.TextChanged

    End Sub

    Private Sub DtcVenc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DtcVenc.KeyDown
        If e.KeyCode = Keys.Return Then
            MskImp.Enabled = True
            MskImp.Focus()
        End If
    End Sub

    Private Sub DtcVenc_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DtcVenc.ValueChanged

    End Sub

  
    Private Sub MskDescGral_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles MskDescGral.MaskInputRejected

    End Sub

    
    Private Sub BtnArt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnArt.Click
        FrmInArticulos.Show()
    End Sub

    Private Sub ToolStripButton2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        FrmBusRem.Show()
    End Sub

    

   
    
End Class