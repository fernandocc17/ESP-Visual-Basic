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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmb_numeros = New System.Windows.Forms.ComboBox()
        Me.lb_tablas = New System.Windows.Forms.ListBox()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(261, 260)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmb_numeros
        '
        Me.cmb_numeros.FormattingEnabled = True
        Me.cmb_numeros.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmb_numeros.Location = New System.Drawing.Point(55, 54)
        Me.cmb_numeros.Name = "cmb_numeros"
        Me.cmb_numeros.Size = New System.Drawing.Size(121, 21)
        Me.cmb_numeros.TabIndex = 1
        '
        'lb_tablas
        '
        Me.lb_tablas.FormattingEnabled = True
        Me.lb_tablas.Location = New System.Drawing.Point(216, 54)
        Me.lb_tablas.Name = "lb_tablas"
        Me.lb_tablas.Size = New System.Drawing.Size(120, 95)
        Me.lb_tablas.TabIndex = 2
        '
        'btn_limpiar
        '
        Me.btn_limpiar.Location = New System.Drawing.Point(55, 126)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(75, 23)
        Me.btn_limpiar.TabIndex = 3
        Me.btn_limpiar.Text = "Limpiar"
        Me.ToolTip1.SetToolTip(Me.btn_limpiar, "Este boton va a limpiar el listbox")
        Me.btn_limpiar.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipTitle = "El tooltip 1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 309)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.lb_tablas)
        Me.Controls.Add(Me.cmb_numeros)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmb_numeros As System.Windows.Forms.ComboBox
    Friend WithEvents lb_tablas As System.Windows.Forms.ListBox
    Friend WithEvents btn_limpiar As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
