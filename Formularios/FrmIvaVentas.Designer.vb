<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIvaVentas
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
        Me.DtcHasta = New System.Windows.Forms.DateTimePicker
        Me.DtcDesde = New System.Windows.Forms.DateTimePicker
        Me.LbHasta = New System.Windows.Forms.Label
        Me.LbFecha = New System.Windows.Forms.Label
        Me.DtgDetIva = New System.Windows.Forms.DataGridView
        Me.DtgIva = New System.Windows.Forms.DataGridView
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.CmdVenAlic = New System.Windows.Forms.Button
        Me.CmdCiva = New System.Windows.Forms.Button
        Me.CmPantalla = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.DtgDet = New System.Windows.Forms.DataGridView
        Me.CmdAlicIva = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.DtgAlic = New System.Windows.Forms.DataGridView
        Me.GroupBox1.SuspendLayout()
        CType(Me.DtgDetIva, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtgIva, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DtgDet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtgAlic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DtcHasta)
        Me.GroupBox1.Controls.Add(Me.DtcDesde)
        Me.GroupBox1.Controls.Add(Me.LbHasta)
        Me.GroupBox1.Controls.Add(Me.LbFecha)
        Me.GroupBox1.Controls.Add(Me.DtgDetIva)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(224, 55)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
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
        'DtgDetIva
        '
        Me.DtgDetIva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgDetIva.Location = New System.Drawing.Point(115, 7)
        Me.DtgDetIva.Name = "DtgDetIva"
        Me.DtgDetIva.Size = New System.Drawing.Size(88, 42)
        Me.DtgDetIva.TabIndex = 5
        Me.DtgDetIva.Visible = False
        '
        'DtgIva
        '
        Me.DtgIva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgIva.Location = New System.Drawing.Point(3, 1)
        Me.DtgIva.Name = "DtgIva"
        Me.DtgIva.Size = New System.Drawing.Size(151, 54)
        Me.DtgIva.TabIndex = 1
        Me.DtgIva.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CmdVenAlic)
        Me.GroupBox2.Controls.Add(Me.CmdCiva)
        Me.GroupBox2.Controls.Add(Me.CmPantalla)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.DtgDet)
        Me.GroupBox2.Controls.Add(Me.CmdAlicIva)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 60)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(221, 60)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'CmdVenAlic
        '
        Me.CmdVenAlic.Image = Global.Super.My.Resources.Resources.saldos
        Me.CmdVenAlic.Location = New System.Drawing.Point(75, 8)
        Me.CmdVenAlic.Name = "CmdVenAlic"
        Me.CmdVenAlic.Size = New System.Drawing.Size(71, 48)
        Me.CmdVenAlic.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.CmdVenAlic, "Ventas por Alicuota")
        Me.CmdVenAlic.UseVisualStyleBackColor = True
        '
        'CmdCiva
        '
        Me.CmdCiva.Image = Global.Super.My.Resources.Resources._01_Excel
        Me.CmdCiva.Location = New System.Drawing.Point(146, 8)
        Me.CmdCiva.Name = "CmdCiva"
        Me.CmdCiva.Size = New System.Drawing.Size(71, 48)
        Me.CmdCiva.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.CmdCiva, "Exportar a Holistor")
        Me.CmdCiva.UseVisualStyleBackColor = True
        '
        'CmPantalla
        '
        Me.CmPantalla.Image = Global.Super.My.Resources.Resources.Pantalla
        Me.CmPantalla.Location = New System.Drawing.Point(3, 8)
        Me.CmPantalla.Name = "CmPantalla"
        Me.CmPantalla.Size = New System.Drawing.Size(71, 48)
        Me.CmPantalla.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.CmPantalla, "Ver Libro de Iva Ventas")
        Me.CmPantalla.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(6, 15)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(65, 41)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'DtgDet
        '
        Me.DtgDet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgDet.Location = New System.Drawing.Point(-3, 0)
        Me.DtgDet.Name = "DtgDet"
        Me.DtgDet.Size = New System.Drawing.Size(224, 49)
        Me.DtgDet.TabIndex = 4
        Me.DtgDet.Visible = False
        '
        'CmdAlicIva
        '
        Me.CmdAlicIva.Location = New System.Drawing.Point(152, 7)
        Me.CmdAlicIva.Name = "CmdAlicIva"
        Me.CmdAlicIva.Size = New System.Drawing.Size(54, 47)
        Me.CmdAlicIva.TabIndex = 4
        Me.CmdAlicIva.Text = "Iva"
        Me.CmdAlicIva.UseVisualStyleBackColor = True
        Me.CmdAlicIva.Visible = False
        '
        'DtgAlic
        '
        Me.DtgAlic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgAlic.Location = New System.Drawing.Point(244, 14)
        Me.DtgAlic.Name = "DtgAlic"
        Me.DtgAlic.Size = New System.Drawing.Size(261, 94)
        Me.DtgAlic.TabIndex = 4
        '
        'FrmIvaVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 122)
        Me.Controls.Add(Me.DtgAlic)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DtgIva)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmIvaVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Iva Ventas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DtgDetIva, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtgIva, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DtgDet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtgAlic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LbFecha As System.Windows.Forms.Label
    Friend WithEvents DtgIva As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CmPantalla As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents CmdCiva As System.Windows.Forms.Button
    Friend WithEvents LbHasta As System.Windows.Forms.Label
    Friend WithEvents DtcDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtcHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents CmdVenAlic As System.Windows.Forms.Button
    Friend WithEvents DtgDet As System.Windows.Forms.DataGridView
    Friend WithEvents CmdAlicIva As System.Windows.Forms.Button
    Friend WithEvents DtgDetIva As System.Windows.Forms.DataGridView
    Friend WithEvents DtgAlic As System.Windows.Forms.DataGridView
End Class
