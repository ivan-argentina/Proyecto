Public Class FrmLcarne

    Private Sub CmdPantalla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdPantalla.Click
        Desde = CDate(DtcDesde.Value)
        Hasta = CDate(DtcHasta.Value)
        Dim Mn As New DtcCarne
        Dim Fila As DtcCarne.EncabezadoRow
        Fila = Mn.Encabezado.NewEncabezadoRow
        'traigo los datos del encabezado
        misdatos = MiClase.traedataset("select linea1,linea2,linea3 from encabezado")
        Linea1 = misdatos.Tables(0).Rows(0).Item(0)
        Linea2 = misdatos.Tables(0).Rows(0).Item(1)
        Linea3 = misdatos.Tables(0).Rows(0).Item(2)
        Fila.Linea1 = Linea1
        Fila.Linea2 = Linea2
        Fila.Linea3 = Linea3
        Fila.Desde = DtcDesde.Value
        Fila.Hasta = DtcHasta.Value
        Mn.Encabezado.AddEncabezadoRow(Fila)
        'Ventas
        MiClase.cargardatagriview(DtgV, "select id,familia,est from familias where est =" & 1 & "")
        DtgV.AllowUserToAddRows = False
        Dim Fila2 As DtcCarne.CarneRow
        Fila2 = Mn.Carne.NewCarneRow
        DtgV.AllowUserToAddRows = False
        For i As Integer = 0 To DtgV.RowCount - 1
            Fila2 = Mn.Carne.NewCarneRow
            IdFm = DtgV(0, i).Value
            ' and '" & FcH & "'
            misdatos = MiClase.traedataset("select isnull(sum(ptotal),0) from detal_fac where idfm=" & IdFm & "and detal_fac.fecha between '" & Desde & "' and '" & Hasta & "'")
            Fila2.Total = misdatos.Tables(0).Rows(0).Item(0)
            Tot = misdatos.Tables(0).Rows(0).Item(0)
            Fila2.Total = Tot
            Fila2.IdEst = 0
            'and '" & FcH & "'
            misdatos = MiClase.traedataset("select isnull(sum(ptotal),0) from carne where idfm=" & IdFm & " and carne.fecha between '" & Desde & "' and '" & Hasta & "' ")
            Fila2.TotCom = misdatos.Tables(0).Rows(0).Item(0)
            Id = DtgV(0, i).Value
            Fila2.IdFm = DtgV(0, i).Value
            Fila2.Familia = DtgV(1, i).Value
            Mn.Carne.AddCarneRow(Fila2)
        Next
        Dim rpt As New CryCarne
        rpt.SetDataSource(Mn)
        Reportes.CrystalReportViewer1.ReportSource = rpt
        Reportes.Show()


    End Sub

    Private Sub FrmLcarne_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    
End Class