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
    public partial class DangNhap: Form
    {
        //DbConnectionBLL dbConnectionBLL;
        private ErrorProvider errorProvider1 = new ErrorProvider();
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {

            try
            {
                DbConnectionBLL.CapNhatThongTinDangNhap(txt_Username.Text, txt_Password.Text);
                label_Error.Visible = false;
                Dashboard db = new Dashboard();
                this.Hide();
                db.ShowDialog();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Username.ResetText();
                txt_Password.ResetText();
            }
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã Ngừng Chương Trình!", "Thông báo", MessageBoxButtons.OK);
            Application.Exit();
        }


        private void txt_Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Ngăn tiếng beep mặc định

                if (string.IsNullOrWhiteSpace(txt_Username.Text))
                {
                    txt_Username.ForeColor = Color.Red;
                    txt_Username.Text = "Tên đăng nhập không được để trống!!!";
                    txt_Username.Tag = "error"; // Đánh dấu trạng thái lỗi
                    txt_Username.SelectAll(); // Chọn toàn bộ nội dung lỗi
                }
                txt_Password.Focus(); // Vẫn chuyển xuống ô mật khẩu
            }
        }

        private void txt_Username_Enter(object sender, EventArgs e)
        {
            if (txt_Username.Tag != null && txt_Username.Tag.ToString() == "error")
            {
                txt_Username.ForeColor = Color.Black;
                txt_Username.Text = "";
                txt_Username.Tag = null; // Xóa trạng thái lỗi
            }
        }

        private void txt_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                if (string.IsNullOrWhiteSpace(txt_Password.Text))
                {
                    errorProvider1.SetError(txt_Password, "Mật khẩu không được để trống!");
                    txt_Password.Focus(); // Giữ lại con trỏ ở textbox
                }
                else
                {
                    errorProvider1.SetError(txt_Password, ""); // Xóa lỗi nếu có
                    btn_Login_Click(sender, e); // Gọi hàm đăng nhập
                }
            }
        }

        private void txt_Password_Enter(object sender, EventArgs e)
        {
            if (txt_Password.Tag != null && txt_Password.Tag.ToString() == "error")
            {
                txt_Password.ForeColor = Color.Black;
                txt_Password.Text = "";
                txt_Password.Tag = null;
                txt_Password.UseSystemPasswordChar = true; // Bật lại dấu ● cho mật khẩu
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
