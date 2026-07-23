using EmployeeWebAPI.DTOs;
using EmployeeWebAPI.Filters;
using EmployeeWebAPI.Models;
using EmployeeWebAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        // GET ALL EMPLOYEES
        [HttpGet]
        public IActionResult GetEmployees()
        {
            var employeeDtos = _employeeService.GetAll()
                .Select(e => new EmployeeDTO
                {
                    Id = e.Id,
                    Name = e.Name,
                    Department = e.Department
                })
                .ToList();

            return Ok(employeeDtos);
        }

        // GET EMPLOYEE BY ID (Protected with Custom Authorization Filter)
        [HttpGet("{id}")]
        [CustomAuthFilter]
        public IActionResult GetEmployee(int id)
        {
            var employee = _employeeService.GetById(id);

            if (employee == null)
                return NotFound();

            var dto = new EmployeeDTO
            {
                Id = employee.Id,
                Name = employee.Name,
                Department = employee.Department
            };

            return Ok(dto);
        }

        // ADD EMPLOYEE
        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            var newEmployee = _employeeService.Add(employee);

            return CreatedAtAction(
                nameof(GetEmployee),
                new { id = newEmployee.Id },
                newEmployee);
        }

        // UPDATE EMPLOYEE
        [HttpPut("{id}")]
        public IActionResult UpdateEmployee(int id, Employee employee)
        {
            var updated = _employeeService.Update(id, employee);

            if (!updated)
                return NotFound();

            return NoContent();
        }

        // DELETE EMPLOYEE
        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            var deleted = _employeeService.Delete(id);

            if (!deleted)
                return NotFound();

            return NoContent();
        }
    }
}