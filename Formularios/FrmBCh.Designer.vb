<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBCh
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
        Me.DtgCheque = New System.Windows.Forms.DataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CmdConfirmar = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.LbDvenc = New System.Windows.Forms.Label
        Me.DtcFecha = New System.Windows.Forms.DateTimePicker
        Me.MskEnt = New System.Windows.Forms.MaskedTextBox
        Me.LbNumero = New System.Windows.Forms.Label
        Me.LbComp = New System.Windows.Forms.Label
        Me.TxtNum = New System.Windows.Forms.TextBox
        Me.TxtComp = New System.Windows.Forms.TextBox
        Me.LbEntrega = New System.Windows.Forms.Label
        CType(Me.DtgCheque, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DtgCheque
        '
        Me.DtgCheque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgCheque.Location = New System.Drawing.Point(6, 65)
        Me.DtgCheque.Name = "DtgCheque"
        Me.DtgCheque.Size = New System.Drawing.Size(585, 204)
        Me.DtgCheque.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CmdConfirmar)
        Me.GroupBox1.Location = New System.Drawing.Point(511, 275)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(80, 57)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'CmdConfirmar
        '
        Me.CmdConfirmar.Image = Global.Super.My.Resources.Resources.Pantalla
        Me.CmdConfirmar.Location = New System.Drawing.Point(6, 11)
        Me.CmdConfirmar.Name = "CmdConfirmar"
        Me.CmdConfirmar.Size = New System.Drawing.Size(66, 46)
        Me.CmdConfirmar.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.CmdConfirmar, "Confirmar")
        Me.CmdConfirmar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LbDvenc)
        Me.GroupBox3.Controls.Add(Me.DtcFecha)
        Me.GroupBox3.Controls.Add(Me.MskEnt)
        Me.GroupBox3.Controls.Add(Me.LbNumero)
        Me.GroupBox3.Controls.Add(Me.LbComp)
        Me.GroupBox3.Controls.Add(Me.TxtNum)
        Me.GroupBox3.Controls.Add(Me.TxtComp)
        Me.GroupBox3.Controls.Add(Me.LbEntrega)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(439, 56)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        '
        'LbDvenc
        '
        Me.LbDvenc.AutoSize = True
        Me.LbDvenc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDvenc.ForeColor = System.Drawing.Color.Blue
        Me.LbDvenc.Location = New System.Drawing.Point(227, 10)
        Me.LbDvenc.Name = "LbDvenc"
        Me.LbDvenc.Size = New System.Drawing.Size(76, 14)
        Me.LbDvenc.TabIndex = 12
        Me.LbDvenc.Text = "Vencimiento"
        '
        'DtcFecha
        '
        Me.DtcFecha.Enabled = False
        Me.DtcFecha.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtcFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtcFecha.Location = New System.Drawing.Point(227, 25)
        Me.DtcFecha.Name = "DtcFecha"
        Me.DtcFecha.Size = New System.Drawing.Size(105, 26)
        Me.DtcFecha.TabIndex = 11
        '
        'MskEnt
        '
        Me.MskEnt.Enabled = False
        Me.MskEnt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskEnt.Location = New System.Drawing.Point(335, 25)
        Me.MskEnt.Name = "MskEnt"
        Me.MskEnt.Size = New System.Drawing.Size(100, 26)
        Me.MskEnt.TabIndex = 10
        '
        'LbNumero
        '
        Me.LbNumero.AutoSize = True
        Me.LbNumero.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNumero.ForeColor = System.Drawing.Color.Blue
        Me.LbNumero.Location = New System.Drawing.Point(125, 10)
        Me.LbNumero.Name = "LbNumero"
        Me.LbNumero.Size = New System.Drawing.Size(57, 14)
        Me.LbNumero.TabIndex = 9
        Me.LbNumero.Text = "Numero :"
        '
        'LbComp
        '
        Me.LbComp.AutoSize = True
        Me.LbComp.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbComp.ForeColor = System.Drawing.Color.Blue
        Me.LbComp.Location = New System.Drawing.Point(6, 10)
        Me.LbComp.Name = "LbComp"
        Me.LbComp.Size = New System.Drawing.Size(89, 14)
        Me.LbComp.TabIndex = 8
        Me.LbComp.Text = "Comprobante :"
        '
        'TxtNum
        '
        Me.TxtNum.Enabled = False
        Me.TxtNum.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNum.Location = New System.Drawing.Point(125, 25)
        Me.TxtNum.Name = "TxtNum"
        Me.TxtNum.Size = New System.Drawing.Size(97, 26)
        Me.TxtNum.TabIndex = 7
        '
        'TxtComp
        '
        Me.TxtComp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtComp.Location = New System.Drawing.Point(6, 25)
        Me.TxtComp.Name = "TxtComp"
        Me.TxtComp.Size = New System.Drawing.Size(115, 26)
        Me.TxtComp.TabIndex = 6
        '
        'LbEntrega
        '
        Me.LbEntrega.AutoSize = True
        Me.LbEntrega.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbEntrega.ForeColor = System.Drawing.Color.Blue
        Me.LbEntrega.Location = New System.Drawing.Point(335, 10)
        Me.LbEntrega.Name = "LbEntrega"
        Me.LbEntrega.Size = New System.Drawing.Size(55, 14)
        Me.LbEntrega.TabIndex = 4
        Me.LbEntrega.Text = "Entrega :"
        '
        'FrmBCh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 338)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DtgCheque)
        Me.Name = "FrmBCh"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cheques en Cartera"
        CType(Me.DtgCheque, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DtgCheque As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdConfirmar As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents LbDvenc As System.Windows.Forms.Label
    Friend WithEvents DtcFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents MskEnt As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LbNumero As System.Windows.Forms.Label
    Friend WithEvents LbComp As System.Windows.Forms.Label
    Friend WithEvents TxtNum As System.Windows.Forms.TextBox
    Friend WithEvents TxtComp As System.Windows.Forms.TextBox
    Friend WithEvents LbEntrega As System.Windows.Forms.Label
End Class
