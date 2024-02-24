Public Class FrmRcuePro
    Dim Fila2 As DtcClientes.DatosRow
    Private Sub Blanq()
        MiClase.eliminaactualizaregistra("delete from faccompras where idtp=" & 10 & "")
        Total = "0"
        Tot = "0"
        Ent = "0"
        Entrega = "0"
        EntAc = "0"
        EntAnt = "0"
        Saldo = "0"
        Txtprov.Text = ""
        txtDirec.Text = ""
        TxtCuit.Text = ""
        TxtCiu.Text = ""
        CmdPantalla.Enabled = False
        Dim fecha1 As Date = DateAdd(DateInterval.Month, 1, Now.Date)
        DtcHasta.Value = DateAdd(DateInterval.Day, 1, DateSerial(fecha1.Year, fecha1.Month, -1))
        DtcDesde.Value = DateSerial(Now.Year, Now.Month, 1)
        Dim fecha2 As Date = DateAdd(DateInterval.Month, 1, Now.Date)
        DtcDesde.Enabled = False
        DtcHasta.Enabled = False
    End Sub


    Private Sub CmdbusCli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdbusCli.Click
        EsPr = "4"
        FrmBpr.Show()
    End Sub

    Private Sub CmdPantalla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdPantalla.Click
        'traigo para el saldo anterior
        DesAn = "01/12/14"
        HasAn = DateAdd(DateInterval.Day, -1, DtcDesde.Value)
        'Dim NextMonth As Date = DateAdd(DateInterval.Day, -1, DtcDesde.Value)
        misdatos = MiClase.traedataset("select isnull( sum(total),0),isnull(sum(entrega),0) from faccompras where numero=" & Id & "and esventa=1 and fecha between '" & DesAn & "' and '" & HasAn & "'")
        SalAnt = misdatos.Tables(0).Rows(0).Item(0)
        EntAnt = misdatos.Tables(0).Rows(0).Item(1)
        SalOld = SalAnt - EntAnt
        If SalOld = "0" Then
        Else
            Cventa = "Cta.Cte"

            MiClase.eliminaactualizaregistra("insert into faccompras  values(" & 1 & "," & 1 & " ," & Id & "," & IdTp & ",'" & Clave & "', " & _
                "'" & DtcDesde.Text & "','" & Txtprov.Text & "','" & txtDirec.Text & "','" & TxtCuit.Text & "','" & TxtIva.Text & "'," & 0 & ", " & _
                "" & 0 & "," & SalAnt & "," & EsVenta & ",'" & Cventa & "'," & 0 & "," & 0 & "," & 0 & "," & 0 & "," & 0 & "," & 0 & ")")
        End If
        '*****************************************
        'Cargo la datagridvies para el reporte
        MiClase.cargardatagriview(DtgD, "select faccompras.idtp,fecha,esventa,total,blng,tipo,fnum,entrega,numero from faccompras inner join tip_fac on faccompras.idtp=tip_fac.id where faccompras.fecha between '" & DtcDesde.Value & "' and '" & DtcHasta.Value & "'  and idpr =" & Id & "and blng=" & BlNg & "and esventa=1 order by fecha")
        Dim Mn As New DtcRcuenta
        Dim Fila As DtcRcuenta.EncabezadoRow
        Fila = Mn.Encabezado.NewEncabezadoRow
        'traigo los datos del encabezado
        misdatos = MiClase.traedataset("select linea1,linea2,linea3 from encabezado")
        Linea1 = misdatos.Tables(0).Rows(0).Item(0)
        Linea2 = misdatos.Tables(0).Rows(0).Item(1)
        Linea3 = misdatos.Tables(0).Rows(0).Item(2)
        Fila.Linea1 = Linea1
        Fila.Linea2 = Linea2
        Fila.Linea3 = Linea3
        Fila.Cliente = Txtprov.Text
        Fila.Direccion = txtDirec.Text
        Fila.Ciudad = TxtCiu.Text
        Fila.Cuit = TxtCuit.Text
        Mn.Encabezado.AddEncabezadoRow(Fila)
        '************************************************
        'traigo para el detalle de resumen
        Dim fila2 As DtcRcuenta.RcuentaRow
        DtgD.AllowUserToAddRows = False
        For i As Integer = 0 To DtgD.RowCount - 1
            NumFac = DtgD(8, i).Value
            fila2 = Mn.Rcuenta.NewRcuentaRow
            fila2.FechaCm = DtgD(1, i).Value
            fila2.Numero = DtgD(6, i).Value
            fila2.Comprobante = DtgD(5, i).Value
            Tot = FormatNumber(DtgD(3, i).Value, 2)
            Ent = FormatNumber(DtgD(7, i).Value, 2)
            Total = Tot + Total
            Entrega = Ent + Entrega
            Saldo = Total - Entrega
            fila2.Debe = Tot
            fila2.Haber = Ent
            fila2.Saldo = Saldo
            Mn.Rcuenta.AddRcuentaRow(fila2)
        Next
        'Traigo los totales del resumen
        misdatos = MiClase.traedataset("select  isnull(sum(total),0),isnull(sum(entrega),0) from facturas where fecha between '" & DtcDesde.Value & "' and '" & DtcHasta.Value & "'  and idcl=" & Idcl & "and blng=" & BlNg & "and esventa=1")
        SumDebe = FormatNumber(misdatos.Tables(0).Rows(0).Item(0), 2)
        SumHaber = FormatNumber(misdatos.Tables(0).Rows(0).Item(1), 2)
        If SumDebe = 0 Then
        Else
            '   fila2.SumDebe = SumDebe
        End If
        If SumHaber = 0 Then
        Else
            '  fila2.SumHaber = SumHaber
        End If
        Dim rpt As New CryRcuenPro
        rpt.SetDataSource(Mn)
        Reportes.CrystalReportViewer1.ReportSource = rpt
        Reportes.Show()
        Blanq()
    End Sub

    Private Sub FrmRcuePro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Blanq()
        Dim fecha1 As Date = DateAdd(DateInterval.Month, 1, Now.Date)
        DtcHasta.Value = DateAdd(DateInterval.Day, 1, DateSerial(fecha1.Year, fecha1.Month, -1))
        DtcDesde.Value = DateSerial(Now.Year, Now.Month, 1)
        Dim fecha2 As Date = DateAdd(DateInterval.Month, 1, Now.Date)
    End Sub

    Private Sub Txtprov_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txtprov.KeyDown
        If e.KeyCode = Keys.Return Then
            EsPr = "4"
            FrmBpr.Show()
        End If
    End Sub

    Private Sub Txtprov_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtprov.TextChanged

    End Sub

    Private Sub CmdLSal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdLSal.Click
        Mensaje = MsgBox("Desea Actualizar los saldos de Proveedor", MsgBoxStyle.YesNo, "Actualizar Saldos Proveedor!!!")
        If Mensaje = MsgBoxResult.Yes Then
            Dim Cont As Integer
            Bar.Minimum = 0
            Bar.Value = 0
            misdatos = MiClase.traedataset("select isnull(count(id),0) from proveedor")
            Cont = FormatNumber(misdatos.Tables(0).Rows(0).Item(0))
            'Bar.Maximum = Cont
            MiClase.cargardatagriview(DtgPro, "select proveedor.id,proveedor,saldo from proveedor order by proveedor ")
            Dim filas As Integer = DtgPro.Rows.Count
            ' Dim contador As Integer = 0
            For i As Integer = 0 To filas - 1
                If IsDBNull(Convert.ToString(DtgPro(0, i).Value)) Then
                Else
                    Idcl = Trim(Convert.ToDouble(DtgPro(0, i).Value))
                End If
                misdatos = MiClase.traedataset("select isnull(sum(saldo),0) from ctactep where idpr=" & Idcl & "")
                TotalE = FormatNumber(misdatos.Tables(0).Rows(0).Item(0))
                '        If TotalE > 0 Then
                MiClase.eliminaactualizaregistra("update proveedor set saldo =" & Str(TotalE) & "where id=" & Idcl & "")
                'End If
                Bar.Increment(1)
            Next
            Mensaje = MsgBox("Finalizo el Proceso")
            If Mensaje = MsgBoxResult.Ok Then
                Bar.Value = 0
                Bar.Increment(0)
            End If
        End If
        'Cargo la datagridvies para el reporte
        MiClase.cargardatagriview(DtgPro, "select proveedor.id,proveedor,direccion,cuit,ciudad,idciu,idciva,saldo from proveedor inner join ciudad on proveedor.idciu=ciudad.id where proveedor.saldo  > 0 order by proveedor")
        Dim Mn As New DtcClientes
        Dim fila As DtcClientes.EncabezadoRow
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
        '************************************************
        Dim Total As Decimal
        'Dim Col As Integer = Me.DtgFac.CurrentCell.ColumnIndex
        Dim Col As Integer = 7
        For Each row As DataGridViewRow In Me.DtgPro.Rows
            Total += Val(row.Cells(Col).Value)
        Next
        Total.ToString()
        'traigo para el detalle de resumen

        DtgPro.AllowUserToAddRows = False
        For i As Integer = 0 To DtgPro.RowCount - 1
            'Clave = DtgRcu(0, i).Value
            Fila2 = Mn.Datos.NewDatosRow
            Fila2.Id = DtgPro(0, i).Value
            Fila2.Cliente = DtgPro(1, i).Value
            Fila2.Direccion = DtgPro(2, i).Value
            Fila2.Cuit = DtgPro(3, i).Value
            Fila2.Ciudad = DtgPro(4, i).Value
            Fila2.IdCiu = DtgPro(5, i).Value
            Fila2.Saldo = FormatNumber(DtgPro(7, i).Value, 2)
            Fila2.TotSaldos = FormatNumber(Total, 2)
            Mn.Datos.AddDatosRow(Fila2)
        Next
        Dim rpt As New CrySaldos
        rpt.SetDataSource(Mn)
        Reportes.CrystalReportViewer1.ReportSource = rpt
        Reportes.Show()


    End Sub
End Class