using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class MemberDTO
    {
        [Key]
        public int Id { get; set; }
        [StringLength(150)]
        public string Role { get; set; }
        [StringLength(500)]
        public string Name { get; set; }
    }
}
