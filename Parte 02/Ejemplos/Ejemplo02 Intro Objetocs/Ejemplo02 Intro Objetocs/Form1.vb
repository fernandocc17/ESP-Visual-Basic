Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Dim Oso As Perro
        'Oso = New Perro
        ''Oso.nombre = "OSO"
        ''Oso.raza = "Schnauzer"
        ''Oso.edad = 3

        'Oso.nombre = TextBox1.Text
        'Oso.raza = TextBox2.Text
        'Oso.edad = TextBox3.Text

        'Oso.Ladrar()

        'If (ComboBox1.SelectedItem = "Gato") Then
        '    Dim g As Gato
        '    g = New Gato(TextBox1.Text, TextBox2.Text, TextBox3.Text)
        '    'g.maullar()
        '    'g.maullar(2)
        '    g.correr()


        'Else
        '    Dim p As Perro
        '    p = New Perro(TextBox1.Text, TextBox2.Text, TextBox3.Text)
        '    p.correr()
        'End If


        Dim a As Animal
        If (ComboBox1.SelectedItem = "Gato") Then
            a = New Gato(TextBox1.Text, TextBox2.Text, TextBox3.Text)

        Else
            a = New Perro(TextBox1.Text, TextBox2.Text, TextBox3.Text)
        End If
        a.Comer()

        Dim h As Hablante
        If (ComboBox1.SelectedItem = "Gato") Then
            h = New Gato(TextBox1.Text, TextBox2.Text, TextBox3.Text)

        Else
            h = New Perro(TextBox1.Text, TextBox2.Text, TextBox3.Text)
        End If
        h.hablar()


    End Sub
End Class
