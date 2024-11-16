Public Class Form3
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1 = Double.Parse(TextBox1.Text)
        Dim num2 = Double.Parse(TextBox2.Text)
        TextBox3.Text = (num1 + num2).ToString
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim num1 As Double = Double.Parse(TextBox1.Text)
        Dim num2 As Double = Double.Parse(TextBox2.Text)
        TextBox3.Text = (num1 - num2).ToString()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim num1 As Double = Double.Parse(TextBox1.Text)
        Dim num2 As Double = Double.Parse(TextBox2.Text)
        TextBox3.Text = (num1 * num2).ToString()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim num1 As Double = Double.Parse(TextBox1.Text)
        Dim num2 As Double = Double.Parse(TextBox2.Text)
        If num2 <> 0 Then
            TextBox3.Text = (num1 / num2).ToString()
        Else
            TextBox3.Text = "Error!"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim num1 As Double = Double.Parse(TextBox1.Text)
        If num1 >= 0 Then
            TextBox3.Text = Math.Sqrt(num1).ToString()
        Else
            TextBox3.Text = "Error!"
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim num1 As Double = Double.Parse(TextBox1.Text)
        Dim num2 As Double = Double.Parse(TextBox2.Text)

        If Not Double.TryParse(TextBox1.Text, num1) Then
            TextBox3.Text = "Error!"
            Exit Sub
        End If

        If Not Double.TryParse(TextBox2.Text, num2) Then
            TextBox3.Text = "Error!"
            Exit Sub
        End If
        TextBox3.Text = Math.Pow(num1, num2).ToString()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text = String.Empty
        TextBox2.Text = String.Empty
        TextBox3.Text = String.Empty
    End Sub
End Class