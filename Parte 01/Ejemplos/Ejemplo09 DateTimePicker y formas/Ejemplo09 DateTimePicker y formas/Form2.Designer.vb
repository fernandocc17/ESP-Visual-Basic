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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.dtp_fechas = New System.Windows.Forms.DateTimePicker()
        Me.btn_calcular = New System.Windows.Forms.Button()
        Me.rtb_texto = New System.Windows.Forms.RichTextBox()
        Me.lbl_texto = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtp_fechas
        '
        Me.dtp_fechas.Location = New System.Drawing.Point(12, 12)
        Me.dtp_fechas.MinDate = New Date(2012, 6, 2, 0, 0, 0, 0)
        Me.dtp_fechas.Name = "dtp_fechas"
        Me.dtp_fechas.Size = New System.Drawing.Size(200, 20)
        Me.dtp_fechas.TabIndex = 0
        Me.dtp_fechas.Value = New Date(2012, 6, 2, 0, 0, 0, 0)
        '
        'btn_calcular
        '
        Me.btn_calcular.Location = New System.Drawing.Point(286, 13)
        Me.btn_calcular.Name = "btn_calcular"
        Me.btn_calcular.Size = New System.Drawing.Size(75, 23)
        Me.btn_calcular.TabIndex = 1
        Me.btn_calcular.Text = "Calcular"
        Me.btn_calcular.UseVisualStyleBackColor = True
        '
        'rtb_texto
        '
        Me.rtb_texto.Location = New System.Drawing.Point(12, 143)
        Me.rtb_texto.Name = "rtb_texto"
        Me.rtb_texto.Size = New System.Drawing.Size(349, 96)
        Me.rtb_texto.TabIndex = 2
        Me.rtb_texto.Text = ""
        '
        'lbl_texto
        '
        Me.lbl_texto.AutoSize = True
        Me.lbl_texto.Location = New System.Drawing.Point(170, 89)
        Me.lbl_texto.Name = "lbl_texto"
        Me.lbl_texto.Size = New System.Drawing.Size(39, 13)
        Me.lbl_texto.TabIndex = 3
        Me.lbl_texto.Text = "Label1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 259)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 69)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 372)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_texto)
        Me.Controls.Add(Me.rtb_texto)
        Me.Controls.Add(Me.btn_calcular)
        Me.Controls.Add(Me.dtp_fechas)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtp_fechas As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_calcular As System.Windows.Forms.Button
    Friend WithEvents rtb_texto As System.Windows.Forms.RichTextBox
    Friend WithEvents lbl_texto As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
