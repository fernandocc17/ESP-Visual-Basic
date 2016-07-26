Public Class Form1


    Private Sub btn_pasar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pasar.Click
        Dim ventana As New Form2
        
        Me.Hide()
        nombre = txt_nombre.Text
        ' ventana.lbl_nombre.Text = txt_nombre.Text
        ventana.ShowDialog()
        'Me.Show()
        Me.Close()
    End Sub

    Private Sub Form1_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        cerrar("Forma 1")
    End Sub
End Class
