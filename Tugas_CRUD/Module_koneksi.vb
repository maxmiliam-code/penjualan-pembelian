Imports System.Data
Imports MySql.Data.MySqlClient
Module Module_koneksi
    Public conn As MySqlConnection
    Public dr As MySqlDataReader
    Public cmd As MySqlCommand
    Public ds As DataSet
    Public da As New MySqlDataAdapter

    Public Sub koneksi()
        Dim server As String = "Server=localhost; user id=root; password=; database=penjualan_a;"
        conn = New MySqlConnection(server)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
End Module
