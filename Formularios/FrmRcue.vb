Public Class FrmRcue
    Dim Esc As Integer
    Dim SalMor As Decimal
    Dim EntMor As Decimal
    Dim DebMor As Decimal
    Dim Porc As Decimal
    Private Sub Fnum()
        'Formateo el Numero de Comprobante
        Num = NumFac
        If Num < 10 Then
            Lnum = "0000000" + Num
        ElseIf Num >= 10 And Num < 100 Then
            Lnum = "000000" + Num
        ElseIf Num >= 100 And Num < 1000 Then
            Lnum = "00000" + Num
        ElseIf Num >= 1000 And Num < 10000 Then
            Lnum = "0000" + Num
        ElseIf Num >= 10000 And Num < 100000 Then
            Lnum = "000" + Num
        ElseIf Num >= 100000 And Num < 1000000 Then
            Lnum = "00" + Num
        ElseIf Num >= 1000000 And Num < 10000000 Then
            Lnum = "0" + Num
        ElseIf Num >= 10000000 And Num < 100000000 Then
            Lnum = Num
        End If
        Clave = Lnum
    End Sub


    Private Sub actSal()
        Dim Cont As Integer
        Bar.Minimum = 0
        Bar.Value = 0
        misdatos = MiClase.traedataset("select isnull(count(id),0) from clientes")
        Cont = FormatNumber(misdatos.Tables(0).Rows(0).Item(0))
        'Bar.Maximum = Cont
        MiClase.cargardatagriview(Dtgcli, "select clientes.id,cliente,salcli from clientes order by cliente ")
        Dim filas As Integer = Dtgcli.Rows.Count
        ' Dim contador As Integer = 0
        For i As Integer = 0 To filas - 1
            If IsDBNull(Convert.ToString(Dtgcli(0, i).Value)) Then
            Else
                Idcl = Trim(Convert.ToDouble(Dtgcli(0, i).Value))
            End If
            misdatos = MiClase.traedataset("select isnull(sum(saldo),0) from ctacte where idcl=" & Idcl & "")
            TotalE = FormatNumber(misdatos.Tables(0).Rows(0).Item(0))
            If TotalE > 0 Then
                MiClase.eliminaactualizaregistra("update clientes set salcli =" & Str(TotalE) & "where id=" & Idcl & "")
            End If
            Bar.Increment(1)
        Next
        MsgBox("Finalizo el Proceso")
    End Sub
    
    Private Sub Blanq()
        MiClase.eliminaactualizaregistra("delete from fac_cta where idtp=" & 10 & "")
        MiClase.eliminaactualizaregistra("delete from fac_cta where idtp=" & 15 & "")
        Total = "0"
        Tot = "0"
        Ent = "0"
        Entrega = "0"
        EntAc = "0"
        EntAnt = "0"
        Saldo = "0"
        TxtCli.Text = ""
        txtDirec.Text = ""
        TxtCuit.Text = ""
        TxtCiu.Text = ""
        CmdPantalla.Enabled = False
        CmdDetVen.Enabled = False
        Dim fecha1 As Date = DateAdd(DateInterval.Month, 1, Now.Date)
        DtcHasta.Value = DateAdd(DateInterval.Day, 1, DateSerial(fecha1.Year, fecha1.Month, -1))
        DtcDesde.Value = DateSerial(Now.Year, Now.Month, 1)
        Dim fecha2 As Date = DateAdd(DateInterval.Month, 1, Now.Date)
        DtcDesde.Enabled = False
        DtcHasta.Enabled = False
        TxtMora.Text = 0
        'TxtMora.Enabled = False
    End Sub


    Private Sub TotGrid()
        Dim Col As Integer = 4
        For Each row As DataGridViewRow In Me.DtgRcu.Rows
            Total += Val(row.Cells(Col).Value)
        Next
        Total = (Total.ToString)
        Dim ColE As Integer = 8
        For Each row As DataGridViewRow In Me.DtgRcu.Rows
            TotalE += Val(row.Cells(ColE).Value)
        Next

    End Sub

    Private Sub TxtCli_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCli.Click
        Blanq()
    End Sub
    Private Sub TxtCli_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCli.KeyDown
        If e.KeyCode = Keys.Return Then
            If IsNumeric(TxtCli.Text) Then
                misdatos = MiClase.traedataset("select id,cliente,direccion from clientes where id=" & TxtCli.Text & "")
                Dim totclF As Integer = misdatos.Tables(0).Rows.Count
                If totclF = 0 Then
                    Mensaje = MsgBox("Este Cliente No Existe", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Cliente Inexistente!!!")
                    If Mensaje = MsgBoxResult.Ok Then
                        TxtCli.Focus()
                        TxtCli.SelectionStart = 0
                        TxtCli.SelectionLength = TxtCli.Text.Length
                    End If
                Else
                    misdatos = MiClase.traedataset("select clientes.id,cliente,direccion,ciudad,cuit,c_iva,idciu,idciva,email,telefono,cel,cpostal,idpr,provincia,email from clientes inner join ciudad on clientes.idciu=ciudad.id inner join c_de_iva on clientes.idciva = c_de_iva.id inner join provincias on clientes.idpr=provincias.id where clientes.id = " & TxtCli.Text & " ")
                    Idcl = misdatos.Tables(0).Rows(0).Item(0)
                    TxtCli.Text = misdatos.Tables(0).Rows(0).Item(1)
                    txtDirec.Text = misdatos.Tables(0).Rows(0).Item(2)
                    TxtCiu.Text = misdatos.Tables(0).Rows(0).Item(3)
                    TxtCuit.Text = misdatos.Tables(0).Rows(0).Item(4)
                    IdCiva = misdatos.Tables(0).Rows(0).Item(7)
                    DtcDesde.Enabled = True
                    DtcHasta.Enabled = True
                    CmdPantalla.Enabled = True
                    CmdPantalla.Focus()
                    CmdDetVen.Enabled = True

                    
                End If
            Else
                EsCl = 5
                BCli = TxtCli.Text
                FrmBcl.Show()
            End If

        End If

    End Sub

    Private Sub CmdPantalla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdPantalla.Click
        MiClase.cargardatagriview(Dtgcli, "select clientes.id,cliente,direccion,ciudad,cuit,c_iva,idciu,idciva,email,telefono,cel,cpostal,idpr,provincia,fec_nac,salcli from clientes inner join ciudad on clientes.idciu=ciudad.id inner join c_de_iva on clientes.idciva = c_de_iva.id inner join provincias on clientes.idpr=provincias.id order by cliente ")
        'traigo para el saldo anterior
        DesAn = "01/12/14"
        Ds = (DateAdd("d", -1, DtcDesde.Value))
        HasAn1 = Ds
        HasAn1 = Format(Ds, "dd/MM/yy")
        FcD = Format(DesAn, "dd/MM/yy")
        FcH = Format(HasAn, "dd/MM/yy")
        FDes = DtcDesde.Value
        FDes = Format(DtcDesde.Value, "dd/MM/yy")
        FHas = DtcHasta.Value
        FHas = Format(DtcHasta.Value, "dd/MM/yy")
        If BlNg = 0 Then
            misdatos = MiClase.traedataset("select isnull( sum(debe),0),isnull(sum(haber),0) from fac_cta where idcl=" & Idcl & "and blng=" & BlNg & " and fecha between '" & DesAn & "' and '" & HasAn1 & "'")
        ElseIf BlNg = 1 Then
            misdatos = MiClase.traedataset("select isnull( sum(debe),0),isnull(sum(haber),0) from fac_cta where idcl=" & Idcl & " and fecha between '" & DesAn & "' and '" & HasAn1 & "'")
        End If
        SalAnt = misdatos.Tables(0).Rows(0).Item(0)
        EntAnt = misdatos.Tables(0).Rows(0).Item(1)
        SalOld = SalAnt - EntAnt
        If SalOld = 0 Then
        Else
            Cventa = "Cta.Cte"
            IdTp = 10
            EsVenta = 1
            Cventa = "Cta.Cte"
            NetT = 0
            IvT = 0
            Iint = 0
            Alic = 21
            Dim Ob As String
            Ob = "a"
            Dim Civa As String
            Civa = "RI"
            Pv = 1
            IdEnc = 1
            IdCiva = 1
            IdPrv = 12
            Cpostal = "0"
            Clave = 0
            SalOld = 0
            MiClase.eliminaactualizaregistra("insert into fac_cta values(" & NumFac & "," & IdTp & ", " & _
              "" & Idcl & ",'" & TxtCli.Text & "','" & txtDirec.Text & "','" & TxtCiu.Text & "','" & IdCiva & "','" & FDes & "', " & _
              "" & Str(SalOld) & "," & Str(EntAnt) & "," & Str(SalAnt) & ",'" & Clave & "'," & BlNg & "," & IdUs & ")")
        End If
        '*****************************************
        'Traigo para mora
        If BlNg = 0 Then
            misdatos = MiClase.traedataset("select isnull( sum(debe),0),isnull(sum(haber),0) from fac_cta where idcl=" & Idcl & "and blng=" & BlNg & " and fecha between '" & FDes & "' and '" & FHas & "'  and idcl=" & Idcl & "")
        ElseIf BlNg = 1 Then
            misdatos = MiClase.traedataset("select isnull( sum(saldo),0),isnull(sum(haber),0) from fac_cta where fac_cta.fecha between '" & FDes & "' and '" & FHas & "'  and idcl=" & Idcl & "")
        End If
        DebMor = misdatos.Tables(0).Rows(0).Item(0)
        EntMor = misdatos.Tables(0).Rows(0).Item(1)
        SalMor = DebMor - EntMor
        Porc = SalMor * TxtMora.Text / 100
        If TxtMora.Text > 0 Then
            Cventa = "Cta.Cte"
            IdTp = 15
            EsVenta = 1
            Cventa = "Cta.Cte"
            NetT = 0
            IvT = 0
            Iint = 0
            Alic = 21
            Dim Ob As String
            Ob = "a"
            Dim Civa As String
            Civa = "RI"
            Pv = 1
            IdEnc = 1
            IdCiva = 1
            IdPrv = 12
            Cpostal = "0"
            Clave = 0
            SalOld = 0
            misdatos = MiClase.traedataset("select isnull(max(numero),0) from facturas where idtp=" & 15 & "")
            NumFac = misdatos.Tables(0).Rows(0).Item(0) + 1
            Fnum()
            MiClase.eliminaactualizaregistra("insert into fac_cta values(" & NumFac & "," & IdTp & ", " & _
              "" & Idcl & ",'" & TxtCli.Text & "','" & txtDirec.Text & "','" & TxtCiu.Text & "','" & IdCiva & "','" & Date.Today & "', " & _
              "" & Str(Porc) & "," & Str(0) & "," & Str(Porc) & ",'" & Clave & "'," & BlNg & "," & IdUs & ")")
        End If


        '*****************************
        'Cargo la datagridvies para el reporte        
        If BlNg = 0 Then
            MiClase.cargardatagriview(DtgRcu, "select fac_cta.idtp,fecha,saldo,blng,tipo,lnum,haber,numero from fac_cta inner join tip_fac on fac_cta.idtp=tip_fac.id where fac_cta.fecha between '" & FDes & "' and '" & FHas & "'  and idcl=" & Idcl & "and blng=" & BlNg & " order by fecha")
        ElseIf BlNg = 1 Then
            MiClase.cargardatagriview(DtgRcu, "select fac_cta.idtp,fecha,saldo,blng,tipo,lnum,haber,numero from fac_cta inner join tip_fac on fac_cta.idtp=tip_fac.id where fac_cta.fecha between '" & FDes & "' and '" & FHas & "'  and idcl=" & Idcl & " order by fecha")
        End If
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
        Fila.Cliente = TxtCli.Text
        Fila.Direccion = txtDirec.Text
        Fila.Ciudad = TxtCiu.Text
        Fila.Cuit = TxtCuit.Text
        Mn.Encabezado.AddEncabezadoRow(Fila)
        '************************************************
        'traigo para el detalle de resumen
        Dim fila2 As DtcRcuenta.RcuentaRow
        DtgRcu.AllowUserToAddRows = False
        For i As Integer = 0 To DtgRcu.RowCount - 1
            fila2 = Mn.Rcuenta.NewRcuentaRow
            NumFac = DtgRcu(7, i).Value
            FecVen = Format(DtgRcu(1, i).Value)
            Fcp = FecVen
            Fcp = Format(FecVen, "dd/MM/yy")
            fila2.FechaCm = Fcp
            fila2.Numero = DtgRcu(5, i).Value
            fila2.Comprobante = DtgRcu(4, i).Value
            Tot = FormatNumber(DtgRcu(2, i).Value, 2)
            Ent = FormatNumber(DtgRcu(6, i).Value, 2)
            Total = Tot + Total
            Entrega = Ent + Entrega
            Saldo = Total - Entrega
            fila2.Debe = Tot
            fila2.Haber = Ent
            fila2.Saldo = Saldo
            'If TxtMora.Text > 0 Then
            ' fila2.mora = TxtMora.Text
            'End If


            Mn.Rcuenta.AddRcuentaRow(fila2)
        Next
        DesRs = DtcDesde.Value
        DesRs = Format(DtcDesde.Value, "dd/MM/yy")
        HasRs = DtcHasta.Value
        HasRs = Format(DtcHasta.Value, "dd/MM/yy")
        If BlNg = 0 Then
            misdatos = MiClase.traedataset("select  isnull(sum(debe),0),isnull(sum(haber),0) from fac_cta where fecha between '" & DesRs & "' and '" & HasRs & "'  and idcl=" & Idcl & "and blng=" & BlNg & "")
        ElseIf BlNg = 1 Then
            misdatos = MiClase.traedataset("select  isnull(sum(debe),0),isnull(sum(haber),0) from fac_cta where fecha between '" & DesRs & "' and '" & HasRs & "'  and idcl=" & Idcl & "")
        End If
        
        Dim rpt As New CryRcuenCli
        rpt.SetDataSource(Mn)
        Reportes.CrystalReportViewer1.ReportSource = rpt
        Reportes.Show()
        Blanq()
        ' CmdPantalla.Enabled = False
    End Sub
    Private Sub FrmRcue_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim fecha1 As Date = DateAdd(DateInterval.Month, 1, Now.Date)
        DtcHasta.Value = DateAdd(DateInterval.Day, 1, DateSerial(fecha1.Year, fecha1.Month, -1))
        DtcDesde.Value = DateSerial(Now.Year, Now.Month, 1)
        Dim fecha2 As Date = DateAdd(DateInterval.Month, 1, Now.Date)
        ' HasAn = DateSerial(Year(DtcDesde.Text), Month(DtcDesde.Text), 0)

    End Sub

    Private Sub DtcHasta_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DtcHasta.KeyDown
        If e.KeyCode = Keys.Return Then
            CmdPantalla.Focus()
        End If
    End Sub
    Private Sub DtcDesde_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DtcDesde.KeyDown
        If e.KeyCode = Keys.Return Then
            DtcHasta.Focus()
        End If
    End Sub
    Private Sub CmdLSal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdLSal.Click
        MiClase.cargardatagriview(DtgRcu, "select clientes.id,cliente,direccion,cuit,ciudad,idciu,idciva,salcli from clientes inner join ciudad on clientes.idciu=ciudad.id where clientes.salcli  <> 0 order by cliente")
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
        For Each row As DataGridViewRow In Me.DtgRcu.Rows
            Total += Val(row.Cells(Col).Value)
        Next
        Total.ToString()
        'traigo para el detalle de resumen
        Dim Fila2 As DtcClientes.DatosRow
        DtgRcu.AllowUserToAddRows = False
        For i As Integer = 0 To DtgRcu.RowCount - 1
            'Clave = DtgRcu(0, i).Value
            Fila2 = Mn.Datos.NewDatosRow
            Fila2.Id = DtgRcu(0, i).Value
            Fila2.Cliente = DtgRcu(1, i).Value
            Fila2.Direccion = DtgRcu(2, i).Value
            Fila2.Cuit = DtgRcu(3, i).Value
            Fila2.Ciudad = DtgRcu(4, i).Value
            Fila2.IdCiu = DtgRcu(5, i).Value
            Fila2.Saldo = FormatNumber(DtgRcu(7, i).Value, 2)
            Fila2.TotSaldos = FormatNumber(Total, 2)
            Mn.Datos.AddDatosRow(Fila2)
        Next
        Dim rpt As New CrySaldos
        rpt.SetDataSource(Mn)
        Reportes.CrystalReportViewer1.ReportSource = rpt
        Reportes.Show()
        'Blanq()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Saldo As Decimal
        misdatos = MiClase.traedataset("select isnull( count(id),0) from clientes")
        Count = misdatos.Tables(0).Rows(0).Item(0)
        barra.Minimum = 0
        barra.Value = 0
        barra.Maximum = Count
        MiClase.cargardatagriview(DtgRcu, "select id,cliente from clientes")
        Dim filas As Integer = DtgRcu.Rows.Count
        Dim contador As Integer = 0
        For i As Integer = 0 To filas - 1
            Idcl = DtgRcu(0, i).Value
            misdatos = MiClase.traedataset("select  isnull(sum(total),0),isnull(sum(entrega),0) from facturas where idcl=" & Idcl & " and EsVenta=1")
            Total = FormatNumber(misdatos.Tables(0).Rows(0).Item(0), 2)
            TotalE = FormatNumber(misdatos.Tables(0).Rows(0).Item(1), 2)
            Saldo = Total - TotalE
            MiClase.eliminaactualizaregistra("update clientes set salcli=" & Saldo & " where id=" & Idcl & "")
            barra.Increment(1)
        Next
        If barra.Value = barra.Maximum Then
            MsgBox("Finalizo")
        End If


    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdDetVen.Click
        'Dim Mn1 As New DtcDetalFac
        Dim Mn As New DtcDetalFac
        Dim Fila As DtcDetalFac.DetalFacRow
        Dim Fil As DtcDetalFac.EncabezadoRow
        Fil = Mn.Encabezado.NewEncabezadoRow
        FDes = DtcDesde.Value
        FDes = Format(DtcDesde.Value, "dd/MM/yy")
        FHas = DtcHasta.Value
        FHas = Format(DtcHasta.Value, "dd/MM/yy")
        'traigo los datos del encabezado
        misdatos = MiClase.traedataset("select linea1,linea2,linea3 from encabezado")
        Linea1 = misdatos.Tables(0).Rows(0).Item(0)
        Linea2 = misdatos.Tables(0).Rows(0).Item(1)
        Linea3 = misdatos.Tables(0).Rows(0).Item(2)
        Fil.Linea1 = Linea1
        Fil.Linea2 = Linea2
        Fil.Linea3 = Linea3
        Fil.Cliente = TxtCli.Text
        Fil.Direccion = txtDirec.Text
        'Fil.Ciudad = TxtCiu.Text
        'Fil.Cuit = TxtCuit.Text
        Mn.Encabezado.AddEncabezadoRow(Fil)
        
        'traigo los datos de la factura
        If BlNg = 0 Then
            MiClase.cargardatagriview(DtgRcu, "select articulo,punit,cantidad,ptotal,linea,barra,id,idtp,fecha from detal_Fac where idcl=" & Idcl & " and blng=" & BlNg & " and detal_fac.fecha between '" & FDes & "' and '" & FHas & "'and esventa=" & 1 & " order by fecha desc ")
        Else
            MiClase.cargardatagriview(DtgRcu, "select articulo,punit,cantidad,ptotal,linea,barra,id,idtp,fecha from detal_Fac where idcl=" & Idcl & " and detal_fac.fecha between '" & FDes & "' and '" & FHas & "'and esventa=" & 1 & " order by fecha desc ")
        End If

        DtgRcu.AllowUserToAddRows = False
        For i As Integer = 0 To DtgRcu.RowCount - 1
            Fila = Mn.DetalFac.NewDetalFacRow
            Fila.Articulo = Trim(DtgRcu(0, i).Value)
            Fila.PUnit = FormatNumber(DtgRcu(1, i).Value, 2)
            Fila.Cantidad = FormatNumber(DtgRcu(2, i).Value, 2)
            Fila.Ptotal = FormatNumber(DtgRcu(3, i).Value, 2)
            Fila.Barra = DtgRcu(5, i).Value
            Fila.numero = DtgRcu(6, i).Value
            Fila.Fecha = DtgRcu(8, i).Value
            ' Fila1.Unidad = Dtgart(10, i).Value
            ' Mn.Detalle.AddDetalleRow(Fila1)
            Mn.DetalFac.AddDetalFacRow(Fila)
            'Mn.Rcuenta.AddRcuentaRow(fila2)
            'Mn.DetalFac.AddDetalFacRow(Fila)
        Next
        Dim rpt As New CryDetVen
        rpt.SetDataSource(Mn)
        Reportes.CrystalReportViewer1.ReportSource = rpt
        'Dim bottomForm As New Form
        'bottomForm = Reportes
        'Reportes.Height = 500
        'Reportes.Width = 1000
        'bottomForm.WindowState = FormWindowState.Normal
        Reportes.Show()
        Blanq()
    End Sub

    Private Sub TxtCli_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCli.TextChanged

    End Sub

    Private Sub TxtMora_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtMora.LostFocus
        If TxtMora.Text = "" Then
            TxtMora.Text = 0
        End If
    End Sub

    Private Sub TxtMora_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtMora.TextChanged

    End Sub
End Class