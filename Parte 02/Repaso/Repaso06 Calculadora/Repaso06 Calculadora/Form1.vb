Public Class Form1

    ReadOnly SUMAR = 1, RESTAR = 2, MULTIPLICAR = 3, DIVIDIR = 4, IGUAL = 5
    Dim operacion As Integer = 0
    Dim n1 As Integer = 0

    Sub asigna(ByVal numero As Button)
        TextBox1.Text = TextBox1.Text & numero.Text

    End Sub
    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        asigna(Button10)
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        asigna(Button1)
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        asigna(Button6)
    End Sub
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        asigna(Button9)
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        asigna(Button2)
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        asigna(Button5)
    End Sub
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        asigna(Button8)
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        asigna(Button3)
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        asigna(Button4)
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        asigna(Button7)
    End Sub

    'Botones de operaciones
    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        calcula()
        operacion = SUMAR
        clickOperacion()

    End Sub
    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        operacion = RESTAR
        clickOperacion()
    End Sub
    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        calcula()
        operacion = MULTIPLICAR
        clickOperacion()
    End Sub
    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        calcula()
        operacion = DIVIDIR
        clickOperacion()

    End Sub
    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click

        calcula()
        operacion = IGUAL
    End Sub
    Sub clickOperacion()
        n1 = TextBox1.Text
        TextBox1.Text = 0
    End Sub

    
    Sub calcula()
        Dim n2 As Integer
        n2 = TextBox1.Text
        Select Case operacion
            Case SUMAR
                n2 = n2 + n1
            Case RESTAR
                n2 = n2 - n1
            Case MULTIPLICAR
                n2 = n2 * n1
            Case DIVIDIR
                n2 = n2 / n1
            Case IGUAL
                n1 = n2
        End Select
        TextBox1.Text = n2
    End Sub
End Class
