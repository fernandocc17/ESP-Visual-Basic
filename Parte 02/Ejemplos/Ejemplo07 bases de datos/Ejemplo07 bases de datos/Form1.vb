Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim con As New Odbc.OdbcConnection("Dsn=vb_mysql_dvd;uid=root;database=vb_mysql;port=3306")
        Dim cmd As New Odbc.OdbcCommand()

        cmd.Connection = con
        cmd.CommandText = "INSERT INTO dvd (titulo,director) VALUES('" & TextBox2.Text & "','" & TextBox1.Text & " ')"
        'MsgBox(cmd.CommandText)

        con.Open()
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()

        Dim con As New Odbc.OdbcConnection("Dsn=vb_mysql_dvd;uid=root;database=vb_mysql;port=3306")
        Dim cmd As New Odbc.OdbcCommand()
        cmd.Connection = con
        cmd.CommandText = "SELECT titulo,director FROM dvd"
        con.Open()
        Try
            Dim lector As Odbc.OdbcDataReader = cmd.ExecuteReader()
            While lector.HasRows
                ListBox1.Items.Add(lector.Item(0))
                ListBox2.Items.Add(lector.Item(1))
                lector.NextResult()
            End While
        Catch ex As Exception

        Finally
            con.Close()
        End Try






    End Sub
End Class
