using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.MODELS
{
    public class Member
    {
        [Key]
        public int Id { get; set; }
        [StringLength(150)]
        public string Role { get; set; }
        [StringLength(500)]
        public string Name { get; set; }



        public virtual Project Project { get; set; }
    }
}
