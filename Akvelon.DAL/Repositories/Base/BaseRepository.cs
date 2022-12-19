using Akvelon.Core.Interfaces;
using Akvelon.DAL.Context;
using Microsoft.EntityFrameworkCore;

namespace Akvelon.DAL.Repositories.Base
{
    /// <summary>
    /// Generic repository with implementation
    /// </summary>
    /// <typeparam name="TEntity">Type of entity for define necessary repo</typeparam>
    /// <typeparam name="TEntityPrimaryKey">Type of id (i.e int, guid)</typeparam>
    public abstract class BaseRepository<TEntity, TEntityPrimaryKey> : IRepository<TEntity, TEntityPrimaryKey>
        where TEntity : class, IEntity<TEntityPrimaryKey>
        where TEntityPrimaryKey : IEquatable<TEntityPrimaryKey>
    {
        /// <summary>
        /// Database context
        /// </summary>
        private readonly AppDbContext _db;
        public BaseRepository(AppDbContext db)
        {
            _db = db;
        }
        /// <summary>
        /// Method for finding single entity by id
        /// </summary>
        /// <param name="entityId">Id of entity in db</param>
        /// <returns>Entity by id</returns>
        public async Task<TEntity> FindSingleAsync(TEntityPrimaryKey entityId)
        {
            var entitySelectionQuery = _db.Set<TEntity>().Where(entity => entity.Id.Equals(entityId));

            return await entitySelectionQuery.SingleOrDefaultAsync();
        }

        /// <summary>
        /// Method for finding single entity by specification
        /// </summary>
        /// <param name="entitySelectionSpecification">Specification with selection function</param>
        /// <returns>Entity by specification</returns>
        public async Task<TEntity> FindSingleAsync(IEntitySelectionSpecification<TEntity, TEntityPrimaryKey> entitySelectionSpecification)
        {
            var entitySelectionQuery = _db.Set<TEntity>().AsQueryable();

            if (entitySelectionSpecification.SelectionFunction is not null)
            {
                entitySelectionQuery = entitySelectionSpecification.SelectionFunction(entitySelectionQuery);
            }

            return await entitySelectionQuery.SingleOrDefaultAsync();
        }

        /// <summary>
        /// Method for finding many entities by specification
        /// </summary>
        /// <param name="entitySelectionSpecification">Specification with selection function</param>
        /// <returns>Collection of entities by specification</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public async Task<IEnumerable<TEntity>> FindManyAsync(IEntitySelectionSpecification<TEntity, TEntityPrimaryKey> entitySelectionSpecification)
        {
            if (entitySelectionSpecification is null)         
                throw new ArgumentNullException($"{nameof(entitySelectionSpecification)}: argument is not initialized");
            
            var entitySelectionQuery = _db.Set<TEntity>().AsQueryable();

            if (entitySelectionSpecification.SelectionFunction is not null)           
                entitySelectionQuery = entitySelectionSpecification.SelectionFunction(entitySelectionQuery);
           
            return await entitySelectionQuery.ToListAsync();
        }
        
        /// <summary>
        /// Method for finding all TEntity entities from db
        /// </summary>
        /// <returns>Collection of entites</returns>
        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            var entitySelectionQuery = _db.Set<TEntity>().AsQueryable();

            return await entitySelectionQuery.ToListAsync();
        }

        /// <summary>
        /// Method for adding new entity to db
        /// </summary>
        /// <param name="entity">Entity for adding</param>
        /// <exception cref="ArgumentNullException"></exception>
        public void Add(TEntity entity)
        {
            if (entity is null)
                throw new ArgumentNullException($"{nameof(entity)}: argument is not initialized");

            _db.Set<TEntity>().Add(entity);
        }

        /// <summary>
        /// Method for delete existing entity from db
        /// </summary>
        /// <param name="entity">Entity for delete</param>
        /// <exception cref="ArgumentNullException"></exception>
        public void Delete(TEntity entity)
        {
            if (entity is null)
                throw new ArgumentNullException($"{nameof(entity)}: argument is not initialized");

            _db.Set<TEntity>().Remove(entity);
        }

        /// <summary>
        /// Method for update existing entity in db
        /// </summary>
        /// <param name="entity">Entity for update</param>
        /// <exception cref="ArgumentNullException"></exception>
        public void Update(TEntity entity)
        {
            if (entity is null)
                throw new ArgumentNullException($"{nameof(entity)}: argument is not initialized");

            _db.Set<TEntity>().Update(entity);
        }
    }
}
