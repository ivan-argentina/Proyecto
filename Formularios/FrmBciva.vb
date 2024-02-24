Public Class FrmBciva
    Dim MiClase As New Conexion

    Private Sub TxtCiva_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCiva.TextChanged
        Try
            If TxtCiva.Text = "" Then
                DtgCiva.DataSource = Nothing
            End If
            If IsNumeric(TxtCiva.Text) Then
                MiClase.cargardatagriview(DtgCiva, "select id,c_iva from c_de_iva where id Like '" & TxtCiva.Text & "%'")
                DtgCiva.Font = New Font("Arial ", 12, FontStyle.Regular)
                DtgCiva.Columns(0).HeaderText = "Codigo"
                DtgCiva.Columns(1).HeaderText = "C.de Iva"
                DtgCiva.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                DtgCiva.AllowUserToAddRows = False
            Else
                MiClase.cargardatagriview(DtgCiva, "select id,c_iva from c_de_iva where c_iva Like '" & TxtCiva.Text & "%'")
                DtgCiva.Font = New Font("Arial ", 12, FontStyle.Regular)
                DtgCiva.Columns(0).HeaderText = "Codigo"
                DtgCiva.Columns(1).HeaderText = "C.de Iva"
                DtgCiva.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                DtgCiva.AllowUserToAddRows = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DtgCiva_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DtgCiva.CellDoubleClick
        Try
            If EsCv = 0 Then
                FrmInProv.TxtCiva.Text = Me.DtgCiva.Rows(e.RowIndex).Cells(0).Value()
                FrmInProv.TxtIva.Text = Me.DtgCiva.Rows(e.RowIndex).Cells(1).Value()
                FrmInProv.MskCuit.Focus()
                Me.Close()
            ElseIf EsCv = 1 Then
                IdCiva = Me.DtgCiva.Rows(e.RowIndex).Cells(0).Value()
                FrmFacturaa.TxtcIva.Text = Me.DtgCiva.Rows(e.RowIndex).Cells(1).Value()
                If IdCiva = 5 Then
                    FrmFacturaa.MskCuit.Mask = "##.###.###"
                    FrmFacturaa.LbCuit.Text = "DNI :"
                Else
                    FrmFacturaa.MskCuit.Mask = "##-########-#"
                    FrmFacturaa.LbCuit.Text = "Cuit :"
                End If
                FrmFacturaa.MskCuit.Focus()
                Me.Close()
            ElseIf EsCv = 3 Then
                FrmInCl.txtCiva.Text = Me.DtgCiva.Rows(e.RowIndex).Cells(0).Value()
                FrmInCl.TxtIva.Text = Me.DtgCiva.Rows(e.RowIndex).Cells(1).Value()
                FrmInCl.MskCuit.Focus()
                Me.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DtgCiva_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DtgCiva.KeyDown
        Try


            Dim fila As Integer
            fila = DtgCiva.CurrentRow.Index
            If e.KeyCode = Keys.Enter Then
                If EsCv = 0 Then
                    FrmInProv.TxtCiva.Text = DtgCiva.Item(0, fila).Value
                    FrmInProv.TxtIva.Text = DtgCiva.Item(1, fila).Value
                    FrmInProv.MskCuit.Focus()
                    Me.Close()
                ElseIf EsCv = 1 Then
                    IdCiva = DtgCiva.Item(0, fila).Value
                    FrmFacturaa.TxtcIva.Text = DtgCiva.Item(1, fila).Value
                    If IdCiva = 5 Then
                        FrmFacturaa.MskCuit.Mask = "##.###.###"
                        FrmFacturaa.LbCuit.Text = "DNI :"
                    Else
                        FrmFacturaa.MskCuit.Mask = "##-########-#"
                        FrmFacturaa.LbCuit.Text = "Cuit :"
                    End If
                    FrmFacturaa.MskCuit.Focus()
                    Me.Close()
                ElseIf EsCv = 2 Then
                    FrmInCl.txtCiva.Text = DtgCiva.Item(0, fila).Value
                    FrmInCl.TxtIva.Text = DtgCiva.Item(1, fila).Value
                    FrmInCl.MskCuit.Focus()
                    Me.Close()
                ElseIf EsCv = 3 Then
                    IdCiva = DtgCiva.Item(0, fila).Value
                    FrmPagoP.TxtCiva.Text = Trim(DtgCiva.Item(1, fila).Value)
                    FrmPagoP.TxtCiva.Focus()
                    Me.Close()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DtgCiva_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DtgCiva.CellContentClick

    End Sub
End Class