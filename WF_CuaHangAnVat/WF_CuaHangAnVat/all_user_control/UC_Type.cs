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
    public partial class UC_Type: UserControl
    {
        DataTable dt = null;
        LoaiSanPhamBLL loaiSanPhamBLL;
        KhuyenMaiBLL khuyenMaiBLL;
        bool them = false;
        public UC_Type()
        {
            InitializeComponent();
            loaiSanPhamBLL = new LoaiSanPhamBLL();
            khuyenMaiBLL = new KhuyenMaiBLL();
            LoadListLoaiSP();
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            
        }
        private void LoadListLoaiSP()
        {
            //đẩy dữ liệu lên trên datagridview 
            dt = new DataTable();
            dt.Clear();
            dt = loaiSanPhamBLL.GetList();
            dgvLSP.DataSource = dt;

            //đưa dữ liệu lên combobox
            dt = new DataTable();
            dt.Clear();
            dt = khuyenMaiBLL.GetList();
            cbx_ChuongTrinhKM.DataSource = dt;
            cbx_ChuongTrinhKM.DisplayMember = "tenChuongTrinh";
            cbx_ChuongTrinhKM.ValueMember = "maKM";

            //đóng các thanh nhập thông tin 
            txt_maLoaiSP.Enabled = false;
            txt_TenloaiSP.Enabled = false;
            cbx_ChuongTrinhKM.Enabled = false;


            // cho thao tác trên các nút 
            btn_Reload.Enabled = true;
            btn_Them.Enabled = true;
            btn_Sua.Enabled = true;
            btn_Xoa.Enabled = true;

            //không cho thao tác trên các nút 
            btn_HuyBo.Enabled = false;
            btn_Luu.Enabled = false;

            dgvLSP_CellClick(null, null);
        }

        private void dgvLSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvLSP.CurrentCell != null)
            {
                int i = dgvLSP.CurrentCell.RowIndex;
                txt_maLoaiSP.Text = dgvLSP.Rows[i].Cells[0].Value.ToString();
                txt_TenloaiSP.Text = dgvLSP.Rows[i].Cells[1].Value.ToString();

                string maKM = dgvLSP.Rows[i].Cells[2].Value.ToString();
                string tenChuongTrinh = khuyenMaiBLL.LayTenChuongTrinh(maKM);
                cbx_ChuongTrinhKM.Text = tenChuongTrinh;
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            
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

        private void UC_Type_Load(object sender, EventArgs e)
        {

        }

        private void btn_Reload_Click_1(object sender, EventArgs e)
        {
            LoadListLoaiSP();
        }

        private void btn_Them_Click_1(object sender, EventArgs e)
        {
            them = true;

            txt_maLoaiSP.ResetText();
            txt_TenloaiSP.ResetText();
            cbx_ChuongTrinhKM.ResetText();

            txt_maLoaiSP.Enabled = true;
            txt_TenloaiSP.Enabled = true;
            cbx_ChuongTrinhKM.Enabled = true;

            //không cho thao tác
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_Reload.Enabled = false;

            //cho thao tác
            btn_Luu.Enabled = true;
            btn_HuyBo.Enabled = true;


            //đưa con trỏ về đây
            txt_maLoaiSP.Focus();
        }

        private void btn_Sua_Click_1(object sender, EventArgs e)
        {
            them = false;

            dgvLSP_CellClick(null, null);

            txt_maLoaiSP.Enabled = false;
            txt_TenloaiSP.Enabled = true;
            cbx_ChuongTrinhKM.Enabled = true;

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
                    string tenChuongTrinh = cbx_ChuongTrinhKM.Text.ToString();
                    string maKM = khuyenMaiBLL.LayMaKM(tenChuongTrinh);
                    bool f = loaiSanPhamBLL.ThemLSP(txt_maLoaiSP.Text.ToString(), txt_TenloaiSP.Text.ToString(), maKM);
                    if (f)
                    {
                        MessageBox.Show("Cửa Hàng Có Thêm Loại Sản Phẩm Mới");
                        LoadListLoaiSP();
                    }
                    else
                    {
                        MessageBox.Show("Loại Sản Phẩm Không Hợp Lệ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hệ Thống Đang Lỗi\n" + ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                try
                {
                    string tenChuongTrinh = cbx_ChuongTrinhKM.Text.ToString();
                    string maKM = khuyenMaiBLL.LayMaKM(tenChuongTrinh);
                    bool f = loaiSanPhamBLL.SuaLSP(txt_maLoaiSP.Text.ToString(), txt_TenloaiSP.Text.ToString(), maKM);
                    if (f)
                    {
                        MessageBox.Show("Đã Cập Nhật Thông Tin");
                        LoadListLoaiSP();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi không sữa được", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hệ Thống Đang Lỗi\n" + ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btn_Xoa_Click_1(object sender, EventArgs e)
        {
            try
            {

                DialogResult result = MessageBox.Show("Loại Sản Phẩm Đã Được Loại Bỏ", "Xác nhận Loại Bỏ",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bool f = loaiSanPhamBLL.XoaLSP(txt_TenloaiSP.Text.ToString());

                    if (f) // Kiểm tra xem xóa có thành công không
                    {
                        MessageBox.Show("Loại Bỏ Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadListLoaiSP(); // Tải lại danh sách sau khi xóa
                    }
                    else
                    {
                        MessageBox.Show("Loại Bỏ Thất Bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hệ Thống Đang Lỗi\n" + ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_HuyBo_Click_1(object sender, EventArgs e)
        {
            txt_maLoaiSP.ResetText();
            txt_TenloaiSP.ResetText();
            cbx_ChuongTrinhKM.ResetText();

            txt_maLoaiSP.Enabled = false;
            txt_TenloaiSP.Enabled = false;
            cbx_ChuongTrinhKM.Enabled = false;

            // cho thao tác trên các nút 
            btn_Reload.Enabled = true;
            btn_Them.Enabled = true;
            btn_Sua.Enabled = true;
            btn_Xoa.Enabled = true;

            //không cho thao tác trên các nút 
            btn_HuyBo.Enabled = false;
            btn_Luu.Enabled = false;

            dgvLSP_CellClick(null, null);
        }
    }
}
