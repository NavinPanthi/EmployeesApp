using System;
using RazorTutorial.Models;
namespace RazorTutorial.Services
{
	public class MockEmployeeRepository : IEmployeeRepository
	{
		private List<Employee> _employeeList;

		public MockEmployeeRepository()
		{
			_employeeList = new List<Employee>()
			{
				new Employee{ID=1, Name="Kiran Tiwari", Department=Dept.HR, Email="kiran567@gmail.com",PhotoPath="kiran.png" },
                new Employee{ID=2, Name="Sushil Tiwari", Department=Dept.HR, Email="sushil567@gmail.com",PhotoPath="sushil.png" },
                new Employee{ID=3, Name="Prabin Gurung", Department=Dept.HR, Email= "prabin567@gmail.com",PhotoPath="prabin.png" },
                new Employee{ID=4, Name="Sanjok Sunam", Department=Dept.HR, Email="sunam567@gmail.com",PhotoPath="sanjok.png" },
            };
		}
		public IEnumerable<Employee> GetAllEmployees()
		{
			return _employeeList;
		}
	}
}

