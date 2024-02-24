<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBackup
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
        Me.CmdCopia = New System.Windows.Forms.Button
        Me.LbRuta = New System.Windows.Forms.Label
        Me.TxtRuta = New System.Windows.Forms.TextBox
        Me.CmdRuta = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolText = New System.Windows.Forms.ToolStripStatusLabel
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.GroupBox1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CmdCopia)
        Me.GroupBox1.Controls.Add(Me.LbRuta)
        Me.GroupBox1.Controls.Add(Me.TxtRuta)
        Me.GroupBox1.Controls.Add(Me.CmdRuta)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(395, 63)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'CmdCopia
        '
        Me.CmdCopia.Image = Global.Super.My.Resources.Resources.data
        Me.CmdCopia.Location = New System.Drawing.Point(320, 10)
        Me.CmdCopia.Name = "CmdCopia"
        Me.CmdCopia.Size = New System.Drawing.Size(65, 45)
        Me.CmdCopia.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.CmdCopia, "Crear Copia de Seguridad")
        Me.CmdCopia.UseVisualStyleBackColor = True
        '
        'LbRuta
        '
        Me.LbRuta.AutoSize = True
        Me.LbRuta.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbRuta.ForeColor = System.Drawing.Color.Blue
        Me.LbRuta.Location = New System.Drawing.Point(6, 10)
        Me.LbRuta.Name = "LbRuta"
        Me.LbRuta.Size = New System.Drawing.Size(37, 14)
        Me.LbRuta.TabIndex = 3
        Me.LbRuta.Text = "Ruta :"
        '
        'TxtRuta
        '
        Me.TxtRuta.Enabled = False
        Me.TxtRuta.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRuta.Location = New System.Drawing.Point(6, 25)
        Me.TxtRuta.Name = "TxtRuta"
        Me.TxtRuta.Size = New System.Drawing.Size(242, 26)
        Me.TxtRuta.TabIndex = 2
        '
        'CmdRuta
        '
        Me.CmdRuta.Image = Global.Super.My.Resources.Resources.folder
        Me.CmdRuta.Location = New System.Drawing.Point(254, 10)
        Me.CmdRuta.Name = "CmdRuta"
        Me.CmdRuta.Size = New System.Drawing.Size(65, 45)
        Me.CmdRuta.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.CmdRuta, "Ubicacion del Archivo")
        Me.CmdRuta.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolText})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 90)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(421, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolText
        '
        Me.ToolText.Name = "ToolText"
        Me.ToolText.Size = New System.Drawing.Size(0, 17)
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'FrmBackup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 112)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmBackup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Copia de Seguridad"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdCopia As System.Windows.Forms.Button
    Friend WithEvents LbRuta As System.Windows.Forms.Label
    Friend WithEvents TxtRuta As System.Windows.Forms.TextBox
    Friend WithEvents CmdRuta As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolText As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
End Class
