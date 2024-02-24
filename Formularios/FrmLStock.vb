Public Class FrmLStock

    Private Sub CmdPantalla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdPantalla.Click
        IdFm = CInt(CmbFamilia.SelectedValue(1))
        'Cargo la datagridvies para el reporte
        MiClase.cargardatagriview(DtgArtculo, "select barra,articulo,pcosto,pfinal,stock,idfm,familia from articulos inner join familias on articulos.idfm=familias.id  where idfm=" & IdFm & "")
        Dim Mn As New DtcArticulo
        ' Dim fila As DtcCuotas.EncabRow
        Dim fila As DtcArticulo.EncabezadoRow
        fila = Mn.Encabezado.NewEncabezadoRow
        'traigo los datos del encabezado
        misdatos = MiClase.traedataset("select linea1,linea2,linea3 from encabezado")
        Linea1 = misdatos.Tables(0).Rows(0).Item(0)
        Linea2 = misdatos.Tables(0).Rows(0).Item(1)
        Linea3 = misdatos.Tables(0).Rows(0).Item(2)
        fila.Linea1 = Linea1
        fila.Linea2 = Linea2
        fila.Linea3 = Linea3
        Mn.Encabezado.AddEncabezadoRow(fila)
        'traigo para el detalle de resumen
        Dim Fila2 As DtcArticulo.ArticulosRow
        Fila2 = Mn.Articulos.NewArticulosRow
        DtgArtculo.AllowUserToAddRows = False
        For i As Integer = 0 To DtgArtculo.RowCount - 1
            Fila2 = Mn.Articulos.NewArticulosRow
            Fila2.Codigo = DtgArtculo(0, i).Value
            Fila2.Articulo = DtgArtculo(1, i).Value
            Fila2.Precio = DtgArtculo(2, i).Value
            Fila2.PFinal = FormatNumber(DtgArtculo(3, i).Value, 2)
            Fila2.Stock = DtgArtculo(4, i).Value
            Fila2.IdFm = DtgArtculo(5, i).Value
            Fila2.Familia = DtgArtculo(6, i).Value
            Mn.Articulos.AddArticulosRow(Fila2)
        Next
        Dim rpt As New CryartStk
        rpt.SetDataSource(Mn)
        Reportes.CrystalReportViewer1.ReportSource = rpt
        Reportes.Show()
    End Sub

    Private Sub FrmLStock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MiClase.cargar_Combo(CmbFamilia, "select familia,id from familias order by familia")
    End Sub
End Class