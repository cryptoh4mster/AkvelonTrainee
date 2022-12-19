using Akvelon.Business.Interfaces;
using Akvelon.Business.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Akvelon.Business.Extensions
{
    public static class IServiceCollectionBusinessExtensions
    {
        /// <summary>
        /// Extension method for register dependencies from business layer
        /// </summary>
        /// <param name="services"></param>
        public static void RegisterBusinessServices(this IServiceCollection services)
        {
            services.AddScoped<IProjectService, ProjectService>();
            services.AddScoped<ITaskService, TaskService>();
        }
    }
}
