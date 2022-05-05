using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFMVCTestApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace EFMVCTestApp.Controllers
{
    public class EmployeeController : Controller
    {
        private EmployeeDBCtx _context;
        public EmployeeController(EmployeeDBCtx context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create(EmployeesDetailsInfo eInfo)
        {
            /* if (!ModelState.IsValid)
             {
                 _context.Add(eInfo);
                 int result = _context.SaveChanges();
             }*/
            if (!String.IsNullOrEmpty(eInfo.surName))
            {
                _context.Add(eInfo);
                int result = _context.SaveChanges();
            }

            return View();
        }
        public IActionResult List()
        {
            object eList=  _context.EmployeeDetailsList;
            return View(eList);
        }
    }

}
