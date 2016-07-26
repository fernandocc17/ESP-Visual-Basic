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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.etiquetaEjemplo2 = New System.Windows.Forms.Label()
        Me.numeroEjemplo2 = New System.Windows.Forms.TextBox()
        Me.botonEjemplo2 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.resultado = New System.Windows.Forms.Label()
        Me.num1 = New System.Windows.Forms.TextBox()
        Me.num2 = New System.Windows.Forms.TextBox()
        Me.num3 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(420, 117)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Uso de \ y Mod"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Segundos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(200, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Minutos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(200, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Segundos"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(81, 32)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(273, 32)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 4
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(273, 70)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(23, 73)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(158, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Calcular"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.botonEjemplo2)
        Me.GroupBox2.Controls.Add(Me.numeroEjemplo2)
        Me.GroupBox2.Controls.Add(Me.etiquetaEjemplo2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(22, 147)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(420, 121)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Uso de Valores Logicos y Concatenacion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Numero"
        '
        'etiquetaEjemplo2
        '
        Me.etiquetaEjemplo2.AutoSize = True
        Me.etiquetaEjemplo2.Location = New System.Drawing.Point(201, 39)
        Me.etiquetaEjemplo2.Name = "etiquetaEjemplo2"
        Me.etiquetaEjemplo2.Size = New System.Drawing.Size(81, 13)
        Me.etiquetaEjemplo2.TabIndex = 1
        Me.etiquetaEjemplo2.Text = "Numero valido?"
        '
        'numeroEjemplo2
        '
        Me.numeroEjemplo2.Location = New System.Drawing.Point(82, 36)
        Me.numeroEjemplo2.Name = "numeroEjemplo2"
        Me.numeroEjemplo2.Size = New System.Drawing.Size(100, 20)
        Me.numeroEjemplo2.TabIndex = 2
        Me.numeroEjemplo2.Text = "0"
        Me.numeroEjemplo2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'botonEjemplo2
        '
        Me.botonEjemplo2.Location = New System.Drawing.Point(124, 76)
        Me.botonEjemplo2.Name = "botonEjemplo2"
        Me.botonEjemplo2.Size = New System.Drawing.Size(178, 23)
        Me.botonEjemplo2.TabIndex = 3
        Me.botonEjemplo2.Text = "&Verificar"
        Me.botonEjemplo2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.num3)
        Me.GroupBox3.Controls.Add(Me.num2)
        Me.GroupBox3.Controls.Add(Me.num1)
        Me.GroupBox3.Controls.Add(Me.resultado)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(22, 276)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(434, 173)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Numero 1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(31, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Numero 2"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(31, 107)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Numero 3"
        '
        'resultado
        '
        Me.resultado.AutoSize = True
        Me.resultado.Location = New System.Drawing.Point(297, 87)
        Me.resultado.Name = "resultado"
        Me.resultado.Size = New System.Drawing.Size(22, 13)
        Me.resultado.TabIndex = 3
        Me.resultado.Text = "0.0"
        '
        'num1
        '
        Me.num1.Location = New System.Drawing.Point(93, 37)
        Me.num1.Name = "num1"
        Me.num1.Size = New System.Drawing.Size(66, 20)
        Me.num1.TabIndex = 4
        Me.num1.Text = "0.0"
        Me.num1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'num2
        '
        Me.num2.Location = New System.Drawing.Point(93, 69)
        Me.num2.Name = "num2"
        Me.num2.Size = New System.Drawing.Size(66, 20)
        Me.num2.TabIndex = 5
        Me.num2.Text = "0.0"
        Me.num2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'num3
        '
        Me.num3.Location = New System.Drawing.Point(93, 104)
        Me.num3.Name = "num3"
        Me.num3.Size = New System.Drawing.Size(66, 20)
        Me.num3.TabIndex = 6
        Me.num3.Text = "0.0"
        Me.num3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(240, 40)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(134, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Sumar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 465)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents botonEjemplo2 As System.Windows.Forms.Button
    Friend WithEvents numeroEjemplo2 As System.Windows.Forms.TextBox
    Friend WithEvents etiquetaEjemplo2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents num3 As System.Windows.Forms.TextBox
    Friend WithEvents num2 As System.Windows.Forms.TextBox
    Friend WithEvents num1 As System.Windows.Forms.TextBox
    Friend WithEvents resultado As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
