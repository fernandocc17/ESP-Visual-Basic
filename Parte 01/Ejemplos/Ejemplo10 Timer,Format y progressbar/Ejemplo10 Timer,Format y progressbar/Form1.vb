Public Class Form1
    Dim segundo, minuto, hora As Integer

    Private Sub btn_accion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_accion.Click
        Ti_prueba.Enabled = True

    End Sub

    Private Sub Ti_prueba_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ti_prueba.Tick
        segundo = segundo + 1
        If segundo = 60 Then
            segundo = 0
            minuto = minuto + 1
            If minuto = 60 Then
                minuto = 0
                hora = hora + 1

            End If
        End If

        ProgressBar1.PerformStep()


    End Sub

    
    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar1.Click

    End Sub
End Class
