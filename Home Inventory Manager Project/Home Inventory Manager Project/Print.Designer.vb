<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Print
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Print))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lb_note = New System.Windows.Forms.Label()
        Me.lb_store = New System.Windows.Forms.Label()
        Me.lb_date = New System.Windows.Forms.Label()
        Me.lb_price = New System.Windows.Forms.Label()
        Me.lb_serial = New System.Windows.Forms.Label()
        Me.lb_location = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lb_nama = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GunaControlBox1 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaTransfarantPictureBox1 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.GunaTransfarantPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(191, 379)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(300, 234)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lb_note)
        Me.Panel1.Controls.Add(Me.lb_store)
        Me.Panel1.Controls.Add(Me.lb_date)
        Me.Panel1.Controls.Add(Me.lb_price)
        Me.Panel1.Controls.Add(Me.lb_serial)
        Me.Panel1.Controls.Add(Me.lb_location)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lb_nama)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(63, 84)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(676, 671)
        Me.Panel1.TabIndex = 3
        '
        'lb_note
        '
        Me.lb_note.AutoSize = True
        Me.lb_note.Font = New System.Drawing.Font("Poppins", 11.89565!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_note.Location = New System.Drawing.Point(262, 277)
        Me.lb_note.Name = "lb_note"
        Me.lb_note.Size = New System.Drawing.Size(59, 34)
        Me.lb_note.TabIndex = 89
        Me.lb_note.Text = "Note"
        Me.lb_note.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lb_store
        '
        Me.lb_store.AutoSize = True
        Me.lb_store.Font = New System.Drawing.Font("Poppins", 11.89565!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_store.Location = New System.Drawing.Point(262, 238)
        Me.lb_store.Name = "lb_store"
        Me.lb_store.Size = New System.Drawing.Size(151, 34)
        Me.lb_store.TabIndex = 88
        Me.lb_store.Text = "Store/Website"
        Me.lb_store.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lb_date
        '
        Me.lb_date.AutoSize = True
        Me.lb_date.Font = New System.Drawing.Font("Poppins", 11.89565!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_date.Location = New System.Drawing.Point(262, 199)
        Me.lb_date.Name = "lb_date"
        Me.lb_date.Size = New System.Drawing.Size(167, 34)
        Me.lb_date.TabIndex = 87
        Me.lb_date.Text = "Date Purchased"
        Me.lb_date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lb_price
        '
        Me.lb_price.AutoSize = True
        Me.lb_price.Font = New System.Drawing.Font("Poppins", 11.89565!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_price.Location = New System.Drawing.Point(262, 155)
        Me.lb_price.Name = "lb_price"
        Me.lb_price.Size = New System.Drawing.Size(156, 34)
        Me.lb_price.TabIndex = 86
        Me.lb_price.Text = "Purchase Price"
        Me.lb_price.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lb_serial
        '
        Me.lb_serial.AutoSize = True
        Me.lb_serial.Font = New System.Drawing.Font("Poppins", 11.89565!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_serial.Location = New System.Drawing.Point(262, 116)
        Me.lb_serial.Name = "lb_serial"
        Me.lb_serial.Size = New System.Drawing.Size(150, 34)
        Me.lb_serial.TabIndex = 85
        Me.lb_serial.Text = "Serial Number"
        Me.lb_serial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lb_location
        '
        Me.lb_location.AutoSize = True
        Me.lb_location.Font = New System.Drawing.Font("Poppins", 11.89565!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_location.Location = New System.Drawing.Point(262, 77)
        Me.lb_location.Name = "lb_location"
        Me.lb_location.Size = New System.Drawing.Size(96, 34)
        Me.lb_location.TabIndex = 84
        Me.lb_location.Text = "Location"
        Me.lb_location.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Black
        Me.Label14.Font = New System.Drawing.Font("Poppins", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(22, 62)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(635, 1)
        Me.Label14.TabIndex = 83
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Poppins", 11.89565!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(237, 77)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(19, 34)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = ":"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Poppins", 11.89565!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(237, 116)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(19, 34)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = ":"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Poppins", 11.89565!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(237, 277)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(19, 34)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = ":"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Poppins", 11.89565!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(237, 238)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(19, 34)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = ":"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Poppins", 11.89565!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(237, 155)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(19, 34)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = ":"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Poppins", 11.89565!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(35, 277)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 34)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Note"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Poppins", 11.89565!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(35, 238)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(151, 34)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Store/Website"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Poppins", 11.89565!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(35, 199)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(167, 34)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Date Purchased"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins", 11.89565!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(35, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 34)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Purchase Price"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins", 11.89565!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(237, 199)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 34)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = ":"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins", 11.89565!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 34)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Serial Number"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 11.89565!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 34)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Location"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lb_nama
        '
        Me.lb_nama.Font = New System.Drawing.Font("Poppins", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_nama.Location = New System.Drawing.Point(23, 17)
        Me.lb_nama.Name = "lb_nama"
        Me.lb_nama.Size = New System.Drawing.Size(634, 34)
        Me.lb_nama.TabIndex = 22
        Me.lb_nama.Text = "Photo" & Global.Microsoft.VisualBasic.ChrW(13)
        Me.lb_nama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Panel2.Controls.Add(Me.GunaControlBox1)
        Me.Panel2.Controls.Add(Me.GunaTransfarantPictureBox1)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(802, 78)
        Me.Panel2.TabIndex = 4
        '
        'GunaControlBox1
        '
        Me.GunaControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox1.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox1.AnimationSpeed = 0.03!
        Me.GunaControlBox1.IconColor = System.Drawing.Color.White
        Me.GunaControlBox1.IconSize = 15.0!
        Me.GunaControlBox1.Location = New System.Drawing.Point(763, 1)
        Me.GunaControlBox1.Name = "GunaControlBox1"
        Me.GunaControlBox1.OnHoverBackColor = System.Drawing.Color.Transparent
        Me.GunaControlBox1.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox1.OnPressedColor = System.Drawing.Color.Transparent
        Me.GunaControlBox1.Size = New System.Drawing.Size(45, 29)
        Me.GunaControlBox1.TabIndex = 80
        '
        'GunaTransfarantPictureBox1
        '
        Me.GunaTransfarantPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransfarantPictureBox1.BaseColor = System.Drawing.Color.Black
        Me.GunaTransfarantPictureBox1.Image = CType(resources.GetObject("GunaTransfarantPictureBox1.Image"), System.Drawing.Image)
        Me.GunaTransfarantPictureBox1.Location = New System.Drawing.Point(31, 16)
        Me.GunaTransfarantPictureBox1.Name = "GunaTransfarantPictureBox1"
        Me.GunaTransfarantPictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.GunaTransfarantPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaTransfarantPictureBox1.TabIndex = 79
        Me.GunaTransfarantPictureBox1.TabStop = False
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Poppins", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(3, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(796, 51)
        Me.Label9.TabIndex = 78
        Me.Label9.Text = "Home Inventory Item"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Print
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(802, 790)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Print"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.GunaTransfarantPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lb_nama As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lb_note As System.Windows.Forms.Label
    Friend WithEvents lb_store As System.Windows.Forms.Label
    Friend WithEvents lb_date As System.Windows.Forms.Label
    Friend WithEvents lb_price As System.Windows.Forms.Label
    Friend WithEvents lb_serial As System.Windows.Forms.Label
    Friend WithEvents lb_location As System.Windows.Forms.Label
    Friend WithEvents GunaTransfarantPictureBox1 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents GunaControlBox1 As Guna.UI.WinForms.GunaControlBox
End Class
