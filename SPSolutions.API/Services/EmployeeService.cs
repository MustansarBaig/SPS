using AutoMapper;
using SPSolutions.API.DTOs;
using SPSolutions.API.Entities;
using SPSolutions.API.Repositories;

namespace SPSolutions.API.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _empRepo;
        private readonly IMapper _mapper;
        public EmployeeService(IEmployeeRepository empRepo, IMapper mapper)
        {
            _mapper = mapper;
            _empRepo = empRepo;

        }
        public async Task<bool> Add(EmployeeDto empDto)
        {
            var employee = _mapper.Map<Employee>(empDto);

            if (await _empRepo.AddEmployee(employee)) return true;

            return false;
        }
    }
}