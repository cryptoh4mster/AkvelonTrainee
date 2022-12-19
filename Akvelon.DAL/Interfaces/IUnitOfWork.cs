using Akvelon.DAL.Interfaces.Repositories;

namespace Akvelon.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        ITaskRepository TaskRepository { get; }
        IProjectRepository ProjectRepository { get; }
        Task SaveChangesAsync();
    }
}
