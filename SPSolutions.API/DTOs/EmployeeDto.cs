using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SPSolutions.API.Entities;

namespace SPSolutions.API.DTOs
{
    public class EmployeeDto
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public DateOnly? DOB { get; set; }
        public Department DepartmentId { get; set; }
    }
}