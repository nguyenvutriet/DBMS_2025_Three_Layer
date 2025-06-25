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
using System.IO;

namespace WF_CuaHangAnVat.all_user_control
{
    public partial class UC_Receipt: UserControl
    {
        HoaDonBLL hoaDonBLL;
        DataTable dt = null;
        bool them;
        public UC_Receipt()
        {
            InitializeComponent();
            hoaDonBLL = new HoaDonBLL();
            LoadListHD();
        }
        private void LoadListHD()
        {
            //đẩy dữ liệu lên trên datagridview 
            //khuyenMaiBLL = new KhuyenMaiBLL();
            dt = new DataTable();
            dt.Clear();
            dt = hoaDonBLL.GetlistHD();
            dgvHoaDon.DataSource = dt;

            //đóng các thanh nhập thông tin 
            txt_MaDon.Enabled = false;
            txt_NgayDat.Enabled = false;
            txt_TongTien.Enabled = false;
            //txt_CTTongCong.Enabled = false;
            //txt_CTMaDon.Enabled = false;
            //txt_CTNgayDat.Enabled = false;

            // cho thao tác trên các nút 
            btn_Reload.Enabled = true;
            btn_Them.Enabled = true;
            btn_Sua.Enabled = true;
            btn_Xoa.Enabled = true;
            btn_HDChiTiet.Enabled = true;
            btn_XuatHD.Enabled = true;

            //không cho thao tác trên các nút 
            btn_HuyBo.Enabled = false;
            btn_Luu.Enabled = false;

            dgvHoaDon_CellClick(null, null);
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
            if (them)
            {
                try
                {
                    string mahoadon = txt_MaDon.Text.ToString();
                    bool f = hoaDonBLL.ThemHD(txt_MaDon.Text.ToString(), DateTime.Parse(txt_NgayDat.Text.ToString()), 0);
                    if (f)
                    {
                        ThongTinCT thongtin = new ThongTinCT(mahoadon, true);
                        thongtin.ShowDialog();
                        MessageBox.Show("Đã Tạo Đơn Thành Công");
                        LoadListHD();
                    }
                    else
                    {
                        MessageBox.Show("Đơn Hàng Này Không Phù Hợp");
                    }
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
                    int r = dgvHoaDon.CurrentCell.RowIndex;
                    string mahoadon = dgvHoaDon.Rows[r].Cells[0].Value.ToString();
                    bool f = hoaDonBLL.SuaHD(txt_MaDon.Text.ToString(), DateTime.Parse(txt_NgayDat.Text.ToString()), 0);
                    ThongTinCT thongtin = new ThongTinCT(mahoadon, false);
                    thongtin.ShowDialog();
                    MessageBox.Show("Đã Cập Nhật Lại Hóa Đơn");
                    LoadListHD();
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

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvHoaDon.CurrentCell != null)
            {
                int r = dgvHoaDon.CurrentCell.RowIndex;
                txt_MaDon.Text = dgvHoaDon.Rows[r].Cells[0].Value.ToString();
                txt_NgayDat.Text = dgvHoaDon.Rows[r].Cells[1].Value.ToString();
                txt_TongTien.Text = dgvHoaDon.Rows[r].Cells[2].Value.ToString();

            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo SaveFileDialog để người dùng chọn nơi lưu file
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                saveDialog.FileName = "HoaDon_" + txt_MaDon.Text + ".pdf";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    string path = saveDialog.FileName;

                    // Tạo document với kích thước A5
                    iTextSharp.text.Document doc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A5, 20, 20, 20, 20);
                    iTextSharp.text.pdf.PdfWriter writer = iTextSharp.text.pdf.PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));
                    doc.Open();

                    // Font Tiếng Việt
                    iTextSharp.text.pdf.BaseFont bf = iTextSharp.text.pdf.BaseFont.CreateFont(@"c:\windows\fonts\arial.ttf",
                        iTextSharp.text.pdf.BaseFont.IDENTITY_H, iTextSharp.text.pdf.BaseFont.EMBEDDED);
                    iTextSharp.text.Font fontHeader = new iTextSharp.text.Font(bf, 16, iTextSharp.text.Font.BOLD);
                    iTextSharp.text.Font fontTitle = new iTextSharp.text.Font(bf, 14, iTextSharp.text.Font.BOLD);
                    iTextSharp.text.Font fontNormal = new iTextSharp.text.Font(bf, 10);
                    iTextSharp.text.Font fontBold = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.BOLD);
                    iTextSharp.text.Font fontSmall = new iTextSharp.text.Font(bf, 8);

                    // Logo
                    try
                    {
                        iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(@"D:\HCMUTE_IT\HK2_2024-2025\Database Management System\siêu thị ăn vặt.png");
                        logo.ScaleAbsolute(70, 70);
                        logo.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                        doc.Add(logo);
                    }
                    catch
                    {
                        // Nếu không tìm thấy logo, bỏ qua
                    }

                    // Tiêu đề cửa hàng
                    iTextSharp.text.Paragraph storeName = new iTextSharp.text.Paragraph("ĂN VẬT MLEM", fontHeader);
                    storeName.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                    doc.Add(storeName);

                    iTextSharp.text.Paragraph storeAddress = new iTextSharp.text.Paragraph("162 Khương Đình, Thanh Xuân, Hà Nội", fontNormal);
                    storeAddress.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                    doc.Add(storeAddress);

                    iTextSharp.text.Paragraph storePhone = new iTextSharp.text.Paragraph("Hotline: 0123 456 789", fontNormal);
                    storePhone.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                    doc.Add(storePhone);

                    // Đường kẻ ngăn cách
                    iTextSharp.text.Paragraph line = new iTextSharp.text.Paragraph("------------------------------------------------------------", fontNormal);
                    line.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                    doc.Add(line);

                    // Tiêu đề hóa đơn
                    iTextSharp.text.Paragraph title = new iTextSharp.text.Paragraph("HÓA ĐƠN THANH TOÁN", fontTitle);
                    title.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                    title.SpacingBefore = 10;
                    title.SpacingAfter = 10;
                    doc.Add(title);

                    // Thông tin đơn hàng
                    iTextSharp.text.pdf.PdfPTable infoTable = new iTextSharp.text.pdf.PdfPTable(2);
                    infoTable.WidthPercentage = 100;
                    infoTable.SetWidths(new float[] { 1, 2 });

                    infoTable.AddCell(new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase("Mã đơn:", fontBold)) { Border = 0 });
                    infoTable.AddCell(new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase(txt_MaDon.Text, fontNormal)) { Border = 0 });

                    infoTable.AddCell(new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase("Ngày đặt:", fontBold)) { Border = 0 });
                    infoTable.AddCell(new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase(txt_NgayDat.Text, fontNormal)) { Border = 0 });

                    doc.Add(infoTable);
                    doc.Add(new iTextSharp.text.Paragraph(" ", fontNormal));

                    // Bảng chi tiết món ăn
                    iTextSharp.text.pdf.PdfPTable table = new iTextSharp.text.pdf.PdfPTable(4);
                    table.WidthPercentage = 100;
                    table.SetWidths(new float[] { 3, 1, 1.5f, 1.5f });

                    // Header của bảng
                    iTextSharp.text.pdf.PdfPCell cell1 = new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase("Tên Món", fontBold));
                    cell1.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    cell1.HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER;
                    cell1.VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE;
                    cell1.Padding = 5;
                    table.AddCell(cell1);

                    iTextSharp.text.pdf.PdfPCell cell2 = new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase("SL", fontBold));
                    cell2.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    cell2.HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER;
                    cell2.VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE;
                    cell2.Padding = 5;
                    table.AddCell(cell2);

                    iTextSharp.text.pdf.PdfPCell cell3 = new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase("Đơn Giá", fontBold));
                    cell3.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    cell3.HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER;
                    cell3.VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE;
                    cell3.Padding = 5;
                    table.AddCell(cell3);

                    iTextSharp.text.pdf.PdfPCell cell4 = new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase("Thành Tiền", fontBold));
                    cell4.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    cell4.HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER;
                    cell4.VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE;
                    cell4.Padding = 5;
                    table.AddCell(cell4);

                    // Lấy dữ liệu từ dgvChiTietHD
                    foreach (DataGridViewRow row in dgvChiTietHD.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            iTextSharp.text.pdf.PdfPCell c1 = new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase(row.Cells[0].Value.ToString(), fontNormal));
                            c1.Padding = 5;
                            table.AddCell(c1);

                            iTextSharp.text.pdf.PdfPCell c2 = new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase(row.Cells[1].Value.ToString(), fontNormal));
                            c2.HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER;
                            c2.Padding = 5;
                            table.AddCell(c2);

                            iTextSharp.text.pdf.PdfPCell c3 = new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase(string.Format("{0:#,##0} VNĐ", decimal.Parse(row.Cells[2].Value.ToString())), fontNormal));
                            c3.HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT;
                            c3.Padding = 5;
                            table.AddCell(c3);

                            iTextSharp.text.pdf.PdfPCell c4 = new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase(string.Format("{0:#,##0} VNĐ", decimal.Parse(row.Cells[3].Value.ToString())), fontNormal));
                            c4.HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT;
                            c4.Padding = 5;
                            table.AddCell(c4);
                        }
                    }

                    doc.Add(table);
                    doc.Add(new iTextSharp.text.Paragraph(" ", fontNormal));

                    // Tổng cộng
                    iTextSharp.text.pdf.PdfPTable totalTable = new iTextSharp.text.pdf.PdfPTable(2);
                    totalTable.WidthPercentage = 100;
                    totalTable.SetWidths(new float[] { 3, 1 });

                    iTextSharp.text.pdf.PdfPCell totalLabelCell = new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase("Tổng cộng:", fontBold));
                    totalLabelCell.Border = 0;
                    totalLabelCell.HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT;
                    totalLabelCell.Padding = 5;
                    totalTable.AddCell(totalLabelCell);

                    iTextSharp.text.pdf.PdfPCell totalValueCell = new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase(string.Format("{0:#,##0} VNĐ", decimal.Parse(txt_CTTongCong.Text)), fontBold));
                    totalValueCell.Border = 0;
                    totalValueCell.HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT;
                    totalValueCell.Padding = 5;
                    totalTable.AddCell(totalValueCell);

                    doc.Add(totalTable);

                    // Chân trang
                    iTextSharp.text.Paragraph footer = new iTextSharp.text.Paragraph("Cảm ơn quý khách đã mua hàng!", fontNormal);
                    footer.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                    footer.SpacingBefore = 20;
                    doc.Add(footer);

                    iTextSharp.text.Paragraph dateFooter = new iTextSharp.text.Paragraph("Ngày in: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), fontSmall);
                    dateFooter.Alignment = iTextSharp.text.Element.ALIGN_RIGHT;
                    dateFooter.SpacingBefore = 20;
                    doc.Add(dateFooter);

                    doc.Close();

                    MessageBox.Show("Xuất hóa đơn thành công!\nĐường dẫn: " + path, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Mở file PDF sau khi xuất
                    System.Diagnostics.Process.Start(path);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_HDChiTiet_Click(object sender, EventArgs e)
        {
            LoadDataHoaDonChiTiet();
            txt_CTMaDon.Text = txt_MaDon.Text.ToString();
            txt_CTNgayDat.Text = txt_NgayDat.Text.ToString();
            txt_CTTongCong.Text = hoaDonBLL.TongTienHoaDonChiTiet(txt_CTMaDon.Text);
        }
        private void LoadDataHoaDonChiTiet()
        {
            string maDon = txt_MaDon.Text.ToString();
            dt = new DataTable();
            dt.Clear();
            dt = hoaDonBLL.ThongTinCTHD(maDon);
            dgvChiTietHD.DataSource = dt;
        }

        private void UC_Receipt_Load(object sender, EventArgs e)
        {

        }

        private void txt_CTNgayDat1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_HDChiTiet_Click_1(object sender, EventArgs e)
        {
            LoadDataHoaDonChiTiet();
            txt_CTMaDon.Text = txt_MaDon.Text.ToString();
            txt_CTNgayDat.Text = txt_NgayDat.Text.ToString();
            txt_CTTongCong.Text = hoaDonBLL.TongTienHoaDonChiTiet(txt_CTMaDon.Text);
        }

        private void btn_XuatHD_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo SaveFileDialog để người dùng chọn nơi lưu file
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                saveDialog.FileName = "HoaDon_" + txt_MaDon.Text + ".pdf";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    string path = saveDialog.FileName;

                    // Tạo document với kích thước A5
                    iTextSharp.text.Document doc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A5, 20, 20, 20, 20);
                    iTextSharp.text.pdf.PdfWriter writer = iTextSharp.text.pdf.PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));
                    doc.Open();

                    // Font Tiếng Việt
                    iTextSharp.text.pdf.BaseFont bf = iTextSharp.text.pdf.BaseFont.CreateFont(@"c:\windows\fonts\arial.ttf",
                        iTextSharp.text.pdf.BaseFont.IDENTITY_H, iTextSharp.text.pdf.BaseFont.EMBEDDED);
                    iTextSharp.text.Font fontHeader = new iTextSharp.text.Font(bf, 16, iTextSharp.text.Font.BOLD);
                    iTextSharp.text.Font fontTitle = new iTextSharp.text.Font(bf, 14, iTextSharp.text.Font.BOLD);
                    iTextSharp.text.Font fontNormal = new iTextSharp.text.Font(bf, 10);
                    iTextSharp.text.Font fontBold = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.BOLD);
                    iTextSharp.text.Font fontSmall = new iTextSharp.text.Font(bf, 8);

                    // Logo
                    try
                    {
                        iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(@"D:\HCMUTE_IT\HK2_2024-2025\Database Management System\siêu thị ăn vặt.png");
                        logo.ScaleAbsolute(70, 70);
                        logo.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                        doc.Add(logo);
                    }
                    catch
                    {
                        // Nếu không tìm thấy logo, bỏ qua
                    }

                    // Tiêu đề cửa hàng
                    iTextSharp.text.Paragraph storeName = new iTextSharp.text.Paragraph("ĂN VẬT MLEM", fontHeader);
                    storeName.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                    doc.Add(storeName);

                    iTextSharp.text.Paragraph storeAddress = new iTextSharp.text.Paragraph("162 Khương Đình, Thanh Xuân, Hà Nội", fontNormal);
                    storeAddress.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                    doc.Add(storeAddress);

                    iTextSharp.text.Paragraph storePhone = new iTextSharp.text.Paragraph("Hotline: 0123 456 789", fontNormal);
                    storePhone.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                    doc.Add(storePhone);

                    // Đường kẻ ngăn cách
                    iTextSharp.text.Paragraph line = new iTextSharp.text.Paragraph("------------------------------------------------------------", fontNormal);
                    line.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                    doc.Add(line);

                    // Tiêu đề hóa đơn
                    iTextSharp.text.Paragraph title = new iTextSharp.text.Paragraph("HÓA ĐƠN THANH TOÁN", fontTitle);
                    title.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                    title.SpacingBefore = 10;
                    title.SpacingAfter = 10;
                    doc.Add(title);

                    // Thông tin đơn hàng
                    iTextSharp.text.pdf.PdfPTable infoTable = new iTextSharp.text.pdf.PdfPTable(2);
                    infoTable.WidthPercentage = 100;
                    infoTable.SetWidths(new float[] { 1, 2 });

                    infoTable.AddCell(new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase("Mã đơn:", fontBold)) { Border = 0 });
                    infoTable.AddCell(new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase(txt_MaDon.Text, fontNormal)) { Border = 0 });

                    infoTable.AddCell(new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase("Ngày đặt:", fontBold)) { Border = 0 });
                    infoTable.AddCell(new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase(txt_NgayDat.Text, fontNormal)) { Border = 0 });

                    doc.Add(infoTable);
                    doc.Add(new iTextSharp.text.Paragraph(" ", fontNormal));

                    // Bảng chi tiết món ăn
                    iTextSharp.text.pdf.PdfPTable table = new iTextSharp.text.pdf.PdfPTable(4);
                    table.WidthPercentage = 100;
                    table.SetWidths(new float[] { 3, 1, 1.5f, 1.5f });

                    // Header của bảng
                    iTextSharp.text.pdf.PdfPCell cell1 = new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase("Tên Món", fontBold));
                    cell1.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    cell1.HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER;
                    cell1.VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE;
                    cell1.Padding = 5;
                    table.AddCell(cell1);

                    iTextSharp.text.pdf.PdfPCell cell2 = new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase("SL", fontBold));
                    cell2.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    cell2.HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER;
                    cell2.VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE;
                    cell2.Padding = 5;
                    table.AddCell(cell2);

                    iTextSharp.text.pdf.PdfPCell cell3 = new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase("Đơn Giá", fontBold));
                    cell3.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    cell3.HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER;
                    cell3.VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE;
                    cell3.Padding = 5;
                    table.AddCell(cell3);

                    iTextSharp.text.pdf.PdfPCell cell4 = new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase("Thành Tiền", fontBold));
                    cell4.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    cell4.HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER;
                    cell4.VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE;
                    cell4.Padding = 5;
                    table.AddCell(cell4);

                    // Lấy dữ liệu từ dgvChiTietHD
                    foreach (DataGridViewRow row in dgvChiTietHD.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            iTextSharp.text.pdf.PdfPCell c1 = new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase(row.Cells[0].Value.ToString(), fontNormal));
                            c1.Padding = 5;
                            table.AddCell(c1);

                            iTextSharp.text.pdf.PdfPCell c2 = new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase(row.Cells[1].Value.ToString(), fontNormal));
                            c2.HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER;
                            c2.Padding = 5;
                            table.AddCell(c2);

                            iTextSharp.text.pdf.PdfPCell c3 = new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase(string.Format("{0:#,##0} VNĐ", decimal.Parse(row.Cells[2].Value.ToString())), fontNormal));
                            c3.HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT;
                            c3.Padding = 5;
                            table.AddCell(c3);

                            iTextSharp.text.pdf.PdfPCell c4 = new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase(string.Format("{0:#,##0} VNĐ", decimal.Parse(row.Cells[3].Value.ToString())), fontNormal));
                            c4.HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT;
                            c4.Padding = 5;
                            table.AddCell(c4);
                        }
                    }

                    doc.Add(table);
                    doc.Add(new iTextSharp.text.Paragraph(" ", fontNormal));

                    // Tổng cộng
                    iTextSharp.text.pdf.PdfPTable totalTable = new iTextSharp.text.pdf.PdfPTable(2);
                    totalTable.WidthPercentage = 100;
                    totalTable.SetWidths(new float[] { 3, 1 });

                    iTextSharp.text.pdf.PdfPCell totalLabelCell = new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase("Tổng cộng:", fontBold));
                    totalLabelCell.Border = 0;
                    totalLabelCell.HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT;
                    totalLabelCell.Padding = 5;
                    totalTable.AddCell(totalLabelCell);

                    iTextSharp.text.pdf.PdfPCell totalValueCell = new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase(string.Format("{0:#,##0} VNĐ", decimal.Parse(txt_CTTongCong.Text)), fontBold));
                    totalValueCell.Border = 0;
                    totalValueCell.HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT;
                    totalValueCell.Padding = 5;
                    totalTable.AddCell(totalValueCell);

                    doc.Add(totalTable);

                    // Chân trang
                    iTextSharp.text.Paragraph footer = new iTextSharp.text.Paragraph("Cảm ơn quý khách đã mua hàng!", fontNormal);
                    footer.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                    footer.SpacingBefore = 20;
                    doc.Add(footer);

                    iTextSharp.text.Paragraph dateFooter = new iTextSharp.text.Paragraph("Ngày in: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), fontSmall);
                    dateFooter.Alignment = iTextSharp.text.Element.ALIGN_RIGHT;
                    dateFooter.SpacingBefore = 20;
                    doc.Add(dateFooter);

                    doc.Close();

                    MessageBox.Show("Xuất hóa đơn thành công!\nĐường dẫn: " + path, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Mở file PDF sau khi xuất
                    System.Diagnostics.Process.Start(path);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Reload_Click_1(object sender, EventArgs e)
        {
            LoadListHD();
        }

        private void btn_Them_Click_1(object sender, EventArgs e)
        {
            them = true;

            txt_TongTien.ResetText();

            txt_MaDon.Enabled = true;
            txt_NgayDat.Enabled = true;
            txt_TongTien.Enabled = false;

            txt_MaDon.ResetText();
            txt_NgayDat.ResetText();
            txt_TongTien.ResetText();

            //không cho thao tác
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_Reload.Enabled = false;
            btn_HDChiTiet.Enabled = false;
            btn_XuatHD.Enabled = false;


            //cho thao tác
            btn_Luu.Enabled = true;
            btn_HuyBo.Enabled = true;


            //đưa con trỏ về đây
            txt_MaDon.Focus();
        }

        private void btn_Sua_Click_1(object sender, EventArgs e)
        {
            them = false;

            dgvHoaDon_CellClick(null, null);

            //txt_NgayDat.ResetText();
            txt_TongTien.ResetText();


            txt_MaDon.Enabled = false;
            txt_NgayDat.Enabled = true;
            txt_TongTien.Enabled = false;

            //không cho thao tác 
            btn_Them.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_Reload.Enabled = false;
            btn_HDChiTiet.Enabled = false;

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
                    string mahoadon = txt_MaDon.Text.ToString();
                    bool f = hoaDonBLL.ThemHD(txt_MaDon.Text.ToString(), DateTime.Parse(txt_NgayDat.Text.ToString()), 0);
                    if (f)
                    {
                        ThongTinCT thongtin = new ThongTinCT(mahoadon, true);
                        thongtin.ShowDialog();
                        MessageBox.Show("Đã Tạo Đơn Thành Công");
                        LoadListHD();
                    }
                    else
                    {
                        MessageBox.Show("Đơn Hàng Này Không Phù Hợp");
                    }
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
                    int r = dgvHoaDon.CurrentCell.RowIndex;
                    string mahoadon = dgvHoaDon.Rows[r].Cells[0].Value.ToString();
                    bool f = hoaDonBLL.SuaHD(txt_MaDon.Text.ToString(), DateTime.Parse(txt_NgayDat.Text.ToString()), 0);
                    ThongTinCT thongtin = new ThongTinCT(mahoadon, false);
                    thongtin.ShowDialog();
                    MessageBox.Show("Đã Cập Nhật Lại Hóa Đơn");
                    LoadListHD();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btn_Xoa_Click_1(object sender, EventArgs e)
        {
            string mahoadon = txt_MaDon.Text.ToString();
            try
            {

                DialogResult result = MessageBox.Show("Bạn Muốn Xóa Đơn Này", "Xác nhận xóa",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bool f = hoaDonBLL.XoaHD(mahoadon);

                    if (f) // Kiểm tra xem xóa có thành công không
                    {
                        MessageBox.Show("Đơn Hàng Đã Được Xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadListHD(); // Tải lại danh sách sau khi xóa
                    }
                    else
                    {
                        MessageBox.Show("Không Thể Xóa Đơn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            txt_MaDon.ResetText();
            txt_NgayDat.ResetText();
            txt_TongTien.ResetText();

            txt_MaDon.Enabled = false;
            txt_NgayDat.Enabled = false;
            txt_TongTien.Enabled = false;

            // cho thao tác trên các nút 
            btn_Reload.Enabled = true;
            btn_Them.Enabled = true;
            btn_Sua.Enabled = true;
            btn_Xoa.Enabled = true;
            btn_HDChiTiet.Enabled = true;

            //không cho thao tác trên các nút 
            btn_HuyBo.Enabled = false;
            btn_Luu.Enabled = false;

            dgvHoaDon_CellClick(null, null);
        }
    }
}
