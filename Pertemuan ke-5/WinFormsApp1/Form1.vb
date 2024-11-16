Public Class Form1
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.GridLines = True
        ListView1.View = View.Details
        ListView1.Columns.Add("NIM", 50)
        ListView1.Columns.Add("Nama", 130)
        ListView1.Columns.Add("Jurusan", 100)
        TextBox1.Text = 1001
        TextBox2.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Arr(2) As String
        Arr(0) = TextBox1.Text
        Arr(1) = TextBox2.Text
        Arr(2) = TextBox3.Text
        Dim listitem As ListViewItem
        listitem = New ListViewItem
        listitem = ListView1.Items.Add(Arr(0))
        listitem.SubItems.Add(Arr(1))
        listitem.SubItems.Add(Arr(2))
        TextBox1.Text = TextBox1.Text - 1
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub
End Class
