
using RestApiCRUD.Models;
using System.Collections.Generic;

namespace RestApiCRUD.EmployeeData
{
    public class MockEmployeeData : IEmployeeData
    {
        public Employee AddEmployee(Employee employee)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteEmployee(Employee employee)
        {
            throw new System.NotImplementedException();
        }

        public Employee GetEmployee(string id)
        {
            throw new System.NotImplementedException();
        }

        public List<Employee> GetEmployees()
        {
            throw new System.NotImplementedException();
        }

        public Employee UpdateEmployee(Employee employee)
        {
            throw new System.NotImplementedException();
        }
    }
}
