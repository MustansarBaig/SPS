namespace SPSolutions.API.DTOs
{
    public class DepartmentDto
    {
        public string Name { get; set; }
        public string? Location { get; set; }
        public double Budget { get; set; }
        public bool HasPrinter { get; set; }
    }
}