using System.ComponentModel.DataAnnotations;

namespace SPSolutions.API.Entities
{
    public class Department
    {
        public int DepartmentId { get; set; }
        
        [MinLength(10)]
        [Required] public string Name { get; set; }
        public string? Location { get; set; }
        
        [Range(1, int.MaxValue)]
        public double Budget { get; set; }
        public bool HasPrinter { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}