namespace Axelot.Core.Interfaces
{
    public interface IEntitySelectionSpecification<TEntity, TEntityPrimaryKey>
        where TEntity : class, IEntity<TEntityPrimaryKey>
        where TEntityPrimaryKey : IEquatable<TEntityPrimaryKey>
    {
        public Func<IQueryable<TEntity>, IQueryable<TEntity>> SelectionFunction { get; init; }
    }
}
