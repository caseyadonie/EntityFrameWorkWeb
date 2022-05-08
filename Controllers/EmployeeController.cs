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

            try
            {
                if (!String.IsNullOrEmpty(eInfo.surName))
                {
                    _context.Add(eInfo);
                    int result = _context.SaveChanges();

                    List();
                    return View("List");
                }
            }
            catch (Exception ex)
            {

               
            }

            return View();
        }
        public IActionResult List()
        {
            object eList=  _context.EmployeeDetailsList;
            return View(eList);
        }
        public IActionResult deleteEmployeeRecord(int Id)
        {
            EmployeesDetailsInfo esInfo = _context.EmployeeDetailsList.Where(x => x.Id == Id).FirstOrDefault();
            _context.Remove(esInfo);
            int result = _context.SaveChanges();

            string url = this.Url.Action("List", "Employee");
            
            return Json(url);

        }
    }

}
