Public Class FrmBfam

    Dim MiClase As New Conexion

    Private Sub TxtFamilia_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtFamilia.KeyDown
        If e.KeyCode = Keys.Return Then
            If TxtFamilia.Text = "" Then
                DtgFam.DataSource = Nothing
            End If
            If IsNumeric(TxtFamilia.Text) Then
                MiClase.cargardatagriview(DtgFam, "select id,familia from familias where id Like '" & TxtFamilia.Text & "%'")
                DtgFam.Font = New Font("Arial ", 12, FontStyle.Regular)
                DtgFam.Columns(1).HeaderText = "Familia"
                DtgFam.Columns(0).Width = 50
                DtgFam.Columns(1).Width = 300
            Else
                MiClase.cargardatagriview(DtgFam, "select id,familia from familias where familia Like '" & TxtFamilia.Text & "%'")
                DtgFam.Font = New Font("Arial ", 12, FontStyle.Regular)
                DtgFam.Columns(1).HeaderText = "Familia"
                DtgFam.Columns(0).Width = 50
                DtgFam.Columns(1).Width = 300
            End If
        End If
    End Sub

    Private Sub TxtFamilia_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtFamilia.TextChanged

    End Sub

    Private Sub DtgFam_CellBorderStyleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DtgFam.CellBorderStyleChanged

    End Sub

    Private Sub DtgFam_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DtgFam.CellClick


    End Sub

    Private Sub DtgFam_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DtgFam.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.Return Then
            Dim fila As Integer
            fila = DtgFam.CurrentRow.Index
            If EsFam = "0" Then
                IdFm = Me.DtgFam.Item(0, fila).Value
                FrmInArticulos.TxtCfam.Text = IdFm
                FrmInArticulos.TxtFam.Text = Me.DtgFam.Item(1, fila).Value
                FrmInArticulos.TxtCfam.Focus()
                Me.Close()
            ElseIf EsFam = "1" Then
                IdFm = Me.DtgFam.Item(0, fila).Value
                FrmInArticulos.TxtCfam.Text = IdFm
                FrmCprecio.TxtProv.Text = Me.DtgFam.Item(1, fila).Value
                FrmCprecio.TxtProv.Focus()
                Me.Close()
            ElseIf EsFam = "2" Then
                IdFm = Me.DtgFam.Item(0, fila).Value
                'Form2..TxtCfam.Text = IdFm
                Form2.TxtProv.Text = Me.DtgFam.Item(1, fila).Value
                Form2.DtgCli.Focus()
                Me.Close()
            End If
        End If

    End Sub

    Private Sub DtgFam_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DtgFam.CellEndEdit
        Try
            currentrow = CType((e.RowIndex.ToString()), Integer) ''Obtiene la fila actual
            If DtgFam.Columns(e.ColumnIndex).Name = "familia" Then
                'Si en la columna de la celda familia se hace clic y escribe algo y esta vacio, al terminar la edicion se registrara este dato
                If IsDBNull(Convert.ToString(DtgFam(1, currentrow).Value)) Then

                Else
                    MiClase.eliminaactualizaregistra("insert into familias values('" & Convert.ToString(DtgFam(1, currentrow).Value) & "'," & 0 & ")")
                    Dim dts As New DataSet
                    dts = MiClase.traedataset("Select id from familias where familia='" & Convert.ToString(DtgFam(1, currentrow).Value & "'"))
                    DtgFam(0, currentrow).Value = dts.Tables(0).Rows(0).Item(0).ToString
                End If


            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FrmBfam_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DtgFam_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DtgFam.CellContentClick

    End Sub

    Private Sub DtgFam_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DtgFam.CellDoubleClick
        If IsDBNull(Me.DtgFam.Rows(e.RowIndex).Cells(0).Value()) Then
        Else
            FrmInArticulos.TxtCfam.Text = Me.DtgFam.Rows(e.RowIndex).Cells(0).Value()
        End If
        If IsDBNull(Me.DtgFam.Rows(e.RowIndex).Cells(1).Value()) Then
        Else
            If EsFam = "0" Then
                IdFm = Me.DtgFam.Rows(e.RowIndex).Cells(0).Value()
                FrmInArticulos.TxtFam.Text = Me.DtgFam.Rows(e.RowIndex).Cells(1).Value()
                FrmInArticulos.TxtCfam.Focus()
                Me.Close()
            ElseIf EsFam = "1" Then
                IdFm = Me.DtgFam.Rows(e.RowIndex).Cells(0).Value()
                FrmCprecio.TxtProv.Text = Me.DtgFam.Rows(e.RowIndex).Cells(1).Value()
                FrmCprecio.TxtProv.Focus()
                Me.Close()
            End If
        End If
    End Sub
End Class
