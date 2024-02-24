Public Class FrmBMar
    Dim MiClase As New Conexion

    Private Sub TxtMar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtMar.KeyDown
        If e.KeyCode = Keys.Return Then
            If TxtMar.Text = "" Then
                DtgMar.DataSource = Nothing
            End If
            If IsNumeric(TxtMar.Text) Then
                MiClase.cargardatagriview(DtgMar, "select id,marca from marcas where id Like '" & TxtMar.Text & "%'")
                DtgMar.Font = New Font("Arial ", 12, FontStyle.Regular)
                DtgMar.Columns(1).HeaderText = "Marca"
                DtgMar.Columns(0).Width = 50
                DtgMar.Columns(1).Width = 300
            Else
                MiClase.cargardatagriview(DtgMar, "select id,marca from marcas where marca Like '" & TxtMar.Text & "%'")
                DtgMar.Font = New Font("Arial ", 12, FontStyle.Regular)
                DtgMar.Columns(1).HeaderText = "Marca"
                DtgMar.Columns(0).Width = 50
                DtgMar.Columns(1).Width = 300
            End If
        End If
    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtMar.TextChanged
        
    End Sub

    Private Sub DtgMar_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DtgMar.CellClick
        
    End Sub

    Private Sub DtgMar_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DtgMar.CellContentClick
       
    End Sub

    Private Sub DtgMar_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DtgMar.CellDoubleClick
        If IsDBNull(Me.DtgMar.Rows(e.RowIndex).Cells(0).Value()) Then
        Else
            FrmInArticulos.TxtCMar.Text = Me.DtgMar.Rows(e.RowIndex).Cells(0).Value()
        End If
        If IsDBNull(Me.DtgMar.Rows(e.RowIndex).Cells(1).Value()) Then
        Else
            If EsMar = "0" Then
                IdMr = Me.DtgMar.Rows(e.RowIndex).Cells(0).Value()
                FrmInArticulos.TxtMar.Text = Me.DtgMar.Rows(e.RowIndex).Cells(1).Value()
                FrmInArticulos.TxtCMar.Focus()
                Me.Close()
            ElseIf EsMar = "1" Then
                IdMr = Me.DtgMar.Rows(e.RowIndex).Cells(0).Value()
                FrmCprecio.TxtProv.Text = Me.DtgMar.Rows(e.RowIndex).Cells(1).Value()
                FrmCprecio.TxtProv.Focus()
                Me.Close()
            ElseIf EsMar = "2" Then
                IdMr = Me.DtgMar.Rows(e.RowIndex).Cells(0).Value()
                FrmOrep.TxtMarca.Text = Me.DtgMar.Rows(e.RowIndex).Cells(1).Value()
                FrmOrep.TxtNumero.Focus()
                Me.Close()
            ElseIf EsMar = "3" Then
                IdMr = Me.DtgMar.Rows(e.RowIndex).Cells(0).Value()
                Form2.TxtProv.Text = Me.DtgMar.Rows(e.RowIndex).Cells(1).Value()
                Form2.DtgCli.Focus()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub DtgMar_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DtgMar.CellEndEdit
        currentrow = CType((e.RowIndex.ToString()), Integer) ''Obtiene la fila actual

        If DtgMar.Columns(e.ColumnIndex).Name = "marca" Then
            'Si en la columna de la celda marca se hace clic y escribe algo y esta vacio, al terminar la edicion se registrara este dato
            If IsDBNull(Convert.ToString(DtgMar(1, currentrow).Value)) Then
                'MiClase.eliminaactualizaregistra("insert into familias values('" & Convert.ToString(DtgFam(1, currentrow).Value) & "')")

            Else
                MiClase.eliminaactualizaregistra("insert into marcas values('" & Convert.ToString(DtgMar(1, currentrow).Value) & "')")
                Dim dts As New DataSet
                dts = MiClase.traedataset("Select id from marcas where marca='" & Convert.ToString(DtgMar(1, currentrow).Value & "'"))
                DtgMar(0, currentrow).Value = dts.Tables(0).Rows(0).Item(0).ToString
            End If


        End If

    End Sub

    Private Sub DtgMar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DtgMar.KeyDown
        Try
            Dim fila As Integer
            fila = DtgMar.CurrentRow.Index
            If e.KeyCode = Keys.Enter Then
                If EsMar = "0" Then
                    IdMr = Me.DtgMar.Item(0, fila).Value
                    FrmInArticulos.TxtCMar.Text = IdMr
                    FrmInArticulos.TxtMar.Text = DtgMar.Item(1, fila).Value
                    FrmInArticulos.TxtCMar.Focus()
                    Me.Close()
                ElseIf EsMar = "1" Then
                    IdMr = Me.DtgMar.Item(0, fila).Value
                    FrmCprecio.TxtProv.Text = Me.DtgMar.Item(1, fila).Value
                    FrmCprecio.TxtProv.Focus()
                    Me.Close()
                ElseIf EsMar = "2" Then
                    IdMr = Me.DtgMar.Item(0, fila).Value
                    FrmOrep.TxtMarca.Text = Me.DtgMar.Item(1, fila).Value
                    FrmOrep.TxtNumero.Focus()
                ElseIf EsMar = "3" Then
                    IdMr = Me.DtgMar.Item(0, fila).Value
                    Form2.TxtProv.Text = Me.DtgMar.Item(1, fila).Value
                    Form2.DtgCli.Focus()
                    Me.Close()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

End Class