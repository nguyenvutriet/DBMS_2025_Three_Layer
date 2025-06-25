using WF_CuaHangAnVat.all_user_control;

namespace WF_CuaHangAnVat
{
    partial class Dashboard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            //System.ComponentModel.ComponentResourceManager
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.PanelMoving = new Guna.UI2.WinForms.Guna2Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Categories = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Type = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Income = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Provider = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Receipt = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Discount = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Product = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Register = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Minimize = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Exit = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_Categories1 = new WF_CuaHangAnVat.all_user_control.UC_Categories();
            this.uC_Discount1 = new WF_CuaHangAnVat.all_user_control.UC_Discount();
            this.uC_Income1 = new WF_CuaHangAnVat.all_user_control.UC_Income();
            this.uC_Product1 = new WF_CuaHangAnVat.all_user_control.UC_Product();
            this.uC_Provider1 = new WF_CuaHangAnVat.all_user_control.UC_Provider();
            this.uC_Receipt1 = new WF_CuaHangAnVat.all_user_control.UC_Receipt();
            this.uC_Register1 = new WF_CuaHangAnVat.all_user_control.UC_Register();
            this.uC_Type1 = new WF_CuaHangAnVat.all_user_control.UC_Type();
           
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMoving
            // 
            this.PanelMoving.BackColor = System.Drawing.Color.Sienna;
            this.PanelMoving.Location = new System.Drawing.Point(72, 161);
            this.PanelMoving.Name = "PanelMoving";
            this.PanelMoving.Size = new System.Drawing.Size(197, 7);
            this.PanelMoving.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_Categories);
            this.panel1.Controls.Add(this.btn_Type);
            this.panel1.Controls.Add(this.btn_Income);
            this.panel1.Controls.Add(this.btn_Provider);
            this.panel1.Controls.Add(this.btn_Receipt);
            this.panel1.Controls.Add(this.btn_Discount);
            this.panel1.Controls.Add(this.btn_Product);
            this.panel1.Controls.Add(this.btn_Register);
            this.panel1.Location = new System.Drawing.Point(83, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1765, 130);
            this.panel1.TabIndex = 7;
            // 
            // btn_Categories
            // 
            this.btn_Categories.BackColor = System.Drawing.Color.Transparent;
            this.btn_Categories.BorderRadius = 20;
            this.btn_Categories.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_Categories.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Categories.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Categories.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Categories.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Categories.FillColor = System.Drawing.Color.SteelBlue;
            this.btn_Categories.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Categories.ForeColor = System.Drawing.Color.White;
            this.btn_Categories.Image = ((System.Drawing.Image)(resources.GetObject("btn_Categories.Image")));
            this.btn_Categories.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Categories.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_Categories.Location = new System.Drawing.Point(1532, 3);
            this.btn_Categories.Name = "btn_Categories";
            this.btn_Categories.Size = new System.Drawing.Size(226, 116);
            this.btn_Categories.TabIndex = 13;
            this.btn_Categories.Text = "Categories";
            this.btn_Categories.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Categories.Click += new System.EventHandler(this.btn_Categories_Click);
            // 
            // btn_Type
            // 
            this.btn_Type.BackColor = System.Drawing.Color.Transparent;
            this.btn_Type.BorderRadius = 20;
            this.btn_Type.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_Type.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Type.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Type.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Type.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Type.FillColor = System.Drawing.Color.SteelBlue;
            this.btn_Type.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Type.ForeColor = System.Drawing.Color.White;
            this.btn_Type.Image = ((System.Drawing.Image)(resources.GetObject("btn_Type.Image")));
            this.btn_Type.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Type.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_Type.Location = new System.Drawing.Point(701, 3);
            this.btn_Type.Name = "btn_Type";
            this.btn_Type.Size = new System.Drawing.Size(170, 116);
            this.btn_Type.TabIndex = 8;
            this.btn_Type.Text = "Type";
            this.btn_Type.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_Type.Click += new System.EventHandler(this.btn_Type_Click);
            // 
            // btn_Income
            // 
            this.btn_Income.BackColor = System.Drawing.Color.Transparent;
            this.btn_Income.BorderRadius = 20;
            this.btn_Income.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_Income.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Income.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Income.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Income.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Income.FillColor = System.Drawing.Color.SteelBlue;
            this.btn_Income.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Income.ForeColor = System.Drawing.Color.White;
            this.btn_Income.Image = ((System.Drawing.Image)(resources.GetObject("btn_Income.Image")));
            this.btn_Income.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Income.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_Income.Location = new System.Drawing.Point(1327, 3);
            this.btn_Income.Name = "btn_Income";
            this.btn_Income.Size = new System.Drawing.Size(188, 116);
            this.btn_Income.TabIndex = 11;
            this.btn_Income.Text = "Income";
            this.btn_Income.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Income.Click += new System.EventHandler(this.btn_Income_Click);
            // 
            // btn_Provider
            // 
            this.btn_Provider.BackColor = System.Drawing.Color.Transparent;
            this.btn_Provider.BorderRadius = 20;
            this.btn_Provider.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_Provider.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Provider.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Provider.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Provider.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Provider.FillColor = System.Drawing.Color.SteelBlue;
            this.btn_Provider.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Provider.ForeColor = System.Drawing.Color.White;
            this.btn_Provider.Image = ((System.Drawing.Image)(resources.GetObject("btn_Provider.Image")));
            this.btn_Provider.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Provider.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_Provider.Location = new System.Drawing.Point(889, 3);
            this.btn_Provider.Name = "btn_Provider";
            this.btn_Provider.Size = new System.Drawing.Size(206, 116);
            this.btn_Provider.TabIndex = 10;
            this.btn_Provider.Text = "Provider";
            this.btn_Provider.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Provider.Click += new System.EventHandler(this.btn_Provider_Click);
            // 
            // btn_Receipt
            // 
            this.btn_Receipt.BackColor = System.Drawing.Color.Transparent;
            this.btn_Receipt.BorderRadius = 20;
            this.btn_Receipt.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_Receipt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Receipt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Receipt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Receipt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Receipt.FillColor = System.Drawing.Color.SteelBlue;
            this.btn_Receipt.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Receipt.ForeColor = System.Drawing.Color.White;
            this.btn_Receipt.Image = ((System.Drawing.Image)(resources.GetObject("btn_Receipt.Image")));
            this.btn_Receipt.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Receipt.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_Receipt.Location = new System.Drawing.Point(1114, 3);
            this.btn_Receipt.Name = "btn_Receipt";
            this.btn_Receipt.Size = new System.Drawing.Size(191, 116);
            this.btn_Receipt.TabIndex = 12;
            this.btn_Receipt.Text = "Receipt";
            this.btn_Receipt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Receipt.Click += new System.EventHandler(this.btn_Receipt_Click);
            // 
            // btn_Discount
            // 
            this.btn_Discount.BackColor = System.Drawing.Color.Transparent;
            this.btn_Discount.BorderRadius = 20;
            this.btn_Discount.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_Discount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Discount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Discount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Discount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Discount.FillColor = System.Drawing.Color.SteelBlue;
            this.btn_Discount.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Discount.ForeColor = System.Drawing.Color.White;
            this.btn_Discount.Image = ((System.Drawing.Image)(resources.GetObject("btn_Discount.Image")));
            this.btn_Discount.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Discount.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_Discount.Location = new System.Drawing.Point(460, 3);
            this.btn_Discount.Name = "btn_Discount";
            this.btn_Discount.Size = new System.Drawing.Size(222, 116);
            this.btn_Discount.TabIndex = 7;
            this.btn_Discount.Text = "Discount";
            this.btn_Discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Discount.Click += new System.EventHandler(this.btn_Discount_Click);
            // 
            // btn_Product
            // 
            this.btn_Product.BackColor = System.Drawing.Color.Transparent;
            this.btn_Product.BorderRadius = 20;
            this.btn_Product.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_Product.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Product.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Product.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Product.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Product.FillColor = System.Drawing.Color.SteelBlue;
            this.btn_Product.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Product.ForeColor = System.Drawing.Color.White;
            this.btn_Product.Image = ((System.Drawing.Image)(resources.GetObject("btn_Product.Image")));
            this.btn_Product.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Product.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_Product.Location = new System.Drawing.Point(239, 3);
            this.btn_Product.Name = "btn_Product";
            this.btn_Product.Size = new System.Drawing.Size(203, 116);
            this.btn_Product.TabIndex = 6;
            this.btn_Product.Text = "Product";
            this.btn_Product.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Product.Click += new System.EventHandler(this.btn_Product_Click);
            // 
            // btn_Register
            // 
            this.btn_Register.BackColor = System.Drawing.Color.Transparent;
            this.btn_Register.BorderRadius = 20;
            this.btn_Register.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_Register.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Register.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Register.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Register.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Register.FillColor = System.Drawing.Color.SteelBlue;
            this.btn_Register.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Register.ForeColor = System.Drawing.Color.White;
            this.btn_Register.Image = ((System.Drawing.Image)(resources.GetObject("btn_Register.Image")));
            this.btn_Register.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Register.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_Register.Location = new System.Drawing.Point(23, 3);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(197, 116);
            this.btn_Register.TabIndex = 0;
            this.btn_Register.Text = "Register";
            this.btn_Register.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.BackColor = System.Drawing.Color.Transparent;
            this.btn_Minimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Minimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Minimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Minimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Minimize.FillColor = System.Drawing.Color.Transparent;
            this.btn_Minimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Minimize.ForeColor = System.Drawing.Color.White;
            this.btn_Minimize.Image = ((System.Drawing.Image)(resources.GetObject("btn_Minimize.Image")));
            this.btn_Minimize.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_Minimize.Location = new System.Drawing.Point(26, 65);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(35, 34);
            this.btn_Minimize.TabIndex = 6;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Exit.FillColor = System.Drawing.Color.Transparent;
            this.btn_Exit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.Image")));
            this.btn_Exit.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_Exit.Location = new System.Drawing.Point(26, 25);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(35, 34);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.uC_Type1);
            this.panel2.Controls.Add(this.uC_Register1);
            this.panel2.Controls.Add(this.uC_Receipt1);
            this.panel2.Controls.Add(this.uC_Provider1);
            this.panel2.Controls.Add(this.uC_Product1);
            this.panel2.Controls.Add(this.uC_Income1);
            this.panel2.Controls.Add(this.uC_Discount1);
            this.panel2.Controls.Add(this.uC_Categories1);
            this.panel2.Location = new System.Drawing.Point(27, 195);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1882, 852);
            this.panel2.TabIndex = 8;
            // 
            // uC_Categories1
            // 
            this.uC_Categories1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.uC_Categories1.Location = new System.Drawing.Point(-2, -2);
            this.uC_Categories1.Name = "uC_Categories1";
            this.uC_Categories1.Size = new System.Drawing.Size(1882, 852);
            this.uC_Categories1.TabIndex = 10;
            // 
            // uC_Discount1
            // 
            this.uC_Discount1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.uC_Discount1.Location = new System.Drawing.Point(0, 0);
            this.uC_Discount1.Name = "uC_Discount1";
            this.uC_Discount1.Size = new System.Drawing.Size(1882, 852);
            this.uC_Discount1.TabIndex = 11;
            // 
            // uC_Income1
            // 
            this.uC_Income1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.uC_Income1.Location = new System.Drawing.Point(0, 0);
            this.uC_Income1.Name = "uC_Income1";
            this.uC_Income1.Size = new System.Drawing.Size(1882, 852);
            this.uC_Income1.TabIndex = 12;
            // 
            // uC_Product1
            // 
            this.uC_Product1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.uC_Product1.Location = new System.Drawing.Point(0, 0);
            this.uC_Product1.Name = "uC_Product1";
            this.uC_Product1.Size = new System.Drawing.Size(1882, 852);
            this.uC_Product1.TabIndex = 13;
            // 
            // uC_Provider1
            // 
            this.uC_Provider1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.uC_Provider1.Location = new System.Drawing.Point(0, 0);
            this.uC_Provider1.Name = "uC_Provider1";
            this.uC_Provider1.Size = new System.Drawing.Size(1882, 852);
            this.uC_Provider1.TabIndex = 14;
            // 
            // uC_Receipt1
            // 
            this.uC_Receipt1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.uC_Receipt1.Location = new System.Drawing.Point(0, 0);
            this.uC_Receipt1.Name = "uC_Receipt1";
            this.uC_Receipt1.Size = new System.Drawing.Size(1882, 852);
            this.uC_Receipt1.TabIndex = 15;
            // 
            // uC_Register1
            // 
            this.uC_Register1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.uC_Register1.Location = new System.Drawing.Point(0, 0);
            this.uC_Register1.Name = "uC_Register1";
            this.uC_Register1.Size = new System.Drawing.Size(1882, 852);
            this.uC_Register1.TabIndex = 16;
            // 
            // uC_Type1
            // 
            this.uC_Type1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.uC_Type1.Location = new System.Drawing.Point(0, 0);
            this.uC_Type1.Name = "uC_Type1";
            this.uC_Type1.Size = new System.Drawing.Size(1882, 852);
            this.uC_Type1.TabIndex = 17;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1942, 1102);
            this.Controls.Add(this.PanelMoving);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Minimize);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PanelMoving;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btn_Categories;
        private Guna.UI2.WinForms.Guna2Button btn_Type;
        private Guna.UI2.WinForms.Guna2Button btn_Income;
        private Guna.UI2.WinForms.Guna2Button btn_Provider;
        private Guna.UI2.WinForms.Guna2Button btn_Receipt;
        private Guna.UI2.WinForms.Guna2Button btn_Discount;
        private Guna.UI2.WinForms.Guna2Button btn_Product;
        private Guna.UI2.WinForms.Guna2Button btn_Register;
        private Guna.UI2.WinForms.Guna2Button btn_Minimize;
        private Guna.UI2.WinForms.Guna2Button btn_Exit;
        private System.Windows.Forms.Panel panel2;
        private all_user_control.UC_Type uC_Type1;
        private all_user_control.UC_Register uC_Register1;
        private all_user_control.UC_Receipt uC_Receipt1;
        private all_user_control.UC_Provider uC_Provider1;
        private all_user_control.UC_Product uC_Product1;
        private all_user_control.UC_Income uC_Income1;
        private all_user_control.UC_Discount uC_Discount1;
        private all_user_control.UC_Categories uC_Categories1;
    }
}