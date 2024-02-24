Public Class FrmBprov

    Private Sub TxtProv_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtProv.TextChanged
        If TxtProv.Text = "" Then
            Dtgprov.DataSource = Nothing
        End If
        If IsNumeric(TxtProv.Text) Then
            MiClase.cargardatagriview(Dtgprov, "select id,provincia from provincias where id Like '" & TxtProv.Text & "%'")
            Dtgprov.Font = New Font("Arial ", 12, FontStyle.Regular)
            Dtgprov.Columns(0).HeaderText = "Codigo"
            Dtgprov.Columns(1).HeaderText = "C.de Iva"
            Dtgprov.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Dtgprov.AllowUserToAddRows = False
        Else
            MiClase.cargardatagriview(Dtgprov, "select id,provincia from provincias where provincia Like '" & TxtProv.Text & "%'")
            Dtgprov.Font = New Font("Arial ", 12, FontStyle.Regular)
            Dtgprov.Columns(0).HeaderText = "Codigo"
            Dtgprov.Columns(1).HeaderText = "C.de Iva"
            Dtgprov.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Dtgprov.AllowUserToAddRows = False
        End If
    End Sub

  

    Private Sub Dtgprov_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dtgprov.CellContentDoubleClick
        If EsPrv = 0 Then
            IdPrv = Me.Dtgprov.Rows(e.RowIndex).Cells(0).Value()
            FrmInCl.TxtProv.Text = Me.Dtgprov.Rows(e.RowIndex).Cells(1).Value()
            FrmInCl.TxtEmail.Focus()
            Me.Close()
        ElseIf EsPrv = 1 Then
            IdPrv = Me.Dtgprov.Rows(e.RowIndex).Cells(0).Value()
            FrmFacturaa.TxtProv.Text = Me.Dtgprov.Rows(e.RowIndex).Cells(1).Value()
            FrmFacturaa.TxtArticulo.Focus()
            Me.Close()
        End If
    End Sub

    Private Sub Dtgprov_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Dtgprov.KeyDown
        Dim fila As Integer
        fila = Dtgprov.CurrentRow.Index
        If e.KeyCode = Keys.Enter Then
            If EsPrv = 0 Then
                If IsDBNull(Dtgprov.Item(0, fila).Value) Then
                Else
                    FrmInCl.TxtProv.Text = Dtgprov.Item(0, fila).Value
                End If
                IdPrv = Dtgprov.Item(0, fila).Value
                FrmInCl.TxtProv.Text = Dtgprov.Item(1, fila).Value
                FrmInCl.TxtEmail.Focus()
                Me.Close()
            ElseIf EsPrv = 1 Then
                If IsDBNull(Dtgprov.Item(0, fila).Value) Then
                Else
                    FrmFacturaa.TxtProv.Text = Dtgprov.Item(0, fila).Value
                End If
                IdPrv = Dtgprov.Item(0, fila).Value
                FrmFacturaa.TxtProv.Text = Dtgprov.Item(1, fila).Value
                FrmFacturaa.TxtArticulo.Focus()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub Dtgprov_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dtgprov.CellContentClick

    End Sub
End Class