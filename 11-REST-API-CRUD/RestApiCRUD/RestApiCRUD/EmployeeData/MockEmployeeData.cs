using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestApiCRUD.Models;

namespace RestApiCRUD.EmployeeData
{
    public class MockEmployeeData : IEmployeeData
    {
        private List<Employee> _defaultEmployees = new List<Employee>()
        {
            new Employee()
            {
                Name = "John Doe",
                ID = "JDoe001",
                Designation = "Project Manager"
            },
            new Employee()
            {
                Name = "Angie Ash",
                ID = "AAsh001",
                Designation = "Senior Technical Recuriter"
            },
            new Employee()
            {
                Name = "Timothy Sim",
                ID = "TSim001",
                Designation = "Development Manager"
            }
        };

        public Employee AddEmployee(Employee employee)
        {
            _defaultEmployees.Add(employee);
            return employee;
        }

        public void DeleteEmployee(Employee employee)
        {
            _defaultEmployees.Remove(employee);
        }

        public Employee GetEmployee(string id)
        {
            return _defaultEmployees.SingleOrDefault(x => x.ID == id);
        }

        public List<Employee> GetEmployees()
        {
            return _defaultEmployees;
        }

        public Employee UpdateEmployee(Employee employee)
        {
            var existingEmployee = GetEmployee(employee.ID);
            existingEmployee = employee;
            return existingEmployee;
        }
    }
}
