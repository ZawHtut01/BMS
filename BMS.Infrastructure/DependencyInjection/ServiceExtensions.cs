
using BMS.Application.Interfaces;
using BMS.Application.Services;
using BMS.Infrastructure.Data;
using BMS.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BMS.Infrastructure.DependencyInjection
{
    public static class ServiceExtensions
    {
        public static IServiceCollection CommonServices(this IServiceCollection services, IConfiguration configuration)
        {

            AddDatabaseService(services, configuration);
            AddBusinessLogicServices(services);
            AddCustomRepositoryServices(services);

            return services;
        }
        public static IServiceCollection AddDatabaseService(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });

            return services;
        }

        public static IServiceCollection AddBusinessLogicServices(IServiceCollection services)
        {

            services.AddScoped<IStudentService, StudentService>();

            return services;
        }

        public static IServiceCollection AddCustomRepositoryServices(IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }


    }
}
