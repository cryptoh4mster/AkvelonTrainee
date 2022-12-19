using AutoMapper;
using Axelot.Business.Models;
using Axelot.DTO.Models.Requests;
using Axelot.DTO.Models.Responses;

namespace Axelot.DTO.Mapping
{
    public class TaskModelMapper : Profile
    {
        public TaskModelMapper()
        {
            CreateMap<NewTaskRequest, TaskModel>()
                .ForMember(u => u.Status,
                        opt => opt.MapFrom(c => Enum.Parse(typeof(Core.Enums.TaskStatus), c.Status)))
                .ForMember(u => u.TaskId,
                        opt => opt.MapFrom(c => Guid.NewGuid()));

            CreateMap<TaskModel, TaskResponse>()
                .ForMember(u => u.Status,
                        opt => opt.MapFrom(c => c.Status.ToString()))
                .ForMember(u => u.TaskId,
                        opt => opt.MapFrom(c => c.TaskId));

            CreateMap<UpdateTaskRequest, TaskModel>()
                .ForMember(u => u.Status,
                        opt => opt.MapFrom(c => Enum.Parse(typeof(Core.Enums.TaskStatus), c.Status)))
                .ForMember(u => u.TaskId,
                        opt => opt.MapFrom(c => c.TaskId));
        }
    }
}
