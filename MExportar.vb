Imports System.Data
Imports System.IO
Imports Microsoft.Office.Interop


Module MExportar
    Dim AbrCiva As String
    Sub Oexcel(ByVal dg As DataGridView)
        Dim Olibro As Excel.Workbook

        ''hoja a excel
        Dim Ohoja As Excel.Worksheet
        Dim Oapl As New Excel.Application
        Olibro = Oapl.Workbooks.Open(ruta & "\HWVenta.xls")
        Oapl.Visible = True
        Ohoja = Olibro.Worksheets(1)
        Olibro.Worksheets(1).Activate()
        Dim Lin As Integer = 2
        Dim NCol As Integer = dg.ColumnCount
        Dim NRow As Integer = dg.RowCount
        Dim Fila As Integer = 0
        For Fila = 0 To NRow - 2
            Cuit = Trim(dg.Rows(Fila).Cells(4).Value)
            Dim CodCuit As Integer
            Dim Cuitt As String
            Dim DesCuit As String
            Dim ComAbrev As String
            Dim Abrev As String
            Dim AbrCiva As String
            Dim RSocial As String
            Dim Rsoc As String
            Dim Direc As String
            Dim CodProv As String
            Dim Snum As String
            Dim Sdata As String
            Cuitt = Cuit
            Dim Icut As String
            Dim Mcut As String
            Dim Dcut As String
            Dim Pv1 As String
            'Identifico Alicuota de Iva
            Num = dg.Rows(Fila).Cells(3).Value 'numero
            IdTp = dg.Rows(Fila).Cells(8).Value 'Id tipo de comprobante
            MiClase.cargardatagriview(FrmIvaVentas.DtgAlic, "select id,ptotal,alic,idalic  from detal_fac where id=" & Num & "and idtp =" & IdTp & "")


            Dim Lcuit As Integer = Len(Trim(Cuitt))
            If Lcuit = 13 Then
                CodCuit = 80
                DesCuit = "CUIT"
            Else
                CodCuit = 96
                DesCuit = "DNI"
                Icut = Mid(Cuit, 1, 2)
                Mcut = Mid(Cuit, 4, 3)
                Dcut = Mid(Cuit, 8, 3)
                Cuit = "00-" + Icut + Mcut + Dcut + "-0"
            End If
            'Traigo la abreviatura del comprobante
            IdTp = dg.Rows(Fila).Cells(8).Value 'Id tipo de comprobante
            misdatos = MiClase.traedataset("select id,tipo,abrev from tip_fac where id=" & IdTp & "")
            ComAbrev = Trim(misdatos.Tables(0).Rows(0).Item(2))
            Abrev = Mid(ComAbrev, 1, 2)
            LetrComp = Right(ComAbrev, 1)
            'Traigo la Abreviatura de Condicion de iva
            IdCiva = dg.Rows(Fila).Cells(22).Value 'Id tipo de comprobante
            misdatos = MiClase.traedataset("select id,c_iva,abrev from c_de_iva where id=" & IdCiva & "")
            AbrCiva = Trim(misdatos.Tables(0).Rows(0).Item(2))
            '++++++++++++++++++++++++++++++++++
            Fecha = CDate(dg.Rows(Fila).Cells(0).Value) 'fecha
            Pv1 = dg.Rows(Fila).Cells(2).Value 'Pv
            Snum = dg.Rows(Fila).Cells(3).Value 'numero
            RSocial = Trim(dg.Rows(Fila).Cells(5).Value) 'Razon Social
            Rsoc = Trim(dg.Rows(Fila).Cells(5).Value) 'Razon Social
            'hoja.Cells.Item(Fila + 2, 7) = CodCuit 'codigo de cuit
            ' Cuit = dg.Rows(Fila).Cells(4).Value 'Numero de cuit
            Direc = dg.Rows(Fila).Cells(6).Value 'Direccion
            Cpostal = Trim(dg.Rows(Fila).Cells(19).Value) 'Codigo Postal
            CodProv = Trim(dg.Rows(Fila).Cells(20).Value) 'Codigo de provincia
            AbrCiva = AbrCiva  'Abrev.Cond de Iva
            Neto = FormatNumber(dg.Rows(Fila).Cells(16).Value, 2) 'Neto
            Alic = FormatNumber(dg.Rows(Fila).Cells(23).Value, 2) 'Alicuota de Iva
            Iva = FormatNumber(dg.Rows(Fila).Cells(17).Value, 2) 'Iva liquido
            'hoja.Cells.Item(Fila + 2, 17) = FormatNumber(dg.Rows(Fila).Cells(17).Value, 2) 'Iva debito
            CodProv = Trim(dg.Rows(Fila).Cells(20).Value) 'Codigo de provincia
            Total = FormatNumber(dg.Rows(Fila).Cells(18).Value, 2) 'Total    

            Sdata = Fecha & vbTab & Abrev & vbTab & LetrComp & vbTab & Pv1 & vbTab & Snum & vbTab & Rsoc & vbTab & CodCuit & vbTab & Cuit & vbTab & Direc & vbTab & Cpostal & vbTab & CodProv & vbTab & AbrCiva & vbTab & vbTab & Neto & vbTab & Alic & vbTab & Iva & vbTab & Iva & vbTab & vbTab & vbTab & vbTab & vbTab & CodProv & vbTab & Total
            Clipboard.Clear()
            Clipboard.SetText(Sdata)
            'Olibro.Worksheets(1).Range("A3").Select()
            Olibro.Worksheets(1).Range("A" & Lin).Select()
            Olibro.Worksheets(1).Pastespecial()
            Lin = Lin + 1
        Next
        Ohoja = Nothing
        Olibro = Nothing
        Oapl = Nothing
        Mensaje = MsgBox("Finalizo el proceso de Exportacion", MsgBoxStyle.OkOnly, "Finalizo el Proceso!!!")

    End Sub

End Module
