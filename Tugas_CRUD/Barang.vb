Imports System.Data
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Public Class Barang
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles bt_backbrg.Click
        Me.Hide()
    End Sub

    Private Sub Barang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampil_barang()
    End Sub

    Private Sub tampil_barang()
        Try
            Call koneksi()
            da = New MySqlDataAdapter("SELECT * FROM barang", conn)
            ds = New DataSet
            da.Fill(ds, "brg")
            dgv_brg.DataSource = ds.Tables("brg")
        Catch ex As Exception
            MsgBox("Gagal menampilkan table barang")

        End Try
    End Sub

    Private Sub tambah_barang()
        Try
            If bt_tambahbrg.Text = "Tambah" Then
                bt_tambahbrg.Text = "Simpan"
                Call koneksi()
                Dim urutan As String
                Dim hitung As Long
                cmd = New MySqlCommand("SELECT * from barang where kode_barang in (select max(kode_barang) from barang)", conn)
                dr = cmd.ExecuteReader
                dr.Read()
                If Not dr.HasRows Then
                    urutan = "B" + "001"
                Else
                    hitung = Microsoft.VisualBasic.Right(dr.GetString(0), 3) + 1
                    urutan = "B" + Microsoft.VisualBasic.Right("000" & hitung, 3)
                End If
                tb_kodebrg.Text = urutan
                tb_namabrg.Focus()
            Else
                Call koneksi()
                Dim perintah As String = "INSERT INTO barang VALUES ('" & tb_kodebrg.Text & "','" & tb_namabrg.Text & "','" & tb_stok.Text & "','" & cb_satuan.Text & "','" & tb_hrgjual.Text & "','" & tb_hrgbeli.Text & "')"
            cmd = New MySqlCommand(perintah, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data barang berhasil ditambahkan")
                Call kosongkan()
                bt_tambahbrg.Text = "Tambah"
            End If
        Catch ex As Exception
            MsgBox("Data barang tidak berhasil ditambahkan")
        End Try
    End Sub

    Private Sub bt_tambahbrg_Click(sender As Object, e As EventArgs) Handles bt_tambahbrg.Click
        Call tambah_barang()
        Call tampil_barang()
    End Sub

    Private Sub kosongkan()
        tb_kodebrg.Text = ""
        tb_namabrg.Text = ""
        tb_hrgbeli.Text = ""
        tb_hrgjual.Text = ""
        tb_stok.Text = ""
        cb_satuan.Text = ""
    End Sub

    Private Sub ubah_barang()
        Try
            Call koneksi()
            Dim perintah As String = "UPDATE barang SET 
               nama_barang ='" & tb_namabrg.Text & "',
               jumlah= '" & tb_stok.Text & "',
               satuan = '" & cb_satuan.Text & "',
               hrg_beli ='" & tb_hrgbeli.Text & "',
               hrg_jual ='" & tb_hrgjual.Text & "'
            WHERE kode_barang ='" & tb_kodebrg.Text & "'"
            cmd = New MySqlCommand(perintah, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data barang berhasil Diubah")
            Call kosongkan()
        Catch ex As Exception
            MsgBox("Data barang tidak berhasil diubah")
        End Try
    End Sub

    Private Sub bt_updatebrg_Click(sender As Object, e As EventArgs) Handles bt_updatebrg.Click
        If MessageBox.Show("Apakah anda yakin ingin mengedit data barang?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
        End If
        Call ubah_barang()
        Call tampil_barang()
    End Sub

    Private Sub dgv_brg_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_brg.CellMouseClick
        tb_kodebrg.Text = dgv_brg.Rows(e.RowIndex).Cells(0).Value
        tb_namabrg.Text = dgv_brg.Rows(e.RowIndex).Cells(1).Value
        tb_stok.Text = dgv_brg.Rows(e.RowIndex).Cells(2).Value
        cb_satuan.Text = dgv_brg.Rows(e.RowIndex).Cells(3).Value
        tb_hrgbeli.Text = dgv_brg.Rows(e.RowIndex).Cells(4).Value
        tb_hrgjual.Text = dgv_brg.Rows(e.RowIndex).Cells(5).Value
    End Sub

    Private Sub delete_barang()
        Try
            Call koneksi()
            Dim perintah As String = "DELETE FROM barang WHERE kode_barang ='" & tb_kodebrg.Text & "'"
            cmd = New MySqlCommand(perintah, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data barang berhasil dihapus")
            Call kosongkan()
        Catch ex As Exception
            MsgBox("Data barang tidak berhasil dihapus")
        End Try
    End Sub

    Private Sub bt_deletebrg_Click(sender As Object, e As EventArgs) Handles bt_deletebrg.Click
        Call delete_barang()
        Call tampil_barang()
    End Sub
End Class