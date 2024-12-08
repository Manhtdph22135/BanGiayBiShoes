namespace BanGiay.Form.US
{
    partial class Frm_US_BangLuong
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
            panel3 = new Panel();
            btnLamMoi = new Button();
            btnSua = new Button();
            panel4 = new Panel();
            btnThem = new Button();
            txtThanglam = new TextBox();
            label8 = new Label();
            txtTongthunhap = new TextBox();
            label7 = new Label();
            txtTienkhautru = new TextBox();
            label6 = new Label();
            txtTienthuong = new TextBox();
            label5 = new Label();
            txtLCB = new TextBox();
            txtTennv = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtManv = new TextBox();
            label2 = new Label();
            groupBox3 = new GroupBox();
            dgvHienThi = new DataGridView();
            panel1 = new Panel();
            btn_Excel = new Button();
            panel2 = new Panel();
            txtTimkiem_NhanVien = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHienThi).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel3);
            groupBox1.Controls.Add(txtThanglam);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtTongthunhap);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtTienkhautru);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtTienthuong);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtLCB);
            groupBox1.Controls.Add(txtTennv);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtManv);
            groupBox1.Controls.Add(label2);
            groupBox1.Dock = DockStyle.Right;
            groupBox1.Location = new Point(895, 0);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(355, 977);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tính Lương";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnLamMoi);
            panel3.Controls.Add(btnSua);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(btnThem);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(3, 913);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(349, 60);
            panel3.TabIndex = 33;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(64, 79, 105);
            btnLamMoi.Cursor = Cursors.Hand;
            btnLamMoi.Dock = DockStyle.Right;
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 97, 120);
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(261, 0);
            btnLamMoi.Margin = new Padding(3, 4, 3, 4);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(88, 60);
            btnLamMoi.TabIndex = 23;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLammoi_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(64, 79, 105);
            btnSua.Cursor = Cursors.Hand;
            btnSua.Dock = DockStyle.Left;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 97, 120);
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(131, 0);
            btnSua.Margin = new Padding(3, 4, 3, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(86, 60);
            btnSua.TabIndex = 21;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(90, 0);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(41, 60);
            panel4.TabIndex = 20;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(64, 79, 105);
            btnThem.Cursor = Cursors.Hand;
            btnThem.Dock = DockStyle.Left;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 97, 120);
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(0, 0);
            btnThem.Margin = new Padding(2, 3, 2, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(90, 60);
            btnThem.TabIndex = 19;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtThanglam
            // 
            txtThanglam.BorderStyle = BorderStyle.FixedSingle;
            txtThanglam.Location = new Point(117, 144);
            txtThanglam.Name = "txtThanglam";
            txtThanglam.Size = new Size(221, 27);
            txtThanglam.TabIndex = 32;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 315);
            label8.Name = "label8";
            label8.Size = new Size(86, 20);
            label8.TabIndex = 30;
            label8.Text = "Tổng lương";
            // 
            // txtTongthunhap
            // 
            txtTongthunhap.BorderStyle = BorderStyle.FixedSingle;
            txtTongthunhap.Enabled = false;
            txtTongthunhap.Location = new Point(117, 315);
            txtTongthunhap.Name = "txtTongthunhap";
            txtTongthunhap.Size = new Size(221, 27);
            txtTongthunhap.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 272);
            label7.Name = "label7";
            label7.Size = new Size(95, 20);
            label7.TabIndex = 28;
            label7.Text = "Tiền khấu trừ";
            // 
            // txtTienkhautru
            // 
            txtTienkhautru.BorderStyle = BorderStyle.FixedSingle;
            txtTienkhautru.Location = new Point(117, 272);
            txtTienkhautru.Name = "txtTienkhautru";
            txtTienkhautru.Size = new Size(221, 27);
            txtTienkhautru.TabIndex = 27;
            txtTienkhautru.TextChanged += txtTienkhautru_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 231);
            label6.Name = "label6";
            label6.Size = new Size(89, 20);
            label6.TabIndex = 26;
            label6.Text = "Tiền thưởng";
            // 
            // txtTienthuong
            // 
            txtTienthuong.BorderStyle = BorderStyle.FixedSingle;
            txtTienthuong.Location = new Point(117, 229);
            txtTienthuong.Name = "txtTienthuong";
            txtTienthuong.Size = new Size(221, 27);
            txtTienthuong.TabIndex = 25;
            txtTienthuong.TextChanged += txtTienthuong_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 187);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 24;
            label5.Text = "Lương cơ bản";
            // 
            // txtLCB
            // 
            txtLCB.BorderStyle = BorderStyle.FixedSingle;
            txtLCB.Location = new Point(117, 187);
            txtLCB.Name = "txtLCB";
            txtLCB.Size = new Size(221, 27);
            txtLCB.TabIndex = 23;
            txtLCB.TextChanged += txtLCB_TextChanged;
            // 
            // txtTennv
            // 
            txtTennv.BorderStyle = BorderStyle.FixedSingle;
            txtTennv.Enabled = false;
            txtTennv.Location = new Point(117, 105);
            txtTennv.Name = "txtTennv";
            txtTennv.Size = new Size(221, 27);
            txtTennv.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 105);
            label4.Name = "label4";
            label4.Size = new Size(99, 20);
            label4.TabIndex = 20;
            label4.Text = "Tên nhân viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 65);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 18;
            label3.Text = "Mã nhân viên";
            // 
            // txtManv
            // 
            txtManv.BorderStyle = BorderStyle.FixedSingle;
            txtManv.Location = new Point(117, 65);
            txtManv.Name = "txtManv";
            txtManv.Size = new Size(221, 27);
            txtManv.TabIndex = 17;
            txtManv.TextChanged += txtManv_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 141);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 16;
            label2.Text = "Tháng làm";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvHienThi);
            groupBox3.Controls.Add(panel1);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(0, 0);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(895, 977);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Bảng Lương";
            // 
            // dgvHienThi
            // 
            dgvHienThi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvHienThi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHienThi.Dock = DockStyle.Fill;
            dgvHienThi.Location = new Point(3, 95);
            dgvHienThi.Margin = new Padding(3, 4, 3, 4);
            dgvHienThi.Name = "dgvHienThi";
            dgvHienThi.RowHeadersWidth = 51;
            dgvHienThi.RowTemplate.Height = 25;
            dgvHienThi.Size = new Size(889, 878);
            dgvHienThi.TabIndex = 2;
            dgvHienThi.CellClick += dgvHienThi_CellClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_Excel);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(txtTimkiem_NhanVien);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 24);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(889, 71);
            panel1.TabIndex = 1;
            // 
            // btn_Excel
            // 
            btn_Excel.BackColor = Color.LimeGreen;
            btn_Excel.Cursor = Cursors.Hand;
            btn_Excel.Dock = DockStyle.Right;
            btn_Excel.FlatAppearance.BorderSize = 0;
            btn_Excel.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 97, 120);
            btn_Excel.FlatStyle = FlatStyle.Flat;
            btn_Excel.ForeColor = Color.White;
            btn_Excel.Location = new Point(730, 0);
            btn_Excel.Margin = new Padding(3, 4, 3, 4);
            btn_Excel.Name = "btn_Excel";
            btn_Excel.Size = new Size(86, 71);
            btn_Excel.TabIndex = 4;
            btn_Excel.Text = "Excel";
            btn_Excel.UseVisualStyleBackColor = false;
            btn_Excel.Click += btnexcel_Click;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(816, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(73, 71);
            panel2.TabIndex = 3;
            // 
            // txtTimkiem_NhanVien
            // 
            txtTimkiem_NhanVien.BorderStyle = BorderStyle.FixedSingle;
            txtTimkiem_NhanVien.Location = new Point(96, 21);
            txtTimkiem_NhanVien.Margin = new Padding(3, 4, 3, 4);
            txtTimkiem_NhanVien.Name = "txtTimkiem_NhanVien";
            txtTimkiem_NhanVien.Size = new Size(361, 27);
            txtTimkiem_NhanVien.TabIndex = 1;
            txtTimkiem_NhanVien.TextChanged += txtTimkiem_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 27);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "Tìm kiếm:";
            // 
            // Frm_US_BangLuong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Frm_US_BangLuong";
            Size = new Size(1250, 977);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHienThi).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private Panel panel1;
        private TextBox txtTimkiem_NhanVien;
        private Label label1;
        private Button btn_Excel;
        private Panel panel2;
        private TextBox txtThanglam;
        private Button btnThem;
        private Label label8;
        private TextBox txtTongthunhap;
        private Label label7;
        private TextBox txtTienkhautru;
        private Label label6;
        private TextBox txtTienthuong;
        private Label label5;
        private TextBox txtLCB;
        private TextBox txtTennv;
        private Label label4;
        private Label label3;
        private TextBox txtManv;
        private Label label2;
        private Panel panel3;
        private Panel panel4;
        private Button btnLamMoi;
        private Button btnSua;
        private DataGridView dgvHienThi;
    }
}
