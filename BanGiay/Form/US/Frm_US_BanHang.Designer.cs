﻿namespace BanGiay.Form.US
{
    partial class Frm_US_BanHang
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            cbb_giamgia = new ComboBox();
            btnThanhToan = new Button();
            txtGhiChu = new TextBox();
            txtSoTienNhan = new TextBox();
            txtDiem_KH = new TextBox();
            cbbHinhThucThanhToan = new ComboBox();
            chbox_Dung_DiemKH = new CheckBox();
            groupBox5 = new GroupBox();
            btnChon_KhachHang = new Button();
            txtTenKhachHang = new Label();
            label3 = new Label();
            txtMaKhachhang = new Label();
            label1 = new Label();
            txtTongTien = new Label();
            txtTongTienSP = new Label();
            txtSoTienThua = new Label();
            label23 = new Label();
            label21 = new Label();
            label20 = new Label();
            label17 = new Label();
            label16 = new Label();
            label13 = new Label();
            txtSoTienThieu = new Label();
            label9 = new Label();
            label8 = new Label();
            label5 = new Label();
            label2 = new Label();
            txtMaHoaDon = new Label();
            txtMaNhanVien = new Label();
            panel1 = new Panel();
            groupBox4 = new GroupBox();
            dgvHDCT = new DataGridView();
            panel4 = new Panel();
            btnLamMoi_ID_HDCT = new Button();
            panel7 = new Panel();
            txtID_HDCT = new TextBox();
            panel6 = new Panel();
            txtSoLuongMuonXoa = new NumericUpDown();
            panel9 = new Panel();
            btnXoa_HDCT = new Button();
            panel5 = new Panel();
            btnChontatCa = new Button();
            groupBox3 = new GroupBox();
            dgvSP = new DataGridView();
            panel8 = new Panel();
            btnTimKiem_SP = new Button();
            panel10 = new Panel();
            txtTimKiem_SP = new TextBox();
            btnLamMoi = new Button();
            groupBox2 = new GroupBox();
            dgv_HD = new DataGridView();
            panel2 = new Panel();
            btn_Xoa_HD = new Button();
            panel3 = new Panel();
            btnThem_HD = new Button();
            groupBox1.SuspendLayout();
            groupBox5.SuspendLayout();
            panel1.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHDCT).BeginInit();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtSoLuongMuonXoa).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSP).BeginInit();
            panel8.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_HD).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbb_giamgia);
            groupBox1.Controls.Add(btnThanhToan);
            groupBox1.Controls.Add(txtGhiChu);
            groupBox1.Controls.Add(txtSoTienNhan);
            groupBox1.Controls.Add(txtDiem_KH);
            groupBox1.Controls.Add(cbbHinhThucThanhToan);
            groupBox1.Controls.Add(chbox_Dung_DiemKH);
            groupBox1.Controls.Add(groupBox5);
            groupBox1.Controls.Add(txtTongTien);
            groupBox1.Controls.Add(txtTongTienSP);
            groupBox1.Controls.Add(txtSoTienThua);
            groupBox1.Controls.Add(label23);
            groupBox1.Controls.Add(label21);
            groupBox1.Controls.Add(label20);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(txtSoTienThieu);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMaHoaDon);
            groupBox1.Controls.Add(txtMaNhanVien);
            groupBox1.Dock = DockStyle.Right;
            groupBox1.Location = new Point(893, 0);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(357, 977);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thanh toán";
            // 
            // cbb_giamgia
            // 
            cbb_giamgia.FormattingEnabled = true;
            cbb_giamgia.Location = new Point(116, 270);
            cbb_giamgia.Name = "cbb_giamgia";
            cbb_giamgia.Size = new Size(218, 28);
            cbb_giamgia.TabIndex = 6;
            cbb_giamgia.SelectedIndexChanged += cbb_giamgia_SelectedIndexChanged;
            // 
            // btnThanhToan
            // 
            btnThanhToan.BackColor = Color.LimeGreen;
            btnThanhToan.Cursor = Cursors.Hand;
            btnThanhToan.Dock = DockStyle.Bottom;
            btnThanhToan.FlatAppearance.BorderSize = 0;
            btnThanhToan.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 97, 120);
            btnThanhToan.FlatStyle = FlatStyle.Flat;
            btnThanhToan.ForeColor = Color.White;
            btnThanhToan.Location = new Point(3, 900);
            btnThanhToan.Margin = new Padding(3, 4, 3, 4);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(351, 73);
            btnThanhToan.TabIndex = 5;
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.UseVisualStyleBackColor = false;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // txtGhiChu
            // 
            txtGhiChu.BorderStyle = BorderStyle.FixedSingle;
            txtGhiChu.Location = new Point(13, 715);
            txtGhiChu.Margin = new Padding(3, 4, 3, 4);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(337, 133);
            txtGhiChu.TabIndex = 4;
            // 
            // txtSoTienNhan
            // 
            txtSoTienNhan.BorderStyle = BorderStyle.FixedSingle;
            txtSoTienNhan.Location = new Point(130, 424);
            txtSoTienNhan.Margin = new Padding(3, 4, 3, 4);
            txtSoTienNhan.Name = "txtSoTienNhan";
            txtSoTienNhan.Size = new Size(223, 27);
            txtSoTienNhan.TabIndex = 4;
            txtSoTienNhan.TextChanged += txtSoTienNhan_TextChanged;
            // 
            // txtDiem_KH
            // 
            txtDiem_KH.BorderStyle = BorderStyle.FixedSingle;
            txtDiem_KH.Enabled = false;
            txtDiem_KH.Location = new Point(101, 375);
            txtDiem_KH.Margin = new Padding(3, 4, 3, 4);
            txtDiem_KH.Name = "txtDiem_KH";
            txtDiem_KH.Size = new Size(252, 27);
            txtDiem_KH.TabIndex = 4;
            txtDiem_KH.TextChanged += txtDiemKH_TextChanged;
            // 
            // cbbHinhThucThanhToan
            // 
            cbbHinhThucThanhToan.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbHinhThucThanhToan.FormattingEnabled = true;
            cbbHinhThucThanhToan.Location = new Point(193, 320);
            cbbHinhThucThanhToan.Margin = new Padding(3, 4, 3, 4);
            cbbHinhThucThanhToan.Name = "cbbHinhThucThanhToan";
            cbbHinhThucThanhToan.Size = new Size(156, 28);
            cbbHinhThucThanhToan.TabIndex = 3;
            // 
            // chbox_Dung_DiemKH
            // 
            chbox_Dung_DiemKH.AutoSize = true;
            chbox_Dung_DiemKH.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            chbox_Dung_DiemKH.Location = new Point(25, 376);
            chbox_Dung_DiemKH.Margin = new Padding(3, 4, 3, 4);
            chbox_Dung_DiemKH.Name = "chbox_Dung_DiemKH";
            chbox_Dung_DiemKH.Size = new Size(74, 27);
            chbox_Dung_DiemKH.TabIndex = 1;
            chbox_Dung_DiemKH.Text = "Dùng";
            chbox_Dung_DiemKH.UseVisualStyleBackColor = true;
            chbox_Dung_DiemKH.CheckedChanged += cboxDungDiemKH_CheckedChanged;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btnChon_KhachHang);
            groupBox5.Controls.Add(txtTenKhachHang);
            groupBox5.Controls.Add(label3);
            groupBox5.Controls.Add(txtMaKhachhang);
            groupBox5.Controls.Add(label1);
            groupBox5.Dock = DockStyle.Top;
            groupBox5.Location = new Point(3, 24);
            groupBox5.Margin = new Padding(3, 4, 3, 4);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(3, 4, 3, 4);
            groupBox5.Size = new Size(351, 121);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            groupBox5.Text = "Khách hàng";
            // 
            // btnChon_KhachHang
            // 
            btnChon_KhachHang.BackColor = Color.LimeGreen;
            btnChon_KhachHang.Cursor = Cursors.Hand;
            btnChon_KhachHang.Dock = DockStyle.Right;
            btnChon_KhachHang.FlatAppearance.BorderSize = 0;
            btnChon_KhachHang.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 97, 120);
            btnChon_KhachHang.FlatStyle = FlatStyle.Flat;
            btnChon_KhachHang.ForeColor = Color.White;
            btnChon_KhachHang.Location = new Point(276, 24);
            btnChon_KhachHang.Margin = new Padding(3, 4, 3, 4);
            btnChon_KhachHang.Name = "btnChon_KhachHang";
            btnChon_KhachHang.Size = new Size(72, 93);
            btnChon_KhachHang.TabIndex = 1;
            btnChon_KhachHang.Text = "Chọn";
            btnChon_KhachHang.UseVisualStyleBackColor = false;
            btnChon_KhachHang.Click += ptbChonKhachHang_Click;
            // 
            // txtTenKhachHang
            // 
            txtTenKhachHang.AutoSize = true;
            txtTenKhachHang.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtTenKhachHang.Location = new Point(136, 65);
            txtTenKhachHang.Name = "txtTenKhachHang";
            txtTenKhachHang.Size = new Size(41, 23);
            txtTenKhachHang.TabIndex = 0;
            txtTenKhachHang.Text = "N/A";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(9, 65);
            label3.Name = "label3";
            label3.Size = new Size(135, 23);
            label3.TabIndex = 0;
            label3.Text = "Tên khách hàng:";
            // 
            // txtMaKhachhang
            // 
            txtMaKhachhang.AutoSize = true;
            txtMaKhachhang.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtMaKhachhang.Location = new Point(136, 31);
            txtMaKhachhang.Name = "txtMaKhachhang";
            txtMaKhachhang.Size = new Size(41, 23);
            txtMaKhachhang.TabIndex = 0;
            txtMaKhachhang.Text = "N/A";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(9, 31);
            label1.Name = "label1";
            label1.Size = new Size(134, 23);
            label1.TabIndex = 0;
            label1.Text = "Mã khách hàng:";
            // 
            // txtTongTien
            // 
            txtTongTien.AutoSize = true;
            txtTongTien.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtTongTien.Location = new Point(116, 635);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(41, 23);
            txtTongTien.TabIndex = 0;
            txtTongTien.Text = "N/A";
            // 
            // txtTongTienSP
            // 
            txtTongTienSP.AutoSize = true;
            txtTongTienSP.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtTongTienSP.Location = new Point(182, 480);
            txtTongTienSP.Name = "txtTongTienSP";
            txtTongTienSP.Size = new Size(41, 23);
            txtTongTienSP.TabIndex = 0;
            txtTongTienSP.Text = "N/A";
            // 
            // txtSoTienThua
            // 
            txtSoTienThua.AutoSize = true;
            txtSoTienThua.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtSoTienThua.Location = new Point(137, 532);
            txtSoTienThua.Name = "txtSoTienThua";
            txtSoTienThua.Size = new Size(41, 23);
            txtSoTienThua.TabIndex = 0;
            txtSoTienThua.Text = "N/A";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label23.Location = new Point(23, 688);
            label23.Name = "label23";
            label23.Size = new Size(73, 23);
            label23.TabIndex = 0;
            label23.Text = "Ghi chú:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label21.Location = new Point(23, 636);
            label21.Name = "label21";
            label21.Size = new Size(87, 23);
            label21.TabIndex = 0;
            label21.Text = "Tổng tiền:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label20.Location = new Point(23, 584);
            label20.Name = "label20";
            label20.Size = new Size(111, 23);
            label20.TabIndex = 0;
            label20.Text = "Số tiền thiếu:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(23, 532);
            label17.Name = "label17";
            label17.Size = new Size(108, 23);
            label17.TabIndex = 0;
            label17.Text = "Số tiền thừa:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(23, 480);
            label16.Name = "label16";
            label16.Size = new Size(167, 23);
            label16.TabIndex = 0;
            label16.Text = "Tổng tiền sản phẩm:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(23, 428);
            label13.Name = "label13";
            label13.Size = new Size(111, 23);
            label13.TabIndex = 0;
            label13.Text = "Số tiền nhận:";
            // 
            // txtSoTienThieu
            // 
            txtSoTienThieu.AutoSize = true;
            txtSoTienThieu.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtSoTienThieu.Location = new Point(139, 584);
            txtSoTienThieu.Name = "txtSoTienThieu";
            txtSoTienThieu.Size = new Size(41, 23);
            txtSoTienThieu.TabIndex = 0;
            txtSoTienThieu.Text = "N/A";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(23, 324);
            label9.Name = "label9";
            label9.Size = new Size(181, 23);
            label9.TabIndex = 0;
            label9.Text = "Hình thức thanh toán:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(23, 272);
            label8.Name = "label8";
            label8.Size = new Size(82, 23);
            label8.TabIndex = 0;
            label8.Text = "Giảm giá:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(23, 220);
            label5.Name = "label5";
            label5.Size = new Size(108, 23);
            label5.TabIndex = 0;
            label5.Text = "Mã hóa đơn:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(23, 168);
            label2.Name = "label2";
            label2.Size = new Size(120, 23);
            label2.TabIndex = 0;
            label2.Text = "Mã nhân viên:";
            // 
            // txtMaHoaDon
            // 
            txtMaHoaDon.AutoSize = true;
            txtMaHoaDon.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtMaHoaDon.Location = new Point(130, 220);
            txtMaHoaDon.Name = "txtMaHoaDon";
            txtMaHoaDon.Size = new Size(41, 23);
            txtMaHoaDon.TabIndex = 0;
            txtMaHoaDon.Text = "N/A";
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.AutoSize = true;
            txtMaNhanVien.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtMaNhanVien.Location = new Point(139, 168);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.Size = new Size(41, 23);
            txtMaNhanVien.TabIndex = 0;
            txtMaNhanVien.Text = "N/A";
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox4);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(893, 977);
            panel1.TabIndex = 2;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dgvHDCT);
            groupBox4.Controls.Add(panel4);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(0, 287);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(893, 371);
            groupBox4.TabIndex = 22;
            groupBox4.TabStop = false;
            groupBox4.Text = "Giở hàng";
            // 
            // dgvHDCT
            // 
            dgvHDCT.AllowUserToAddRows = false;
            dgvHDCT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHDCT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHDCT.Dock = DockStyle.Fill;
            dgvHDCT.Location = new Point(3, 71);
            dgvHDCT.Margin = new Padding(3, 4, 3, 4);
            dgvHDCT.Name = "dgvHDCT";
            dgvHDCT.RowHeadersWidth = 51;
            dgvHDCT.RowTemplate.Height = 25;
            dgvHDCT.Size = new Size(887, 296);
            dgvHDCT.TabIndex = 2;
            dgvHDCT.CellClick += dgvHDCT_CellContentClick;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnLamMoi_ID_HDCT);
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(txtID_HDCT);
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(btnXoa_HDCT);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(btnChontatCa);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(3, 24);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(887, 47);
            panel4.TabIndex = 1;
            // 
            // btnLamMoi_ID_HDCT
            // 
            btnLamMoi_ID_HDCT.BackColor = Color.LimeGreen;
            btnLamMoi_ID_HDCT.Cursor = Cursors.Hand;
            btnLamMoi_ID_HDCT.Dock = DockStyle.Right;
            btnLamMoi_ID_HDCT.FlatAppearance.BorderSize = 0;
            btnLamMoi_ID_HDCT.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 97, 120);
            btnLamMoi_ID_HDCT.FlatStyle = FlatStyle.Flat;
            btnLamMoi_ID_HDCT.ForeColor = Color.White;
            btnLamMoi_ID_HDCT.Location = new Point(248, 0);
            btnLamMoi_ID_HDCT.Margin = new Padding(3, 4, 3, 4);
            btnLamMoi_ID_HDCT.Name = "btnLamMoi_ID_HDCT";
            btnLamMoi_ID_HDCT.Size = new Size(86, 47);
            btnLamMoi_ID_HDCT.TabIndex = 6;
            btnLamMoi_ID_HDCT.Text = "Làm mới";
            btnLamMoi_ID_HDCT.UseVisualStyleBackColor = false;
            btnLamMoi_ID_HDCT.Click += ptbLamMoiIdHoaDonChiTiet_Click;
            // 
            // panel7
            // 
            panel7.Dock = DockStyle.Right;
            panel7.Location = new Point(334, 0);
            panel7.Margin = new Padding(3, 4, 3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(18, 47);
            panel7.TabIndex = 5;
            // 
            // txtID_HDCT
            // 
            txtID_HDCT.BorderStyle = BorderStyle.FixedSingle;
            txtID_HDCT.Dock = DockStyle.Right;
            txtID_HDCT.Enabled = false;
            txtID_HDCT.Location = new Point(352, 0);
            txtID_HDCT.Margin = new Padding(3, 4, 3, 4);
            txtID_HDCT.Multiline = true;
            txtID_HDCT.Name = "txtID_HDCT";
            txtID_HDCT.PlaceholderText = "...";
            txtID_HDCT.Size = new Size(114, 47);
            txtID_HDCT.TabIndex = 4;
            txtID_HDCT.TextAlign = HorizontalAlignment.Center;
            // 
            // panel6
            // 
            panel6.Controls.Add(txtSoLuongMuonXoa);
            panel6.Controls.Add(panel9);
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(466, 0);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(202, 47);
            panel6.TabIndex = 3;
            // 
            // txtSoLuongMuonXoa
            // 
            txtSoLuongMuonXoa.BorderStyle = BorderStyle.FixedSingle;
            txtSoLuongMuonXoa.Location = new Point(25, 8);
            txtSoLuongMuonXoa.Margin = new Padding(3, 4, 3, 4);
            txtSoLuongMuonXoa.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            txtSoLuongMuonXoa.Name = "txtSoLuongMuonXoa";
            txtSoLuongMuonXoa.Size = new Size(137, 27);
            txtSoLuongMuonXoa.TabIndex = 8;
            // 
            // panel9
            // 
            panel9.Dock = DockStyle.Left;
            panel9.Location = new Point(0, 0);
            panel9.Margin = new Padding(3, 4, 3, 4);
            panel9.Name = "panel9";
            panel9.Size = new Size(18, 47);
            panel9.TabIndex = 7;
            // 
            // btnXoa_HDCT
            // 
            btnXoa_HDCT.BackColor = Color.LimeGreen;
            btnXoa_HDCT.Cursor = Cursors.Hand;
            btnXoa_HDCT.Dock = DockStyle.Right;
            btnXoa_HDCT.FlatAppearance.BorderSize = 0;
            btnXoa_HDCT.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 97, 120);
            btnXoa_HDCT.FlatStyle = FlatStyle.Flat;
            btnXoa_HDCT.ForeColor = Color.White;
            btnXoa_HDCT.Location = new Point(668, 0);
            btnXoa_HDCT.Margin = new Padding(3, 4, 3, 4);
            btnXoa_HDCT.Name = "btnXoa_HDCT";
            btnXoa_HDCT.Size = new Size(86, 47);
            btnXoa_HDCT.TabIndex = 2;
            btnXoa_HDCT.Text = "Xóa";
            btnXoa_HDCT.UseVisualStyleBackColor = false;
            btnXoa_HDCT.Click += btnXoa_Click;
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(754, 0);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(18, 47);
            panel5.TabIndex = 1;
            // 
            // btnChontatCa
            // 
            btnChontatCa.BackColor = Color.LimeGreen;
            btnChontatCa.Cursor = Cursors.Hand;
            btnChontatCa.Dock = DockStyle.Right;
            btnChontatCa.FlatAppearance.BorderSize = 0;
            btnChontatCa.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 97, 120);
            btnChontatCa.FlatStyle = FlatStyle.Flat;
            btnChontatCa.ForeColor = Color.White;
            btnChontatCa.Location = new Point(772, 0);
            btnChontatCa.Margin = new Padding(3, 4, 3, 4);
            btnChontatCa.Name = "btnChontatCa";
            btnChontatCa.Size = new Size(115, 47);
            btnChontatCa.TabIndex = 0;
            btnChontatCa.Text = "Chọn tắt cả";
            btnChontatCa.UseVisualStyleBackColor = false;
            btnChontatCa.Click += btnChonTatCa_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvSP);
            groupBox3.Controls.Add(panel8);
            groupBox3.Dock = DockStyle.Bottom;
            groupBox3.Location = new Point(0, 658);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(893, 319);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Sản phẩm";
            // 
            // dgvSP
            // 
            dgvSP.AllowUserToAddRows = false;
            dgvSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSP.Dock = DockStyle.Fill;
            dgvSP.Location = new Point(3, 71);
            dgvSP.Margin = new Padding(3, 4, 3, 4);
            dgvSP.Name = "dgvSP";
            dgvSP.RowHeadersWidth = 51;
            dgvSP.RowTemplate.Height = 25;
            dgvSP.Size = new Size(887, 244);
            dgvSP.TabIndex = 3;
            dgvSP.CellClick += dgvSP_CellClick;
            // 
            // panel8
            // 
            panel8.Controls.Add(btnTimKiem_SP);
            panel8.Controls.Add(panel10);
            panel8.Controls.Add(txtTimKiem_SP);
            panel8.Controls.Add(btnLamMoi);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(3, 24);
            panel8.Margin = new Padding(3, 4, 3, 4);
            panel8.Name = "panel8";
            panel8.Size = new Size(887, 47);
            panel8.TabIndex = 1;
            // 
            // btnTimKiem_SP
            // 
            btnTimKiem_SP.BackColor = Color.LimeGreen;
            btnTimKiem_SP.Cursor = Cursors.Hand;
            btnTimKiem_SP.Dock = DockStyle.Left;
            btnTimKiem_SP.FlatAppearance.BorderSize = 0;
            btnTimKiem_SP.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 97, 120);
            btnTimKiem_SP.FlatStyle = FlatStyle.Flat;
            btnTimKiem_SP.ForeColor = Color.White;
            btnTimKiem_SP.Location = new Point(341, 0);
            btnTimKiem_SP.Margin = new Padding(3, 4, 3, 4);
            btnTimKiem_SP.Name = "btnTimKiem_SP";
            btnTimKiem_SP.Size = new Size(94, 47);
            btnTimKiem_SP.TabIndex = 6;
            btnTimKiem_SP.Text = "Tìm kiếm";
            btnTimKiem_SP.UseVisualStyleBackColor = false;
            btnTimKiem_SP.Click += btnTimKiem_SP_Click;
            // 
            // panel10
            // 
            panel10.Dock = DockStyle.Left;
            panel10.Location = new Point(323, 0);
            panel10.Margin = new Padding(3, 4, 3, 4);
            panel10.Name = "panel10";
            panel10.Size = new Size(18, 47);
            panel10.TabIndex = 5;
            // 
            // txtTimKiem_SP
            // 
            txtTimKiem_SP.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem_SP.Dock = DockStyle.Left;
            txtTimKiem_SP.Location = new Point(0, 0);
            txtTimKiem_SP.Margin = new Padding(3, 4, 3, 4);
            txtTimKiem_SP.Multiline = true;
            txtTimKiem_SP.Name = "txtTimKiem_SP";
            txtTimKiem_SP.PlaceholderText = "Tìm kiếm...";
            txtTimKiem_SP.Size = new Size(323, 47);
            txtTimKiem_SP.TabIndex = 1;
            txtTimKiem_SP.TextChanged += btnTimKiem_SP_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.LimeGreen;
            btnLamMoi.Cursor = Cursors.Hand;
            btnLamMoi.Dock = DockStyle.Right;
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 97, 120);
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(801, 0);
            btnLamMoi.Margin = new Padding(3, 4, 3, 4);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(86, 47);
            btnLamMoi.TabIndex = 0;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += pictureBox3_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgv_HD);
            groupBox2.Controls.Add(panel2);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(893, 287);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hóa đơn";
            // 
            // dgv_HD
            // 
            dgv_HD.AllowUserToAddRows = false;
            dgv_HD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_HD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_HD.Dock = DockStyle.Fill;
            dgv_HD.Location = new Point(3, 71);
            dgv_HD.Margin = new Padding(3, 4, 3, 4);
            dgv_HD.Name = "dgv_HD";
            dgv_HD.RowHeadersWidth = 51;
            dgv_HD.RowTemplate.Height = 25;
            dgv_HD.Size = new Size(887, 212);
            dgv_HD.TabIndex = 1;
            dgv_HD.CellClick += dgv_HD_CellClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_Xoa_HD);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(btnThem_HD);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 24);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(887, 47);
            panel2.TabIndex = 0;
            // 
            // btn_Xoa_HD
            // 
            btn_Xoa_HD.BackColor = Color.LimeGreen;
            btn_Xoa_HD.Cursor = Cursors.Hand;
            btn_Xoa_HD.Dock = DockStyle.Right;
            btn_Xoa_HD.FlatAppearance.BorderSize = 0;
            btn_Xoa_HD.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 97, 120);
            btn_Xoa_HD.FlatStyle = FlatStyle.Flat;
            btn_Xoa_HD.ForeColor = Color.White;
            btn_Xoa_HD.Location = new Point(697, 0);
            btn_Xoa_HD.Margin = new Padding(3, 4, 3, 4);
            btn_Xoa_HD.Name = "btn_Xoa_HD";
            btn_Xoa_HD.Size = new Size(86, 47);
            btn_Xoa_HD.TabIndex = 2;
            btn_Xoa_HD.Text = "Xóa";
            btn_Xoa_HD.UseVisualStyleBackColor = false;
            btn_Xoa_HD.Click += btnXoaHoaDon_Click;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(783, 0);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(18, 47);
            panel3.TabIndex = 1;
            // 
            // btnThem_HD
            // 
            btnThem_HD.BackColor = Color.LimeGreen;
            btnThem_HD.Cursor = Cursors.Hand;
            btnThem_HD.Dock = DockStyle.Right;
            btnThem_HD.FlatAppearance.BorderSize = 0;
            btnThem_HD.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 97, 120);
            btnThem_HD.FlatStyle = FlatStyle.Flat;
            btnThem_HD.ForeColor = Color.White;
            btnThem_HD.Location = new Point(801, 0);
            btnThem_HD.Margin = new Padding(3, 4, 3, 4);
            btnThem_HD.Name = "btnThem_HD";
            btnThem_HD.Size = new Size(86, 47);
            btnThem_HD.TabIndex = 0;
            btnThem_HD.Text = "Thêm";
            btnThem_HD.UseVisualStyleBackColor = false;
            btnThem_HD.Click += ptbThemHoaDon_Click;
            // 
            // Frm_US_BanHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Frm_US_BanHang";
            Size = new Size(1250, 977);
            Load += Frm_BanHang_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHDCT).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtSoLuongMuonXoa).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSP).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_HD).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox5;
        private Button btnChon_KhachHang;
        private Label txtTenKhachHang;
        private Label label3;
        private Label txtMaKhachhang;
        private Label label1;
        private TextBox textBox1;
        private CheckBox chbox_Dung_DiemKH;
        private Label label24;
        private Label txtTongTien;
        private Label txtSoTienThua;
        private Label label14;
        private Label label10;
        private Label label6;
        private Label label23;
        private Label label21;
        private Label label20;
        private Label label17;
        private Label label16;
        private Label label13;
        private Label txtSoTienThieu;
        private Label label9;
        private Label label15;
        private Label label8;
        private Label label11;
        private Label label5;
        private Label label2;
        private Label txtMaNhanVien;
        private Button btnThanhToan;
        private TextBox txtGhiChu;
        private TextBox txtSoTienNhan;
        private TextBox txtDiem_KH;
        private ComboBox cbbHinhThucThanhToan;
        private Label txtTongTienSP;
        private Label txtMaHoaDon;
        private Panel panel1;
        private GroupBox groupBox4;
        private DataGridView dgvHDCT;
        private Panel panel4;
        private Button btnLamMoi_ID_HDCT;
        private Panel panel7;
        private TextBox txtID_HDCT;
        private Button btnXoa_HDCT;
        private Panel panel5;
        private Button btnChontatCa;
        private GroupBox groupBox3;
        private DataGridView dgvSP;
        private Panel panel8;
        private Button btnTimKiem_SP;
        private Panel panel10;
        private TextBox txtTimKiem_SP;
        private Button btnLamMoi;
        private GroupBox groupBox2;
        private DataGridView dgv_HD;
        private Panel panel2;
        private Button btn_Xoa_HD;
        private Panel panel3;
        private Button btnThem_HD;
        private Panel panel6;
        private Panel panel9;
        private NumericUpDown txtSoLuongMuonXoa;
        private ComboBox cbb_giamgia;
    }
}
