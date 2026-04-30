using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class DepartmentDTO
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public  int Name { get; set; }
    }
}
