using Akvelon.Business.Interfaces;
using Akvelon.Business.Models;
using Akvelon.DTO.Models.Requests;
using Akvelon.DTO.Models.Responses;
using Akvelon.WebApi.Controllers.Base;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Akvelon.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : BaseController
    {
        private readonly ITaskService _taskService;
        public TaskController(IMapper mapper, ITaskService taskService) : base(mapper)
        {
            _taskService = taskService;
        }

        /// <summary>
        /// Find task by id
        /// </summary>
        /// <param name="request">Task id in request</param>
        /// <returns></returns>
        [HttpGet]
        [Route("task")]
        public async Task<IActionResult> GetTaskById([FromQuery] GetTaskByIdRequest request)
        {
            var result = await _taskService.GetTaskById(request.TaskId);

            return Ok(_mapper.Map<TaskResponse>(result));
        }

        /// <summary>
        /// Find all tasks
        /// </summary>
        /// <returns>All tasks</returns>
        [HttpGet]
        [Route("tasks")]
        public async Task<IActionResult> GetAllTasks()
        {
            var result = await _taskService.GetAllTasks();

            return Ok(_mapper.Map<IEnumerable<TaskResponse>>(result));
        }

        /// <summary>
        /// Add new task
        /// </summary>
        /// <param name="request">New task request</param>
        /// <returns></returns>
        [HttpPost]
        [Route("task")]
        public async Task<IActionResult> AddNewTask(NewTaskRequest request)
        {
            var newTaskModel = _mapper.Map<TaskModel>(request);

            await _taskService.AddNewTask(newTaskModel);

            return Ok("");
        }

        /// <summary>
        /// Update exist task
        /// </summary>
        /// <param name="request">Task with new values</param>
        /// <returns></returns>
        [HttpPut]
        [Route("task")]
        public async Task<IActionResult> UpdateTask(UpdateTaskRequest request)
        {
            var updateTaskModel = _mapper.Map<TaskModel>(request);

            await _taskService.UpdateTask(updateTaskModel);

            return Ok("");
        }

        /// <summary>
        /// Delete exist task
        /// </summary>
        /// <param name="request">Task id in request</param>
        /// <returns></returns>
        [HttpDelete]
        [Route("task")]
        public async Task<IActionResult> DeleteTask([FromQuery] GetTaskByIdRequest request)
        {
            await _taskService.DeleteTaskById(request.TaskId);

            return Ok("");
        }
    }
}
