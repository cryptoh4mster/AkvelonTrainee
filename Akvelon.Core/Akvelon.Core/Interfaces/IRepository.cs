namespace Akvelon.Core.Interfaces
{
    /// <summary>
    /// Provides methods to work with repositories
    /// </summary>
    /// <typeparam name="TEntity">Type of entity for define necessary repo</typeparam>
    /// <typeparam name="TEntityPrimaryKey">Type of id (i.e int, guid)</typeparam>
    public interface IRepository<TEntity, TEntityPrimaryKey>
        where TEntity : class, IEntity<TEntityPrimaryKey>
        where TEntityPrimaryKey : IEquatable<TEntityPrimaryKey>
    {
        /// <summary>
        /// Method for finding all TEntity entities from db
        /// </summary>
        /// <returns>Collection of entites</returns>
        Task<IEnumerable<TEntity>> GetAllAsync();

        /// <summary>
        /// Method for finding single entity by id
        /// </summary>
        /// <param name="entityId">Id of entity in db</param>
        /// <returns>Entity by id</returns>
        Task<TEntity> FindSingleAsync(TEntityPrimaryKey entityId);

        /// <summary>
        /// Method for finding single entity by specification
        /// </summary>
        /// <param name="entitySelectionSpecification">Specification with selection function</param>
        /// <returns>Entity by specification</returns>
        Task<TEntity> FindSingleAsync(IEntitySelectionSpecification<TEntity, TEntityPrimaryKey> entitySelectionSpecification);

        /// <summary>
        /// Method for finding many entities by specification
        /// </summary>
        /// <param name="entitySelectionSpecification">Specification with selection function</param>
        /// <returns>Collection of entities by specification</returns>
        Task<IEnumerable<TEntity>> FindManyAsync(IEntitySelectionSpecification<TEntity, TEntityPrimaryKey> entitySelectionSpecification);

        /// <summary>
        /// Method for adding new entity to db
        /// </summary>
        /// <param name="entity">Entity for adding</param>
        void Add(TEntity entity);

        /// <summary>
        /// Method for delete existing entity from db
        /// </summary>
        /// <param name="entity">Entity for delete</param>
        void Delete(TEntity entity);

        /// <summary>
        /// Method for update existing entity in db
        /// </summary>
        /// <param name="entity">Entity for update</param>
        void Update(TEntity entity);
    }
}
