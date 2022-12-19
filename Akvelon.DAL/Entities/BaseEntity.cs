using Akvelon.Core.Interfaces;

namespace Akvelon.DAL.Entities
{
    public class BaseEntity<TEntityPrimaryKey> : IEntity<TEntityPrimaryKey>
        where TEntityPrimaryKey : IEquatable<TEntityPrimaryKey>
    {
        public TEntityPrimaryKey Id { get; set; }
    }
}
