using System;
using System.ComponentModel.DataAnnotations;
namespace RazorTutorial.Models;

public class Employee
{

    public int Id { get; set; }

    [Required, MinLength(3, ErrorMessage = "Name must contain at least 3 characters")]
    public String Name { get; set; }

    [Display(Name = "Office Email")]
    [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",
    ErrorMessage = "Invalid email format")]
    public String Email { get; set; }

    public String PhotoPath { get; set; }

    [Required]
    public Dept Department{get; set;}
	
}

