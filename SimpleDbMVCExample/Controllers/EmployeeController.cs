using SimpleDbMVCExample.Controllers;
using SimpleDbMVCExample.Models;
using SimpleDbMVCExample.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleDbMVCExample.Controllers
{
    public class EmployeeController : Controller
    {

        public ActionResult Index()
        {
            EmployeeContext _myEmployeeContext = new EmployeeContext();
            
                var employeeDetails = (from emp in _myEmployeeContext.Employee
                                       join dept in _myEmployeeContext.Department
                                       on emp.DepartmentId equals dept.DepartmentId
                                       orderby dept.DepartmentName
                                       select new EmployeeDetailViewModel
                                       {
                                           Name = emp.Name ,
                                           DempartmentName = dept.DepartmentName
                                       }).ToList();


            EmployeeDepartmentDetailsViewModel employeeDepartmentDetails = new EmployeeDepartmentDetailsViewModel
            {
                Employees = employeeDetails
            };
            return View(employeeDepartmentDetails);

        }
       
    }
}
