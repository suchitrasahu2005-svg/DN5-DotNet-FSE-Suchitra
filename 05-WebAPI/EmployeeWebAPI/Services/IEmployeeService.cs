using EmployeeWebAPI.Models;

namespace EmployeeWebAPI.Services
{
    public interface IEmployeeService
    {
        List<Employee> GetAll();

        Employee? GetById(int id);

        Employee Add(Employee employee);

        bool Update(int id, Employee employee);

        bool Delete(int id);
    }
}