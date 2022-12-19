using Akvelon.Business.Models;
using System.Linq.Dynamic.Core;

namespace Akvelon.Business.EntitySelectionSpecifications.ProjectSelectionSpecifications
{
    /// <summary>
    /// Specification for filtering and sorting projects
    /// </summary>
    public class ProjectsByCriteriaSelectionSpecification : ProjectSelectionSpecificationBase
    {
        public ProjectsByCriteriaSelectionSpecification(ProjectCriteriaModel projectCriteriaModel)
        {
            SelectionFunction = entites => entites.Where(e => e.Name.Contains(projectCriteriaModel.Name)
                                                                && e.Status.Equals(projectCriteriaModel.Status)
                                                                && e.StartDate > projectCriteriaModel.StartDate
                                                                && e.CompletionDate < projectCriteriaModel.CompletionDate
                                                                && e.Priority.Equals(projectCriteriaModel.Priority))
                                                  .OrderBy($"{projectCriteriaModel.SortByField.Name} {projectCriteriaModel.SortOrder}");
        }
    }
}
