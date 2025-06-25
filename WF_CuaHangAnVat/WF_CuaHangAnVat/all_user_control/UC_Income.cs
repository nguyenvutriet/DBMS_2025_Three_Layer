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
    public partial class UC_Income: UserControl
    {
        DataTable dt = null;
        DoanhThuBLL doanhThuBLL;
        public UC_Income()
        {
            InitializeComponent();
            doanhThuBLL = new DoanhThuBLL();
        }
        private void LoadDataDT()
        {
            try
            {
                dt = new DataTable();
                dt.Clear();
                DateTime tuNgay = DateTime.Parse(dtp_tuNgay.Text.ToString());
                DateTime denNgay = DateTime.Parse(dtp_denNgay.Text.ToString());
                dt = doanhThuBLL.GetDoanhThu(tuNgay, denNgay);
                dgvDoanhThu.DataSource = dt;

                txt_TongTien.Enabled = false;
                string tongTien = doanhThuBLL.TongTienDT(tuNgay, denNgay);
                txt_TongTien.Text = tongTien;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            
        }

        private void UC_Income_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_ThongKe_Click_1(object sender, EventArgs e)
        {
            LoadDataDT();
        }
    }
}
