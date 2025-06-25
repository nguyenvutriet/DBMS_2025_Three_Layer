using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoaiSanPhamDAL
    {
        DBConnection connection = null;
        public LoaiSanPhamDAL()
        {
            connection = new DBConnection();
        }
        public DataTable GetListLSP()
        {
            DataTable table = new DataTable();
            connection.OpenConnection();
            string sql = "proc_ListLoaiSanPham";
            SqlCommand command = new SqlCommand(sql, connection.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);

            return table;
        }
        // Thêm loại sản phẩm
        public bool themLoaiSanPham(string maLoaiSanPham, string tenLoaiSanPham, string maKM)
        {
            connection.OpenConnection();
            SqlCommand command = new SqlCommand("Them_LoaiSanPham", connection.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@maLoaiSanPham", SqlDbType.VarChar).Value = maLoaiSanPham;
            command.Parameters.Add("@tenLoaiSanPham", SqlDbType.NVarChar).Value = tenLoaiSanPham;
            command.Parameters.Add("@maKM", SqlDbType.VarChar).Value = maKM;


            return command.ExecuteNonQuery() > 0;


        }
        //Cập nhật loại sản phẩm 
        public bool suaLoaiSanPham(string maLoaiSanPham, string tenLoaiSanPham, string maKM)
        {
            connection.OpenConnection();
            SqlCommand command = new SqlCommand("Sua_LoaiSanPham", connection.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@maLoaiSanPham", SqlDbType.VarChar).Value = maLoaiSanPham;
            command.Parameters.Add("@tenLoaiSanPham", SqlDbType.NVarChar).Value = tenLoaiSanPham;
            command.Parameters.Add("@maKM", SqlDbType.VarChar).Value = maKM;


            return command.ExecuteNonQuery() > 0;

        }
        // Xóa loại sản phẩm
        public bool xoaLoaiSanPham(string tenLoaiSanPham)
        {
            connection.OpenConnection();
            SqlCommand command = new SqlCommand("proc_XoaLSP", connection.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@tenLoaiSP", SqlDbType.NVarChar).Value = tenLoaiSanPham;
            return command.ExecuteNonQuery() > 0;
        }
        public string TenLoaiSP(string maloaisp)
        {
            connection.OpenConnection();
            SqlCommand command = new SqlCommand("SELECT dbo.fun_TenLoaiSanPham(@maLoaiSP)", connection.GetConnection());
            command.Parameters.Add("@maLoaiSP", SqlDbType.VarChar).Value = maloaisp;
            string tenLSP = command.ExecuteScalar().ToString();
            return tenLSP;
        }
        public string maLSP(string tenlsp)
        {
            connection.OpenConnection();
            SqlCommand command = new SqlCommand("SELECT dbo.fun_maLSP(@tenLSP)", connection.GetConnection());
            command.Parameters.Add("@tenLSP", SqlDbType.NVarChar).Value = tenlsp;
            string malsp = command.ExecuteScalar().ToString();
            return malsp;
        }
    }
}
