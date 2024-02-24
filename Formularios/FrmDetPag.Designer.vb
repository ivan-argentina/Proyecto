<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDetPag
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.CmdCh = New System.Windows.Forms.Button
        Me.CmdEfec = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.MskEnt = New System.Windows.Forms.MaskedTextBox
        Me.LbNumero = New System.Windows.Forms.Label
        Me.LbComp = New System.Windows.Forms.Label
        Me.TxtNum = New System.Windows.Forms.TextBox
        Me.TxtComp = New System.Windows.Forms.TextBox
        Me.LbEntrega = New System.Windows.Forms.Label
        Me.DtgPag = New System.Windows.Forms.DataGridView
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DtgPag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.CmdCh)
        Me.GroupBox4.Controls.Add(Me.CmdEfec)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 10)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(83, 92)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        '
        'CmdCh
        '
        Me.CmdCh.Image = Global.Super.My.Resources.Resources.cheque
        Me.CmdCh.Location = New System.Drawing.Point(6, 50)
        Me.CmdCh.Name = "CmdCh"
        Me.CmdCh.Size = New System.Drawing.Size(70, 38)
        Me.CmdCh.TabIndex = 1
        Me.CmdCh.UseVisualStyleBackColor = True
        '
        'CmdEfec
        '
        Me.CmdEfec.Image = Global.Super.My.Resources.Resources.efectivo
        Me.CmdEfec.Location = New System.Drawing.Point(6, 10)
        Me.CmdEfec.Name = "CmdEfec"
        Me.CmdEfec.Size = New System.Drawing.Size(70, 38)
        Me.CmdEfec.TabIndex = 0
        Me.CmdEfec.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.MskEnt)
        Me.GroupBox3.Controls.Add(Me.LbNumero)
        Me.GroupBox3.Controls.Add(Me.LbComp)
        Me.GroupBox3.Controls.Add(Me.TxtNum)
        Me.GroupBox3.Controls.Add(Me.TxtComp)
        Me.GroupBox3.Controls.Add(Me.LbEntrega)
        Me.GroupBox3.Location = New System.Drawing.Point(90, 10)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(350, 56)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        '
        'MskEnt
        '
        Me.MskEnt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskEnt.Location = New System.Drawing.Point(246, 25)
        Me.MskEnt.Name = "MskEnt"
        Me.MskEnt.Size = New System.Drawing.Size(100, 26)
        Me.MskEnt.TabIndex = 10
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
        Me.TxtNum.Location = New System.Drawing.Point(146, 25)
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
        Me.TxtComp.Size = New System.Drawing.Size(137, 26)
        Me.TxtComp.TabIndex = 6
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
        'DtgPag
        '
        Me.DtgPag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgPag.Location = New System.Drawing.Point(90, 72)
        Me.DtgPag.Name = "DtgPag"
        Me.DtgPag.Size = New System.Drawing.Size(350, 106)
        Me.DtgPag.TabIndex = 8
        '
        'FrmDetPag
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 182)
        Me.Controls.Add(Me.DtgPag)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Name = "FrmDetPag"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle de Pago"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DtgPag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdCh As System.Windows.Forms.Button
    Friend WithEvents CmdEfec As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents MskEnt As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LbNumero As System.Windows.Forms.Label
    Friend WithEvents LbComp As System.Windows.Forms.Label
    Friend WithEvents TxtNum As System.Windows.Forms.TextBox
    Friend WithEvents TxtComp As System.Windows.Forms.TextBox
    Friend WithEvents LbEntrega As System.Windows.Forms.Label
    Friend WithEvents DtgPag As System.Windows.Forms.DataGridView
End Class
