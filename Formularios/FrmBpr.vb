Public Class FrmBpr

    

    Private Sub TxtBprov_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtBprov.KeyDown
        If e.KeyCode = Keys.Return Then
            If TxtBprov.Text = "" Then
                DtgProv.DataSource = Nothing
            End If
            If IsNumeric(TxtBprov.Text) Then
                MiClase.cargardatagriview(DtgProv, "select proveedor.id,proveedor,direccion,ciudad,cuit,c_iva,idciu,idciva,email,telefono,cel from proveedor inner join ciudad on proveedor.idciu=ciudad.id inner join c_de_iva on proveedor.idciva = c_de_iva.id where proveedor.id like '" & TxtBprov.Text & "%'")
                DtgProv.Font = New Font("arial ", 12, FontStyle.Regular)
                DtgProv.Columns(1).Width = 300
                DtgProv.Columns(2).Width = 200
                DtgProv.Columns(3).Width = 200
                DtgProv.Columns(4).Width = 130
                DtgProv.Columns(5).Width = 200
                DtgProv.Columns(8).Width = 300
                DtgProv.Columns(9).Width = 150
                DtgProv.Columns(10).Width = 150
                DtgProv.Columns(5).HeaderText = "Condición de Iva"
                DtgProv.Columns(6).Visible = False
                DtgProv.Columns(7).Visible = False
                DtgProv.Columns(6).Visible = False
                DtgProv.Columns(7).Visible = False
                DtgProv.Columns(10).HeaderText = "Celular"
                DtgProv.AllowUserToAddRows = False
            Else
                MiClase.cargardatagriview(DtgProv, "select proveedor.id,proveedor,direccion,ciudad,cuit,c_iva,idciu,idciva,email,telefono,cel from proveedor inner join ciudad   on proveedor.IdCiu=ciudad.Id inner join c_de_iva on proveedor.idciva=c_de_iva.id where proveedor Like '" & TxtBprov.Text & "%'")
                DtgProv.Font = New Font("Arial ", 12, FontStyle.Regular)
                DtgProv.Columns(1).Width = 300
                DtgProv.Columns(2).Width = 200
                DtgProv.Columns(3).Width = 200
                DtgProv.Columns(4).Width = 130
                DtgProv.Columns(5).Width = 200
                DtgProv.Columns(8).Width = 300
                DtgProv.Columns(9).Width = 150
                DtgProv.Columns(10).Width = 150
                DtgProv.Columns(5).HeaderText = "Condición de iva"
                DtgProv.Columns(6).Visible = False
                DtgProv.Columns(7).Visible = False
                DtgProv.Columns(10).HeaderText = "Celular"
                DtgProv.AllowUserToAddRows = False
            End If
        End If
    End Sub

    Private Sub DtgProv_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DtgProv.CellDoubleClick
        '  Try
        If EsPr = "0" Then
            FrmInArticulos.TxtCodPr.Text = Me.DtgProv.Rows(e.RowIndex).Cells(0).Value()
            FrmInArticulos.TxtProv.Text = Me.DtgProv.Rows(e.RowIndex).Cells(1).Value()
            FrmInArticulos.TxtCodPr.Focus()
            Me.Close()
        ElseIf EsPr = "1" Then
            Id = Me.DtgProv.Rows(e.RowIndex).Cells(0).Value()
            FrmInProv.TxtProv.Text = Me.DtgProv.Rows(e.RowIndex).Cells(1).Value()
            FrmInProv.txtDir.Text = Me.DtgProv.Rows(e.RowIndex).Cells(2).Value()
            FrmInProv.TxtCciu.Text = Me.DtgProv.Rows(e.RowIndex).Cells(6).Value()
            FrmInProv.TxtCiu.Text = Me.DtgProv.Rows(e.RowIndex).Cells(3).Value()
            FrmInProv.MskCuit.Text = Me.DtgProv.Rows(e.RowIndex).Cells(4).Value()
            FrmInProv.TxtIva.Text = Me.DtgProv.Rows(e.RowIndex).Cells(5).Value()
            FrmInProv.TxtCiva.Text = Me.DtgProv.Rows(e.RowIndex).Cells(7).Value()
            FrmInProv.TxtEmail.Text = Me.DtgProv.Rows(e.RowIndex).Cells(8).Value()
            FrmInProv.TxtTel.Text = Me.DtgProv.Rows(e.RowIndex).Cells(9).Value()
            FrmInProv.TxtCel.Text = Me.DtgProv.Rows(e.RowIndex).Cells(10).Value()
            FrmInProv.CmdBuscar.Enabled = False
            FrmInProv.CmdEliminar.Enabled = True
            FrmInProv.CmdModificar.Enabled = True
            FrmInArticulos.TxtOb.Focus()
            Me.Close()
        ElseIf EsPr = "2" Then
            IdPr = Me.DtgProv.Rows(e.RowIndex).Cells(0).Value()
            FrmCprecio.TxtProv.Text = Me.DtgProv.Rows(e.RowIndex).Cells(1).Value()
            FrmCprecio.TxtProv.Focus()
            Me.Close()
        ElseIf EsPr = "3" Then
            Id = Me.DtgProv.Rows(e.RowIndex).Cells(0).Value()
            FrmCarCom.TxtPro.Text = Me.DtgProv.Rows(e.RowIndex).Cells(1).Value()
            FrmCarCom.TxTDirecion.Text = Me.DtgProv.Rows(e.RowIndex).Cells(2).Value()
            FrmCarCom.Txtciudad.Text = Me.DtgProv.Rows(e.RowIndex).Cells(3).Value()
            FrmCarCom.TxtCuit.Text = Me.DtgProv.Rows(e.RowIndex).Cells(4).Value()
            FrmCarCom.TxtCiva.Text = Me.DtgProv.Rows(e.RowIndex).Cells(5).Value()
            IdCiva = Me.DtgProv.Rows(e.RowIndex).Cells(7).Value()
            '    FrmCarCom.CmdBProv.Enabled = False
            FrmCarCom.Grupo.Enabled = True
            FrmCarCom.GroupBox2.Enabled = True
            FrmCarCom.GroupBox3.Enabled = True
            FrmCarCom.TxtPv.Focus()
            Me.Close()
        ElseIf EsPr = "4" Then
            Id = Me.DtgProv.Rows(e.RowIndex).Cells(0).Value()
            FrmRcuePro.Txtprov.Text = Me.DtgProv.Rows(e.RowIndex).Cells(1).Value()
            FrmRcuePro.txtDirec.Text = Me.DtgProv.Rows(e.RowIndex).Cells(2).Value()
            FrmRcuePro.TxtCiu.Text = Me.DtgProv.Rows(e.RowIndex).Cells(3).Value()
            FrmRcuePro.TxtCuit.Text = Me.DtgProv.Rows(e.RowIndex).Cells(4).Value()
            FrmRcuePro.TxtIva.Text = Me.DtgProv.Rows(e.RowIndex).Cells(5).Value()
            IdCiva = Me.DtgProv.Rows(e.RowIndex).Cells(7).Value()
            FrmRcuePro.CmdPantalla.Enabled = True
            FrmRcuePro.CmdPantalla.Focus()
            Me.Close()
        ElseIf EsPr = "5" Then
            Id = Me.DtgProv.Rows(e.RowIndex).Cells(0).Value()
            FrmPagoP.TxtPro.Text = Trim(Me.DtgProv.Rows(e.RowIndex).Cells(1).Value())
            FrmPagoP.txtDirec.Text = Me.DtgProv.Rows(e.RowIndex).Cells(2).Value()
            FrmPagoP.TxtCiu.Text = Me.DtgProv.Rows(e.RowIndex).Cells(3).Value()
            FrmPagoP.TxtCuit.Text = Me.DtgProv.Rows(e.RowIndex).Cells(4).Value()
            FrmPagoP.TxtCiva.Text = Me.DtgProv.Rows(e.RowIndex).Cells(5).Value()
            IdCiva = Me.DtgProv.Rows(e.RowIndex).Cells(7).Value()
            FrmPagoP.TxtComp.Enabled = True
            FrmPagoP.TxtComp.Focus()
            Me.Close()
        End If
        'Catch ex As Exception

        'End Try

    End Sub

    Private Sub DtgProv_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DtgProv.KeyDown
        Try
            Dim fila As Integer
            If e.KeyCode = Keys.Enter Then
                Try
                    fila = DtgProv.CurrentRow.Index
                    If EsPr = "0" Then
                        FrmInArticulos.TxtCodPr.Text = Trim(DtgProv.Item(0, fila).Value)
                        FrmInArticulos.TxtProv.Text = DtgProv.Item(1, fila).Value
                        FrmInArticulos.TxtCodPr.Focus()
                        Me.Close()
                    ElseIf EsPr = "1" Then
                        Id = DtgProv.Item(0, fila).Value
                        FrmInProv.TxtProv.Text = Trim(DtgProv.Item(1, fila).Value)
                        FrmInProv.txtDir.Text = DtgProv.Item(2, fila).Value
                        FrmInProv.TxtCciu.Text = DtgProv.Item(6, fila).Value
                        FrmInProv.TxtCiu.Text = DtgProv.Item(3, fila).Value
                        FrmInProv.MskCuit.Text = DtgProv.Item(4, fila).Value
                        FrmInProv.TxtIva.Text = DtgProv.Item(5, fila).Value
                        FrmInProv.TxtCiva.Text = DtgProv.Item(7, fila).Value
                        FrmInProv.TxtEmail.Text = DtgProv.Item(8, fila).Value
                        FrmInProv.TxtTel.Text = DtgProv.Item(9, fila).Value
                        FrmInProv.TxtCel.Text = DtgProv.Item(10, fila).Value
                        FrmInProv.CmdBuscar.Enabled = False
                        FrmInProv.CmdEliminar.Enabled = True
                        FrmInProv.CmdModificar.Enabled = True
                        '  FrmInProv.TxtProv.Focus()
                        FrmInArticulos.TxtOb.Focus()
                        Me.Close()
                    ElseIf EsPr = "2" Then
                        IdPr = DtgProv.Item(0, fila).Value
                        FrmCprecio.TxtProv.Text = Trim(DtgProv.Item(1, fila).Value)
                        FrmCprecio.TxtProv.Focus()
                        Me.Close()
                    ElseIf EsPr = "3" Then
                        Id = DtgProv.Item(0, fila).Value
                        'FrmCarCom.TxtPr.Text = DtgProv.Item(1, fila).Value
                        FrmCarCom.TxtPro.Text = Trim(DtgProv.Item(1, fila).Value)
                        FrmCarCom.TxTDirecion.Text = DtgProv(2, fila).Value
                        FrmCarCom.Txtciudad.Text = DtgProv.Item(3, fila).Value
                        FrmCarCom.TxtCuit.Text = DtgProv.Item(4, fila).Value
                        FrmCarCom.TxtCiva.Text = DtgProv.Item(5, fila).Value
                        IdCiva = DtgProv.Item(7, fila).Value
                        '   FrmCarCom.CmdBProv.Enabled = False
                        FrmCarCom.Grupo.Enabled = True
                        '  FrmCarCom.CmdBProv.Enabled = False
                        FrmCarCom.GroupBox2.Enabled = True
                        FrmCarCom.GroupBox3.Enabled = True
                        FrmCarCom.TxtPv.Enabled = True
                        FrmCarCom.TxtPv.Focus()
                        Me.Close()
                    ElseIf EsPr = "4" Then
                        Id = DtgProv.Item(0, fila).Value
                        FrmRcuePro.Txtprov.Text = Trim(DtgProv.Item(1, fila).Value)
                        FrmRcuePro.txtDirec.Text = DtgProv(2, fila).Value
                        FrmRcuePro.TxtCiu.Text = DtgProv.Item(3, fila).Value
                        FrmRcuePro.TxtCuit.Text = DtgProv.Item(4, fila).Value
                        FrmRcuePro.TxtIva.Text = DtgProv.Item(5, fila).Value
                        IdCiva = DtgProv.Item(7, fila).Value
                        FrmRcuePro.CmdPantalla.Enabled = True
                        FrmRcuePro.CmdPantalla.Focus()
                        Me.Close()
                    ElseIf EsPr = "5" Then
                        Id = DtgProv.Item(0, fila).Value
                        FrmPagoP.TxtPro.Text = Trim(DtgProv.Item(1, fila).Value)
                        FrmPagoP.txtDirec.Text = DtgProv(2, fila).Value
                        FrmPagoP.TxtCiu.Text = DtgProv.Item(3, fila).Value
                        FrmPagoP.TxtCuit.Text = DtgProv.Item(4, fila).Value
                        FrmPagoP.TxtCiva.Text = DtgProv.Item(5, fila).Value
                        IdCiva = DtgProv.Item(7, fila).Value
                        FrmPagoP.TxtComp.Enabled = True
                        FrmPagoP.TxtComp.Focus()
                        Me.Close()
                    ElseIf EsPr = "6" Then
                        Id = DtgProv.Item(0, fila).Value
                        Form2.TxtProv.Text = Trim(DtgProv.Item(1, fila).Value)
                        Form2.DtgCli.Focus()
                        Me.Close()
                    End If
                Catch ex As Exception

                End Try

            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub DtgProv_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DtgProv.CellContentClick

    End Sub

    Private Sub TxtBprov_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBprov.TextChanged

    End Sub
End Class