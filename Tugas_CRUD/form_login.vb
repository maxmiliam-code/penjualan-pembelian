Imports System.Data
Imports MySql.Data.MySqlClient
Public Class form_login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call koneksi()
        Dim perintah As String = "SELECT * FROM user
        WHERE username='" & tb_username.Text & "'
        AND password='" & tb_password.Text & "'
        AND status='0'"
        cmd = New MySqlCommand(perintah, conn)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            Dim menu_utama As New menu_utama
            menu_utama.Show()
            Me.Hide()
        Else
            MsgBox("Login Gagal")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class