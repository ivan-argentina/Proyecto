<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFactura
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFactura))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TxtProv = New System.Windows.Forms.TextBox
        Me.LbProvincia = New System.Windows.Forms.Label
        Me.TxtCpostal = New System.Windows.Forms.MaskedTextBox
        Me.LbSaldo = New System.Windows.Forms.Label
        Me.CmdBuscar = New System.Windows.Forms.Button
        Me.TxtCiudad = New System.Windows.Forms.TextBox
        Me.LbCiudad = New System.Windows.Forms.Label
        Me.TxtcIva = New System.Windows.Forms.TextBox
        Me.LbCiva = New System.Windows.Forms.Label
        Me.TxtDir = New System.Windows.Forms.TextBox
        Me.LbDireccion = New System.Windows.Forms.Label
        Me.LbCuit = New System.Windows.Forms.Label
        Me.TxtCli = New System.Windows.Forms.TextBox
        Me.LbCli = New System.Windows.Forms.Label
        Me.MskCuit = New System.Windows.Forms.MaskedTextBox
        Me.Grupo = New System.Windows.Forms.GroupBox
        Me.DtcFecha = New System.Windows.Forms.DateTimePicker
        Me.LbFecha = New System.Windows.Forms.Label
        Me.TxtNumFac = New System.Windows.Forms.TextBox
        Me.LbNumero = New System.Windows.Forms.Label
        Me.TxtPv = New System.Windows.Forms.TextBox
        Me.LbPv = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CmdFactura = New System.Windows.Forms.Button
        Me.BtnFin = New System.Windows.Forms.Button
        Me.CmdCta = New System.Windows.Forms.Button
        Me.CmdCheque = New System.Windows.Forms.Button
        Me.CmdTarjeta = New System.Windows.Forms.Button
        Me.Cmdefectivo = New System.Windows.Forms.Button
        Me.CmdBart = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.MskDescuento = New System.Windows.Forms.MaskedTextBox
        Me.LbDesc = New System.Windows.Forms.Label
        Me.MskPtotal = New System.Windows.Forms.MaskedTextBox
        Me.LbPtotal = New System.Windows.Forms.Label
        Me.MskCantidad = New System.Windows.Forms.MaskedTextBox
        Me.LbCantidad = New System.Windows.Forms.Label
        Me.MskPunit = New System.Windows.Forms.MaskedTextBox
        Me.Punit = New System.Windows.Forms.Label
        Me.TxtArticulo = New System.Windows.Forms.TextBox
        Me.LbArticulo = New System.Windows.Forms.Label
        Me.Dtgart = New System.Windows.Forms.DataGridView
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Lb = New System.Windows.Forms.Label
        Me.DtgPag = New System.Windows.Forms.DataGridView
        Me.Group = New System.Windows.Forms.GroupBox
        Me.TxtOb1 = New System.Windows.Forms.TextBox
        Me.TxtOb = New System.Windows.Forms.TextBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.MskDescGral = New System.Windows.Forms.MaskedTextBox
        Me.LbDescgral = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.LbVVen = New System.Windows.Forms.Label
        Me.DtcVenc = New System.Windows.Forms.DateTimePicker
        Me.TxtPag = New System.Windows.Forms.TextBox
        Me.TxtNCh = New System.Windows.Forms.TextBox
        Me.LbIm = New System.Windows.Forms.Label
        Me.MskImp = New System.Windows.Forms.MaskedTextBox
        Me.LbNum = New System.Windows.Forms.Label
        Me.Lbtar = New System.Windows.Forms.Label
        Me.txtNumero = New System.Windows.Forms.TextBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.DtgCuotas = New System.Windows.Forms.DataGridView
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.DtcDesde = New System.Windows.Forms.DateTimePicker
        Me.LbDesde = New System.Windows.Forms.Label
        Me.MskCuotas = New System.Windows.Forms.MaskedTextBox
        Me.LbCuotas = New System.Windows.Forms.Label
        Me.MskEntrega = New System.Windows.Forms.MaskedTextBox
        Me.LbEntrega = New System.Windows.Forms.Label
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.CArticulos = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.Ccli = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.CmdCer = New System.Windows.Forms.ToolStripButton
        Me.CmbRepZ = New System.Windows.Forms.ToolStripButton
        Me.BtnArt = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.CblNg = New System.Windows.Forms.ToolStripButton
        Me.CmbMenu = New System.Windows.Forms.ToolStripComboBox
        Me.TxtNCr = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.TsNc = New System.Windows.Forms.ToolStripComboBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.DtgTotAlic = New System.Windows.Forms.DataGridView
        Me.Button2 = New System.Windows.Forms.Button
        Me.TxtBarra = New System.Windows.Forms.TextBox
        Me.DtcFech = New System.Windows.Forms.DateTimePicker
        Me.TxtReq = New System.Windows.Forms.TextBox
        Me.TxtP = New System.Windows.Forms.TextBox
        Me.TxtTot = New System.Windows.Forms.TextBox
        Me.DtgNc = New System.Windows.Forms.DataGridView
        Me.DtgRem = New System.Windows.Forms.DataGridView
        Me.TxtTo = New System.Windows.Forms.TextBox
        Me.LbCan = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.Grupo.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Dtgart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DtgPag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Group.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DtgCuotas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DtgTotAlic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtgNc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtgRem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtProv)
        Me.GroupBox1.Controls.Add(Me.LbProvincia)
        Me.GroupBox1.Controls.Add(Me.TxtCpostal)
        Me.GroupBox1.Controls.Add(Me.LbSaldo)
        Me.GroupBox1.Controls.Add(Me.CmdBuscar)
        Me.GroupBox1.Controls.Add(Me.TxtCiudad)
        Me.GroupBox1.Controls.Add(Me.LbCiudad)
        Me.GroupBox1.Controls.Add(Me.TxtcIva)
        Me.GroupBox1.Controls.Add(Me.LbCiva)
        Me.GroupBox1.Controls.Add(Me.TxtDir)
        Me.GroupBox1.Controls.Add(Me.LbDireccion)
        Me.GroupBox1.Controls.Add(Me.LbCuit)
        Me.GroupBox1.Controls.Add(Me.TxtCli)
        Me.GroupBox1.Controls.Add(Me.LbCli)
        Me.GroupBox1.Controls.Add(Me.MskCuit)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(870, 113)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'TxtProv
        '
        Me.TxtProv.Enabled = False
        Me.TxtProv.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtProv.Location = New System.Drawing.Point(648, 72)
        Me.TxtProv.Name = "TxtProv"
        Me.TxtProv.Size = New System.Drawing.Size(215, 29)
        Me.TxtProv.TabIndex = 17
        '
        'LbProvincia
        '
        Me.LbProvincia.AutoSize = True
        Me.LbProvincia.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbProvincia.ForeColor = System.Drawing.Color.Blue
        Me.LbProvincia.Location = New System.Drawing.Point(648, 58)
        Me.LbProvincia.Name = "LbProvincia"
        Me.LbProvincia.Size = New System.Drawing.Size(63, 14)
        Me.LbProvincia.TabIndex = 16
        Me.LbProvincia.Text = "Provincia :"
        '
        'TxtCpostal
        '
        Me.TxtCpostal.Enabled = False
        Me.TxtCpostal.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCpostal.Location = New System.Drawing.Point(705, 24)
        Me.TxtCpostal.Name = "TxtCpostal"
        Me.TxtCpostal.Size = New System.Drawing.Size(95, 29)
        Me.TxtCpostal.TabIndex = 15
        '
        'LbSaldo
        '
        Me.LbSaldo.AutoSize = True
        Me.LbSaldo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSaldo.ForeColor = System.Drawing.Color.Blue
        Me.LbSaldo.Location = New System.Drawing.Point(705, 10)
        Me.LbSaldo.Name = "LbSaldo"
        Me.LbSaldo.Size = New System.Drawing.Size(58, 14)
        Me.LbSaldo.TabIndex = 14
        Me.LbSaldo.Text = "C.Postal :"
        '
        'CmdBuscar
        '
        Me.CmdBuscar.Image = CType(resources.GetObject("CmdBuscar.Image"), System.Drawing.Image)
        Me.CmdBuscar.Location = New System.Drawing.Point(802, 8)
        Me.CmdBuscar.Name = "CmdBuscar"
        Me.CmdBuscar.Size = New System.Drawing.Size(65, 45)
        Me.CmdBuscar.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.CmdBuscar, "Buscar Un Cliente")
        Me.CmdBuscar.UseVisualStyleBackColor = True
        '
        'TxtCiudad
        '
        Me.TxtCiudad.Enabled = False
        Me.TxtCiudad.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCiudad.Location = New System.Drawing.Point(409, 72)
        Me.TxtCiudad.Name = "TxtCiudad"
        Me.TxtCiudad.Size = New System.Drawing.Size(236, 29)
        Me.TxtCiudad.TabIndex = 12
        '
        'LbCiudad
        '
        Me.LbCiudad.AutoSize = True
        Me.LbCiudad.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCiudad.ForeColor = System.Drawing.Color.Blue
        Me.LbCiudad.Location = New System.Drawing.Point(410, 58)
        Me.LbCiudad.Name = "LbCiudad"
        Me.LbCiudad.Size = New System.Drawing.Size(51, 14)
        Me.LbCiudad.TabIndex = 11
        Me.LbCiudad.Text = "Ciudad :"
        '
        'TxtcIva
        '
        Me.TxtcIva.Enabled = False
        Me.TxtcIva.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtcIva.Location = New System.Drawing.Point(6, 72)
        Me.TxtcIva.Name = "TxtcIva"
        Me.TxtcIva.Size = New System.Drawing.Size(236, 29)
        Me.TxtcIva.TabIndex = 10
        '
        'LbCiva
        '
        Me.LbCiva.AutoSize = True
        Me.LbCiva.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCiva.ForeColor = System.Drawing.Color.Blue
        Me.LbCiva.Location = New System.Drawing.Point(6, 58)
        Me.LbCiva.Name = "LbCiva"
        Me.LbCiva.Size = New System.Drawing.Size(59, 14)
        Me.LbCiva.TabIndex = 9
        Me.LbCiva.Text = "C. de Iva :"
        '
        'TxtDir
        '
        Me.TxtDir.Enabled = False
        Me.TxtDir.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDir.Location = New System.Drawing.Point(409, 24)
        Me.TxtDir.Name = "TxtDir"
        Me.TxtDir.Size = New System.Drawing.Size(292, 29)
        Me.TxtDir.TabIndex = 8
        '
        'LbDireccion
        '
        Me.LbDireccion.AutoSize = True
        Me.LbDireccion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDireccion.ForeColor = System.Drawing.Color.Blue
        Me.LbDireccion.Location = New System.Drawing.Point(409, 10)
        Me.LbDireccion.Name = "LbDireccion"
        Me.LbDireccion.Size = New System.Drawing.Size(64, 14)
        Me.LbDireccion.TabIndex = 7
        Me.LbDireccion.Text = "Direccion :"
        '
        'LbCuit
        '
        Me.LbCuit.AutoSize = True
        Me.LbCuit.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCuit.ForeColor = System.Drawing.Color.Blue
        Me.LbCuit.Location = New System.Drawing.Point(245, 58)
        Me.LbCuit.Name = "LbCuit"
        Me.LbCuit.Size = New System.Drawing.Size(35, 14)
        Me.LbCuit.TabIndex = 5
        Me.LbCuit.Text = "Cuit :"
        '
        'TxtCli
        '
        Me.TxtCli.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCli.Location = New System.Drawing.Point(6, 24)
        Me.TxtCli.Name = "TxtCli"
        Me.TxtCli.Size = New System.Drawing.Size(400, 29)
        Me.TxtCli.TabIndex = 100
        '
        'LbCli
        '
        Me.LbCli.AutoSize = True
        Me.LbCli.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCli.ForeColor = System.Drawing.Color.Blue
        Me.LbCli.Location = New System.Drawing.Point(6, 10)
        Me.LbCli.Name = "LbCli"
        Me.LbCli.Size = New System.Drawing.Size(52, 14)
        Me.LbCli.TabIndex = 3
        Me.LbCli.Text = "Cliente :"
        '
        'MskCuit
        '
        Me.MskCuit.Enabled = False
        Me.MskCuit.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskCuit.Location = New System.Drawing.Point(245, 72)
        Me.MskCuit.Name = "MskCuit"
        Me.MskCuit.Size = New System.Drawing.Size(161, 29)
        Me.MskCuit.TabIndex = 6
        '
        'Grupo
        '
        Me.Grupo.Controls.Add(Me.DtcFecha)
        Me.Grupo.Controls.Add(Me.LbFecha)
        Me.Grupo.Controls.Add(Me.TxtNumFac)
        Me.Grupo.Controls.Add(Me.LbNumero)
        Me.Grupo.Controls.Add(Me.TxtPv)
        Me.Grupo.Controls.Add(Me.LbPv)
        Me.Grupo.Location = New System.Drawing.Point(660, 4)
        Me.Grupo.Name = "Grupo"
        Me.Grupo.Size = New System.Drawing.Size(261, 60)
        Me.Grupo.TabIndex = 32
        Me.Grupo.TabStop = False
        Me.Grupo.Visible = False
        '
        'DtcFecha
        '
        Me.DtcFecha.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtcFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtcFecha.Location = New System.Drawing.Point(138, 24)
        Me.DtcFecha.Name = "DtcFecha"
        Me.DtcFecha.Size = New System.Drawing.Size(110, 29)
        Me.DtcFecha.TabIndex = 5
        '
        'LbFecha
        '
        Me.LbFecha.AutoSize = True
        Me.LbFecha.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFecha.ForeColor = System.Drawing.Color.Blue
        Me.LbFecha.Location = New System.Drawing.Point(138, 10)
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
        Me.TxtNumFac.Size = New System.Drawing.Size(60, 29)
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
        'CmdFactura
        '
        Me.CmdFactura.Enabled = False
        Me.CmdFactura.Image = CType(resources.GetObject("CmdFactura.Image"), System.Drawing.Image)
        Me.CmdFactura.Location = New System.Drawing.Point(4, 57)
        Me.CmdFactura.Name = "CmdFactura"
        Me.CmdFactura.Size = New System.Drawing.Size(98, 38)
        Me.CmdFactura.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.CmdFactura, "Facturar")
        Me.CmdFactura.UseVisualStyleBackColor = True
        '
        'BtnFin
        '
        Me.BtnFin.Image = Global.Super.My.Resources.Resources.Financiado__2_
        Me.BtnFin.Location = New System.Drawing.Point(6, 134)
        Me.BtnFin.Name = "BtnFin"
        Me.BtnFin.Size = New System.Drawing.Size(70, 38)
        Me.BtnFin.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.BtnFin, "Financiado")
        Me.BtnFin.UseVisualStyleBackColor = True
        Me.BtnFin.Visible = False
        '
        'CmdCta
        '
        Me.CmdCta.Image = CType(resources.GetObject("CmdCta.Image"), System.Drawing.Image)
        Me.CmdCta.Location = New System.Drawing.Point(6, 137)
        Me.CmdCta.Name = "CmdCta"
        Me.CmdCta.Size = New System.Drawing.Size(70, 38)
        Me.CmdCta.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.CmdCta, "Cuenta Corriente")
        Me.CmdCta.UseVisualStyleBackColor = True
        '
        'CmdCheque
        '
        Me.CmdCheque.Image = CType(resources.GetObject("CmdCheque.Image"), System.Drawing.Image)
        Me.CmdCheque.Location = New System.Drawing.Point(6, 95)
        Me.CmdCheque.Name = "CmdCheque"
        Me.CmdCheque.Size = New System.Drawing.Size(70, 38)
        Me.CmdCheque.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.CmdCheque, "Pago Con Cheque")
        Me.CmdCheque.UseVisualStyleBackColor = True
        '
        'CmdTarjeta
        '
        Me.CmdTarjeta.Image = CType(resources.GetObject("CmdTarjeta.Image"), System.Drawing.Image)
        Me.CmdTarjeta.Location = New System.Drawing.Point(6, 53)
        Me.CmdTarjeta.Name = "CmdTarjeta"
        Me.CmdTarjeta.Size = New System.Drawing.Size(70, 38)
        Me.CmdTarjeta.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.CmdTarjeta, "Pago con Tarjeta")
        Me.CmdTarjeta.UseVisualStyleBackColor = True
        '
        'Cmdefectivo
        '
        Me.Cmdefectivo.Image = CType(resources.GetObject("Cmdefectivo.Image"), System.Drawing.Image)
        Me.Cmdefectivo.Location = New System.Drawing.Point(6, 11)
        Me.Cmdefectivo.Name = "Cmdefectivo"
        Me.Cmdefectivo.Size = New System.Drawing.Size(70, 38)
        Me.Cmdefectivo.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.Cmdefectivo, "Pago Con efectivo")
        Me.Cmdefectivo.UseVisualStyleBackColor = True
        '
        'CmdBart
        '
        Me.CmdBart.Image = CType(resources.GetObject("CmdBart.Image"), System.Drawing.Image)
        Me.CmdBart.Location = New System.Drawing.Point(800, 10)
        Me.CmdBart.Name = "CmdBart"
        Me.CmdBart.Size = New System.Drawing.Size(65, 45)
        Me.CmdBart.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.CmdBart, "Buscar un Articulo")
        Me.CmdBart.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.MskDescuento)
        Me.GroupBox2.Controls.Add(Me.LbDesc)
        Me.GroupBox2.Controls.Add(Me.CmdBart)
        Me.GroupBox2.Controls.Add(Me.MskPtotal)
        Me.GroupBox2.Controls.Add(Me.LbPtotal)
        Me.GroupBox2.Controls.Add(Me.MskCantidad)
        Me.GroupBox2.Controls.Add(Me.LbCantidad)
        Me.GroupBox2.Controls.Add(Me.MskPunit)
        Me.GroupBox2.Controls.Add(Me.Punit)
        Me.GroupBox2.Controls.Add(Me.TxtArticulo)
        Me.GroupBox2.Controls.Add(Me.LbArticulo)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 153)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(870, 59)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'MskDescuento
        '
        Me.MskDescuento.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskDescuento.Location = New System.Drawing.Point(606, 24)
        Me.MskDescuento.Name = "MskDescuento"
        Me.MskDescuento.Size = New System.Drawing.Size(86, 29)
        Me.MskDescuento.TabIndex = 10
        '
        'LbDesc
        '
        Me.LbDesc.AutoSize = True
        Me.LbDesc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDesc.ForeColor = System.Drawing.Color.Blue
        Me.LbDesc.Location = New System.Drawing.Point(606, 10)
        Me.LbDesc.Name = "LbDesc"
        Me.LbDesc.Size = New System.Drawing.Size(87, 14)
        Me.LbDesc.TabIndex = 9
        Me.LbDesc.Text = "Descuento %  :"
        '
        'MskPtotal
        '
        Me.MskPtotal.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskPtotal.Location = New System.Drawing.Point(695, 24)
        Me.MskPtotal.Name = "MskPtotal"
        Me.MskPtotal.Size = New System.Drawing.Size(100, 29)
        Me.MskPtotal.TabIndex = 3
        '
        'LbPtotal
        '
        Me.LbPtotal.AutoSize = True
        Me.LbPtotal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPtotal.ForeColor = System.Drawing.Color.Blue
        Me.LbPtotal.Location = New System.Drawing.Point(695, 10)
        Me.LbPtotal.Name = "LbPtotal"
        Me.LbPtotal.Size = New System.Drawing.Size(48, 14)
        Me.LbPtotal.TabIndex = 6
        Me.LbPtotal.Text = "P.Total :"
        '
        'MskCantidad
        '
        Me.MskCantidad.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskCantidad.Location = New System.Drawing.Point(503, 24)
        Me.MskCantidad.Name = "MskCantidad"
        Me.MskCantidad.Size = New System.Drawing.Size(100, 29)
        Me.MskCantidad.TabIndex = 2
        '
        'LbCantidad
        '
        Me.LbCantidad.AutoSize = True
        Me.LbCantidad.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCantidad.ForeColor = System.Drawing.Color.Blue
        Me.LbCantidad.Location = New System.Drawing.Point(503, 10)
        Me.LbCantidad.Name = "LbCantidad"
        Me.LbCantidad.Size = New System.Drawing.Size(61, 14)
        Me.LbCantidad.TabIndex = 4
        Me.LbCantidad.Text = "Cantidad :"
        '
        'MskPunit
        '
        Me.MskPunit.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskPunit.Location = New System.Drawing.Point(400, 24)
        Me.MskPunit.Name = "MskPunit"
        Me.MskPunit.Size = New System.Drawing.Size(100, 29)
        Me.MskPunit.TabIndex = 1
        '
        'Punit
        '
        Me.Punit.AutoSize = True
        Me.Punit.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Punit.ForeColor = System.Drawing.Color.Blue
        Me.Punit.Location = New System.Drawing.Point(400, 10)
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
        Me.TxtArticulo.Size = New System.Drawing.Size(390, 29)
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
        'Dtgart
        '
        Me.Dtgart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dtgart.Location = New System.Drawing.Point(6, 220)
        Me.Dtgart.Name = "Dtgart"
        Me.Dtgart.Size = New System.Drawing.Size(803, 368)
        Me.Dtgart.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Lb)
        Me.Panel1.Controls.Add(Me.DtgPag)
        Me.Panel1.Controls.Add(Me.Group)
        Me.Panel1.Controls.Add(Me.GroupBox5)
        Me.Panel1.Controls.Add(Me.GroupBox4)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(120, 233)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(549, 189)
        Me.Panel1.TabIndex = 6
        Me.Panel1.Visible = False
        '
        'Lb
        '
        Me.Lb.AutoSize = True
        Me.Lb.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb.ForeColor = System.Drawing.Color.Blue
        Me.Lb.Location = New System.Drawing.Point(90, 223)
        Me.Lb.Name = "Lb"
        Me.Lb.Size = New System.Drawing.Size(0, 14)
        Me.Lb.TabIndex = 14
        '
        'DtgPag
        '
        Me.DtgPag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgPag.Location = New System.Drawing.Point(88, 70)
        Me.DtgPag.Name = "DtgPag"
        Me.DtgPag.Size = New System.Drawing.Size(346, 108)
        Me.DtgPag.TabIndex = 13
        '
        'Group
        '
        Me.Group.Controls.Add(Me.TxtOb1)
        Me.Group.Controls.Add(Me.TxtOb)
        Me.Group.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Group.ForeColor = System.Drawing.Color.Blue
        Me.Group.Location = New System.Drawing.Point(88, 75)
        Me.Group.Name = "Group"
        Me.Group.Size = New System.Drawing.Size(341, 92)
        Me.Group.TabIndex = 12
        Me.Group.TabStop = False
        Me.Group.Text = "Observaciones"
        Me.Group.Visible = False
        '
        'TxtOb1
        '
        Me.TxtOb1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOb1.Location = New System.Drawing.Point(6, 50)
        Me.TxtOb1.MaxLength = 50
        Me.TxtOb1.Name = "TxtOb1"
        Me.TxtOb1.Size = New System.Drawing.Size(330, 29)
        Me.TxtOb1.TabIndex = 13
        '
        'TxtOb
        '
        Me.TxtOb.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOb.Location = New System.Drawing.Point(6, 15)
        Me.TxtOb.MaxLength = 50
        Me.TxtOb.Name = "TxtOb"
        Me.TxtOb.Size = New System.Drawing.Size(330, 29)
        Me.TxtOb.TabIndex = 12
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.MskDescGral)
        Me.GroupBox5.Controls.Add(Me.LbDescgral)
        Me.GroupBox5.Controls.Add(Me.CmdFactura)
        Me.GroupBox5.Location = New System.Drawing.Point(435, 65)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(106, 140)
        Me.GroupBox5.TabIndex = 10
        Me.GroupBox5.TabStop = False
        '
        'MskDescGral
        '
        Me.MskDescGral.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskDescGral.Location = New System.Drawing.Point(5, 25)
        Me.MskDescGral.Name = "MskDescGral"
        Me.MskDescGral.Size = New System.Drawing.Size(97, 29)
        Me.MskDescGral.TabIndex = 14
        '
        'LbDescgral
        '
        Me.LbDescgral.AutoSize = True
        Me.LbDescgral.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDescgral.ForeColor = System.Drawing.Color.Blue
        Me.LbDescgral.Location = New System.Drawing.Point(5, 10)
        Me.LbDescgral.Name = "LbDescgral"
        Me.LbDescgral.Size = New System.Drawing.Size(97, 14)
        Me.LbDescgral.TabIndex = 13
        Me.LbDescgral.Text = "Descuento Gral :"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Cmdefectivo)
        Me.GroupBox4.Controls.Add(Me.CmdCta)
        Me.GroupBox4.Controls.Add(Me.CmdCheque)
        Me.GroupBox4.Controls.Add(Me.CmdTarjeta)
        Me.GroupBox4.Controls.Add(Me.BtnFin)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(78, 181)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LbVVen)
        Me.GroupBox3.Controls.Add(Me.DtcVenc)
        Me.GroupBox3.Controls.Add(Me.TxtPag)
        Me.GroupBox3.Controls.Add(Me.TxtNCh)
        Me.GroupBox3.Controls.Add(Me.LbIm)
        Me.GroupBox3.Controls.Add(Me.MskImp)
        Me.GroupBox3.Controls.Add(Me.LbNum)
        Me.GroupBox3.Controls.Add(Me.Lbtar)
        Me.GroupBox3.Controls.Add(Me.txtNumero)
        Me.GroupBox3.Location = New System.Drawing.Point(88, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(453, 62)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        '
        'LbVVen
        '
        Me.LbVVen.AutoSize = True
        Me.LbVVen.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbVVen.ForeColor = System.Drawing.Color.Blue
        Me.LbVVen.Location = New System.Drawing.Point(244, 13)
        Me.LbVVen.Name = "LbVVen"
        Me.LbVVen.Size = New System.Drawing.Size(82, 14)
        Me.LbVVen.TabIndex = 16
        Me.LbVVen.Text = "Vencimiento :"
        '
        'DtcVenc
        '
        Me.DtcVenc.Enabled = False
        Me.DtcVenc.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtcVenc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtcVenc.Location = New System.Drawing.Point(248, 28)
        Me.DtcVenc.Name = "DtcVenc"
        Me.DtcVenc.Size = New System.Drawing.Size(99, 26)
        Me.DtcVenc.TabIndex = 15
        '
        'TxtPag
        '
        Me.TxtPag.Enabled = False
        Me.TxtPag.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPag.Location = New System.Drawing.Point(0, 28)
        Me.TxtPag.Name = "TxtPag"
        Me.TxtPag.Size = New System.Drawing.Size(129, 26)
        Me.TxtPag.TabIndex = 14
        '
        'TxtNCh
        '
        Me.TxtNCh.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNCh.Location = New System.Drawing.Point(131, 28)
        Me.TxtNCh.Name = "TxtNCh"
        Me.TxtNCh.Size = New System.Drawing.Size(114, 26)
        Me.TxtNCh.TabIndex = 13
        '
        'LbIm
        '
        Me.LbIm.AutoSize = True
        Me.LbIm.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbIm.ForeColor = System.Drawing.Color.Blue
        Me.LbIm.Location = New System.Drawing.Point(350, 13)
        Me.LbIm.Name = "LbIm"
        Me.LbIm.Size = New System.Drawing.Size(57, 14)
        Me.LbIm.TabIndex = 12
        Me.LbIm.Text = "Importe :"
        '
        'MskImp
        '
        Me.MskImp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskImp.Location = New System.Drawing.Point(350, 28)
        Me.MskImp.Name = "MskImp"
        Me.MskImp.Size = New System.Drawing.Size(100, 26)
        Me.MskImp.TabIndex = 11
        '
        'LbNum
        '
        Me.LbNum.AutoSize = True
        Me.LbNum.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNum.ForeColor = System.Drawing.Color.Blue
        Me.LbNum.Location = New System.Drawing.Point(131, 13)
        Me.LbNum.Name = "LbNum"
        Me.LbNum.Size = New System.Drawing.Size(57, 14)
        Me.LbNum.TabIndex = 9
        Me.LbNum.Text = "Número :"
        '
        'Lbtar
        '
        Me.Lbtar.AutoSize = True
        Me.Lbtar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbtar.ForeColor = System.Drawing.Color.Blue
        Me.Lbtar.Location = New System.Drawing.Point(0, 13)
        Me.Lbtar.Name = "Lbtar"
        Me.Lbtar.Size = New System.Drawing.Size(50, 14)
        Me.Lbtar.TabIndex = 8
        Me.Lbtar.Text = "Tarjeta :"
        '
        'txtNumero
        '
        Me.txtNumero.Enabled = False
        Me.txtNumero.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.Location = New System.Drawing.Point(131, 28)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(114, 26)
        Me.txtNumero.TabIndex = 10
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DtgCuotas)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(88, 265)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(353, 208)
        Me.Panel2.TabIndex = 36
        Me.Panel2.Visible = False
        '
        'DtgCuotas
        '
        Me.DtgCuotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgCuotas.Location = New System.Drawing.Point(18, 72)
        Me.DtgCuotas.Name = "DtgCuotas"
        Me.DtgCuotas.Size = New System.Drawing.Size(320, 236)
        Me.DtgCuotas.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.DtcDesde)
        Me.Panel3.Controls.Add(Me.LbDesde)
        Me.Panel3.Controls.Add(Me.MskCuotas)
        Me.Panel3.Controls.Add(Me.LbCuotas)
        Me.Panel3.Controls.Add(Me.MskEntrega)
        Me.Panel3.Controls.Add(Me.LbEntrega)
        Me.Panel3.Location = New System.Drawing.Point(12, 6)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(319, 52)
        Me.Panel3.TabIndex = 0
        '
        'DtcDesde
        '
        Me.DtcDesde.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtcDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtcDesde.Location = New System.Drawing.Point(6, 18)
        Me.DtcDesde.Name = "DtcDesde"
        Me.DtcDesde.Size = New System.Drawing.Size(130, 29)
        Me.DtcDesde.TabIndex = 5
        '
        'LbDesde
        '
        Me.LbDesde.AutoSize = True
        Me.LbDesde.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDesde.ForeColor = System.Drawing.Color.Blue
        Me.LbDesde.Location = New System.Drawing.Point(6, 5)
        Me.LbDesde.Name = "LbDesde"
        Me.LbDesde.Size = New System.Drawing.Size(48, 14)
        Me.LbDesde.TabIndex = 4
        Me.LbDesde.Text = "Desde :"
        '
        'MskCuotas
        '
        Me.MskCuotas.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskCuotas.Location = New System.Drawing.Point(238, 18)
        Me.MskCuotas.Name = "MskCuotas"
        Me.MskCuotas.Size = New System.Drawing.Size(59, 29)
        Me.MskCuotas.TabIndex = 3
        '
        'LbCuotas
        '
        Me.LbCuotas.AutoSize = True
        Me.LbCuotas.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCuotas.ForeColor = System.Drawing.Color.Blue
        Me.LbCuotas.Location = New System.Drawing.Point(238, 5)
        Me.LbCuotas.Name = "LbCuotas"
        Me.LbCuotas.Size = New System.Drawing.Size(52, 14)
        Me.LbCuotas.TabIndex = 2
        Me.LbCuotas.Text = "Cuotas :"
        '
        'MskEntrega
        '
        Me.MskEntrega.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskEntrega.Location = New System.Drawing.Point(140, 18)
        Me.MskEntrega.Name = "MskEntrega"
        Me.MskEntrega.Size = New System.Drawing.Size(94, 29)
        Me.MskEntrega.TabIndex = 1
        '
        'LbEntrega
        '
        Me.LbEntrega.AutoSize = True
        Me.LbEntrega.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbEntrega.ForeColor = System.Drawing.Color.Blue
        Me.LbEntrega.Location = New System.Drawing.Point(140, 5)
        Me.LbEntrega.Name = "LbEntrega"
        Me.LbEntrega.Size = New System.Drawing.Size(55, 14)
        Me.LbEntrega.TabIndex = 0
        Me.LbEntrega.Text = "Entrega :"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txtTotal)
        Me.GroupBox6.Location = New System.Drawing.Point(815, 542)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(110, 45)
        Me.GroupBox6.TabIndex = 8
        Me.GroupBox6.TabStop = False
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.Red
        Me.txtTotal.Location = New System.Drawing.Point(6, 11)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(100, 29)
        Me.txtTotal.TabIndex = 8
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CArticulos, Me.ToolStripSeparator1, Me.Ccli, Me.ToolStripSeparator2, Me.ToolStripButton1, Me.CmdCer, Me.CmbRepZ, Me.BtnArt, Me.ToolStripButton2, Me.CblNg, Me.CmbMenu, Me.TxtNCr, Me.ToolStripSeparator3, Me.TsNc})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(956, 43)
        Me.ToolStrip1.TabIndex = 9
        '
        'CArticulos
        '
        Me.CArticulos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CArticulos.Image = CType(resources.GetObject("CArticulos.Image"), System.Drawing.Image)
        Me.CArticulos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CArticulos.Name = "CArticulos"
        Me.CArticulos.Padding = New System.Windows.Forms.Padding(10)
        Me.CArticulos.Size = New System.Drawing.Size(40, 40)
        Me.CArticulos.ToolTipText = "A.B.M. de Articulos"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 43)
        '
        'Ccli
        '
        Me.Ccli.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Ccli.Image = CType(resources.GetObject("Ccli.Image"), System.Drawing.Image)
        Me.Ccli.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Ccli.Name = "Ccli"
        Me.Ccli.Padding = New System.Windows.Forms.Padding(10)
        Me.Ccli.Size = New System.Drawing.Size(40, 40)
        Me.Ccli.Text = "ToolStripButton2"
        Me.Ccli.ToolTipText = "A.B.M. de Clientes"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 43)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Padding = New System.Windows.Forms.Padding(10)
        Me.ToolStripButton1.Size = New System.Drawing.Size(40, 40)
        Me.ToolStripButton1.ToolTipText = "Buscar Presupuestos"
        '
        'CmdCer
        '
        Me.CmdCer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CmdCer.Image = Global.Super.My.Resources.Resources.cheque
        Me.CmdCer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CmdCer.Name = "CmdCer"
        Me.CmdCer.Padding = New System.Windows.Forms.Padding(10)
        Me.CmdCer.Size = New System.Drawing.Size(40, 40)
        Me.CmdCer.Text = "Crear Certificado"
        Me.CmdCer.ToolTipText = "Crear Certificado"
        '
        'CmbRepZ
        '
        Me.CmbRepZ.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CmbRepZ.Image = Global.Super.My.Resources.Resources.cash_register
        Me.CmbRepZ.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CmbRepZ.Name = "CmbRepZ"
        Me.CmbRepZ.Padding = New System.Windows.Forms.Padding(10)
        Me.CmbRepZ.Size = New System.Drawing.Size(40, 40)
        Me.CmbRepZ.Text = "Reporte Z"
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
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Padding = New System.Windows.Forms.Padding(10)
        Me.ToolStripButton2.Size = New System.Drawing.Size(40, 40)
        '
        'CblNg
        '
        Me.CblNg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CblNg.Image = CType(resources.GetObject("CblNg.Image"), System.Drawing.Image)
        Me.CblNg.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CblNg.Name = "CblNg"
        Me.CblNg.Padding = New System.Windows.Forms.Padding(10)
        Me.CblNg.Size = New System.Drawing.Size(40, 40)
        Me.CblNg.Text = "ToolStripButton3"
        '
        'CmbMenu
        '
        Me.CmbMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.CmbMenu.AutoCompleteCustomSource.AddRange(New String() {"Factura"})
        Me.CmbMenu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.CmbMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMenu.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CmbMenu.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbMenu.Name = "CmbMenu"
        Me.CmbMenu.Size = New System.Drawing.Size(160, 43)
        '
        'TxtNCr
        '
        Me.TxtNCr.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TxtNCr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNCr.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNCr.Name = "TxtNCr"
        Me.TxtNCr.Size = New System.Drawing.Size(50, 43)
        Me.TxtNCr.ToolTipText = "Numero de Factura Original"
        Me.TxtNCr.Visible = False
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 43)
        '
        'TsNc
        '
        Me.TsNc.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TsNc.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TsNc.Items.AddRange(New Object() {"Articulos", "Concepto"})
        Me.TsNc.Name = "TsNc"
        Me.TsNc.Size = New System.Drawing.Size(100, 43)
        Me.TsNc.Text = "Articulo"
        Me.TsNc.ToolTipText = "Elija tipo de Nota de Credito"
        Me.TsNc.Visible = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(842, 255)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(34, 23)
        Me.Button4.TabIndex = 21
        Me.Button4.Text = "Cert"
        Me.Button4.UseVisualStyleBackColor = True
        Me.Button4.Visible = False
        '
        'DtgTotAlic
        '
        Me.DtgTotAlic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgTotAlic.Location = New System.Drawing.Point(120, 470)
        Me.DtgTotAlic.Name = "DtgTotAlic"
        Me.DtgTotAlic.Size = New System.Drawing.Size(509, 95)
        Me.DtgTotAlic.TabIndex = 22
        Me.DtgTotAlic.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(821, 456)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(59, 41)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "Correo"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'TxtBarra
        '
        Me.TxtBarra.Location = New System.Drawing.Point(821, 341)
        Me.TxtBarra.Name = "TxtBarra"
        Me.TxtBarra.Size = New System.Drawing.Size(100, 20)
        Me.TxtBarra.TabIndex = 2
        Me.TxtBarra.Visible = False
        '
        'DtcFech
        '
        Me.DtcFech.Location = New System.Drawing.Point(836, 341)
        Me.DtcFech.Name = "DtcFech"
        Me.DtcFech.Size = New System.Drawing.Size(74, 20)
        Me.DtcFech.TabIndex = 37
        Me.DtcFech.Visible = False
        '
        'TxtReq
        '
        Me.TxtReq.Location = New System.Drawing.Point(821, 240)
        Me.TxtReq.Name = "TxtReq"
        Me.TxtReq.Size = New System.Drawing.Size(45, 20)
        Me.TxtReq.TabIndex = 38
        Me.TxtReq.Visible = False
        '
        'TxtP
        '
        Me.TxtP.Location = New System.Drawing.Point(833, 233)
        Me.TxtP.Name = "TxtP"
        Me.TxtP.Size = New System.Drawing.Size(35, 20)
        Me.TxtP.TabIndex = 39
        Me.TxtP.Visible = False
        '
        'TxtTot
        '
        Me.TxtTot.Location = New System.Drawing.Point(815, 380)
        Me.TxtTot.Name = "TxtTot"
        Me.TxtTot.Size = New System.Drawing.Size(68, 20)
        Me.TxtTot.TabIndex = 40
        Me.TxtTot.Visible = False
        '
        'DtgNc
        '
        Me.DtgNc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgNc.Location = New System.Drawing.Point(72, 514)
        Me.DtgNc.Name = "DtgNc"
        Me.DtgNc.Size = New System.Drawing.Size(465, 71)
        Me.DtgNc.TabIndex = 41
        Me.DtgNc.Visible = False
        '
        'DtgRem
        '
        Me.DtgRem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgRem.Location = New System.Drawing.Point(821, 470)
        Me.DtgRem.Name = "DtgRem"
        Me.DtgRem.Size = New System.Drawing.Size(102, 66)
        Me.DtgRem.TabIndex = 42
        Me.DtgRem.Visible = False
        '
        'TxtTo
        '
        Me.TxtTo.Location = New System.Drawing.Point(815, 443)
        Me.TxtTo.Name = "TxtTo"
        Me.TxtTo.Size = New System.Drawing.Size(106, 20)
        Me.TxtTo.TabIndex = 45
        Me.TxtTo.Visible = False
        '
        'LbCan
        '
        Me.LbCan.AutoSize = True
        Me.LbCan.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCan.ForeColor = System.Drawing.Color.Blue
        Me.LbCan.Location = New System.Drawing.Point(881, 177)
        Me.LbCan.Name = "LbCan"
        Me.LbCan.Size = New System.Drawing.Size(46, 14)
        Me.LbCan.TabIndex = 46
        Me.LbCan.Text = "Manual"
        Me.LbCan.Visible = False
        '
        'FrmFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(956, 639)
        Me.Controls.Add(Me.LbCan)
        Me.Controls.Add(Me.TxtTo)
        Me.Controls.Add(Me.DtgRem)
        Me.Controls.Add(Me.TxtTot)
        Me.Controls.Add(Me.TxtP)
        Me.Controls.Add(Me.TxtReq)
        Me.Controls.Add(Me.DtcFech)
        Me.Controls.Add(Me.TxtBarra)
        Me.Controls.Add(Me.Grupo)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Dtgart)
        Me.Controls.Add(Me.DtgTotAlic)
        Me.Controls.Add(Me.DtgNc)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmFactura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Grupo.ResumeLayout(False)
        Me.Grupo.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Dtgart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DtgPag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Group.ResumeLayout(False)
        Me.Group.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DtgCuotas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DtgTotAlic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtgNc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtgRem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LbCli As System.Windows.Forms.Label
    Friend WithEvents TxtCli As System.Windows.Forms.TextBox
    Friend WithEvents LbCuit As System.Windows.Forms.Label
    Friend WithEvents MskCuit As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LbDireccion As System.Windows.Forms.Label
    Friend WithEvents TxtDir As System.Windows.Forms.TextBox
    Friend WithEvents LbCiva As System.Windows.Forms.Label
    Friend WithEvents TxtcIva As System.Windows.Forms.TextBox
    Friend WithEvents LbCiudad As System.Windows.Forms.Label
    Friend WithEvents TxtCiudad As System.Windows.Forms.TextBox
    Friend WithEvents CmdBuscar As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents LbSaldo As System.Windows.Forms.Label
    Friend WithEvents TxtCpostal As System.Windows.Forms.MaskedTextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LbArticulo As System.Windows.Forms.Label
    Friend WithEvents TxtArticulo As System.Windows.Forms.TextBox
    Friend WithEvents Punit As System.Windows.Forms.Label
    Friend WithEvents MskPunit As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LbCantidad As System.Windows.Forms.Label
    Friend WithEvents MskCantidad As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LbPtotal As System.Windows.Forms.Label
    Friend WithEvents MskPtotal As System.Windows.Forms.MaskedTextBox
    Friend WithEvents CmdBart As System.Windows.Forms.Button
    Friend WithEvents Dtgart As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Lbtar As System.Windows.Forms.Label
    Friend WithEvents LbNum As System.Windows.Forms.Label
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents MskImp As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LbIm As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Cmdefectivo As System.Windows.Forms.Button
    Friend WithEvents CmdCta As System.Windows.Forms.Button
    Friend WithEvents CmdCheque As System.Windows.Forms.Button
    Friend WithEvents CmdTarjeta As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdFactura As System.Windows.Forms.Button
    Friend WithEvents TxtNCh As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Public WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents CArticulos As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Ccli As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CblNg As System.Windows.Forms.ToolStripButton
    Protected Friend WithEvents CmbMenu As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents Group As System.Windows.Forms.GroupBox
    Friend WithEvents TxtOb As System.Windows.Forms.TextBox
    Friend WithEvents TxtOb1 As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents DtgTotAlic As System.Windows.Forms.DataGridView
    ' Friend WithEvents text As System.Windows.Forms.TextBox
    Friend WithEvents CmdCer As System.Windows.Forms.ToolStripButton
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents CmbRepZ As System.Windows.Forms.ToolStripButton
    Friend WithEvents TxtNCr As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Grupo As System.Windows.Forms.GroupBox
    Friend WithEvents LbPv As System.Windows.Forms.Label
    Friend WithEvents TxtPv As System.Windows.Forms.TextBox
    Friend WithEvents TxtNumFac As System.Windows.Forms.TextBox
    Friend WithEvents LbNumero As System.Windows.Forms.Label
    Friend WithEvents LbFecha As System.Windows.Forms.Label
    Friend WithEvents DtcFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtPag As System.Windows.Forms.TextBox
    Friend WithEvents DtgPag As System.Windows.Forms.DataGridView
    Friend WithEvents BtnFin As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents DtgCuotas As System.Windows.Forms.DataGridView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents MskEntrega As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LbEntrega As System.Windows.Forms.Label
    Friend WithEvents LbCuotas As System.Windows.Forms.Label
    Friend WithEvents MskCuotas As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LbDesde As System.Windows.Forms.Label
    Friend WithEvents DtcDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents LbDesc As System.Windows.Forms.Label
    Friend WithEvents MskDescuento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LbDescgral As System.Windows.Forms.Label
    Friend WithEvents MskDescGral As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TxtProv As System.Windows.Forms.TextBox
    Friend WithEvents LbProvincia As System.Windows.Forms.Label
    Protected Friend WithEvents TsNc As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents Lb As System.Windows.Forms.Label
    Friend WithEvents DtcVenc As System.Windows.Forms.DateTimePicker
    Friend WithEvents LbVVen As System.Windows.Forms.Label
    Friend WithEvents TxtBarra As System.Windows.Forms.TextBox
    Friend WithEvents DtcFech As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtReq As System.Windows.Forms.TextBox
    Friend WithEvents TxtP As System.Windows.Forms.TextBox
    Friend WithEvents TxtTot As System.Windows.Forms.TextBox
    Friend WithEvents DtgNc As System.Windows.Forms.DataGridView
    Friend WithEvents BtnArt As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents DtgRem As System.Windows.Forms.DataGridView
    Friend WithEvents TxtTo As System.Windows.Forms.TextBox
    Friend WithEvents LbCan As System.Windows.Forms.Label
End Class
