<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTrans
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
        Me.DtgArt = New System.Windows.Forms.DataGridView
        Me.Lb = New System.Windows.Forms.Label
        Me.CmdArticulos = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.DtcFecha = New System.Windows.Forms.DateTimePicker
        CType(Me.DtgArt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DtgArt
        '
        Me.DtgArt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgArt.Location = New System.Drawing.Point(4, 13)
        Me.DtgArt.Name = "DtgArt"
        Me.DtgArt.Size = New System.Drawing.Size(569, 236)
        Me.DtgArt.TabIndex = 0
        '
        'Lb
        '
        Me.Lb.AutoSize = True
        Me.Lb.Location = New System.Drawing.Point(68, 258)
        Me.Lb.Name = "Lb"
        Me.Lb.Size = New System.Drawing.Size(39, 13)
        Me.Lb.TabIndex = 1
        Me.Lb.Text = "Label1"
        '
        'CmdArticulos
        '
        Me.CmdArticulos.Location = New System.Drawing.Point(244, 265)
        Me.CmdArticulos.Name = "CmdArticulos"
        Me.CmdArticulos.Size = New System.Drawing.Size(73, 41)
        Me.CmdArticulos.TabIndex = 2
        Me.CmdArticulos.Text = "Articulos"
        Me.CmdArticulos.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(357, 265)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(66, 40)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Clientes"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DtcFecha
        '
        Me.DtcFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtcFecha.Location = New System.Drawing.Point(440, 273)
        Me.DtcFecha.Name = "DtcFecha"
        Me.DtcFecha.Size = New System.Drawing.Size(131, 20)
        Me.DtcFecha.TabIndex = 4
        Me.DtcFecha.Value = New Date(2017, 1, 1, 14, 57, 0, 0)
        '
        'FrmTrans
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 311)
        Me.Controls.Add(Me.DtcFecha)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CmdArticulos)
        Me.Controls.Add(Me.Lb)
        Me.Controls.Add(Me.DtgArt)
        Me.Name = "FrmTrans"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmTrans"
        CType(Me.DtgArt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DtgArt As System.Windows.Forms.DataGridView
    Friend WithEvents Lb As System.Windows.Forms.Label
    Friend WithEvents CmdArticulos As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DtcFecha As System.Windows.Forms.DateTimePicker
End Class
