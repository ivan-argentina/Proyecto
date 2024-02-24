<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRmBAct
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtBact = New System.Windows.Forms.TextBox
        Me.DtgAct = New System.Windows.Forms.DataGridView
        CType(Me.DtgAct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(6, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese Codigo o Nombre de Actividad :"
        '
        'TxtBact
        '
        Me.TxtBact.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBact.Location = New System.Drawing.Point(230, 10)
        Me.TxtBact.Name = "TxtBact"
        Me.TxtBact.Size = New System.Drawing.Size(229, 26)
        Me.TxtBact.TabIndex = 1
        '
        'DtgAct
        '
        Me.DtgAct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgAct.Location = New System.Drawing.Point(12, 42)
        Me.DtgAct.Name = "DtgAct"
        Me.DtgAct.Size = New System.Drawing.Size(449, 159)
        Me.DtgAct.TabIndex = 2
        '
        'FRmBAct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 206)
        Me.Controls.Add(Me.DtgAct)
        Me.Controls.Add(Me.TxtBact)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRmBAct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Actividad"
        CType(Me.DtgAct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtBact As System.Windows.Forms.TextBox
    Friend WithEvents DtgAct As System.Windows.Forms.DataGridView
End Class
