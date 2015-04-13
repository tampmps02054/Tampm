<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvoice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInvoice))
        Me.grbHoadon = New System.Windows.Forms.GroupBox()
        Me.txtTongTien = New System.Windows.Forms.TextBox()
        Me.txtMaKhuyenMai = New System.Windows.Forms.TextBox()
        Me.txtMSNV = New System.Windows.Forms.TextBox()
        Me.txtMSHD = New System.Windows.Forms.TextBox()
        Me.lblMaKhuyenMai = New System.Windows.Forms.Label()
        Me.txtMSKH = New System.Windows.Forms.TextBox()
        Me.lblTongTien = New System.Windows.Forms.Label()
        Me.lblMSNV = New System.Windows.Forms.Label()
        Me.lblMSHD = New System.Windows.Forms.Label()
        Me.lblMSKH = New System.Windows.Forms.Label()
        Me.dgvHoaDon = New System.Windows.Forms.DataGridView()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btmSua = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.grbHoadon.SuspendLayout()
        CType(Me.dgvHoaDon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grbHoadon
        '
        Me.grbHoadon.Controls.Add(Me.txtTongTien)
        Me.grbHoadon.Controls.Add(Me.txtMaKhuyenMai)
        Me.grbHoadon.Controls.Add(Me.txtMSNV)
        Me.grbHoadon.Controls.Add(Me.txtMSHD)
        Me.grbHoadon.Controls.Add(Me.lblMaKhuyenMai)
        Me.grbHoadon.Controls.Add(Me.txtMSKH)
        Me.grbHoadon.Controls.Add(Me.lblTongTien)
        Me.grbHoadon.Controls.Add(Me.lblMSNV)
        Me.grbHoadon.Controls.Add(Me.lblMSHD)
        Me.grbHoadon.Controls.Add(Me.lblMSKH)
        Me.grbHoadon.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbHoadon.Location = New System.Drawing.Point(3, 5)
        Me.grbHoadon.Name = "grbHoadon"
        Me.grbHoadon.Size = New System.Drawing.Size(254, 191)
        Me.grbHoadon.TabIndex = 1
        Me.grbHoadon.TabStop = False
        Me.grbHoadon.Text = "Thông tin Hóa Đơn"
        '
        'txtTongTien
        '
        Me.txtTongTien.Location = New System.Drawing.Point(123, 126)
        Me.txtTongTien.Name = "txtTongTien"
        Me.txtTongTien.Size = New System.Drawing.Size(125, 23)
        Me.txtTongTien.TabIndex = 4
        '
        'txtMaKhuyenMai
        '
        Me.txtMaKhuyenMai.Location = New System.Drawing.Point(123, 159)
        Me.txtMaKhuyenMai.Name = "txtMaKhuyenMai"
        Me.txtMaKhuyenMai.Size = New System.Drawing.Size(125, 23)
        Me.txtMaKhuyenMai.TabIndex = 5
        '
        'txtMSNV
        '
        Me.txtMSNV.Location = New System.Drawing.Point(123, 62)
        Me.txtMSNV.Name = "txtMSNV"
        Me.txtMSNV.Size = New System.Drawing.Size(125, 23)
        Me.txtMSNV.TabIndex = 2
        '
        'txtMSHD
        '
        Me.txtMSHD.Location = New System.Drawing.Point(123, 25)
        Me.txtMSHD.Name = "txtMSHD"
        Me.txtMSHD.Size = New System.Drawing.Size(125, 23)
        Me.txtMSHD.TabIndex = 1
        '
        'lblMaKhuyenMai
        '
        Me.lblMaKhuyenMai.AutoSize = True
        Me.lblMaKhuyenMai.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaKhuyenMai.Location = New System.Drawing.Point(6, 159)
        Me.lblMaKhuyenMai.Name = "lblMaKhuyenMai"
        Me.lblMaKhuyenMai.Size = New System.Drawing.Size(109, 17)
        Me.lblMaKhuyenMai.TabIndex = 3
        Me.lblMaKhuyenMai.Text = "Mã Khuyến Mãi:"
        '
        'txtMSKH
        '
        Me.txtMSKH.Location = New System.Drawing.Point(123, 94)
        Me.txtMSKH.Name = "txtMSKH"
        Me.txtMSKH.Size = New System.Drawing.Size(125, 23)
        Me.txtMSKH.TabIndex = 3
        '
        'lblTongTien
        '
        Me.lblTongTien.AutoSize = True
        Me.lblTongTien.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTongTien.Location = New System.Drawing.Point(6, 129)
        Me.lblTongTien.Name = "lblTongTien"
        Me.lblTongTien.Size = New System.Drawing.Size(77, 17)
        Me.lblTongTien.TabIndex = 3
        Me.lblTongTien.Text = "Tổng Tiền:"
        '
        'lblMSNV
        '
        Me.lblMSNV.AutoSize = True
        Me.lblMSNV.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMSNV.Location = New System.Drawing.Point(6, 65)
        Me.lblMSNV.Name = "lblMSNV"
        Me.lblMSNV.Size = New System.Drawing.Size(101, 17)
        Me.lblMSNV.TabIndex = 2
        Me.lblMSNV.Text = "Mã Nhân Viên:"
        '
        'lblMSHD
        '
        Me.lblMSHD.AutoSize = True
        Me.lblMSHD.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMSHD.Location = New System.Drawing.Point(6, 31)
        Me.lblMSHD.Name = "lblMSHD"
        Me.lblMSHD.Size = New System.Drawing.Size(91, 17)
        Me.lblMSHD.TabIndex = 0
        Me.lblMSHD.Text = "Mã Hóa Đơn:"
        '
        'lblMSKH
        '
        Me.lblMSKH.AutoSize = True
        Me.lblMSKH.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMSKH.Location = New System.Drawing.Point(6, 100)
        Me.lblMSKH.Name = "lblMSKH"
        Me.lblMSKH.Size = New System.Drawing.Size(113, 17)
        Me.lblMSKH.TabIndex = 1
        Me.lblMSKH.Text = "Mã Khách Hàng:"
        '
        'dgvHoaDon
        '
        Me.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHoaDon.Location = New System.Drawing.Point(263, 12)
        Me.dgvHoaDon.Name = "dgvHoaDon"
        Me.dgvHoaDon.Size = New System.Drawing.Size(503, 238)
        Me.dgvHoaDon.TabIndex = 2
        '
        'btnXoa
        '
        Me.btnXoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoa.Image = CType(resources.GetObject("btnXoa.Image"), System.Drawing.Image)
        Me.btnXoa.Location = New System.Drawing.Point(158, 202)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(56, 48)
        Me.btnXoa.TabIndex = 8
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btmSua
        '
        Me.btmSua.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btmSua.Image = CType(resources.GetObject("btmSua.Image"), System.Drawing.Image)
        Me.btmSua.Location = New System.Drawing.Point(96, 202)
        Me.btmSua.Name = "btmSua"
        Me.btmSua.Size = New System.Drawing.Size(56, 48)
        Me.btmSua.TabIndex = 7
        Me.btmSua.Text = "Sữa"
        Me.btmSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btmSua.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThem.Image = CType(resources.GetObject("btnThem.Image"), System.Drawing.Image)
        Me.btnThem.Location = New System.Drawing.Point(34, 202)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(56, 48)
        Me.btnThem.TabIndex = 6
        Me.btnThem.Text = "Thêm"
        Me.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'frmInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 258)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btmSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.dgvHoaDon)
        Me.Controls.Add(Me.grbHoadon)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmInvoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hóa Đơn"
        Me.grbHoadon.ResumeLayout(False)
        Me.grbHoadon.PerformLayout()
        CType(Me.dgvHoaDon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grbHoadon As System.Windows.Forms.GroupBox
    Friend WithEvents lblMSNV As System.Windows.Forms.Label
    Friend WithEvents lblMSKH As System.Windows.Forms.Label
    Friend WithEvents lblMSHD As System.Windows.Forms.Label
    Friend WithEvents txtTongTien As System.Windows.Forms.TextBox
    Friend WithEvents txtMaKhuyenMai As System.Windows.Forms.TextBox
    Friend WithEvents txtMSNV As System.Windows.Forms.TextBox
    Friend WithEvents txtMSKH As System.Windows.Forms.TextBox
    Friend WithEvents txtMSHD As System.Windows.Forms.TextBox
    Friend WithEvents lblMaKhuyenMai As System.Windows.Forms.Label
    Friend WithEvents lblTongTien As System.Windows.Forms.Label
    Friend WithEvents dgvHoaDon As System.Windows.Forms.DataGridView
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btmSua As System.Windows.Forms.Button
    Friend WithEvents btnThem As System.Windows.Forms.Button
End Class
