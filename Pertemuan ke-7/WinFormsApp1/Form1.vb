Imports System.Data.Common
Imports System.Data.Odbc
Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Module Module1
    Public Conn As OdbcConnection
    Public da As OdbcDataAdapter
    Public ds As DataSet
    Public cmd As OdbcCommand
    Public rd As OdbcDataReader
    Public MyDb As String

    Public Sub Koneksi()
        MyDb = "Driver={MySQL ODBC 9.1 ANSI Driver};Server=localhost;Database=db_python;User=SFR;Password=231204"
        Conn = New OdbcConnection(MyDb)
        Try
            If Conn.State = ConnectionState.Closed Then
                Conn.Open()
                Console.WriteLine("Connection Successful!")
            End If
        Catch ex As Exception
            Console.WriteLine("Connection Failed! " & ex.Message)
        End Try
    End Sub
End Module

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call kosong()
        Call tampil_kode()
        Call Atur_grid()
        Call tampil_grid()
        Call isi()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then

            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)


            TextBox1.Text = row.Cells("id_barang").Value.ToString()
            TextBox4.Text = row.Cells("nama_barang").Value.ToString()
            TextBox3.Text = row.Cells("harga_barang").Value.ToString()
            TextBox2.Text = row.Cells("satuan").Value.ToString()
        End If
    End Sub

    Private Sub DataGridView1_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles DataGridView1.DataError

        If e.Exception.GetType() = GetType(FormatException) Then
            MessageBox.Show("Format cell tidak valid. Harap masukkan angka cell yang valid! ", "Data Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            MessageBox.Show("Terjadi kesalahan! " & e.Exception.Message, "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        e.Cancel = True
    End Sub
    Sub kosong()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox1.Focus()
    End Sub

    Sub isi()
        TextBox2.Clear()
        TextBox2.Focus()
    End Sub

    Sub tampil_kode()
        Try
            Dim query As String = "SELECT MAX(id_barang) FROM masterbarang"
            cmd = New OdbcCommand(query, Conn)
            rd = cmd.ExecuteReader()
            If rd.Read() And Not IsDBNull(rd(0)) Then
                TextBox1.Text = (Integer.Parse(rd(0)) + 1).ToString()
            Else
                TextBox1.Text = "1"
            End If
        Catch ex As Exception
            MessageBox.Show("Error! " & ex.Message)
        End Try
    End Sub


    Sub Atur_grid()
        If DataGridView1.Columns.Count >= 4 Then
            DataGridView1.Columns(0).Width = 70
            DataGridView1.Columns(1).Width = 120
            DataGridView1.Columns(2).Width = 100
            DataGridView1.Columns(3).Width = 50
            DataGridView1.Columns(0).HeaderText = "ID BARANG"
            DataGridView1.Columns(1).HeaderText = "NAMA BARANG"
            DataGridView1.Columns(2).HeaderText = "HARGA BARANG (Rp.)"
            DataGridView1.Columns(3).HeaderText = "SATUAN"
        Else
            Console.WriteLine("Error! Kolom tidak cukup pada DataGridView ")
        End If
    End Sub


    Sub tampil_grid()
        Try
            Dim query As String = "SELECT * FROM masterbarang"
            da = New OdbcDataAdapter(query, Conn)
            ds = New DataSet()
            da.Fill(ds, "masterbarang")
            DataGridView1.DataSource = ds.Tables("masterbarang")
        Catch ex As Exception
            MessageBox.Show("Error! " & ex.Message)
        End Try
    End Sub


    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If String.IsNullOrWhiteSpace(TextBox1.Text) OrElse
       String.IsNullOrWhiteSpace(TextBox2.Text) OrElse
       String.IsNullOrWhiteSpace(TextBox3.Text) OrElse
       String.IsNullOrWhiteSpace(TextBox4.Text) Then

            MessageBox.Show("Silahkan coba kembali! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim query As String = "INSERT INTO masterbarang (id_barang, nama_barang, harga_barang, satuan) VALUES (?, ?, ?, ?)"
        cmd = New OdbcCommand(query, Conn)

        cmd.Parameters.AddWithValue("id_barang", TextBox1.Text)
        cmd.Parameters.AddWithValue("nama_barang", TextBox4.Text)
        cmd.Parameters.AddWithValue("harga_barang", TextBox3.Text)
        cmd.Parameters.AddWithValue("satuan", TextBox2.Text)

        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data Telah Berhasil Disimpan! ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tampil_grid()
            tampil_kode()
            kosong()
        Catch ex As Exception

        End Try
    End Sub



    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If TextBox1.Text <> "" Then
            Dim query As String = "UPDATE masterbarang SET nama_barang = ?, harga_barang = ?, satuan = ? WHERE id_barang = ?"
            cmd = New OdbcCommand(query, Conn)
            cmd.Parameters.AddWithValue("nama_barang", TextBox4.Text)
            cmd.Parameters.AddWithValue("harga_barang", TextBox3.Text)
            cmd.Parameters.AddWithValue("satuan", TextBox2.Text)
            cmd.Parameters.AddWithValue("id_barang", TextBox1.Text)

            Try
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Telah Berhasil Diubah! ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                tampil_grid()
                kosong()
            Catch ex As Exception
                MessageBox.Show("Silahkan coba kembali! " & vbCrLf & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Silahkan pilih data yang ingin diubah! ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If TextBox1.Text <> "" Then
            Dim query As String = "DELETE FROM masterbarang WHERE id_barang = ?"
            cmd = New OdbcCommand(query, Conn)
            cmd.Parameters.AddWithValue("id_barang", TextBox1.Text)

            Try
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Telah Berhasil Dihapus! ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ds.Tables("masterbarang").Clear()
                tampil_grid()
                tampil_kode()
                kosong()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Silahkan pilih data yang ingin dihapus! ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        kosong()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim result As DialogResult = MessageBox.Show("Apakah anda yakin ? ", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class
