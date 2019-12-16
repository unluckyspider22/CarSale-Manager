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
    public partial class frmItem : Form
    {
        DataProgram db = new DataProgram();
        DataTable dtItem;
        List<Car> listCar;
        List<Car_Category> listCategory;
        List<Car_Manufacturer> listManufacturer;
        List<Customer> listCustomer;
        List<Payment> listPayment;
        List<Insurance> listInsurance;
        List<Staff> listStaff;
        List<Order> listOrder;
        int row;
        int index;
        string type;
        public string user { get; set; }
        public frmItem(string title, string type)
        {
            InitializeComponent();
            ItemPage.Text = title;
            this.type = type;
            listCategory = db.ListCategories();
            listManufacturer = db.ListManufacturers();
            listCustomer = db.ListCustomer();
            listPayment = db.ListPayment();
            listInsurance = db.ListInsurance();
            listCar = db.ListCars();
            listStaff = db.ListStaff();
            listOrder = db.ListOrder();
        }
        private void GetAllCars()
        {
            dtItem = db.GetCars();
            dgvList.DataSource = dtItem;
            row = dgvList.RowCount;
            index = 0;
            dgvList.Rows[0].Selected = true;
            dgvList.Columns[0].HeaderText = "ID";
            dgvList.Columns[1].HeaderText = "Model";
            dgvList.Columns[2].HeaderText = "Manufacturer";
            dgvList.Columns[3].HeaderText = "Category";
            dgvList.Columns[4].HeaderText = "Price";
            dgvList.Columns[5].HeaderText = "Speed";
            dgvList.Columns[6].HeaderText = "Date Accquired";
            dgvList.Columns[7].HeaderText = "Registration Year";
            dgvList.Columns[8].Visible = false;
            dgvList.Columns[9].HeaderText = "Status";
            dgvList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            for(int i = 0; i < row - 1; i++)
            {
                string tmp = dgvList.Rows[i].Cells[3].Value.ToString();
                for(int j = 0; j < listCategory.Count; j++)
                {
                    if (tmp.Equals(listCategory.ElementAt(j).category_Code_))
                    {
                        dgvList.Rows[i].Cells[3].Value = listCategory.ElementAt(j).category_Name_;
                    }
                }
            }
            for (int i = 0; i < row - 1; i++)
            {
                string tmp = dgvList.Rows[i].Cells[2].Value.ToString();
                for (int j = 0; j < listManufacturer.Count; j++)
                {
                    if (tmp.Equals(listManufacturer.ElementAt(j).manufacturer_Code_))
                    {
                        dgvList.Rows[i].Cells[2].Value = listManufacturer.ElementAt(j).manufacturer_Name_;
                    }
                }
            }
            dgvList.ReadOnly = true;
        }
        private void GetAllCategories()
        {
            dtItem = db.GetCategories();
            dgvList.DataSource = dtItem;
            row = dgvList.RowCount;
            index = 0;
            dgvList.Rows[0].Selected = true;
            dgvList.Columns[0].HeaderText = "Code";
            dgvList.Columns[1].HeaderText = "Name";
            dgvList.Columns[2].HeaderText = "Description";
            dgvList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvList.ReadOnly = true;
        }
        private void GetAllManufacturers()
        {
            dtItem = db.GetManufacturers();
            dgvList.DataSource = dtItem;
            row = dgvList.RowCount;
            index = 0;
            dgvList.Rows[0].Selected = true;
            dgvList.Columns[0].HeaderText = "Code";
            dgvList.Columns[1].HeaderText = "Name";
            dgvList.Columns[2].HeaderText = "Description";
            dgvList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvList.ReadOnly = true;
        }
        private void GetAllStaffs()
        {
            dtItem = db.GetStaffs();
            dgvList.DataSource = dtItem;
            row = dgvList.RowCount;
            index = 0;
            dgvList.Rows[0].Selected = true;
            dgvList.Columns[0].HeaderText = "ID";
            dgvList.Columns[1].HeaderText = "Fullname";
            dgvList.Columns[2].HeaderText = "Gender";
            dgvList.Columns[3].HeaderText = "Age";
            dgvList.Columns[4].HeaderText = "Address";
            dgvList.Columns[5].HeaderText = "Phone";
            dgvList.Columns[6].HeaderText = "Email";
            dgvList.Columns[7].HeaderText = "Position";
            dgvList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvList.ReadOnly = true;
        }
        private void GetAllManager()
        {
            dtItem = db.GetManagers();
            dgvList.DataSource = dtItem;
            row = dgvList.RowCount;
            index = 0;
            dgvList.Rows[0].Selected = true;
            dgvList.Columns[0].Visible = false;
            dgvList.Columns[1].Visible = false;
            dgvList.Columns[2].HeaderText = "Fullname";
            dgvList.Columns[3].HeaderText = "Gender";
            dgvList.Columns[4].HeaderText = "Address";
            dgvList.Columns[5].HeaderText = "Age";
            dgvList.Columns[6].HeaderText = "Phone";
            dgvList.Columns[7].HeaderText = "Email";
            dgvList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvList.ReadOnly = true;
        }
        private void GetAllOrder()
        {
            dtItem = db.GetOrders();
            dgvList.DataSource = dtItem;
            row = dgvList.RowCount;
            index = 0;
            dgvList.Rows[0].Selected = true;
            dgvList.Columns[0].HeaderText = "ID";
            dgvList.Columns[1].HeaderText = "Customer";
            dgvList.Columns[2].HeaderText = "Payment";
            dgvList.Columns[3].HeaderText = "Insurance";
            dgvList.Columns[4].HeaderText = "Total money";
            dgvList.Columns[5].HeaderText = "Date Order";
            dgvList.Columns[6].HeaderText = "Description";
            dgvList.Columns[7].HeaderText = "Status";
            dgvList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            for (int i = 0; i < row - 1; i++)
            {
                string tmp = dgvList.Rows[i].Cells[1].Value.ToString();
                for (int j = 0; j < listCustomer.Count; j++)
                {
                    if (tmp.Equals(listCustomer.ElementAt(j).customer_ID_))
                    {
                        dgvList.Rows[i].Cells[1].Value = listCustomer.ElementAt(j).fullname_;
                    }
                }
            }
            for (int i = 0; i < row - 1; i++)
            {
                string tmp = dgvList.Rows[i].Cells[2].Value.ToString();
                for (int j = 0; j < listPayment.Count; j++)
                {
                    if (tmp.Equals(listPayment.ElementAt(j).payment_ID_))
                    {
                        dgvList.Rows[i].Cells[2].Value = listPayment.ElementAt(j).type_;
                    }
                }
            }
            for (int i = 0; i < row - 1; i++)
            {
                string tmp = dgvList.Rows[i].Cells[3].Value.ToString();
                for (int j = 0; j < listInsurance.Count; j++)
                {
                    if (tmp.Equals(listInsurance.ElementAt(j).insurance_Company_ID_))
                    {
                        dgvList.Rows[i].Cells[3].Value = listInsurance.ElementAt(j).insurance_Company_Name_;
                    }
                }
            }
            dgvList.ReadOnly = true;
        }
        private void GetAllCustomer()
        {
            dtItem = db.GetCustomers();
            dgvList.DataSource = dtItem;
            row = dgvList.RowCount;
            index = 0;
            dgvList.Rows[0].Selected = true;
            dgvList.Columns[0].HeaderText = "ID";
            dgvList.Columns[1].HeaderText = "Fullname";
            dgvList.Columns[2].HeaderText = "Gender";
            dgvList.Columns[3].HeaderText = "Age";
            dgvList.Columns[4].HeaderText = "Address";
            dgvList.Columns[5].HeaderText = "Phone";
            dgvList.Columns[6].HeaderText = "Email";
            dgvList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvList.ReadOnly = true;
        }
        private void GetAllInsurances()
        {
            dtItem = db.GetInsurance();
            dgvList.DataSource = dtItem;
            row = dgvList.RowCount;
            index = 0;
            dgvList.Rows[0].Selected = true;
            dgvList.Columns[0].HeaderText = "ID";
            dgvList.Columns[1].HeaderText = "Company";
            dgvList.Columns[2].HeaderText = "Description";
            dgvList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvList.ReadOnly = true;
        }
        private void GetAllPayments()
        {
            dtItem = db.GetPayments();
            dgvList.DataSource = dtItem;
            row = dgvList.RowCount;
            index = 0;
            dgvList.Rows[0].Selected = true;
            dgvList.Columns[0].HeaderText = "ID";
            dgvList.Columns[1].HeaderText = "Type";
            dgvList.Columns[2].HeaderText = "Description";
            dgvList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvList.ReadOnly = true;
        }
        private void frmItem_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {
            if (type.Equals("Car"))
            {
                GetAllCars();
                checkNullTable();
                lbQuantity.Text = string.Format("Total Quantity: " + (row - 1));
            }
            if (type.Equals("Category"))
            {
                GetAllCategories();
                checkNullTable();
                btnDelete.Enabled = false;
                lbQuantity.Text = string.Format("Total Quantity: " + (row - 1));
            }
            if (type.Equals("Manufacturer"))
            {
                GetAllManufacturers();
                checkNullTable();
                btnDelete.Enabled = false;
                lbQuantity.Text = string.Format("Total Quantity: " + (row - 1));
            }
            if (type.Equals("Staff"))
            {
                GetAllStaffs();
                checkNullTable();
                lbQuantity.Text = string.Format("Total Quantity: " + (row - 1));
            }
            if (type.Equals("Manager"))
            {
                GetAllManager();
                btnNew.Enabled = false;
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
                lbQuantity.Text = string.Format("Total Quantity: " + (row - 1));
            }
            if (type.Equals("Order"))
            {
                GetAllOrder();
                btnNew.Enabled = false;
                btnDelete.Enabled = false;
                btnEdit.Caption = "Appove";
                checkNullTable();
                lbQuantity.Text = string.Format("Total Quantity: " + (row - 1));
            }
            if (type.Equals("Customer"))
            {
                GetAllCustomer();
                btnNew.Enabled = false;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                lbQuantity.Text = string.Format("Total Quantity: " + (row - 1));
            }
            if (type.Equals("Insurance"))
            {
                GetAllInsurances();
                checkNullTable();
                btnDelete.Enabled = false;
                lbQuantity.Text = string.Format("Total Quantity: " + (row - 1));
            }
            if (type.Equals("Payment"))
            {
                GetAllPayments();
                checkNullTable();
                btnDelete.Enabled = false;
                lbQuantity.Text = string.Format("Total Quantity: " + (row - 1));
            }
        }
        private void checkNullTable()
        {
            if (type.Equals("Car"))
            {
                listCar = db.ListCars();
                if (listCar.Count < 1)
                {
                    btnEdit.Enabled = false;
                }
                else
                {
                    btnEdit.Enabled = true;
                }
            }
            if (type.Equals("Category"))
            {
                listCategory = db.ListCategories();
                if (listCategory.Count < 1)
                {
                    btnEdit.Enabled = false;
                }
                else
                {
                    btnEdit.Enabled = true;
                }
            }
            if (type.Equals("Manufacturer"))
            {
                listManufacturer = db.ListManufacturers();
                if (listManufacturer.Count < 1)
                {
                    btnEdit.Enabled = false;
                }
                else
                {
                    btnEdit.Enabled = true;
                }
            }
            if (type.Equals("Staff"))
            {
                listStaff = db.ListStaff();
                if (listStaff.Count < 1)
                {
                    btnEdit.Enabled = false;
                }
                else
                {
                    btnEdit.Enabled = true;
                }
            }
            if (type.Equals("Order"))
            {
                listOrder = db.ListOrder();
                if (listCustomer.Count < 1)
                {
                    btnEdit.Enabled = false;
                }
                else
                {
                    btnEdit.Enabled = true;
                }
            }
            if (type.Equals("Customer"))
            {
                listCustomer = db.ListCustomer();
                if (listCustomer.Count < 1)
                {
                    btnEdit.Enabled = false;
                }
                else
                {
                    btnEdit.Enabled = true;
                }
            }
            if (type.Equals("Insurance"))
            {
                listInsurance = db.ListInsurance();
                if (listInsurance.Count < 1)
                {
                    btnEdit.Enabled = false;
                }
                else
                {
                    btnEdit.Enabled = true;
                }
            }
            if (type.Equals("Payment"))
            {
                listPayment = db.ListPayment();
                if (listPayment.Count < 1)
                {
                    btnEdit.Enabled = false;
                }
                else
                {
                    btnEdit.Enabled = true;
                }
            }
        }
        public void getSelectedIndex()
        {
            for (int i = 0; i < row - 1; i++)
            {
                if (dgvList.Rows[i].Selected == true)
                {
                    index = i;
                }
            }
            
        }
        private void searchControl1_TextChanged(object sender, EventArgs e)
        {
            searchControl();
        }
        private void searchControl()
        {
            string filter;
            if (type.Equals("Car"))
            {
                DataView dv = dtItem.DefaultView;
                filter = "model_Name_ like '%" + txtFilter.Text + "%'";
                dv.RowFilter = filter;
                row = dgvList.RowCount;
                lbQuantity.Text = string.Format("Total Quantity: " + (row - 1));
            }
            if (type.Equals("Category"))
            {
                DataView dv = dtItem.DefaultView;
                filter = "category_Name_ like '%" + txtFilter.Text + "%'";
                dv.RowFilter = filter;
                row = dgvList.RowCount;
                lbQuantity.Text = string.Format("Total Quantity: " + (row - 1));
            }
            if (type.Equals("Manufacturer"))
            {
                DataView dv = dtItem.DefaultView;
                filter = "manufacturer_Name_ like '%" + txtFilter.Text + "%'";
                dv.RowFilter = filter;
                row = dgvList.RowCount;
                lbQuantity.Text = string.Format("Total Quantity: " + (row - 1));
            }
            if (type.Equals("Staff"))
            {
                DataView dv = dtItem.DefaultView;
                filter = "fullname_ like '%" + txtFilter.Text + "%'";
                dv.RowFilter = filter;
                row = dgvList.RowCount;
                lbQuantity.Text = string.Format("Total Quantity: " + (row - 1));
            }
            if (type.Equals("Manager"))
            {
                DataView dv = dtItem.DefaultView;
                filter = "fullname_ like '%" + txtFilter.Text + "%'";
                dv.RowFilter = filter;
                row = dgvList.RowCount;
                lbQuantity.Text = string.Format("Total Quantity: " + (row - 1));
            }
            if (type.Equals("Order"))
            {
                DataView dv = dtItem.DefaultView;
                filter = "customer_ID_ like '%" + txtFilter.Text + "%'";
                dv.RowFilter = filter;
                row = dgvList.RowCount;
                lbQuantity.Text = string.Format("Total Quantity: " + (row - 1));
            }
            if (type.Equals("Customer"))
            {
                DataView dv = dtItem.DefaultView;
                filter = "fullname_ like '%" + txtFilter.Text + "%'";
                dv.RowFilter = filter;
                row = dgvList.RowCount;
                lbQuantity.Text = string.Format("Total Quantity: " + (row - 1));
            }
            if (type.Equals("Insurance"))
            {
                DataView dv = dtItem.DefaultView;
                filter = "insurance_Company_Name_ like '%" + txtFilter.Text + "%'";
                dv.RowFilter = filter;
                row = dgvList.RowCount;
                lbQuantity.Text = string.Format("Total Quantity: " + (row - 1));
            }
            if (type.Equals("Payment"))
            {
                DataView dv = dtItem.DefaultView;
                filter = "type_ like '%" + txtFilter.Text + "%'";
                dv.RowFilter = filter;
                row = dgvList.RowCount;
                lbQuantity.Text = string.Format("Total Quantity: " + (row - 1));
            }
        }
        private void ribbonControl_ShowCustomizationMenu(object sender, DevExpress.XtraBars.Ribbon.RibbonCustomizationMenuEventArgs e)
        {
            e.ShowCustomizationMenu = false;
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadData();
            txtFilter.Text = string.Empty;
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            getSelectedIndex();
            string id = dgvList.Rows[index].Cells[0].Value.ToString();
            if (type.Equals("Car"))
            {
                if (db.DeleteCar(id))
                {
                    loadData();
                }
                else
                {
                    MessageBox.Show("Error while delete!", "Warning");
                }         
            }
            if (type.Equals("Staff"))
            {
                if (db.DeleteStaff(id))
                {
                    loadData();
                }
                else
                {
                    MessageBox.Show("Error while delete!", "Warning");
                }
            }
        }

        private void btnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {   
            if (type.Equals("Car"))
            {
                frmNewCar form = new frmNewCar();
                form.Text = "New Car";
                form.Show();
            }
            if (type.Equals("Staff"))
            {
                frmNewStaff form = new frmNewStaff();
                form.Text = "New Staff";
                form.Show();
            }
            if (type.Equals("Category"))
            {
                frmNewCategory form = new frmNewCategory();
                form.Text = "New Category";
                form.Show();
            }
            if (type.Equals("Manufacturer"))
            {
                frmNewManufacturer form = new frmNewManufacturer();
                form.Text = "New Manufacturer";
                form.Show();
            }
            if (type.Equals("Insurance"))
            {
                frmNewInsurance form = new frmNewInsurance();
                form.Text = "New Insurance";
                form.Show();
            }
            if (type.Equals("Payment"))
            {
                frmNewPayment form = new frmNewPayment();
                form.Text = "New Payment";
                form.Show();
            }
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            getSelectedIndex();
            string id;
            try
            {
                id = dgvList.Rows[index].Cells[0].Value.ToString();
            }catch(Exception e1)
            {
                return;
            }
            
            if (type.Equals("Car"))
            {
                frmEditCar form = new frmEditCar();
                form.Text = "Edit Car (ID:" + (id) + ")";
                form.Show();
            }
            if (type.Equals("Staff"))
            {
                frmEditStaff form = new frmEditStaff();
                form.Text = "Edit Staff (ID:" + (id) + ")";
                form.Show();
            }
            if (type.Equals("Order"))
            {
                Order order = db.GetOrderById(id);
                frmApproveOrder form = new frmApproveOrder(order);
                form.Text = "Approve (Order:" + (id) + ")";
                form.Show();
            }
            if (type.Equals("Manufacturer"))
            {
                frmEditManufacturer form = new frmEditManufacturer();
                form.Text = "Edit Manufacturer (ID:" + (id) + ")";
                form.Show();
            }
            if (type.Equals("Category"))
            {
                frmEditCategory form = new frmEditCategory();
                form.Text = "Edit Manufacturer (ID:" + (id) + ")";
                form.Show();
            }
            if (type.Equals("Insurance"))
            {
                frmEditInsurance form = new frmEditInsurance();
                form.Text = "Edit Insurance (ID:" + (id) + ")";
                form.Show();
            }
            if (type.Equals("Payment"))
            {
                frmEditPayment form = new frmEditPayment();
                form.Text = "Edit Payment (ID:" + (id) + ")";
                form.Show();
            }
        }

        private void dgvList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (type.Equals("Car"))
            {
                for (int i = 0; i < row - 1; i++)
                {
                    for (int j = 0; j < 9; j++)
                        if (dgvList.Rows[i].Cells[j].Selected == true)
                        {
                            dgvList.Rows[i].Selected = true;
                        }
                }
            }
            if (type.Equals("Manufacturer"))
            {
                for (int i = 0; i < row - 1; i++)
                {
                    for (int j = 0; j < 2; j++)
                        if (dgvList.Rows[i].Cells[j].Selected == true)
                        {
                            dgvList.Rows[i].Selected = true;
                        }
                }
            }
            if (type.Equals("Category"))
            {
                for (int i = 0; i < row - 1; i++)
                {
                    for (int j = 0; j < 2; j++)
                        if (dgvList.Rows[i].Cells[j].Selected == true)
                        {
                            dgvList.Rows[i].Selected = true;
                        }
                }
            }
            if (type.Equals("Order"))
            {
                for (int i = 0; i < row - 1; i++)
                {
                    for (int j = 0; j < 8; j++)
                        if (dgvList.Rows[i].Cells[j].Selected == true)
                        {
                            dgvList.Rows[i].Selected = true;
                        }
                }
            }
            if (type.Equals("Staff"))
            {
                for (int i = 0; i < row - 1; i++)
                {
                    for (int j = 0; j < 8; j++)
                        if (dgvList.Rows[i].Cells[j].Selected == true)
                        {
                            dgvList.Rows[i].Selected = true;
                        }
                }
            }
            if (type.Equals("Manager"))
            {
                for (int i = 0; i < row - 1; i++)
                {
                    for (int j = 0; j < 6; j++)
                        if (dgvList.Rows[i].Cells[j].Selected == true)
                        {
                            dgvList.Rows[i].Selected = true;
                        }
                }
            }
            if (type.Equals("Customer"))
            {
                for (int i = 0; i < row - 1; i++)
                {
                    for (int j = 0; j < 7; j++)
                        if (dgvList.Rows[i].Cells[j].Selected == true)
                        {
                            dgvList.Rows[i].Selected = true;
                        }
                }
            }
        }
    }
}
