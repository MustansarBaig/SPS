using Microsoft.EntityFrameworkCore;
using SPSolutions.API.Data;
using SPSolutions.API.Entities;

namespace SPSolutions.API.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly ApiContext _context;
        public DepartmentRepository(ApiContext context)
        {
            _context = context;
        }
        public async Task<bool> AddDepartment(Department department)
        {
            if (department != null)
            {
                await _context.Departments.AddAsync(department);
            }

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<Department>> GetDepartment(int employeeCount)
        {
            var departments = await _context.Departments.Include(e => e.Employees)
            .Where(d => d.Employees.Count >= employeeCount)
            .ToListAsync();

            return departments;
        }

        public async Task<bool> DepartmentExists(string departmentName)
        {
            var department = _context.Departments.Where(d=>d.Name == departmentName).Select(u=> u.Name);
            if(department != null) return true;

            return false;
        }

        public async Task<bool> UpdateDepartment(Department department)
        {
            var dept = await _context.Departments.Where(d => d.Name == department.Name).FirstOrDefaultAsync();

            if (dept != null)
            {
                dept.Budget = department.Budget;
                dept.HasPrinter = department.HasPrinter;
            }

            return await _context.SaveChangesAsync() > 1;
        }
    }
}