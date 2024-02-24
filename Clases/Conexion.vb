Imports System.Data.SqlClient
Imports System.Data
Imports System.Xml
Public Class Conexion
    Sub New()
        cargapccadena()
    End Sub
    'Dim conexion As New SqlConnection("data Source=Colombo\SQLEXPRESS;Initial Catalog=Super;Integrated Security=SSPI")
    ' Dim conexion As New SqlConnection(Cadena)
    'Dim conexion As New SqlConnection("data Source=(local)\SQLEXPRESS;Initial Catalog=Super;Integrated Security=SSPI")
    'Dim conexion As New SqlConnection("data Source=SERVIDOR-PC\SQL;Initial Catalog=Super;Integrated Security=SSPI;User ID=ivan2;Password=12345")
    'Dim conexion As New SqlConnection("data Source=SERVIDOR-PC\MSSQLSERVER;Initial Catalog=Super;Integrated Security=SSPI")
    'Dim conexion As New SqlConnection("data Source=MATERCON-PC\SQLEXPRESS;Initial Catalog=Super;Integrated Security=SSPI")
    'Dim conexion As New SqlConnection("data Source=MOSTRADOR-PC\TSQLEXPRESS;Initial Catalog=Super;Integrated Security=SSPI")
    'Dim conexion As New SqlConnection("data Source=naguyo-PC\SQLEXPRESS;Initial Catalog=Super;Integrated Security=SSPI")
    'Dim conexion As New SqlConnection("data Source=(local);Initial Catalog=Super;Integrated Security=SSPI")
    'Dim conexion As New SqlConnection("data Source=prueba-PC\SQLEXPRESS;Initial Catalog=Super;Integrated Security=SSPI")
    ' Dim conexion As New SqlConnection("data Source=H81-PC\SQLEXPRES;Initial Catalog=Super;Integrated Security=SSPI")
    Public Sub comm(ByVal querystring As String, ByVal con As String)
        Using connec As New SqlConnection(Cadena)

        End Using
    End Sub
    Public Sub cargardatagriview(ByRef dgv As DataGridView, ByVal sql As String)
        ' Crea y abre una nueva conexión  
        Try
            Dim Conexion As New SqlConnection("" & Cadena & "")
            cargapccadena()
            Dim da As New SqlDataAdapter(sql, Conexion) ' Crear nuevo SqlDataAdapter  
            Dim dataset As New DataSet ' Crear nuevo dataset  
            Conexion.Open()
            ' llenar el dataset
            da.Fill(dataset)
            Conexion.Close()
            dgv.DataSource = dataset.Tables(0)
            ' errores  
        Catch ex As Exception

            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Aviso")
        End Try

    End Sub

    Public Function traedataset(ByVal sql As String) As DataSet
        ' Crea y abre una nueva conexión  
        Dim Conexion As New SqlConnection("" & Cadena & "")
        cargapccadena()
        Dim dataset As New DataSet ' Crear nuevo dataset  
        Try

            Dim da As New SqlDataAdapter(sql, Conexion) ' Crear nuevo SqlDataAdapter  

            Conexion.Open()
            ' llenar el dataset
            da.Fill(dataset)
            Conexion.Close()
            'Traemos el contenido de la consulta

            ' errores  
        Catch ex As Exception

            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Aviso")
        End Try
        Return dataset
    End Function
    'Metodo para eliminar, actualizar
    Public Sub eliminaactualizaregistra(ByVal sql As String)
        ' Crea y abre una nueva conexión  
        Try
            Dim Conexion As New SqlConnection("" & Cadena & "")
            cargapccadena()
            Conexion.Open()
            Dim accion As New SqlCommand(sql, Conexion)

            'cmdactualiza2.ExecuteNonQuery()

            If accion.ExecuteNonQuery() > 0 Then
                '  MsgBox("SE HA REALIZADO CORRECTAMENTE", MsgBoxStyle.Information, "                      Atención")
            Else
                ' MsgBox("EL REGISTRO NO FUE ELIMINADO  ", MsgBoxStyle.Exclamation, "                      Atención")
            End If
            Conexion.Close()

        Catch ex As Exception
            Dim Conexion As New SqlConnection("" & Cadena & "")
            Conexion.Close()
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Aviso")
        End Try
    End Sub

    Public Sub cargar_Combo(ByVal ComboBox As ComboBox, ByVal sql As String)

        ' nueva conexión indicando al SqlConnection la cadena de conexión  
        'Dim cn As New SqlConnection(cs)
        Dim Conexion As New SqlConnection("" & Cadena & "")
        cargapccadena()
        Try

            ' Abrir la conexión a Sql  
            'cn.Open()
            Conexion.Open()
            ' Pasar la consulta sql y la conexión al Sql Command   
            Dim cmd As New SqlCommand(sql, Conexion)

            ' Inicializar un nuevo SqlDataAdapter   
            Dim da As New SqlDataAdapter(cmd)

            'Crear y Llenar un Dataset  
            Dim ds As New DataSet
            da.Fill(ds)

            ' asignar el DataSource al combobox  
            ComboBox.DataSource = ds.Tables(0)

            ' Asignar el campo a la propiedad DisplayMember del combo   
            ComboBox.DisplayMember = ds.Tables(0).Columns(0).Caption.ToString

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, _
                            "error", MessageBoxButtons.OK, _
                            MessageBoxIcon.Error)
        Finally
            If Conexion.State = ConnectionState.Open Then
                Conexion.Close()
            End If
        End Try
    End Sub
End Class
