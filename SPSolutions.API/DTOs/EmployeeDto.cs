using System.ComponentModel.DataAnnotations;
using SPSolutions.API.Entities;

namespace SPSolutions.API.DTOs
{
    public class EmployeeDto
    {
        [Required][MaxLength(100)] public string Name { get; set; }
        [Range(1, double.MaxValue)] public double Salary { get; set; }
        public DateOnly? DOB { get; set; }
        public Department DepartmentId { get; set; }
    }
}