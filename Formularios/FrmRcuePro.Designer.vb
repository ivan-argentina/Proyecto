<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRcuePro
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.CmdbusCli = New System.Windows.Forms.Button
        Me.TxtCiu = New System.Windows.Forms.TextBox
        Me.LbCiu = New System.Windows.Forms.Label
        Me.txtDirec = New System.Windows.Forms.TextBox
        Me.LbDirec = New System.Windows.Forms.Label
        Me.TxtCuit = New System.Windows.Forms.TextBox
        Me.LbCuit = New System.Windows.Forms.Label
        Me.Txtprov = New System.Windows.Forms.TextBox
        Me.LbCl = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CmdLSal = New System.Windows.Forms.Button
        Me.CmdPantalla = New System.Windows.Forms.Button
        Me.DtgD = New System.Windows.Forms.DataGridView
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.DtcHasta = New System.Windows.Forms.DateTimePicker
        Me.LbHasta = New System.Windows.Forms.Label
        Me.Lbdesde = New System.Windows.Forms.Label
        Me.DtcDesde = New System.Windows.Forms.DateTimePicker
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TxtIva = New System.Windows.Forms.TextBox
        Me.Bar = New System.Windows.Forms.ProgressBar
        Me.DtgPro = New System.Windows.Forms.DataGridView
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DtgD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DtgPro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CmdbusCli)
        Me.GroupBox2.Controls.Add(Me.TxtCiu)
        Me.GroupBox2.Controls.Add(Me.LbCiu)
        Me.GroupBox2.Controls.Add(Me.txtDirec)
        Me.GroupBox2.Controls.Add(Me.LbDirec)
        Me.GroupBox2.Controls.Add(Me.TxtCuit)
        Me.GroupBox2.Controls.Add(Me.LbCuit)
        Me.GroupBox2.Controls.Add(Me.Txtprov)
        Me.GroupBox2.Controls.Add(Me.LbCl)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(556, 109)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'CmdbusCli
        '
        Me.CmdbusCli.Image = Global.Super.My.Resources.Resources.Buscar
        Me.CmdbusCli.Location = New System.Drawing.Point(480, 22)
        Me.CmdbusCli.Name = "CmdbusCli"
        Me.CmdbusCli.Size = New System.Drawing.Size(65, 45)
        Me.CmdbusCli.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.CmdbusCli, "Buscar un Proveedor")
        Me.CmdbusCli.UseVisualStyleBackColor = True
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
        Me.TxtCuit.Location = New System.Drawing.Point(341, 30)
        Me.TxtCuit.Name = "TxtCuit"
        Me.TxtCuit.Size = New System.Drawing.Size(136, 26)
        Me.TxtCuit.TabIndex = 3
        '
        'LbCuit
        '
        Me.LbCuit.AutoSize = True
        Me.LbCuit.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCuit.ForeColor = System.Drawing.Color.Blue
        Me.LbCuit.Location = New System.Drawing.Point(341, 16)
        Me.LbCuit.Name = "LbCuit"
        Me.LbCuit.Size = New System.Drawing.Size(35, 14)
        Me.LbCuit.TabIndex = 2
        Me.LbCuit.Text = "Cuit :"
        '
        'Txtprov
        '
        Me.Txtprov.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtprov.Location = New System.Drawing.Point(6, 30)
        Me.Txtprov.Name = "Txtprov"
        Me.Txtprov.Size = New System.Drawing.Size(333, 26)
        Me.Txtprov.TabIndex = 1
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CmdLSal)
        Me.GroupBox1.Controls.Add(Me.CmdPantalla)
        Me.GroupBox1.Location = New System.Drawing.Point(418, 123)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(144, 60)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'CmdLSal
        '
        Me.CmdLSal.Image = Global.Super.My.Resources.Resources.saldos
        Me.CmdLSal.Location = New System.Drawing.Point(74, 10)
        Me.CmdLSal.Name = "CmdLSal"
        Me.CmdLSal.Size = New System.Drawing.Size(65, 45)
        Me.CmdLSal.TabIndex = 1
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
        Me.ToolTip1.SetToolTip(Me.CmdPantalla, "Pantalla")
        Me.CmdPantalla.UseVisualStyleBackColor = True
        '
        'DtgD
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DtgD.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DtgD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DtgD.DefaultCellStyle = DataGridViewCellStyle2
        Me.DtgD.Location = New System.Drawing.Point(5, 123)
        Me.DtgD.Name = "DtgD"
        Me.DtgD.Size = New System.Drawing.Size(349, 50)
        Me.DtgD.TabIndex = 8
        Me.DtgD.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DtcHasta)
        Me.GroupBox3.Controls.Add(Me.LbHasta)
        Me.GroupBox3.Controls.Add(Me.Lbdesde)
        Me.GroupBox3.Controls.Add(Me.DtcDesde)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 123)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(231, 55)
        Me.GroupBox3.TabIndex = 9
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
        '
        'TxtIva
        '
        Me.TxtIva.Location = New System.Drawing.Point(382, 139)
        Me.TxtIva.Name = "TxtIva"
        Me.TxtIva.Size = New System.Drawing.Size(14, 20)
        Me.TxtIva.TabIndex = 10
        Me.TxtIva.Visible = False
        '
        'Bar
        '
        Me.Bar.Location = New System.Drawing.Point(6, 189)
        Me.Bar.Name = "Bar"
        Me.Bar.Size = New System.Drawing.Size(556, 25)
        Me.Bar.TabIndex = 11
        '
        'DtgPro
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DtgPro.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DtgPro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DtgPro.DefaultCellStyle = DataGridViewCellStyle4
        Me.DtgPro.Location = New System.Drawing.Point(15, 101)
        Me.DtgPro.Name = "DtgPro"
        Me.DtgPro.Size = New System.Drawing.Size(468, 72)
        Me.DtgPro.TabIndex = 12
        Me.DtgPro.Visible = False
        '
        'FrmRcuePro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 222)
        Me.Controls.Add(Me.Bar)
        Me.Controls.Add(Me.TxtIva)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DtgD)
        Me.Controls.Add(Me.DtgPro)
        Me.Name = "FrmRcuePro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resumen de Cuenta de Proveedores"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DtgD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DtgPro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdbusCli As System.Windows.Forms.Button
    Friend WithEvents TxtCiu As System.Windows.Forms.TextBox
    Friend WithEvents LbCiu As System.Windows.Forms.Label
    Friend WithEvents txtDirec As System.Windows.Forms.TextBox
    Friend WithEvents LbDirec As System.Windows.Forms.Label
    Friend WithEvents TxtCuit As System.Windows.Forms.TextBox
    Friend WithEvents LbCuit As System.Windows.Forms.Label
    Friend WithEvents Txtprov As System.Windows.Forms.TextBox
    Friend WithEvents LbCl As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdLSal As System.Windows.Forms.Button
    Friend WithEvents CmdPantalla As System.Windows.Forms.Button
    Friend WithEvents DtgD As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DtcHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents LbHasta As System.Windows.Forms.Label
    Friend WithEvents Lbdesde As System.Windows.Forms.Label
    Friend WithEvents DtcDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents TxtIva As System.Windows.Forms.TextBox
    Friend WithEvents Bar As System.Windows.Forms.ProgressBar
    Friend WithEvents DtgPro As System.Windows.Forms.DataGridView
End Class
