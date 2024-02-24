<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPago
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPago))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LbSaldo = New System.Windows.Forms.Label
        Me.TxtCiu = New System.Windows.Forms.TextBox
        Me.LbCiu = New System.Windows.Forms.Label
        Me.txtDirec = New System.Windows.Forms.TextBox
        Me.LbDirec = New System.Windows.Forms.Label
        Me.TxtCuit = New System.Windows.Forms.TextBox
        Me.LbCuit = New System.Windows.Forms.Label
        Me.TxtCli = New System.Windows.Forms.TextBox
        Me.LbCl = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CmdEfec = New System.Windows.Forms.Button
        Me.CmdCh = New System.Windows.Forms.Button
        Me.CmdPagar = New System.Windows.Forms.Button
        Me.CmdTarjeta = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.LbDvenc = New System.Windows.Forms.Label
        Me.DtcFecha = New System.Windows.Forms.DateTimePicker
        Me.MskEnt = New System.Windows.Forms.MaskedTextBox
        Me.LbNumero = New System.Windows.Forms.Label
        Me.LbComp = New System.Windows.Forms.Label
        Me.TxtNum = New System.Windows.Forms.TextBox
        Me.TxtComp = New System.Windows.Forms.TextBox
        Me.LbEntrega = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.MskEntrega_old = New System.Windows.Forms.MaskedTextBox
        Me.DtgPag = New System.Windows.Forms.DataGridView
        Me.DtgRec = New System.Windows.Forms.DataGridView
        Me.DtgCom = New System.Windows.Forms.DataGridView
        Me.DtgDetalFac = New System.Windows.Forms.DataGridView
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.LbTotal = New System.Windows.Forms.Label
        Me.MskTotal = New System.Windows.Forms.MaskedTextBox
        Me.TxtSaldo = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DtgPag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtgRec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtgCom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtgDetalFac, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtSaldo)
        Me.GroupBox1.Controls.Add(Me.LbSaldo)
        Me.GroupBox1.Controls.Add(Me.TxtCiu)
        Me.GroupBox1.Controls.Add(Me.LbCiu)
        Me.GroupBox1.Controls.Add(Me.txtDirec)
        Me.GroupBox1.Controls.Add(Me.LbDirec)
        Me.GroupBox1.Controls.Add(Me.TxtCuit)
        Me.GroupBox1.Controls.Add(Me.LbCuit)
        Me.GroupBox1.Controls.Add(Me.TxtCli)
        Me.GroupBox1.Controls.Add(Me.LbCl)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(550, 109)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'LbSaldo
        '
        Me.LbSaldo.AutoSize = True
        Me.LbSaldo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSaldo.ForeColor = System.Drawing.Color.Blue
        Me.LbSaldo.Location = New System.Drawing.Point(434, 61)
        Me.LbSaldo.Name = "LbSaldo"
        Me.LbSaldo.Size = New System.Drawing.Size(43, 14)
        Me.LbSaldo.TabIndex = 12
        Me.LbSaldo.Text = "Saldo :"
        '
        'TxtCiu
        '
        Me.TxtCiu.Enabled = False
        Me.TxtCiu.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCiu.Location = New System.Drawing.Point(6, 75)
        Me.TxtCiu.Name = "TxtCiu"
        Me.TxtCiu.Size = New System.Drawing.Size(270, 26)
        Me.TxtCiu.TabIndex = 7
        '
        'LbCiu
        '
        Me.LbCiu.AutoSize = True
        Me.LbCiu.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCiu.ForeColor = System.Drawing.Color.Blue
        Me.LbCiu.Location = New System.Drawing.Point(6, 60)
        Me.LbCiu.Name = "LbCiu"
        Me.LbCiu.Size = New System.Drawing.Size(51, 14)
        Me.LbCiu.TabIndex = 6
        Me.LbCiu.Text = "Ciudad :"
        '
        'txtDirec
        '
        Me.txtDirec.Enabled = False
        Me.txtDirec.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDirec.Location = New System.Drawing.Point(309, 25)
        Me.txtDirec.Name = "txtDirec"
        Me.txtDirec.Size = New System.Drawing.Size(235, 26)
        Me.txtDirec.TabIndex = 5
        '
        'LbDirec
        '
        Me.LbDirec.AutoSize = True
        Me.LbDirec.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDirec.ForeColor = System.Drawing.Color.Blue
        Me.LbDirec.Location = New System.Drawing.Point(306, 10)
        Me.LbDirec.Name = "LbDirec"
        Me.LbDirec.Size = New System.Drawing.Size(64, 14)
        Me.LbDirec.TabIndex = 4
        Me.LbDirec.Text = "Direccion :"
        '
        'TxtCuit
        '
        Me.TxtCuit.Enabled = False
        Me.TxtCuit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCuit.Location = New System.Drawing.Point(280, 75)
        Me.TxtCuit.Name = "TxtCuit"
        Me.TxtCuit.Size = New System.Drawing.Size(149, 26)
        Me.TxtCuit.TabIndex = 3
        '
        'LbCuit
        '
        Me.LbCuit.AutoSize = True
        Me.LbCuit.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCuit.ForeColor = System.Drawing.Color.Blue
        Me.LbCuit.Location = New System.Drawing.Point(280, 61)
        Me.LbCuit.Name = "LbCuit"
        Me.LbCuit.Size = New System.Drawing.Size(35, 14)
        Me.LbCuit.TabIndex = 2
        Me.LbCuit.Text = "Cuit :"
        '
        'TxtCli
        '
        Me.TxtCli.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCli.Location = New System.Drawing.Point(6, 25)
        Me.TxtCli.Name = "TxtCli"
        Me.TxtCli.Size = New System.Drawing.Size(300, 26)
        Me.TxtCli.TabIndex = 1
        '
        'LbCl
        '
        Me.LbCl.AutoSize = True
        Me.LbCl.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCl.ForeColor = System.Drawing.Color.Blue
        Me.LbCl.Location = New System.Drawing.Point(6, 10)
        Me.LbCl.Name = "LbCl"
        Me.LbCl.Size = New System.Drawing.Size(52, 14)
        Me.LbCl.TabIndex = 0
        Me.LbCl.Text = "Cliente :"
        '
        'CmdEfec
        '
        Me.CmdEfec.Enabled = False
        Me.CmdEfec.Image = Global.Super.My.Resources.Resources.efectivo
        Me.CmdEfec.Location = New System.Drawing.Point(6, 10)
        Me.CmdEfec.Name = "CmdEfec"
        Me.CmdEfec.Size = New System.Drawing.Size(70, 38)
        Me.CmdEfec.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.CmdEfec, "Pago Con efectivo")
        Me.CmdEfec.UseVisualStyleBackColor = True
        '
        'CmdCh
        '
        Me.CmdCh.Enabled = False
        Me.CmdCh.Image = Global.Super.My.Resources.Resources.cheque
        Me.CmdCh.Location = New System.Drawing.Point(6, 50)
        Me.CmdCh.Name = "CmdCh"
        Me.CmdCh.Size = New System.Drawing.Size(70, 38)
        Me.CmdCh.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.CmdCh, "Pago con Cheque")
        Me.CmdCh.UseVisualStyleBackColor = True
        Me.CmdCh.Visible = False
        '
        'CmdPagar
        '
        Me.CmdPagar.Enabled = False
        Me.CmdPagar.Image = Global.Super.My.Resources.Resources.cash_register
        Me.CmdPagar.Location = New System.Drawing.Point(6, 10)
        Me.CmdPagar.Name = "CmdPagar"
        Me.CmdPagar.Size = New System.Drawing.Size(65, 45)
        Me.CmdPagar.TabIndex = 17
        Me.ToolTip1.SetToolTip(Me.CmdPagar, "Grabar Pago")
        Me.CmdPagar.UseVisualStyleBackColor = True
        '
        'CmdTarjeta
        '
        Me.CmdTarjeta.Enabled = False
        Me.CmdTarjeta.Image = CType(resources.GetObject("CmdTarjeta.Image"), System.Drawing.Image)
        Me.CmdTarjeta.Location = New System.Drawing.Point(6, 50)
        Me.CmdTarjeta.Name = "CmdTarjeta"
        Me.CmdTarjeta.Size = New System.Drawing.Size(70, 38)
        Me.CmdTarjeta.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.CmdTarjeta, "Pago con Tarjeta")
        Me.CmdTarjeta.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LbDvenc)
        Me.GroupBox3.Controls.Add(Me.DtcFecha)
        Me.GroupBox3.Controls.Add(Me.MskEnt)
        Me.GroupBox3.Controls.Add(Me.LbNumero)
        Me.GroupBox3.Controls.Add(Me.LbComp)
        Me.GroupBox3.Controls.Add(Me.TxtNum)
        Me.GroupBox3.Controls.Add(Me.TxtComp)
        Me.GroupBox3.Controls.Add(Me.LbEntrega)
        Me.GroupBox3.Location = New System.Drawing.Point(90, 122)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(439, 56)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        '
        'LbDvenc
        '
        Me.LbDvenc.AutoSize = True
        Me.LbDvenc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDvenc.ForeColor = System.Drawing.Color.Blue
        Me.LbDvenc.Location = New System.Drawing.Point(227, 10)
        Me.LbDvenc.Name = "LbDvenc"
        Me.LbDvenc.Size = New System.Drawing.Size(76, 14)
        Me.LbDvenc.TabIndex = 12
        Me.LbDvenc.Text = "Vencimiento"
        '
        'DtcFecha
        '
        Me.DtcFecha.Enabled = False
        Me.DtcFecha.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtcFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtcFecha.Location = New System.Drawing.Point(227, 25)
        Me.DtcFecha.Name = "DtcFecha"
        Me.DtcFecha.Size = New System.Drawing.Size(105, 26)
        Me.DtcFecha.TabIndex = 11
        '
        'MskEnt
        '
        Me.MskEnt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskEnt.Location = New System.Drawing.Point(335, 25)
        Me.MskEnt.Name = "MskEnt"
        Me.MskEnt.Size = New System.Drawing.Size(100, 26)
        Me.MskEnt.TabIndex = 10
        '
        'LbNumero
        '
        Me.LbNumero.AutoSize = True
        Me.LbNumero.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNumero.ForeColor = System.Drawing.Color.Blue
        Me.LbNumero.Location = New System.Drawing.Point(125, 10)
        Me.LbNumero.Name = "LbNumero"
        Me.LbNumero.Size = New System.Drawing.Size(57, 14)
        Me.LbNumero.TabIndex = 9
        Me.LbNumero.Text = "Numero :"
        '
        'LbComp
        '
        Me.LbComp.AutoSize = True
        Me.LbComp.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbComp.ForeColor = System.Drawing.Color.Blue
        Me.LbComp.Location = New System.Drawing.Point(6, 10)
        Me.LbComp.Name = "LbComp"
        Me.LbComp.Size = New System.Drawing.Size(89, 14)
        Me.LbComp.TabIndex = 8
        Me.LbComp.Text = "Comprobante :"
        '
        'TxtNum
        '
        Me.TxtNum.Enabled = False
        Me.TxtNum.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNum.Location = New System.Drawing.Point(125, 25)
        Me.TxtNum.Name = "TxtNum"
        Me.TxtNum.Size = New System.Drawing.Size(97, 26)
        Me.TxtNum.TabIndex = 7
        '
        'TxtComp
        '
        Me.TxtComp.Enabled = False
        Me.TxtComp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtComp.Location = New System.Drawing.Point(6, 25)
        Me.TxtComp.Name = "TxtComp"
        Me.TxtComp.Size = New System.Drawing.Size(115, 26)
        Me.TxtComp.TabIndex = 6
        '
        'LbEntrega
        '
        Me.LbEntrega.AutoSize = True
        Me.LbEntrega.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbEntrega.ForeColor = System.Drawing.Color.Blue
        Me.LbEntrega.Location = New System.Drawing.Point(335, 10)
        Me.LbEntrega.Name = "LbEntrega"
        Me.LbEntrega.Size = New System.Drawing.Size(55, 14)
        Me.LbEntrega.TabIndex = 4
        Me.LbEntrega.Text = "Entrega :"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.CmdTarjeta)
        Me.GroupBox4.Controls.Add(Me.CmdCh)
        Me.GroupBox4.Controls.Add(Me.CmdEfec)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 122)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(83, 100)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        '
        'MskEntrega_old
        '
        Me.MskEntrega_old.Enabled = False
        Me.MskEntrega_old.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskEntrega_old.Location = New System.Drawing.Point(528, 203)
        Me.MskEntrega_old.Name = "MskEntrega_old"
        Me.MskEntrega_old.Size = New System.Drawing.Size(28, 26)
        Me.MskEntrega_old.TabIndex = 6
        Me.MskEntrega_old.Visible = False
        '
        'DtgPag
        '
        Me.DtgPag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgPag.Location = New System.Drawing.Point(90, 180)
        Me.DtgPag.Name = "DtgPag"
        Me.DtgPag.Size = New System.Drawing.Size(332, 132)
        Me.DtgPag.TabIndex = 7
        '
        'DtgRec
        '
        Me.DtgRec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgRec.Location = New System.Drawing.Point(511, 180)
        Me.DtgRec.Name = "DtgRec"
        Me.DtgRec.Size = New System.Drawing.Size(79, 74)
        Me.DtgRec.TabIndex = 9
        Me.DtgRec.Visible = False
        '
        'DtgCom
        '
        Me.DtgCom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgCom.Location = New System.Drawing.Point(511, 184)
        Me.DtgCom.Name = "DtgCom"
        Me.DtgCom.Size = New System.Drawing.Size(66, 80)
        Me.DtgCom.TabIndex = 10
        Me.DtgCom.Visible = False
        '
        'DtgDetalFac
        '
        Me.DtgDetalFac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgDetalFac.Location = New System.Drawing.Point(511, 189)
        Me.DtgDetalFac.Name = "DtgDetalFac"
        Me.DtgDetalFac.Size = New System.Drawing.Size(74, 50)
        Me.DtgDetalFac.TabIndex = 11
        Me.DtgDetalFac.Visible = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.CmdPagar)
        Me.GroupBox6.Location = New System.Drawing.Point(428, 184)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(77, 55)
        Me.GroupBox6.TabIndex = 18
        Me.GroupBox6.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LbTotal)
        Me.GroupBox2.Controls.Add(Me.MskTotal)
        Me.GroupBox2.Location = New System.Drawing.Point(430, 255)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(130, 55)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        '
        'LbTotal
        '
        Me.LbTotal.AutoSize = True
        Me.LbTotal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTotal.ForeColor = System.Drawing.Color.Blue
        Me.LbTotal.Location = New System.Drawing.Point(6, 10)
        Me.LbTotal.Name = "LbTotal"
        Me.LbTotal.Size = New System.Drawing.Size(39, 14)
        Me.LbTotal.TabIndex = 21
        Me.LbTotal.Text = "Total :"
        '
        'MskTotal
        '
        Me.MskTotal.Enabled = False
        Me.MskTotal.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskTotal.Location = New System.Drawing.Point(6, 25)
        Me.MskTotal.Name = "MskTotal"
        Me.MskTotal.Size = New System.Drawing.Size(118, 26)
        Me.MskTotal.TabIndex = 20
        Me.MskTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtSaldo
        '
        Me.TxtSaldo.Enabled = False
        Me.TxtSaldo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSaldo.Location = New System.Drawing.Point(434, 75)
        Me.TxtSaldo.Name = "TxtSaldo"
        Me.TxtSaldo.Size = New System.Drawing.Size(110, 26)
        Me.TxtSaldo.TabIndex = 13
        '
        'FrmPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 318)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.DtgPag)
        Me.Controls.Add(Me.MskEntrega_old)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DtgRec)
        Me.Controls.Add(Me.DtgDetalFac)
        Me.Controls.Add(Me.DtgCom)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmPago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cargar Pagos Clientes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DtgPag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtgRec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtgCom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtgDetalFac, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LbCl As System.Windows.Forms.Label
    Friend WithEvents TxtCli As System.Windows.Forms.TextBox
    Friend WithEvents LbCuit As System.Windows.Forms.Label
    Friend WithEvents TxtCuit As System.Windows.Forms.TextBox
    Friend WithEvents LbDirec As System.Windows.Forms.Label
    Friend WithEvents txtDirec As System.Windows.Forms.TextBox
    Friend WithEvents LbCiu As System.Windows.Forms.Label
    Friend WithEvents TxtCiu As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents LbEntrega As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdCh As System.Windows.Forms.Button
    Friend WithEvents CmdEfec As System.Windows.Forms.Button
    Friend WithEvents TxtNum As System.Windows.Forms.TextBox
    Friend WithEvents TxtComp As System.Windows.Forms.TextBox
    Friend WithEvents LbComp As System.Windows.Forms.Label
    Friend WithEvents LbNumero As System.Windows.Forms.Label
    Friend WithEvents MskEnt As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MskEntrega_old As System.Windows.Forms.MaskedTextBox
    Friend WithEvents DtgPag As System.Windows.Forms.DataGridView
    Friend WithEvents DtgRec As System.Windows.Forms.DataGridView
    Friend WithEvents DtgCom As System.Windows.Forms.DataGridView
    Friend WithEvents DtgDetalFac As System.Windows.Forms.DataGridView
    Friend WithEvents LbSaldo As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdPagar As System.Windows.Forms.Button
    Friend WithEvents CmdTarjeta As System.Windows.Forms.Button
    Friend WithEvents DtcFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents LbDvenc As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents MskTotal As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LbTotal As System.Windows.Forms.Label
    Friend WithEvents TxtSaldo As System.Windows.Forms.TextBox
End Class
