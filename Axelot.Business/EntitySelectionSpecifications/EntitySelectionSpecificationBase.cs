using Axelot.Core.Interfaces;

namespace Axelot.Business.EntitySelectionSpecifications
{
    public abstract class EntitySelectionSpecificationBase<TEntity, TEntityPrimaryKey> : IEntitySelectionSpecification<TEntity, TEntityPrimaryKey>
        where TEntity : class, IEntity<TEntityPrimaryKey>
        where TEntityPrimaryKey : IEquatable<TEntityPrimaryKey>
    {
        public Func<IQueryable<TEntity>, IQueryable<TEntity>> SelectionFunction { get; init; }

        public EntitySelectionSpecificationBase() { }

        public EntitySelectionSpecificationBase(Func<IQueryable<TEntity>, IQueryable<TEntity>> selectionFunction)
        {
            SelectionFunction = selectionFunction;
        }
    }
}
