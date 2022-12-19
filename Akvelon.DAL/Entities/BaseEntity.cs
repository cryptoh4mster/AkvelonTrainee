using Akvelon.Core.Interfaces;

namespace Akvelon.DAL.Entities
{
    /// <summary>
    /// Base entity with id
    /// </summary>
    /// <typeparam name="TEntityPrimaryKey">Type of PK</typeparam>
    public class BaseEntity<TEntityPrimaryKey> : IEntity<TEntityPrimaryKey>
        where TEntityPrimaryKey : IEquatable<TEntityPrimaryKey>
    {
        public TEntityPrimaryKey Id { get; set; }
    }
}
