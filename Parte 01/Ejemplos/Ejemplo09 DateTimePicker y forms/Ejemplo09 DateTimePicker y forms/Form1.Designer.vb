﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.btn_log = New System.Windows.Forms.Button
        Me.txt_login = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'btn_log
        '
        Me.btn_log.Location = New System.Drawing.Point(114, 104)
        Me.btn_log.Name = "btn_log"
        Me.btn_log.Size = New System.Drawing.Size(75, 23)
        Me.btn_log.TabIndex = 0
        Me.btn_log.Text = "Logearse"
        Me.btn_log.UseVisualStyleBackColor = True
        '
        'txt_login
        '
        Me.txt_login.Location = New System.Drawing.Point(104, 53)
        Me.txt_login.Name = "txt_login"
        Me.txt_login.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_login.Size = New System.Drawing.Size(100, 20)
        Me.txt_login.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.txt_login)
        Me.Controls.Add(Me.btn_log)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_log As System.Windows.Forms.Button
    Friend WithEvents txt_login As System.Windows.Forms.TextBox

End Class
