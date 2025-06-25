using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HoaDonChiTietDAL
    {
        DBConnection connection;
        public HoaDonChiTietDAL()
        {
            connection = new DBConnection();
        }
        public DataTable LayTTChiTiet(string maDon)
        {
            DataTable dt = new DataTable();
            connection.OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.fun_LayThongTinChiTietHD(@maHD)", connection.GetConnection());
            cmd.Parameters.Add("@maHD", SqlDbType.VarChar).Value = maDon;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        public bool ThemHDChiTiet(string masp, string madon, int soluong, double thanhtien)
        {
            connection.OpenConnection();
            SqlCommand cmd = new SqlCommand("proc_ThemHDChiTiet", connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@maSP", SqlDbType.VarChar).Value = masp;
            cmd.Parameters.Add("@maDon", SqlDbType.VarChar).Value = madon;
            cmd.Parameters.Add("@soLuongSp", SqlDbType.Int).Value = soluong;
            cmd.Parameters.Add("@thanhTien", SqlDbType.Decimal).Value = thanhtien;

            return cmd.ExecuteNonQuery() > 0;
        }
        public bool XoaHDChiTiet(string masp, string madon)
        {
            connection.OpenConnection();
            SqlCommand cmd = new SqlCommand("prox_XoaHDChiTiet", connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@maSP", SqlDbType.VarChar).Value = masp;
            cmd.Parameters.Add("@maDon", SqlDbType.VarChar).Value = madon;

            return cmd.ExecuteNonQuery() > 0;
        }
        public bool CapNhatHDChiTiet(string maspcu, string madon, int soluong, double thanhtien, string maspnew)
        {
            connection.OpenConnection();
            SqlCommand cmd = new SqlCommand("proc_SuaHDChiTiet", connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@maSPCu", SqlDbType.VarChar).Value = maspcu;
            cmd.Parameters.Add("@maSPNew", SqlDbType.VarChar).Value = maspnew;
            cmd.Parameters.Add("@maDon", SqlDbType.VarChar).Value = madon;
            cmd.Parameters.Add("@soLuongSP", SqlDbType.Int).Value = soluong;
            cmd.Parameters.Add("@thanhTien", SqlDbType.Decimal).Value = thanhtien;

            return cmd.ExecuteNonQuery() > 0;
        }
    }
}
