namespace Axelot.Core.Interfaces
{
    public interface IRepository<TEntity, TEntityPrimaryKey>
        where TEntity : class, IEntity<TEntityPrimaryKey>
        where TEntityPrimaryKey : IEquatable<TEntityPrimaryKey>
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> FindSingleAsync(TEntityPrimaryKey entityId);
        Task<IEnumerable<TEntity>> FindManyAsync(IEntitySelectionSpecification<TEntity, TEntityPrimaryKey> entitySelectionSpecification);
        Task Add(TEntity entity);
        Task Delete(TEntity entity);
        Task Update(TEntity entity);
    }
}
