using Axelot.DAL.Context;
using Axelot.DAL.Entities;
using Axelot.DAL.Interfaces.Repositories;
using Axelot.DAL.Repositories.Base;

namespace Axelot.DAL.Repositories
{
    public class ProjectRepository : BaseRepository<ProjectEntity, Guid>, IProjectRepository
    {
        public ProjectRepository(AppDbContext db) : base(db) { }
    }
}
