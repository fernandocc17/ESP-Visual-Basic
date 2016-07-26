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
        Me.btn_sumar = New System.Windows.Forms.Button()
        Me.btn_restar = New System.Windows.Forms.Button()
        Me.btn_multiplicar = New System.Windows.Forms.Button()
        Me.btn_dividir = New System.Windows.Forms.Button()
        Me.txt_n1 = New System.Windows.Forms.TextBox()
        Me.txt_n2 = New System.Windows.Forms.TextBox()
        Me.lbl_resultado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_sumar
        '
        Me.btn_sumar.Location = New System.Drawing.Point(205, 107)
        Me.btn_sumar.Name = "btn_sumar"
        Me.btn_sumar.Size = New System.Drawing.Size(75, 23)
        Me.btn_sumar.TabIndex = 0
        Me.btn_sumar.Text = "Sumar"
        Me.btn_sumar.UseVisualStyleBackColor = True
        '
        'btn_restar
        '
        Me.btn_restar.Location = New System.Drawing.Point(301, 107)
        Me.btn_restar.Name = "btn_restar"
        Me.btn_restar.Size = New System.Drawing.Size(75, 23)
        Me.btn_restar.TabIndex = 1
        Me.btn_restar.Text = "Restar"
        Me.btn_restar.UseVisualStyleBackColor = True
        '
        'btn_multiplicar
        '
        Me.btn_multiplicar.Location = New System.Drawing.Point(205, 148)
        Me.btn_multiplicar.Name = "btn_multiplicar"
        Me.btn_multiplicar.Size = New System.Drawing.Size(75, 23)
        Me.btn_multiplicar.TabIndex = 2
        Me.btn_multiplicar.Text = "Multiplicar"
        Me.btn_multiplicar.UseVisualStyleBackColor = True
        '
        'btn_dividir
        '
        Me.btn_dividir.Location = New System.Drawing.Point(301, 148)
        Me.btn_dividir.Name = "btn_dividir"
        Me.btn_dividir.Size = New System.Drawing.Size(75, 23)
        Me.btn_dividir.TabIndex = 3
        Me.btn_dividir.Text = "Dividir"
        Me.btn_dividir.UseVisualStyleBackColor = True
        '
        'txt_n1
        '
        Me.txt_n1.Location = New System.Drawing.Point(32, 107)
        Me.txt_n1.Name = "txt_n1"
        Me.txt_n1.Size = New System.Drawing.Size(100, 20)
        Me.txt_n1.TabIndex = 4
        '
        'txt_n2
        '
        Me.txt_n2.Location = New System.Drawing.Point(32, 148)
        Me.txt_n2.Name = "txt_n2"
        Me.txt_n2.Size = New System.Drawing.Size(100, 20)
        Me.txt_n2.TabIndex = 5
        '
        'lbl_resultado
        '
        Me.lbl_resultado.AutoSize = True
        Me.lbl_resultado.Location = New System.Drawing.Point(301, 207)
        Me.lbl_resultado.Name = "lbl_resultado"
        Me.lbl_resultado.Size = New System.Drawing.Size(55, 13)
        Me.lbl_resultado.TabIndex = 6
        Me.lbl_resultado.Text = "Resultado"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 368)
        Me.Controls.Add(Me.lbl_resultado)
        Me.Controls.Add(Me.txt_n2)
        Me.Controls.Add(Me.txt_n1)
        Me.Controls.Add(Me.btn_dividir)
        Me.Controls.Add(Me.btn_multiplicar)
        Me.Controls.Add(Me.btn_restar)
        Me.Controls.Add(Me.btn_sumar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_sumar As System.Windows.Forms.Button
    Friend WithEvents btn_restar As System.Windows.Forms.Button
    Friend WithEvents btn_multiplicar As System.Windows.Forms.Button
    Friend WithEvents btn_dividir As System.Windows.Forms.Button
    Friend WithEvents txt_n1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_n2 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_resultado As System.Windows.Forms.Label

End Class
