using Akvelon.Business.Models;

namespace Akvelon.Business.Interfaces
{
    public interface ITaskService
    {
        Task AddNewTask(TaskModel taskModel);
        Task UpdateTask(TaskModel taskModel);
        Task DeleteTaskById(Guid taskId);
        Task<TaskModel> GetTaskById(Guid taskId);
        Task<IEnumerable<TaskModel>> GetAllTasks();
        Task<IEnumerable<TaskModel>> GettAllTasksByProjectId(Guid projectId);
    }
}
