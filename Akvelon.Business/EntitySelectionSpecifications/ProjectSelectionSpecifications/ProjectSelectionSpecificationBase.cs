using Akvelon.Business.Interfaces.EntitySelectionSpecifications;
using Akvelon.DAL.Entities;

namespace Akvelon.Business.EntitySelectionSpecifications.ProjectSelectionSpecifications
{
    public class ProjectSelectionSpecificationBase : EntitySelectionSpecificationBase<ProjectEntity, Guid>, IProjectSelectionSpecification
    {
        public ProjectSelectionSpecificationBase() { }
        public ProjectSelectionSpecificationBase(Func<IQueryable<ProjectEntity>, IQueryable<ProjectEntity>> selectionFunction) : base(selectionFunction) { }
    }
}
