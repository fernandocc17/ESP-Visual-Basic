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
        Me.lb_tabla = New System.Windows.Forms.ListBox()
        Me.cmb_numero = New System.Windows.Forms.ComboBox()
        Me.btn_borrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lb_tabla
        '
        Me.lb_tabla.FormattingEnabled = True
        Me.lb_tabla.Location = New System.Drawing.Point(226, 58)
        Me.lb_tabla.Name = "lb_tabla"
        Me.lb_tabla.Size = New System.Drawing.Size(120, 186)
        Me.lb_tabla.TabIndex = 0
        '
        'cmb_numero
        '
        Me.cmb_numero.FormattingEnabled = True
        Me.cmb_numero.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.cmb_numero.Location = New System.Drawing.Point(66, 58)
        Me.cmb_numero.Name = "cmb_numero"
        Me.cmb_numero.Size = New System.Drawing.Size(121, 21)
        Me.cmb_numero.TabIndex = 1
        '
        'btn_borrar
        '
        Me.btn_borrar.Location = New System.Drawing.Point(66, 221)
        Me.btn_borrar.Name = "btn_borrar"
        Me.btn_borrar.Size = New System.Drawing.Size(75, 23)
        Me.btn_borrar.TabIndex = 2
        Me.btn_borrar.Text = "Borrar"
        Me.btn_borrar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 344)
        Me.Controls.Add(Me.btn_borrar)
        Me.Controls.Add(Me.cmb_numero)
        Me.Controls.Add(Me.lb_tabla)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lb_tabla As System.Windows.Forms.ListBox
    Friend WithEvents cmb_numero As System.Windows.Forms.ComboBox
    Friend WithEvents btn_borrar As System.Windows.Forms.Button

End Class
