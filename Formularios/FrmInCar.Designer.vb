<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInCar
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LbPtotal = New System.Windows.Forms.Label
        Me.MskPtotal = New System.Windows.Forms.MaskedTextBox
        Me.MskCantidad = New System.Windows.Forms.MaskedTextBox
        Me.LbCantidad = New System.Windows.Forms.Label
        Me.MskPunit = New System.Windows.Forms.MaskedTextBox
        Me.LbPunit = New System.Windows.Forms.Label
        Me.LbArticulo = New System.Windows.Forms.Label
        Me.TxtArticulo = New System.Windows.Forms.TextBox
        Me.DtcFecha = New System.Windows.Forms.DateTimePicker
        Me.LbFecha = New System.Windows.Forms.Label
        Me.DtgDet = New System.Windows.Forms.DataGridView
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TxTtotal = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GrpCerrar = New System.Windows.Forms.GroupBox
        Me.CmdGuardar = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.DtgDet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GrpCerrar.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LbPtotal)
        Me.GroupBox1.Controls.Add(Me.MskPtotal)
        Me.GroupBox1.Controls.Add(Me.MskCantidad)
        Me.GroupBox1.Controls.Add(Me.LbCantidad)
        Me.GroupBox1.Controls.Add(Me.MskPunit)
        Me.GroupBox1.Controls.Add(Me.LbPunit)
        Me.GroupBox1.Controls.Add(Me.LbArticulo)
        Me.GroupBox1.Controls.Add(Me.TxtArticulo)
        Me.GroupBox1.Controls.Add(Me.DtcFecha)
        Me.GroupBox1.Controls.Add(Me.LbFecha)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(631, 110)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'LbPtotal
        '
        Me.LbPtotal.AutoSize = True
        Me.LbPtotal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPtotal.ForeColor = System.Drawing.Color.Blue
        Me.LbPtotal.Location = New System.Drawing.Point(528, 63)
        Me.LbPtotal.Name = "LbPtotal"
        Me.LbPtotal.Size = New System.Drawing.Size(51, 14)
        Me.LbPtotal.TabIndex = 9
        Me.LbPtotal.Text = "P. Total :"
        '
        'MskPtotal
        '
        Me.MskPtotal.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskPtotal.Location = New System.Drawing.Point(528, 77)
        Me.MskPtotal.Name = "MskPtotal"
        Me.MskPtotal.Size = New System.Drawing.Size(97, 26)
        Me.MskPtotal.TabIndex = 8
        '
        'MskCantidad
        '
        Me.MskCantidad.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskCantidad.Location = New System.Drawing.Point(328, 77)
        Me.MskCantidad.Name = "MskCantidad"
        Me.MskCantidad.Size = New System.Drawing.Size(97, 26)
        Me.MskCantidad.TabIndex = 7
        '
        'LbCantidad
        '
        Me.LbCantidad.AutoSize = True
        Me.LbCantidad.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCantidad.ForeColor = System.Drawing.Color.Blue
        Me.LbCantidad.Location = New System.Drawing.Point(328, 63)
        Me.LbCantidad.Name = "LbCantidad"
        Me.LbCantidad.Size = New System.Drawing.Size(61, 14)
        Me.LbCantidad.TabIndex = 6
        Me.LbCantidad.Text = "Cantidad :"
        '
        'MskPunit
        '
        Me.MskPunit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskPunit.Location = New System.Drawing.Point(428, 77)
        Me.MskPunit.Name = "MskPunit"
        Me.MskPunit.Size = New System.Drawing.Size(97, 26)
        Me.MskPunit.TabIndex = 5
        '
        'LbPunit
        '
        Me.LbPunit.AutoSize = True
        Me.LbPunit.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPunit.ForeColor = System.Drawing.Color.Blue
        Me.LbPunit.Location = New System.Drawing.Point(428, 63)
        Me.LbPunit.Name = "LbPunit"
        Me.LbPunit.Size = New System.Drawing.Size(46, 14)
        Me.LbPunit.TabIndex = 4
        Me.LbPunit.Text = "P. Unit :"
        '
        'LbArticulo
        '
        Me.LbArticulo.AutoSize = True
        Me.LbArticulo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbArticulo.ForeColor = System.Drawing.Color.Blue
        Me.LbArticulo.Location = New System.Drawing.Point(6, 63)
        Me.LbArticulo.Name = "LbArticulo"
        Me.LbArticulo.Size = New System.Drawing.Size(56, 14)
        Me.LbArticulo.TabIndex = 3
        Me.LbArticulo.Text = "Articulo :"
        '
        'TxtArticulo
        '
        Me.TxtArticulo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtArticulo.Location = New System.Drawing.Point(6, 77)
        Me.TxtArticulo.Name = "TxtArticulo"
        Me.TxtArticulo.Size = New System.Drawing.Size(319, 26)
        Me.TxtArticulo.TabIndex = 2
        '
        'DtcFecha
        '
        Me.DtcFecha.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtcFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtcFecha.Location = New System.Drawing.Point(6, 25)
        Me.DtcFecha.Name = "DtcFecha"
        Me.DtcFecha.Size = New System.Drawing.Size(124, 26)
        Me.DtcFecha.TabIndex = 1
        '
        'LbFecha
        '
        Me.LbFecha.AutoSize = True
        Me.LbFecha.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFecha.ForeColor = System.Drawing.Color.Blue
        Me.LbFecha.Location = New System.Drawing.Point(6, 10)
        Me.LbFecha.Name = "LbFecha"
        Me.LbFecha.Size = New System.Drawing.Size(45, 14)
        Me.LbFecha.TabIndex = 0
        Me.LbFecha.Text = "Fecha :"
        '
        'DtgDet
        '
        Me.DtgDet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgDet.Location = New System.Drawing.Point(6, 125)
        Me.DtgDet.Name = "DtgDet"
        Me.DtgDet.Size = New System.Drawing.Size(631, 152)
        Me.DtgDet.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxTtotal)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(506, 283)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(130, 64)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'TxTtotal
        '
        Me.TxTtotal.Enabled = False
        Me.TxTtotal.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxTtotal.Location = New System.Drawing.Point(6, 24)
        Me.TxTtotal.Name = "TxTtotal"
        Me.TxTtotal.Size = New System.Drawing.Size(120, 26)
        Me.TxTtotal.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(6, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total :"
        '
        'GrpCerrar
        '
        Me.GrpCerrar.Controls.Add(Me.CmdGuardar)
        Me.GrpCerrar.Location = New System.Drawing.Point(288, 119)
        Me.GrpCerrar.Name = "GrpCerrar"
        Me.GrpCerrar.Size = New System.Drawing.Size(97, 59)
        Me.GrpCerrar.TabIndex = 10
        Me.GrpCerrar.TabStop = False
        Me.GrpCerrar.Visible = False
        '
        'CmdGuardar
        '
        Me.CmdGuardar.Image = Global.Super.My.Resources.Resources.save
        Me.CmdGuardar.Location = New System.Drawing.Point(6, 10)
        Me.CmdGuardar.Name = "CmdGuardar"
        Me.CmdGuardar.Size = New System.Drawing.Size(84, 43)
        Me.CmdGuardar.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.CmdGuardar, "Guardar Compra")
        Me.CmdGuardar.UseVisualStyleBackColor = True
        '
        'FrmInCar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(641, 352)
        Me.Controls.Add(Me.GrpCerrar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DtgDet)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmInCar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compras de Carne"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DtgDet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GrpCerrar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LbFecha As System.Windows.Forms.Label
    Friend WithEvents DtcFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents LbArticulo As System.Windows.Forms.Label
    Friend WithEvents TxtArticulo As System.Windows.Forms.TextBox
    Friend WithEvents MskPunit As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LbPunit As System.Windows.Forms.Label
    Friend WithEvents MskCantidad As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LbCantidad As System.Windows.Forms.Label
    Friend WithEvents LbPtotal As System.Windows.Forms.Label
    Friend WithEvents MskPtotal As System.Windows.Forms.MaskedTextBox
    Friend WithEvents DtgDet As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TxTtotal As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GrpCerrar As System.Windows.Forms.GroupBox
    Friend WithEvents CmdGuardar As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
