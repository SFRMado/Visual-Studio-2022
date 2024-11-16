Imports System.Data.Common
Imports System.Data.Odbc
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.ComboBox

Module Module1
    Public Conn As OdbcConnection
    Public da As OdbcDataAdapter
    Public ds As DataSet
    Public cmd As OdbcCommand
    Public rd As OdbcDataReader
    Public MyDb As String

    Public Sub Koneksi()
        MyDb = "Driver={MySQL ODBC 9.1 ANSI Driver};Server=localhost;Database=db_syspenggajian;User=SFR;Password=231204"
        Conn = New OdbcConnection(MyDb)
        Try
            If Conn.State = ConnectionState.Closed Then
                Conn.Open()
                Console.WriteLine("Connection Successful!")
            End If
        Catch ex As Exception
            Console.WriteLine("Connection Failed!" & ex.Message)
        End Try
    End Sub
End Module

Public Class Form1
    Public gajioperator, gajiofficeboy, gajistaff, gajisupervisor, gajimanager As Integer
    Private Function HitungGaji()
        Dim GajiKotor As Double
        Dim GajiBersih As Double
        Dim Potongan As Double
        Select Case ComboBox1.Text
            Case "Operator"
                GajiKotor = 3500000

            Case "Office Boy"
                GajiKotor = 2500000

            Case "Staff"
                GajiKotor = 1950000

            Case "Supervisor"
                GajiKotor = 7500000

            Case "Manager"
                GajiKotor = 12500000

        End Select
        
        Potongan = GajiKotor * 0.02
        GajiBersih = GajiKotor - Potongan


        TextBox3.Text = GajiKotor.ToString("N0")
        TextBox5.Text = Potongan.ToString("N0")
        TextBox4.Text = GajiBersih.ToString("N0")
        Return GajiKotor
    End Function

    Sub msgbox_btnHitungGaji()
        If String.IsNullOrWhiteSpace(TextBox2.Text) Then
            MessageBox.Show("Nama harus di Isi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox3.Clear()
            TextBox5.Clear()
            TextBox4.Clear()
            TextBox1.Focus()
            Return
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call IsiGridView()
        Call Cb1_Items()
        Call CekBersih()
        TextBox1.Focus()
    End Sub

    Private Sub btnHitungGaji_Click(sender As Object, e As EventArgs) Handles btnHitungGaji.Click
        Call HitungGaji()
        Call msgbox_btnHitungGaji()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If Not CekKosong() Then Return
        Dim gajiKotor As Decimal = (TextBox3.Text)
        Dim potongan As Decimal = (TextBox5.Text)
        Dim gajiBersih As Decimal = gajiKotor + potongan

        Dim query As String = "INSERT INTO systempenggajian (NIP, nama, Jabatan, gaji_kotor, potongan, gaji_bersih) VALUES (?, ?, ?, ?, ?, ?)"
        cmd = New OdbcCommand(query, Conn)
        cmd.Parameters.AddWithValue("NIP", TextBox1.Text)
        cmd.Parameters.AddWithValue("nama", TextBox2.Text)
        cmd.Parameters.AddWithValue("Jabatan", ComboBox1.SelectedItem?.ToString())
        cmd.Parameters.AddWithValue("gaji_kotor", Integer.Parse(TextBox3.Text.Replace(".", "")))
        cmd.Parameters.AddWithValue("potongan", Integer.Parse(TextBox5.Text.Replace(".", "")))
        cmd.Parameters.AddWithValue("gaji_bersih", Integer.Parse(TextBox4.Text.Replace(".", "")))

        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data telah berhasil disimpan!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            IsiGridView()
            CekBersih()
        Catch ex As Exception
            MessageBox.Show("Silahkan anda periksa kembali data yang ingin dimasukkan! " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView1_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles DataGridView1.DataError
        MessageBox.Show("Format data Error! " & e.Exception.Message)
        e.Cancel = True
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("Silahkan pilih data yang ingin diubah!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not CekKosong() Then Return

        Dim query As String = "UPDATE systempenggajian SET nama = ?, Jabatan = ?, gaji_kotor = ?, potongan = ?, gaji_bersih = ? WHERE NIP = ?"
        cmd = New OdbcCommand(query, Conn)
        cmd.Parameters.AddWithValue("nama", TextBox2.Text)
        cmd.Parameters.AddWithValue("Jabatan", ComboBox1.SelectedItem?.ToString())
        cmd.Parameters.AddWithValue("gaji_kotor", Integer.Parse(TextBox3.Text.Replace(".", "")))
        cmd.Parameters.AddWithValue("potongan", Integer.Parse(TextBox5.Text.Replace(".", "")))
        cmd.Parameters.AddWithValue("gaji_bersih", Integer.Parse(TextBox4.Text.Replace(".", "")))
        cmd.Parameters.AddWithValue("NIP", TextBox1.Text)

        Try
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            If rowsAffected > 0 Then
                MessageBox.Show("Data telah berhasil diubah!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                IsiGridView()
                CekBersih()
            Else
                MessageBox.Show("Data tidak dapat diubah!.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Silahkan pilih  data yang ingin diubah! " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("Silahkan pilih data yang ingin dihapus!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim query As String = "DELETE FROM systempenggajian WHERE NIP = ?"
        cmd = New OdbcCommand(query, Conn)
        cmd.Parameters.AddWithValue("NIP", TextBox1.Text)

        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data telah berhasil dihapus!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            IsiGridView()
            CekBersih()
        Catch ex As Exception
            MessageBox.Show("Silahkan coba kembali! " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        CekBersih()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim result As DialogResult = MessageBox.Show("Apakah anda yakin ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            TextBox1.Text = row.Cells("NIP").Value.ToString()
            TextBox2.Text = row.Cells("nama").Value.ToString()
            ComboBox1.SelectedItem = row.Cells("Jabatan").Value.ToString()
            TextBox3.Text = row.Cells("gaji_kotor").Value.ToString()
            TextBox5.Text = row.Cells("potongan").Value.ToString()
            TextBox4.Text = row.Cells("gaji_bersih").Value.ToString()
        End If
    End Sub

    Private Function CekKosong() As Boolean
        If String.IsNullOrWhiteSpace(TextBox2.Text) OrElse
           String.IsNullOrWhiteSpace(TextBox3.Text) OrElse
           String.IsNullOrWhiteSpace(TextBox5.Text) OrElse
           String.IsNullOrWhiteSpace(TextBox4.Text) Then

            MessageBox.Show("Semua kolom harus ada isi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function


    Sub Cb1_Items()
        ComboBox1.Items.Add("Operator")
        ComboBox1.Items.Add("Office Boy")
        ComboBox1.Items.Add("Staff")
        ComboBox1.Items.Add("Supervisor")
        ComboBox1.Items.Add("Manager")
    End Sub
    Private Function CekBersih()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        ComboBox1.SelectedIndex = -1
        TextBox1.Focus()
    End Function

    Private Function IsiGridView()
        Try
            Dim query As String = "SELECT NIP, nama, Jabatan, gaji_kotor, potongan, gaji_bersih FROM systempenggajian"
            da = New OdbcDataAdapter(query, Conn)
            ds = New DataSet()
            da.Fill(ds, "systempenggajian")
            DataGridView1.DataSource = ds.Tables("systempenggajian")

            For Each column As DataGridViewColumn In DataGridView1.Columns
                If column.Name = "gaji_kotor" OrElse column.Name = "potongan" OrElse column.Name = "gaji_bersih" Then
                    column.DefaultCellStyle.Format = "N0"
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("ERROR! PLEASE TRY AGAIN!!" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.Text
            Case "Operator"
                TextBox3.Text = "3.500.000"
                gajioperator = 3500000

            Case "Office Boy"
                TextBox3.Text = "2.500.000"
                gajiofficeboy = 2500000

            Case "Staff"
                TextBox3.Text = "1.950.000"
                gajistaff = 1950000

            Case "Supervisor"
                TextBox3.Text = "7.500.000"
                gajisupervisor = 7500000

            Case "Manager"
                TextBox3.Text = "12.500.000"
                gajimanager = 12500000
        End Select
    End Sub
End Class
