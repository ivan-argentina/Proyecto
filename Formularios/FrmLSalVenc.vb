Public Class FrmLSalVenc

    Private Sub CmdSaldos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
      
    End Sub

    Private Sub CmdSaldos_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSaldos.Click
        'Cargo la datagridvies para el reporte
        If BlNg = 0 Then
            MiClase.cargardatagriview(DtgSaldos, "select numero,idtp,cuota,idcl,idenc,fecha,fecven,importe,entrega,saldo,blng,lnum,cliente,direccion from ctacte inner join clientes  on clientes.id=ctacte.idcl where saldo >" & 0 & "and blng=" & 0 & "")
        Else
            MiClase.cargardatagriview(DtgSaldos, "select numero,idtp,cuota,idcl,idenc,fecha,fecven,importe,entrega,saldo,blng,lnum,cliente,direccion from ctacte inner join clientes  on clientes.id=ctacte.idcl where saldo >" & 0 & "")
        End If
        Dim Mn As New DtcCuotas
        Dim fila As DtcCuotas.EncabRow
        'fila = Mn.Encabezado.NewEncabezadoRow
        fila = Mn.Encab.NewEncabRow
        'traigo los datos del encabezado
        misdatos = MiClase.traedataset("select linea1,linea2,linea3 from encabezado")
        Linea1 = misdatos.Tables(0).Rows(0).Item(0)
        Linea2 = misdatos.Tables(0).Rows(0).Item(1)
        Linea3 = misdatos.Tables(0).Rows(0).Item(2)
        fila.Linea1 = Linea1
        fila.Linea2 = Linea2
        fila.Linea3 = Linea3
        Mn.Encab.AddEncabRow(fila)
        '************************************************
        'Dim Total As Decimal
        'Dim Col As Integer = Me.DtgFac.CurrentCell.ColumnIndex
        'Dim Col As Integer = 7
        'For Each row As DataGridViewRow In Me.DtgRcu.Rows
        ' Total += Val(row.Cells(Col).Value)
        ' Next
        ' Total.ToString()
        'traigo para el detalle de resumen
        Dim Fila2 As DtcCuotas.CuotasRow

        DtgSaldos.AllowUserToAddRows = False
        For i As Integer = 0 To DtgSaldos.RowCount - 1
            'Clave = DtgRcu(0, i).Value
            Dim Dias As Integer
            FecVen = DtgSaldos(6, i).Value
            Dias = DateDiff(DateInterval.Day, Date.Today, FecVen)

            Fila2 = Mn.Cuotas.NewCuotasRow
            Fila2.IdCli = DtgSaldos(3, i).Value
            Fila2.Numero = DtgSaldos(11, i).Value
            Fila2.Vencimiento = DtgSaldos(6, i).Value
            Fila2.Saldo = DtgSaldos(9, i).Value
            Fila2.Cliente = DtgSaldos(12, i).Value
            Fila2.Direccion = DtgSaldos(13, i).Value
            'Fila2.Ciudad = DtgRcu(4, i).Value
            'Fila2.IdCiu = DtgRcu(5, i).Value
            'Fila2.Saldo = FormatNumber(DtgRcu(7, i).Value, 2)
            'Fila2.TotSaldos = Total
            'Mn.Datos.AddDatosRow(Fila2)
            Mn.Cuotas.AddCuotasRow(Fila2)
        Next
        Dim rpt As New CrySalVenc
        rpt.SetDataSource(Mn)
        Reportes.CrystalReportViewer1.ReportSource = rpt
        Reportes.Show()
    End Sub
End Class