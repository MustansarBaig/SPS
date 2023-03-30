using SPSolutions.API.Data;
using SPSolutions.API.Entities;

namespace SPSolutions.API.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApiContext _context;
        public EmployeeRepository(ApiContext context)
        {
            _context = context;

        }
        public async Task<bool> AddEmployee(Employee employee)
        {
            if (employee != null)
            {
                await _context.Employees.AddAsync(employee);
            }

            return await _context.SaveChangesAsync() > 0;

        }
    }
}