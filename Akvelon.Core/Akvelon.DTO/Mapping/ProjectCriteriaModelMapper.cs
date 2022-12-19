using Akvelon.Business.Models;
using Akvelon.DTO.Models.Requests;
using AutoMapper;

namespace Akvelon.DTO.Mapping
{
    public class ProjectCriteriaModelMapper : Profile
    {
        public ProjectCriteriaModelMapper() 
        {
            CreateMap<ProjectCriteriaRequest, ProjectCriteriaModel>()
                .ForMember(u => u.SortByField,
                        opt => opt.MapFrom(c => typeof(ProjectCriteriaModel).GetProperty(c.SortByField)))
                .ForMember(u => u.SortOrder,
                        opt => opt.MapFrom(c => c.SortOrder ? "ASC" : "DESC"));
        }
    }
}
