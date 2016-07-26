<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txt_receptor = New System.Windows.Forms.TextBox()
        Me.lbl_resultado = New System.Windows.Forms.Label()
        Me.btn_pasar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_receptor
        '
        Me.txt_receptor.Location = New System.Drawing.Point(41, 41)
        Me.txt_receptor.Name = "txt_receptor"
        Me.txt_receptor.Size = New System.Drawing.Size(100, 20)
        Me.txt_receptor.TabIndex = 0
        '
        'lbl_resultado
        '
        Me.lbl_resultado.AutoSize = True
        Me.lbl_resultado.Location = New System.Drawing.Point(172, 47)
        Me.lbl_resultado.Name = "lbl_resultado"
        Me.lbl_resultado.Size = New System.Drawing.Size(0, 13)
        Me.lbl_resultado.TabIndex = 1
        '
        'btn_pasar
        '
        Me.btn_pasar.Location = New System.Drawing.Point(41, 114)
        Me.btn_pasar.Name = "btn_pasar"
        Me.btn_pasar.Size = New System.Drawing.Size(170, 23)
        Me.btn_pasar.TabIndex = 2
        Me.btn_pasar.Text = "Pasar el texto"
        Me.btn_pasar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.btn_pasar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btn_pasar)
        Me.Controls.Add(Me.lbl_resultado)
        Me.Controls.Add(Me.txt_receptor)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_receptor As System.Windows.Forms.TextBox
    Friend WithEvents lbl_resultado As System.Windows.Forms.Label
    Friend WithEvents btn_pasar As System.Windows.Forms.Button

End Class
