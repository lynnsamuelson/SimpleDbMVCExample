using SimpleDbMVCExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleDbMVCExample.ViewModels
{
    public class EmployeeDepartmentDetailsViewModel
    {
        public List<EmployeeDetailViewModel> Employees { get; set; }
    }
}