Public Class Form1

    Private Sub cmb_numeros_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_numeros.SelectedIndexChanged

        lb_tablas.Items.Clear()


        'Guardamos el valor seleccionado por el usuario en numero
        Dim numero As Integer = cmb_numeros.SelectedItem
        'For que recorre desde i=0 hasta 10, cada ciclo aumenta i en uno
        For i As Integer = 0 To 10
            'metemos un item con el formato
            '5*1=5
            '5*2=10
            lb_tablas.Items.Add(numero & "x" & i & "=" & numero * i)
            'la i  es opcional ,sirve para ver rapido quien se altera
        Next i




    End Sub


    Private Sub btn_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_limpiar.Click
        lb_tablas.Items.Clear()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class
