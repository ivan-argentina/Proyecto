<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLSalCli
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
        Me.LbHasta = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.BtnPantalla = New System.Windows.Forms.Button
        Me.DtgSl = New System.Windows.Forms.DataGridView
        Me.EventLog1 = New System.Diagnostics.EventLog
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DtgSl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MskFecha)
        Me.GroupBox1.Controls.Add(Me.LbHasta)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(109, 55)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'MskFecha
        '
        Me.MskFecha.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskFecha.Location = New System.Drawing.Point(6, 24)
        Me.MskFecha.Mask = "##/##/####"
        Me.MskFecha.Name = "MskFecha"
        Me.MskFecha.Size = New System.Drawing.Size(98, 26)
        Me.MskFecha.TabIndex = 2
        '
        'LbHasta
        '
        Me.LbHasta.AutoSize = True
        Me.LbHasta.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbHasta.ForeColor = System.Drawing.Color.Blue
        Me.LbHasta.Location = New System.Drawing.Point(6, 10)
        Me.LbHasta.Name = "LbHasta"
        Me.LbHasta.Size = New System.Drawing.Size(43, 14)
        Me.LbHasta.TabIndex = 1
        Me.LbHasta.Text = "Hasta :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnPantalla)
        Me.GroupBox2.Location = New System.Drawing.Point(115, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(70, 55)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'BtnPantalla
        '
        Me.BtnPantalla.Image = Global.Super.My.Resources.Resources.Pantalla
        Me.BtnPantalla.Location = New System.Drawing.Point(3, 10)
        Me.BtnPantalla.Name = "BtnPantalla"
        Me.BtnPantalla.Size = New System.Drawing.Size(66, 43)
        Me.BtnPantalla.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.BtnPantalla, "Ver Listado de Saldos")
        Me.BtnPantalla.UseVisualStyleBackColor = True
        '
        'DtgSl
        '
        Me.DtgSl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgSl.Location = New System.Drawing.Point(9, 10)
        Me.DtgSl.Name = "DtgSl"
        Me.DtgSl.Size = New System.Drawing.Size(159, 40)
        Me.DtgSl.TabIndex = 4
        Me.DtgSl.Visible = False
        '
        'EventLog1
        '
        Me.EventLog1.SynchronizingObject = Me
        '
        'FrmLSalCli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(187, 59)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DtgSl)
        Me.Name = "FrmLSalCli"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Saldos Por Clientes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DtgSl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LbHasta As System.Windows.Forms.Label
    Friend WithEvents MskFecha As System.Windows.Forms.MaskedTextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnPantalla As System.Windows.Forms.Button
    Friend WithEvents DtgSl As System.Windows.Forms.DataGridView
    Friend WithEvents EventLog1 As System.Diagnostics.EventLog
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
