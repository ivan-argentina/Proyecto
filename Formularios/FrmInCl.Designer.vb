<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInCl
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
        Me.LbSaldo = New System.Windows.Forms.Label
        Me.MskSaldo = New System.Windows.Forms.MaskedTextBox
        Me.DtcNc = New System.Windows.Forms.DateTimePicker
        Me.LbNac = New System.Windows.Forms.Label
        Me.TxtProv = New System.Windows.Forms.TextBox
        Me.LbProvincia = New System.Windows.Forms.Label
        Me.TxtCpostal = New System.Windows.Forms.TextBox
        Me.LbCpostal = New System.Windows.Forms.Label
        Me.CmdBuscar = New System.Windows.Forms.Button
        Me.txtCel = New System.Windows.Forms.TextBox
        Me.LbFax = New System.Windows.Forms.Label
        Me.TxtTelefono = New System.Windows.Forms.TextBox
        Me.LbTel = New System.Windows.Forms.Label
        Me.TxtEmail = New System.Windows.Forms.TextBox
        Me.LbEmail = New System.Windows.Forms.Label
        Me.TxtCiudad = New System.Windows.Forms.TextBox
        Me.LbCiudad = New System.Windows.Forms.Label
        Me.TxtCCiu = New System.Windows.Forms.TextBox
        Me.LbCiu = New System.Windows.Forms.Label
        Me.MskCuit = New System.Windows.Forms.MaskedTextBox
        Me.LbCuit = New System.Windows.Forms.Label
        Me.TxtIva = New System.Windows.Forms.TextBox
        Me.LbCiva = New System.Windows.Forms.Label
        Me.txtCiva = New System.Windows.Forms.TextBox
        Me.LbCodigo = New System.Windows.Forms.Label
        Me.TxtDireccion = New System.Windows.Forms.TextBox
        Me.LbDireccion = New System.Windows.Forms.Label
        Me.TxtNombre = New System.Windows.Forms.TextBox
        Me.LbNombre = New System.Windows.Forms.Label
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
        Me.GroupBox1.Controls.Add(Me.LbSaldo)
        Me.GroupBox1.Controls.Add(Me.MskSaldo)
        Me.GroupBox1.Controls.Add(Me.DtcNc)
        Me.GroupBox1.Controls.Add(Me.LbNac)
        Me.GroupBox1.Controls.Add(Me.TxtProv)
        Me.GroupBox1.Controls.Add(Me.LbProvincia)
        Me.GroupBox1.Controls.Add(Me.TxtCpostal)
        Me.GroupBox1.Controls.Add(Me.LbCpostal)
        Me.GroupBox1.Controls.Add(Me.CmdBuscar)
        Me.GroupBox1.Controls.Add(Me.txtCel)
        Me.GroupBox1.Controls.Add(Me.LbFax)
        Me.GroupBox1.Controls.Add(Me.TxtTelefono)
        Me.GroupBox1.Controls.Add(Me.LbTel)
        Me.GroupBox1.Controls.Add(Me.TxtEmail)
        Me.GroupBox1.Controls.Add(Me.LbEmail)
        Me.GroupBox1.Controls.Add(Me.TxtCiudad)
        Me.GroupBox1.Controls.Add(Me.LbCiudad)
        Me.GroupBox1.Controls.Add(Me.TxtCCiu)
        Me.GroupBox1.Controls.Add(Me.LbCiu)
        Me.GroupBox1.Controls.Add(Me.MskCuit)
        Me.GroupBox1.Controls.Add(Me.LbCuit)
        Me.GroupBox1.Controls.Add(Me.TxtIva)
        Me.GroupBox1.Controls.Add(Me.LbCiva)
        Me.GroupBox1.Controls.Add(Me.txtCiva)
        Me.GroupBox1.Controls.Add(Me.LbCodigo)
        Me.GroupBox1.Controls.Add(Me.TxtDireccion)
        Me.GroupBox1.Controls.Add(Me.LbDireccion)
        Me.GroupBox1.Controls.Add(Me.TxtNombre)
        Me.GroupBox1.Controls.Add(Me.LbNombre)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(685, 201)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'LbSaldo
        '
        Me.LbSaldo.AutoSize = True
        Me.LbSaldo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSaldo.ForeColor = System.Drawing.Color.Blue
        Me.LbSaldo.Location = New System.Drawing.Point(568, 155)
        Me.LbSaldo.Name = "LbSaldo"
        Me.LbSaldo.Size = New System.Drawing.Size(43, 14)
        Me.LbSaldo.TabIndex = 37
        Me.LbSaldo.Text = "Saldo :"
        '
        'MskSaldo
        '
        Me.MskSaldo.Enabled = False
        Me.MskSaldo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskSaldo.Location = New System.Drawing.Point(568, 170)
        Me.MskSaldo.Name = "MskSaldo"
        Me.MskSaldo.Size = New System.Drawing.Size(110, 26)
        Me.MskSaldo.TabIndex = 36
        '
        'DtcNc
        '
        Me.DtcNc.Enabled = False
        Me.DtcNc.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtcNc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtcNc.Location = New System.Drawing.Point(159, 169)
        Me.DtcNc.Name = "DtcNc"
        Me.DtcNc.Size = New System.Drawing.Size(112, 26)
        Me.DtcNc.TabIndex = 35
        '
        'LbNac
        '
        Me.LbNac.AutoSize = True
        Me.LbNac.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNac.ForeColor = System.Drawing.Color.Blue
        Me.LbNac.Location = New System.Drawing.Point(159, 155)
        Me.LbNac.Name = "LbNac"
        Me.LbNac.Size = New System.Drawing.Size(74, 14)
        Me.LbNac.TabIndex = 34
        Me.LbNac.Text = "Nacimiento :"
        '
        'TxtProv
        '
        Me.TxtProv.Enabled = False
        Me.TxtProv.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtProv.Location = New System.Drawing.Point(478, 75)
        Me.TxtProv.Name = "TxtProv"
        Me.TxtProv.Size = New System.Drawing.Size(202, 26)
        Me.TxtProv.TabIndex = 33
        '
        'LbProvincia
        '
        Me.LbProvincia.AutoSize = True
        Me.LbProvincia.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbProvincia.ForeColor = System.Drawing.Color.Blue
        Me.LbProvincia.Location = New System.Drawing.Point(478, 60)
        Me.LbProvincia.Name = "LbProvincia"
        Me.LbProvincia.Size = New System.Drawing.Size(63, 14)
        Me.LbProvincia.TabIndex = 32
        Me.LbProvincia.Text = "Provincia :"
        '
        'TxtCpostal
        '
        Me.TxtCpostal.Enabled = False
        Me.TxtCpostal.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCpostal.Location = New System.Drawing.Point(360, 75)
        Me.TxtCpostal.Name = "TxtCpostal"
        Me.TxtCpostal.Size = New System.Drawing.Size(115, 26)
        Me.TxtCpostal.TabIndex = 31
        '
        'LbCpostal
        '
        Me.LbCpostal.AutoSize = True
        Me.LbCpostal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCpostal.ForeColor = System.Drawing.Color.Blue
        Me.LbCpostal.Location = New System.Drawing.Point(360, 60)
        Me.LbCpostal.Name = "LbCpostal"
        Me.LbCpostal.Size = New System.Drawing.Size(58, 14)
        Me.LbCpostal.TabIndex = 30
        Me.LbCpostal.Text = "C.Postal :"
        '
        'CmdBuscar
        '
        Me.CmdBuscar.Image = Global.Super.My.Resources.Resources.Buscar
        Me.CmdBuscar.Location = New System.Drawing.Point(318, 13)
        Me.CmdBuscar.Name = "CmdBuscar"
        Me.CmdBuscar.Size = New System.Drawing.Size(65, 45)
        Me.CmdBuscar.TabIndex = 29
        Me.ToolTip1.SetToolTip(Me.CmdBuscar, "Buscar un Cliente")
        Me.CmdBuscar.UseVisualStyleBackColor = True
        '
        'txtCel
        '
        Me.txtCel.Enabled = False
        Me.txtCel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCel.Location = New System.Drawing.Point(422, 170)
        Me.txtCel.Name = "txtCel"
        Me.txtCel.Size = New System.Drawing.Size(143, 26)
        Me.txtCel.TabIndex = 28
        '
        'LbFax
        '
        Me.LbFax.AutoSize = True
        Me.LbFax.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFax.ForeColor = System.Drawing.Color.Blue
        Me.LbFax.Location = New System.Drawing.Point(422, 155)
        Me.LbFax.Name = "LbFax"
        Me.LbFax.Size = New System.Drawing.Size(52, 14)
        Me.LbFax.TabIndex = 27
        Me.LbFax.Text = "Celular :"
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Enabled = False
        Me.TxtTelefono.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTelefono.Location = New System.Drawing.Point(275, 170)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(143, 26)
        Me.TxtTelefono.TabIndex = 26
        '
        'LbTel
        '
        Me.LbTel.AutoSize = True
        Me.LbTel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTel.ForeColor = System.Drawing.Color.Blue
        Me.LbTel.Location = New System.Drawing.Point(275, 155)
        Me.LbTel.Name = "LbTel"
        Me.LbTel.Size = New System.Drawing.Size(61, 14)
        Me.LbTel.TabIndex = 25
        Me.LbTel.Text = "Telefono :"
        '
        'TxtEmail
        '
        Me.TxtEmail.Enabled = False
        Me.TxtEmail.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmail.Location = New System.Drawing.Point(360, 119)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(320, 26)
        Me.TxtEmail.TabIndex = 24
        '
        'LbEmail
        '
        Me.LbEmail.AutoSize = True
        Me.LbEmail.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbEmail.ForeColor = System.Drawing.Color.Blue
        Me.LbEmail.Location = New System.Drawing.Point(360, 105)
        Me.LbEmail.Name = "LbEmail"
        Me.LbEmail.Size = New System.Drawing.Size(42, 14)
        Me.LbEmail.TabIndex = 23
        Me.LbEmail.Text = "Email :"
        '
        'TxtCiudad
        '
        Me.TxtCiudad.Enabled = False
        Me.TxtCiudad.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCiudad.Location = New System.Drawing.Point(458, 26)
        Me.TxtCiudad.Name = "TxtCiudad"
        Me.TxtCiudad.Size = New System.Drawing.Size(222, 26)
        Me.TxtCiudad.TabIndex = 22
        '
        'LbCiudad
        '
        Me.LbCiudad.AutoSize = True
        Me.LbCiudad.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCiudad.ForeColor = System.Drawing.Color.Blue
        Me.LbCiudad.Location = New System.Drawing.Point(458, 11)
        Me.LbCiudad.Name = "LbCiudad"
        Me.LbCiudad.Size = New System.Drawing.Size(51, 14)
        Me.LbCiudad.TabIndex = 21
        Me.LbCiudad.Text = "Ciudad :"
        '
        'TxtCCiu
        '
        Me.TxtCCiu.Enabled = False
        Me.TxtCCiu.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCCiu.Location = New System.Drawing.Point(389, 26)
        Me.TxtCCiu.Name = "TxtCCiu"
        Me.TxtCCiu.Size = New System.Drawing.Size(66, 26)
        Me.TxtCCiu.TabIndex = 20
        '
        'LbCiu
        '
        Me.LbCiu.AutoSize = True
        Me.LbCiu.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCiu.ForeColor = System.Drawing.Color.Blue
        Me.LbCiu.Location = New System.Drawing.Point(389, 11)
        Me.LbCiu.Name = "LbCiu"
        Me.LbCiu.Size = New System.Drawing.Size(52, 14)
        Me.LbCiu.TabIndex = 19
        Me.LbCiu.Text = "Codigo :"
        '
        'MskCuit
        '
        Me.MskCuit.Enabled = False
        Me.MskCuit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskCuit.Location = New System.Drawing.Point(6, 169)
        Me.MskCuit.Name = "MskCuit"
        Me.MskCuit.Size = New System.Drawing.Size(149, 26)
        Me.MskCuit.TabIndex = 18
        '
        'LbCuit
        '
        Me.LbCuit.AutoSize = True
        Me.LbCuit.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCuit.ForeColor = System.Drawing.Color.Blue
        Me.LbCuit.Location = New System.Drawing.Point(6, 155)
        Me.LbCuit.Name = "LbCuit"
        Me.LbCuit.Size = New System.Drawing.Size(35, 14)
        Me.LbCuit.TabIndex = 17
        Me.LbCuit.Text = "Cuit :"
        '
        'TxtIva
        '
        Me.TxtIva.Enabled = False
        Me.TxtIva.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIva.Location = New System.Drawing.Point(75, 119)
        Me.TxtIva.Name = "TxtIva"
        Me.TxtIva.Size = New System.Drawing.Size(281, 26)
        Me.TxtIva.TabIndex = 16
        '
        'LbCiva
        '
        Me.LbCiva.AutoSize = True
        Me.LbCiva.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCiva.ForeColor = System.Drawing.Color.Blue
        Me.LbCiva.Location = New System.Drawing.Point(75, 105)
        Me.LbCiva.Name = "LbCiva"
        Me.LbCiva.Size = New System.Drawing.Size(103, 14)
        Me.LbCiva.TabIndex = 15
        Me.LbCiva.Text = "Condición de Iva :"
        '
        'txtCiva
        '
        Me.txtCiva.Enabled = False
        Me.txtCiva.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCiva.Location = New System.Drawing.Point(6, 119)
        Me.txtCiva.Name = "txtCiva"
        Me.txtCiva.Size = New System.Drawing.Size(66, 26)
        Me.txtCiva.TabIndex = 14
        '
        'LbCodigo
        '
        Me.LbCodigo.AutoSize = True
        Me.LbCodigo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCodigo.ForeColor = System.Drawing.Color.Blue
        Me.LbCodigo.Location = New System.Drawing.Point(6, 105)
        Me.LbCodigo.Name = "LbCodigo"
        Me.LbCodigo.Size = New System.Drawing.Size(52, 14)
        Me.LbCodigo.TabIndex = 13
        Me.LbCodigo.Text = "Codigo :"
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Enabled = False
        Me.TxtDireccion.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDireccion.Location = New System.Drawing.Point(6, 75)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(350, 26)
        Me.TxtDireccion.TabIndex = 12
        '
        'LbDireccion
        '
        Me.LbDireccion.AutoSize = True
        Me.LbDireccion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDireccion.ForeColor = System.Drawing.Color.Blue
        Me.LbDireccion.Location = New System.Drawing.Point(6, 60)
        Me.LbDireccion.Name = "LbDireccion"
        Me.LbDireccion.Size = New System.Drawing.Size(64, 14)
        Me.LbDireccion.TabIndex = 11
        Me.LbDireccion.Tag = ""
        Me.LbDireccion.Text = "Dirección :"
        '
        'TxtNombre
        '
        Me.TxtNombre.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.Location = New System.Drawing.Point(6, 26)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(306, 26)
        Me.TxtNombre.TabIndex = 10
        '
        'LbNombre
        '
        Me.LbNombre.AutoSize = True
        Me.LbNombre.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNombre.ForeColor = System.Drawing.Color.Blue
        Me.LbNombre.Location = New System.Drawing.Point(6, 12)
        Me.LbNombre.Name = "LbNombre"
        Me.LbNombre.Size = New System.Drawing.Size(57, 14)
        Me.LbNombre.TabIndex = 9
        Me.LbNombre.Text = "Nombre :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CmdEliminar)
        Me.GroupBox2.Controls.Add(Me.CmdModificar)
        Me.GroupBox2.Location = New System.Drawing.Point(546, 203)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(140, 57)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        '
        'CmdEliminar
        '
        Me.CmdEliminar.Enabled = False
        Me.CmdEliminar.Image = Global.Super.My.Resources.Resources.Eliminar
        Me.CmdEliminar.Location = New System.Drawing.Point(72, 8)
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
        'FrmInCl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 267)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmInCl"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "A.B.M.Clientes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LbCuit As System.Windows.Forms.Label
    Friend WithEvents TxtIva As System.Windows.Forms.TextBox
    Friend WithEvents LbCiva As System.Windows.Forms.Label
    Friend WithEvents txtCiva As System.Windows.Forms.TextBox
    Friend WithEvents LbCodigo As System.Windows.Forms.Label
    Friend WithEvents TxtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents LbDireccion As System.Windows.Forms.Label
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents LbNombre As System.Windows.Forms.Label
    Friend WithEvents MskCuit As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LbCiu As System.Windows.Forms.Label
    Friend WithEvents TxtCCiu As System.Windows.Forms.TextBox
    Friend WithEvents LbCiudad As System.Windows.Forms.Label
    Friend WithEvents TxtCiudad As System.Windows.Forms.TextBox
    Friend WithEvents LbEmail As System.Windows.Forms.Label
    Friend WithEvents TxtEmail As System.Windows.Forms.TextBox
    Friend WithEvents LbTel As System.Windows.Forms.Label
    Friend WithEvents TxtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents LbFax As System.Windows.Forms.Label
    Friend WithEvents txtCel As System.Windows.Forms.TextBox
    Friend WithEvents CmdBuscar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdEliminar As System.Windows.Forms.Button
    Friend WithEvents CmdModificar As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents LbCpostal As System.Windows.Forms.Label
    Friend WithEvents TxtCpostal As System.Windows.Forms.TextBox
    Friend WithEvents TxtProv As System.Windows.Forms.TextBox
    Friend WithEvents LbProvincia As System.Windows.Forms.Label
    Friend WithEvents LbNac As System.Windows.Forms.Label
    Friend WithEvents DtcNc As System.Windows.Forms.DateTimePicker
    Friend WithEvents MskSaldo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LbSaldo As System.Windows.Forms.Label
End Class
