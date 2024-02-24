Public Class FrmLSalCli

    Private Sub FrmLSalCli_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MskFecha.Text = Date.Today
    End Sub

    Private Sub BtnPantalla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPantalla.Click
        MiClase.cargardatagriview(DtgSl, "select ctacte.fecven,lnum,numero,cuota,idcl,cliente,cuit,saldo from ctacte inner join clientes on ctacte.idcl=clientes.id where fecven <'" & MskFecha.Text & "' order by fecven")
        Dim Mn As New DtcSalCli
        Dim Fila As DtcSalCli.EncabezadoRow
        fila = Mn.Encabezado.NewEncabezadoRow
        'traigo los datos del encabezado
        misdatos = MiClase.traedataset("select linea1,linea2,linea3 from encabezado")
        Linea1 = misdatos.Tables(0).Rows(0).Item(0)
        Linea2 = misdatos.Tables(0).Rows(0).Item(1)
        Linea3 = misdatos.Tables(0).Rows(0).Item(2)
        Fila.Linea1 = Linea1
        Fila.Linea2 = Linea2
        Fila.Linea3 = Linea3
        Mn.Encabezado.AddEncabezadoRow(Fila)
        '************************************************
        'traigo para el detalle 
        Dim Fila2 As DtcSalCli.detalFacRow
        DtgSl.AllowUserToAddRows = False
        For i As Integer = 0 To DtgSl.RowCount - 1
            Fila2 = Mn.detalFac.NewdetalFacRow
            Fila2.FecVen = DtgSl(0, i).Value
            Fila2.Lnum = DtgSl(1, i).Value
            Fila2.Cliente = DtgSl(5, i).Value
            Fila2.Cuit = DtgSl(6, i).Value
            Fila2.Saldo = FormatNumber(DtgSl(7, i).Value, 2)
            Mn.detalFac.AdddetalFacRow(Fila2)
        Next
        '+++++++++++++++++++++++++++++++++++++++++++++++++++++++
        Dim rpt As New CrysalCli
        rpt.SetDataSource(Mn)
        Reportes.CrystalReportViewer1.ReportSource = rpt
        Reportes.Show()
    End Sub
End Class