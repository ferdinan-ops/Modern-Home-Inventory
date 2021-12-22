Imports MySql.Data.MySqlClient
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmInventory
    Private Sub RandomCharAndNum()
        Dim tahun = Format(CDate(DateAndTime.Now), "yMMddhhss") 'menambahkan DateTime dengan Format jam dan detik
        serial_number.Text = RandomString(4, _chars) & tahun & RandomString(2, _nums) 'memanggil fungsi random karakter,jam dan detik,number
    End Sub
    Private Const _chars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ" 'untuk random characters
    Private Const _nums As String = "0123456789" 'untuk random number
    Private Shared ReadOnly _randLock = New Object()
    Private Shared ReadOnly _rnd = New Random()
    Private Shared Function RandomString(ByVal size As Integer, ByVal chars As String) As String
        Dim arr = New Char(size - 1) {}
        For i As Integer = 0 To size - 1
            SyncLock _randLock
                arr(i) = chars(_rnd.Next(chars.Length))
            End SyncLock
        Next
        Return New String(arr)
    End Function
    Sub otomatis()
        Call koneksi()
        Dim hitung As Long
        Dim urutan As String
        Cmd = New MySqlCommand("select id_barang from inventory order by id_barang desc", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows = True Then
            urutan = "BRG" + "001"
        Else
            hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 3) + 1
            urutan = "BRG" + Microsoft.VisualBasic.Right("000" & hitung, 3)
        End If
        id_barang.Text = urutan
        Rd.Close()
    End Sub
    Sub setting_header()
        Try
            DataGridView1.Columns(0).Width = 100
            DataGridView1.Columns(1).Width = 100
            DataGridView1.Columns(2).Width = 100
            DataGridView1.Columns(3).Width = 100
            DataGridView1.Columns(4).Width = 80
            DataGridView1.Columns(5).Width = 100
            DataGridView1.Columns(6).Width = 90

            DataGridView1.Columns(0).HeaderText = "Inventory Item"
            DataGridView1.Columns(1).HeaderText = "Location"
            DataGridView1.Columns(2).HeaderText = "Serial Number"
            DataGridView1.Columns(3).HeaderText = "Purchase Price"
            DataGridView1.Columns(4).HeaderText = "Date Price"
            DataGridView1.Columns(5).HeaderText = "Store/Website"
            DataGridView1.Columns(6).HeaderText = "Note"
        Catch ex As Exception
        End Try
    End Sub
    Sub tampil()
        Da = New MySqlDataAdapter("select nama_barang,location,serial_number,harga,tgl_beli,toko,note from inventory order by id_barang", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "inventory")
        DataGridView1.DataSource = Ds.Tables("inventory")
    End Sub
    Sub bersih()
        searchbox.Text = "Search"
        inventory_item.Clear()
        location.Text = " "
        serial_number.Clear()
        purchase_price.Clear()
        store.Clear()
        note.Clear()
        PictureBox1.Image = Nothing
        photo.Text = ""
        Call otomatis()
    End Sub
    Private Sub frmInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call tampil()
        Call otomatis()
        Call setting_header()
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Dim pathfile As String = Nothing

        OpenFileDialog1.ShowDialog()
        OpenFileDialog1.Filter = "JPG Files(*.jpg)|*.jpg"
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        pathfile = OpenFileDialog1.FileName
        photo.Text = OpenFileDialog1.FileName

        PictureBox1.Image = Image.FromFile(photo.Text)
    End Sub

    Private Sub GunaTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btsave_Click(sender As Object, e As EventArgs) Handles btsave.Click
        Dim ms As New MemoryStream

        Try
            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
        Catch ex As Exception
            MessageBox.Show("ERROR" & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Cmd = New MySqlCommand
        Cmd.Connection = Conn
        sql = "INSERT INTO `inventory`(`id_barang`, `nama_barang`, `location`, `serial_number`, `harga`, `tgl_beli`, `toko`, `note`, `photo`) VALUES (@kode,@nama,@lokasi,@noserial,@harga,@tgl,@toko,@note,@foto)"

        Cmd.Parameters.Add("@kode", MySqlDbType.VarChar).Value = id_barang.Text
        Cmd.Parameters.Add("@nama", MySqlDbType.VarChar).Value = inventory_item.Text
        Cmd.Parameters.Add("@lokasi", MySqlDbType.VarChar).Value = location.Text
        Cmd.Parameters.Add("@noserial", MySqlDbType.VarChar).Value = serial_number.Text
        Cmd.Parameters.Add("@harga", MySqlDbType.Int64).Value = purchase_price.Text
        Cmd.Parameters.Add("@tgl", MySqlDbType.Date).Value = date_purchased.Text
        Cmd.Parameters.Add("@toko", MySqlDbType.VarChar).Value = store.Text
        Cmd.Parameters.Add("@note", MySqlDbType.VarChar).Value = note.Text
        Cmd.Parameters.Add("@foto", MySqlDbType.Blob).Value = ms.ToArray()

        Cmd.CommandText = sql

        Try
            Cmd.ExecuteNonQuery()
            MsgBox("DATA ADDED SUCCESFULLY", vbInformation)
        Catch ex As Exception
            MessageBox.Show("ERROR" & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
        Call tampil()
        Call bersih()
    End Sub

    Private Sub btsearch_Click(sender As Object, e As EventArgs) Handles btsearch.Click
        Call koneksi()
        sql = "select *from inventory where nama_barang like '%" & searchbox.Text & "%'"
        Cmd = New MySqlCommand(sql, Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()

        Try

            Dim gambar() As Byte

            If Rd.HasRows() Then

                gambar = Rd("photo")

                Dim ms As New MemoryStream(gambar)
                PictureBox1.Image = Image.FromStream(ms)
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                id_barang.Text = Rd("id_barang")
                inventory_item.Text = Rd("nama_barang")
                location.Text = Rd("location")
                serial_number.Text = Rd("serial_number")
                purchase_price.Text = Rd("harga")
                date_purchased.Text = Rd("tgl_beli")
                store.Text = Rd("toko")
                note.Text = Rd("note")

                Print.PictureBox1.Image = Image.FromStream(ms)
                Print.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                Print.lb_nama.Text = Rd("nama_barang")
                Print.lb_location.Text = Rd("location")
                Print.lb_serial.Text = Rd("serial_number")
                Print.lb_price.Text = Rd("harga")
                Print.lb_date.Text = Rd("tgl_beli")
                Print.lb_store.Text = Rd("toko")
                Print.lb_note.Text = Rd("note")
            Else
                PictureBox1.Image = Nothing
                MsgBox("YOUR DATA DOES NOT EXIST", vbCritical, "Demo System")
            End If
            Rd.Close()
        Catch ex As Exception
            MessageBox.Show("ERROR : " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        If searchbox.Text = "" Then
            PictureBox1.Image = Nothing
        End If
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        End
    End Sub

    Private Sub btupdate_Click(sender As Object, e As EventArgs) Handles btupdate.Click

        If inventory_item.Text = "" Or location.Text = "" Or serial_number.Text = "" Or purchase_price.Text = "" Or date_purchased.Text = "" Or store.Text = "" Or note.Text = "" Or id_barang.Text = "" Then
            MsgBox("PLEASE CHECK BACK", vbCritical, "Demo System")
        Else

            Dim ms2 As New MemoryStream

            Try
                PictureBox1.Image.Save(ms2, PictureBox1.Image.RawFormat)
            Catch ex As Exception
                MessageBox.Show("ERROR" & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Cmd = New MySqlCommand
            Cmd.Connection = Conn
            sql = "update inventory set nama_barang=@nama , location=@lokasi, serial_number=@noserial, harga=@harga, tgl_beli=@tgl, toko=@toko, note=@note, photo=@foto where id_barang= '" & id_barang.Text & "'"

            Cmd.Parameters.Add("@nama", MySqlDbType.VarChar).Value = inventory_item.Text
            Cmd.Parameters.Add("@lokasi", MySqlDbType.VarChar).Value = location.Text
            Cmd.Parameters.Add("@noserial", MySqlDbType.VarChar).Value = serial_number.Text
            Cmd.Parameters.Add("@harga", MySqlDbType.Int64).Value = purchase_price.Text
            Cmd.Parameters.Add("@tgl", MySqlDbType.Date).Value = date_purchased.Text
            Cmd.Parameters.Add("@toko", MySqlDbType.VarChar).Value = store.Text
            Cmd.Parameters.Add("@note", MySqlDbType.VarChar).Value = note.Text
            Cmd.Parameters.Add("@foto", MySqlDbType.Blob).Value = ms2.ToArray()

            Cmd.CommandText = sql

            Try
                Cmd.ExecuteNonQuery()
                MsgBox("DATA UPDATED SUCCESFULLY", vbInformation)
            Catch ex As Exception
                MessageBox.Show("ERROR" & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try
            Rd.Close()
            Call tampil()
            Call bersih()
        End If
    End Sub

    Private Sub btdelete_Click(sender As Object, e As EventArgs) Handles btdelete.Click
        If inventory_item.Text = "" Or location.Text = "" Or serial_number.Text = "" Or purchase_price.Text = "" Or date_purchased.Text = "" Or store.Text = "" Or note.Text = "" Or id_barang.Text = "" Then
            MsgBox("PLEASE CHECK BACK", vbCritical, "Demo System")
        Else
            Try

                Call koneksi()

                Dim str2 As String

                str2 = "delete from inventory where id_barang = '" & id_barang.Text & "'"

                Cmd = New MySqlCommand(str2, Conn)

                Cmd.ExecuteNonQuery()

                MessageBox.Show("DATA DELETED SUCCESFULLY")

            Catch ex As Exception

                MessageBox.Show("Data Gagal Dihapus.")

            End Try
            Call tampil()
            Call bersih()
        End If
    End Sub

    Private Sub searchbox_MouseClick(sender As Object, e As MouseEventArgs) Handles searchbox.MouseClick
        searchbox.Clear()
    End Sub

    Private Sub serial_number_MouseClick(sender As Object, e As MouseEventArgs) Handles serial_number.MouseClick
        RandomCharAndNum()
    End Sub

    Private Sub btprint_Click(sender As Object, e As EventArgs) Handles btprint.Click
        Print.Show()
    End Sub

    Private Sub searchbox_MouseLeave(sender As Object, e As EventArgs) Handles searchbox.MouseLeave
        If searchbox.Text = "" Then
            searchbox.Text = "Search"
            searchbox.FocusedBorderColor = Color.Silver
        End If
    End Sub
End Class
