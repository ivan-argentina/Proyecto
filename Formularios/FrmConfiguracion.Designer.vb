<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConfiguracion
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
        Me.CmdAct = New System.Windows.Forms.Button
        Me.MskInt = New System.Windows.Forms.MaskedTextBox
        Me.LbIntereses = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CmdObtener = New System.Windows.Forms.Button
        Me.CmdMandar = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.LbLinea = New System.Windows.Forms.Label
        Me.CmbLinea = New System.Windows.Forms.ComboBox
        Me.TxtCola = New System.Windows.Forms.TextBox
        Me.LbCola = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CmdAct)
        Me.GroupBox1.Controls.Add(Me.MskInt)
        Me.GroupBox1.Controls.Add(Me.LbIntereses)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(160, 58)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'CmdAct
        '
        Me.CmdAct.Image = Global.Super.My.Resources.Resources.Modificar
        Me.CmdAct.Location = New System.Drawing.Point(93, 10)
        Me.CmdAct.Name = "CmdAct"
        Me.CmdAct.Size = New System.Drawing.Size(65, 45)
        Me.CmdAct.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.CmdAct, "Actualizar Intereses")
        Me.CmdAct.UseVisualStyleBackColor = True
        '
        'MskInt
        '
        Me.MskInt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskInt.Location = New System.Drawing.Point(6, 25)
        Me.MskInt.Name = "MskInt"
        Me.MskInt.Size = New System.Drawing.Size(80, 26)
        Me.MskInt.TabIndex = 1
        '
        'LbIntereses
        '
        Me.LbIntereses.AutoSize = True
        Me.LbIntereses.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbIntereses.ForeColor = System.Drawing.Color.Blue
        Me.LbIntereses.Location = New System.Drawing.Point(6, 10)
        Me.LbIntereses.Name = "LbIntereses"
        Me.LbIntereses.Size = New System.Drawing.Size(67, 14)
        Me.LbIntereses.TabIndex = 0
        Me.LbIntereses.Text = "Intereses :"
        '
        'CmdObtener
        '
        Me.CmdObtener.Image = Global.Super.My.Resources.Resources.back
        Me.CmdObtener.Location = New System.Drawing.Point(6, 10)
        Me.CmdObtener.Name = "CmdObtener"
        Me.CmdObtener.Size = New System.Drawing.Size(65, 45)
        Me.CmdObtener.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.CmdObtener, "Obtener Cola")
        Me.CmdObtener.UseVisualStyleBackColor = True
        '
        'CmdMandar
        '
        Me.CmdMandar.Image = Global.Super.My.Resources.Resources.go
        Me.CmdMandar.Location = New System.Drawing.Point(77, 10)
        Me.CmdMandar.Name = "CmdMandar"
        Me.CmdMandar.Size = New System.Drawing.Size(65, 45)
        Me.CmdMandar.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.CmdMandar, "Mandar Cola")
        Me.CmdMandar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LbLinea)
        Me.GroupBox2.Controls.Add(Me.CmbLinea)
        Me.GroupBox2.Controls.Add(Me.TxtCola)
        Me.GroupBox2.Controls.Add(Me.LbCola)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 70)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(446, 65)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'LbLinea
        '
        Me.LbLinea.AutoSize = True
        Me.LbLinea.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbLinea.ForeColor = System.Drawing.Color.Blue
        Me.LbLinea.Location = New System.Drawing.Point(6, 10)
        Me.LbLinea.Name = "LbLinea"
        Me.LbLinea.Size = New System.Drawing.Size(43, 14)
        Me.LbLinea.TabIndex = 5
        Me.LbLinea.Text = "Linea :"
        '
        'CmbLinea
        '
        Me.CmbLinea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbLinea.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbLinea.FormattingEnabled = True
        Me.CmbLinea.Items.AddRange(New Object() {"13", "14"})
        Me.CmbLinea.Location = New System.Drawing.Point(6, 25)
        Me.CmbLinea.Name = "CmbLinea"
        Me.CmbLinea.Size = New System.Drawing.Size(53, 26)
        Me.CmbLinea.TabIndex = 4
        '
        'TxtCola
        '
        Me.TxtCola.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCola.Location = New System.Drawing.Point(62, 25)
        Me.TxtCola.MaxLength = 50
        Me.TxtCola.Name = "TxtCola"
        Me.TxtCola.Size = New System.Drawing.Size(378, 26)
        Me.TxtCola.TabIndex = 1
        '
        'LbCola
        '
        Me.LbCola.AutoSize = True
        Me.LbCola.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCola.ForeColor = System.Drawing.Color.Blue
        Me.LbCola.Location = New System.Drawing.Point(62, 10)
        Me.LbCola.Name = "LbCola"
        Me.LbCola.Size = New System.Drawing.Size(97, 14)
        Me.LbCola.TabIndex = 0
        Me.LbCola.Text = "Cola de Factura :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CmdMandar)
        Me.GroupBox3.Controls.Add(Me.CmdObtener)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 141)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(150, 61)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'FrmConfiguracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 208)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmConfiguracion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuracion"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LbIntereses As System.Windows.Forms.Label
    Friend WithEvents MskInt As System.Windows.Forms.MaskedTextBox
    Friend WithEvents CmdAct As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LbCola As System.Windows.Forms.Label
    Friend WithEvents TxtCola As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdObtener As System.Windows.Forms.Button
    Friend WithEvents CmdMandar As System.Windows.Forms.Button
    Friend WithEvents CmbLinea As System.Windows.Forms.ComboBox
    Friend WithEvents LbLinea As System.Windows.Forms.Label
End Class
