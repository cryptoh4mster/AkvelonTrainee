using Axelot.Core.Interfaces;
using Axelot.DAL.Entities;

namespace Axelot.DAL.Interfaces.Repositories
{
    public interface IProjectRepository : IRepository<ProjectEntity, Guid> { }
}
