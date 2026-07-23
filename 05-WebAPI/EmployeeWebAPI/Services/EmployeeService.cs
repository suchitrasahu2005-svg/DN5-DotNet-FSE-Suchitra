using EmployeeWebAPI.Models;

namespace EmployeeWebAPI.Services
{
    public class EmployeeService : IEmployeeService
    {
        private static List<Employee> employees = new()
        {
            new Employee
            {
                Id = 1,
                Name = "Rahul",
                Department = "IT",
                Salary = 50000
            },
            new Employee
            {
                Id = 2,
                Name = "Priya",
                Department = "HR",
                Salary = 45000
            }
        };

        public List<Employee> GetAll()
        {
            return employees;
        }

        public Employee? GetById(int id)
        {
            return employees.FirstOrDefault(e => e.Id == id);
        }

        public Employee Add(Employee employee)
        {
            employee.Id = employees.Max(e => e.Id) + 1;
            employees.Add(employee);
            return employee;
        }

        public bool Update(int id, Employee updatedEmployee)
        {
            var employee = employees.FirstOrDefault(e => e.Id == id);

            if (employee == null)
                return false;

            employee.Name = updatedEmployee.Name;
            employee.Department = updatedEmployee.Department;
            employee.Salary = updatedEmployee.Salary;

            return true;
        }

        public bool Delete(int id)
        {
            var employee = employees.FirstOrDefault(e => e.Id == id);

            if (employee == null)
                return false;

            employees.Remove(employee);
            return true;
        }
    }
}