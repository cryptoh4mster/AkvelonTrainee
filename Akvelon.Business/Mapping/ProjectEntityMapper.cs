using AutoMapper;
using Akvelon.Business.Models;
using Akvelon.DAL.Entities;

namespace Akvelon.Business.Mapping
{
    public class ProjectEntityMapper : Profile
    {
        public ProjectEntityMapper() 
        {
            CreateMap<ProjectEntity, ProjectModel>()
                    .ForMember(u => u.ProjectId,
                            opt => opt.MapFrom(c => c.Id));

            CreateMap<ProjectModel, ProjectEntity>()
                    .ForMember(u => u.Id,
                            opt => opt.MapFrom(c => c.ProjectId));
        }
    }
}
