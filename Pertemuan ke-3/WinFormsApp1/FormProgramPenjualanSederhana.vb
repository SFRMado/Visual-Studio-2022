Public Class FormProgramPenjualanSederhana
    Private Sub btnhitung_Click(sender As Object, e As EventArgs) Handles btnhitung.Click
        Dim harga As Decimal = txtharga.Text
        Dim jumlah As Integer = txtjumlah.Text
        Dim totalharga As Decimal
        Dim diskon As Decimal = 0
        Dim bonus As String

        totalharga = jumlah * harga


        If totalharga >= 500000 Then
            bonus = "Kaos"
            diskon = totalharga * 0.2
        ElseIf totalharga >= 200000 Then
            bonus = "Sapu Tangan"
            diskon = totalharga * 0.15
        ElseIf totalharga >= 100000 Then
            bonus = "Gelas"
            diskon = totalharga * 0.1
        ElseIf totalharga >= 50000 Then
            bonus = "Sendok"
            diskon = totalharga * 0.05
        Else
            bonus = "Tidak ada"
        End If


        Dim totalBayar As Decimal = totalharga - diskon


        txtbonus.Text = bonus
        txttotalharga.Text = totalharga.ToString()
        txtdiskon.Text = diskon.ToString()
        txttotalbayar.Text = totalBayar.ToString()
    End Sub

    Private Sub btnkeluar_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub btnulang_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        txtbonus.Clear()
        txtnamabarang.Clear()
        txtdiskon.Clear()
        txtjumlah.Clear()
        txttotalbayar.Clear()
        txttotalharga.Clear()
        txtharga.Clear()
    End Sub
End Class