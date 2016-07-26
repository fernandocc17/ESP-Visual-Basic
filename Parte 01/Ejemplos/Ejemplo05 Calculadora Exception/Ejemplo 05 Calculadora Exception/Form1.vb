Public Class Form1

    Private Sub Btn_Suma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Suma.Click
        'Definimos nuestras variables de tipo byte, que representa
        'numeros del 0 al 255
        Dim n1, n2, res As Byte

        'Guardamos los valores de los textbox en las variables
        'Iniciamos nuestro seguro para el manejo de excepciones
        Try
            'solamente la linea de codigo entre el try y el catch es segura
            n1 = Txt_Valor1.Text
            'la linea del catch especifica donde se va a recibir la excepcion
            'y el tipo de excepcion
        Catch ex As OverflowException
            'lo que pongamos entre la  linea del catch y "lo siguiente"
            'sera nuestro manejo para el error

            'aviso para el usuario de que hubo un error
            MsgBox("El valor es demasiado grande " & Txt_Valor1.Text & ", debe ser menor a 256")
            'reestablecemos el campos de texto donde surgio el problema
            Txt_Valor1.Text = 0
        Catch ex As InvalidCastException
            MsgBox("Este campo solo acepta numeros")

        Catch es As Exception
            MsgBox("Hubo un problema")


        End Try

        Try
            'solamente la linea de codigo entre el try y el catch es segura
            n2 = Txt_Valor2.Text
            'la linea del catch especifica donde se va a recibir la excepcion
            'y el tipo de excepcion
        Catch ex As OverflowException
            'lo que pongamos entre la  linea del catch y "lo siguiente"
            'sera nuestro manejo para el error

            'aviso para el usuario de que hubo un error
            MsgBox("El valor es demasiado grande " & Txt_Valor2.Text & ", debe ser menor a 256")
            'reestablecemos el campos de texto donde surgio el problema
            Txt_Valor2.Text = 0
        Catch ex As InvalidCastException
            MsgBox("Este campo solo acepta numeros")

        Catch es As Exception
            MsgBox("Hubo un problema")

        End Try

        'Haemos la Sumatoria

        Try
            res = n1 + n2
        Catch ex As OverflowException
            MsgBox("El valor resultante es demasiado grande")
        Catch ex As Exception
            MsgBox("Hubo un error")

        End Try

        'Mostramos el resultado en la label

        Lbl_Resultado.Text = res


    End Sub

    Private Sub Btn_Resta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Resta.Click
        'Definimos nuestras variables de tipo byte, que representa
        'numeros del 0 al 255
        Dim n1, n2, res As Byte

        'Guardamos los valores de los textbox en las variables
        'Iniciamos nuestro seguro para el manejo de excepciones
        Try
            'solamente la linea de codigo entre el try y el catch es segura
            n1 = Txt_Valor1.Text
            'la linea del catch especifica donde se va a recibir la excepcion
            'y el tipo de excepcion
        Catch ex As OverflowException
            'lo que pongamos entre la  linea del catch y "lo siguiente"
            'sera nuestro manejo para el error

            'aviso para el usuario de que hubo un error
            MsgBox("El valor es demasiado grande" & Txt_Valor1.Text & ", debe ser menor a 256")
            'reestablecemos el campos de texto donde surgio el problema
            Txt_Valor1.Text = 0
        Catch ex As InvalidCastException
            MsgBox("Este campo solo acepta numeros")

        Catch es As Exception
            MsgBox("Hubo un problema")


        End Try

        Try
            'solamente la linea de codigo entre el try y el catch es segura
            n2 = Txt_Valor2.Text
            'la linea del catch especifica donde se va a recibir la excepcion
            'y el tipo de excepcion
        Catch ex As OverflowException
            'lo que pongamos entre la  linea del catch y "lo siguiente"
            'sera nuestro manejo para el error

            'aviso para el usuario de que hubo un error
            MsgBox("El valor es demasiado grande" & Txt_Valor2.Text & ", debe ser menor a 256")
            'reestablecemos el campos de texto donde surgio el problema
            Txt_Valor2.Text = 0
        Catch ex As InvalidCastException
            MsgBox("Este campo solo acepta numeros")

        Catch es As Exception
            MsgBox("Hubo un problema")

        End Try

        'Haemos la Sumatoria

        Try
            res = n1 - n2
        Catch ex As OverflowException
            MsgBox("El valor resultante es demasiado grande")
        Catch ex As Exception
            MsgBox("Hubo un error")

        End Try

        'Mostramos el resultado en la label

        Lbl_Resultado.Text = res
    End Sub

    Private Sub Btn_Multiplicacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Multiplicacion.Click
        'Definimos nuestras variables de tipo byte, que representa
        'numeros del 0 al 255
        Dim n1, n2, res As Byte

        'Guardamos los valores de los textbox en las variables
        'Iniciamos nuestro seguro para el manejo de excepciones
        Try
            'solamente la linea de codigo entre el try y el catch es segura
            n1 = Txt_Valor1.Text
            'la linea del catch especifica donde se va a recibir la excepcion
            'y el tipo de excepcion
        Catch ex As OverflowException
            'lo que pongamos entre la  linea del catch y "lo siguiente"
            'sera nuestro manejo para el error

            'aviso para el usuario de que hubo un error
            MsgBox("El valor es demasiado grande" & Txt_Valor1.Text & ", debe ser menor a 256")
            'reestablecemos el campos de texto donde surgio el problema
            Txt_Valor1.Text = 0
        Catch ex As InvalidCastException
            MsgBox("Este campo solo acepta numeros")

        Catch es As Exception
            MsgBox("Hubo un problema")


        End Try

        Try
            'solamente la linea de codigo entre el try y el catch es segura
            n2 = Txt_Valor2.Text
            'la linea del catch especifica donde se va a recibir la excepcion
            'y el tipo de excepcion
        Catch ex As OverflowException
            'lo que pongamos entre la  linea del catch y "lo siguiente"
            'sera nuestro manejo para el error

            'aviso para el usuario de que hubo un error
            MsgBox("El valor es demasiado grande" & Txt_Valor2.Text & ", debe ser menor a 256")
            'reestablecemos el campos de texto donde surgio el problema
            Txt_Valor2.Text = 0
        Catch ex As InvalidCastException
            MsgBox("Este campo solo acepta numeros")

        Catch es As Exception
            MsgBox("Hubo un problema")

        End Try


        'Hacemos la Multiplicacion

        Try
            res = n1 * n2
        Catch ex As OverflowException
            MsgBox("El valor resultante es demasiado grande")
        Catch ex As Exception
            MsgBox("Hubo un error")

        End Try


        'Mostramos el resultado en la label

        Lbl_Resultado.Text = res
    End Sub

    Private Sub Btn_Division_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Division.Click
        'Definimos nuestras variables de tipo byte, que representa
        'numeros del 0 al 255
        Dim n1, n2, res As Byte

        'Guardamos los valores de los textbox en las variables
        'Iniciamos nuestro seguro para el manejo de excepciones
        Try
            'solamente la linea de codigo entre el try y el catch es segura
            n1 = Txt_Valor1.Text
            'la linea del catch especifica donde se va a recibir la excepcion
            'y el tipo de excepcion
        Catch ex As OverflowException
            'lo que pongamos entre la  linea del catch y "lo siguiente"
            'sera nuestro manejo para el error

            'aviso para el usuario de que hubo un error
            MsgBox("El valor es demasiado grande " & Txt_Valor1.Text & ", debe ser menor a 256")
            'reestablecemos el campos de texto donde surgio el problema
            Txt_Valor1.Text = 0
        Catch ex As InvalidCastException
            MsgBox("Este campo solo acepta numeros")

        Catch es As Exception
            MsgBox("Hubo un problema")


        End Try

        Try
            'solamente la linea de codigo entre el try y el catch es segura
            n2 = Txt_Valor2.Text
            'la linea del catch especifica donde se va a recibir la excepcion
            'y el tipo de excepcion
        Catch ex As OverflowException
            'lo que pongamos entre la  linea del catch y "lo siguiente"
            'sera nuestro manejo para el error

            'aviso para el usuario de que hubo un error
            MsgBox("El valor es demasiado grande " & Txt_Valor1.Text & ", debe ser menor a 256")
            'reestablecemos el campos de texto donde surgio el problema
            Txt_Valor1.Text = 0

        Catch ex As InvalidCastException
            MsgBox("Este campo solo acepta numeros")

        Catch es As Exception
            MsgBox("Hubo un problema")

        End Try

        'Hacemos la Division

        Try
            res = n1 \ n2

        Catch ex As DivideByZeroException
            MsgBox("No Existe Division Entre 0")

        End Try

        'Mostramos el resultado en la label

        Lbl_Resultado.Text = res
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = Color.AntiqueWhite
    End Sub
End Class
