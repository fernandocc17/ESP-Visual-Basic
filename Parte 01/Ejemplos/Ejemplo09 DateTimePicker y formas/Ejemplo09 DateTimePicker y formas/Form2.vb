Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'cargamos imagen en tiempo de ejecucion
        PictureBox1.Image = Image.FromFile("C:\Users\Public\Pictures\Sample Pictures\koala.jpg")

    End Sub

    Private Sub btn_calcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_calcular.Click
        'Creamos una variable de tipo fecha
        Dim fecha As Date
        'Guardamos la fecha seleccionada del datetimepicker
        fecha = dtp_fechas.Value

        'Agregamos al richtextbox los dias a pagar por los proximos 3 meses
        ' un for para ir agregando las fechas de pago al RTB
        For i As Integer = 0 To 2
            'Concatenamos al final del RTB, la siguiente cadena
            rtb_texto.AppendText(i + 1 & "Pago el dia de " & fecha.AddMonths(i) & vbNewLine)
            'vbNewLine produce una nueva linea en el RTB
            'fecha.addMonths() agrega un mes a la fecha actual pero no cambia su valor



        Next i
    End Sub
End Class