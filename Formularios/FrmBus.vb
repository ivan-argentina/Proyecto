Public Class FrmBus

    Private Sub FrmBus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MiClase.cargardatagriview(DtgBus, "select id,cajero,psw,prioridad from cajeros ")
        DtgBus.Font = New Font("Arial ", 12, FontStyle.Regular)
        DtgBus.Columns(0).HeaderText = "Codigo"
        DtgBus.Columns(0).Width = 50
        DtgBus.Columns(1).HeaderText = "Cajero"
        DtgBus.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
    End Sub

    Private Sub DtgBus_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DtgBus.CellContentClick

    End Sub

    Private Sub DtgBus_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DtgBus.CellDoubleClick
        IdUs = Me.DtgBus.Rows(e.RowIndex).Cells(0).Value()
        FrmInUs.TxtUsuario.Text = Me.DtgBus.Rows(e.RowIndex).Cells(1).Value()
        FrmInUs.TxtClave.Text = Me.DtgBus.Rows(e.RowIndex).Cells(2).Value()
        FrmInUs.CmbPr.Text = Me.DtgBus.Rows(e.RowIndex).Cells(3).Value()
        FrmInUs.CmdModificar.Enabled = True
        FrmInUs.CmdEliminar.Enabled = True
        FrmInUs.TxtUsuario.Focus()
        Me.Close()
    End Sub

    Private Sub DtgBus_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DtgBus.KeyDown
        If e.KeyCode = Keys.Return Then
            Try
                Dim fila As Integer
                fila = DtgBus.CurrentRow.Index
                If e.KeyData = Keys.Enter Then
                    IdUs = Me.DtgBus.Item(0, fila).Value
                    FrmInUs.TxtUsuario.Text = Me.DtgBus.Item(1, fila).Value
                    FrmInUs.TxtClave.Text = Me.DtgBus.Item(2, fila).Value
                    FrmInUs.CmbPr.Text = Me.DtgBus.Item(3, fila).Value
                    FrmInUs.CmdEliminar.Enabled = True
                    FrmInUs.CmdModificar.Enabled = True
                    FrmInUs.TxtUsuario.Focus()
                    Me.Close()
                End If
            Catch ex As Exception

            End Try

            
        End If

    End Sub
End Class