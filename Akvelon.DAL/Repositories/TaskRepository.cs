using Akvelon.DAL.Context;
using Akvelon.DAL.Entities;
using Akvelon.DAL.Interfaces.Repositories;
using Akvelon.DAL.Repositories.Base;

namespace Akvelon.DAL.Repositories
{
    /// <summary>
    /// Repository for work with task entities
    /// </summary>
    public class TaskRepository : BaseRepository<TaskEntity, Guid>, ITaskRepository
    {
        public TaskRepository(AppDbContext db): base(db) { }
    }
}
