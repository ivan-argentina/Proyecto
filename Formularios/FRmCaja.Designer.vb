<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRmCaja
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
        Me.DtgCaja = New System.Windows.Forms.DataGridView
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CmdPantalla = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DtcDesde = New System.Windows.Forms.DateTimePicker
        Me.LbCajero = New System.Windows.Forms.Label
        Me.CmbCajero = New System.Windows.Forms.ComboBox
        Me.LbFecha = New System.Windows.Forms.Label
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        CType(Me.DtgCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DtgCaja
        '
        Me.DtgCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgCaja.Location = New System.Drawing.Point(9, 12)
        Me.DtgCaja.Name = "DtgCaja"
        Me.DtgCaja.Size = New System.Drawing.Size(344, 62)
        Me.DtgCaja.TabIndex = 1
        Me.DtgCaja.Visible = False
        '
        'CmdPantalla
        '
        Me.CmdPantalla.Image = Global.Super.My.Resources.Resources.Pantalla
        Me.CmdPantalla.Location = New System.Drawing.Point(288, 11)
        Me.CmdPantalla.Name = "CmdPantalla"
        Me.CmdPantalla.Size = New System.Drawing.Size(65, 45)
        Me.CmdPantalla.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.CmdPantalla, "Ver la Caja")
        Me.CmdPantalla.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DtcDesde)
        Me.GroupBox1.Controls.Add(Me.LbCajero)
        Me.GroupBox1.Controls.Add(Me.CmbCajero)
        Me.GroupBox1.Controls.Add(Me.LbFecha)
        Me.GroupBox1.Controls.Add(Me.CmdPantalla)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(355, 62)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'DtcDesde
        '
        Me.DtcDesde.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtcDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtcDesde.Location = New System.Drawing.Point(9, 25)
        Me.DtcDesde.Name = "DtcDesde"
        Me.DtcDesde.Size = New System.Drawing.Size(105, 26)
        Me.DtcDesde.TabIndex = 8
        '
        'LbCajero
        '
        Me.LbCajero.AutoSize = True
        Me.LbCajero.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCajero.ForeColor = System.Drawing.Color.Blue
        Me.LbCajero.Location = New System.Drawing.Point(117, 10)
        Me.LbCajero.Name = "LbCajero"
        Me.LbCajero.Size = New System.Drawing.Size(55, 14)
        Me.LbCajero.TabIndex = 7
        Me.LbCajero.Text = "Usuario :"
        '
        'CmbCajero
        '
        Me.CmbCajero.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbCajero.FormatString = "d"
        Me.CmbCajero.FormattingEnabled = True
        Me.CmbCajero.Location = New System.Drawing.Point(117, 25)
        Me.CmbCajero.Name = "CmbCajero"
        Me.CmbCajero.Size = New System.Drawing.Size(165, 26)
        Me.CmbCajero.TabIndex = 6
        '
        'LbFecha
        '
        Me.LbFecha.AutoSize = True
        Me.LbFecha.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFecha.ForeColor = System.Drawing.Color.Blue
        Me.LbFecha.Location = New System.Drawing.Point(6, 10)
        Me.LbFecha.Name = "LbFecha"
        Me.LbFecha.Size = New System.Drawing.Size(43, 14)
        Me.LbFecha.TabIndex = 5
        Me.LbFecha.Text = "fecha :"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'FRmCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 127)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DtgCaja)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRmCaja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listar Caja"
        CType(Me.DtgCaja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DtgCaja As System.Windows.Forms.DataGridView
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LbFecha As System.Windows.Forms.Label
    Friend WithEvents CmdPantalla As System.Windows.Forms.Button
    Friend WithEvents LbCajero As System.Windows.Forms.Label
    Friend WithEvents CmbCajero As System.Windows.Forms.ComboBox
    Friend WithEvents DtcDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
End Class
