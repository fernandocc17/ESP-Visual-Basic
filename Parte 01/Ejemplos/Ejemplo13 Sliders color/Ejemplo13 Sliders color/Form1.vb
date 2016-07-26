Public Class Form1

    Private Sub HScrollBar1_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles HScrollBar1.Scroll
        cambiaColor()

    End Sub

    Private Sub HScrollBar2_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles HScrollBar2.Scroll
        cambiaColor()

    End Sub

    Private Sub HScrollBar3_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles HScrollBar3.Scroll
        cambiaColor()

    End Sub

    Sub cambiaColor()
        Me.BackColor = Color.FromArgb(HScrollBar1.Value, HScrollBar2.Value, HScrollBar3.Value)

    End Sub
End Class
