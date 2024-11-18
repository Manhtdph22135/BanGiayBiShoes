 using BUS.Services;
using DAL.Models.DomainClass;
using DAL.Models.ModelRefer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanGiay;
using BanGiay.Form.US;
using DAL.Models.Context;

namespace PRL.Frm_Main
{
    public partial class DangNhap_Frm : System.Windows.Forms.Form
    {
        TaiKhoanService _Ser_TaiKhoan = new TaiKhoanService();
        List<Taikhoan> _lstTaiKhoan = new List<Taikhoan>();
        int idTaiKhoan;
        string hoVaTen;
        string maChucVu;
        public DangNhap_Frm()
        {
            InitializeComponent();
        }
        private void DangNhap_Frm_Load(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = true;
            LoadMau();
            this.BackColor = Color.FromArgb(69, 97, 120);
        }
        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }
        public bool AuthenticateUser(string userName, string password, List<Taikhoan> lstTaiKhoan)
        {
            foreach (var user in lstTaiKhoan)
            {
                if (user.Username == userName && user.Pasword == password)
                {
                    idTaiKhoan = user.Mataikhoan;
                    //maChucVu = user.MachucvuNavigation.Tenchucvu;
                    maChucVu = user.Machucvu.ToString();
                    hoVaTen = user.Hovaten;
                    LoginManager.Instance.UpdateLoginInfo(user.Mataikhoan, user.Machucvu, user.Hovaten);
                    return true;
                }
            }

            return false;
        }
        private void btnQuenmk_Click(object sender, EventArgs e)
        {
            QuenMatKhau_Frm formQuenMatKhau = new QuenMatKhau_Frm();
            formQuenMatKhau.Show();
        }
        private void txtMatKhau_Enter(object sender, EventArgs e)
        {
            if (e is KeyEventArgs keyEventArgs && keyEventArgs.KeyCode == Keys.Enter)
            {
                DangNhap();
            }
        }
        public void DangNhap()
        {
            _lstTaiKhoan = _Ser_TaiKhoan.GetAll(null, null);
            if (AuthenticateUser(txtTaiKhoan.Text, txtMatKhau.Text, _lstTaiKhoan))
            {
                var chuc = LoginManager.Instance.GetTenChucVu(new DBContext());
                MessageBox.Show($"Đăng nhập thành công!\n Xin chào '{hoVaTen}'\n Bạn là: '{(chuc == "Nhân Viên" ? "Nhân viên" : chuc == "Quản Lý" ?  "Quản lý" : "Không thể nhận dạng")}'");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại. Sai tên đăng nhập hoặc mật khẩu.");
            }
        }
        public void LoadMau()
        {
            txt1.ForeColor = Color.FromArgb(255, 255, 255);
            txt2.ForeColor = Color.FromArgb(255, 255, 255);
            txt3.ForeColor = Color.FromArgb(255, 255, 255);
            txt4.ForeColor = Color.FromArgb(255, 255, 255);
            txt1.ForeColor = Color.FromArgb(255, 255, 255);
            txtMatKhau.BackColor = Color.FromArgb(221, 242, 253);
            txtTaiKhoan.BackColor = Color.FromArgb(221, 242, 253);
            btnDangnhap.BackColor = Color.FromArgb(243, 19, 86);
            btnDangnhap.ForeColor = Color.FromArgb(255, 255, 255);
            txtQuenMatKhau.ForeColor = Color.FromArgb(255, 255, 255);
        }
        private void ptbTat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
