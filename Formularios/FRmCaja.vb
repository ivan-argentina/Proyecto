Public Class FRmCaja

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Cargo la datagridvies para el reporte
        MiClase.cargardatagriview(DtgCaja, "select numero,idcl,idcom,fecha,comprobante,nucom,importe,blng,idpc,comp from pagos inner join com_caja on pagos.idcom=com_caja.id ")
        Dim Mn As New DtcCaja
        'Dim fila As DtcClientes.EncabezadoRow
        Dim Fila As DtcCaja.EncabezadoRow
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
        '************************************************
        'traigo para el detalle de resumen
        'Dim Fila2 As DtcClientes.DatosRow

        Dim Tot As Decimal
        Dim Fila2 As DtcCaja.CajaRow
        DtgCaja.AllowUserToAddRows = False
        misdatos = MiClase.traedataset("select isnull(sum(importe),0) from pagos where idpc=" & Pc & "")
        Tot = FormatNumber(misdatos.Tables(0).Rows(0).Item(0))
        For i As Integer = 0 To DtgCaja.RowCount - 1
            'Clave = DtgRcu(0, i).Value
            'Fila2 = Mn.Datos.NewDatosRow 
            Fila2 = Mn.Caja.NewCajaRow
            'Fila2 = Mn.Caja
            Fila2.Numero = DtgCaja(0, i).Value
            Fila2.IdCom = DtgCaja(2, i).Value
            Fila2.Comprobante = DtgCaja(9, i).Value
            Fila2.Importe = DtgCaja(6, i).Value
            Fila2.Sum_Total = Tot
            '   Fila2.Fecha = DtgCaja(3, i).Value

            'Fila2.IdCiu = DtgRcu(5, i).Value
            'Fila2.Saldo = FormatNumber(DtgRcu(7, i).Value, 2)
            'Fila2.TotSaldos = Total
            'Mn.Datos.AddDatosRow(Fila2)
            Mn.Caja.AddCajaRow(Fila2)
        Next
        Dim rpt As New CryCaja
        rpt.SetDataSource(Mn)
        Reportes.CrystalReportViewer1.ReportSource = rpt
        Reportes.Show()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdPantalla.Click
        IdUs = CmbCajero.SelectedValue(1)
        Fc = DtcDesde.Value
        Fc = Format(DtcDesde.Value, "dd/MM/yy")
        Dim Mn As New DtcCaja
        'Dim fila As DtcClientes.EncabezadoRow
        Dim Fila As DtcCaja.EncabezadoRow
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
        '************************************************
        'Dim Fila2 As DtcClientes.DatosRow
        Dim Fila2 As DtcCaja.CajaRow
        Fila2 = Mn.Caja.NewCajaRow
        Fila2.fecha = Fc
        Fila2.Cajero = CmbCajero.SelectedValue(0)
        'Traigo Total Efectivo
        'misdatos = MiClase.traedataset("select isnull(sum(importe),0) from pagos where idcom=" & 1 & " and fecha='" & DtcDesde.Text & "'and idus=" & IdUs & " ")
        ' misdatos = MiClase.traedataset("   select isnull( sum(total),0) FROM facturas where fecha ='" & DtcDesde.Text & "' and EsVenta= " & 0 & "and idus=" & IdUs & "and idtp=" & 4 & "")
        misdatos = MiClase.traedataset("select isnull( SUM(importe),0) from Pagos where Fecha ='" & DtcDesde.Text & "' and IdCom= '" & 1 & "'")
        Fila2.Sum_Efectivo = misdatos.Tables(0).Rows(0).Item(0)
        'Traigo Total Tarjetas
        misdatos = MiClase.traedataset("select isnull( SUM(importe),0)  FROM Pagos where Fecha ='" & DtcDesde.Text & "' and IdCom= '" & 2 & "'")
        Fila2.Sum_Tarjeta = misdatos.Tables(0).Rows(0).Item(0)
        'Traigo Total Ventas en Cta.Cte
        misdatos = MiClase.traedataset("select isnull(sum(debe),0) from fac_cta where fecha='" & DtcDesde.Text & "'and idus=" & IdUs & " ")
        Fila2.Sum_Ctacte = misdatos.Tables(0).Rows(0).Item(0)

        'Traigo Total Cobros en Cuentas Corrientes
        misdatos = MiClase.traedataset("select isnull(sum(haber),0) from fac_cta where fecha='" & DtcDesde.Text & "' and idus=" & IdUs & "")
        Fila2.Sum_Cobros = misdatos.Tables(0).Rows(0).Item(0)

        'Traigo Total de pagos Cta.Cte
        misdatos = MiClase.traedataset("select isnull(sum(importe),0) from pagosp where fecha='" & DtcDesde.Text & "'and idus=" & IdUs & " ")
        Fila2.Sum_Pagos = misdatos.Tables(0).Rows(0).Item(0)

        Mn.Caja.AddCajaRow(Fila2)

        Dim rpt As New CryCaja
        rpt.SetDataSource(Mn)
        Reportes.CrystalReportViewer1.ReportSource = rpt
        Reportes.Show()
    End Sub

    Private Sub FRmCaja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Desde = DateSerial(startDate.Year, startDate.Month, Date )

        MiClase.cargar_Combo(CmbCajero, "select cajero,id from cajeros")
    End Sub

    Private Sub Dtcfecha_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Return Then
            CmbCajero.Focus()
        End If
    End Sub

    Private Sub Dtcfecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CmbCajero_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbCajero.KeyDown
        If e.KeyCode = Keys.Return Then
            CmdPantalla.Focus()
        End If
    End Sub

    Private Sub CmbCajero_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbCajero.SelectedIndexChanged

    End Sub
End Class