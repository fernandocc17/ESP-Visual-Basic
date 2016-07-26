Public Class Form1

    Private Sub btn_accion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_accion.Click
        'definir el arreglo
        Dim arreglo(2, 2), i, j, tam As Integer
        tam = 2

        'Pasamos los datos de los txt al arreglo
        arreglo(0, 0) = txt_n1.Text
        arreglo(1, 0) = txt_n2.Text
        arreglo(1, 1) = txt_n3.Text
        arreglo(0, 1) = txt_n4.Text

        'Pasamos los datos del arreglo al listbox

        'Manera poco elegante de hacerlo
        'lb_datos.Items.Add(arreglo(0))
        'lb_datos.Items.Add(arreglo(1))
        'lb_datos.Items.Add(arreglo(2))
        'lb_datos.Items.Add(arreglo(3))

        'Manera chida...tipo buena idea y mala idea de animaniacs
        For i = 0 To tam - 1
            For j = 0 To tam - 1
                lb_datos.Items.Add(arreglo(i, j))
            Next
        Next
    End Sub


    Private Sub txt_n4_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_n4.KeyDown
        If e.KeyValue = Keys.Enter Then
            MsgBox("Se presiono enter")
        End If
    End Sub
End Class
