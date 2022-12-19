using Microsoft.EntityFrameworkCore;

namespace Akvelon.Business.EntitySelectionSpecifications.ProjectSelectionSpecifications
{
    public class ProjectWithTasksSelectionSpecification : ProjectSelectionSpecificationBase
    {
        public ProjectWithTasksSelectionSpecification(Guid projectId) 
        {
            SelectionFunction = entities => entities.Where(e => e.Id.Equals(projectId))
                                                    .Include(e => e.Tasks);
        }
    }
}
