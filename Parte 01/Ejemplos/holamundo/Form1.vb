Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Me.Text = "Hola Mundo: " + TextBox1.Text

        MessageBox.Show("Saludos " + TextBox1.Text)

    End Sub

    Private Sub Label1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label1.Click

        MessageBox.Show("Debes escribir tu nombre y presionar el boton")

    End Sub
End Class
