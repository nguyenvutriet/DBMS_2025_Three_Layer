using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DoanhThuDAL
    {
        DBConnection connection;

        public DoanhThuDAL()
        {
            connection = new DBConnection();
        }
        public DataTable GetDoanhThu(DateTime tuNgay, DateTime denNgay)
        {
            DataTable table = new DataTable();
            connection.OpenConnection();
            SqlCommand command = new SqlCommand("SELECT * FROM dbo.fun_DoanhThuTheoSP(@tuNgay, @denNgay)", connection.GetConnection());
            command.Parameters.Add("@tuNgay", SqlDbType.DateTime).Value = tuNgay;
            command.Parameters.Add("@denNgay", SqlDbType.DateTime).Value = denNgay;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }
        public string TongTienDT(DateTime tuNgay, DateTime denNgay)
        {
            DataTable table = new DataTable();
            connection.OpenConnection();
            SqlCommand command = new SqlCommand("SELECT dbo.fun_tongTienDT(@tuNgay, @denNgay) AS TongTien", connection.GetConnection());
            command.Parameters.Add("@tuNgay", SqlDbType.DateTime).Value = tuNgay;
            command.Parameters.Add("@denNgay", SqlDbType.DateTime).Value = denNgay;
            string tongTien = command.ExecuteScalar().ToString();
            return tongTien;

        }

    }
}
