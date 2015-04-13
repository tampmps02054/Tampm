<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.mni = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniThongtin = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnHoaDon = New System.Windows.Forms.Button()
        Me.btnKhachHang = New System.Windows.Forms.Button()
        Me.btnSanPham = New System.Windows.Forms.Button()
        Me.btnNhanVien = New System.Windows.Forms.Button()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.mnuMain.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuMain
        '
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mni, Me.mniThongtin})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(572, 24)
        Me.mnuMain.TabIndex = 0
        Me.mnuMain.Text = "Menu"
        '
        'mni
        '
        Me.mni.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniLogout, Me.mniExit})
        Me.mni.Name = "mni"
        Me.mni.Size = New System.Drawing.Size(71, 20)
        Me.mni.Text = "Tài khoản"
        '
        'mniLogout
        '
        Me.mniLogout.Image = CType(resources.GetObject("mniLogout.Image"), System.Drawing.Image)
        Me.mniLogout.Name = "mniLogout"
        Me.mniLogout.Size = New System.Drawing.Size(127, 22)
        Me.mniLogout.Text = "Đăng xuất"
        '
        'mniExit
        '
        Me.mniExit.Image = CType(resources.GetObject("mniExit.Image"), System.Drawing.Image)
        Me.mniExit.Name = "mniExit"
        Me.mniExit.Size = New System.Drawing.Size(127, 22)
        Me.mniExit.Text = "Thoát"
        '
        'mniThongtin
        '
        Me.mniThongtin.Name = "mniThongtin"
        Me.mniThongtin.Size = New System.Drawing.Size(71, 20)
        Me.mniThongtin.Text = "Thông tin"
        '
        'btnHoaDon
        '
        Me.btnHoaDon.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHoaDon.Image = CType(resources.GetObject("btnHoaDon.Image"), System.Drawing.Image)
        Me.btnHoaDon.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnHoaDon.Location = New System.Drawing.Point(16, 208)
        Me.btnHoaDon.Name = "btnHoaDon"
        Me.btnHoaDon.Size = New System.Drawing.Size(136, 162)
        Me.btnHoaDon.TabIndex = 1
        Me.btnHoaDon.Text = "Hóa Đơn"
        Me.btnHoaDon.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnHoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnHoaDon.UseVisualStyleBackColor = True
        '
        'btnKhachHang
        '
        Me.btnKhachHang.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKhachHang.Image = CType(resources.GetObject("btnKhachHang.Image"), System.Drawing.Image)
        Me.btnKhachHang.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnKhachHang.Location = New System.Drawing.Point(170, 28)
        Me.btnKhachHang.Name = "btnKhachHang"
        Me.btnKhachHang.Size = New System.Drawing.Size(136, 162)
        Me.btnKhachHang.TabIndex = 2
        Me.btnKhachHang.Text = "Khách Hàng"
        Me.btnKhachHang.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnKhachHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnKhachHang.UseVisualStyleBackColor = True
        '
        'btnSanPham
        '
        Me.btnSanPham.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSanPham.Image = CType(resources.GetObject("btnSanPham.Image"), System.Drawing.Image)
        Me.btnSanPham.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSanPham.Location = New System.Drawing.Point(170, 208)
        Me.btnSanPham.Name = "btnSanPham"
        Me.btnSanPham.Size = New System.Drawing.Size(136, 162)
        Me.btnSanPham.TabIndex = 3
        Me.btnSanPham.Text = "Sản Phẩm"
        Me.btnSanPham.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSanPham.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSanPham.UseVisualStyleBackColor = True
        '
        'btnNhanVien
        '
        Me.btnNhanVien.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNhanVien.Image = CType(resources.GetObject("btnNhanVien.Image"), System.Drawing.Image)
        Me.btnNhanVien.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNhanVien.Location = New System.Drawing.Point(16, 29)
        Me.btnNhanVien.Name = "btnNhanVien"
        Me.btnNhanVien.Size = New System.Drawing.Size(136, 162)
        Me.btnNhanVien.TabIndex = 4
        Me.btnNhanVien.Text = "Nhân Viên"
        Me.btnNhanVien.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnNhanVien.UseVisualStyleBackColor = True
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(327, 220)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 5
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(460, 28)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 13)
        Me.lblStatus.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(327, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(227, 191)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 391)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.btnNhanVien)
        Me.Controls.Add(Me.btnSanPham)
        Me.Controls.Add(Me.btnKhachHang)
        Me.Controls.Add(Me.btnHoaDon)
        Me.Controls.Add(Me.mnuMain)
        Me.MainMenuStrip = Me.mnuMain
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuMain As System.Windows.Forms.MenuStrip
    Friend WithEvents mni As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniLogout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnHoaDon As System.Windows.Forms.Button
    Friend WithEvents btnKhachHang As System.Windows.Forms.Button
    Friend WithEvents btnSanPham As System.Windows.Forms.Button
    Friend WithEvents mniThongtin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnNhanVien As System.Windows.Forms.Button
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
