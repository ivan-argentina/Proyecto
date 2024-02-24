Imports System.Xml
Imports System.Data.SqlClient
Imports System.Data
Public Class FrmBackup
    Dim Ruta As String
    Dim Ruta1 As String

    Private Sub CmdRuta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdRuta.Click
        FolderBrowserDialog1.ShowDialog()
        ruta = FolderBrowserDialog1.SelectedPath
        TxtRuta.Text = Trim(ruta)
        MiClase.eliminaactualizaregistra("update configuracion set ruta='" & Ruta & "'")
    End Sub

    Private Sub FrmBackup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        misdatos = MiClase.traedataset("SELECT Ruta from Configuracion")
        Ruta = Trim(misdatos.Tables(0).Rows(0).Item(0))
        TxtRuta.Text = Ruta
    End Sub

    Private Sub CmdCopia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCopia.Click
        Dim Con As New SqlConnection("" & Cadena & "")
        ToolText.Text = "Realizando Copia de Seguridad, Aguarde un Momento"
        CmdCopia.Enabled = False
        CmdRuta.Enabled = False
        Dim Fd As String
        Dim Fm As String
        Dim Fa As String
        Dim FCd As String
        Fd = Mid(Date.Today, 1, 2)
        Fm = Mid(Date.Today, 4, 2)
        Fa = Mid(Date.Today, 9, 2)
        FCd = Fd + Fm + Fa
        Ruta1 = Ruta1 + FCd + ".bak"
        Ruta1 = Ruta + "\" + Ruta1
        If My.Computer.FileSystem.FileExists("" & Ruta1 & "") Then
            Mensaje = MsgBox("Este Nombre de Archivo ya Existe, Desea reemplazarlo?", MsgBoxStyle.YesNo, "Archivo Existente!!!")
            If Mensaje = vbYes Then
                Dim Sbackup As String = "USE " & BsDt & "; BACKUP DATABASE " & BsDt & " TO DISK = '" & Ruta1 & "' WITH FORMAT,MEDIANAME = 'Z_SQLServerBackups', NAME = ' " & BsDt & " '"
                Dim cmdBackUp As New SqlCommand(Sbackup, Con)
                Con.Open()
                cmdBackUp.ExecuteNonQuery()
                MiClase.eliminaactualizaregistra("update configuracion set fechcop='" & Date.Today & "'where pc= " & Pc & "")
                MessageBox.Show("Se ha creado un BackUp de La base de datos satisfactoria", "Copia de seguridad de base de datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Con.Close()
                ToolText.Text = "Finalizo La Copia de Seguridad"
            End If
        Else
            Con.Open()
            Dim Sbackup As String = "USE " & BsDt & "; BACKUP DATABASE " & BsDt & " TO DISK = '" & Ruta1 & "' WITH FORMAT,MEDIANAME = 'Z_SQLServerBackups', NAME =  ' " & BsDt & " '"
            Dim cmdBackUp As New SqlCommand(Sbackup, Con)
            cmdBackUp.ExecuteNonQuery()
            MiClase.eliminaactualizaregistra("update configuracion set fechcop='" & Date.Today & "'where pc= " & Pc & "")
            MessageBox.Show("Se ha creado un BackUp de La base de datos satisfactoria", "Copia de seguridad de base de datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ToolText.Text = "Finalizo La Copia de Seguridad"
            Con.Close()
            ToolText.Text = "Finalizo La Copia de Seguridad"
        End If
        CmdCopia.Enabled = True
        CmdRuta.Enabled = True
    End Sub

End Class