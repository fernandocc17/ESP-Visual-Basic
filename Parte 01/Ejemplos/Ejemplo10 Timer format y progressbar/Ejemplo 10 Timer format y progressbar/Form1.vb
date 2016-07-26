Public Class Form1

    Private Sub btn_accion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_accion.Click
        'habilitamos el timer
        ti_prueba.Enabled = True

        Dim i As Decimal = 89.5
        MsgBox(Format(i, "$ 0#.00"))
    End Sub
    Private Sub ti_prueba_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ti_prueba.Tick
        'incrementa el progressbar
        pb_prueba.PerformStep()

    End Sub
End Class
