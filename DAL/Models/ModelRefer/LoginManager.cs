using DAL.Models.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models.ModelRefer
{
    public class LoginManager
    {
        private static LoginManager _instance;
        public static LoginManager Instance => _instance ?? (_instance = new LoginManager());

        public int IdTaiKhoan { get; private set; }
        public int MaChucVu { get; private set; }
        public string HoVaTen { get; private set; }
        public void UpdateLoginInfo(int idTaiKhoan, int machucvu, string hoVaTen)
        {
            IdTaiKhoan = idTaiKhoan;
            MaChucVu = machucvu;
            HoVaTen = hoVaTen;
        }
        public void Logout()
        {
            IdTaiKhoan = 0;
            MaChucVu = 0;
            HoVaTen = null;
        }
        public string GetTenChucVu(DbContext context)
        {
            var chucvu = context.Set<Chucvu>().FirstOrDefault(cv => cv.Machucvu == MaChucVu);
            return chucvu?.Tenchucvu ?? "Chức vụ không tồn tại";
        }
    }
}
