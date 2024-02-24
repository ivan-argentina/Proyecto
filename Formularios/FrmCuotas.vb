
Public Class FrmCuotas
    Private Sub CmdbusCli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdbusCli.Click
        EsCl = 7
        FrmBcl.Show()
    End Sub

    Private Sub Fnum()
        'Formateo el Numero de Comprobante
        'Num = "2569"
        If Num < 10 Then
            Lnum = "0000000" + Num
        ElseIf Num >= 10 And Num < 100 Then
            Lnum = "000000" + Num
        ElseIf Num >= 100 And Num < 1000 Then
            Lnum = "00000" + Num
        ElseIf Num >= 1000 And Num < 10000 Then
            Lnum = "0000" + Num
        ElseIf Num >= 10000 And Num < 100000 Then
            Lnum = "000" + Num
        ElseIf Num >= 100000 And Num < 1000000 Then
            Lnum = "00" + Num
        ElseIf Num >= 1000000 And Num < 10000000 Then
            Lnum = "0" + Num
        ElseIf Num >= 10000000 And Num < 100000000 Then
            Lnum = Num
        End If
        'formateo el numero de pv
        'Pv = "14"
        If Pv < 10 Then
            Lpv = "000" + Pv
        ElseIf Pv >= 10 And Pv < 100 Then
            Lpv = "00" + Pv
        ElseIf Pv >= 100 And Pv < 1000 Then
            Lpv = "0" + Pv
        ElseIf Pv >= 1000 And Pv < 10000 Then
            Lpv = Pv
        End If
        'formateo el numero de cliente
        If TxtCli.Text = "" Then
            Idcl = "1"
        End If
        'Idcl = "28"
        If Idcl < 10 Then
            LidCl = "000" + CStr(Idcl)
        ElseIf Idcl >= 10 And Idcl < 100 Then
            LidCl = "00" + CStr(Idcl)
        ElseIf Idcl >= 100 And Idcl < 1000 Then
            LidCl = "0" + CStr(Idcl)
        ElseIf Idcl >= 1000 And Idcl < 10000 Then
            LidCl = CStr(Idcl)
        End If
        'Formateo el Numero de Comprobante
        IdTp = "5"
        If IdTp < 10 Then
            LidTp = "0" + IdTp
        ElseIf IdTp >= 10 And IdTp < 100 Then
            LidTp = IdTp
        End If
        'formateo el numero de linea

        'txt.Text = LidTp + Lpv + Lnum + CStr(LidCl) + CStr(BlNg)
        Clave = Lpv + "-" + Lnum

    End Sub
    Private Sub Buscar()
        If BlNg = 0 Then
            MiClase.cargardatagriview(DtgCuotas, "select cuotas.idcl,numcom,idtp,numero,vencimiento,importe,entrega,salcuo from cuotas inner join tip_fac on cuotas.idtp=tip_fac.id where cuotas.idcl=" & Idcl & "and blng=" & BlNg & "and salcuo >0 ")
        ElseIf BlNg = 1 Then
            MiClase.cargardatagriview(DtgCuotas, "select cuotas.idcl,numcom,idtp,numero,vencimiento,importe,entrega,salcuo from cuotas inner join tip_fac on cuotas.idtp=tip_fac.id where cuotas.idcl=" & Idcl & "and salcuo >0 ")
        End If
        DtgCuotas.Font = New Font("Arial ", 12, FontStyle.Regular)
        DtgCuotas.Columns(0).Visible = False
        ' DtgCuotas.Columns(1).Visible = False
        DtgCuotas.Columns(2).Visible = False
        DtgCuotas.Columns(3).HeaderText = "Cuota"
        DtgCuotas.Columns(7).HeaderText = "Saldo"
        DtgCuotas.Columns(1).HeaderText = "Numero"
        DtgCuotas.Columns(5).DefaultCellStyle.Format = "##,##0.00"
        DtgCuotas.Columns(6).DefaultCellStyle.Format = "##,##0.00"
        DtgCuotas.Columns(7).DefaultCellStyle.Format = "##,##0.00"
        DtgCuotas.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        DtgCuotas.Columns(1).Width = 80
        DtgCuotas.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        DtgCuotas.Columns(3).Width = 60
        DtgCuotas.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        DtgCuotas.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        DtgCuotas.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        Dim total As Double = 0
        Dim iTotal As Integer = Me.DtgCuotas.Rows.Count
        Dim i As Integer
        For i = 0 To iTotal - 1
            total = total + (Me.DtgCuotas(7, i).Value)
        Next
        MskTotal.Text = FormatNumber(total, 2)
    End Sub

    Private Sub TxtCli_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCli.KeyDown
        If e.KeyCode = Keys.Return Then
            Buscar()
        End If
    End Sub

    Private Sub TxtCli_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCli.TextChanged

    End Sub

    Private Sub DtgCuotas_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DtgCuotas.CellContentClick

    End Sub

    Private Sub DtgCuotas_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DtgCuotas.CellEndEdit
        Dim fila As Integer
        fila = DtgCuotas.CurrentRow.Index
        NumCom = DtgCuotas.Item(1, fila).Value
        IdTp = DtgCuotas.Item(2, fila).Value
        Num = DtgCuotas.Item(3, fila).Value
        Importe = DtgCuotas.Item(5, fila).Value
        Entrega = DtgCuotas.Item(6, fila).Value
        Saldo = DtgCuotas.Item(7, fila).Value
        Saldo = Saldo - Entrega
        currentrow = CType((e.RowIndex.ToString()), Integer) ''Obtiene la fila actual
        DtgCuotas.Item(7, fila).Value = Saldo
        'Sumar una Columna
        Dim Total As Single
        Dim Col As Integer = Me.DtgCuotas.CurrentCell.ColumnIndex
        For Each row As DataGridViewRow In Me.DtgCuotas.Rows
            Total += Val(row.Cells(Col).Value)
        Next
        Me.MskEntrega.Text = FormatNumber(Total.ToString, 2)

        'Dim dts As New DataSet
        'MiClase.eliminaactualizaregistra("Update Cuotas SET SalCuo = " & Saldo & "where numcom=" & NumCom & " and numero=" & Num & "")
        'fila = DtgCuotas.CurrentRow.Index
        'DtgCuotas.Item(7, fila).Value = Saldo
        Entrega = 0
    End Sub


    Private Sub CmdPagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdPagar.Click
        Mensaje = MsgBox("Desea Guardar el Recibo", MsgBoxStyle.YesNo, "Guardar Recibo!!!")
        If Mensaje = MsgBoxResult.Yes Then
            'EntAc = MskEntrega.Text
            Dim filas As Integer = DtgCuotas.Rows.Count
            Dim contador As Integer = 0
            For i As Integer = 0 To filas - 1
                If IsDBNull(Convert.ToDouble(DtgCuotas(1, i).Value)) Then
                Else
                    NumCom = Convert.ToDouble(DtgCuotas(1, i).Value)
                End If
                If IsDBNull(Convert.ToDouble(DtgCuotas(2, i).Value)) Then
                Else
                    IdTp = Convert.ToDouble(DtgCuotas(2, i).Value)
                End If
                If IsDBNull(Convert.ToDouble(DtgCuotas(3, i).Value)) Then
                Else
                    NumCuo = Convert.ToDouble(DtgCuotas(3, i).Value)
                End If
                If IsDBNull(Convert.ToDateTime(DtgCuotas(4, i).Value)) Then
                Else
                    VenCuo = Convert.ToDateTime(DtgCuotas(4, i).Value)
                End If
                If IsDBNull(Convert.ToDouble(DtgCuotas(5, i).Value)) Then
                Else
                    ImpCuo = Convert.ToDouble(DtgCuotas(5, i).Value)
                End If
                If IsDBNull(Convert.ToDouble(DtgCuotas(6, i).Value)) Then
                Else
                    Entrega = Convert.ToDouble(DtgCuotas(6, i).Value)
                End If
                If IsDBNull(Convert.ToDouble(DtgCuotas(7, i).Value)) Then
                Else
                    Saldo = Convert.ToDouble(DtgCuotas(7, i).Value)
                End If
                MiClase.eliminaactualizaregistra("Update Cuotas SET SalCuo = " & Saldo & "where numcom=" & NumCom & " and numero=" & NumCuo & "")
                'actualizo la tabla ctacte
               
                If Entrega > 0 Then
                    misdatos = MiClase.traedataset("select isnull((saldo),0) from ctacte where Numero = " & NumCom & " And IdTp = " & IdTp & "")
                    SalAnt = misdatos.Tables(0).Rows(0).Item(0)
                    Saldo = SalAnt - Entrega
                    MiClase.eliminaactualizaregistra("Update CtaCte set Saldo = " & Saldo & " WHERE  Numero = " & NumCom & " And IdTp = " & IdTp & "")
                End If
            Next
            'grabo el recibo
            'Traigo el Numero del Comprobante
            misdatos = MiClase.traedataset("select isnull( max(numero),0) from facturas where idtp=" & 5 & "")
            NumFac = misdatos.Tables(0).Rows(0).Item(0) + 1
            Num = misdatos.Tables(0).Rows(0).Item(0) + 1
            EsVenta = 1
            Cventa = "cta.cte"
            Pv = 3
            Fnum()
            MiClase.eliminaactualizaregistra("insert into facturas values(" & NumFac & "," & IdTp & ", " & _
              "" & Pv & "," & IdEnc & "," & Idcl & ",'" & Date.Today & "'," & EsVenta & ",'" & Cventa & "'," & Neto & ", " & _
              "" & Iva & "," & Iint & "," & Iint & "," & BlNg & "," & Alic & ",'" & Date.Today & "','" & Clave & "'," & MskEntrega.Text & "," & _
              "'" & Iint & "','" & Iint & "','" & TxtCli.Text & "','" & txtDirec.Text & "','" & TxtCiu.Text & "','" & TxtCiva.Text & "','" & TxtCuit.Text & "')")

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim total As Double = 0
        Dim iTotal As Integer = Me.DtgCuotas.Rows.Count
        Dim i As Integer
        For i = 0 To iTotal - 1
            total = total + (Me.DtgCuotas(7, i).Value)
        Next
        MskTotal.Text = total
    End Sub
End Class