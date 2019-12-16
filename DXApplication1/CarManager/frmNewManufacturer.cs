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
    public partial class frmNewManufacturer : Form
    {
        DataProgram db = new DataProgram();
        List<Car_Manufacturer> listManu = new List<Car_Manufacturer>();
        public frmNewManufacturer()
        {
            InitializeComponent();
            barManager1.AllowCustomization = false;
            barManager1.AllowQuickCustomization = false;
            barManager1.AllowShowToolbarsPopup = false;
            listManu = db.ListManufacturers();
        }
        private void resetLable()
        {
            lbIdError.Text = string.Empty;
            lbNameError.Text = string.Empty;
        }
        private bool checkDupKey(string id)
        {
            for (int i = 0; i < listManu.Count; i++)
            {
                if (id.Equals(listManu.ElementAt(i).manufacturer_Code_))
                {
                    return true;
                }
            }
            return false;
        }
        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            resetLable();
            bool valid = true;
            string id = txtID.Text;
            if (id.Equals(""))
            {
                lbIdError.Text = "Code cannot be blank";
                valid = false;
            }
            if (checkDupKey(id))
            {
                lbIdError.Text = "Code existed!";
                valid = false;
            }
            string name = txtName.Text;
            if (name.Equals(""))
            {
                lbNameError.Text = "Name cannot be blank";
                valid = false;
            }
            string desc = txtDesc.Text;
            if (valid == true)
            {
                Car_Manufacturer manu = new Car_Manufacturer
                {
                    manufacturer_Code_ = id,
                    manufacturer_Name_=name,
                    description_=desc
                };
                bool result = db.AddNewManufacturer(manu);
                if (result)
                {
                    MessageBox.Show("Add successful!", "New");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Add failed!", "New");
                }
            }
        }

        private void btnReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtID.Text = string.Empty;
            txtName.Text = string.Empty;
            txtDesc.Text = string.Empty;
            resetLable();
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
