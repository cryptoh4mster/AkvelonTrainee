namespace Akvelon.Core.Interfaces
{
    public interface IEntity<TEntityPrimaryKey> 
        where TEntityPrimaryKey : IEquatable<TEntityPrimaryKey>
    {
        TEntityPrimaryKey Id { get; set; }
    }
}
