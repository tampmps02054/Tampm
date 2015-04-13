Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmProduct
    'Khai báo các biến quan trọng
    Dim connection_db As String = "workstation id=PS02054.mssql.somee.com;packet size=4096;user id=tampm;pwd=T@M789852;data source=PS02054.mssql.somee.com;persist security info=False;initial catalog=PS02054"
    Dim data As New DataTable

    'Tải về dữ liệu từ Server
    Private Sub frmSanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connect As SqlConnection = New SqlConnection(connection_db)
        Dim Truyvan1 As SqlDataAdapter = New SqlDataAdapter("select * from San_Pham", connect)

        connect.Open()
        Truyvan1.Fill(data)
        dgvSanpham.DataSource = data.DefaultView

    End Sub
    'Thêm
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim connect As SqlConnection = New SqlConnection(connection_db)
        Dim Query2 As String = "insert into San_Pham values (@MSNSP,@MSSP,@TenSP,@DonGia,@SoLuong)"
        Dim ExecuteTruyvan1 As New SqlCommand(Query2, connect)
        connect.Open()
        ExecuteTruyvan1.Parameters.AddWithValue("@MSNSP", cbxNSP.SelectedItem)
        ExecuteTruyvan1.Parameters.AddWithValue("@MSSP", txtMSSP.Text)
        ExecuteTruyvan1.Parameters.AddWithValue("@TenSP", txtTenSP.Text)
        ExecuteTruyvan1.Parameters.AddWithValue("@DonGia", txtGia.Text)
        ExecuteTruyvan1.Parameters.AddWithValue("@SoLuong", txtTonkho.Text)

        ExecuteTruyvan1.ExecuteNonQuery()

        MessageBox.Show("Thêm thành công")

        'Làm mới bảng
        Dim Query3 As SqlDataAdapter = New SqlDataAdapter("select * from San_Pham", connect)
        data.Clear()
        Query3.Fill(data)
        dgvSanpham.DataSource = data.DefaultView

    End Sub
    'Tạo bảng
    Private Sub dgvSanpham_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSanpham.CellContentClick
        Dim index As Integer = dgvSanpham.CurrentCell.RowIndex
        txtMSSP.Text = dgvSanpham.Item(1, index).Value
        txtTenSP.Text = dgvSanpham.Item(2, index).Value
        txtGia.Text = dgvSanpham.Item(3, index).Value
        txtTonkho.Text = dgvSanpham.Item(4, index).Value
        cbxNSP.SelectedItem = dgvSanpham.Item(0, index).Value
    End Sub
    'Chỉnh sữa dự liệu
    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btmSua.Click
        Dim connect As SqlConnection = New SqlConnection(connection_db)
        Dim Query4 As String = "Update San_Pham Set Nhom_San_Pham_MSNSP=@MSNSP, MSSP=@MSSP, TenSP=@TenSP, DonGia=@DonGia, SoLuong=@SoLuong Where MSSP=@MSSP"
        Dim ExecuteQuery2 As New SqlCommand(Query4, connect)

        connect.Open()
        ExecuteQuery2.Parameters.AddWithValue("@MSNSP", cbxNSP.SelectedItem)
        ExecuteQuery2.Parameters.AddWithValue("@MSSP", txtMSSP.Text)
        ExecuteQuery2.Parameters.AddWithValue("@TenSP", txtTenSP.Text)
        ExecuteQuery2.Parameters.AddWithValue("@DonGia", txtGia.Text)
        ExecuteQuery2.Parameters.AddWithValue("@SoLuong", txtTonkho.Text)


        'Chạy lệnh truy vấn
        ExecuteQuery2.ExecuteNonQuery()
        MessageBox.Show("Sửa thành công")

        'Làm mới
        Dim refresh As SqlDataAdapter = New SqlDataAdapter("select * from San_Pham", connect)
        data.Clear()
        refresh.Fill(data)
        dgvSanpham.DataSource = data.DefaultView
    End Sub
    'Xóa
    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim connect As SqlConnection = New SqlConnection(connection_db)
        Dim Query As String = " delete from San_Pham Where MSSP=@MSSP"
        Dim Executequery3 As New SqlCommand(Query, connect)

        connect.Open()
        Executequery3.Parameters.AddWithValue("@MSSP", txtMSSP.Text)
        Executequery3.ExecuteNonQuery()
        MessageBox.Show("Xóa thành công")
        'làm mới
        Dim refresh As SqlDataAdapter = New SqlDataAdapter("select * from San_Pham", connect)
        data.Clear()
        refresh.Fill(data)
        dgvSanpham.DataSource = data.DefaultView
    End Sub
End Class