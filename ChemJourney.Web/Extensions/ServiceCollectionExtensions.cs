using ChemJourney.Data.Models;
using ChemJourney.Web.Data;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static void AddApplicationServices(this IServiceCollection services, Type serviceType)
        {
            Assembly? serviceAssembly = Assembly.GetAssembly(serviceType) ?? 
                throw new InvalidOperationException("Invalid service type provided.");

            Type[] serviceTypes = serviceAssembly
                .GetTypes()
                .Where(t => t.Name.EndsWith("Service") && !t.IsInterface)
                .ToArray();

            foreach (Type implementationType in serviceTypes)
            {
                Type? interfaceType = implementationType
                    .GetInterface($"I{implementationType.Name}") ?? 
                    throw new InvalidOperationException($"No interface is provided for the service with name: {implementationType.Name}");

                services.AddScoped(interfaceType, implementationType);
            }
        }

        public static IServiceCollection AddApplicationDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<ChemJourneyDbContext>(options => 
                options.UseSqlServer(connectionString));

            services.AddDatabaseDeveloperPageExceptionFilter();

            return services;
        }

        public static IServiceCollection AddApplicationIdentity(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDefaultIdentity<ApplicationUser>(options =>
            {
                options.SignIn.RequireConfirmedAccount = configuration.GetValue<bool>("Identity:SignIn:RequireConfirmedAccount");
                options.Password.RequireLowercase = configuration.GetValue<bool>("Identity:Password:RequireLowercase");
                options.Password.RequireUppercase = configuration.GetValue<bool>("Identity:Password:RequireUppercase");
                options.Password.RequireNonAlphanumeric = configuration.GetValue<bool>("Identity:Password:RequireNonAlphanumeric");
                options.Password.RequiredLength = configuration.GetValue<int>("Identity:Password:RequiredLength");
            })
                .AddEntityFrameworkStores<ChemJourneyDbContext>();

            return services;
        }
    }
}
