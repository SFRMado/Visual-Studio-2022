Public Class FormPercabanganatauPemilihan
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nilai As Integer
        If Integer.TryParse(TextBox2.Text, nilai) Then
            If nilai >= 85 Then
                TextBox3.Text = "Lulus, Sangat Memuaskan"
            ElseIf nilai >= 70 Then
                TextBox3.Text = "Lulus, Memuaskan"
            ElseIf nilai >= 60 Then
                TextBox3.Text = "Lulus, Cukup Memuaskan"
            Else
                TextBox3.Text = "Tidak Lulus, Silahkan Anda Mengulang"
            End If
        Else
            TextBox2.Clear()
            TextBox3.Clear()
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub
End Class
