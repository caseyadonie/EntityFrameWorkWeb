using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EFMVCTestApp.Models
{
    [Table("EmployeeTbl")]
    public class EmployeesDetailsInfo
    {
       
        [Key]
        public int Id { get; set; }
       [StringLength(50)]
        public string surName { get; set; }
        public string otherNames { get; set; }
        
        [Required]
        
        [Display(Name = "Grade Level")]
        public string GradeLevel{ set; get; }
        [NotMapped]
        public IEnumerable<SelectListItem> GradeLevelList { set; get; }
    }
}
