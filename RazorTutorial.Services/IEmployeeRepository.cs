using RazorTutorial.Models;
using System.Collections.Generic;

namespace RazorTutorial.Services;

    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployee(int id);
        Employee Update(Employee updatedEmployee);
    }

