using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PMS.EF.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Qty { get; set; }
        public string Location { get; set; }
        public System.DateTime Lasttime { get; set; }
        public virtual Order Order { get; set; }
        public virtual Product Product{ get; set; }
    }
}