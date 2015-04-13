Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmCustomer
    Dim connection_db As String = "workstation id=PS02054.mssql.somee.com;packet size=4096;user id=tampm;pwd=T@M789852;data source=PS02054.mssql.somee.com;persist security info=False;initial catalog=PS02054"
    Dim data As New DataTable
    Private Sub dgvKhachHang_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKhachHang.CellContentClick
        Dim index As Integer = dgvKhachHang.CurrentCell.RowIndex
        txtMSKH.Text = dgvKhachHang.Item(0, index).Value
        txtTenKH.Text = dgvKhachHang.Item(1, index).Value
        txtTenCongTy.Text = dgvKhachHang.Item(2, index).Value
        txtDiaCHi.Text = dgvKhachHang.Item(3, index).Value
        txtThanhPho.Text = dgvKhachHang.Item(4, index).Value
        txtSDT.Text = dgvKhachHang.Item(5, index).Value
    End Sub

    Private Sub frmCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connect As SqlConnection = New SqlConnection(connection_db)
        Dim Truyvan1 As SqlDataAdapter = New SqlDataAdapter("select * from Khach_Hang", connect)

        connect.Open()
        Truyvan1.Fill(data)
        dgvKhachHang.DataSource = data.DefaultView

    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim connect As SqlConnection = New SqlConnection(connection_db)
        Dim Query2 As String = "insert into Khach_Hang values (@MSKH,@HoTenKH,@TenCongTy,@DiaChi,@ThanhPho,@DienThoai)"
        Dim ExecuteTruyvan1 As New SqlCommand(Query2, connect)
        connect.Open()

        ExecuteTruyvan1.Parameters.AddWithValue("@MSKH", txtMSKH.Text)
        ExecuteTruyvan1.Parameters.AddWithValue("@HoTenKH", txtTenKH.Text)
        ExecuteTruyvan1.Parameters.AddWithValue("@TenCongTy", txtTenCongTy.Text)
        ExecuteTruyvan1.Parameters.AddWithValue("@DiaChi", txtDiaCHi.Text)
        ExecuteTruyvan1.Parameters.AddWithValue("@ThanhPho", txtThanhPho.Text)
        ExecuteTruyvan1.Parameters.AddWithValue("@DienThoai", txtSDT.Text)
        ExecuteTruyvan1.ExecuteNonQuery()

        MessageBox.Show("Thêm thành công")

        'Làm mới bảng
        Dim Query3 As SqlDataAdapter = New SqlDataAdapter("select * from Khach_Hang", connect)
        data.Clear()

        Query3.Fill(data)
        dgvKhachHang.DataSource = data.DefaultView
    End Sub

    Private Sub btmSua_Click(sender As Object, e As EventArgs) Handles btmSua.Click
        Dim connect As SqlConnection = New SqlConnection(connection_db)
        Dim Query4 As String = "Update Khach_Hang Set HoTenKH=@HoTenKH, TenCongTy=@TenCongTy, DiaChi=@DiaChi,ThanhPho=@ThanhPho, DienThoai=@DienThoai where MSKH=@MSKH"

        Dim ExecuteQuery2 As New SqlCommand(Query4, connect)
        connect.Open()

        ExecuteQuery2.Parameters.AddWithValue("@MSKH", txtMSKH.Text)
        ExecuteQuery2.Parameters.AddWithValue("@HoTenKH", txtTenKH.Text)
        ExecuteQuery2.Parameters.AddWithValue("@TenCongTy", txtTenCongTy.Text)
        ExecuteQuery2.Parameters.AddWithValue("@DiaChi", txtDiaCHi.Text)
        ExecuteQuery2.Parameters.AddWithValue("@ThanhPho", txtThanhPho.Text)
        ExecuteQuery2.Parameters.AddWithValue("@DienThoai", txtSDT.Text)

        'Chạy các câu truy vấn
        ExecuteQuery2.ExecuteNonQuery()
        connect.Close()

        MessageBox.Show("Sửa thành công")

        'Làm mới
        Dim refresh As SqlDataAdapter = New SqlDataAdapter("select * from Khach_Hang", connect)
        data.Clear()

        refresh.Fill(data)
        dgvKhachHang.DataSource = data.DefaultView
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim connect As SqlConnection = New SqlConnection(connection_db)
        Dim Query As String = " delete from Khach_Hang Where MSKH=@MSKH"
        Dim Executequery3 As New SqlCommand(Query, connect)

        connect.Open()
        Executequery3.Parameters.AddWithValue("@MSKH", txtMSKH.Text)
        Executequery3.ExecuteNonQuery()
        MessageBox.Show("Xóa thành công")
        'Làm mới
        Dim refresh As SqlDataAdapter = New SqlDataAdapter("select * from Khach_Hang", connect)
        data.Clear()

        refresh.Fill(data)
        dgvKhachHang.DataSource = data.DefaultView
    End Sub
End Class