Public Class FrmOrep
    Private Sub Blanquear()
        TxtCli.Text = ""
        TxtDireccion.Text = ""
        TxtCiudad.Text = ""
        TxtCdeiva.Text = ""
        TxtCuit.Text = ""
        TxtMarca.Text = ""
        TxtEquipo.Text = ""
        TxtNumero.Text = ""
        TxtFalla.Text = ""
        CmdBuscar.Enabled = True
        TxtCli.Focus()
    End Sub
    Private Sub Act()
        If IdOr = 0 Then
            MiClase.cargardatagriview(DtgRep, "select id,fent,idcli,cliente,direccion,ciudad,cuit,cdeiva,equipo,marca,numero,falla,estado,es from o_rep where es = " & IdOr & "order by id desc")
            DtgRep.Columns(11).HeaderText = "Falla"
        ElseIf IdOr = 1 Then
            MiClase.cargardatagriview(DtgRep, "select id,frep,idcli,cliente,direccion,ciudad,cuit,cdeiva,equipo,marca,numero,numcom,estado,es from o_rep where es = " & IdOr & "order by id desc")
            DtgRep.Columns(11).HeaderText = "Comprobante"
        ElseIf IdOr = 2 Then
            MiClase.cargardatagriview(DtgRep, "select id,fsal,idcli,cliente,direccion,ciudad,cuit,cdeiva,equipo,marca,numero,numcom,estado,es from o_rep where es = " & IdOr & "order by id desc")
            DtgRep.Columns(11).HeaderText = "Comprobante"
        End If
        DtgRep.Font = New Font("Arial ", 12, FontStyle.Regular)
        DtgRep.AutoResizeColumns()
        DtgRep.AutoResizeRows()
        DtgRep.Columns(0).HeaderText = "Id"
        DtgRep.Columns(1).HeaderText = "Fecha"
        DtgRep.Columns(2).HeaderText = "Codigo"
        DtgRep.Columns(3).HeaderText = "Cliente"
        DtgRep.Columns(4).HeaderText = "Direccion"
        DtgRep.Columns(5).HeaderText = "Ciudad"
        DtgRep.Columns(6).HeaderText = "Cuit"
        DtgRep.Columns(7).HeaderText = "C.de Iva"
        DtgRep.Columns(8).HeaderText = "Equipo"
        DtgRep.Columns(9).HeaderText = "Marca"
        DtgRep.Columns(10).HeaderText = "Numero"
        DtgRep.Columns(12).HeaderText = "Estado"
        DtgRep.Columns(13).Visible = False
    End Sub
    Private Sub FrmOrep_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        IdOr = 0
        Act()
    End Sub

    Private Sub CmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdBuscar.Click
        EsCl = "4"
        FrmBcl.Show()
    End Sub
    Private Sub CmdBEq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdBEq.Click
        FrmBeq.Show()
    End Sub

    Private Sub CmdBM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdBM.Click
        EsMar = "2"
        FrmBMar.Show()
    End Sub

    Private Sub TxtEquipo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtEquipo.KeyDown
        If e.KeyCode = Keys.Return Then
            TxtMarca.Focus()
        End If
    End Sub

    Private Sub TxtMarca_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtMarca.KeyDown
        If e.KeyCode = Keys.Return Then
            TxtNumero.Focus()
        End If
    End Sub
    Private Sub TxtNumero_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtNumero.KeyDown
        If e.KeyCode = Keys.Return Then
            TxtFalla.Focus()
        End If
    End Sub

    Private Sub TxtFalla_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtFalla.KeyDown
        If e.KeyCode = Keys.Return Then
            If TxtCli.Text = "" Then
                Mensaje = MsgBox("Faltan Datos de Ingresar", MsgBoxStyle.YesNo, "Faltan datos de Ingresar")
                If Mensaje = MsgBoxResult.Yes Then
                    TxtCli.Focus()
                End If
            Else
                Mensaje = MsgBox("Desea Cargar La Orden de Reparacion", MsgBoxStyle.YesNo, "Cargar Orden de Reparacion!!!")
                If Mensaje = MsgBoxResult.Yes Then
                    Dim FSal As Date
                    FSal = "01/01/00"
                    EsOr = "Para Reparar"
                    If TxtEquipo.Text = "" Then
                        TxtEquipo.Text = "0"
                    End If
                    If TxtMarca.Text = "" Then
                        TxtMarca.Text = "0"
                    End If
                    If TxtNumero.Text = "" Then
                        TxtNumero.Text = "0"
                    End If
                    If TxtFalla.Text = "" Then
                        TxtFalla.Text = "0"
                    End If
                    MiClase.eliminaactualizaregistra("insert into o_rep values('" & TxtCli.Text & "'," & Idcl & ",'" & TxtDireccion.Text & "', " & _
                      "'" & TxtCuit.Text & "','" & TxtCdeiva.Text & "','" & TxtCiudad.Text & "','" & TxtEquipo.Text & "','" & TxtMarca.Text & "', " & _
                      "'" & TxtNumero.Text & "','" & TxtFalla.Text & "','" & Date.Today & "'," & 0 & ",'" & EsOr & "','" & FSal & "','" & FSal & "'," & 0 & ")")
                    Blanquear()
                    Act()
                End If
            End If
        End If
    End Sub

    Private Sub DtgRep_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DtgRep.CellClick
        
        IdOrt = Me.DtgRep.Rows(e.RowIndex).Cells(0).Value()
        Idcl = Me.DtgRep.Rows(e.RowIndex).Cells(2).Value()
        FrmFacturaa.TxtCli.Text = Me.DtgRep.Rows(e.RowIndex).Cells(3).Value()
        FrmFacturaa.TxtDir.Text = Me.DtgRep.Rows(e.RowIndex).Cells(4).Value()
        FrmFacturaa.TxtCiudad.Text = Me.DtgRep.Rows(e.RowIndex).Cells(5).Value()
        FrmFacturaa.MskCuit.Text = Me.DtgRep.Rows(e.RowIndex).Cells(6).Value()
        FrmFacturaa.TxtcIva.Text = Me.DtgRep.Rows(e.RowIndex).Cells(7).Value()
        IdOrd = Me.DtgRep.Rows(e.RowIndex).Cells(13).Value()
        If IdOrd = 0 Then
            FrmFacturaa.Show()
            BlNg = "1"
            Ord = 1
            FrmFacturaa.TxtArticulo.Focus()

        ElseIf IdOrd = 1 Then
            Mensaje = MsgBox("Desea Entregar este Equipo:", MsgBoxStyle.YesNo, "Entregar Equipo!!!")
            If Mensaje = MsgBoxResult.Yes Then
                EsOr = "Entregada"
                MiClase.eliminaactualizaregistra("update o_rep set fsal='" & Date.Today & "',es=" & 2 & ",estado='" & EsOr & "' where id=" & IdOrt & "")
                Act()
            End If
        End If


    End Sub
    Private Sub OptRep_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptRep.CheckedChanged
        IdOr = 1
        Act()
    End Sub

    Private Sub OptEnt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptEnt.CheckedChanged
        IdOr = 2
        Act()
    End Sub

    Private Sub OptPRep_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptPRep.CheckedChanged
        ' IdOrd = 0
        ' Act()
    End Sub

    Private Sub OptPRep_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles OptPRep.Click
        IdOr = 0
        Act()
    End Sub

    
    Private Sub DtgRep_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DtgRep.CellContentClick

    End Sub

    Private Sub TxtFalla_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtFalla.TextChanged

    End Sub

    Private Sub TxtEquipo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtEquipo.TextChanged

    End Sub
End Class