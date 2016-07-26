Public Class Form1

    Dim n1, n2 As Byte

    Sub asignar()
        Try
            n1 = txt_n1.Text
        Catch exe As OverflowException
            MsgBox("El valor introducido esta fuera del rango")
        Catch ex As InvalidCastException
            MsgBox("Solamente se admiten valores numericos entre 0 y 255")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            n2 = txt_n2.Text
        Catch exe As OverflowException
            MsgBox("El valor introducido esta fuera del rango")
        Catch ex As InvalidCastException
            MsgBox("Solamente se admiten valores numericos entre 0 y 255")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub btn_sumar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_sumar.Click
        asignar()
        Try
            lbl_resultado.Text = n1 + n2
        Catch ex As OverflowException

        End Try


    End Sub

    Private Sub btn_restar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_restar.Click
        asignar()
        Try
            lbl_resultado.Text = n1 - n2
        Catch ex As OverflowException

        End Try

    End Sub

    Private Sub btn_multiplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_multiplicar.Click
        asignar()
        Try
            lbl_resultado.Text = n1 * n2
        Catch ex As OverflowException

        End Try

    End Sub

    Private Sub btn_dividir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_dividir.Click
        asignar()

        Try
            lbl_resultado.Text = n1 \ n2
        Catch ex As DivideByZeroException


        End Try

    End Sub
End Class
