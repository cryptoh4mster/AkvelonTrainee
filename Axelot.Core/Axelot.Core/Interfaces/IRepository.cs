namespace Axelot.Core.Interfaces
{
    public interface IRepository<TEntity, TEntityPrimaryKey>
        where TEntity : class, IEntity<TEntityPrimaryKey>
        where TEntityPrimaryKey : IEquatable<TEntityPrimaryKey>
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> FindSingleAsync(TEntityPrimaryKey entityId);
        Task<IEnumerable<TEntity>> FindManyAsync();
        void Add(TEntity entity);
        void AddRange(IEquatable<TEntity> entites);
        void Delete(TEntity entity);
        void DeleteRange(IEnumerable<TEntity> entities);
    }
}
