using AutoMapper;
using Axelot.Business.Models;
using Axelot.DAL.Entities;

namespace Axelot.Business.Mapping
{
    public class TaskEntityMapper : Profile
    {
        public TaskEntityMapper() 
        {
            CreateMap<TaskEntity, TaskModel>()
                    .ForMember(u => u.TaskId,
                            opt => opt.MapFrom(c => c.Id))
                    .ForMember(u => u.ProjectId,
                            opt => opt.MapFrom(c => c.ProjectId));

            CreateMap<TaskModel, TaskEntity>()
                    .ForMember(u => u.Id,
                            opt => opt.MapFrom(c => c.TaskId))
                    .ForMember(u => u.ProjectId,
                            opt => opt.MapFrom(c => c.ProjectId));
        }
    }
}
