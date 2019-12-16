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
    public partial class frmEditPayment : Form
    {
        DataProgram db = new DataProgram();
        List<Payment> listCategory = new List<Payment>();
        public frmEditPayment()
        {
            InitializeComponent();
            barManager1.AllowCustomization = false;
            barManager1.AllowQuickCustomization = false;
            barManager1.AllowShowToolbarsPopup = false;
        }
        private void frmEditPayment_Load(object sender, EventArgs e)
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
                lbNameError.Text = "Type cannot be blank";
                valid = false;
            }
            string desc = txtDesc.Text;
            if (valid)
            {
                Payment item = new Payment
                {
                    payment_ID_ = id,
                    type_ = name,
                    description_ = desc
                };
                bool result = db.UpdatePayment(item);
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
