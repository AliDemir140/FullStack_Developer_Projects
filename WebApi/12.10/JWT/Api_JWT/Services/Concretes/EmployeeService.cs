using Api_JWT.DTOs.EmployeeDTOs;
using Api_JWT.Models.Context;
using Api_JWT.Services.Abstracts;

namespace Api_JWT.Services.Concretes
{
    public class EmployeeService : IEmployeeService
    {
        private readonly NorthwindContext _northwindContext;

        public EmployeeService(NorthwindContext northwindContext)
        {
            _northwindContext = northwindContext;
        }



        public EmployeeDTO GetEmployee(int id)
        {
            var employee=_northwindContext.Employees.Find(id);
            var employeeDto = new EmployeeDTO
            {
                ID = employee.EmployeeId,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Title = employee.Title,
                TitleOfCourtesy = employee.TitleOfCourtesy,
            };
            return employeeDto;
        }

        public List<EmployeeDTO> GetEmployees()
        {
            var employees=_northwindContext.Employees.Select(x=>new EmployeeDTO
            {
                ID=x.EmployeeId,
                FirstName=x.FirstName,
                LastName=x.LastName,
                Title=x.Title,
                TitleOfCourtesy=x.TitleOfCourtesy
            }).ToList();
            return employees;
        }
    }
}
