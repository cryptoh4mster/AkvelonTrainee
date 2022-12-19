using Microsoft.EntityFrameworkCore;

namespace Akvelon.DAL.Extensions
{
    public static class IQueryableExtensions
    {
        public static IQueryable<TEntity> IncludeProperties<TEntity>(this IQueryable<TEntity> entitySelectionQuery, string[] entityIncludablePropertyNames)
            where TEntity : class
        {
            if (entityIncludablePropertyNames is null)
            {
                return entitySelectionQuery;
            }

            return entityIncludablePropertyNames.Where(entityIncludablePropertyName => entityIncludablePropertyName is not null)
                .Aggregate(entitySelectionQuery, (generatedEntitySelectionQuery, entityIncludablePropertyName) =>
                    generatedEntitySelectionQuery.Include(entityIncludablePropertyName));
        }
    }
}
