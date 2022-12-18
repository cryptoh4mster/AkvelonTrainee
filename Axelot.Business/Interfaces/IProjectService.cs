using Axelot.Business.Models;

namespace Axelot.Business.Interfaces
{
    public interface IProjectService
    {
        Task AddNewProject(ProjectModel projectModel);
        Task UpdateProject(ProjectModel projectModel);
        Task DeleteProjectById(Guid ProjectId);
        Task<ProjectModel> GetProjectById(Guid projectId);
        Task<IEnumerable<ProjectModel>> GetAllProjects();
    }
}
