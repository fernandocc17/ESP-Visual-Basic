Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' definimos nuestra variable i
        ' que usaremos como contador
        Dim i As Integer ' = 0

        'asignamos a i cero
        i = 0

        'limpiamos el combobox1 y listbox1 de cualquier valor que tenga
        ComboBox1.Items.Clear()
        ListBox1.Items.Clear()


        ' estructuras de control repetitivas

        'while

        'la forma de usar la instruccion while es
        'while <exp> lineas de codigo y al final end while
        'El while siempre debe tener una instruccion que modifique
        ' la variable de control

        While i < 11
            ComboBox1.Items.Add(i)

            ' condicion que modifica la variable de control
            i += 1
        End While

        'For

        'El for tiene la modificacion de la VC dentro de
        ' su misma linea de codigo, asi como su asignacion
        For i = 10 To 0 Step -1
            ListBox1.Items.Add(i)
        Next

        ListBox1.SelectedIndex = 2


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        'La propiedad selecteditem nos devuelve
        ' el valor, lo que el usuario ve
        Label3.Text = ComboBox1.SelectedItem

        'La propiedad selectedindex nos devuelve
        ' la posicion, del objeto seleccionado
        ' por el usuario

        Label4.Text = ComboBox1.SelectedIndex

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Label5.Text = ListBox1.SelectedItem
        Label6.Text = ListBox1.SelectedIndex


    End Sub
End Class
