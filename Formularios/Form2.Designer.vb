<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Button1 = New System.Windows.Forms.Button
        Me.DtgCli = New System.Windows.Forms.DataGridView
        Me.Lb = New System.Windows.Forms.Label
        Me.Button9 = New System.Windows.Forms.Button
        Me.Button10 = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.CmdBus = New System.Windows.Forms.Button
        Me.TxtProv = New System.Windows.Forms.TextBox
        Me.LbNom = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.RdtMarca = New System.Windows.Forms.RadioButton
        Me.RdtProv = New System.Windows.Forms.RadioButton
        Me.RdtFam = New System.Windows.Forms.RadioButton
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.CmdVaciar = New System.Windows.Forms.Button
        Me.CmdEtiqueta = New System.Windows.Forms.Button
        Me.CmdBorrar = New System.Windows.Forms.Button
        Me.Dtget = New System.Windows.Forms.DataGridView
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TxtBarra = New System.Windows.Forms.TextBox
        Me.LbBarra = New System.Windows.Forms.Label
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.OptComandera = New System.Windows.Forms.RadioButton
        Me.OptLaser = New System.Windows.Forms.RadioButton
        CType(Me.DtgCli, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.Dtget, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(448, 407)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(76, 35)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Ciudad"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'DtgCli
        '
        Me.DtgCli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgCli.Location = New System.Drawing.Point(3, 70)
        Me.DtgCli.Name = "DtgCli"
        Me.DtgCli.Size = New System.Drawing.Size(719, 325)
        Me.DtgCli.TabIndex = 10
        '
        'Lb
        '
        Me.Lb.AutoSize = True
        Me.Lb.Location = New System.Drawing.Point(91, 427)
        Me.Lb.Name = "Lb"
        Me.Lb.Size = New System.Drawing.Size(0, 13)
        Me.Lb.TabIndex = 8
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(479, 398)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(73, 34)
        Me.Button9.TabIndex = 10
        Me.Button9.Text = "N.Credito Det"
        Me.Button9.UseVisualStyleBackColor = True
        Me.Button9.Visible = False
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(480, 412)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(72, 27)
        Me.Button10.TabIndex = 11
        Me.Button10.Text = "Factura B"
        Me.Button10.UseVisualStyleBackColor = True
        Me.Button10.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CmdBus)
        Me.GroupBox2.Controls.Add(Me.TxtProv)
        Me.GroupBox2.Controls.Add(Me.LbNom)
        Me.GroupBox2.Location = New System.Drawing.Point(97, 1)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(396, 63)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        '
        'CmdBus
        '
        Me.CmdBus.Image = Global.Super.My.Resources.Resources.Buscar
        Me.CmdBus.Location = New System.Drawing.Point(329, 16)
        Me.CmdBus.Name = "CmdBus"
        Me.CmdBus.Size = New System.Drawing.Size(66, 46)
        Me.CmdBus.TabIndex = 2
        Me.CmdBus.UseVisualStyleBackColor = True
        '
        'TxtProv
        '
        Me.TxtProv.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtProv.Location = New System.Drawing.Point(6, 25)
        Me.TxtProv.Name = "TxtProv"
        Me.TxtProv.Size = New System.Drawing.Size(317, 26)
        Me.TxtProv.TabIndex = 0
        '
        'LbNom
        '
        Me.LbNom.AutoSize = True
        Me.LbNom.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNom.ForeColor = System.Drawing.Color.Blue
        Me.LbNom.Location = New System.Drawing.Point(6, 10)
        Me.LbNom.Name = "LbNom"
        Me.LbNom.Size = New System.Drawing.Size(51, 14)
        Me.LbNom.TabIndex = 0
        Me.LbNom.Text = "Familia :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RdtMarca)
        Me.GroupBox3.Controls.Add(Me.RdtProv)
        Me.GroupBox3.Controls.Add(Me.RdtFam)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(90, 63)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        '
        'RdtMarca
        '
        Me.RdtMarca.AutoSize = True
        Me.RdtMarca.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdtMarca.ForeColor = System.Drawing.Color.Blue
        Me.RdtMarca.Location = New System.Drawing.Point(6, 27)
        Me.RdtMarca.Name = "RdtMarca"
        Me.RdtMarca.Size = New System.Drawing.Size(58, 18)
        Me.RdtMarca.TabIndex = 1
        Me.RdtMarca.Text = "Marca"
        Me.RdtMarca.UseVisualStyleBackColor = True
        '
        'RdtProv
        '
        Me.RdtProv.AutoSize = True
        Me.RdtProv.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdtProv.ForeColor = System.Drawing.Color.Blue
        Me.RdtProv.Location = New System.Drawing.Point(6, 44)
        Me.RdtProv.Name = "RdtProv"
        Me.RdtProv.Size = New System.Drawing.Size(83, 18)
        Me.RdtProv.TabIndex = 2
        Me.RdtProv.Text = "Proveedor"
        Me.RdtProv.UseVisualStyleBackColor = True
        '
        'RdtFam
        '
        Me.RdtFam.AutoSize = True
        Me.RdtFam.Checked = True
        Me.RdtFam.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdtFam.ForeColor = System.Drawing.Color.Blue
        Me.RdtFam.Location = New System.Drawing.Point(6, 10)
        Me.RdtFam.Name = "RdtFam"
        Me.RdtFam.Size = New System.Drawing.Size(63, 18)
        Me.RdtFam.TabIndex = 0
        Me.RdtFam.TabStop = True
        Me.RdtFam.Text = "Familia"
        Me.RdtFam.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox4.Controls.Add(Me.CmdVaciar)
        Me.GroupBox4.Controls.Add(Me.CmdEtiqueta)
        Me.GroupBox4.Controls.Add(Me.CmdBorrar)
        Me.GroupBox4.Location = New System.Drawing.Point(398, 401)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(215, 60)
        Me.GroupBox4.TabIndex = 16
        Me.GroupBox4.TabStop = False
        '
        'CmdVaciar
        '
        Me.CmdVaciar.Image = Global.Super.My.Resources.Resources.Eliminar
        Me.CmdVaciar.Location = New System.Drawing.Point(148, 9)
        Me.CmdVaciar.Name = "CmdVaciar"
        Me.CmdVaciar.Size = New System.Drawing.Size(65, 45)
        Me.CmdVaciar.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.CmdVaciar, "Vaciar Bandeja de Etiquetas")
        Me.CmdVaciar.UseVisualStyleBackColor = True
        '
        'CmdEtiqueta
        '
        Me.CmdEtiqueta.Enabled = False
        Me.CmdEtiqueta.Image = Global.Super.My.Resources.Resources.saldos
        Me.CmdEtiqueta.Location = New System.Drawing.Point(6, 11)
        Me.CmdEtiqueta.Name = "CmdEtiqueta"
        Me.CmdEtiqueta.Size = New System.Drawing.Size(65, 45)
        Me.CmdEtiqueta.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.CmdEtiqueta, "Cargar Etiquetas")
        Me.CmdEtiqueta.UseVisualStyleBackColor = True
        '
        'CmdBorrar
        '
        Me.CmdBorrar.Image = Global.Super.My.Resources.Resources.Modificar
        Me.CmdBorrar.Location = New System.Drawing.Point(77, 9)
        Me.CmdBorrar.Name = "CmdBorrar"
        Me.CmdBorrar.Size = New System.Drawing.Size(65, 45)
        Me.CmdBorrar.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.CmdBorrar, "Imprimir Etiquetas")
        Me.CmdBorrar.UseVisualStyleBackColor = True
        '
        'Dtget
        '
        Me.Dtget.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dtget.Location = New System.Drawing.Point(19, 412)
        Me.Dtget.Name = "Dtget"
        Me.Dtget.Size = New System.Drawing.Size(66, 57)
        Me.Dtget.TabIndex = 17
        Me.Dtget.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtBarra)
        Me.GroupBox1.Controls.Add(Me.LbBarra)
        Me.GroupBox1.Location = New System.Drawing.Point(514, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(207, 63)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        '
        'TxtBarra
        '
        Me.TxtBarra.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBarra.Location = New System.Drawing.Point(6, 24)
        Me.TxtBarra.Name = "TxtBarra"
        Me.TxtBarra.Size = New System.Drawing.Size(197, 29)
        Me.TxtBarra.TabIndex = 0
        '
        'LbBarra
        '
        Me.LbBarra.AutoSize = True
        Me.LbBarra.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbBarra.ForeColor = System.Drawing.Color.Blue
        Me.LbBarra.Location = New System.Drawing.Point(6, 10)
        Me.LbBarra.Name = "LbBarra"
        Me.LbBarra.Size = New System.Drawing.Size(42, 14)
        Me.LbBarra.TabIndex = 0
        Me.LbBarra.Text = "Barra :"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.OptComandera)
        Me.GroupBox5.Controls.Add(Me.OptLaser)
        Me.GroupBox5.Location = New System.Drawing.Point(619, 401)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(97, 60)
        Me.GroupBox5.TabIndex = 19
        Me.GroupBox5.TabStop = False
        '
        'OptComandera
        '
        Me.OptComandera.AutoSize = True
        Me.OptComandera.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptComandera.ForeColor = System.Drawing.Color.Blue
        Me.OptComandera.Location = New System.Drawing.Point(6, 30)
        Me.OptComandera.Name = "OptComandera"
        Me.OptComandera.Size = New System.Drawing.Size(89, 18)
        Me.OptComandera.TabIndex = 1
        Me.OptComandera.Text = "Comandera"
        Me.OptComandera.UseVisualStyleBackColor = True
        '
        'OptLaser
        '
        Me.OptLaser.AutoSize = True
        Me.OptLaser.Checked = True
        Me.OptLaser.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptLaser.ForeColor = System.Drawing.Color.Blue
        Me.OptLaser.Location = New System.Drawing.Point(6, 10)
        Me.OptLaser.Name = "OptLaser"
        Me.OptLaser.Size = New System.Drawing.Size(57, 18)
        Me.OptLaser.TabIndex = 0
        Me.OptLaser.TabStop = True
        Me.OptLaser.Text = "Laser"
        Me.OptLaser.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(727, 467)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Dtget)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Lb)
        Me.Controls.Add(Me.DtgCli)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Etiquetas"
        CType(Me.DtgCli, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.Dtget, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DtgCli As System.Windows.Forms.DataGridView
    Friend WithEvents Lb As System.Windows.Forms.Label
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdBus As System.Windows.Forms.Button
    Friend WithEvents TxtProv As System.Windows.Forms.TextBox
    Friend WithEvents LbNom As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RdtMarca As System.Windows.Forms.RadioButton
    Friend WithEvents RdtProv As System.Windows.Forms.RadioButton
    Friend WithEvents RdtFam As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdBorrar As System.Windows.Forms.Button
    Friend WithEvents CmdEtiqueta As System.Windows.Forms.Button
    Friend WithEvents Dtget As System.Windows.Forms.DataGridView
    Friend WithEvents CmdVaciar As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LbBarra As System.Windows.Forms.Label
    Friend WithEvents TxtBarra As System.Windows.Forms.TextBox
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents OptComandera As System.Windows.Forms.RadioButton
    Friend WithEvents OptLaser As System.Windows.Forms.RadioButton
End Class
