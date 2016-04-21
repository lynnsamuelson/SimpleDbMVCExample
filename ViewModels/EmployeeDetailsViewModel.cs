using SimpleDbMVCExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleDbMVCExample.ViewModels
{
    public class EmployeeDetailsViewModel
    {
        public int EmployeeId { get; set; }
        public String Name { get; set; }
        public String Gender { get; set; }
        public String City { get; set; }
        public List<Employee> Employees { get; set; }
    }
}