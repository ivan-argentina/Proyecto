Imports System.Text
Imports System
Imports System.IO.Ports
Imports Microsoft.VisualBasic
Imports FiscalNET
Imports System.Drawing.Printing
Imports System.Drawing



Public Class FrmBusRem
    Dim chk As New DataGridViewCheckBoxColumn()
    Dim Dif As Integer
    Dim FcAc As Date = Date.Now
    Dim Fc As Date
    Dim TotTic As Decimal

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
        Fecha = Fecha
        concepto = 3
        ' datos del cliente:
        If IdCiva = 1 Then
            tipo_doc = 80
        Else
            tipo_doc = 96
        End If


        Dim Nombre_Cliente, nombre, x1, y1, x2, y2, bonif, despacho, dato_a, dato_b, dato_c, dato_d, dato_e, u_mtx, cod_mtx, codigo, ds, qty, umed, precio, iva_id, idioma_cbte, Domicilio_Cliente, pais_dst_cmp, id_impositivo, descuento, imp_subtotal, obs_generales, forma_pago, incoterms As String
        Dim Cliente_Localidad As String
        Nombre_Cliente = CliTick
        Domicilio_Cliente = DirTick
        Cliente_Localidad = CiuTick
        pais_dst_cmp = 16 ' código para exportación
        id_impositivo = "A Consumidor Final"  '

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
            fecha_cbte = Fecha : fecha_venc_pago = Fecha
            ' Fechas del período del servicio facturado
            fecha_serv_desde = Fecha : fecha_serv_hasta = Fecha
            moneda_id = "PES" : moneda_ctz = "1.000"
        Else
            imp_total = ToTT : imp_tot_conc = "0.00"
            imp_neto = 0 : imp_iva = 0
            imp_trib = "0.00" : imp_op_ex = "0.00" : imp_subtotal = NetT
            descuento = "0.00"
            fecha_cbte = Fecha : fecha_venc_pago = Fecha
            ' Fechas del período del servicio facturado
            fecha_serv_desde = Fecha : fecha_serv_hasta = Fecha
            moneda_id = "PES" : moneda_ctz = "1.000"
        End If
        obs_generales = ""
        'If IdCom = 2 Or IdCom = 3 Then

        Dim fila As Integer = DtgDetRem.Rows.Count
        Dim cont As Integer = 0

       

        Comprobante = "Efectivo"
        Obs = "Pago Con :" + CStr(Comprobante) + CStr(ImPag)
        obs_comerciales = Obs

        'End If
        moneda_id = "012"
        moneda_ctz = 0.5
        Cventa = "Contado"
        forma_pago = Cventa
        cae = cae
        fecha_vto_cae = VtoCae

        ' Creo la factura (internamente en la interfaz)
        'Motivo_obs = ""
        idioma_cbte = "1"
        incoterms = 0
        motivo_obs = "0"
        fecha_venc_pago = ""
        fecha_serv_desde = ""
        'fecha_serv_hasta = ""
        ok = PyFEPDF.CrearFactura(concepto, tipo_doc, nro_doc, tipo_cbte, punto_vta, cbte_nro, imp_total, imp_tot_conc, imp_neto, imp_iva, imp_trib, imp_op_ex, fecha_cbte, fecha_venc_pago, fecha_serv_desde, fecha_serv_hasta, moneda_id, moneda_ctz, cae, VtoCae, id_impositivo, Nombre_Cliente, Domicilio_Cliente, pais_dst_cmp, obs_comerciales, obs_generales, forma_pago, incoterms, idioma_cbte, motivo_obs, descuento)
        ok = PyFEPDF.EstablecerParametro("localidad_cliente", CiuTick)
        ok = PyFEPDF.EstablecerParametro("provincia_cliente", "Santa Fe")
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
        Dim fil As Integer = DtgDetRem.Rows.Count
        Dim contador As Integer = 0
        '"select barra,articulo,punit,cantidad,ptotal,id,idtp,linea,idfm,idmr,idpr,alic,idalic,idcl from detal_fac where idtp=" & 4 & "and id=" & NumFac & "order by linea desc")
        For i As Integer = 0 To fil - 1
            If IsDBNull(Convert.ToString(DtgDetRem(1, i).Value)) Then
            Else
                Articulo = Trim(Convert.ToString(DtgDetRem(1, i).Value))
            End If
            If IsDBNull(Convert.ToString(DtgDetRem(3, i).Value)) Then
            Else
                Cantidad = Convert.ToDecimal(DtgDetRem(3, i).Value)
            End If
            If IsDBNull(Convert.ToString(DtgDetRem(2, i).Value)) Then
            Else
                Punt = Convert.ToDecimal(DtgDetRem(2, i).Value)
            End If

            If IsDBNull(Convert.ToString(DtgDetRem(4, i).Value)) Then
            Else
                Ptotal = Convert.ToDecimal(DtgDetRem(4, i).Value)
            End If
            If IsDBNull(Convert.ToString(DtgDetRem(7, i).Value)) Then
            Else
                LinCom = (DtgDetRem(7, i).Value)
            End If
            If IsDBNull(Convert.ToString(DtgDetRem(0, i).Value)) Then
            Else
                BarFac = Convert.ToString((DtgDetRem(0, i).Value))
            End If
            If IsDBNull(Convert.ToString(DtgDetRem(11, i).Value)) Then
            Else
                Alic1 = Convert.ToDecimal(DtgDetRem(11, i).Value)
            End If
            If IsDBNull(Convert.ToString(DtgDetRem(12, i).Value)) Then
            Else
                IdAlic = Convert.ToDecimal(DtgDetRem(12, i).Value)
            End If
            'If IsDBNull(Convert.ToString(DtgDetRem(14, i).Value)) Then
            'Else
            'Abn = Trim(Convert.ToString(DtgDetRem(14, i).Value))
            'End If
            Abn = 7
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
        'ok = PyFEPDF.AgregarDato("logocont", PyFEPDF.InstallDir + "\plantillas\logo.png")
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
                NomArc = Trim("A" + CStr(cbte_nro) + "-" + Trim(CliTick))
            Else
                NomArc = "B" + CStr(cbte_nro) + "-" + Trim(CliTick)

            End If
        ElseIf EsCom = 2 Then
            If IdCiva = 1 Then
                NomArc = Trim("NC-A" + CStr(cbte_nro) + "-" + Trim(CliTick))
            Else
                NomArc = "NC-B" + CStr(cbte_nro) + "-" + Trim(CliTick)

            End If
        ElseIf EsCom = 3 Then
            If IdCiva = 1 Then
                NomArc = Trim("ND-A" + CStr(cbte_nro) + "-" + Trim(CliTick))
            Else
                NomArc = "ND-B" + CStr(cbte_nro) + "-" + Trim(CliTick)

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
        e.Graphics.DrawString(CliTick, prFont, Brushes.Black, New Rectangle(0, y, width, 15))
        y = y + 15
        e.Graphics.DrawString(DirTick, prFont, Brushes.Black, New Rectangle(0, y, width, 15))
        y = y + 15
        e.Graphics.DrawString(CiuTick, prFont, Brushes.Black, New Rectangle(0, y, width, 15))
        y = y + 15
        e.Graphics.DrawString(CuitTick, prFont, Brushes.Black, New Rectangle(0, y, width, 15))
        e.Graphics.DrawLine(OurPen, 0, 230, width, 230)
        y = 240
        CantProd = 0
        'imprimo  los Items
        Dim filas As Integer = DtgDetRem.Rows.Count
        Dim contador As Integer = 0
        'select barra,articulo,punit,cantidad,ptotal,id,idtp,linea,idfm,idmr,idpr,alic,idalic,idcl from detal_fac
        For i As Integer = 0 To filas - 1
            If IsDBNull(Convert.ToString(DtgDetRem(1, i).Value)) Then
            Else
                Articulo = Mid(Convert.ToString(DtgDetRem(1, i).Value), 1, 30)
            End If

            If IsDBNull(Convert.ToString(DtgDetRem(2, i).Value)) Then
            Else
                PunIm = Mid(Convert.ToString(DtgDetRem(2, i).Value), 1, 5)
                Punit1 = Mid(Convert.ToString(DtgDetRem(2, i).Value), 1, 5)
            End If
            If IsDBNull(Convert.ToString(DtgDetRem(3, i).Value)) Then
            Else
                CanIm = Convert.ToString(DtgDetRem(3, i).Value)
                Canti = Convert.ToString(DtgDetRem(3, i).Value)
            End If
            If IsDBNull(Convert.ToString(DtgDetRem(4, i).Value)) Then
            Else
                PtoIm = Mid(Convert.ToString(DtgDetRem(4, i).Value), 1, 7)
                Ptotal = FormatNumber(Convert.ToDecimal(DtgDetRem(4, i).Value), 2)
            End If

            DetCant = CanIm + " / " + PunIm
            e.Graphics.DrawString(DetCant, prFont, Brushes.Black, New Rectangle(0, y, width, 15))
            e.Graphics.DrawString(Ptotal, prFont, Brushes.Black, New Rectangle(xPos, y, Width1, 15))
            y = y + 12
            e.Graphics.DrawString(Articulo, prFont, Brushes.Black, New Rectangle(0, y, width, 15))
            y = y + 15
            Cantidad = Convert.ToDecimal(DtgDetRem(3, i).Value)
            Barra = Convert.ToDecimal(DtgDetRem(0, i).Value)
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
        e.Graphics.DrawString("TOTAL: " + TxtTotal.Text, prFontT, Brushes.Black, New Rectangle(xPos, y, Width1, 15))
        y = y + 15
        e.Graphics.DrawString("Cond.de Venta :" + Cventa, prFont, Brushes.Black, New Rectangle(0, y + 20, width, 15))

        ' misdatos = MiClase.traedataset("select count(linea) from t_detalfac where idpc=" & Pc & "")
        ' CantProd = FormatNumber(misdatos.Tables(0).Rows(0).Item(0), 2)
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
        FechIm = "Fecha : " + FcD
        e.Graphics.DrawString(FechIm, prFont, Brushes.Black, New Rectangle(xPos, y + 80, width, 15))
        e.Graphics.DrawString(Clave, prFont, Brushes.Black, New Rectangle(xPos, y + 95, width, 15))
        'select barra,articulo,punit,cantidad,ptotal,id,idtp,linea,idfm,idmr,idpr,alic,idalic,idcl from detal_fac
        Dim OurPen As Pen
        OurPen = New Pen(Color.Black, 1)
        e.Graphics.DrawLine(OurPen, 0, 160, width, 160)
        y = 165
        CantProd = 0
        'imprimo  los Items
        Dim filas As Integer = DtgDetRem.Rows.Count
        Dim contador As Integer = 0
        For i As Integer = 0 To filas - 1
            If IsDBNull(Convert.ToString(DtgDetRem(1, i).Value)) Then
            Else
                Articulo = Mid(Convert.ToString(DtgDetRem(1, i).Value), 1, 30)
            End If

            If IsDBNull(Convert.ToString(DtgDetRem(1, i).Value)) Then
            Else
                PunIm = Mid(Convert.ToString(DtgDetRem(2, i).Value), 1, 5)
                Punit1 = Mid(Convert.ToString(DtgDetRem(2, i).Value), 1, 5)
            End If
            If IsDBNull(Convert.ToString(DtgDetRem(3, i).Value)) Then
            Else
                CanIm = Convert.ToString(DtgDetRem(3, i).Value)
                Canti = Convert.ToString(DtgDetRem(3, i).Value)
            End If
            If IsDBNull(Convert.ToString(DtgDetRem(4, i).Value)) Then
            Else
                PtoIm = Mid(Convert.ToString(DtgDetRem(4, i).Value), 1, 7)
                Ptotal = FormatNumber(DtgDetRem(4, i).Value, 2)
            End If
            Cantidad = Convert.ToDecimal(DtgDetRem(3, i).Value)
            Barra = Convert.ToDecimal(DtgDetRem(0, i).Value)
            Largo = Len(Barra)
            Primero = Mid(Barra, 1, 1)
            If Largo = 13 And Primero = 2 Then
                Cantidad = 1
            End If
            If Cantidad < 1 Then
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

        'AGREGAR ESTE CAMPO ES EL TOTAL
        e.Graphics.DrawString("TOTAL: " + TxtTotal.Text, prFontT, Brushes.Black, New Rectangle(xPos, y, Width1, 15))
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
        'MsgBox(WSAA.Token, vbInformation, "WSAA Token")
        'MsgBox(WSAA.Sign, vbInformation, "WSAA Sign")
        MiClase.eliminaactualizaregistra("delete from ticket ")
        Dim Ftick As String
        'Ftick = Date.Now
        'Ftick = Convert.ToDateTime(Date.Now)
        Ftick = Format(Date.Now, "dd/MM/yy hh:mm:ss")
        MiClase.eliminaactualizaregistra("insert into ticket values('" & WSAA.token & "','" & WSAA.sign & "','" & Ftick & "')")
        '  MiClase.eliminaactualizaregistra("insert into ticket values('" & WSAA.token & "','" & WSAA.sign & "','" & Date.Now & "')")

    End Sub

   
    Private Sub Guar_fac()
        'Cargo  los Items
        'barra,articulo,punit,cantidad,ptotal,id,idtp,linea,idfm,idmr,idpr,alic,idalic from detal_fac where idtp=" & 4 & "and id=" & NumFac & "order by linea desc")
        Dim filas As Integer = DtgDetRem.Rows.Count
        Dim contador As Integer = 0
        For i As Integer = 0 To filas - 1
            BarFac = Convert.ToDecimal(DtgDetRem(0, i).Value)
            Articulo = Convert.ToString(DtgDetRem(1, i).Value)
            Punt = Convert.ToDecimal(DtgDetRem(2, i).Value)
            Cantidad = Convert.ToDecimal(DtgDetRem(3, i).Value)
            Ptotal = Convert.ToDecimal(DtgDetRem(4, i).Value)
            LinCom = Convert.ToString(DtgDetRem(7, i).Value)
            IdFm = Convert.ToDecimal(DtgDetRem(8, i).Value)
            IdMr = Convert.ToDecimal(DtgDetRem(9, i).Value)
            IdPr = Convert.ToDecimal(DtgDetRem(10, i).Value)
            Alic = Convert.ToDecimal(DtgDetRem(11, i).Value)
            IdAlic = Convert.ToDecimal(DtgDetRem(12, i).Value)
            If EsVenta = 0 Then
                Cventa = "Contado"
            End If
            BlNg = 0
            Fnum()
            'Grabo el detalle de factura
            MiClase.eliminaactualizaregistra("insert into detal_fac values(" & cbte_nro & "," & tipo_cbte & " ," & LinCom & "," & Pv & ",'" & Fecha & "', " & _
            "" & BarFac & ",'" & Articulo & "'," & Str(Punt) & "," & Str(Cantidad) & "," & Str(Ptotal) & "," & IdFm & "," & IdMr & "," & IdPr & ", " & _
           "" & Str(Alic) & "," & Idcl & "," & IdEnc & "," & EsVenta & ",'" & Cventa & "'," & IdAlic & "," & BlNg & ",'" & Clave & "'," & IdAct & "," & IdUs & ")")
            LinCom = LinCom + 1
        Next
        Dim Obs As String = 0
        BlNg = 0
        Cpostal = 0
        IdPrv = 12
        misdatos = MiClase.traedataset("select sum(neto),sum(iva),sum(total) from totalic where pc=" & Pc & "")
        NetT = FormatNumber(misdatos.Tables(0).Rows(0).Item(0), 2)
        'IvT = misdatos.Tables(0).Rows(0).Item(1)
        ToTT = FormatNumber(misdatos.Tables(0).Rows(0).Item(2), 2)
        TotTic = FormatNumber(misdatos.Tables(0).Rows(0).Item(2), 2)
        MiClase.eliminaactualizaregistra("insert into facturas values(" & cbte_nro & "," & tipo_cbte & ", " & _
          "" & Pv & "," & IdEnc & "," & Idcl & ",'" & Fecha & "'," & EsVenta & ",'" & Cventa & "'," & Str(NetT) & ", " & _
          "" & Str(IvT) & "," & Str(Iint) & "," & Str(TotTic) & "," & BlNg & "," & Str(Alic) & ",'" & Fecha & "','" & Clave & "'," & 0 & ", " & _
          "'" & Obs & "','" & Obs & "','" & CliTick & "','" & DirTick & "','" & CiuTick & "'," & _
          "'" & CivaTick & "','" & CuitTick & "'," & IdCiva & ",'" & Cpostal & "'," & IdPrv & "," & IdUs & ")")
        'MsgBox("Resultado:"Factura Generada CAE: " & cae & ", vbInformation + vbOKOnly)
        Mensaje = MsgBox("Factura Generada CAE:" & cae & " ", MsgBoxStyle.OkOnly + MsgBoxStyle.Question, "Factura Genrada!!!")
        If Mensaje = MsgBoxResult.Ok Then
            DtgDetRem.DataSource = Nothing
            MiClase.eliminaactualizaregistra("delete from totalic where pc=" & Pc & "")
            Idcl = 0
        End If
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
        'TxtPv.Text = Lpv
        'TxtNumFac.Text = Lnum
        Clave = Lpv + "-" + Lnum
    End Sub
    Private Sub print_PrintCliFC(ByVal sender As Object, _
                   ByVal e As PrintPageEventArgs)
        Dim PCom As String
        Dim PAbrev As String
        Dim Pcod As String
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
        Dim dd As Integer = tipo_cbte
        'Traigo los datos del encabezado
        misdatos = MiClase.traedataset("select cuit_em,pv,empresa,direccion,ciudad,ib,civa,in_act,lfantacia from configuracion")
        Cuit_Em = misdatos.Tables(0).Rows(0).Item(0)
        Pv = misdatos.Tables(0).Rows(0).Item(1)
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


        e.Graphics.DrawString(Lfantacia, prFontE, Brushes.Black, New Rectangle(0, y + 15, width, 15))
        e.Graphics.DrawString(Empresa, prFont, Brushes.Black, New Rectangle(0, y + 35, width, 15))
        e.Graphics.DrawString(Cuit_Em, prFont, Brushes.Black, New Rectangle(0, y + 50, width, 15))
        e.Graphics.DrawString(DirEm, prFont, Brushes.Black, New Rectangle(0, y + 65, width, 15))
        e.Graphics.DrawString(CiuEm, prFont, Brushes.Black, New Rectangle(0, y + 80, width, 15))
        e.Graphics.DrawString("Inc.Actividades: " + InAcEm, prFont, Brushes.Black, New Rectangle(0, y + 95, width, 15))
        e.Graphics.DrawString("I.Brutos: " + IbEm, prFont, Brushes.Black, New Rectangle(0, y + 110, width, 15))
        FNum()
        Dim OurPen As Pen
        OurPen = New Pen(Color.Black, 1)
        e.Graphics.DrawLine(OurPen, 0, 190, width, 190)
        Fecha = Format(Now, "dd/MM/yyyy")
        e.Graphics.DrawString(PCom, prFontE, Brushes.Black, New Rectangle(0, y + 140, width, 15))
        FechIm = "Fecha : " + Fecha
        e.Graphics.DrawString(Clave, prFont, Brushes.Black, New Rectangle(xPos, y + 143, width, 15))
        e.Graphics.DrawString(Fecha, prFont, Brushes.Black, New Rectangle(xPos, y + 158, width, 15))
        e.Graphics.DrawString(Pcod, prFont, Brushes.Black, New Rectangle(0, y + 158, width, 15))
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

        y = 300
        CantProd = 0
        If IdCiva = 1 Then
            'imprimo  los Items
            Dim filas As Integer = DtgDetRem.Rows.Count
            Dim contador As Integer = 0
            For i As Integer = 0 To filas - 1
                If IsDBNull(Convert.ToString(DtgDetRem(1, i).Value)) Then
                Else
                    Articulo = Mid(Convert.ToString(DtgDetRem(1, i).Value), 1, 30)
                End If

                If IsDBNull(Convert.ToString(DtgDetRem(2, i).Value)) Then
                Else
                    PunIm = Mid(Convert.ToString(DtgDetRem(2, i).Value), 1, 5)
                    Punit1 = Mid(Convert.ToString(DtgDetRem(2, i).Value), 1, 5)
                End If
                If IsDBNull(Convert.ToString(DtgDetRem(3, i).Value)) Then
                Else
                    CanIm = Convert.ToString(DtgDetRem(3, i).Value)
                    Canti = Convert.ToString(DtgDetRem(3, i).Value)
                End If
                If IsDBNull(Convert.ToString(DtgDetRem(4, i).Value)) Then
                Else
                    PtoIm = Mid(Convert.ToString(DtgDetRem(4, i).Value), 1, 7)
                    Ptotal = FormatNumber(Convert.ToDecimal(DtgDetRem(4, i).Value), 2)
                End If
                If IsDBNull(Convert.ToString(DtgDetRem(11, i).Value)) Then
                Else

                    IdAlic = Convert.ToString(DtgDetRem(12, i).Value)
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
                '+ " (" + AlicIm + ")"
                e.Graphics.DrawString(Articulo + " (" + Str(AlicIm) + ")", prFont, Brushes.Black, New Rectangle(0, y, width, 15))
                y = y + 15
                Barra = Convert.ToDecimal(DtgDetRem(0, i).Value)
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
                    ' Net = misdatos.Tables(0).Rows(0).Item(0)
                    Iv = misdatos.Tables(0).Rows(0).Item(1)
                    ' Tot = misdatos.Tables(0).Rows(0).Item(2)
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
            'IvT = misdatos.Tables(0).Rows(0).Item(1)
            ToTT = FormatNumber(misdatos.Tables(0).Rows(0).Item(2), 2)
            TotTic = FormatNumber(misdatos.Tables(0).Rows(0).Item(2), 2)
            y = y + 15
            'e.Graphics.DrawString(FechIm,               prFont, Brushes.Black, New Rectangle(xPos, y + 158, width, 15))
            e.Graphics.DrawString("NETO: " + Str(NetT), prFont, Brushes.Black, New Rectangle(xPos, y, Width1, 15))
            y = y + 15
            e.Graphics.DrawString("IVA 10.5 %: " + Str(Iva10), prFont, Brushes.Black, New Rectangle(xPos, y, Width1, 15))
            y = y + 15
            e.Graphics.DrawString("IVA 21.00 %: " + Str(Iva21), prFont, Brushes.Black, New Rectangle(xPos, y, Width1, 15))
            y = y + 15
            e.Graphics.DrawString("TOTAL: " + Str(ToTT), prFontT, Brushes.Black, New Rectangle(xPos, y, Width1, 15))
        Else
            'imprimo  los Items
            Dim filas As Integer = DtgDetRem.Rows.Count
            Dim contador As Integer = 0
            For i As Integer = 0 To filas - 1
                If IsDBNull(Convert.ToString(DtgDetRem(1, i).Value)) Then
                Else
                    Articulo = Mid(Convert.ToString(DtgDetRem(1, i).Value), 1, 30)
                End If

                If IsDBNull(Convert.ToString(DtgDetRem(2, i).Value)) Then
                Else
                    PunIm = Mid(Convert.ToString(DtgDetRem(2, i).Value), 1, 5)
                    Punit1 = Mid(Convert.ToString(DtgDetRem(2, i).Value), 1, 5)
                End If
                If IsDBNull(Convert.ToString(DtgDetRem(3, i).Value)) Then
                Else
                    CanIm = Convert.ToString(DtgDetRem(3, i).Value)
                    Canti = Convert.ToString(DtgDetRem(3, i).Value)
                End If
                If IsDBNull(Convert.ToString(DtgDetRem(4, i).Value)) Then
                Else
                    PtoIm = Mid(Convert.ToString(DtgDetRem(4, i).Value), 1, 7)
                    Ptotal = FormatNumber(Convert.ToDecimal(DtgDetRem(4, i).Value), 2)
                End If
                If IsDBNull(Convert.ToString(DtgDetRem(12, i).Value)) Then
                Else

                    IdAlic = Convert.ToString(DtgDetRem(12, i).Value)
                    misdatos = MiClase.traedataset("select id,alic from alic_iva where id=" & IdAlic & "")
                    AlicIm = Mid(misdatos.Tables(0).Rows(0).Item(1), 1, 5)
                End If
                DetCant = CanIm + " / " + PunIm
                e.Graphics.DrawString(DetCant, prFont, Brushes.Black, New Rectangle(0, y, width, 15))
                e.Graphics.DrawString(Ptotal, prFont, Brushes.Black, New Rectangle(230, y, 500, 15))
                y = y + 12
                e.Graphics.DrawString(Articulo + "(" + Str(AlicIm) + ")", prFont, Brushes.Black, New Rectangle(0, y, width, 15))
                y = y + 15

            Next
            DetCant = ""
            Ptotal = "0"
            Articulo = ""

            'e.Graphics.DrawString("TOTAL: " + Str(ToTT), prFontT, Brushes.Black, New Rectangle(150, y, Width1, 15))
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
                    ' Net = misdatos.Tables(0).Rows(0).Item(0)
                    Iv = misdatos.Tables(0).Rows(0).Item(1)
                    ' Tot = misdatos.Tables(0).Rows(0).Item(2)
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
            'IvT = misdatos.Tables(0).Rows(0).Item(1)
            ToTT = FormatNumber(misdatos.Tables(0).Rows(0).Item(2), 2)
            TotTic = FormatNumber(misdatos.Tables(0).Rows(0).Item(2), 2)
            y = y + 15
            e.Graphics.DrawString("TOTAL: " + Str(ToTT), prFontT, Brushes.Black, New Rectangle(xPos, y, Width1, 15))



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

        '  misdatos = MiClase.traedataset("select count(linea) from t_detalfac where idpc=" & Pc & "")
        '  CantProd = Trim(misdatos.Tables(0).Rows(0).Item(0))
        y = y + 15
        e.Graphics.DrawString("Cantidad de Productos :" + Str(CantProd), prFont, Brushes.Black, New Rectangle(0, y + 20, width, 15))
        y = y + 25
        e.Graphics.DrawString("Factura Electrónica", prFontE, Brushes.Black, New Rectangle(45, y + 15, width, 15))
        y = y + 40
        'Cargo Imagen
        Dim newImage As Image = Image.FromFile("qr.png")
        ' Create coordinates for upper-left corner of image.
        Dim x1 As Single = 40.0F
        Dim y1 As Single = 60.0F
        ' Create rectangle for source image.
        Dim srcRect As New RectangleF(20.0F, 20.0F, 150.0F, 150.0F)
        Dim units As GraphicsUnit = GraphicsUnit.Pixel
        ' Draw image to screen.
        e.Graphics.DrawImage(newImage, x1, y, srcRect, units)
        '***************************++++
        CantProd = 0
        e.HasMorePages = False
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
        Dim fl As Integer = DtgDetRem.Rows.Count
        Dim contador As Integer = 0
        For i As Integer = 0 To fl - 1
            Idcl = Convert.ToString(DtgDetRem(13, i).Value)
            If Idcl = 0 Then
                Idcl = 1
            End If
        Next
        ' If IsDBNull(Convert.ToString(DtgRem1(0, i).Value)) Then
        ' Else
        'Lnum = Trim(Convert.ToString(DtgRem1(0, i).Value))

        misdatos = MiClase.traedataset("select clientes.id,cliente,direccion,ciudad,cuit,c_iva,idciu,idciva,email,telefono,cel,cpostal,idpr,provincia,email from clientes inner join ciudad on clientes.idciu=ciudad.id inner join c_de_iva on clientes.idciva = c_de_iva.id inner join provincias on clientes.idpr=provincias.id where clientes.id = " & Idcl & " ")
        CliTick = Trim(misdatos.Tables(0).Rows(0).Item(1))
        DirTick = Trim(misdatos.Tables(0).Rows(0).Item(2))
        CiuTick = Trim(misdatos.Tables(0).Rows(0).Item(3))
        CuitTick = Trim(misdatos.Tables(0).Rows(0).Item(4))
        IdCiva = Trim(misdatos.Tables(0).Rows(0).Item(7))

        If CuitTick = "0" Then
            Idcl = 1
            misdatos = MiClase.traedataset("select clientes.id,cliente,direccion,ciudad,cuit,c_iva,idciu,idciva,email,telefono,cel,cpostal,idpr,provincia,email from clientes inner join ciudad on clientes.idciu=ciudad.id inner join c_de_iva on clientes.idciva = c_de_iva.id inner join provincias on clientes.idpr=provincias.id where clientes.id = " & Idcl & " ")
            CliTick = Trim(misdatos.Tables(0).Rows(0).Item(1))
            DirTick = Trim(misdatos.Tables(0).Rows(0).Item(2))
            CiuTick = Trim(misdatos.Tables(0).Rows(0).Item(3))
            CuitTick = Trim(misdatos.Tables(0).Rows(0).Item(4))
            IdCiva = Trim(misdatos.Tables(0).Rows(0).Item(7))
        End If
        misdatos = MiClase.traedataset("select id,c_iva from C_De_Iva where id = " & IdCiva & " ")
        CivaTick = Trim(misdatos.Tables(0).Rows(0).Item(0))

        EsCom = 1
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
            Dcuit = Mid(CuitTick, 8, 3)
            Mcuit = Mid(CuitTick, 4, 3)
            Icuit = Mid(CuitTick, 1, 2)
            Cuit = Icuit + Mcuit + Dcuit
            'tipo_doc = 80 : nro_doc = "33693450239"
            tipo_doc = 96 : nro_doc = Cuit

        Else
            Dcuit = Mid(CuitTick, 13, 1)
            Mcuit = Mid(CuitTick, 4, 8)
            Icuit = Mid(CuitTick, 1, 2)
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
            '''' misdatos = MiClase.traedataset("select isnull(sum(ptotal),0) from t_detalfac where idiv=" & i & "and idpc=" & Pc & "")
            misdatos = MiClase.traedataset("select isnull(sum(ptotal),0) from detal_fac where idalic=" & i & " and idtp=" & 4 & "and id=" & NumFac & "")
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

        Dim Req As String
        Dim Response As String
        ' Imprimo pedido y respuesta XML para depuración (errores de formato)
        Console.WriteLine(WSFEv1.XmlRequest)
        Console.WriteLine(WSFEv1.XmlResponse)
        Req = WSFEv1.xmlrequest
        Response = WSFEv1.XmlResponse
        Dlin = Len(Req)
        MiClase.eliminaactualizaregistra("insert into respuesta values(" & cbte_nro & "," & tipo_cbte & ",'" & Req & "','" & Response & "')")
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
            Dim printCta As New PrintDocument
            Dim printDoc As New PrintDocument
            Mensaje = MsgBox("Desea Imprimir la Factura", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir Factura!!!")
            If Mensaje = MsgBoxResult.Yes Then
                misdatos = MiClase.traedataset("select impresora from configuracion where pc=" & Pc & "")
                Impresora = Trim(misdatos.Tables(0).Rows(0).Item(0))
                printCta.PrinterSettings.PrinterName = Impresora
                AddHandler printDoc.PrintPage, AddressOf print_PrintCliFC
                printDoc.Print()
            End If
            Crear_Pdf()
            Guar_fac()
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


    Private Sub Act()
        '    DtgRem1.AllowUserToAddRows = False
        '    Dim filas As Integer = DtgRem1.Rows.Count
        '    Dim contador As Integer = 0
        '    For i As Integer = 0 To filas - 1
        ' If IsDBNull(Convert.ToString(DtgRem1(0, i).Value)) Then
        ' Else
        'Lnum = Trim(Convert.ToString(DtgRem1(0, i).Value))
        ' End If
        ' If IsDBNull(Convert.ToString(DtgRem1(1, i).Value)) Then
        ' Else
        ' Fecha = Format(Convert.ToDateTime(DtgRem1(1, i).Value), "dd/MM/yy")
        ' End If
        ' If IsDBNull(Convert.ToString(DtgRem1(2, i).Value)) Then
        ' Else
        ' Importe = Convert.ToDecimal(DtgRem1(2, i).Value)
        ' End If
        ' If IsDBNull(Convert.ToString(DtgRem1(3, i).Value)) Then
        ' Else
        ' NumFac = Convert.ToString(DtgRem1(3, i).Value)
        ' End If
        ' EsOr = 0
        '  Fc = Date.Today
        ' Fc = Format(Date.Today, "dd/MM/yy")

        'Next


        MiClase.cargardatagriview(DtgRem, "select lnum,fecha,importe,numero,estado from tremcta where estado=" & 0 & "")
        DtgRem.AllowUserToAddRows = False
        DtgRem.Font = New Font("Arial ", 12, FontStyle.Regular)
        DtgRem.Columns(0).HeaderText = "Numero"
        DtgRem.Columns(0).Width = 150
        DtgRem.Columns(2).HeaderText = "Precio"
        DtgRem.Columns(2).DefaultCellStyle.Format = "##,##0.00"
        DtgRem.Columns(3).Visible = False
        DtgRem.Columns(4).Visible = False
        DtgRem.Columns.Add(chk)
        chk.HeaderText = "Estado"
        chk.Name = "Estado"

    End Sub
    

    


    Private Sub FrmBusRem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MiClase.eliminaactualizaregistra("delete from totalic where pc=" & Pc & "")
        Idcl = 0
        EsCl = 0
        Ds = (DateAdd("d", -90, DtcDesde.Value))
        FDes = Format(Ds, "dd/MM/yy")
        FHas = DtcHasta.Value
        FHas = Format(DtcHasta.Value, "dd/MM/yy")
        MiClase.cargardatagriview(DtgRem, "select facturas.fnum,fecha,cliente,cuit,total,idus,blng,esventa,tipo,entrega,numero,idtp,abrev,idtp,neto,iva,total,idcl from facturas inner join tip_fac on facturas.idtp=tip_fac.id where idtp=" & 4 & " and facturas.fecha between '" & FDes & "' and '" & FHas & "'order by numero desc")
        DtgRem.AllowUserToAddRows = False
        DtgRem.Font = New Font("Arial ", 12, FontStyle.Regular)
        DtgRem.Columns(1).DefaultCellStyle.Format = "dd/MM/yy"
        DtgRem.Columns(4).DefaultCellStyle.Format = "##,##0.00"
        DtgRem.Columns(0).HeaderText = "Numero"
        DtgRem.Columns(1).HeaderText = "Fecha"
        DtgRem.Columns(2).HeaderText = "Cliente"
        DtgRem.Columns(3).HeaderText = "Cuit"
        DtgRem.Columns(4).HeaderText = "Total"
        DtgRem.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        DtgRem.Columns(0).Width = 150
        DtgRem.Columns(1).Width = 80
        DtgRem.Columns(2).Width = 200
        DtgRem.Columns(5).Visible = False
        DtgRem.Columns(6).Visible = False
        DtgRem.Columns(7).Visible = False
        DtgRem.Columns(8).Visible = False
        DtgRem.Columns(9).Visible = False
        DtgRem.Columns(10).Visible = False
        DtgRem.Columns(11).Visible = False
        DtgRem.Columns(12).Visible = False
        DtgRem.Columns(13).Visible = False
        DtgRem.Columns(14).Visible = False
        DtgRem.Columns(15).Visible = False
        DtgRem.Columns(16).Visible = False
        DtgRem.Columns(17).Visible = False
        misdatos = MiClase.traedataset("select fecha from ticket")
        Fc = misdatos.Tables(0).Rows(0).Item(0)
        Dif = DateDiff(DateInterval.Hour, Fc, FcAc)
        '  If Dif > 10 Then
        ' Cer()
        ' End If
    End Sub

    Private Sub Cmdfacturar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmdfacturar.Click
        Cmdfacturar.Enabled = False
        Fac_Elec()

        Cmdfacturar.Enabled = True
    End Sub

    Private Sub DtgRem_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DtgRem.CellClick


    End Sub

    Private Sub DtgRem_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DtgRem.CellContentClick
        'Dim DicL As Integer
        NumFac = DtgRem.Rows(e.RowIndex).Cells(10).Value()
        'Idcl = DtgRem.Rows(e.RowIndex).Cells(17).Value()
        MiClase.cargardatagriview(DtgDetRem, "select barra,articulo,punit,cantidad,ptotal,id,idtp,linea,idfm,idmr,idpr,alic,idalic,idcl from detal_fac where idtp=" & 4 & "and id=" & NumFac & "order by linea desc")
        DtgDetRem.AllowUserToAddRows = False
        DtgDetRem.Font = New Font("Arial ", 10, FontStyle.Regular)
        DtgDetRem.Columns(1).Width = 250
        DtgDetRem.Columns(2).DefaultCellStyle.Format = "##,##0.00"
        DtgDetRem.Columns(3).DefaultCellStyle.Format = "##,##0.00"
        DtgDetRem.Columns(4).DefaultCellStyle.Format = "##,##0.00"
        DtgDetRem.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        DtgDetRem.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        DtgDetRem.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        DtgDetRem.Columns(5).Visible = False
        DtgDetRem.Columns(6).Visible = False
        DtgDetRem.Columns(7).Visible = False
        DtgDetRem.Columns(8).Visible = False
        DtgDetRem.Columns(9).Visible = False
        DtgDetRem.Columns(10).Visible = False
        DtgDetRem.Columns(11).Visible = False
        DtgDetRem.Columns(12).Visible = False
        DtgDetRem.Columns(13).Visible = False
        misdatos = MiClase.traedataset("select sum(ptotal) from detal_fac where idtp=" & 4 & "and id=" & NumFac & "")
        TxtTotal.Text = FormatNumber(misdatos.Tables(0).Rows(0).Item(0), 2)
    End Sub


    Private Sub UsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuarioToolStripMenuItem.Click
        EsCl = 0
        TxtCliente.Clear()
        TxtCliente.Enabled = False
        BtnCiva.Enabled = False
        CmbUsuario.Enabled = True
        MiClase.cargar_Combo(CmbUsuario, "select cajero,id from cajeros")

    End Sub

    Private Sub CmbUsuario_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbUsuario.SelectedIndexChanged
        Ds = (DateAdd("d", -90, DtcDesde.Value))
        FDes = Format(Ds, "dd/MM/yy")
        FHas = DtcHasta.Value
        FHas = Format(DtcHasta.Value, "dd/MM/yy")
        IdUs = CInt(CmbUsuario.SelectedValue(1))
        DtgDetRem.DataSource = Nothing
        MiClase.cargardatagriview(DtgRem, "select facturas.fnum,fecha,cliente,cuit,total,idus,blng,esventa,tipo,entrega,numero,idtp,abrev,idtp,neto,iva,total from facturas inner join tip_fac on facturas.idtp=tip_fac.id where idtp=" & 4 & " and facturas.fecha between '" & FDes & "' and '" & FHas & "'and idus=" & IdUs & "order by numero desc")
        TxtTotal.Clear()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        EsCl = 0
        TxtCliente.Clear()
        TxtCliente.Enabled = False
        BtnCiva.Enabled = False
        CmbUsuario.Enabled = False
        DtgDetRem.DataSource = Nothing
        Ds = (DateAdd("d", -90, DtcDesde.Value))
        FDes = Format(Ds, "dd/MM/yy")
        FHas = DtcHasta.Value
        FHas = Format(DtcHasta.Value, "dd/MM/yy")
        MiClase.cargardatagriview(DtgRem, "select facturas.fnum,fecha,cliente,cuit,total,idus,blng,esventa,tipo,entrega,numero,idtp,abrev,idtp,neto,iva,total from facturas inner join tip_fac on facturas.idtp=tip_fac.id where idtp=" & 4 & " and facturas.fecha between '" & FDes & "' and '" & FHas & "'order by numero desc")

    End Sub

    Private Sub ConddeVentaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConddeVentaToolStripMenuItem.Click
        EsCl = 0
        TxtCliente.Clear()
        TxtCliente.Enabled = False
        CmbUsuario.Enabled = False
        BtnCiva.Enabled = True
    End Sub



    Private Sub ContadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContadoToolStripMenuItem.Click
        DtgDetRem.DataSource = Nothing
        Ds = (DateAdd("d", -90, DtcDesde.Value))
        FDes = Format(Ds, "dd/MM/yy")
        FHas = DtcHasta.Value
        FHas = Format(DtcHasta.Value, "dd/MM/yy")
        MiClase.cargardatagriview(DtgRem, "select facturas.fnum,fecha,cliente,cuit,total,idus,blng,esventa,tipo,entrega,numero,idtp,abrev,idtp,neto,iva,total from facturas inner join tip_fac on facturas.idtp=tip_fac.id where idtp=" & 4 & " and facturas.fecha between '" & FDes & "' and '" & FHas & "'and esventa=" & 0 & " order by numero desc")
    End Sub

    Private Sub CtaCteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CtaCteToolStripMenuItem.Click
        DtgDetRem.DataSource = Nothing
        Ds = (DateAdd("d", -90, DtcDesde.Value))
        FDes = Format(Ds, "dd/MM/yy")
        FHas = DtcHasta.Value
        FHas = Format(DtcHasta.Value, "dd/MM/yy")
        MiClase.cargardatagriview(DtgRem, "select facturas.fnum,fecha,cliente,cuit,total,idus,blng,esventa,tipo,entrega,numero,idtp,abrev,idtp,neto,iva,total from facturas inner join tip_fac on facturas.idtp=tip_fac.id where idtp=" & 4 & " and facturas.fecha between '" & FDes & "' and '" & FHas & "'and esventa=" & 1 & " order by numero desc")
    End Sub

    Private Sub TxtCliente_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCliente.GotFocus
        If EsCl = 1 Then
            DtgDetRem.DataSource = Nothing
            Ds = (DateAdd("d", -90, DtcDesde.Value))
            FDes = Format(Ds, "dd/MM/yy")
            FHas = DtcHasta.Value
            FHas = Format(DtcHasta.Value, "dd/MM/yy")
            MiClase.cargardatagriview(DtgRem, "select facturas.fnum,fecha,cliente,cuit,total,idus,blng,esventa,tipo,entrega,numero,idtp,abrev,idtp,neto,iva,total from facturas inner join tip_fac on facturas.idtp=tip_fac.id where idtp=" & 4 & " and facturas.fecha between '" & FDes & "' and '" & FHas & "'and idcl=" & Idcl & " order by numero desc")
            EsCl = 0
        End If
    End Sub


    Private Sub TxtCliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCliente.KeyDown
        If e.KeyCode = Keys.Return Then
            If IsNumeric(TxtCliente.Text) Then
                misdatos = MiClase.traedataset("select id,cliente,direccion from clientes where id=" & TxtCliente.Text & "")
                Dim totclF As Integer = misdatos.Tables(0).Rows.Count
                If totclF = 0 Then
                    Mensaje = MsgBox("Este Cliente No Existe", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Cliente Inexistente!!!")
                    If Mensaje = MsgBoxResult.Ok Then
                        TxtCliente.Focus()
                    End If
                Else
                    misdatos = MiClase.traedataset("select clientes.id,cliente,direccion,ciudad,cuit,c_iva,idciu,idciva,email,telefono,cel,cpostal,idpr,provincia,email from clientes inner join ciudad on clientes.idciu=ciudad.id inner join c_de_iva on clientes.idciva = c_de_iva.id inner join provincias on clientes.idpr=provincias.id where clientes.id = " & TxtCliente.Text & " ")
                    Idcl = misdatos.Tables(0).Rows(0).Item(0)
                    DtgDetRem.DataSource = Nothing
                    Ds = (DateAdd("d", -90, DtcDesde.Value))
                    FDes = Format(Ds, "dd/MM/yy")
                    FHas = DtcHasta.Value
                    FHas = Format(DtcHasta.Value, "dd/MM/yy")
                    MiClase.cargardatagriview(DtgRem, "select facturas.fnum,fecha,cliente,cuit,total,idus,blng,esventa,tipo,entrega,numero,idtp,abrev,idtp,neto,iva,total,idcl from facturas inner join tip_fac on facturas.idtp=tip_fac.id where idtp=" & 4 & " and facturas.fecha between '" & FDes & "' and '" & FHas & "'and idcl=" & Idcl & " order by numero desc")
                End If
            Else
                EsCl = "8"
                BCli = TxtCliente.Text
                FrmBcl.Show()
            End If
        End If


    End Sub

    Private Sub TxtCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCliente.Click

    End Sub

    Private Sub ClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClienteToolStripMenuItem.Click
        EsCl = 0
        TxtCliente.Clear()
        BtnCiva.Enabled = False
        TxtCliente.Enabled = True

    End Sub

    Private Sub DtgRem_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DtgRem.CellDoubleClick
        Mensaje = MsgBox("Desea Imprimir el Ticket", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir El Ticket")
        If Mensaje = MsgBoxResult.Yes Then
            'Traigo la Impresora
            misdatos = MiClase.traedataset("select impresora from configuracion where pc=" & Pc & "")
            Impresora = Trim(misdatos.Tables(0).Rows(0).Item(0))
            '********************
            'Traigo los datos de la factura
            NumFac = DtgRem.Rows(e.RowIndex).Cells(10).Value()
            misdatos = MiClase.traedataset("select facturas.fnum,fecha,cliente,cuit,total,idus,blng,esventa,tipo,entrega,numero,idtp,abrev,idtp,neto,iva,total,idcl from facturas inner join tip_fac on facturas.idtp=tip_fac.id where idtp=" & 4 & " and facturas.numero = " & NumFac & "")
            Clave = Trim(misdatos.Tables(0).Rows(0).Item(0))
            FcD = misdatos.Tables(0).Rows(0).Item(1)
            CliTick = Trim(misdatos.Tables(0).Rows(0).Item(2))
            CuitTick = Trim(misdatos.Tables(0).Rows(0).Item(3))



            Dim printDoc As New PrintDocument
            printDoc.PrinterSettings.PrinterName = Impresora
            Dim printCta As New PrintDocument
            printCta.PrinterSettings.PrinterName = Impresora
            If CliTick = "" Then
                AddHandler printDoc.PrintPage, AddressOf print_PrintPage
                printDoc.Print()
            Else
                AddHandler printDoc.PrintPage, AddressOf print_PrintCli
                printDoc.Print()
            End If
        End If
        MiClase.cargardatagriview(DtgRem, "select facturas.fnum,fecha,cliente,cuit,total,idus,blng,esventa,tipo,entrega,numero,idtp,abrev,idtp,neto,iva,total from facturas inner join tip_fac on facturas.idtp=tip_fac.id where idtp=" & 4 & " and facturas.fecha between '" & FDes & "' and '" & FHas & "'and idus=" & IdUs & "order by numero desc")
        DtgDetRem.DataSource = Nothing
        TxtTotal.Clear()
    End Sub

End Class
