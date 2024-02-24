<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRcue
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
        Me.Button1 = New System.Windows.Forms.Button
        Me.TxtCiu = New System.Windows.Forms.TextBox
        Me.LbCiu = New System.Windows.Forms.Label
        Me.txtDirec = New System.Windows.Forms.TextBox
        Me.LbDirec = New System.Windows.Forms.Label
        Me.TxtCuit = New System.Windows.Forms.TextBox
        Me.DtgDet = New System.Windows.Forms.DataGridView
        Me.LbCuit = New System.Windows.Forms.Label
        Me.DtgD = New System.Windows.Forms.DataGridView
        Me.TxtCli = New System.Windows.Forms.TextBox
        Me.LbCl = New System.Windows.Forms.Label
        Me.DtgRcu = New System.Windows.Forms.DataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CmdDetVen = New System.Windows.Forms.Button
        Me.CmdLSal = New System.Windows.Forms.Button
        Me.CmdPantalla = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.DtcHasta = New System.Windows.Forms.DateTimePicker
        Me.LbHasta = New System.Windows.Forms.Label
        Me.Lbdesde = New System.Windows.Forms.Label
        Me.DtcDesde = New System.Windows.Forms.DateTimePicker
        Me.barra = New System.Windows.Forms.ProgressBar
        Me.Bar = New System.Windows.Forms.ProgressBar
        Me.Dtgcli = New System.Windows.Forms.DataGridView
        Me.DtgProv = New System.Windows.Forms.DataGridView
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.TxtMora = New System.Windows.Forms.TextBox
        Me.LbMora = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        CType(Me.DtgDet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtgD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtgRcu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Dtgcli, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtgProv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.TxtCiu)
        Me.GroupBox2.Controls.Add(Me.LbCiu)
        Me.GroupBox2.Controls.Add(Me.txtDirec)
        Me.GroupBox2.Controls.Add(Me.LbDirec)
        Me.GroupBox2.Controls.Add(Me.TxtCuit)
        Me.GroupBox2.Controls.Add(Me.DtgDet)
        Me.GroupBox2.Controls.Add(Me.LbCuit)
        Me.GroupBox2.Controls.Add(Me.DtgD)
        Me.GroupBox2.Controls.Add(Me.TxtCli)
        Me.GroupBox2.Controls.Add(Me.LbCl)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(556, 109)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(248, 90)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(71, 44)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Act.Saldo"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'TxtCiu
        '
        Me.TxtCiu.Enabled = False
        Me.TxtCiu.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCiu.Location = New System.Drawing.Point(297, 75)
        Me.TxtCiu.Name = "TxtCiu"
        Me.TxtCiu.Size = New System.Drawing.Size(253, 26)
        Me.TxtCiu.TabIndex = 7
        '
        'LbCiu
        '
        Me.LbCiu.AutoSize = True
        Me.LbCiu.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCiu.ForeColor = System.Drawing.Color.Blue
        Me.LbCiu.Location = New System.Drawing.Point(297, 60)
        Me.LbCiu.Name = "LbCiu"
        Me.LbCiu.Size = New System.Drawing.Size(51, 14)
        Me.LbCiu.TabIndex = 6
        Me.LbCiu.Text = "Ciudad :"
        '
        'txtDirec
        '
        Me.txtDirec.Enabled = False
        Me.txtDirec.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDirec.Location = New System.Drawing.Point(6, 75)
        Me.txtDirec.Name = "txtDirec"
        Me.txtDirec.Size = New System.Drawing.Size(288, 26)
        Me.txtDirec.TabIndex = 5
        '
        'LbDirec
        '
        Me.LbDirec.AutoSize = True
        Me.LbDirec.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDirec.ForeColor = System.Drawing.Color.Blue
        Me.LbDirec.Location = New System.Drawing.Point(6, 60)
        Me.LbDirec.Name = "LbDirec"
        Me.LbDirec.Size = New System.Drawing.Size(64, 14)
        Me.LbDirec.TabIndex = 4
        Me.LbDirec.Text = "Direccion :"
        '
        'TxtCuit
        '
        Me.TxtCuit.Enabled = False
        Me.TxtCuit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCuit.Location = New System.Drawing.Point(411, 30)
        Me.TxtCuit.Name = "TxtCuit"
        Me.TxtCuit.Size = New System.Drawing.Size(136, 26)
        Me.TxtCuit.TabIndex = 3
        '
        'DtgDet
        '
        Me.DtgDet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgDet.Location = New System.Drawing.Point(-5, 70)
        Me.DtgDet.Name = "DtgDet"
        Me.DtgDet.Size = New System.Drawing.Size(296, 68)
        Me.DtgDet.TabIndex = 7
        Me.DtgDet.Visible = False
        '
        'LbCuit
        '
        Me.LbCuit.AutoSize = True
        Me.LbCuit.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCuit.ForeColor = System.Drawing.Color.Blue
        Me.LbCuit.Location = New System.Drawing.Point(408, 16)
        Me.LbCuit.Name = "LbCuit"
        Me.LbCuit.Size = New System.Drawing.Size(35, 14)
        Me.LbCuit.TabIndex = 2
        Me.LbCuit.Text = "Cuit :"
        '
        'DtgD
        '
        Me.DtgD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgD.Location = New System.Drawing.Point(18, 60)
        Me.DtgD.Name = "DtgD"
        Me.DtgD.Size = New System.Drawing.Size(330, 68)
        Me.DtgD.TabIndex = 8
        Me.DtgD.Visible = False
        '
        'TxtCli
        '
        Me.TxtCli.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCli.Location = New System.Drawing.Point(6, 30)
        Me.TxtCli.Name = "TxtCli"
        Me.TxtCli.Size = New System.Drawing.Size(399, 26)
        Me.TxtCli.TabIndex = 1
        '
        'LbCl
        '
        Me.LbCl.AutoSize = True
        Me.LbCl.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCl.ForeColor = System.Drawing.Color.Blue
        Me.LbCl.Location = New System.Drawing.Point(6, 16)
        Me.LbCl.Name = "LbCl"
        Me.LbCl.Size = New System.Drawing.Size(52, 14)
        Me.LbCl.TabIndex = 0
        Me.LbCl.Text = "Cliente :"
        '
        'DtgRcu
        '
        Me.DtgRcu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgRcu.Location = New System.Drawing.Point(9, 100)
        Me.DtgRcu.Name = "DtgRcu"
        Me.DtgRcu.Size = New System.Drawing.Size(547, 39)
        Me.DtgRcu.TabIndex = 3
        Me.DtgRcu.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CmdDetVen)
        Me.GroupBox1.Controls.Add(Me.CmdLSal)
        Me.GroupBox1.Controls.Add(Me.CmdPantalla)
        Me.GroupBox1.Location = New System.Drawing.Point(342, 120)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(210, 60)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'CmdDetVen
        '
        Me.CmdDetVen.Enabled = False
        Me.CmdDetVen.Image = Global.Super.My.Resources.Resources.Articulo
        Me.CmdDetVen.Location = New System.Drawing.Point(75, 10)
        Me.CmdDetVen.Name = "CmdDetVen"
        Me.CmdDetVen.Size = New System.Drawing.Size(65, 45)
        Me.CmdDetVen.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.CmdDetVen, "Detalle de Venta")
        Me.CmdDetVen.UseVisualStyleBackColor = True
        '
        'CmdLSal
        '
        Me.CmdLSal.Image = Global.Super.My.Resources.Resources.saldos
        Me.CmdLSal.Location = New System.Drawing.Point(142, 10)
        Me.CmdLSal.Name = "CmdLSal"
        Me.CmdLSal.Size = New System.Drawing.Size(65, 45)
        Me.CmdLSal.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.CmdLSal, "Listado de Saldos")
        Me.CmdLSal.UseVisualStyleBackColor = True
        '
        'CmdPantalla
        '
        Me.CmdPantalla.Enabled = False
        Me.CmdPantalla.Image = Global.Super.My.Resources.Resources.Pantalla
        Me.CmdPantalla.Location = New System.Drawing.Point(6, 10)
        Me.CmdPantalla.Name = "CmdPantalla"
        Me.CmdPantalla.Size = New System.Drawing.Size(65, 45)
        Me.CmdPantalla.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.CmdPantalla, "Resumen de Cuenta")
        Me.CmdPantalla.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DtcHasta)
        Me.GroupBox3.Controls.Add(Me.LbHasta)
        Me.GroupBox3.Controls.Add(Me.Lbdesde)
        Me.GroupBox3.Controls.Add(Me.DtcDesde)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 120)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(231, 55)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        '
        'DtcHasta
        '
        Me.DtcHasta.Enabled = False
        Me.DtcHasta.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtcHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtcHasta.Location = New System.Drawing.Point(116, 24)
        Me.DtcHasta.Name = "DtcHasta"
        Me.DtcHasta.Size = New System.Drawing.Size(108, 26)
        Me.DtcHasta.TabIndex = 3
        Me.DtcHasta.Value = New Date(2015, 11, 30, 0, 0, 0, 0)
        '
        'LbHasta
        '
        Me.LbHasta.AutoSize = True
        Me.LbHasta.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbHasta.ForeColor = System.Drawing.Color.Blue
        Me.LbHasta.Location = New System.Drawing.Point(116, 10)
        Me.LbHasta.Name = "LbHasta"
        Me.LbHasta.Size = New System.Drawing.Size(43, 14)
        Me.LbHasta.TabIndex = 2
        Me.LbHasta.Text = "Hasta :"
        '
        'Lbdesde
        '
        Me.Lbdesde.AutoSize = True
        Me.Lbdesde.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbdesde.ForeColor = System.Drawing.Color.Blue
        Me.Lbdesde.Location = New System.Drawing.Point(6, 10)
        Me.Lbdesde.Name = "Lbdesde"
        Me.Lbdesde.Size = New System.Drawing.Size(48, 14)
        Me.Lbdesde.TabIndex = 1
        Me.Lbdesde.Text = "Desde :"
        '
        'DtcDesde
        '
        Me.DtcDesde.CalendarFont = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtcDesde.Enabled = False
        Me.DtcDesde.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtcDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtcDesde.Location = New System.Drawing.Point(6, 24)
        Me.DtcDesde.Name = "DtcDesde"
        Me.DtcDesde.Size = New System.Drawing.Size(108, 26)
        Me.DtcDesde.TabIndex = 0
        Me.DtcDesde.Value = New Date(2015, 11, 1, 0, 0, 0, 0)
        '
        'barra
        '
        Me.barra.Location = New System.Drawing.Point(12, 101)
        Me.barra.Name = "barra"
        Me.barra.Size = New System.Drawing.Size(340, 26)
        Me.barra.TabIndex = 6
        Me.barra.Visible = False
        '
        'Bar
        '
        Me.Bar.Location = New System.Drawing.Point(6, 200)
        Me.Bar.Name = "Bar"
        Me.Bar.Size = New System.Drawing.Size(556, 22)
        Me.Bar.TabIndex = 7
        '
        'Dtgcli
        '
        Me.Dtgcli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dtgcli.Location = New System.Drawing.Point(17, 111)
        Me.Dtgcli.Name = "Dtgcli"
        Me.Dtgcli.Size = New System.Drawing.Size(534, 27)
        Me.Dtgcli.TabIndex = 8
        Me.Dtgcli.Visible = False
        '
        'DtgProv
        '
        Me.DtgProv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgProv.Location = New System.Drawing.Point(1, 100)
        Me.DtgProv.Name = "DtgProv"
        Me.DtgProv.Size = New System.Drawing.Size(529, 24)
        Me.DtgProv.TabIndex = 9
        Me.DtgProv.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TxtMora)
        Me.GroupBox4.Controls.Add(Me.LbMora)
        Me.GroupBox4.Location = New System.Drawing.Point(239, 120)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(103, 55)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        '
        'TxtMora
        '
        Me.TxtMora.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMora.Location = New System.Drawing.Point(6, 24)
        Me.TxtMora.Name = "TxtMora"
        Me.TxtMora.Size = New System.Drawing.Size(91, 26)
        Me.TxtMora.TabIndex = 1
        Me.TxtMora.Text = "0"
        '
        'LbMora
        '
        Me.LbMora.AutoSize = True
        Me.LbMora.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbMora.ForeColor = System.Drawing.Color.Blue
        Me.LbMora.Location = New System.Drawing.Point(6, 10)
        Me.LbMora.Name = "LbMora"
        Me.LbMora.Size = New System.Drawing.Size(69, 14)
        Me.LbMora.TabIndex = 0
        Me.LbMora.Text = "% Por Mora"
        '
        'FrmRcue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 230)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Bar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.barra)
        Me.Controls.Add(Me.Dtgcli)
        Me.Controls.Add(Me.DtgProv)
        Me.Controls.Add(Me.DtgRcu)
        Me.Name = "FrmRcue"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resumen De Cuenta de Clientes"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DtgDet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtgD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtgRcu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.Dtgcli, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtgProv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtCiu As System.Windows.Forms.TextBox
    Friend WithEvents LbCiu As System.Windows.Forms.Label
    Friend WithEvents txtDirec As System.Windows.Forms.TextBox
    Friend WithEvents LbDirec As System.Windows.Forms.Label
    Friend WithEvents TxtCuit As System.Windows.Forms.TextBox
    Friend WithEvents LbCuit As System.Windows.Forms.Label
    Friend WithEvents TxtCli As System.Windows.Forms.TextBox
    Friend WithEvents LbCl As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdPantalla As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents DtgRcu As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DtcDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Lbdesde As System.Windows.Forms.Label
    Friend WithEvents LbHasta As System.Windows.Forms.Label
    Friend WithEvents DtcHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents CmdLSal As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents barra As System.Windows.Forms.ProgressBar
    Friend WithEvents DtgDet As System.Windows.Forms.DataGridView
    Friend WithEvents DtgD As System.Windows.Forms.DataGridView
    Friend WithEvents Bar As System.Windows.Forms.ProgressBar
    Friend WithEvents Dtgcli As System.Windows.Forms.DataGridView
    Friend WithEvents DtgProv As System.Windows.Forms.DataGridView
    Friend WithEvents CmdDetVen As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents LbMora As System.Windows.Forms.Label
    Friend WithEvents TxtMora As System.Windows.Forms.TextBox
End Class
