<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBeq
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
        Me.TxtEquipo = New System.Windows.Forms.TextBox
        Me.DtgEqu = New System.Windows.Forms.DataGridView
        CType(Me.DtgEqu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(3, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese Numero o Nombre :"
        '
        'TxtEquipo
        '
        Me.TxtEquipo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEquipo.Location = New System.Drawing.Point(160, 8)
        Me.TxtEquipo.Name = "TxtEquipo"
        Me.TxtEquipo.Size = New System.Drawing.Size(223, 26)
        Me.TxtEquipo.TabIndex = 1
        '
        'DtgEqu
        '
        Me.DtgEqu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgEqu.Location = New System.Drawing.Point(6, 40)
        Me.DtgEqu.Name = "DtgEqu"
        Me.DtgEqu.Size = New System.Drawing.Size(377, 143)
        Me.DtgEqu.TabIndex = 2
        '
        'FrmBeq
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 187)
        Me.Controls.Add(Me.DtgEqu)
        Me.Controls.Add(Me.TxtEquipo)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmBeq"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Equipo "
        CType(Me.DtgEqu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtEquipo As System.Windows.Forms.TextBox
    Friend WithEvents DtgEqu As System.Windows.Forms.DataGridView
End Class
