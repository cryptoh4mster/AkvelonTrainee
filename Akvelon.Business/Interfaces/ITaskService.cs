using Akvelon.Business.Models;

namespace Akvelon.Business.Interfaces
{
    /// <summary>
    /// Provides methods to work with task business logic service
    /// </summary>
    public interface ITaskService
    {
        Task AddNewTask(TaskModel taskModel);
        Task UpdateTask(TaskModel taskModel);
        Task DeleteTaskById(Guid taskId);
        Task<TaskModel> GetTaskById(Guid taskId);
        Task<IEnumerable<TaskModel>> GetAllTasks();
    }
}
