using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PMS.EF.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public System.DateTime Lasttime { get; set; }
        public string Location { get; set; }

        public int Qty { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public Order() {
            OrderDetails = new List<OrderDetail>();
        }
    }
}