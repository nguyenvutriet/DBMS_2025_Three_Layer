using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SanPhamDAL
    {
        DBConnection connection = null;
        public SanPhamDAL()
        {
            connection = new DBConnection();
        }
        public DataTable getListSanPham()
        {
            DataTable table = new DataTable();
            connection.OpenConnection();
            string sql = "proc_ListSanPham";
            SqlCommand command = new SqlCommand(sql, connection.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }
        public bool themSanPham(string maSP, string tenSanPham, double giaBan, DateTime hanSuDung, string moTa, int soLuongSP, string maLoaiSanPham)
        {
            connection.OpenConnection();
            SqlCommand command = new SqlCommand("Them_SanPham", connection.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@maSP", SqlDbType.VarChar).Value = maSP;
            command.Parameters.Add("@tenSanPham", SqlDbType.NVarChar).Value = tenSanPham;
            command.Parameters.Add("@giaBan", SqlDbType.Decimal).Value = giaBan;
            command.Parameters.Add("@hanSuDung", SqlDbType.DateTime).Value = hanSuDung;
            command.Parameters.Add("@moTa", SqlDbType.NVarChar).Value = moTa;
            command.Parameters.Add("@soLuongSP", SqlDbType.Int).Value = soLuongSP;
            command.Parameters.Add("@maLoaiSanPham", SqlDbType.VarChar).Value = maLoaiSanPham;
            return command.ExecuteNonQuery() > 0;
        }
        public bool CapNhap_SanPham(string maSP, string tenSanPham, double giaBan, DateTime hanSuDung, string moTa, int soLuongSP, string maLoaiSanPham)
        {
            connection.OpenConnection();
            SqlCommand command = new SqlCommand("ChinhSua_SanPham", connection.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@maSP", SqlDbType.VarChar).Value = maSP;
            command.Parameters.Add("@tenSanPham", SqlDbType.NVarChar).Value = tenSanPham;
            command.Parameters.Add("@giaBan", SqlDbType.Decimal).Value = giaBan;
            command.Parameters.Add("@hanSuDung", SqlDbType.DateTime).Value = hanSuDung;
            command.Parameters.Add("@moTa", SqlDbType.NVarChar).Value = moTa;
            command.Parameters.Add("@soLuongSP", SqlDbType.Int).Value = soLuongSP;
            command.Parameters.Add("@maLoaiSanPham", SqlDbType.VarChar).Value = maLoaiSanPham;
            return command.ExecuteNonQuery() > 0;

        }
        public DataTable TimKiemSanPham(string maSP)
        {
            connection.OpenConnection();
            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Fun_ThongTinSP(@maSP)", connection.GetConnection());
            command.Parameters.Add("@maSP", SqlDbType.NVarChar).Value = maSP;
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);

            return table;

        }
        public DataTable DanhSachLoai_SanPham(string maLoaiSanPham)
        {
            DataTable table = new DataTable();

            connection.OpenConnection();
            SqlCommand command = new SqlCommand("DsTheoLoai_SanPham", connection.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@maLoaiSanPham", SqlDbType.VarChar).Value = maLoaiSanPham;
            SqlDataReader reader = command.ExecuteReader();
            // Tạo cột cho DataTable nếu chưa có
            table.Columns.Add("maSP", typeof(string));
            table.Columns.Add("tenSanPham", typeof(string));
            table.Columns.Add("giaBan", typeof(double));
            table.Columns.Add("hanSuDung", typeof(DateTime));
            table.Columns.Add("moTa", typeof(string));
            table.Columns.Add("soLuongSP", typeof(int));
            table.Columns.Add("maLoaiSanPham", typeof(string));
            // Đọc dữ liệu và thêm vào bảng
            while (reader.Read())
            {
                table.Rows.Add(
                    reader["maSP"].ToString(),
                    reader["tenSanPham"].ToString(),
                    Convert.ToDouble(reader["giaBan"]),
                    Convert.ToDateTime(reader["hanSuDung"]),
                    reader["moTa"].ToString(),
                    Convert.ToInt32(reader["soLuongSP"]),
                    reader["maLoaiSanPham"].ToString()
                );
            }

            return table;
        }
        public double GiaBan_SanPham(string tenSanPham)
        {
            double GiaBan = 0;
            connection.OpenConnection();
            SqlCommand command = new SqlCommand("SELECT giaBan FROM dbo.Fun_GiaBan(@tenSanPham)", connection.GetConnection());
            command.Parameters.Add("@tenSanPham", SqlDbType.NVarChar).Value = tenSanPham;
            SqlDataReader reder = command.ExecuteReader();
            if (reder != null)
            {
                GiaBan = Convert.ToDouble(reder["giaBan"]);
            }

            return GiaBan;

        }
        public bool XoaSanPham(string tenSanPham)
        {
            try
            {
                connection.OpenConnection();
                SqlCommand command = new SqlCommand("proc_XoaSP", connection.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@tenSanPham", SqlDbType.NVarChar).Value = tenSanPham;
                return command.ExecuteNonQuery() > 0;
            }
            finally
            {
                connection.CloseConnection();
            }
        }
        public string LayMaSanPham(string tensanpham)
        {
            connection.OpenConnection();
            SqlCommand command = new SqlCommand("SELECT dbo.fun_MaSanPham(@tensanpham)", connection.GetConnection());
            command.Parameters.Add("@tensanpham", SqlDbType.NVarChar).Value = tensanpham;
            string masanpham = command.ExecuteScalar().ToString();
            return masanpham;
        }
        public string LayTenSanPham(string masanpham)
        {
            connection.OpenConnection();
            SqlCommand command = new SqlCommand("SELECT dbo.fun_TenSanPham(@maSP)", connection.GetConnection());
            command.Parameters.Add("@maSP", SqlDbType.NVarChar).Value = masanpham;
            string tensanpham = command.ExecuteScalar().ToString();
            return tensanpham;
        }
        public DataTable layThongTinNCC(string maSanPham)
        {
            connection.OpenConnection();
            SqlCommand command = new SqlCommand("SELECT * FROM dbo.fun_ThongTinNCCSP(@maSP)", connection.GetConnection());
            command.Parameters.Add("@maSP", SqlDbType.NVarChar).Value = maSanPham;
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }
    }
}
