Public Class FrmBeq

    Private Sub TxtEquipo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtEquipo.TextChanged
        If TxtEquipo.Text = "" Then
            DtgEqu.DataSource = Nothing
        End If
        If IsNumeric(TxtEquipo.Text) Then
            MiClase.cargardatagriview(DtgEqu, "select maquina from maquinas where id Like '" & TxtEquipo.Text & "%'")
            DtgEqu.Font = New Font("Arial ", 12, FontStyle.Regular)
            DtgEqu.Columns(0).HeaderText = "Equipo"
            DtgEqu.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            DtgEqu.AllowUserToAddRows = True
        Else
            MiClase.cargardatagriview(DtgEqu, "select maquina from maquinas where maquina Like '" & TxtEquipo.Text & "%'")
            DtgEqu.Font = New Font("Arial ", 12, FontStyle.Regular)
            DtgEqu.Columns(0).HeaderText = "Equipo"
            DtgEqu.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            DtgEqu.AllowUserToAddRows = True
        End If
    End Sub

    Private Sub DtgEqu_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DtgEqu.CellClick
        If IsDBNull(Me.DtgEqu.Rows(e.RowIndex).Cells(0).Value()) Then
        Else
            FrmOrep.TxtEquipo.Text = Me.DtgEqu.Rows(e.RowIndex).Cells(0).Value()
            FrmOrep.TxtMarca.Focus()
            Me.Close()
        End If
    End Sub

 
    Private Sub DtgEqu_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DtgEqu.CellEndEdit
        Try
            currentrow = CType((e.RowIndex.ToString()), Integer) ''Obtiene la fila actual

            'If DtgEqu.Columns(e.ColumnIndex).Name = "Equipo" Then
            'Si en la columna de la celda familia se hace clic y escribe algo y esta vacio, al terminar la edicion se registrara este dato
            If IsDBNull(Convert.ToString(DtgEqu(0, currentrow).Value)) Then

            Else
                MiClase.eliminaactualizaregistra("insert into maquinas values('" & Convert.ToString(DtgEqu(0, currentrow).Value) & "')")
                Dim dts As New DataSet
                dts = MiClase.traedataset("Select maquina from maquinas where maquina='" & Convert.ToString(DtgEqu(1, currentrow).Value & "'"))
                DtgEqu(0, currentrow).Value = dts.Tables(0).Rows(0).Item(0).ToString
            End If

            'End If
        Catch ex As Exception

        End Try
    End Sub

    
End Class