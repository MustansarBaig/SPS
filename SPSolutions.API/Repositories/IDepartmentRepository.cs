using SPSolutions.API.Entities;

namespace SPSolutions.API.Repositories
{
    public interface IDepartmentRepository
    {
        public Task<bool> AddDepartment(Department department);
        public Task<bool> UpdateDepartment(Department department);
        public Task<IEnumerable<Department>> GetDepartment(int employeeCount);
        public Task<bool> DepartmentExists(string departmentName);
    }
}