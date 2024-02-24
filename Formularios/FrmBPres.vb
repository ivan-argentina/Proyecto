Public Class FrmBPres
    Private Sub ImpRem()
        
    End Sub
    Private Sub FrmBPres_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'MiClase.cargardatagriview(DtgProv, "select " & Tabla & ".id," & Campo & ",direccion,ciudad,cuit,c_iva,idciu,idcivfa,email,telefono,cel from " & Tabla & " inner join ciudad on " & Tabla & ".idciu=ciudad.id inner join c_de_iva on " & Tabla & ".idciva = c_de_iva.id where " & Tabla & ".id like '" & TxtBprov.Text & "%'")
        'MiClase.cargardatagriview(DtgPres, "select facturas.fnum,fecha,idcl,cliente,direccion,cuit,total,idtp,numero,obs1,obs2 from facturas inner join clientes on facturas.idcl=clientes.id where idtp = " & 7 & "order by numero desc")
        MiClase.cargardatagriview(DtgPres, "select fnum,fecha,idcl,cliente,direccion,cuit,total,idtp,numero,obs1,obs2,ciudad,c_iva from facturas  where idtp = " & 7 & "order by numero desc")
        DtgPres.Font = New Font("Arial ", 12, FontStyle.Regular)
        'DtgEqu.Columns(0).HeaderText = "Equipo"
        DtgPres.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DtgPres.AllowUserToAddRows = False
        DtgPres.AutoResizeColumns()
        DtgPres.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        DtgPres.AutoResizeRows()
        DtgPres.Columns(0).HeaderText = "Numero"
        DtgPres.Columns(2).HeaderText = "Cod."
        DtgPres.Columns(7).Visible = False
        DtgPres.Columns(8).Visible = False
    End Sub

    Private Sub DtgPres_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DtgPres.CellClick
        Dim Mn As New DtcRemito
        Dim Fila As DtcRemito.RemitoRow
        Fila = Mn.Remito.NewRemitoRow
        'Dim Fila1 As DtcRemito.RemitoRow
        'Fila1 = Mn.Remito.NewRemitoRow
        'traigo los datos del e ncabezado
        misdatos = MiClase.traedataset("select linea1,linea2,linea3 from encabezado")
        Linea1 = misdatos.Tables(0).Rows(0).Item(0)
        Linea2 = misdatos.Tables(0).Rows(0).Item(1)
        Linea3 = misdatos.Tables(0).Rows(0).Item(2)
        Fila.Linea1 = Linea1
        Fila.Linea2 = Linea2
        Fila.Linea3 = Linea3
        Fila.Numero = Me.DtgPres.Rows(e.RowIndex).Cells(0).Value()
        Fila.Fecha = Me.DtgPres.Rows(e.RowIndex).Cells(1).Value()
        Fila.IdCl = Me.DtgPres.Rows(e.RowIndex).Cells(2).Value()
        Idcl = Me.DtgPres.Rows(e.RowIndex).Cells(2).Value()
        Fila.Cliente = Me.DtgPres.Rows(e.RowIndex).Cells(3).Value()
        Fila.Direccion = Me.DtgPres.Rows(e.RowIndex).Cells(4).Value()
        Fila.Cuit = Me.DtgPres.Rows(e.RowIndex).Cells(5).Value()
        Fila.IdCl = Me.DtgPres.Rows(e.RowIndex).Cells(2).Value()
        Fila.Total = FormatNumber(Me.DtgPres.Rows(e.RowIndex).Cells(6).Value(), 2)
        Num = Me.DtgPres.Rows(e.RowIndex).Cells(8).Value()
        Fila.Obs = Me.DtgPres.Rows(e.RowIndex).Cells(9).Value()
        Fila.Obs1 = Me.DtgPres.Rows(e.RowIndex).Cells(10).Value()
        'traigo los datos del cliente
        '        misdatos = MiClase.traedataset("select clientes.cliente,ciudad,c_iva from clientes inner join ciudad on clientes.IdCiu=ciudad.Id inner join c_de_iva on clientes.idciva = c_de_iva.id  where clientes.id=" & Idcl & "")
        '       Fila.Ciudad = misdatos.Tables(0).Rows(0).Item(1)
        '      Fila.CDe_Iva = misdatos.Tables(0).Rows(0).Item(2)

        Mn.Remito.AddRemitoRow(Fila)
        'detalle de remito
        Dim Fila1 As DtcRemito.DetalleRow
        'Fila1 = Mn.Remito.new
        'FilDt = Mn.Remito.NewRemitoRow
        MiClase.cargardatagriview(DtgArt, "select articulo,punit,cantidad,ptotal,linea,barra,idpr,idmr,idfm,alic from detal_Fac where id=" & Num & " and idtp=" & 7 & "order by linea desc ")
        DtgArt.AllowUserToAddRows = False
        For i As Integer = 0 To DtgArt.RowCount - 1
            Fila1 = Mn.Detalle.NewDetalleRow
            Fila1.Articulo = DtgArt(0, i).Value
            Fila1.PUnit = FormatNumber(DtgArt(1, i).Value, 2)
            Fila1.Cantidad = FormatNumber(DtgArt(2, i).Value, 2)
            Fila1.PTotal = FormatNumber(DtgArt(3, i).Value, 2)
            Fila1.IdAr = DtgArt(5, i).Value
            Mn.Detalle.AddDetalleRow(Fila1)
        Next
        Dim RpP As New CryPresupuesto
        RpP.SetDataSource(Mn)
        Reportes.CrystalReportViewer1.ReportSource = RpP
        'Reportes.CrystalReportViewer1.PrintReport()
        Reportes.Show()
        'End If
    End Sub


    Private Sub DtgPres_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DtgPres.CellContentClick

    End Sub
End Class