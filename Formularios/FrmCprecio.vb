Imports System.Text
Imports System.Runtime.InteropServices
Imports System.Drawing.Printing
Imports System.Drawing


Public Class FrmCprecio

    Private Sub print_PrintEtiqueta(ByVal sender As Object, _
                     ByVal e As PrintPageEventArgs)
        Dim x As Single = 0.0F
        Dim y As Single = -11.0F
        Dim y1 As Single = 50.0F
        Dim yL As Single = 75.0F
        Dim width As Int32 = 300
        Dim height As Int32 = 250
        Dim drawRect As New RectangleF(x, y, width, height)
        Dim xPos As Single = e.MarginBounds.Right
        Dim PrecioEtiqueta As String
        Dim prFont As New Font("Arial", 40, FontStyle.Bold)
        Dim prFont1 As New Font("Arial", 14, FontStyle.Bold)
        Dim yPos As Single = prFont.GetHeight(e.Graphics)
        MiClase.cargardatagriview(DtgArt, "select codigo,articulo,precio from etiquetas")
        'traigo los articulos para imprimir etiquetas
        DtgArt.AllowUserToAddRows = False
        For i As Integer = 0 To DtgArt.RowCount - 1
            Articulo = Trim(DtgArt(1, i).Value)
            PrecioEtiqueta = FormatNumber(DtgArt(2, i).Value, 2)
            '  e.Graphics.DrawString(PrecioEtiqueta, prFont, Brushes.Black, New Rectangle(20, -11, width, height))
            e.Graphics.DrawString(PrecioEtiqueta, prFont, Brushes.Black, New Rectangle(20, y, width, height))
            '  e.Graphics.DrawString(Articulo, prFont1, Brushes.Black, New Rectangle(0, 50, width, height))
            e.Graphics.DrawString(Articulo, prFont1, Brushes.Black, New Rectangle(0, y1, width, height))
            Dim OurPen As Pen
            OurPen = New Pen(Color.Black, 2)
            e.Graphics.DrawLine(OurPen, 0, yL, width, yL)
            y = y + 100
            y1 = y1 + 100
            yL = yL + 100
        Next
        e.HasMorePages = False



    End Sub



    Private Sub Buscar()
        MiClase.cargardatagriview(DtgArt, "select articulos.barra,articulo,pcosto,pfinal,idpr,idfm,idmr,idact,alic,idiv,abu,stock,familia,utilidad from articulos inner join familias on articulos.idfm=familias.id where barra=" & TxtBarr.Text & "")
        DtgArt.Font = New Font("Arial ", 12, FontStyle.Regular)
        DtgArt.AllowUserToAddRows = False
        DtgArt.Columns(1).Width = 330S
        DtgArt.Columns(2).DefaultCellStyle.Format = "##,##0.00"
        DtgArt.Columns(3).DefaultCellStyle.Format = "##,##0.00"
        DtgArt.Columns(6).DefaultCellStyle.Format = "##,##0.00"
        DtgArt.Columns(7).DefaultCellStyle.Format = "##,##0.00"
        DtgArt.Columns(8).DefaultCellStyle.Format = "##,##0.00"
        DtgArt.Columns(9).DefaultCellStyle.Format = "##,##0.00"
        DtgArt.Columns(10).DefaultCellStyle.Format = "##,##0.00"
        DtgArt.Columns(11).DefaultCellStyle.Format = "##,##0.00"
        DtgArt.Columns(13).DefaultCellStyle.Format = "##,##0.00"
        'DtgArt.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        DtgArt.Columns(4).Visible = False
        DtgArt.Columns(5).Visible = False
        DtgArt.Columns(6).Visible = False
        DtgArt.Columns(7).Visible = False
        DtgArt.Columns(8).Visible = False
        DtgArt.Columns(9).Visible = False
        DtgArt.Columns(10).Visible = False
        DtgArt.Columns(12).Visible = False
        DtgArt.Columns(13).Visible = False
        DtgArt.Columns(2).HeaderText = "Costo"
        DtgArt.Columns(11).HeaderText = "Stock"
    End Sub
    Private Sub Act()
        MiClase.cargardatagriview(DtgArt, "select barra,articulo,pcosto,idpr,idfm,idmr,pfinal,util,alic,pneto,iva,stock,familia from articulos inner join familias on articulos.idfm=familias.id where barra = " & TxtBar1.Text & "")
        DtgArt.Font = New Font("Arial ", 12, FontStyle.Regular)
        DtgArt.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        DtgArt.AllowUserToAddRows = False
        DtgArt.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DtgArt.Columns(2).DefaultCellStyle.Format = "##,##0.00"
        DtgArt.Columns(6).DefaultCellStyle.Format = "##,##0.00"
        DtgArt.Columns(7).DefaultCellStyle.Format = "##,##0.00"
        DtgArt.Columns(8).DefaultCellStyle.Format = "##,##0.00"
        DtgArt.Columns(9).DefaultCellStyle.Format = "##,##0.00"
        DtgArt.Columns(10).DefaultCellStyle.Format = "##,##0.00"
        DtgArt.Columns(2).Visible = False
        DtgArt.Columns(3).Visible = False
        DtgArt.Columns(4).Visible = False
        DtgArt.Columns(5).Visible = False
        DtgArt.Columns(7).Visible = False
        DtgArt.Columns(8).Visible = False
        DtgArt.Columns(9).Visible = False
        DtgArt.Columns(10).Visible = False
        DtgArt.Columns(11).Visible = False
        DtgArt.Columns(12).Visible = False
        DtgArt.Columns(6).HeaderText = "Precio"
    End Sub
    Private Sub Actualizar()
        If RdtFam.Checked = True Then
            MiClase.cargardatagriview(DtgArt, "select barra,articulo,pcosto,idpr,idfm,idmr,pfinal,util,alic,pneto,iva,stock,familia from articulos inner join familias on articulos.idfm=familias.id where idfm = " & IdFm & "")
            DtgArt.Font = New Font("Arial ", 12, FontStyle.Regular)
            DtgArt.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
            DtgArt.AllowUserToAddRows = False
            DtgArt.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            DtgArt.Columns(2).DefaultCellStyle.Format = "##,##0.00"
            DtgArt.Columns(6).DefaultCellStyle.Format = "##,##0.00"
            DtgArt.Columns(7).DefaultCellStyle.Format = "##,##0.00"
            DtgArt.Columns(8).DefaultCellStyle.Format = "##,##0.00"
            DtgArt.Columns(9).DefaultCellStyle.Format = "##,##0.00"
            DtgArt.Columns(10).DefaultCellStyle.Format = "##,##0.00"
            DtgArt.Columns(2).Visible = False
            DtgArt.Columns(3).Visible = False
            DtgArt.Columns(4).Visible = False
            DtgArt.Columns(5).Visible = False
            DtgArt.Columns(7).Visible = False
            DtgArt.Columns(8).Visible = False
            DtgArt.Columns(9).Visible = False
            DtgArt.Columns(10).Visible = False
            DtgArt.Columns(11).Visible = False
            DtgArt.Columns(12).Visible = False
            DtgArt.Columns(6).HeaderText = "Precio"
        ElseIf RdtMarca.Checked = True Then
            MiClase.cargardatagriview(DtgArt, "select barra,articulo,pcosto,idpr,idfm,idmr,pfinal,util,alic,pneto,iva,stock,familia from articulos inner join familias on articulos.idfm=familias.id where idmr = " & IdMr & "")
            DtgArt.Font = New Font("Arial ", 12, FontStyle.Regular)
            DtgArt.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
            DtgArt.AllowUserToAddRows = False
            DtgArt.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            DtgArt.Columns(2).DefaultCellStyle.Format = "##,##0.00"
            DtgArt.Columns(6).DefaultCellStyle.Format = "##,##0.00"
            DtgArt.Columns(7).DefaultCellStyle.Format = "##,##0.00"
            DtgArt.Columns(8).DefaultCellStyle.Format = "##,##0.00"
            DtgArt.Columns(9).DefaultCellStyle.Format = "##,##0.00"
            DtgArt.Columns(10).DefaultCellStyle.Format = "##,##0.00"
            DtgArt.Columns(2).Visible = False
            DtgArt.Columns(3).Visible = False
            DtgArt.Columns(4).Visible = False
            DtgArt.Columns(5).Visible = False
            DtgArt.Columns(7).Visible = False
            DtgArt.Columns(8).Visible = False
            DtgArt.Columns(9).Visible = False
            DtgArt.Columns(10).Visible = False
            DtgArt.Columns(11).Visible = False
            DtgArt.Columns(12).Visible = False
            DtgArt.Columns(6).HeaderText = "Precio"
        ElseIf RdtProv.Checked = True Then
            MiClase.cargardatagriview(DtgArt, "select barra,articulo,pcosto,idpr,idfm,idmr,pfinal,util,alic,pneto,iva from articulos where idpr = " & IdPr & "")
            DtgArt.Font = New Font("Arial ", 12, FontStyle.Regular)
            DtgArt.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
            DtgArt.AllowUserToAddRows = False
            DtgArt.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            DtgArt.Columns(2).DefaultCellStyle.Format = "##,##0.00"
            DtgArt.Columns(6).DefaultCellStyle.Format = "##,##0.00"
            DtgArt.Columns(7).DefaultCellStyle.Format = "##,##0.00"
            DtgArt.Columns(8).DefaultCellStyle.Format = "##,##0.00"
            DtgArt.Columns(9).DefaultCellStyle.Format = "##,##0.00"
            DtgArt.Columns(10).DefaultCellStyle.Format = "##,##0.00"
            DtgArt.Columns(2).Visible = False
            DtgArt.Columns(3).Visible = False
            DtgArt.Columns(4).Visible = False
            DtgArt.Columns(5).Visible = False
            DtgArt.Columns(7).Visible = False
            DtgArt.Columns(8).Visible = False
            DtgArt.Columns(9).Visible = False
            DtgArt.Columns(10).Visible = False
            DtgArt.Columns(11).Visible = False
            DtgArt.Columns(2).HeaderText = "Precio"
        End If
        Dim filas As Integer = DtgArt.Rows.Count
        If filas = 0 Then
            CmdGrabar.Enabled = False
            CmdPantalla.Enabled = False
            RdtAum.Enabled = False
            Rdtdesc.Enabled = False
            MskPor.Enabled = False
        Else
            CmdGrabar.Enabled = True
            RdtAum.Enabled = True
            RdtAum.Checked = True
            Rdtdesc.Enabled = True
            MskPor.Enabled = True
            CmdPantalla.Enabled = True
        End If

    End Sub
    Private Sub FrmCprecio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LbNom.Text = "Familia"
        EsPr = "2"
        EsFam = 1
        EsMar = "1"
        EsBr = 0
        TxtProv.Focus()
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")
    End Sub

    Private Sub RtpMarca_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdtMarca.CheckedChanged
        If RdtFam.Checked = True Then
            LbNom.Text = "Familia"
        ElseIf RdtMarca.Checked = True Then
            LbNom.Text = "Marca"
        ElseIf RdtProv.Checked = True Then
            LbNom.Text = "Proveedor"
        End If
    End Sub

    Private Sub RdtMarca_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RdtMarca.Click

    End Sub

    Private Sub RdtProv_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdtProv.CheckedChanged
        If RdtFam.Checked = True Then
            LbNom.Text = "Familia"
        ElseIf RdtMarca.Checked = True Then
            LbNom.Text = "Marca"
        ElseIf RdtProv.Checked = True Then
            LbNom.Text = "Proveedor"
        End If
    End Sub

    'Private Sub CmdBus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdBus.Click
    '    TxtProv.Text = ""
    '    CmdGrabar.Enabled = False
    '    DtgArt.DataSource = Nothing
    '    Barra.Value = 0
    '    If RdtFam.Checked = True Then
    '       FrmBfam.Show()
    '   ElseIf RdtMarca.Checked = True Then
    '       FrmBMar.Show()
    '  ElseIf RdtProv.Checked = True Then
    ''      FrmBpr.Show()
    ' End If
    'End Sub

    Private Sub RdtFam_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdtFam.CheckedChanged
        If RdtFam.Checked = True Then
            LbNom.Text = "Familia"
        ElseIf RdtMarca.Checked = True Then
            LbNom.Text = "Marca"
        ElseIf RdtProv.Checked = True Then
            LbNom.Text = "Proveedor"
        End If
    End Sub

    Private Sub TxtProv_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtProv.KeyDown
        If e.KeyCode = Keys.Return Then
            TxtProv.Text = ""
            CmdGrabar.Enabled = False
            DtgArt.DataSource = Nothing
            Barra.Value = 0
            If RdtFam.Checked = True Then
                FrmBfam.Show()
            ElseIf RdtMarca.Checked = True Then
                FrmBMar.Show()
            ElseIf RdtProv.Checked = True Then
                FrmBpr.Show()
            End If
        End If
    End Sub

    Private Sub TxtProv_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtProv.TextChanged
        Actualizar()
    End Sub

    Private Sub CmdGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdGrabar.Click
        'Try
        Dim filas As Integer = DtgArt.Rows.Count
        Dim contador As Integer = 0
        Barra.Minimum = 0
        Barra.Value = 0
        Barra.Maximum = filas
        For i As Integer = 0 To filas - 1
            If IsDBNull(Convert.ToString(DtgArt(0, i).Value)) Then
            Else
                Txtbarra.Text = Convert.ToString(DtgArt(0, i).Value)
            End If
            If IsDBNull(Convert.ToString(DtgArt(1, i).Value)) Then
            Else
                Articulo = Convert.ToString(DtgArt(1, i).Value)
            End If

            If IsDBNull(Convert.ToString(DtgArt(6, i).Value)) Then
            Else
                Pfinal = Convert.ToString(DtgArt(6, i).Value)
            End If
            If IsDBNull(Convert.ToString(DtgArt(6, i).Value)) Then
            Else
                Pcosto = Convert.ToString(DtgArt(6, i).Value)
            End If
            If IsDBNull(Convert.ToString(DtgArt(7, i).Value)) Then
            Else
                Util1 = Convert.ToString(DtgArt(7, i).Value)
            End If
            If IsDBNull(Convert.ToString(DtgArt(8, i).Value)) Then
            Else
                Alic = Convert.ToString(DtgArt(8, i).Value)
            End If
            'Pcos = Pcosto * MskPor.Text / 100
            Pcosto = 0
            'Util = FormatNumber(Pcosto * Util1 / 100, 2)
            'UtilTot = Pcosto + Util

            '        MskIva.Text = Iva
            Neto = FormatNumber(Pfinal * MskPor.Text / 100)
            Total = Pfinal + Neto
            Fcp = Date.Today
            Fcp = Format(Date.Today, "dd/MM/yy")


            MiClase.eliminaactualizaregistra("update articulos set pfinal=" & Str(Total) & ",pcosto=" & Str(Pcosto) & ", " & _
                    "pneto=" & Str(UtilTot) & ",iva= " & Str(Iva) & ",fstock='" & Fcp & "'  where barra=" & Txtbarra.Text & "")

            misdatos = MiClase.traedataset("select isnull(count(codigo),0) from etiquetas where codigo=" & Txtbarra.Text & " ")
            Br = misdatos.Tables(0).Rows(0).Item(0)
            If Br = 0 Then
                MiClase.eliminaactualizaregistra("insert into etiquetas values(" & Txtbarra.Text & ",'" & Articulo & "'," & Pfinal & ")")
            Else
                MiClase.eliminaactualizaregistra("Update etiquetas set precio=" & Str(Pfinal) & " where codigo= " & Str(Txtbarra.Text) & "")
            End If

            ' MiClase.eliminaactualizaregistra("insert into etiquetas values(" & Txtbarra.Text & ",'" & Articulo & "'," & Total & ")")
            Barra.Increment(1)
        Next


        If Barra.Value = Barra.Maximum Then
            Mensaje = MsgBox("Finalizo el proceso", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Finalizo el proceso!!!")
            If Mensaje = vbOK Then
                TxtProv.Text = ""
                TxtProv.Focus()
                MskPor.Text = ""
                RdtAum.Enabled = False
                Rdtdesc.Enabled = False
                CmdGrabar.Enabled = False
                DtgArt.DataSource = Nothing
                Barra.Value = 0
            End If
        End If
        'Catch ex As Exception
        ' MsgBox("Falta Información")
        ' End Try
    End Sub



    Private Sub MskPor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MskPor.KeyDown
        If e.KeyCode = Keys.Return Then
            CmdGrabar.Focus()
        End If
    End Sub


    Private Sub DtgArt_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DtgArt.CellClick
        fila = DtgArt.CurrentRow.Index
        'NumFac = DtgArt.Item(0, fila).Value
        Articulo = DtgArt.Item(1, fila).Value
        MskPrecio.Text = FormatNumber(DtgArt.Item(2, fila).Value, 2)
        Stk = FormatNumber(DtgArt.Item(11, fila).Value, 2)
    End Sub

    Private Sub DtgArt_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DtgArt.CellEndEdit
        'Try
        fila = CType((e.RowIndex.ToString()), Integer) ''Obtiene la fila actual
        Txtbar.Text = DtgArt.Item(0, fila).Value
        Articulo = Trim(DtgArt.Item(1, fila).Value)
        Total = CDec(DtgArt.Item(6, fila).Value)
        Fcp = Date.Today
        Fcp = Format(Date.Today, "dd/MM/yy")
        If TxtBarr.Text = "" Then
            TxtBarr.Text = TxtBar1.Text
        End If
        MiClase.eliminaactualizaregistra("update articulos set pfinal=" & Str(Total) & ",pcosto=" & Str(Pcosto) & ", " & _
               "pneto=" & Str(Pneto) & ",iva= " & Str(Iva) & ",fstock='" & Fcp & "' where barra=" & Txtbar.Text & "")
        misdatos = MiClase.traedataset("select isnull(count(codigo),0) from etiquetas where codigo=" & Txtbar.Text & " ")
        Br = misdatos.Tables(0).Rows(0).Item(0)
        If Br = 0 Then
            MiClase.eliminaactualizaregistra("insert into etiquetas values(" & Txtbar.Text & ",'" & Articulo & "'," & Total & ")")
        Else
            MiClase.eliminaactualizaregistra("Update etiquetas set precio=" & Str(Total) & " where codigo= " & Str(Txtbar.Text) & "")
        End If
        'Catch ex As Exception
        ' MsgBox("Falta Informacion")
        ' End Try

    End Sub

    Private Sub MskPrecio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Return Then
            Try
                'Pcosto = Decimal.Parse(MskPrecio.Text, System.Globalization.CultureInfo.GetCultureInfo("es-us"))
                Pcosto = MskPrecio.Text
                Util = FormatNumber(Pcosto * Util1 / 100, 2)
                UtilTot = Pcosto + Util
                Iva = FormatNumber(UtilTot * Alic / 100, 2)
                '        MskIva.Text = Iva
                Total = UtilTot + Iva
                Neto = Total - Iva
            Catch ex As Exception
                MsgBox("Falta Informacion")
            End Try
            MiClase.eliminaactualizaregistra("update articulos set pfinal=" & Str(Total) & ",pcosto=" & Str(Pcosto) & ", " & _
                   "pneto=" & Str(UtilTot) & ",iva= " & Str(Iva) & ",fstock='" & Date.Today & "'   where barra=" & NumFac & "")
            Actualizar()
            MskPrecio.Text = ""
            MskPrecio.Enabled = False
        End If

    End Sub

    Private Sub MskPrecio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False
        End If
    End Sub



    Private Sub CmdPantalla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdPantalla.Click
        If OptLaser.Checked = True Then
            MiClase.cargardatagriview(DtgArt, "select codigo,articulo,precio from etiquetas")
            Dim Mn As New DtcArticulo
            'traigo los articulos para imprimir etiquetas
            Dim Fila2 As DtcArticulo.ArticulosRow
            DtgArt.AllowUserToAddRows = False
            For i As Integer = 0 To DtgArt.RowCount - 1
                Fila2 = Mn.Articulos.NewArticulosRow
                Fila2.Codigo = DtgArt(0, i).Value
                Fila2.Articulo = DtgArt(1, i).Value
                Fila2.Precio = DtgArt(2, i).Value
                Mn.Articulos.AddArticulosRow(Fila2)
            Next
            Dim rpt As New CryEtiquetas
            rpt.SetDataSource(Mn)
            Reportes.CrystalReportViewer1.ReportSource = rpt
            Reportes.Show()
        ElseIf OptComandera.Checked = True Then
            misdatos = MiClase.traedataset("select impresora from configuracion where pc=" & Pc & "")
            Impresora = Trim(misdatos.Tables(0).Rows(0).Item(0))
            Dim printDoc As New PrintDocument
            printDoc.PrinterSettings.PrinterName = Impresora
            AddHandler printDoc.PrintPage, AddressOf print_PrintEtiqueta
            printDoc.Print()

        End If
    End Sub

    Private Sub TxtBar1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtBar1.DoubleClick
        TxtBar1.Clear()
        DtgArt.DataSource = Nothing
        EsBr = 1
    End Sub

    Private Sub TxtBar1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtBar1.GotFocus
        If EsBr = 0 Then
        ElseIf EsBr = 1 Then
            MiClase.cargardatagriview(DtgArt, "select barra,articulo,pcosto,idpr,idfm,idmr,pfinal,util,alic,pneto,iva,stock,familia from articulos inner join familias on articulos.idfm=familias.id where barra = " & TxtBarr.Text & "")
            DtgArt.Font = New Font("Arial ", 12, FontStyle.Regular)
            DtgArt.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
            DtgArt.AllowUserToAddRows = False
            DtgArt.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            DtgArt.Columns(2).DefaultCellStyle.Format = "##,##0.00"
            DtgArt.Columns(6).DefaultCellStyle.Format = "##,##0.00"
            DtgArt.Columns(7).DefaultCellStyle.Format = "##,##0.00"
            DtgArt.Columns(8).DefaultCellStyle.Format = "##,##0.00"
            DtgArt.Columns(9).DefaultCellStyle.Format = "##,##0.00"
            DtgArt.Columns(10).DefaultCellStyle.Format = "##,##0.00"
            '    DtgArt.Columns(2).Visible = False
            DtgArt.Columns(3).Visible = False
            DtgArt.Columns(4).Visible = False
            DtgArt.Columns(5).Visible = False
            DtgArt.Columns(7).Visible = False
            DtgArt.Columns(8).Visible = False
            DtgArt.Columns(9).Visible = False
            DtgArt.Columns(10).Visible = False
            DtgArt.Columns(12).Visible = False
            DtgArt.Columns(6).HeaderText = "Precio"
            DtgArt.Columns(2).HeaderText = "Costo"
            EsBr = 0
        End If
    End Sub

    Private Sub TxtBar1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtBar1.KeyDown
        If e.KeyCode = Keys.Return Then
            If IsNumeric(TxtBar1.Text) Then
                MiClase.cargardatagriview(DtgArt, "select barra,articulo,pcosto,idpr,idfm,idmr,pfinal,util,alic,pneto,iva,stock,familia from articulos inner join familias on articulos.idfm=familias.id where barra = " & TxtBar1.Text & "")
                DtgArt.Font = New Font("Arial ", 12, FontStyle.Regular)
                DtgArt.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
                DtgArt.AllowUserToAddRows = False
                DtgArt.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                DtgArt.Columns(2).DefaultCellStyle.Format = "##,##0.00"
                DtgArt.Columns(6).DefaultCellStyle.Format = "##,##0.00"
                DtgArt.Columns(7).DefaultCellStyle.Format = "##,##0.00"
                DtgArt.Columns(8).DefaultCellStyle.Format = "##,##0.00"
                DtgArt.Columns(9).DefaultCellStyle.Format = "##,##0.00"
                DtgArt.Columns(10).DefaultCellStyle.Format = "##,##0.00"
                'DtgArt.Columns(2).Visible = False
                DtgArt.Columns(3).Visible = False
                DtgArt.Columns(4).Visible = False
                DtgArt.Columns(5).Visible = False
                DtgArt.Columns(7).Visible = False
                DtgArt.Columns(8).Visible = False
                DtgArt.Columns(9).Visible = False
                DtgArt.Columns(10).Visible = False
                DtgArt.Columns(12).Visible = False
                DtgArt.Columns(2).HeaderText = "Costo"
                DtgArt.Columns(6).HeaderText = "Precio"
            Else
                'cargo la busqueda de articulos
                EsAr = "3"
                EsBr = 1
                Bart = TxtBar1.Text
                FrmBarticulos.Show()
            End If


        End If
    End Sub

    Private Sub TxtBar1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBar1.TextChanged

    End Sub

    Private Sub CmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdBorrar.Click
        Mensaje = MsgBox("Desea Vaciar la Bandeja", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "Vaciar Bandeja!!!")
        If Mensaje = MsgBoxResult.Ok Then
            MiClase.eliminaactualizaregistra("delete from etiquetas")
            DtgArt.DataSource = Nothing
        End If
    End Sub

    Private Sub DtgArt_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DtgArt.CellContentClick

    End Sub
End Class