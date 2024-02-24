<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLStock
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CmdPantalla = New System.Windows.Forms.Button
        Me.DtgArtculo = New System.Windows.Forms.DataGridView
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.CmbFamilia = New System.Windows.Forms.ComboBox
        Me.LbFamilia = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.DtgArtculo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CmdPantalla)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(81, 64)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'CmdPantalla
        '
        Me.CmdPantalla.Image = Global.Super.My.Resources.Resources.Pantalla
        Me.CmdPantalla.Location = New System.Drawing.Point(6, 10)
        Me.CmdPantalla.Name = "CmdPantalla"
        Me.CmdPantalla.Size = New System.Drawing.Size(71, 48)
        Me.CmdPantalla.TabIndex = 0
        Me.CmdPantalla.UseVisualStyleBackColor = True
        '
        'DtgArtculo
        '
        Me.DtgArtculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgArtculo.Location = New System.Drawing.Point(120, 89)
        Me.DtgArtculo.Name = "DtgArtculo"
        Me.DtgArtculo.Size = New System.Drawing.Size(19, 16)
        Me.DtgArtculo.TabIndex = 1
        Me.DtgArtculo.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LbFamilia)
        Me.GroupBox2.Controls.Add(Me.CmbFamilia)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(275, 58)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'CmbFamilia
        '
        Me.CmbFamilia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbFamilia.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbFamilia.FormattingEnabled = True
        Me.CmbFamilia.Location = New System.Drawing.Point(6, 25)
        Me.CmbFamilia.Name = "CmbFamilia"
        Me.CmbFamilia.Size = New System.Drawing.Size(265, 26)
        Me.CmbFamilia.TabIndex = 0
        '
        'LbFamilia
        '
        Me.LbFamilia.AutoSize = True
        Me.LbFamilia.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFamilia.ForeColor = System.Drawing.Color.Blue
        Me.LbFamilia.Location = New System.Drawing.Point(6, 10)
        Me.LbFamilia.Name = "LbFamilia"
        Me.LbFamilia.Size = New System.Drawing.Size(51, 14)
        Me.LbFamilia.TabIndex = 1
        Me.LbFamilia.Text = "Familia :"
        '
        'FrmLStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(283, 130)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DtgArtculo)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLStock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DtgArtculo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdPantalla As System.Windows.Forms.Button
    Friend WithEvents DtgArtculo As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LbFamilia As System.Windows.Forms.Label
    Public WithEvents CmbFamilia As System.Windows.Forms.ComboBox
End Class
