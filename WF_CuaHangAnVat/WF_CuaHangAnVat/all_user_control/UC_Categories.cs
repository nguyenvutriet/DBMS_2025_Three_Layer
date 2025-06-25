using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace WF_CuaHangAnVat.all_user_control
{
    public partial class UC_Categories: UserControl
    {
        DanhMucBLL danhMucBLL;
        DataTable dt = null;
        public UC_Categories()
        {
            InitializeComponent();
            danhMucBLL = new DanhMucBLL();
            LoadData();
        }
        private void LoadData()
        {
            dt = new DataTable();
            dt.Clear();
            dt = danhMucBLL.View_SanPham();
            dgv_SP.DataSource = dt;

            dt = new DataTable();
            dt.Clear();
            dt = danhMucBLL.View_NhaCungCap();
            dgv_NCC.DataSource = dt;

            dt = new DataTable();
            dt.Clear();
            dt = danhMucBLL.View_KhuyenMai();
            dgv_SPKM.DataSource = dt;

            dt = new DataTable();
            dt.Clear();
            dt = danhMucBLL.View_DoanhThu();
            dgv_DT.DataSource = dt;

        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            
        }

        private void UC_Categories_Load(object sender, EventArgs e)
        {

        }

        private void tp_DT_Click(object sender, EventArgs e)
        {

        }

        private void btn_Reload_Click_1(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
