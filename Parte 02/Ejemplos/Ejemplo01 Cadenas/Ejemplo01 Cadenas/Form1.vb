Public Class Form1

    Private Sub btn_cadena_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cadena.Click
        Dim cambia As String
        cambia = txt_cadena.Text

        lbl_contains.Text = cambia.Contains("VB")

        lbl_endswith.Text = cambia.EndsWith("VB")

        lbl_indexof.Text = cambia.IndexOf("VB")

        lbl_insert.Text = cambia.Insert(4, "VB")

        lbl_lastindexof.Text = cambia.LastIndexOf("VB")

        lbl_length.Text = cambia.Length

        lbl_remove.Text = cambia.Remove(3, 2)

        lbl_replace.Text = cambia.Replace("VB", "hola mundo")

        lbl_starswith.Text = cambia.StartsWith("VB")

        lbl_substring.Text = cambia.Substring(4)

        lbl_tolower.Text = cambia.ToLower

        lbl_toupper.Text = cambia.ToUpper

        lbl_trim.Text = cambia.Trim

    End Sub

   
End Class
