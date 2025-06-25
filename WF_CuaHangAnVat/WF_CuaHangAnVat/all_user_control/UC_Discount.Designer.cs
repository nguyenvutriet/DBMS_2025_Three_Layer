namespace WF_CuaHangAnVat.all_user_control
{
    partial class UC_Discount
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            this.l = new System.Windows.Forms.Label();
            this.dgvKM = new System.Windows.Forms.DataGridView();
            this.maKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenChuongTrinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_NgayBatDau = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_NgayKetThuc = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_MaKhuyenMai = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_TenChuongTrinh = new Guna.UI2.WinForms.Guna2TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.btn_Reload = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_Them = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_Sua = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_Luu = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_Xoa = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_HuyBo = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKM)).BeginInit();
            this.guna2ShadowPanel1.SuspendLayout();
            this.guna2ShadowPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l.ForeColor = System.Drawing.Color.Black;
            this.l.Location = new System.Drawing.Point(17, 13);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(156, 38);
            this.l.TabIndex = 68;
            this.l.Text = "DISCOUNT";
            // 
            // dgvKM
            // 
            this.dgvKM.BackgroundColor = System.Drawing.Color.White;
            this.dgvKM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKM.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dgvKM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maKM,
            this.tenChuongTrinh,
            this.ngayBatDau,
            this.ngayKetThuc});
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKM.DefaultCellStyle = dataGridViewCellStyle30;
            this.dgvKM.Location = new System.Drawing.Point(24, 70);
            this.dgvKM.Name = "dgvKM";
            this.dgvKM.RowHeadersWidth = 51;
            this.dgvKM.RowTemplate.Height = 24;
            this.dgvKM.Size = new System.Drawing.Size(1062, 454);
            this.dgvKM.TabIndex = 69;
            this.dgvKM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKM_CellClick);
            // 
            // maKM
            // 
            this.maKM.DataPropertyName = "maKM";
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.maKM.DefaultCellStyle = dataGridViewCellStyle26;
            this.maKM.HeaderText = "maKM";
            this.maKM.MinimumWidth = 6;
            this.maKM.Name = "maKM";
            this.maKM.Width = 125;
            // 
            // tenChuongTrinh
            // 
            this.tenChuongTrinh.DataPropertyName = "tenChuongTrinh";
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tenChuongTrinh.DefaultCellStyle = dataGridViewCellStyle27;
            this.tenChuongTrinh.HeaderText = "tenChuongTrinh";
            this.tenChuongTrinh.MinimumWidth = 6;
            this.tenChuongTrinh.Name = "tenChuongTrinh";
            this.tenChuongTrinh.Width = 390;
            // 
            // ngayBatDau
            // 
            this.ngayBatDau.DataPropertyName = "ngayBatDau";
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ngayBatDau.DefaultCellStyle = dataGridViewCellStyle28;
            this.ngayBatDau.HeaderText = "ngayBatDau";
            this.ngayBatDau.MinimumWidth = 6;
            this.ngayBatDau.Name = "ngayBatDau";
            this.ngayBatDau.Width = 150;
            // 
            // ngayKetThuc
            // 
            this.ngayKetThuc.DataPropertyName = "ngayKetThuc";
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ngayKetThuc.DefaultCellStyle = dataGridViewCellStyle29;
            this.ngayKetThuc.HeaderText = "ngayKetThuc";
            this.ngayKetThuc.MinimumWidth = 6;
            this.ngayKetThuc.Name = "ngayKetThuc";
            this.ngayKetThuc.Width = 150;
            // 
            // txt_NgayBatDau
            // 
            this.txt_NgayBatDau.BorderRadius = 5;
            this.txt_NgayBatDau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_NgayBatDau.DefaultText = "";
            this.txt_NgayBatDau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_NgayBatDau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_NgayBatDau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_NgayBatDau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_NgayBatDau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_NgayBatDau.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_NgayBatDau.ForeColor = System.Drawing.Color.Black;
            this.txt_NgayBatDau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_NgayBatDau.IconLeft = global::WF_CuaHangAnVat.Properties.Resources.thunderstorm;
            this.txt_NgayBatDau.Location = new System.Drawing.Point(29, 340);
            this.txt_NgayBatDau.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NgayBatDau.Name = "txt_NgayBatDau";
            this.txt_NgayBatDau.PasswordChar = '\0';
            this.txt_NgayBatDau.PlaceholderText = "";
            this.txt_NgayBatDau.SelectedText = "";
            this.txt_NgayBatDau.Size = new System.Drawing.Size(547, 50);
            this.txt_NgayBatDau.TabIndex = 101;
            // 
            // txt_NgayKetThuc
            // 
            this.txt_NgayKetThuc.BorderRadius = 5;
            this.txt_NgayKetThuc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_NgayKetThuc.DefaultText = "";
            this.txt_NgayKetThuc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_NgayKetThuc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_NgayKetThuc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_NgayKetThuc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_NgayKetThuc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_NgayKetThuc.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_NgayKetThuc.ForeColor = System.Drawing.Color.Black;
            this.txt_NgayKetThuc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_NgayKetThuc.IconLeft = global::WF_CuaHangAnVat.Properties.Resources.end;
            this.txt_NgayKetThuc.Location = new System.Drawing.Point(29, 446);
            this.txt_NgayKetThuc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NgayKetThuc.Name = "txt_NgayKetThuc";
            this.txt_NgayKetThuc.PasswordChar = '\0';
            this.txt_NgayKetThuc.PlaceholderText = "";
            this.txt_NgayKetThuc.SelectedText = "";
            this.txt_NgayKetThuc.Size = new System.Drawing.Size(547, 50);
            this.txt_NgayKetThuc.TabIndex = 100;
            // 
            // txt_MaKhuyenMai
            // 
            this.txt_MaKhuyenMai.BorderRadius = 5;
            this.txt_MaKhuyenMai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MaKhuyenMai.DefaultText = "";
            this.txt_MaKhuyenMai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_MaKhuyenMai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_MaKhuyenMai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MaKhuyenMai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MaKhuyenMai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_MaKhuyenMai.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_MaKhuyenMai.ForeColor = System.Drawing.Color.Black;
            this.txt_MaKhuyenMai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_MaKhuyenMai.IconLeft = global::WF_CuaHangAnVat.Properties.Resources.discount_code;
            this.txt_MaKhuyenMai.Location = new System.Drawing.Point(30, 110);
            this.txt_MaKhuyenMai.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaKhuyenMai.Name = "txt_MaKhuyenMai";
            this.txt_MaKhuyenMai.PasswordChar = '\0';
            this.txt_MaKhuyenMai.PlaceholderText = "";
            this.txt_MaKhuyenMai.SelectedText = "";
            this.txt_MaKhuyenMai.Size = new System.Drawing.Size(547, 50);
            this.txt_MaKhuyenMai.TabIndex = 99;
            // 
            // txt_TenChuongTrinh
            // 
            this.txt_TenChuongTrinh.BorderRadius = 5;
            this.txt_TenChuongTrinh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TenChuongTrinh.DefaultText = "";
            this.txt_TenChuongTrinh.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_TenChuongTrinh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_TenChuongTrinh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TenChuongTrinh.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TenChuongTrinh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TenChuongTrinh.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_TenChuongTrinh.ForeColor = System.Drawing.Color.Black;
            this.txt_TenChuongTrinh.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TenChuongTrinh.IconLeft = global::WF_CuaHangAnVat.Properties.Resources.coupon;
            this.txt_TenChuongTrinh.Location = new System.Drawing.Point(35, 221);
            this.txt_TenChuongTrinh.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenChuongTrinh.Name = "txt_TenChuongTrinh";
            this.txt_TenChuongTrinh.PasswordChar = '\0';
            this.txt_TenChuongTrinh.PlaceholderText = "";
            this.txt_TenChuongTrinh.SelectedText = "";
            this.txt_TenChuongTrinh.Size = new System.Drawing.Size(547, 50);
            this.txt_TenChuongTrinh.TabIndex = 98;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.Black;
            this.label.Location = new System.Drawing.Point(23, 75);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(160, 31);
            this.label.TabIndex = 97;
            this.label.Text = "Mã khuyến mãi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(29, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 31);
            this.label4.TabIndex = 96;
            this.label4.Text = "Ngày bắt đầu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(29, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 31);
            this.label3.TabIndex = 95;
            this.label3.Text = "Tên chương trình";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(24, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 31);
            this.label2.TabIndex = 94;
            this.label2.Text = "Ngày kết thúc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(52, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(530, 38);
            this.label1.TabIndex = 98;
            this.label1.Text = "Thông Tin Chương Trinh Khuyến Mãi ";
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.guna2Separator1);
            this.guna2ShadowPanel1.Controls.Add(this.l);
            this.guna2ShadowPanel1.Controls.Add(this.dgvKM);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(79, 76);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 7;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(1110, 546);
            this.guna2ShadowPanel1.TabIndex = 103;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(24, 54);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1062, 10);
            this.guna2Separator1.TabIndex = 113;
            // 
            // guna2ShadowPanel2
            // 
            this.guna2ShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel2.Controls.Add(this.txt_NgayKetThuc);
            this.guna2ShadowPanel2.Controls.Add(this.label1);
            this.guna2ShadowPanel2.Controls.Add(this.label2);
            this.guna2ShadowPanel2.Controls.Add(this.label);
            this.guna2ShadowPanel2.Controls.Add(this.txt_NgayBatDau);
            this.guna2ShadowPanel2.Controls.Add(this.txt_MaKhuyenMai);
            this.guna2ShadowPanel2.Controls.Add(this.label3);
            this.guna2ShadowPanel2.Controls.Add(this.txt_TenChuongTrinh);
            this.guna2ShadowPanel2.Controls.Add(this.label4);
            this.guna2ShadowPanel2.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel2.Location = new System.Drawing.Point(1206, 76);
            this.guna2ShadowPanel2.Name = "guna2ShadowPanel2";
            this.guna2ShadowPanel2.Radius = 7;
            this.guna2ShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel2.Size = new System.Drawing.Size(630, 546);
            this.guna2ShadowPanel2.TabIndex = 104;
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.FillColor = System.Drawing.Color.DarkGray;
            this.guna2Separator2.Location = new System.Drawing.Point(79, 652);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(1500, 10);
            this.guna2Separator2.TabIndex = 114;
            // 
            // btn_Reload
            // 
            this.btn_Reload.BorderRadius = 5;
            this.btn_Reload.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Reload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Reload.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Reload.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Reload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Reload.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(214)))));
            this.btn_Reload.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_Reload.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Reload.ForeColor = System.Drawing.Color.White;
            this.btn_Reload.Location = new System.Drawing.Point(79, 668);
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.Size = new System.Drawing.Size(121, 45);
            this.btn_Reload.TabIndex = 132;
            this.btn_Reload.Text = "ReLoad";
            this.btn_Reload.Click += new System.EventHandler(this.btn_Reload_Click_1);
            // 
            // btn_Them
            // 
            this.btn_Them.BorderRadius = 5;
            this.btn_Them.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Them.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Them.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Them.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Them.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Them.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(214)))));
            this.btn_Them.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Location = new System.Drawing.Point(250, 668);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(221, 45);
            this.btn_Them.TabIndex = 133;
            this.btn_Them.Text = "Tạo Khuyến Mãi";
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click_1);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BorderRadius = 5;
            this.btn_Sua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Sua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Sua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Sua.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Sua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Sua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(214)))));
            this.btn_Sua.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_Sua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Sua.ForeColor = System.Drawing.Color.White;
            this.btn_Sua.Location = new System.Drawing.Point(534, 668);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(278, 45);
            this.btn_Sua.TabIndex = 134;
            this.btn_Sua.Text = "Chỉnh Sữa Khuyến Mãi";
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click_1);
            // 
            // btn_Luu
            // 
            this.btn_Luu.BorderRadius = 5;
            this.btn_Luu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Luu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Luu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Luu.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Luu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Luu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(214)))));
            this.btn_Luu.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_Luu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Luu.ForeColor = System.Drawing.Color.White;
            this.btn_Luu.Location = new System.Drawing.Point(877, 668);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(154, 45);
            this.btn_Luu.TabIndex = 135;
            this.btn_Luu.Text = "Áp Dụng";
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click_1);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BorderRadius = 5;
            this.btn_Xoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Xoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Xoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Xoa.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Xoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Xoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(214)))));
            this.btn_Xoa.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.Location = new System.Drawing.Point(1094, 668);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(257, 45);
            this.btn_Xoa.TabIndex = 136;
            this.btn_Xoa.Text = "Gỡ Bỏ Khuyến Mãi";
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click_1);
            // 
            // btn_HuyBo
            // 
            this.btn_HuyBo.BorderRadius = 5;
            this.btn_HuyBo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_HuyBo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_HuyBo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_HuyBo.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_HuyBo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_HuyBo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(214)))));
            this.btn_HuyBo.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_HuyBo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_HuyBo.ForeColor = System.Drawing.Color.White;
            this.btn_HuyBo.Location = new System.Drawing.Point(1412, 668);
            this.btn_HuyBo.Name = "btn_HuyBo";
            this.btn_HuyBo.Size = new System.Drawing.Size(167, 45);
            this.btn_HuyBo.TabIndex = 137;
            this.btn_HuyBo.Text = "Tạm Dừng";
            this.btn_HuyBo.Click += new System.EventHandler(this.btn_HuyBo_Click_1);
            // 
            // UC_Discount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_HuyBo);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Reload);
            this.Controls.Add(this.guna2Separator2);
            this.Controls.Add(this.guna2ShadowPanel2);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Name = "UC_Discount";
            this.Size = new System.Drawing.Size(1882, 852);
            this.Load += new System.EventHandler(this.UC_Discount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKM)).EndInit();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.guna2ShadowPanel2.ResumeLayout(false);
            this.guna2ShadowPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label l;
        private System.Windows.Forms.DataGridView dgvKM;
        private Guna.UI2.WinForms.Guna2TextBox txt_NgayBatDau;
        private Guna.UI2.WinForms.Guna2TextBox txt_NgayKetThuc;
        private Guna.UI2.WinForms.Guna2TextBox txt_MaKhuyenMai;
        private Guna.UI2.WinForms.Guna2TextBox txt_TenChuongTrinh;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenChuongTrinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayKetThuc;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Reload;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Them;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Sua;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Luu;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Xoa;
        private Guna.UI2.WinForms.Guna2GradientButton btn_HuyBo;
    }
}
