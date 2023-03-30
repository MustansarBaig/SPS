using SPSolutions.API.Repositories;
using SPSolutions.API.Services;

namespace SPSolutions.API.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddCors();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IDepartmentService, DepartmentService>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            
            return services;
        }
    }
}