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
    public partial class frmAccount : Form
    {
        DataProgram db = new DataProgram();
        Account acc = new Account();
        string user;
        public frmAccount(string user)
        {
            InitializeComponent();
            barManager1.AllowCustomization = false;
            barManager1.AllowQuickCustomization = false;
            barManager1.AllowShowToolbarsPopup = false;   
            this.user = user;
            this.acc = db.getAccount(user);
            

        }
        private void resetLable()
        {
            lbEmailError.Text = string.Empty;
            lbPhoneError.Text = string.Empty;
            lbAddrError.Text = string.Empty;
            lbAgeError.Text = string.Empty;
            lbNameError.Text = string.Empty;
            lbOldError.Text = string.Empty;
            lbNewError.Text = string.Empty;
            lbConfirmError.Text = string.Empty;
        }
        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            resetLable();
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
            else if (!age.Equals(""))
            {
                try
                {
                    float temp = float.Parse(age);
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
            string gender;
            if (rbMale.Checked == true)
            {
                gender = rbMale.Text;
            }
            else
            {
                gender = rbFemale.Text;
            }
            string address = txtAddress.Text;
            if (address.Equals(""))
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
            else if (!phone.Equals(""))
            {
                try
                {
                    decimal temp = decimal.Parse(phone);
                    if (temp <= 0)
                    {
                        lbPhoneError.Text = "Wrong phone";
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
                lbEmailError.Text = "Email cannot be blank";
                valid = false;
            }
            string oldPass = txtOld.Text;
            if (oldPass.Equals(""))
            {
                lbOldError.Text = "Password cannot be blank";
                valid = false;
            }
            if (!oldPass.Equals(acc.password_))
            {
                lbOldError.Text = "Wrong old password";
                valid = false;
            }
            string newPass = txtNew.Text;
            if (newPass.Equals(""))
            {
                lbNewError.Text = "Password cannot be blank";
                valid = false;
            }
            if (newPass.Length < 8)
            {
                lbNewError.Text = "Password must be at least 8 character";
                valid = false;
            }
            string confirm = txtConfirm.Text;
            if (confirm.Equals(""))
            {
                lbConfirmError.Text = "Password cannot be blank";
                valid = false;
            }
            if (!confirm.Equals(newPass))
            {
                lbConfirmError.Text = "Password confirm not match";
                valid = false;
            }
            

            if (valid)
            {
                acc.password_ = newPass;
                acc.fullname_ = name;
                acc.gender_ = gender;
                acc.address_ = address;
                acc.age_ = int.Parse(age);
                acc.phone_ = decimal.Parse(phone);
                acc.email_ = email;
                
                if (db.UpdateAccount(acc))
                {
                    MessageBox.Show("Account updated!", "Update");
                }
                else
                {
                    MessageBox.Show("Update fail!", "Update");
                }
            }
        }

        private void btnReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtAddress.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtAge.Text = string.Empty;
            txtName.Text = string.Empty;
            txtOld.Text = string.Empty;
            txtNew.Text = string.Empty;
            txtConfirm.Text = string.Empty;
            resetLable();
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnReset.Enabled = true;
            txtName.Enabled = true;
            txtAge.Enabled = true;
            rbMale.Enabled = true;
            rbFemale.Enabled = true;
            txtAddress.Enabled = true;
            txtPhone.Enabled = true;
            txtEmail.Enabled = true;
            txtOld.Enabled = true;
            txtNew.Enabled = true;
            txtConfirm.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            btnReset.Enabled = false;
            txtName.Enabled = false;
            txtAge.Enabled = false;
            rbMale.Enabled = false;
            rbFemale.Enabled = false;
            txtAddress.Enabled = false;
            txtPhone.Enabled = false;
            txtEmail.Enabled = false;
            txtOld.Enabled = false;
            txtNew.Enabled = false;
            txtConfirm.Enabled = false;
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {
            txtName.Text = acc.fullname_;
            txtAge.Text = acc.age_.ToString();
            if (acc.gender_.Equals("male"))
            {
                rbMale.Checked = true;
            }
            else
            {
                rbFemale.Checked = true;
            }
            txtAddress.Text = acc.address_;
            txtPhone.Text = acc.phone_.ToString();
            txtEmail.Text = acc.email_;
        }
    }
}
