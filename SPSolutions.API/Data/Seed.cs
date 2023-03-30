using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using SPSolutions.API.Entities;

namespace SPSolutions.API.Data
{
    public class Seed
    {
        public static async Task SeedDepartments(ApiContext context)
        {
            if(await context.Departments.AnyAsync()) return;
            
            var data = await File.ReadAllTextAsync("Data/MockData/mock_dept.json");
            var departments = JsonSerializer.Deserialize<List<Department>>(data);

            foreach(var dept in departments)
            {
                await context.Departments.AddAsync(dept);
            }

            await context.SaveChangesAsync();
        }

        public static async Task SeedEmployees(ApiContext context)
        {
            if(await context.Employees.AnyAsync()) return;
            
            var data = await File.ReadAllTextAsync("Data/MockData/mock_emp.json");
            var employees = JsonSerializer.Deserialize<List<Employee>>(data);

            foreach(var emp in employees)
            {
                await context.Employees.AddAsync(emp);
            }

            await context.SaveChangesAsync();
        }
    }
}