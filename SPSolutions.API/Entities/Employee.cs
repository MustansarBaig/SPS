using System.ComponentModel.DataAnnotations;

namespace SPSolutions.API.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        [Required][MaxLength(100)] public string Name { get; set; }
        [Range(1, double.MaxValue)] public double Salary { get; set; }
        public DateOnly? DOB { get; set; }
        public Department Department { get; set; }
    }
}