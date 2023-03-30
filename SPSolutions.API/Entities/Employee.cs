using System.ComponentModel.DataAnnotations;

namespace SPSolutions.API.Entities
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        [MaxLength(100)]
        [Required] public string Name { get; set; }
        
        [Range(1, int.MaxValue)]
        public double Salary { get; set; }
        public DateOnly? DOB { get; set; }
        public Department Department { get; set; }
    }
}