Imports MySql.Data.MySqlClient
Module Module1
    Public Conn As MySqlConnection
    Public Da As MySqlDataAdapter
    Public Ds As DataSet
    Public Rd As MySqlDataReader
    Public Cmd As MySqlCommand
    Public sql As String
    Public Sub koneksi()
        Conn = New MySqlConnection("Data Source=localhost;user id=root;database=home_inventory;")
        Try
            Conn.Open()
        Catch ex As Exception
            MsgBox("Error in connection, please check the database and connection server.", vbCritical, "System Demo Only")
            End
        End Try
    End Sub
End Module
