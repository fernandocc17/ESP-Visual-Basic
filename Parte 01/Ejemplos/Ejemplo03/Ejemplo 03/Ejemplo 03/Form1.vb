Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Con esta linea se va a habilitar el boton
        button1.Enabled = True


        'Cambiamos el color de fondo de la forma
        ' a rojo
        
        Me.BackColor = Color.Turquoise

        'Color es un elemento predefinido que contiene
        ' una amplia variedad de colores


    End Sub

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        'en esta linea se definen las variables
        Dim a, b As Integer

        'en esta linea se asignan los valores
        ' de los textbox a las variables a y b
        a = textBox1.Text
        b = textBox2.Text

        'esta linea comentada  es una forma incorrecta
        'de asignar el valor a la variable,
        ' lo que hace es asignar al textbox1
        ' el valor de a
        'textBox1.Text = a

        'Ejemplos de las estructuras de control condicionales


        'If
        'La estructura de control condicional if funciona
        'evaluando la expresion en medio de if y then
        ' si el resultado es true se ejecuta todo
        ' lo que este entre el if <exp> then hasta el end if

        If a = b Then
            label1.Text = "Son iguales"
            'Else
            'El else es una porcion de codigo que queremos 
            'que se ejecute en caso de que la condicion sea
            'falsa.Debe ir entre el if <exp> then y el end if
        Else
            label1.Text = "Son diferentes"
        End If

        'Select case
        ' se escribe select case y la variable con la que se va a interactuar
        Select Case a

            ' se puede poner caso para un solo valor que tome la variable 
            Case 1
                label2.Text = " El primer valor es uno"

                ' se puede poner un rango de valores como el siguiente
            Case 2 To 6
                label2.Text = "El primer valor esta en un rango de 2 a 6"

                ' se puede poner una opcion que se ejecute si ninguna de las 
                'anteriores escritas fue exitosa
            Case Else
                label2.Text = "El valor no esta dentro de ninguna opcion"
        End Select

    End Sub

    Private Sub pictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pictureBox1.Click
        'cambiar el radiobutton2.text al hacer click 
        'en la imagen
        radioButton2.Text = "Se hizo click en la imagen"

    End Sub

    Private Sub textBox1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles textBox1.MouseHover
        'Se va a cambiar el checkbox2.text
        'para que cuando el mouse pase por el textbox1
        ' cambie a se paso el mouse
        checkBox2.Text = "Se paso el mouse por el textbox1"

    End Sub

    Private Sub checkBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
        If checkBox1.Checked Then
            MsgBox("El Checkbox1 esta marcado")
        Else
            MsgBox("El Checkbox1 esta desmarcado")
        End If
    End Sub

    Private Sub radioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioButton1.CheckedChanged

    End Sub
End Class
