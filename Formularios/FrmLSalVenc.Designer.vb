<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLSalVenc
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
        Me.DtgSaldos = New System.Windows.Forms.DataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CmdSaldos = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.DtgSaldos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DtgSaldos
        '
        Me.DtgSaldos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgSaldos.Location = New System.Drawing.Point(-6, 12)
        Me.DtgSaldos.Name = "DtgSaldos"
        Me.DtgSaldos.Size = New System.Drawing.Size(116, 88)
        Me.DtgSaldos.TabIndex = 12
        Me.DtgSaldos.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CmdSaldos)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(85, 66)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'CmdSaldos
        '
        Me.CmdSaldos.Image = Global.Super.My.Resources.Resources.saldos
        Me.CmdSaldos.Location = New System.Drawing.Point(6, 10)
        Me.CmdSaldos.Name = "CmdSaldos"
        Me.CmdSaldos.Size = New System.Drawing.Size(71, 48)
        Me.CmdSaldos.TabIndex = 14
        Me.CmdSaldos.UseVisualStyleBackColor = True
        '
        'FrmLSalVenc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(150, 95)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DtgSaldos)
        Me.Name = "FrmLSalVenc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle de Saldos Vencidos"
        CType(Me.DtgSaldos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DtgSaldos As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdSaldos As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
