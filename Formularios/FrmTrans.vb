Public Class FrmTrans

    Private Sub FrmTrans_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'MiClase.cargardatagriview(DtgArt, "select id_prov,proveedor,direccion,cuit,id_ciu,id_civa,telefono,fax from proveedores$ ")
        'MiClase.cargardatagriview(DtgArt, "select id_cliente,cliente,direccion,cuit,id_ciudad,id_civa,telefono  from clientes$ ")
        MiClase.cargardatagriview(DtgArt, "select count(articulo.cod_articulo),ultima_act from articulo inner join precio on articulo.cod_articulo= precio.cod_articulo where ultima_act > ' " & DtcFecha.Text & "' order by ultima_act desc")
        MiClase.cargardatagriview(DtgArt, "select articulo.cod_articulo,cod_barra,descripcion,unidad_medida,costo_pesos,precio,ultima_act  from articulo inner join precio on articulo.cod_articulo= precio.cod_articulo where ultima_act > ' " & DtcFecha.Text & "' order by ultima_act desc")
        'MiClase.cargardatagriview(DtgArt, "select barra,articulo,idprove,idfamilia,idmar,stock,smin,fstock,p_costo,p_final,p_neto,iva,impiva from articulos$ ")
        'misdatos = MiClase.traedataset("select COUNT(barra)from ARTICULOS$")
        'Lb.Text = FormatNumber(misdatos.Tables(0).Rows(0).Item(0))

    End Sub

    Dim Pcos1, Pfin1, Pnet1, iva1, ImpIv1 As Decimal
    Dim Barra, IdPr1, IdFm1, IdMr1, smin1 As String
    Dim art1, fstk1, Mon, Uni1, Ob, stk1, barra1 As String
    Dim Id, cliente, direccion, idciu, idciva, telefono, cuit, email, idpr, fnac As String



    Private Sub CmdArticulos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdArticulos.Click
        'select articulo.cod_articulo,cod_barra,descripcion,unidad_medida,costo_pesos,precio  from articulo inner join precio on articulo.cod_articulo= precio.cod_articulo ")
        Dim filas As Integer = DtgArt.Rows.Count
        Dim contador As Integer = 0
        For i As Integer = 0 To filas - 1
            If IsDBNull(Convert.ToString(DtgArt(0, i).Value)) Then
            Else
                barra1 = Convert.ToString(DtgArt(1, i).Value)
            End If
            If IsDBNull(Convert.ToString(DtgArt(2, i).Value)) Then
            Else
                art1 = Convert.ToString(DtgArt(2, i).Value)
            End If
            If IsDBNull(Convert.ToString(DtgArt(3, i).Value)) Then
            Else
                AbUn = Convert.ToString(DtgArt(3, i).Value)
            End If
            'If IsDBNull(Convert.ToString(DtgArt(3, i).Value)) Then
            'Else
            'IdFm1 = Convert.ToString(DtgArt(3, i).Value)
            'End If
            'If IsDBNull(Convert.ToString(DtgArt(4, i).Value)) Then
            'Else
            'IdMr1 = Convert.ToString(DtgArt(4, i).Value)
            'End If
            'If IsDBNull(Convert.ToString(DtgArt(5, i).Value)) Then
            'Else
            'stk1 = Convert.ToString(DtgArt(5, i).Value)
            'End If
            'If IsDBNull(Convert.ToString(DtgArt(6, i).Value)) Then
            'Else
            'smin1 = Convert.ToString(DtgArt(6, i).Value)
            'End If
            If IsDBNull(Convert.ToString(DtgArt(6, i).Value)) Then
            Else
                fstk1 = Convert.ToString(DtgArt(6, i).Value)
            End If
            If IsDBNull(Convert.ToDecimal(DtgArt(4, i).Value)) Then
            Else
                Pcos1 = Convert.ToDecimal(DtgArt(4, i).Value)
            End If
            If IsDBNull(Convert.ToDecimal(DtgArt(5, i).Value)) Then
            Else
                Pfin1 = Convert.ToDecimal(DtgArt(5, i).Value)
            End If
            'If IsDBNull(Convert.ToString(DtgArt(10, i).Value)) Then
            'Else
            'Pnet1 = Convert.ToString(DtgArt(10, i).Value)
            'End If
            'If IsDBNull(Convert.ToString(DtgArt(11, i).Value)) Then
            'Else
            'iva1 = Convert.ToString(DtgArt(11, i).Value)
            'End If
            'If IsDBNull(Convert.ToString(DtgArt(12, i).Value)) Then
            'Else
            'ImpIv1 = Convert.ToString(DtgArt(12, i).Value)
            'End If

            IdPr1 = 0
            IdFm1 = 0
            IdMr1 = 0
            IdAct = 1
            stk1 = 0
            smin1 = 0
            Mon = 0
            Uni1 = 0
            Ob = "a"
            MiClase.eliminaactualizaregistra("insert into articulos values(" & barra1 & ",'" & art1 & "', " & _
         "" & IdPr1 & "," & IdFm1 & ", " & IdMr1 & "," & IdAct & ",'" & fstk1 & "'," & stk1 & ", " & _
        "" & smin1 & "," & Str(Pcos1) & "," & Str(CosDolar) & "," & Str(Cambio) & ",'" & Mon & "'," & Str(Util) & "," & Str(iva1) & "," & Str(Pnet1) & ", " & _
        "" & Str(ImpIv1) & "," & Str(Pfin1) & "," & IdIva & ",'" & Uni1 & "','" & AbUn & "','" & Ob & "')")
        Next
        Mensaje = MsgBox("Este Usuario No Existe en la Base de Datos", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Usuario Inexistente!!!")
        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim filas As Integer = DtgArt.Rows.Count
        Dim contador As Integer = 0
        For i As Integer = 0 To filas - 1
            If IsDBNull(Convert.ToString(DtgArt(0, i).Value)) Then
            Else
                Id = Convert.ToString(DtgArt(0, i).Value)
            End If
            If IsDBNull(Convert.ToString(DtgArt(1, i).Value)) Then
            Else
                cliente = Convert.ToString(DtgArt(1, i).Value)
            End If
            If IsDBNull(Convert.ToString(DtgArt(2, i).Value)) Then
            Else
                direccion = Convert.ToString(DtgArt(2, i).Value)
            End If
            If IsDBNull(Convert.ToString(DtgArt(3, i).Value)) Then
            Else
                cuit = Convert.ToString(DtgArt(3, i).Value)
            End If
            If IsDBNull(Convert.ToString(DtgArt(4, i).Value)) Then
            Else
                idciu = Convert.ToString(DtgArt(4, i).Value)
            End If
            If IsDBNull(Convert.ToString(DtgArt(5, i).Value)) Then
            Else
                idciva = Convert.ToString(DtgArt(5, i).Value)
            End If
            If IsDBNull(Convert.ToString(DtgArt(6, i).Value)) Then
            Else
                telefono = Convert.ToString(DtgArt(6, i).Value)
            End If
            If telefono = "" Then
                telefono = "0"
            End If
            If direccion = "" Then
                direccion = "0"
            End If
            If cuit = "" Then
                cuit = "0"
            End If
            idpr = 12
            email = 0
            fnac = "01/01/01"
            MiClase.eliminaactualizaregistra("insert into clientes  values(" & Id & ",'" & cliente & "','" & direccion & " ', " & _
                    "" & idciu & "," & idciva & ",'" & cuit & "','" & email & "','" & telefono & "', " & _
                    "'" & email & "'," & 0 & ",'" & email & "'," & idpr & ",'" & fnac & "')")
        Next
        Mensaje = MsgBox("Este Usuario No Existe en la Base de Datos", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Usuario Inexistente!!!")
    End Sub
End Class