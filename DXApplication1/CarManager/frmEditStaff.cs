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
    public partial class frmEditStaff : Form
    {
        DataProgram db = new DataProgram();
        public frmEditStaff()
        {
            InitializeComponent();
            barManager1.AllowCustomization = false;
            barManager1.AllowQuickCustomization = false;
            barManager1.AllowShowToolbarsPopup = false;
            cbGender.Items.Add("male");
            cbGender.Items.Add("female");
            cbGender.SelectedItem = cbGender.Items[0];
        }
        private void resetLable()
        {
            lbNameError.Text = string.Empty;
            lbAgeError.Text = string.Empty;
            lbAddrError.Text = string.Empty;
            lbPhoneError.Text = string.Empty;
            lbEmailError.Text = string.Empty;
            lbPositionError.Text = string.Empty;
        }
        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            resetLable();
            string[] tmp = this.Text.Split(':', ')');
            string id = tmp[1];
            bool valid = true;
            string name = txtName.Text;
            if (name.Equals(""))
            {
                lbNameError.Text = "Name cannot be blank";
                valid = false;
            }
            string age = txtAge.Text;
            if (age.Equals(""))
            {
                lbAgeError.Text = "Age cannot be blank";
                valid = false;
            }
            else
            {
                try
                {
                    int temp = int.Parse(age);
                    if (temp <= 0)
                    {
                        lbAgeError.Text = "Age must be >0";
                        valid = false;
                    }
                    else
                    {
                        valid = true;
                    }
                }
                catch (FormatException exc)
                {
                    lbAgeError.Text = "Wrong format";
                    valid = false;
                }
            }
            string addr = txtAddress.Text;
            if (addr.Equals(""))
            {
                lbAddrError.Text = "Address cannot be blank";
                valid = false;
            }
            string phone = txtPhone.Text;
            if (phone.Equals(""))
            {
                lbPhoneError.Text = "Phone cannot be blank";
                valid = false;
            }
            else
            {
                try
                {
                    decimal temp = decimal.Parse(phone);
                    if (temp <= 0)
                    {
                        lbPhoneError.Text = "Wrong phone number";
                        valid = false;
                    }
                    else
                    {
                        valid = true;
                    }
                }
                catch (FormatException exc)
                {
                    lbPhoneError.Text = "Wrong format";
                    valid = false;
                }
            }
            string email = txtEmail.Text;
            if (email.Equals(""))
            {
                lbEmailError.Text = "Eamil cannot be blank";
                valid = false;
            }
            string pos = txtPosition.Text;
            if (pos.Equals(""))
            {
                lbPositionError.Text = "Position cannot be blank";
                valid = false;
            }
            string gender = cbGender.Text;
            if (valid == true)
            {
                Staff staff = new Staff
                {
                    staff_ID_ = id,
                    fullname_ = name,
                    gender_ = gender,
                    age_ = int.Parse(age),
                    address_ = addr,
                    phone_ = decimal.Parse(phone),
                    email_ = email,
                    position_ = pos
                };
                bool result = db.UpdateStaff(staff);
                if (result)
                {
                    MessageBox.Show("Update successful!", "New");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Update failed!", "New");
                }
            }
        }

        private void btnReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtName.Text = string.Empty;
            txtAge.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPhone.Text = string.Empty;
            resetLable();
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
