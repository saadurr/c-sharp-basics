using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestApiCRUD.EmployeeData;
using RestApiCRUD.Models;

namespace RestApiCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private IEmployeeData _employeeData;

        public EmployeesController(IEmployeeData employeeData)
        {
            _employeeData = employeeData;
        }

        [HttpGet]
        public IActionResult GetEmployees()
        {
            return Ok(_employeeData.GetEmployees());
        }

        [HttpGet("{id}")]
        public IActionResult GetEmployee(string id)
        {
            var employee = _employeeData.GetEmployee(id);
            if (employee != null)
            {
                return Ok(employee);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            var emp = _employeeData.GetEmployee(employee.ID);
            //check if already exists
            if (emp != null)
            {
                return Ok("Employee record already exists.");
            }
            _employeeData.AddEmployee(employee);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + employee.ID, employee);

        }

        [HttpPut("{id}")]
        public IActionResult UpdateEmployee(string id, Employee employee)
        {
            var emp = _employeeData.GetEmployee(id);
            if (emp != null)
            {
                employee.ID = emp.ID;
                return Ok(_employeeData.UpdateEmployee(employee));
            }
            return NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(string id)
        {
            var emp = _employeeData.GetEmployee(id);
            if (emp != null)
            {
                _employeeData.DeleteEmployee(emp);
                return Ok($"Employee {id} record deleted");
            }
            return NotFound();
        }

    }
}
