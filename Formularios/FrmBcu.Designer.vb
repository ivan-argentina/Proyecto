<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBcu
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
        Me.LbTitulo = New System.Windows.Forms.Label
        Me.TxtCuenta = New System.Windows.Forms.TextBox
        Me.DtgCuenta = New System.Windows.Forms.DataGridView
        CType(Me.DtgCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LbTitulo
        '
        Me.LbTitulo.AutoSize = True
        Me.LbTitulo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTitulo.ForeColor = System.Drawing.Color.Blue
        Me.LbTitulo.Location = New System.Drawing.Point(6, 13)
        Me.LbTitulo.Name = "LbTitulo"
        Me.LbTitulo.Size = New System.Drawing.Size(174, 14)
        Me.LbTitulo.TabIndex = 0
        Me.LbTitulo.Text = "Ingrese Nombre de la Cuenta :"
        '
        'TxtCuenta
        '
        Me.TxtCuenta.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCuenta.Location = New System.Drawing.Point(178, 8)
        Me.TxtCuenta.Name = "TxtCuenta"
        Me.TxtCuenta.Size = New System.Drawing.Size(246, 26)
        Me.TxtCuenta.TabIndex = 1
        '
        'DtgCuenta
        '
        Me.DtgCuenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgCuenta.Location = New System.Drawing.Point(6, 40)
        Me.DtgCuenta.Name = "DtgCuenta"
        Me.DtgCuenta.Size = New System.Drawing.Size(418, 169)
        Me.DtgCuenta.TabIndex = 2
        '
        'FrmBcu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 214)
        Me.Controls.Add(Me.DtgCuenta)
        Me.Controls.Add(Me.TxtCuenta)
        Me.Controls.Add(Me.LbTitulo)
        Me.Name = "FrmBcu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar una Cuenta"
        CType(Me.DtgCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LbTitulo As System.Windows.Forms.Label
    Friend WithEvents TxtCuenta As System.Windows.Forms.TextBox
    Friend WithEvents DtgCuenta As System.Windows.Forms.DataGridView
End Class
