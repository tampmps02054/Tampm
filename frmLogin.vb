Imports System.Data.SqlClient
Imports System.Data.DataTable
Imports System.Security.Cryptography
Imports System.Text
Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim chuoiketnoi As String = "workstation id=PS02054.mssql.somee.com;packet size=4096;user id=tampm;pwd=T@M789852;data source=PS02054.mssql.somee.com;persist security info=False;initial catalog=PS02054"

        Dim KetNoi As SqlConnection = New SqlConnection(chuoiketnoi)
        
        Dim sqlAdapter As New SqlDataAdapter("select * from Nhan_Vien where MSNV='" & txtUsername.Text & "' and Password='" & Encrypt(txtPassword.Text, "this is key") & "' ", KetNoi)
    Dim tb As New DataTable
        Try
            KetNoi.Open()
            sqlAdapter.Fill(tb)
            If tb.Rows.Count > 0 Then
                MessageBox.Show("Kết nối thành công.")
                frmMain.Show()
                Me.Hide()
            Else
                MessageBox.Show("Sai Tài Khoản hoặc Mật Khẩu.")
            End If

        Catch ex As Exception

        End Try
    End Sub
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

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
