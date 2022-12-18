using Axelot.DAL.Interfaces.Repositories;

namespace Axelot.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        ITaskRepository TaskRepository { get; }
        IProjectRepository ProjectRepository { get; }
        Task SaveChangesAsync();
    }
}
