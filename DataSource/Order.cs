using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSource
{
    public class Order
    {
        public string order_ID_ { get; set; }
        public string customer_ID_ { get; set; }
        public string payment_ID_ { get; set; }
        public string insurance_Company_ID_ { get; set; }
        public float total_money_ { get; set; }
        public DateTime date_order_ { get; set; }
        public string description_ { get; set; }
        public string status_ { get; set; }
    }
}
