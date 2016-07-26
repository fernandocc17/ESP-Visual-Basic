<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.dtp1 = New System.Windows.Forms.DateTimePicker
        Me.cmb_meses = New System.Windows.Forms.ComboBox
        Me.rtb_desglose = New System.Windows.Forms.RichTextBox
        Me.btn_accion = New System.Windows.Forms.Button
        Me.lbl_ultimo = New System.Windows.Forms.Label
        Me.lbl_desglose = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'dtp1
        '
        Me.dtp1.Location = New System.Drawing.Point(38, 32)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(200, 20)
        Me.dtp1.TabIndex = 0
        '
        'cmb_meses
        '
        Me.cmb_meses.FormattingEnabled = True
        Me.cmb_meses.Location = New System.Drawing.Point(266, 30)
        Me.cmb_meses.Name = "cmb_meses"
        Me.cmb_meses.Size = New System.Drawing.Size(121, 21)
        Me.cmb_meses.TabIndex = 1
        '
        'rtb_desglose
        '
        Me.rtb_desglose.Location = New System.Drawing.Point(38, 129)
        Me.rtb_desglose.Name = "rtb_desglose"
        Me.rtb_desglose.Size = New System.Drawing.Size(100, 96)
        Me.rtb_desglose.TabIndex = 2
        Me.rtb_desglose.Text = ""
        '
        'btn_accion
        '
        Me.btn_accion.Location = New System.Drawing.Point(430, 32)
        Me.btn_accion.Name = "btn_accion"
        Me.btn_accion.Size = New System.Drawing.Size(75, 23)
        Me.btn_accion.TabIndex = 3
        Me.btn_accion.Text = "Calcular"
        Me.btn_accion.UseVisualStyleBackColor = True
        '
        'lbl_ultimo
        '
        Me.lbl_ultimo.AutoSize = True
        Me.lbl_ultimo.Location = New System.Drawing.Point(38, 79)
        Me.lbl_ultimo.Name = "lbl_ultimo"
        Me.lbl_ultimo.Size = New System.Drawing.Size(62, 13)
        Me.lbl_ultimo.TabIndex = 4
        Me.lbl_ultimo.Text = "Fecha Final"
        '
        'lbl_desglose
        '
        Me.lbl_desglose.AutoSize = True
        Me.lbl_desglose.Location = New System.Drawing.Point(38, 110)
        Me.lbl_desglose.Name = "lbl_desglose"
        Me.lbl_desglose.Size = New System.Drawing.Size(51, 13)
        Me.lbl_desglose.TabIndex = 5
        Me.lbl_desglose.Text = "Desglose"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 262)
        Me.Controls.Add(Me.lbl_desglose)
        Me.Controls.Add(Me.lbl_ultimo)
        Me.Controls.Add(Me.btn_accion)
        Me.Controls.Add(Me.rtb_desglose)
        Me.Controls.Add(Me.cmb_meses)
        Me.Controls.Add(Me.dtp1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtp1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmb_meses As System.Windows.Forms.ComboBox
    Friend WithEvents rtb_desglose As System.Windows.Forms.RichTextBox
    Friend WithEvents btn_accion As System.Windows.Forms.Button
    Friend WithEvents lbl_ultimo As System.Windows.Forms.Label
    Friend WithEvents lbl_desglose As System.Windows.Forms.Label
End Class
