using SPSolutions.API.DTOs;

namespace SPSolutions.API.Services
{
    public interface IEmployeeService
    {
        public Task<bool> Add(EmployeeDto empDto);
    }
}