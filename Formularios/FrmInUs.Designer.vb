<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInUs
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
        Me.CmbPr = New System.Windows.Forms.ComboBox
        Me.LbPrioridad = New System.Windows.Forms.Label
        Me.TxtClave = New System.Windows.Forms.TextBox
        Me.LbClave = New System.Windows.Forms.Label
        Me.TxtUsuario = New System.Windows.Forms.TextBox
        Me.LbUsuario = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.CmdBuscar = New System.Windows.Forms.Button
        Me.CmdEliminar = New System.Windows.Forms.Button
        Me.CmdModificar = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CmbPr)
        Me.GroupBox1.Controls.Add(Me.LbPrioridad)
        Me.GroupBox1.Controls.Add(Me.TxtClave)
        Me.GroupBox1.Controls.Add(Me.LbClave)
        Me.GroupBox1.Controls.Add(Me.TxtUsuario)
        Me.GroupBox1.Controls.Add(Me.LbUsuario)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(488, 63)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'CmbPr
        '
        Me.CmbPr.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbPr.FormattingEnabled = True
        Me.CmbPr.Items.AddRange(New Object() {"Maxima", "Minima"})
        Me.CmbPr.Location = New System.Drawing.Point(378, 25)
        Me.CmbPr.Name = "CmbPr"
        Me.CmbPr.Size = New System.Drawing.Size(101, 26)
        Me.CmbPr.TabIndex = 5
        '
        'LbPrioridad
        '
        Me.LbPrioridad.AutoSize = True
        Me.LbPrioridad.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPrioridad.ForeColor = System.Drawing.Color.Blue
        Me.LbPrioridad.Location = New System.Drawing.Point(378, 10)
        Me.LbPrioridad.Name = "LbPrioridad"
        Me.LbPrioridad.Size = New System.Drawing.Size(63, 14)
        Me.LbPrioridad.TabIndex = 4
        Me.LbPrioridad.Text = "Prioridad :"
        '
        'TxtClave
        '
        Me.TxtClave.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtClave.Location = New System.Drawing.Point(247, 25)
        Me.TxtClave.Name = "TxtClave"
        Me.TxtClave.Size = New System.Drawing.Size(128, 26)
        Me.TxtClave.TabIndex = 3
        Me.TxtClave.UseSystemPasswordChar = True
        '
        'LbClave
        '
        Me.LbClave.AutoSize = True
        Me.LbClave.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbClave.ForeColor = System.Drawing.Color.Blue
        Me.LbClave.Location = New System.Drawing.Point(247, 10)
        Me.LbClave.Name = "LbClave"
        Me.LbClave.Size = New System.Drawing.Size(43, 14)
        Me.LbClave.TabIndex = 2
        Me.LbClave.Text = "Clave :"
        '
        'TxtUsuario
        '
        Me.TxtUsuario.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsuario.Location = New System.Drawing.Point(6, 25)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(238, 26)
        Me.TxtUsuario.TabIndex = 1
        '
        'LbUsuario
        '
        Me.LbUsuario.AutoSize = True
        Me.LbUsuario.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbUsuario.ForeColor = System.Drawing.Color.Blue
        Me.LbUsuario.Location = New System.Drawing.Point(6, 10)
        Me.LbUsuario.Name = "LbUsuario"
        Me.LbUsuario.Size = New System.Drawing.Size(55, 14)
        Me.LbUsuario.TabIndex = 0
        Me.LbUsuario.Text = "Usuario :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CmdBuscar)
        Me.GroupBox2.Controls.Add(Me.CmdEliminar)
        Me.GroupBox2.Controls.Add(Me.CmdModificar)
        Me.GroupBox2.Location = New System.Drawing.Point(290, 70)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(205, 57)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'CmdBuscar
        '
        Me.CmdBuscar.AccessibleDescription = ""
        Me.CmdBuscar.AccessibleName = ""
        Me.CmdBuscar.DataBindings.Add(New System.Windows.Forms.Binding("TextAlign", Global.Super.My.MySettings.Default, "Modificar", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CmdBuscar.Image = Global.Super.My.Resources.Resources.Buscar
        Me.CmdBuscar.Location = New System.Drawing.Point(6, 8)
        Me.CmdBuscar.Name = "CmdBuscar"
        Me.CmdBuscar.Size = New System.Drawing.Size(65, 45)
        Me.CmdBuscar.TabIndex = 2
        Me.CmdBuscar.TextAlign = Global.Super.My.MySettings.Default.Modificar
        Me.ToolTip1.SetToolTip(Me.CmdBuscar, "Buscar")
        Me.CmdBuscar.UseVisualStyleBackColor = True
        '
        'CmdEliminar
        '
        Me.CmdEliminar.Enabled = False
        Me.CmdEliminar.Image = Global.Super.My.Resources.Resources.Eliminar
        Me.CmdEliminar.Location = New System.Drawing.Point(138, 8)
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
        Me.CmdModificar.Location = New System.Drawing.Point(72, 8)
        Me.CmdModificar.Name = "CmdModificar"
        Me.CmdModificar.Size = New System.Drawing.Size(65, 45)
        Me.CmdModificar.TabIndex = 0
        Me.CmdModificar.TextAlign = Global.Super.My.MySettings.Default.Modificar
        Me.ToolTip1.SetToolTip(Me.CmdModificar, "Modificar")
        Me.CmdModificar.UseVisualStyleBackColor = True
        '
        'FrmInUs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 132)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmInUs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "A.B.M. de Usuarios"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LbUsuario As System.Windows.Forms.Label
    Friend WithEvents TxtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents TxtClave As System.Windows.Forms.TextBox
    Friend WithEvents LbClave As System.Windows.Forms.Label
    Friend WithEvents LbPrioridad As System.Windows.Forms.Label
    Friend WithEvents CmbPr As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdEliminar As System.Windows.Forms.Button
    Friend WithEvents CmdModificar As System.Windows.Forms.Button
    Friend WithEvents CmdBuscar As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
