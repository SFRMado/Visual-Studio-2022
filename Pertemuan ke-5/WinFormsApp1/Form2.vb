Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Arr(6, 1) As String
        Arr(0, 0) = "NIM"
        Arr(0, 1) = "Nama"
        Arr(1, 0) = "Jenis Kelamin"
        Arr(1, 1) = "Fakultas"
        Arr(2, 0) = "Laki-Laki"
        Arr(2, 1) = "Perempuan"

        For Baris = 0 To 1
            For kolom = 0 To 1
                ListView1.Columns.Add(Arr(Baris, kolom), 100)
            Next kolom
        Next Baris

        For Baris = 2 To 2
            For kolom = 0 To 1
                ComboBox1.Items.Add(Arr(Baris, kolom))
            Next kolom
        Next Baris
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ArrInput(6) As String
        ArrInput(0) = TextBox1.Text
        ArrInput(1) = TextBox2.Text
        ArrInput(2) = ComboBox1.Text
        ArrInput(3) = ComboBox2.Text
        ArrInput(4) = ComboBox3.Text
        ArrInput(5) = ComboBox4.Text

        Dim listitem As ListViewItem
        listitem = ListView1.Items.Add(ArrInput(0))
        listitem.SubItems.Add(ArrInput(1))
        listitem.SubItems.Add(ArrInput(2))
        listitem.SubItems.Add(ArrInput(3))
    End Sub

End Class
