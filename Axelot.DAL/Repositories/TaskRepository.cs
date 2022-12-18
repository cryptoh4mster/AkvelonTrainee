using Axelot.DAL.Context;
using Axelot.DAL.Entities;
using Axelot.DAL.Interfaces.Repositories;
using Axelot.DAL.Repositories.Base;

namespace Axelot.DAL.Repositories
{
    public class TaskRepository : BaseRepository<TaskEntity, Guid>, ITaskRepository
    {
        public TaskRepository(AppDbContext db): base(db) { }
    }
}
