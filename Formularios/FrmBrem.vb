Public Class FrmBrem
    Dim chk As New DataGridViewCheckBoxColumn()
    Dim EsBlNg As Integer
    Dim Estado As String
    

  

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim RowIndex As Integer
        Dim ColumnIndex As Integer

        Dim IsTicked As Boolean = CBool(DtgRem.Rows(RowIndex).Cells(ColumnIndex).Value)

        If IsTicked Then
            MessageBox.Show("You ticked the box.")
        Else
            MessageBox.Show("You cleared the box.")
        End If
    End Sub

    Private Sub FrmBrem_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MiClase.cargardatagriview(DtgRem, "select fnum,fecha,total,numero,idtp,blng,idcl from facturas where idcl=" & Idcl & "and idtp=" & 4 & "and esventa=" & 1 & "and blng=" & 1 & " ")
        DtgRem.Font = New Font("Arial ", 12, FontStyle.Regular)
        DtgRem.Columns(0).HeaderText = "Numero"
        DtgRem.Columns(0).Width = 150
        DtgRem.Columns(2).HeaderText = "Precio"
        DtgRem.Columns(2).DefaultCellStyle.Format = "##,##0.00"
        DtgRem.AllowUserToAddRows = False
        DtgRem.Columns(3).Visible = False
        DtgRem.Columns(4).Visible = False
        DtgRem.Columns(5).Visible = False
        DtgRem.Columns(6).Visible = False
        DtgRem.Columns.Add(chk)
        chk.HeaderText = "Estado"
        chk.Name = "Estado"
        DtgRem.AllowUserToAddRows = False
    End Sub

    Private Sub Cmdfacturar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmdfacturar.Click
        For i As Integer = 0 To DtgRem.Rows.Count() - 1
            Dim C As Boolean
            'Bar = DtgCli.Rows(i).Cells(0).Value
            Num = DtgRem.Rows(i).Cells(3).Value
            C = DtgRem.Rows(i).Cells(7).Value
            If C = True Then
                MiClase.cargardatagriview(DtgDFac, "select id,idtp,linea,barra,articulo,punit,cantidad,ptotal,idfm,idmr,idpr,alic,idalic from detal_fac where idtp=" & 4 & "and id=" & Num & "")
            End If

        Next



        '  Dim St As String
        '  Dim filas As Integer = DtgRem.Rows.Count
        '  Dim contador As Integer = 0
        '  For i As Integer = 0 To filas - 1
        ' If IsDBNull(Convert.ToBoolean(DtgRem(3, i).Value)) Then
        ' Else
        ' Num = Convert.ToString(DtgRem(3, i).Value)
        'End If
        'If IsDBNull(Convert.ToBoolean(DtgRem(4, i).Value)) Then
        ' Else
        'IdTp = Convert.ToString(DtgRem(4, i).Value)
        'End If
        'If IsDBNull(Convert.ToBoolean(DtgRem(5, i).Value)) Then
        'Else
        'EsBlNg = Convert.ToString(DtgRem(5, i).Value)
        'End If
        'I() 'f IsDBNull(Convert.ToBoolean(DtgRem(7, i).Value)) Then
        'Else
        'St = Convert.ToString(DtgRem(7, i).Value)
        'End If
        'Next
        'If Estado = "True" Then
        ''MiClase.cargardatagriview(DtgDFac, "select id,idtp,linea,barra,articulo,punit,cantidad,ptotal,idfm,idmr,idpr,alic,idalic from detal_fac where idtp=" & 4 & "and id=" & Num & " and blng=" & EsBlNg & "")
        'End If


        'AbUn = 0
        'Dim Fl As Integer = DtgDFac.Rows.Count
        'Dim Cnt As Integer = 0
        'For u As Integer = 0 To Fl - 1
        ' If IsDBNull(Convert.ToString(DtgDFac(0, u).Value)) Then
        ' Else
        ' NumDet = Convert.ToString(DtgDFac(0, u).Value)
        ' End If
        ' If IsDBNull(Convert.ToString(DtgDFac(2, u).Value)) Then
        ' Else
        ' LinDet = Convert.ToString(DtgDFac(2, u).Value)
        ' End If
        'If IsDBNull(Convert.ToString(DtgDFac(3, u).Value)) Then
        'Else
        'BarDet = Convert.ToString(DtgDFac(3, u).Value)
        'End If
        ''If IsDBNull(Convert.ToString(DtgDFac(4, u).Value)) Then
        'Else
        'ArtDet = Convert.ToString(DtgDFac(4, u).Value)
        'End If
        'If IsDBNull(Convert.ToString(DtgDFac(5, u).Value)) Then
        'Else
        'PunDet = Convert.ToString(DtgDFac(5, u).Value)
        'End If
        'If IsDBNull(Convert.ToString(DtgDFac(6, u).Value)) Then
        'Else
        'CanDet = Convert.ToString(DtgDFac(6, u).Value)
        'End If
        'If IsDBNull(Convert.ToString(DtgDFac(7, u).Value)) Then
        'Else
        'TotDet = Convert.ToString(DtgDFac(7, u).Value)
        'End If
        'MiClase.eliminaactualizaregistra("insert into t_detalfac values(" & LinDet & "," & Pc & ",'" & Articulo & "'," & PunDet & "," & CanDet & "," & DesDet & "," & TotDet & "," & TotDet & "," & BarDet & "," & IdPr & "," & IdMr & "," & IdFm & "," & BlNg & "," & Alic1 & "," & IdIva & ",'" & AbUn & "'," & IdAct & ")")

        'Next

        ' misdatos = MiClase.traedataset("select id,idtp,linea,barra,articulo,punit,cantidad,ptotal from detal_fac where idtp=" & 4 & "and id=" & Num & " and blng=" & EsBlNg & "")
        ' NumDet = misdatos.Tables(0).Rows(0).Item(0)
        ' IdTpDet = misdatos.Tables(0).Rows(0).Item(1)
        '   End If
        'Next
    End Sub
End Class