Imports FiscalNET
Public Class FrmConfiguracion
    Dim ObjFiscal As HasarTicket = New HasarTicket

    Dim Lin As Integer

    Private Sub FrmConfiguracion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        misdatos = MiClase.traedataset("select puerto from configuracion")
        PuerImp = Trim(misdatos.Tables(0).Rows(0).Item(0))
        nError = ObjFiscal.IF_OPEN(PuerImp, 9600)
        ObjFiscal.SerialNumber = "27-0163848-435"
        misdatos = MiClase.traedataset("SELECT Interes FROM Intereses ")
        nError = ObjFiscal.IF_CLOSE()
        MskInt.Text = FormatNumber(misdatos.Tables(0).Rows(0).Item(0), 2)
        'misdatos = MiClase.traedataset("SELECT cola FROM configuracion ")
        'TxtCola.Text = misdatos.Tables(0).Rows(0).Item(0)
    End Sub

    Private Sub CmdAct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAct.Click
        Mensaje = MsgBox("Desea Actualizar La Informacion:", MsgBoxStyle.YesNo, "Actualizar!!!")
        If Mensaje = MsgBoxResult.Yes Then
            Dim InAct As Decimal
            'InAct = Decimal.Parse(MskInt.Text, System.Globalization.CultureInfo.GetCultureInfo("es-us"))
            InAct = MskInt.Text
            MiClase.eliminaactualizaregistra("update intereses set interes=" & Str(InAct) & "")
            misdatos = MiClase.traedataset("SELECT Interes FROM Intereses ")
            MskInt.Text = FormatNumber(misdatos.Tables(0).Rows(0).Item(0), 2)
        End If
    End Sub

    Private Sub CmdObtener_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdObtener.Click
        If CmbLinea.Text = "" Then
            Mensaje = MsgBox("Debe Seleccionar un numero de Linea:", MsgBoxStyle.OkOnly, "Seleccionar Numero de Linea!!!")
        Else
            If CmbLinea.Text = "13" Then
                misdatos = MiClase.traedataset("select linea13 from configuracion")
                TxtCola.Text = misdatos.Tables(0).Rows(0).Item(0)
            ElseIf CmbLinea.Text = "14" Then
                misdatos = MiClase.traedataset("select linea14 from configuracion")
                TxtCola.Text = misdatos.Tables(0).Rows(0).Item(0)
            End If
            End If
    End Sub

    Private Sub CmdMandar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdMandar.Click
        If CmbLinea.Text = "" Then
            Mensaje = MsgBox("Debe Seleccionar un numero de Linea:", MsgBoxStyle.OkOnly, "Seleccionar Numero de Linea!!!")
        ElseIf CmbLinea.Text = "13" Then
            MiClase.eliminaactualizaregistra("update configuracion set linea13 ='" & TxtCola.Text & "'")
            misdatos = MiClase.traedataset("select linea13 from configuracion")
            TxtCola.Text = misdatos.Tables(0).Rows(0).Item(0)
        ElseIf CmbLinea.Text = "14" Then
            MiClase.eliminaactualizaregistra("update configuracion set linea14 ='" & TxtCola.Text & "'")
            misdatos = MiClase.traedataset("select linea14 from configuracion")
            TxtCola.Text = misdatos.Tables(0).Rows(0).Item(0)
        End If
        'nError = ObjFiscal.IF_OPEN(PuerImp, 9600)
        'nError = ObjFiscal.IF_WRITE("@SetHeaderTrailer|" & Lin & "|" & TxtCola.Text & "")
        'nError = ObjFiscal.IF_CLOSE()
    End Sub
End Class