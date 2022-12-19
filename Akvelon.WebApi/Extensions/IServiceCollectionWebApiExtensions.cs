using FluentValidation;
using System.Reflection.Emit;

namespace Akvelon.WebApi.Extensions
{
    public static class IServiceCollectionWebApiExtensions
    {
        public static IServiceCollection AddValidation(this IServiceCollection services) 
        {
            var assemblyWithValidators = AssemblyBuilder.Load("Akvelon.DTO");

            return services.AddValidatorsFromAssembly(assemblyWithValidators);
        }
    }
}
