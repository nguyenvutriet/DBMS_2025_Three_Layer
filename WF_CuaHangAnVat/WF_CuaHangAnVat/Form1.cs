using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_CuaHangAnVat
{
    public partial class Form1 : Form
    {
        NhaCungCapBLL nhaCungCapBLL;
        DataTable dt = null;
        //string maSP;
        public Form1(string masp)
        {
            InitializeComponent();
            nhaCungCapBLL = new NhaCungCapBLL();
            this.txt_MaSP.Text = masp;
            LoadData();
        }
        private void LoadData()
        {
            dt = new DataTable();
            dt.Clear();
            dt = nhaCungCapBLL.getListNhaCC();
            
            cbx_NCC.DataSource = dt;
            cbx_NCC.DisplayMember = "tenNCC";
            cbx_NCC.ValueMember = "maNCC";

            txt_MaSP.Enabled = false;

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_LienKet_Click(object sender, EventArgs e)
        {
            try
            {
                string masanpham = txt_MaSP.Text.ToString();
                string manhacungcap = cbx_NCC.SelectedValue.ToString();
                int soluong = int.Parse(txt_SoLuong.Text.ToString());
                if(soluong == 25)
                {
                    MessageBox.Show("Đây là số nguyên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                MessageBox.Show(masanpham + "--" + manhacungcap + "--" + soluong);
                bool f = nhaCungCapBLL.LienKet(masanpham, manhacungcap, soluong);
                if (f)
                {

                    MessageBox.Show("Liên kết thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Liên kết không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Ngat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
