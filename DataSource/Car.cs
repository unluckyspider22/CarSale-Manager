using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSource
{
    public class Car
    {
        public string car_for_Sale_ID_ { get; set; }
        public string model_Name_ { get; set; }
        public string manufacturer_Code_ { get; set; }
        public string category_Code_ { get; set; }
        public float price_ { get; set; }
        public float speed_ { get; set; }
        public DateTime date_Accquired_ { get; set; }
        public int registration_Year_ { get; set; }
        public string description_ { get; set; }
        public string status_ { get; set; }
    }
}
