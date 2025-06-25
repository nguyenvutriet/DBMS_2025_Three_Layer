using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class DbConnectionBLL
    {

        DBConnection connection;
        public DbConnectionBLL()
        {
            connection = new DBConnection();
        }
        public static string tenDangNhap { get; set; }
        public static string matKhau { get; set; }

        public static void CapNhatThongTinDangNhap(string username, string password)
        {
            tenDangNhap = username;
            matKhau = password;

            // Cập nhật thông tin đăng nhập cho DAL
            DAL.DBConnection.CapNhatThongTinDangNhap(username, password);
        }

    }
}
