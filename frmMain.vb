Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmMain
    Private Sub btnHoaDon_Click(sender As Object, e As EventArgs) Handles btnHoaDon.Click
        frmInvoice.Show()
    End Sub
    Private Sub btnSanPham_Click(sender As Object, e As EventArgs) Handles btnSanPham.Click
        frmProduct.Show()
    End Sub
    Private Sub btnKhachHang_Click(sender As Object, e As EventArgs) Handles btnKhachHang.Click
        frmCustomer.Show()
    End Sub
    Private Sub btnNhanVien_Click(sender As Object, e As EventArgs) Handles btnNhanVien.Click
        frmStaff.Show()
    End Sub
    Private Sub mniThongtin_Click(sender As Object, e As EventArgs) Handles mniThongtin.Click
        frmInfo.ShowDialog()
    End Sub
    Private Sub mniLogout_Click(sender As Object, e As EventArgs) Handles mniLogout.Click
        frmLogin.Show()
        Me.Hide()
    End Sub
    Private Sub mniExit_Click(sender As Object, e As EventArgs) Handles mniExit.Click
        End
    End Sub
End Class