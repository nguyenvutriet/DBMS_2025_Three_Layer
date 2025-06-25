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
    public partial class UC_Discount: UserControl
    {
        DataTable dt = null;
        KhuyenMaiBLL khuyenMaiBLL;
        bool them;
        public UC_Discount()
        {
            InitializeComponent();
            khuyenMaiBLL = new KhuyenMaiBLL();
            LoadListKM();
        }
        private void LoadListKM()
        {
            //đẩy dữ liệu lên trên datagridview 
            //khuyenMaiBLL = new KhuyenMaiBLL();
            dt = new DataTable();
            dt.Clear();
            dt = khuyenMaiBLL.GetList();
            dgvKM.DataSource = dt;

            //đóng các thanh nhập thông tin 
            txt_MaKhuyenMai.Enabled = false;
            txt_TenChuongTrinh.Enabled = false;
            txt_NgayBatDau.Enabled = false;
            txt_NgayKetThuc.Enabled = false;

            // cho thao tác trên các nút 
            btn_Reload.Enabled = true;
            btn_Them.Enabled = true;
            btn_Sua.Enabled = true;
            btn_Xoa.Enabled = true;

            //không cho thao tác trên các nút 
            btn_HuyBo.Enabled = false;
            btn_Luu.Enabled = false;

            dgvKM_CellClick(null, null); // Gọi sự kiện CellClick để hiển thị dữ liệu lên các textbox
        }


        private void btn_Reload_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvKM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvKM.CurrentCell != null)
            {
                int r = dgvKM.CurrentCell.RowIndex;
                txt_MaKhuyenMai.Text = dgvKM.Rows[r].Cells[0].Value.ToString();
                txt_TenChuongTrinh.Text = dgvKM.Rows[r].Cells[1].Value.ToString();
                txt_NgayBatDau.Text = dgvKM.Rows[r].Cells[2].Value.ToString();
                txt_NgayKetThuc.Text = dgvKM.Rows[r].Cells[3].Value.ToString();
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            
        }
            
        

        private void btn_HuyBo_Click(object sender, EventArgs e)
        {
            
        }

        private void UC_Discount_Load(object sender, EventArgs e)
        {

        }

        private void btn_Reload_Click_1(object sender, EventArgs e)
        {
            LoadListKM();
        }

        private void btn_Them_Click_1(object sender, EventArgs e)
        {
            them = true;

            txt_MaKhuyenMai.ResetText();
            txt_TenChuongTrinh.ResetText();
            txt_NgayBatDau.ResetText();
            txt_NgayKetThuc.ResetText();

            txt_MaKhuyenMai.Enabled = true;
            txt_TenChuongTrinh.Enabled = true;
            txt_NgayBatDau.Enabled = true;
            txt_NgayKetThuc.Enabled = true;

            //không cho thao tác
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_Reload.Enabled = false;

            //cho thao tác
            btn_Luu.Enabled = true;
            btn_HuyBo.Enabled = true;


            //đưa con trỏ về đây
            txt_MaKhuyenMai.Focus();
        }

        private void btn_Sua_Click_1(object sender, EventArgs e)
        {
            them = false;

            dgvKM_CellClick(null, null);

            txt_MaKhuyenMai.Enabled = false;
            txt_TenChuongTrinh.Enabled = true;
            txt_NgayBatDau.Enabled = true;
            txt_NgayKetThuc.Enabled = true;

            //không cho thao tác 
            btn_Them.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_Reload.Enabled = false;

            //cho thao tác
            btn_Luu.Enabled = true;
            btn_HuyBo.Enabled = true;
        }

        private void btn_Luu_Click_1(object sender, EventArgs e)
        {
            if (them)
            {
                try
                {
                    bool f = khuyenMaiBLL.ThemKM(txt_MaKhuyenMai.Text.ToString(), txt_TenChuongTrinh.Text.ToString(), txt_NgayBatDau.Text.ToString(), txt_NgayKetThuc.Text.ToString());
                    LoadListKM();
                    MessageBox.Show("Chương Trình Khuyến Mãi Mới Đã Được Tạo");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                try
                {
                    bool f = khuyenMaiBLL.SuaKM(txt_MaKhuyenMai.Text.ToString(), txt_TenChuongTrinh.Text.ToString(), txt_NgayBatDau.Text.ToString(), txt_NgayKetThuc.Text.ToString());
                    LoadListKM();
                    MessageBox.Show("Đã Cập Nhật Thông Tin");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btn_Xoa_Click_1(object sender, EventArgs e)
        {
            string tenChuongTrinh = txt_TenChuongTrinh.Text.ToString();

            DialogResult result = MessageBox.Show("Chương Trình Khuyến Mãi này Sẽ Được Gỡ Bỏ?", "Xác nhận Gỡ",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    bool f = khuyenMaiBLL.XoaKM(tenChuongTrinh);

                    if (f) // Kiểm tra xem xóa có thành công không
                    {
                        MessageBox.Show("Đã Gỡ Bỏ Thành Công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadListKM(); // Tải lại danh sách sau khi xóa
                    }
                    else
                    {
                        MessageBox.Show("Gỡ Bỏ Thất Bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_HuyBo_Click_1(object sender, EventArgs e)
        {
            txt_MaKhuyenMai.ResetText();
            txt_TenChuongTrinh.ResetText();
            txt_NgayBatDau.ResetText();
            txt_NgayKetThuc.ResetText();

            txt_MaKhuyenMai.Enabled = false;
            txt_TenChuongTrinh.Enabled = false;
            txt_NgayBatDau.Enabled = false;
            txt_NgayKetThuc.Enabled = false;

            // cho thao tác trên các nút 
            btn_Reload.Enabled = true;
            btn_Them.Enabled = true;
            btn_Sua.Enabled = true;
            btn_Xoa.Enabled = true;

            //không cho thao tác trên các nút 
            btn_HuyBo.Enabled = false;
            btn_Luu.Enabled = false;

            dgvKM_CellClick(null, null);
        }
    }
}
