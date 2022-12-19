namespace Akvelon.Core.Interfaces
{
    /// <summary>
    /// Provides Id with TEntityPrimaryKey type 
    /// </summary>
    /// <typeparam name="TEntityPrimaryKey"></typeparam>
    public interface IEntity<TEntityPrimaryKey> 
        where TEntityPrimaryKey : IEquatable<TEntityPrimaryKey>
    {
        TEntityPrimaryKey Id { get; set; }
    }
}
