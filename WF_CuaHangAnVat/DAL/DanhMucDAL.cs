using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DanhMucDAL
    {
        readonly DBConnection connection = null;
        public DanhMucDAL()
        {
            connection = new DBConnection();
        }
        public DataTable View_DoanhThu()
        {
            DataTable dt = new DataTable();
            connection.OpenConnection();
            SqlCommand command = new SqlCommand("proc_DoanhMuc_DoanhThu", connection.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            return dt;
        }
        public DataTable View_SanPham()
        {
            DataTable dt = new DataTable();
            connection.OpenConnection();
            SqlCommand command = new SqlCommand("proc_DanhMuc_SanPham", connection.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            return dt;
        }
        public DataTable View_NhaCungCap()
        {
            DataTable table = new DataTable();
            connection.OpenConnection();
            SqlCommand command = new SqlCommand("proc_ThongTinNCC", connection.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }
        public DataTable View_KhuyenMai()
        {
            DataTable table = new DataTable();
            connection.OpenConnection();
            SqlCommand command = new SqlCommand("proc_ChuongTrinhKM_SP", connection.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }
        public DataTable View_TaiKhoan()
        {
            DataTable table = new DataTable();
            connection.OpenConnection();
            SqlCommand command = new SqlCommand("proc_View_TaiKhoan", connection.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }
    }
}
