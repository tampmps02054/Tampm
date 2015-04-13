<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProduct
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProduct))
        Me.dgvSanpham = New System.Windows.Forms.DataGridView()
        Me.grbThoitinsanpham = New System.Windows.Forms.GroupBox()
        Me.cbxNSP = New System.Windows.Forms.ComboBox()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btmSua = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.txtTonkho = New System.Windows.Forms.TextBox()
        Me.txtGia = New System.Windows.Forms.TextBox()
        Me.txtTenSP = New System.Windows.Forms.TextBox()
        Me.txtMSSP = New System.Windows.Forms.TextBox()
        Me.lblTonkho = New System.Windows.Forms.Label()
        Me.lblGia = New System.Windows.Forms.Label()
        Me.lblTenSP = New System.Windows.Forms.Label()
        Me.lblNSP = New System.Windows.Forms.Label()
        Me.lblMSSP = New System.Windows.Forms.Label()
        CType(Me.dgvSanpham, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbThoitinsanpham.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvSanpham
        '
        Me.dgvSanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSanpham.Location = New System.Drawing.Point(12, 179)
        Me.dgvSanpham.Name = "dgvSanpham"
        Me.dgvSanpham.Size = New System.Drawing.Size(586, 168)
        Me.dgvSanpham.TabIndex = 3
        '
        'grbThoitinsanpham
        '
        Me.grbThoitinsanpham.Controls.Add(Me.cbxNSP)
        Me.grbThoitinsanpham.Controls.Add(Me.btnXoa)
        Me.grbThoitinsanpham.Controls.Add(Me.btmSua)
        Me.grbThoitinsanpham.Controls.Add(Me.btnThem)
        Me.grbThoitinsanpham.Controls.Add(Me.txtTonkho)
        Me.grbThoitinsanpham.Controls.Add(Me.txtGia)
        Me.grbThoitinsanpham.Controls.Add(Me.txtTenSP)
        Me.grbThoitinsanpham.Controls.Add(Me.txtMSSP)
        Me.grbThoitinsanpham.Controls.Add(Me.lblTonkho)
        Me.grbThoitinsanpham.Controls.Add(Me.lblGia)
        Me.grbThoitinsanpham.Controls.Add(Me.lblTenSP)
        Me.grbThoitinsanpham.Controls.Add(Me.lblNSP)
        Me.grbThoitinsanpham.Controls.Add(Me.lblMSSP)
        Me.grbThoitinsanpham.Location = New System.Drawing.Point(12, 12)
        Me.grbThoitinsanpham.Name = "grbThoitinsanpham"
        Me.grbThoitinsanpham.Size = New System.Drawing.Size(586, 152)
        Me.grbThoitinsanpham.TabIndex = 4
        Me.grbThoitinsanpham.TabStop = False
        Me.grbThoitinsanpham.Text = "Thông tin Sản Phẩm"
        '
        'cbxNSP
        '
        Me.cbxNSP.FormattingEnabled = True
        Me.cbxNSP.Items.AddRange(New Object() {"NSP01", "NSP02", "NSP03"})
        Me.cbxNSP.Location = New System.Drawing.Point(171, 64)
        Me.cbxNSP.Name = "cbxNSP"
        Me.cbxNSP.Size = New System.Drawing.Size(135, 21)
        Me.cbxNSP.TabIndex = 15
        '
        'btnXoa
        '
        Me.btnXoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoa.Image = CType(resources.GetObject("btnXoa.Image"), System.Drawing.Image)
        Me.btnXoa.Location = New System.Drawing.Point(527, 98)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(56, 48)
        Me.btnXoa.TabIndex = 14
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btmSua
        '
        Me.btmSua.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btmSua.Image = CType(resources.GetObject("btmSua.Image"), System.Drawing.Image)
        Me.btmSua.Location = New System.Drawing.Point(454, 98)
        Me.btmSua.Name = "btmSua"
        Me.btmSua.Size = New System.Drawing.Size(56, 48)
        Me.btmSua.TabIndex = 13
        Me.btmSua.Text = "Sữa"
        Me.btmSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btmSua.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThem.Image = CType(resources.GetObject("btnThem.Image"), System.Drawing.Image)
        Me.btnThem.Location = New System.Drawing.Point(377, 98)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(56, 48)
        Me.btnThem.TabIndex = 12
        Me.btnThem.Text = "Thêm"
        Me.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'txtTonkho
        '
        Me.txtTonkho.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTonkho.Location = New System.Drawing.Point(428, 62)
        Me.txtTonkho.Name = "txtTonkho"
        Me.txtTonkho.Size = New System.Drawing.Size(151, 23)
        Me.txtTonkho.TabIndex = 11
        '
        'txtGia
        '
        Me.txtGia.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGia.Location = New System.Drawing.Point(428, 29)
        Me.txtGia.Name = "txtGia"
        Me.txtGia.Size = New System.Drawing.Size(151, 23)
        Me.txtGia.TabIndex = 10
        '
        'txtTenSP
        '
        Me.txtTenSP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTenSP.Location = New System.Drawing.Point(171, 98)
        Me.txtTenSP.Name = "txtTenSP"
        Me.txtTenSP.Size = New System.Drawing.Size(151, 23)
        Me.txtTenSP.TabIndex = 9
        '
        'txtMSSP
        '
        Me.txtMSSP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMSSP.Location = New System.Drawing.Point(171, 29)
        Me.txtMSSP.Name = "txtMSSP"
        Me.txtMSSP.Size = New System.Drawing.Size(90, 23)
        Me.txtMSSP.TabIndex = 6
        '
        'lblTonkho
        '
        Me.lblTonkho.AutoSize = True
        Me.lblTonkho.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTonkho.Location = New System.Drawing.Point(349, 65)
        Me.lblTonkho.Name = "lblTonkho"
        Me.lblTonkho.Size = New System.Drawing.Size(73, 17)
        Me.lblTonkho.TabIndex = 5
        Me.lblTonkho.Text = "Số Lượng:"
        '
        'lblGia
        '
        Me.lblGia.AutoSize = True
        Me.lblGia.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGia.Location = New System.Drawing.Point(359, 32)
        Me.lblGia.Name = "lblGia"
        Me.lblGia.Size = New System.Drawing.Size(63, 17)
        Me.lblGia.TabIndex = 4
        Me.lblGia.Text = "Giá Bán:"
        '
        'lblTenSP
        '
        Me.lblTenSP.AutoSize = True
        Me.lblTenSP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTenSP.Location = New System.Drawing.Point(24, 101)
        Me.lblTenSP.Name = "lblTenSP"
        Me.lblTenSP.Size = New System.Drawing.Size(106, 17)
        Me.lblTenSP.TabIndex = 2
        Me.lblTenSP.Text = "Tên Sản Phẩm:"
        '
        'lblNSP
        '
        Me.lblNSP.AutoSize = True
        Me.lblNSP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNSP.Location = New System.Drawing.Point(24, 65)
        Me.lblNSP.Name = "lblNSP"
        Me.lblNSP.Size = New System.Drawing.Size(141, 17)
        Me.lblNSP.TabIndex = 1
        Me.lblNSP.Text = "Mã Nhóm Sản Phẩm:"
        '
        'lblMSSP
        '
        Me.lblMSSP.AutoSize = True
        Me.lblMSSP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMSSP.Location = New System.Drawing.Point(24, 32)
        Me.lblMSSP.Name = "lblMSSP"
        Me.lblMSSP.Size = New System.Drawing.Size(99, 17)
        Me.lblMSSP.TabIndex = 0
        Me.lblMSSP.Text = "Mã Sản phẩm:"
        '
        'frmProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 363)
        Me.Controls.Add(Me.grbThoitinsanpham)
        Me.Controls.Add(Me.dgvSanpham)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sản Phẩm"
        CType(Me.dgvSanpham, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbThoitinsanpham.ResumeLayout(False)
        Me.grbThoitinsanpham.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvSanpham As System.Windows.Forms.DataGridView
    Friend WithEvents grbThoitinsanpham As System.Windows.Forms.GroupBox
    Friend WithEvents txtTonkho As System.Windows.Forms.TextBox
    Friend WithEvents txtGia As System.Windows.Forms.TextBox
    Friend WithEvents txtTenSP As System.Windows.Forms.TextBox
    Friend WithEvents txtMSSP As System.Windows.Forms.TextBox
    Friend WithEvents lblTonkho As System.Windows.Forms.Label
    Friend WithEvents lblGia As System.Windows.Forms.Label
    Friend WithEvents lblTenSP As System.Windows.Forms.Label
    Friend WithEvents lblNSP As System.Windows.Forms.Label
    Friend WithEvents lblMSSP As System.Windows.Forms.Label
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btmSua As System.Windows.Forms.Button
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents cbxNSP As System.Windows.Forms.ComboBox
End Class
