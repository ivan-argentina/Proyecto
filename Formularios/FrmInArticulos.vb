Public Class FrmInArticulos
    ''Para usar en todos los form se usa public
    Public botonregistra As String
    Public boonbusca As String
    Private Sub Barticulo()

        misdatos = MiClase.traedataset("select articulos.barra,articulo,pfinal,stock,proveedor,familia,marca,idpr,idfm,idmr,fstock,smin,pcosto,util,alic,pneto,iva,idiv,idact,actividad,moneda,pcostod,unidad,abu,ob from articulos inner join proveedor on articulos.idpr=proveedor.id inner join familias on articulos.idfm=familias.id inner join marcas on articulos.idmr=marcas.id inner join actividad on articulos.idact=actividad.id where articulos.barra = " & TxtBarra.Text & "")

        TxtBarra.Text = misdatos.Tables(0).Rows(0).Item(0)
        Txtarticulo.Text = misdatos.Tables(0).Rows(0).Item(1)
        MskTotal.Text = FormatNumber(misdatos.Tables(0).Rows(0).Item(2), 2)
        MskStock.Text = misdatos.Tables(0).Rows(0).Item(3)
        TxtProv.Text = misdatos.Tables(0).Rows(0).Item(4)
        TxtFam.Text = misdatos.Tables(0).Rows(0).Item(5)
        TxtMar.Text = misdatos.Tables(0).Rows(0).Item(6)
        TxtCodPr.Text = misdatos.Tables(0).Rows(0).Item(7)
        TxtCfam.Text = misdatos.Tables(0).Rows(0).Item(8)
        TxtCMar.Text = misdatos.Tables(0).Rows(0).Item(9)
        'MskFecha.Text = misdatos.Tables(0).Rows(0).Item(10)
        MskStMin.Text = misdatos.Tables(0).Rows(0).Item(11)
        MskPcos.Text = FormatNumber(misdatos.Tables(0).Rows(0).Item(12), 2)
        MskUtil.Text = FormatNumber(misdatos.Tables(0).Rows(0).Item(13), 2)
        MskPneto.Text = FormatNumber(misdatos.Tables(0).Rows(0).Item(15), 2)
        MskIva.Text = FormatNumber(misdatos.Tables(0).Rows(0).Item(16), 2)
        IdIva = FormatNumber(misdatos.Tables(0).Rows(0).Item(17), 2)
        IdAct = FormatNumber(misdatos.Tables(0).Rows(0).Item(18), 2)
        TxtActividad.Text = misdatos.Tables(0).Rows(0).Item(19)
        CmbPes.Text = misdatos.Tables(0).Rows(0).Item(20)
        MskPcosD.Text = FormatNumber(misdatos.Tables(0).Rows(0).Item(21), 2)
        CmbUnidad.Text = misdatos.Tables(0).Rows(0).Item(22)
        AbUn = misdatos.Tables(0).Rows(0).Item(23)
        TxtOb.Text = misdatos.Tables(0).Rows(0).Item(24)
        Habilitar()
        CmdModificar.Enabled = True
        CmdEliminar.Enabled = True
        Txtarticulo.Enabled = True
        CmdBuscar.Enabled = False

    End Sub
    Private Sub barra1()
        If TxtBarra.Text = "No dejar en blanco" Or TxtBarra.Text = "" Then
            ' Mensaje = MsgBox("Tiene que Ingresar Un Codigo", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Falta Codigo!!!")
            ' If Mensaje = MsgBoxResult.Ok Then
            ' TxtBarra.Text = "No dejar en blanco"
            ' TxtBarra.Focus()
            Txtarticulo.Enabled = True
            Txtarticulo.Focus()
        End If

        'Dim existecodigo As String
        Dim dsdataset As New DataSet
        dsdataset = MiClase.traedataset("select barra from articulos where barra='" & TxtBarra.Text & "'")
        Dim totalregistros As Integer = dsdataset.Tables(0).Rows.Count
        If totalregistros = 0 Then
            '    MsgBox("Este codigo d ebarra no existe, Debes agregarlo a la base de datos", MsgBoxStyle.Critical)
            Habilitar()
            Txtarticulo.Focus()
        Else
            Mensaje = MsgBox("Este Articulo ya Existe", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Articulo Existente!!!")
            If Mensaje = MsgBoxResult.Ok Then
                TxtBarra.Text = "No dejar en blanco"
                TxtBarra.Focus()
            End If

        End If
    End Sub
    Private Sub Habilitar()
        Txtarticulo.Enabled = True
        Txtarticulo.MaxLength = 50
        TxtCodPr.Enabled = True
        TxtProv.Enabled = True
        TxtCfam.Enabled = True
        TxtFam.Enabled = True
        TxtCMar.Enabled = True
        TxtMar.Enabled = True
        'MskFecha.Enabled = True
        MskStock.Enabled = True
        MskStMin.Enabled = True
        TxtActividad.Enabled = True
        MskPcos.Enabled = True
        MskUtil.Enabled = True
        MskPneto.Enabled = True
        MskIva.Enabled = True
        CmbPes.Enabled = True
        CmbUnidad.Enabled = True
        TxtOb.Enabled = True
        If IdIva = 0 Then
            IdIva = 5
        End If
        If IdIva > 0 Then
            MiClase.cargar_Combo(CmbIva, "select alic,id,ord from alic_iva  where id=" & IdIva & " ")
        Else
            If CmdModificar.Enabled = False Then
                MiClase.cargar_Combo(CmbIva, "select alic,id,ord from alic_iva  order by ord")
            End If
        End If
        CmbIva.Enabled = True
        MskTotal.Enabled = True
        CmbPes.Enabled = True
        MskPcosD.Enabled = True
    End Sub

    Private Sub Blanquear()
        TxtBarra.Clear()
        Txtarticulo.Clear()
        Txtarticulo.Enabled = False
        TxtCodPr.Clear()
        TxtCodPr.Enabled = False
        TxtProv.Clear()
        TxtProv.Enabled = False
        TxtCfam.Clear()
        TxtCfam.Enabled = False
        TxtFam.Clear()
        TxtFam.Enabled = False
        TxtCMar.Clear()
        TxtCMar.Enabled = False
        TxtMar.Clear()
        TxtMar.Enabled = False
        MskStock.Clear()
        MskStock.Enabled = False
        MskStMin.Clear()
        MskStMin.Enabled = False
        MskPcos.Clear()
        MskPcos.Enabled = False
        MskUtil.Clear()
        MskUtil.Enabled = False
        MskPneto.Clear()
        MskPneto.Enabled = False
        TxtOb.Clear()
        TxtOb.Enabled = False
        MiClase.cargar_Combo(CmbIva, "select alic,id,ord from alic_iva order by ord")
        CmbIva.Enabled = False
        MskTotal.Clear()
        MskTotal.Enabled = False
        'MskFecha.Clear()
        'MskFecha.Enabled = False
        MskIva.Clear()
        MskIva.Enabled = False
        CmdBuscar.Enabled = True
        CmdModificar.Enabled = False
        CmdEliminar.Enabled = False
        TxtActividad.Clear()
        IdAct = "0"
        CmbPes.Text = "Pesos"
        CmbPes.Enabled = False
        CmbUnidad.Enabled = False
        MskPcosD.Clear()
        MskPcosD.Enabled = False
        TxtBarra.Focus()
    End Sub

    Private Sub Txtarticulo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txtarticulo.GotFocus
        Habilitar()
    End Sub

    Private Sub TxtBarra_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtBarra.GotFocus
        'Blanquear()
    End Sub
    Private Sub TxtBarra_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtBarra.KeyDown
        If e.KeyData = Keys.Enter Then
            If TxtBarra.Text = "No dejar en blanco" Or TxtBarra.Text = "" Then
                Txtarticulo.Enabled = True
                Txtarticulo.Focus()
            Else
                Dim dsdataset As New DataSet
                dsdataset = MiClase.traedataset("select barra from articulos where barra='" & TxtBarra.Text & "'")
                Dim totalregistros As Integer = dsdataset.Tables(0).Rows.Count
                If totalregistros = 0 Then
                    MsgBox("Este codigo d ebarra no existe, Debes agregarlo a la base de datos", MsgBoxStyle.Critical)
                    Habilitar()
                    Txtarticulo.Focus()
                Else
                    '           Mensaje = MsgBox("Este Articulo ya Existe", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Articulo Existente!!!")
                    Barticulo()
                    If Mensaje = MsgBoxResult.Ok Then
                        '                TxtBarra.Text = "No dejar en blanco"
                        TxtBarra.Focus()
                    End If

                End If


            End If
        End If


    End Sub

    Private Sub TxtCfam_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCfam.Click
        FrmBfam.Show()
    End Sub

    Private Sub TxtCMar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCMar.Click
        FrmBMar.Show()
    End Sub

    Private Sub TxtCMar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCMar.KeyDown
        If e.KeyData = Keys.Enter And TxtCMar.Text = "" Then
            FrmBMar.Show()
        ElseIf e.KeyData = Keys.Enter Then
            FRmBAct.Show()
        End If
    End Sub

    Private Sub TxtCMar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCMar.TextChanged

    End Sub


    Private Sub FrmInArticulos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CmbPes.Items.Add("Pesos")
        CmbPes.Items.Add("Dolares")
        CmbPes.Text = "Pesos"
        misdatos = MiClase.traedataset("select  dolar from dolar where id=" & 1 & "")
        TxtDolar.Text = FormatNumber(misdatos.Tables(0).Rows(0).Item(0), 2)
        BtnAct.Enabled = False
        EsMar = "0"
        EsFam = "0"
        EsAr = "0"
        EsPr = "0"
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Dim misdatos As New DataSet()
        ''Aqui puedes traer un solo dato o muchos segun la consulta sql
        ''..................................traera dos datos
        ''.....................................  0    1
        misdatos = MiClase.traedataset("select ciudad,cpostal from ciudad where id=" & 1 & " ")

        'Como se sabe en la consulta trae un solo dato se carga directo
        ',,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,columna 0 fla 0
        TxtBarra.Text = misdatos.Tables(0).Rows(0).Item(0)
        ',,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,columna 0 fla 2
        Txtarticulo.Text = misdatos.Tables(0).Rows(0).Item(1)
        'For Each row As DataRow In misdatos.Rows

        '    campo = row("campo1").ToString





        'Next
    End Sub


    Private Sub TxtCodPr_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCodPr.Click
        FrmBpr.Show()
    End Sub

    Private Sub TxtCodPr_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCodPr.KeyDown
        If e.KeyData = Keys.Enter And TxtCodPr.Text = "" Then
            FrmBpr.Show()
        ElseIf e.KeyData = Keys.Enter Then
            TxtOb.Focus()
        End If
    End Sub

    Private Sub MskTotal_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MskTotal.GotFocus
        'Me.MskTotal.Text = Format(valor, "###0.00") 'esto te da 1050.00
        MskTotal.SelectionStart = 0
        MskTotal.SelectionLength = MskTotal.Text.Length

    End Sub

    Private Sub MskTotal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MskTotal.KeyDown
        If e.KeyCode = Keys.Return Then
            If CmdModificar.Enabled = False Then
                '                Pfinal = Decimal.Parse(MskTotal.Text, System.Globalization.CultureInfo.GetCultureInfo("es-Us"))
                Pfinal = MskTotal.Text
                AlicDisc = CmbIva.Text / 100 + 1
                MskPneto.Text = FormatNumber(Pfinal / AlicDisc, 2)
                MskIva.Text = FormatNumber(Pfinal - MskPneto.Text, 2)
                ' Pneto = Decimal.Parse(MskPneto.Text, System.Globalization.CultureInfo.GetCultureInfo("es-es"))
                '  Iva = Decimal.Parse(MskIva.Text, System.Globalization.CultureInfo.GetCultureInfo("es-es"))
                Pneto = MskPneto.Text
                Iva = MskIva.Text
                Alic = CmbIva.Text
                IdIva = CInt(CmbIva.SelectedValue(1))
                FcD = Date.Today
                FcD = Format(Date.Today, "dd/MM/yy")
                MiClase.eliminaactualizaregistra("insert into articulos values(" & TxtBarra.Text & ",'" & Txtarticulo.Text & "', " & _
                  "" & TxtCodPr.Text & "," & TxtCfam.Text & ", " & TxtCMar.Text & "," & IdAct & ",'" & FcD & "'," & MskStock.Text & ", " & _
                  "" & MskStMin.Text & "," & Str(Pcos) & "," & Str(CosDolar) & "," & Str(Cambio) & ",'" & CmbPes.Text & "'," & Str(Util) & "," & Str(Alic) & "," & Str(Pneto) & ", " & _
                  "" & Str(Iva) & "," & Str(Pfinal) & "," & IdIva & ",'" & CmbUnidad.Text & "','" & AbUn & "','" & TxtOb.Text & "')")

                MiClase.eliminaactualizaregistra("insert into etiquetas values(" & TxtBarra.Text & ",'" & Txtarticulo.Text & "'," & Pfinal & ")")

                Blanquear()
            Else

                CmdModificar.Focus()
            End If
        End If
    End Sub

    Private Sub MskTotal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MskTotal.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False
        End If
    End Sub
    Private Sub MaskedTextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MskTotal.LostFocus
        If CmdModificar.Enabled = True Then
            'Pfinal = Decimal.Parse(MskTotal.Text, System.Globalization.CultureInfo.GetCultureInfo("es-us"))
            Pfinal = MskTotal.Text
            'End If
            AlicDisc = CmbIva.Text / 100 + 1
            MskPneto.Text = FormatNumber(Pfinal / AlicDisc, 2)
            Pneto = Decimal.Parse(MskPneto.Text, System.Globalization.CultureInfo.GetCultureInfo("es-es"))
            Pneto = MskPneto.Text
            Iva = FormatNumber(Pfinal - Pneto, 2)
            ' Pcosto = MskPcos.Text
            Pcos = Decimal.Parse(MskPcos.Text, System.Globalization.CultureInfo.GetCultureInfo("es-es"))
            Util = MskUtil.Text
            Alic = CmbIva.Text
            ' Pneto = MskPneto.Text
            'Iva = MskIva.Text
            'Pfinal = MskTotal.Textk
            IdIva = CInt(CmbIva.SelectedValue(1))
            '  Me.MskTotal.Text = Format(CType(Me.MskTotal.Text, Decimal), "#,##0.00")
        End If
    End Sub
    Private Sub TxtCfam_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCfam.KeyDown
        If e.KeyData = Keys.Enter And TxtCfam.Text = "" Then
            FrmBfam.Show()
        ElseIf e.KeyData = Keys.Enter Then
            FrmBMar.Show()
        End If
    End Sub

    Private Sub TxtCfam_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCfam.TextChanged

    End Sub

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub MskFecha_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Return Then
            CmbUnidad.Focus()
        End If
    End Sub

    Private Sub MskStMin_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MskStMin.KeyDown
        If e.KeyCode = Keys.Return Then
            CmbPes.Focus()
        End If
    End Sub

    Private Sub MskStMin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MskStMin.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub MskStock_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MskStock.KeyDown
        If e.KeyCode = Keys.Return Then
            MskStMin.Focus()
        End If
    End Sub

    Private Sub MskPcos_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MskPcos.GotFocus
        'Me.MskPcos.Text = Format(valor, "###0.00") 'esto te da 1050.00
        MskPcos.SelectionStart = 0
        MskPcos.SelectionLength = MskPcos.Text.Length

    End Sub

    Private Sub MskPcos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MskPcos.KeyDown
        If e.KeyCode = Keys.Return Then
            MskUtil.Focus()
        End If
    End Sub

    Private Sub MskPcos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MskPcos.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub MskPcos_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles MskPcos.Leave
        '  Me.MskPcos.Text = Format(CType(Me.MskPcos.Text, Decimal), "#.##0,00")
    End Sub


    Private Sub MskPcos_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MskPcos.LostFocus
        CmbPes.Text = Trim(CmbPes.Text)
        If CmbPes.Text = "Dolares" Then
            'CosDolar = Decimal.Parse(MskPcosD.Text, System.Globalization.CultureInfo.GetCultureInfo("es-Us"))
            CosDolar = MskPcosD.Text
            'Cambio = Decimal.Parse(TxtDolar.Text, System.Globalization.CultureInfo.GetCultureInfo("es-es"))
            Cambio = TxtDolar.Text
            MskPcos.Text = FormatNumber(CosDolar * Cambio, 2)
        ElseIf CmbPes.Text = "Pesos" Then
            CosDolar = 0
            Cambio = 0
        End If
    End Sub

    Private Sub MskPneto_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MskPneto.GotFocus
        'Me.MskPneto.Text = Format(valor, "###0.00") 'esto te dato 1050.00
        MskPneto.SelectionStart = 0
        MskPneto.SelectionLength = MskPneto.Text.Length
    End Sub

    Private Sub MskPneto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MskPneto.KeyDown
        If e.KeyCode = Keys.Return Then
            MskIva.Focus()
        End If
    End Sub

    Private Sub MskPneto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MskPneto.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub MskPneto_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles MskPneto.Leave
        If MskPneto.Text = "" Then
            MskPneto.Text = "0"
        End If
    End Sub

    Private Sub MskPneto_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MskPneto.LostFocus
        'Me.MskPneto.Text = Format(CType(Me.MskPneto.Text, Decimal), "#,##0.00")
    End Sub

    Private Sub MskUtil_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MskUtil.GotFocus
        'Me.MskUtil.Text = Format(valor, "###0.00") 'esto te da 1050.00
        MskUtil.SelectionStart = 0
        MskUtil.SelectionLength = MskUtil.Text.Length
    End Sub

    Private Sub MskUtil_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MskUtil.KeyDown
        If e.KeyCode = Keys.Return Then
            CmbIva.Focus()
        End If
    End Sub

    Private Sub MskUtil_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MskUtil.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub MskUtil_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles MskUtil.Leave
        If MskUtil.Text = "" Then
            MskUtil.Text = "0"
        End If
    End Sub


    Private Sub TxtBarra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBarra.KeyPress
        'If Char.IsDigit(e.KeyChar) Then
        ' e.Handled = False
        ' ElseIf Char.IsControl(e.KeyChar) Then
        ' e.Handled = False
        ' Else
        ' e.Handled = True
        ' End If
    End Sub

    Private Sub MskStock_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MskStock.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    Private Sub CmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdBuscar.Click
        EsAr = "0"
        FrmBarticulos.Show()
    End Sub



    Private Sub CmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdModificar.Click

        Try

            Fc = Date.Today
            Fc = Format(Date.Today, "dd/MM/yy")
            IdIva = CInt(CmbIva.SelectedValue(1))
            MiClase.eliminaactualizaregistra("update articulos set articulo='" & Txtarticulo.Text & "',idpr=" & TxtCodPr.Text & ", " & _
             "idfm=" & TxtCfam.Text & ",idmr=" & TxtCMar.Text & ",fstock='" & Date.Today & "',stock=" & MskStock.Text & ", " & _
             "smin=" & MskStMin.Text & ",pcosto=" & Str(Pcos) & ",util= " & Str(Util) & ",pneto=" & Str(Pneto) & ", iva=" & Str(Iva) & ",pfinal= " & Str(Pfinal) & "," & _
             "alic=" & Str(Alic) & ",idiv=" & Val(IdIva) & ",idact=" & IdAct & ",pcostod=" & Str(CosDolar) & ",cambio=" & Str(TxtDolar.Text) & ",moneda='" & CmbPes.Text & "'," & _
             "unidad='" & CmbUnidad.Text & "',abu='" & AbUn & "',ob='" & TxtOb.Text & "' where barra=" & TxtBarra.Text & "")
            misdatos = MiClase.traedataset("select isnull(count(codigo),0) from etiquetas where codigo=" & TxtBarra.Text & " ")
            Br = misdatos.Tables(0).Rows(0).Item(0)
            If Br = 0 Then
                MiClase.eliminaactualizaregistra("insert into etiquetas values(" & TxtBarra.Text & ",'" & Txtarticulo.Text & "'," & Pfinal & ")")
            Else
                MiClase.eliminaactualizaregistra("Update etiquetas set precio=" & Str(Pfinal) & " where codigo= " & Str(TxtBarra.Text) & "")
            End If
            Blanquear()
        Catch ex As Exception

        End Try
    End Sub

   

    Private Sub CmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdEliminar.Click
        Mensaje = MsgBox("Desea Eliminar el Articulo: " & Txtarticulo.Text & "", MsgBoxStyle.YesNo, "Eliminar Articulo!!!")
        If Mensaje = MsgBoxResult.Yes Then
            MiClase.eliminaactualizaregistra("delete from articulos where barra=" & TxtBarra.Text & "")
            Blanquear()
        End If

    End Sub

    Private Sub TxtBarra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBarra.Click
        Blanquear()
    End Sub
    Private Sub MskStock_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles MskStock.Leave
        If MskStock.Text = "" Then
            MskStock.Text = "0"
        End If
    End Sub

    Private Sub MskStMin_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles MskStMin.Leave
        If MskStMin.Text = "" Then
            MskStMin.Text = "0"
        End If
    End Sub

    Private Sub MskStMin_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles MskStMin.MaskInputRejected

    End Sub

    Private Sub CmbIva_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbIva.Click
        MiClase.cargar_Combo(CmbIva, "select alic,id,ord from alic_iva")
    End Sub

    Private Sub CmbIva_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbIva.GotFocus
        '  CmbIva.BackColor = Color.AliceBlue

    End Sub
    Private Sub CmbIva_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbIva.KeyDown
        If e.KeyCode = Keys.Return Then
            If CmdModificar.Enabled = True Then
                CmdModificar.Focus()
            Else
                MskPneto.Focus()
            End If

        End If
    End Sub

    Private Sub CmbIva_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbIva.LostFocus
        Try
            CmbPes.Text = Trim(CmbPes.Text)
            Pcos = "0"
            Util = "0"
            If CmbPes.Text = "Pesos" Then
                'Pcos = Decimal.Parse(MskPcos.Text, System.Globalization.CultureInfo.GetCultureInfo("es-us"))
                Pcos = MskPcos.Text
                'Util = Decimal.Parse(MskUtil.Text, System.Globalization.CultureInfo.GetCultureInfo("es-us"))
                Util = MskUtil.Text
                UtilNet = (Pcos * Util / 100)
                UtilTot = FormatNumber(UtilNet + Pcos, 2)
            ElseIf CmbPes.Text = "Dolares" Then
                'Pcos = Decimal.Parse(MskPcos.Text, System.Globalization.CultureInfo.GetCultureInfo("es-es"))
                Pcos = MskPcos.Text
                'Util = Decimal.Parse(MskUtil.Text, System.Globalization.CultureInfo.GetCultureInfo("es-es"))
                Util = MskUtil.Text
                UtilNet = (Pcos * Util / 100)
                UtilTot = FormatNumber(UtilNet + Pcos, 2)
            End If
            Alic = CmbIva.Text
            Iva = FormatNumber(UtilTot * Alic / 100, 2)
            Pfinal = FormatNumber(UtilTot + Iva, 2)
            MskTotal.Text = Str(Pfinal)
            MskIva.Text = Str(Iva)
            Pneto = Pfinal - Iva
            MskPneto.Text = Str(Pneto)
        Catch ex As Exception
            MsgBox("Falta Informacion")
        End Try
        
    End Sub

    Private Sub MskIva_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MskIva.GotFocus
        MskIva.SelectionStart = 0
        MskIva.SelectionLength = MskIva.Text.Length
    End Sub

    Private Sub MskIva_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MskIva.KeyDown
        If e.KeyCode = Keys.Return Then
            MskTotal.Focus()
        End If
    End Sub

    Private Sub MskIva_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MskIva.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub MskIva_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles MskIva.Leave
        If MskIva.Text = "" Then
            MskIva.Text = "0"
        End If
    End Sub

   
    Private Sub MskFecha_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs)

    End Sub

    Private Sub TxtActividad_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtActividad.Click
        FRmBAct.Show()
    End Sub

    Private Sub TxtActividad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtActividad.KeyDown
        If e.KeyData = Keys.Enter Then
            CmbUnidad.Focus()
        End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAct.Click
        Try
            Dim Max As Integer
            MiClase.eliminaactualizaregistra("update dolar set dolar=" & TxtDolar.Text & " where id=" & 1 & "")
            misdatos = MiClase.traedataset("select isnull(count(barra),0) from articulos where   pcostod > " & 0 & "")
            Max = misdatos.Tables(0).Rows(0).Item(0)
            Barra.Minimum = 0
            misdatos = MiClase.traedataset("select isnull((dolar),0) from dolar where id=" & 1 & "")
            TxtDolar.Text = misdatos.Tables(0).Rows(0).Item(0)
            Dolar = Decimal.Parse(TxtDolar.Text, System.Globalization.CultureInfo.GetCultureInfo("es-es"))
            If Max = 0 Then
                Mensaje = MsgBox("No Hay Articulos para Actualizar", MsgBoxStyle.OkOnly, "Actualizar Articulo!!!")
                If Mensaje = MsgBoxResult.Ok Then
                    TxtBarra.Focus()
                End If
            Else
                Barra.Maximum = Max + 1
                Barra.Value = 0
                MiClase.cargardatagriview(DtgArt, "select barra,articulo,pfinal,pcosto,util,alic,pneto,iva,pcostod from articulos where pcostod >" & 0 & "")
                ' Cargo  los Items
                Dim filas As Integer = DtgArt.Rows.Count
                Dim contador As Integer = 0
                For i As Integer = 0 To filas - 1
                    If IsDBNull(Convert.ToDouble(DtgArt(0, i).Value)) Then
                    Else
                        BarFac = Convert.ToDouble(DtgArt(0, i).Value)
                    End If

                    If IsDBNull(Convert.ToDecimal(DtgArt(2, i).Value)) Then
                    Else
                        Pfinal = Convert.ToDecimal(DtgArt(2, i).Value)
                    End If

                    If IsDBNull(Convert.ToDecimal(DtgArt(3, i).Value)) Then
                    Else
                        Pcosto = Convert.ToDecimal(DtgArt(3, i).Value)
                    End If
                    If IsDBNull(Convert.ToDecimal(DtgArt(4, i).Value)) Then
                    Else
                        Util = Convert.ToDecimal(DtgArt(4, i).Value)
                    End If
                    If IsDBNull(Convert.ToDecimal(DtgArt(5, i).Value)) Then
                    Else
                        Alic = Convert.ToDecimal(DtgArt(5, i).Value)
                    End If
                    If IsDBNull(Convert.ToDecimal(DtgArt(6, i).Value)) Then
                    Else
                        Pneto = Convert.ToDecimal(DtgArt(6, i).Value)
                    End If
                    If IsDBNull(Convert.ToDecimal(DtgArt(7, i).Value)) Then
                    Else
                        Iva = Convert.ToDecimal(DtgArt(7, i).Value)
                    End If
                    If IsDBNull(Convert.ToDecimal(DtgArt(8, i).Value)) Then
                    Else
                        CosDolar = Convert.ToDecimal(DtgArt(8, i).Value)
                    End If
                    Pcosto = FormatNumber(CosDolar * Dolar, 2)
                    UtilNet = FormatNumber(Pcosto * Util / 100, 2)
                    UtilTot = FormatNumber(UtilNet + Pcosto, 2)
                    'AlicDisc = CmbIva.Text / 100 + 1
                    Iva = FormatNumber(UtilTot * Alic / 100, 2)
                    Pfinal = UtilTot + Iva
                    Pneto = Pfinal - Iva
                    MiClase.eliminaactualizaregistra("update articulos set  fstock='" & Date.Today & "',pcosto=" & Str(Pcosto) & "," & _
                          "pneto=" & Str(Pneto) & ", iva=" & Str(Iva) & ",pfinal= " & Str(Pfinal) & ",cambio=" & Str(Dolar) & " where barra=" & BarFac & "")
                    Barra.Value = Barra.Value + 1
                Next
                Mensaje = MsgBox("Finalizo la Actualizacion de precios", MsgBoxStyle.YesNo, "Actualizacion de precios!!!")
                If Mensaje = MsgBoxResult.Yes Then
                    Barra.Value = 0
                    Pcosto = 0
                    CosDolar = 0
                    UtilNet = 0
                    Util = 0
                    UtilTot = 0
                    Iva = 0
                    Pfinal = 0
                    Pneto = 0
                    TxtBarra.Focus()
                End If
            End If
        Catch ex As Exception
            Mensaje = MsgBox("Falta Informacion", MsgBoxStyle.OkOnly, "Falta Informacion!!!")
        End Try
    End Sub

    Private Sub CmbPes_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbPes.KeyDown
        If e.KeyCode = Keys.Return Then
            CmbPes.Text = Trim(CmbPes.Text)
            If CmbPes.Text = "Pesos" Then
                MskPcosD.Text = "0"
                MskPcos.Focus()
            ElseIf CmbPes.Text = "Dolares" Then
                MskPcosD.Enabled = True
                MskPcosD.Focus()
            End If
        End If
    End Sub

    Private Sub CmbPes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbPes.SelectedIndexChanged

    End Sub

    Private Sub MskPcosD_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MskPcosD.GotFocus
        MskPcosD.SelectionStart = 0
        MskPcosD.SelectionLength = MskPcosD.Text.Length
    End Sub

    Private Sub MskPcosD_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MskPcosD.KeyDown
        If e.KeyCode = Keys.Return Then
            MskPcos.Focus()
        End If
    End Sub

    Private Sub TxtDolar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDolar.KeyDown

    End Sub

    Private Sub TxtDolar_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtDolar.LostFocus
        If TxtDolar.Text = "" Then
            BtnAct.Enabled = False
            Mensaje = MsgBox("Tiene que Ingresar el Valor del Dolar", MsgBoxStyle.OkOnly, "Falta Informacion!!!")
            If Mensaje = MsgBoxResult.Ok Then
                TxtDolar.Focus()
            End If
        End If
    End Sub

    Private Sub TxtDolar_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtDolar.TextChanged
        BtnAct.Enabled = True
    End Sub

    Private Sub MskPcos_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles MskPcos.MaskInputRejected

    End Sub

    Private Sub CmbUnidad_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbUnidad.GotFocus
        MiClase.cargar_Combo(CmbUnidad, "select unidad from unidad")
    End Sub

    Private Sub CmbUnidad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbUnidad.KeyDown
        If e.KeyCode = Keys.Return Then
            MskStock.Focus()
        End If
    End Sub

    Private Sub CmbUnidad_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbUnidad.LostFocus
        misdatos = MiClase.traedataset("select unidad,id,abrev from unidad where unidad='" & CmbUnidad.Text & "' ")
        AbUn = misdatos.Tables(0).Rows(0).Item(1)
    End Sub

    Private Sub TxtActividad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtActividad.TextChanged

    End Sub

    Private Sub TxtOb_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtOb.KeyDown
        If e.KeyData = Keys.Enter Then
            FrmBfam.Show()
        End If
    End Sub
    Private Sub TxtOb_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtOb.Leave
        If TxtOb.Text = "" Then
            TxtOb.Text = "0"
        End If
    End Sub


    Private Sub TxtDolar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDolar.Click
        TxtDolar.Clear()
    End Sub

    Private Sub Txtarticulo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txtarticulo.KeyDown
        If e.KeyCode = Keys.Return Then
            TxtProv.Focus()
        End If
    End Sub


    Private Sub Txtarticulo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtarticulo.TextChanged

    End Sub

    Private Sub MskTotal_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles MskTotal.MaskInputRejected

    End Sub

    Private Sub TxtCodPr_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCodPr.TextChanged

    End Sub

    
End Class