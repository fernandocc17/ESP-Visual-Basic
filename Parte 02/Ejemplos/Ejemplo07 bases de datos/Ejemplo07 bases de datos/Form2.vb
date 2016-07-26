Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Vb_mysqlDataSet.DataTable1' Puede moverla o quitarla según sea necesario.
        Me.DataTable1TableAdapter.Fill(Me.Vb_mysqlDataSet.DataTable1)

    End Sub
End Class