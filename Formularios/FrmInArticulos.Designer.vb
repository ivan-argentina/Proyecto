<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInArticulos
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LbOb = New System.Windows.Forms.Label
        Me.TxtOb = New System.Windows.Forms.TextBox
        Me.CmbUnidad = New System.Windows.Forms.ComboBox
        Me.LbUnidad = New System.Windows.Forms.Label
        Me.MskPcosD = New System.Windows.Forms.MaskedTextBox
        Me.LbPcosD = New System.Windows.Forms.Label
        Me.LbMoneda = New System.Windows.Forms.Label
        Me.CmbPes = New System.Windows.Forms.ComboBox
        Me.TxtActividad = New System.Windows.Forms.TextBox
        Me.LbAct = New System.Windows.Forms.Label
        Me.MskIva = New System.Windows.Forms.MaskedTextBox
        Me.CmbIva = New System.Windows.Forms.ComboBox
        Me.CmdBuscar = New System.Windows.Forms.Button
        Me.LbUtil = New System.Windows.Forms.Label
        Me.MskUtil = New System.Windows.Forms.MaskedTextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.LbPneto = New System.Windows.Forms.Label
        Me.MskTotal = New System.Windows.Forms.MaskedTextBox
        Me.LbFinal = New System.Windows.Forms.Label
        Me.LbIva = New System.Windows.Forms.Label
        Me.MskPneto = New System.Windows.Forms.MaskedTextBox
        Me.LbAlic = New System.Windows.Forms.Label
        Me.MskPcos = New System.Windows.Forms.MaskedTextBox
        Me.LbPcosto = New System.Windows.Forms.Label
        Me.MskStMin = New System.Windows.Forms.MaskedTextBox
        Me.LbStkm = New System.Windows.Forms.Label
        Me.MskStock = New System.Windows.Forms.MaskedTextBox
        Me.LbStock = New System.Windows.Forms.Label
        Me.TxtMar = New System.Windows.Forms.TextBox
        Me.LbMarca = New System.Windows.Forms.Label
        Me.TxtCMar = New System.Windows.Forms.TextBox
        Me.LbCodM = New System.Windows.Forms.Label
        Me.TxtFam = New System.Windows.Forms.TextBox
        Me.LbFamilia = New System.Windows.Forms.Label
        Me.TxtCfam = New System.Windows.Forms.TextBox
        Me.LbCodF = New System.Windows.Forms.Label
        Me.TxtProv = New System.Windows.Forms.TextBox
        Me.LbProv = New System.Windows.Forms.Label
        Me.TxtCodPr = New System.Windows.Forms.TextBox
        Me.LbCodP = New System.Windows.Forms.Label
        Me.Txtarticulo = New System.Windows.Forms.TextBox
        Me.LbArt = New System.Windows.Forms.Label
        Me.TxtBarra = New System.Windows.Forms.TextBox
        Me.LbBarra = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.CmdEliminar = New System.Windows.Forms.Button
        Me.CmdModificar = New System.Windows.Forms.Button
        Me.EventLog1 = New System.Diagnostics.EventLog
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.TxtDolar = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnAct = New System.Windows.Forms.ToolStripButton
        Me.Barra = New System.Windows.Forms.ToolStripProgressBar
        Me.DtgArt = New System.Windows.Forms.DataGridView
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DtgArt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LbOb)
        Me.GroupBox1.Controls.Add(Me.TxtOb)
        Me.GroupBox1.Controls.Add(Me.CmbUnidad)
        Me.GroupBox1.Controls.Add(Me.LbUnidad)
        Me.GroupBox1.Controls.Add(Me.MskPcosD)
        Me.GroupBox1.Controls.Add(Me.LbPcosD)
        Me.GroupBox1.Controls.Add(Me.LbMoneda)
        Me.GroupBox1.Controls.Add(Me.CmbPes)
        Me.GroupBox1.Controls.Add(Me.TxtActividad)
        Me.GroupBox1.Controls.Add(Me.LbAct)
        Me.GroupBox1.Controls.Add(Me.MskIva)
        Me.GroupBox1.Controls.Add(Me.CmbIva)
        Me.GroupBox1.Controls.Add(Me.CmdBuscar)
        Me.GroupBox1.Controls.Add(Me.LbUtil)
        Me.GroupBox1.Controls.Add(Me.MskUtil)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.LbPneto)
        Me.GroupBox1.Controls.Add(Me.MskTotal)
        Me.GroupBox1.Controls.Add(Me.LbFinal)
        Me.GroupBox1.Controls.Add(Me.LbIva)
        Me.GroupBox1.Controls.Add(Me.MskPneto)
        Me.GroupBox1.Controls.Add(Me.LbAlic)
        Me.GroupBox1.Controls.Add(Me.MskPcos)
        Me.GroupBox1.Controls.Add(Me.LbPcosto)
        Me.GroupBox1.Controls.Add(Me.MskStMin)
        Me.GroupBox1.Controls.Add(Me.LbStkm)
        Me.GroupBox1.Controls.Add(Me.MskStock)
        Me.GroupBox1.Controls.Add(Me.LbStock)
        Me.GroupBox1.Controls.Add(Me.TxtMar)
        Me.GroupBox1.Controls.Add(Me.LbMarca)
        Me.GroupBox1.Controls.Add(Me.TxtCMar)
        Me.GroupBox1.Controls.Add(Me.LbCodM)
        Me.GroupBox1.Controls.Add(Me.TxtFam)
        Me.GroupBox1.Controls.Add(Me.LbFamilia)
        Me.GroupBox1.Controls.Add(Me.TxtCfam)
        Me.GroupBox1.Controls.Add(Me.LbCodF)
        Me.GroupBox1.Controls.Add(Me.TxtProv)
        Me.GroupBox1.Controls.Add(Me.LbProv)
        Me.GroupBox1.Controls.Add(Me.TxtCodPr)
        Me.GroupBox1.Controls.Add(Me.LbCodP)
        Me.GroupBox1.Controls.Add(Me.Txtarticulo)
        Me.GroupBox1.Controls.Add(Me.LbArt)
        Me.GroupBox1.Controls.Add(Me.TxtBarra)
        Me.GroupBox1.Controls.Add(Me.LbBarra)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(762, 209)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'LbOb
        '
        Me.LbOb.AutoSize = True
        Me.LbOb.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbOb.ForeColor = System.Drawing.Color.Blue
        Me.LbOb.Location = New System.Drawing.Point(238, 109)
        Me.LbOb.Name = "LbOb"
        Me.LbOb.Size = New System.Drawing.Size(93, 14)
        Me.LbOb.TabIndex = 49
        Me.LbOb.Text = "Observaciones:"
        '
        'TxtOb
        '
        Me.TxtOb.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOb.Location = New System.Drawing.Point(233, 123)
        Me.TxtOb.Name = "TxtOb"
        Me.TxtOb.Size = New System.Drawing.Size(160, 26)
        Me.TxtOb.TabIndex = 48
        '
        'CmbUnidad
        '
        Me.CmbUnidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmbUnidad.Enabled = False
        Me.CmbUnidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbUnidad.FormattingEnabled = True
        Me.CmbUnidad.Location = New System.Drawing.Point(664, 123)
        Me.CmbUnidad.Name = "CmbUnidad"
        Me.CmbUnidad.Size = New System.Drawing.Size(89, 28)
        Me.CmbUnidad.TabIndex = 47
        '
        'LbUnidad
        '
        Me.LbUnidad.AutoSize = True
        Me.LbUnidad.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbUnidad.ForeColor = System.Drawing.Color.Blue
        Me.LbUnidad.Location = New System.Drawing.Point(664, 106)
        Me.LbUnidad.Name = "LbUnidad"
        Me.LbUnidad.Size = New System.Drawing.Size(50, 14)
        Me.LbUnidad.TabIndex = 46
        Me.LbUnidad.Text = "Unidad :"
        '
        'MskPcosD
        '
        Me.MskPcosD.Enabled = False
        Me.MskPcosD.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskPcosD.Location = New System.Drawing.Point(192, 173)
        Me.MskPcosD.Name = "MskPcosD"
        Me.MskPcosD.Size = New System.Drawing.Size(74, 26)
        Me.MskPcosD.TabIndex = 45
        '
        'LbPcosD
        '
        Me.LbPcosD.AutoSize = True
        Me.LbPcosD.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPcosD.ForeColor = System.Drawing.Color.Blue
        Me.LbPcosD.Location = New System.Drawing.Point(192, 159)
        Me.LbPcosD.Name = "LbPcosD"
        Me.LbPcosD.Size = New System.Drawing.Size(66, 14)
        Me.LbPcosD.TabIndex = 44
        Me.LbPcosD.Text = "Costo U$S:"
        '
        'LbMoneda
        '
        Me.LbMoneda.AutoSize = True
        Me.LbMoneda.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbMoneda.ForeColor = System.Drawing.Color.Blue
        Me.LbMoneda.Location = New System.Drawing.Point(113, 159)
        Me.LbMoneda.Name = "LbMoneda"
        Me.LbMoneda.Size = New System.Drawing.Size(57, 14)
        Me.LbMoneda.TabIndex = 43
        Me.LbMoneda.Text = "Moneda :"
        '
        'CmbPes
        '
        Me.CmbPes.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmbPes.DropDownWidth = 75
        Me.CmbPes.Enabled = False
        Me.CmbPes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmbPes.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbPes.FormattingEnabled = True
        Me.CmbPes.Location = New System.Drawing.Point(113, 173)
        Me.CmbPes.Name = "CmbPes"
        Me.CmbPes.Size = New System.Drawing.Size(75, 26)
        Me.CmbPes.TabIndex = 42
        '
        'TxtActividad
        '
        Me.TxtActividad.Enabled = False
        Me.TxtActividad.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtActividad.Location = New System.Drawing.Point(395, 123)
        Me.TxtActividad.Name = "TxtActividad"
        Me.TxtActividad.Size = New System.Drawing.Size(267, 26)
        Me.TxtActividad.TabIndex = 41
        '
        'LbAct
        '
        Me.LbAct.AutoSize = True
        Me.LbAct.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAct.ForeColor = System.Drawing.Color.Blue
        Me.LbAct.Location = New System.Drawing.Point(395, 109)
        Me.LbAct.Name = "LbAct"
        Me.LbAct.Size = New System.Drawing.Size(63, 14)
        Me.LbAct.TabIndex = 40
        Me.LbAct.Text = "Actividad :"
        '
        'MskIva
        '
        Me.MskIva.Enabled = False
        Me.MskIva.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskIva.Location = New System.Drawing.Point(587, 173)
        Me.MskIva.Name = "MskIva"
        Me.MskIva.Size = New System.Drawing.Size(75, 26)
        Me.MskIva.TabIndex = 39
        '
        'CmbIva
        '
        Me.CmbIva.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmbIva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbIva.Enabled = False
        Me.CmbIva.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmbIva.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbIva.FormattingEnabled = True
        Me.CmbIva.Location = New System.Drawing.Point(408, 173)
        Me.CmbIva.Name = "CmbIva"
        Me.CmbIva.Size = New System.Drawing.Size(94, 26)
        Me.CmbIva.TabIndex = 38
        '
        'CmdBuscar
        '
        Me.CmdBuscar.Image = Global.Super.My.Resources.Resources.Buscar
        Me.CmdBuscar.Location = New System.Drawing.Point(165, 11)
        Me.CmdBuscar.Name = "CmdBuscar"
        Me.CmdBuscar.Size = New System.Drawing.Size(65, 45)
        Me.CmdBuscar.TabIndex = 37
        Me.CmdBuscar.UseVisualStyleBackColor = True
        '
        'LbUtil
        '
        Me.LbUtil.AutoSize = True
        Me.LbUtil.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbUtil.ForeColor = System.Drawing.Color.Blue
        Me.LbUtil.Location = New System.Drawing.Point(348, 159)
        Me.LbUtil.Name = "LbUtil"
        Me.LbUtil.Size = New System.Drawing.Size(42, 14)
        Me.LbUtil.TabIndex = 36
        Me.LbUtil.Text = "Util % :"
        '
        'MskUtil
        '
        Me.MskUtil.Enabled = False
        Me.MskUtil.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskUtil.Location = New System.Drawing.Point(348, 173)
        Me.MskUtil.Name = "MskUtil"
        Me.MskUtil.Size = New System.Drawing.Size(55, 26)
        Me.MskUtil.TabIndex = 35
        Me.MskUtil.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(270, 26)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 41)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "Trae dato"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'LbPneto
        '
        Me.LbPneto.AutoSize = True
        Me.LbPneto.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPneto.ForeColor = System.Drawing.Color.Blue
        Me.LbPneto.Location = New System.Drawing.Point(508, 159)
        Me.LbPneto.Name = "LbPneto"
        Me.LbPneto.Size = New System.Drawing.Size(47, 14)
        Me.LbPneto.TabIndex = 26
        Me.LbPneto.Text = "P.neto :"
        '
        'MskTotal
        '
        Me.MskTotal.Enabled = False
        Me.MskTotal.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskTotal.Location = New System.Drawing.Point(666, 173)
        Me.MskTotal.Name = "MskTotal"
        Me.MskTotal.Size = New System.Drawing.Size(90, 26)
        Me.MskTotal.TabIndex = 31
        Me.MskTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.MskTotal.ValidatingType = GetType(Date)
        '
        'LbFinal
        '
        Me.LbFinal.AutoSize = True
        Me.LbFinal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFinal.ForeColor = System.Drawing.Color.Blue
        Me.LbFinal.Location = New System.Drawing.Point(666, 160)
        Me.LbFinal.Name = "LbFinal"
        Me.LbFinal.Size = New System.Drawing.Size(47, 14)
        Me.LbFinal.TabIndex = 30
        Me.LbFinal.Text = "P.Final :"
        '
        'LbIva
        '
        Me.LbIva.AutoSize = True
        Me.LbIva.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbIva.ForeColor = System.Drawing.Color.Blue
        Me.LbIva.Location = New System.Drawing.Point(587, 160)
        Me.LbIva.Name = "LbIva"
        Me.LbIva.Size = New System.Drawing.Size(28, 14)
        Me.LbIva.TabIndex = 28
        Me.LbIva.Text = "Iva :"
        '
        'MskPneto
        '
        Me.MskPneto.Enabled = False
        Me.MskPneto.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskPneto.Location = New System.Drawing.Point(508, 173)
        Me.MskPneto.Name = "MskPneto"
        Me.MskPneto.Size = New System.Drawing.Size(74, 26)
        Me.MskPneto.TabIndex = 27
        Me.MskPneto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.MskPneto.ValidatingType = GetType(Date)
        '
        'LbAlic
        '
        Me.LbAlic.AutoSize = True
        Me.LbAlic.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAlic.ForeColor = System.Drawing.Color.Blue
        Me.LbAlic.Location = New System.Drawing.Point(408, 160)
        Me.LbAlic.Name = "LbAlic"
        Me.LbAlic.Size = New System.Drawing.Size(57, 14)
        Me.LbAlic.TabIndex = 24
        Me.LbAlic.Text = "Alicuota :"
        '
        'MskPcos
        '
        Me.MskPcos.Enabled = False
        Me.MskPcos.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskPcos.Location = New System.Drawing.Point(270, 173)
        Me.MskPcos.Name = "MskPcos"
        Me.MskPcos.Size = New System.Drawing.Size(74, 26)
        Me.MskPcos.TabIndex = 23
        Me.MskPcos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LbPcosto
        '
        Me.LbPcosto.AutoSize = True
        Me.LbPcosto.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPcosto.ForeColor = System.Drawing.Color.Blue
        Me.LbPcosto.Location = New System.Drawing.Point(270, 160)
        Me.LbPcosto.Name = "LbPcosto"
        Me.LbPcosto.Size = New System.Drawing.Size(64, 14)
        Me.LbPcosto.TabIndex = 22
        Me.LbPcosto.Text = "P.Costo $ :"
        '
        'MskStMin
        '
        Me.MskStMin.Enabled = False
        Me.MskStMin.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskStMin.Location = New System.Drawing.Point(59, 173)
        Me.MskStMin.Name = "MskStMin"
        Me.MskStMin.Size = New System.Drawing.Size(50, 26)
        Me.MskStMin.TabIndex = 21
        Me.MskStMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LbStkm
        '
        Me.LbStkm.AutoSize = True
        Me.LbStkm.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbStkm.ForeColor = System.Drawing.Color.Blue
        Me.LbStkm.Location = New System.Drawing.Point(59, 160)
        Me.LbStkm.Name = "LbStkm"
        Me.LbStkm.Size = New System.Drawing.Size(33, 14)
        Me.LbStkm.TabIndex = 20
        Me.LbStkm.Text = "Min :"
        '
        'MskStock
        '
        Me.MskStock.Enabled = False
        Me.MskStock.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskStock.Location = New System.Drawing.Point(6, 173)
        Me.MskStock.Name = "MskStock"
        Me.MskStock.Size = New System.Drawing.Size(50, 26)
        Me.MskStock.TabIndex = 19
        Me.MskStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LbStock
        '
        Me.LbStock.AutoSize = True
        Me.LbStock.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbStock.ForeColor = System.Drawing.Color.Blue
        Me.LbStock.Location = New System.Drawing.Point(6, 160)
        Me.LbStock.Name = "LbStock"
        Me.LbStock.Size = New System.Drawing.Size(44, 14)
        Me.LbStock.TabIndex = 18
        Me.LbStock.Text = "Stock :"
        '
        'TxtMar
        '
        Me.TxtMar.Enabled = False
        Me.TxtMar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMar.Location = New System.Drawing.Point(425, 73)
        Me.TxtMar.MaxLength = 50
        Me.TxtMar.Name = "TxtMar"
        Me.TxtMar.Size = New System.Drawing.Size(331, 26)
        Me.TxtMar.TabIndex = 13
        '
        'LbMarca
        '
        Me.LbMarca.AutoSize = True
        Me.LbMarca.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbMarca.ForeColor = System.Drawing.Color.Blue
        Me.LbMarca.Location = New System.Drawing.Point(425, 59)
        Me.LbMarca.Name = "LbMarca"
        Me.LbMarca.Size = New System.Drawing.Size(46, 14)
        Me.LbMarca.TabIndex = 15
        Me.LbMarca.Text = "Marca :"
        '
        'TxtCMar
        '
        Me.TxtCMar.Enabled = False
        Me.TxtCMar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCMar.Location = New System.Drawing.Point(366, 73)
        Me.TxtCMar.MaxLength = 50
        Me.TxtCMar.Name = "TxtCMar"
        Me.TxtCMar.Size = New System.Drawing.Size(56, 26)
        Me.TxtCMar.TabIndex = 12
        '
        'LbCodM
        '
        Me.LbCodM.AutoSize = True
        Me.LbCodM.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCodM.ForeColor = System.Drawing.Color.Blue
        Me.LbCodM.Location = New System.Drawing.Point(366, 59)
        Me.LbCodM.Name = "LbCodM"
        Me.LbCodM.Size = New System.Drawing.Size(52, 14)
        Me.LbCodM.TabIndex = 14
        Me.LbCodM.Text = "Codigo :"
        '
        'TxtFam
        '
        Me.TxtFam.Enabled = False
        Me.TxtFam.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFam.Location = New System.Drawing.Point(425, 26)
        Me.TxtFam.MaxLength = 50
        Me.TxtFam.Name = "TxtFam"
        Me.TxtFam.Size = New System.Drawing.Size(331, 26)
        Me.TxtFam.TabIndex = 9
        '
        'LbFamilia
        '
        Me.LbFamilia.AutoSize = True
        Me.LbFamilia.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFamilia.ForeColor = System.Drawing.Color.Blue
        Me.LbFamilia.Location = New System.Drawing.Point(425, 12)
        Me.LbFamilia.Name = "LbFamilia"
        Me.LbFamilia.Size = New System.Drawing.Size(51, 14)
        Me.LbFamilia.TabIndex = 11
        Me.LbFamilia.Text = "Familia :"
        '
        'TxtCfam
        '
        Me.TxtCfam.Enabled = False
        Me.TxtCfam.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCfam.Location = New System.Drawing.Point(366, 26)
        Me.TxtCfam.MaxLength = 50
        Me.TxtCfam.Name = "TxtCfam"
        Me.TxtCfam.Size = New System.Drawing.Size(56, 26)
        Me.TxtCfam.TabIndex = 8
        '
        'LbCodF
        '
        Me.LbCodF.AutoSize = True
        Me.LbCodF.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCodF.ForeColor = System.Drawing.Color.Blue
        Me.LbCodF.Location = New System.Drawing.Point(366, 12)
        Me.LbCodF.Name = "LbCodF"
        Me.LbCodF.Size = New System.Drawing.Size(52, 14)
        Me.LbCodF.TabIndex = 10
        Me.LbCodF.Text = "Codigo :"
        '
        'TxtProv
        '
        Me.TxtProv.Enabled = False
        Me.TxtProv.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtProv.Location = New System.Drawing.Point(65, 123)
        Me.TxtProv.MaxLength = 50
        Me.TxtProv.Name = "TxtProv"
        Me.TxtProv.Size = New System.Drawing.Size(165, 26)
        Me.TxtProv.TabIndex = 3
        '
        'LbProv
        '
        Me.LbProv.AutoSize = True
        Me.LbProv.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbProv.ForeColor = System.Drawing.Color.Blue
        Me.LbProv.Location = New System.Drawing.Point(65, 109)
        Me.LbProv.Name = "LbProv"
        Me.LbProv.Size = New System.Drawing.Size(71, 14)
        Me.LbProv.TabIndex = 7
        Me.LbProv.Text = "Proveedor :"
        '
        'TxtCodPr
        '
        Me.TxtCodPr.Enabled = False
        Me.TxtCodPr.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodPr.Location = New System.Drawing.Point(6, 123)
        Me.TxtCodPr.MaxLength = 50
        Me.TxtCodPr.Name = "TxtCodPr"
        Me.TxtCodPr.Size = New System.Drawing.Size(56, 26)
        Me.TxtCodPr.TabIndex = 2
        '
        'LbCodP
        '
        Me.LbCodP.AutoSize = True
        Me.LbCodP.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCodP.ForeColor = System.Drawing.Color.Blue
        Me.LbCodP.Location = New System.Drawing.Point(6, 109)
        Me.LbCodP.Name = "LbCodP"
        Me.LbCodP.Size = New System.Drawing.Size(52, 14)
        Me.LbCodP.TabIndex = 5
        Me.LbCodP.Text = "Codigo :"
        '
        'Txtarticulo
        '
        Me.Txtarticulo.Enabled = False
        Me.Txtarticulo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtarticulo.Location = New System.Drawing.Point(6, 73)
        Me.Txtarticulo.MaxLength = 30
        Me.Txtarticulo.Name = "Txtarticulo"
        Me.Txtarticulo.Size = New System.Drawing.Size(350, 26)
        Me.Txtarticulo.TabIndex = 1
        '
        'LbArt
        '
        Me.LbArt.AutoSize = True
        Me.LbArt.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbArt.ForeColor = System.Drawing.Color.Blue
        Me.LbArt.Location = New System.Drawing.Point(6, 60)
        Me.LbArt.Name = "LbArt"
        Me.LbArt.Size = New System.Drawing.Size(56, 14)
        Me.LbArt.TabIndex = 3
        Me.LbArt.Text = "Articulo :"
        '
        'TxtBarra
        '
        Me.TxtBarra.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBarra.Location = New System.Drawing.Point(6, 26)
        Me.TxtBarra.Name = "TxtBarra"
        Me.TxtBarra.Size = New System.Drawing.Size(150, 26)
        Me.TxtBarra.TabIndex = 0
        '
        'LbBarra
        '
        Me.LbBarra.AutoSize = True
        Me.LbBarra.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbBarra.ForeColor = System.Drawing.Color.Blue
        Me.LbBarra.Location = New System.Drawing.Point(6, 12)
        Me.LbBarra.Name = "LbBarra"
        Me.LbBarra.Size = New System.Drawing.Size(42, 14)
        Me.LbBarra.TabIndex = 1
        Me.LbBarra.Text = "Barra :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CmdEliminar)
        Me.GroupBox2.Controls.Add(Me.CmdModificar)
        Me.GroupBox2.Location = New System.Drawing.Point(619, 247)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(144, 58)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'CmdEliminar
        '
        Me.CmdEliminar.Enabled = False
        Me.CmdEliminar.Image = Global.Super.My.Resources.Resources.Eliminar
        Me.CmdEliminar.Location = New System.Drawing.Point(76, 8)
        Me.CmdEliminar.Name = "CmdEliminar"
        Me.CmdEliminar.Size = New System.Drawing.Size(65, 45)
        Me.CmdEliminar.TabIndex = 1
        Me.CmdEliminar.UseVisualStyleBackColor = True
        '
        'CmdModificar
        '
        Me.CmdModificar.AccessibleDescription = "Prueba"
        Me.CmdModificar.AccessibleName = "p"
        Me.CmdModificar.AllowDrop = True
        Me.CmdModificar.Enabled = False
        Me.CmdModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdModificar.Image = Global.Super.My.Resources.Resources.Modificar1
        Me.CmdModificar.Location = New System.Drawing.Point(6, 8)
        Me.CmdModificar.Name = "CmdModificar"
        Me.CmdModificar.Size = New System.Drawing.Size(65, 45)
        Me.CmdModificar.TabIndex = 0
        Me.CmdModificar.UseVisualStyleBackColor = True
        '
        'EventLog1
        '
        Me.EventLog1.SynchronizingObject = Me
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TxtDolar, Me.ToolStripSeparator1, Me.BtnAct, Me.Barra})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(768, 43)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'TxtDolar
        '
        Me.TxtDolar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDolar.Name = "TxtDolar"
        Me.TxtDolar.Size = New System.Drawing.Size(100, 43)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 43)
        '
        'BtnAct
        '
        Me.BtnAct.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnAct.Enabled = False
        Me.BtnAct.Image = Global.Super.My.Resources.Resources.efectivo
        Me.BtnAct.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnAct.Name = "BtnAct"
        Me.BtnAct.Padding = New System.Windows.Forms.Padding(10)
        Me.BtnAct.Size = New System.Drawing.Size(40, 40)
        Me.BtnAct.ToolTipText = "Cambiar Valor del Dolar"
        '
        'Barra
        '
        Me.Barra.Name = "Barra"
        Me.Barra.Size = New System.Drawing.Size(200, 40)
        '
        'DtgArt
        '
        Me.DtgArt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgArt.Location = New System.Drawing.Point(10, 253)
        Me.DtgArt.Name = "DtgArt"
        Me.DtgArt.Size = New System.Drawing.Size(437, 27)
        Me.DtgArt.TabIndex = 4
        Me.DtgArt.Visible = False
        '
        'FrmInArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(768, 314)
        Me.Controls.Add(Me.DtgArt)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmInArticulos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "A.B.M. Articulos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DtgArt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LbBarra As System.Windows.Forms.Label
    Friend WithEvents TxtBarra As System.Windows.Forms.TextBox
    Friend WithEvents Txtarticulo As System.Windows.Forms.TextBox
    Friend WithEvents LbArt As System.Windows.Forms.Label
    Friend WithEvents TxtCodPr As System.Windows.Forms.TextBox
    Friend WithEvents LbCodP As System.Windows.Forms.Label
    Friend WithEvents TxtProv As System.Windows.Forms.TextBox
    Friend WithEvents LbProv As System.Windows.Forms.Label
    Friend WithEvents TxtFam As System.Windows.Forms.TextBox
    Friend WithEvents LbFamilia As System.Windows.Forms.Label
    Friend WithEvents TxtCfam As System.Windows.Forms.TextBox
    Friend WithEvents LbCodF As System.Windows.Forms.Label
    Friend WithEvents TxtMar As System.Windows.Forms.TextBox
    Friend WithEvents LbMarca As System.Windows.Forms.Label
    Friend WithEvents TxtCMar As System.Windows.Forms.TextBox
    Friend WithEvents LbCodM As System.Windows.Forms.Label
    Friend WithEvents LbStock As System.Windows.Forms.Label
    Friend WithEvents MskStock As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MskStMin As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LbStkm As System.Windows.Forms.Label
    Friend WithEvents MskPcos As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LbPcosto As System.Windows.Forms.Label
    Friend WithEvents LbAlic As System.Windows.Forms.Label
    Friend WithEvents MskPneto As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LbPneto As System.Windows.Forms.Label
    Friend WithEvents LbIva As System.Windows.Forms.Label
    Friend WithEvents MskTotal As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LbFinal As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents LbUtil As System.Windows.Forms.Label
    Friend WithEvents MskUtil As System.Windows.Forms.MaskedTextBox
    Friend WithEvents CmdBuscar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdModificar As System.Windows.Forms.Button
    Friend WithEvents CmdEliminar As System.Windows.Forms.Button
    Friend WithEvents EventLog1 As System.Diagnostics.EventLog
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents CmbIva As System.Windows.Forms.ComboBox
    Friend WithEvents MskIva As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LbAct As System.Windows.Forms.Label
    Friend WithEvents TxtActividad As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents TxtDolar As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnAct As System.Windows.Forms.ToolStripButton
    Friend WithEvents CmbPes As System.Windows.Forms.ComboBox
    Friend WithEvents LbMoneda As System.Windows.Forms.Label
    Friend WithEvents MskPcosD As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LbPcosD As System.Windows.Forms.Label
    Friend WithEvents Barra As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents DtgArt As System.Windows.Forms.DataGridView
    Friend WithEvents LbUnidad As System.Windows.Forms.Label
    Friend WithEvents CmbUnidad As System.Windows.Forms.ComboBox
    Friend WithEvents TxtOb As System.Windows.Forms.TextBox
    Friend WithEvents LbOb As System.Windows.Forms.Label
End Class
