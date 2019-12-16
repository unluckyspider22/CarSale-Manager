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
    public partial class frmNewPayment : Form
    {
        DataProgram db = new DataProgram();
        List<Payment> listPayment = new List<Payment>();
        public frmNewPayment()
        {
            InitializeComponent();
            barManager1.AllowCustomization = false;
            barManager1.AllowQuickCustomization = false;
            barManager1.AllowShowToolbarsPopup = false;
            listPayment = db.ListPayment();
        }
        private void resetLable()
        {
            lbIdError.Text = string.Empty;
            lbNameError.Text = string.Empty;
        }
        private bool checkDupKey(string id)
        {
            for (int i = 0; i < listPayment.Count; i++)
            {
                if (id.Equals(listPayment.ElementAt(i).payment_ID_))
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
                lbIdError.Text = "ID cannot be blank";
                valid = false;
            }
            if (checkDupKey(id))
            {
                lbIdError.Text = "ID existed!";
                valid = false;
            }
            string name = txtName.Text;
            if (name.Equals(""))
            {
                lbNameError.Text = "Type cannot be blank";
                valid = false;
            }
            string desc = txtDesc.Text;
            if (valid == true)
            {
                Payment item = new Payment
                {
                    payment_ID_ = id,
                    type_ = name,
                    description_ = desc
                };
                bool result = db.AddNewPayment(item);
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
