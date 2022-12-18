﻿using Axelot.Business.Models;

namespace Axelot.Business.Interfaces
{
    public interface ITaskService
    {
        Task AddNewTask(TaskModel taskModel);
        Task UpdateTaskById(TaskModel taskModel);
        Task DeleteTaskById(Guid taskId);
        Task<TaskModel> GetTaskById(Guid taskId);
        Task<IEnumerable<TaskModel>> GetAllTasks();
        Task<IEnumerable<TaskModel>> GettAllTasksByProjectId(Guid projectId);
    }
}