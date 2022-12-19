using Akvelon.Business.Interfaces.EntitySelectionSpecifications;
using Akvelon.DAL.Entities;

namespace Akvelon.Business.EntitySelectionSpecifications.ProjectSelectionSpecifications
{
    /// <summary>
    /// SpecificationBase provides selectionFunction for implementation specifications
    /// </summary>
    public class ProjectSelectionSpecificationBase : EntitySelectionSpecificationBase<ProjectEntity, Guid>, IProjectSelectionSpecification
    {
        public ProjectSelectionSpecificationBase() { }
        public ProjectSelectionSpecificationBase(Func<IQueryable<ProjectEntity>, IQueryable<ProjectEntity>> selectionFunction) : base(selectionFunction) { }
    }
}
