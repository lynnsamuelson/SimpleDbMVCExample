using SimpleDbMVCExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleDbMVCExample.ViewModels
{
    public class DepartmentDetailsViewModel
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public int DepartmentSize { get; set; }
        public string DepartmentLocation { get; set; }
        public List<Department> Departments { get; set; }
    }
}