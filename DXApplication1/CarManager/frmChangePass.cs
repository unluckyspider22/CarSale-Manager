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
    public partial class frmChangePass : Form
    {
        DataProgram db = new DataProgram();
        public frmChangePass()
        {
            InitializeComponent();
            barManager1.AllowCustomization = false;
            barManager1.AllowQuickCustomization = false;
            barManager1.AllowShowToolbarsPopup = false;
        }
        private void resetLable()
        {
            lbOldError.Text = string.Empty;
            lbNewError.Text = string.Empty;
            lbConfirmError.Text = string.Empty;
        }
        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            resetLable();
            string[] tmp = this.Text.Split(':', ')');
            string user = tmp[1];
            bool valid = true;
            string oldPass = txtOld.Text;
            if (oldPass.Equals(""))
            {
                lbOldError.Text = "Password cannot be blank";
                valid = false;
            }
            if (!oldPass.Equals(db.getPass(user)))
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
                if (db.UpdatePass(user, newPass))
                {
                    MessageBox.Show("Password changed!", "Update");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Update fail!", "Update");
                }
            }
        }

        private void btnReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtOld.Text = string.Empty;
            txtNew.Text = string.Empty;
            txtConfirm.Text = string.Empty;
            resetLable();
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
