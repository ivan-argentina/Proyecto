Public Class FrmInCar
    Private Sub Guardar()
        If Punit1 = 0 Or MskCantidad.Text = 0 Or Ptotal = 0 Then
            Mensaje = MsgBox("No Puede haber Importes en 0", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Fala Informacion!!!")
        Else
        End If
        Descu = 0
        If BarId = "" Then
            BarId = 0
        End If
        If Alic1 = 0 Then
            Alic1 = 21
        End If
        If AbUn = "" Then
            AbUn = 0
        End If
        If IdAct = 0 Then
            IdAct = 1
        End If
        misdatos = MiClase.traedataset("select isnull(max(linea),0) from t_detalfac where idpc=" & Pc & "")
        Linea = misdatos.Tables(0).Rows(0).Item(0) + 1
        MiClase.eliminaactualizaregistra("insert into t_detalfac values(" & Linea & "," & Pc & ",'" & TxtArticulo.Text & "'," & Str(Punit1) & "," & Str(Cantidad) & "," & Str(Descu) & "," & Str(Ptotal) & "," & Str(PtotalM) & "," & BarId & "," & IdPr & "," & IdMr & "," & IdFm & "," & BlNg & "," & Str(Alic1) & "," & IdIva & ",'" & AbUn & "'," & IdAct & ")")
        Linea = Linea + 1
        Refrescar()
        TxtArticulo.Clear()
        MskCantidad.Text = "1.00"
        MskPunit.Clear()
        MskPtotal.Clear()
    End Sub

    Private Sub Refrescar()
        DtgDet.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        MiClase.cargardatagriview(DtgDet, "select articulo,cantidad,punit,descu,ptotal,linea,barra,idpr,idmr,idfm,alic,idiv,ptotalm,idact,unidad,idpc from t_detalFac where idpc=" & Pc & " order by linea desc")
        DtgDet.Font = New Font("Arial ", 12, FontStyle.Regular)
        DtgDet.ColumnHeadersVisible = False
        DtgDet.AllowUserToAddRows = False
        'Dtgart.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DtgDet.Columns(0).Width = 280
        'Dtgart.Columns(1).DefaultCellStyle.Format = "##,##0.00"
        DtgDet.Columns(1).DefaultCellStyle.Format = "##,###0.000"
        DtgDet.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        DtgDet.Columns(2).DefaultCellStyle.Format = "##,##0.00"
        DtgDet.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        'DtgDet.Columns(3).DefaultCellStyle.Format = "##,##0.00"
        'DtgDet.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        DtgDet.Columns(4).DefaultCellStyle.Format = "##,##0.00"
        DtgDet.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        DtgDet.Columns(12).DefaultCellStyle.Format = "##,##0.00"
        DtgDet.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        DtgDet.Columns(3).Visible = False
        DtgDet.Columns(4).Visible = False
        DtgDet.Columns(5).Visible = False
        DtgDet.Columns(6).Visible = False
        DtgDet.Columns(7).Visible = False
        DtgDet.Columns(8).Visible = False
        DtgDet.Columns(9).Visible = False
        DtgDet.Columns(10).Visible = False
        DtgDet.Columns(11).Visible = False
        DtgDet.Columns(13).Visible = False
        DtgDet.Columns(14).Visible = False
        DtgDet.Columns(15).Visible = False
        misdatos = MiClase.traedataset("select sum(ptotal),sum(ptotalm) from t_detalfac where idpc=" & Pc & "")
        txtTotal.Text = FormatNumber(misdatos.Tables(0).Rows(0).Item(1), 2)
        TxTtotal.Text = FormatNumber(misdatos.Tables(0).Rows(0).Item(0), 2)
        TxtArticulo.Text = ""
        MskCantidad.Text = ""
        MskPunit.Text = ""
        MskPtotal.Text = ""
        MskPunit.Enabled = False
        MskCantidad.Enabled = False
        MskPtotal.Enabled = False
        PtotalM = 0
        TxtArticulo.Focus()
    End Sub
    Private Sub MskPunit_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MskPunit.GotFocus
        MskPunit.SelectionStart = 0
        MskPunit.SelectionLength = MskPunit.Text.Length
    End Sub

    Private Sub MskPunit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MskPunit.KeyDown
        If e.KeyCode = Keys.Return Then
            Punit1 = MskPunit.Text
            Cantidad = MskCantidad.Text
            Ptotal = FormatNumber(MskPunit.Text * Cantidad, 2)
            PtotalM = FormatNumber(MskPunit.Text * Cantidad, 2)
            MskPtotal.Text = PtotalM
            MskPtotal.Focus()
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

    Private Sub TxtArticulo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtArticulo.GotFocus
        TxtArticulo.SelectionStart = 0
        TxtArticulo.SelectionLength = TxtArticulo.Text.Length
    End Sub

    Private Sub MskCantidad_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MskCantidad.GotFocus
        MskCantidad.SelectionStart = 0
        MskCantidad.SelectionLength = MskCantidad.Text.Length
    End Sub

    Private Sub MskCantidad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MskCantidad.KeyDown
        If e.KeyCode = Keys.Return Then
            MskPunit.Focus()
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
        Try
            Cantidad = MskCantidad.Text
            Ptotal = FormatNumber(Punit1 * Cantidad, 2)
            MskPtotal.Text = Str(Ptotal)
        Catch ex As Exception
            Mensaje = MsgBox("Se Han Ingresados Caracteres Erroneos: ", MsgBoxStyle.OkOnly, "Informacion Fallida!!!")
            If Mensaje = MsgBoxResult.Ok Then
                MskPunit.Focus()
                MskPtotal.Text = 0
            End If
        End Try
    End Sub

    Private Sub MskCantidad_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles MskCantidad.MaskInputRejected

    End Sub

    Private Sub MskPtotal_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MskPtotal.GotFocus
        MskPtotal.SelectionStart = 0
        MskPtotal.SelectionLength = MskPtotal.Text.Length
    End Sub

    Private Sub MskPtotal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MskPtotal.KeyDown
        If e.KeyCode = Keys.Return Then
            Guardar()
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

    Private Sub TxtArticulo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtArticulo.KeyDown
        If e.KeyCode = Keys.F10 Then
            GrpCerrar.Visible = True
            CmdGuardar.Focus()
        ElseIf e.KeyCode = Keys.Return Then
            If IsNumeric(TxtArticulo.Text) Then
                Barra = TxtArticulo.Text
                Dim dsdataset As New DataSet
                dsdataset = MiClase.traedataset("select barra from articulos where barra=" & Barra & "")
                Dim totalregistros As Integer = dsdataset.Tables(0).Rows.Count
                If totalregistros = 0 Then
                    MsgBox("Este codigo de barra no existe, Debes agregarlo a la base de datos", MsgBoxStyle.Critical)

                Else
                    TxtArticulo.Focus()
                    misdatos = MiClase.traedataset("select barra,articulo,pfinal,idpr,idfm,idmr,idact,alic,idiv,abu from articulos where barra=" & Barra & "")
                    BarId = misdatos.Tables(0).Rows(0).Item(0)
                    TxtArticulo.Text = Trim(misdatos.Tables(0).Rows(0).Item(1))
                    MskPunit.Text = FormatNumber(misdatos.Tables(0).Rows(0).Item(2))
                    IdPr = misdatos.Tables(0).Rows(0).Item(3)
                    IdFm = misdatos.Tables(0).Rows(0).Item(4)
                    IdMr = misdatos.Tables(0).Rows(0).Item(5)
                    IdAct = misdatos.Tables(0).Rows(0).Item(6)
                    IdIva = misdatos.Tables(0).Rows(0).Item(8)
                    AbUn = misdatos.Tables(0).Rows(0).Item(9)
                    MskCantidad.Enabled = True
                    MskPunit.Enabled = True
                    MskPtotal.Enabled = True
                    If MskCantidad.Text = "" Then
                        MskCantidad.Text = 1
                    End If
                    MskCantidad.Focus()
                End If
            Else
                'cargo la busqueda de articulos
                EsAr = "4"
                Bart = TxtArticulo.Text
                FrmBarticulos.Show()
            End If
        End If

        

    End Sub

    Private Sub TxtArticulo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtArticulo.TextChanged

    End Sub

    Private Sub MskPunit_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MskPunit.LostFocus

    End Sub

    Private Sub MskPunit_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles MskPunit.MaskInputRejected

    End Sub

    Private Sub FrmInCar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MiClase.eliminaactualizaregistra("delete from t_detalfac where idpc=" & Pc & "")
    End Sub

    Private Sub CmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdGuardar.Click
        'select articulo,cantidad,punit,descu,ptotal,linea,barra,idpr,idmr,idfm,alic,idiv,ptotalm,idact,unidad,idpc from t_detalFac where idpc=" & Pc & " order by linea desc")
        'Cargo  los Items
        Dim FcCar As String
        FcCar = DtcFecha.Value
        misdatos = MiClase.traedataset("select isnull(max(numcom),0) from carne")
        NumCom = misdatos.Tables(0).Rows(0).Item(0) + 1
        Dim filas As Integer = DtgDet.Rows.Count
        Dim contador As Integer = 0
        For i As Integer = 0 To filas - 1    
            Articulo = Trim(Convert.ToString(DtgDet(0, i).Value))
            Cantidad = Convert.ToDecimal(DtgDet(1, i).Value)
            Punit1 = Convert.ToDecimal(DtgDet(2, i).Value)
            Ptotal = Convert.ToDecimal(DtgDet(4, i).Value)
            LinCom = Convert.ToDecimal(DtgDet(5, i).Value)
            BarFac = Convert.ToDecimal(DtgDet(6, i).Value)
            IdFm = Convert.ToDecimal(DtgDet(9, i).Value)
            MiClase.eliminaactualizaregistra("insert into carne values(" & NumCom & "," & LinCom & " ,'" & FcCar & "'," & BarFac & ",'" & Articulo & "', " & _
                   "" & Punit1 & ",'" & Cantidad & "'," & Ptotal & "," & IdFm & ")")
        Next
        DtcFecha.Value = Date.Today
        MiClase.eliminaactualizaregistra("delete from t_detalfac where idpc=" & Pc & "")
        DtgDet.DataSource = Nothing
        GrpCerrar.Visible = False
        TxTtotal.Clear()
        TxtArticulo.Focus()

    End Sub
End Class