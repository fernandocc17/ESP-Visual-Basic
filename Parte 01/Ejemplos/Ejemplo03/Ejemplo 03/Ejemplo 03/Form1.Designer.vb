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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.pictureBox1 = New System.Windows.Forms.PictureBox
        Me.textBox2 = New System.Windows.Forms.TextBox
        Me.textBox1 = New System.Windows.Forms.TextBox
        Me.radioButton2 = New System.Windows.Forms.RadioButton
        Me.radioButton1 = New System.Windows.Forms.RadioButton
        Me.label3 = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.label1 = New System.Windows.Forms.Label
        Me.checkBox2 = New System.Windows.Forms.CheckBox
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.button1 = New System.Windows.Forms.Button
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(225, 29)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 21
        Me.pictureBox1.TabStop = False
        '
        'textBox2
        '
        Me.textBox2.Location = New System.Drawing.Point(143, 130)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(100, 20)
        Me.textBox2.TabIndex = 20
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(28, 130)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(100, 20)
        Me.textBox1.TabIndex = 19
        '
        'radioButton2
        '
        Me.radioButton2.AutoSize = True
        Me.radioButton2.Location = New System.Drawing.Point(43, 98)
        Me.radioButton2.Name = "radioButton2"
        Me.radioButton2.Size = New System.Drawing.Size(59, 17)
        Me.radioButton2.TabIndex = 18
        Me.radioButton2.TabStop = True
        Me.radioButton2.Text = "Prueba"
        Me.radioButton2.UseVisualStyleBackColor = True
        '
        'radioButton1
        '
        Me.radioButton1.AutoSize = True
        Me.radioButton1.Location = New System.Drawing.Point(43, 75)
        Me.radioButton1.Name = "radioButton1"
        Me.radioButton1.Size = New System.Drawing.Size(52, 17)
        Me.radioButton1.TabIndex = 17
        Me.radioButton1.TabStop = True
        Me.radioButton1.Text = "Suma"
        Me.radioButton1.UseVisualStyleBackColor = True
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(272, 133)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(34, 13)
        Me.label3.TabIndex = 16
        Me.label3.Text = "Suma"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(85, 199)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(39, 13)
        Me.label2.TabIndex = 15
        Me.label2.Text = "Rango"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(85, 171)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(99, 13)
        Me.label1.TabIndex = 14
        Me.label1.Text = "Prueba de igualdad"
        '
        'checkBox2
        '
        Me.checkBox2.AutoSize = True
        Me.checkBox2.Location = New System.Drawing.Point(40, 52)
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(60, 17)
        Me.checkBox2.TabIndex = 13
        Me.checkBox2.Text = "Prueba"
        Me.checkBox2.UseVisualStyleBackColor = True
        '
        'checkBox1
        '
        Me.checkBox1.AutoSize = True
        Me.checkBox1.Location = New System.Drawing.Point(40, 29)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(59, 17)
        Me.checkBox1.TabIndex = 12
        Me.checkBox1.Text = "Activar"
        Me.checkBox1.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Enabled = False
        Me.button1.Location = New System.Drawing.Point(126, 29)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 23)
        Me.button1.TabIndex = 11
        Me.button1.Text = "Accion"
        Me.button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 327)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.textBox2)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.radioButton2)
        Me.Controls.Add(Me.radioButton1)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.checkBox2)
        Me.Controls.Add(Me.checkBox1)
        Me.Controls.Add(Me.button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
    Private WithEvents textBox2 As System.Windows.Forms.TextBox
    Private WithEvents textBox1 As System.Windows.Forms.TextBox
    Private WithEvents radioButton2 As System.Windows.Forms.RadioButton
    Private WithEvents radioButton1 As System.Windows.Forms.RadioButton
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents checkBox2 As System.Windows.Forms.CheckBox
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private WithEvents button1 As System.Windows.Forms.Button

End Class
