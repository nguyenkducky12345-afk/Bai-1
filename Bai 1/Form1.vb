Imports System.Globalization

Public Class Form1

    Private Sub btnTinhTien_Click(sender As Object, e As EventArgs) Handles btnTinhTien.Click
        ' Kiểm tra rỗng
        If String.IsNullOrWhiteSpace(txtDonGia.Text) OrElse String.IsNullOrWhiteSpace(txtSoLuong.Text) OrElse String.IsNullOrWhiteSpace(txtGiamGia.Text) Then
            MessageBox.Show("Vui lòng nhập đầy đủ các ô số.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim donGia As Double
        Dim soLuong As Double
        Dim giamGia As Double

        If Not Double.TryParse(txtDonGia.Text, donGia) Then
            MessageBox.Show("Đơn giá không hợp lệ.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDonGia.Focus()
            Return
        End If

        If Not Double.TryParse(txtSoLuong.Text, soLuong) Then
            MessageBox.Show("Số lượng không hợp lệ.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSoLuong.Focus()
            Return
        End If

        If Not Double.TryParse(txtGiamGia.Text, giamGia) Then
            MessageBox.Show("Giảm giá không hợp lệ.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtGiamGia.Focus()
            Return
        End If

        If donGia < 0 OrElse soLuong < 0 OrElse giamGia < 0 Then
            MessageBox.Show("Các giá trị không được âm.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If giamGia > 100 Then
            MessageBox.Show("Giảm giá không thể lớn hơn 100%.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim tongTien As Double = donGia * soLuong * (100.0 - giamGia) / 100.0

        ' Hiển thị theo định dạng tiền tệ Việt Nam (VND) - không có chữ số thập phân
        Dim vi As New CultureInfo("vi-VN")
        lblKetQua.Text = tongTien.ToString("C0", vi)
    End Sub

    Private Sub btnLamMoi_Click(sender As Object, e As EventArgs) Handles btnLamMoi.Click
        txtDonGia.Clear()
        txtSoLuong.Clear()
        txtGiamGia.Clear()
        lblKetQua.Text = "0"
        txtDonGia.Focus()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Thiết lập TabIndex hợp lý (nếu cần) và tiêu đề tiếng Việt
        Me.Text = "Máy tính cước dịch vụ"
        txtDonGia.TabIndex = 0
        txtSoLuong.TabIndex = 1
        txtGiamGia.TabIndex = 2
        btnTinhTien.TabIndex = 3
        btnLamMoi.TabIndex = 4
    End Sub

End Class
