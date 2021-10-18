Public Class menu_utama
    Dim Barang As New Barang
    Dim pembelian As New pembelian
    Dim penjualan As New penjualan
    Dim costumer As New costumer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Barang.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        costumer.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        pembelian.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        penjualan.Show()
    End Sub
End Class