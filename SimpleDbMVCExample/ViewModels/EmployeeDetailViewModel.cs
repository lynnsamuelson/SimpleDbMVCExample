using SimpleDbMVCExample.Models;
using SimpleDbMVCExample.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleDbMVCExample.ViewModels
{
    public class EmployeeDetailViewModel
    {
        public int EmployeeId { get; set; }
        public String Name { get; set; }
        public String DempartmentName { get; set; }
        
    }
}