using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PMS.EF.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int Qty { get; set; }
        public System.DateTime Lasttime { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public Product()
        {
            OrderDetails = new List<OrderDetail>();
        }
    }
    }
