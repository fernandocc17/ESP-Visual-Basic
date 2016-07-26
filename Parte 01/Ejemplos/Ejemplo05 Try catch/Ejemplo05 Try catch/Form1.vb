Public Class Form1

    Dim n1 As Byte
    Dim n2 As Byte


    Private Sub btn_sumar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_sumar.Click
        Try
            n1 = txt_n1.Text
        Catch ex As Exception
            MsgBox("El " & txt_n1.Text & "es invalido")

        End Try
        Try
            n2 = txt_n2.Text
        Catch ex As OverflowException
            MsgBox("El valor es demasiado grande")

        Catch ex As InvalidCastException
            MsgBox("No es un numero")
        Catch ex As Exception
            MsgBox("excepcion inesperada")

        End Try
        Try
            lbl_resultado.Text = n1 + n2

        Catch ex As Exception
            MsgBox("La suma se desbordo")
        End Try
        
    End Sub
End Class
