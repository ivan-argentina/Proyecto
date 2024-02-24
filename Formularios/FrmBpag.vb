Public Class FrmBpag

    Private Sub TxtPago_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'If e.KeyCode = Keys.Return Then
        'If TxtPago.Text = "" Then
        ' DtgPag.DataSource = Nothing
        ' End If
        'If IsNumeric(TxtPago.Text) Then
        ' MiClase.cargardatagriview(DtgPag, "select id,tarjeta from tarjetas where id Like '" & TxtPago.Text & "%'")
        ' DtgPag.Font = New Font("Arial ", 12, FontStyle.Regular)
        ' DtgPag.Columns(1).HeaderText = "Tarjeta"
        ' DtgPag.Columns(0).Width = 60
        ' DtgPag.Columns(1).Width = 230
        ' DtgPago.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        ' Else
        'MiClase.cargardatagriview(DtgPag, "select id,tarjeta from tarjetas where tarjeta Like '" & TxtPago.Text & "%'")
        'DtgPag.Font = New Font("Arial ", 12, FontStyle.Regular)
        'DtgPag.Columns(1).HeaderText = "Tarjeta"
        'DtgPag.Columns(0).Width = 60
        'DtgPag.Columns(1).Width = 230
        'DtgPago.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells


    End Sub

    Private Sub DtgPag_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DtgPag.CellDoubleClick
        If IsDBNull(Me.DtgPag.Rows(e.RowIndex).Cells(0).Value()) Then
        Else
            If EsPago = 5 Then
                FrmFacturaa.TxtPag.Text = Trim(Me.DtgPag.Rows(e.RowIndex).Cells(1).Value())
                FrmFacturaa.txtNumero.Enabled = True
                FrmFacturaa.txtNumero.Focus()
            ElseIf EsPago = 2 Then
                FrmPago.TxtComp.Text = Me.DtgPag.Rows(e.RowIndex).Cells(1).Value()
                FrmPago.TxtNum.Enabled = True
                FrmPago.TxtNum.Focus()
            ElseIf EsPago = 6 Then
                FrmPagoP.TxtComp.Text = Trim(Me.DtgPag.Rows(e.RowIndex).Cells(1).Value())
                FrmPagoP.TxtNum.Enabled = True
                FrmPagoP.TxtNum.Focus()
            ElseIf EsPago = 7 Then
                FrmBCh.TxtComp.Text = Me.DtgPag.Rows(e.RowIndex).Cells(1).Value()
            End If
            Me.Close()
        End If
    End Sub

    Private Sub DtgPag_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DtgPag.CellEndEdit
        If EsPago = 0 Then
            currentrow = CType((e.RowIndex.ToString()), Integer) ''Obtiene la fila actual

            'If DtgPag.Columns(e.ColumnIndex).Name = "Tarjeta" Then
            If DtgPag.Columns(e.ColumnIndex).Index = 1 Then
                'Si en la columna de la celda marca se hace clic y escribe algo y esta vacio, al terminar la edicion se registrara este dato
                If IsDBNull(Convert.ToString(DtgPag(1, currentrow).Value)) Then
                    'MiClase.eliminaactualizaregistra("insert into familias values('" & Convert.ToString(DtgFam(1, currentrow).Value) & "')")

                Else
                    MiClase.eliminaactualizaregistra("insert into tarjetas values('" & Convert.ToString(DtgPag(1, currentrow).Value) & "')")
                    Dim dts As New DataSet
                    dts = MiClase.traedataset("Select id from tarjetas where tarjeta='" & Convert.ToString(DtgPag(1, currentrow).Value & "'"))
                    DtgPag(0, currentrow).Value = dts.Tables(0).Rows(0).Item(0).ToString
                End If


            End If
        ElseIf EsPago = 1 Then
            currentrow = CType((e.RowIndex.ToString()), Integer) ''Obtiene la fila actual

            'If DtgPag.Columns(e.ColumnIndex).Name = "Tarjeta" Then
            If DtgPag.Columns(e.ColumnIndex).Index = 1 Then
                'Si en la columna de la celda marca se hace clic y escribe algo y esta vacio, al terminar la edicion se registrara este dato
                If IsDBNull(Convert.ToString(DtgPag(1, currentrow).Value)) Then
                    'MiClase.eliminaactualizaregistra("insert into familias values('" & Convert.ToString(DtgFam(1, currentrow).Value) & "')")

                Else
                    MiClase.eliminaactualizaregistra("insert into cheques values('" & Convert.ToString(DtgPag(1, currentrow).Value) & "')")
                    Dim dts As New DataSet
                    dts = MiClase.traedataset("Select id from cheques where cheque='" & Convert.ToString(DtgPag(1, currentrow).Value & "'"))
                    DtgPag(0, currentrow).Value = dts.Tables(0).Rows(0).Item(0).ToString
                End If


            End If
        ElseIf EsPago = 2 Then
            currentrow = CType((e.RowIndex.ToString()), Integer) ''Obtiene la fila actual

            'If DtgPag.Columns(e.ColumnIndex).Name = "Tarjeta" Then
            If DtgPag.Columns(e.ColumnIndex).Index = 1 Then
                'Si en la columna de la celda marca se hace clic y escribe algo y esta vacio, al terminar la edicion se registrara este dato
                If IsDBNull(Convert.ToString(DtgPag(1, currentrow).Value)) Then
                    'MiClase.eliminaactualizaregistra("insert into familias values('" & Convert.ToString(DtgFam(1, currentrow).Value) & "')")

                Else
                    MiClase.eliminaactualizaregistra("insert into cheques values('" & Convert.ToString(DtgPag(1, currentrow).Value) & "')")
                    Dim dts As New DataSet
                    dts = MiClase.traedataset("Select id from cheques where cheque='" & Convert.ToString(DtgPag(1, currentrow).Value & "'"))
                    DtgPag(0, currentrow).Value = dts.Tables(0).Rows(0).Item(0).ToString
                End If


            End If
        End If
    End Sub

    Private Sub DtgPag_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DtgPag.KeyDown
        Dim fila As Integer
        fila = DtgPag.CurrentRow.Index
        If e.KeyCode = Keys.Enter Then
            If EsPago = 5 Then
                FrmFacturaa.TxtPag.Text = Trim(DtgPag.Item(1, fila).Value)
                FrmFacturaa.txtNumero.Enabled = True
                FrmFacturaa.txtNumero.Enabled = True
                FrmFacturaa.txtNumero.Focus()
            ElseIf EsPago = 0 Then

                FrmPago.TxtComp.Text = Trim(DtgPag.Item(1, fila).Value)
                FrmPago.TxtNum.Enabled = True
                FrmPago.TxtNum.Focus()
            End If
            Me.Close()
        End If
        'End If
    End Sub

    Private Sub DtgPag_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DtgPag.CellContentClick

    End Sub

    Private Sub FrmBpag_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MiClase.cargardatagriview(DtgPag, "select id,tarjeta from tarjetas where tarjeta Like '" & Btar & "%'")
        DtgPag.Font = New Font("Arial ", 12, FontStyle.Regular)
        DtgPag.Columns(1).HeaderText = "Tarjeta"
        DtgPag.Columns(0).Width = 60
        DtgPag.Columns(1).Width = 230
        ' DtgPago.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
    End Sub
End Class