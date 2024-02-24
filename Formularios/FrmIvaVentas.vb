Imports System.IO

Public Class FrmIvaVentas
    Dim fila2 As DtcIvaVentas.IvaVentasRow
    Dim fila As DtcIvaVentas.EncabezadoRow
    Dim Ventas As DtcIvaVentas
    Dim Fil2 As DtcAlicIva.AlicIvaRow
    Dim ms As String

    Private Sub CmPantalla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Mes = Mid(MskDesde.Text, 1, 2)
        ' Desde = DateSerial(startDate.Year, Mes, "01")
        ' Hasta = DateSerial(startDate.Year, Mes + 1, 0)
        Desde = DtcDesde.Value
        Hasta = DtcHasta.Value
        Dim Mn As New DtcIvaVentas
        Dim Fila As DtcIvaVentas.EncabezadoRow
        Fila = Mn.Encabezado.NewEncabezadoRow
        'traigo los datos del encabezado
        misdatos = MiClase.traedataset("select linea1,linea2,linea3 from encabezado")
        Linea1 = misdatos.Tables(0).Rows(0).Item(0)
        Linea2 = misdatos.Tables(0).Rows(0).Item(1)
        Linea3 = misdatos.Tables(0).Rows(0).Item(2)
        Fila.Linea1 = Linea1
        Fila.Linea2 = Linea2
        Fila.Linea3 = Linea3
        Mn.Encabezado.AddEncabezadoRow(Fila)
        'cargo los datos al datagridview
        'Cargo la datagridvies para el reporte
        MiClase.cargardatagriview(DtgIva, "select facturas.idtp,fecha,esventa,total,blng,tipo,fnum,entrega,numero,idtp,abrev,cliente,cuit,neto,iva,total from facturas inner join tip_fac on facturas.idtp=tip_fac.id where blng=" & 0 & " and facturas.fecha between '" & Desde & "' and '" & Hasta & "' ")
        'traigo los datos de las facturas
        'Dim MnVen As New DtcIvaVentas
        Dim Fila2 As DtcIvaVentas.IvaVentasRow
        Fila2 = Mn.IvaVentas.NewIvaVentasRow
        DtgIva.AllowUserToAddRows = False
        For i As Integer = 0 To DtgIva.RowCount - 1
            Fila2 = Mn.IvaVentas.NewIvaVentasRow
            Fila2.Fecha = DtgIva(1, i).Value
            Fila2.Numero = DtgIva(6, i).Value
            Fila2.Comprobante = DtgIva(10, i).Value
            Fila2.Cliente = DtgIva(11, i).Value
            Fila2.Cuit = DtgIva(12, i).Value
            Fila2.Neto = FormatNumber(DtgIva(13, i).Value, 2)
            Fila2.Iva = FormatNumber(DtgIva(14, i).Value, 2)
            Fila2.Total = FormatNumber(DtgIva(3, i).Value, 2)
            Mn.IvaVentas.AddIvaVentasRow(Fila2)
        Next
        misdatos = MiClase.traedataset("select  isnull(sum(neto),0),isnull(sum(iva),0),isnull(sum(total),0) from facturas where blng=" & 0 & " and facturas.fecha between '" & Desde & "' and '" & Hasta & "'")
        Fila2.Sum_Neto = FormatNumber(misdatos.Tables(0).Rows(0).Item(0), 2)
        Fila2.Sum_iva = FormatNumber(misdatos.Tables(0).Rows(0).Item(1), 2)
        Fila2.Sum_Total = FormatNumber(misdatos.Tables(0).Rows(0).Item(2), 2)
        Dim rpt As New CryIvaVentas
        rpt.SetDataSource(Mn)
        Reportes.CrystalReportViewer1.ReportSource = rpt
        Reportes.Show()
    End Sub

    Private Sub FrmIvaVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim Fech As Date
        'Fech = Date.Today
        'MskDesde.Text = Mid(Fech, 3, 9)
        'MskFecha.Text = Mid(Fech, 3, 9)
        Desde = DateSerial(startDate.Year, startDate.Month, "01")
        Hasta = DateSerial(startDate.Year, startDate.Month + 1, 0)
        DtcDesde.Value = Desde
        DtcHasta.Value = Hasta
    End Sub

    Private Sub CmPantalla_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmPantalla.Click
        Try
            ' Mes = 7
            ' Desde = DateSerial(startDate.Year, Mes, "01")
            'Hasta = DateSerial(startDate.Year, Mes + 1, 0)
            Desde = CDate(DtcDesde.Value)
            Hasta = CDate(DtcHasta.Value)
            Dim Mn As New DtcIvaVentas
            Dim Fila As DtcIvaVentas.EncabezadoRow
            Fila = Mn.Encabezado.NewEncabezadoRow
            'traigo los datos del encabezado
            misdatos = MiClase.traedataset("select linea1,linea2,linea3 from encabezado")
            Linea1 = misdatos.Tables(0).Rows(0).Item(0)
            Linea2 = misdatos.Tables(0).Rows(0).Item(1)
            Linea3 = misdatos.Tables(0).Rows(0).Item(2)
            Fila.Linea1 = Linea1
            Fila.Linea2 = Linea2
            Fila.Linea3 = Linea3
            Mn.Encabezado.AddEncabezadoRow(Fila)
            'cargo los datos al datagridview
            'Cargo la datagridvies para el reporte
            MiClase.cargardatagriview(DtgIva, "select facturas.idtp,fecha,esventa,total,blng,tipo,fnum,entrega,numero,idtp,abrev,cliente,cuit,neto,iva,total from facturas inner join tip_fac on facturas.idtp=tip_fac.id where blng=" & 0 & " and facturas.fecha between '" & Desde & "' and '" & Hasta & "'")
            'traigo los datos de las facturas
            'Dim MnVen As New DtcIvaVentas
            Dim Fila2 As DtcIvaVentas.IvaVentasRow
            Fila2 = Mn.IvaVentas.NewIvaVentasRow
            DtgIva.AllowUserToAddRows = False
            For i As Integer = 0 To DtgIva.RowCount - 1
                Fila2 = Mn.IvaVentas.NewIvaVentasRow
                Fila2.Fecha = DtgIva(1, i).Value
                Fila2.Numero = DtgIva(6, i).Value
                Fila2.Comprobante = DtgIva(10, i).Value
                Fila2.Cliente = DtgIva(11, i).Value
                Fila2.Cuit = DtgIva(12, i).Value
                Fila2.Neto = FormatNumber(DtgIva(13, i).Value, 2)
                Fila2.Iva = FormatNumber(DtgIva(14, i).Value, 2)
                Fila2.Total = FormatNumber(DtgIva(3, i).Value, 2)
                Mn.IvaVentas.AddIvaVentasRow(Fila2)
            Next
            misdatos = MiClase.traedataset("select  isnull(sum(neto),0),isnull(sum(iva),0),isnull(sum(total),0) from facturas where blng=" & 0 & " and facturas.fecha between '" & Desde & "' and '" & Hasta & "'")
            Fila2.Sum_Neto = FormatNumber(misdatos.Tables(0).Rows(0).Item(0), 2)
            Fila2.Sum_iva = FormatNumber(misdatos.Tables(0).Rows(0).Item(1), 2)
            Fila2.Sum_Total = FormatNumber(misdatos.Tables(0).Rows(0).Item(2), 2)
            Dim rpt As New CryIvaVentas
            rpt.SetDataSource(Mn)
            Reportes.CrystalReportViewer1.ReportSource = rpt
            Reportes.Show()
        Catch ex As Exception
            Mensaje = MsgBox("Error de Informacion", MsgBoxStyle.OkOnly, "Error!!!")
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Mes = Mid(MskDesde.Text, 1, 2)
        Desde = DateSerial(startDate.Year, Mes, "01")
        Hasta = DateSerial(startDate.Year, Mes + 1, 0)
        'MiClase.cargardatagriview(DtgIva, "select facturas.fecha,tipo,esventa,total,blng,tipo,fnum,entrega,numero,idtp,abrev,cliente,cuit,neto,iva,total from facturas inner join tip_fac on facturas.idtp=tip_fac.id where blng=" & 0 & " and facturas.fecha between '" & Desde & "' and '" & Hasta & "' ")
        MiClase.cargardatagriview(DtgIva, "select facturas.fecha,tipo,idpv,numero,cuit,cliente,total,idtp,blng,fnum,entrega,numero,abrev,cliente,cuit,neto,iva,total from facturas inner join tip_fac on facturas.idtp=tip_fac.id where blng=" & 0 & " and facturas.fecha between '" & Desde & "' and '" & Hasta & "' ")
        Dim ruta As String = System.Environment.CurrentDirectory.ToString
        If File.Exists("C:\Ventas.xlsx") Then
            excel(DtgIva)
        Else
            Dim rutas As String = ruta & "\Ventas.xlsx"
            Dim rutas2s As String = "C:\Ventas.xlsx"

            Try
                File.Copy(rutas, rutas2s, True)
                MsgBox("Se creo un archivo de excel HERBALIFE.XLSX en la unidad C:\" & vbNewLine & "Se ha definido formatos para poder mostrar los datos, no eliminar el archivo", MsgBoxStyle.Information, "Aviso")
                excel(DtgIva)
            Catch ex As Exception
                'MsgBox("No se realizo la copia", MsgBoxStyle.Critical, "Aviso")
            End Try
        End If
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Acumulo los totales por alicuota
        Dim filas As Integer = 6
        For i As Integer = 4 To filas - 1
            misdatos = MiClase.traedataset("select isnull(sum(ptotal),0) from detal_fac where idalic=" & i & "")
            Total = misdatos.Tables(0).Rows(0).Item(0)
        Next
    End Sub

    Private Sub CmdVenAlic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdVenAlic.Click
        Dim Mn As New DtcAlicIva
        Dim Fil As DtcAlicIva.EncabezadoRow
        Fil = Mn.Encabezado.NewEncabezadoRow
        'traigo los datos del encabezado
        misdatos = MiClase.traedataset("select linea1,linea2,linea3 from encabezado")
        Linea1 = misdatos.Tables(0).Rows(0).Item(0)
        Linea2 = misdatos.Tables(0).Rows(0).Item(1)
        Linea3 = misdatos.Tables(0).Rows(0).Item(2)
        Fil.Linea1 = Linea1
        Fil.Linea2 = Linea2
        Fil.Linea3 = Linea3
        Desde = CDate(DtcDesde.Text)
        Dim Ds As Integer
        Dim da As String = Mid(Desde, 7, 4)

        Ds = Mid(Desde, 4, 2)
        If Ds = 1 Then
            ms = "Enero" + " de " + da
        ElseIf Ds = 2 Then
            ms = "Febrero" + " de " + da
        ElseIf Ds = 3 Then
            ms = "Marzo" + " de " + da
        ElseIf Ds = 4 Then
            ms = "Abril" + " de " + da
        ElseIf Ds = 5 Then
            ms = "Mayo" + " de " + da
        ElseIf Ds = 6 Then
            ms = "Junio" + " de " + da
        ElseIf Ds = 7 Then
            ms = "Julio" + " de " + da
        ElseIf Ds = 8 Then
            ms = "Agosto" + " de " + da
        ElseIf Ds = 9 Then
            ms = "Septiembre" + " de " + da
        ElseIf Ds = 10 Then
            ms = "Octubre" + " de " + da
        ElseIf Ds = 11 Then
            ms = "Noviembre" + " de " + da
        ElseIf Ds = 12 Then
            ms = "Diciembre" + " de " + da
        End If
        Fil.Fecha = ms
        Mn.Encabezado.AddEncabezadoRow(Fil)
        MiClase.cargardatagriview(DtgIva, "select id,alic,ord from alic_iva")
        Dim IdAlicV As Integer
        Dim AlicV As Decimal
        Dim AlicV1 As Decimal
        Dim PtotalV As Decimal
        Dim NetoI As Decimal
        Dim IvaI As Decimal
        Desde = CDate(DtcDesde.Text)
        Hasta = CDate(DtcHasta.Value)
        DtgIva.AllowUserToAddRows = False
        For i As Integer = 0 To DtgIva.RowCount - 1
            IdAlicV = DtgIva(0, i).Value
            AlicV = DtgIva(1, i).Value
            misdatos = MiClase.traedataset("select isnull(sum(ptotal),0) from detal_fac where  fecha between '" & CDate(Desde) & "'and '" & CDate(Hasta) & "' and blng=" & 0 & " and idalic = " & IdAlicV & "")
            PtotalV = misdatos.Tables(0).Rows(0).Item(0)
            AlicV1 = AlicV / 100 + 1
            If IdAlicV = 3 Then
                NetoI = PtotalV
                IvaI = 0
            Else
                NetoI = FormatNumber(PtotalV / AlicV1, 2)
                IvaI = FormatNumber(PtotalV - NetoI, 2)
            End If
            If PtotalV = 0 Then
            Else
                MiClase.eliminaactualizaregistra("insert into dalic_iva values(" & IdAlicV & "," & AlicV & " ," & NetoI & "," & IvaI & "," & PtotalV & ",'" & Desde & "')")
            End If
        Next
        MiClase.cargardatagriview(DtgDetIva, "select idalic,alic,neto,iva,total from dalic_iva")

        Dim Fil2 As DtcAlicIva.AlicIvaRow
        Fil2 = Mn.AlicIva.NewAlicIvaRow
        DtgDetIva.AllowUserToAddRows = False
        For u As Integer = 0 To DtgDetIva.RowCount - 1

            Fil2 = Mn.AlicIva.NewAlicIvaRow
            Fil2.Alic = DtgDetIva(1, u).Value
            Fil2.Neto = DtgDetIva(2, u).Value
            Fil2.Iva = DtgDetIva(3, u).Value
            Fil2.Total = DtgDetIva(4, u).Value
            Mn.AlicIva.AddAlicIvaRow(Fil2)
        Next
        Dim rpt As New CryAlicVen
        rpt.SetDataSource(Mn)
        Reportes.CrystalReportViewer1.ReportSource = rpt
        Reportes.Show()
        MiClase.eliminaactualizaregistra("delete FROM DAlic_Iva")
    End Sub


    Private Sub CmdAlicIva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAlicIva.Click
        Dim Mn As New DtcAlicIva
        Dim Fil As DtcAlicIva.EncabezadoRow
        Fil = Mn.Encabezado.NewEncabezadoRow
        'traigo los datos del encabezado
        misdatos = MiClase.traedataset("select linea1,linea2,linea3 from encabezado")
        Linea1 = misdatos.Tables(0).Rows(0).Item(0)
        Linea2 = misdatos.Tables(0).Rows(0).Item(1)
        Linea3 = misdatos.Tables(0).Rows(0).Item(2)
        Fil.Linea1 = Linea1
        Fil.Linea2 = Linea2
        Fil.Linea3 = Linea3
        Desde = CDate(DtcDesde.Text)
        Dim Ds As Integer
        Dim da As String = Mid(Desde, 7, 4)

        Ds = Mid(Desde, 4, 2)
        If Ds = 1 Then
            ms = "Enero" + " de " + da
        ElseIf Ds = 2 Then
            ms = "Febrero" + " de " + da
        ElseIf Ds = 3 Then
            ms = "Marzo" + " de " + da
        ElseIf Ds = 4 Then
            ms = "Abril" + " de " + da
        ElseIf Ds = 5 Then
            ms = "Mayo" + " de " + da
        ElseIf Ds = 6 Then
            ms = "Junio" + " de " + da
        ElseIf Ds = 7 Then
            ms = "Julio" + " de " + da
        ElseIf Ds = 8 Then
            ms = "Agosto" + " de " + da
        ElseIf Ds = 9 Then
            ms = "Septiembre" + " de " + da
        ElseIf Ds = 10 Then
            ms = "Octubre" + " de " + da
        ElseIf Ds = 11 Then
            ms = "Noviembre" + " de " + da
        ElseIf Ds = 12 Then
            ms = "Diciembre" + " de " + da
        End If
        Fil.Fecha = ms
        Mn.Encabezado.AddEncabezadoRow(Fil)
        MiClase.cargardatagriview(DtgIva, "select id,alic,ord from alic_iva")
        Dim IdAlicV As Integer
        Dim AlicV As Decimal
        Dim AlicV1 As Decimal
        Dim PtotalV As Decimal
        Dim NetoI As Decimal
        Dim IvaI As Decimal
        Desde = CDate(DtcDesde.Text)
        Hasta = CDate(DtcHasta.Value)
        DtgIva.AllowUserToAddRows = False
        For i As Integer = 0 To DtgIva.RowCount - 1
            IdAlicV = DtgIva(0, i).Value
            AlicV = DtgIva(1, i).Value
            misdatos = MiClase.traedataset("select isnull(sum(ptotal),0) from detal_fac where  fecha between '" & CDate(Desde) & "'and '" & CDate(Hasta) & "' and blng=" & 0 & " and idalic = " & IdAlicV & "")
            PtotalV = misdatos.Tables(0).Rows(0).Item(0)
            AlicV1 = AlicV / 100 + 1
            If IdAlicV = 3 Then
                NetoI = PtotalV
                IvaI = 0
            Else
                NetoI = FormatNumber(PtotalV / AlicV1, 2)
                IvaI = FormatNumber(PtotalV - NetoI, 2)
            End If
            If PtotalV = 0 Then
            Else
                MiClase.eliminaactualizaregistra("insert into dalic_iva values(" & IdAlicV & "," & AlicV & " ," & NetoI & "," & IvaI & "," & PtotalV & ",'" & Desde & "')")
            End If
        Next
        MiClase.cargardatagriview(DtgDetIva, "select idalic,alic,neto,iva,total from dalic_iva")

        Dim Fil2 As DtcAlicIva.AlicIvaRow
        Fil2 = Mn.AlicIva.NewAlicIvaRow
        DtgDetIva.AllowUserToAddRows = False
        For u As Integer = 0 To DtgDetIva.RowCount - 1

            Fil2 = Mn.AlicIva.NewAlicIvaRow
            Fil2.Alic = DtgDetIva(1, u).Value
            Fil2.Neto = DtgDetIva(2, u).Value
            Fil2.Iva = DtgDetIva(3, u).Value
            Fil2.Total = DtgDetIva(4, u).Value
            Mn.AlicIva.AddAlicIvaRow(Fil2)
        Next
        Dim rpt As New CryAlicVen
        rpt.SetDataSource(Mn)
        Reportes.CrystalReportViewer1.ReportSource = rpt
        Reportes.Show()
        MiClase.eliminaactualizaregistra("delete FROM DAlic_Iva")
    End Sub

    Private Sub CmdCiva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCiva.Click
        Exp = 1
        Desde = DtcDesde.Value
        Hasta = DtcHasta.Value
        MiClase.cargardatagriview(DtgIva, "select facturas.fecha,tipo,idpv,numero,cuit,cliente,direccion,total,idtp,blng,fnum,entrega,numero,abrev,cliente,cuit,neto,iva,total,cpostal,idpr,c_iva,idciva,alic from facturas inner join tip_fac on facturas.idtp=tip_fac.id where blng=" & 0 & " and facturas.fecha between '" & Desde & "' and '" & Hasta & "' ")


        If File.Exists(ruta & "\HWVenta.xls") Then
            Oexcel(DtgIva)
        Else
            Dim rutas As String = ruta & "\HWVentas.xls"
            Dim rutas2s As String = "C:\debug\HWVentas.xls"

            Try
                File.Copy(rutas, rutas2s, True)
                MsgBox("Se creo un archivo de excel HWVenta.XLS en la unidad C:\" & vbNewLine & "Se ha definido formatos para poder mostrar los datos, no eliminar el archivo", MsgBoxStyle.Information, "Aviso")
                Oexcel(DtgIva)
            Catch ex As Exception
                'MsgBox("No se realizo la copia", MsgBoxStyle.Critical, "Aviso")
            End Try
        End If

    End Sub
End Class