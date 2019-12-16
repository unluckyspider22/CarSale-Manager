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
    public partial class frmNewCategory : Form
    {
        DataProgram db = new DataProgram();
        List<Car_Category> listCategory = new List<Car_Category>();
        public frmNewCategory()
        {
            InitializeComponent();
            barManager1.AllowCustomization = false;
            barManager1.AllowQuickCustomization = false;
            barManager1.AllowShowToolbarsPopup = false;
            listCategory = db.ListCategories();
        }
        private void resetLable()
        {
            lbIdError.Text = string.Empty;
            lbNameError.Text = string.Empty;
        }
        private bool checkDupKey(string id)
        {
            for (int i = 0; i < listCategory.Count; i++)
            {
                if (id.Equals(listCategory.ElementAt(i).category_Code_))
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
                Car_Category category = new Car_Category
                {
                    category_Code_ = id,
                    category_Name_ = name,
                    description_ = desc
                };
                bool result = db.AddNewCategory(category);
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
            resetLable();
            txtID.Text = string.Empty;
            txtName.Text = string.Empty;
            txtDesc.Text = string.Empty;
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
