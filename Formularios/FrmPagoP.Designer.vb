<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPagoP
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.CmdPagar = New System.Windows.Forms.Button
        Me.Txttotal = New System.Windows.Forms.TextBox
        Me.LbTotal = New System.Windows.Forms.Label
        Me.DtgPag = New System.Windows.Forms.DataGridView
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CmdBciva = New System.Windows.Forms.Button
        Me.CmdBCiu = New System.Windows.Forms.Button
        Me.DtgRec = New System.Windows.Forms.DataGridView
        Me.LbEntrega = New System.Windows.Forms.Label
        Me.TxtComp = New System.Windows.Forms.TextBox
        Me.TxtNum = New System.Windows.Forms.TextBox
        Me.LbComp = New System.Windows.Forms.Label
        Me.LbNumero = New System.Windows.Forms.Label
        Me.MskEnt = New System.Windows.Forms.MaskedTextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TxtCuit = New System.Windows.Forms.MaskedTextBox
        Me.TxtCiva = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.MskFecha = New System.Windows.Forms.MaskedTextBox
        Me.Lbfecha = New System.Windows.Forms.Label
        Me.CmdbusCli = New System.Windows.Forms.Button
        Me.TxtCiu = New System.Windows.Forms.TextBox
        Me.LbCiu = New System.Windows.Forms.Label
        Me.txtDirec = New System.Windows.Forms.TextBox
        Me.LbDirec = New System.Windows.Forms.Label
        Me.LbCuit = New System.Windows.Forms.Label
        Me.TxtPro = New System.Windows.Forms.TextBox
        Me.LbCl = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        CType(Me.DtgPag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtgRec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CmdPagar)
        Me.GroupBox2.Controls.Add(Me.Txttotal)
        Me.GroupBox2.Controls.Add(Me.LbTotal)
        Me.GroupBox2.Location = New System.Drawing.Point(362, 190)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(191, 60)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'CmdPagar
        '
        Me.CmdPagar.Enabled = False
        Me.CmdPagar.Image = Global.Super.My.Resources.Resources.cash_register
        Me.CmdPagar.Location = New System.Drawing.Point(6, 9)
        Me.CmdPagar.Name = "CmdPagar"
        Me.CmdPagar.Size = New System.Drawing.Size(65, 45)
        Me.CmdPagar.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.CmdPagar, "Grabar Pago")
        Me.CmdPagar.UseVisualStyleBackColor = True
        '
        'Txttotal
        '
        Me.Txttotal.Enabled = False
        Me.Txttotal.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txttotal.Location = New System.Drawing.Point(88, 23)
        Me.Txttotal.Name = "Txttotal"
        Me.Txttotal.Size = New System.Drawing.Size(101, 26)
        Me.Txttotal.TabIndex = 5
        '
        'LbTotal
        '
        Me.LbTotal.AutoSize = True
        Me.LbTotal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTotal.ForeColor = System.Drawing.Color.Blue
        Me.LbTotal.Location = New System.Drawing.Point(88, 9)
        Me.LbTotal.Name = "LbTotal"
        Me.LbTotal.Size = New System.Drawing.Size(39, 14)
        Me.LbTotal.TabIndex = 4
        Me.LbTotal.Text = "Total :"
        '
        'DtgPag
        '
        Me.DtgPag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgPag.Location = New System.Drawing.Point(6, 168)
        Me.DtgPag.Name = "DtgPag"
        Me.DtgPag.Size = New System.Drawing.Size(350, 80)
        Me.DtgPag.TabIndex = 8
        '
        'CmdBciva
        '
        Me.CmdBciva.Enabled = False
        Me.CmdBciva.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdBciva.Location = New System.Drawing.Point(465, 74)
        Me.CmdBciva.Name = "CmdBciva"
        Me.CmdBciva.Size = New System.Drawing.Size(30, 28)
        Me.CmdBciva.TabIndex = 103
        Me.CmdBciva.Text = "..."
        Me.ToolTip1.SetToolTip(Me.CmdBciva, "Buscar un Cliente")
        Me.CmdBciva.UseVisualStyleBackColor = True
        '
        'CmdBCiu
        '
        Me.CmdBCiu.Enabled = False
        Me.CmdBCiu.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdBCiu.Location = New System.Drawing.Point(228, 75)
        Me.CmdBCiu.Name = "CmdBCiu"
        Me.CmdBCiu.Size = New System.Drawing.Size(30, 28)
        Me.CmdBCiu.TabIndex = 102
        Me.CmdBCiu.Text = "..."
        Me.ToolTip1.SetToolTip(Me.CmdBCiu, "Buscar un Cliente")
        Me.CmdBCiu.UseVisualStyleBackColor = True
        '
        'DtgRec
        '
        Me.DtgRec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgRec.Location = New System.Drawing.Point(466, 120)
        Me.DtgRec.Name = "DtgRec"
        Me.DtgRec.Size = New System.Drawing.Size(110, 41)
        Me.DtgRec.TabIndex = 10
        Me.DtgRec.Visible = False
        '
        'LbEntrega
        '
        Me.LbEntrega.AutoSize = True
        Me.LbEntrega.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbEntrega.ForeColor = System.Drawing.Color.Blue
        Me.LbEntrega.Location = New System.Drawing.Point(246, 10)
        Me.LbEntrega.Name = "LbEntrega"
        Me.LbEntrega.Size = New System.Drawing.Size(55, 14)
        Me.LbEntrega.TabIndex = 4
        Me.LbEntrega.Text = "Entrega :"
        '
        'TxtComp
        '
        Me.TxtComp.Enabled = False
        Me.TxtComp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtComp.Location = New System.Drawing.Point(6, 25)
        Me.TxtComp.Name = "TxtComp"
        Me.TxtComp.Size = New System.Drawing.Size(137, 26)
        Me.TxtComp.TabIndex = 6
        '
        'TxtNum
        '
        Me.TxtNum.Enabled = False
        Me.TxtNum.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNum.Location = New System.Drawing.Point(146, 25)
        Me.TxtNum.Name = "TxtNum"
        Me.TxtNum.Size = New System.Drawing.Size(97, 26)
        Me.TxtNum.TabIndex = 7
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
        'LbNumero
        '
        Me.LbNumero.AutoSize = True
        Me.LbNumero.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNumero.ForeColor = System.Drawing.Color.Blue
        Me.LbNumero.Location = New System.Drawing.Point(146, 10)
        Me.LbNumero.Name = "LbNumero"
        Me.LbNumero.Size = New System.Drawing.Size(57, 14)
        Me.LbNumero.TabIndex = 9
        Me.LbNumero.Text = "Numero :"
        '
        'MskEnt
        '
        Me.MskEnt.Enabled = False
        Me.MskEnt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskEnt.Location = New System.Drawing.Point(246, 25)
        Me.MskEnt.Name = "MskEnt"
        Me.MskEnt.Size = New System.Drawing.Size(100, 26)
        Me.MskEnt.TabIndex = 10
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.MskEnt)
        Me.GroupBox3.Controls.Add(Me.LbNumero)
        Me.GroupBox3.Controls.Add(Me.LbComp)
        Me.GroupBox3.Controls.Add(Me.TxtNum)
        Me.GroupBox3.Controls.Add(Me.TxtComp)
        Me.GroupBox3.Controls.Add(Me.LbEntrega)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 110)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(350, 56)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtCuit)
        Me.GroupBox1.Controls.Add(Me.CmdBciva)
        Me.GroupBox1.Controls.Add(Me.CmdBCiu)
        Me.GroupBox1.Controls.Add(Me.TxtCiva)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.MskFecha)
        Me.GroupBox1.Controls.Add(Me.Lbfecha)
        Me.GroupBox1.Controls.Add(Me.CmdbusCli)
        Me.GroupBox1.Controls.Add(Me.TxtCiu)
        Me.GroupBox1.Controls.Add(Me.LbCiu)
        Me.GroupBox1.Controls.Add(Me.txtDirec)
        Me.GroupBox1.Controls.Add(Me.LbDirec)
        Me.GroupBox1.Controls.Add(Me.LbCuit)
        Me.GroupBox1.Controls.Add(Me.TxtPro)
        Me.GroupBox1.Controls.Add(Me.LbCl)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(626, 109)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        '
        'TxtCuit
        '
        Me.TxtCuit.Enabled = False
        Me.TxtCuit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCuit.Location = New System.Drawing.Point(497, 75)
        Me.TxtCuit.Name = "TxtCuit"
        Me.TxtCuit.Size = New System.Drawing.Size(125, 26)
        Me.TxtCuit.TabIndex = 105
        '
        'TxtCiva
        '
        Me.TxtCiva.Enabled = False
        Me.TxtCiva.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCiva.Location = New System.Drawing.Point(261, 75)
        Me.TxtCiva.Name = "TxtCiva"
        Me.TxtCiva.Size = New System.Drawing.Size(203, 26)
        Me.TxtCiva.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(261, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 14)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "C. de Iva :"
        '
        'MskFecha
        '
        Me.MskFecha.Enabled = False
        Me.MskFecha.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskFecha.Location = New System.Drawing.Point(501, 78)
        Me.MskFecha.Mask = "##/##/####"
        Me.MskFecha.Name = "MskFecha"
        Me.MskFecha.Size = New System.Drawing.Size(95, 26)
        Me.MskFecha.TabIndex = 10
        Me.MskFecha.Visible = False
        '
        'Lbfecha
        '
        Me.Lbfecha.AutoSize = True
        Me.Lbfecha.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbfecha.ForeColor = System.Drawing.Color.Blue
        Me.Lbfecha.Location = New System.Drawing.Point(525, 79)
        Me.Lbfecha.Name = "Lbfecha"
        Me.Lbfecha.Size = New System.Drawing.Size(45, 14)
        Me.Lbfecha.TabIndex = 9
        Me.Lbfecha.Text = "Fecha :"
        Me.Lbfecha.Visible = False
        '
        'CmdbusCli
        '
        Me.CmdbusCli.Image = Global.Super.My.Resources.Resources.Buscar
        Me.CmdbusCli.Location = New System.Drawing.Point(555, 13)
        Me.CmdbusCli.Name = "CmdbusCli"
        Me.CmdbusCli.Size = New System.Drawing.Size(65, 45)
        Me.CmdbusCli.TabIndex = 8
        Me.CmdbusCli.UseVisualStyleBackColor = True
        '
        'TxtCiu
        '
        Me.TxtCiu.Enabled = False
        Me.TxtCiu.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCiu.Location = New System.Drawing.Point(6, 75)
        Me.TxtCiu.Name = "TxtCiu"
        Me.TxtCiu.Size = New System.Drawing.Size(221, 26)
        Me.TxtCiu.TabIndex = 7
        '
        'LbCiu
        '
        Me.LbCiu.AutoSize = True
        Me.LbCiu.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCiu.ForeColor = System.Drawing.Color.Blue
        Me.LbCiu.Location = New System.Drawing.Point(6, 61)
        Me.LbCiu.Name = "LbCiu"
        Me.LbCiu.Size = New System.Drawing.Size(51, 14)
        Me.LbCiu.TabIndex = 6
        Me.LbCiu.Text = "Ciudad :"
        '
        'txtDirec
        '
        Me.txtDirec.Enabled = False
        Me.txtDirec.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDirec.Location = New System.Drawing.Point(318, 30)
        Me.txtDirec.Name = "txtDirec"
        Me.txtDirec.Size = New System.Drawing.Size(235, 26)
        Me.txtDirec.TabIndex = 5
        '
        'LbDirec
        '
        Me.LbDirec.AutoSize = True
        Me.LbDirec.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDirec.ForeColor = System.Drawing.Color.Blue
        Me.LbDirec.Location = New System.Drawing.Point(318, 16)
        Me.LbDirec.Name = "LbDirec"
        Me.LbDirec.Size = New System.Drawing.Size(64, 14)
        Me.LbDirec.TabIndex = 4
        Me.LbDirec.Text = "Direccion :"
        '
        'LbCuit
        '
        Me.LbCuit.AutoSize = True
        Me.LbCuit.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCuit.ForeColor = System.Drawing.Color.Blue
        Me.LbCuit.Location = New System.Drawing.Point(497, 61)
        Me.LbCuit.Name = "LbCuit"
        Me.LbCuit.Size = New System.Drawing.Size(35, 14)
        Me.LbCuit.TabIndex = 2
        Me.LbCuit.Text = "Cuit :"
        '
        'TxtPro
        '
        Me.TxtPro.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPro.Location = New System.Drawing.Point(6, 30)
        Me.TxtPro.Name = "TxtPro"
        Me.TxtPro.Size = New System.Drawing.Size(310, 26)
        Me.TxtPro.TabIndex = 0
        '
        'LbCl
        '
        Me.LbCl.AutoSize = True
        Me.LbCl.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCl.ForeColor = System.Drawing.Color.Blue
        Me.LbCl.Location = New System.Drawing.Point(6, 16)
        Me.LbCl.Name = "LbCl"
        Me.LbCl.Size = New System.Drawing.Size(71, 14)
        Me.LbCl.TabIndex = 0
        Me.LbCl.Text = "Proveedor :"
        '
        'FrmPagoP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 258)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DtgPag)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DtgRec)
        Me.Name = "FrmPagoP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cargar Pagos Proveedores"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DtgPag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtgRec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdPagar As System.Windows.Forms.Button
    Friend WithEvents Txttotal As System.Windows.Forms.TextBox
    Friend WithEvents LbTotal As System.Windows.Forms.Label
    Friend WithEvents DtgPag As System.Windows.Forms.DataGridView
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents DtgRec As System.Windows.Forms.DataGridView
    Friend WithEvents LbEntrega As System.Windows.Forms.Label
    Friend WithEvents TxtComp As System.Windows.Forms.TextBox
    Friend WithEvents TxtNum As System.Windows.Forms.TextBox
    Friend WithEvents LbComp As System.Windows.Forms.Label
    Friend WithEvents LbNumero As System.Windows.Forms.Label
    Friend WithEvents MskEnt As System.Windows.Forms.MaskedTextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdBciva As System.Windows.Forms.Button
    Friend WithEvents CmdBCiu As System.Windows.Forms.Button
    Friend WithEvents TxtCiva As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MskFecha As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Lbfecha As System.Windows.Forms.Label
    Friend WithEvents CmdbusCli As System.Windows.Forms.Button
    Friend WithEvents TxtCiu As System.Windows.Forms.TextBox
    Friend WithEvents LbCiu As System.Windows.Forms.Label
    Friend WithEvents txtDirec As System.Windows.Forms.TextBox
    Friend WithEvents LbDirec As System.Windows.Forms.Label
    Friend WithEvents LbCuit As System.Windows.Forms.Label
    Friend WithEvents TxtPro As System.Windows.Forms.TextBox
    Friend WithEvents LbCl As System.Windows.Forms.Label
    Friend WithEvents TxtCuit As System.Windows.Forms.MaskedTextBox
End Class
