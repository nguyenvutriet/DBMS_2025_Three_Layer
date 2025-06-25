using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DangKyDAL
    {
        DBConnection connection = null;
        public DangKyDAL()
        {
            connection = new DBConnection();
        }
        public bool LuuThongTinTaiKhoan(string hoTen, string SDT, string email, string gioiTinh, string vaiTro, string tenDangNhap, string matKhau)
        {
            connection.OpenConnection();
            SqlCommand command = new SqlCommand("proc_LuuThongTinnDK", connection.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@hoTen", SqlDbType.NVarChar).Value = hoTen;
            command.Parameters.Add("@SDT", SqlDbType.VarChar).Value = SDT;
            command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
            command.Parameters.Add("@gioiTinh", SqlDbType.NVarChar).Value = gioiTinh;
            command.Parameters.Add("@vaiTro", SqlDbType.NVarChar).Value = vaiTro;
            command.Parameters.Add("@tenDangNhap", SqlDbType.VarChar).Value = tenDangNhap;
            command.Parameters.Add("@matKhau", SqlDbType.VarChar).Value = matKhau;
            return command.ExecuteNonQuery() > 0;
        }
        public bool HuyThongTin(string hoTen, string SDT)
        {
            connection.OpenConnection();
            SqlCommand command = new SqlCommand("proc_XoaTaiKhoan", connection.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@hoTen", SqlDbType.NVarChar).Value = hoTen;
            command.Parameters.Add("@SDT", SqlDbType.VarChar).Value = SDT;
            return command.ExecuteNonQuery() > 0;
        }
        public DataTable LayDanhSach()
        {
            DataTable table = new DataTable();
            connection.OpenConnection();
            SqlCommand command = new SqlCommand("SELECT * FROM DangKy", connection.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }
        public DataTable XemTK(string hoTen, string SDT)
        {
            DataTable table = new DataTable();
            connection.OpenConnection();
            SqlCommand command = new SqlCommand("SELECT * FROM dbo.fun_XemTK(@hoTen, @SDT)", connection.GetConnection());
            command.Parameters.Add("@hoTen", SqlDbType.NVarChar).Value = hoTen;
            command.Parameters.Add("@SDT", SqlDbType.VarChar).Value = SDT;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }
    }
}
