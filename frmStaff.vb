Imports System.Data.SqlClient
Imports System.Data.DataTable
Imports System.Security.Cryptography
Imports System.Text
Public Class frmStaff
    Dim connection_db As String = "workstation id=PS02054.mssql.somee.com;packet size=4096;user id=tampm;pwd=T@M789852;data source=PS02054.mssql.somee.com;persist security info=False;initial catalog=PS02054"
    Dim data As New DataTable
    Dim DES As New TripleDESCryptoServiceProvider
    Dim MD5 As New MD5CryptoServiceProvider
    'tạo Function Hash
    Function MD5Hash(value As String) As Byte()
        Return MD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(value))
    End Function
    ' tạo encrypt function bằng Hash
    Function Encrypt(stringInput As String, Keys As String) As String
        DES.Key = MD5Hash(Keys)
        DES.Mode = CipherMode.ECB
        Dim buffer As Byte() = ASCIIEncoding.ASCII.GetBytes(stringInput)
        Return Convert.ToBase64String(DES.CreateEncryptor().TransformFinalBlock(buffer, 0, buffer.Length))
    End Function
    Private Sub frmStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connect As SqlConnection = New SqlConnection(connection_db)
        Dim Truyvan1 As SqlDataAdapter = New SqlDataAdapter("select * from Nhan_Vien", connect)
        connect.Open()
        Truyvan1.Fill(data)
        dgvNhanVien.DataSource = data.DefaultView
    End Sub
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim connect As SqlConnection = New SqlConnection(connection_db)
        Dim Query2 As String = "insert into Nhan_Vien values (@MSNV,@Password,@HoTen,@ChucVu,@Email,@BirthYear)"
        Dim ExecuteTruyvan1 As New SqlCommand(Query2, connect)
        connect.Open()

        ExecuteTruyvan1.Parameters.AddWithValue("@MSNV", txtMSNV.Text)
        ExecuteTruyvan1.Parameters.AddWithValue("@Password", Encrypt(txtPassword.Text, "this is key"))
        ExecuteTruyvan1.Parameters.AddWithValue("@HoTen", txtHoTen.Text)
        ExecuteTruyvan1.Parameters.AddWithValue("@ChucVu", txtChucvu.Text)
        ExecuteTruyvan1.Parameters.AddWithValue("@Email", txtEmail.Text)
        ExecuteTruyvan1.Parameters.AddWithValue("@BirthYear", txtBirthYear.Text)
        ExecuteTruyvan1.ExecuteNonQuery()
        MessageBox.Show("Thêm thành công")
        'Làm mới bảng
        Dim Query3 As SqlDataAdapter = New SqlDataAdapter("select * from Nhan_Vien", connect)
        data.Clear()
        Query3.Fill(data)
        dgvNhanVien.DataSource = data.DefaultView
    End Sub
    Private Sub btmSua_Click(sender As Object, e As EventArgs) Handles btmSua.Click
        Dim connect As SqlConnection = New SqlConnection(connection_db)
        Dim Query4 As String = "Update Nhan_Vien Set MSNV=@MSNV, Password=@Password, HoTen=@HoTen,Chucvu=@ChucVu,Email=@Email, BirthYear=@BirthYear"
        Dim ExecuteQuery2 As New SqlCommand(Query4, connect)
        connect.Open()
        ExecuteQuery2.Parameters.AddWithValue("@MSNV", txtMSNV.Text)
        ExecuteQuery2.Parameters.AddWithValue("@Password", txtPassword.Text)
        ExecuteQuery2.Parameters.AddWithValue("@HoTen", txtHoTen.Text)
        ExecuteQuery2.Parameters.AddWithValue("@ChucVu", txtChucvu.Text)
        ExecuteQuery2.Parameters.AddWithValue("@Email", txtEmail.Text)
        ExecuteQuery2.Parameters.AddWithValue("@BirthYear", txtBirthYear.Text)
        'Chạy các câu truy vấn
        ExecuteQuery2.ExecuteNonQuery()
        MessageBox.Show("Sửa thành công")
        'Làm mới
        Dim refresh As SqlDataAdapter = New SqlDataAdapter("select * from Nhan_Vien", connect)
        data.Clear()
        refresh.Fill(data)
        dgvNhanVien.DataSource = data.DefaultView
    End Sub
    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim connect As SqlConnection = New SqlConnection(connection_db)
        Dim Query As String = " delete from NHan_Vien Where MSNV=@MSNV"
        Dim Executequery3 As New SqlCommand(Query, connect)
        connect.Open()
        Executequery3.Parameters.AddWithValue("@MSNV", txtMSNV.Text)
        Executequery3.ExecuteNonQuery()
        MessageBox.Show("Xóa thành công")
        'làm mới
        Dim refresh As SqlDataAdapter = New SqlDataAdapter("select * from Nhan_Vien", connect)
        data.Clear()
        refresh.Fill(data)
        dgvNhanVien.DataSource = data.DefaultView
    End Sub
    Private Sub dgvNhanVien_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvNhanVien.CellContentClick
        Dim index As Integer = dgvNhanVien.CurrentCell.RowIndex
        txtMSNV.Text = dgvNhanVien.Item(0, index).Value
        txtPassword.Text = dgvNhanVien.Item(1, index).Value
        txtHoTen.Text = dgvNhanVien.Item(2, index).Value
        txtChucvu.Text = dgvNhanVien.Item(3, index).Value
        txtEmail.Text = dgvNhanVien.Item(4, index).Value
        txtBirthYear.Text = dgvNhanVien.Item(5, index).Value
    End Sub
End Class