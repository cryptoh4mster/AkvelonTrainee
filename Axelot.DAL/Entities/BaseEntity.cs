using Axelot.Core.Interfaces;

namespace Axelot.DAL.Entities
{
    public class BaseEntity<TEntityPrimaryKey> : IEntity<TEntityPrimaryKey>
        where TEntityPrimaryKey : IEquatable<TEntityPrimaryKey>
    {
        public TEntityPrimaryKey Id { get; set; }
    }
}
