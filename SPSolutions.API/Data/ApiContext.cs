using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
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
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Department>()
            .Property(d => d.Name).Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Throw);
            builder.Entity<Department>()
            .Property(d => d.Location).Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Throw);
        }
    }
}