using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleDbMVCExample.Models
{
	public class Employee
    {
        public int EmployeeId { get; set; }
        public String Name { get; set; }
        public int DepartmentId { get; set; }
    }
}