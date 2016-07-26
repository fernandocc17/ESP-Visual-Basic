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
        Me.components = New System.ComponentModel.Container
        Me.ti_prueba = New System.Windows.Forms.Timer(Me.components)
        Me.pb_prueba = New System.Windows.Forms.ProgressBar
        Me.btn_accion = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'ti_prueba
        '
        '
        'pb_prueba
        '
        Me.pb_prueba.Location = New System.Drawing.Point(110, 87)
        Me.pb_prueba.Name = "pb_prueba"
        Me.pb_prueba.Size = New System.Drawing.Size(100, 23)
        Me.pb_prueba.TabIndex = 0
        '
        'btn_accion
        '
        Me.btn_accion.Location = New System.Drawing.Point(110, 30)
        Me.btn_accion.Name = "btn_accion"
        Me.btn_accion.Size = New System.Drawing.Size(75, 23)
        Me.btn_accion.TabIndex = 1
        Me.btn_accion.Text = "Accion"
        Me.btn_accion.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btn_accion)
        Me.Controls.Add(Me.pb_prueba)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ti_prueba As System.Windows.Forms.Timer
    Friend WithEvents pb_prueba As System.Windows.Forms.ProgressBar
    Friend WithEvents btn_accion As System.Windows.Forms.Button

End Class
