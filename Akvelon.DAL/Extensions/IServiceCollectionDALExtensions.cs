using Akvelon.DAL.Context;
using Akvelon.DAL.Interfaces;
using Akvelon.DAL.UoW;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Akvelon.DAL.Extensions
{
    public static class IServiceCollectionDALExtensions
    {
        /// <summary>
        /// Extension method for register dependencies from data layer
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        public static void RegisterDataAccess(this IServiceCollection services, IConfiguration configuration)
        {
            var appDbConnectionString = configuration.GetConnectionString("Axelot.DevelopmentDb");
            services.AddDbContext<AppDbContext>(options => options.UseNpgsql(appDbConnectionString));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
