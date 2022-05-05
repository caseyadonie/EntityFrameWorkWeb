using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFMVCTestApp.Models
{
    public class EmployeesDetailsInfo
    {
        [Key]
        public int Id { get; set; }
       [StringLength(50)]
        public string surName { get; set; }
        public string otherNames { get; set; }
        public string Level { get; set; }

    }
}
