using SPSolutions.API.Entities;

namespace SPSolutions.API.Repositories
{
    public interface IEmployeeRepository
    {
        public Task<bool> AddEmployee(Employee employee);
    }
}