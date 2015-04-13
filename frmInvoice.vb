Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmInvoice
    'Khai báo các biến quan trọng
    Dim connection_db As String = "workstation id=PS02054.mssql.somee.com;packet size=4096;user id=tampm;pwd=T@M789852;data source=PS02054.mssql.somee.com;persist security info=False;initial catalog=PS02054"
    Dim data As New DataTable
    Private Sub frmInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connect As SqlConnection = New SqlConnection(connection_db)
        Dim Truyvan1 As SqlDataAdapter = New SqlDataAdapter("select * from Hoa_Don", connect)

        connect.Open()
        Truyvan1.Fill(Data)
        dgvHoaDon.DataSource = data.DefaultView
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim connect As SqlConnection = New SqlConnection(connection_db)
        connect.Open()
        Dim Query2 As String = "insert into Hoa_Don values (@MSHD,@Nhan_Vien_MSNV,@Khach_Hang_MSKH,@TongTien,@MaKhuyenMai)"
        Dim ExecuteTruyvan1 As New SqlCommand(Query2, connect)

            ExecuteTruyvan1.Parameters.AddWithValue("@MSHD", txtMSHD.Text)
            ExecuteTruyvan1.Parameters.AddWithValue("@Nhan_Vien_MSNV", txtMSNV.Text)
            ExecuteTruyvan1.Parameters.AddWithValue("@Khach_Hang_MSKH", txtMSKH.Text)
            ExecuteTruyvan1.Parameters.AddWithValue("@TongTien", txtTongTien.Text)
            ExecuteTruyvan1.Parameters.AddWithValue("@MaKhuyenMai", txtMaKhuyenMai.Text)
            ExecuteTruyvan1.ExecuteNonQuery()

            MessageBox.Show("Thêm thành công.")

            'Làm mới bảng
            Dim Query3 As SqlDataAdapter = New SqlDataAdapter("select * from Hoa_Don", connect)
            data.Clear()
            Query3.Fill(data)
            dgvHoaDon.DataSource = data.DefaultView
    End Sub

    Private Sub btmSua_Click(sender As Object, e As EventArgs) Handles btmSua.Click
        Dim connect As SqlConnection = New SqlConnection(connection_db)
        Dim Query4 As String = "Update Hoa_Don Set  TongTien=@TongTien, MaKhuyenMai=@MaKhuyenMai where MSHD=@MSHD"

        Dim ExecuteQuery2 As New SqlCommand(Query4, connect)

        connect.Open()
        ExecuteQuery2.Parameters.AddWithValue("@MSHD", txtMSHD.Text)
        ExecuteQuery2.Parameters.AddWithValue("@TongTien", txtTongTien.Text)
        ExecuteQuery2.Parameters.AddWithValue("@MaKhuyenMai", txtMaKhuyenMai.Text)


        'Chạy các câu truy vấn
        ExecuteQuery2.ExecuteNonQuery()
        MessageBox.Show("Sửa thành công")


        'Làm mới
        Dim refresh As SqlDataAdapter = New SqlDataAdapter("select * from Hoa_Don", connect)
        data.Clear()

        refresh.Fill(data)
        dgvHoaDon.DataSource = data.DefaultView
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim connect As SqlConnection = New SqlConnection(connection_db)
        Dim Query As String = " delete from Hoa_Don Where MSHD=@MSHD"
        Dim Executequery3 As New SqlCommand(Query, connect)

        connect.Open()
        Executequery3.Parameters.AddWithValue("@MSHD", txtMSHD.Text)
        Executequery3.ExecuteNonQuery()
        MessageBox.Show("Xóa thành công")
        'Làm mới
        Dim refresh As SqlDataAdapter = New SqlDataAdapter("select * from Hoa_Don", connect)
        data.Clear()

        refresh.Fill(data)
        dgvHoaDon.DataSource = data.DefaultView
    End Sub

    Private Sub mniThongtin_Click(sender As Object, e As EventArgs)
        frmInfo.Show()
    End Sub

    Private Sub mniLogout_Click(sender As Object, e As EventArgs)
        frmLogin.ShowDialog()
        Me.Hide()
    End Sub

    Private Sub mniExit_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub dgvHoaDon_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHoaDon.CellContentClick
        Dim index As Integer = dgvHoaDon.CurrentCell.RowIndex
        txtMSHD.Text = dgvHoaDon.Item(0, index).Value
        txtMSNV.Text = dgvHoaDon.Item(1, index).Value
        txtMSKH.Text = dgvHoaDon.Item(2, index).Value
        txtTongTien.Text = dgvHoaDon.Item(3, index).Value
        txtMaKhuyenMai.Text = dgvHoaDon.Item(4, index).Value
    End Sub
End Class