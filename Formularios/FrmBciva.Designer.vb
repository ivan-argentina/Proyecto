﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBciva
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtCiva = New System.Windows.Forms.TextBox
        Me.DtgCiva = New System.Windows.Forms.DataGridView
        CType(Me.DtgCiva, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(3, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(221, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese Codigo o Nombre de C. de Iva :"
        '
        'TxtCiva
        '
        Me.TxtCiva.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCiva.Location = New System.Drawing.Point(222, 19)
        Me.TxtCiva.Name = "TxtCiva"
        Me.TxtCiva.Size = New System.Drawing.Size(206, 26)
        Me.TxtCiva.TabIndex = 1
        '
        'DtgCiva
        '
        Me.DtgCiva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgCiva.Location = New System.Drawing.Point(3, 51)
        Me.DtgCiva.Name = "DtgCiva"
        Me.DtgCiva.Size = New System.Drawing.Size(425, 119)
        Me.DtgCiva.TabIndex = 2
        '
        'FrmBciva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 173)
        Me.Controls.Add(Me.DtgCiva)
        Me.Controls.Add(Me.TxtCiva)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmBciva"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Condicion de Iva :"
        CType(Me.DtgCiva, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtCiva As System.Windows.Forms.TextBox
    Friend WithEvents DtgCiva As System.Windows.Forms.DataGridView
End Class
