using AutoMapper;
using Akvelon.Business.Models;
using Akvelon.DTO.Models.Requests;
using Akvelon.DTO.Models.Responses;
using Akvelon.Core.Enums;

namespace Akvelon.DTO.Mapping
{
    public class TaskModelMapper : Profile
    {
        public TaskModelMapper()
        {
            CreateMap<NewTaskRequest, TaskModel>()
                .ForMember(u => u.Status,
                        opt => opt.MapFrom(c => Enum.Parse(typeof(TasksStatus), c.Status)))
                .ForMember(u => u.TaskId,
                        opt => opt.MapFrom(c => Guid.NewGuid()));

            CreateMap<TaskModel, TaskResponse>()
                .ForMember(u => u.Status,
                        opt => opt.MapFrom(c => c.Status.ToString()))
                .ForMember(u => u.TaskId,
                        opt => opt.MapFrom(c => c.TaskId));

            CreateMap<UpdateTaskRequest, TaskModel>()
                .ForMember(u => u.Status,
                        opt => opt.MapFrom(c => Enum.Parse(typeof(TasksStatus), c.Status)))
                .ForMember(u => u.TaskId,
                        opt => opt.MapFrom(c => c.TaskId));
        }
    }
}
