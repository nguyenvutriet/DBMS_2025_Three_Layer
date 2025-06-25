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
    public partial class ThongTinCT: Form
    {
        SanPhamBLL phamBLL;
        HoaDonChiTietBLL hoaDonChiTietBLL;
        DataTable dt = null;
        private string madon;
        private bool them;
        public ThongTinCT(string madon, bool them)
        {
            InitializeComponent();
            this.madon = madon;
            hoaDonChiTietBLL = new HoaDonChiTietBLL();
            phamBLL = new SanPhamBLL();
            this.them = them;
        }
        private void LoadDataHD()
        {
            txt_MaDon.Text = this.madon;
            txt_MaDon.Enabled = false;

            txt_SoLuong.Enabled = true;
            cbx_TenSanPham.Enabled = true;

            txt_SoLuong.ResetText();
            cbx_TenSanPham.ResetText();

            dt = new DataTable();
            dt.Clear();
            dt = phamBLL.getListSanPham();
            cbx_TenSanPham.DataSource = dt;
            cbx_TenSanPham.DisplayMember = "tenSanPham";
            cbx_TenSanPham.ValueMember = "maSP";


            dt = new DataTable();
            dt.Clear();
            dt = hoaDonChiTietBLL.LayThongTinCTHD(this.madon);
            dgvChiTiet.DataSource = dt;
        }

        private void btn_BoSung_Click(object sender, EventArgs e)
        {
            if (!them)
            {
                try
                {
                    string masp = phamBLL.Laymasanpham(cbx_TenSanPham.Text.ToString());

                    bool f = hoaDonChiTietBLL.ThemHoaDonChiTiet(masp, this.madon, int.Parse(txt_SoLuong.Text.ToString()), 0);
                    if (f)
                    {
                        MessageBox.Show("Đã Thêm Món");
                        LoadDataHD();
                    }
                    else
                    {
                        MessageBox.Show("Không Thêm Được Món");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bạn Đang Tạo Đơn Mới Không Thể Chọn Chức Năng Này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ThongTinCT_Load(object sender, EventArgs e)
        {
            LoadDataHD();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string madon = txt_MaDon.Text.ToString();
            string masp = phamBLL.Laymasanpham(cbx_TenSanPham.Text.ToString());
            try
            {

                DialogResult result = MessageBox.Show("Bạn Có Chắc Muốn Hủy Món?", "Xác nhận Hủy",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        bool f = hoaDonChiTietBLL.XoaHDChiTiet(masp, madon);

                        if (f) // Kiểm tra xem xóa có thành công không
                        {
                            MessageBox.Show("Món Ăn Này Đã Được Hủy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDataHD(); // Tải lại danh sách sau khi xóa
                        }
                        else
                        {
                            MessageBox.Show("Hủy Món Thất Bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Xong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (them)
            {
                try
                {
                    string masp = phamBLL.Laymasanpham(cbx_TenSanPham.Text.ToString());

                    bool f = hoaDonChiTietBLL.ThemHoaDonChiTiet(masp, this.madon, int.Parse(txt_SoLuong.Text.ToString()), 0);
                    if (f)
                    {
                        MessageBox.Show("Lên Món Thành Công");
                        LoadDataHD();
                    }
                    else
                    {
                        MessageBox.Show("Lên Món Thất Bại");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    string maspnew = phamBLL.Laymasanpham(cbx_TenSanPham.Text.ToString());
                    //MessageBox.Show(masp);
                    int r = dgvChiTiet.CurrentCell.RowIndex;
                    string maspcu = dgvChiTiet.Rows[r].Cells[0].Value.ToString();
                    try
                    {
                        bool f = hoaDonChiTietBLL.CapNhatHDChiTiet(maspcu, this.madon, int.Parse(txt_SoLuong.Text.ToString()), 0, maspnew);
                        if (f)
                        {
                            MessageBox.Show("Đổi Món Thành Công");
                            LoadDataHD();
                        }
                        else
                        {
                            MessageBox.Show("Đổi Món Thất Bại");
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvChiTiet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvChiTiet.CurrentCell.RowIndex;
            txt_SoLuong.Text = dgvChiTiet.Rows[i].Cells[2].Value.ToString();

            string masp = dgvChiTiet.Rows[i].Cells[0].Value.ToString();
            string tensp = phamBLL.LayTenSanPham(masp);
            cbx_TenSanPham.Text = tensp;
        }

        private void btn_Giam_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Tang_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }
    }
}
