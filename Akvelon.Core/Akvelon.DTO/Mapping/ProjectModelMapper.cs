using AutoMapper;
using Akvelon.Business.Models;
using Akvelon.Core.Enums;
using Akvelon.DTO.Models.Requests;
using Akvelon.DTO.Models.Responses;

namespace Akvelon.DTO.Mapping
{
    public class ProjectModelMapper : Profile
    {
        public ProjectModelMapper() 
        {
            CreateMap<NewProjectRequest, ProjectModel>()
                .ForMember(u => u.Status,
                        opt => opt.MapFrom(c => Enum.Parse(typeof(ProjectsStatus), c.Status)))
                .ForMember(u => u.ProjectId,
                        opt => opt.MapFrom(c => Guid.NewGuid()));

            CreateMap<ProjectModel, ProjectResponse>()
                .ForMember(u => u.Status,
                        opt => opt.MapFrom(c => c.Status.ToString()))
                .ForMember(u => u.ProjectId,
                        opt => opt.MapFrom(c => c.ProjectId));

            CreateMap<UpdateProjectRequest, ProjectModel>()
                .ForMember(u => u.Status,
                        opt => opt.MapFrom(c => Enum.Parse(typeof(ProjectsStatus), c.Status)))
                .ForMember(u => u.ProjectId,
                        opt => opt.MapFrom(c => c.ProjectId));

            CreateMap<ProjectModel, ProjectWithTasksResponse>()
                .ForMember(u => u.Status,
                        opt => opt.MapFrom(c => c.Status.ToString()))
                .ForMember(u => u.ProjectId,
                        opt => opt.MapFrom(c => c.ProjectId));
        } 
    }
}
