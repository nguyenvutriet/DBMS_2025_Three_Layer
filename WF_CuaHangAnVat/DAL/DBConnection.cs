using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBConnection
    {
        // Đường dẫn kết nối đến cơ sở dữ liệu
        private static string _tenDangNhap;
        private static string _matKhau;
        SqlConnection conn;
        public DBConnection()
        {
            string connectionString = $"Data Source=(local); Initial Catalog=SieuThiAnVatMlem; User ID={_tenDangNhap}; Password={_matKhau}";
            conn = new SqlConnection(connectionString);
        }
        public static void CapNhatThongTinDangNhap(string tenDangNhap, string matKhau)
        {
            _tenDangNhap = tenDangNhap;
            _matKhau = matKhau;
        }
        public SqlConnection GetConnection()
        {
            return conn;
        }

        public void OpenConnection()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }

        public void CloseConnection()
        {
            if (conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }
        }
    }
}
