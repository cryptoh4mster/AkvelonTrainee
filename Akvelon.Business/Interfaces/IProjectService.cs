using Akvelon.Business.Models;

namespace Akvelon.Business.Interfaces
{
    /// <summary>
    /// Provides methods to work with project business logic service
    /// </summary>
    public interface IProjectService
    {
        Task AddNewProject(ProjectModel projectModel);
        Task UpdateProject(ProjectModel projectModel);
        Task DeleteProjectById(Guid projectId);
        Task<ProjectModel> GetProjectById(Guid projectId);
        Task<IEnumerable<ProjectModel>> GetAllProjects();
        Task<ProjectModel> GetProjectWithTasksById(Guid projectId);
        Task<IEnumerable<ProjectModel>> GetProjectsByCriteria(ProjectCriteriaModel projectCriteriaModel);
    }
}
