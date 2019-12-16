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
    public partial class frmEditCar : Form
    {
        DataProgram db = new DataProgram();
        List<Car_Category> listCategory = new List<Car_Category>();
        List<Car_Manufacturer> listManufacturer = new List<Car_Manufacturer>();
        
        public frmEditCar()
        {
            InitializeComponent();
            barManager1.AllowCustomization = false;
            barManager1.AllowQuickCustomization = false;
            barManager1.AllowShowToolbarsPopup = false;
            listCategory = db.ListCategories();
            listManufacturer = db.ListManufacturers();
            for (int i = 0; i < listCategory.Count; i++)
            {
                cbCategory.Items.Add(listCategory.ElementAt(i).category_Name_);
            }
            try
            {
                cbCategory.SelectedItem = cbCategory.Items[0];
            }catch(Exception e)
            {
                cbCategory.SelectedItem = string.Empty;
            }
            
            for (int i = 0; i < listManufacturer.Count; i++)
            {
                cbManufacturer.Items.Add(listManufacturer.ElementAt(i).manufacturer_Name_);
            }
            try
            {
                cbManufacturer.SelectedItem = cbManufacturer.Items[0];
            }catch(Exception e)
            {
                cbManufacturer.SelectedItem = string.Empty;
            }
        }
        private void resetLable()
        {
            lbNameError.Text = string.Empty;
            lbPriceError.Text = string.Empty;
            lbSpeedError.Text = string.Empty;
            lbDateError.Text = string.Empty;
            lbYearError.Text = string.Empty;
            lbStatusError.Text = string.Empty;
        }
        private string getCategoryCode(string name)
        {
            string result = string.Empty;
            for (int i = 0; i < listCategory.Count; i++)
            {
                if (name.Equals(listCategory.ElementAt(i).category_Name_))
                {
                    result = listCategory.ElementAt(i).category_Code_;
                }
            }
            return result;
        }
        private string getManuCode(string name)
        {
            string result = string.Empty;
            for (int i = 0; i < listManufacturer.Count; i++)
            {
                if (name.Equals(listManufacturer.ElementAt(i).manufacturer_Name_))
                {
                    result = listManufacturer.ElementAt(i).manufacturer_Code_;
                }
            }
            return result;
        }

        private void btnReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtName.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtSpeed.Text = string.Empty;
            txtDate.Text = string.Empty;
            txtYear.Text = string.Empty;
            txtDesc.Text = string.Empty;
            txtStatus.Text = string.Empty;
            resetLable();
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
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
            string price = txtPrice.Text;
            if (price.Equals(""))
            {
                lbPriceError.Text = "Price cannot be blank";
                valid = false;
            }
            else if (!price.Equals(""))
            {
                try
                {
                    float temp = float.Parse(price);
                    if (temp <= 0)
                    {
                        lbPriceError.Text = "Price must be >0";
                        valid = false;
                    }
                    else
                    {
                        valid = true;
                    }
                }
                catch (FormatException exc)
                {
                    lbPriceError.Text = "Wrong format";
                    valid = false;
                }
            }
            string speed = txtSpeed.Text;
            if (speed.Equals(""))
            {
                lbSpeedError.Text = "Speed cannot be blank";
                valid = false;
            }
            else
            {
                try
                {
                    float temp = float.Parse(speed);
                    if (temp <= 0)
                    {
                        lbSpeedError.Text = "Spped must be >0";
                        valid = false;
                    }
                    else
                    {
                        valid = true;
                    }
                }
                catch (FormatException exc)
                {
                    lbSpeedError.Text = "Wrong format";
                    valid = false;
                }
            }
            string date = txtDate.Text;
            if (date.Equals(""))
            {
                lbDateError.Text = "Date cannot be blank";
                valid = false;
            }
            else
            {
                try
                {
                    DateTime temp = DateTime.Parse(date);
                    valid = true;
                }
                catch (FormatException exc)
                {
                    lbDateError.Text = "Wrong format";
                    valid = false;
                }
            }
            string year = txtYear.Text;
            if (year.Equals(""))
            {
                lbYearError.Text = "Year cannot be blank";
                valid = false;
            }
            else
            {
                try
                {
                    int temp = int.Parse(year);
                    if (temp < 1990 || temp > 2050)
                    {
                        lbYearError.Text = "Range must from 1990 to 2050";
                        valid = false;
                    }
                    else
                    {
                        valid = true;
                    }
                }
                catch (FormatException exc)
                {
                    lbYearError.Text = "Wrong format";
                    valid = false;
                }
            }
            string status = txtStatus.Text;
            if (status.Equals(""))
            {
                lbStatusError.Text = "Status cannot be blank";
                valid = false;
            }
            if (valid)
            {
                Car car = new Car
                {
                    car_for_Sale_ID_ = id,
                    model_Name_ = name,
                    manufacturer_Code_ = getManuCode(cbManufacturer.Text),
                    category_Code_ = getCategoryCode(cbCategory.Text),
                    price_ = float.Parse(price),
                    speed_ = float.Parse(speed),
                    date_Accquired_ = DateTime.Parse(date),
                    registration_Year_ = int.Parse(year),
                    description_ = txtDesc.Text,
                    status_ = txtStatus.Text
                };
                bool result = db.UpdateCar(car);
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
    }
}
