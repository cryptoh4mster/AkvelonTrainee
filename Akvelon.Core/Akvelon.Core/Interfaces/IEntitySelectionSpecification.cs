namespace Akvelon.Core.Interfaces
{
    /// <summary>
    /// Provides selectionfunction for specifications implementation
    /// </summary>
    /// <typeparam name="TEntity">Type of entity</typeparam>
    /// <typeparam name="TEntityPrimaryKey">Type of primary key</typeparam>
    public interface IEntitySelectionSpecification<TEntity, TEntityPrimaryKey>
        where TEntity : class, IEntity<TEntityPrimaryKey>
        where TEntityPrimaryKey : IEquatable<TEntityPrimaryKey>
    {
        public Func<IQueryable<TEntity>, IQueryable<TEntity>> SelectionFunction { get; init; }
    }
}
