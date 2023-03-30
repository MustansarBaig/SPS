using SPSolutions.API.DTOs;
using SPSolutions.API.Entities;

namespace SPSolutions.API.Services
{
    public interface IDepartmentService
    {
        public Task<bool> Add(DepartmentDto deptDto);
        public Task<bool> Update(DepartmentDto deptDto);
        public Task<ICollection<Department>> Get(int employeeCount);
    }
}