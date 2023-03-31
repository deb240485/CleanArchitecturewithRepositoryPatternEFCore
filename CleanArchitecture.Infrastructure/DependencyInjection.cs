using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection ImplementPersistence( this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DBContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly(typeof(DBContext).Assembly.FullName)),
                    ServiceLifetime.Transient);

            services.AddScoped<IDBContext>(provider => provider.GetRequiredService<DBContext>());

            return services;
        }
    }
}
