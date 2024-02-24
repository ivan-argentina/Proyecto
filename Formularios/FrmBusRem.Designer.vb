<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBusRem
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
        Me.DtgRem = New System.Windows.Forms.DataGridView
        Me.DtgDFac = New System.Windows.Forms.DataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Cmdfacturar = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CmbUsuario = New System.Windows.Forms.ComboBox
        Me.TxtBarra = New System.Windows.Forms.TextBox
        Me.DtgRem1 = New System.Windows.Forms.DataGridView
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DtcHasta = New System.Windows.Forms.DateTimePicker
        Me.DtcDesde = New System.Windows.Forms.DateTimePicker
        Me.LbHasta = New System.Windows.Forms.Label
        Me.LbFecha = New System.Windows.Forms.Label
        Me.DtgDetRem = New System.Windows.Forms.DataGridView
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.UsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConddeVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnCiva = New System.Windows.Forms.ToolStripSplitButton
        Me.ContadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CtaCteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TxtCliente = New System.Windows.Forms.ToolStripTextBox
        Me.DtgTotAlic = New System.Windows.Forms.DataGridView
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.TxtTotal = New System.Windows.Forms.TextBox
        Me.LbTtotal = New System.Windows.Forms.Label
        CType(Me.DtgRem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtgDFac, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DtgRem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DtgDetRem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DtgTotAlic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DtgRem
        '
        Me.DtgRem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgRem.Location = New System.Drawing.Point(6, 35)
        Me.DtgRem.Name = "DtgRem"
        Me.DtgRem.Size = New System.Drawing.Size(702, 255)
        Me.DtgRem.TabIndex = 1
        '
        'DtgDFac
        '
        Me.DtgDFac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgDFac.Location = New System.Drawing.Point(23, 127)
        Me.DtgDFac.Name = "DtgDFac"
        Me.DtgDFac.Size = New System.Drawing.Size(347, 44)
        Me.DtgDFac.TabIndex = 6
        Me.DtgDFac.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Cmdfacturar)
        Me.GroupBox1.Location = New System.Drawing.Point(632, 413)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(75, 55)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'Cmdfacturar
        '
        Me.Cmdfacturar.Image = Global.Super.My.Resources.Resources.Facturar
        Me.Cmdfacturar.Location = New System.Drawing.Point(4, 10)
        Me.Cmdfacturar.Name = "Cmdfacturar"
        Me.Cmdfacturar.Size = New System.Drawing.Size(65, 45)
        Me.Cmdfacturar.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.Cmdfacturar, "Cargar para Facturar")
        Me.Cmdfacturar.UseVisualStyleBackColor = True
        '
        'CmbUsuario
        '
        Me.CmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbUsuario.Enabled = False
        Me.CmbUsuario.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbUsuario.FormattingEnabled = True
        Me.CmbUsuario.Location = New System.Drawing.Point(282, 1)
        Me.CmbUsuario.Name = "CmbUsuario"
        Me.CmbUsuario.Size = New System.Drawing.Size(155, 24)
        Me.CmbUsuario.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.CmbUsuario, "Elija un Usuario")
        '
        'TxtBarra
        '
        Me.TxtBarra.Location = New System.Drawing.Point(76, 151)
        Me.TxtBarra.Name = "TxtBarra"
        Me.TxtBarra.Size = New System.Drawing.Size(103, 20)
        Me.TxtBarra.TabIndex = 8
        Me.TxtBarra.Visible = False
        '
        'DtgRem1
        '
        Me.DtgRem1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgRem1.Location = New System.Drawing.Point(23, 73)
        Me.DtgRem1.Name = "DtgRem1"
        Me.DtgRem1.Size = New System.Drawing.Size(275, 48)
        Me.DtgRem1.TabIndex = 9
        Me.DtgRem1.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DtcHasta)
        Me.GroupBox2.Controls.Add(Me.DtcDesde)
        Me.GroupBox2.Controls.Add(Me.LbHasta)
        Me.GroupBox2.Controls.Add(Me.LbFecha)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 90)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(224, 55)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Visible = False
        '
        'DtcHasta
        '
        Me.DtcHasta.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtcHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtcHasta.Location = New System.Drawing.Point(115, 26)
        Me.DtcHasta.Name = "DtcHasta"
        Me.DtcHasta.Size = New System.Drawing.Size(105, 26)
        Me.DtcHasta.TabIndex = 5
        '
        'DtcDesde
        '
        Me.DtcDesde.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtcDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtcDesde.Location = New System.Drawing.Point(6, 26)
        Me.DtcDesde.Name = "DtcDesde"
        Me.DtcDesde.Size = New System.Drawing.Size(105, 26)
        Me.DtcDesde.TabIndex = 4
        '
        'LbHasta
        '
        Me.LbHasta.AutoSize = True
        Me.LbHasta.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbHasta.ForeColor = System.Drawing.Color.Blue
        Me.LbHasta.Location = New System.Drawing.Point(115, 12)
        Me.LbHasta.Name = "LbHasta"
        Me.LbHasta.Size = New System.Drawing.Size(43, 14)
        Me.LbHasta.TabIndex = 2
        Me.LbHasta.Text = "Hasta :"
        '
        'LbFecha
        '
        Me.LbFecha.AutoSize = True
        Me.LbFecha.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFecha.ForeColor = System.Drawing.Color.Blue
        Me.LbFecha.Location = New System.Drawing.Point(3, 12)
        Me.LbFecha.Name = "LbFecha"
        Me.LbFecha.Size = New System.Drawing.Size(48, 14)
        Me.LbFecha.TabIndex = 1
        Me.LbFecha.Text = "Desde :"
        '
        'DtgDetRem
        '
        Me.DtgDetRem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgDetRem.Location = New System.Drawing.Point(6, 296)
        Me.DtgDetRem.Name = "DtgDetRem"
        Me.DtgDetRem.Size = New System.Drawing.Size(702, 116)
        Me.DtgDetRem.TabIndex = 12
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1, Me.ToolStripSeparator1, Me.BtnCiva, Me.TxtCliente})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(712, 25)
        Me.ToolStrip1.TabIndex = 13
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.UsuarioToolStripMenuItem, Me.ConddeVentaToolStripMenuItem, Me.ClienteToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = Global.Super.My.Resources.Resources.selectivo
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(29, 22)
        Me.ToolStripDropDownButton1.Text = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.ToolTipText = "Elegir Opcion"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(151, 22)
        Me.ToolStripMenuItem1.Text = "Ninguno"
        '
        'UsuarioToolStripMenuItem
        '
        Me.UsuarioToolStripMenuItem.Name = "UsuarioToolStripMenuItem"
        Me.UsuarioToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.UsuarioToolStripMenuItem.Text = "Usuario"
        '
        'ConddeVentaToolStripMenuItem
        '
        Me.ConddeVentaToolStripMenuItem.Name = "ConddeVentaToolStripMenuItem"
        Me.ConddeVentaToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.ConddeVentaToolStripMenuItem.Text = "Cond.de Venta"
        '
        'ClienteToolStripMenuItem
        '
        Me.ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem"
        Me.ClienteToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.ClienteToolStripMenuItem.Text = "Cliente"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BtnCiva
        '
        Me.BtnCiva.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnCiva.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContadoToolStripMenuItem, Me.CtaCteToolStripMenuItem})
        Me.BtnCiva.Enabled = False
        Me.BtnCiva.Image = Global.Super.My.Resources.Resources.efectivo
        Me.BtnCiva.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnCiva.Name = "BtnCiva"
        Me.BtnCiva.Size = New System.Drawing.Size(32, 22)
        Me.BtnCiva.Text = "ToolStripSplitButton1"
        Me.BtnCiva.ToolTipText = "Condicion de Iva"
        '
        'ContadoToolStripMenuItem
        '
        Me.ContadoToolStripMenuItem.Name = "ContadoToolStripMenuItem"
        Me.ContadoToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.ContadoToolStripMenuItem.Text = "Contado"
        '
        'CtaCteToolStripMenuItem
        '
        Me.CtaCteToolStripMenuItem.Name = "CtaCteToolStripMenuItem"
        Me.CtaCteToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.CtaCteToolStripMenuItem.Text = "Cta.Cte"
        '
        'TxtCliente
        '
        Me.TxtCliente.Enabled = False
        Me.TxtCliente.Name = "TxtCliente"
        Me.TxtCliente.Size = New System.Drawing.Size(200, 25)
        '
        'DtgTotAlic
        '
        Me.DtgTotAlic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgTotAlic.Location = New System.Drawing.Point(25, 423)
        Me.DtgTotAlic.Name = "DtgTotAlic"
        Me.DtgTotAlic.Size = New System.Drawing.Size(72, 28)
        Me.DtgTotAlic.TabIndex = 15
        Me.DtgTotAlic.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TxtTotal)
        Me.GroupBox3.Controls.Add(Me.LbTtotal)
        Me.GroupBox3.Location = New System.Drawing.Point(414, 418)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(153, 60)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        '
        'TxtTotal
        '
        Me.TxtTotal.Enabled = False
        Me.TxtTotal.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.TxtTotal.Location = New System.Drawing.Point(6, 24)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(141, 29)
        Me.TxtTotal.TabIndex = 1
        '
        'LbTtotal
        '
        Me.LbTtotal.AutoSize = True
        Me.LbTtotal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTtotal.ForeColor = System.Drawing.Color.Blue
        Me.LbTtotal.Location = New System.Drawing.Point(6, 10)
        Me.LbTtotal.Name = "LbTtotal"
        Me.LbTtotal.Size = New System.Drawing.Size(39, 14)
        Me.LbTtotal.TabIndex = 0
        Me.LbTtotal.Text = "Total :"
        '
        'FrmBusRem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 491)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.DtgTotAlic)
        Me.Controls.Add(Me.CmbUsuario)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.DtgDetRem)
        Me.Controls.Add(Me.DtgRem)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DtgDFac)
        Me.Controls.Add(Me.DtgRem1)
        Me.Controls.Add(Me.TxtBarra)
        Me.Name = "FrmBusRem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Ticket"
        CType(Me.DtgRem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtgDFac, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DtgRem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DtgDetRem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DtgTotAlic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DtgRem As System.Windows.Forms.DataGridView
    Friend WithEvents DtgDFac As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Cmdfacturar As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents TxtBarra As System.Windows.Forms.TextBox
    Friend WithEvents DtgRem1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DtcHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtcDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents LbHasta As System.Windows.Forms.Label
    Friend WithEvents LbFecha As System.Windows.Forms.Label
    Friend WithEvents DtgDetRem As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents UsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConddeVentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CmbUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnCiva As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents ContadoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CtaCteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TxtCliente As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents DtgTotAlic As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents LbTtotal As System.Windows.Forms.Label
    Friend WithEvents TxtTotal As System.Windows.Forms.TextBox
End Class
