<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCuotas
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
        Me.TxtCiva = New System.Windows.Forms.TextBox
        Me.MskFecha = New System.Windows.Forms.MaskedTextBox
        Me.Lbfecha = New System.Windows.Forms.Label
        Me.CmdbusCli = New System.Windows.Forms.Button
        Me.TxtCiu = New System.Windows.Forms.TextBox
        Me.LbCiu = New System.Windows.Forms.Label
        Me.txtDirec = New System.Windows.Forms.TextBox
        Me.LbDirec = New System.Windows.Forms.Label
        Me.TxtCuit = New System.Windows.Forms.TextBox
        Me.LbCuit = New System.Windows.Forms.Label
        Me.TxtCli = New System.Windows.Forms.TextBox
        Me.LbCl = New System.Windows.Forms.Label
        Me.DtgCuotas = New System.Windows.Forms.DataGridView
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.MskTotal = New System.Windows.Forms.MaskedTextBox
        Me.LbTotal = New System.Windows.Forms.Label
        Me.LbEntrega = New System.Windows.Forms.Label
        Me.MskEntrega = New System.Windows.Forms.MaskedTextBox
        Me.CmdPagar = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.DtgCuotas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtCiva)
        Me.GroupBox1.Controls.Add(Me.MskFecha)
        Me.GroupBox1.Controls.Add(Me.Lbfecha)
        Me.GroupBox1.Controls.Add(Me.CmdbusCli)
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
        Me.GroupBox1.Size = New System.Drawing.Size(626, 109)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'TxtCiva
        '
        Me.TxtCiva.Location = New System.Drawing.Point(553, 32)
        Me.TxtCiva.Name = "TxtCiva"
        Me.TxtCiva.Size = New System.Drawing.Size(59, 20)
        Me.TxtCiva.TabIndex = 11
        Me.TxtCiva.Visible = False
        '
        'MskFecha
        '
        Me.MskFecha.Enabled = False
        Me.MskFecha.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskFecha.Location = New System.Drawing.Point(528, 75)
        Me.MskFecha.Mask = "##/##/####"
        Me.MskFecha.Name = "MskFecha"
        Me.MskFecha.Size = New System.Drawing.Size(95, 26)
        Me.MskFecha.TabIndex = 10
        '
        'Lbfecha
        '
        Me.Lbfecha.AutoSize = True
        Me.Lbfecha.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbfecha.ForeColor = System.Drawing.Color.Blue
        Me.Lbfecha.Location = New System.Drawing.Point(528, 61)
        Me.Lbfecha.Name = "Lbfecha"
        Me.Lbfecha.Size = New System.Drawing.Size(45, 14)
        Me.Lbfecha.TabIndex = 9
        Me.Lbfecha.Text = "Fecha :"
        '
        'CmdbusCli
        '
        Me.CmdbusCli.Image = Global.Super.My.Resources.Resources.Buscar
        Me.CmdbusCli.Location = New System.Drawing.Point(480, 13)
        Me.CmdbusCli.Name = "CmdbusCli"
        Me.CmdbusCli.Size = New System.Drawing.Size(65, 45)
        Me.CmdbusCli.TabIndex = 8
        Me.CmdbusCli.UseVisualStyleBackColor = True
        '
        'TxtCiu
        '
        Me.TxtCiu.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCiu.Location = New System.Drawing.Point(273, 75)
        Me.TxtCiu.Name = "TxtCiu"
        Me.TxtCiu.Size = New System.Drawing.Size(253, 26)
        Me.TxtCiu.TabIndex = 7
        '
        'LbCiu
        '
        Me.LbCiu.AutoSize = True
        Me.LbCiu.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCiu.ForeColor = System.Drawing.Color.Blue
        Me.LbCiu.Location = New System.Drawing.Point(273, 60)
        Me.LbCiu.Name = "LbCiu"
        Me.LbCiu.Size = New System.Drawing.Size(51, 14)
        Me.LbCiu.TabIndex = 6
        Me.LbCiu.Text = "Ciudad :"
        '
        'txtDirec
        '
        Me.txtDirec.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDirec.Location = New System.Drawing.Point(6, 75)
        Me.txtDirec.Name = "txtDirec"
        Me.txtDirec.Size = New System.Drawing.Size(264, 26)
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
        'TxtCli
        '
        Me.TxtCli.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCli.Location = New System.Drawing.Point(6, 30)
        Me.TxtCli.Name = "TxtCli"
        Me.TxtCli.Size = New System.Drawing.Size(333, 26)
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
        'DtgCuotas
        '
        Me.DtgCuotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgCuotas.Location = New System.Drawing.Point(6, 125)
        Me.DtgCuotas.Name = "DtgCuotas"
        Me.DtgCuotas.Size = New System.Drawing.Size(626, 163)
        Me.DtgCuotas.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.MskTotal)
        Me.GroupBox2.Controls.Add(Me.LbTotal)
        Me.GroupBox2.Controls.Add(Me.LbEntrega)
        Me.GroupBox2.Controls.Add(Me.MskEntrega)
        Me.GroupBox2.Controls.Add(Me.CmdPagar)
        Me.GroupBox2.Location = New System.Drawing.Point(301, 299)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(326, 57)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'MskTotal
        '
        Me.MskTotal.Enabled = False
        Me.MskTotal.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskTotal.Location = New System.Drawing.Point(195, 26)
        Me.MskTotal.Name = "MskTotal"
        Me.MskTotal.Size = New System.Drawing.Size(119, 26)
        Me.MskTotal.TabIndex = 4
        '
        'LbTotal
        '
        Me.LbTotal.AutoSize = True
        Me.LbTotal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTotal.ForeColor = System.Drawing.Color.Blue
        Me.LbTotal.Location = New System.Drawing.Point(195, 10)
        Me.LbTotal.Name = "LbTotal"
        Me.LbTotal.Size = New System.Drawing.Size(39, 14)
        Me.LbTotal.TabIndex = 3
        Me.LbTotal.Text = "Total :"
        '
        'LbEntrega
        '
        Me.LbEntrega.AutoSize = True
        Me.LbEntrega.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbEntrega.ForeColor = System.Drawing.Color.Blue
        Me.LbEntrega.Location = New System.Drawing.Point(75, 10)
        Me.LbEntrega.Name = "LbEntrega"
        Me.LbEntrega.Size = New System.Drawing.Size(55, 14)
        Me.LbEntrega.TabIndex = 2
        Me.LbEntrega.Text = "Entrega :"
        '
        'MskEntrega
        '
        Me.MskEntrega.Enabled = False
        Me.MskEntrega.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskEntrega.Location = New System.Drawing.Point(75, 26)
        Me.MskEntrega.Name = "MskEntrega"
        Me.MskEntrega.Size = New System.Drawing.Size(114, 26)
        Me.MskEntrega.TabIndex = 1
        '
        'CmdPagar
        '
        Me.CmdPagar.Image = Global.Super.My.Resources.Resources.cash_register
        Me.CmdPagar.Location = New System.Drawing.Point(6, 10)
        Me.CmdPagar.Name = "CmdPagar"
        Me.CmdPagar.Size = New System.Drawing.Size(65, 45)
        Me.CmdPagar.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.CmdPagar, "Grabar Pago")
        Me.CmdPagar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(220, 315)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 32)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmCuotas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 368)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DtgCuotas)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmCuotas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cuotas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DtgCuotas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtCiva As System.Windows.Forms.TextBox
    Friend WithEvents MskFecha As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Lbfecha As System.Windows.Forms.Label
    Friend WithEvents CmdbusCli As System.Windows.Forms.Button
    Friend WithEvents TxtCiu As System.Windows.Forms.TextBox
    Friend WithEvents LbCiu As System.Windows.Forms.Label
    Friend WithEvents txtDirec As System.Windows.Forms.TextBox
    Friend WithEvents LbDirec As System.Windows.Forms.Label
    Friend WithEvents TxtCuit As System.Windows.Forms.TextBox
    Friend WithEvents LbCuit As System.Windows.Forms.Label
    Friend WithEvents TxtCli As System.Windows.Forms.TextBox
    Friend WithEvents LbCl As System.Windows.Forms.Label
    Friend WithEvents DtgCuotas As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdPagar As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents LbEntrega As System.Windows.Forms.Label
    Friend WithEvents MskEntrega As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents LbTotal As System.Windows.Forms.Label
    Friend WithEvents MskTotal As System.Windows.Forms.MaskedTextBox
End Class
