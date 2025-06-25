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
    public partial class UC_Provider: UserControl
    {
        NhaCungCapBLL nhaCungCapBLL;
        DataTable dt = null;
        bool them;
        public UC_Provider()
        {
            InitializeComponent();
            nhaCungCapBLL = new NhaCungCapBLL();
            LoadListNCC();
        }
        private void LoadListNCC()
        {
            //đẩy dữ liệu lên trên datagridview 
            //khuyenMaiBLL = new KhuyenMaiBLL();
            dt = new DataTable();
            dt.Clear();
            dt = nhaCungCapBLL.getListNhaCC();
            dgvNhaCungCap.DataSource = dt;

            //đóng các thanh nhập thông tin 
            txt_MaNCC.Enabled = false;
            txt_TenNCC.Enabled = false;
            txt_DiaChi.Enabled = false;
            txt_Email.Enabled = false;
            txt_SDT.Enabled = false;

            // cho thao tác trên các nút 
            btn_Reload.Enabled = true;
            btn_Them.Enabled = true;
            btn_Sua.Enabled = true;
            btn_Xoa.Enabled = true;

            //không cho thao tác trên các nút 
            btn_HuyBo.Enabled = false;
            btn_Luu.Enabled = false;

            dgvNhaCungCap_CellClick(null, null);
        }


        private void btn_Reload_Click(object sender, EventArgs e)
        {
            
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

        private void dgvNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNhaCungCap.CurrentCell != null)
            {
                int r = dgvNhaCungCap.CurrentCell.RowIndex;
                txt_MaNCC.Text = dgvNhaCungCap.Rows[r].Cells[0].Value.ToString();
                txt_TenNCC.Text = dgvNhaCungCap.Rows[r].Cells[1].Value.ToString();
                txt_DiaChi.Text = dgvNhaCungCap.Rows[r].Cells[2].Value.ToString();
                txt_Email.Text = dgvNhaCungCap.Rows[r].Cells[3].Value.ToString();
                txt_SDT.Text = dgvNhaCungCap.Rows[r].Cells[4].Value.ToString();
            }
        }

        private void UC_Provider_Load(object sender, EventArgs e)
        {

        }

        private void btn_Reload_Click_1(object sender, EventArgs e)
        {
            LoadListNCC();
        }

        private void btn_Them_Click_1(object sender, EventArgs e)
        {
            them = true;

            txt_MaNCC.ResetText();
            txt_TenNCC.ResetText();
            txt_DiaChi.ResetText();
            txt_Email.ResetText();
            txt_SDT.ResetText();

            txt_MaNCC.Enabled = true;
            txt_TenNCC.Enabled = true;
            txt_DiaChi.Enabled = true;
            txt_Email.Enabled = true;
            txt_SDT.Enabled = true;

            //không cho thao tác
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_Reload.Enabled = false;

            //cho thao tác
            btn_Luu.Enabled = true;
            btn_HuyBo.Enabled = true;


            //đưa con trỏ về đây
            txt_MaNCC.Focus();
        }

        private void btn_Sua_Click_1(object sender, EventArgs e)
        {
            them = false;

            dgvNhaCungCap_CellClick(null, null);

            txt_MaNCC.Enabled = false;
            txt_TenNCC.Enabled = true;
            txt_DiaChi.Enabled = true;
            txt_Email.Enabled = true;
            txt_SDT.Enabled = true;

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
                    bool f = nhaCungCapBLL.ThemNhaCungCap(txt_MaNCC.Text.ToString(), txt_TenNCC.Text.ToString(), txt_DiaChi.Text.ToString(), txt_Email.Text.ToString(), txt_SDT.Text.ToString());
                    LoadListNCC();
                    MessageBox.Show("Cửa Hàng Đã Hợp Tác Với Một Nhà Cung Cấp Mới");
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
                    bool f = nhaCungCapBLL.ChinhSuaNCC(txt_MaNCC.Text.ToString(), txt_TenNCC.Text.ToString(), txt_DiaChi.Text.ToString(), txt_Email.Text.ToString(), txt_SDT.Text.ToString());
                    LoadListNCC();
                    MessageBox.Show("Cập Nhật Thông Tin Thành Công");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btn_Xoa_Click_1(object sender, EventArgs e)
        {
            string tennhacungcap = txt_TenNCC.Text.ToString();
            try
            {

                DialogResult result = MessageBox.Show("Bạn Muốn Ngừng Hợp Tác Với Nhà Cung Cấp Này?", "Xác nhận Ngừng",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bool f = nhaCungCapBLL.XoaNCC(tennhacungcap);

                    if (f) // Kiểm tra xem xóa có thành công không
                    {
                        MessageBox.Show("Đã Ngừng Hợp Tác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadListNCC(); // Tải lại danh sách sau khi xóa
                    }
                    else
                    {
                        MessageBox.Show("Việc Ngừng Hợp Tác Đang Có Lỗi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_HuyBo_Click_1(object sender, EventArgs e)
        {
            txt_MaNCC.ResetText();
            txt_TenNCC.ResetText();
            txt_DiaChi.ResetText();
            txt_Email.ResetText();
            txt_SDT.ResetText();

            txt_MaNCC.Enabled = false;
            txt_TenNCC.Enabled = false;
            txt_DiaChi.Enabled = false;
            txt_Email.Enabled = false;
            txt_SDT.Enabled = false;

            // cho thao tác trên các nút 
            btn_Reload.Enabled = true;
            btn_Them.Enabled = true;
            btn_Sua.Enabled = true;
            btn_Xoa.Enabled = true;

            //không cho thao tác trên các nút 
            btn_HuyBo.Enabled = false;
            btn_Luu.Enabled = false;

            dgvNhaCungCap_CellClick(null, null);
        }
    }
}
