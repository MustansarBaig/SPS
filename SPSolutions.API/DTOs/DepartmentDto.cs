using System.ComponentModel.DataAnnotations;

namespace SPSolutions.API.DTOs
{
    public class DepartmentDto
    {
        [Required][MinLength(10)] public string Name { get; set; }
        public string? Location { get; set; }
        [Range(1, int.MaxValue)] public double Budget { get; set; }
        public bool HasPrinter { get; set; }
    }
}