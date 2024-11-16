Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim harga1 As Double
        Dim harga2 As Double
        Dim harga3 As Double
        Dim total As Double

        Double.TryParse(TextBox1.Text, harga1)
        Double.TryParse(TextBox2.Text, harga2)
        Double.TryParse(TextBox3.Text, harga3)

        total = harga1 + harga2 + harga3

        TextBox5.Text = total.ToString()
    End Sub
End Class