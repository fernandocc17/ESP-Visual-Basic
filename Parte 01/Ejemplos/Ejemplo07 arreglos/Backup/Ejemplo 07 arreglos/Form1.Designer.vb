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
        Me.txt_n1 = New System.Windows.Forms.TextBox
        Me.txt_n2 = New System.Windows.Forms.TextBox
        Me.txt_n3 = New System.Windows.Forms.TextBox
        Me.txt_n4 = New System.Windows.Forms.TextBox
        Me.btn_accion = New System.Windows.Forms.Button
        Me.lb_datos = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'txt_n1
        '
        Me.txt_n1.Location = New System.Drawing.Point(74, 44)
        Me.txt_n1.Name = "txt_n1"
        Me.txt_n1.Size = New System.Drawing.Size(100, 20)
        Me.txt_n1.TabIndex = 0
        '
        'txt_n2
        '
        Me.txt_n2.Location = New System.Drawing.Point(219, 44)
        Me.txt_n2.Name = "txt_n2"
        Me.txt_n2.Size = New System.Drawing.Size(100, 20)
        Me.txt_n2.TabIndex = 1
        '
        'txt_n3
        '
        Me.txt_n3.Location = New System.Drawing.Point(74, 95)
        Me.txt_n3.Name = "txt_n3"
        Me.txt_n3.Size = New System.Drawing.Size(100, 20)
        Me.txt_n3.TabIndex = 2
        '
        'txt_n4
        '
        Me.txt_n4.Location = New System.Drawing.Point(219, 94)
        Me.txt_n4.Name = "txt_n4"
        Me.txt_n4.Size = New System.Drawing.Size(100, 20)
        Me.txt_n4.TabIndex = 3
        '
        'btn_accion
        '
        Me.btn_accion.Location = New System.Drawing.Point(74, 143)
        Me.btn_accion.Name = "btn_accion"
        Me.btn_accion.Size = New System.Drawing.Size(75, 23)
        Me.btn_accion.TabIndex = 4
        Me.btn_accion.Text = "Pasar datos"
        Me.btn_accion.UseVisualStyleBackColor = True
        '
        'lb_datos
        '
        Me.lb_datos.FormattingEnabled = True
        Me.lb_datos.Location = New System.Drawing.Point(219, 143)
        Me.lb_datos.Name = "lb_datos"
        Me.lb_datos.Size = New System.Drawing.Size(120, 95)
        Me.lb_datos.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 243)
        Me.Controls.Add(Me.lb_datos)
        Me.Controls.Add(Me.btn_accion)
        Me.Controls.Add(Me.txt_n4)
        Me.Controls.Add(Me.txt_n3)
        Me.Controls.Add(Me.txt_n2)
        Me.Controls.Add(Me.txt_n1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_n1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_n2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_n3 As System.Windows.Forms.TextBox
    Friend WithEvents txt_n4 As System.Windows.Forms.TextBox
    Friend WithEvents btn_accion As System.Windows.Forms.Button
    Friend WithEvents lb_datos As System.Windows.Forms.ListBox

End Class
