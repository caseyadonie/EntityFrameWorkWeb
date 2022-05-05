using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFMVCTestApp.Models
{
    public class EmployeeDBCtx : DbContext
    {
        public EmployeeDBCtx(DbContextOptions<EmployeeDBCtx> options) : base(options)
        {

        }
        public DbSet<EmployeesDetailsInfo> EmployeeDetailsList { get; set; }
        public DbSet<EmployeesSalaryInfo> EmployeesSalaryList { get; set; }
    }
}
