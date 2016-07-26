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
        Me.Txt_Valor1 = New System.Windows.Forms.TextBox
        Me.Txt_Valor2 = New System.Windows.Forms.TextBox
        Me.Lbl_Resultado = New System.Windows.Forms.Label
        Me.Btn_Suma = New System.Windows.Forms.Button
        Me.Btn_Resta = New System.Windows.Forms.Button
        Me.Btn_Multiplicacion = New System.Windows.Forms.Button
        Me.Btn_Division = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Txt_Valor1
        '
        Me.Txt_Valor1.Location = New System.Drawing.Point(76, 42)
        Me.Txt_Valor1.Name = "Txt_Valor1"
        Me.Txt_Valor1.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Valor1.TabIndex = 0
        '
        'Txt_Valor2
        '
        Me.Txt_Valor2.Location = New System.Drawing.Point(76, 85)
        Me.Txt_Valor2.Name = "Txt_Valor2"
        Me.Txt_Valor2.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Valor2.TabIndex = 1
        '
        'Lbl_Resultado
        '
        Me.Lbl_Resultado.AutoSize = True
        Me.Lbl_Resultado.Location = New System.Drawing.Point(99, 124)
        Me.Lbl_Resultado.Name = "Lbl_Resultado"
        Me.Lbl_Resultado.Size = New System.Drawing.Size(55, 13)
        Me.Lbl_Resultado.TabIndex = 2
        Me.Lbl_Resultado.Text = "Resultado"
        '
        'Btn_Suma
        '
        Me.Btn_Suma.Location = New System.Drawing.Point(207, 27)
        Me.Btn_Suma.Name = "Btn_Suma"
        Me.Btn_Suma.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Suma.TabIndex = 3
        Me.Btn_Suma.Text = "Sumar"
        Me.Btn_Suma.UseVisualStyleBackColor = True
        '
        'Btn_Resta
        '
        Me.Btn_Resta.Location = New System.Drawing.Point(207, 56)
        Me.Btn_Resta.Name = "Btn_Resta"
        Me.Btn_Resta.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Resta.TabIndex = 4
        Me.Btn_Resta.Text = "Restar"
        Me.Btn_Resta.UseVisualStyleBackColor = True
        '
        'Btn_Multiplicacion
        '
        Me.Btn_Multiplicacion.Location = New System.Drawing.Point(207, 85)
        Me.Btn_Multiplicacion.Name = "Btn_Multiplicacion"
        Me.Btn_Multiplicacion.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Multiplicacion.TabIndex = 5
        Me.Btn_Multiplicacion.Text = "Multiplicar"
        Me.Btn_Multiplicacion.UseVisualStyleBackColor = True
        '
        'Btn_Division
        '
        Me.Btn_Division.Location = New System.Drawing.Point(207, 114)
        Me.Btn_Division.Name = "Btn_Division"
        Me.Btn_Division.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Division.TabIndex = 6
        Me.Btn_Division.Text = "Dividir"
        Me.Btn_Division.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(383, 295)
        Me.Controls.Add(Me.Btn_Division)
        Me.Controls.Add(Me.Btn_Multiplicacion)
        Me.Controls.Add(Me.Btn_Resta)
        Me.Controls.Add(Me.Btn_Suma)
        Me.Controls.Add(Me.Lbl_Resultado)
        Me.Controls.Add(Me.Txt_Valor2)
        Me.Controls.Add(Me.Txt_Valor1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Txt_Valor1 As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Valor2 As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Resultado As System.Windows.Forms.Label
    Friend WithEvents Btn_Suma As System.Windows.Forms.Button
    Friend WithEvents Btn_Resta As System.Windows.Forms.Button
    Friend WithEvents Btn_Multiplicacion As System.Windows.Forms.Button
    Friend WithEvents Btn_Division As System.Windows.Forms.Button

End Class
