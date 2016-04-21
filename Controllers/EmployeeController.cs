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
            List<Employee> employees = _myEmployeeContext.Employee.OrderBy(a => a.Name).ToList();
            //Employee myEmployee = new Employee();
            //DepartmentContext _myDepartmentContext = new DepartmentContext();
            //List<Department> departments = _myDepartmentContext.Department.OrderBy(a => a.DepartmentName).ToList();
            //var query = 
            //     from Employee in EmployeeContext join Department in 
            //     //where  Employee.DepartmentId == _myEmployeeContext.Department.DepartmentId
            //     join meta in _myEmployeeContext.Department on DepartmentId equals meta.DepartmentId
            //     where Department.DepartmentId == id

                var query = (from emp in _myEmployeeContext.Employee
                                       join dept in _myEmployeeContext.Department
                                       on emp.DepartmentId equals dept.DepartmentId
                                       orderby dept.DepartmentName
                                       select new
                                       {
                                           emp.Name,
                                           emp.Gender,
                                           DepartmentName = dept.DepartmentName
                                       }).ToList();

             /*var query =
   from post in database.Posts
   join meta in database.Post_Metas on post.ID equals meta.Post_ID
   where post.ID == id
   select new { Post = post, Meta = meta };*/

            //should just need the _myEmployeeContext


            EmployeeDetailsViewModel employeeModel = new EmployeeDetailsViewModel
            {
                Employees = employees
            };
            return View(employeeModel);

        }
        public ActionResult Details()
        {
            EmployeeContext employeeContext = new EmployeeContext();
            Employee employee = employeeContext.Employee.Where(emp => emp.EmployeeId == 1).FirstOrDefault();
            return View(employee);
        }
    }
}
