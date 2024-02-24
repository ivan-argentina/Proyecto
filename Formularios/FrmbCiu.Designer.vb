<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmbCiu
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
        Me.Lbc = New System.Windows.Forms.Label
        Me.TxtCiu = New System.Windows.Forms.TextBox
        Me.DtgCiu = New System.Windows.Forms.DataGridView
        CType(Me.DtgCiu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lbc
        '
        Me.Lbc.AutoSize = True
        Me.Lbc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbc.ForeColor = System.Drawing.Color.Blue
        Me.Lbc.Location = New System.Drawing.Point(3, 26)
        Me.Lbc.Name = "Lbc"
        Me.Lbc.Size = New System.Drawing.Size(211, 14)
        Me.Lbc.TabIndex = 0
        Me.Lbc.Text = "Ingrese codigo o Nombre de Ciudad :"
        '
        'TxtCiu
        '
        Me.TxtCiu.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCiu.Location = New System.Drawing.Point(210, 19)
        Me.TxtCiu.Name = "TxtCiu"
        Me.TxtCiu.Size = New System.Drawing.Size(229, 26)
        Me.TxtCiu.TabIndex = 1
        '
        'DtgCiu
        '
        Me.DtgCiu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgCiu.Location = New System.Drawing.Point(1, 54)
        Me.DtgCiu.Name = "DtgCiu"
        Me.DtgCiu.Size = New System.Drawing.Size(437, 148)
        Me.DtgCiu.TabIndex = 2
        '
        'FrmbCiu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 204)
        Me.Controls.Add(Me.DtgCiu)
        Me.Controls.Add(Me.TxtCiu)
        Me.Controls.Add(Me.Lbc)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmbCiu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Ciudad"
        CType(Me.DtgCiu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbc As System.Windows.Forms.Label
    Friend WithEvents TxtCiu As System.Windows.Forms.TextBox
    Friend WithEvents DtgCiu As System.Windows.Forms.DataGridView
End Class
