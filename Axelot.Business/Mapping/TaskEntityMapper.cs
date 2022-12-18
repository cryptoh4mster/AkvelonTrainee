using AutoMapper;
using Axelot.Business.Models;
using Axelot.DAL.Entities;

namespace Axelot.Business.Mapping
{
    public class TaskEntityMapper : Profile
    {
        public TaskEntityMapper() 
        {
            CreateMap<TaskEntity, TaskModel>().ReverseMap();
        }
    }
}
