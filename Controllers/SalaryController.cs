using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFMVCTestApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace EFMVCTestApp.Controllers
{
 
    public class SalaryController : Controller
    {
        private EmployeeDBCtx _context;
        public SalaryController(EmployeeDBCtx context)
        {
            _context = context;
        }
        
        public IActionResult List()
        {
            object eList = _context.EmployeesSalaryList;
            return View(eList);
        }
        public IActionResult Create(int Id)
        {
            try
            {
               
                if (Id > 0)
                {
                    EmployeesDetailsInfo eInfo = returnEmployeesInfo(Id);
                    ViewBag.EmpDFId = Id;
                    ViewBag.Names = (eInfo.surName + " " + eInfo.otherNames);
                   
                    return View();
                }

            }
            catch (Exception ex)
            {


            }

            return View();
        }
        public IActionResult SaveRecord(EmployeesSalaryInfo esInfo)
        {
            try
            {
                if (esInfo.AmountPaid > 0)
                {

                    _context.Add(esInfo);
                    int result = _context.SaveChanges();
                    List();
                    return View("List");
                }
                
               
            }
            catch (Exception ex)
            {

                
            }
            
            return View("Create");
        }
        private EmployeesDetailsInfo returnEmployeesInfo(int Id)
        {
            EmployeesDetailsInfo employeeInfo = _context.EmployeeDetailsList.Where(x => x.Id == Id).FirstOrDefault();
           
            return employeeInfo;
        }
        public IActionResult deleteSalaryRecord(int Id)
        {
            EmployeesSalaryInfo esInfo = _context.EmployeesSalaryList.Where(x => x.Id == Id).FirstOrDefault();
            _context.Remove(esInfo);
            int result = _context.SaveChanges();

            string url = this.Url.Action("List", "Salary");
            //string url = this.Url.Action("List", "Salary", new { id = Id });
            //List();
            return Json(url);
            
        }
    }
   
}
