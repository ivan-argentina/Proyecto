<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBPres
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
        Me.DtgPres = New System.Windows.Forms.DataGridView
        Me.DtgArt = New System.Windows.Forms.DataGridView
        CType(Me.DtgPres, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtgArt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DtgPres
        '
        Me.DtgPres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgPres.Location = New System.Drawing.Point(3, 2)
        Me.DtgPres.Name = "DtgPres"
        Me.DtgPres.Size = New System.Drawing.Size(913, 396)
        Me.DtgPres.TabIndex = 0
        '
        'DtgArt
        '
        Me.DtgArt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgArt.Location = New System.Drawing.Point(204, 324)
        Me.DtgArt.Name = "DtgArt"
        Me.DtgArt.Size = New System.Drawing.Size(94, 20)
        Me.DtgArt.TabIndex = 1
        Me.DtgArt.Visible = False
        '
        'FrmBPres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(918, 404)
        Me.Controls.Add(Me.DtgArt)
        Me.Controls.Add(Me.DtgPres)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmBPres"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Presupuestos"
        CType(Me.DtgPres, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtgArt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DtgPres As System.Windows.Forms.DataGridView
    Friend WithEvents DtgArt As System.Windows.Forms.DataGridView
End Class
