using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSource
{
    public class DataProgram
    {
        string strConnection;
        public DataProgram()
        {
            strConnection = getConnectionString();
        }
        public string getConnectionString()
        {
            string strConnection = "server=.;database=CarManager;uid=sa;pwd=12345678";
            return strConnection;
        }
        public string checkLogin(string username, string password)
        {
            string user = "";
            string SQL = "select * from Accounts where username_=@ID and password_=@Pass";
            SqlConnection cnn = new SqlConnection(strConnection);
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            cmd.Parameters.AddWithValue("@ID", username);
            cmd.Parameters.AddWithValue("@Pass", password);
            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    user = reader.GetValue(0).ToString();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return user;
        }
        //Car
        public DataTable GetCars()
        {
            string SQL = "select * from Cars_for_Sale";
            SqlConnection cnn = new SqlConnection(strConnection);
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtCar = new DataTable();
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                da.Fill(dtCar);
            }catch(SqlException se)
            {
                throw new Exception(se.Message);
            }
            finally
            {
                cnn.Close();
            }
            return dtCar;
        }
        public List<Car> ListCars()
        {
            List<Car> result = new List<Car>();
            string SQL = "select * from Cars_for_Sale";
            SqlConnection cnn = new SqlConnection(strConnection);
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Car tmp = new Car
                    {
                        car_for_Sale_ID_ = reader.GetValue(0).ToString(),
                        model_Name_ = reader.GetValue(1).ToString(), 
                        manufacturer_Code_ = reader.GetValue(2).ToString(),
                        category_Code_ = reader.GetValue(3).ToString(),
                        price_ = float.Parse(reader.GetValue(4).ToString()),
                        speed_=float.Parse(reader.GetValue(5).ToString()),
                        date_Accquired_=DateTime.Parse(reader.GetValue(6).ToString()),
                        registration_Year_=int.Parse(reader.GetValue(7).ToString()),
                        description_ = reader.GetValue(8).ToString(),
                        status_ = reader.GetValue(9).ToString()
                    };
                    result.Add(tmp);
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
        public bool AddNewCar(Car car)
        {
            bool result;
            SqlConnection cnn = new SqlConnection(strConnection);
            string SQL = "insert Cars_for_Sale values(@ID,@Name,@Manu,@Category,@Price,@Speed,@Date,@Year,@Desc,@Status)";
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            cmd.Parameters.AddWithValue("@ID", car.car_for_Sale_ID_);
            cmd.Parameters.AddWithValue("@Name", car.model_Name_);
            cmd.Parameters.AddWithValue("@Manu", car.manufacturer_Code_);
            cmd.Parameters.AddWithValue("@Category", car.category_Code_);
            cmd.Parameters.AddWithValue("@Price", car.price_);
            cmd.Parameters.AddWithValue("@Speed", car.speed_);
            cmd.Parameters.AddWithValue("@Date", car.date_Accquired_);
            cmd.Parameters.AddWithValue("@Year", car.registration_Year_);
            cmd.Parameters.AddWithValue("@Desc", car.description_);
            cmd.Parameters.AddWithValue("@Status", car.status_);
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                result = cmd.ExecuteNonQuery() > 0;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
        public bool UpdateCar(Car car)
        {
            SqlConnection cnn = new SqlConnection(strConnection);
            string SQL = "update Cars_for_Sale set model_Name_=@Name,manufacturer_Code_=@Manu,category_Code_=@Category,price_=@Price,speed_=@Speed,date_Accquired_=@Date,registration_Year_=@Year,description_=@Desc,status_=@Status where car_for_Sale_ID_=@ID";
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            cmd.Parameters.AddWithValue("@ID", car.car_for_Sale_ID_);
            cmd.Parameters.AddWithValue("@Name", car.model_Name_);
            cmd.Parameters.AddWithValue("@Manu", car.manufacturer_Code_);
            cmd.Parameters.AddWithValue("@Category", car.category_Code_);
            cmd.Parameters.AddWithValue("@Price", car.price_);
            cmd.Parameters.AddWithValue("@Speed", car.speed_);
            cmd.Parameters.AddWithValue("@Date", car.date_Accquired_);
            cmd.Parameters.AddWithValue("@Year", car.registration_Year_);
            cmd.Parameters.AddWithValue("@Desc", car.description_);
            cmd.Parameters.AddWithValue("@Status", car.status_);
            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
            int count = cmd.ExecuteNonQuery();
            return (count > 0);
        }
        public bool DeleteCar(string id)
        {
            bool result;
            SqlConnection cnn = new SqlConnection(strConnection);
            string SQL = "delete Cars_for_Sale where car_for_Sale_ID_=@ID";
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            cmd.Parameters.AddWithValue("@ID", id);
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                result = cmd.ExecuteNonQuery() > 0;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
        //Category
        public DataTable GetCategories()
        {
            string SQL = "select * from Car_Categories";
            SqlConnection cnn = new SqlConnection(strConnection);
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtCategory = new DataTable();
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                da.Fill(dtCategory);
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
            finally
            {
                cnn.Close();
            }
            return dtCategory;
        }
        public List<Car_Category> ListCategories()
        {
            List<Car_Category> result = new List<Car_Category>();
            string SQL = "select * from Car_Categories";
            SqlConnection cnn = new SqlConnection(strConnection);
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Car_Category tmp = new Car_Category
                    {
                        category_Code_ = reader.GetValue(0).ToString(),
                        category_Name_ = reader.GetValue(1).ToString(),
                        description_ = reader.GetValue(2).ToString()
                    };
                    result.Add(tmp);
                }          
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
        public bool AddNewCategory(Car_Category category)
        {
            bool result;
            SqlConnection cnn = new SqlConnection(strConnection);
            string SQL = "insert Car_Categories values(@Code,@Name,@Desc)";
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            cmd.Parameters.AddWithValue("@Code", category.category_Code_);
            cmd.Parameters.AddWithValue("@Name", category.category_Name_);
            cmd.Parameters.AddWithValue("@Desc", category.description_);
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                result = cmd.ExecuteNonQuery() > 0;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
        public bool UpdateCategory(Car_Category category)
        {
            SqlConnection cnn = new SqlConnection(strConnection);
            string SQL = "update Car_Categories set category_Name_=@Name,description_=@Desc where category_Code_=@Code";
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            cmd.Parameters.AddWithValue("@Code", category.category_Code_);
            cmd.Parameters.AddWithValue("@Name", category.category_Name_);
            cmd.Parameters.AddWithValue("@Desc", category.description_);
            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
            int count = cmd.ExecuteNonQuery();
            return (count > 0);
        }
        
        //Manufacturer
        public DataTable GetManufacturers()
        {
            string SQL = "select * from Car_Manufacturers";
            SqlConnection cnn = new SqlConnection(strConnection);
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtManufacturer = new DataTable();
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                da.Fill(dtManufacturer);
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
            finally
            {
                cnn.Close();
            }
            return dtManufacturer;
        }
        public bool AddNewManufacturer(Car_Manufacturer manu)
        {
            bool result;
            SqlConnection cnn = new SqlConnection(strConnection);
            string SQL = "insert Car_Manufacturers values(@Code,@Name,@Desc)";
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            cmd.Parameters.AddWithValue("@Code", manu.manufacturer_Code_);
            cmd.Parameters.AddWithValue("@Name", manu.manufacturer_Name_);
            cmd.Parameters.AddWithValue("@Desc", manu.description_);        
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                result = cmd.ExecuteNonQuery() > 0;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
        public bool UpdateManufacturer(Car_Manufacturer manu)
        {
            SqlConnection cnn = new SqlConnection(strConnection);
            string SQL = "update Car_Manufacturers set manufacturer_Name_=@Name,description_=@Desc where manufacturer_Code_=@Code";
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            cmd.Parameters.AddWithValue("@Code", manu.manufacturer_Code_);
            cmd.Parameters.AddWithValue("@Name", manu.manufacturer_Name_);
            cmd.Parameters.AddWithValue("@Desc", manu.description_);
            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
            int count = cmd.ExecuteNonQuery();
            return (count > 0);
        }
        
        public List<Car_Manufacturer> ListManufacturers()
        {
            List<Car_Manufacturer> result = new List<Car_Manufacturer>();
            string SQL = "select * from Car_Manufacturers";
            SqlConnection cnn = new SqlConnection(strConnection);
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Car_Manufacturer tmp = new Car_Manufacturer
                    {
                        manufacturer_Code_ = reader.GetValue(0).ToString(),
                        manufacturer_Name_ = reader.GetValue(1).ToString(),
                        description_ = reader.GetValue(2).ToString()
                    };
                    result.Add(tmp);
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
        public DataTable GetStaffs()
        {
            string SQL = "select * from Staffs";
            SqlConnection cnn = new SqlConnection(strConnection);
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtStaff = new DataTable();
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                da.Fill(dtStaff);
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
            finally
            {
                cnn.Close();
            }
            return dtStaff;
        }
        
        
        public bool AddNewStaff(Staff staff)
        {
            bool result;
            SqlConnection cnn = new SqlConnection(strConnection);
            string SQL = "insert Staffs values(@ID,@Name,@Gender,@Age,@Address,@Phone,@Email,@Position)";
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            cmd.Parameters.AddWithValue("@ID", staff.staff_ID_);
            cmd.Parameters.AddWithValue("@Name", staff.fullname_);
            cmd.Parameters.AddWithValue("@Gender", staff.gender_);
            cmd.Parameters.AddWithValue("@Age", staff.age_);
            cmd.Parameters.AddWithValue("@Address", staff.address_);
            cmd.Parameters.AddWithValue("@Phone", staff.phone_);
            cmd.Parameters.AddWithValue("@Email", staff.email_);
            cmd.Parameters.AddWithValue("@Position", staff.position_);
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                result = cmd.ExecuteNonQuery() > 0;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
        public List<Staff> ListStaff()
        {
            List<Staff> result = new List<Staff>();
            string SQL = "select * from Staffs";
            SqlConnection cnn = new SqlConnection(strConnection);
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Staff tmp = new Staff
                    {
                        staff_ID_ = reader.GetValue(0).ToString(),
                        fullname_ = reader.GetValue(1).ToString(),
                        gender_ = reader.GetValue(2).ToString(),
                        age_ = int.Parse(reader.GetValue(3).ToString()),
                        address_ = reader.GetValue(4).ToString(),
                        phone_ = decimal.Parse(reader.GetValue(5).ToString()),
                        email_ = reader.GetValue(6).ToString(),
                        position_ = reader.GetValue(7).ToString()
                    };
                    result.Add(tmp);
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
        public bool DeleteStaff(string id)
        {
            bool result;
            SqlConnection cnn = new SqlConnection(strConnection);
            string SQL = "delete Staffs where staff_ID_=@ID";
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            cmd.Parameters.AddWithValue("@ID", id);
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                result = cmd.ExecuteNonQuery() > 0;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
        public bool UpdateStaff(Staff staff)
        {
            SqlConnection cnn = new SqlConnection(strConnection);
            string SQL = "update Staffs set fullname_=@Name,gender_=@Gender,age_=@Age,address_=@Address,phone_=@Phone,email_=@Email,position_=@Position where staff_ID_=@ID";
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            cmd.Parameters.AddWithValue("@ID", staff.staff_ID_);
            cmd.Parameters.AddWithValue("@Name", staff.fullname_);
            cmd.Parameters.AddWithValue("@Gender", staff.gender_);
            cmd.Parameters.AddWithValue("@Age", staff.age_);
            cmd.Parameters.AddWithValue("@Address", staff.address_);
            cmd.Parameters.AddWithValue("@Phone", staff.phone_);
            cmd.Parameters.AddWithValue("@Email", staff.email_);
            cmd.Parameters.AddWithValue("@Position", staff.position_);
            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
            int count = cmd.ExecuteNonQuery();
            return (count > 0);
        }
        //Manager
        public DataTable GetManagers()
        {
            string SQL = "select * from Accounts";
            SqlConnection cnn = new SqlConnection(strConnection);
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtManager = new DataTable();
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                da.Fill(dtManager);
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
            finally
            {
                cnn.Close();
            }
            return dtManager;
        } 
        public bool UpdateAccount(Account item)
        {
            SqlConnection cnn = new SqlConnection(strConnection);
            string SQL = "update Accounts set password_=@Pass,fullname_=@Name,gender_=@Gender,address_=@Addr,age_=@Age,phone_=@Phone,email_=@Email where username_=@User";
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            cmd.Parameters.AddWithValue("@User", item.username_);
            cmd.Parameters.AddWithValue("@Pass", item.password_);
            cmd.Parameters.AddWithValue("@Name", item.fullname_);
            cmd.Parameters.AddWithValue("@Gender", item.gender_);
            cmd.Parameters.AddWithValue("@Addr", item.address_);
            cmd.Parameters.AddWithValue("@Age", item.age_);
            cmd.Parameters.AddWithValue("@Phone", item.phone_);
            cmd.Parameters.AddWithValue("@Email", item.email_);
            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
            int count = cmd.ExecuteNonQuery();
            return (count > 0);
        }
        
        public Account getAccount(string user)
        {
            Account result=new Account();
            string SQL = "select * from Accounts where username_=@User";
            SqlConnection cnn = new SqlConnection(strConnection);
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            cmd.Parameters.AddWithValue("@User", user);
            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    result.username_ = user;
                    result.password_ = reader.GetValue(1).ToString();
                    result.fullname_= reader.GetValue(2).ToString();
                    result.gender_ = reader.GetValue(3).ToString();
                    result.address_ = reader.GetValue(4).ToString();
                    result.age_ = int.Parse(reader.GetValue(5).ToString());
                    result.phone_ = decimal.Parse(reader.GetValue(6).ToString());
                    result.email_ = reader.GetValue(7).ToString();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
        public DataTable GetCustomers()
        {
            string SQL = "select * from Customers";
            SqlConnection cnn = new SqlConnection(strConnection);
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtCust = new DataTable();
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                da.Fill(dtCust);
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
            finally
            {
                cnn.Close();
            }
            return dtCust;
        }
        public List<Customer> ListCustomer()
        {   
            List<Customer> result = new List<Customer>();
            string SQL = "select * from Customers";
            SqlConnection cnn = new SqlConnection(strConnection);
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Customer tmp = new Customer
                    {
                        customer_ID_ = reader.GetValue(0).ToString(),
                        fullname_ = reader.GetValue(1).ToString(),
                        gender_ = reader.GetValue(2).ToString(),
                        age_ = int.Parse(reader.GetValue(3).ToString()),
                        address_ = reader.GetValue(4).ToString(),
                        phone_ = decimal.Parse(reader.GetValue(5).ToString()),
                        email_ = reader.GetValue(6).ToString(),
                    };
                    result.Add(tmp);
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
        //Payment
        public DataTable GetPayments()
        {
            string SQL = "select * from Customer_Payments";
            SqlConnection cnn = new SqlConnection(strConnection);
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtPayment = new DataTable();
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                da.Fill(dtPayment);
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
            finally
            {
                cnn.Close();
            }
            return dtPayment;
        }
        public List<Payment> ListPayment()
        {
            List<Payment> result = new List<Payment>();
            string SQL = "select * from Customer_Payments";
            SqlConnection cnn = new SqlConnection(strConnection);
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Payment tmp = new Payment
                    {
                        payment_ID_ = reader.GetValue(0).ToString(),
                        type_ = reader.GetValue(1).ToString(),
                        description_ = reader.GetValue(2).ToString()
                    };
                    result.Add(tmp);
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
        public bool AddNewPayment(Payment item)
        {
            bool result;
            SqlConnection cnn = new SqlConnection(strConnection);
            string SQL = "insert Customer_Payments values(@ID,@Type,@Desc)";
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            cmd.Parameters.AddWithValue("@ID", item.payment_ID_);
            cmd.Parameters.AddWithValue("@Type", item.type_);
            cmd.Parameters.AddWithValue("@Desc", item.description_);
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                result = cmd.ExecuteNonQuery() > 0;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
        public bool UpdatePayment(Payment item)
        {
            SqlConnection cnn = new SqlConnection(strConnection);
            string SQL = "update Customer_Payments set type_=@Type,description_=@Desc where payment_ID_=@ID";
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            cmd.Parameters.AddWithValue("@ID", item.payment_ID_);
            cmd.Parameters.AddWithValue("@Type", item.type_);
            cmd.Parameters.AddWithValue("@Desc", item.description_);
            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
            int count = cmd.ExecuteNonQuery();
            return (count > 0);
        }
        //Insurance
        public DataTable GetInsurance()
        {
            string SQL = "select * from Insurance_Companies";
            SqlConnection cnn = new SqlConnection(strConnection);
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtItem = new DataTable();
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                da.Fill(dtItem);
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
            finally
            {
                cnn.Close();
            }
            return dtItem;
        }
        public List<Insurance> ListInsurance()
        {
            List<Insurance> result = new List<Insurance>();
            string SQL = "select * from Insurance_Companies";
            SqlConnection cnn = new SqlConnection(strConnection);
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Insurance tmp = new Insurance
                    {
                        insurance_Company_ID_ = reader.GetValue(0).ToString(),
                        insurance_Company_Name_ = reader.GetValue(1).ToString(),
                        description_ = reader.GetValue(2).ToString()
                    };
                    result.Add(tmp);
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
        public bool AddNewInsurance(Insurance ins)
        {
            bool result;
            SqlConnection cnn = new SqlConnection(strConnection);
            string SQL = "insert Insurance_Companies values(@ID,@Name,@Desc)";
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            cmd.Parameters.AddWithValue("@ID", ins.insurance_Company_ID_);
            cmd.Parameters.AddWithValue("@Name", ins.insurance_Company_Name_);
            cmd.Parameters.AddWithValue("@Desc", ins.description_);
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                result = cmd.ExecuteNonQuery() > 0;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
        public bool UpdateInsurance(Insurance item)
        {
            SqlConnection cnn = new SqlConnection(strConnection);
            string SQL = "update Insurance_Companies set insurance_Company_Name_=@Name,description_=@Desc where insurance_Company_ID_=@Code";
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            cmd.Parameters.AddWithValue("@Code", item.insurance_Company_ID_);
            cmd.Parameters.AddWithValue("@Name", item.insurance_Company_Name_);
            cmd.Parameters.AddWithValue("@Desc", item.description_);
            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
            int count = cmd.ExecuteNonQuery();
            return (count > 0);
        }
        public DataTable GetOrders()
        {
            string SQL = "select * from Orders";
            SqlConnection cnn = new SqlConnection(strConnection);
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtOrder = new DataTable();
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                da.Fill(dtOrder);
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
            finally
            {
                cnn.Close();
            }
            return dtOrder;
        }
        public List<Order> ListOrder()
        {
            List<Order> result = new List<Order>();
            string SQL = "select * from Orders";
            SqlConnection cnn = new SqlConnection(strConnection);
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Order tmp = new Order
                    {
                        order_ID_ = reader.GetValue(0).ToString(),
                        customer_ID_ = reader.GetValue(1).ToString(),
                        payment_ID_ = reader.GetValue(2).ToString(),
                        insurance_Company_ID_ = reader.GetValue(3).ToString(),
                        total_money_ = float.Parse(reader.GetValue(4).ToString()),
                        date_order_ = DateTime.Parse(reader.GetValue(5).ToString()),
                        description_ = reader.GetValue(6).ToString(),
                        status_ = reader.GetValue(7).ToString(),
                    };
                    result.Add(tmp);
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
        public Order GetOrderById(string id)
        {
            Order result = new Order();
            string SQL = "select * from Orders where order_ID_=@ID";
            SqlConnection cnn = new SqlConnection(strConnection);
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            cmd.Parameters.AddWithValue("@ID", id);
            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    result = new Order
                    {
                        order_ID_ = reader.GetValue(0).ToString(),
                        customer_ID_ = reader.GetValue(1).ToString(),
                        payment_ID_ = reader.GetValue(2).ToString(),
                        insurance_Company_ID_ = reader.GetValue(3).ToString(),
                        total_money_ = float.Parse(reader.GetValue(4).ToString()),
                        date_order_ = DateTime.Parse(reader.GetValue(5).ToString()),
                        description_ = reader.GetValue(6).ToString(),
                        status_ = reader.GetValue(7).ToString(),
                    };
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
        public DataTable GetOrderDetails(string id)
        {
            string SQL = "select * from Order_Details where order_ID_=@ID";
            SqlConnection cnn = new SqlConnection(strConnection);
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            cmd.Parameters.AddWithValue("@ID", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtOrderDetails = new DataTable();
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                da.Fill(dtOrderDetails);
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
            finally
            {
                cnn.Close();
            }
            return dtOrderDetails;
        }
        public bool UpdateStatusOrder(string id, string status)
        {
            SqlConnection cnn = new SqlConnection(strConnection);
            string SQL = "update Orders set status_=@Status where order_ID_=@ID";
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.Parameters.AddWithValue("@Status", status);
            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
            int count = cmd.ExecuteNonQuery();
            return (count > 0);
        }
        public DataSet GetOrderDetails()
        {
            string SQL = "select * from Order_Details";
            SqlConnection cnn = new SqlConnection(strConnection);
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dsOrderDetails = new DataSet();
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                da.Fill(dsOrderDetails);
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
            finally
            {
                cnn.Close();
            }
            return dsOrderDetails;
        }

        public int countQtt(string id)
        {
            int count = 0;
            string SQL = "select * from Order_Details where order_ID_=@ID";
            SqlConnection cnn = new SqlConnection(strConnection);
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            cmd.Parameters.AddWithValue("@ID", id);
            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    count += int.Parse(reader.GetValue(3).ToString());          
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return count;
        }
        public double countMoney(string id)
        {
            double total = 0;
            string SQL = "select * from Orders where order_ID_=@ID";
            SqlConnection cnn = new SqlConnection(strConnection);
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            cmd.Parameters.AddWithValue("@ID", id);
            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    total += float.Parse(reader.GetValue(4).ToString());
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return total;
        }
    }
}
