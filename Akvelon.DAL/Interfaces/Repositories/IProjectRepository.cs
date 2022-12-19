using Akvelon.Core.Interfaces;
using Akvelon.DAL.Entities;

namespace Akvelon.DAL.Interfaces.Repositories
{
    public interface IProjectRepository : IRepository<ProjectEntity, Guid> { }
}
