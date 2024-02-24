<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInProv
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
        Me.CmdBuscar = New System.Windows.Forms.Button
        Me.TxtCiva = New System.Windows.Forms.TextBox
        Me.LbCciva = New System.Windows.Forms.Label
        Me.TxtCciu = New System.Windows.Forms.TextBox
        Me.LbCciu = New System.Windows.Forms.Label
        Me.TxtEmail = New System.Windows.Forms.TextBox
        Me.LbEmail = New System.Windows.Forms.Label
        Me.TxtCel = New System.Windows.Forms.TextBox
        Me.LbCel = New System.Windows.Forms.Label
        Me.TxtTel = New System.Windows.Forms.TextBox
        Me.LbTel = New System.Windows.Forms.Label
        Me.TxtIva = New System.Windows.Forms.TextBox
        Me.LbCIva = New System.Windows.Forms.Label
        Me.TxtCiu = New System.Windows.Forms.TextBox
        Me.LbCiudad = New System.Windows.Forms.Label
        Me.MskCuit = New System.Windows.Forms.MaskedTextBox
        Me.LbCuit = New System.Windows.Forms.Label
        Me.txtDir = New System.Windows.Forms.TextBox
        Me.LbDir = New System.Windows.Forms.Label
        Me.TxtProv = New System.Windows.Forms.TextBox
        Me.LbProv = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.CmdEliminar = New System.Windows.Forms.Button
        Me.CmdModificar = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CmdBuscar)
        Me.GroupBox1.Controls.Add(Me.TxtCiva)
        Me.GroupBox1.Controls.Add(Me.LbCciva)
        Me.GroupBox1.Controls.Add(Me.TxtCciu)
        Me.GroupBox1.Controls.Add(Me.LbCciu)
        Me.GroupBox1.Controls.Add(Me.TxtEmail)
        Me.GroupBox1.Controls.Add(Me.LbEmail)
        Me.GroupBox1.Controls.Add(Me.TxtCel)
        Me.GroupBox1.Controls.Add(Me.LbCel)
        Me.GroupBox1.Controls.Add(Me.TxtTel)
        Me.GroupBox1.Controls.Add(Me.LbTel)
        Me.GroupBox1.Controls.Add(Me.TxtIva)
        Me.GroupBox1.Controls.Add(Me.LbCIva)
        Me.GroupBox1.Controls.Add(Me.TxtCiu)
        Me.GroupBox1.Controls.Add(Me.LbCiudad)
        Me.GroupBox1.Controls.Add(Me.MskCuit)
        Me.GroupBox1.Controls.Add(Me.LbCuit)
        Me.GroupBox1.Controls.Add(Me.txtDir)
        Me.GroupBox1.Controls.Add(Me.LbDir)
        Me.GroupBox1.Controls.Add(Me.TxtProv)
        Me.GroupBox1.Controls.Add(Me.LbProv)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(686, 206)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'CmdBuscar
        '
        Me.CmdBuscar.Image = Global.Super.My.Resources.Resources.Buscar
        Me.CmdBuscar.Location = New System.Drawing.Point(318, 13)
        Me.CmdBuscar.Name = "CmdBuscar"
        Me.CmdBuscar.Size = New System.Drawing.Size(65, 45)
        Me.CmdBuscar.TabIndex = 19
        Me.ToolTip1.SetToolTip(Me.CmdBuscar, "Buscar Un Proveedor")
        Me.CmdBuscar.UseVisualStyleBackColor = True
        '
        'TxtCiva
        '
        Me.TxtCiva.Enabled = False
        Me.TxtCiva.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCiva.Location = New System.Drawing.Point(6, 119)
        Me.TxtCiva.Name = "TxtCiva"
        Me.TxtCiva.Size = New System.Drawing.Size(66, 26)
        Me.TxtCiva.TabIndex = 18
        '
        'LbCciva
        '
        Me.LbCciva.AutoSize = True
        Me.LbCciva.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCciva.ForeColor = System.Drawing.Color.Blue
        Me.LbCciva.Location = New System.Drawing.Point(6, 105)
        Me.LbCciva.Name = "LbCciva"
        Me.LbCciva.Size = New System.Drawing.Size(52, 14)
        Me.LbCciva.TabIndex = 17
        Me.LbCciva.Text = "Codigo :"
        '
        'TxtCciu
        '
        Me.TxtCciu.Enabled = False
        Me.TxtCciu.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCciu.Location = New System.Drawing.Point(389, 26)
        Me.TxtCciu.Name = "TxtCciu"
        Me.TxtCciu.Size = New System.Drawing.Size(66, 26)
        Me.TxtCciu.TabIndex = 16
        '
        'LbCciu
        '
        Me.LbCciu.AutoSize = True
        Me.LbCciu.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCciu.ForeColor = System.Drawing.Color.Blue
        Me.LbCciu.Location = New System.Drawing.Point(389, 11)
        Me.LbCciu.Name = "LbCciu"
        Me.LbCciu.Size = New System.Drawing.Size(52, 14)
        Me.LbCciu.TabIndex = 15
        Me.LbCciu.Text = "Codigo :"
        '
        'TxtEmail
        '
        Me.TxtEmail.Enabled = False
        Me.TxtEmail.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmail.Location = New System.Drawing.Point(360, 75)
        Me.TxtEmail.MaxLength = 50
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(320, 26)
        Me.TxtEmail.TabIndex = 5
        '
        'LbEmail
        '
        Me.LbEmail.AutoSize = True
        Me.LbEmail.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbEmail.ForeColor = System.Drawing.Color.Blue
        Me.LbEmail.Location = New System.Drawing.Point(360, 60)
        Me.LbEmail.Name = "LbEmail"
        Me.LbEmail.Size = New System.Drawing.Size(42, 14)
        Me.LbEmail.TabIndex = 13
        Me.LbEmail.Text = "Email :"
        '
        'TxtCel
        '
        Me.TxtCel.Enabled = False
        Me.TxtCel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCel.Location = New System.Drawing.Point(360, 170)
        Me.TxtCel.MaxLength = 20
        Me.TxtCel.Name = "TxtCel"
        Me.TxtCel.Size = New System.Drawing.Size(261, 26)
        Me.TxtCel.TabIndex = 7
        '
        'LbCel
        '
        Me.LbCel.AutoSize = True
        Me.LbCel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCel.ForeColor = System.Drawing.Color.Blue
        Me.LbCel.Location = New System.Drawing.Point(360, 156)
        Me.LbCel.Name = "LbCel"
        Me.LbCel.Size = New System.Drawing.Size(52, 14)
        Me.LbCel.TabIndex = 11
        Me.LbCel.Text = "Celular :"
        '
        'TxtTel
        '
        Me.TxtTel.Enabled = False
        Me.TxtTel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTel.Location = New System.Drawing.Point(360, 119)
        Me.TxtTel.MaxLength = 20
        Me.TxtTel.Name = "TxtTel"
        Me.TxtTel.Size = New System.Drawing.Size(261, 26)
        Me.TxtTel.TabIndex = 6
        '
        'LbTel
        '
        Me.LbTel.AutoSize = True
        Me.LbTel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTel.ForeColor = System.Drawing.Color.Blue
        Me.LbTel.Location = New System.Drawing.Point(360, 105)
        Me.LbTel.Name = "LbTel"
        Me.LbTel.Size = New System.Drawing.Size(61, 14)
        Me.LbTel.TabIndex = 9
        Me.LbTel.Text = "Telefono :"
        '
        'TxtIva
        '
        Me.TxtIva.Enabled = False
        Me.TxtIva.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIva.Location = New System.Drawing.Point(75, 119)
        Me.TxtIva.MaxLength = 50
        Me.TxtIva.Name = "TxtIva"
        Me.TxtIva.Size = New System.Drawing.Size(281, 26)
        Me.TxtIva.TabIndex = 4
        '
        'LbCIva
        '
        Me.LbCIva.AutoSize = True
        Me.LbCIva.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCIva.ForeColor = System.Drawing.Color.Blue
        Me.LbCIva.Location = New System.Drawing.Point(75, 105)
        Me.LbCIva.Name = "LbCIva"
        Me.LbCIva.Size = New System.Drawing.Size(103, 14)
        Me.LbCIva.TabIndex = 7
        Me.LbCIva.Text = "Condicion de Iva :"
        '
        'TxtCiu
        '
        Me.TxtCiu.Enabled = False
        Me.TxtCiu.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCiu.Location = New System.Drawing.Point(458, 26)
        Me.TxtCiu.MaxLength = 50
        Me.TxtCiu.Name = "TxtCiu"
        Me.TxtCiu.Size = New System.Drawing.Size(222, 26)
        Me.TxtCiu.TabIndex = 2
        '
        'LbCiudad
        '
        Me.LbCiudad.AutoSize = True
        Me.LbCiudad.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCiudad.ForeColor = System.Drawing.Color.Blue
        Me.LbCiudad.Location = New System.Drawing.Point(458, 11)
        Me.LbCiudad.Name = "LbCiudad"
        Me.LbCiudad.Size = New System.Drawing.Size(51, 14)
        Me.LbCiudad.TabIndex = 5
        Me.LbCiudad.Text = "Ciudad :"
        '
        'MskCuit
        '
        Me.MskCuit.Enabled = False
        Me.MskCuit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskCuit.Location = New System.Drawing.Point(6, 170)
        Me.MskCuit.Mask = "##-########-#"
        Me.MskCuit.Name = "MskCuit"
        Me.MskCuit.Size = New System.Drawing.Size(155, 26)
        Me.MskCuit.TabIndex = 3
        '
        'LbCuit
        '
        Me.LbCuit.AutoSize = True
        Me.LbCuit.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCuit.ForeColor = System.Drawing.Color.Blue
        Me.LbCuit.Location = New System.Drawing.Point(6, 156)
        Me.LbCuit.Name = "LbCuit"
        Me.LbCuit.Size = New System.Drawing.Size(35, 14)
        Me.LbCuit.TabIndex = 3
        Me.LbCuit.Text = "Cuit :"
        '
        'txtDir
        '
        Me.txtDir.Enabled = False
        Me.txtDir.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDir.Location = New System.Drawing.Point(6, 75)
        Me.txtDir.MaxLength = 50
        Me.txtDir.Name = "txtDir"
        Me.txtDir.Size = New System.Drawing.Size(350, 26)
        Me.txtDir.TabIndex = 1
        '
        'LbDir
        '
        Me.LbDir.AutoSize = True
        Me.LbDir.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDir.ForeColor = System.Drawing.Color.Blue
        Me.LbDir.Location = New System.Drawing.Point(6, 60)
        Me.LbDir.Name = "LbDir"
        Me.LbDir.Size = New System.Drawing.Size(64, 14)
        Me.LbDir.TabIndex = 1
        Me.LbDir.Text = "Direccion :"
        '
        'TxtProv
        '
        Me.TxtProv.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtProv.Location = New System.Drawing.Point(6, 26)
        Me.TxtProv.MaxLength = 50
        Me.TxtProv.Name = "TxtProv"
        Me.TxtProv.Size = New System.Drawing.Size(306, 26)
        Me.TxtProv.TabIndex = 0
        '
        'LbProv
        '
        Me.LbProv.AutoSize = True
        Me.LbProv.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbProv.ForeColor = System.Drawing.Color.Blue
        Me.LbProv.Location = New System.Drawing.Point(6, 12)
        Me.LbProv.Name = "LbProv"
        Me.LbProv.Size = New System.Drawing.Size(57, 14)
        Me.LbProv.TabIndex = 0
        Me.LbProv.Text = "Nombre :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CmdEliminar)
        Me.GroupBox2.Controls.Add(Me.CmdModificar)
        Me.GroupBox2.Location = New System.Drawing.Point(543, 207)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(144, 57)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'CmdEliminar
        '
        Me.CmdEliminar.Enabled = False
        Me.CmdEliminar.Image = Global.Super.My.Resources.Resources.Eliminar
        Me.CmdEliminar.Location = New System.Drawing.Point(76, 8)
        Me.CmdEliminar.Name = "CmdEliminar"
        Me.CmdEliminar.Size = New System.Drawing.Size(65, 45)
        Me.CmdEliminar.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.CmdEliminar, "Eliminar")
        Me.CmdEliminar.UseVisualStyleBackColor = True
        '
        'CmdModificar
        '
        Me.CmdModificar.AccessibleDescription = ""
        Me.CmdModificar.AccessibleName = ""
        Me.CmdModificar.DataBindings.Add(New System.Windows.Forms.Binding("TextAlign", Global.Super.My.MySettings.Default, "Modificar", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CmdModificar.Enabled = False
        Me.CmdModificar.Image = Global.Super.My.Resources.Resources.Modificar
        Me.CmdModificar.Location = New System.Drawing.Point(6, 8)
        Me.CmdModificar.Name = "CmdModificar"
        Me.CmdModificar.Size = New System.Drawing.Size(65, 45)
        Me.CmdModificar.TabIndex = 0
        Me.CmdModificar.TextAlign = Global.Super.My.MySettings.Default.Modificar
        Me.ToolTip1.SetToolTip(Me.CmdModificar, "Modificar")
        Me.CmdModificar.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        '
        'FrmInProv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 267)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmInProv"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LbProv As System.Windows.Forms.Label
    Friend WithEvents TxtProv As System.Windows.Forms.TextBox
    Friend WithEvents LbDir As System.Windows.Forms.Label
    Friend WithEvents txtDir As System.Windows.Forms.TextBox
    Friend WithEvents LbCuit As System.Windows.Forms.Label
    Friend WithEvents MskCuit As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LbCiudad As System.Windows.Forms.Label
    Friend WithEvents TxtCiu As System.Windows.Forms.TextBox
    Friend WithEvents LbCIva As System.Windows.Forms.Label
    Friend WithEvents TxtIva As System.Windows.Forms.TextBox
    Friend WithEvents LbTel As System.Windows.Forms.Label
    Friend WithEvents TxtTel As System.Windows.Forms.TextBox
    Friend WithEvents LbCel As System.Windows.Forms.Label
    Friend WithEvents TxtCel As System.Windows.Forms.TextBox
    Friend WithEvents LbEmail As System.Windows.Forms.Label
    Friend WithEvents TxtEmail As System.Windows.Forms.TextBox
    Friend WithEvents LbCciu As System.Windows.Forms.Label
    Friend WithEvents TxtCciu As System.Windows.Forms.TextBox
    Friend WithEvents LbCciva As System.Windows.Forms.Label
    Friend WithEvents TxtCiva As System.Windows.Forms.TextBox
    Friend WithEvents CmdBuscar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdEliminar As System.Windows.Forms.Button
    Friend WithEvents CmdModificar As System.Windows.Forms.Button
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
