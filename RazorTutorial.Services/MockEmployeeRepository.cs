﻿using System;
using RazorTutorial.Models;
using System.Linq;
namespace RazorTutorial.Services
{
	public class MockEmployeeRepository : IEmployeeRepository
	{
		private List<Employee> _employeeList;

		public MockEmployeeRepository()
		{
			_employeeList = new List<Employee>()
			{
				new Employee{Id=1, Name="Kiran Tiwari", Department=Dept.HR, Email="kiran567@gmail.com",PhotoPath="kiran.jpeg" },
                new Employee{Id=2, Name="Sushil Tiwari", Department=Dept.HR, Email="sushil567@gmail.com",PhotoPath="sushil.jpeg" },
                new Employee{Id=3, Name="Rashmi kc", Department=Dept.HR, Email= "rashmi567@gmail.com",PhotoPath="rashmi.jpeg" },
                new Employee{Id=4, Name="Sanjok Sunam", Department=Dept.HR, Email="sunam567@gmail.com" },
            };
		}
		public IEnumerable<Employee> GetAllEmployees()
		{
			return _employeeList;
		}
		public  Employee GetEmployee(int id)
		{
			return _employeeList.FirstOrDefault(e => e.Id == id);
		}
	}
}

