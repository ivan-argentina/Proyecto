Imports System.Data
Imports System.IO
'Imports Microsoft.Office.Interop
Module Module1
    ' Sub excel(ByVal dg As DataGridView)
    'si tu metodo tra un gridview se pone esto
    Sub excel(ByVal dg As DataGridView)
        '=============================================================================
        Dim NumCom As Integer
        Dim IdPv As Integer
        '       Dim aplicacion As New Excel.Application
        ''libro a excel
        '      Dim libro As Excel.Workbook
        ''hoja a excel
        '     Dim hoja As Excel.Worksheet
        'sub (byval dg as datagridview)
        '    libro = aplicacion.Workbooks.Open("c:\Ventas.xlsx")

        '   aplicacion.Visible = True
        '  hoja = libro.Worksheets(2)
        ' libro.Worksheets(1).Activate()
        ' hoja.Rows.Item(1).Font.Bold = 1
        ' hoja.Rows.Item(1).HorizontalAlignment = 3
        ' hoja.Activate()


        '        Dim NCol As Integer = dg.ColumnCount
        '        Dim NRow As Integer = dg.RowCount
        '        'Aqui usaras el form para llenar los datos si usas un grdiview
        '        Dim Fila As Integer
        
        '       For Fila = 0 To NRow - 2
        ' Cuit = dg.Rows(fila).Cells(4).Value
        ' 'Dim Lcuit As Integer
        'Dim LLL As Integer
        ' Dim CodCuit As Integer
        ' Dim Cuitt As String
        ' Dim DesCuit As String
        ' Cuitt = Cuit
        ' ' Lcuit = Len(Cuitt)
        ' Dim Lcuit As Integer = Len(Trim(Cuitt))
        ' If Lcuit = 13 Then
        ' CodCuit = 80
        ' DesCuit = "CUIT"
        ' Else
        'CodCuit = 96
        'DesCuit = "DNI"
        'End If
        'hoja.Cells.Item(fila + 12, 2) = CDate(dg.Rows(fila).Cells(0).Value) 'fecha
        'hoja.Cells.Item(fila + 12, 3) = dg.Rows(fila).Cells(7).Value
        ''hoja.Cells.Item(Fila + 7, 3) = dg.Rows(Fila).Cells(2).Value
        'hoja.Cells.Item(fila + 12, 4) = dg.Rows(fila).Cells(1).Value 'comprobante
        'hoja.Cells.Item(fila + 12, 5) = dg.Rows(fila).Cells(2).Value 'Pv
        'hoja.Cells.Item(fila + 12, 6) = dg.Rows(fila).Cells(3).Value 'numero
        'hoja.Cells.Item(fila + 12, 7) = dg.Rows(fila).Cells(3).Value 'hasta numero
        'hoja.Cells.Item(fila + 12, 8) = CodCuit 'codigo de cuit
        'hoja.Cells.Item(fila + 12, 9) = DesCuit 'descripcion cuit
        'hoja.Cells.Item(fila + 12, 10) = dg.Rows(fila).Cells(4).Value 'Numero de cuit
        'hoja.Cells.Item(fila + 12, 11) = dg.Rows(fila).Cells(5).Value 'Razon Social
        'hoja.Cells.Item(fila + 12, 12) = dg.Rows(fila).Cells(6).Value 'Importe Total
        'hoja.Cells.Item(fila + 12, 15) = 0
        'hoja.Cells.Item(fila + 12, 22) = 1 'Tipo de cambio
        'hoja.Cells.Item(fila + 12, 23) = 1 'Cantidad de alicuotas
        'hoja.Cells.Item(fila + 12, 24) = "E" 'Codigo de Operaciones Excentas
        'hoja.Cells.Item(fila + 12, 25) = "Operaciones Exentas" 'Operaciones Excentas
        'IdPv = dg.Rows(fila).Cells(2).Value 'Pv
        'NumCom = dg.Rows(fila).Cells(3).Value
        'IdTp = dg.Rows(fila).Cells(7).Value
        'Dim filas As Integer = 6
        'For i As Integer = 4 To filas - 1
        ' misdatos = MiClase.traedataset("select isnull(sum(ptotal),0) from detal_fac where idalic=" & i & " and id=" & NumCom & "and idtp=" & IdTp & "and pv=" & IdPv & "")
        ' ToTT = misdatos.Tables(0).Rows(0).Item(0)
        ' If i = 4 And ToTT > 0 Then
        ' Alic = 1.105
        ' Alic1 = 10.5
        ' ToTT = misdatos.Tables(0).Rows(0).Item(0)
        ' NetT = FormatNumber(ToTT / Alic, 2)
        ' IvT = ToTT - NetT
        ' hoja.Cells.Item(fila + 12, 29) = NetT 'neto de la factura por alicuota
        ' hoja.Cells.Item(fila + 12, 30) = Alic1  'alicuota de factura
        ' hoja.Cells.Item(fila + 12, 32) = IvT 'neto de la factura por alicuota
        ' ElseIf i = 5 And ToTT > 0 Then
        ' Alic = 1.21
        ' Alic1 = 21.0
        ' ToTT = misdatos.Tables(0).Rows(0).Item(0)
        ' NetT = FormatNumber(ToTT / Alic, 2)
        ' IvT = ToTT - NetT
        ' hoja.Cells.Item(fila + 12, 29) = NetT 'neto de la factura por alicuota
        ' hoja.Cells.Item(fila + 12, 30) = Alic1  'alicuota de factura
        ' hoja.Cells.Item(fila + 12, 32) = IvT 'neto de la factura por alicuota
        ' End If
        'Next
        'Next
        ''hoja.Columns().AutoFit() ''Ajustamos el ancho de las columnas
        'hoja = Nothing
        'libro = Nothing
        'aplicacion = Nothing
        'Mensaje = MsgBox("Finalizo el proceso de Exportacion", MsgBoxStyle.OkOnly, "Finalizo el Proceso!!!")
    End Sub
End Module

