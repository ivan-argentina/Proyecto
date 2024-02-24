Public Class FrmBcu

    Private Sub TxtCuenta_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCuenta.KeyDown

    End Sub

    Private Sub TxtCuenta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCuenta.TextChanged
        If TxtCuenta.Text = "" Then
            DtgCuenta.DataSource = Nothing
        End If
        If IsNumeric(TxtCuenta.Text) Then
            MiClase.cargardatagriview(DtgCuenta, "select id,cuenta from cuenta where id Like '" & TxtCuenta.Text & "%'")
            DtgCuenta.Font = New Font("Arial ", 12, FontStyle.Regular)
            DtgCuenta.Columns(0).HeaderText = "Codigo"
            DtgCuenta.Columns(1).HeaderText = "Cuenta"
            DtgCuenta.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            ' DtgCuenta.AllowUserToAddRows = False
        Else
            MiClase.cargardatagriview(DtgCuenta, "select id,cuenta from cuenta where cuenta Like '" & TxtCuenta.Text & "%'")
            DtgCuenta.Font = New Font("Arial ", 12, FontStyle.Regular)
            DtgCuenta.Columns(0).HeaderText = "Codigo"
            DtgCuenta.Columns(1).HeaderText = "Cuenta"
            DtgCuenta.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            'DtgCuenta.AllowUserToAddRows = False
        End If
    End Sub

    Private Sub DtgCuenta_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DtgCuenta.CellContentClick

    End Sub

    Private Sub DtgCuenta_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DtgCuenta.CellDoubleClick
        IdCu = Me.DtgCuenta.Rows(e.RowIndex).Cells(0).Value()
        ' FrmCarCom.TxtCuenta.Text = Me.DtgCuenta.Rows(e.RowIndex).Cells(1).Value()
        FrmCarCom.RdContado.Focus()
        Me.Close()
    End Sub

    Private Sub DtgCuenta_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DtgCuenta.CellEndEdit
        Try
            currentrow = CType((e.RowIndex.ToString()), Integer) ''Obtiene la fila actual
            If DtgCuenta.Columns(e.ColumnIndex).Name = "cuenta" Then
                'Si en la columna de la celda familia se hace clic y escribe algo y esta vacio, al terminar la edicion se registrara este dato
                If IsDBNull(Convert.ToString(DtgCuenta(1, currentrow).Value)) Then

                Else
                    MiClase.eliminaactualizaregistra("insert into cuenta values('" & Convert.ToString(DtgCuenta(1, currentrow).Value) & "')")
                    Dim dts As New DataSet
                    dts = MiClase.traedataset("Select id from cuenta where cuenta='" & Convert.ToString(DtgCuenta(1, currentrow).Value & "'"))
                    DtgCuenta(0, currentrow).Value = dts.Tables(0).Rows(0).Item(0).ToString
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub



    Private Sub DtgCuenta_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DtgCuenta.KeyDown
        If e.KeyCode = Keys.Return Then
            Dim fila As Integer
            fila = DtgCuenta.CurrentRow.Index
            If e.KeyCode = Keys.Enter Then
                IdCu = DtgCuenta.Item(0, fila).Value
                '  FrmCarCom.TxtCuenta.Text = DtgCuenta.Item(1, fila).Value
                FrmCarCom.RdtCta.Focus()
                Me.Close()
            End If
        End If
    End Sub
End Class