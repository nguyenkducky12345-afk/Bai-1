<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        LabellblDonGia = New Label()
        lblSoLuong = New Label()
        lblGiamGia = New Label()
        lblTongTien = New Label()
        txtDonGia = New TextBox()
        txtSoLuong = New TextBox()
        txtGiamGia = New TextBox()
        btnTinhTien = New Button()
        btnLamMoi = New Button()
        lblKetQua = New Label()
        SuspendLayout()
        ' 
        ' LabellblDonGia
        ' 
        LabellblDonGia.AutoSize = True
        LabellblDonGia.Location = New Point(67, 35)
        LabellblDonGia.Name = "LabellblDonGia"
        LabellblDonGia.Size = New Size(116, 20)
        LabellblDonGia.TabIndex = 0
        LabellblDonGia.Text = "Đơn giá dịch vụ:"
        ' 
        ' lblSoLuong
        ' 
        lblSoLuong.AutoSize = True
        lblSoLuong.Location = New Point(67, 74)
        lblSoLuong.Name = "lblSoLuong"
        lblSoLuong.Size = New Size(114, 20)
        lblSoLuong.TabIndex = 1
        lblSoLuong.Text = "Số lượng khách:"
        ' 
        ' lblGiamGia
        ' 
        lblGiamGia.AutoSize = True
        lblGiamGia.Location = New Point(67, 112)
        lblGiamGia.Name = "lblGiamGia"
        lblGiamGia.Size = New Size(98, 20)
        lblGiamGia.TabIndex = 2
        lblGiamGia.Text = "Giảm giá (%):"
        ' 
        ' lblTongTien
        ' 
        lblTongTien.AutoSize = True
        lblTongTien.Location = New Point(67, 151)
        lblTongTien.Name = "lblTongTien"
        lblTongTien.Size = New Size(75, 20)
        lblTongTien.TabIndex = 3
        lblTongTien.Text = "Tổng tiền:"
        ' 
        ' txtDonGia
        ' 
        txtDonGia.Location = New Point(267, 35)
        txtDonGia.Name = "txtDonGia"
        txtDonGia.Size = New Size(125, 27)
        txtDonGia.TabIndex = 4
        ' 
        ' txtSoLuong
        ' 
        txtSoLuong.Location = New Point(267, 74)
        txtSoLuong.Name = "txtSoLuong"
        txtSoLuong.Size = New Size(125, 27)
        txtSoLuong.TabIndex = 5
        ' 
        ' txtGiamGia
        ' 
        txtGiamGia.Location = New Point(267, 112)
        txtGiamGia.Name = "txtGiamGia"
        txtGiamGia.Size = New Size(125, 27)
        txtGiamGia.TabIndex = 6
        ' 
        ' btnTinhTien
        ' 
        btnTinhTien.Location = New Point(145, 226)
        btnTinhTien.Name = "btnTinhTien"
        btnTinhTien.Size = New Size(94, 29)
        btnTinhTien.TabIndex = 7
        btnTinhTien.Text = "Tính tiền"
        btnTinhTien.UseVisualStyleBackColor = True
        ' 
        ' btnLamMoi
        ' 
        btnLamMoi.Location = New Point(287, 226)
        btnLamMoi.Name = "btnLamMoi"
        btnLamMoi.Size = New Size(94, 29)
        btnLamMoi.TabIndex = 8
        btnLamMoi.Text = "Làm mới"
        btnLamMoi.UseVisualStyleBackColor = True
        ' 
        ' lblKetQua
        ' 
        lblKetQua.AutoSize = True
        lblKetQua.Location = New Point(267, 151)
        lblKetQua.Name = "lblKetQua"
        lblKetQua.Size = New Size(17, 20)
        lblKetQua.TabIndex = 9
        lblKetQua.Text = "0"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblKetQua)
        Controls.Add(btnLamMoi)
        Controls.Add(btnTinhTien)
        Controls.Add(txtGiamGia)
        Controls.Add(txtSoLuong)
        Controls.Add(txtDonGia)
        Controls.Add(lblTongTien)
        Controls.Add(lblGiamGia)
        Controls.Add(lblSoLuong)
        Controls.Add(LabellblDonGia)
        Name = "Form1"
        Text = "Máy tính cước dịch vụ"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LabellblDonGia As Label
    Friend WithEvents lblSoLuong As Label
    Friend WithEvents lblGiamGia As Label
    Friend WithEvents lblTongTien As Label
    Friend WithEvents txtDonGia As TextBox
    Friend WithEvents txtSoLuong As TextBox
    Friend WithEvents txtGiamGia As TextBox
    Friend WithEvents btnTinhTien As Button
    Friend WithEvents btnLamMoi As Button
    Friend WithEvents lblKetQua As Label

End Class
