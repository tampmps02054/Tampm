<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInfo))
        Me.lblNP = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblGvhd = New System.Windows.Forms.Label()
        Me.lblSvtk = New System.Windows.Forms.Label()
        Me.lblNamesoft = New System.Windows.Forms.Label()
        Me.lblLicense = New System.Windows.Forms.Label()
        Me.lblVer = New System.Windows.Forms.Label()
        Me.ptbLogo = New System.Windows.Forms.PictureBox()
        CType(Me.ptbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNP
        '
        Me.lblNP.AutoSize = True
        Me.lblNP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNP.Location = New System.Drawing.Point(95, 372)
        Me.lblNP.Name = "lblNP"
        Me.lblNP.Size = New System.Drawing.Size(178, 17)
        Me.lblNP.TabIndex = 17
        Me.lblNP.Text = "NumPhone: 0907.19.14.07"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(95, 344)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(224, 17)
        Me.lblEmail.TabIndex = 16
        Me.lblEmail.Text = "Email: tampmps02054@fpt.edu.vn"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(156, 398)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 15
        Me.btnClose.Text = "Đóng"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblGvhd
        '
        Me.lblGvhd.AutoSize = True
        Me.lblGvhd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGvhd.Location = New System.Drawing.Point(95, 290)
        Me.lblGvhd.Name = "lblGvhd"
        Me.lblGvhd.Size = New System.Drawing.Size(160, 17)
        Me.lblGvhd.TabIndex = 14
        Me.lblGvhd.Text = "GVHD: Trần Duy Phong"
        '
        'lblSvtk
        '
        Me.lblSvtk.AutoSize = True
        Me.lblSvtk.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSvtk.Location = New System.Drawing.Point(95, 318)
        Me.lblSvtk.Name = "lblSvtk"
        Me.lblSvtk.Size = New System.Drawing.Size(136, 17)
        Me.lblSvtk.TabIndex = 13
        Me.lblSvtk.Text = "SV: Phạm Minh Tâm"
        '
        'lblNamesoft
        '
        Me.lblNamesoft.AutoSize = True
        Me.lblNamesoft.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamesoft.Location = New System.Drawing.Point(95, 203)
        Me.lblNamesoft.Name = "lblNamesoft"
        Me.lblNamesoft.Size = New System.Drawing.Size(222, 17)
        Me.lblNamesoft.TabIndex = 12
        Me.lblNamesoft.Text = "PHẦN MỀM QUẢN LÝ BÁN HÀNG"
        '
        'lblLicense
        '
        Me.lblLicense.AutoSize = True
        Me.lblLicense.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLicense.Location = New System.Drawing.Point(95, 263)
        Me.lblLicense.Name = "lblLicense"
        Me.lblLicense.Size = New System.Drawing.Size(220, 17)
        Me.lblLicense.TabIndex = 11
        Me.lblLicense.Text = "Phần mềm thuộc Tampmps02054"
        '
        'lblVer
        '
        Me.lblVer.AutoSize = True
        Me.lblVer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVer.Location = New System.Drawing.Point(95, 235)
        Me.lblVer.Name = "lblVer"
        Me.lblVer.Size = New System.Drawing.Size(113, 17)
        Me.lblVer.TabIndex = 10
        Me.lblVer.Text = "Phiên bản: V.1.0"
        '
        'ptbLogo
        '
        Me.ptbLogo.Image = CType(resources.GetObject("ptbLogo.Image"), System.Drawing.Image)
        Me.ptbLogo.Location = New System.Drawing.Point(3, 12)
        Me.ptbLogo.Name = "ptbLogo"
        Me.ptbLogo.Size = New System.Drawing.Size(383, 188)
        Me.ptbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptbLogo.TabIndex = 9
        Me.ptbLogo.TabStop = False
        '
        'frmInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 424)
        Me.Controls.Add(Me.lblNP)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblGvhd)
        Me.Controls.Add(Me.lblSvtk)
        Me.Controls.Add(Me.lblNamesoft)
        Me.Controls.Add(Me.lblLicense)
        Me.Controls.Add(Me.lblVer)
        Me.Controls.Add(Me.ptbLogo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thông tin"
        CType(Me.ptbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNP As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblGvhd As System.Windows.Forms.Label
    Friend WithEvents lblSvtk As System.Windows.Forms.Label
    Friend WithEvents lblNamesoft As System.Windows.Forms.Label
    Friend WithEvents lblLicense As System.Windows.Forms.Label
    Friend WithEvents lblVer As System.Windows.Forms.Label
    Friend WithEvents ptbLogo As System.Windows.Forms.PictureBox
End Class
