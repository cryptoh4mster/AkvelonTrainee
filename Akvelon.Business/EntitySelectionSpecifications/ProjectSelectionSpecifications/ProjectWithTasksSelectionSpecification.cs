using Microsoft.EntityFrameworkCore;

namespace Akvelon.Business.EntitySelectionSpecifications.ProjectSelectionSpecifications
{
    /// <summary>
    /// Specification for get project with his tasks by id
    /// </summary>
    public class ProjectWithTasksSelectionSpecification : ProjectSelectionSpecificationBase
    {
        public ProjectWithTasksSelectionSpecification(Guid projectId) 
        {
            SelectionFunction = entities => entities.Where(e => e.Id.Equals(projectId))
                                                    .Include(e => e.Tasks);
        }
    }
}
