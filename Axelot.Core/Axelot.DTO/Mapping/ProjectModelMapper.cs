using AutoMapper;
using Axelot.Business.Models;
using Axelot.Core.Enums;
using Axelot.DTO.Models.Requests;
using Axelot.DTO.Models.Responses;

namespace Axelot.DTO.Mapping
{
    public class ProjectModelMapper : Profile
    {
        public ProjectModelMapper() 
        {
            CreateMap<NewProjectRequest, ProjectModel>()
                .ForMember(u => u.Status,
                        opt => opt.MapFrom(c => Enum.Parse(typeof(ProjectStatus), c.Status)))
                .ForMember(u => u.ProjectId,
                        opt => opt.MapFrom(c => Guid.NewGuid()));

            CreateMap<ProjectModel, ProjectResponse>()
                .ForMember(u => u.Status,
                        opt => opt.MapFrom(c => c.Status.ToString()))
                .ForMember(u => u.ProjectId,
                        opt => opt.MapFrom(c => c.ProjectId));

            CreateMap<UpdateProjectRequest, ProjectModel>()
                .ForMember(u => u.Status,
                        opt => opt.MapFrom(c => Enum.Parse(typeof(ProjectStatus), c.Status)))
                .ForMember(u => u.ProjectId,
                        opt => opt.MapFrom(c => c.ProjectId));

        } 
    }
}
