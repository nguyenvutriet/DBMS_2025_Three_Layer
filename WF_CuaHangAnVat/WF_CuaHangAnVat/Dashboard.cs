using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_CuaHangAnVat
{
    public partial class Dashboard: Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            uC_Product1.Visible = false;
            uC_Provider1.Visible = false;
            uC_Discount1.Visible = false;
            uC_Receipt1.Visible = false;
            uC_Categories1.Visible = false;
            uC_Type1.Visible = false;
            uC_Income1.Visible = false;
            uC_Register1.Visible = false;
            btn_Type.PerformClick();
            btn_Register.PerformClick();
            btn_Income.PerformClick();
            btn_Categories.PerformClick();
            btn_Product.PerformClick();
            btn_Provider.PerformClick();
            btn_Discount.PerformClick();
            btn_Receipt.PerformClick();

            
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btn_Register.Left + 60;
            uC_Register1.Visible = true;
            uC_Register1.BringToFront();
        }

        private void btn_Product_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btn_Product.Left + 60;
            uC_Product1.Visible = true;
            uC_Product1.BringToFront();
        }

        private void btn_Discount_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btn_Discount.Left + 60;
            uC_Discount1.Visible = true;
            uC_Discount1.BringToFront();
        }

        private void btn_Type_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btn_Type.Left + 60;
            uC_Type1.Visible = true;
            uC_Type1.BringToFront();
        }

        private void btn_Provider_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btn_Provider.Left + 60;
            uC_Provider1.Visible = true;
            uC_Provider1.BringToFront();
        }

        private void btn_Receipt_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btn_Receipt.Left + 60;
            uC_Receipt1.Visible = true;
            uC_Receipt1.BringToFront();
        }

        private void btn_Income_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btn_Income.Left + 60;
            uC_Income1.Visible = true;
            uC_Income1.BringToFront();
        }

        private void btn_Categories_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btn_Categories.Left + 60;
            uC_Categories1.Visible = true;
            uC_Categories1.BringToFront();
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
