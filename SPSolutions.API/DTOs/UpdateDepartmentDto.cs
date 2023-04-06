using System.ComponentModel.DataAnnotations;

namespace SPSolutions.API.DTOs
{
    public class UpdateDepartmentDto
    {
        [Required] public string Name { get; set; }
        public double Budget { get; set; }
        public bool HasPrinter { get; set; }
    }
}