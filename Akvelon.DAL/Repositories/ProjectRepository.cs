﻿using Akvelon.DAL.Context;
using Akvelon.DAL.Entities;
using Akvelon.DAL.Interfaces.Repositories;
using Akvelon.DAL.Repositories.Base;

namespace Akvelon.DAL.Repositories
{
    public class ProjectRepository : BaseRepository<ProjectEntity, Guid>, IProjectRepository
    {
        public ProjectRepository(AppDbContext db) : base(db) { }
    }
}
