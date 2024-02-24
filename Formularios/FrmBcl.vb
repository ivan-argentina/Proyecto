Public Class FrmBcl

    Private Sub DtgCli_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DtgCli.CellDoubleClick
        Try
            If EsCl = 2 Then
                Id = Me.DtgCli.Rows(e.RowIndex).Cells(0).Value()
                FrmInCl.TxtNombre.Text = Me.DtgCli.Rows(e.RowIndex).Cells(1).Value()
                FrmInCl.TxtDireccion.Text = Me.DtgCli.Rows(e.RowIndex).Cells(2).Value()
                FrmInCl.TxtCCiu.Text = Me.DtgCli.Rows(e.RowIndex).Cells(6).Value()
                FrmInCl.TxtCiudad.Text = Me.DtgCli.Rows(e.RowIndex).Cells(3).Value()
                FrmInCl.MskCuit.Text = Me.DtgCli.Rows(e.RowIndex).Cells(4).Value()
                FrmInCl.TxtIva.Text = Me.DtgCli.Rows(e.RowIndex).Cells(5).Value()
                FrmInCl.txtCiva.Text = Me.DtgCli.Rows(e.RowIndex).Cells(7).Value()
                FrmInCl.TxtEmail.Text = Me.DtgCli.Rows(e.RowIndex).Cells(8).Value()
                FrmInCl.TxtTelefono.Text = Me.DtgCli.Rows(e.RowIndex).Cells(9).Value()
                FrmInCl.txtCel.Text = Me.DtgCli.Rows(e.RowIndex).Cells(10).Value()
                FrmInCl.TxtCpostal.Text = Me.DtgCli.Rows(e.RowIndex).Cells(11).Value()
                IdPr = Me.DtgCli.Rows(e.RowIndex).Cells(12).Value()
                FrmInCl.TxtProv.Text = Me.DtgCli.Rows(e.RowIndex).Cells(13).Value()
                FrmInCl.DtcNc.Text = Me.DtgCli.Rows(e.RowIndex).Cells(14).Value()
                FrmInCl.MskSaldo.Text = FormatNumber(Me.DtgCli.Rows(e.RowIndex).Cells(15).Value(), 2)
                FrmInCl.CmdBuscar.Enabled = False
                FrmInCl.CmdEliminar.Enabled = True
                FrmInCl.CmdModificar.Enabled = True
                FrmInCl.TxtNombre.Focus()
                Me.Close()
            ElseIf EsCl = 3 Then
                Idcl = Me.DtgCli.Rows(e.RowIndex).Cells(0).Value()
                FrmFacturaa.TxtCli.Text = Me.DtgCli.Rows(e.RowIndex).Cells(1).Value()
                FrmFacturaa.TxtDir.Text = Me.DtgCli.Rows(e.RowIndex).Cells(2).Value()
                FrmFacturaa.TxtCiudad.Text = Me.DtgCli.Rows(e.RowIndex).Cells(3).Value()
                FrmFacturaa.MskCuit.Text = Trim(Me.DtgCli.Rows(e.RowIndex).Cells(4).Value())
                FrmFacturaa.TxtcIva.Text = Me.DtgCli.Rows(e.RowIndex).Cells(5).Value()
                IdCiva = Me.DtgCli.Rows(e.RowIndex).Cells(7).Value()
                If IdCiva = 5 Then
                    FrmFacturaa.LbCuit.Text = "D.N.I."
                Else
                    FrmFacturaa.LbCuit.Text = "Cuit :"
                End If
                IdPr = Me.DtgCli.Rows(e.RowIndex).Cells(12).Value()
                FrmFacturaa.TxtProv.Text = Me.DtgCli.Rows(e.RowIndex).Cells(13).Value()
                FrmFacturaa.TxtLimite.Text = FormatNumber(Me.DtgCli.Rows(e.RowIndex).Cells(15).Value(), 2)
                FrmFacturaa.TxtSaldo.Text = FormatNumber(Me.DtgCli.Rows(e.RowIndex).Cells(16).Value(), 2)
                If FrmFacturaa.TxtLimite.Text = 0 Then
                Else
                    '  If TxtSaldo.Text > TxtLimite.Text Then
                    If FrmFacturaa.TxtLimite.Text > FrmFacturaa.TxtSaldo.Text Then
                        Mensaje = MsgBox("Llego al Limite", MsgBoxStyle.OkOnly + MsgBoxStyle.Question, "Limite de Cta.Cte")
                    End If
                End If
                FrmFacturaa.TxtArticulo.Enabled = True
                FrmFacturaa.TxtArticulo.Focus()
                Me.Close()
            ElseIf EsCl = 4 Then
                Idcl = Me.DtgCli.Rows(e.RowIndex).Cells(0).Value()
                FrmOrep.TxtCli.Text = Me.DtgCli.Rows(e.RowIndex).Cells(1).Value()
                FrmOrep.TxtDireccion.Text = Me.DtgCli.Rows(e.RowIndex).Cells(2).Value()
                FrmOrep.TxtCiudad.Text = Me.DtgCli.Rows(e.RowIndex).Cells(3).Value()
                FrmOrep.TxtCuit.Text = Me.DtgCli.Rows(e.RowIndex).Cells(4).Value()
                FrmOrep.TxtCdeiva.Text = Me.DtgCli.Rows(e.RowIndex).Cells(5).Value()
                FrmOrep.CmdBuscar.Enabled = False
                FrmOrep.TxtEquipo.Enabled = True
                FrmOrep.CmdBEq.Enabled = True
                FrmOrep.TxtMarca.Enabled = True
                FrmOrep.TxtNumero.Enabled = True
                FrmOrep.TxtFalla.Enabled = True
                FrmOrep.CmdBM.Enabled = True
                FrmOrep.TxtEquipo.Focus()
                Me.Close()
            ElseIf EsCl = 5 Then
                Idcl = Me.DtgCli.Rows(e.RowIndex).Cells(0).Value()
                FrmRcue.TxtCli.Text = Me.DtgCli.Rows(e.RowIndex).Cells(1).Value()
                FrmRcue.txtDirec.Text = Me.DtgCli.Rows(e.RowIndex).Cells(2).Value()
                FrmRcue.TxtCiu.Text = Me.DtgCli.Rows(e.RowIndex).Cells(3).Value()
                FrmRcue.TxtCuit.Text = Me.DtgCli.Rows(e.RowIndex).Cells(4).Value()
                FrmRcue.DtcDesde.Enabled = True
                FrmRcue.DtcHasta.Enabled = True
                FrmRcue.CmdDetVen.Enabled = True
                FrmRcue.DtcDesde.Enabled = True
                FrmRcue.DtcHasta.Enabled = True
                FrmRcue.CmdPantalla.Enabled = True
                FrmRcue.CmdDetVen.Enabled = True
                FrmRcue.TxtMora.Enabled = True
                FrmRcue.DtcDesde.Enabled = True
                FrmRcue.DtcHasta.Enabled = True
                FrmRcue.CmdPantalla.Enabled = True
                FrmRcue.CmdPantalla.Focus()
                FrmRcue.CmdDetVen.Enabled = True
                Me.Close()
            ElseIf EsCl = 6 Then
                Idcl = Me.DtgCli.Rows(e.RowIndex).Cells(0).Value()
                FrmPago.TxtCli.Text = Me.DtgCli.Rows(e.RowIndex).Cells(1).Value()
                FrmPago.txtDirec.Text = Me.DtgCli.Rows(e.RowIndex).Cells(2).Value()
                FrmPago.TxtCiu.Text = Me.DtgCli.Rows(e.RowIndex).Cells(3).Value()
                FrmPago.TxtCuit.Text = Me.DtgCli.Rows(e.RowIndex).Cells(4).Value()
                FrmPago.TxtSaldo.Text = Me.DtgCli.Rows(e.RowIndex).Cells(16).Value()
                Civa = Me.DtgCli.Rows(e.RowIndex).Cells(5).Value()
                FrmPago.CmdEfec.Enabled = True
                FrmPago.CmdTarjeta.Enabled = True
                FrmPago.TxtComp.Enabled = True
                FrmPago.TxtComp.Text = "Efectivo"
                FrmPago.TxtComp.Enabled = False
                FrmPago.TxtNum.Enabled = True
                FrmPago.DtcFecha.Enabled = True
                FrmPago.MskEnt.Enabled = True
                FrmPago.MskEnt.Focus()
                Me.Close()
            ElseIf EsCl = 7 Then
                Idcl = Me.DtgCli.Rows(e.RowIndex).Cells(0).Value()
                FrmCuotas.TxtCli.Text = Me.DtgCli.Rows(e.RowIndex).Cells(1).Value()
                FrmCuotas.txtDirec.Text = Me.DtgCli.Rows(e.RowIndex).Cells(2).Value()
                FrmCuotas.TxtCiu.Text = Me.DtgCli.Rows(e.RowIndex).Cells(3).Value()
                FrmCuotas.TxtCuit.Text = Me.DtgCli.Rows(e.RowIndex).Cells(4).Value()
                FrmCuotas.TxtCiva.Text = Me.DtgCli.Rows(e.RowIndex).Cells(5).Value()
                FrmCuotas.TxtCli.Focus()
                Me.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DtgCli_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DtgCli.CellContentClick

    End Sub

    Private Sub DtgCli_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DtgCli.KeyDown
        Try
            Dim fila As Integer
            fila = DtgCli.CurrentRow.Index
            If e.KeyCode = Keys.Enter Then
                If EsCl = 2 Then
                    Id = Me.DtgCli.Item(0, fila).Value
                    FrmInCl.TxtNombre.Text = DtgCli.Item(1, fila).Value
                    FrmInCl.TxtDireccion.Text = DtgCli.Item(2, fila).Value
                    FrmInCl.TxtCCiu.Text = DtgCli.Item(6, fila).Value
                    FrmInCl.TxtCiudad.Text = DtgCli.Item(3, fila).Value
                    FrmInCl.MskCuit.Text = DtgCli.Item(4, fila).Value
                    FrmInCl.TxtIva.Text = DtgCli.Item(5, fila).Value
                    FrmInCl.txtCiva.Text = DtgCli.Item(7, fila).Value
                    IdCiva = DtgCli.Item(7, fila).Value
                    FrmInCl.TxtEmail.Text = DtgCli.Item(8, fila).Value
                    FrmInCl.TxtTelefono.Text = DtgCli.Item(9, fila).Value
                    FrmInCl.txtCel.Text = DtgCli.Item(10, fila).Value
                    FrmInCl.TxtCpostal.Text = DtgCli.Item(11, fila).Value
                    IdPrv = DtgCli.Item(12, fila).Value
                    FrmInCl.TxtProv.Text = DtgCli.Item(13, fila).Value
                    FrmInCl.DtcNc.Text = DtgCli.Item(14, fila).Value
                    FrmInCl.MskSaldo.Text = FormatNumber(FormatNumber(DtgCli.Item(15, fila).Value), 2)
                    FrmInCl.CmdBuscar.Enabled = False
                    FrmInCl.CmdEliminar.Enabled = True
                    FrmInCl.CmdModificar.Enabled = True
                    If IdCiva = 5 Then
                        FrmInCl.LbCuit.Text = "D.N.I."
                    Else
                        FrmInCl.LbCuit.Text = "Cuit"
                    End If
                    FrmInCl.TxtNombre.Focus()
                    Me.Close()
                ElseIf EsCl = 3 Then
                    Idcl = DtgCli.Item(0, fila).Value
                    FrmFacturaa.TxtCli.Text = Trim(DtgCli.Item(1, fila).Value)
                    FrmFacturaa.TxtDir.Text = DtgCli.Item(2, fila).Value
                    FrmFacturaa.TxtCiudad.Text = DtgCli.Item(3, fila).Value
                    FrmFacturaa.MskCuit.Text = Trim(DtgCli.Item(4, fila).Value)
                    FrmFacturaa.TxtcIva.Text = DtgCli.Item(5, fila).Value
                    IdCiva = DtgCli.Item(7, fila).Value
                    FrmFacturaa.TxtProv.Text = DtgCli.Item(13, fila).Value
                    LimFac = FormatNumber(DtgCli.Item(15, fila).Value, 2)
                    FrmFacturaa.TxtLimite.Text = FormatNumber(DtgCli.Item(15, fila).Value, 2)
                    SalFac = FormatNumber(DtgCli.Item(16, fila).Value, 2)
                    FrmFacturaa.TxtSaldo.Text = FormatNumber(DtgCli.Item(16, fila).Value, 2)

                    If IdCiva = 5 Then
                        FrmFacturaa.LbCuit.Text = "D.N.I."
                    Else
                        FrmFacturaa.LbCuit.Text = "Cuit :"
                    End If
                    If FrmFacturaa.TxtLimite.Text = 0 Then
                    Else

                      
                        If LimFac < SalFac Then
                            Mensaje = MsgBox("Llego al Limite", MsgBoxStyle.OkOnly + MsgBoxStyle.Question, "Limite de Cta.Cte")
                        End If
                    End If

                    FrmFacturaa.TxtArticulo.Enabled = True
                    FrmFacturaa.TxtArticulo.Focus()
                    Me.Close()
                ElseIf EsCl = 4 Then
                    Idcl = DtgCli.Item(0, fila).Value
                    FrmOrep.TxtCli.Text = DtgCli.Item(1, fila).Value
                    FrmOrep.TxtDireccion.Text = DtgCli.Item(2, fila).Value
                    FrmOrep.TxtCiudad.Text = DtgCli.Item(3, fila).Value
                    FrmOrep.TxtCuit.Text = DtgCli.Item(4, fila).Value
                    FrmOrep.TxtCdeiva.Text = DtgCli.Item(5, fila).Value
                    FrmOrep.CmdBuscar.Enabled = False
                    FrmOrep.TxtEquipo.Enabled = True
                    FrmOrep.CmdBEq.Enabled = True
                    FrmOrep.TxtMarca.Enabled = True
                    FrmOrep.TxtNumero.Enabled = True
                    FrmOrep.TxtFalla.Enabled = True
                    FrmOrep.CmdBM.Enabled = True
                    FrmOrep.TxtEquipo.Focus()
                    Me.Close()
                ElseIf EsCl = 5 Then
                    Idcl = DtgCli.Item(0, fila).Value
                    FrmRcue.TxtCli.Text = DtgCli.Item(1, fila).Value
                    FrmRcue.txtDirec.Text = DtgCli.Item(2, fila).Value
                    FrmRcue.TxtCiu.Text = DtgCli.Item(3, fila).Value
                    FrmRcue.TxtCuit.Text = DtgCli.Item(4, fila).Value
                    FrmRcue.DtcDesde.Enabled = True
                    FrmRcue.DtcHasta.Enabled = True
                    FrmRcue.CmdPantalla.Enabled = True
                    FrmRcue.CmdDetVen.Enabled = True
                    FrmRcue.TxtMora.Enabled = True
                    FrmRcue.DtcDesde.Enabled = True
                    FrmRcue.DtcHasta.Enabled = True
                    FrmRcue.CmdPantalla.Enabled = True
                    FrmRcue.CmdPantalla.Focus()
                    FrmRcue.CmdDetVen.Enabled = True
                    Me.Close()
                ElseIf EsCl = 6 Then
                    Idcl = Me.DtgCli.Item(0, fila).Value
                    FrmPago.TxtCli.Text = DtgCli.Item(1, fila).Value
                    FrmPago.txtDirec.Text = DtgCli.Item(2, fila).Value
                    FrmPago.TxtCiu.Text = DtgCli.Item(3, fila).Value
                    FrmPago.TxtCuit.Text = DtgCli.Item(4, fila).Value
                    Civa = DtgCli.Item(5, fila).Value
                    FrmPago.TxtSaldo.Text = FormatNumber(DtgCli.Item(16, fila).Value, 2)
                    FrmPago.CmdEfec.Enabled = True
                    FrmPago.CmdTarjeta.Enabled = True
                    FrmPago.CmdEfec.Enabled = True
                    FrmPago.CmdTarjeta.Enabled = True
                    FrmPago.TxtComp.Enabled = True
                    FrmPago.TxtComp.Text = "Efectivo"
                    FrmPago.TxtComp.Enabled = False
                    FrmPago.TxtNum.Enabled = True
                    FrmPago.DtcFecha.Enabled = True
                    FrmPago.MskEnt.Enabled = True
                    FrmPago.MskEnt.Focus()
                    Me.Close()
                ElseIf EsCl = 7 Then
                    Idcl = Me.DtgCli.Item(0, fila).Value
                    FrmCuotas.TxtCli.Text = DtgCli.Item(1, fila).Value
                    FrmCuotas.txtDirec.Text = DtgCli.Item(2, fila).Value
                    FrmCuotas.TxtCiu.Text = DtgCli.Item(3, fila).Value
                    FrmCuotas.TxtCuit.Text = DtgCli.Item(4, fila).Value
                    FrmCuotas.TxtCiva.Text = DtgCli.Item(5, fila).Value
                    FrmCuotas.TxtCli.Focus()
                    Me.Close()
                ElseIf EsCl = 8 Then
                    EsCl = 1
                    Idcl = Me.DtgCli.Item(0, fila).Value
                    FrmBusRem.TxtCliente.Focus()
                    Me.Close()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    
    Private Sub FrmBcl_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MiClase.cargardatagriview(DtgCli, "select clientes.id,cliente,direccion,ciudad,cuit,c_iva,idciu,idciva,email,telefono,cel,cpostal,idpr,provincia,fec_nac,saldo,salcli from clientes inner join ciudad   on clientes.IdCiu=ciudad.Id inner join c_de_iva on clientes.idciva=c_de_iva.id inner join provincias on clientes.idpr=provincias.id where cliente Like '%" & BCli & "%'order by cliente")
        DtgCli.Font = New Font("Arial ", 12, FontStyle.Regular)
        DtgCli.Columns(5).HeaderText = "Condición de iva"
        DtgCli.AutoResizeColumns()
        DtgCli.AutoResizeRows()
        DtgCli.Columns(6).Visible = False
        DtgCli.Columns(7).Visible = False
        DtgCli.Columns(10).HeaderText = "Celular"
        DtgCli.Columns(11).Visible = False
        DtgCli.Columns(12).Visible = False
        DtgCli.Columns(13).Visible = False
        DtgCli.AllowUserToAddRows = False
    End Sub
End Class