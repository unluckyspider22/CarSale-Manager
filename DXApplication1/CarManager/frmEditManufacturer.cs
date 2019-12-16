using DataSource;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarManager
{
    
    public partial class frmEditManufacturer : Form
    {
        DataProgram db = new DataProgram();
        List<Car_Manufacturer> listManufacturer = new List<Car_Manufacturer>();
        public frmEditManufacturer()
        {
            InitializeComponent();
            barManager1.AllowCustomization = false;
            barManager1.AllowQuickCustomization = false;
            barManager1.AllowShowToolbarsPopup = false;
        }

        private void frmEditManufacturer_Load(object sender, EventArgs e)
        {
            string[] tmp = this.Text.Split(':', ')');
            txtID.Text = tmp[1];
        }
        private void resetLable()
        {
            lbNameError.Text = string.Empty;
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            resetLable();
            string id = txtID.Text;
            bool valid = true;
            string name = txtName.Text;
            if (name.Equals(""))
            {
                lbNameError.Text = "Name cannot be blank";
                valid = false;
            }
            string desc = txtDesc.Text;
            if (valid)
            {
                Car_Manufacturer manu = new Car_Manufacturer
                {
                    manufacturer_Code_ = id,
                    manufacturer_Name_ = name,
                    description_ = desc
                };
                bool result = db.UpdateManufacturer(manu);
                if (result)
                {
                    MessageBox.Show("Update successful!", "Update");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Update failed!", "Update");
                }
            }
        }

        private void btnReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            resetLable();
            txtName.Text = string.Empty;
            txtDesc.Text = string.Empty;
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
