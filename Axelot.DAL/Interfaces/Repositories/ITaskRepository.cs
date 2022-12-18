using Axelot.Core.Interfaces;
using Axelot.DAL.Entities;

namespace Axelot.DAL.Interfaces.Repositories
{
    public interface ITaskRepository : IRepository<TaskEntity, Guid> { }
}
