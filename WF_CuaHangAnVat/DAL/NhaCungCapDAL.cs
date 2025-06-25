using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhaCungCapDAL
    {
        DBConnection connection = null;
        public NhaCungCapDAL()
        {
            connection = new DBConnection();
        }

        public DataTable GetListNCC()
        {
            DataTable table = new DataTable();
            connection.OpenConnection();
            string sql = "proc_ListNhaCungCap";
            SqlCommand command = new SqlCommand(sql, connection.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);

            return table;
        }
        // Gọi thủ tục ThemNhaCungCap trong SQL
        public bool ThemNhaCungCap(string maNCC, string tenNCC, string diaChi, string email, string sdt)
        {
            connection.OpenConnection();
            SqlCommand command = new SqlCommand("ThemNhaCungCap", connection.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@maNCC", SqlDbType.VarChar).Value = maNCC;
            command.Parameters.Add("@tenNCC", SqlDbType.NVarChar).Value = tenNCC;
            command.Parameters.Add("@diaChi", SqlDbType.NVarChar).Value = diaChi;
            command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
            command.Parameters.Add("@sdt", SqlDbType.VarChar).Value = sdt;
            bool result = command.ExecuteNonQuery() > 0;

            return result;

        }

        // Gọi thủ tục ChinhSuaNhaCungCap trong SQL
        public bool ChinhSuaNhaCungCap(string maNCC, string tenNCC, string diaChi, string email, string sdt)
        {
            connection.OpenConnection();
            SqlCommand command = new SqlCommand("ChinhSuaNhaCungCap", connection.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@maNCC", SqlDbType.VarChar).Value = maNCC;
            command.Parameters.Add("@tenNCC", SqlDbType.NVarChar).Value = tenNCC;
            command.Parameters.Add("@diaChi", SqlDbType.NVarChar).Value = diaChi;
            command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
            command.Parameters.Add("@sdt", SqlDbType.VarChar).Value = sdt;
            bool result = command.ExecuteNonQuery() > 0;

            return result;

        }

        // Gọi thủ tục XoaNhaCungCap trong SQL
        public bool XoaNhaCungCap(string tenNhaCungCap)
        {
            try
            {
                connection.OpenConnection();
                SqlCommand command = new SqlCommand("proc_XoaNCC", connection.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@tenNCC", SqlDbType.NVarChar).Value = tenNhaCungCap;
                return command.ExecuteNonQuery() > 0;
            }
            finally
            {
                connection.CloseConnection();
            }
        }

        // Gọi hàm TimKiemNhaCungCap trong SQL
        public DataTable TimKiemNhaCungCap(string tenNCC)
        {
            DataTable table = new DataTable();
            connection.OpenConnection();
            SqlCommand command = new SqlCommand("SELECT * FROM dbo.TimKiemNhaCungCap(@tenNCC)", connection.GetConnection());
            command.Parameters.Add("@tenNCC", SqlDbType.NVarChar).Value = tenNCC;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);

            return table;
        }
        public DataTable soLuongSPCuaNCC(string maNCC)
        {
            DataTable table = new DataTable();
            connection.OpenConnection();
            SqlCommand command = new SqlCommand("SELECT * FROM dbo.SoLuongSPCCTuNCC(@maNCC)", connection.GetConnection());
            command.Parameters.Add("@maNCC", SqlDbType.VarChar).Value = maNCC;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);

            return table;
        }
        public bool LienKet(string maSP, string maNCC, int soluong)
        {
            connection.OpenConnection();
            SqlCommand command = new SqlCommand("proc_LienKet", connection.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@maSP", SqlDbType.VarChar).Value = maSP;
            command.Parameters.Add("@MaNCC", SqlDbType.VarChar).Value = maNCC;
            command.Parameters.Add("@soLuong", SqlDbType.Int).Value = soluong;
            return command.ExecuteNonQuery() > 0;
        }
        public string GetMaNCC(string tenNCC)
        {
            connection.OpenConnection();
            SqlCommand command = new SqlCommand("SELECT * FROM dbo.fun_MaNhaCungCap(@tenNCC)", connection.GetConnection());
            command.Parameters.Add("@tenNCC", SqlDbType.NVarChar).Value = tenNCC;
            string maNCC = (string)command.ExecuteScalar();
            return maNCC;
        }
    }
}
