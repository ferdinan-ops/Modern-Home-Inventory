<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventory
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInventory))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.inventory_item = New Guna.UI.WinForms.GunaTextBox()
        Me.serial_number = New Guna.UI.WinForms.GunaTextBox()
        Me.location = New Guna.UI.WinForms.GunaComboBox()
        Me.purchase_price = New Guna.UI.WinForms.GunaTextBox()
        Me.date_purchased = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.store = New Guna.UI.WinForms.GunaTextBox()
        Me.note = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.photo = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.id_barang = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.DataGridView1 = New Guna.UI.WinForms.GunaDataGridView()
        Me.GunaElipsePanel1 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btprint = New Guna.UI.WinForms.GunaButton()
        Me.btdelete = New Guna.UI.WinForms.GunaButton()
        Me.btupdate = New Guna.UI.WinForms.GunaButton()
        Me.btsave = New Guna.UI.WinForms.GunaButton()
        Me.btn_exit = New Guna.UI.WinForms.GunaButton()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.searchbox = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaElipsePanel2 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.btsearch = New Guna.UI.WinForms.GunaButton()
        Me.lbusername = New System.Windows.Forms.Label()
        Me.GunaCirclePictureBox1 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.GunaElipsePanel3 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GunaElipsePanel4 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GunaElipse2 = New Guna.UI.WinForms.GunaElipse(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaElipsePanel1.SuspendLayout()
        Me.GunaElipsePanel2.SuspendLayout()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaElipsePanel3.SuspendLayout()
        Me.GunaElipsePanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Poppins", 11.89565!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Inventory Item"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Poppins", 11.89565!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 34)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Location" & Global.Microsoft.VisualBasic.ChrW(13)
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Poppins", 11.89565!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 34)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Serial Number"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Poppins", 11.89565!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(157, 34)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Purchase Price"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Poppins", 11.89565!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label5.Location = New System.Drawing.Point(410, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(183, 34)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Date Purchased"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Poppins", 11.89565!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 254)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(151, 34)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Store/Website"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Poppins", 11.89565!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 305)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(151, 34)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Note"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'inventory_item
        '
        Me.inventory_item.BackColor = System.Drawing.Color.Transparent
        Me.inventory_item.BaseColor = System.Drawing.Color.White
        Me.inventory_item.BorderColor = System.Drawing.Color.Silver
        Me.inventory_item.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.inventory_item.FocusedBaseColor = System.Drawing.Color.White
        Me.inventory_item.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.inventory_item.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.inventory_item.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.inventory_item.Location = New System.Drawing.Point(172, 52)
        Me.inventory_item.Name = "inventory_item"
        Me.inventory_item.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.inventory_item.Radius = 4
        Me.inventory_item.SelectedText = ""
        Me.inventory_item.Size = New System.Drawing.Size(559, 32)
        Me.inventory_item.TabIndex = 8
        '
        'serial_number
        '
        Me.serial_number.BackColor = System.Drawing.Color.Transparent
        Me.serial_number.BaseColor = System.Drawing.Color.White
        Me.serial_number.BorderColor = System.Drawing.Color.Silver
        Me.serial_number.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.serial_number.FocusedBaseColor = System.Drawing.Color.White
        Me.serial_number.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.serial_number.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.serial_number.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.serial_number.Location = New System.Drawing.Point(172, 152)
        Me.serial_number.Name = "serial_number"
        Me.serial_number.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.serial_number.Radius = 4
        Me.serial_number.SelectedText = ""
        Me.serial_number.Size = New System.Drawing.Size(559, 32)
        Me.serial_number.TabIndex = 9
        '
        'location
        '
        Me.location.BackColor = System.Drawing.Color.Transparent
        Me.location.BaseColor = System.Drawing.Color.White
        Me.location.BorderColor = System.Drawing.Color.Silver
        Me.location.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.location.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.location.FocusedColor = System.Drawing.Color.Empty
        Me.location.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.location.ForeColor = System.Drawing.Color.Black
        Me.location.FormattingEnabled = True
        Me.location.Items.AddRange(New Object() {"Teras", "Taman", "Garasi", "Gudang", "Ruang Tamu", "Ruang Makan", "Dapur", "Toilet", "Ruang Kerja", "Ruang Belajar", "Kamar Tidur", " "})
        Me.location.Location = New System.Drawing.Point(172, 106)
        Me.location.Name = "location"
        Me.location.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.location.OnHoverItemForeColor = System.Drawing.Color.White
        Me.location.Radius = 4
        Me.location.Size = New System.Drawing.Size(559, 30)
        Me.location.TabIndex = 10
        '
        'purchase_price
        '
        Me.purchase_price.BackColor = System.Drawing.Color.Transparent
        Me.purchase_price.BaseColor = System.Drawing.Color.White
        Me.purchase_price.BorderColor = System.Drawing.Color.Silver
        Me.purchase_price.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.purchase_price.FocusedBaseColor = System.Drawing.Color.White
        Me.purchase_price.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.purchase_price.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.purchase_price.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.purchase_price.Location = New System.Drawing.Point(172, 202)
        Me.purchase_price.Name = "purchase_price"
        Me.purchase_price.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.purchase_price.Radius = 4
        Me.purchase_price.SelectedText = ""
        Me.purchase_price.Size = New System.Drawing.Size(232, 32)
        Me.purchase_price.TabIndex = 12
        '
        'date_purchased
        '
        Me.date_purchased.BackColor = System.Drawing.Color.Transparent
        Me.date_purchased.BaseColor = System.Drawing.Color.White
        Me.date_purchased.BorderColor = System.Drawing.Color.Silver
        Me.date_purchased.CustomFormat = "yyy/MM/dd"
        Me.date_purchased.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.date_purchased.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.date_purchased.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.date_purchased.ForeColor = System.Drawing.Color.Black
        Me.date_purchased.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.date_purchased.Location = New System.Drawing.Point(599, 202)
        Me.date_purchased.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.date_purchased.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.date_purchased.Name = "date_purchased"
        Me.date_purchased.OnHoverBaseColor = System.Drawing.Color.White
        Me.date_purchased.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.date_purchased.OnHoverForeColor = System.Drawing.Color.Black
        Me.date_purchased.OnPressedColor = System.Drawing.Color.Black
        Me.date_purchased.Radius = 4
        Me.date_purchased.Size = New System.Drawing.Size(132, 30)
        Me.date_purchased.TabIndex = 13
        Me.date_purchased.Text = "2021/12/09"
        Me.date_purchased.Value = New Date(2021, 12, 9, 13, 57, 45, 159)
        '
        'store
        '
        Me.store.BackColor = System.Drawing.Color.Transparent
        Me.store.BaseColor = System.Drawing.Color.White
        Me.store.BorderColor = System.Drawing.Color.Silver
        Me.store.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.store.FocusedBaseColor = System.Drawing.Color.White
        Me.store.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.store.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.store.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.store.Location = New System.Drawing.Point(172, 254)
        Me.store.Name = "store"
        Me.store.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.store.Radius = 4
        Me.store.SelectedText = ""
        Me.store.Size = New System.Drawing.Size(559, 32)
        Me.store.TabIndex = 14
        '
        'note
        '
        Me.note.BackColor = System.Drawing.Color.Transparent
        Me.note.BaseColor = System.Drawing.Color.White
        Me.note.BorderColor = System.Drawing.Color.Silver
        Me.note.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.note.FocusedBaseColor = System.Drawing.Color.White
        Me.note.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.note.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.note.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.note.Location = New System.Drawing.Point(172, 305)
        Me.note.Name = "note"
        Me.note.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.note.Radius = 4
        Me.note.SelectedText = ""
        Me.note.Size = New System.Drawing.Size(559, 32)
        Me.note.TabIndex = 15
        '
        'GunaButton1
        '
        Me.GunaButton1.Animated = True
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton1.BaseColor = System.Drawing.Color.White
        Me.GunaButton1.BorderColor = System.Drawing.Color.Silver
        Me.GunaButton1.BorderSize = 2
        Me.GunaButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Poppins", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton1.ForeColor = System.Drawing.Color.Black
        Me.GunaButton1.Image = Nothing
        Me.GunaButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton1.Location = New System.Drawing.Point(780, 299)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Radius = 6
        Me.GunaButton1.Size = New System.Drawing.Size(234, 38)
        Me.GunaButton1.TabIndex = 17
        Me.GunaButton1.Text = "Choose Image"
        Me.GunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'photo
        '
        Me.photo.BackColor = System.Drawing.SystemColors.Control
        Me.photo.Font = New System.Drawing.Font("Poppins", 11.89565!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.photo.Location = New System.Drawing.Point(399, 11)
        Me.photo.Name = "photo"
        Me.photo.Size = New System.Drawing.Size(517, 34)
        Me.photo.TabIndex = 16
        Me.photo.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.Location = New System.Drawing.Point(780, 52)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(234, 234)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'id_barang
        '
        Me.id_barang.Font = New System.Drawing.Font("Poppins", 11.89565!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id_barang.Location = New System.Drawing.Point(844, 6)
        Me.id_barang.Name = "id_barang"
        Me.id_barang.Size = New System.Drawing.Size(72, 34)
        Me.id_barang.TabIndex = 21
        Me.id_barang.Text = "Photo" & Global.Microsoft.VisualBasic.ChrW(13)
        Me.id_barang.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.id_barang.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'DataGridView1
        '
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(85, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridView1.ColumnHeadersHeight = 50
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(21, 56)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 30
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1013, 295)
        Me.DataGridView1.TabIndex = 75
        Me.DataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DataGridView1.ThemeStyle.HeaderStyle.Height = 50
        Me.DataGridView1.ThemeStyle.ReadOnly = False
        Me.DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.[Single]
        Me.DataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.ThemeStyle.RowsStyle.Height = 30
        Me.DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White
        Me.DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'GunaElipsePanel1
        '
        Me.GunaElipsePanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.GunaElipsePanel1.Controls.Add(Me.Label10)
        Me.GunaElipsePanel1.Controls.Add(Me.Label9)
        Me.GunaElipsePanel1.Controls.Add(Me.btprint)
        Me.GunaElipsePanel1.Controls.Add(Me.btdelete)
        Me.GunaElipsePanel1.Controls.Add(Me.btupdate)
        Me.GunaElipsePanel1.Controls.Add(Me.btsave)
        Me.GunaElipsePanel1.Controls.Add(Me.btn_exit)
        Me.GunaElipsePanel1.Location = New System.Drawing.Point(19, 19)
        Me.GunaElipsePanel1.Name = "GunaElipsePanel1"
        Me.GunaElipsePanel1.Radius = 13
        Me.GunaElipsePanel1.Size = New System.Drawing.Size(200, 852)
        Me.GunaElipsePanel1.TabIndex = 76
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Poppins", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(0, 63)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(200, 1)
        Me.Label10.TabIndex = 82
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Poppins", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(9, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(166, 51)
        Me.Label9.TabIndex = 77
        Me.Label9.Text = "Inventory."
        '
        'btprint
        '
        Me.btprint.Animated = True
        Me.btprint.AnimationHoverSpeed = 0.07!
        Me.btprint.AnimationSpeed = 0.03!
        Me.btprint.BackColor = System.Drawing.Color.Transparent
        Me.btprint.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btprint.BorderColor = System.Drawing.Color.Black
        Me.btprint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btprint.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btprint.FocusedColor = System.Drawing.Color.Empty
        Me.btprint.Font = New System.Drawing.Font("Poppins", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btprint.ForeColor = System.Drawing.Color.White
        Me.btprint.Image = CType(resources.GetObject("btprint.Image"), System.Drawing.Image)
        Me.btprint.ImageSize = New System.Drawing.Size(22, 22)
        Me.btprint.Location = New System.Drawing.Point(18, 276)
        Me.btprint.Margin = New System.Windows.Forms.Padding(4)
        Me.btprint.Name = "btprint"
        Me.btprint.OnHoverBaseColor = System.Drawing.Color.White
        Me.btprint.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btprint.OnHoverForeColor = System.Drawing.Color.Black
        Me.btprint.OnHoverImage = CType(resources.GetObject("btprint.OnHoverImage"), System.Drawing.Image)
        Me.btprint.OnPressedColor = System.Drawing.Color.Black
        Me.btprint.Padding = New System.Windows.Forms.Padding(40, 40, 0, 0)
        Me.btprint.Radius = 6
        Me.btprint.Size = New System.Drawing.Size(159, 44)
        Me.btprint.TabIndex = 81
        Me.btprint.Text = "Print"
        Me.btprint.TextOffsetX = 8
        '
        'btdelete
        '
        Me.btdelete.Animated = True
        Me.btdelete.AnimationHoverSpeed = 0.07!
        Me.btdelete.AnimationSpeed = 0.03!
        Me.btdelete.BackColor = System.Drawing.Color.Transparent
        Me.btdelete.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btdelete.BorderColor = System.Drawing.Color.Black
        Me.btdelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btdelete.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btdelete.FocusedColor = System.Drawing.Color.Empty
        Me.btdelete.Font = New System.Drawing.Font("Poppins", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btdelete.ForeColor = System.Drawing.Color.White
        Me.btdelete.Image = CType(resources.GetObject("btdelete.Image"), System.Drawing.Image)
        Me.btdelete.ImageSize = New System.Drawing.Size(22, 22)
        Me.btdelete.Location = New System.Drawing.Point(18, 216)
        Me.btdelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btdelete.Name = "btdelete"
        Me.btdelete.OnHoverBaseColor = System.Drawing.Color.White
        Me.btdelete.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btdelete.OnHoverForeColor = System.Drawing.Color.Black
        Me.btdelete.OnHoverImage = CType(resources.GetObject("btdelete.OnHoverImage"), System.Drawing.Image)
        Me.btdelete.OnPressedColor = System.Drawing.Color.Black
        Me.btdelete.Padding = New System.Windows.Forms.Padding(40, 40, 0, 0)
        Me.btdelete.Radius = 6
        Me.btdelete.Size = New System.Drawing.Size(159, 44)
        Me.btdelete.TabIndex = 80
        Me.btdelete.Text = "Delete"
        Me.btdelete.TextOffsetX = 8
        '
        'btupdate
        '
        Me.btupdate.Animated = True
        Me.btupdate.AnimationHoverSpeed = 0.07!
        Me.btupdate.AnimationSpeed = 0.03!
        Me.btupdate.BackColor = System.Drawing.Color.Transparent
        Me.btupdate.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btupdate.BorderColor = System.Drawing.Color.Black
        Me.btupdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btupdate.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btupdate.FocusedColor = System.Drawing.Color.Empty
        Me.btupdate.Font = New System.Drawing.Font("Poppins", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btupdate.ForeColor = System.Drawing.Color.White
        Me.btupdate.Image = CType(resources.GetObject("btupdate.Image"), System.Drawing.Image)
        Me.btupdate.ImageSize = New System.Drawing.Size(25, 25)
        Me.btupdate.Location = New System.Drawing.Point(18, 156)
        Me.btupdate.Margin = New System.Windows.Forms.Padding(4)
        Me.btupdate.Name = "btupdate"
        Me.btupdate.OnHoverBaseColor = System.Drawing.Color.White
        Me.btupdate.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btupdate.OnHoverForeColor = System.Drawing.Color.Black
        Me.btupdate.OnHoverImage = CType(resources.GetObject("btupdate.OnHoverImage"), System.Drawing.Image)
        Me.btupdate.OnPressedColor = System.Drawing.Color.Black
        Me.btupdate.Padding = New System.Windows.Forms.Padding(40, 40, 0, 0)
        Me.btupdate.Radius = 6
        Me.btupdate.Size = New System.Drawing.Size(159, 44)
        Me.btupdate.TabIndex = 79
        Me.btupdate.Text = "Update"
        Me.btupdate.TextOffsetX = 6
        '
        'btsave
        '
        Me.btsave.Animated = True
        Me.btsave.AnimationHoverSpeed = 0.07!
        Me.btsave.AnimationSpeed = 0.03!
        Me.btsave.BackColor = System.Drawing.Color.Transparent
        Me.btsave.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btsave.BorderColor = System.Drawing.Color.Black
        Me.btsave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btsave.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btsave.FocusedColor = System.Drawing.Color.Empty
        Me.btsave.Font = New System.Drawing.Font("Poppins", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btsave.ForeColor = System.Drawing.Color.White
        Me.btsave.Image = CType(resources.GetObject("btsave.Image"), System.Drawing.Image)
        Me.btsave.ImageSize = New System.Drawing.Size(22, 22)
        Me.btsave.Location = New System.Drawing.Point(18, 96)
        Me.btsave.Margin = New System.Windows.Forms.Padding(4)
        Me.btsave.Name = "btsave"
        Me.btsave.OnHoverBaseColor = System.Drawing.Color.White
        Me.btsave.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btsave.OnHoverForeColor = System.Drawing.Color.Black
        Me.btsave.OnHoverImage = CType(resources.GetObject("btsave.OnHoverImage"), System.Drawing.Image)
        Me.btsave.OnPressedColor = System.Drawing.Color.Black
        Me.btsave.Padding = New System.Windows.Forms.Padding(40, 40, 0, 0)
        Me.btsave.Radius = 6
        Me.btsave.Size = New System.Drawing.Size(159, 44)
        Me.btsave.TabIndex = 78
        Me.btsave.Text = "Save"
        Me.btsave.TextOffsetX = 8
        '
        'btn_exit
        '
        Me.btn_exit.Animated = True
        Me.btn_exit.AnimationHoverSpeed = 0.07!
        Me.btn_exit.AnimationSpeed = 0.03!
        Me.btn_exit.BackColor = System.Drawing.Color.Transparent
        Me.btn_exit.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btn_exit.BorderColor = System.Drawing.Color.Black
        Me.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_exit.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_exit.FocusedColor = System.Drawing.Color.Empty
        Me.btn_exit.Font = New System.Drawing.Font("Poppins", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.ForeColor = System.Drawing.Color.White
        Me.btn_exit.Image = CType(resources.GetObject("btn_exit.Image"), System.Drawing.Image)
        Me.btn_exit.ImageSize = New System.Drawing.Size(22, 22)
        Me.btn_exit.Location = New System.Drawing.Point(16, 770)
        Me.btn_exit.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.OnHoverBaseColor = System.Drawing.Color.White
        Me.btn_exit.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_exit.OnHoverForeColor = System.Drawing.Color.Black
        Me.btn_exit.OnHoverImage = CType(resources.GetObject("btn_exit.OnHoverImage"), System.Drawing.Image)
        Me.btn_exit.OnPressedColor = System.Drawing.Color.Black
        Me.btn_exit.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.btn_exit.Radius = 6
        Me.btn_exit.Size = New System.Drawing.Size(159, 44)
        Me.btn_exit.TabIndex = 77
        Me.btn_exit.Text = "Logout"
        Me.btn_exit.TextOffsetX = 8
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 6
        Me.GunaElipse1.TargetControl = Me.PictureBox1
        '
        'searchbox
        '
        Me.searchbox.BackColor = System.Drawing.Color.Transparent
        Me.searchbox.BaseColor = System.Drawing.Color.White
        Me.searchbox.BorderColor = System.Drawing.Color.Silver
        Me.searchbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.searchbox.FocusedBaseColor = System.Drawing.Color.White
        Me.searchbox.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.searchbox.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.searchbox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.searchbox.ForeColor = System.Drawing.Color.Black
        Me.searchbox.Location = New System.Drawing.Point(14, 14)
        Me.searchbox.Name = "searchbox"
        Me.searchbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.searchbox.Radius = 8
        Me.searchbox.SelectedText = ""
        Me.searchbox.Size = New System.Drawing.Size(459, 38)
        Me.searchbox.TabIndex = 77
        Me.searchbox.Text = "Search"
        Me.searchbox.TextOffsetX = 8
        '
        'GunaElipsePanel2
        '
        Me.GunaElipsePanel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel2.BaseColor = System.Drawing.Color.White
        Me.GunaElipsePanel2.Controls.Add(Me.btsearch)
        Me.GunaElipsePanel2.Controls.Add(Me.lbusername)
        Me.GunaElipsePanel2.Controls.Add(Me.GunaCirclePictureBox1)
        Me.GunaElipsePanel2.Controls.Add(Me.searchbox)
        Me.GunaElipsePanel2.Location = New System.Drawing.Point(243, 19)
        Me.GunaElipsePanel2.Name = "GunaElipsePanel2"
        Me.GunaElipsePanel2.Radius = 13
        Me.GunaElipsePanel2.Size = New System.Drawing.Size(1053, 65)
        Me.GunaElipsePanel2.TabIndex = 78
        '
        'btsearch
        '
        Me.btsearch.AnimationHoverSpeed = 0.07!
        Me.btsearch.AnimationSpeed = 0.03!
        Me.btsearch.BackColor = System.Drawing.Color.Transparent
        Me.btsearch.BaseColor = System.Drawing.Color.White
        Me.btsearch.BorderColor = System.Drawing.Color.Black
        Me.btsearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btsearch.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btsearch.FocusedColor = System.Drawing.Color.Empty
        Me.btsearch.Font = New System.Drawing.Font("Poppins", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btsearch.ForeColor = System.Drawing.Color.White
        Me.btsearch.Image = CType(resources.GetObject("btsearch.Image"), System.Drawing.Image)
        Me.btsearch.ImageSize = New System.Drawing.Size(21, 21)
        Me.btsearch.Location = New System.Drawing.Point(474, 14)
        Me.btsearch.Margin = New System.Windows.Forms.Padding(4)
        Me.btsearch.Name = "btsearch"
        Me.btsearch.OnHoverBaseColor = System.Drawing.Color.White
        Me.btsearch.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btsearch.OnHoverForeColor = System.Drawing.Color.Black
        Me.btsearch.OnHoverImage = Nothing
        Me.btsearch.OnPressedColor = System.Drawing.Color.Transparent
        Me.btsearch.Padding = New System.Windows.Forms.Padding(40, 40, 0, 0)
        Me.btsearch.Size = New System.Drawing.Size(35, 38)
        Me.btsearch.TabIndex = 83
        '
        'lbusername
        '
        Me.lbusername.Font = New System.Drawing.Font("Poppins", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbusername.ForeColor = System.Drawing.Color.Black
        Me.lbusername.Location = New System.Drawing.Point(750, 20)
        Me.lbusername.Name = "lbusername"
        Me.lbusername.Size = New System.Drawing.Size(231, 27)
        Me.lbusername.TabIndex = 82
        Me.lbusername.Text = "Hi, Username"
        Me.lbusername.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GunaCirclePictureBox1
        '
        Me.GunaCirclePictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaCirclePictureBox1.Image = CType(resources.GetObject("GunaCirclePictureBox1.Image"), System.Drawing.Image)
        Me.GunaCirclePictureBox1.Location = New System.Drawing.Point(987, 14)
        Me.GunaCirclePictureBox1.Name = "GunaCirclePictureBox1"
        Me.GunaCirclePictureBox1.Size = New System.Drawing.Size(38, 38)
        Me.GunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox1.TabIndex = 78
        Me.GunaCirclePictureBox1.TabStop = False
        Me.GunaCirclePictureBox1.UseTransfarantBackground = False
        '
        'GunaElipsePanel3
        '
        Me.GunaElipsePanel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel3.BaseColor = System.Drawing.Color.White
        Me.GunaElipsePanel3.Controls.Add(Me.PictureBox1)
        Me.GunaElipsePanel3.Controls.Add(Me.Label1)
        Me.GunaElipsePanel3.Controls.Add(Me.Label2)
        Me.GunaElipsePanel3.Controls.Add(Me.id_barang)
        Me.GunaElipsePanel3.Controls.Add(Me.Label3)
        Me.GunaElipsePanel3.Controls.Add(Me.Label4)
        Me.GunaElipsePanel3.Controls.Add(Me.GunaButton1)
        Me.GunaElipsePanel3.Controls.Add(Me.Label5)
        Me.GunaElipsePanel3.Controls.Add(Me.Label6)
        Me.GunaElipsePanel3.Controls.Add(Me.Label7)
        Me.GunaElipsePanel3.Controls.Add(Me.inventory_item)
        Me.GunaElipsePanel3.Controls.Add(Me.note)
        Me.GunaElipsePanel3.Controls.Add(Me.serial_number)
        Me.GunaElipsePanel3.Controls.Add(Me.store)
        Me.GunaElipsePanel3.Controls.Add(Me.location)
        Me.GunaElipsePanel3.Controls.Add(Me.date_purchased)
        Me.GunaElipsePanel3.Controls.Add(Me.purchase_price)
        Me.GunaElipsePanel3.Controls.Add(Me.Label8)
        Me.GunaElipsePanel3.Location = New System.Drawing.Point(243, 108)
        Me.GunaElipsePanel3.Name = "GunaElipsePanel3"
        Me.GunaElipsePanel3.Radius = 13
        Me.GunaElipsePanel3.Size = New System.Drawing.Size(1053, 364)
        Me.GunaElipsePanel3.TabIndex = 79
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(3, 7)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(1047, 33)
        Me.Label8.TabIndex = 82
        Me.Label8.Text = "Insert Data"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GunaElipsePanel4
        '
        Me.GunaElipsePanel4.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel4.BaseColor = System.Drawing.Color.White
        Me.GunaElipsePanel4.Controls.Add(Me.Label11)
        Me.GunaElipsePanel4.Controls.Add(Me.DataGridView1)
        Me.GunaElipsePanel4.Controls.Add(Me.photo)
        Me.GunaElipsePanel4.Location = New System.Drawing.Point(243, 496)
        Me.GunaElipsePanel4.Name = "GunaElipsePanel4"
        Me.GunaElipsePanel4.Radius = 13
        Me.GunaElipsePanel4.Size = New System.Drawing.Size(1053, 375)
        Me.GunaElipsePanel4.TabIndex = 80
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(16, 12)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(193, 33)
        Me.Label11.TabIndex = 81
        Me.Label11.Text = "Inventory Table"
        '
        'GunaElipse2
        '
        Me.GunaElipse2.Radius = 13
        Me.GunaElipse2.TargetControl = Me
        '
        'frmInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1319, 892)
        Me.Controls.Add(Me.GunaElipsePanel4)
        Me.Controls.Add(Me.GunaElipsePanel3)
        Me.Controls.Add(Me.GunaElipsePanel2)
        Me.Controls.Add(Me.GunaElipsePanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmInventory"
        Me.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaElipsePanel1.ResumeLayout(False)
        Me.GunaElipsePanel2.ResumeLayout(False)
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaElipsePanel3.ResumeLayout(False)
        Me.GunaElipsePanel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents inventory_item As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents serial_number As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents location As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents purchase_price As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents date_purchased As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents store As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents note As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents photo As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents id_barang As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents DataGridView1 As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents GunaElipsePanel1 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents btn_exit As Guna.UI.WinForms.GunaButton
    Friend WithEvents btsave As Guna.UI.WinForms.GunaButton
    Friend WithEvents btupdate As Guna.UI.WinForms.GunaButton
    Friend WithEvents btprint As Guna.UI.WinForms.GunaButton
    Friend WithEvents btdelete As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GunaElipsePanel2 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents searchbox As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaElipsePanel3 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents GunaElipsePanel4 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GunaElipse2 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents lbusername As System.Windows.Forms.Label
    Friend WithEvents GunaCirclePictureBox1 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents btsearch As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label8 As System.Windows.Forms.Label

End Class
