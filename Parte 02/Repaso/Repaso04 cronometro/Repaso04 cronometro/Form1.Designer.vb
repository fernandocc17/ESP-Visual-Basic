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
        Me.components = New System.ComponentModel.Container()
        Me.lbl_hora = New System.Windows.Forms.Label()
        Me.lbl_minuto = New System.Windows.Forms.Label()
        Me.lbl_segundos = New System.Windows.Forms.Label()
        Me.lbl_c_segundos = New System.Windows.Forms.Label()
        Me.lbl_c_minutos = New System.Windows.Forms.Label()
        Me.lbl_c_hora = New System.Windows.Forms.Label()
        Me.btn_empieza = New System.Windows.Forms.Button()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        Me.t_cronometro = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lbl_hora
        '
        Me.lbl_hora.AutoSize = True
        Me.lbl_hora.Location = New System.Drawing.Point(65, 67)
        Me.lbl_hora.Name = "lbl_hora"
        Me.lbl_hora.Size = New System.Drawing.Size(30, 13)
        Me.lbl_hora.TabIndex = 0
        Me.lbl_hora.Text = "Hora"
        '
        'lbl_minuto
        '
        Me.lbl_minuto.AutoSize = True
        Me.lbl_minuto.Location = New System.Drawing.Point(139, 67)
        Me.lbl_minuto.Name = "lbl_minuto"
        Me.lbl_minuto.Size = New System.Drawing.Size(44, 13)
        Me.lbl_minuto.TabIndex = 1
        Me.lbl_minuto.Text = "Minutos"
        '
        'lbl_segundos
        '
        Me.lbl_segundos.AutoSize = True
        Me.lbl_segundos.Location = New System.Drawing.Point(227, 67)
        Me.lbl_segundos.Name = "lbl_segundos"
        Me.lbl_segundos.Size = New System.Drawing.Size(55, 13)
        Me.lbl_segundos.TabIndex = 2
        Me.lbl_segundos.Text = "Segundos"
        '
        'lbl_c_segundos
        '
        Me.lbl_c_segundos.AutoSize = True
        Me.lbl_c_segundos.Location = New System.Drawing.Point(227, 122)
        Me.lbl_c_segundos.Name = "lbl_c_segundos"
        Me.lbl_c_segundos.Size = New System.Drawing.Size(0, 13)
        Me.lbl_c_segundos.TabIndex = 5
        '
        'lbl_c_minutos
        '
        Me.lbl_c_minutos.AutoSize = True
        Me.lbl_c_minutos.Location = New System.Drawing.Point(139, 122)
        Me.lbl_c_minutos.Name = "lbl_c_minutos"
        Me.lbl_c_minutos.Size = New System.Drawing.Size(0, 13)
        Me.lbl_c_minutos.TabIndex = 4
        '
        'lbl_c_hora
        '
        Me.lbl_c_hora.AutoSize = True
        Me.lbl_c_hora.Location = New System.Drawing.Point(65, 122)
        Me.lbl_c_hora.Name = "lbl_c_hora"
        Me.lbl_c_hora.Size = New System.Drawing.Size(0, 13)
        Me.lbl_c_hora.TabIndex = 3
        '
        'btn_empieza
        '
        Me.btn_empieza.Location = New System.Drawing.Point(68, 194)
        Me.btn_empieza.Name = "btn_empieza"
        Me.btn_empieza.Size = New System.Drawing.Size(75, 23)
        Me.btn_empieza.TabIndex = 6
        Me.btn_empieza.Text = "Iniciar"
        Me.btn_empieza.UseVisualStyleBackColor = True
        '
        'btn_cerrar
        '
        Me.btn_cerrar.Location = New System.Drawing.Point(206, 193)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cerrar.TabIndex = 7
        Me.btn_cerrar.Text = "Cerrar"
        Me.btn_cerrar.UseVisualStyleBackColor = True
        '
        't_cronometro
        '
        Me.t_cronometro.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 283)
        Me.Controls.Add(Me.btn_cerrar)
        Me.Controls.Add(Me.btn_empieza)
        Me.Controls.Add(Me.lbl_c_segundos)
        Me.Controls.Add(Me.lbl_c_minutos)
        Me.Controls.Add(Me.lbl_c_hora)
        Me.Controls.Add(Me.lbl_segundos)
        Me.Controls.Add(Me.lbl_minuto)
        Me.Controls.Add(Me.lbl_hora)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_hora As System.Windows.Forms.Label
    Friend WithEvents lbl_minuto As System.Windows.Forms.Label
    Friend WithEvents lbl_segundos As System.Windows.Forms.Label
    Friend WithEvents lbl_c_segundos As System.Windows.Forms.Label
    Friend WithEvents lbl_c_minutos As System.Windows.Forms.Label
    Friend WithEvents lbl_c_hora As System.Windows.Forms.Label
    Friend WithEvents btn_empieza As System.Windows.Forms.Button
    Friend WithEvents btn_cerrar As System.Windows.Forms.Button
    Friend WithEvents t_cronometro As System.Windows.Forms.Timer

End Class
