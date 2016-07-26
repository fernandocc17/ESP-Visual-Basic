Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        ' Aqui estamos calculando la DIVISION ENTERA y el resultado lo guardamos en el Text de la caja TextBox2
        TextBox2.Text = TextBox1.Text \ 60
        ' Aqui el residuo
        TextBox3.Text = TextBox1.Text Mod 60

    End Sub

    Private Sub botonEjemplo2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botonEjemplo2.Click

        ' Un numero se considerara valido si esta en el rango de 10 a 100
        etiquetaEjemplo2.Text = "Numero valido? " & (numeroEjemplo2.Text >= 10 And numeroEjemplo2.Text <= 100)


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        ' La propiedad Text de los controles es texto, si queremos sumarlo (aritmeticamente) necesitamos convertirlo a numero

        resultado.Text = (Val(num1.Text) + Val(num2.Text) + Val(num3.Text)) / 3.0


        ' resultado.Text = (Val(num1.Text  + num2.text + num3.text)) / 3.0      <- NO
        ' Val(resultado.Text) = (num1.Text + num2.Text + num3.Text) / 3.0       <- NO

        MessageBox.Show("El promedio es: " & resultado.Text)

        ' MessageBox.Show("El promedio es: " & ((Val(num1.Text) + Val(num2.Text) + Val(num3.Text)) / 3.0))      <- SI

        ' MessageBox.Show() = (Val(num1.Text) + Val(num2.Text) + Val(num3.Text)) / 3.0      <- NO


    End Sub
End Class
