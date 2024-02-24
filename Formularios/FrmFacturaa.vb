Imports System.Text
Imports System
Imports System.IO.Ports
Imports Microsoft.VisualBasic
Imports FiscalNET
Imports System.Drawing.Printing
Imports System.Drawing


Public Class FrmFacturaa
    'Variables Factura electronica
    Dim NmCm As String
    Dim TotNeg As String
    Dim NumFac As String
    Dim TipDoc As String
    Dim Prueba As String
    Dim Cbte As String
    Dim tipo As String
    Dim Dif As Integer
    Dim Fc As Date
    Dim FcAc As Date = Date.Now

    Dim Pv1 As Integer

    Dim Linea13 As String
    Dim Linea14 As String
    Dim IdCom As Integer
    'Dim Certificado As String
   
   
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


    Dim Fech As Date
   
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
    Dim EsCant As Integer
    Dim Alc As Decimal
    Dim Desc As Decimal
    Dim UnIt1 As String
    Dim UnItem As Integer
    Dim AlicTm As Integer
    Dim CivaTm As Integer
    Dim TipDocTm As Integer
    Dim CompTm As Integer
    Dim id_str As String
    Dim PagoTm As String
    Dim PagoTm9 As Decimal
    Dim ComPagTm As String
    Dim PrTm As String
   

    Private Sub Crear_Pdf()
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
        ElseIf EsCom = 3 Then
            If IdCiva = "1" Then
                tipo_cbte = "2"
            Else
                tipo_cbte = "7"
            End If
        End If

        punto_vta = Pv
        fecha = fecha
        concepto = 3
        ' datos del cliente:
        If IdCiva = 1 Then
            tipo_doc = 80
        Else
            tipo_doc = 96
        End If


        Dim Nombre_Cliente, nombre, x1, y1, x2, y2, bonif, despacho, dato_a, dato_b, dato_c, dato_d, dato_e, u_mtx, cod_mtx, codigo, ds, qty, umed, precio, iva_id, idioma_cbte, Domicilio_Cliente, pais_dst_cmp, id_impositivo, descuento, imp_subtotal, obs_generales, forma_pago, incoterms As String
        Dim Cliente_Localidad As String
        Nombre_Cliente = TxtCli.Text
        Domicilio_Cliente = TxtDir.Text
        Cliente_Localidad = TxtCiudad.Text
        pais_dst_cmp = 16 ' código para exportación
        id_impositivo = TxtcIva.Text  '
        forma_pago = Cventa
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
        'If IdCom = 2 Or IdCom = 3 Then


        Obs = "Pago Con :" + CStr(TxtPag.Text) + "-N :" + CStr(txtNumero.Text) + "- $" + MskImp.Text         ' obs_comerciales = "Item Prueba"
        obs_comerciales = Obs

        'End If
        moneda_id = "012"
        moneda_ctz = 0.5
        forma_pago = Cventa
        cae = cae
        fecha_vto_cae = VtoCae

        ' Creo la factura (internamente en la interfaz)
        'Motivo_obs = ""
        idioma_cbte = "1"
        incoterms = 0

        fecha_venc_pago = ""
        fecha_serv_desde = ""
        'fecha_serv_hasta = ""
        ok = PyFEPDF.CrearFactura(concepto, tipo_doc, nro_doc, tipo_cbte, punto_vta, cbte_nro, imp_total, imp_tot_conc, imp_neto, imp_iva, imp_trib, imp_op_ex, fecha_cbte, fecha_venc_pago, fecha_serv_desde, fecha_serv_hasta, moneda_id, moneda_ctz, cae, VtoCae, id_impositivo, Nombre_Cliente, Domicilio_Cliente, pais_dst_cmp, obs_comerciales, obs_generales, forma_pago, incoterms, idioma_cbte, motivo_obs, descuento)
        ok = PyFEPDF.EstablecerParametro("localidad_cliente", TxtCiudad.Text)
        'ok = PyFEPDF.EstablecerParametro("provincia_cliente", TxtProvin.Text)
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
                Importe = Iv    ' importe liquidado de iva
                ok = PyFEPDF.AgregarIva(iva_id, base_imp, Importe)
                Net = "0"
                Iv = "0"
            End If

        Next

        ' Agrego detalles de cada item de la factura:
        Dim fil As Integer = Dtgart.Rows.Count
        Dim contador As Integer = 0
        'select articulo,cantidad,punit,descu,ptotal,linea,barra,idpr,idmr,idfm,alic,idiv,ptotalm,idact,unidad,idpc from t_detalFac where idpc=" & Pc & " order by linea desc")
        For i As Integer = 0 To fil - 1
            If IsDBNull(Convert.ToString(Dtgart(0, i).Value)) Then
            Else
                Articulo = Trim(Convert.ToString(Dtgart(0, i).Value))
            End If
            If IsDBNull(Convert.ToString(Dtgart(1, i).Value)) Then
            Else
                Cantidad = Convert.ToDecimal(Dtgart(1, i).Value)
            End If
            If IsDBNull(Convert.ToString(Dtgart(2, i).Value)) Then
            Else
                Punt = Convert.ToDecimal(Dtgart(2, i).Value)
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
                Alic1 = Convert.ToDecimal(Dtgart(10, i).Value)
            End If
            If IsDBNull(Convert.ToString(Dtgart(11, i).Value)) Then
            Else
                IdAlic = Convert.ToDecimal(Dtgart(11, i).Value)
            End If
            If IsDBNull(Convert.ToString(Dtgart(14, i).Value)) Then
            Else
                Abn = Trim(Convert.ToString(Dtgart(14, i).Value))
            End If
            If IdCiva = "1" Then
                AlicDisc = Alic1 / 100 + 1
                Punt = FormatNumber(Punt / AlicDisc, 2)
            End If
            Ptotal = Punt * Cantidad
            u_mtx = 123456              ' unidades
            ' u_mtx = 12345678
            cod_mtx = BarFac    ' código de barras
            codigo = BarFac             ' codigo interno a imprimir (ej. "articulo")
            ds = Articulo
            qty = Cantidad             ' cantidad
            umed = Abn                     ' código de unidad de medida (ej. 7 para "unidades")
            precio = Punt                ' precio neto (A) o iva incluido (B)
            bonif = 0                   ' importe de descuentos
            iva_id = ""                   ' código para alícuota del 21%
            imp_iva = Alic1                  ' importe liquidado de iva
            Importe = Ptotal                ' importe total del item
            despacho = "Nº 123456"      ' numero de despacho de importación
            dato_a = ""          ' primer dato adicional del item
            dato_b = ""
            dato_c = ""
            dato_d = ""
            dato_e = ""           ' ultimo dato adicional del item
            ok = PyFEPDF.AgregarDetalleItem(u_mtx, cod_mtx, codigo, ds, qty, umed, _
                    precio, bonif, IdAlic, imp_iva, Importe, despacho, _
                    dato_a, dato_b, dato_c, dato_d, dato_e)
        Next
        'Traigo los datos de la empresa vendedora
        misdatos = MiClase.traedataset("select empresa,direccion,ciudad,ib,civa,in_act,ob1,ob2,ob3,numcop,cuit_em from configuracion")
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
        'ok = PyFEPDF.AgregarDato("logo", PyFEPDF.InstallDir + "\plantillas\logo.png")
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
        ok = PyFEPDF.AgregarDato("ObservacionesGenerales1", "Nota de Pie")
        ok = PyFEPDF.AgregarDato("ObservacionesGenerales2", "ob1")
        ok = PyFEPDF.AgregarDato("ObservacionesGenerales3", "c")
        ' Cargo el formato desde el archivo CSV (opcional)
        ' (carga todos los campos a utilizar desde la planilla)
        ok = PyFEPDF.CargarFormato(PyFEPDF.InstallDir + "\factura.csv")
        ' Agrego campos manualmente (opcional):
        nombre = "prueba" : tipo = "T"           ' "T" texto, "L" lineas, "I" imagen, etc.
        x1 = 50 : y1 = 150 : x2 = 150 : y2 = 255  ' coordenadas (en milimetros)
        Font = "Arial" : Size = 20 : Bold = 1 : italic = 1 : underline = 1 ' tipo de letra
        foreground = "000000" : background = "FFFFFF"    ' colores de frente y fondo
        align = "A" ' Alineación: Centrado, Izquierda, Derecha
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
        'Mensaje = MsgBox("Hasta Aca", MsgBoxStyle.YesNo, "Cliente!!!")
        salida = "C:\PyAfipWs\factura.pdf"
        ok = PyFEPDF.GenerarPDF(salida)
        'Mensaje = MsgBox("Hasta Aca1", MsgBoxStyle.YesNo, "Cliente!!!")
        ' Abro el visor de PDF y muestro lo generado
        ' (es necesario tener instalado Acrobat Reader o similar)
        'imprimir = False
        'imprimir = False  ' cambiar a True para que lo envie directo a la impresora

        'ok = PyFEPDF.MostrarPDF(salida, imprimir)
        'Dim SalAr As String

        If EsCom = 1 Then
            If IdCiva = 1 Then
                NomArc = Trim("A" + CStr(cbte_nro) + "-" + Trim(TxtCli.Text))
            Else
                NomArc = "B" + CStr(cbte_nro) + "-" + Trim(TxtCli.Text)

            End If
        ElseIf EsCom = 2 Then
            If IdCiva = 1 Then
                NomArc = Trim("NC-A" + CStr(cbte_nro) + "-" + Trim(TxtCli.Text))
            Else
                NomArc = "NC-B" + CStr(cbte_nro) + "-" + Trim(TxtCli.Text)

            End If
        ElseIf EsCom = 3 Then
            If IdCiva = 1 Then
                NomArc = Trim("ND-A" + CStr(cbte_nro) + "-" + Trim(TxtCli.Text))
            Else
                NomArc = "ND-B" + CStr(cbte_nro) + "-" + Trim(TxtCli.Text)

            End If
        End If

        Dim Dexist As String
        Dexist = My.Computer.FileSystem.FileExists("C:\PyAfipWs\Facturas\factura.pdf")
        If Dexist = True Then
            My.Computer.FileSystem.DeleteFile("C:\PyAfipWs\Facturas\factura.pdf")
        End If
        My.Computer.FileSystem.CopyFile("C:\PyAfipWs\factura.pdf", "C:\PyAfipWs\Facturas\factura.pdf")
        ' My.Computer.FileSystem.CopyFile("C:\PyAfipWs\factura.pdf", "C:\PyAfipWs\Facturas\factura.pdf")
        Dim ArcOld As String
        ArcOld = "factura.pdf"
        My.Computer.FileSystem.RenameFile("C:\PyAfipWs\Facturas\" + ArcOld, (NomArc) + ".pdf")
        'My.Computer.FileSystem.DeleteFile("C:\PyAfipWs\Facturas\factura.pdf")

    End Sub
   
    Private Sub print_PrintCliFC(ByVal sender As Object, _
                   ByVal e As PrintPageEventArgs)
        Dim PCom As String
        Dim PAbrev As String
        Dim Pcod As String
        Dim x As Single = 0.0F
        Dim y As Single = 60.0F
        'Dim width As Int32 = 198
        Dim width As Int32 = 580
        Dim height As Int32 = 55
        Dim Width1 As Int32 = 530
        Dim drawRect As New RectangleF(x, y, width, height)
        Dim xPos As Single = e.MarginBounds.Right
        Dim xPs As Single = 100.0F
        Dim prFont As New Font("Arial", 8, FontStyle.Regular)
        Dim prFontT As New Font("Arial", 10, FontStyle.Bold)
        Dim prFontE As New Font("Arial", 12, FontStyle.Bold)
        Dim yPos As Single = prFont.GetHeight(e.Graphics)
        Dim dd As Integer = tipo_cbte
        'Traigo los datos del encabezado
        misdatos = MiClase.traedataset("select cuit_em,pv,empresa,direccion,ciudad,ib,civa,in_act,lfantacia from configuracion")
        Cuit_Em = misdatos.Tables(0).Rows(0).Item(0)
        Pv1 = misdatos.Tables(0).Rows(0).Item(1)
        Empresa = Trim(misdatos.Tables(0).Rows(0).Item(2))
        DirEm = Trim(misdatos.Tables(0).Rows(0).Item(3))
        CiuEm = Trim(misdatos.Tables(0).Rows(0).Item(4))
        IbEm = Trim(misdatos.Tables(0).Rows(0).Item(5))
        CivaEnc = Trim(misdatos.Tables(0).Rows(0).Item(6))
        InAcEm = Trim(misdatos.Tables(0).Rows(0).Item(7))
        Lfantacia = Trim(misdatos.Tables(0).Rows(0).Item(8))
        'Traigo los datos del comprobante
        misdatos = MiClase.traedataset("select id,tipo,abrev,cod from tip_fac where id=" & tipo_cbte & "")
        PCom = Trim(misdatos.Tables(0).Rows(0).Item(1))
        PAbrev = Trim(misdatos.Tables(0).Rows(0).Item(2))
        Pcod = Trim(misdatos.Tables(0).Rows(0).Item(3))
        ' e.Graphics.DrawString(Lfantacia, prFontE, Brushes.Black, New Rectangle(0, y + 15, width, 15))
        e.Graphics.DrawString(Empresa, prFont, Brushes.Black, New Rectangle(0, y + 35, width, 15))
        e.Graphics.DrawString(Cuit_Em, prFont, Brushes.Black, New Rectangle(0, y + 50, width, 15))
        e.Graphics.DrawString(DirEm, prFont, Brushes.Black, New Rectangle(0, y + 65, width, 15))
        e.Graphics.DrawString(CiuEm, prFont, Brushes.Black, New Rectangle(0, y + 80, width, 15))
        e.Graphics.DrawString("Inc.Actividades: " + InAcEm, prFont, Brushes.Black, New Rectangle(0, y + 95, width, 15))
        e.Graphics.DrawString("I.Brutos: " + IbEm, prFont, Brushes.Black, New Rectangle(0, y + 110, width, 15))
        Fnum()
        Dim OurPen As Pen
        OurPen = New Pen(Color.Black, 1)
        e.Graphics.DrawLine(OurPen, 0, 190, width, 190)
        Fecha = Format(Now, "dd/MM/yyyy")
        e.Graphics.DrawString(PCom, prFontE, Brushes.Black, New Rectangle(0, y + 140, width, 15))
        FechIm = "Fecha : " + Fecha
        e.Graphics.DrawString(Clave, prFont, Brushes.Black, New Rectangle(xPos, y + 143, width, 15))
        e.Graphics.DrawString(FechIm, prFont, Brushes.Black, New Rectangle(xPos, y + 158, width, 15))
        e.Graphics.DrawString(Pcod, prFont, Brushes.Black, New Rectangle(0, y + 158, width, 15))
        e.Graphics.DrawLine(OurPen, 0, 232, width, 232)


        'Imprimo los datos del cliente
        y = 234
        e.Graphics.DrawString(TxtCli.Text, prFont, Brushes.Black, New Rectangle(0, y, width, 15))
        y = y + 15
        e.Graphics.DrawString(TxtDir.Text, prFont, Brushes.Black, New Rectangle(0, y, width, 15))
        y = y + 15
        e.Graphics.DrawString(TxtCiudad.Text, prFont, Brushes.Black, New Rectangle(0, y, width, 15))
        y = y + 15
        e.Graphics.DrawString(MskCuit.Text, prFont, Brushes.Black, New Rectangle(0, y, width, 15))
        e.Graphics.DrawLine(OurPen, 0, 295, width, 295)
        y = 310
        CantProd = 0
        If IdCiva = 1 Then
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
                    PunIm = Mid(Convert.ToString(Dtgart(2, i).Value), 1, 5)
                    Punit1 = Mid(Convert.ToString(Dtgart(2, i).Value), 1, 5)
                End If
                If IsDBNull(Convert.ToString(Dtgart(2, i).Value)) Then
                Else
                    CanIm = Convert.ToString(Dtgart(1, i).Value)
                    Canti = Convert.ToString(Dtgart(1, i).Value)
                End If
                If IsDBNull(Convert.ToString(Dtgart(4, i).Value)) Then
                Else
                    PtoIm = Mid(Convert.ToString(Dtgart(4, i).Value), 1, 7)
                    Ptotal = FormatNumber(Convert.ToDecimal(Dtgart(4, i).Value), 2)
                End If
                If IsDBNull(Convert.ToString(Dtgart(11, i).Value)) Then
                Else
                    IdAlic = Convert.ToString(Dtgart(11, i).Value)
                    misdatos = MiClase.traedataset("select id,alic from alic_iva where id=" & IdAlic & "")
                    AlicIm = Mid(misdatos.Tables(0).Rows(0).Item(1), 1, 5)
                    ' AlicIm = Mid(AlicMi, 1, 5)
                    'Ptotal = FormatNumber(Convert.ToDecimal(Dtgart(4, i).Value), 2)
                End If

                AlicDisc = AlicIm / 100 + 1
                PunIm = FormatNumber(PunIm / AlicDisc, 2)

                DetCant = CanIm + " / " + PunIm
                Ptotal = PunIm * CanIm
                e.Graphics.DrawString(DetCant, prFont, Brushes.Black, New Rectangle(0, y, width, 15))
                e.Graphics.DrawString(Ptotal, prFont, Brushes.Black, New Rectangle(230, y, 500, 15))
                y = y + 12
                e.Graphics.DrawString(Articulo + " (" + Str(AlicIm) + ")", prFont, Brushes.Black, New Rectangle(0, y, width, 15))
                y = y + 15
                Cantidad = Convert.ToDecimal(Dtgart(1, i).Value)
                Barra = Convert.ToDecimal(Dtgart(6, i).Value)
                Largo = Len(Barra)
                Primero = Mid(Barra, 1, 1)
                If Largo = 13 And Primero = 2 Then
                    Cantidad = 1
                End If
                If Cantidad < 1 Then
                    Cantidad = 1
                End If
                CantProd = CantProd + Cantidad
            Next
            DetCant = ""
            Ptotal = "0"
            Articulo = ""
            'Acumulo los totales por alicuota
            Dim Iva_id As Integer
            misdatos = MiClase.traedataset("select isnull(max(id),0) from alic_iva")
            MaxFl = misdatos.Tables(0).Rows(0).Item(0)
            Dim fl As Integer = MaxFl
            For i As Integer = 0 To fl - 1
                misdatos = MiClase.traedataset("select isnull(sum(total),0) from totalic where idiva=" & i & "")
                Tot = misdatos.Tables(0).Rows(0).Item(0)
                If Tot > 0 Then
                    misdatos = MiClase.traedataset("select sum(neto),sum(iva),sum(total) from totalic where idiva=" & i & "and pc = " & Pc & "")
                    Iv = misdatos.Tables(0).Rows(0).Item(1)
                    Iva_id = i
                    If i = 4 Then
                        Iva10 = Iv
                    ElseIf i = 5 Then
                        Iva21 = Iv
                    End If
                End If
            Next

            misdatos = MiClase.traedataset("select sum(neto),sum(iva),sum(total) from totalic where pc=" & Pc & "")
            NetT = FormatNumber(misdatos.Tables(0).Rows(0).Item(0), 2)

            y = y + 15
            'e.Graphics.DrawString(FechIm,               prFont, Brushes.Black, New Rectangle(xPos, y + 158, width, 15))
            e.Graphics.DrawString("NETO: " + Str(NetT), prFont, Brushes.Black, New Rectangle(xPs, y, Width1, 15))
            y = y + 15
            e.Graphics.DrawString("IVA 10.5 %: " + Str(Iva10), prFont, Brushes.Black, New Rectangle(xPs, y, Width1, 15))
            y = y + 15
            e.Graphics.DrawString("IVA 21.00 %: " + Str(Iva21), prFont, Brushes.Black, New Rectangle(xPs, y, Width1, 15))
            y = y + 15
            e.Graphics.DrawString("TOTAL: " + TxtTotal1.Text, prFontT, Brushes.Black, New Rectangle(xPs, y, Width1, 15))
        Else
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
                    PunIm = Mid(Convert.ToString(Dtgart(2, i).Value), 1, 5)
                    Punit1 = Mid(Convert.ToString(Dtgart(2, i).Value), 1, 5)
                End If
                If IsDBNull(Convert.ToString(Dtgart(2, i).Value)) Then
                Else
                    CanIm = Convert.ToString(Dtgart(1, i).Value)
                    Canti = Convert.ToString(Dtgart(1, i).Value)
                End If
                If IsDBNull(Convert.ToString(Dtgart(4, i).Value)) Then
                Else
                    PtoIm = Mid(Convert.ToString(Dtgart(4, i).Value), 1, 7)
                    Ptotal = FormatNumber(Convert.ToDecimal(Dtgart(4, i).Value), 2)
                End If
                If IsDBNull(Convert.ToString(Dtgart(11, i).Value)) Then
                Else

                    IdAlic = Convert.ToString(Dtgart(11, i).Value)
                    misdatos = MiClase.traedataset("select id,alic from alic_iva where id=" & IdAlic & "")
                    AlicIm = Mid(misdatos.Tables(0).Rows(0).Item(1), 1, 5)
                End If
                DetCant = CanIm + " / " + PunIm
                e.Graphics.DrawString(DetCant, prFont, Brushes.Black, New Rectangle(0, y, width, 15))
                e.Graphics.DrawString(Ptotal, prFont, Brushes.Black, New Rectangle(230, y, 500, 15))
                y = y + 12
                e.Graphics.DrawString(Articulo + "(" + Str(AlicIm) + ")", prFont, Brushes.Black, New Rectangle(0, y, width, 15))
                y = y + 15
                Cantidad = Convert.ToDecimal(Dtgart(1, i).Value)
                If Cantidad < 1 Then
                    Cantidad = 1
                End If
                CantProd = CantProd + Cantidad
            Next
            DetCant = ""
            Ptotal = "0"
            Articulo = ""

            e.Graphics.DrawString("TOTAL: " + TxtTotal1.Text, prFontT, Brushes.Black, New Rectangle(150, y, Width1, 15))

        End If ' cierro If Condcion de iva idciva
        '***************************++++


        y = y + 15
        e.Graphics.DrawString("Cond.de Venta :" + Cventa, prFont, Brushes.Black, New Rectangle(0, y + 20, width, 15))
        y = y + 15
        e.Graphics.DrawString("Cajero :" + UsuCar, prFont, Brushes.Black, New Rectangle(0, y + 20, width, 15))
        y = y + 15
        'Traigo Cae
        e.Graphics.DrawString("CAE :" + cae, prFont, Brushes.Black, New Rectangle(0, y + 20, width, 15))

        Dim dCae As String = Mid(VtoCae, 7, 2)
        Dim mCae As String = Mid(VtoCae, 5, 2)
        Dim aCae As String = Mid(VtoCae, 3, 2)
        Dim VtoCae1 As String
        VtoCae1 = dCae + "/" + mCae + "/" + aCae


        e.Graphics.DrawString("Vto.Cae: " + VtoCae1, prFont, Brushes.Black, New Rectangle(xPos, y + 20, width, 15))
        'Traigo la cantidad de productos vendidos

        'misdatos = MiClase.traedataset("select count(linea) from t_detalfac where idpc=" & Pc & "")
        'CantProd = FormatNumber(misdatos.Tables(0).Rows(0).Item(0), 2)
        y = y + 15
        e.Graphics.DrawString("Cantidad de Productos :" + Str(CantProd), prFont, Brushes.Black, New Rectangle(0, y + 20, width, 15))
        y = y + 25
        e.Graphics.DrawString("Factura Electrónica", prFontE, Brushes.Black, New Rectangle(45, y + 15, width, 15))
        y = y + 40
        'Cargo Imagen
        Dim newImage As Image = Image.FromFile("qr_1_1_11.bmp")

        ' Create coordinates for upper-left corner of image.
        Dim x1 As Single = 40.0F
        Dim y1 As Single = 60.0F

        ' Create rectangle for source image.
        'Dim srcRect As New RectangleF(20.0F, 20.0F, 150.0F, 150.0F)
        Dim srcRect As New RectangleF(20.0F, 20.0F, 40.0F, 40.0F)
        'Dim units As GraphicsUnit = GraphicsUnit.Pixel
        Dim units As GraphicsUnit = GraphicsUnit.Millimeter

        ' Draw image to screen.
        e.Graphics.DrawImage(newImage, x1, y, srcRect, units)
        '***************************++++
        CantProd = 0
        e.HasMorePages = False

    End Sub


    Private Sub Cerrar_Comp()
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
            ElseIf Fact = 4 Then
                Tm900()
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
                IdTp = 13
            End If
            'End If 'aca
            ''Grabo la Factura
            Fnum()
            Fech = Date.Today
            FecVen = Fech.Date.Date.AddDays(30)

            'Cargo  los Items
            Dim filas As Integer = Dtgart.Rows.Count
            Dim contador As Integer = 0
            For i As Integer = 0 To filas - 1
                If IsDBNull(Convert.ToString(Dtgart(0, i).Value)) Then
                Else
                    Articulo = Trim(Convert.ToString(Dtgart(0, i).Value))
                End If
                If IsDBNull(Convert.ToString(Dtgart(2, i).Value)) Then
                Else
                    Punit1 = Convert.ToDecimal(Dtgart(2, i).Value)
                End If
                If IsDBNull(Convert.ToString(Dtgart(1, i).Value)) Then
                Else
                    Cantidad = Convert.ToDecimal(Dtgart(1, i).Value)
                End If
                If IsDBNull(Convert.ToString(Dtgart(4, i).Value)) Then
                Else
                    Ptotal = Convert.ToDecimal(Dtgart(4, i).Value)
                End If
                If IsDBNull(Convert.ToString(Dtgart(5, i).Value)) Then
                Else
                    LinCom = Convert.ToDecimal(Dtgart(5, i).Value)
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
                    Alic = Convert.ToDecimal(Dtgart(10, i).Value)
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
                "" & Str(Alic) & "," & Idcl & "," & IdEnc & "," & EsVenta & ",'" & Cventa & "'," & IdAlic & "," & BlNg & ",'" & Clave & "'," & IdAct & "," & IdUs & ")")
                LinCom = LinCom + 1
                'Descuelnto el Stock
                ' If CmbMenu.Text = "Remito" Then
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
                'End If
            Next
            'NmCm = TxtNCom.Text
            misdatos = MiClase.traedataset("select isnull( sum(importe),0) from tcuotas")
            TotalGral = FormatNumber(misdatos.Tables(0).Rows(0).Item(0), 2)

            FcH = FecVen
            FcH = Format(FecVen, "dd/MM/yy")
            MiClase.eliminaactualizaregistra("insert into facturas values(" & cbte_nro & "," & IdTp & ", " & _
             "" & Pv & "," & IdEnc & "," & Idcl & ",'" & FcD & "'," & EsVenta & ",'" & Cventa & "'," & Str(NetT) & ", " & _
             "" & Str(IvT) & "," & Str(Iint) & "," & Str(txtTotal.Text) & "," & BlNg & "," & Str(Alic) & ",'" & FcH & "','" & Clave & "'," & 0 & ", " & _
             "'" & TxtOb.Text & "','" & TxtOb1.Text & "','" & TxtCli.Text & "','" & TxtDir.Text & "','" & TxtCiudad.Text & "'," & _
             "'" & TxtcIva.Text & "','" & MskCuit.Text & "'," & IdCiva & ",'" & TxtSaldo.Text & "'," & IdPrv & "," & IdUs & ")")

            'Grabo para la Cuenta Corriente
            If EsVenta = 1 And IdCuota = 0 Then
                TTotal = txtTotal.Text
                FCA = DtcFech.Value
                FCA = Format(DtcFech.Value, "dd/MM/yy")
                FecVen = Mid(DateAdd(DateInterval.Month, 1, Fc), 1, 10)
                MiClase.eliminaactualizaregistra("insert into ctacte values(" & cbte_nro & "," & IdTp & "," & NumCuo & ", " & _
                 "" & Idcl & "," & IdEnc & ",'" & FcD & "','" & FcH & "'," & Str(TTotal) & "," & Str(Entrega) & "," & Str(TTotal) & "," & BlNg & ",'" & Clave & "'," & IdUs & ")")

                ' ToTT = TtoTT - MskEntrega.Text
                If TxtCiudad.Text = "" Then
                    TxtCiudad.Text = "0"
                End If
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
                'Cargo el pago

                If TxtPag.Text = "" Then
                    TxtPag.Text = "Efectivo"
                End If
                If txtNumero.Text = "" Then
                    txtNumero.Text = 0
                End If
                If MskImp.Text = "" Or MskImp.Text = "0" Then
                    MskImp.Text = txtTotal.Text
                End If

                MiClase.eliminaactualizaregistra("insert into pagos values(" & cbte_nro & "," & IdTp & ", " & _
                "" & Dln & "," & Idcl & "," & IdCom & ",'" & FcD & "','" & TxtPag.Text & "'," & txtNumero.Text & "," & Str(MskImp.Text) & ", " & _
                "" & 1 & "," & BlNg & "," & Pc & "," & IdUs & ")")

            End If
            'Imprimo el remito
            Mensaje = MsgBox("Desea Imprimir el Ticket", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir El Ticket")
            If Mensaje = MsgBoxResult.Yes Then
                misdatos = MiClase.traedataset("select impresora from configuracion where pc=" & Pc & "")
                Impresora = Trim(misdatos.Tables(0).Rows(0).Item(0))
                If IdTp = 4 Or IdTp = 7 Or IdTp = 13 Then
                    If EsNeg = "LPT" Then
                        Imp_TickP()
                    ElseIf EsNeg = "COM" Then
                        Imp_tick()
                    ElseIf EsNeg = "USB" Then
                        Dim printDoc As New PrintDocument
                        printDoc.PrinterSettings.PrinterName = Impresora
                        Dim printCta As New PrintDocument
                        printCta.PrinterSettings.PrinterName = Impresora
                        If TxtCli.Text = "" Then
                            AddHandler printDoc.PrintPage, AddressOf print_PrintPage
                            printDoc.Print()
                            If ChkCopia.Checked = True Then
                                AddHandler printDoc.PrintPage, AddressOf print_PrintPage
                                printDoc.Print()
                            End If
                        Else
                            AddHandler printDoc.PrintPage, AddressOf print_PrintCli
                            printDoc.Print()
                            If ChkCopia.Checked = True Then
                                AddHandler printDoc.PrintPage, AddressOf print_PrintCli
                                printDoc.Print()
                            End If

                        End If
                    End If
                End If
            End If
        End If
        Blanquear()
        TxtArticulo.Focus()
        EsVenta = "0"
        Cventa = "Contado"
        'End If
        If TxtCli.Text = "" Then
            IdCiva = "5"
        End If

    End Sub
    Private Sub panel_1()
        'Panel1.Visible = True
        If CmbMenu.Text = "Presupuesto" Then
            EsCom = 0
        ElseIf CmbMenu.Text = "Factura" Then
            'If OptContado.Checked = True Then
            'Lb.Text = "Pago Efectivo"
            MskImp.Enabled = True
            MskImp.Text = txtTotal.Text
            '  Else
            MskImp.Enabled = False
            ' End If
            EsCom = 1
            IdCom = 1

        ElseIf CmbMenu.Text = "Remito" Then
            EsCom = 1
            IdCom = 1

            If TxtCli.Text = "" Then
                'Lb.Text = "Pago Efectivo"
                MskImp.Enabled = True
                MskImp.Text = txtTotal.Text
                MskImp.Focus()
            Else
                'GroupBox7.Enabled = True
                OptCta.Checked = True
                MskImp.Enabled = False
                MskDescGral.Enabled = False
                GroupBox5.Focus()
                CmdFactura.Focus()
            End If
            CmdFactura.Enabled = True
            CmdFactura.Focus()
        ElseIf CmbMenu.Text = "Nota De Credito" Then
            MskDescGral.Enabled = False
            EsCom = 2
            IdCom = 1

        End If
        If EsCom = 0 Then
            'Panel1.Visible = True
            GroupBox4.Enabled = False
            TxtOb.Focus()
            'Group.Visible = True
            CmdFactura.Enabled = True
        ElseIf EsCom = 1 Then
            'Panel1.Visible = True
            txtNumero.Visible = False
            'Group.Visible = True
            GroupBox4.Enabled = True
            EsVenta = 0
            Cventa = "Contado"
        ElseIf EsCom = 2 Then
            '   Panel1.Visible = True
            txtNumero.Visible = False
            'Group.Visible = False
            GroupBox4.Enabled = True
            EsVenta = 0
            Cventa = "Contado"
            MskImp.Enabled = False
            CmdFactura.Enabled = True
            CmdTarjeta.Enabled = False
            CmdFactura.Focus()
        End If
    End Sub
    Private Sub ObtenerEstadoFiscalDelEquipo()
        Dim FisTm As String
        '  retorno = ObtenerEstadoFiscal()
        MostrarMensaje(ERROR_NINGUNO, "Estado fiscal: " & String.Format("{0:X4}", retorno))
        FisTm = String.Format("{0:X4}", retorno)
        If FisTm = "0801" Then
            Mensaje = MsgBox("Requiere período de actividades iniciado", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Requiere período de actividades iniciado")
        ElseIf FisTm = "0802" Then
            Mensaje = MsgBox("Requiere un Reporte Z", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Realize Reporte Z")
            If Mensaje = MsgBoxResult.Ok Then
                Exit Sub
                ' TxtCli.Focus()
            End If
        ElseIf FisTm = "0803" Then
            Mensaje = MsgBox("Memoria fiscal llena", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Memoria fiscal llena")
        ElseIf FisTm = "0804" Then
            Mensaje = MsgBox("Requiere jornada fiscal abierta", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Requiere jornada fiscal abierta")
        ElseIf FisTm = "0807" Then
            Mensaje = MsgBox("Período auditado sin datos", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Período auditado sin datos")
        ElseIf FisTm = "0808" Then
            Mensaje = MsgBox("Rango auditado inválido", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Rango auditado inválido")
        ElseIf FisTm = "0809" Then
            Mensaje = MsgBox("Restan datos por auditar/descargar", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Restan datos por auditar/descargar")
        ElseIf FisTm = "080A" Then
            Mensaje = MsgBox("No hay más datos a descargar", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "No hay más datos a descargar")
        ElseIf FisTm = "080B" Then
            Mensaje = MsgBox("No es posible abrir la jornada fiscal", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "No es posible abrir la jornada fiscal")
        ElseIf FisTm = "080C" Then
            Mensaje = MsgBox("No es posible cerrar la jornada fiscal", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "No es posible cerrar la jornada fiscal")
        ElseIf FisTm = "0810" Then
            Mensaje = MsgBox("Tipo de documento solicitado inválido", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Tipo de documento solicitado inválido")
        ElseIf FisTm = "0811" Then
            Mensaje = MsgBox("Número de documento solicitado inválido", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Número de documento solicitado inválido")
        ElseIf FisTm = "0812" Then
            Mensaje = MsgBox("Documento solicitado no existente", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Documento solicitado no existente")
        ElseIf FisTm = "0813" Then
            Mensaje = MsgBox("La copia del documento solicitado fue borrada", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "La copia del documento solicitado fue borrada")
        ElseIf FisTm = "0814" Then
            Mensaje = MsgBox("Tipo de documento no soportado", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Tipo de documento no soportado")
        ElseIf FisTm = "0815" Then
            Mensaje = MsgBox("Registrado para emitir documentos ‘normales’", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Registrado para emitir documentos ‘normales’")
        ElseIf FisTm = "0816" Then
            Mensaje = MsgBox("Registrado para emitir documentos M’", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Registrado para emitir documentos M")
        ElseIf FisTm = "0817" Then
            Mensaje = MsgBox("Falta descargar jornadas previas", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Falta descargar jornadas previas")
        ElseIf FisTm = "0818" Then
            Mensaje = MsgBox("Sólo se puede imprimir el cambio una única vez dentro de la jornada", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Sólo se puede imprimir el cambio una única vez dentro de la jornada")
        ElseIf FisTm = "0819" Then
            Mensaje = MsgBox("Requiere que se encuentre establecida la línea de inicio de actividades", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Requiere que se encuentre establecida la línea de inicio de actividades")
        End If
    End Sub

    Private Sub ObtenerEstadoDeImpresoraDelEquipo()
        Dim RetTm As String
        '  retorno = ObtenerEstadoImpresora()
        MostrarMensaje(ERROR_NINGUNO, "Estado de impresora: " & String.Format("{0:X4}", retorno))
        RetTm = "Estado de impresora: " & String.Format("{0:X4}", retorno)
    End Sub

    Private Function ObtenerCampoSalida_TipoString(ByVal numero_campo_salida As Integer, ByRef respuesta As String) As Integer
        Const FIELD_OUTPUT_MAX_LEN As Integer = 65536

        ' READ
        ' crear un buffer en memoria con el tamaño de bytes que indice la constante FIELD_OUTPUT_MAX_LEN (típico MALLOC)
        Dim puntero_buffer_salida As IntPtr = Runtime.InteropServices.Marshal.AllocHGlobal(FIELD_OUTPUT_MAX_LEN)

        ' crear variable del tipo integer donde devolverá la cantidad de bytes utilizados del buffer creado
        Dim respuesta_final_buffer_salida As Integer

        ' llamar a la funcion
        retorno = ObtenerRespuestaExtendida(numero_campo_salida, puntero_buffer_salida, FIELD_OUTPUT_MAX_LEN, respuesta_final_buffer_salida)

        ' copiar la respuesta contenida segun el puntero "puntero_buffer_salida" a la variable "respuesta"
        respuesta = Runtime.InteropServices.Marshal.PtrToStringAnsi(puntero_buffer_salida, respuesta_final_buffer_salida)

        ' Ejemplo para una estrucura de datos, ver el link: 
        ' https://stackoverflow.com/questions/16481622/passing-parameter-from-vb-net-to-c-structure

        ' liberar la memoria solicitada (típico FREE)
        Runtime.InteropServices.Marshal.FreeHGlobal(puntero_buffer_salida)

        ' retorno del error
        ObtenerCampoSalida_TipoString = retorno
    End Function

    Private Sub PagarTdC()
        misdatos = MiClase.traedataset("select sum(total) from tpago where pc=" & Pc & "")
        PagoTm9 = FormatNumber(misdatos.Tables(0).Rows(0).Item(0), 2)
        misdatos = MiClase.traedataset("select comprobante,idcom from tpago where pc=" & Pc & "")
        ComPagTm = misdatos.Tables(0).Rows(0).Item(0)
        IdCom = misdatos.Tables(0).Rows(0).Item(1)
        If IdCom = 1 Then
            PagoTm = AFIP_CODIGO_FORMA_DE_PAGO_EFECTIVO
        ElseIf IdCom = 2 Then
            PagoTm = AFIP_CODIGO_FORMA_DE_PAGO_TARJETA_DE_CREDITO
        ElseIf IdCom = 3 Then
            PagoTm = AFIP_CODIGO_FORMA_DE_PAGO_CHEQUE
        ElseIf IdCom = 4 Then
            PagoTm = AFIP_CODIGO_FORMA_DE_PAGO_CUENTA_CORRIENTE
        End If
        retorno = CargarPago(ID_MODIFICADOR_AGREGAR, PagoTm, 0, PagoTm9, "", ComPagTm, "", "")
        MostrarMensaje(retorno, "Pago almacenado.")
    End Sub
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
        Dim prFontT As New Font("Arial", 8, FontStyle.Bold)
        Dim prFontE As New Font("Arial", 8, FontStyle.Bold)

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
        FechIm = "Fecha : " + FcD
        e.Graphics.DrawString(FechIm, prFont, Brushes.Black, New Rectangle(xPos, y + 80, width, 15))
        e.Graphics.DrawString(Clave, prFont, Brushes.Black, New Rectangle(xPos, y + 95, width, 15))

        Dim OurPen As Pen
        OurPen = New Pen(Color.Black, 1)
        e.Graphics.DrawLine(OurPen, 0, 160, width, 160)
        y = 165
        CantProd = 0
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
                PunIm = Mid(Convert.ToString(Dtgart(2, i).Value), 1, 5)
                Punit1 = Mid(Convert.ToString(Dtgart(2, i).Value), 1, 5)
            End If
            If IsDBNull(Convert.ToString(Dtgart(2, i).Value)) Then
            Else
                CanIm = Convert.ToString(Dtgart(1, i).Value)
                Canti = Convert.ToString(Dtgart(1, i).Value)
            End If
            If IsDBNull(Convert.ToString(Dtgart(4, i).Value)) Then
            Else
                PtoIm = Mid(Convert.ToString(Dtgart(4, i).Value), 1, 7)
                Ptotal = FormatNumber(Dtgart(4, i).Value, 2)
                'Ptotal = Convert.ToDecimal(Dtgart(4, i).Value)
            End If
            Cantidad = Convert.ToDecimal(Dtgart(1, i).Value)
            Barra = Convert.ToDecimal(Dtgart(6, i).Value)
            Largo = Len(Barra)
            Primero = Mid(Barra, 1, 1)
            If Largo = 13 And Primero = 2 Then
                Cantidad = 1
            End If
            CantProd = CantProd + Cantidad
            DetCant = CanIm + " / " + PunIm

            e.Graphics.DrawString(DetCant, prFont, Brushes.Black, New Rectangle(0, y, width, 15))
            e.Graphics.DrawString(Ptotal, prFont, Brushes.Black, New Rectangle(xPos, y, Width1, 15))
            y = y + 12
            e.Graphics.DrawString(Articulo, prFont, Brushes.Black, New Rectangle(0, y, width, 15))
            y = y + 15
        Next
        y = y + 15
        e.Graphics.DrawString("TOTAL: " + TxtTotal1.Text, prFontT, Brushes.Black, New Rectangle(xPos, y, Width1, 15))
        y = y + 5
        e.Graphics.DrawString("Cond.de Venta :" + Cventa, prFont, Brushes.Black, New Rectangle(0, y + 20, width, 15))
        y = y + 15
        e.Graphics.DrawString("Cantidad de Productos :" + Str(CantProd), prFont, Brushes.Black, New Rectangle(0, y + 20, width, 15))
        y = y + 15
        e.Graphics.DrawString("Cajero :" + UsuCar, prFont, Brushes.Black, New Rectangle(0, y + 20, width, 15))
        e.Graphics.DrawString("* GRACIAS POR SU COMPRA *", prFontT, Brushes.Black, New Rectangle(30, y + 40, width, 15))
        y = y + 5
        e.Graphics.DrawString("-", prFontT, Brushes.Black, New Rectangle(0, y + 20, width, 15))
        CantProd = 0
        e.HasMorePages = False
    End Sub

    Private Sub print_PrintPageC(ByVal sender As Object, _
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
        Dim prFontT As New Font("Arial", 8, FontStyle.Bold)
        Dim prFontE As New Font("Arial", 8, FontStyle.Bold)

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
        FechIm = "Fecha : " + FcD
        e.Graphics.DrawString(FechIm, prFont, Brushes.Black, New Rectangle(xPos, y + 80, width, 15))
        e.Graphics.DrawString(Clave, prFont, Brushes.Black, New Rectangle(xPos, y + 95, width, 15))

        Dim OurPen As Pen
        OurPen = New Pen(Color.Black, 1)
        e.Graphics.DrawLine(OurPen, 0, 160, width, 160)
        y = 165
        CantProd = 0
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
                PunIm = Mid(Convert.ToString(Dtgart(2, i).Value), 1, 5)
                Punit1 = Mid(Convert.ToString(Dtgart(2, i).Value), 1, 5)
            End If
            If IsDBNull(Convert.ToString(Dtgart(2, i).Value)) Then
            Else
                CanIm = Convert.ToString(Dtgart(1, i).Value)
                Canti = Convert.ToString(Dtgart(1, i).Value)
            End If
            If IsDBNull(Convert.ToString(Dtgart(4, i).Value)) Then
            Else
                PtoIm = Mid(Convert.ToString(Dtgart(4, i).Value), 1, 7)
                Ptotal = FormatNumber(Dtgart(4, i).Value, 2)
                'Ptotal = Convert.ToDecimal(Dtgart(4, i).Value)
            End If
            Cantidad = Convert.ToDecimal(Dtgart(1, i).Value)
            Barra = Convert.ToDecimal(Dtgart(6, i).Value)
            Largo = Len(Barra)
            Primero = Mid(Barra, 1, 1)
            If Largo = 13 And Primero = 2 Then
                Cantidad = 1
            End If
            CantProd = CantProd + Cantidad
            DetCant = CanIm + " / " + PunIm

            e.Graphics.DrawString(DetCant, prFont, Brushes.Black, New Rectangle(0, y, width, 15))
            e.Graphics.DrawString(Ptotal, prFont, Brushes.Black, New Rectangle(xPos, y, Width1, 15))
            y = y + 12
            e.Graphics.DrawString(Articulo, prFont, Brushes.Black, New Rectangle(0, y, width, 15))
            y = y + 15
        Next
        y = y + 15
        e.Graphics.DrawString("TOTAL: " + TxtTotal1.Text, prFontT, Brushes.Black, New Rectangle(xPos, y, Width1, 15))
        y = y + 5
        e.Graphics.DrawString("Cond.de Venta :" + Cventa, prFont, Brushes.Black, New Rectangle(0, y + 20, width, 15))
        y = y + 15
        e.Graphics.DrawString("Cantidad de Productos :" + Str(CantProd), prFont, Brushes.Black, New Rectangle(0, y + 20, width, 15))
        y = y + 15
        e.Graphics.DrawString("Cajero :" + UsuCar, prFont, Brushes.Black, New Rectangle(0, y + 20, width, 15))
        e.Graphics.DrawString("* GRACIAS POR SU COMPRA *", prFontT, Brushes.Black, New Rectangle(30, y + 40, width, 15))
        y = y + 5
        e.Graphics.DrawString("-", prFontT, Brushes.Black, New Rectangle(0, y + 20, width, 15))
        CantProd = 0
        e.HasMorePages = False
    End Sub


    Private Sub print_PrintCli(ByVal sender As Object, _
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
        FechIm = "Fecha : " + FcD
        e.Graphics.DrawString(FechIm, prFont, Brushes.Black, New Rectangle(xPos, y + 80, width, 15))
        e.Graphics.DrawString(Clave, prFont, Brushes.Black, New Rectangle(xPos, y + 95, width, 15))

        Dim OurPen As Pen
        OurPen = New Pen(Color.Black, 1)
        e.Graphics.DrawLine(OurPen, 0, 160, width, 160)

        'Imprimo los datos del cliente
        y = 170
        e.Graphics.DrawString(TxtCli.Text, prFont, Brushes.Black, New Rectangle(0, y, width, 15))
        y = y + 15
        e.Graphics.DrawString(TxtDir.Text, prFont, Brushes.Black, New Rectangle(0, y, width, 15))
        y = y + 15
        e.Graphics.DrawString(TxtCiudad.Text, prFont, Brushes.Black, New Rectangle(0, y, width, 15))
        y = y + 15
        e.Graphics.DrawString(MskCuit.Text, prFont, Brushes.Black, New Rectangle(0, y, width, 15))
        e.Graphics.DrawLine(OurPen, 0, 230, width, 230)
        y = 240
        CantProd = 0
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
                PunIm = Mid(Convert.ToString(Dtgart(2, i).Value), 1, 5)
                Punit1 = Mid(Convert.ToString(Dtgart(2, i).Value), 1, 5)
            End If
            If IsDBNull(Convert.ToString(Dtgart(2, i).Value)) Then
            Else
                CanIm = Convert.ToString(Dtgart(1, i).Value)
                Canti = Convert.ToString(Dtgart(1, i).Value)
            End If
            If IsDBNull(Convert.ToString(Dtgart(4, i).Value)) Then
            Else
                PtoIm = Mid(Convert.ToString(Dtgart(4, i).Value), 1, 7)
                Ptotal = FormatNumber(Convert.ToDecimal(Dtgart(4, i).Value), 2)
            End If

            DetCant = CanIm + " / " + PunIm
            e.Graphics.DrawString(DetCant, prFont, Brushes.Black, New Rectangle(0, y, width, 15))
            e.Graphics.DrawString(Ptotal, prFont, Brushes.Black, New Rectangle(xPos, y, Width1, 15))
            y = y + 12
            e.Graphics.DrawString(Articulo, prFont, Brushes.Black, New Rectangle(0, y, width, 15))
            y = y + 15
            Cantidad = Convert.ToDecimal(Dtgart(1, i).Value)
            Barra = Convert.ToDecimal(Dtgart(6, i).Value)
            Largo = Len(Barra)
            Primero = Mid(Barra, 1, 1)
            If Largo = 13 And Primero = 2 Then
                Cantidad = 1
            End If
            If Cantidad < 1 Then
                Cantidad = 1
            End If
            CantProd = CantProd + Cantidad
        Next
        DetCant = ""
        Ptotal = "0"
        Articulo = ""
        e.Graphics.DrawString("TOTAL: " + TxtTotal1.Text, prFontT, Brushes.Black, New Rectangle(xPos, y, Width1, 15))
        y = y + 15
        e.Graphics.DrawString("Cond.de Venta :" + Cventa, prFont, Brushes.Black, New Rectangle(0, y + 20, width, 15))

        '        misdatos = MiClase.traedataset("select count(linea) from t_detalfac where idpc=" & Pc & "")
        '       CantProd = FormatNumber(misdatos.Tables(0).Rows(0).Item(0), 2)
        y = y + 15
        e.Graphics.DrawString("Cantidad de Productos :" + Str(CantProd), prFont, Brushes.Black, New Rectangle(0, y + 20, width, 15))
        y = y + 15
        e.Graphics.DrawString("Cajero :" + UsuCar, prFont, Brushes.Black, New Rectangle(0, y + 20, width, 15))

        e.Graphics.DrawString("* GRACIAS POR SU COMPRA *", prFontT, Brushes.Black, New Rectangle(30, y + 40, width, 15))
        y = y + 35
        e.Graphics.DrawString("-", prFontT, Brushes.Black, New Rectangle(0, y + 20, width, 15))
        CantProd = 0
        e.HasMorePages = False

    End Sub
    Private Sub print_TalonCta(ByVal sender As Object, _
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
        FechIm = "Fecha : " + FcD
        e.Graphics.DrawString(FechIm, prFont, Brushes.Black, New Rectangle(xPos, y + 80, width, 15))
        e.Graphics.DrawString("TALON CTA.CTE : " + Clave, prFont, Brushes.Black, New Rectangle(20, y + 95, width, 15))

        Dim OurPen As Pen
        OurPen = New Pen(Color.Black, 1)
        e.Graphics.DrawLine(OurPen, 0, 160, width, 160)

        'Imprimo los datos del cliente
        y = 170
        e.Graphics.DrawString(TxtCli.Text, prFont, Brushes.Black, New Rectangle(0, y, width, 15))
        y = y + 15
        e.Graphics.DrawString(TxtDir.Text, prFont, Brushes.Black, New Rectangle(0, y, width, 15))
        y = y + 15
        e.Graphics.DrawString(TxtCiudad.Text, prFont, Brushes.Black, New Rectangle(0, y, width, 15))
        y = y + 15
        e.Graphics.DrawString(MskCuit.Text, prFont, Brushes.Black, New Rectangle(0, y, width, 15))
        e.Graphics.DrawLine(OurPen, 0, 230, width, 230)
        y = 240
        y = y + 12


        e.Graphics.DrawString("TOTAL: " + TxtTotal1.Text, prFontT, Brushes.Black, New Rectangle(xPos, y, Width1, 15))
        'y = y + 45
        e.Graphics.DrawString("--------------------------------------------------", prFont, Brushes.Black, New Rectangle(0, 300, width, 15))
        e.Graphics.DrawString("           FIRMA                       ", prFontE, Brushes.Black, New Rectangle(0, 315, width, 15))
        e.Graphics.DrawString("--------------------------------------------------", prFont, Brushes.Black, New Rectangle(0, 360, width, 15))
        e.Graphics.DrawString("           ACLARACION                     ", prFontE, Brushes.Black, New Rectangle(0, 375, width, 15))
        e.HasMorePages = False
    End Sub

    Private Sub FnumTm()
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
    End Sub
    Private Sub ObtenerFechaHora()
        Dim respuesta As StringBuilder = New StringBuilder(MAX_ANSWER)
        'Dim fecha As String
        Dim hora As String
        Dim cad As String
        Dim DiaTm As String
        Dim MesTm As String
        Dim AñoTm As String


        retorno = ConsultarFechaHora(respuesta, MAX_ANSWER)

        cad = respuesta.ToString()
        ' fecha = cad.Substring(0, 6)
        DiaTm = cad.Substring(0, 2)
        MesTm = cad.Substring(2, 2)
        AñoTm = "20" + cad.Substring(4, 2)
        '  Fech = Mid(cad, 1, 6)
        Fecha = AñoTm + MesTm + DiaTm
        hora = cad.Substring(7, 6)
        'MostrarMensaje(retorno, "Datos en impresora fiscal" &
        '               vbCrLf & "Fecha: " & fecha.Substring(0, 2) & "/" & fecha.Substring(2, 2) & "/20" & fecha.Substring(4, 2) &
        '               vbCrLf & "Hora: " & hora.Substring(0, 2) & ":" & hora.Substring(2, 2) & ":" & hora.Substring(4, 2))
    End Sub

    Private Sub ObtenerPuntoDeVenta()
        Dim respuesta As StringBuilder = New StringBuilder(MAX_ANSWER)

        retorno = ConsultarNumeroPuntoDeVenta(respuesta, MAX_ANSWER)
        'MostrarMensaje(retorno, "Punto de Venta: " & respuesta.ToString)
        Pv = respuesta.ToString
    End Sub


    Private Sub ObtenerEstadoDeterminado()
        Dim id As Integer
        Dim id_str As String
        Dim respuesta As Integer
        Dim mensaje As String

        ' init
        mensaje = ""

        ' get id 
        ' id_str = Rhtestado.Text.Substring(0, 4)
        id_str = 7013
        id = Val(id_str)

        ' consultar
        retorno = ConsultarEstado(id, respuesta)

        ' salir por error
        If retorno <> ERROR_NINGUNO Then
            MostrarMensaje(retorno, "Consultar tipo de estado ")
            Exit Sub
        End If


        ' mostrar respuesta
        Select Case id
            Case DOC_EN_PROGRESO
                Select Case respuesta
                    Case 0
                        mensaje = "Sin documentos en progreso"
                    Case 1
                        mensaje = "Tique/Tique-Nota de Crédito"
                    Case 2
                        mensaje = "Tique-Factura A/B/C/M"
                    Case 3
                        mensaje = "Tique-Nota de Crédito A/B/C/M"
                    Case 4
                        mensaje = "Tique-Nota de Débito A/B/C/M"
                    Case 6
                        mensaje = "Documento de Auditoría"
                    Case 8
                        mensaje = "DNFH Genérico/Uso Interno (rollo)"
                    Case 10
                        mensaje = "DNFH"
                End Select

            Case SUBESTADOS
                Select Case respuesta
                    Case 0
                        mensaje = "Sin subestados"
                    Case 1
                        mensaje = "Solicitud o carga de certificado digital"
                    Case 2
                        mensaje = "Configuración de Scanner"
                    Case 3
                        mensaje = "Configuración de Logo"
                    Case 4
                        mensaje = "Auditoría en progreso"
                    Case 5
                        mensaje = "Descarga de reporte en progreso"
                    Case 6
                        mensaje = "Reimpresión en progreso"
                    Case 7
                        mensaje = "Descarga de reporte de eventos en progreso"
                End Select

            Case JORNADA_FISCAL
                If respuesta = 0 Then
                    mensaje = "Jornada cerrada"
                Else
                    mensaje = "Jornada abierta"
                End If

            Case ESTADO_MEM_TRANSACCIONES
                Select Case respuesta
                    Case 0
                        mensaje = "Memoria de transacciones en perfecto estado"
                    Case 1
                        mensaje = "Memoria de transacciones cerca de su llenado"
                    Case 2
                        mensaje = "Memoria de transacciones llena"
                    Case 3
                        mensaje = "Memoria de transacciones con desperfectos"
                End Select

            Case ESTADO_MEM_FISCAL
                Select Case respuesta
                    Case 0
                        mensaje = "Memoria fiscal en perfecto estado"
                    Case 1
                        mensaje = "Memoria fiscal cerca de su llenado"
                    Case 2
                        mensaje = "Memoria fiscal llena"
                    Case 3
                        mensaje = "Memoria fiscal con desperfectos"
                End Select

            Case MODO_TECNICO
                Select Case respuesta
                    Case 0
                        mensaje = "Modo técnico inactivo"
                    Case 1
                        mensaje = "Modo técnico activo"
                End Select

            Case ESTADO_CERTIFICADOS_DIGITALES
                Select Case respuesta
                    Case 0
                        mensaje = "Certificados digitales válidos"
                    Case 1
                        mensaje = "certificados digitales vencido(s), cercano(s) de su expiración, inválido(s)"
                End Select

            Case MODO_FUNCIONAMIENTO_EQUIPO
                Select Case respuesta
                    Case 0
                        mensaje = "Modo bloqueado por software"
                    Case 1
                        mensaje = "Modo manufactura"
                    Case 2
                        mensaje = "Modo entrenamiento"
                    Case 3
                        mensaje = "Modo fiscal"
                    Case 15
                        mensaje = "Bloqueo por hardware"
                End Select

            Case ESTADO_ESTACION_RECIBOS
                Select Case respuesta
                    Case 0
                        mensaje = "Sin problemas"
                    Case 1
                        mensaje = "Poco papel disponible"
                    Case 2
                        mensaje = "Papel no disponible"
                End Select

            Case ESTADO_ESTACION_JOURNAL
                Select Case respuesta
                    Case 0
                        mensaje = "Sin problemas"
                    Case 1
                        mensaje = "Poco papel disponible"
                    Case 2
                        mensaje = "Papel no disponible"
                End Select

            Case ESTADO_ESTACION_SLIP_SENSOR_VALIDACION
                Select Case respuesta
                    Case 0
                        mensaje = "Sin papel"
                    Case 1
                        mensaje = "Con papel"
                End Select

            Case ESTADO_ESTACION_SLIP_SENSOR_TOF
                Select Case respuesta
                    Case 0
                        mensaje = "Sin papel"
                    Case 1
                        mensaje = "Con papel"
                End Select

            Case ESTADO_ESTACION_SLIP_SENSOR_BOF
                Select Case respuesta
                    Case 0
                        mensaje = "Sin papel"
                    Case 1
                        mensaje = "Con papel"
                End Select

            Case ESTADO_ESTACION_SLIP_VALIDACION_SENSOR_ESPERA
                Select Case respuesta
                    Case 0
                        mensaje = "Estado normal (sin espera)"
                    Case 1
                        mensaje = "A la espera de carga de papel"
                    Case 2
                        mensaje = "A la espera de remoción de papel"
                End Select

            Case ESTADO_ESTACION_SELECCIONADA
                Select Case respuesta
                    Case 0
                        mensaje = "Receipt (recibos)"
                    Case 1
                        mensaje = "Slip (hojas sueltas)"
                    Case 2
                        mensaje = "Validación"
                    Case 3
                        mensaje = "MICR"
                End Select

            Case ESTADO_CAJON_DINERO
                Select Case respuesta
                    Case 0
                        mensaje = "Cajón de dinero cerrado"
                    Case 1
                        mensaje = "Cajón de dinero abierto"
                End Select

            Case ESTADO_TAPA
                Select Case respuesta
                    Case 0
                        mensaje = "Tapa de impresora cerrada"
                    Case 1
                        mensaje = "Tapa de impresora abierta"
                End Select

            Case IMPRESORA_CON_ERROR
                Select Case respuesta
                    Case 0
                        mensaje = "Impresora sin error"
                    Case 1
                        mensaje = "Impresora con error"
                End Select

            Case IMPRESORA_EN_LINEA
                Select Case respuesta
                    Case 0
                        mensaje = "Impresora en línea (online)"
                    Case 1
                        mensaje = "Impresora fuera de línea (offline)"
                End Select

            Case ESTADO_CONEXION
                Select Case respuesta
                    Case 0
                        mensaje = "Sin Conexión"
                    Case 1
                        mensaje = "Equipo ocupado"
                    Case 2
                        mensaje = "Equipo disponible para comunicarse. (IDLE)"
                End Select

            Case Else
                Exit Sub
        End Select

        ' mostrar mensaje
        MostrarMensaje(retorno, "Tipo de estado: " & mensaje)
    End Sub

    Private Function ObtenerNroComprobanteUltimo(ByVal tipo_de_comprobante As String) As String
        Dim respuesta As StringBuilder = New StringBuilder(MAX_ANSWER)

        retorno = ConsultarNumeroComprobanteUltimo(tipo_de_comprobante, respuesta, MAX_ANSWER)
        Return respuesta.ToString
    End Function


    Private Function ObtenerNroComprobanteEnCurso() As String
        Dim respuesta As StringBuilder = New StringBuilder(MAX_ANSWER)

        retorno = ConsultarNumeroComprobanteActual(respuesta, MAX_ANSWER)
        Return respuesta.ToString
        cbte_nro = respuesta.ToString
    End Function
    Private Sub MostrarMensaje(ByVal retorno, ByVal mensaje)
        Dim respuesta As StringBuilder = New StringBuilder(MAX_DESCRIPTION)
        Dim hexVal As String

        If retorno = ERROR_NINGUNO Then
            ' antiguo mensaje:   MsgBox(mensaje, MsgBoxStyle.Information, "Información")
            '   MsgLogAgregar(mensaje, MsgBoxStyle.Information, "Información")
        Else
            ConsultarDescripcionDeError(retorno, respuesta, MAX_DESCRIPTION)
            hexVal = String.Format("{0:X4}", retorno)

            ' antiguo mensaje:   MsgBox("Error: " & hexVal & vbCrLf & "Descripción: " & respuesta.ToString, MsgBoxStyle.Exclamation, "Error!")
            '  MsgLogAgregar("Error: " & hexVal & vbCrLf & "Descripción: " & respuesta.ToString, MsgBoxStyle.Exclamation, "Error!")
        End If
    End Sub

    Function ConectarFiscal() As Integer
        'ConfigurarPuerto(cmbPort.SelectedItem.ToString)
        'ConfigurarVelocidad(CInt(cmbBaudRate.SelectedItem))
        Dim Veloc As Integer
        'Dim Puerto As String
        PuerImp = Mid(PuerImp, 4, 1)
        Puerto = PuerImp
        Veloc = 9600
        ConfigurarVelocidad(9600)
        ConfigurarPuerto(PuerImp)
        retorno = Conectar()
        ConectarFiscal = retorno
        If retorno <> 0 Then
            ObtenerEstadoFiscalDelEquipo()
            Mensaje = MsgBox("El Controlador Esta Apagado o Desconectado", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Se perdio la Conexion!!")
            Exit Function
        End If
        MostrarMensaje(retorno, "Host vinculado a la impresora fiscal.")
    End Function
    Private Function CerrarCualquierDocumentoEnCurso() As Integer
        retorno = CerrarComprobante()
        CerrarCualquierDocumentoEnCurso = retorno
    End Function
    Private Sub Imp_TalonCtaP()
        Dim objFSO
        Dim Paralelo
        objFSO = CreateObject("Scripting.FileSystemObject")
        'Paralelo = objFSO.CreateTextFile("LPT1") 'Puerto al cual se envía la impresión
        Paralelo = objFSO.CreateTextFile(PuerNeg)  'Puerto al cual se envía la impresión
        misdatos = MiClase.traedataset("select linea1,linea2,linea3 from encabezado")
        Linea1 = Trim(misdatos.Tables(0).Rows(0).Item(0))
        Linea2 = Trim(misdatos.Tables(0).Rows(0).Item(1))
        Linea3 = Trim(misdatos.Tables(0).Rows(0).Item(2))
        'Paralelo.Writeline(Chr(27) & Chr(99) & Chr(48) & Chr(3)) 'Le pedimos que imprima tanto en el rollo Receipt como en el Journal
        Paralelo.Writeline(Chr(27) & Chr(99) & Chr(48) & Chr(3)) 'Le pedimos que imprima tanto en el rollo Receipt como en el Journal
        Paralelo.Writeline(Chr(27) & Chr(122) & Chr(0)) 'Ponemos en Off la impresion paralela
        Paralelo.Writeline(Linea1)
        Paralelo.Writeline(Linea2)
        Paralelo.Writeline(Linea3)
        Paralelo.WriteLine("----------------------------------------")
        FcD = Date.Today
        FcD = Format(Date.Today, "dd/MM/yy")
        'Paralelo.WriteLine("Fecha: " + FcD + "              TICKET")
        Paralelo.WriteLine("Fecha: " + FcD + "       TALON CTA.CTE")
        NumFac = "N:" + Clave
        NumFac = (NumFac.PadLeft(40))  ' Displays "BBQ and Slaw".
        Paralelo.WriteLine(NumFac)
        Paralelo.WriteLine("----------------------------------------")
        If TxtCli.Text = "" Then
        Else
            Paralelo.WriteLine(Trim(TxtCli.Text))
            Paralelo.WriteLine(Trim(TxtDir.Text))
            Paralelo.WriteLine(Trim(TxtCiudad.Text))
            Paralelo.WriteLine("----------------------------------------")
        End If

        'Total del comprrobante
        misdatos = MiClase.traedataset("select sum(ptotalm) from t_detalfac where idpc=" & Pc & "")
        TotNeg = FormatNumber(misdatos.Tables(0).Rows(0).Item(0), 2)
        TotCom = FormatNumber(misdatos.Tables(0).Rows(0).Item(0), 2)
        TotNeg = (TotNeg.PadLeft(9))  ' Displays "BBQ and Slaw".
        CerrNeg = "TOTAL :" + TotNeg
        CerrNeg = Chr(27) + "!" + Chr(32) + CerrNeg
        Paralelo.WriteLine(CerrNeg)
        Paralelo.WriteLine("")
        Paralelo.WriteLine("")
        Paralelo.WriteLine("")
        Paralelo.WriteLine("----------------")
        Paralelo.WriteLine("     Firma      ")
        Paralelo.WriteLine("")
        Paralelo.WriteLine("")
        Paralelo.WriteLine("")
        Paralelo.WriteLine("----------------")
        Paralelo.WriteLine("  Aclaracion   ")
        Scmd = Chr(29) & Chr(86) & Chr(66) & Chr(1)
        Paralelo.WriteLine(Scmd)
        Paralelo.Close()
        '  End If

    End Sub
    Private Sub Imp_TalonCta()
        Dim serial As SerialPort = New System.IO.Ports.SerialPort(PuerNeg, 9600, Parity.None, 8, StopBits.One)
        serial.PortName = PuerNeg
        misdatos = MiClase.traedataset("select linea1,linea2,linea3 from encabezado")
        Linea1 = Trim(misdatos.Tables(0).Rows(0).Item(0))
        Linea2 = Trim(misdatos.Tables(0).Rows(0).Item(1))
        Linea3 = Trim(misdatos.Tables(0).Rows(0).Item(2))
        serial.PortName = PuerNeg
        'HABILITAR PARA QUE IMPRIMA EL IMPRESOR EN NEGRO
        serial.Open()  '**************
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
            'serial.WriteLine("Fecha: " + FcD + "              TICKET")
            serial.WriteLine("Fecha: " + FcD + "       TALON CTA.CTE")
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
            serial.WriteLine("")
            serial.WriteLine("")
            serial.WriteLine("")
            serial.WriteLine("----------------")
            serial.WriteLine("     Firma      ")
            serial.WriteLine("")
            serial.WriteLine("")
            serial.WriteLine("")
            serial.WriteLine("----------------")
            serial.WriteLine("  Aclaracion   ")
            'ingreso de dinero
            Scmd = Chr(29) & Chr(86) & Chr(66) & Chr(1)
            serial.WriteLine(Scmd)
            serial.Close()
            serial.Close()
        End If

    End Sub
    Private Sub Imp_TickP()
        Dim objFSO
        Dim Paralelo
        objFSO = CreateObject("Scripting.FileSystemObject")
        'Paralelo = objFSO.CreateTextFile("LPT1") 'Puerto al cual se envía la impresión
        Paralelo = objFSO.CreateTextFile(PuerNeg)  'Puerto al cual se envía la impresión
        misdatos = MiClase.traedataset("select linea1,linea2,linea3 from encabezado")
        Linea1 = Trim(misdatos.Tables(0).Rows(0).Item(0))
        Linea2 = Trim(misdatos.Tables(0).Rows(0).Item(1))
        Linea3 = Trim(misdatos.Tables(0).Rows(0).Item(2))
        'Paralelo.Writeline(Chr(27) & Chr(99) & Chr(48) & Chr(3)) 'Le pedimos que imprima tanto en el rollo Receipt como en el Journal
        Paralelo.Writeline(Chr(27) & Chr(99) & Chr(48) & Chr(3)) 'Le pedimos que imprima tanto en el rollo Receipt como en el Journal
        Paralelo.Writeline(Chr(27) & Chr(122) & Chr(0)) 'Ponemos en Off la impresion paralela
        Paralelo.Writeline(Linea1)
        Paralelo.Writeline(Linea2)
        Paralelo.Writeline(Linea3)
        Paralelo.WriteLine("----------------------------------------")
        FcD = Date.Today
        FcD = Format(Date.Today, "dd/MM/yy")
        Paralelo.WriteLine("Fecha: " + FcD + "              TICKET")
        NumFac = "N:" + Clave
        NumFac = (NumFac.PadLeft(40))  ' Displays "BBQ and Slaw".
        Paralelo.WriteLine(NumFac)
        Paralelo.WriteLine("----------------------------------------")
        If TxtCli.Text = "" Then
        Else
            Paralelo.WriteLine(Trim(TxtCli.Text))
            Paralelo.WriteLine(Trim(TxtDir.Text))
            Paralelo.WriteLine(Trim(TxtCiudad.Text))
            Paralelo.WriteLine("----------------------------------------")
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
            Paralelo.WriteLine(Item)
            Paralelo.WriteLine(Item1)
        Next
        ' End If
        Paralelo.WriteLine("")
        'Total del comprrobante
        misdatos = MiClase.traedataset("select sum(ptotalm) from t_detalfac where idpc=" & Pc & "")
        TotNeg = FormatNumber(misdatos.Tables(0).Rows(0).Item(0), 2)
        TotCom = FormatNumber(misdatos.Tables(0).Rows(0).Item(0), 2)
        TotNeg = (TotNeg.PadLeft(9))  ' Displays "BBQ and Slaw".
        CerrNeg = "TOTAL :" + TotNeg
        CerrNeg = Chr(27) + "!" + Chr(32) + CerrNeg
        Paralelo.WriteLine(CerrNeg)
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
        Paralelo.WriteLine(CerRec)
        'Vuelto

        Vuelto = EntCom - TotCom
        TotVuel = Str(Vuelto)
        TotVuel = (TotVuel.PadLeft(32))  ' Displays "BBQ and Slaw".
        CerVuel = "Vuelto :" + TotVuel
        Paralelo.WriteLine(CerVuel)

        Paralelo.WriteLine("Cond.de Venta :" + Cventa)
        Paralelo.WriteLine("Cajero :" + UsuCar)
        Paralelo.WriteLine("*Gracias Por Su Compra*")
        Scmd = Chr(29) & Chr(86) & Chr(66) & Chr(1)
        Paralelo.WriteLine(Scmd)
        Paralelo.Close()
        '  End If

    End Sub
    Private Sub Imp_tick()
        Dim serial As SerialPort = New System.IO.Ports.SerialPort(PuerNeg, 9600, Parity.None, 8, StopBits.One)
        misdatos = MiClase.traedataset("select linea1,linea2,linea3 from encabezado")
        Linea1 = Trim(misdatos.Tables(0).Rows(0).Item(0))
        Linea2 = Trim(misdatos.Tables(0).Rows(0).Item(1))
        Linea3 = Trim(misdatos.Tables(0).Rows(0).Item(2))
        serial.PortName = PuerNeg
        serial.Open()
        If serial.IsOpen = False Then
            Mensaje = MsgBox("El Impresor esta Apagado o Desconectado ", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Problema con el impresor!!!")
        Else
            'HABILITAR PARA QUE IMPRIMA EL IMPRESOR EN NEGRO
            ' serial.Open()  '**************
        End If
        '*****************************************
        If Not serial.IsOpen Then
            serial.Open()
        End If
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
    Private Sub Habl()
        TxtPag.Enabled = False
        txtNumero.Enabled = False
        txtNumero.Text = ""
        MskImp.Text = ""
        MskImp.Enabled = False
        txtNumero.Visible = False
        CmdFactura.Enabled = True
        EsVenta = 1
        Cventa = "Cta.Cte"
        CmdFactura.Focus()
        IdCom = 4
        'Lb.Text = "Cta.Cte."
        IdCuota = 0
        ' Panel2.Visible = False
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
                    Fecha = Convert.ToString(DtgNc(1, i).Value)
                End If
                If IsDBNull(Convert.ToString(DtgNc(2, i).Value)) Then
                Else
                    Importe = Convert.ToDecimal(DtgNc(2, i).Value)
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
                    Alic = Alic1 * "1.00"
                    nError = Ihasar.IF_WRITE("@PrintLineItem|" & Articulo & "|" & Cantidad & "|" & Punt & "|" & Alic & "|M|0.0|1|T")
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
                Fecha = (CStr(Ihasar.IF_READ(3)))
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
                    Importe = Convert.ToDecimal(DtgNc(2, i).Value)
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
        End If
        If EsVenta = 1 Then
            If MskEntrega.Text = "" Then
                MskEntrega.Text = 0
            End If
            ToTT = ToTT - MskEntrega.Text
            MiClase.eliminaactualizaregistra("insert into fac_cta values(" & cbte_nro & "," & tipo_cbte & ", " & _
            "" & Idcl & ",'" & TxtCli.Text & "','" & TxtDir.Text & "','" & TxtCiudad.Text & "','" & TxtcIva.Text & "','" & Fecha & "', " & _
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
                  "" & Dln & "," & Idcl & "," & IdCom & ",'" & Fecha & "','" & Comprobante & "'," & NumPag & "," & ImPag & ", " & _
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
        Cliente = Mid(Trim(TxtCli.Text), 1, 15)
        Direccion = Mid(Trim(TxtDir.Text) + " - " + Trim(TxtCiudad.Text), 1, 15)
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
                    Cantidad = Convert.ToDecimal(Dtgart(1, i).Value)
                End If
                If IsDBNull(Convert.ToString(Dtgart(2, i).Value)) Then
                Else
                    Punt = Convert.ToDecimal(Dtgart(2, i).Value)
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
                If IsDBNull(Convert.ToDecimal(Dtgart(10, i).Value)) Then
                Else
                    Alc = Convert.ToDecimal(Dtgart(10, i).Value)
                End If
                Articulo = Mid(Trim(Articulo), 1, 20)
                nError = Ihasar.IF_WRITE("@PrintLineItem|" & Articulo & "|" & Cantidad & "|" & Punt & "|" & Alc & "|M|0.0|0|T")
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
            Fecha = (CStr(Ihasar.IF_READ(3)))

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
        ElseIf IdCiva = 5 Or IdCiva = 0 Then
            Dcuit = Mid(MskCuit.Text, 8, 3)
            Mcuit = Mid(MskCuit.Text, 4, 3)
            Icuit = Mid(MskCuit.Text, 1, 2)
            Cuit = Icuit + Mcuit + Dcuit
            IdIv = "F"
            TipCu = "DNI"
            LetrCierr = "B"
        End If
        If TxtCli.Text = "" Then
            TxtCli.Text = "A Consumidor Final"
            Cuit = "22222222"
        End If
        nError = ifiscal.IF_OPEN(PuerImp, 9600)
        ifiscal.SerialNumber = "27-0163848-435"
        'nError = ifiscal.IF_WRITE("@FACTABRE|" & LetrComp & "|C|A|1|P|10|I|" & IdIv & "|" & TxtCli.Text & "||" & TipCu & "|" & Cuit & "|N|" & TxtDir.Text & "|" & TxtCiudad.Text & " ||||C")
        nError = ifiscal.IF_WRITE("@FACTABRE|" & LetrComp & "|C|" & LetrCierr & "|1|P|10|I|" & IdIv & "|" & TxtCli.Text & "||" & TipCu & "|" & Cuit & "|N|" & TxtDir.Text & "|" & TxtCiudad.Text & " ||||C")

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
        'articulo,cantidad,punit,descu,ptotal,linea,barra,idpr,idmr,idfm,alic,idiv,ptotalm,idact from t_detalFac where idpc=" & Pc & " order by linea desc")
        Dim fil As Integer = Dtgart.Rows.Count
        Dim contador As Integer = 0
        For i As Integer = 0 To fil - 1
            If IsDBNull(Convert.ToString(Dtgart(0, i).Value)) Then
            Else
                Articulo = Convert.ToString(Dtgart(0, i).Value)
            End If
            If IsDBNull(Convert.ToString(Dtgart(1, i).Value)) Then
            Else
                Cantidad = Convert.ToDecimal(Dtgart(1, i).Value)
            End If

            If IsDBNull(Convert.ToString(Dtgart(2, i).Value)) Then
            Else
                Punt = Convert.ToDecimal(Dtgart(2, i).Value)
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
        Fecha = ifiscal.IF_READ(3)
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
    Private Sub Tm900()
        Try

            'Imprimo la Factura
            If CmbMenu.Text = "Factura" Then
                CompTm = ID_TIPO_COMPROBANTE_TIQUE_FACTURA
                IdCom = 2
            ElseIf CmbMenu.Text = "Nota De Credito" Then
                CompTm = ID_TIPO_COMPROBANTE_TIQUE_NOTA_DE_CREDITO
                IdCom = 3
            End If

            If IdCiva = 1 Then
                Dcuit = Mid(MskCuit.Text, 13, 1)
                Mcuit = Mid(MskCuit.Text, 4, 8)
                Icuit = Mid(MskCuit.Text, 1, 2)
                Cuit = Icuit + Mcuit + Dcuit
                TipDocTm = ID_TIPO_DOCUMENTO_CUIT
                CivaTm = ID_RESPONSABILIDAD_IVA_RESPONSABLE_INSCRIPTO
                tipo_cbte = 1
            ElseIf IdCiva = 3 Then
                Dcuit = Mid(MskCuit.Text, 13, 1)
                Mcuit = Mid(MskCuit.Text, 4, 8)
                Icuit = Mid(MskCuit.Text, 1, 2)
                Cuit = Icuit + Mcuit + Dcuit
                TipDocTm = ID_TIPO_DOCUMENTO_CUIT
                CivaTm = ID_RESPONSABILIDAD_IVA_EXENTO
                tipo_cbte = 6
            ElseIf IdCiva = 4 Then
                Dcuit = Mid(MskCuit.Text, 13, 1)
                Mcuit = Mid(MskCuit.Text, 4, 8)
                Icuit = Mid(MskCuit.Text, 1, 2)
                Cuit = Icuit + Mcuit + Dcuit
                TipDocTm = ID_TIPO_DOCUMENTO_CUIT
                CivaTm = ID_RESPONSABILIDAD_IVA_MONOTRIBUTISTA
                tipo_cbte = 6
            ElseIf IdCiva = 5 Then
                Dcuit = Mid(MskCuit.Text, 8, 3)
                Mcuit = Mid(MskCuit.Text, 4, 3)
                Icuit = Mid(MskCuit.Text, 1, 2)
                Cuit = Icuit + Mcuit + Dcuit
                TipDocTm = ID_TIPO_DOCUMENTO_DNI
                CivaTm = ID_RESPONSABILIDAD_IVA_CONSUMIDOR_FINAL
                tipo_cbte = 6
            End If

            'If ErrTm = "0" Then
            If TxtCli.Text = "" Then
                id_str = 83
                ' ejecutar funcion
                Dim nroComp As String
                nroComp = ObtenerNroComprobanteUltimo(id_str.Trim())
                nroComp = nroComp + 1
                retorno = CargarComprobanteAsociado("083-00001-" & nroComp & "")
                If retorno <> ERROR_NINGUNO Then
                    MostrarMensaje(retorno, "Error en función CargarComprobanteAsociado()")
                    Exit Sub
                End If
                ' Apertura del comprobante
                retorno = AbrirComprobante(ID_TIPO_COMPROBANTE_TIQUET)
                'ObtenerEstadoDeImpresoraDelEquipo()
                ObtenerEstadoFiscalDelEquipo()

                MostrarMensaje(retorno, "Tiquet factura abierto.")
                tipo_cbte = 9
            Else

                retorno = CargarDatosCliente(TxtCli.Text, "", TxtDir.Text, TxtCiudad.Text, "", TipDocTm, Cuit, CivaTm)
            End If


            ' ObtenerNroComprobanteEnCurso()
            If CmbMenu.Text = "Factura" Then
                If IdCiva = 1 Then
                    id_str = 81
                    ' ejecutar funcion
                    Dim nroComp As String
                    nroComp = ObtenerNroComprobanteUltimo(id_str.Trim())
                    nroComp = nroComp + 1
                    retorno = CargarComprobanteAsociado("081-00001-" & nroComp & "")
                    If retorno <> ERROR_NINGUNO Then
                        MostrarMensaje(retorno, "Error en función CargarComprobanteAsociado()")
                        Exit Sub
                    End If
                ElseIf IdCiva = 3 Or IdCiva = 4 Or IdCiva = 5 Or IdCiva = 0 Then
                    id_str = 82
                    ' ejecutar funcion
                    Dim nroComp As String
                    nroComp = ObtenerNroComprobanteUltimo(id_str.Trim())
                    nroComp = nroComp + 1
                    retorno = CargarComprobanteAsociado("082-00001-" & nroComp & "")
                    If retorno <> ERROR_NINGUNO Then
                        MostrarMensaje(retorno, "Error en función CargarComprobanteAsociado()")
                        Exit Sub
                    End If
                End If
            ElseIf CmbMenu.Text = "Nota De Credito" Then
                If IdCiva = 1 Then
                    id_str = 112
                    ' ejecutar funcion
                    Dim nroComp As String
                    nroComp = ObtenerNroComprobanteUltimo(id_str.Trim())
                    nroComp = nroComp + 1
                    retorno = CargarComprobanteAsociado("112-00001-" & nroComp & "")
                    If retorno <> ERROR_NINGUNO Then
                        MostrarMensaje(retorno, "Error en función CargarComprobanteAsociado()")
                        Exit Sub
                    End If
                ElseIf IdCiva = 3 Or IdCiva = 4 Or IdCiva = 5 Or IdCiva = 0 Then
                    id_str = 113
                    ' ejecutar funcion
                    Dim nroComp As String
                    nroComp = ObtenerNroComprobanteUltimo(id_str.Trim())
                    nroComp = nroComp + 1
                    retorno = CargarComprobanteAsociado("113-00001-" & nroComp & "")
                    If retorno <> ERROR_NINGUNO Then
                        MostrarMensaje(retorno, "Error en función CargarComprobanteAsociado()")
                        Exit Sub
                    End If
                End If

            End If


            ' Apertura del comprobante
            'retorno = AbrirComprobante(ID_TIPO_COMPROBANTE_TIQUE_FACTURA)
            retorno = AbrirComprobante(CompTm)

            MostrarMensaje(retorno, "Comprobante abierto.")
            'Cargo el Item
            ' Agrego detalles de cada item de la factura:



            Dim fil As Integer = Dtgart.Rows.Count
            Dim contador As Integer = 0
            For i As Integer = 0 To fil - 1
                If IsDBNull(Convert.ToString(Dtgart(0, i).Value)) Then
                Else
                    Articulo = Mid(Trim(Convert.ToString(Dtgart(0, i).Value)), 1, 50)
                End If
                If IsDBNull(Convert.ToString(Dtgart(1, i).Value)) Then
                Else
                    Cantidad = Convert.ToDecimal(Dtgart(1, i).Value)
                End If
                If IsDBNull(Convert.ToString(Dtgart(2, i).Value)) Then
                Else
                    Punt = Convert.ToDecimal(Dtgart(2, i).Value)
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
                If IsDBNull(Convert.ToDecimal(Dtgart(10, i).Value)) Then
                Else
                    Alc = Convert.ToDecimal(Dtgart(10, i).Value)
                End If
                If IsDBNull(Convert.ToDecimal(Dtgart(11, i).Value)) Then
                Else
                    IdIv = Convert.ToDecimal(Dtgart(11, i).Value)
                End If
                If IsDBNull(Convert.ToString(Dtgart(14, i).Value)) Then
                Else
                    UnIt1 = Trim(Convert.ToString(Dtgart(14, i).Value))
                End If
                If UnIt1 = "3" Then
                    UnItem = AFIP_CODIGO_UNIDAD_MEDIDA_KILOGRAMO
                ElseIf UnIt1 = "2" Then
                    UnItem = AFIP_CODIGO_UNIDAD_MEDIDA_UNIDAD
                ElseIf UnIt1 = "5" Then
                    UnItem = AFIP_CODIGO_UNIDAD_MEDIDA_LITROS
                ElseIf UnIt1 = "4" Then
                    UnItem = AFIP_CODIGO_UNIDAD_MEDIDA_METROS
                End If
                If IdIv = 0 Then
                    AlicTm = ID_TASA_IVA_NINGUNO
                ElseIf IdIv = 4 Then
                    AlicTm = ID_TASA_IVA_10_50
                ElseIf IdIv = 5 Then
                    AlicTm = ID_TASA_IVA_21_00
                End If
                If TxtCli.Text = "" Then
                    Punt1 = Punt
                Else
                    AlicDisc = Alc / 100 + 1
                    Punt1 = FormatNumber(Punt / AlicDisc, 2)
                End If
                ' Articulo = Mid(Trim(Articulo), 1, 20)
                retorno = ImprimirItem(ID_MODIFICADOR_AGREGAR, Articulo, Cantidad, Punt1, AlicTm, ID_IMPUESTO_NINGUNO, "", ID_CODIGO_INTERNO, "1234567890", "", UnItem)
                MostrarMensaje(retorno, "Ítem vendido.")
            Next

            '   Dim NNCom As Integer
            'Cierro la Factura
            retorno = ImprimirSubtotal()
            MostrarMensaje(retorno, "Subtotal impreso.")


            'NNCom = respuesta.ToString
            retorno = EstablecerCola(1, "Cond.de Venta:" + Cventa)
            retorno = EstablecerCola(2, "Cajero:" + UsuCar)
            'Obtengo los datos del ticket para cargar en la base de datos
            ObtenerPuntoDeVenta()
            ObtenerFechaHora()
            retorno = ConsultarNumeroComprobanteActual(respuesta, MAX_ANSWER)
            'Return respuesta.ToString
            cbte_nro = respuesta.ToString
            NumDbto = respuesta.ToString
            FnumTm()
            Clave = Pv + "-" + Lnum
            If retorno = ERROR_NINGUNO Then
                If tipo_cbte = 9 Then
                    retorno = ObtenerCampoSalida_TipoString(2, ToTT)
                    ToTT = ToTT / 100
                    retorno = ObtenerCampoSalida_TipoString(4, IvT)
                    IvT = IvT / 100
                    NetT = FormatCurrency(ToTT - IvT, 2)
                Else
                    retorno = ObtenerCampoSalida_TipoString(3, ToTT)
                    ToTT = ToTT / 100
                    retorno = ObtenerCampoSalida_TipoString(5, IvT)
                    IvT = IvT / 100
                    NetT = FormatCurrency(ToTT - IvT, 2)
                End If
                'Hasta Aca************************************+++++++
            End If
            If CmbMenu.Text = "Factura" Then
                PagarTdC()
            End If

            retorno = CerrarComprobante
            Guar_Fac()
            If CmbMenu.Text = "Factura" Then
            Else
                CmbMenu.Text = "Factura"
            End If
        Catch ex As Exception

        End Try
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
            If IsDBNull(Convert.ToString(Dtgart(2, i).Value)) Then
            Else
                Punt = Convert.ToDecimal(Dtgart(2, i).Value)
            End If
            If IsDBNull(Convert.ToString(Dtgart(1, i).Value)) Then
            Else
                Cantidad = Convert.ToDecimal(Dtgart(1, i).Value)
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
                'LinCom = (Dtgart(5, i).Value)
                LinCom = Convert.ToString(Dtgart(5, i).Value)
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
                Alic = Convert.ToDecimal(Dtgart(10, i).Value)
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
                If IdCiva = 1 Then
                    tipo_cbte = 3
                Else
                    tipo_cbte = 8
                End If
                ToTT = ToTT * -1
                IvT = IvT * -1
                NetT = NetT * -1
                Punt = Punt * -1
                Ptotal = Ptotal * -1
            End If
            If CmbMenu.Text = "Factura Manual" Then
                Fecha = DtcFecha.Text
                ToTT = txtTotal.Text
                DesAic = Alic / 100 + 1
                NetT = FormatNumber(ToTT / DesAic)
                IvT = FormatNumber(ToTT - NetT)
            End If
            If EsVenta = 0 Then
                Cventa = "Contado"
            End If
            'Grabo el detalle de factura
            MiClase.eliminaactualizaregistra("insert into detal_fac values(" & cbte_nro & "," & tipo_cbte & " ," & LinCom & "," & Pv & ",'" & Fecha & "', " & _
            "" & BarFac & ",'" & Articulo & "'," & Str(Punt) & "," & Str(Cantidad) & "," & Str(Ptotal) & "," & IdFm & "," & IdMr & "," & IdPr & ", " & _
           "" & Str(Alic) & "," & Idcl & "," & IdEnc & "," & EsVenta & ",'" & Cventa & "'," & IdAlic & "," & BlNg & ",'" & Clave & "'," & IdAct & "," & IdUs & ")")
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
          "" & Pv & "," & IdEnc & "," & Idcl & ",'" & Fecha & "'," & EsVenta & ",'" & Cventa & "'," & Str(NetT) & ", " & _
          "" & Str(IvT) & "," & Str(Iint) & "," & Str(ToTT) & "," & BlNg & "," & Str(Alic) & ",'" & Fecha & "','" & Clave & "'," & 0 & ", " & _
          "'" & TxtOb.Text & "','" & TxtOb1.Text & "','" & TxtCli.Text & "','" & TxtDir.Text & "','" & TxtCiudad.Text & "'," & _
          "'" & TxtcIva.Text & "','" & MskCuit.Text & "'," & IdCiva & ",'" & Cpostal & "'," & IdPrv & "," & IdUs & ")")

        'Grabo para la Cuenta Corriente
        If EsVenta = 1 And IdCuota = 0 Then
            TTotal = txtTotal.Text
            MiClase.eliminaactualizaregistra("insert into ctacte values(" & cbte_nro & "," & tipo_cbte & "," & NumCuo & ", " & _
             "" & Idcl & "," & IdEnc & ",'" & Fecha & "','" & Fecha & "'," & Str(TTotal) & "," & Str(Entrega) & "," & Str(TTotal) & "," & BlNg & ",'" & Clave & "'," & IdUs & ")")

            '   MiClase.eliminaactualizaregistra("insert into fac_cta values(" & cbte_nro & "," & tipo_cbte & ", " & _
            '   "" & Idcl & ",'" & TxtCli.Text & "','" & TxtDir.Text & "','" & TxtCiudad.Text & "','" & TxtcIva.Text & "','" & Fecha & "', " & _
            '  "" & Str(TTotal) & "," & 0 & "," & Str(TTotal) & ",'" & Clave & "'," & BlNg & "," & IdUs & ")")

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
            'Cargo el pago
            '   MiClase.eliminaactualizaregistra("insert into pagos values(" & cbte_nro & "," & tipo_cbte & ", " & _
            ' "" & Dln & "," & Idcl & "," & IdCom & ",'" & Fecha & "','" & TxtPag.Text & "'," & txtNumero.Text & "," & MskImp.Text & ", " & _
            '"" & BlNg & "," & BlNg & "," & Pc & "," & IdUs & ")")

        End If
    End Sub
    Private Sub Cer_()
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
        misdatos = MiClase.traedataset("select certificado,claveprivada,servidor from configuracion")
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
        Dim Ftick As String
        'Ftick = Date.Now
        'Ftick = Convert.ToDateTime(Date.Now)
        Ftick = Format(Date.Now, "dd/MM/yy hh:mm:ss")
        MiClase.eliminaactualizaregistra("insert into ticket values('" & WSAA.token & "','" & WSAA.sign & "','" & Date.Now & "')")

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
        'certificado = "\genari.crt" ' certificado de prueba
        'claveprivada = "\genari.key" ' clave privada de prueba
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
        MiClase.eliminaactualizaregistra("delete from ticket ")
        Dim Ftick As String
        Ftick = Format(Date.Now, "dd/MM/yy hh:mm:ss")
        MiClase.eliminaactualizaregistra("insert into ticket values('" & WSAA.token & "','" & WSAA.sign & "','" & Date.Now & "')")

    End Sub
    
    Private Sub Fac_Elec()
      
        Dim WSFEv1 As Object
        'traigo los datos de la configuracion
        misdatos = MiClase.traedataset("select cuit_em,pv,servidor from configuracion where pc = " & Pc & "")
        Cuit_Em = misdatos.Tables(0).Rows(0).Item(0)
        punto_vta = Trim(misdatos.Tables(0).Rows(0).Item(1))
        Pv = misdatos.Tables(0).Rows(0).Item(1)
        Ser = misdatos.Tables(0).Rows(0).Item(2)
        '   ***********************++

        Console.WriteLine("Crear objeto interface Web Service de Factura Electrónica de Mercado Interno")
        WSFEv1 = CreateObject("WSFEv1")

        Try
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
                    'Cambio para factura tipo_cbte="1" por tipo_cbte="1" para emitir factura "M"
                    tipo_cbte = "1"
                    'tipo_cbte = "51"
                Else
                    tipo_cbte = "6"
                End If
            ElseIf EsCom = 2 Then
                If IdCiva = "1" Then
                    tipo_cbte = "3"
                Else
                    tipo_cbte = "8"
                End If
            ElseIf EsCom = 3 Then
                If IdCiva = "1" Then
                    tipo_cbte = "2"
                Else
                    tipo_cbte = "7"
                End If
            End If

            cbte_nro = WSFEv1.CompUltimoAutorizado(tipo_cbte, punto_vta)

            If cbte_nro = "" Then
                cbte_nro = 0                ' no hay comprobantes emitidos
            Else
                cbte_nro = CLng(cbte_nro)   ' convertir a entero largo
            End If
            Fecha = Format(Now, "yyyyMMdd")
            concepto = 1
            If IdCiva = 5 Then
                Dcuit = Mid(MskCuit.Text, 8, 3)
                Mcuit = Mid(MskCuit.Text, 4, 3)
                Icuit = Mid(MskCuit.Text, 1, 2)
                Cuit = Icuit + Mcuit + Dcuit
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
                    MiClase.eliminaactualizaregistra("insert into totalic values(" & Lin & "," & i & "," & AlIv & "," & Net & "," & Iv & "," & Tot1 & "," & Pc & " )")
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
            fecha_cbte = Fecha : fecha_venc_pago = ""
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
            If EsCom = "2" Then
                ok = WSFEv1.AgregarCmpAsoc("1", punto_vta, TxtNCr.Text)
            End If

            'Grabo varias alicuotas de iva
            MiClase.cargardatagriview(DtgTotAlic, "select idiva,alic,neto,iva,total from  totalic ")
            DtgTotAlic.AllowUserToAddRows = False
            Dim fils As Integer = DtgTotAlic.Rows.Count
            For i As Integer = 0 To fils - 1
                misdatos = MiClase.traedataset("select idiva,alic,neto,iva,total from totalic")
                IdAlic = Convert.ToString(DtgTotAlic(0, i).Value)
                Alic = Convert.ToString(DtgTotAlic(1, i).Value)
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
            ' MsgBox("Resultado:" & WSFEv1.Resultado & " CAE: " & cae & " Venc: " & WSFEv1.Vencimiento & " Reproceso: " & WSFEv1.Reproceso, vbInformation + vbOKOnly)
            If cae > "0" Then
                cae = WSFEv1.cae
                fecha_vto_cae = WSFEv1.vencimiento
                VtoCae = WSFEv1.vencimiento
                Crear_Pdf()
                misdatos = MiClase.traedataset("select impresora from configuracion where pc=" & Pc & "")
                Impresora = Trim(misdatos.Tables(0).Rows(0).Item(0))
                Dim printDoc As New PrintDocument
                printDoc.PrinterSettings.PrinterName = Impresora
                AddHandler printDoc.PrintPage, AddressOf print_PrintCliFC
                printDoc.Print()
                If ChkCopia.Checked = True Then
                    AddHandler printDoc.PrintPage, AddressOf print_PrintCliFC
                    printDoc.Print()
                End If

                Guar_Fac()
            End If
            'Else
            'MsgBox("No Obtubo respuesta del servidor", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Respuesta del Servidor")
            'End If

        Catch ex As Exception
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

        End Try

    End Sub
    Private Sub Fac_Elec_old()
        Dim WSFEv1 As Object
        'traigo los datos de la configuracion
        misdatos = MiClase.traedataset("select cuit_em,pv,servidor from configuracion where pc=" & Pc & "")
        Cuit_Em = misdatos.Tables(0).Rows(0).Item(0)
        punto_vta = Trim(misdatos.Tables(0).Rows(0).Item(1))
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
        Fecha = Format(Now, "yyyyMMdd")
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
        fecha_cbte = Fecha : fecha_venc_pago = ""
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
            Alic = Convert.ToString(DtgTotAlic(1, i).Value)
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

        ' MsgBox("Resultado:" & WSFEv1.Resultado & " CAE: " & cae & " Venc: " & WSFEv1.Vencimiento & " Reproceso: " & WSFEv1.Reproceso, vbInformation + vbOKOnly)
        If cae > "0" Then
            cae = WSFEv1.cae
            fecha_vto_cae = WSFEv1.vencimiento
            VtoCae = WSFEv1.vencimiento
            Crear_Pdf()
            misdatos = MiClase.traedataset("select impresora from configuracion where pc=" & Pc & "")
            Impresora = Trim(misdatos.Tables(0).Rows(0).Item(0))
            Dim printDoc As New PrintDocument
            printDoc.PrinterSettings.PrinterName = Impresora
            AddHandler printDoc.PrintPage, AddressOf print_PrintCliFC
            printDoc.Print()
            If ChkCopia.Checked = True Then
                AddHandler printDoc.PrintPage, AddressOf print_PrintCliFC
                printDoc.Print()
            End If

            Guar_Fac()
        Else
            Mensaje = MsgBox("Hubo un problema en  la respuesta del Servidor", MsgBoxStyle.OkOnly + MsgBoxStyle.Question, "Problema Servidor!!!")
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
        'Fila.Total1 = TxtTotal1.Text
        'Fila.Desc = TxtDesc.Text
        Fila.Total = TxtTotal1.Text
        Fila.TotalM = txtTotal.Text
        Fila.Obs = TxtOb.Text
        Fila.Obs1 = TxtOb1.Text
        Mn.Remito.AddRemitoRow(Fila)
        ' Mn.Remito.AddRemitoRow(Fila)
        'detalle de remito
        Dim Fila1 As DtcRemito.DetalleRow
        'Fila1 = Mn.Remito.new
        'FilDt = Mn.Remito.NewRemitoRow
        MiClase.cargardatagriview(Dtgart, "select articulo,punit,cantidad,ptotalm,linea,barra,idpr,idmr,idfm,alic,unidad,descu from t_detalFac where idpc=" & Pc & " order by linea asc ")
        Dtgart.AllowUserToAddRows = False
        For i As Integer = 0 To Dtgart.RowCount - 1
            Fila1 = Mn.Detalle.NewDetalleRow
            Fila1.Articulo = Dtgart(0, i).Value
            Fila1.PUnit = FormatNumber(Dtgart(1, i).Value, 2)
            Fila1.Cantidad = FormatNumber(Dtgart(2, i).Value, 2)
            Fila1.PTotal = FormatNumber(Dtgart(3, i).Value, 2)
            Fila1.IdAr = Dtgart(5, i).Value
            Fila1.Unidad = Dtgart(10, i).Value
            Fila1.Descuento = FormatNumber(Dtgart(11, i).Value, 2)
            Mn.Detalle.AddDetalleRow(Fila1)
        Next
        Reportes.CrystalReportViewer1.Visible = False
        If IdTp = "4" Then
            Dim rpt As New CryRemito
            rpt.SetDataSource(Mn)
            Reportes.CrystalReportViewer1.ReportSource = rpt
            Reportes.CrystalReportViewer1.PrintReport()
            'Reportes.Show()
        ElseIf IdTp = "13" Then
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

        Next

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
        GrpCerrar.Visible = False
        TxtOb.Clear()

        TxtBarra.Text = ""
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
        TxtSaldo.Text = ""
        TxtArticulo.Text = ""
        MskCantidad.Text = ""
        MskPnt.Text = ""
        MskCantidad.Text = ""
        MskPtotal.Text = ""
        MskEntrega.Text = ""
        TxtLimite.Clear()
        TxtProv.Text = ""
        MskDescGral.Text = ""
        TxtProv.Enabled = False
        'Panel2.Visible = False
        MskCantidad.Enabled = False
        MskPtotal.Enabled = False
        MskCuit.Enabled = False
        txtTotal.Text = ""
        MskImp.Text = ""
        TxtTotal1.Text = ""
        TxtDesc.Text = ""
        OptContado.Checked = True
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
        'MiClase.cargardatagriview(DtgCuotas, "select * from  tcuotas where pc=" & Pc & " ")
        MiClase.cargardatagriview(Dtgart, "select articulo,punit,cantidad,ptotal,linea,barra,idpr,idmr,idfm,alic from t_detalFac where idpc=" & Pc & " order by linea desc ")
        TxtNCr.Text = 0
        MiClase.cargardatagriview(DtgNc, "select ctacte.lnum,fecha,importe,entrega,saldo,numero,idtp,cuota,fecven,idcl from ctacte where numero=" & TxtNCr.Text & "and idtp=" & 1000 & "order by cuota desc")
        misdatos = MiClase.traedataset("select fact,pvimp from configuracion where pc=" & Pc & "")
        Fact = misdatos.Tables(0).Rows(0).Item(0)

        TxtPag.Clear()
        txtNumero.Clear()
        misdatos = MiClase.traedataset("select sum(importe) from tpago")
        CantProd = 0
        TsNc.Visible = False
        TsNc.Text = "Articulo"
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
        OptContado.Checked = True
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
            If MskDescuento.Text = "" Then
                MskDescuento.Text = 0
            End If
            Descu = MskDescuento.Text
            If MskDescuento.Text = "" Then
                MskDescuento.Text = 0
            End If
            Descu = MskDescuento.Text
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
            misdatos = MiClase.traedataset("select isnull(max(linea),0) from t_detalfac where idpc=" & Pc & "")
            Linea = misdatos.Tables(0).Rows(0).Item(0) + 1
            MiClase.eliminaactualizaregistra("insert into t_detalfac values(" & Linea & "," & Pc & ",'" & TxtArticulo.Text & "'," & Str(Punit1) & "," & Str(Cantidad) & "," & Str(Descu) & "," & Str(Ptotal) & "," & Str(PtotalM) & "," & TxtBarra.Text & "," & IdPr & "," & IdMr & "," & IdFm & "," & BlNg & "," & Str(Alic1) & "," & IdIva & ",'" & AbUn & "'," & IdAct & ")")
            Refrescar()
            If TxtCli.Text = "" Then
                EsVenta = 0
                OptContado.Checked = True
            Else
                EsVenta = 1
                OptCta.Checked = True

            End If
            If EsVenta = 1 Then
                If TxtLimite.Text = 0 Then
                Else
                    misdatos = MiClase.traedataset("select saldo,salcli from clientes where id=" & Idcl & "")
                    SalMax = FormatNumber(misdatos.Tables(0).Rows(0).Item(0))
                    Saldo = FormatNumber(misdatos.Tables(0).Rows(0).Item(1))
                    misdatos = MiClase.traedataset("select sum(ptotal) from t_detalfac where idpc=" & Pc & "")
                    SalCuo = FormatNumber(misdatos.Tables(0).Rows(0).Item(0))
                    'SalCuo = SalCuo + txtTotal.Text
                    TxtSaldo.Text = SalCuo + Saldo

                    If SalMax <= TxtSaldo.Text Then
                        Mensaje = MsgBox("Llego al Limite", MsgBoxStyle.OkOnly + MsgBoxStyle.Question, "Limite de Cta.Cte")
                    End If
                End If
            End If
        End If

    End Sub
    Private Sub Refrescar()
        Dtgart.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        MiClase.cargardatagriview(Dtgart, "select articulo,cantidad,punit,descu,ptotal,linea,barra,idpr,idmr,idfm,alic,idiv,ptotalm,idact,unidad,idpc from t_detalFac where idpc=" & Pc & " order by linea desc")
        Dtgart.Font = New Font("Arial ", 14, FontStyle.Regular)
        Dtgart.ColumnHeadersVisible = False
        Dtgart.AllowUserToAddRows = False
        'Dtgart.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Dtgart.Columns(0).Width = 400
        'Dtgart.Columns(1).DefaultCellStyle.Format = "##,##0.00"
        Dtgart.Columns(1).DefaultCellStyle.Format = "##,###0.000"
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
        Dtgart.Columns(13).Visible = False
        Dtgart.Columns(14).Visible = False
        Dtgart.Columns(15).Visible = False
        misdatos = MiClase.traedataset("select sum(ptotal),sum(ptotalm) from t_detalfac where idpc=" & Pc & "")
        txtTotal.Text = FormatNumber(misdatos.Tables(0).Rows(0).Item(1), 2)
        TxtTotal1.Text = FormatNumber(misdatos.Tables(0).Rows(0).Item(0), 2)
        TxtArticulo.Text = ""
        MskCantidad.Text = ""
        MskPnt.Text = ""
        MskDescuento.Text = 0
        MskPtotal.Text = ""
        MskPnt.Enabled = False
        MskCantidad.Enabled = False
        MskDescuento.Enabled = False
        MskPtotal.Enabled = False
        PtotalM = 0
        TxtArticulo.Focus()
    End Sub
    Private Sub Guardar1()
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
            Cantidad = MskCantidad.Text
            '  Ptotal = MskPtotal.Text
            If MskDescuento.Text = "" Then
                MskDescuento.Text = 0
            End If
            Descu = MskDescuento.Text
            If MskDescuento.Text = "" Then
                MskDescuento.Text = 0
            End If
            'Descu = MskDescuento.Text
            '    Descu = Decimal.Parse(MskDescuento.Text, System.Globalization.CultureInfo.GetCultureInfo("es-us"))
            Descu = MskDescuento.Text
        End If
        If Punit1 = 0 Or MskCantidad.Text = 0 Or Ptotal = 0 Then
            Mensaje = MsgBox("No Puede haber Importes en 0", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Fala Informacion!!!")
        Else

            If Descu > 0 Then
                '        PtotalM = Ptotal * Descu / 100
                '       PtotalM = FormatNumber(Ptotal - PtotalM, 2)
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
            misdatos = MiClase.traedataset("select isnull(max(linea),0) from t_detalfac where idpc=" & Pc & "")
            Linea = misdatos.Tables(0).Rows(0).Item(0) + 1
            If IdTp = 4 Or IdTp = 0 Then
                If Linea = 37 Then
                    ' If Desc = "" Then
                    ' Desc = 0
                    'End If
                    Mensaje = MsgBox("LLego al Limite de Lineas debe Cerrar el Comprobante", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Limite de Lineas")
                Else
                    Ptotal = PtotalM - Desc
                    MiClase.eliminaactualizaregistra("insert into t_detalfac values(" & Linea & "," & Pc & ",'" & TxtArticulo.Text & "'," & Str(Punit1) & "," & Str(Cantidad) & "," & Str(Descu) & "," & Str(Ptotal) & "," & Str(PtotalM) & "," & TxtBarra.Text & "," & IdPr & "," & IdMr & "," & IdFm & "," & BlNg & "," & Str(Alic1) & "," & IdIva & ",'" & AbUn & "'," & IdAct & ")")
                    '            Linea = Linea + 1
                    Dtgart.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
                    TxtArticulo.Text = ""
                    MskCantidad.Text = 0
                    MskPnt.Text = 0
                    MskDescuento.Text = 0
                    MskPtotal.Text = 0
                    MskPnt.Enabled = False
                    MskCantidad.Enabled = False
                    MskDescuento.Enabled = False
                    MskPtotal.Enabled = False
                    PtotalM = 0
                    EsCant = 0
                    LbCan.Visible = False
                    ' TxtArticulo.Focus()
                End If
            End If
            ' End If
        End If
    End Sub


    Private Sub FrmFacturaa_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

    End Sub


    Private Sub FrmFactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")
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
        EsNeg = Mid(PuerNeg, 1, 3)
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
                ElseIf Dfis = "B604" Then
                    nError = Ihasar.IF_WRITE("@Cancel|")
                End If
                If Dpr = "0" Then
                    MsgBox("Error en la Memoria fiscal, No Esta Formateada", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Llame al Servicio Tecnico")
                ElseIf Dpr = "016" Then
                    MsgBox("El Controlador Fiscal Esta Bloqueado", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Llame al Servicio Tecnico")
                End If
                'nError = Ihasar.Cancel
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
            ElseIf Fact = 4 Then
                CmdCer.Visible = False
                CmbRepZ.Visible = True
                misdatos = MiClase.traedataset("select puerto from configuracion where pc=" & Pc & "")
                PuerImp = Trim(misdatos.Tables(0).Rows(0).Item(0))
                ConectarFiscal()
                ObtenerEstadoFiscalDelEquipo()
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

    Private Sub CmdBart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        IdCom = 0
        EsAr = 1
        FrmBarticulos.Show()
    End Sub
    Private Sub MskCantidad_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MskCantidad.GotFocus
        MskCantidad.SelectionStart = 0
        MskCantidad.SelectionLength = MskCantidad.Text.Length
    End Sub

    Private Sub MskCantidad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MskCantidad.KeyDown
        If e.KeyCode = Keys.Return Then
            MskPnt.Focus()
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
            '    Cantidad = Decimal.Parse(MskCantidad.Text, System.Globalization.CultureInfo.GetCultureInfo("es-us"))
            Cantidad = MskCantidad.Text
            Ptotal = FormatNumber(Punit1 * Cantidad, 2)
            MskPtotal.Text = Str(Ptotal)
            ' MskPunit.Text = 0
            ' MskPunit.Text = Str(Punit1)
            ' MskCantidad.Text = Str(Cantidad)
        Catch ex As Exception
            Mensaje = MsgBox("Se Han Ingresados Caracteres Erroneos: ", MsgBoxStyle.OkOnly, "Informacion Fallida!!!")
            If Mensaje = MsgBoxResult.Ok Then
                MskPnt.Focus()
                MskPtotal.Text = 0
            End If
        End Try

        'End If

    End Sub


    Private Sub TxtArticulo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtArticulo.DoubleClick
        TxtArticulo.Clear()
        MskPnt.Clear()
        MskCantidad.Text = "1.00"
        MskDescuento.Clear()
        MskPtotal.Clear()
        GrpCerrar.Visible = False
    End Sub

    Private Sub TxtArticulo_GiveFeedback(ByVal sender As Object, ByVal e As System.Windows.Forms.GiveFeedbackEventArgs) Handles TxtArticulo.GiveFeedback

    End Sub
    Private Sub TxtArticulo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtArticulo.GotFocus
        TxtArticulo.SelectionStart = 0
        TxtArticulo.SelectionLength = TxtArticulo.Text.Length
    End Sub

    Private Sub TxtArticulo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtArticulo.KeyDown
        'Try

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

            If IsNumeric(TxtArticulo.Text) Then
                Barra = TxtArticulo.Text
                TxtBarra.Text = Barra
                Largo = Len(Barra)
                Primero = Mid(Barra, 1, 1)
                If Largo = 13 And Primero = 2 Then
                    BarId = Mid(Barra, 1, 6)
                    Entero = Mid(Barra, 7, 4)
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
                    Dim PuntB As Decimal
                    TxtArticulo.Focus()
                    misdatos = MiClase.traedataset("select barra,articulo,pfinal,idpr,idfm,idmr,idact,alic,idiv,abu from articulos where barra=" & BarId & "")
                    TxtArticulo.Text = Trim(misdatos.Tables(0).Rows(0).Item(1))
                    MskPnt.Text = FormatNumber(misdatos.Tables(0).Rows(0).Item(2))
                    PuntB = FormatNumber(misdatos.Tables(0).Rows(0).Item(2))
                    Punit1 = FormatNumber(misdatos.Tables(0).Rows(0).Item(2))
                    IdPr = FormatNumber(misdatos.Tables(0).Rows(0).Item(3))
                    IdFm = FormatNumber(misdatos.Tables(0).Rows(0).Item(4))
                    IdMr = FormatNumber(misdatos.Tables(0).Rows(0).Item(5))
                    IdAct = FormatNumber(misdatos.Tables(0).Rows(0).Item(6))
                    Alic1 = FormatNumber(misdatos.Tables(0).Rows(0).Item(7))
                    IdIva = FormatNumber(misdatos.Tables(0).Rows(0).Item(8))
                    AbUn = Trim(misdatos.Tables(0).Rows(0).Item(9))

                    If MskCantidad.Text = "" Then
                        MskCantidad.Text = 1
                    End If
                    If Largo = 13 And Primero = 2 Then
                        Cantidad = FormatNumber(Tot / PuntB, 3)
                        txtTotal.Text = Tot
                        Ptotal = Tot
                        MskCantidad.Text = Cantidad
                        Guardar()
                    Else
                        MskCantidad.Text = 1
                        Cantidad = MskCantidad.Text
                        Tot = Punit1 * MskCantidad.Text
                        MskPtotal.Text = Tot
                        Ptotal = Tot
                        Guardar()

                    End If

                End If
            Else
                'cargo la busqueda de articulos
                EsAr = "1"
                Bart = TxtArticulo.Text
                FrmBarticulos.Show()
            End If


            'End If
        ElseIf e.KeyCode = Keys.F4 Then
            GrpCerrar.Visible = True
            If CmbMenu.Text = "Presupuesto" Then
                EsCom = 0

            ElseIf CmbMenu.Text = "Factura" Then
                EsCom = 1
                IdCom = 1

                TxtOb.Enabled = True
                If TxtCli.Text = "" And BlNg = 0 Then
                    Mensaje = MsgBox("Tiene que Cargar un Cliente", MsgBoxStyle.OkOnly + MsgBoxStyle.Question, "Ingrese un Cliente!!!")
                    If Mensaje = MsgBoxResult.Ok Then
                        GrpCerrar.Visible = False
                        TxtCli.Focus()
                    End If
                Else
                    OptCta.Enabled = True
                    OptContado.Enabled = True
                    OptContado.Checked = True
                    MskImp.Enabled = True
                    MskDescGral.Enabled = False
                    'GroupBox5.Focus()
                    CmdFactura.Enabled = True
                    CmdFactura.Focus()
                End If
            ElseIf CmbMenu.Text = "Remito" Then
                EsCom = 1
                IdCom = 1
                If TxtCli.Text = "" Then
                    OptCta.Enabled = False
                    OptContado.Enabled = False
                    MskImp.Text = txtTotal.Text
                    MskImp.Enabled = True
                    MskImp.Focus()
                    MskImp.SelectionStart = 0
                    MskImp.SelectionLength = MskImp.Text.Length
                Else
                    OptCta.Enabled = True
                    OptContado.Enabled = True
                    OptCta.Checked = True
                    MskImp.Enabled = False
                    MskDescGral.Enabled = False
                    GroupBox5.Focus()
                    CmdFactura.Enabled = True
                    CmdFactura.Focus()
                End If

                ' CmdFactura.Focus()
            ElseIf CmbMenu.Text = "Nota De Credito" Then
                MskDescGral.Enabled = False
                EsCom = 2
                IdCom = 1

            End If



        End If


    End Sub

    Private Sub TxtCli_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCli.Click
        'Panel1.Visible = False
        'Blanquear()
    End Sub
    Private Sub MskPtotal_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MskPtotal.GotFocus
        MskPtotal.SelectionStart = 0
        MskPtotal.SelectionLength = MskPtotal.Text.Length
    End Sub

    Private Sub MskPtotal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MskPtotal.KeyDown
        If e.KeyCode = Keys.Return Then
            MskCantidad.Text = MskPtotal.Text / Punit1
            Punit1 = MskPnt.Text
            Cantidad = MskCantidad.Text
            Ptotal = MskPtotal.Text
            Guardar()
        End If
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
        If txtNumero.Text = "" Then
            txtNumero.Text = "0"
        End If
        If TxtPag.Text = "" Then
            TxtPag.Text = "Efectivo"
            txtNumero.Text = "0"
            IdCom = 1
            ' ImpTot = MskImp.Text
        End If
        Ent1 = MskImp.Text

        MiClase.eliminaactualizaregistra("insert into tpago  values(" & LCom & "," & Pc & "," & IdCom & ",'" & TxtPag.Text & " ', " & _
                 "" & txtNumero.Text & "," & Str(Ent1) & ",'" & DtcVenc.Text & "'," & Str(Ent1) & ")")
        LCom = LCom + 1
        TxtPag.Clear()
        txtNumero.Clear()
        misdatos = MiClase.traedataset("select sum(importe) from tpago where pc=" & Pc & "")
        TotPago = misdatos.Tables(0).Rows(0).Item(0)
        MskImp.Text = FormatNumber(txtTotal.Text - TotPago, 2)
        'IdCom = 1
        'txtNumero.Visible = True
        TxtPag.Enabled = False
        txtNumero.Enabled = False
        txtNumero.Text = ""
        MskImp.Enabled = True
        'txtNumero.Visible = False
        EsVenta = 0
        Cventa = "Contado"
        'Lb.Text = "Pago Efectivo"
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
        If txtNumero.Text = "" Then
            txtNumero.Text = "0"
        End If
        If TxtPag.Text = "" Then
            TxtPag.Text = "Efectivo"
            txtNumero.Text = "0"
            IdCom = 1
            ImpTot = MskImp.Text
        End If
        ImpTot = MskImp.Text

        MiClase.eliminaactualizaregistra("insert into tpago  values(" & LCom & "," & Pc & "," & IdCom & ",'" & TxtPag.Text & " ', " & _
                 "" & txtNumero.Text & "," & ImpTot & ")")
        LCom = LCom + 1

        TxtPag.Clear()
        txtNumero.Clear()
        misdatos = MiClase.traedataset("select sum(importe) from tpago where pc=" & Pc & "")
        TotPago = misdatos.Tables(0).Rows(0).Item(0)
        MskImp.Text = FormatNumber(txtTotal.Text - TotPago, 2)
        MskImp.Focus()
        CmdFactura.Enabled = True
    End Sub
    Private Sub MskImp_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MskImp.KeyDown
        If e.KeyCode = Keys.Return Then
            CmdFactura.Enabled = True
            CmdFactura.Focus()
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
            Refrescar()
            'MiClase.cargardatagriview(Dtgart, "select articulo,punit,cantidad,descu,ptotal,linea,barra,idpr,idmr,idfm,alic,idiv,ptotalm,idact from t_detalFac where idpc=" & Pc & " order by linea ")
            'Dtgart.Font = New Font("Arial ", 14, FontStyle.Regular)
            'Dtgart.ColumnHeadersVisible = False
            'Dtgart.AllowUserToAddRows = False
            'Dtgart.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            'Dtgart.Columns(0).Width = 360
            'Dtgart.Columns(1).DefaultCellStyle.Format = "##,##0.00"
            'Dtgart.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            'Dtgart.Columns(2).DefaultCellStyle.Format = "##,##0.00"
            'Dtgart.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            'Dtgart.Columns(3).DefaultCellStyle.Format = "##,##0.00"
            'Dtgart.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            'Dtgart.Columns(4).DefaultCellStyle.Format = "##,##0.00"
            'Dtgart.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            'Dtgart.Columns(12).DefaultCellStyle.Format = "##,##0.00"
            'Dtgart.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            'Dtgart.Columns(4).Visible = False
            'Dtgart.Columns(5).Visible = False
            'Dtgart.Columns(6).Visible = False
            'Dtgart.Columns(7).Visible = False
            'Dtgart.Columns(8).Visible = False
            'Dtgart.Columns(9).Visible = False
            'Dtgart.Columns(10).Visible = False
            'Dtgart.Columns(11).Visible = False
            misdatos = MiClase.traedataset("select isnull(sum(ptotalm),0) from t_detalfac where idpc=" & Pc & "")
            txtTotal.Text = FormatNumber(misdatos.Tables(0).Rows(0).Item(0), 2)
            TxtArticulo.Text = ""
            MskCantidad.Text = ""
            MskPnt.Text = ""
            MskDescuento.Text = 0
            MskPtotal.Text = ""
            MskPnt.Enabled = False
            MskCantidad.Enabled = False
            MskDescuento.Enabled = False
            MskPtotal.Enabled = False
            PtotalM = 0
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
        MskImp.Enabled = True
        Lbtar.Text = "Tarjeta :"
        txtNumero.Text = ""
        EsVenta = 0
        Cventa = "Contado"
        IdCom = 2
        IdCuota = 0
        'Lb.Text = "pago Con Tarjeta"
        'Panel2.Visible = False
    End Sub



    Private Sub Cmdefectivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmdefectivo.Click
        IdCom = 1
        txtNumero.Visible = True
        TxtPag.Enabled = False
        txtNumero.Enabled = False
        txtNumero.Text = ""
        MskImp.Enabled = True
        txtNumero.Visible = False
        EsVenta = 0
        Cventa = "Contado"
        'Lb.Text = "Pago Efectivo"
        'Panel2.Visible = False
        MskImp.Focus()
    End Sub

    Private Sub TxtCli_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCli.KeyDown
        If e.KeyCode = Keys.Return And TxtDir.Enabled = True Then
            TxtDir.Focus()
        ElseIf e.KeyCode = Keys.Return And TxtDir.Enabled = False Then
            If IsNumeric(TxtCli.Text) Then
                misdatos = MiClase.traedataset("select id,cliente,direccion from clientes where id=" & TxtCli.Text & "")
                Dim totclF As Integer = misdatos.Tables(0).Rows.Count
                If totclF = 0 Then
                    Mensaje = MsgBox("Este Cliente No Existe", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Cliente Inexistente!!!")
                    If Mensaje = MsgBoxResult.Ok Then
                        TxtCli.Focus()
                    End If
                Else
                    misdatos = MiClase.traedataset("select clientes.id,cliente,direccion,ciudad,cuit,c_iva,idciu,idciva,email,telefono,cel,cpostal,idpr,provincia,email,salcli,saldo from clientes inner join ciudad on clientes.idciu=ciudad.id inner join c_de_iva on clientes.idciva = c_de_iva.id inner join provincias on clientes.idpr=provincias.id where clientes.id = " & TxtCli.Text & " ")
                    Idcl = misdatos.Tables(0).Rows(0).Item(0)
                    TxtCli.Text = misdatos.Tables(0).Rows(0).Item(1)
                    TxtDir.Text = misdatos.Tables(0).Rows(0).Item(2)
                    TxtCiudad.Text = misdatos.Tables(0).Rows(0).Item(3)
                    MskCuit.Text = misdatos.Tables(0).Rows(0).Item(4)
                    TxtcIva.Text = misdatos.Tables(0).Rows(0).Item(5)
                    IdCiva = misdatos.Tables(0).Rows(0).Item(7)
                    TxtProv.Text = misdatos.Tables(0).Rows(0).Item(13)
                    TxtSaldo.Text = FormatNumber(misdatos.Tables(0).Rows(0).Item(15), 2)
                    TxtLimite.Text = FormatNumber(misdatos.Tables(0).Rows(0).Item(16), 2)
                    If TxtLimite.Text = 0 Then
                    Else
                        If TxtSaldo.Text > TxtLimite.Text Then
                            Mensaje = MsgBox("Llego al Limite", MsgBoxStyle.OkOnly + MsgBoxStyle.Question, "Limite de Cta.Cte")
                        End If
                    End If
                    TxtArticulo.Focus()
                End If
            Else
                EsCl = "3"
                BCli = TxtCli.Text
                FrmBcl.Show()
            End If

        End If
    End Sub



    Private Sub TxtNCh_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Return Then
            DtcVenc.Enabled = True
            DtcVenc.Focus()
        End If
    End Sub

    Private Sub TxtNCh_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
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
        If OptContado.Checked = True Then
            EsVenta = 0
            Cventa = "Contado"
            If TxtPag.Text = "" Then
                TxtPag.Text = "Efectivo"
            End If
            If txtNumero.Text = "" Then
                txtNumero.Text = 0
                NmCm = txtNumero.Text
            End If
            If MskImp.Text = "" Or MskImp.Text = "0" Then
                MskImp.Text = txtTotal.Text
            End If
            Cerrar_Comp()
        ElseIf OptCta.Checked = True Then
            EsVenta = 1
            Cventa = "Cta.Cte"
            Cerrar_Comp()
        End If

    End Sub

    Private Sub CArticulos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CArticulos.Click
        FrmInArticulos.Show()
    End Sub

    Private Sub CmdFactura_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmdFactura.KeyDown
        If e.KeyCode = Keys.F10 Then
            MsgBox("Presoiono")
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


    Private Sub TxtOb1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Return Then
            If EsCom = 1 Then
                MskImp.Focus()
            Else
                CmdFactura.Focus()
            End If
        End If
    End Sub

    Private Sub TxtOb1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        FRmCaja.Show()
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
            ElseIf Fact = 4 Then


                Dim respuesta As Integer
                Dim mensaje As String = "ABIERTA"

                retorno = ConsultarEstado(JORNADA_FISCAL, respuesta)
                If respuesta = 0 Then
                    mensaje = MsgBox("Jornada  Fiscal Cerrada")
                Else

                    retorno = ImprimirCierreZ
                End If
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

    Private Sub TxtCli_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCli.KeyPress

    End Sub

    Private Sub TxtCli_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCli.TextChanged

    End Sub








    Private Sub MskDescuento_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MskDescuento.GotFocus
        MskDescuento.Text = 0
        MskDescuento.SelectionStart = 0
        MskDescuento.SelectionLength = MskDescuento.Text.Length
    End Sub

    Private Sub MskDescuento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MskDescuento.KeyDown
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

    Private Sub MskDescuento_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MskDescuento.LostFocus
        If BlNg = 1 Then
            Desc = MskPtotal.Text * MskDescuento.Text / 100
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

    Private Sub TxtNCh_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

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


    Private Sub BtnArt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBusRem.Click
        FrmBusRem.Show()
    End Sub

    Private Sub ToolStripButton2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        FrmBusRem.Show()
    End Sub

    Private Sub MskPnt_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MskPnt.GotFocus
        MskPnt.SelectionStart = 0
        MskPnt.SelectionLength = MskPnt.Text.Length
    End Sub

    Private Sub MskPnt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MskPnt.KeyDown
        If e.KeyCode = Keys.Return Then
            Punit1 = MskPnt.Text
            Cantidad = MskCantidad.Text
            Ptotal = FormatNumber(MskPnt.Text * Cantidad, 2)
            PtotalM = FormatNumber(MskPnt.Text * Cantidad, 2)
            MskPtotal.Text = PtotalM
            MskDescuento.Enabled = True
            MskDescuento.Focus()
        End If
    End Sub



    Private Sub Dtgart_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dtgart.CellEndEdit
        fila = CType((e.RowIndex.ToString()), Integer) ''Obtiene la fila actual
        Cantidad = FormatNumber(Me.Dtgart.Rows(e.RowIndex).Cells(1).Value(), 2)
        Punit1 = FormatNumber(Me.Dtgart.Rows(e.RowIndex).Cells(2).Value(), 2)
        Lin = FormatNumber(Me.Dtgart.Rows(e.RowIndex).Cells(5).Value(), 2)
        Pc = FormatNumber(Me.Dtgart.Rows(e.RowIndex).Cells(15).Value(), 2)
        Ptotal = Punit1 * Cantidad
        MiClase.eliminaactualizaregistra("update t_detalfac set punit=" & Punit1 & ", cantidad=" & Cantidad & ",ptotal=" & Ptotal & ",ptotalm=" & Ptotal & " where linea=" & Lin & " and idpc=" & Pc & "")
        Refrescar()
        If TxtCli.Text = "" Then
            EsVenta = 0
            OptContado.Checked = True
        Else
            EsVenta = 1
            OptCta.Checked = True

        End If
        If EsVenta = 1 Then
            If TxtLimite.Text = 0 Then
            Else
                misdatos = MiClase.traedataset("select saldo,salcli from clientes where id=" & Idcl & "")
                SalMax = FormatNumber(misdatos.Tables(0).Rows(0).Item(0))
                Saldo = FormatNumber(misdatos.Tables(0).Rows(0).Item(1))
                misdatos = MiClase.traedataset("select sum(ptotal) from t_detalfac where idpc=" & Pc & "")
                SalCuo = FormatNumber(misdatos.Tables(0).Rows(0).Item(0))
                'SalCuo = SalCuo + txtTotal.Text
                TxtSaldo.Text = SalCuo + Saldo
                If TxtSaldo.Text <= SalMax Then
                    Mensaje = MsgBox("Llego al Limite", MsgBoxStyle.OkOnly + MsgBoxStyle.Question, "Limite de Cta.Cte")
                End If
            End If
        End If
    End Sub
End Class