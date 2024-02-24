Public Class FrmLVenFam

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdPantalla.Click
        Desde = CDate(DtcDes.Value)
        Hasta = CDate(DtcHas.Value)
        Dim Mn As New DtcDetalFac '
        Dim Fila As DtcDetalFac.EncabezadoRow
        Fila = Mn.Encabezado.NewEncabezadoRow
        misdatos = MiClase.traedataset("select linea1,linea2,linea3 from encabezado")
        Linea1 = misdatos.Tables(0).Rows(0).Item(0)
        Linea2 = misdatos.Tables(0).Rows(0).Item(1)
        Linea3 = misdatos.Tables(0).Rows(0).Item(2)
        Fila.Linea1 = Linea1
        Fila.Linea2 = Linea2
        Fila.Linea3 = Linea3
        Fila.Desde = CDate(Desde)
        Fila.Hasta = Hasta
        Mn.Encabezado.AddEncabezadoRow(Fila)
        MiClase.cargardatagriview(DtgVen, "select detal_fac.id,fecha,barra,articulo,punit,cantidad,ptotal,idfm,familia from detal_fac inner join familias on detal_fac.idfm=familias.id where detal_fac.fecha between '" & Desde & "' and '" & Hasta & "' and idtp=" & 4 & "")
        For i As Integer = 0 To DtgVen.RowCount - 1
            Dim filas As Integer = DtgVen.Rows.Count
            Dim contador As Integer = 0
            Dim Fila2 As DtcDetalFac.DetalFacRow
            Fila2 = Mn.DetalFac.NewDetalFacRow
            Fila2.IdFm = DtgVen(7, i).Value
            Fila2.Familia = DtgVen(8, i).Value
            Fila2.Ptotal = DtgVen(6, i).Value
            Mn.DetalFac.AddDetalFacRow(Fila2)
        Next
        Dim rpt As New CryVenFam
        rpt.SetDataSource(Mn)
        Reportes.CrystalReportViewer1.ReportSource = rpt
        Reportes.Show()
    End Sub

    Private Sub DtgVen_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DtgVen.CellContentClick

    End Sub
End Class