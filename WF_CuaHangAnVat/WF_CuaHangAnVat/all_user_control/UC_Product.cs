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
    public partial class UC_Product: UserControl
    {
        DataTable dt = null;
        SanPhamBLL sanPhamBLL;
        LoaiSanPhamBLL loaiSanPhamBLL;
        bool them;
        public UC_Product()
        {
            InitializeComponent();
            sanPhamBLL = new SanPhamBLL();
            loaiSanPhamBLL = new LoaiSanPhamBLL();
            LoadListSP();
        }
        private void LoadListSP()
        {
            //đẩy dữ liệu lên trên datagridview 
            dt = new DataTable();
            dt.Clear();
            dt = sanPhamBLL.getListSanPham();
            dvgSanPham.DataSource = dt;

            //đẩy dữ liệu lên txt_TenLoaiSanPham
            dt = new DataTable();
            dt.Clear();
            dt = loaiSanPhamBLL.GetList();
            txt_TenLoaiSanPham.DataSource = dt;
            txt_TenLoaiSanPham.DisplayMember = "tenLoaiSanPham";
            txt_TenLoaiSanPham.ValueMember = "maLoaiSanPham";

            //đóng các thanh nhập thông tin 
            txt_MaSanPham.Enabled = false;
            txt_TenSanPham.Enabled = false;
            txt_Giaban.Enabled = false;
            txt_HanSuDung.Enabled = false;
            txt_MoTa.Enabled = false;
            txt_SoLuong.Enabled = false;
            txt_TenLoaiSanPham.Enabled = false;

            // cho thao tác trên các nút 
            btn_Reload.Enabled = true;
            btn_Them.Enabled = true;
            btn_Sua.Enabled = true;
            btn_Xoa.Enabled = true;

            //không cho thao tác trên các nút 
            btn_HuyBo.Enabled = false;
            btn_Luu.Enabled = false;

            dvgSanPham_CellClick(null, null);
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            
        }

        private void dvgSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dvgSanPham.CurrentCell != null)
            {
                int r = dvgSanPham.CurrentCell.RowIndex;
                txt_MaSanPham.Text = dvgSanPham.Rows[r].Cells[0].Value.ToString();
                txt_TenSanPham.Text = dvgSanPham.Rows[r].Cells[1].Value.ToString();
                txt_Giaban.Text = dvgSanPham.Rows[r].Cells[2].Value.ToString();
                txt_HanSuDung.Text = dvgSanPham.Rows[r].Cells[3].Value.ToString();
                txt_MoTa.Text = dvgSanPham.Rows[r].Cells[4].Value.ToString();
                txt_SoLuong.Text = dvgSanPham.Rows[r].Cells[5].Value.ToString();
                //txt_TenLoaiSanPham.Text = dvgSanPham.Rows[r].Cells[6].Value.ToString();
                string maLSP = dvgSanPham.Rows[r].Cells[6].Value.ToString();
                txt_TenLoaiSanPham.Text = loaiSanPhamBLL.tenLSP(maLSP);

                try
                {
                    DataTable dt = new DataTable();
                    dt.Clear();
                    dt = sanPhamBLL.LayThongTinNCC(txt_MaSanPham.Text.ToString());

                    lbl_tenNSX.Text = dt.Rows[0]["tenNCC"].ToString();
                    lbl_diachi.Text = dt.Rows[0]["diaChi"].ToString();
                    string lienHe = dt.Rows[0]["SDT"].ToString() + " - " + dt.Rows[0]["email"].ToString();
                    lbl_lienHe.Text = lienHe;
                    lbl_soLuong.Text = dt.Rows[0]["soLuongSP"].ToString();
                }catch(Exception ex){
                    MessageBox.Show(ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lbl_diachi.Text = "";
                    lbl_lienHe.Text = "";
                    lbl_soLuong.Text = "";
                    lbl_tenNSX.Text = "";
                }
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
            if (them)
            {
                try
                {
                    string maLSP = loaiSanPhamBLL.maLSP(txt_TenLoaiSanPham.Text.ToString());
                    bool f = sanPhamBLL.themSanPham(txt_MaSanPham.Text.ToString(), txt_TenSanPham.Text.ToString(), double.Parse(txt_Giaban.Text.ToString()), DateTime.Parse(txt_HanSuDung.Text.ToString()), txt_MoTa.Text.ToString(), int.Parse(txt_SoLuong.Text.ToString()), maLSP);

                    LoadListSP();
                    MessageBox.Show("Sản Phẩm Đã Được Nhập Vào Cửa Hàng");
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
                    string maLSP = loaiSanPhamBLL.maLSP(txt_TenLoaiSanPham.Text.ToString());

                    if (double.TryParse(txt_Giaban.Text.ToString(), out double giaBan) &&
                        DateTime.TryParse(txt_HanSuDung.Text.ToString(), out DateTime hanSuDung) &&
                        int.TryParse(txt_SoLuong.Text.ToString(), out int soLuong))
                    {
                        bool f = sanPhamBLL.CapNhatSanPham(txt_MaSanPham.Text.ToString(), txt_TenSanPham.Text.ToString(), giaBan, hanSuDung, txt_MoTa.Text.ToString(), soLuong, maLSP);
                        LoadListSP();
                        MessageBox.Show("Sản Phẩm Đã Được Chỉnh Sữa Thông Tin");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_HuyBo_Click(object sender, EventArgs e)
        {
            
        }

        private void UC_Product_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btn_Reload_Click_1(object sender, EventArgs e)
        {
            LoadListSP();
        }

        private void btn_Them_Click_1(object sender, EventArgs e)
        {
            them = true;

            txt_MaSanPham.ResetText();
            txt_TenSanPham.ResetText();
            txt_Giaban.ResetText();
            txt_HanSuDung.ResetText();
            txt_MoTa.ResetText();
            txt_SoLuong.ResetText();
            txt_TenLoaiSanPham.ResetText();


            txt_MaSanPham.Enabled = true;
            txt_TenSanPham.Enabled = true;
            txt_Giaban.Enabled = true;
            txt_HanSuDung.Enabled = true;
            txt_MoTa.Enabled = true;
            txt_SoLuong.Enabled = true;
            txt_TenLoaiSanPham.Enabled = true;

            //không cho thao tác
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_Reload.Enabled = false;

            //cho thao tác
            btn_Luu.Enabled = true;
            btn_HuyBo.Enabled = true;


            //đưa con trỏ về đây
            txt_MaSanPham.Focus();
        }

        private void btn_Sua_Click_1(object sender, EventArgs e)
        {
            them = false;

            dvgSanPham_CellClick(null, null);

            txt_MaSanPham.Enabled = false;
            txt_TenSanPham.Enabled = true;
            txt_Giaban.Enabled = true;
            txt_HanSuDung.Enabled = true;
            txt_MoTa.Enabled = true;
            txt_SoLuong.Enabled = true;
            txt_TenLoaiSanPham.Enabled = true;

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
                    string maLSP = loaiSanPhamBLL.maLSP(txt_TenLoaiSanPham.Text.ToString());
                    bool f = sanPhamBLL.themSanPham(txt_MaSanPham.Text.ToString(), txt_TenSanPham.Text.ToString(), double.Parse(txt_Giaban.Text.ToString()), DateTime.Parse(txt_HanSuDung.Text.ToString()), txt_MoTa.Text.ToString(), int.Parse(txt_SoLuong.Text.ToString()), maLSP);
                    MessageBox.Show("Sản Phẩm Đã Được Nhập Vào Cửa Hàng");
                    Form1 lienKet = new Form1(txt_MaSanPham.Text.ToString());
                    lienKet.ShowDialog();
                    LoadListSP();

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
                    string maLSP = loaiSanPhamBLL.maLSP(txt_TenLoaiSanPham.Text.ToString());

                    if (double.TryParse(txt_Giaban.Text.ToString(), out double giaBan) &&
                        DateTime.TryParse(txt_HanSuDung.Text.ToString(), out DateTime hanSuDung) &&
                        int.TryParse(txt_SoLuong.Text.ToString(), out int soLuong))
                    {
                        bool f = sanPhamBLL.CapNhatSanPham(txt_MaSanPham.Text.ToString(), txt_TenSanPham.Text.ToString(), giaBan, hanSuDung, txt_MoTa.Text.ToString(), soLuong, maLSP);
                        LoadListSP();
                        MessageBox.Show("Sản Phẩm Đã Được Chỉnh Sữa Thông Tin");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btn_Xoa_Click_1(object sender, EventArgs e)
        {
            string tenSanPham = txt_TenSanPham.Text.ToString();
            try
            {

                DialogResult result = MessageBox.Show("Bạn Muốn Ngừng Bán Sản Phẩm Này?", "Xác nhận Ngừng",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bool f = sanPhamBLL.XoaSanPham(tenSanPham);

                    if (f) // Kiểm tra xem xóa có thành công không
                    {
                        MessageBox.Show("Loại Bỏ Thành Công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadListSP(); // Tải lại danh sách sau khi xóa
                    }
                    else
                    {
                        MessageBox.Show("Loại Bỏ Thất Bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_HuyBo_Click_1(object sender, EventArgs e)
        {
            txt_MaSanPham.ResetText();
            txt_TenSanPham.ResetText();
            txt_Giaban.ResetText();
            txt_HanSuDung.ResetText();
            txt_MoTa.ResetText();
            txt_SoLuong.ResetText();
            txt_TenLoaiSanPham.ResetText();

            txt_MaSanPham.Enabled = false;
            txt_TenSanPham.Enabled = false;
            txt_Giaban.Enabled = false;
            txt_HanSuDung.Enabled = false;
            txt_MoTa.Enabled = false;
            txt_SoLuong.Enabled = false;
            txt_TenLoaiSanPham.Enabled = false;

            // cho thao tác trên các nút 
            btn_Reload.Enabled = true;
            btn_Them.Enabled = true;
            btn_Sua.Enabled = true;
            btn_Xoa.Enabled = true;

            //không cho thao tác trên các nút 
            btn_HuyBo.Enabled = false;
            btn_Luu.Enabled = false;

            dvgSanPham_CellClick(null, null);
        }
    }
}
