using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HoaDonDAL
    {
        readonly DBConnection connection = null;
        public HoaDonDAL()
        {
            connection = new DBConnection();
        }

        public DataTable GetListHD()
        {
            DataTable table = new DataTable();
            connection.OpenConnection();
            string sql = "proc_ListHoaDon";
            SqlCommand command = new SqlCommand(sql, connection.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);

            return table;
        }

        // Gọi hàm TimKiemHoaDon trong SQL
        public DataTable TimKiemHoaDon(string maDon)
        {
            DataTable table = new DataTable();
            connection.OpenConnection();
            SqlCommand command = new SqlCommand("SELECT * FROM dbo.TimKiemHoaDon(@maDon)", connection.GetConnection());
            command.Parameters.Add("@maDon", SqlDbType.VarChar).Value = maDon;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);

            return table;
        }

        // Gọi thủ tục themHoaDonMoi trong SQL
        // tạo hóa đơn mới 
        public bool ThemHoaDonMoi(string maDon, DateTime ngayDat, double tongTien)
        {
            connection.OpenConnection();
            SqlCommand command = new SqlCommand("themHoaDonMoi", connection.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@maDon", SqlDbType.VarChar).Value = maDon;
            command.Parameters.Add("@ngayDat", SqlDbType.Date).Value = ngayDat;
            command.Parameters.Add("@tongTien", SqlDbType.Decimal).Value = tongTien;
            bool result = command.ExecuteNonQuery() > 0;

            return result;

        }

        // Gọi thủ tục suaHoaDon trong SQL
        public bool SuaHoaDon(string maDon, DateTime ngayDat, double tongTien)
        {
            connection.OpenConnection();
            SqlCommand command = new SqlCommand("suaHoaDon", connection.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@maDon", SqlDbType.VarChar).Value = maDon;
            command.Parameters.Add("@ngayDat", SqlDbType.Date).Value = ngayDat;
            command.Parameters.Add("@tongTien", SqlDbType.Decimal).Value = tongTien;
            bool result = command.ExecuteNonQuery() > 0;
            //conn.Close();
            return result;

        }

        // Gọi thủ tục xoaHoaDon trong SQL
        public bool XoaHoaDon(string maDon)
        {
            connection.OpenConnection();
            SqlCommand command = new SqlCommand("proc_XoaHD", connection.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@maDon", SqlDbType.VarChar).Value = maDon;
            bool result = command.ExecuteNonQuery() > 0;

            return result;

        }

        // Gọi hàm XuatHoaDon trong SQL
        public DataTable XuatHoaDon(string maDon)
        {
            DataTable table = new DataTable();
            connection.OpenConnection();
            SqlCommand command = new SqlCommand("SELECT * FROM dbo.XuatHoaDon", connection.GetConnection());
            command.Parameters.Add("@maDon", SqlDbType.VarChar).Value = maDon;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);

            return table;
        }
        public DataTable ThongTinChiTietCuaHoaDon(string maDon)
        {
            DataTable table = new DataTable();
            connection.OpenConnection();
            SqlCommand command = new SqlCommand("SELECT * FROM dbo.fun_ChiTietHoaDon(@maDon)", connection.GetConnection());
            command.Parameters.Add("@maDon", SqlDbType.VarChar).Value = maDon;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);

            return table;
        }
        public string TongTienMotHoaDon(string maDon)
        {
            connection.OpenConnection();
            SqlCommand command = new SqlCommand("SELECT dbo.fun_TongCong(@maDon)", connection.GetConnection());
            command.Parameters.Add("@maDon", SqlDbType.VarChar).Value = maDon;
            string tongTien = command.ExecuteScalar().ToString();

            return tongTien;
        }
    }
}
