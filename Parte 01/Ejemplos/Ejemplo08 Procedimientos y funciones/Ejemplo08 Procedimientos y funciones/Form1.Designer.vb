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
        Me.btn_suma = New System.Windows.Forms.Button
        Me.lbl_res = New System.Windows.Forms.Label
        Me.txt_n1 = New System.Windows.Forms.TextBox
        Me.txt_n2 = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'btn_suma
        '
        Me.btn_suma.Location = New System.Drawing.Point(219, 45)
        Me.btn_suma.Name = "btn_suma"
        Me.btn_suma.Size = New System.Drawing.Size(75, 23)
        Me.btn_suma.TabIndex = 0
        Me.btn_suma.Text = "Suma"
        Me.btn_suma.UseVisualStyleBackColor = True
        '
        'lbl_res
        '
        Me.lbl_res.AutoSize = True
        Me.lbl_res.Location = New System.Drawing.Point(78, 165)
        Me.lbl_res.Name = "lbl_res"
        Me.lbl_res.Size = New System.Drawing.Size(55, 13)
        Me.lbl_res.TabIndex = 1
        Me.lbl_res.Text = "Resultado"
        '
        'txt_n1
        '
        Me.txt_n1.Location = New System.Drawing.Point(55, 45)
        Me.txt_n1.Name = "txt_n1"
        Me.txt_n1.Size = New System.Drawing.Size(100, 20)
        Me.txt_n1.TabIndex = 2
        '
        'txt_n2
        '
        Me.txt_n2.Location = New System.Drawing.Point(55, 98)
        Me.txt_n2.Name = "txt_n2"
        Me.txt_n2.Size = New System.Drawing.Size(100, 20)
        Me.txt_n2.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 308)
        Me.Controls.Add(Me.txt_n2)
        Me.Controls.Add(Me.txt_n1)
        Me.Controls.Add(Me.lbl_res)
        Me.Controls.Add(Me.btn_suma)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_suma As System.Windows.Forms.Button
    Friend WithEvents lbl_res As System.Windows.Forms.Label
    Friend WithEvents txt_n1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_n2 As System.Windows.Forms.TextBox

End Class
