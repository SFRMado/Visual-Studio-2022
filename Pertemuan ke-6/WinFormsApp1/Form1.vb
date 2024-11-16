Public Class Form1
    Public gajioperator, gajiofficeboy, gajistaff, gajisupervisor, gajimanager As Integer

    Sub YNTKTS()
        If txtNama.Text = "" Then
            MessageBox.Show("Name container cannot empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
        Call hitung()
        End If
    End Sub
    Private Function hitung()
        Dim GajiKotor As Double = 0
        Dim GajiBersih As Double
        Dim Potongan As Double
        Select Case cbJabatan.Text
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

            Case Else
                GajiKotor = 0
        End Select

        Potongan = GajiKotor * 0.02
        GajiBersih = GajiKotor - Potongan


        txtGajiKotor.Text = GajiKotor.ToString("N0")
        txtPotongan.Text = Potongan.ToString("N0")
        txtGajiBersih.Text = GajiBersih.ToString("N0")
        Return GajiKotor
    End Function


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbJabatan.Items.Add("Operator")
        cbJabatan.Items.Add("Office Boy")
        cbJabatan.Items.Add("Staff")
        cbJabatan.Items.Add("Supervisor")
        cbJabatan.Items.Add("Manager")

        txtNIP.Text = 1001
        txtNama.Focus()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNama.Text = ""
        txtGajiKotor.Text = ""
        txtPotongan.Text = ""
        txtGajiBersih.Text = ""
        txtNIP.Text = txtNIP.Text + 1
        txtNama.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim close As String
        close = MessageBox.Show("Are you sure ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If close = MsgBoxResult.Yes Then
            End
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnProsesGaji_Click(sender As Object, e As EventArgs) Handles btnProsesGaji.Click
        YNTKTS()
        hitung()
    End Sub

    Private Sub cbJabatan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbJabatan.SelectedIndexChanged
        Select Case cbJabatan.Text
            Case "Operator"
                txtGajiKotor.Text = "3.500.000"
                gajioperator = 3500000

            Case "Office Boy"
                txtGajiKotor.Text = "2.500.000"
                gajiofficeboy = 2500000

            Case "Staff"
                txtGajiKotor.Text = "1.950.000"
                gajistaff = 1950000

            Case "Supervisor"
                txtGajiKotor.Text = "7.500.000"
                gajisupervisor = 7500000

            Case "Manager"
                txtGajiKotor.Text = "12.500.000"
                gajimanager = 12500000
        End Select
    End Sub
End Class
