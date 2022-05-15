using RestApiCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiCRUD.EmployeeData
{
    public class SqlEmployeeData : IEmployeeData
    {
        private EmployeeContext _context;
        public SqlEmployeeData(EmployeeContext employeeContext)
        {
            _context = employeeContext;
        }

        public Employee AddEmployee(Employee employee)
        {
            _context.Add(employee);
            _context.SaveChanges();
            return employee; 
        }

        public void DeleteEmployee(Employee employee)
        {
            _context.Employees.Remove(employee);
            _context.SaveChanges();
        }

        public Employee GetEmployee(string id)
        {
            return _context.Employees.Find(id);
        }

        public List<Employee> GetEmployees()
        {
            return _context.Employees.ToList();
        }

        public Employee UpdateEmployee(Employee employee)
        {
            var existingEmployee = _context.Employees.Find(employee.ID);
            if (existingEmployee != null)
            {
                _context.Employees.Update(existingEmployee);
                _context.SaveChanges();
            }
            return employee;

        }
    }
}
