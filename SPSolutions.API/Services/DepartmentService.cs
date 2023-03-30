using AutoMapper;
using SPSolutions.API.DTOs;
using SPSolutions.API.Entities;
using SPSolutions.API.Repositories;

namespace SPSolutions.API.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepo;
        private readonly IMapper _mapper;
        public DepartmentService(IDepartmentRepository departmentRepo, IMapper mapper)
        {
            _mapper = mapper;
            _departmentRepo = departmentRepo;
        }
        public async Task<bool> Add(DepartmentDto deptDto)
        {
            var department = _mapper.Map<Department>(deptDto);

            return await _departmentRepo.AddDepartment(department);
        }

        public async Task<ICollection<Department>> Get(int employeeCount)
        {
            return await _departmentRepo.GetDepartment(employeeCount);
        }

        public async Task<bool> Update(DepartmentDto deptDto)
        {
            var department = _mapper.Map<Department>(deptDto);

            return await _departmentRepo.UpdateDepartment(department);
        }
    }
}