Public Class FrmBarticulos
    Dim MiClase As New Conexion
    Dim chk As New DataGridViewCheckBoxColumn()
    Dim Estado As String

    Private Sub DtgArt_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DtgArt.CellDoubleClick
        Try
            If EsAr = "0" Then
                FrmInArticulos.TxtBarra.Text = Me.DtgArt.Rows(e.RowIndex).Cells(0).Value()
                FrmInArticulos.Txtarticulo.Text = Me.DtgArt.Rows(e.RowIndex).Cells(1).Value()
                FrmInArticulos.MskTotal.Text = FormatNumber(Me.DtgArt.Rows(e.RowIndex).Cells(2).Value(), 2)
                FrmInArticulos.MskStock.Text = Me.DtgArt.Rows(e.RowIndex).Cells(3).Value()
                FrmInArticulos.TxtProv.Text = Me.DtgArt.Rows(e.RowIndex).Cells(4).Value()
                FrmInArticulos.TxtFam.Text = Me.DtgArt.Rows(e.RowIndex).Cells(5).Value()
                FrmInArticulos.TxtMar.Text = Me.DtgArt.Rows(e.RowIndex).Cells(6).Value()
                FrmInArticulos.TxtCodPr.Text = Me.DtgArt.Rows(e.RowIndex).Cells(7).Value()
                FrmInArticulos.TxtCfam.Text = Me.DtgArt.Rows(e.RowIndex).Cells(8).Value()
                FrmInArticulos.TxtCMar.Text = Me.DtgArt.Rows(e.RowIndex).Cells(9).Value()
                ' FrmInArticulos.MskFecha.Text = Me.DtgArt.Rows(e.RowIndex).Cells(10).Value()
                FrmInArticulos.MskStMin.Text = Me.DtgArt.Rows(e.RowIndex).Cells(11).Value()
                FrmInArticulos.MskPcos.Text = FormatNumber(Me.DtgArt.Rows(e.RowIndex).Cells(12).Value(), 2)
                FrmInArticulos.MskUtil.Text = FormatNumber(Me.DtgArt.Rows(e.RowIndex).Cells(13).Value(), 2)
                FrmInArticulos.MskPneto.Text = FormatNumber(Me.DtgArt.Rows(e.RowIndex).Cells(15).Value(), 2)
                FrmInArticulos.MskIva.Text = FormatNumber(Me.DtgArt.Rows(e.RowIndex).Cells(16).Value(), 2)
                IdIva = FormatNumber(Me.DtgArt.Rows(e.RowIndex).Cells(17).Value(), 2)
                IdAct = Me.DtgArt.Rows(e.RowIndex).Cells(18).Value()
                FrmInArticulos.TxtActividad.Text = Me.DtgArt.Rows(e.RowIndex).Cells(19).Value()
                FrmInArticulos.CmbPes.Text = Me.DtgArt.Rows(e.RowIndex).Cells(20).Value()
                FrmInArticulos.MskPcosD.Text = FormatNumber(Me.DtgArt.Rows(e.RowIndex).Cells(21).Value(), 2)
                FrmInArticulos.CmbUnidad.Text = Me.DtgArt.Rows(e.RowIndex).Cells(22).Value()
                AbUn = Me.DtgArt.Rows(e.RowIndex).Cells(23).Value()
                FrmInArticulos.TxtOb.Text = Me.DtgArt.Rows(e.RowIndex).Cells(24).Value()
                FrmInArticulos.CmdModificar.Enabled = True
                FrmInArticulos.CmdEliminar.Enabled = True
                FrmInArticulos.Txtarticulo.Enabled = True
                FrmInArticulos.CmdBuscar.Enabled = False
                FrmInArticulos.Txtarticulo.Focus()
                Me.Close()
            ElseIf EsAr = "1" Then
                FrmFacturaa.Txtbarra.Text = Me.DtgArt.Rows(e.RowIndex).Cells(0).Value()
                FrmFacturaa.TxtArticulo.Text = Me.DtgArt.Rows(e.RowIndex).Cells(1).Value()
                'FrmFactura.MskPunit.Text = FormatNumber(Me.DtgArt.Rows(e.RowIndex).Cells(2).Value(), 2)
                Punit1 = FormatNumber(Me.DtgArt.Rows(e.RowIndex).Cells(2).Value(), 2)
                FrmFacturaa.MskPnt.Text = Str(Punit1)
                IdPr = Me.DtgArt.Rows(e.RowIndex).Cells(7).Value()
                IdFm = Me.DtgArt.Rows(e.RowIndex).Cells(8).Value()
                IdMr = Me.DtgArt.Rows(e.RowIndex).Cells(9).Value()
                Alic = FormatNumber(Me.DtgArt.Rows(e.RowIndex).Cells(14).Value())
                Alic1 = FormatNumber(Me.DtgArt.Rows(e.RowIndex).Cells(14).Value())
                IdIva = FormatNumber(Me.DtgArt.Rows(e.RowIndex).Cells(17).Value(), 2)
                IdAct = Me.DtgArt.Rows(e.RowIndex).Cells(18).Value()
                FrmInArticulos.TxtActividad.Text = Me.DtgArt.Rows(e.RowIndex).Cells(19).Value()
                AbUn = Me.DtgArt.Rows(e.RowIndex).Cells(23).Value()
                FrmFacturaa.MskCantidad.Enabled = True
                FrmFacturaa.MskPnt.Enabled = True
                FrmFacturaa.MskPtotal.Enabled = True
                FrmFacturaa.MskCantidad.Text = "1.00"
                FrmFacturaa.MskCantidad.Focus()
                Me.Close()
            ElseIf EsAr = "2" Then
                Barra = Me.DtgArt.Rows(e.RowIndex).Cells(0).Value()
                FrmCarCom.TxtArticulo.Text = Me.DtgArt.Rows(e.RowIndex).Cells(1).Value()
                Punit1 = FormatNumber(Me.DtgArt.Rows(e.RowIndex).Cells(12).Value(), 2)
                FrmCarCom.MskPunit.Text = FormatNumber(Me.DtgArt.Rows(e.RowIndex).Cells(12).Value(), 2)
                IdPr = Me.DtgArt.Rows(e.RowIndex).Cells(7).Value()
                IdFm = Me.DtgArt.Rows(e.RowIndex).Cells(8).Value()
                IdMr = Me.DtgArt.Rows(e.RowIndex).Cells(9).Value()
                Alic = FormatNumber(Me.DtgArt.Rows(e.RowIndex).Cells(14).Value())
                'Punt = Punit1 * Alic / 100
                'FrmCarCom.MskPunit.Text = Punit1 + Punt
                Alic1 = FormatNumber(Me.DtgArt.Rows(e.RowIndex).Cells(14).Value())
                IdIva = FormatNumber(Me.DtgArt.Rows(e.RowIndex).Cells(17).Value(), 2)
                IdAct = Me.DtgArt.Rows(e.RowIndex).Cells(18).Value()
                AbUn = FormatNumber(Me.DtgArt.Rows(e.RowIndex).Cells(23).Value(), 2)
                FrmCarCom.MskUtil.Text = FormatNumber(Me.DtgArt.Rows(e.RowIndex).Cells(13).Value(), 2)
                FrmCarCom.LbFamilia.Text = Trim(Me.DtgArt.Rows(e.RowIndex).Cells(5).Value())
                FrmCarCom.MskCantidad.Enabled = True
                FrmCarCom.MskPunit.Enabled = True
                FrmCarCom.MskPtotal.Enabled = True
                FrmCarCom.MskCantidad.Text = "1.00"
                FrmCarCom.MskPunit.Focus()
                Me.Close()
            ElseIf EsAr = "4" Then
                BarId = Me.DtgArt.Rows(e.RowIndex).Cells(0).Value()
                FrmInCar.TxtArticulo.Text = Me.DtgArt.Rows(e.RowIndex).Cells(1).Value()
                FrmInCar.MskPunit.Text = FormatNumber(Me.DtgArt.Rows(e.RowIndex).Cells(12).Value(), 2)
                IdPr = Me.DtgArt.Rows(e.RowIndex).Cells(7).Value()
                IdFm = Me.DtgArt.Rows(e.RowIndex).Cells(8).Value()
                IdMr = Me.DtgArt.Rows(e.RowIndex).Cells(9).Value()
                Alic = FormatNumber(Me.DtgArt.Rows(e.RowIndex).Cells(14).Value())
                Alic1 = FormatNumber(Me.DtgArt.Rows(e.RowIndex).Cells(14).Value())
                IdIva = FormatNumber(Me.DtgArt.Rows(e.RowIndex).Cells(17).Value(), 2)
                IdAct = Me.DtgArt.Rows(e.RowIndex).Cells(18).Value()
                AbUn = Me.DtgArt.Rows(e.RowIndex).Cells(23).Value()
                FrmInCar.MskCantidad.Text = "1.00"
                FrmInCar.MskCantidad.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DtgArt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DtgArt.KeyDown
        Try
            Dim fila As Integer
            fila = DtgArt.CurrentRow.Index
            If e.KeyCode = Keys.Enter Then
                If EsAr = "0" Then
                    FrmInArticulos.TxtBarra.Text = DtgArt.Item(0, fila).Value
                    FrmInArticulos.Txtarticulo.Text = Trim(DtgArt.Item(1, fila).Value)
                    FrmInArticulos.MskTotal.Text = FormatNumber(DtgArt.Item(2, fila).Value)
                    FrmInArticulos.MskStock.Text = DtgArt.Item(3, fila).Value
                    FrmInArticulos.TxtProv.Text = DtgArt.Item(4, fila).Value
                    FrmInArticulos.TxtFam.Text = DtgArt.Item(5, fila).Value
                    FrmInArticulos.TxtMar.Text = DtgArt.Item(6, fila).Value
                    FrmInArticulos.TxtCodPr.Text = DtgArt.Item(7, fila).Value
                    FrmInArticulos.TxtCfam.Text = DtgArt.Item(8, fila).Value
                    FrmInArticulos.TxtCMar.Text = DtgArt.Item(9, fila).Value
                    ' FrmInArticulos.MskFecha.Text = DtgArt.Item(10, fila).Value
                    'Fc = FrmInArticulos.MskFecha.Text
                    'Fc = Format(Date.Today, "dd/MM/yy")
                    'FrmInArticulos.MskFecha.Text = Fc
                    FrmInArticulos.MskStMin.Text = DtgArt.Item(11, fila).Value
                    Pcos = FormatNumber(DtgArt.Item(12, fila).Value)
                    FrmInArticulos.MskPcos.Text = Pcos
                    FrmInArticulos.MskUtil.Text = FormatNumber(DtgArt.Item(13, fila).Value)
                    CmIva = FormatNumber(DtgArt.Item(14, fila).Value)
                    FrmInArticulos.MskPneto.Text = FormatNumber(DtgArt.Item(15, fila).Value)
                    FrmInArticulos.MskIva.Text = FormatNumber(DtgArt.Item(16, fila).Value)
                    IdIva = FormatNumber(DtgArt.Item(17, fila).Value)
                    MiClase.cargar_Combo(FrmInArticulos.CmbIva, "select alic,id,ord from alic_iva where id=" & IdIva & "")
                    IdAct = DtgArt.Item(18, fila).Value
                    FrmInArticulos.TxtActividad.Text = DtgArt.Item(19, fila).Value
                    FrmInArticulos.CmbPes.Text = DtgArt.Item(20, fila).Value
                    FrmInArticulos.MskPcosD.Text = FormatNumber(DtgArt.Item(21, fila).Value, 2)
                    FrmInArticulos.CmbUnidad.Text = DtgArt.Item(22, fila).Value
                    AbUn = DtgArt.Item(23, fila).Value
                    FrmInArticulos.TxtOb.Text = DtgArt.Item(24, fila).Value
                    FrmInArticulos.CmdModificar.Enabled = True
                    FrmInArticulos.CmdEliminar.Enabled = True
                    FrmInArticulos.Txtarticulo.Enabled = True
                    FrmInArticulos.CmdBuscar.Enabled = False
                    FrmInArticulos.Txtarticulo.Focus()
                    Me.Close()
                ElseIf EsAr = "1" Then
                    FrmFacturaa.TxtBarra.Text = DtgArt.Item(0, fila).Value
                    FrmFacturaa.TxtArticulo.Text = Trim(DtgArt.Item(1, fila).Value)
                    FrmFacturaa.MskPnt.Text = FormatNumber(DtgArt.Item(2, fila).Value, 3)
                    Punit1 = FormatNumber(DtgArt.Item(2, fila).Value, 3)
                    FrmFacturaa.MskPnt.Text = FormatNumber(DtgArt.Item(2, fila).Value)
                    'FrmFacturaa.MskPunit.Text = Str(Punit1)
                    IdPr = DtgArt.Item(7, fila).Value
                    IdFm = DtgArt.Item(8, fila).Value
                    IdMr = DtgArt.Item(9, fila).Value
                    Alic = FormatNumber(DtgArt.Item(14, fila).Value)
                    Alic1 = FormatNumber(DtgArt.Item(14, fila).Value)
                    IdIva = FormatNumber(DtgArt.Item(17, fila).Value)
                    IdAct = DtgArt.Item(18, fila).Value
                    AbUn = DtgArt.Item(23, fila).Value
                    FrmFacturaa.MskCantidad.Enabled = True
                    FrmFacturaa.MskPnt.Enabled = True
                    FrmFacturaa.MskDescuento.Enabled = True
                    FrmFacturaa.MskPtotal.Enabled = True
                    FrmFacturaa.MskCantidad.Text = "1.00"
                    FrmFacturaa.MskPnt.Text = FormatNumber(DtgArt.Item(2, fila).Value)
                    FrmFacturaa.MskCantidad.Focus()
                    Me.Close()
                ElseIf EsAr = "2" Then
                    FrmCarCom.TxtBarra.Text = DtgArt.Item(0, fila).Value
                    'Barra = DtgArt.Item(0, fila).Value
                    FrmCarCom.TxtArticulo.Text = DtgArt.Item(1, fila).Value
                    ' FrmCarCom.MskPunit.Text = FormatNumber(DtgArt.Item(12, fila).Value)
                    Pcosto = FormatNumber(DtgArt.Item(12, fila).Value)
                    Punit1 = FormatNumber(DtgArt.Item(12, fila).Value)
                    FrmCarCom.MskPunit.Text = Str(Punit1)
                    IdPr = DtgArt.Item(7, fila).Value
                    IdFm = DtgArt.Item(8, fila).Value
                    IdMr = DtgArt.Item(9, fila).Value
                    FrmCarCom.MskUtil.Text = FormatNumber(DtgArt.Item(13, fila).Value, 2)
                    FrmCarCom.LbFamilia.Text = Trim(DtgArt.Item(5, fila).Value)
                    Alic = FormatNumber(DtgArt.Item(14, fila).Value)
                    Alic1 = FormatNumber(DtgArt.Item(14, fila).Value)
                    IdIva = FormatNumber(DtgArt.Item(17, fila).Value)
                    IdAct = DtgArt.Item(18, fila).Value
                    AbUn = DtgArt.Item(23, fila).Value
                    'Punt = Punit1 * Alic / 100
                    'FrmCarCom.MskPunit.Text = Punit1 + Punt
                    FrmCarCom.MskCantidad.Enabled = True
                    FrmCarCom.MskPunit.Enabled = True
                    FrmCarCom.MskPtotal.Enabled = True
                    FrmCarCom.MskCantidad.Text = "1.00"
                    FrmCarCom.MskPunit.Focus()
                    Me.Close()
                ElseIf EsAr = "3" Then
                    FrmCprecio.TxtBarr.Text = Trim(DtgArt.Item(0, fila).Value)
                    FrmCprecio.TxtBar1.Text = Trim(DtgArt.Item(1, fila).Value)
                    EsBr = 1
                    Me.Close()
                ElseIf EsAr = "4" Then
                    BarId = Trim(DtgArt.Item(0, fila).Value)
                    FrmInCar.TxtArticulo.Text = Trim(DtgArt.Item(1, fila).Value)
                    FrmInCar.MskPunit.Text = FormatNumber(DtgArt.Item(12, fila).Value, 2)
                    IdPr = DtgArt.Item(7, fila).Value
                    IdFm = DtgArt.Item(8, fila).Value
                    IdMr = DtgArt.Item(9, fila).Value
                    Alic = FormatNumber(DtgArt.Item(14, fila).Value)
                    Alic1 = FormatNumber(DtgArt.Item(14, fila).Value)
                    IdIva = FormatNumber(DtgArt.Item(17, fila).Value)
                    IdAct = DtgArt.Item(18, fila).Value
                    AbUn = DtgArt.Item(23, fila).Value
                    FrmInCar.MskPtotal.Enabled = True
                    FrmInCar.MskPunit.Enabled = True
                    FrmInCar.MskCantidad.Enabled = True
                    FrmInCar.MskCantidad.Text = "1.00"
                    FrmInCar.MskCantidad.Focus()
                    Me.Close()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

   
   
    Private Sub FrmBarticulos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MiClase.cargardatagriview(DtgArt, "select articulos.barra,articulo,pfinal,stock,proveedor,familia,marca,idpr,idfm,idmr,fstock,smin,pcosto,utilidad,alic,pneto,iva,idiv,idact,actividad,moneda,pcostod,unidad,abu,ob from articulos inner join proveedor on articulos.idpr=proveedor.id inner join familias on articulos.idfm=familias.id inner join marcas on articulos.idmr=marcas.id inner join actividad on articulos.idact=actividad.id where articulos.articulo like '%" & Bart & "%'order by articulo asc")
        DtgArt.Font = New Font("Arial ", 12, FontStyle.Regular)
        DtgArt.Columns(2).HeaderText = "Precio"
        DtgArt.Columns(2).DefaultCellStyle.Format = "##,##0.00"
        DtgArt.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DtgArt.Columns(7).Visible = False
        DtgArt.Columns(8).Visible = False
        DtgArt.Columns(9).Visible = False
        DtgArt.Columns(10).HeaderText = "Fecha"
        DtgArt.Columns(11).Visible = False
        'DtgArt.Columns(12).Visible = False
        DtgArt.Columns(13).Visible = False
        DtgArt.Columns(14).Visible = False
        DtgArt.Columns(15).Visible = False
        DtgArt.Columns(16).Visible = False
        DtgArt.Columns(17).Visible = False
        DtgArt.Columns(18).Visible = False
        DtgArt.Columns(19).Visible = False
        DtgArt.Columns(20).Visible = False
        DtgArt.Columns(21).Visible = False
        DtgArt.Columns(22).Visible = False
        DtgArt.Columns(23).Visible = False
        DtgArt.AllowUserToAddRows = False
    End Sub

    Private Sub DtgArt_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DtgArt.CellContentClick

    End Sub
End Class