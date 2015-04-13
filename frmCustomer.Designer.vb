<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomer))
        Me.dgvKhachHang = New System.Windows.Forms.DataGridView()
        Me.grbThongtinkhachhang = New System.Windows.Forms.GroupBox()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btmSua = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.txtThanhPho = New System.Windows.Forms.TextBox()
        Me.txtDiaCHi = New System.Windows.Forms.TextBox()
        Me.txtSDT = New System.Windows.Forms.TextBox()
        Me.txtTenCongTy = New System.Windows.Forms.TextBox()
        Me.txtTenKH = New System.Windows.Forms.TextBox()
        Me.txtMSKH = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTenKH = New System.Windows.Forms.Label()
        Me.lblMSKH = New System.Windows.Forms.Label()
        CType(Me.dgvKhachHang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbThongtinkhachhang.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvKhachHang
        '
        Me.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKhachHang.Location = New System.Drawing.Point(14, 201)
        Me.dgvKhachHang.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvKhachHang.Name = "dgvKhachHang"
        Me.dgvKhachHang.Size = New System.Drawing.Size(600, 135)
        Me.dgvKhachHang.TabIndex = 2
        '
        'grbThongtinkhachhang
        '
        Me.grbThongtinkhachhang.Controls.Add(Me.btnXoa)
        Me.grbThongtinkhachhang.Controls.Add(Me.btmSua)
        Me.grbThongtinkhachhang.Controls.Add(Me.btnThem)
        Me.grbThongtinkhachhang.Controls.Add(Me.txtThanhPho)
        Me.grbThongtinkhachhang.Controls.Add(Me.txtDiaCHi)
        Me.grbThongtinkhachhang.Controls.Add(Me.txtSDT)
        Me.grbThongtinkhachhang.Controls.Add(Me.txtTenCongTy)
        Me.grbThongtinkhachhang.Controls.Add(Me.txtTenKH)
        Me.grbThongtinkhachhang.Controls.Add(Me.txtMSKH)
        Me.grbThongtinkhachhang.Controls.Add(Me.Label4)
        Me.grbThongtinkhachhang.Controls.Add(Me.Label3)
        Me.grbThongtinkhachhang.Controls.Add(Me.Label2)
        Me.grbThongtinkhachhang.Controls.Add(Me.Label1)
        Me.grbThongtinkhachhang.Controls.Add(Me.lblTenKH)
        Me.grbThongtinkhachhang.Controls.Add(Me.lblMSKH)
        Me.grbThongtinkhachhang.Location = New System.Drawing.Point(14, 9)
        Me.grbThongtinkhachhang.Name = "grbThongtinkhachhang"
        Me.grbThongtinkhachhang.Size = New System.Drawing.Size(602, 185)
        Me.grbThongtinkhachhang.TabIndex = 3
        Me.grbThongtinkhachhang.TabStop = False
        Me.grbThongtinkhachhang.Text = "Thông tin khách hàng"
        '
        'btnXoa
        '
        Me.btnXoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoa.Image = CType(resources.GetObject("btnXoa.Image"), System.Drawing.Image)
        Me.btnXoa.Location = New System.Drawing.Point(526, 131)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(56, 48)
        Me.btnXoa.TabIndex = 17
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btmSua
        '
        Me.btmSua.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btmSua.Image = CType(resources.GetObject("btmSua.Image"), System.Drawing.Image)
        Me.btmSua.Location = New System.Drawing.Point(453, 131)
        Me.btmSua.Name = "btmSua"
        Me.btmSua.Size = New System.Drawing.Size(56, 48)
        Me.btmSua.TabIndex = 16
        Me.btmSua.Text = "Sữa"
        Me.btmSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btmSua.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThem.Image = CType(resources.GetObject("btnThem.Image"), System.Drawing.Image)
        Me.btnThem.Location = New System.Drawing.Point(376, 131)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(56, 48)
        Me.btnThem.TabIndex = 15
        Me.btnThem.Text = "Thêm"
        Me.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'txtThanhPho
        '
        Me.txtThanhPho.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtThanhPho.Location = New System.Drawing.Point(434, 97)
        Me.txtThanhPho.Name = "txtThanhPho"
        Me.txtThanhPho.Size = New System.Drawing.Size(147, 23)
        Me.txtThanhPho.TabIndex = 11
        '
        'txtDiaCHi
        '
        Me.txtDiaCHi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiaCHi.Location = New System.Drawing.Point(434, 62)
        Me.txtDiaCHi.Name = "txtDiaCHi"
        Me.txtDiaCHi.Size = New System.Drawing.Size(147, 23)
        Me.txtDiaCHi.TabIndex = 10
        '
        'txtSDT
        '
        Me.txtSDT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSDT.Location = New System.Drawing.Point(434, 25)
        Me.txtSDT.Name = "txtSDT"
        Me.txtSDT.Size = New System.Drawing.Size(147, 23)
        Me.txtSDT.TabIndex = 9
        '
        'txtTenCongTy
        '
        Me.txtTenCongTy.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTenCongTy.Location = New System.Drawing.Point(136, 97)
        Me.txtTenCongTy.Name = "txtTenCongTy"
        Me.txtTenCongTy.Size = New System.Drawing.Size(147, 23)
        Me.txtTenCongTy.TabIndex = 8
        '
        'txtTenKH
        '
        Me.txtTenKH.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTenKH.Location = New System.Drawing.Point(136, 62)
        Me.txtTenKH.Name = "txtTenKH"
        Me.txtTenKH.Size = New System.Drawing.Size(147, 23)
        Me.txtTenKH.TabIndex = 7
        '
        'txtMSKH
        '
        Me.txtMSKH.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMSKH.Location = New System.Drawing.Point(136, 28)
        Me.txtMSKH.Name = "txtMSKH"
        Me.txtMSKH.Size = New System.Drawing.Size(147, 23)
        Me.txtMSKH.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(347, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Thành phố:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(373, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Địa chỉ:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(333, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Số điện thoại:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Tên công ty:"
        '
        'lblTenKH
        '
        Me.lblTenKH.AutoSize = True
        Me.lblTenKH.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTenKH.Location = New System.Drawing.Point(20, 62)
        Me.lblTenKH.Name = "lblTenKH"
        Me.lblTenKH.Size = New System.Drawing.Size(115, 17)
        Me.lblTenKH.TabIndex = 1
        Me.lblTenKH.Text = "Tên khách hàng:"
        '
        'lblMSKH
        '
        Me.lblMSKH.AutoSize = True
        Me.lblMSKH.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMSKH.Location = New System.Drawing.Point(20, 28)
        Me.lblMSKH.Name = "lblMSKH"
        Me.lblMSKH.Size = New System.Drawing.Size(109, 17)
        Me.lblMSKH.TabIndex = 0
        Me.lblMSKH.Text = "Mã khách hàng:"
        '
        'frmCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 349)
        Me.Controls.Add(Me.grbThongtinkhachhang)
        Me.Controls.Add(Me.dgvKhachHang)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer"
        CType(Me.dgvKhachHang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbThongtinkhachhang.ResumeLayout(False)
        Me.grbThongtinkhachhang.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvKhachHang As System.Windows.Forms.DataGridView
    Friend WithEvents grbThongtinkhachhang As System.Windows.Forms.GroupBox
    Friend WithEvents lblTenKH As System.Windows.Forms.Label
    Friend WithEvents lblMSKH As System.Windows.Forms.Label
    Friend WithEvents txtThanhPho As System.Windows.Forms.TextBox
    Friend WithEvents txtDiaCHi As System.Windows.Forms.TextBox
    Friend WithEvents txtSDT As System.Windows.Forms.TextBox
    Friend WithEvents txtTenCongTy As System.Windows.Forms.TextBox
    Friend WithEvents txtTenKH As System.Windows.Forms.TextBox
    Friend WithEvents txtMSKH As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btmSua As System.Windows.Forms.Button
    Friend WithEvents btnThem As System.Windows.Forms.Button
End Class
