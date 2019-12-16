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
    public partial class frmApproveOrder : Form
    {
        DataProgram db = new DataProgram();
        Order order = new Order();
        List<Customer> listCustomer;
        List<Payment> listPayment;
        List<Insurance> listInsurance;
        List<Car> listCar;
        int row;
        public frmApproveOrder(Order order)
        {
            InitializeComponent();
            this.order = order;
            listCustomer = db.ListCustomer();
            listPayment = db.ListPayment();
            listInsurance = db.ListInsurance();
            listCar = db.ListCars();
            barManager1.AllowCustomization = false;
            barManager1.AllowQuickCustomization = false;
            barManager1.AllowShowToolbarsPopup = false;
        }

        private void frmApproveOrder_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < listCustomer.Count; i++)
            {
                if (order.customer_ID_.Equals(listCustomer.ElementAt(i).customer_ID_))
                {
                    txtCustomer.Text = listCustomer.ElementAt(i).fullname_;
                }
            }
            for (int i = 0; i < listPayment.Count; i++)
            {
                if (order.payment_ID_.Equals(listPayment.ElementAt(i).payment_ID_))
                {
                    txtPayment.Text = listPayment.ElementAt(i).type_;
                }
            }
            for (int i = 0; i < listInsurance.Count; i++)
            {
                if (order.insurance_Company_ID_.Equals(listInsurance.ElementAt(i).insurance_Company_ID_))
                {
                    txtInsurance.Text = listInsurance.ElementAt(i).insurance_Company_Name_;
                }
            }
            txtTotal.Text = order.total_money_.ToString();
            txtDate.Text = order.date_order_.ToString();
            txtDesc.Text = order.description_;
            dgvDetail.DataSource = null;
            dgvDetail.DataSource = db.GetOrderDetails(order.order_ID_);
            row = dgvDetail.RowCount;
            dgvDetail.Rows[0].Selected = true;
            dgvDetail.Columns[0].Visible = false;
            dgvDetail.Columns[1].HeaderText = "Car";
            dgvDetail.Columns[2].HeaderText = "Price";
            dgvDetail.Columns[3].HeaderText = "Quantity";
            dgvDetail.Columns[4].HeaderText = "Discount";
            dgvDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            for (int i = 0; i < row-1; i++)
            {
                string tmp = dgvDetail.Rows[i].Cells[1].Value.ToString();
                for (int j = 0; j < listCar.Count; j++)
                {
                    if (tmp.Equals(listCar.ElementAt(j).car_for_Sale_ID_))
                    {
                        dgvDetail.Rows[i].Cells[1].Value = listCar.ElementAt(j).model_Name_;
                    }
                }
            }
            cbStatus.Items.Add("deposited");
            cbStatus.Items.Add("deliverd");
            cbStatus.Items.Add("approved");
            for(int i = 0; i < 3; i++)
            {
                if (order.status_.Equals(cbStatus.Items[i]))
                {
                    cbStatus.SelectedItem = cbStatus.Items[i];
                }
            }    
            dgvDetail.ReadOnly = true;
        }

        private void btnApprove_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string status = cbStatus.Text;
            if (db.UpdateStatusOrder(order.order_ID_, status))
            {
                MessageBox.Show("Updated!", "Approve");
                this.Close();
            }
            else
            {
                MessageBox.Show("Fail approve!", "Approve");
            }
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
