using Axelot.DAL.Context;
using Axelot.DAL.Interfaces;
using Axelot.DAL.UoW;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Axelot.DAL.Extensions
{
    public static class IServiceCollectionDALExtensions
    {
        public static void RegisterDataAccess(this IServiceCollection services, IConfiguration configuration)
        {
            var appDbConnectionString = configuration.GetConnectionString("Axelot.DevelopmentDb");
            services.AddDbContext<AppDbContext>(options => options.UseNpgsql(appDbConnectionString));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
