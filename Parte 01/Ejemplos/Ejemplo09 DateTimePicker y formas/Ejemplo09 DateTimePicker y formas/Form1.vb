Public Class Form1

    Private Sub btn_log_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_log.Click
        If txt_clave.Text = "12345" Then
            ' MsgBox("Contraseña aceptada")
            ' creamos una "variable" de tipo form2 
            Dim ventana As New Form2
            'escondemos la ventana actual(form1)

            Me.Hide()
            'Le damos un valor a la label de la otra forma
            ventana.lbl_texto.Text = "Texto pasado por la otra ventana"

            'Mostramos y le damos el foco a la ventana
            ventana.ShowDialog()
            'Cuando el foco vuelva a form1 , se cerrara
            Me.Close()


        End If
    End Sub
End Class
