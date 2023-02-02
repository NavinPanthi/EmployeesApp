using System;
namespace RazorTutorial.Models
{
	public class Employee
	{
		
		public int ID { get; set; }
		public String Name { get; set; }
		public String Email { get; set; }
		public String PhotoPath { get; set; }
		public Dept Department{get; set;}
		
	}
}

