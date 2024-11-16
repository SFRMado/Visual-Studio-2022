Imports System.Math
Public Class Form2
    Dim firstValue As Decimal = 0
    Dim secondValue As Decimal = 0
    Dim operation As String = ""
    Dim isNewEntry As Boolean = True

    Private Sub HandleNumberClick(number As String)
        If isNewEntry Then
            TextBox1.Text = number
            isNewEntry = False
        Else
            TextBox1.Text &= number
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        HandleNumberClick("0")
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        HandleNumberClick("1")
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        HandleNumberClick("2")
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        HandleNumberClick("3")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        HandleNumberClick("4")
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        HandleNumberClick("5")
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        HandleNumberClick("6")
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        HandleNumberClick("7")
    End Sub
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        HandleNumberClick("8")
    End Sub
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        HandleNumberClick("9")
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBox1.Text <> "" Then
            TextBox1.Text = (Decimal.Parse(TextBox1.Text) * -1).ToString()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Not TextBox1.Text.Contains(",") Then
            TextBox1.Text &= ","
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If TextBox1.Text <> "" Then
            TextBox1.Text = (Decimal.Parse(TextBox1.Text) / 100).ToString()
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        firstValue = 0
        secondValue = 0
        operation = ""
        isNewEntry = True
    End Sub

    Private Sub HandleOperation(op As String)
        If TextBox1.Text <> "" Then
            firstValue = Decimal.Parse(TextBox1.Text)
            operation = op
            TextBox2.Text = TextBox1.Text & " " & operation
            isNewEntry = True
        End If
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        HandleOperation("+")
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        HandleOperation("-")
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        HandleOperation("*")
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        HandleOperation("/")
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If TextBox1.Text <> "" Then
            TextBox1.Text = Math.Sqrt(Decimal.Parse(TextBox1.Text)).ToString()
        End If
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        HandleOperation("^")
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        If TextBox1.Text <> "" Then
            secondValue = Decimal.Parse(TextBox1.Text)
            Dim result As Decimal = 0

            Select Case operation
                Case "+"
                    result = firstValue + secondValue
                Case "-"
                    result = firstValue - secondValue
                Case "*"
                    result = firstValue * secondValue
                Case "/"
                    If secondValue <> 0 Then
                        result = firstValue / secondValue
                    Else
                        MessageBox.Show("Error!")
                        Return
                    End If
                Case "^"
                    result = Math.Pow(firstValue, secondValue)
            End Select

            TextBox2.Text = TextBox2.Text & " " & secondValue.ToString() & " = " & result.ToString()
            isNewEntry = True
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
