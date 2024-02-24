<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCarCom
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TxtSaldo = New System.Windows.Forms.TextBox
        Me.LbSaldo = New System.Windows.Forms.Label
        Me.Txtciudad = New System.Windows.Forms.TextBox
        Me.LbCiudad = New System.Windows.Forms.Label
        Me.TxtCuit = New System.Windows.Forms.TextBox
        Me.TxtCiva = New System.Windows.Forms.TextBox
        Me.LbCuit = New System.Windows.Forms.Label
        Me.LbCdeIva = New System.Windows.Forms.Label
        Me.TxTDirecion = New System.Windows.Forms.TextBox
        Me.LbDireccion = New System.Windows.Forms.Label
        Me.TxtPro = New System.Windows.Forms.TextBox
        Me.LbProv = New System.Windows.Forms.Label
        Me.GrpFamilia = New System.Windows.Forms.GroupBox
        Me.LbFamilia = New System.Windows.Forms.Label
        Me.MskUtil = New System.Windows.Forms.MaskedTextBox
        Me.LbUtilidad = New System.Windows.Forms.Label
        Me.Grupo = New System.Windows.Forms.GroupBox
        Me.DtcFecha = New System.Windows.Forms.DateTimePicker
        Me.LbFecha = New System.Windows.Forms.Label
        Me.TxtNumFac = New System.Windows.Forms.TextBox
        Me.LbNumero = New System.Windows.Forms.Label
        Me.TxtPv = New System.Windows.Forms.TextBox
        Me.LbPv = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.RdtCta = New System.Windows.Forms.RadioButton
        Me.RdContado = New System.Windows.Forms.RadioButton
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.CmdCerrar = New System.Windows.Forms.Button
        Me.MskPtotal = New System.Windows.Forms.MaskedTextBox
        Me.LbPtotal = New System.Windows.Forms.Label
        Me.MskCantidad = New System.Windows.Forms.MaskedTextBox
        Me.LbCantidad = New System.Windows.Forms.Label
        Me.MskPunit = New System.Windows.Forms.MaskedTextBox
        Me.Punit = New System.Windows.Forms.Label
        Me.TxtArticulo = New System.Windows.Forms.TextBox
        Me.LbArticulo = New System.Windows.Forms.Label
        Me.DtgArt = New System.Windows.Forms.DataGridView
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.CmdVaciar = New System.Windows.Forms.Button
        Me.CmdBorrar = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.TxtTtotal = New System.Windows.Forms.TextBox
        Me.LbTot = New System.Windows.Forms.Label
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.CmbComp = New System.Windows.Forms.ToolStripComboBox
        Me.BtnArt = New System.Windows.Forms.ToolStripButton
        Me.TxtBarra = New System.Windows.Forms.TextBox
        Me.DtgIva = New System.Windows.Forms.DataGridView
        Me.Dtget = New System.Windows.Forms.DataGridView
        Me.GroupBox1.SuspendLayout()
        Me.GrpFamilia.SuspendLayout()
        Me.Grupo.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.DtgArt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DtgIva, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dtget, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtSaldo)
        Me.GroupBox1.Controls.Add(Me.LbSaldo)
        Me.GroupBox1.Controls.Add(Me.Txtciudad)
        Me.GroupBox1.Controls.Add(Me.LbCiudad)
        Me.GroupBox1.Controls.Add(Me.TxtCuit)
        Me.GroupBox1.Controls.Add(Me.TxtCiva)
        Me.GroupBox1.Controls.Add(Me.LbCuit)
        Me.GroupBox1.Controls.Add(Me.LbCdeIva)
        Me.GroupBox1.Controls.Add(Me.TxTDirecion)
        Me.GroupBox1.Controls.Add(Me.LbDireccion)
        Me.GroupBox1.Controls.Add(Me.TxtPro)
        Me.GroupBox1.Controls.Add(Me.LbProv)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(770, 112)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'TxtSaldo
        '
        Me.TxtSaldo.Enabled = False
        Me.TxtSaldo.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSaldo.Location = New System.Drawing.Point(665, 72)
        Me.TxtSaldo.Name = "TxtSaldo"
        Me.TxtSaldo.Size = New System.Drawing.Size(100, 29)
        Me.TxtSaldo.TabIndex = 13
        '
        'LbSaldo
        '
        Me.LbSaldo.AutoSize = True
        Me.LbSaldo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSaldo.ForeColor = System.Drawing.Color.Blue
        Me.LbSaldo.Location = New System.Drawing.Point(665, 58)
        Me.LbSaldo.Name = "LbSaldo"
        Me.LbSaldo.Size = New System.Drawing.Size(43, 14)
        Me.LbSaldo.TabIndex = 12
        Me.LbSaldo.Text = "Saldo :"
        '
        'Txtciudad
        '
        Me.Txtciudad.Enabled = False
        Me.Txtciudad.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtciudad.Location = New System.Drawing.Point(409, 72)
        Me.Txtciudad.Name = "Txtciudad"
        Me.Txtciudad.Size = New System.Drawing.Size(254, 29)
        Me.Txtciudad.TabIndex = 11
        '
        'LbCiudad
        '
        Me.LbCiudad.AutoSize = True
        Me.LbCiudad.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCiudad.ForeColor = System.Drawing.Color.Blue
        Me.LbCiudad.Location = New System.Drawing.Point(410, 58)
        Me.LbCiudad.Name = "LbCiudad"
        Me.LbCiudad.Size = New System.Drawing.Size(51, 14)
        Me.LbCiudad.TabIndex = 10
        Me.LbCiudad.Text = "Ciudad :"
        '
        'TxtCuit
        '
        Me.TxtCuit.Enabled = False
        Me.TxtCuit.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCuit.Location = New System.Drawing.Point(245, 72)
        Me.TxtCuit.Name = "TxtCuit"
        Me.TxtCuit.Size = New System.Drawing.Size(161, 29)
        Me.TxtCuit.TabIndex = 9
        '
        'TxtCiva
        '
        Me.TxtCiva.Enabled = False
        Me.TxtCiva.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCiva.Location = New System.Drawing.Point(6, 72)
        Me.TxtCiva.Name = "TxtCiva"
        Me.TxtCiva.Size = New System.Drawing.Size(236, 29)
        Me.TxtCiva.TabIndex = 8
        '
        'LbCuit
        '
        Me.LbCuit.AutoSize = True
        Me.LbCuit.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCuit.ForeColor = System.Drawing.Color.Blue
        Me.LbCuit.Location = New System.Drawing.Point(245, 58)
        Me.LbCuit.Name = "LbCuit"
        Me.LbCuit.Size = New System.Drawing.Size(35, 14)
        Me.LbCuit.TabIndex = 7
        Me.LbCuit.Text = "Cuit :"
        '
        'LbCdeIva
        '
        Me.LbCdeIva.AutoSize = True
        Me.LbCdeIva.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCdeIva.ForeColor = System.Drawing.Color.Blue
        Me.LbCdeIva.Location = New System.Drawing.Point(6, 58)
        Me.LbCdeIva.Name = "LbCdeIva"
        Me.LbCdeIva.Size = New System.Drawing.Size(59, 14)
        Me.LbCdeIva.TabIndex = 5
        Me.LbCdeIva.Text = "C. de Iva :"
        '
        'TxTDirecion
        '
        Me.TxTDirecion.Enabled = False
        Me.TxTDirecion.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxTDirecion.Location = New System.Drawing.Point(409, 24)
        Me.TxTDirecion.Name = "TxTDirecion"
        Me.TxTDirecion.Size = New System.Drawing.Size(358, 29)
        Me.TxTDirecion.TabIndex = 3
        '
        'LbDireccion
        '
        Me.LbDireccion.AutoSize = True
        Me.LbDireccion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDireccion.ForeColor = System.Drawing.Color.Blue
        Me.LbDireccion.Location = New System.Drawing.Point(411, 10)
        Me.LbDireccion.Name = "LbDireccion"
        Me.LbDireccion.Size = New System.Drawing.Size(64, 14)
        Me.LbDireccion.TabIndex = 2
        Me.LbDireccion.Text = "Direccion :"
        '
        'TxtPro
        '
        Me.TxtPro.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPro.Location = New System.Drawing.Point(6, 24)
        Me.TxtPro.Name = "TxtPro"
        Me.TxtPro.Size = New System.Drawing.Size(400, 29)
        Me.TxtPro.TabIndex = 1
        '
        'LbProv
        '
        Me.LbProv.AutoSize = True
        Me.LbProv.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbProv.ForeColor = System.Drawing.Color.Blue
        Me.LbProv.Location = New System.Drawing.Point(6, 10)
        Me.LbProv.Name = "LbProv"
        Me.LbProv.Size = New System.Drawing.Size(71, 14)
        Me.LbProv.TabIndex = 0
        Me.LbProv.Text = "Proveedor :"
        '
        'GrpFamilia
        '
        Me.GrpFamilia.Controls.Add(Me.LbFamilia)
        Me.GrpFamilia.Controls.Add(Me.MskUtil)
        Me.GrpFamilia.Controls.Add(Me.LbUtilidad)
        Me.GrpFamilia.ForeColor = System.Drawing.Color.Blue
        Me.GrpFamilia.Location = New System.Drawing.Point(410, 142)
        Me.GrpFamilia.Name = "GrpFamilia"
        Me.GrpFamilia.Size = New System.Drawing.Size(363, 60)
        Me.GrpFamilia.TabIndex = 52
        Me.GrpFamilia.TabStop = False
        '
        'LbFamilia
        '
        Me.LbFamilia.AutoSize = True
        Me.LbFamilia.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFamilia.Location = New System.Drawing.Point(105, 27)
        Me.LbFamilia.Name = "LbFamilia"
        Me.LbFamilia.Size = New System.Drawing.Size(73, 19)
        Me.LbFamilia.TabIndex = 2
        Me.LbFamilia.Text = "Familia :"
        '
        'MskUtil
        '
        Me.MskUtil.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskUtil.Location = New System.Drawing.Point(6, 24)
        Me.MskUtil.Name = "MskUtil"
        Me.MskUtil.Size = New System.Drawing.Size(95, 29)
        Me.MskUtil.TabIndex = 1
        '
        'LbUtilidad
        '
        Me.LbUtilidad.AutoSize = True
        Me.LbUtilidad.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbUtilidad.ForeColor = System.Drawing.Color.Blue
        Me.LbUtilidad.Location = New System.Drawing.Point(6, 10)
        Me.LbUtilidad.Name = "LbUtilidad"
        Me.LbUtilidad.Size = New System.Drawing.Size(65, 14)
        Me.LbUtilidad.TabIndex = 0
        Me.LbUtilidad.Text = "Utilidad % :"
        '
        'Grupo
        '
        Me.Grupo.Controls.Add(Me.DtcFecha)
        Me.Grupo.Controls.Add(Me.LbFecha)
        Me.Grupo.Controls.Add(Me.TxtNumFac)
        Me.Grupo.Controls.Add(Me.LbNumero)
        Me.Grupo.Controls.Add(Me.TxtPv)
        Me.Grupo.Controls.Add(Me.LbPv)
        Me.Grupo.Enabled = False
        Me.Grupo.Location = New System.Drawing.Point(6, 142)
        Me.Grupo.Name = "Grupo"
        Me.Grupo.Size = New System.Drawing.Size(310, 60)
        Me.Grupo.TabIndex = 51
        Me.Grupo.TabStop = False
        '
        'DtcFecha
        '
        Me.DtcFecha.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtcFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtcFecha.Location = New System.Drawing.Point(178, 24)
        Me.DtcFecha.Name = "DtcFecha"
        Me.DtcFecha.Size = New System.Drawing.Size(126, 29)
        Me.DtcFecha.TabIndex = 5
        '
        'LbFecha
        '
        Me.LbFecha.AutoSize = True
        Me.LbFecha.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFecha.ForeColor = System.Drawing.Color.Blue
        Me.LbFecha.Location = New System.Drawing.Point(178, 10)
        Me.LbFecha.Name = "LbFecha"
        Me.LbFecha.Size = New System.Drawing.Size(45, 14)
        Me.LbFecha.TabIndex = 4
        Me.LbFecha.Text = "Fecha :"
        '
        'TxtNumFac
        '
        Me.TxtNumFac.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNumFac.Location = New System.Drawing.Point(75, 24)
        Me.TxtNumFac.Name = "TxtNumFac"
        Me.TxtNumFac.Size = New System.Drawing.Size(100, 29)
        Me.TxtNumFac.TabIndex = 3
        '
        'LbNumero
        '
        Me.LbNumero.AutoSize = True
        Me.LbNumero.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNumero.ForeColor = System.Drawing.Color.Blue
        Me.LbNumero.Location = New System.Drawing.Point(75, 10)
        Me.LbNumero.Name = "LbNumero"
        Me.LbNumero.Size = New System.Drawing.Size(57, 14)
        Me.LbNumero.TabIndex = 2
        Me.LbNumero.Text = "Numero :"
        '
        'TxtPv
        '
        Me.TxtPv.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.TxtPv.Location = New System.Drawing.Point(6, 24)
        Me.TxtPv.MaxLength = 4
        Me.TxtPv.Name = "TxtPv"
        Me.TxtPv.Size = New System.Drawing.Size(68, 29)
        Me.TxtPv.TabIndex = 1
        '
        'LbPv
        '
        Me.LbPv.AutoSize = True
        Me.LbPv.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPv.ForeColor = System.Drawing.Color.Blue
        Me.LbPv.Location = New System.Drawing.Point(6, 10)
        Me.LbPv.Name = "LbPv"
        Me.LbPv.Size = New System.Drawing.Size(26, 14)
        Me.LbPv.TabIndex = 0
        Me.LbPv.Text = "P.V."
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RdtCta)
        Me.GroupBox3.Controls.Add(Me.RdContado)
        Me.GroupBox3.Enabled = False
        Me.GroupBox3.Location = New System.Drawing.Point(319, 142)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(85, 60)
        Me.GroupBox3.TabIndex = 50
        Me.GroupBox3.TabStop = False
        '
        'RdtCta
        '
        Me.RdtCta.AutoSize = True
        Me.RdtCta.Checked = True
        Me.RdtCta.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdtCta.ForeColor = System.Drawing.Color.Blue
        Me.RdtCta.Location = New System.Drawing.Point(6, 33)
        Me.RdtCta.Name = "RdtCta"
        Me.RdtCta.Size = New System.Drawing.Size(68, 18)
        Me.RdtCta.TabIndex = 1
        Me.RdtCta.TabStop = True
        Me.RdtCta.Text = "CtaCte :"
        Me.RdtCta.UseVisualStyleBackColor = True
        '
        'RdContado
        '
        Me.RdContado.AutoSize = True
        Me.RdContado.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdContado.ForeColor = System.Drawing.Color.Blue
        Me.RdContado.Location = New System.Drawing.Point(6, 10)
        Me.RdContado.Name = "RdContado"
        Me.RdContado.Size = New System.Drawing.Size(77, 18)
        Me.RdContado.TabIndex = 0
        Me.RdContado.Text = "Contado :"
        Me.RdContado.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.GroupBox6)
        Me.GroupBox8.Controls.Add(Me.MskPtotal)
        Me.GroupBox8.Controls.Add(Me.LbPtotal)
        Me.GroupBox8.Controls.Add(Me.MskCantidad)
        Me.GroupBox8.Controls.Add(Me.LbCantidad)
        Me.GroupBox8.Controls.Add(Me.MskPunit)
        Me.GroupBox8.Controls.Add(Me.Punit)
        Me.GroupBox8.Controls.Add(Me.TxtArticulo)
        Me.GroupBox8.Controls.Add(Me.LbArticulo)
        Me.GroupBox8.Enabled = False
        Me.GroupBox8.Location = New System.Drawing.Point(6, 203)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(770, 65)
        Me.GroupBox8.TabIndex = 53
        Me.GroupBox8.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.CmdCerrar)
        Me.GroupBox6.Location = New System.Drawing.Point(328, 5)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(109, 60)
        Me.GroupBox6.TabIndex = 37
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Visible = False
        '
        'CmdCerrar
        '
        Me.CmdCerrar.Image = Global.Super.My.Resources.Resources.save
        Me.CmdCerrar.Location = New System.Drawing.Point(6, 14)
        Me.CmdCerrar.Name = "CmdCerrar"
        Me.CmdCerrar.Size = New System.Drawing.Size(97, 40)
        Me.CmdCerrar.TabIndex = 0
        Me.CmdCerrar.UseVisualStyleBackColor = True
        '
        'MskPtotal
        '
        Me.MskPtotal.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskPtotal.Location = New System.Drawing.Point(667, 24)
        Me.MskPtotal.Name = "MskPtotal"
        Me.MskPtotal.Size = New System.Drawing.Size(100, 29)
        Me.MskPtotal.TabIndex = 3
        '
        'LbPtotal
        '
        Me.LbPtotal.AutoSize = True
        Me.LbPtotal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPtotal.ForeColor = System.Drawing.Color.Blue
        Me.LbPtotal.Location = New System.Drawing.Point(667, 10)
        Me.LbPtotal.Name = "LbPtotal"
        Me.LbPtotal.Size = New System.Drawing.Size(48, 14)
        Me.LbPtotal.TabIndex = 6
        Me.LbPtotal.Text = "P.Total :"
        '
        'MskCantidad
        '
        Me.MskCantidad.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskCantidad.Location = New System.Drawing.Point(563, 24)
        Me.MskCantidad.Name = "MskCantidad"
        Me.MskCantidad.Size = New System.Drawing.Size(100, 29)
        Me.MskCantidad.TabIndex = 2
        '
        'LbCantidad
        '
        Me.LbCantidad.AutoSize = True
        Me.LbCantidad.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCantidad.ForeColor = System.Drawing.Color.Blue
        Me.LbCantidad.Location = New System.Drawing.Point(563, 10)
        Me.LbCantidad.Name = "LbCantidad"
        Me.LbCantidad.Size = New System.Drawing.Size(61, 14)
        Me.LbCantidad.TabIndex = 4
        Me.LbCantidad.Text = "Cantidad :"
        '
        'MskPunit
        '
        Me.MskPunit.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskPunit.Location = New System.Drawing.Point(459, 24)
        Me.MskPunit.Name = "MskPunit"
        Me.MskPunit.Size = New System.Drawing.Size(100, 29)
        Me.MskPunit.TabIndex = 1
        '
        'Punit
        '
        Me.Punit.AutoSize = True
        Me.Punit.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Punit.ForeColor = System.Drawing.Color.Blue
        Me.Punit.Location = New System.Drawing.Point(459, 10)
        Me.Punit.Name = "Punit"
        Me.Punit.Size = New System.Drawing.Size(46, 14)
        Me.Punit.TabIndex = 2
        Me.Punit.Text = "P. Unit :"
        '
        'TxtArticulo
        '
        Me.TxtArticulo.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtArticulo.Location = New System.Drawing.Point(6, 25)
        Me.TxtArticulo.Name = "TxtArticulo"
        Me.TxtArticulo.Size = New System.Drawing.Size(450, 29)
        Me.TxtArticulo.TabIndex = 0
        '
        'LbArticulo
        '
        Me.LbArticulo.AutoSize = True
        Me.LbArticulo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbArticulo.ForeColor = System.Drawing.Color.Blue
        Me.LbArticulo.Location = New System.Drawing.Point(6, 10)
        Me.LbArticulo.Name = "LbArticulo"
        Me.LbArticulo.Size = New System.Drawing.Size(56, 14)
        Me.LbArticulo.TabIndex = 0
        Me.LbArticulo.Text = "Articulo :"
        '
        'DtgArt
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DtgArt.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DtgArt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DtgArt.DefaultCellStyle = DataGridViewCellStyle8
        Me.DtgArt.Location = New System.Drawing.Point(6, 272)
        Me.DtgArt.Name = "DtgArt"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DtgArt.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DtgArt.Size = New System.Drawing.Size(770, 269)
        Me.DtgArt.TabIndex = 54
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.CmdVaciar)
        Me.GroupBox2.Controls.Add(Me.CmdBorrar)
        Me.GroupBox2.Location = New System.Drawing.Point(394, 545)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(145, 60)
        Me.GroupBox2.TabIndex = 56
        Me.GroupBox2.TabStop = False
        '
        'CmdVaciar
        '
        Me.CmdVaciar.Image = Global.Super.My.Resources.Resources.Eliminar
        Me.CmdVaciar.Location = New System.Drawing.Point(77, 9)
        Me.CmdVaciar.Name = "CmdVaciar"
        Me.CmdVaciar.Size = New System.Drawing.Size(65, 45)
        Me.CmdVaciar.TabIndex = 14
        Me.CmdVaciar.UseVisualStyleBackColor = True
        '
        'CmdBorrar
        '
        Me.CmdBorrar.Image = Global.Super.My.Resources.Resources.Modificar
        Me.CmdBorrar.Location = New System.Drawing.Point(6, 9)
        Me.CmdBorrar.Name = "CmdBorrar"
        Me.CmdBorrar.Size = New System.Drawing.Size(65, 45)
        Me.CmdBorrar.TabIndex = 5
        Me.CmdBorrar.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TxtTtotal)
        Me.GroupBox4.Controls.Add(Me.LbTot)
        Me.GroupBox4.Location = New System.Drawing.Point(646, 545)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(132, 63)
        Me.GroupBox4.TabIndex = 55
        Me.GroupBox4.TabStop = False
        '
        'TxtTtotal
        '
        Me.TxtTtotal.Enabled = False
        Me.TxtTtotal.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTtotal.Location = New System.Drawing.Point(9, 27)
        Me.TxtTtotal.Name = "TxtTtotal"
        Me.TxtTtotal.Size = New System.Drawing.Size(120, 29)
        Me.TxtTtotal.TabIndex = 1
        '
        'LbTot
        '
        Me.LbTot.AutoSize = True
        Me.LbTot.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTot.ForeColor = System.Drawing.Color.Blue
        Me.LbTot.Location = New System.Drawing.Point(6, 10)
        Me.LbTot.Name = "LbTot"
        Me.LbTot.Size = New System.Drawing.Size(39, 14)
        Me.LbTot.TabIndex = 0
        Me.LbTot.Text = "Total :"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CmbComp, Me.BtnArt})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(786, 43)
        Me.ToolStrip1.TabIndex = 57
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'CmbComp
        '
        Me.CmbComp.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbComp.Items.AddRange(New Object() {"Factura", "Nota de Credito"})
        Me.CmbComp.Name = "CmbComp"
        Me.CmbComp.Size = New System.Drawing.Size(150, 43)
        '
        'BtnArt
        '
        Me.BtnArt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnArt.Image = Global.Super.My.Resources.Resources.Articulo
        Me.BtnArt.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnArt.Name = "BtnArt"
        Me.BtnArt.Padding = New System.Windows.Forms.Padding(10)
        Me.BtnArt.Size = New System.Drawing.Size(40, 40)
        Me.BtnArt.Text = "Pantalla Articulos"
        '
        'TxtBarra
        '
        Me.TxtBarra.Location = New System.Drawing.Point(91, 546)
        Me.TxtBarra.Name = "TxtBarra"
        Me.TxtBarra.Size = New System.Drawing.Size(96, 20)
        Me.TxtBarra.TabIndex = 58
        '
        'DtgIva
        '
        Me.DtgIva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgIva.Location = New System.Drawing.Point(100, 583)
        Me.DtgIva.Name = "DtgIva"
        Me.DtgIva.Size = New System.Drawing.Size(110, 24)
        Me.DtgIva.TabIndex = 59
        Me.DtgIva.Visible = False
        '
        'Dtget
        '
        Me.Dtget.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dtget.Location = New System.Drawing.Point(228, 567)
        Me.Dtget.Name = "Dtget"
        Me.Dtget.Size = New System.Drawing.Size(81, 39)
        Me.Dtget.TabIndex = 60
        Me.Dtget.Visible = False
        '
        'FrmCarCom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 634)
        Me.Controls.Add(Me.Dtget)
        Me.Controls.Add(Me.DtgIva)
        Me.Controls.Add(Me.TxtBarra)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.DtgArt)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GrpFamilia)
        Me.Controls.Add(Me.Grupo)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCarCom"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cargar Factura de Compra"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GrpFamilia.ResumeLayout(False)
        Me.GrpFamilia.PerformLayout()
        Me.Grupo.ResumeLayout(False)
        Me.Grupo.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.DtgArt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DtgIva, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dtget, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtSaldo As System.Windows.Forms.TextBox
    Friend WithEvents LbSaldo As System.Windows.Forms.Label
    Friend WithEvents Txtciudad As System.Windows.Forms.TextBox
    Friend WithEvents LbCiudad As System.Windows.Forms.Label
    Friend WithEvents TxtCuit As System.Windows.Forms.TextBox
    Friend WithEvents TxtCiva As System.Windows.Forms.TextBox
    Friend WithEvents LbCuit As System.Windows.Forms.Label
    Friend WithEvents LbCdeIva As System.Windows.Forms.Label
    Friend WithEvents TxTDirecion As System.Windows.Forms.TextBox
    Friend WithEvents LbDireccion As System.Windows.Forms.Label
    Friend WithEvents TxtPro As System.Windows.Forms.TextBox
    Friend WithEvents LbProv As System.Windows.Forms.Label
    Friend WithEvents GrpFamilia As System.Windows.Forms.GroupBox
    Friend WithEvents LbFamilia As System.Windows.Forms.Label
    Friend WithEvents MskUtil As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LbUtilidad As System.Windows.Forms.Label
    Friend WithEvents Grupo As System.Windows.Forms.GroupBox
    Friend WithEvents DtcFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents LbFecha As System.Windows.Forms.Label
    Friend WithEvents TxtNumFac As System.Windows.Forms.TextBox
    Friend WithEvents LbNumero As System.Windows.Forms.Label
    Friend WithEvents TxtPv As System.Windows.Forms.TextBox
    Friend WithEvents LbPv As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RdtCta As System.Windows.Forms.RadioButton
    Friend WithEvents RdContado As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdCerrar As System.Windows.Forms.Button
    Friend WithEvents MskPtotal As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LbPtotal As System.Windows.Forms.Label
    Friend WithEvents MskCantidad As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LbCantidad As System.Windows.Forms.Label
    Friend WithEvents MskPunit As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Punit As System.Windows.Forms.Label
    Friend WithEvents TxtArticulo As System.Windows.Forms.TextBox
    Friend WithEvents LbArticulo As System.Windows.Forms.Label
    Friend WithEvents DtgArt As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdVaciar As System.Windows.Forms.Button
    Friend WithEvents CmdBorrar As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtTtotal As System.Windows.Forms.TextBox
    Friend WithEvents LbTot As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents CmbComp As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents BtnArt As System.Windows.Forms.ToolStripButton
    Friend WithEvents TxtBarra As System.Windows.Forms.TextBox
    Friend WithEvents DtgIva As System.Windows.Forms.DataGridView
    Friend WithEvents Dtget As System.Windows.Forms.DataGridView
End Class
