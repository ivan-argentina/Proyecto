Public Class FrmbCiu
    Dim MiClase As New Conexion

    Private Sub TxtCiu_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCiu.KeyDown

    End Sub

    Private Sub TxtCiu_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCiu.TextChanged
        Try
            If TxtCiu.Text = "" Then
                DtgCiu.DataSource = Nothing
            End If
            If IsNumeric(TxtCiu.Text) Then
                MiClase.cargardatagriview(DtgCiu, "select id,ciudad from ciudad where id Like '" & TxtCiu.Text & "%'")
                DtgCiu.Font = New Font("Arial ", 12, FontStyle.Regular)
                DtgCiu.Columns(0).HeaderText = "Codigo"
                DtgCiu.Columns(1).HeaderText = "Ciudad"
                DtgCiu.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                'DtgCiu.Columns(2).HeaderText = "C.Postal"
            Else
                MiClase.cargardatagriview(DtgCiu, "select id,ciudad from ciudad where ciudad Like '" & TxtCiu.Text & "%'")
                DtgCiu.Font = New Font("Arial ", 12, FontStyle.Regular)
                DtgCiu.Columns(0).HeaderText = "Codigo"
                DtgCiu.Columns(1).HeaderText = "Ciudad"
                DtgCiu.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                'DtgCiu.Columns(2).HeaderText = "C.Postal"
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DtgCiu_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DtgCiu.CellEndEdit
        Try
            currentrow = CType((e.RowIndex.ToString()), Integer) ''Obtiene la fila actual
            If DtgCiu.Columns(e.ColumnIndex).Name = "ciudad" Then
                'Si en la columna de la celda familia se hace clic y escribe algo y esta vacio, al terminar la edicion se registrara este dato
                If IsDBNull(Convert.ToString(DtgCiu(1, currentrow).Value)) Then

                Else
                    MiClase.eliminaactualizaregistra("insert into ciudad values('" & Convert.ToString(DtgCiu(1, currentrow).Value) & "')")
                    Dim dts As New DataSet
                    dts = MiClase.traedataset("Select id from ciudad where ciudad='" & Convert.ToString(DtgCiu(1, currentrow).Value & "'"))
                    DtgCiu(0, currentrow).Value = dts.Tables(0).Rows(0).Item(0).ToString
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub DtgCiu_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DtgCiu.CellDoubleClick
        Try
            If IsDBNull(Me.DtgCiu.Rows(e.RowIndex).Cells(0).Value()) Then
            Else
                FrmInProv.TxtCciu.Text = Me.DtgCiu.Rows(e.RowIndex).Cells(0).Value()
            End If
            If IsDBNull(Me.DtgCiu.Rows(e.RowIndex).Cells(1).Value()) Then
            Else
                If EsCiu = 0 Then
                    FrmInProv.TxtCciu.Text = Me.DtgCiu.Rows(e.RowIndex).Cells(0).Value()
                    FrmInProv.TxtCiu.Text = Me.DtgCiu.Rows(e.RowIndex).Cells(1).Value()
                    FrmInProv.TxtEmail.Focus()
                    Me.Close()
                ElseIf EsCiu = 1 Then
                    FrmFacturaa.TxtCiudad.Text = Me.DtgCiu.Rows(e.RowIndex).Cells(1).Value()
                    FrmFacturaa.TxtArticulo.Focus()
                    Me.Close()
                ElseIf EsCiu = 2 Then
                    FrmInCl.TxtCCiu.Text = Me.DtgCiu.Rows(e.RowIndex).Cells(0).Value()
                    FrmInCl.TxtCiudad.Text = Me.DtgCiu.Rows(e.RowIndex).Cells(1).Value()
                    FrmInCl.TxtEmail.Focus()
                    Me.Close()
                ElseIf EsCiu = 3 Then
                    IdCiu = Me.DtgCiu.Rows(e.RowIndex).Cells(0).Value()
                    FrmPagoP.TxtCiu.Text = Trim(Me.DtgCiu.Rows(e.RowIndex).Cells(1).Value())
                    FrmPagoP.TxtCiu.Focus()
                    Me.Close()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub



    Private Sub DtgCiu_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DtgCiu.KeyDown
        Try

            Dim fila As Integer
            fila = DtgCiu.CurrentRow.Index
            If e.KeyCode = Keys.Enter Then
                If IsDBNull(DtgCiu.Item(0, fila).Value) Then
                Else
                    FrmInProv.TxtCciu.Text = DtgCiu.Item(0, fila).Value
                End If
                'If IsDBNull(Me.DtgCiu.Rows(e.RowIndex).Cells(1).Value()) Then
                ' If IsDBNull(DtgCiu.Item(fila, 1).Value) Then
                'Else
                If EsCiu = 0 Then
                    FrmInProv.TxtCciu.Text = DtgCiu.Item(0, fila).Value
                    FrmInProv.TxtCiu.Text = DtgCiu.Item(1, fila).Value
                    FrmInProv.TxtEmail.Focus()
                    Me.Close()
                ElseIf EsCiu = 1 Then
                    FrmFacturaa.TxtCiudad.Text = DtgCiu.Item(1, fila).Value
                    FrmFacturaa.TxtArticulo.Focus()
                    Me.Close()
                ElseIf EsCiu = 2 Then
                    FrmInCl.TxtCCiu.Text = DtgCiu.Item(0, fila).Value
                    FrmInCl.TxtCiudad.Text = DtgCiu.Item(1, fila).Value
                    FrmInCl.TxtCpostal.Focus()
                    Me.Close()
                ElseIf EsCiu = 3 Then
                    IdCiu = DtgCiu.Item(0, fila).Value
                    FrmPagoP.TxtCiu.Text = Trim(DtgCiu.Item(1, fila).Value)
                    FrmPagoP.TxtCiu.Focus()
                    Me.Close()
                End If
            End If
            'End If
        Catch ex As Exception

        End Try
    End Sub

    
End Class