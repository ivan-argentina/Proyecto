Imports System.Xml
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Printing

Imports System.Data.SqlClient

Public Class FrmInicio
    Dim FechCop As Date
    Dim Dias As Integer
    Dim Obj As Object
    Dim Archivo As Object
    Dim Ar, Id, Pfin, Item As String
    Dim Cl, Dr, Ciu, Civ, Sl As String
    Dim filas As Integer = 0
   
    Private Sub ToolStripButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        If Pr = 0 Then
            FrmInArticulos.Show()
        Else
            Mensaje = MsgBox("No Tiene Suficientes privilegios para entrar", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Nivel Bajo!!!")
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProveedoresToolStripMenuItem.Click
        If Pr = 0 Then
            FrmInProv.Show()
        Else
            Mensaje = MsgBox("No Tiene Suficientes privilegios para entrar", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Nivel Bajo!!!")
        End If

    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        If Pr = 0 Then
            FrmInCl.Show()
        Else
            Mensaje = MsgBox("No Tiene Suficientes privilegios para entrar", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Nivel Bajo!!!")
        End If

    End Sub

    

   

    Private Sub FacturaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturaToolStripMenuItem.Click
        FrmFacturaa.Show()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        FrmFacturaa.Show()
    End Sub



    Private Sub FrmInicio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.Control And e.KeyCode = Keys.A Then
            If BlNg = 0 Then
                BlNg = 1
                cBlNg.Visible = True
            ElseIf BlNg = 1 Then
                BlNg = 0
                cBlNg.Visible = False
            End If
        End If
    End Sub

    Private Sub FrmInicio_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'InitializeComponent()
        '        MiClase.todos()
        'traigo el numero de pc del archivo XML
        Dim DocumentoXml As XmlDocument
        Dim Nodelist As XmlNodeList
        Dim Nodo As XmlNode
        DocumentoXml = New XmlDocument
        'DocumentoXml.Load("C:\Gestion\config.xml")
        DocumentoXml.Load("config.xml")
        Nodelist = DocumentoXml.SelectNodes("/G/Imagen")
        For Each Nodo In Nodelist
            Dim IdpC = Nodo.Attributes.GetNamedItem("Id").Value
            Pc = Nodo.ChildNodes(0).InnerText
            Cadena = Nodo.ChildNodes(1).InnerText
            BsDt = Nodo.ChildNodes(2).InnerText
        Next

        'Idpc = 1
        '+++++++++++++++++++++
        BlNg = 0
        cBlNg.Visible = False
        'Verifico cuantos dias no se hace la copia de seguridad
        misdatos = MiClase.traedataset("SELECT fechcop from Configuracion where pc=" & Pc & "")
        FechCop = Trim(misdatos.Tables(0).Rows(0).Item(0))
        Dias = (DateDiff("y", FechCop, Date.Today))
        If Dias > 5 And Dias < 3000 Then
            Mensaje = MsgBox("Hace " & Dias & " dias que no hace copia de Seguridad, Es Recomendabre realizarla", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Copia de Seguridad!!!")
        End If
        
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        Mensaje = MsgBox("Desea Realmente Salir del Sistema", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Salir del Sistema")
        If Mensaje = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    Private Sub PagoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PagoToolStripMenuItem.Click
        If Pr = 0 Then
            FrmPago.Show()
        Else
            Mensaje = MsgBox("No Tiene Suficientes privilegios para entrar", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Nivel Bajo!!!")
        End If

    End Sub

    Private Sub ResumenDeCuentaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResumenDeCuentaToolStripMenuItem.Click
        If Pr = 0 Then
            FrmRcue.Show()
        Else
            Mensaje = MsgBox("No Tiene Suficientes privilegios para entrar", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Nivel Bajo!!!")
        End If

    End Sub

    Private Sub CambioDePreciosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambioDePreciosToolStripMenuItem.Click
        If Pr = 0 Then
            FrmCprecio.Show()
        Else
            Mensaje = MsgBox("No Tiene Suficientes privilegios para entrar", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Nivel Bajo!!!")
        End If

    End Sub

    Private Sub OrdenDeReparacionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrdenDeReparacionToolStripMenuItem.Click
        FrmOrep.Show()
    End Sub

    


    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        FrmBart.Show()
    End Sub




    Private Sub IvaVentasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IvaVentasToolStripMenuItem.Click
        If Pr = 0 Then
            FrmIvaVentas.Show()
        Else
            Mensaje = MsgBox("No Tiene Suficientes privilegios para entrar", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Nivel Bajo!!!")
        End If

    End Sub


    Private Sub CargarFacturasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CargarFacturasToolStripMenuItem.Click
        If Pr = 0 Then
            FrmCarCom.Show()
        Else
            Mensaje = MsgBox("No Tiene Suficientes privilegios para entrar", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Nivel Bajo!!!")
        End If

    End Sub

    Private Sub IvaComprasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IvaComprasToolStripMenuItem.Click
        If Pr = 0 Then
            FrmIvaCompras.Show()
        Else
            Mensaje = MsgBox("No Tiene Suficientes privilegios para entrar", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Nivel Bajo!!!")
        End If

    End Sub


    Private Sub ResumenDeCuentaToolStripPro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResumenDeCuentaToolStripPro.Click
        If Pr = 0 Then
            FrmRcuePro.Show()
        Else
            Mensaje = MsgBox("No Tiene Suficientes privilegios para entrar", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Nivel Bajo!!!")
        End If

    End Sub

    Private Sub CargarPagosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CargarPagosToolStripMenuItem.Click
        If Pr = 0 Then
            FrmPagoP.Show()
        Else
            Mensaje = MsgBox("No Tiene Suficientes privilegios para entrar", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Nivel Bajo!!!")
        End If

    End Sub

    Private Sub SaldosPorClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Pr = 0 Then
            FrmLSalVenc.Show()
        Else
            Mensaje = MsgBox("No Tiene Suficientes privilegios para entrar", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Nivel Bajo!!!")
        End If

    End Sub

    Private Sub ConfiguracionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfiguracionToolStripMenuItem.Click
        If Pr = 0 Then
            FrmConfiguracion.Show()
        Else
            Mensaje = MsgBox("No Tiene Suficientes privilegios para entrar", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Nivel Bajo!!!")
        End If

    End Sub



    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
        If Pr = 0 Then
            FrmBackup.Show()
        Else
            Mensaje = MsgBox("No Tiene Suficientes privilegios para entrar", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Nivel Bajo!!!")
        End If
    End Sub




    Private Sub BorrarArticulosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BorrarArticulosToolStripMenuItem.Click
        If Pr = 0 Then
            Form2.Show()
        Else
            Mensaje = MsgBox("No Tiene Suficientes privilegios para entrar", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Nivel Bajo!!!")
        End If

    End Sub



    Private Sub PruebaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ActualizarSaldosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub





    Private Sub CajaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CajaToolStripMenuItem.Click
        FRmCaja.Show()

    End Sub



    Private Sub ToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Usuarios.Click
        If Pr = 0 Then
            FrmInUs.Show()
        Else
            Mensaje = MsgBox("No Tiene Suficientes privilegios para entrar", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Nivel Bajo!!!")
        End If
    End Sub

    Private Sub DetalleDeVentasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetalleDeVentasToolStripMenuItem.Click
        FrmLdetVen.Show()
    End Sub


    Private Sub ArticulosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArticulosToolStripMenuItem.Click
        FrmInArticulos.Show()
    End Sub

    Private Sub ABMClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABMClientesToolStripMenuItem.Click
        If Pr = 0 Then
            FrmInCl.Show()
        Else
            Mensaje = MsgBox("No Tiene Suficientes privilegios para entrar", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Nivel Bajo!!!")
        End If


    End Sub

    Private Sub PagosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PagosToolStripMenuItem.Click
        If Pr = 0 Then
            FrmPago.Show()
        Else
            Mensaje = MsgBox("No Tiene Suficientes privilegios para entrar", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Nivel Bajo!!!")
        End If
    End Sub

    Private Sub ResumenDeCuentaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResumenDeCuentaToolStripMenuItem1.Click
        If Pr = 0 Then
            FrmRcue.Show()
        Else
            Mensaje = MsgBox("No Tiene Suficientes privilegios para entrar", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Nivel Bajo!!!")
        End If
    End Sub

    Private Sub ToolStripButton3_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.ButtonClick

    End Sub

    Private Sub ToolStripMenuItem6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem6.Click
        If Pr = 0 Then
            FrmInProv.Show()
        Else
            Mensaje = MsgBox("No Tiene Suficientes privilegios para entrar", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Nivel Bajo!!!")
        End If
    End Sub

    Private Sub ResumenDeCuentaToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResumenDeCuentaToolStripMenuItem2.Click
        If Pr = 0 Then
            FrmRcuePro.Show()
        Else
            Mensaje = MsgBox("No Tiene Suficientes privilegios para entrar", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Nivel Bajo!!!")
        End If
    End Sub

    Private Sub CargarPagosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CargarPagosToolStripMenuItem1.Click
        If Pr = 0 Then
            FrmPagoP.Show()
        Else
            Mensaje = MsgBox("No Tiene Suficientes privilegios para entrar", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Nivel Bajo!!!")
        End If
    End Sub

    Private Sub CargarFacturasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CargarFacturasToolStripMenuItem1.Click
        If Pr = 0 Then
            FrmCarCom.Show()
        Else
            Mensaje = MsgBox("No Tiene Suficientes privilegios para entrar", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Nivel Bajo!!!")
        End If
    End Sub

   

    Private Sub VentasPorFamiliaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VentasPorFamiliaToolStripMenuItem.Click
        FrmLVenFam.Show()
    End Sub

    Private Sub ListarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListarToolStripMenuItem.Click
        If Pr = 0 Then
            FrmLcarne.Show()
        Else
            Mensaje = MsgBox("No Tiene Suficientes privilegios para entrar", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Nivel Bajo!!!")
        End If


    End Sub

    Private Sub IngresarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IngresarToolStripMenuItem.Click
        FrmInCar.Show()
    End Sub

    Private Sub StockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockToolStripMenuItem.Click
        FrmLStock.Show()
    End Sub
End Class

