using Api_JWT.DTOs.EmployeeDTOs;

namespace Api_JWT.Services.Abstracts
{
    public interface IEmployeeService
    {
        List<EmployeeDTO> GetEmployees();
        EmployeeDTO GetEmployee(int id);
    }
}
