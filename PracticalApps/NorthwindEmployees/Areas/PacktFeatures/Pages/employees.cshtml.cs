using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Packt.Shared;

namespace PacktFeatures.Pages
{
    public class EmployeePagesModel : PageModel
    {
        private Northwind db;
        public EmployeePagesModel(Northwind injectedContext)
        {
            db = injectedContext;
        }
        public IEnumerable<Employee> Employees {get;set;}

        public void OnGet()
        {
            Employees = db.Employees.ToArray();
        }
    }
}
