Public Class Form3

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Aqui se definen las variables a y b de tipo
        'enteras
        Dim a, b As Integer 'este es un comentario

        'Se asignan los datos de los textbox en las variables
        a = TextBox1.Text
        b = TextBox2.Text


        'Suma las variables y se muestran en el label
        Label1.Text = a + b

    End Sub
End Class