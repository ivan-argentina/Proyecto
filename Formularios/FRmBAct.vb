Public Class FRmBAct

    Private Sub TxtBact_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtBact.KeyDown
        If e.KeyCode = Keys.Return Then
            Try
                If TxtBact.Text = "" Then
                    DtgAct.DataSource = Nothing
                End If
                If IsNumeric(TxtBact.Text) Then
                    MiClase.cargardatagriview(DtgAct, "select id,actividad from actividad where id Like '" & TxtBact.Text & "%'")
                    DtgAct.Font = New Font("Arial ", 12, FontStyle.Regular)
                    DtgAct.Columns(0).HeaderText = "Codigo"
                    DtgAct.Columns(1).HeaderText = "Actividad"
                    DtgAct.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                Else
                    MiClase.cargardatagriview(DtgAct, "select id,actividad from actividad where actividad Like '" & TxtBact.Text & "%'")
                    DtgAct.Font = New Font("Arial ", 12, FontStyle.Regular)
                    DtgAct.Columns(0).HeaderText = "Codigo"
                    DtgAct.Columns(1).HeaderText = "Actividad"
                    DtgAct.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub
    Private Sub TxtBact_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBact.TextChanged

    End Sub

    Private Sub DtgAct_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DtgAct.CellClick

    End Sub

    Private Sub DtgAct_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DtgAct.CellContentClick

    End Sub

    Private Sub DtgAct_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DtgAct.CellDoubleClick
        Try
            IdAct = Me.DtgAct.Rows(e.RowIndex).Cells(0).Value()
            FrmInArticulos.TxtActividad.Text = Me.DtgAct.Rows(e.RowIndex).Cells(1).Value()
            FrmInArticulos.CmbUnidad.Focus()
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub


    Private Sub DtgAct_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DtgAct.CellEndEdit
        Try
            currentrow = CType((e.RowIndex.ToString()), Integer) ''Obtiene la fila actual
            If DtgAct.Columns(e.ColumnIndex).Name = "actividad" Then
                'Si en la columna de la celda marca se hace clic y escribe algo y esta vacio, al terminar la edicion se registrara este dato
                If IsDBNull(Convert.ToString(DtgAct(1, currentrow).Value)) Then
                Else
                    MiClase.eliminaactualizaregistra("insert into actividad values('" & Convert.ToString(DtgAct(1, currentrow).Value) & "')")
                    Dim dts As New DataSet
                    dts = MiClase.traedataset("Select id from actividad where actividad='" & Convert.ToString(DtgAct(1, currentrow).Value & "'"))
                    DtgAct(0, currentrow).Value = dts.Tables(0).Rows(0).Item(0).ToString
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DtgAct_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DtgAct.KeyDown
        Try
            Dim fila As Integer
            fila = DtgAct.CurrentRow.Index
            If e.KeyData = Keys.Enter Then
                IdAct = Me.DtgAct.Item(0, fila).Value
                FrmInArticulos.TxtActividad.Text = DtgAct.Item(1, fila).Value
                FrmInArticulos.CmbUnidad.Focus()
                Me.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class