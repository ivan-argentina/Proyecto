<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIvaCompras
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
        Me.MskFecha = New System.Windows.Forms.MaskedTextBox
        Me.LbFecha = New System.Windows.Forms.Label
        Me.DtgIva = New System.Windows.Forms.DataGridView
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.BtnExportar = New System.Windows.Forms.Button
        Me.BtnPantalla = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.DtgIva, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MskFecha)
        Me.GroupBox1.Controls.Add(Me.LbFecha)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(83, 58)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'MskFecha
        '
        Me.MskFecha.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskFecha.Location = New System.Drawing.Point(6, 25)
        Me.MskFecha.Mask = "##/####"
        Me.MskFecha.Name = "MskFecha"
        Me.MskFecha.Size = New System.Drawing.Size(75, 26)
        Me.MskFecha.TabIndex = 1
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
        'DtgIva
        '
        Me.DtgIva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgIva.Location = New System.Drawing.Point(-108, 12)
        Me.DtgIva.Name = "DtgIva"
        Me.DtgIva.Size = New System.Drawing.Size(188, 54)
        Me.DtgIva.TabIndex = 2
        Me.DtgIva.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnExportar)
        Me.GroupBox2.Controls.Add(Me.BtnPantalla)
        Me.GroupBox2.Controls.Add(Me.DtgIva)
        Me.GroupBox2.Location = New System.Drawing.Point(95, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(148, 58)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'BtnExportar
        '
        Me.BtnExportar.Image = Global.Super.My.Resources.Resources.category
        Me.BtnExportar.Location = New System.Drawing.Point(76, 8)
        Me.BtnExportar.Name = "BtnExportar"
        Me.BtnExportar.Size = New System.Drawing.Size(71, 48)
        Me.BtnExportar.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.BtnExportar, "Exportar")
        Me.BtnExportar.UseVisualStyleBackColor = True
        '
        'BtnPantalla
        '
        Me.BtnPantalla.Image = Global.Super.My.Resources.Resources.Pantalla
        Me.BtnPantalla.Location = New System.Drawing.Point(3, 8)
        Me.BtnPantalla.Name = "BtnPantalla"
        Me.BtnPantalla.Size = New System.Drawing.Size(71, 48)
        Me.BtnPantalla.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.BtnPantalla, "Ver Libro de Iva Compras")
        Me.BtnPantalla.UseVisualStyleBackColor = True
        '
        'FrmIvaCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(250, 60)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmIvaCompras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Iva Compras"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DtgIva, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LbFecha As System.Windows.Forms.Label
    Friend WithEvents MskFecha As System.Windows.Forms.MaskedTextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnPantalla As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents BtnExportar As System.Windows.Forms.Button
    Friend WithEvents DtgIva As System.Windows.Forms.DataGridView
End Class
