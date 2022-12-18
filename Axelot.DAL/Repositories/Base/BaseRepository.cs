using Axelot.Core.Interfaces;
using Axelot.DAL.Context;
using Microsoft.EntityFrameworkCore;

namespace Axelot.DAL.Repositories.Base
{
    public abstract class BaseRepository<TEntity, TEntityPrimaryKey> : IRepository<TEntity, TEntityPrimaryKey>
        where TEntity : class, IEntity<TEntityPrimaryKey>
        where TEntityPrimaryKey : IEquatable<TEntityPrimaryKey>
    {
        private readonly AppDbContext _db;
        public BaseRepository(AppDbContext db)
        {
            _db = db;
        }
        public async Task<TEntity> FindSingleAsync(TEntityPrimaryKey entityId)
        {
            var entitySelectionQuery = _db.Set<TEntity>().Where(entity => entity.Id.Equals(entityId));

            return await entitySelectionQuery.SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<TEntity>> FindManyAsync(IEntitySelectionSpecification<TEntity, TEntityPrimaryKey> entitySelectionSpecification)
        {
            if (entitySelectionSpecification is null)         
                throw new ArgumentNullException($"{nameof(entitySelectionSpecification)}: argument is not initialized");
            
            var entitySelectionQuery = _db.Set<TEntity>().AsQueryable();

            if (entitySelectionSpecification.SelectionFunction is not null)           
                entitySelectionQuery = entitySelectionSpecification.SelectionFunction(entitySelectionQuery);
           
            return await entitySelectionQuery.ToListAsync();
        }
        
        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            var entitySelectionQuery = _db.Set<TEntity>().AsQueryable();

            return await entitySelectionQuery.ToListAsync();
        }

        public void Add(TEntity entity)
        {
            if (entity is null)
                throw new ArgumentNullException($"{nameof(entity)}: argument is not initialized");

            _db.Set<TEntity>().Add(entity);
        }

        public void Delete(TEntity entity)
        {
            if (entity is null)
                throw new ArgumentNullException($"{nameof(entity)}: argument is not initialized");

            _db.Set<TEntity>().Remove(entity);
        }

        public void Update(TEntity entity)
        {
            if (entity is null)
                throw new ArgumentNullException($"{nameof(entity)}: argument is not initialized");

            _db.Set<TEntity>().Update(entity);
        }
    }
}
