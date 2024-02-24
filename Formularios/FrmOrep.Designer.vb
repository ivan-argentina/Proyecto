<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOrep
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
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CmdBuscar = New System.Windows.Forms.Button
        Me.CmdBEq = New System.Windows.Forms.Button
        Me.CmdBM = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TxtFalla = New System.Windows.Forms.TextBox
        Me.LbFalla = New System.Windows.Forms.Label
        Me.TxtNumero = New System.Windows.Forms.TextBox
        Me.LbNum = New System.Windows.Forms.Label
        Me.TxtMarca = New System.Windows.Forms.TextBox
        Me.LbMarca = New System.Windows.Forms.Label
        Me.TxtEquipo = New System.Windows.Forms.TextBox
        Me.LbMaquina = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TxtCiudad = New System.Windows.Forms.TextBox
        Me.LbCiudad = New System.Windows.Forms.Label
        Me.TxtCuit = New System.Windows.Forms.TextBox
        Me.LbCuit = New System.Windows.Forms.Label
        Me.TxtCdeiva = New System.Windows.Forms.TextBox
        Me.LbCdiva = New System.Windows.Forms.Label
        Me.TxtDireccion = New System.Windows.Forms.TextBox
        Me.LbDireccion = New System.Windows.Forms.Label
        Me.TxtCli = New System.Windows.Forms.TextBox
        Me.LbCliente = New System.Windows.Forms.Label
        Me.DtgRep = New System.Windows.Forms.DataGridView
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.OptEnt = New System.Windows.Forms.RadioButton
        Me.OptRep = New System.Windows.Forms.RadioButton
        Me.OptPRep = New System.Windows.Forms.RadioButton
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DtgRep, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'CmdBuscar
        '
        Me.CmdBuscar.Image = Global.Super.My.Resources.Resources.Buscar
        Me.CmdBuscar.Location = New System.Drawing.Point(603, 10)
        Me.CmdBuscar.Name = "CmdBuscar"
        Me.CmdBuscar.Size = New System.Drawing.Size(65, 48)
        Me.CmdBuscar.TabIndex = 21
        Me.ToolTip1.SetToolTip(Me.CmdBuscar, "Buscar Un Cliente")
        Me.CmdBuscar.UseVisualStyleBackColor = True
        '
        'CmdBEq
        '
        Me.CmdBEq.Enabled = False
        Me.CmdBEq.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdBEq.Location = New System.Drawing.Point(219, 22)
        Me.CmdBEq.Name = "CmdBEq"
        Me.CmdBEq.Size = New System.Drawing.Size(35, 26)
        Me.CmdBEq.TabIndex = 9
        Me.CmdBEq.Text = ". . ."
        Me.ToolTip1.SetToolTip(Me.CmdBEq, "Buscar un Equipo")
        Me.CmdBEq.UseVisualStyleBackColor = True
        '
        'CmdBM
        '
        Me.CmdBM.Enabled = False
        Me.CmdBM.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdBM.Location = New System.Drawing.Point(468, 22)
        Me.CmdBM.Name = "CmdBM"
        Me.CmdBM.Size = New System.Drawing.Size(35, 26)
        Me.CmdBM.TabIndex = 10
        Me.CmdBM.Text = ". . ."
        Me.ToolTip1.SetToolTip(Me.CmdBM, "Buscar una Marca")
        Me.CmdBM.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CmdBM)
        Me.GroupBox1.Controls.Add(Me.CmdBEq)
        Me.GroupBox1.Controls.Add(Me.TxtFalla)
        Me.GroupBox1.Controls.Add(Me.LbFalla)
        Me.GroupBox1.Controls.Add(Me.TxtNumero)
        Me.GroupBox1.Controls.Add(Me.LbNum)
        Me.GroupBox1.Controls.Add(Me.TxtMarca)
        Me.GroupBox1.Controls.Add(Me.LbMarca)
        Me.GroupBox1.Controls.Add(Me.TxtEquipo)
        Me.GroupBox1.Controls.Add(Me.LbMaquina)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 108)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(710, 105)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'TxtFalla
        '
        Me.TxtFalla.Enabled = False
        Me.TxtFalla.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFalla.Location = New System.Drawing.Point(6, 70)
        Me.TxtFalla.MaxLength = 100
        Me.TxtFalla.Name = "TxtFalla"
        Me.TxtFalla.Size = New System.Drawing.Size(702, 26)
        Me.TxtFalla.TabIndex = 8
        '
        'LbFalla
        '
        Me.LbFalla.AutoSize = True
        Me.LbFalla.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFalla.ForeColor = System.Drawing.Color.Blue
        Me.LbFalla.Location = New System.Drawing.Point(6, 55)
        Me.LbFalla.Name = "LbFalla"
        Me.LbFalla.Size = New System.Drawing.Size(37, 14)
        Me.LbFalla.TabIndex = 7
        Me.LbFalla.Text = "Falla :"
        '
        'TxtNumero
        '
        Me.TxtNumero.Enabled = False
        Me.TxtNumero.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNumero.Location = New System.Drawing.Point(505, 22)
        Me.TxtNumero.Name = "TxtNumero"
        Me.TxtNumero.Size = New System.Drawing.Size(203, 26)
        Me.TxtNumero.TabIndex = 6
        '
        'LbNum
        '
        Me.LbNum.AutoSize = True
        Me.LbNum.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNum.ForeColor = System.Drawing.Color.Blue
        Me.LbNum.Location = New System.Drawing.Point(505, 8)
        Me.LbNum.Name = "LbNum"
        Me.LbNum.Size = New System.Drawing.Size(57, 14)
        Me.LbNum.TabIndex = 5
        Me.LbNum.Text = "Número :"
        '
        'TxtMarca
        '
        Me.TxtMarca.Enabled = False
        Me.TxtMarca.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMarca.Location = New System.Drawing.Point(255, 22)
        Me.TxtMarca.Name = "TxtMarca"
        Me.TxtMarca.Size = New System.Drawing.Size(211, 26)
        Me.TxtMarca.TabIndex = 4
        '
        'LbMarca
        '
        Me.LbMarca.AutoSize = True
        Me.LbMarca.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbMarca.ForeColor = System.Drawing.Color.Blue
        Me.LbMarca.Location = New System.Drawing.Point(252, 8)
        Me.LbMarca.Name = "LbMarca"
        Me.LbMarca.Size = New System.Drawing.Size(46, 14)
        Me.LbMarca.TabIndex = 3
        Me.LbMarca.Text = "Marca :"
        '
        'TxtEquipo
        '
        Me.TxtEquipo.Enabled = False
        Me.TxtEquipo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEquipo.Location = New System.Drawing.Point(6, 22)
        Me.TxtEquipo.Name = "TxtEquipo"
        Me.TxtEquipo.Size = New System.Drawing.Size(211, 26)
        Me.TxtEquipo.TabIndex = 2
        '
        'LbMaquina
        '
        Me.LbMaquina.AutoSize = True
        Me.LbMaquina.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbMaquina.ForeColor = System.Drawing.Color.Blue
        Me.LbMaquina.Location = New System.Drawing.Point(6, 8)
        Me.LbMaquina.Name = "LbMaquina"
        Me.LbMaquina.Size = New System.Drawing.Size(50, 14)
        Me.LbMaquina.TabIndex = 1
        Me.LbMaquina.Text = "Equipo :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CmdBuscar)
        Me.GroupBox2.Controls.Add(Me.TxtCiudad)
        Me.GroupBox2.Controls.Add(Me.LbCiudad)
        Me.GroupBox2.Controls.Add(Me.TxtCuit)
        Me.GroupBox2.Controls.Add(Me.LbCuit)
        Me.GroupBox2.Controls.Add(Me.TxtCdeiva)
        Me.GroupBox2.Controls.Add(Me.LbCdiva)
        Me.GroupBox2.Controls.Add(Me.TxtDireccion)
        Me.GroupBox2.Controls.Add(Me.LbDireccion)
        Me.GroupBox2.Controls.Add(Me.TxtCli)
        Me.GroupBox2.Controls.Add(Me.LbCliente)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(671, 102)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'TxtCiudad
        '
        Me.TxtCiudad.Enabled = False
        Me.TxtCiudad.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCiudad.Location = New System.Drawing.Point(391, 65)
        Me.TxtCiudad.Name = "TxtCiudad"
        Me.TxtCiudad.Size = New System.Drawing.Size(276, 26)
        Me.TxtCiudad.TabIndex = 20
        '
        'LbCiudad
        '
        Me.LbCiudad.AutoSize = True
        Me.LbCiudad.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCiudad.ForeColor = System.Drawing.Color.Blue
        Me.LbCiudad.Location = New System.Drawing.Point(391, 52)
        Me.LbCiudad.Name = "LbCiudad"
        Me.LbCiudad.Size = New System.Drawing.Size(51, 14)
        Me.LbCiudad.TabIndex = 19
        Me.LbCiudad.Text = "Ciudad :"
        '
        'TxtCuit
        '
        Me.TxtCuit.Enabled = False
        Me.TxtCuit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCuit.Location = New System.Drawing.Point(240, 65)
        Me.TxtCuit.Name = "TxtCuit"
        Me.TxtCuit.Size = New System.Drawing.Size(148, 26)
        Me.TxtCuit.TabIndex = 18
        '
        'LbCuit
        '
        Me.LbCuit.AutoSize = True
        Me.LbCuit.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCuit.ForeColor = System.Drawing.Color.Blue
        Me.LbCuit.Location = New System.Drawing.Point(240, 52)
        Me.LbCuit.Name = "LbCuit"
        Me.LbCuit.Size = New System.Drawing.Size(35, 14)
        Me.LbCuit.TabIndex = 17
        Me.LbCuit.Text = "Cuit :"
        '
        'TxtCdeiva
        '
        Me.TxtCdeiva.Enabled = False
        Me.TxtCdeiva.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCdeiva.Location = New System.Drawing.Point(3, 65)
        Me.TxtCdeiva.Name = "TxtCdeiva"
        Me.TxtCdeiva.Size = New System.Drawing.Size(234, 26)
        Me.TxtCdeiva.TabIndex = 16
        '
        'LbCdiva
        '
        Me.LbCdiva.AutoSize = True
        Me.LbCdiva.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCdiva.ForeColor = System.Drawing.Color.Blue
        Me.LbCdiva.Location = New System.Drawing.Point(1, 52)
        Me.LbCdiva.Name = "LbCdiva"
        Me.LbCdiva.Size = New System.Drawing.Size(59, 14)
        Me.LbCdiva.TabIndex = 15
        Me.LbCdiva.Text = "C. de Iva :"
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Enabled = False
        Me.TxtDireccion.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDireccion.Location = New System.Drawing.Point(345, 23)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(255, 26)
        Me.TxtDireccion.TabIndex = 14
        '
        'LbDireccion
        '
        Me.LbDireccion.AutoSize = True
        Me.LbDireccion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDireccion.ForeColor = System.Drawing.Color.Blue
        Me.LbDireccion.Location = New System.Drawing.Point(345, 8)
        Me.LbDireccion.Name = "LbDireccion"
        Me.LbDireccion.Size = New System.Drawing.Size(64, 14)
        Me.LbDireccion.TabIndex = 13
        Me.LbDireccion.Text = "Direccion :"
        '
        'TxtCli
        '
        Me.TxtCli.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCli.Location = New System.Drawing.Point(3, 23)
        Me.TxtCli.Name = "TxtCli"
        Me.TxtCli.Size = New System.Drawing.Size(340, 26)
        Me.TxtCli.TabIndex = 0
        '
        'LbCliente
        '
        Me.LbCliente.AutoSize = True
        Me.LbCliente.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCliente.ForeColor = System.Drawing.Color.Blue
        Me.LbCliente.Location = New System.Drawing.Point(1, 8)
        Me.LbCliente.Name = "LbCliente"
        Me.LbCliente.Size = New System.Drawing.Size(52, 14)
        Me.LbCliente.TabIndex = 11
        Me.LbCliente.Text = "Cliente :"
        '
        'DtgRep
        '
        Me.DtgRep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgRep.Location = New System.Drawing.Point(6, 218)
        Me.DtgRep.Name = "DtgRep"
        Me.DtgRep.Size = New System.Drawing.Size(781, 255)
        Me.DtgRep.TabIndex = 3
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.OptEnt)
        Me.GroupBox3.Controls.Add(Me.OptRep)
        Me.GroupBox3.Controls.Add(Me.OptPRep)
        Me.GroupBox3.Location = New System.Drawing.Point(679, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(108, 75)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        '
        'OptEnt
        '
        Me.OptEnt.AutoSize = True
        Me.OptEnt.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptEnt.ForeColor = System.Drawing.Color.Blue
        Me.OptEnt.Location = New System.Drawing.Point(6, 50)
        Me.OptEnt.Name = "OptEnt"
        Me.OptEnt.Size = New System.Drawing.Size(88, 18)
        Me.OptEnt.TabIndex = 2
        Me.OptEnt.Text = "Entregados"
        Me.OptEnt.UseVisualStyleBackColor = True
        '
        'OptRep
        '
        Me.OptRep.AutoSize = True
        Me.OptRep.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptRep.ForeColor = System.Drawing.Color.Blue
        Me.OptRep.Location = New System.Drawing.Point(6, 30)
        Me.OptRep.Name = "OptRep"
        Me.OptRep.Size = New System.Drawing.Size(84, 18)
        Me.OptRep.TabIndex = 1
        Me.OptRep.Text = "Reparados"
        Me.OptRep.UseVisualStyleBackColor = True
        '
        'OptPRep
        '
        Me.OptPRep.Checked = True
        Me.OptPRep.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptPRep.ForeColor = System.Drawing.Color.Blue
        Me.OptPRep.Location = New System.Drawing.Point(6, 10)
        Me.OptPRep.Name = "OptPRep"
        Me.OptPRep.Size = New System.Drawing.Size(95, 16)
        Me.OptPRep.TabIndex = 0
        Me.OptPRep.TabStop = True
        Me.OptPRep.Text = "Para Reparar"
        Me.OptPRep.UseVisualStyleBackColor = True
        '
        'FrmOrep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 476)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.DtgRep)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmOrep"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Orden de Reparacion"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DtgRep, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdBuscar As System.Windows.Forms.Button
    Friend WithEvents TxtCiudad As System.Windows.Forms.TextBox
    Friend WithEvents LbCiudad As System.Windows.Forms.Label
    Friend WithEvents TxtCuit As System.Windows.Forms.TextBox
    Friend WithEvents LbCuit As System.Windows.Forms.Label
    Friend WithEvents TxtCdeiva As System.Windows.Forms.TextBox
    Friend WithEvents LbCdiva As System.Windows.Forms.Label
    Friend WithEvents TxtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents LbDireccion As System.Windows.Forms.Label
    Friend WithEvents TxtCli As System.Windows.Forms.TextBox
    Friend WithEvents LbCliente As System.Windows.Forms.Label
    Friend WithEvents LbMaquina As System.Windows.Forms.Label
    Friend WithEvents TxtEquipo As System.Windows.Forms.TextBox
    Friend WithEvents LbMarca As System.Windows.Forms.Label
    Friend WithEvents TxtMarca As System.Windows.Forms.TextBox
    Friend WithEvents LbNum As System.Windows.Forms.Label
    Friend WithEvents TxtNumero As System.Windows.Forms.TextBox
    Friend WithEvents LbFalla As System.Windows.Forms.Label
    Friend WithEvents TxtFalla As System.Windows.Forms.TextBox
    Friend WithEvents CmdBEq As System.Windows.Forms.Button
    Friend WithEvents CmdBM As System.Windows.Forms.Button
    Friend WithEvents DtgRep As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents OptEnt As System.Windows.Forms.RadioButton
    Friend WithEvents OptRep As System.Windows.Forms.RadioButton
    Friend WithEvents OptPRep As System.Windows.Forms.RadioButton
End Class
