using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KhuyenMaiDAL
    {
        DBConnection connection;

        public KhuyenMaiDAL()
        {
            connection = new DBConnection();
        }
        public DataTable getListKM()
        {
            DataTable table = new DataTable();

            connection.OpenConnection();
            string sql = "proc_ListKhuyenMai";
            SqlCommand command = new SqlCommand(sql, connection.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }
        // Thêm khuyến mãi
        public bool themKhuyenMai(string maKM, string tenChuongTrinh, string ngayBatDau, string ngayKetThuc)
        {
            connection.OpenConnection();
            SqlCommand command = new SqlCommand("Them_KhuyenMai", connection.GetConnection());
            DateTime ngayBD = DateTime.Parse(ngayBatDau);
            DateTime ngayKT = DateTime.Parse(ngayKetThuc);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@maKM", SqlDbType.VarChar).Value = maKM;
            command.Parameters.Add("@tenChuongTrinh", SqlDbType.NVarChar).Value = tenChuongTrinh;
            command.Parameters.Add("@ngayBatDau", SqlDbType.DateTime).Value = ngayBD;
            command.Parameters.Add("@ngayKetThuc", SqlDbType.DateTime).Value = ngayKT;
            return command.ExecuteNonQuery() > 0;

        }
        // Cập nhật khuyến mãi
        public bool suaKhuyenMai(string maKM, string tenChuongTrinh, string ngayBatDau, string ngayKetThuc)
        {
            connection.OpenConnection();
            SqlCommand command = new SqlCommand("Sua_KhuyenMai", connection.GetConnection());
            DateTime ngayBD = DateTime.Parse(ngayBatDau);
            DateTime ngayKT = DateTime.Parse(ngayKetThuc);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@maKM", SqlDbType.VarChar).Value = maKM;
            command.Parameters.Add("@tenChuongTrinh", SqlDbType.NVarChar).Value = tenChuongTrinh;
            command.Parameters.Add("@ngayBatDau", SqlDbType.DateTime).Value = ngayBD;
            command.Parameters.Add("@ngayKetThuc", SqlDbType.DateTime).Value = ngayKT;


            return command.ExecuteNonQuery() > 0;


        }
        // Xóa khuyến mãi
        public bool xoaKhuyenMai(string tenChuongTrinh)
        {
            try
            {
                connection.OpenConnection();
                SqlCommand command = new SqlCommand("Xoa_KhuyenMai", connection.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@tenChuongTrinhKM", SqlDbType.NVarChar).Value = tenChuongTrinh;
                return command.ExecuteNonQuery() > 0;
            }
            finally
            {
                connection.CloseConnection();
            }
        }
        public string LayTenChuongTrinh(string maKM)
        {
            connection.OpenConnection();
            SqlCommand command = new SqlCommand("SELECT dbo.fun_TenChuongTrinh(@maKM)", connection.GetConnection());
            command.Parameters.Add("@maKM", SqlDbType.VarChar).Value = maKM;
            string tenChuongTrinh = command.ExecuteScalar().ToString();
            return tenChuongTrinh;
        }
        public string LayMaChuongTrinh(string tenChuongTrinh)
        {
            connection.OpenConnection();
            SqlCommand command = new SqlCommand("SELECT dbo.fun_MaKM(@tenCT)", connection.GetConnection());
            command.Parameters.Add("@tenCT", SqlDbType.NVarChar).Value = tenChuongTrinh;
            string maChuongTrinh = command.ExecuteScalar().ToString();
            return maChuongTrinh;
        }
    }
}
