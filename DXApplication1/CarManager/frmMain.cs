using DataSource;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace CarManager
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DataProgram db = new DataProgram();
        private bool authen = false;
        string user="Guest";
        
        public frmMain()
        {
            InitializeComponent();
            txtTime.Caption += DateTime.Now;                    
        }
        private void ribbonControl_ShowCustomizationMenu(object sender, DevExpress.XtraBars.Ribbon.RibbonCustomizationMenuEventArgs e)
        {
            e.ShowCustomizationMenu = false;
        }
        public void confirmLogin()
        {
            authen = true;

        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            loadMain();
        }
        private void loadMain()
        {
            if (authen)
            {
                btnAccount.Enabled = true;
                txtUser.Caption = user + " (Manager)";
                txtAuthen.Caption = string.Empty;
                splitContainerControl1.Visible = true;
                btnCarLoad.Enabled = true;
                btnCategoryLoad.Enabled = true;
                btnManufacturerLoad.Enabled = true;
                btnStaffLoad.Enabled = true;
                btnManagerLoad.Enabled = true;
                btnOrderLoad.Enabled = true;
                btnLogout.Enabled = true;
                btnLogin1.Enabled = false;
            }
            else
            {
                btnAccount.Enabled = false;
                txtUser.Caption = string.Empty;
                txtAuthen.Caption = "Status: Not login yet";
                splitContainerControl1.Visible = false;
                btnCarLoad.Enabled = false;
                btnCategoryLoad.Enabled = false;
                btnManufacturerLoad.Enabled = false;
                btnStaffLoad.Enabled = false;
                btnManagerLoad.Enabled = false;
                btnOrderLoad.Enabled = false;
                btnLogout.Enabled = false;
                btnLogin1.Enabled = true;
            }
        }
        private void btnCarLoad_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            splitContainerControl1.Panel2.Controls.Clear();
            frmItem form = new frmItem("Car List", "Car");

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            splitContainerControl1.Panel2.AutoScroll = true;
            splitContainerControl1.Panel2.Controls.Add(form);
            form.Show();
        }
        private void btnCategoryLoad_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            splitContainerControl1.Panel2.Controls.Clear();
            frmItem form = new frmItem("Category List", "Category");

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            splitContainerControl1.Panel2.AutoScroll = true;
            splitContainerControl1.Panel2.Controls.Add(form);
            form.Show();
        }

        private void btnManufacturer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            splitContainerControl1.Panel2.Controls.Clear();
            frmItem form = new frmItem("Manufacturer List", "Manufacturer");

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            splitContainerControl1.Panel2.AutoScroll = true;
            splitContainerControl1.Panel2.Controls.Add(form);
            form.Show();
        }

        private void btnStaff_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            splitContainerControl1.Panel2.Controls.Clear();
            frmItem form = new frmItem("Staff List", "Staff");

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            splitContainerControl1.Panel2.AutoScroll = true;
            splitContainerControl1.Panel2.Controls.Add(form);
            form.Show();
        }

        private void btnManager_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            splitContainerControl1.Panel2.Controls.Clear();
            frmItem form = new frmItem("Manager List", "Manager");

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            //form.user = db.getUser();
            form.user = "admin";
            splitContainerControl1.Panel2.AutoScroll = true;
            splitContainerControl1.Panel2.Controls.Add(form);
            form.Show();
        }

        private void btnOrderLoad_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            splitContainerControl1.Panel2.Controls.Clear();
            frmItem form = new frmItem("Order List", "Order");

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            splitContainerControl1.Panel2.AutoScroll = true;
            splitContainerControl1.Panel2.Controls.Add(form);
            form.Show();
        }

        private void LinkListCustomer_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            splitContainerControl1.Panel2.Controls.Clear();
            frmItem form = new frmItem("Customer List", "Customer");

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            splitContainerControl1.Panel2.AutoScroll = true;
            splitContainerControl1.Panel2.Controls.Add(form);
            form.Show();
        }


        
        private void startLoad()
        {
            splitContainerControl1.Panel2.Controls.Clear();
            StartForm form = new StartForm();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            splitContainerControl1.Panel2.AutoScroll = true;
            splitContainerControl1.Panel2.Controls.Add(form);
            form.Show();
        }
        private void btnLogin1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLogin form = new frmLogin();
            var result = form.ShowDialog();
            if(result == DialogResult.OK)
            {
                this.user = form.getUser();
                this.authen = true;
                loadMain();
                startLoad();
            }          
        }

        private void btnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.user = "Guest";
            authen = false;
            loadMain();
        }

        private void btnQuit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }
        private void linkReport_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            splitContainerControl1.Panel2.Controls.Clear();
            frmReport form = new frmReport();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            splitContainerControl1.Panel2.AutoScroll = true;
            splitContainerControl1.Panel2.Controls.Add(form);
            form.Show();
        }

        private void linkPayment_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            splitContainerControl1.Panel2.Controls.Clear();
            frmItem form = new frmItem("Customer Payment", "Payment");

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            splitContainerControl1.Panel2.AutoScroll = true;
            splitContainerControl1.Panel2.Controls.Add(form);
            form.Show();
        }

        private void linkInsurance_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            splitContainerControl1.Panel2.Controls.Clear();
            frmItem form = new frmItem("Insurance Companies", "Insurance");

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            splitContainerControl1.Panel2.AutoScroll = true;
            splitContainerControl1.Panel2.Controls.Add(form);
            form.Show();
        }

        private void btnAccount_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmAccount form = new frmAccount(user);
            form.Show();
        }
    }
}
