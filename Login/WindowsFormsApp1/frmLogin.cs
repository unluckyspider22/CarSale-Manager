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

namespace WindowsFormsApp1
{
    public partial class frmLogin : MaterialSkin.Controls.MaterialForm
    {
        DataProgram db = new DataProgram();
        string user = "Guest";
        public delegate void authenUser(string user);
        public frmLogin()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue400, MaterialSkin.Primary.Blue400, MaterialSkin.Primary.Blue400,
                MaterialSkin.Accent.Cyan400, MaterialSkin.TextShade.BLACK);
        }
        public string getUser()
        {
            return this.user;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lbUserError.Text = string.Empty;
            lbPassError.Text = string.Empty;
            bool valid = true;
            string username = txtUsername.Text;
            if (username.Equals(""))
            {
                lbUserError.Text = "Username cannot be blank";
                valid = false;
            }
            string password = txtPassword.Text;
            if (password.Equals(""))
            {
                lbPassError.Text = "Password cannot be blank";
                valid = false;
            }
            if (valid)
            {
                if (!db.checkLogin(username, password).Equals(""))
                {
                    this.user = username;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    lbPassError.Text = "Wrong username or password";
                }
            }
        }
    }
}
