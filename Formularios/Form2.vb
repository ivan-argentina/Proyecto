'Imports System
Imports System.Text
Imports System.Runtime.InteropServices
Imports System.Drawing.Printing
Imports System.Drawing

'Imports System.String

Public Class Form2
    Dim IdPr As String
    Dim mail As String
    Dim telefono As String
    Dim Fax As String
    Dim IdCl As Integer
    Dim Clie As String
    Dim Direccion As String
    Dim Cuit As String
    Dim IdCiu As Integer
    Dim IdCiva As Integer
    Dim Dcuit As String
    Dim Mcuit As String
    Dim ICuit As String
    Dim Lcuit As Integer
    Dim Bar As String
    Dim Chk As DataGridViewCheckBoxColumn = New DataGridViewCheckBoxColumn(False)

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
        MiClase.cargardatagriview(Dtget, "select codigo,articulo,precio from etiquetas")
        'traigo los articulos para imprimir etiquetas
        Dtget.AllowUserToAddRows = False
        For i As Integer = 0 To Dtget.RowCount - 1
            Articulo = Trim(Dtget(1, i).Value)
            PrecioEtiqueta = FormatNumber(Dtget(2, i).Value, 2)
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

    Private Sub Actualizar()
        If RdtFam.Checked = True Then
            MiClase.cargardatagriview(DtgCli, "select barra,articulo,pfinal from articulos where idfm = " & IdFm & " order by articulo  ")
            DtgCli.Columns(1).Width = 300
            DtgCli.Columns(1).HeaderText = "Articulos"
            DtgCli.Columns.Add(Chk)
            Chk.HeaderText = "Estado"
            DtgCli.Font = New Font("Arial ", 12, FontStyle.Regular)
            DtgCli.AllowUserToAddRows = False
        ElseIf RdtMarca.Checked = True Then
            MiClase.cargardatagriview(DtgCli, "select barra,articulo,pfinal from articulos where idmr = " & IdMr & " order by articulo  ")
            DtgCli.Columns(1).Width = 300
            DtgCli.Columns(1).HeaderText = "Articulos"
            DtgCli.Columns.Add(Chk)
            Chk.HeaderText = "Estado"
            DtgCli.Font = New Font("Arial ", 12, FontStyle.Regular)
            DtgCli.AllowUserToAddRows = False
        ElseIf RdtProv.Checked = True Then
            MiClase.cargardatagriview(DtgCli, "select barra,articulo,pfinal from articulos where idpr = " & Id & " order by articulo  ")
            DtgCli.Columns(1).Width = 300
            DtgCli.Columns(1).HeaderText = "Articulos"
            DtgCli.Columns.Add(Chk)
            Chk.HeaderText = "Estado"
            DtgCli.Font = New Font("Arial ", 12, FontStyle.Regular)
            DtgCli.AllowUserToAddRows = False
        End If
        CmdEtiqueta.Enabled = True
    End Sub



    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EsFam = 2
        EsMar = 3
        EsPr = 6
        TxtProv.Focus()
    End Sub

    

    Private Sub DtgCli_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DtgCli.GotFocus
        If TxtProv.Text = "" Then
        Else
            Actualizar()
        End If

    End Sub

    Private Sub TxtProv_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtProv.TextChanged

    End Sub

    Private Sub CmdEtiqueta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdEtiqueta.Click
        Dim Br As Integer
        For i As Integer = 0 To DtgCli.Rows.Count() - 1
            Dim C As Boolean
            Bar = DtgCli.Rows(i).Cells(0).Value
            Articulo = Trim(DtgCli.Rows(i).Cells(1).Value)
            Pfinal = DtgCli.Rows(i).Cells(2).Value
            C = DtgCli.Rows(i).Cells(3).Value
            If C = True Then
                'MiClase.eliminaactualizaregistra("delete from articulos where barra='" & Bar & "'")
                'Cargo  los Items
                misdatos = MiClase.traedataset("select isnull(count(codigo),0) from etiquetas where codigo=" & Bar & " ")
                Br = misdatos.Tables(0).Rows(0).Item(0)
                If Br = 0 Then
                    MiClase.eliminaactualizaregistra("insert into etiquetas values(" & Bar & ",'" & Articulo & "'," & Pfinal & ")")
                Else
                    MiClase.eliminaactualizaregistra("Update etiquetas set precio=" & Str(Pfinal) & " where codigo= " & Bar & "")
                End If
            Else
            End If
        Next
        DtgCli.Columns.Remove(Chk)
        DtgCli.DataSource = Nothing
        TxtProv.Text = ""
        TxtProv.Focus()
        RdtFam.Checked = True
    

    End Sub

    Private Sub CmdBorrar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdBorrar.Click
        If OptLaser.Checked = True Then
            MiClase.cargardatagriview(Dtget, "select codigo,articulo,precio from etiquetas")
            Dim Mn As New DtcArticulo
            'traigo los articulos para imprimir etiquetas
            Dim Fila2 As DtcArticulo.ArticulosRow
            Dtget.AllowUserToAddRows = False
            For i As Integer = 0 To Dtget.RowCount - 1
                Fila2 = Mn.Articulos.NewArticulosRow
                Fila2.Codigo = Dtget(0, i).Value
                Fila2.Articulo = Dtget(1, i).Value
                Fila2.Precio = Dtget(2, i).Value
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
            'printDoc.PrinterSettings.PrinterName = "SAM4S GIANT-100"
            printDoc.PrinterSettings.PrinterName = Impresora
            AddHandler printDoc.PrintPage, AddressOf print_PrintEtiqueta
            printDoc.Print()

        End If
    End Sub


    Private Sub CmdVaciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdVaciar.Click
        MiClase.eliminaactualizaregistra("delete from etiquetas")
    End Sub

    Private Sub CmdBus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdBus.Click
        TxtProv.Text = ""
        'CmdGrabar.Enabled = False
        DtgCli.DataSource = Nothing
        'Barra.Value = 0
        If RdtFam.Checked = True Then
            FrmBfam.Show()
        ElseIf RdtMarca.Checked = True Then
            FrmBMar.Show()
        ElseIf RdtProv.Checked = True Then
            FrmBpr.Show()
        End If
    End Sub

    Private Sub TxtBarra_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtBarra.KeyDown
        If e.KeyCode = Keys.Return Then
            MiClase.cargardatagriview(DtgCli, "select barra,articulo,pfinal from articulos where barra = " & TxtBarra.Text & " order by articulo  ")
            DtgCli.Columns(1).Width = 300
            DtgCli.Columns(1).HeaderText = "Articulos"
            DtgCli.Columns.Add(Chk)
            Chk.HeaderText = "Estado"
            DtgCli.Font = New Font("Arial ", 12, FontStyle.Regular)
            DtgCli.AllowUserToAddRows = False
            DtgCli.Focus()
            CmdEtiqueta.Enabled = True
            TxtBarra.Text = ""
        End If
    End Sub

    Private Sub TxtBarra_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBarra.TextChanged

    End Sub

    Private Sub RdtFam_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdtFam.CheckedChanged
        If RdtFam.Checked = True Then
            LbNom.Text = "Familia"
        ElseIf RdtMarca.Checked = True Then
            LbNom.Text = "Marca"
        ElseIf RdtProv.Checked = True Then
            LbNom.Text = "Proveedor"
        End If
    End Sub

    Private Sub GroupBox5_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox5.Enter

    End Sub

    
End Class




