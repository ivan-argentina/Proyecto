Public Class FrmLdetVen

    Private Sub CmdPantalla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdPantalla.Click
        'Try
        IdUs = CInt(CmbCajero.SelectedValue(1))
        Desde = DtcFecha.Value
        Desde = Format(DtcFecha.Value, "dd/MM/yy")
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
        MiClase.cargardatagriview(DtgDetVen, "select facturas.idtp,fecha,esventa,total,blng,tipo,fnum,entrega,numero,idtp,abrev,cliente,cuit,neto,iva,total,cventa,idus,cajero from facturas inner join tip_fac on facturas.idtp=tip_fac.id inner join cajeros on facturas.idus=cajeros.id where facturas.fecha = '" & Desde & "'and idus=" & IdUs & "")
        'traigo los datos de las facturas
        'Dim MnVen As New DtcIvaVentas
        Dim Fila2 As DtcIvaVentas.IvaVentasRow
        Fila2 = Mn.IvaVentas.NewIvaVentasRow
        DtgDetVen.AllowUserToAddRows = False
        For i As Integer = 0 To DtgDetVen.RowCount - 1
            Fila2 = Mn.IvaVentas.NewIvaVentasRow
            Fila2.Fecha = DtgDetVen(1, i).Value
            Fila2.EsVenta = DtgDetVen(2, i).Value
            Fila2.Numero = DtgDetVen(6, i).Value
            Fila2.Comprobante = DtgDetVen(10, i).Value
            Fila2.Cliente = DtgDetVen(11, i).Value
            Fila2.Cuit = DtgDetVen(12, i).Value
            Fila2.Total = FormatNumber(DtgDetVen(3, i).Value, 2)
            Fila2.Cventa = Trim(DtgDetVen(16, i).Value)
            Fila2.IdCaj = Trim(DtgDetVen(17, i).Value)
            Fila2.Cajero = Trim(DtgDetVen(18, i).Value)
            Mn.IvaVentas.AddIvaVentasRow(Fila2)
        Next

        Dim rpt As New CryVentas
        rpt.SetDataSource(Mn)
        Reportes.CrystalReportViewer1.ReportSource = rpt
        Reportes.Show()
        '  Catch ex As Exception
        ' Mensaje = MsgBox("Error de Informacion", MsgBoxStyle.OkOnly, "Error!!!")
        ' End Try
    End Sub

    Private Sub FrmLdetVen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MiClase.cargar_Combo(CmbCajero, "select cajero,id from cajeros")
    End Sub

    Private Sub CmbCajero_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbCajero.SelectedIndexChanged

    End Sub
End Class