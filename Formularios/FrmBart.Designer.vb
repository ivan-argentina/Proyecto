<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBart
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
        Me.LbPrecio = New System.Windows.Forms.Label
        Me.LbArticulo = New System.Windows.Forms.Label
        Me.TxtBarra = New System.Windows.Forms.TextBox
        Me.LbBarra = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LbPrecio)
        Me.GroupBox1.Controls.Add(Me.LbArticulo)
        Me.GroupBox1.Controls.Add(Me.TxtBarra)
        Me.GroupBox1.Controls.Add(Me.LbBarra)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(371, 149)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'LbPrecio
        '
        Me.LbPrecio.AutoSize = True
        Me.LbPrecio.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPrecio.ForeColor = System.Drawing.Color.Blue
        Me.LbPrecio.Location = New System.Drawing.Point(6, 100)
        Me.LbPrecio.Name = "LbPrecio"
        Me.LbPrecio.Size = New System.Drawing.Size(74, 24)
        Me.LbPrecio.TabIndex = 2
        Me.LbPrecio.Text = "Precio"
        '
        'LbArticulo
        '
        Me.LbArticulo.AutoSize = True
        Me.LbArticulo.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbArticulo.ForeColor = System.Drawing.Color.Blue
        Me.LbArticulo.Location = New System.Drawing.Point(6, 65)
        Me.LbArticulo.Name = "LbArticulo"
        Me.LbArticulo.Size = New System.Drawing.Size(82, 22)
        Me.LbArticulo.TabIndex = 1
        Me.LbArticulo.Text = "Articulo"
        '
        'TxtBarra
        '
        Me.TxtBarra.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBarra.Location = New System.Drawing.Point(6, 24)
        Me.TxtBarra.Name = "TxtBarra"
        Me.TxtBarra.Size = New System.Drawing.Size(174, 29)
        Me.TxtBarra.TabIndex = 0
        '
        'LbBarra
        '
        Me.LbBarra.AutoSize = True
        Me.LbBarra.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbBarra.ForeColor = System.Drawing.Color.Blue
        Me.LbBarra.Location = New System.Drawing.Point(6, 10)
        Me.LbBarra.Name = "LbBarra"
        Me.LbBarra.Size = New System.Drawing.Size(42, 14)
        Me.LbBarra.TabIndex = 0
        Me.LbBarra.Text = "Barra :"
        '
        'FrmBart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 167)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmBart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Articulo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LbBarra As System.Windows.Forms.Label
    Friend WithEvents TxtBarra As System.Windows.Forms.TextBox
    Friend WithEvents LbPrecio As System.Windows.Forms.Label
    Friend WithEvents LbArticulo As System.Windows.Forms.Label
End Class
