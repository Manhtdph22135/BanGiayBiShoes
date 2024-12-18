﻿namespace BanGiay.Form.US
{
    partial class Frm_US_KhachHang
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
            btnThem = new Button();
            btnSua = new Button();
            btnKhoa_MoKhoa = new Button();
            btnExcel = new Button();
            txtDiemKH = new TextBox();
            txtSDT = new TextBox();
            txtHoVaTen = new TextBox();
            label4 = new Label();
            txtMaKhachHang = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dgvHD = new DataGridView();
            groupBox3 = new GroupBox();
            dgvKH = new DataGridView();
            panel1 = new Panel();
            txtTimKiem_KhachHang = new TextBox();
            label5 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHD).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKH).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnKhoa_MoKhoa);
            groupBox1.Controls.Add(btnExcel);
            groupBox1.Controls.Add(txtDiemKH);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(txtHoVaTen);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtMaKhachHang);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1250, 165);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thêm khách hàng";
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThem.BackColor = Color.LimeGreen;
            btnThem.Cursor = Cursors.Hand;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 97, 120);
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(787, 89);
            btnThem.Margin = new Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(106, 52);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSua.BackColor = Color.LimeGreen;
            btnSua.Cursor = Cursors.Hand;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 97, 120);
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(901, 89);
            btnSua.Margin = new Padding(3, 4, 3, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(106, 52);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnKhoa_MoKhoa
            // 
            btnKhoa_MoKhoa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnKhoa_MoKhoa.BackColor = Color.LimeGreen;
            btnKhoa_MoKhoa.Cursor = Cursors.Hand;
            btnKhoa_MoKhoa.FlatAppearance.BorderSize = 0;
            btnKhoa_MoKhoa.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 97, 120);
            btnKhoa_MoKhoa.FlatStyle = FlatStyle.Flat;
            btnKhoa_MoKhoa.ForeColor = Color.White;
            btnKhoa_MoKhoa.Location = new Point(1014, 89);
            btnKhoa_MoKhoa.Margin = new Padding(3, 4, 3, 4);
            btnKhoa_MoKhoa.Name = "btnKhoa_MoKhoa";
            btnKhoa_MoKhoa.Size = new Size(117, 52);
            btnKhoa_MoKhoa.TabIndex = 2;
            btnKhoa_MoKhoa.Text = "Khóa/Mở khóa";
            btnKhoa_MoKhoa.UseVisualStyleBackColor = false;
            btnKhoa_MoKhoa.Click += btnKhoaMoKhoa_Click;
            // 
            // btnExcel
            // 
            btnExcel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExcel.BackColor = Color.LimeGreen;
            btnExcel.Cursor = Cursors.Hand;
            btnExcel.FlatAppearance.BorderSize = 0;
            btnExcel.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 97, 120);
            btnExcel.FlatStyle = FlatStyle.Flat;
            btnExcel.ForeColor = Color.White;
            btnExcel.Location = new Point(1137, 89);
            btnExcel.Margin = new Padding(3, 4, 3, 4);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(106, 52);
            btnExcel.TabIndex = 1;
            btnExcel.Text = "Excel";
            btnExcel.UseVisualStyleBackColor = false;
            btnExcel.Click += btnExcel_Click;
            // 
            // txtDiemKH
            // 
            txtDiemKH.BorderStyle = BorderStyle.FixedSingle;
            txtDiemKH.Location = new Point(451, 100);
            txtDiemKH.Margin = new Padding(3, 4, 3, 4);
            txtDiemKH.Name = "txtDiemKH";
            txtDiemKH.Size = new Size(257, 27);
            txtDiemKH.TabIndex = 0;
            // 
            // txtSDT
            // 
            txtSDT.BorderStyle = BorderStyle.FixedSingle;
            txtSDT.Location = new Point(491, 37);
            txtSDT.Margin = new Padding(3, 4, 3, 4);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(217, 27);
            txtSDT.TabIndex = 0;
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.BorderStyle = BorderStyle.FixedSingle;
            txtHoVaTen.Location = new Point(105, 100);
            txtHoVaTen.Margin = new Padding(3, 4, 3, 4);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(257, 27);
            txtHoVaTen.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(375, 105);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 0;
            label4.Text = "Điểm:";
            // 
            // txtMaKhachHang
            // 
            txtMaKhachHang.BorderStyle = BorderStyle.FixedSingle;
            txtMaKhachHang.Enabled = false;
            txtMaKhachHang.Location = new Point(145, 37);
            txtMaKhachHang.Margin = new Padding(3, 4, 3, 4);
            txtMaKhachHang.Name = "txtMaKhachHang";
            txtMaKhachHang.Size = new Size(217, 27);
            txtMaKhachHang.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(375, 43);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 0;
            label3.Text = "Số điện thoại:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 105);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 0;
            label2.Text = "Họ và tên:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 43);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã khách hàng:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvHD);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Location = new Point(0, 609);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(1250, 368);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hóa đon đã mua";
            // 
            // dgvHD
            // 
            dgvHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHD.Dock = DockStyle.Fill;
            dgvHD.Location = new Point(3, 24);
            dgvHD.Margin = new Padding(3, 4, 3, 4);
            dgvHD.Name = "dgvHD";
            dgvHD.RowHeadersWidth = 51;
            dgvHD.RowTemplate.Height = 25;
            dgvHD.Size = new Size(1244, 340);
            dgvHD.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvKH);
            groupBox3.Controls.Add(panel1);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(0, 165);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(1250, 444);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Khách hàng";
            // 
            // dgvKH
            // 
            dgvKH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKH.Dock = DockStyle.Fill;
            dgvKH.Location = new Point(3, 75);
            dgvKH.Margin = new Padding(3, 4, 3, 4);
            dgvKH.Name = "dgvKH";
            dgvKH.RowHeadersWidth = 51;
            dgvKH.RowTemplate.Height = 25;
            dgvKH.Size = new Size(1244, 365);
            dgvKH.TabIndex = 1;
            dgvKH.CellClick += dgvKH_CellClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtTimKiem_KhachHang);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 24);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1244, 51);
            panel1.TabIndex = 0;
            // 
            // txtTimKiem_KhachHang
            // 
            txtTimKiem_KhachHang.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem_KhachHang.Location = new Point(81, 12);
            txtTimKiem_KhachHang.Margin = new Padding(3, 4, 3, 4);
            txtTimKiem_KhachHang.Name = "txtTimKiem_KhachHang";
            txtTimKiem_KhachHang.PlaceholderText = "Tìm kiếm...";
            txtTimKiem_KhachHang.Size = new Size(380, 27);
            txtTimKiem_KhachHang.TabIndex = 0;
            txtTimKiem_KhachHang.TextChanged += txtTimkiem_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 17);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 0;
            label5.Text = "Tìm kiếm:";
            // 
            // Frm_US_KhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Frm_US_KhachHang";
            Size = new Size(1250, 977);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHD).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKH).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtHoVaTen;
        private TextBox txtMaKhachHang;
        private Label label2;
        private Label label1;
        private GroupBox groupBox3;
        private Button btnThem;
        private Button btnSua;
        private Button btnKhoa_MoKhoa;
        private Button btnExcel;
        private TextBox txtDiemKH;
        private TextBox txtSDT;
        private Label label4;
        private Label label3;
        private DataGridView dgvHD;
        private DataGridView dgvKH;
        private Panel panel1;
        private TextBox txtTimKiem_KhachHang;
        private Label label5;
    }
}
