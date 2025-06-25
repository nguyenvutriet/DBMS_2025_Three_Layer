namespace WF_CuaHangAnVat.all_user_control
{
    partial class UC_Income
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.l = new System.Windows.Forms.Label();
            this.dgvDoanhThu = new System.Windows.Forms.DataGridView();
            this.tenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_TongTien = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_tuNgay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_denNgay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.btn_ThongKe = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).BeginInit();
            this.guna2ShadowPanel1.SuspendLayout();
            this.guna2ShadowPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l.ForeColor = System.Drawing.Color.Black;
            this.l.Location = new System.Drawing.Point(31, 24);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(118, 38);
            this.l.TabIndex = 93;
            this.l.Text = "Income";
            // 
            // dgvDoanhThu
            // 
            this.dgvDoanhThu.BackgroundColor = System.Drawing.Color.White;
            this.dgvDoanhThu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDoanhThu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoanhThu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenSanPham,
            this.giaBan,
            this.ngayDat,
            this.soLuongSP,
            this.thanhTien});
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDoanhThu.DefaultCellStyle = dataGridViewCellStyle28;
            this.dgvDoanhThu.Location = new System.Drawing.Point(38, 81);
            this.dgvDoanhThu.Name = "dgvDoanhThu";
            this.dgvDoanhThu.RowHeadersWidth = 51;
            this.dgvDoanhThu.RowTemplate.Height = 24;
            this.dgvDoanhThu.Size = new System.Drawing.Size(1126, 630);
            this.dgvDoanhThu.TabIndex = 94;
            // 
            // tenSanPham
            // 
            this.tenSanPham.DataPropertyName = "tenSanPham";
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tenSanPham.DefaultCellStyle = dataGridViewCellStyle23;
            this.tenSanPham.HeaderText = "Tên sản phẩm ";
            this.tenSanPham.MinimumWidth = 6;
            this.tenSanPham.Name = "tenSanPham";
            this.tenSanPham.Width = 500;
            // 
            // giaBan
            // 
            this.giaBan.DataPropertyName = "giaBan";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.giaBan.DefaultCellStyle = dataGridViewCellStyle24;
            this.giaBan.HeaderText = "Giá bán ";
            this.giaBan.MinimumWidth = 6;
            this.giaBan.Name = "giaBan";
            this.giaBan.Width = 125;
            // 
            // ngayDat
            // 
            this.ngayDat.DataPropertyName = "ngayDat";
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ngayDat.DefaultCellStyle = dataGridViewCellStyle25;
            this.ngayDat.HeaderText = "Ngày đặt ";
            this.ngayDat.MinimumWidth = 6;
            this.ngayDat.Name = "ngayDat";
            this.ngayDat.Width = 150;
            // 
            // soLuongSP
            // 
            this.soLuongSP.DataPropertyName = "soLuongSP";
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.soLuongSP.DefaultCellStyle = dataGridViewCellStyle26;
            this.soLuongSP.HeaderText = "Số lượng bán ra ";
            this.soLuongSP.MinimumWidth = 6;
            this.soLuongSP.Name = "soLuongSP";
            this.soLuongSP.Width = 125;
            // 
            // thanhTien
            // 
            this.thanhTien.DataPropertyName = "tongTien";
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.thanhTien.DefaultCellStyle = dataGridViewCellStyle27;
            this.thanhTien.HeaderText = "Tiền thu";
            this.thanhTien.MinimumWidth = 6;
            this.thanhTien.Name = "thanhTien";
            this.thanhTien.Width = 125;
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.BorderColor = System.Drawing.Color.White;
            this.txt_TongTien.BorderRadius = 5;
            this.txt_TongTien.BorderThickness = 2;
            this.txt_TongTien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TongTien.DefaultText = "";
            this.txt_TongTien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_TongTien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_TongTien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TongTien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TongTien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TongTien.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TongTien.ForeColor = System.Drawing.Color.Black;
            this.txt_TongTien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TongTien.IconLeft = global::WF_CuaHangAnVat.Properties.Resources.gross;
            this.txt_TongTien.Location = new System.Drawing.Point(370, 237);
            this.txt_TongTien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.PasswordChar = '\0';
            this.txt_TongTien.PlaceholderText = "";
            this.txt_TongTien.SelectedText = "";
            this.txt_TongTien.Size = new System.Drawing.Size(136, 41);
            this.txt_TongTien.TabIndex = 100;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(232, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 31);
            this.label5.TabIndex = 99;
            this.label5.Text = "Tổng Tiền:  ";
            // 
            // dtp_tuNgay
            // 
            this.dtp_tuNgay.BackColor = System.Drawing.Color.Transparent;
            this.dtp_tuNgay.BorderColor = System.Drawing.Color.Transparent;
            this.dtp_tuNgay.BorderRadius = 5;
            this.dtp_tuNgay.Checked = true;
            this.dtp_tuNgay.FillColor = System.Drawing.Color.White;
            this.dtp_tuNgay.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_tuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_tuNgay.Location = new System.Drawing.Point(177, 76);
            this.dtp_tuNgay.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_tuNgay.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_tuNgay.Name = "dtp_tuNgay";
            this.dtp_tuNgay.Size = new System.Drawing.Size(190, 36);
            this.dtp_tuNgay.TabIndex = 94;
            this.dtp_tuNgay.Value = new System.DateTime(2025, 4, 5, 15, 17, 26, 310);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(107, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(345, 38);
            this.label4.TabIndex = 98;
            this.label4.Text = "THỐNG KÊ DOANH THU";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dtp_denNgay
            // 
            this.dtp_denNgay.BorderRadius = 5;
            this.dtp_denNgay.Checked = true;
            this.dtp_denNgay.FillColor = System.Drawing.Color.White;
            this.dtp_denNgay.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_denNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_denNgay.Location = new System.Drawing.Point(177, 143);
            this.dtp_denNgay.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_denNgay.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_denNgay.Name = "dtp_denNgay";
            this.dtp_denNgay.Size = new System.Drawing.Size(190, 36);
            this.dtp_denNgay.TabIndex = 95;
            this.dtp_denNgay.Value = new System.DateTime(2025, 4, 5, 14, 48, 12, 668);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 31);
            this.label2.TabIndex = 97;
            this.label2.Text = "Đến ngày: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 31);
            this.label3.TabIndex = 96;
            this.label3.Text = "Từ ngày: ";
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.guna2Separator1);
            this.guna2ShadowPanel1.Controls.Add(this.l);
            this.guna2ShadowPanel1.Controls.Add(this.dgvDoanhThu);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(34, 35);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 7;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(1194, 748);
            this.guna2ShadowPanel1.TabIndex = 102;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(38, 65);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1126, 10);
            this.guna2Separator1.TabIndex = 95;
            // 
            // guna2ShadowPanel2
            // 
            this.guna2ShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel2.Controls.Add(this.label4);
            this.guna2ShadowPanel2.Controls.Add(this.txt_TongTien);
            this.guna2ShadowPanel2.Controls.Add(this.label5);
            this.guna2ShadowPanel2.Controls.Add(this.dtp_tuNgay);
            this.guna2ShadowPanel2.Controls.Add(this.label3);
            this.guna2ShadowPanel2.Controls.Add(this.dtp_denNgay);
            this.guna2ShadowPanel2.Controls.Add(this.label2);
            this.guna2ShadowPanel2.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel2.Location = new System.Drawing.Point(1270, 35);
            this.guna2ShadowPanel2.Name = "guna2ShadowPanel2";
            this.guna2ShadowPanel2.Radius = 7;
            this.guna2ShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel2.Size = new System.Drawing.Size(567, 327);
            this.guna2ShadowPanel2.TabIndex = 103;
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.Location = new System.Drawing.Point(1270, 401);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(567, 8);
            this.guna2Separator2.TabIndex = 104;
            // 
            // btn_ThongKe
            // 
            this.btn_ThongKe.BorderRadius = 5;
            this.btn_ThongKe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ThongKe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ThongKe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ThongKe.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ThongKe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ThongKe.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(214)))));
            this.btn_ThongKe.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_ThongKe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_ThongKe.ForeColor = System.Drawing.Color.White;
            this.btn_ThongKe.Location = new System.Drawing.Point(1670, 450);
            this.btn_ThongKe.Name = "btn_ThongKe";
            this.btn_ThongKe.Size = new System.Drawing.Size(167, 45);
            this.btn_ThongKe.TabIndex = 138;
            this.btn_ThongKe.Text = "Thống Kê";
            this.btn_ThongKe.Click += new System.EventHandler(this.btn_ThongKe_Click_1);
            // 
            // UC_Income
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_ThongKe);
            this.Controls.Add(this.guna2Separator2);
            this.Controls.Add(this.guna2ShadowPanel2);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Name = "UC_Income";
            this.Size = new System.Drawing.Size(1882, 852);
            this.Load += new System.EventHandler(this.UC_Income_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).EndInit();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.guna2ShadowPanel2.ResumeLayout(false);
            this.guna2ShadowPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label l;
        private System.Windows.Forms.DataGridView dgvDoanhThu;
        private Guna.UI2.WinForms.Guna2TextBox txt_TongTien;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_tuNgay;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_denNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhTien;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2GradientButton btn_ThongKe;
    }
}
