using Microsoft.EntityFrameworkCore;
using SPSolutions.API.Entities;

namespace SPSolutions.API.Data
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Department>()
            .HasIndex(d => d.Name)
            .IsUnique();

            builder.Entity<Department>()
                .HasMany(e => e.Employees)
                .WithOne(d => d.Department)
                .HasForeignKey(ed => ed.EmployeeId)
                .IsRequired();
        }
    }
}