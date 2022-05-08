using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EFMVCTestApp.Models
{
    [Table("EmployeesSalaryTbl")]
    public class EmployeesSalaryInfo
    {
        [Key]
        public int Id { get; set; }
        public int EmpDFId { get; set; }
        public decimal BasicSalary { get; set; }
        public decimal Deductions { get; set; }
        public decimal AmountPaid { get; set; }
    }
}
