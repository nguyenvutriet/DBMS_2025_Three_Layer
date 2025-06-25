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
using System.Data.SqlClient;

namespace WF_CuaHangAnVat.all_user_control
{
    public partial class UC_Register: UserControl
    {
        DangKyBLL dangKyBLL;
        DataTable dt = null;
        public UC_Register()
        {
            InitializeComponent();
            dangKyBLL = new DangKyBLL();
            LoadData();
        }
        public void LoadData()
        {
            dt = new DataTable();
            dt.Clear();
            dt = dangKyBLL.LayDanhSach();

            cbx_Tennv.DataSource = dt;
            cbx_Tennv.DisplayMember = "hoTen";
            cbx_Tennv.ValueMember = "hoTen";

            dt = new DataTable();
            dt.Clear();
            dt = dangKyBLL.LayDanhSach();
            cbx_SDT.DataSource = dt;

            cbx_SDT.DisplayMember = "SDT";
            cbx_SDT.ValueMember = "SDT";
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            try
            {
                string hoTen = txt_Name.Text.ToString();
                string SDT = txt_MobileNo.Text.ToString();
                string email = txt_Email.Text.ToString();
                string gioiTinh = rb_Nam.Checked ? "Nam" : "Nữ";
                string vaiTro = "Nhân Viên";
                string tenDangNhap = txt_UserName.Text.ToString();
                string maKhau = txt_Password.Text.ToString();
                bool f = dangKyBLL.LuuThongTin(hoTen, SDT, email, gioiTinh, vaiTro, tenDangNhap, maKhau);
                try
                {
                    if (f == true)
                    {
                        MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Xem_Click(object sender, EventArgs e)
        {
            try
            {
                dt = new DataTable();
                dt.Clear();
                dt = dangKyBLL.XemTK(cbx_Tennv.Text.ToString(), cbx_SDT.Text.ToString());

                lbl_ID.Text = dt.Rows[0]["ID"].ToString();
                txt_Name.Text = dt.Rows[0]["hoTen"].ToString();
                txt_MobileNo.Text = dt.Rows[0]["SDT"].ToString();
                txt_Email.Text = dt.Rows[0]["email"].ToString();
                txt_UserName.Text = dt.Rows[0]["tenDangNhap"].ToString();
                txt_Password.Text = dt.Rows[0]["matKhau"].ToString();
                if (dt.Rows[0]["gioiTinh"].ToString() == "Nam")
                {
                    rb_Nam.Checked = true;
                }
                else
                {
                    rb_Nu.Checked = true;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                dangKyBLL.HuyThongTin(cbx_Tennv.Text.ToString(), cbx_SDT.Text.ToString());
                MessageBox.Show("Hủy thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string hoTen = txt_Name.Text.ToString();
                string SDT = txt_MobileNo.Text.ToString();
                string email = txt_Email.Text.ToString();
                string gioiTinh = rb_Nam.Checked ? "Nam" : "Nữ";
                string vaiTro = "Nhân Viên";
                string tenDangNhap = txt_UserName.Text.ToString();
                string maKhau = txt_Password.Text.ToString();
                bool f = dangKyBLL.LuuThongTin(hoTen, SDT, email, gioiTinh, vaiTro, tenDangNhap, maKhau);
                try
                {
                    if (f == true)
                    {
                        MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Xem_Click_1(object sender, EventArgs e)
        {
            try
            {
                dt = new DataTable();
                dt.Clear();
                dt = dangKyBLL.XemTK(cbx_Tennv.Text.ToString(), cbx_SDT.Text.ToString());
                
                lbl_ID.Text = dt.Rows[0]["ID"].ToString();
                txt_Name.Text = dt.Rows[0]["hoTen"].ToString();
                txt_MobileNo.Text = dt.Rows[0]["SDT"].ToString();
                txt_Email.Text = dt.Rows[0]["email"].ToString();
                txt_UserName.Text = dt.Rows[0]["tenDangNhap"].ToString();
                txt_Password.Text = dt.Rows[0]["matKhau"].ToString();
                if (dt.Rows[0]["gioiTinh"].ToString() == "Nam")
                {
                    rb_Nam.Checked = true;
                }
                else
                {
                    rb_Nu.Checked = true;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Delete_Click_1(object sender, EventArgs e)
        {
            try
            {
                dangKyBLL.HuyThongTin(cbx_Tennv.Text.ToString(), cbx_SDT.Text.ToString());
                MessageBox.Show("Hủy thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UC_Register_Load(object sender, EventArgs e)
        {

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            lbl_ID.Text = "";
            txt_Name.Text = "";
            txt_MobileNo.Text = "";
            txt_Email.Text = "";
            txt_UserName.Text = "";
            txt_Password.Text = "";
            rb_Nam.Checked = false;
            rb_Nu.Checked = false;

        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbx_SDT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
