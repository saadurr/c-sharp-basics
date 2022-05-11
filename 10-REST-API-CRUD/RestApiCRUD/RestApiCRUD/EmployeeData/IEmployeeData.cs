using RestApiCRUD.Models;
using System.Collections.Generic;

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
