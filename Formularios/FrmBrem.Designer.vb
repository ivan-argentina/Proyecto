<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBrem
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
        Me.DtgRem = New System.Windows.Forms.DataGridView
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Cmdfacturar = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DtgDFac = New System.Windows.Forms.DataGridView
        CType(Me.DtgRem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DtgDFac, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DtgRem
        '
        Me.DtgRem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgRem.Location = New System.Drawing.Point(6, 10)
        Me.DtgRem.Name = "DtgRem"
        Me.DtgRem.Size = New System.Drawing.Size(486, 237)
        Me.DtgRem.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(93, 253)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(74, 39)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(41, 253)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(46, 37)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Cmdfacturar
        '
        Me.Cmdfacturar.Image = Global.Super.My.Resources.Resources.Facturar
        Me.Cmdfacturar.Location = New System.Drawing.Point(6, 9)
        Me.Cmdfacturar.Name = "Cmdfacturar"
        Me.Cmdfacturar.Size = New System.Drawing.Size(65, 45)
        Me.Cmdfacturar.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.Cmdfacturar, "Facturar")
        Me.Cmdfacturar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Cmdfacturar)
        Me.GroupBox1.Location = New System.Drawing.Point(417, 256)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(75, 55)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'DtgDFac
        '
        Me.DtgDFac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgDFac.Location = New System.Drawing.Point(6, 319)
        Me.DtgDFac.Name = "DtgDFac"
        Me.DtgDFac.Size = New System.Drawing.Size(441, 129)
        Me.DtgDFac.TabIndex = 5
        '
        'FrmBrem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 449)
        Me.Controls.Add(Me.DtgDFac)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DtgRem)
        Me.Name = "FrmBrem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Remito En Cta.Cte."
        Me.TopMost = True
        CType(Me.DtgRem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DtgDFac, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DtgRem As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Cmdfacturar As System.Windows.Forms.Button
    Friend WithEvents DtgDFac As System.Windows.Forms.DataGridView
End Class
