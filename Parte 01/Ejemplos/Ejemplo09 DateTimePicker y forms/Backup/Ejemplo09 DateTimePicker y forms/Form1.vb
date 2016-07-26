Public Class Form1
    Private Sub btn_log_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_log.Click
        log()

    End Sub

    Private Sub txt_login_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_login.KeyDown
        If e.KeyValue = Keys.Enter Then
            log()
        End If
    End Sub

    Sub log()
        Dim cad As String = txt_login.Text
        If logea(cad) Then

            Me.Hide()
            Dim z As New Form2
            z.ShowDialog()
            Me.Close()



        Else
            MsgBox("La contraseña es incorrecta")

        End If

    End Sub

    Function logea(ByVal c As String) As Boolean
        If c = "12345" Then
            Return True
        Else
            Return False
        End If


    End Function

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
