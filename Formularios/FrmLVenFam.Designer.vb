<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLVenFam
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
        Me.DtgVen = New System.Windows.Forms.DataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CmdPantalla = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DtcHas = New System.Windows.Forms.DateTimePicker
        Me.DtcDes = New System.Windows.Forms.DateTimePicker
        Me.LbHasta = New System.Windows.Forms.Label
        Me.LbFecha = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.DtgVen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DtgVen
        '
        Me.DtgVen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgVen.Location = New System.Drawing.Point(95, 71)
        Me.DtgVen.Name = "DtgVen"
        Me.DtgVen.Size = New System.Drawing.Size(92, 39)
        Me.DtgVen.TabIndex = 0
        Me.DtgVen.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CmdPantalla)
        Me.GroupBox1.Location = New System.Drawing.Point(152, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(75, 60)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'CmdPantalla
        '
        Me.CmdPantalla.Image = Global.Super.My.Resources.Resources.Pantalla
        Me.CmdPantalla.Location = New System.Drawing.Point(6, 10)
        Me.CmdPantalla.Name = "CmdPantalla"
        Me.CmdPantalla.Size = New System.Drawing.Size(65, 48)
        Me.CmdPantalla.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.CmdPantalla, "Ventas por Familias")
        Me.CmdPantalla.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DtcHas)
        Me.GroupBox2.Controls.Add(Me.DtcDes)
        Me.GroupBox2.Controls.Add(Me.LbHasta)
        Me.GroupBox2.Controls.Add(Me.LbFecha)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(224, 55)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'DtcHas
        '
        Me.DtcHas.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtcHas.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtcHas.Location = New System.Drawing.Point(115, 26)
        Me.DtcHas.Name = "DtcHas"
        Me.DtcHas.Size = New System.Drawing.Size(105, 26)
        Me.DtcHas.TabIndex = 5
        '
        'DtcDes
        '
        Me.DtcDes.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtcDes.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtcDes.Location = New System.Drawing.Point(6, 26)
        Me.DtcDes.Name = "DtcDes"
        Me.DtcDes.Size = New System.Drawing.Size(105, 26)
        Me.DtcDes.TabIndex = 4
        '
        'LbHasta
        '
        Me.LbHasta.AutoSize = True
        Me.LbHasta.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbHasta.ForeColor = System.Drawing.Color.Blue
        Me.LbHasta.Location = New System.Drawing.Point(115, 12)
        Me.LbHasta.Name = "LbHasta"
        Me.LbHasta.Size = New System.Drawing.Size(43, 14)
        Me.LbHasta.TabIndex = 2
        Me.LbHasta.Text = "Hasta :"
        '
        'LbFecha
        '
        Me.LbFecha.AutoSize = True
        Me.LbFecha.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFecha.ForeColor = System.Drawing.Color.Blue
        Me.LbFecha.Location = New System.Drawing.Point(3, 12)
        Me.LbFecha.Name = "LbFecha"
        Me.LbFecha.Size = New System.Drawing.Size(48, 14)
        Me.LbFecha.TabIndex = 1
        Me.LbFecha.Text = "Desde :"
        '
        'FrmLVenFam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(236, 126)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DtgVen)
        Me.Name = "FrmLVenFam"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas por Familia"
        CType(Me.DtgVen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DtgVen As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdPantalla As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DtcHas As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtcDes As System.Windows.Forms.DateTimePicker
    Friend WithEvents LbHasta As System.Windows.Forms.Label
    Friend WithEvents LbFecha As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
