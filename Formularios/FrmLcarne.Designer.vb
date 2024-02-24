<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLcarne
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
        Me.DtcHasta = New System.Windows.Forms.DateTimePicker
        Me.LbHasta = New System.Windows.Forms.Label
        Me.DtcDesde = New System.Windows.Forms.DateTimePicker
        Me.LbDesde = New System.Windows.Forms.Label
        Me.DtgV = New System.Windows.Forms.DataGridView
        Me.GroupBox1.SuspendLayout()
        CType(Me.DtgV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CmdPantalla)
        Me.GroupBox1.Controls.Add(Me.DtcHasta)
        Me.GroupBox1.Controls.Add(Me.LbHasta)
        Me.GroupBox1.Controls.Add(Me.DtcDesde)
        Me.GroupBox1.Controls.Add(Me.LbDesde)
        Me.GroupBox1.Controls.Add(Me.DtgV)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(315, 58)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'CmdPantalla
        '
        Me.CmdPantalla.Image = Global.Super.My.Resources.Resources.Pantalla
        Me.CmdPantalla.Location = New System.Drawing.Point(246, 10)
        Me.CmdPantalla.Name = "CmdPantalla"
        Me.CmdPantalla.Size = New System.Drawing.Size(65, 45)
        Me.CmdPantalla.TabIndex = 5
        Me.CmdPantalla.UseVisualStyleBackColor = True
        '
        'DtcHasta
        '
        Me.DtcHasta.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtcHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtcHasta.Location = New System.Drawing.Point(125, 24)
        Me.DtcHasta.Name = "DtcHasta"
        Me.DtcHasta.Size = New System.Drawing.Size(115, 26)
        Me.DtcHasta.TabIndex = 3
        '
        'LbHasta
        '
        Me.LbHasta.AutoSize = True
        Me.LbHasta.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbHasta.ForeColor = System.Drawing.Color.Blue
        Me.LbHasta.Location = New System.Drawing.Point(125, 10)
        Me.LbHasta.Name = "LbHasta"
        Me.LbHasta.Size = New System.Drawing.Size(43, 14)
        Me.LbHasta.TabIndex = 2
        Me.LbHasta.Text = "Hasta :"
        '
        'DtcDesde
        '
        Me.DtcDesde.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtcDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtcDesde.Location = New System.Drawing.Point(6, 24)
        Me.DtcDesde.Name = "DtcDesde"
        Me.DtcDesde.Size = New System.Drawing.Size(115, 26)
        Me.DtcDesde.TabIndex = 1
        '
        'LbDesde
        '
        Me.LbDesde.AutoSize = True
        Me.LbDesde.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDesde.ForeColor = System.Drawing.Color.Blue
        Me.LbDesde.Location = New System.Drawing.Point(6, 10)
        Me.LbDesde.Name = "LbDesde"
        Me.LbDesde.Size = New System.Drawing.Size(48, 14)
        Me.LbDesde.TabIndex = 0
        Me.LbDesde.Text = "Desde :"
        '
        'DtgV
        '
        Me.DtgV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgV.Location = New System.Drawing.Point(6, 27)
        Me.DtgV.Name = "DtgV"
        Me.DtgV.Size = New System.Drawing.Size(234, 20)
        Me.DtgV.TabIndex = 2
        Me.DtgV.Visible = False
        '
        'FrmLcarne
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(328, 73)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmLcarne"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas de Carne"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DtgV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdPantalla As System.Windows.Forms.Button
    Friend WithEvents DtcHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents LbHasta As System.Windows.Forms.Label
    Friend WithEvents DtcDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents LbDesde As System.Windows.Forms.Label
    Friend WithEvents DtgV As System.Windows.Forms.DataGridView
End Class
