using Axelot.Business.Interfaces;
using Axelot.Business.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Axelot.Business.Extensions
{
    public static class IServiceCollectionBusinessExtensions
    {
        public static void RegisterBusinessServices(this IServiceCollection services)
        {
            services.AddScoped<IProjectService, ProjectService>();
            services.AddScoped<ITaskService, TaskService>();
        }
    }
}
