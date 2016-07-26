Public Class Form1

    'procedimiento sin pam
    Sub suma1()
        Dim n1, n2, res As Integer
        n1 = txt_n1.Text
        n2 = txt_n2.Text
        res = n1 + n2
        lbl_res.Text = res

    End Sub
    'procedimiento con pam
    Sub suma2(ByVal n1 As Integer, ByVal n2 As Integer)
        lbl_res.Text = n1 + n2
    End Sub
    'funcion sin pam
    Function suma3() As Integer
        Dim n1, n2, res As Integer
        n1 = txt_n1.Text
        n2 = txt_n2.Text
        res = n1 + n2
        Return res
    End Function
    'funcion con pam
    Function suma4(ByVal n1 As Integer, ByVal n2 As Integer) As Integer
        Return n1 + n2

    End Function

    Sub asigna(ByRef n As Integer, ByVal txt As TextBox)
        Try
            txt.Text = "100"
            n = txt.Text

        Catch ex As InvalidCastException
            MsgBox("Introduce numeros")
        Catch ex As OverflowException
            MsgBox("Numero demasiado grande")
        Catch ex As Exception
            MsgBox("Ocurrio un error inesperado")
        End Try


    End Sub
    Sub asignaChafa(ByRef n1 As Integer, ByRef n2 As Integer)
        Try
            n1 = txt_n1.Text
        Catch ex As InvalidCastException
            MsgBox("Introduce numeros")
        Catch ex As OverflowException
            MsgBox("Numero demasiado grande")
        Catch ex As Exception
            MsgBox("Ocurrio un error inesperado")
        End Try

        Try
            n2 = txt_n2.Text
        Catch ex As InvalidCastException
            MsgBox("Introduce numeros")
        Catch ex As OverflowException
            MsgBox("Numero demasiado grande")
        Catch ex As Exception
            MsgBox("Ocurrio un error inesperado")
        End Try



    End Sub
    Private Sub txt_n2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_n2.KeyDown
        If e.KeyValue = Keys.Enter Then
            Dim n1, n2 As Integer

            asigna(n1, txt_n1)
            asigna(n2, txt_n2)
            lbl_res.Text = suma4(n1, n2)

        End If
    End Sub
    Private Sub txt_n1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_n1.KeyDown
        If e.KeyValue = Keys.Enter Then
            Dim n1, n2 As Integer

            n1 = txt_n1.Text
            n2 = txt_n2.Text
            lbl_res.Text = suma4(n1, n2)

        End If

    End Sub
    Private Sub btn_suma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_suma.Click
        Dim n1, n2 As Integer

        n1 = txt_n1.Text
        n2 = txt_n2.Text

        lbl_res.Text = suma4(n1, n2)
    End Sub

    Private Sub txt_n1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_n1.TextChanged

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
