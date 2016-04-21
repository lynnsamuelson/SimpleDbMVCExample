using SimpleDbMVCExample.Models;
using SimpleDbMVCExample.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleDbMVCExample.Controllers 
{
    public class DepartmentController : Controller
    {
        public ActionResult Index()
        {
            DepartmentContext _myDepartmentContext = new DepartmentContext();
            List<Department> departments = _myDepartmentContext.Department.OrderBy(a => a.DepartmentName).ToList();
            DepartmentDetailsViewModel departmentModel = new DepartmentDetailsViewModel
            {
                Departments = departments
            };
            return View(departmentModel);

        }
        public ActionResult Details()
        {
            DepartmentContext departmentContext = new DepartmentContext();
            Department department = departmentContext.Department.Where(emp => emp.DepartmentId == 1).FirstOrDefault();
            return View(department);
        }
    }
}