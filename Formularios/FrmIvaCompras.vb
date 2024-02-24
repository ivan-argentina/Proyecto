Imports System.IO
Public Class FrmIvaCompras
    Private Sub BtnPantalla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPantalla.Click
        Mes = Mid(MskFecha.Text, 1, 2)
        Desde = DateSerial(startDate.Year, Mes, "01")
        Hasta = DateSerial(startDate.Year, Mes + 1, 0)
        Dim MC As New DtcIvaCompras
        Dim Fila As DtcIvaCompras.EncabezadoRow
        Fila = MC.Encabezado.NewEncabezadoRow
        'traigo los datos del encabezado
        misdatos = MiClase.traedataset("select linea1,linea2,linea3 from encabezado")
        Linea1 = misdatos.Tables(0).Rows(0).Item(0)
        Linea2 = misdatos.Tables(0).Rows(0).Item(1)
        Linea3 = misdatos.Tables(0).Rows(0).Item(2)
        Fila.Linea1 = Linea1
        Fila.Linea2 = Linea2
        Fila.Linea3 = Linea3
        MC.Encabezado.AddEncabezadoRow(Fila)
        'cargo los datos al datagridview
        'Cargo la datagridvies para el reporte
        MiClase.cargardatagriview(DtgIva, "select faccompras.numero,pv,idpr,fnum,fecha,abrev,prov,direccion,cuit,civa,neto,iva21,total,imint,nograv,percep,iva10 from faccompras inner join tip_fac on faccompras.idtp=tip_fac.id where faccompras.fecha between '" & Desde & "' and '" & Hasta & "' order by fecha")
        'traigo los datos de las facturas
        'Dim MnVen As New DtcIvaVentas
        Dim Fila2 As DtcIvaCompras.IvaComprasRow
        Fila2 = MC.IvaCompras.NewIvaComprasRow
        'Fila2 = Mc.IvaVentas.NewIvaVentasRow
        DtgIva.AllowUserToAddRows = False
        For i As Integer = 0 To DtgIva.RowCount - 1
            Fila2 = MC.IvaCompras.NewIvaComprasRow
            Fila2.Id = DtgIva(0, i).Value
            Fila2.Fnum = Trim(DtgIva(3, i).Value)
            Fila2.Fecha = DtgIva(4, i).Value
            Fila2.Comp = DtgIva(5, i).Value
            Fila2.Proveedor = DtgIva(6, i).Value
            Fila2.Cuit = DtgIva(8, i).Value
            ' Fila2.Cuit = DtgIva(12, i).Value
            Fila2.Neto = FormatNumber(DtgIva(10, i).Value, 2)
            Fila2.Iva = FormatNumber(DtgIva(11, i).Value, 2)
            Fila2.Total = FormatNumber(DtgIva(12, i).Value, 2)
            Fila2.ImpInt = FormatNumber(DtgIva(13, i).Value, 2)
            Fila2.NGrav = FormatNumber(DtgIva(14, i).Value, 2)
            Fila2.Percep = FormatNumber(DtgIva(15, i).Value, 2)
            Fila2.Iva10 = FormatNumber(DtgIva(16, i).Value, 2)
            MC.IvaCompras.AddIvaComprasRow(Fila2)
        Next
        misdatos = MiClase.traedataset("select  isnull(sum(neto),0),isnull(sum(iva),0),isnull(sum(total),0) from faccompras where faccompras.fecha between '" & Desde & "' and '" & Hasta & "'")
        Fila2.Sum_Neto = FormatNumber(misdatos.Tables(0).Rows(0).Item(0), 2)
        Fila2.Sum_iva = FormatNumber(misdatos.Tables(0).Rows(0).Item(1), 2)
        Fila2.Sum_Total = FormatNumber(misdatos.Tables(0).Rows(0).Item(2), 2)
        Dim rpt As New CryIvaCompras
        rpt.SetDataSource(MC)
        Reportes.CrystalReportViewer1.ReportSource = rpt
        Reportes.Show()
    End Sub

    Private Sub FrmIvaCompras_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim Fech As Date
        Fech = Date.Today
        MskFecha.Text = Mid(Fech, 3, 9)
    End Sub

    Private Sub MskFecha_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MskFecha.GotFocus
        MskFecha.SelectionStart = 0
        MskFecha.SelectionLength = MskFecha.Text.Length
    End Sub

    Private Sub MskFecha_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles MskFecha.MaskInputRejected

    End Sub
End Class