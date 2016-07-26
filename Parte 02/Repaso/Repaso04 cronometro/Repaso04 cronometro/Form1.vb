Public Class Form1

    Dim horas As Integer = 0
    Dim minutos As Integer = 0
    Dim segundos As Integer = 0

    Private Sub btn_cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cerrar.Click
        Me.Close()
    End Sub

    Private Sub btn_empieza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_empieza.Click
        t_cronometro.Enabled = True

    End Sub

    Private Sub t_cronometro_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t_cronometro.Tick
        

        segundos = segundos + 1

        If segundos = 60 Then
            segundos = 0
            minutos += 1
            If minutos = 60 Then
                horas += 1
                minutos = 0
            End If

           

        End If
        lbl_c_minutos.Text = minutos

        lbl_c_hora.Text = horas
        lbl_c_segundos.Text = segundos



    End Sub
End Class
