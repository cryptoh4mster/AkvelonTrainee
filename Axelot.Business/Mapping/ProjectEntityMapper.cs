using AutoMapper;
using Axelot.Business.Models;
using Axelot.DAL.Entities;

namespace Axelot.Business.Mapping
{
    public class ProjectEntityMapper : Profile
    {
        public ProjectEntityMapper() 
        {
            CreateMap<ProjectEntity, ProjectModel>().ReverseMap();
        }
    }
}
