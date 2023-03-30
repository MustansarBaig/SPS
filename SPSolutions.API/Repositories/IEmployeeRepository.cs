using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SPSolutions.API.DTOs;
using SPSolutions.API.Entities;

namespace SPSolutions.API.Repositories
{
    public interface IEmployeeRepository
    {
        public Task<bool> AddEmployee(Employee employee);
    }
}