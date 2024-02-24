<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCprecio
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
        Me.RdtMarca = New System.Windows.Forms.RadioButton
        Me.RdtProv = New System.Windows.Forms.RadioButton
        Me.RdtFam = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.CmdBus = New System.Windows.Forms.Button
        Me.TxtProv = New System.Windows.Forms.TextBox
        Me.LbNom = New System.Windows.Forms.Label
        Me.DtgArt = New System.Windows.Forms.DataGridView
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CmdGrabar = New System.Windows.Forms.Button
        Me.CmdBorrar = New System.Windows.Forms.Button
        Me.CmdPantalla = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Barra = New System.Windows.Forms.ProgressBar
        Me.Txtbarra = New System.Windows.Forms.TextBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.MskPor = New System.Windows.Forms.MaskedTextBox
        Me.LbP = New System.Windows.Forms.Label
        Me.Rdtdesc = New System.Windows.Forms.RadioButton
        Me.RdtAum = New System.Windows.Forms.RadioButton
        Me.Txtbar = New System.Windows.Forms.TextBox
        Me.MskPrecio = New System.Windows.Forms.MaskedTextBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.DtgAr = New System.Windows.Forms.DataGridView
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.TxtBar1 = New System.Windows.Forms.TextBox
        Me.LbBarra = New System.Windows.Forms.Label
        Me.TxtBarr = New System.Windows.Forms.TextBox
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.OptComandera = New System.Windows.Forms.RadioButton
        Me.OptLaser = New System.Windows.Forms.RadioButton
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DtgArt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.DtgAr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RdtMarca)
        Me.GroupBox1.Controls.Add(Me.RdtProv)
        Me.GroupBox1.Controls.Add(Me.RdtFam)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(90, 63)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CmdBus)
        Me.GroupBox2.Controls.Add(Me.TxtProv)
        Me.GroupBox2.Controls.Add(Me.LbNom)
        Me.GroupBox2.Location = New System.Drawing.Point(100, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(364, 63)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'CmdBus
        '
        Me.CmdBus.Image = Global.Super.My.Resources.Resources.Buscar
        Me.CmdBus.Location = New System.Drawing.Point(73, 15)
        Me.CmdBus.Name = "CmdBus"
        Me.CmdBus.Size = New System.Drawing.Size(66, 46)
        Me.CmdBus.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.CmdBus, "Buscar")
        Me.CmdBus.UseVisualStyleBackColor = True
        Me.CmdBus.Visible = False
        '
        'TxtProv
        '
        Me.TxtProv.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtProv.Location = New System.Drawing.Point(6, 25)
        Me.TxtProv.Name = "TxtProv"
        Me.TxtProv.Size = New System.Drawing.Size(352, 26)
        Me.TxtProv.TabIndex = 0
        '
        'LbNom
        '
        Me.LbNom.AutoSize = True
        Me.LbNom.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNom.ForeColor = System.Drawing.Color.Blue
        Me.LbNom.Location = New System.Drawing.Point(6, 10)
        Me.LbNom.Name = "LbNom"
        Me.LbNom.Size = New System.Drawing.Size(43, 14)
        Me.LbNom.TabIndex = 0
        Me.LbNom.Text = "Label1"
        '
        'DtgArt
        '
        Me.DtgArt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgArt.Location = New System.Drawing.Point(6, 75)
        Me.DtgArt.Name = "DtgArt"
        Me.DtgArt.Size = New System.Drawing.Size(790, 306)
        Me.DtgArt.TabIndex = 2
        '
        'CmdGrabar
        '
        Me.CmdGrabar.Enabled = False
        Me.CmdGrabar.Image = Global.Super.My.Resources.Resources.Modificar
        Me.CmdGrabar.Location = New System.Drawing.Point(251, 6)
        Me.CmdGrabar.Name = "CmdGrabar"
        Me.CmdGrabar.Size = New System.Drawing.Size(65, 45)
        Me.CmdGrabar.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.CmdGrabar, "Actualizar")
        Me.CmdGrabar.UseVisualStyleBackColor = True
        '
        'CmdBorrar
        '
        Me.CmdBorrar.Image = Global.Super.My.Resources.Resources.Eliminar
        Me.CmdBorrar.Location = New System.Drawing.Point(75, 8)
        Me.CmdBorrar.Name = "CmdBorrar"
        Me.CmdBorrar.Size = New System.Drawing.Size(65, 45)
        Me.CmdBorrar.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.CmdBorrar, "Vaciar Bandeja")
        Me.CmdBorrar.UseVisualStyleBackColor = True
        '
        'CmdPantalla
        '
        Me.CmdPantalla.Image = Global.Super.My.Resources.Resources.Pantalla
        Me.CmdPantalla.Location = New System.Drawing.Point(6, 8)
        Me.CmdPantalla.Name = "CmdPantalla"
        Me.CmdPantalla.Size = New System.Drawing.Size(65, 45)
        Me.CmdPantalla.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.CmdPantalla, "Imprimir Etiquetas")
        Me.CmdPantalla.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Barra)
        Me.GroupBox3.Controls.Add(Me.CmdGrabar)
        Me.GroupBox3.Location = New System.Drawing.Point(224, 387)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(320, 60)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        '
        'Barra
        '
        Me.Barra.Location = New System.Drawing.Point(6, 19)
        Me.Barra.Name = "Barra"
        Me.Barra.Size = New System.Drawing.Size(239, 27)
        Me.Barra.TabIndex = 1
        '
        'Txtbarra
        '
        Me.Txtbarra.Location = New System.Drawing.Point(22, 418)
        Me.Txtbarra.Name = "Txtbarra"
        Me.Txtbarra.Size = New System.Drawing.Size(47, 20)
        Me.Txtbarra.TabIndex = 4
        Me.Txtbarra.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.MskPor)
        Me.GroupBox4.Controls.Add(Me.LbP)
        Me.GroupBox4.Controls.Add(Me.Rdtdesc)
        Me.GroupBox4.Controls.Add(Me.RdtAum)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 387)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(178, 60)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        '
        'MskPor
        '
        Me.MskPor.Enabled = False
        Me.MskPor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskPor.Location = New System.Drawing.Point(100, 25)
        Me.MskPor.Name = "MskPor"
        Me.MskPor.Size = New System.Drawing.Size(75, 26)
        Me.MskPor.TabIndex = 3
        '
        'LbP
        '
        Me.LbP.AutoSize = True
        Me.LbP.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbP.ForeColor = System.Drawing.Color.Blue
        Me.LbP.Location = New System.Drawing.Point(100, 10)
        Me.LbP.Name = "LbP"
        Me.LbP.Size = New System.Drawing.Size(72, 14)
        Me.LbP.TabIndex = 2
        Me.LbP.Text = "Porcentaje :"
        '
        'Rdtdesc
        '
        Me.Rdtdesc.AutoSize = True
        Me.Rdtdesc.Enabled = False
        Me.Rdtdesc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rdtdesc.ForeColor = System.Drawing.Color.Blue
        Me.Rdtdesc.Location = New System.Drawing.Point(6, 36)
        Me.Rdtdesc.Name = "Rdtdesc"
        Me.Rdtdesc.Size = New System.Drawing.Size(84, 18)
        Me.Rdtdesc.TabIndex = 1
        Me.Rdtdesc.Text = "Descuento"
        Me.Rdtdesc.UseVisualStyleBackColor = True
        '
        'RdtAum
        '
        Me.RdtAum.AutoSize = True
        Me.RdtAum.Checked = True
        Me.RdtAum.Enabled = False
        Me.RdtAum.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdtAum.ForeColor = System.Drawing.Color.Blue
        Me.RdtAum.Location = New System.Drawing.Point(6, 13)
        Me.RdtAum.Name = "RdtAum"
        Me.RdtAum.Size = New System.Drawing.Size(76, 18)
        Me.RdtAum.TabIndex = 0
        Me.RdtAum.TabStop = True
        Me.RdtAum.Text = "Aumento"
        Me.RdtAum.UseVisualStyleBackColor = True
        '
        'Txtbar
        '
        Me.Txtbar.Location = New System.Drawing.Point(184, 387)
        Me.Txtbar.Name = "Txtbar"
        Me.Txtbar.Size = New System.Drawing.Size(55, 20)
        Me.Txtbar.TabIndex = 7
        Me.Txtbar.Visible = False
        '
        'MskPrecio
        '
        Me.MskPrecio.Location = New System.Drawing.Point(765, 22)
        Me.MskPrecio.Name = "MskPrecio"
        Me.MskPrecio.Size = New System.Drawing.Size(21, 20)
        Me.MskPrecio.TabIndex = 8
        Me.MskPrecio.Visible = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.CmdBorrar)
        Me.GroupBox5.Controls.Add(Me.CmdPantalla)
        Me.GroupBox5.Location = New System.Drawing.Point(550, 387)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(142, 55)
        Me.GroupBox5.TabIndex = 10
        Me.GroupBox5.TabStop = False
        '
        'DtgAr
        '
        Me.DtgAr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgAr.Location = New System.Drawing.Point(72, 251)
        Me.DtgAr.Name = "DtgAr"
        Me.DtgAr.Size = New System.Drawing.Size(646, 60)
        Me.DtgAr.TabIndex = 11
        Me.DtgAr.Visible = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.TxtBar1)
        Me.GroupBox6.Controls.Add(Me.LbBarra)
        Me.GroupBox6.Location = New System.Drawing.Point(494, 6)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(299, 63)
        Me.GroupBox6.TabIndex = 12
        Me.GroupBox6.TabStop = False
        '
        'TxtBar1
        '
        Me.TxtBar1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBar1.Location = New System.Drawing.Point(6, 24)
        Me.TxtBar1.Name = "TxtBar1"
        Me.TxtBar1.Size = New System.Drawing.Size(281, 29)
        Me.TxtBar1.TabIndex = 1
        '
        'LbBarra
        '
        Me.LbBarra.AutoSize = True
        Me.LbBarra.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbBarra.ForeColor = System.Drawing.Color.Blue
        Me.LbBarra.Location = New System.Drawing.Point(6, 10)
        Me.LbBarra.Name = "LbBarra"
        Me.LbBarra.Size = New System.Drawing.Size(56, 14)
        Me.LbBarra.TabIndex = 0
        Me.LbBarra.Text = "Articulo :"
        '
        'TxtBarr
        '
        Me.TxtBarr.Location = New System.Drawing.Point(724, 395)
        Me.TxtBarr.Name = "TxtBarr"
        Me.TxtBarr.Size = New System.Drawing.Size(69, 20)
        Me.TxtBarr.TabIndex = 13
        Me.TxtBarr.Visible = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.OptComandera)
        Me.GroupBox7.Controls.Add(Me.OptLaser)
        Me.GroupBox7.Location = New System.Drawing.Point(698, 382)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(97, 60)
        Me.GroupBox7.TabIndex = 22
        Me.GroupBox7.TabStop = False
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
        'FrmCprecio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 447)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.TxtBarr)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.MskPrecio)
        Me.Controls.Add(Me.Txtbar)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Txtbarra)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.DtgArt)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DtgAr)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCprecio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambio de Precio"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DtgArt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.DtgAr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RdtMarca As System.Windows.Forms.RadioButton
    Friend WithEvents RdtProv As System.Windows.Forms.RadioButton
    Friend WithEvents RdtFam As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LbNom As System.Windows.Forms.Label
    Friend WithEvents TxtProv As System.Windows.Forms.TextBox
    Friend WithEvents DtgArt As System.Windows.Forms.DataGridView
    Friend WithEvents CmdBus As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdGrabar As System.Windows.Forms.Button
    Friend WithEvents Barra As System.Windows.Forms.ProgressBar
    Friend WithEvents Txtbarra As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents RdtAum As System.Windows.Forms.RadioButton
    Friend WithEvents Rdtdesc As System.Windows.Forms.RadioButton
    Friend WithEvents LbP As System.Windows.Forms.Label
    Friend WithEvents MskPor As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Txtbar As System.Windows.Forms.TextBox
    Friend WithEvents MskPrecio As System.Windows.Forms.MaskedTextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdPantalla As System.Windows.Forms.Button
    Friend WithEvents CmdBorrar As System.Windows.Forms.Button
    Friend WithEvents DtgAr As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents LbBarra As System.Windows.Forms.Label
    Friend WithEvents TxtBar1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtBarr As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents OptComandera As System.Windows.Forms.RadioButton
    Friend WithEvents OptLaser As System.Windows.Forms.RadioButton
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
End Class
