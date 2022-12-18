using AutoMapper;
using Axelot.Business.Interfaces;
using Axelot.Business.Models;
using Axelot.DAL.Entities;
using Axelot.DAL.Interfaces;
using Axelot.DAL.Interfaces.Repositories;
using Axelot.DAL.Repositories;

namespace Axelot.Business.Services
{
    public class TaskService : ITaskService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ITaskRepository _taskRepository;
        public TaskService(IMapper mapper, IUnitOfWork unitOfWork) 
        { 
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _taskRepository = _unitOfWork.TaskRepository;
        }

        public async Task AddNewTask(TaskModel taskModel)
        {
            var taskEntity = _mapper.Map<TaskEntity>(taskModel);

            await _taskRepository.Add(taskEntity);

            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<IEnumerable<TaskModel>> GetAllTasks()
        {
            var tasksEntities = await _taskRepository.GetAllAsync();

            return _mapper.Map<IEnumerable<TaskModel>>(tasksEntities);
        }

        public async Task<IEnumerable<TaskModel>> GettAllTasksByProjectId(Guid projectId)
        {
            throw new NotImplementedException();
            //TODO: use specification
        }

        public async Task<TaskModel> GetTaskById(Guid taskId)
        {
            var taskEntity = await _taskRepository.FindSingleAsync(taskId);

            return _mapper.Map<TaskModel>(taskEntity);
        }

        public async Task DeleteTaskById(Guid taskId)
        {
            var taskEntity = await _taskRepository.FindSingleAsync(taskId);

            await _taskRepository.Delete(taskEntity);
        }

        public async Task UpdateTaskById(TaskModel taskModel)
        {
            var taskEntity = _mapper.Map<TaskEntity>(taskModel);

            await _taskRepository.Update(taskEntity);

            await _unitOfWork.SaveChangesAsync();
        }
    }
}
