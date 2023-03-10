using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorTutorial.Services;
using RazorTutorial.Models;

namespace RazorTutorial.Pages.Employees
{
    public class DetailsModel : PageModel
    {
        private readonly IEmployeeRepository employeeRepository;
        public DetailsModel(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        [TempData]
        public string Message { get; set; } 

        public Employee Employee {get; private set;}

        //[BindProperty(SupportsGet= true)]
        //public int Id { get; set; }

        public IActionResult OnGet(int id)
        {
            //Id = id;
            Employee = employeeRepository.GetEmployee(id);
            if(Employee==null)
            {
                return RedirectToPage("/NotFound");
            }
            return Page();
        }
    }
}
