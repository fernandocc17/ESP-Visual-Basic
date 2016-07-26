Public Class Form1

    Private Sub btn_accion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_accion.Click
        Ti_prueba.Enabled = True

    End Sub

    Private Sub Ti_prueba_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ti_prueba.Tick
        ProgressBar1.PerformStep()

    End Sub

    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar1.Click

    End Sub
End Class
