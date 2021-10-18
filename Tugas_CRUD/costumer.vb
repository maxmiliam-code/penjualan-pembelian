Imports System.Data
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Public Class costumer
    Private Sub bt_backcos_Click(sender As Object, e As EventArgs) Handles bt_backcos.Click
        Me.Hide()
    End Sub

    Private Sub costumer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampil_costumer()
    End Sub

    Private Sub tampil_costumer()
        Try
            Call koneksi()
            da = New MySqlDataAdapter("SELECT * FROM costumer", conn)
            ds = New DataSet
            da.Fill(ds, "cstmr")
            dgv_cos.DataSource = ds.Tables("cstmr")
        Catch ex As Exception
            MsgBox("Gagal menampilkan table costumer")

        End Try
    End Sub

    Private Sub tambah_costumer()
        Try
            If bt_tambahcos.Text = "Tambah" Then
                bt_tambahcos.Text = "Simpan"
                Call koneksi()
                Dim urutan As String
                Dim hitung As Long
                cmd = New MySqlCommand("SELECT * from costumer where kode_costumer in (select max(kode_costumer) from costumer)", conn)
                dr = cmd.ExecuteReader
                dr.Read()
                If Not dr.HasRows Then
                    urutan = "C" + "001"
                Else
                    hitung = Microsoft.VisualBasic.Right(dr.GetString(0), 3) + 1
                    urutan = "C" + Microsoft.VisualBasic.Right("000" & hitung, 3)
                End If
                tb_kodecos.Text = urutan
                tb_namacos.Focus()
            Else
                Call koneksi()
                Dim perintah As String = "INSERT INTO costumer VALUES ('" & tb_kodecos.Text & "','" & tb_namacos.Text & "','" & tb_alamatcos.Text & "','" & tb_telponcos.Text & "')"
                cmd = New MySqlCommand(perintah, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data costumer berhasil ditambahkan")
                Call kosongkan()
                bt_tambahcos.Text = "Tambah"
            End If
        Catch ex As Exception
            MsgBox("Data costumer tidak berhasil ditambahkan")
        End Try
    End Sub

    Private Sub bt_tambahcos_Click(sender As Object, e As EventArgs) Handles bt_tambahcos.Click
        Call tambah_costumer()
        Call tampil_costumer()
    End Sub

    Private Sub kosongkan()
        tb_kodecos.Text = ""
        tb_namacos.Text = ""
        tb_alamatcos.Text = ""
        tb_telponcos.Text = ""
    End Sub

    Private Sub ubah_costumer()
        Try
            Call koneksi()
            Dim perintah As String = "UPDATE costumer SET 
               nama_costumer ='" & tb_namacos.Text & "',
               almt= '" & tb_alamatcos.Text & "',
               tlp ='" & tb_telponcos.Text & "'
            WHERE kode_costumer ='" & tb_kodecos.Text & "'"
            cmd = New MySqlCommand(perintah, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data costumer berhasil Diubah")
            Call kosongkan()
        Catch ex As Exception
            MsgBox("Data costumer tidak berhasil diubah")
        End Try
    End Sub

    Private Sub bt_upcos_Click(sender As Object, e As EventArgs) Handles bt_upcos.Click
        If MessageBox.Show("Apakah anda yakin ingin mengedit data costumer?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
        End If
        Call ubah_costumer()
        Call tampil_costumer()
    End Sub

    Private Sub dgv_cos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_cos.CellContentClick
        tb_kodecos.Text = dgv_cos.Rows(e.RowIndex).Cells(0).Value
        tb_namacos.Text = dgv_cos.Rows(e.RowIndex).Cells(1).Value
        tb_alamatcos.Text = dgv_cos.Rows(e.RowIndex).Cells(2).Value
        tb_telponcos.Text = dgv_cos.Rows(e.RowIndex).Cells(3).Value
    End Sub

    Private Sub delete_costumer()
        Try
            Call koneksi()
            Dim perintah As String = "DELETE FROM costumer WHERE kode_costumer ='" & tb_kodecos.Text & "'"
            cmd = New MySqlCommand(perintah, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data costumer berhasil dihapus")
            Call kosongkan()
        Catch ex As Exception
            MsgBox("Data costumer tidak berhasil dihapus")
        End Try
    End Sub

    Private Sub bt_delcos_Click(sender As Object, e As EventArgs) Handles bt_delcos.Click
        Call delete_costumer()
        Call tampil_costumer()
    End Sub


End Class