using Axelot.Core.Interfaces;
using Axelot.DAL.Context;

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

        }

        public async Task<IEnumerable<TEntity>> FindManyAsync(IEntitySelectionSpecification<TEntity, TEntityPrimaryKey> entitySelectionSpecification)
        {

        }
        
        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {

        }

        public void Add(TEntity entity)
        {

        }

        public void AddRange(IEnumerable<TEntity> entities)
        {

        }

        public void Delete(TEntity entity)
        {

        }

        public void DeleteRange(IEnumerable<TEntity> entities)
        {

        }
    }
}
