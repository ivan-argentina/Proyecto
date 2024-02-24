Public Class FrmCarCom
    Dim NumP As Integer
    Dim PvP As Integer
    Dim iva21 As Decimal
    Dim Iva10 As Decimal
    Dim TotalG As Decimal

    Private Sub Blanq()
        TxtArticulo.Clear()
        MskPunit.Clear()
        MskCantidad.Clear()
        MskPtotal.Clear()
        Ptotal = 0
        TxtBarra.Clear()
        IdPr = 0
        IdMr = 0
        IdFm = 0
        Alic = 0
        IdAct = 0
        IdIva = 0
        Iva = 0
        MskUtil.Clear()
        LbFamilia.Text = "Familia"
        TxtArticulo.Focus()
    End Sub
    Private Sub Blanquear()
        TxtPro.Clear()
        TxtPro.Focus()
        TxTDirecion.Clear()
        TxTDirecion.Enabled = False
        Txtciudad.Clear()
        Txtciudad.Enabled = False
        TxtCuit.Clear()
        TxtCuit.Enabled = False
        TxtCiva.Clear()
        TxtCiva.Enabled = False
        TxtPv.Clear()
        TxtPv.Enabled = False
        TxtTtotal.Clear()
        TxtNumFac.Clear()
        TxtNumFac.Enabled = False
        MiClase.eliminaactualizaregistra("delete from tivacom")
        MiClase.eliminaactualizaregistra("delete from totalic where pc=" & Pc & " ")
        MiClase.cargardatagriview(DtgIva, "select alic,neto,iva,total,idpc,linea from tivacom where idpc = " & Pc & "")
        MiClase.eliminaactualizaregistra("delete from t_detalfacp where pc=" & Pc & "")
        MiClase.cargardatagriview(DtgArt, "select articulo,punit,cantidad,ptotal,linea,barra,idpr,idmr,idfm,alic,idact,pc from t_detalFacp where pc=" & Pc & "")

        DtgIva.Enabled = False
        DtcFecha.Enabled = False
        RdContado.Enabled = False
        RdtCta.Enabled = False
        CmbComp.Text = "Factura"
        GroupBox6.Visible = False
        Iva10 = 0
        iva21 = 0

    End Sub

    Private Sub Fnum()
        'Formateo el Numero de Comprobante
        If TxtNumFac.Text = "" Then
            TxtNumFac.Text = "0"
        End If
        Num = TxtNumFac.Text
        NumP = TxtNumFac.Text
        'Num = NumFac
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
        'formateo el numero de pv
        If TxtPv.Text = "" Then
            TxtPv.Text = "0"
        End If
        Pv = TxtPv.Text
        PvP = TxtPv.Text
        If Pv < 10 Then
            Lpv = "000" + Pv
        ElseIf Pv >= 10 And Pv < 100 Then
            Lpv = "00" + Pv
        ElseIf Pv >= 100 And Pv < 1000 Then
            Lpv = "0" + Pv
        ElseIf Pv >= 1000 And Pv < 10000 Then
            Lpv = Pv
        End If
        TxtPv.Text = Lpv
        TxtNumFac.Text = Lnum
        Clave = Lpv + "-" + Lnum
    End Sub

    Private Sub FrmCarCom_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")
        MiClase.eliminaactualizaregistra("delete from tivacom")
        MiClase.eliminaactualizaregistra("delete from t_detalfacp where pc=" & Pc & "")
        MiClase.eliminaactualizaregistra("delete from totalic where pc=" & Pc & " ")
        Linea = 1
        CmbComp.Text = "Factura"
    End Sub

    Private Sub TxtPro_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtPro.DoubleClick
        Blanquear()
    End Sub

    Private Sub TxtPro_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtPro.GotFocus
        TxtPro.SelectionStart = 0
        TxtPro.SelectionLength = TxtPro.Text.Length
    End Sub

    Private Sub TxtPro_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPro.KeyDown
        If e.KeyCode = Keys.Return Then
            If IsNumeric(TxtPro.Text) Then
                misdatos = MiClase.traedataset("select id,proveedor,direccion from proveedor where id=" & TxtPro.Text & "")
                Dim totclF As Integer = misdatos.Tables(0).Rows.Count
                If totclF = 0 Then
                    Mensaje = MsgBox("Este Proveedor No Existe", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Cliente Inexistente!!!")
                    If Mensaje = MsgBoxResult.Ok Then
                        TxtPro.Focus()
                    End If
                Else
                    misdatos = MiClase.traedataset("select proveedor.id,proveedor,direccion,ciudad,cuit,c_iva,idciu,idciva,email,telefono,cel,email from proveedor inner join ciudad on proveedor.idciu=ciudad.id inner join c_de_iva on proveedor.idciva = c_de_iva.id where proveedor.id = " & TxtPro.Text & " ")
                    Id = misdatos.Tables(0).Rows(0).Item(0)
                    TxtPro.Text = Trim(misdatos.Tables(0).Rows(0).Item(1))
                    TxTDirecion.Text = misdatos.Tables(0).Rows(0).Item(2)
                    Txtciudad.Text = Trim(misdatos.Tables(0).Rows(0).Item(3))
                    TxtCuit.Text = Trim(misdatos.Tables(0).Rows(0).Item(4))
                    TxtCiva.Text = Trim(misdatos.Tables(0).Rows(0).Item(5))
                    IdCiva = misdatos.Tables(0).Rows(0).Item(7)
                    Grupo.Enabled = True
                    GroupBox3.Enabled = True
                    TxtPv.Enabled = True
                    TxtPv.Focus()
                    'TxtArticulo.Focus()
                End If
            Else
                EsPr = "3"
                BPro = TxtPro.Text
                FrmBpr.Show()
            End If
        End If
    End Sub

    Private Sub TxtPro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPro.TextChanged

    End Sub

    Private Sub TxtPv_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtPv.GotFocus
        TxtNumFac.Enabled = True
        DtcFecha.Enabled = True
        RdContado.Enabled = True
        RdtCta.Enabled = True
    End Sub

    Private Sub TxtPv_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPv.KeyDown
        If e.KeyCode = Keys.Return Then
            TxtNumFac.Focus()
        End If
    End Sub

    Private Sub TxtPv_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPv.TextChanged

    End Sub

    Private Sub TxtNumFac_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtNumFac.KeyDown
        If e.KeyCode = Keys.Return Then
            Try
                misdatos = MiClase.traedataset("select numero,pv,idpr from faccompras where numero=" & TxtNumFac.Text & "and pv=" & TxtPv.Text & " and idpr=" & Id & "")
                Stock = misdatos.Tables(0).Rows(0).Item(0)
                MsgBox("Esta Factura ya Esta Cargada")
            Catch ex As Exception
                DtcFecha.Focus()
            End Try

        End If
    End Sub

    Private Sub TxtNumFac_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtNumFac.LostFocus
        Fnum()
    End Sub

    Private Sub TxtNumFac_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNumFac.TextChanged

    End Sub

    Private Sub DtcFecha_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DtcFecha.KeyDown
        If e.KeyCode = Keys.Return Then
            RdtCta.Focus()
        End If
    End Sub

    Private Sub DtcFecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DtcFecha.ValueChanged

    End Sub

    Private Sub RdtCta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdtCta.CheckedChanged

    End Sub

    Private Sub RdtCta_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles RdtCta.KeyDown
        If e.KeyCode = Keys.Return Then
            GroupBox8.Enabled = True
            TxtArticulo.Focus()
        End If
    End Sub

    Private Sub RdContado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdContado.CheckedChanged

    End Sub

    Private Sub RdContado_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles RdContado.KeyDown
        If e.KeyCode = Keys.Return Then
            GroupBox8.Enabled = True
            TxtArticulo.Focus()
        End If
    End Sub

    Private Sub TxtArticulo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtArticulo.GotFocus
        TxtArticulo.SelectionStart = 0
        TxtArticulo.SelectionLength = TxtArticulo.Text.Length
    End Sub

    Private Sub TxtArticulo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtArticulo.KeyDown
        If e.KeyCode = Keys.Return Then
            If IsNumeric(TxtArticulo.Text) Then
                Barra = TxtArticulo.Text
                TxtBarra.Text = Barra
                Largo = Len(Barra)
                Primero = Mid(Barra, 1, 1)
                If Largo = 13 And Primero = 2 Then
                    BarId = Mid(Barra, 3, 4)
                    Entero = Mid(Barra, 7, 4)
                    Decim = Mid(Barra, 11, 3)
                    Tot = FormatNumber(Entero + "." + Decim)
                Else
                    BarId = Barra
                End If
                Dim dsdataset As New DataSet
                dsdataset = MiClase.traedataset("select barra from articulos where barra=" & BarId & "")
                Dim totalregistros As Integer = dsdataset.Tables(0).Rows.Count
                If totalregistros = 0 Then
                    MsgBox("Este codigo de barra no existe, Debes agregarlo a la base de datos", MsgBoxStyle.Critical)

                Else
                    Dim PuntB As Decimal
                    TxtArticulo.Focus()
                    misdatos = MiClase.traedataset("select articulos.barra,articulo,pcosto,idpr,idfm,idmr,idact,alic,idiv,abu,familia,utilidad from articulos inner join familias on articulos.idfm=familias.id where barra=" & BarId & "")
                    TxtArticulo.Text = Trim(misdatos.Tables(0).Rows(0).Item(1))
                    MskPunit.Text = FormatNumber(misdatos.Tables(0).Rows(0).Item(2))
                    IdPr = FormatNumber(misdatos.Tables(0).Rows(0).Item(3))
                    IdMr = FormatNumber(misdatos.Tables(0).Rows(0).Item(4))
                    IdFm = FormatNumber(misdatos.Tables(0).Rows(0).Item(5))
                    IdAct = FormatNumber(misdatos.Tables(0).Rows(0).Item(6))
                    Alic1 = FormatNumber(misdatos.Tables(0).Rows(0).Item(7))
                    IdIva = FormatNumber(misdatos.Tables(0).Rows(0).Item(8))
                    AbUn = Trim(misdatos.Tables(0).Rows(0).Item(9))
                    LbFamilia.Text = Trim(misdatos.Tables(0).Rows(0).Item(10))
                    MskUtil.Text = FormatNumber(misdatos.Tables(0).Rows(0).Item(11), 2)
                    MskPtotal.Enabled = True
                    MskCantidad.Enabled = True
                    MskPunit.Enabled = True
                    MskPunit.Focus()

                    If MskCantidad.Text = "" Then
                        MskCantidad.Text = 1
                    End If
                    If Largo = 13 And Primero = 2 Then
                        Cantidad = FormatNumber(Tot / PuntB, 3)
                        TxtTtotal.Text = Tot
                        Ptotal = Tot
                        MskCantidad.Text = Cantidad

                    Else
                        MskCantidad.Text = 1
                        Cantidad = MskCantidad.Text
                        Tot = Punit1 * MskCantidad.Text
                        MskPtotal.Text = Tot
                        Ptotal = Tot

                    End If

                End If
            Else
                'cargo la busqueda de articulos
                EsAr = "2"
                Bart = TxtArticulo.Text
                FrmBarticulos.Show()
            End If

        ElseIf e.KeyCode = Keys.F10 Then
            GroupBox6.Visible = True
            CmdCerrar.Focus()
        End If
    End Sub

    Private Sub TxtArticulo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtArticulo.TextChanged

    End Sub

    Private Sub MskPunit_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MskPunit.GotFocus
        MskPunit.SelectionStart = 0
        MskPunit.SelectionLength = MskPunit.Text.Length
    End Sub

    Private Sub MskPunit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MskPunit.KeyDown
        If e.KeyCode = Keys.Return Then
            MskCantidad.Focus()
        End If
    End Sub

    Private Sub MskPunit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MskPunit.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = False
        End If
    End Sub

    Private Sub MskPunit_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MskPunit.LostFocus
        If MskPunit.Text = "" Then
            MskPunit.Text = 0
        End If
        Punit1 = MskPunit.Text
    End Sub

    Private Sub MskPunit_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles MskPunit.MaskInputRejected

    End Sub

    Private Sub MskCantidad_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MskCantidad.GotFocus
        MskCantidad.SelectionStart = 0
        MskCantidad.SelectionLength = MskCantidad.Text.Length
    End Sub

    Private Sub MskCantidad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MskCantidad.KeyDown
        If e.KeyCode = Keys.Return Then
            MskPtotal.Focus()
        End If
    End Sub

    Private Sub MskCantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MskCantidad.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = False
        End If
    End Sub

    Private Sub MskCantidad_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MskCantidad.LostFocus
        If MskCantidad.Text = "" Then
            MskCantidad.Text = 0
        End If
        Cantidad = MskCantidad.Text
        Ptotal = FormatNumber(Punit1 * Cantidad, 2)
        MskPtotal.Text = Str(Ptotal)
    End Sub

    Private Sub MskCantidad_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles MskCantidad.MaskInputRejected

    End Sub

    Private Sub MskPtotal_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MskPtotal.GotFocus
        MskPtotal.SelectionStart = 0
        MskPtotal.SelectionLength = MskPtotal.Text.Length
    End Sub

    Private Sub MskPtotal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MskPtotal.KeyDown
        If e.KeyCode = Keys.Return Then
            If TxtBarra.Text = "" Then
                TxtBarra.Text = 0
            End If
            If IdPr = 0 Then
                IdPr = 1
            End If
            If IdMr = 0 Then
                IdMr = 1
            End If
            If IdFm = 0 Then
                IdFm = 1
            End If
            If IdAct = 0 Then
                IdAct = 1
            End If
            If Alic = 0 Then
                Alic = 21
            End If

            'AlicDisc = Alic / 100 + 1
            'Net = FormatNumber(Ptotal / AlicDisc)
            Iva = FormatNumber(Ptotal * Alic / 100, 2)
            ' Net = Ptotal - Iva
            MiClase.eliminaactualizaregistra("insert into t_detalfacp values(" & Linea & "," & Pc & ",'" & TxtArticulo.Text & "'," & Str(Punit1) & "," & Str(Cantidad) & "," & Str(Ptotal) & "," & Str(TxtBarra.Text) & "," & IdPr & "," & IdMr & "," & IdFm & "," & Alic & "," & IdAct & "," & IdIva & "," & Iva & "," & MskUtil.Text & ")")
            Linea = Linea + 1
            DtgArt.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
            MiClase.cargardatagriview(DtgArt, "select articulo,punit,cantidad,ptotal,linea,barra,idpr,idmr,idfm,alic,idact,pc,utilidad from t_detalFacp where pc=" & Pc & " order by linea ")
            DtgArt.Font = New Font("Arial ", 14, FontStyle.Regular)
            DtgArt.ColumnHeadersVisible = False
            DtgArt.AllowUserToAddRows = False
            DtgArt.Columns(0).Width = 400
            DtgArt.Columns(1).DefaultCellStyle.Format = "##,##0.00"
            DtgArt.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            DtgArt.Columns(2).DefaultCellStyle.Format = "##,##0.00"
            DtgArt.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            DtgArt.Columns(3).DefaultCellStyle.Format = "##,##0.00"
            DtgArt.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            DtgArt.Columns(4).Visible = False
            DtgArt.Columns(5).Visible = False
            DtgArt.Columns(6).Visible = False
            DtgArt.Columns(7).Visible = False
            DtgArt.Columns(8).Visible = False
            DtgArt.Columns(9).Visible = False
            DtgArt.Columns(10).Visible = False
            DtgArt.Columns(11).Visible = False
            DtgArt.Columns(12).Visible = False
            misdatos = MiClase.traedataset("select sum(ptotal) from t_detalfacp where pc=" & Pc & "")
            Total = FormatNumber(misdatos.Tables(0).Rows(0).Item(0), 2)
            TxtTtotal.Text = FormatNumber(misdatos.Tables(0).Rows(0).Item(0), 2)
            Blanq()

        End If
    End Sub

    Private Sub MskPtotal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MskPtotal.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = False
        End If
    End Sub

    Private Sub MskPtotal_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles MskPtotal.MaskInputRejected

    End Sub

    Private Sub CmdCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCerrar.Click
        Try

            If RdContado.Checked = True Then
                EsVenta = 0
                Cventa = "Contado"
            ElseIf RdtCta.Checked = True Then
                EsVenta = 1
                Cventa = "Cta.Cte"
            End If
            'Cargo  los Items
            Dim filas As Integer = DtgArt.Rows.Count
            Dim contador As Integer = 0
            For i As Integer = 0 To filas - 1
                If IsDBNull(Convert.ToString(DtgArt(0, i).Value)) Then
                Else
                    Articulo = Convert.ToString(DtgArt(0, i).Value)
                End If

                If IsDBNull(Convert.ToString(DtgArt(1, i).Value)) Then
                Else
                    Punt = Convert.ToDecimal(DtgArt(1, i).Value)
                End If

                If IsDBNull(Convert.ToString(DtgArt(2, i).Value)) Then
                Else
                    Cantidad = Convert.ToDecimal(DtgArt(2, i).Value)
                End If

                If IsDBNull(Convert.ToString(DtgArt(3, i).Value)) Then
                Else
                    Ptotal = Convert.ToDecimal(DtgArt(3, i).Value)
                End If
                If IsDBNull(Convert.ToString(DtgArt(4, i).Value)) Then
                Else
                    LinCom = (DtgArt(4, i).Value)
                End If
                If IsDBNull(Convert.ToString(DtgArt(5, i).Value)) Then
                Else
                    BarFac = Convert.ToDecimal(DtgArt(5, i).Value)
                End If
                If IsDBNull(Convert.ToString(DtgArt(6, i).Value)) Then
                Else
                    IdPr = Convert.ToDecimal(DtgArt(6, i).Value)
                End If
                If IsDBNull(Convert.ToString(DtgArt(7, i).Value)) Then
                Else
                    IdMr = Convert.ToDecimal(DtgArt(7, i).Value)
                End If
                If IsDBNull(Convert.ToString(DtgArt(8, i).Value)) Then
                Else
                    IdFm = Convert.ToDecimal(DtgArt(8, i).Value)
                End If
                If IsDBNull(Convert.ToString(DtgArt(9, i).Value)) Then
                Else
                    Alic = Convert.ToDecimal(DtgArt(9, i).Value)
                End If
                If IsDBNull(Convert.ToString(DtgArt(10, i).Value)) Then
                Else
                    IdAct = Convert.ToString(DtgArt(10, i).Value)
                End If
                If IsDBNull(Convert.ToDecimal(DtgArt(12, i).Value)) Then
                Else
                    Util = Convert.ToDecimal(DtgArt(12, i).Value)
                End If
                If CmbComp.Text = "Factura" Then
                    If IdCiva = 1 Then
                        IdTp = 1
                    Else
                        IdTp = 6
                    End If
                ElseIf CmbComp.Text = "Nota de Credito" Then
                    If IdCiva = 1 Then
                        IdTp = 8
                    Else
                        IdTp = 6
                    End If

                End If

                Clave = TxtPv.Text + "-" + TxtNumFac.Text
                'Grabo el detalle de factura
                MiClase.eliminaactualizaregistra("insert into detal_facp values(" & Num & "," & IdTp & " ," & LinCom & "," & Pv & ",'" & DtcFecha.Text & "', " & _
                "" & BarFac & ",'" & Articulo & "'," & Str(Punt) & "," & Str(Cantidad) & "," & Str(Ptotal) & "," & IdFm & "," & IdMr & "," & Id & ", " & _
               "" & Str(Alic) & "," & EsVenta & ",'" & Cventa & "','" & Clave & "'," & IdCu & "," & BlNg & ")")


                'Actualizo el precio en la tabla articulos
                misdatos = MiClase.traedataset("select articulos.barra,stock,pcosto,articulo,pneto,iva,pfinal,familia,utilidad,idiv from articulos inner join familias on articulos.idfm=familias.id  where barra=" & BarFac & "")
                Barra = misdatos.Tables(0).Rows(0).Item(0)
                Stock = misdatos.Tables(0).Rows(0).Item(1)
                Pcosto = misdatos.Tables(0).Rows(0).Item(2)
                Articulo = Trim(misdatos.Tables(0).Rows(0).Item(3))
                'Util = misdatos.Tables(0).Rows(0).Item(8)
                IdIv = misdatos.Tables(0).Rows(0).Item(9)
                misdatos = MiClase.traedataset("select id,alic from alic_iva where id=" & IdIv & "")
                Alic = misdatos.Tables(0).Rows(0).Item(1)
                misdatos = MiClase.traedataset("select punit,cantidad,barra,linea from t_detalfacp where barra=" & BarFac & "and linea=" & LinCom & "")
                ' Actualizo Stock
                PCosCom = misdatos.Tables(0).Rows(0).Item(0)
                Cantidad = misdatos.Tables(0).Rows(0).Item(1)
                Cantidad = Cantidad + Stock

                'Actualizo precio
                If Pcosto <> PCosCom Then
                    UtilNet = (PCosCom * Util / 100)
                    UtilTot = FormatNumber(UtilNet + PCosCom, 2)
                    IvTot = FormatNumber(UtilTot * Alic / 100, 2)
                    Total = FormatNumber(UtilTot + IvTot, 2)
                End If
                FcD = Date.Today
                FcD = Format(Date.Today, "dd/MM/yy")
                MiClase.eliminaactualizaregistra("update articulos set pcosto =" & PCosCom & ",pneto=" & UtilTot & ",iva=" & IvTot & ",pfinal=" & Total & ",stock=" & Cantidad & ",fstock = '" & FcD & "' where barra=" & BarFac & "")

                'Actualico la Tabla Etiqueta
                misdatos = MiClase.traedataset("select isnull(count(codigo),0) from etiquetas where codigo=" & BarFac & " ")
                Br = misdatos.Tables(0).Rows(0).Item(0)
                If Br = 0 Then
                    MiClase.eliminaactualizaregistra("insert into etiquetas values(" & BarFac & ",'" & Articulo & "'," & Total & ")")
                Else
                    MiClase.eliminaactualizaregistra("Update etiquetas set precio=" & Total & " where codigo= " & BarFac & "")
                End If
                Barra = 0
                Stock = 0
                Pcosto = 0
                Articulo = ""
                Util = 0
                IdIv = 0
                Alic = 0
                PCosCom = 0
                Cantidad = 0


            Next
            If IdCiva = 1 Then
                IdTp = 1
            Else
                IdTp = 6
            End If

            TotalG = TxtTtotal.Text
            MiClase.eliminaactualizaregistra("insert into faccompras  values(" & NumP & "," & PvP & " ," & Id & "," & IdTp & ",'" & Clave & "', " & _
                "'" & DtcFecha.Text & "','" & TxtPro.Text & "','" & TxTDirecion.Text & "','" & TxtCuit.Text & "','" & TxtCiva.Text & "', " & _
                "" & Str(TotalG) & "," & 0 & "," & EsVenta & ",'" & Cventa & "'," & BlNg & ")")
            'Grabo para la Cta.Cte
            If RdtCta.Checked = True Then
                ' FecVen = Fech.Date.Date.AddDays(30)
                Fech = DtcFecha.Value
                IdEnc = 1
                FcH = DtcFecha.Value
                FcH = Format(DtcFecha.Value, "dd/MM/yy")
                MiClase.eliminaactualizaregistra("insert into ctactep values(" & NumP & "," & IdTp & ", " & _
                 "" & Id & "," & IdEnc & ",'" & FcH & "','" & FcH & "'," & Str(TotalG) & "," & Str(Entrega) & "," & Str(TotalG) & "," & BlNg & ",'" & Clave & "')")
            End If
            Blanquear()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub CmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdBorrar.Click
        MiClase.cargardatagriview(Dtget, "select codigo,articulo,precio from etiquetas")
        Dim Mn As New DtcArticulo
        'traigo los articulos para imprimir etiquetas
        Dim Fila2 As DtcArticulo.ArticulosRow
        Dtget.AllowUserToAddRows = False
        For i As Integer = 0 To Dtget.RowCount - 1
            Fila2 = Mn.Articulos.NewArticulosRow
            Fila2.Codigo = Dtget(0, i).Value
            Fila2.Articulo = Dtget(1, i).Value
            Fila2.Precio = Dtget(2, i).Value
            Mn.Articulos.AddArticulosRow(Fila2)
        Next
        Dim rpt As New CryEtiquetas
        rpt.SetDataSource(Mn)
        Reportes.CrystalReportViewer1.ReportSource = rpt
        Reportes.Show()
    End Sub

    Private Sub CmdVaciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdVaciar.Click
        MiClase.eliminaactualizaregistra("delete from etiquetas")
    End Sub
End Class