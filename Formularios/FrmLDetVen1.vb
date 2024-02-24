Public Class FrmLDetVen1

    Private Sub CmdPantalla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdPantalla.Click
        ' Mes = 1
        ' Desde = DateSerial(startDate.Year, Mes, "01")
        ' Hasta = DateSerial(startDate.Year, Mes + 1, 0)
        Desde = DtcFecha.Value()
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
        MiClase.cargardatagriview(DtgDetVen, "select facturas.numero,idtp,cliente,esventa,cventa,total,idus,cajero,tipo from facturas inner join tip_fac on facturas.idtp=tip_fac.id inner join cajeros on facturas.idus=cajeros.id where fecha='" & DtcFecha.Text & "'")
        'traigo los datos de las facturas
        'Dim MnVen As New DtcIvaVentas
        Dim Fila2 As DtcIvaVentas.IvaVentasRow
        Fila2 = Mn.IvaVentas.NewIvaVentasRow
        DtgDetVen.AllowUserToAddRows = False
        For i As Integer = 0 To DtgDetVen.RowCount - 1
            Fila2 = Mn.IvaVentas.NewIvaVentasRow
            Fila2.Numero = DtgDetVen(0, i).Value
            Fila2.Cliente = DtgDetVen(2, i).Value
            Fila2.EsVenta = DtgDetVen(3, i).Value
            Fila2.Cventa = DtgDetVen(4, i).Value
            Fila2.Total = FormatNumber(DtgDetVen(5, i).Value, 2)
            Fila2.IdCaj = DtgDetVen(6, i).Value
            Fila2.Cajero = DtgDetVen(7, i).Value
            Fila2.Comprobante = DtgDetVen(8, i).Value
            Mn.IvaVentas.AddIvaVentasRow(Fila2)
        Next
        Dim rpt As New CryDetVen
        rpt.SetDataSource(Mn)
        Reportes.CrystalReportViewer1.ReportSource = rpt
        Reportes.Show()
    End Sub
End Class