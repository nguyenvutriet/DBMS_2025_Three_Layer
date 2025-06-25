namespace WF_CuaHangAnVat.all_user_control
{
    partial class UC_Type
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvLSP = new System.Windows.Forms.DataGridView();
            this.maLoaiSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLoaiSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_ChuongTrinhKM = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_maLoaiSP = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_TenloaiSP = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btn_Reload = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_Them = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_Sua = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_Luu = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_Xoa = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_HuyBo = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLSP)).BeginInit();
            this.guna2ShadowPanel1.SuspendLayout();
            this.guna2ShadowPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLSP
            // 
            this.dgvLSP.BackgroundColor = System.Drawing.Color.White;
            this.dgvLSP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLSP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvLSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maLoaiSanPham,
            this.tenLoaiSanPham,
            this.maKM});
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLSP.DefaultCellStyle = dataGridViewCellStyle25;
            this.dgvLSP.Location = new System.Drawing.Point(29, 81);
            this.dgvLSP.Name = "dgvLSP";
            this.dgvLSP.RowHeadersWidth = 51;
            this.dgvLSP.RowTemplate.Height = 24;
            this.dgvLSP.Size = new System.Drawing.Size(1107, 524);
            this.dgvLSP.TabIndex = 93;
            this.dgvLSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLSP_CellClick);
            // 
            // maLoaiSanPham
            // 
            this.maLoaiSanPham.DataPropertyName = "maLoaiSanPham";
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.maLoaiSanPham.DefaultCellStyle = dataGridViewCellStyle22;
            this.maLoaiSanPham.HeaderText = "Mã loại sản phẩm ";
            this.maLoaiSanPham.MinimumWidth = 6;
            this.maLoaiSanPham.Name = "maLoaiSanPham";
            this.maLoaiSanPham.Width = 150;
            // 
            // tenLoaiSanPham
            // 
            this.tenLoaiSanPham.DataPropertyName = "tenLoaiSanPham";
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tenLoaiSanPham.DefaultCellStyle = dataGridViewCellStyle23;
            this.tenLoaiSanPham.HeaderText = "Tên loại sản phẩm ";
            this.tenLoaiSanPham.MinimumWidth = 6;
            this.tenLoaiSanPham.Name = "tenLoaiSanPham";
            this.tenLoaiSanPham.Width = 390;
            // 
            // maKM
            // 
            this.maKM.DataPropertyName = "maKM";
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.maKM.DefaultCellStyle = dataGridViewCellStyle24;
            this.maKM.HeaderText = "Mã khuyến mãi ";
            this.maKM.MinimumWidth = 6;
            this.maKM.Name = "maKM";
            this.maKM.Width = 150;
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l.ForeColor = System.Drawing.Color.Black;
            this.l.Location = new System.Drawing.Point(22, 24);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(83, 38);
            this.l.TabIndex = 92;
            this.l.Text = "Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 91;
            // 
            // cbx_ChuongTrinhKM
            // 
            this.cbx_ChuongTrinhKM.BackColor = System.Drawing.Color.Transparent;
            this.cbx_ChuongTrinhKM.BorderRadius = 5;
            this.cbx_ChuongTrinhKM.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbx_ChuongTrinhKM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_ChuongTrinhKM.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbx_ChuongTrinhKM.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbx_ChuongTrinhKM.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbx_ChuongTrinhKM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbx_ChuongTrinhKM.ItemHeight = 30;
            this.cbx_ChuongTrinhKM.Location = new System.Drawing.Point(38, 300);
            this.cbx_ChuongTrinhKM.Name = "cbx_ChuongTrinhKM";
            this.cbx_ChuongTrinhKM.Size = new System.Drawing.Size(530, 36);
            this.cbx_ChuongTrinhKM.TabIndex = 111;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(32, 107);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(196, 31);
            this.label.TabIndex = 108;
            this.label.Text = "Mã loại sản phẩm: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 31);
            this.label4.TabIndex = 107;
            this.label4.Text = "Chương trình khuyến mãi:  ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 31);
            this.label3.TabIndex = 106;
            this.label3.Text = "Tên loại sản phẩm: ";
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.label2);
            this.guna2ShadowPanel1.Controls.Add(this.label);
            this.guna2ShadowPanel1.Controls.Add(this.txt_maLoaiSP);
            this.guna2ShadowPanel1.Controls.Add(this.label3);
            this.guna2ShadowPanel1.Controls.Add(this.txt_TenloaiSP);
            this.guna2ShadowPanel1.Controls.Add(this.label4);
            this.guna2ShadowPanel1.Controls.Add(this.cbx_ChuongTrinhKM);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(1236, 52);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 7;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(609, 390);
            this.guna2ShadowPanel1.TabIndex = 118;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(371, 38);
            this.label2.TabIndex = 109;
            this.label2.Text = "Thông Tin Loại Sản Phẩm";
            // 
            // txt_maLoaiSP
            // 
            this.txt_maLoaiSP.BorderRadius = 5;
            this.txt_maLoaiSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_maLoaiSP.DefaultText = "";
            this.txt_maLoaiSP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_maLoaiSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_maLoaiSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_maLoaiSP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_maLoaiSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_maLoaiSP.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_maLoaiSP.ForeColor = System.Drawing.Color.Black;
            this.txt_maLoaiSP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_maLoaiSP.IconLeft = global::WF_CuaHangAnVat.Properties.Resources.password;
            this.txt_maLoaiSP.Location = new System.Drawing.Point(256, 90);
            this.txt_maLoaiSP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_maLoaiSP.Name = "txt_maLoaiSP";
            this.txt_maLoaiSP.PasswordChar = '\0';
            this.txt_maLoaiSP.PlaceholderText = "";
            this.txt_maLoaiSP.SelectedText = "";
            this.txt_maLoaiSP.Size = new System.Drawing.Size(177, 48);
            this.txt_maLoaiSP.TabIndex = 110;
            // 
            // txt_TenloaiSP
            // 
            this.txt_TenloaiSP.BorderRadius = 5;
            this.txt_TenloaiSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TenloaiSP.DefaultText = "";
            this.txt_TenloaiSP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_TenloaiSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_TenloaiSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TenloaiSP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TenloaiSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TenloaiSP.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_TenloaiSP.ForeColor = System.Drawing.Color.Black;
            this.txt_TenloaiSP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TenloaiSP.IconLeft = global::WF_CuaHangAnVat.Properties.Resources.nutrition;
            this.txt_TenloaiSP.Location = new System.Drawing.Point(256, 165);
            this.txt_TenloaiSP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_TenloaiSP.Name = "txt_TenloaiSP";
            this.txt_TenloaiSP.PasswordChar = '\0';
            this.txt_TenloaiSP.PlaceholderText = "";
            this.txt_TenloaiSP.SelectedText = "";
            this.txt_TenloaiSP.Size = new System.Drawing.Size(293, 51);
            this.txt_TenloaiSP.TabIndex = 109;
            // 
            // guna2ShadowPanel2
            // 
            this.guna2ShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel2.Controls.Add(this.guna2Separator1);
            this.guna2ShadowPanel2.Controls.Add(this.l);
            this.guna2ShadowPanel2.Controls.Add(this.dgvLSP);
            this.guna2ShadowPanel2.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel2.Location = new System.Drawing.Point(47, 52);
            this.guna2ShadowPanel2.Name = "guna2ShadowPanel2";
            this.guna2ShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel2.Size = new System.Drawing.Size(1154, 628);
            this.guna2ShadowPanel2.TabIndex = 119;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(29, 65);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1107, 10);
            this.guna2Separator1.TabIndex = 94;
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.Location = new System.Drawing.Point(47, 701);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(1319, 15);
            this.guna2Separator2.TabIndex = 120;
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
            this.btn_Reload.Location = new System.Drawing.Point(47, 722);
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.Size = new System.Drawing.Size(142, 45);
            this.btn_Reload.TabIndex = 121;
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
            this.btn_Them.Location = new System.Drawing.Point(250, 722);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(156, 45);
            this.btn_Them.TabIndex = 122;
            this.btn_Them.Text = "Thêm Mới";
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
            this.btn_Sua.Location = new System.Drawing.Point(473, 722);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(261, 45);
            this.btn_Sua.TabIndex = 123;
            this.btn_Sua.Text = "Chỉnh Sữa Thông Tin";
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
            this.btn_Luu.Location = new System.Drawing.Point(794, 722);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(149, 45);
            this.btn_Luu.TabIndex = 124;
            this.btn_Luu.Text = "Hoàn Tất";
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
            this.btn_Xoa.Location = new System.Drawing.Point(1005, 722);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(148, 45);
            this.btn_Xoa.TabIndex = 125;
            this.btn_Xoa.Text = "Loại Bỏ";
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
            this.btn_HuyBo.Location = new System.Drawing.Point(1218, 722);
            this.btn_HuyBo.Name = "btn_HuyBo";
            this.btn_HuyBo.Size = new System.Drawing.Size(148, 45);
            this.btn_HuyBo.TabIndex = 126;
            this.btn_HuyBo.Text = "Hủy Bỏ";
            this.btn_HuyBo.Click += new System.EventHandler(this.btn_HuyBo_Click_1);
            // 
            // UC_Type
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
            this.Controls.Add(this.label1);
            this.Name = "UC_Type";
            this.Size = new System.Drawing.Size(1882, 852);
            this.Load += new System.EventHandler(this.UC_Type_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLSP)).EndInit();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.guna2ShadowPanel2.ResumeLayout(false);
            this.guna2ShadowPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLSP;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbx_ChuongTrinhKM;
        private Guna.UI2.WinForms.Guna2TextBox txt_maLoaiSP;
        private Guna.UI2.WinForms.Guna2TextBox txt_TenloaiSP;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLoaiSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKM;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Reload;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Them;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Sua;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Luu;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Xoa;
        private Guna.UI2.WinForms.Guna2GradientButton btn_HuyBo;
    }
}
