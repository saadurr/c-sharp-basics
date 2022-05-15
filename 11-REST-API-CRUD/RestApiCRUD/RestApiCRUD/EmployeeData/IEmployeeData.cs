using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestApiCRUD.Models;

namespace RestApiCRUD.EmployeeData
{
    public interface IEmployeeData
    {
        List<Employee> GetEmployees();
        Employee GetEmployee(string id);
        Employee AddEmployee(Employee employee);
        void DeleteEmployee(Employee employee);
        Employee UpdateEmployee(Employee employee);
    }
}
