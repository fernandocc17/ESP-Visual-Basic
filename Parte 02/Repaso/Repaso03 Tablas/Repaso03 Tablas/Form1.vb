Public Class Form1

   
    Private Sub cmb_numero_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_numero.SelectedIndexChanged
        lb_tabla.Items.Clear()

        For i As Integer = 1 To 10
            lb_tabla.Items.Add(i * cmb_numero.SelectedItem)
        Next


    End Sub

    Private Sub btn_borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_borrar.Click
        lb_tabla.Items.Clear()

    End Sub
End Class
