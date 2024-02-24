<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLdetVen
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
        Me.LbCajero = New System.Windows.Forms.Label
        Me.CmbCajero = New System.Windows.Forms.ComboBox
        Me.CmdPantalla = New System.Windows.Forms.Button
        Me.DtcFecha = New System.Windows.Forms.DateTimePicker
        Me.LbFecha = New System.Windows.Forms.Label
        Me.DtgDetVen = New System.Windows.Forms.DataGridView
        Me.GroupBox1.SuspendLayout()
        CType(Me.DtgDetVen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LbCajero)
        Me.GroupBox1.Controls.Add(Me.CmbCajero)
        Me.GroupBox1.Controls.Add(Me.CmdPantalla)
        Me.GroupBox1.Controls.Add(Me.DtcFecha)
        Me.GroupBox1.Controls.Add(Me.LbFecha)
        Me.GroupBox1.Controls.Add(Me.DtgDetVen)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(230, 100)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'LbCajero
        '
        Me.LbCajero.AutoSize = True
        Me.LbCajero.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCajero.ForeColor = System.Drawing.Color.Blue
        Me.LbCajero.Location = New System.Drawing.Point(6, 10)
        Me.LbCajero.Name = "LbCajero"
        Me.LbCajero.Size = New System.Drawing.Size(49, 14)
        Me.LbCajero.TabIndex = 4
        Me.LbCajero.Text = "Cajero :"
        '
        'CmbCajero
        '
        Me.CmbCajero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCajero.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbCajero.FormattingEnabled = True
        Me.CmbCajero.Location = New System.Drawing.Point(6, 24)
        Me.CmbCajero.Name = "CmbCajero"
        Me.CmbCajero.Size = New System.Drawing.Size(145, 26)
        Me.CmbCajero.TabIndex = 3
        '
        'CmdPantalla
        '
        Me.CmdPantalla.Image = Global.Super.My.Resources.Resources.Pantalla
        Me.CmdPantalla.Location = New System.Drawing.Point(155, 46)
        Me.CmdPantalla.Name = "CmdPantalla"
        Me.CmdPantalla.Size = New System.Drawing.Size(71, 48)
        Me.CmdPantalla.TabIndex = 2
        Me.CmdPantalla.UseVisualStyleBackColor = True
        '
        'DtcFecha
        '
        Me.DtcFecha.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtcFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtcFecha.Location = New System.Drawing.Point(6, 69)
        Me.DtcFecha.Name = "DtcFecha"
        Me.DtcFecha.Size = New System.Drawing.Size(119, 26)
        Me.DtcFecha.TabIndex = 1
        '
        'LbFecha
        '
        Me.LbFecha.AutoSize = True
        Me.LbFecha.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFecha.ForeColor = System.Drawing.Color.Blue
        Me.LbFecha.Location = New System.Drawing.Point(6, 55)
        Me.LbFecha.Name = "LbFecha"
        Me.LbFecha.Size = New System.Drawing.Size(45, 14)
        Me.LbFecha.TabIndex = 0
        Me.LbFecha.Text = "Fecha :"
        '
        'DtgDetVen
        '
        Me.DtgDetVen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgDetVen.Location = New System.Drawing.Point(184, 10)
        Me.DtgDetVen.Name = "DtgDetVen"
        Me.DtgDetVen.Size = New System.Drawing.Size(39, 47)
        Me.DtgDetVen.TabIndex = 1
        Me.DtgDetVen.Visible = False
        '
        'FrmLdetVen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(239, 117)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLdetVen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle de Ventas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DtgDetVen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LbCajero As System.Windows.Forms.Label
    Friend WithEvents CmbCajero As System.Windows.Forms.ComboBox
    Friend WithEvents CmdPantalla As System.Windows.Forms.Button
    Friend WithEvents DtcFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents LbFecha As System.Windows.Forms.Label
    Friend WithEvents DtgDetVen As System.Windows.Forms.DataGridView
End Class
