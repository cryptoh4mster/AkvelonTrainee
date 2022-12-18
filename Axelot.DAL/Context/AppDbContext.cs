using Axelot.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Axelot.DAL.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<ProjectEntity> Projects { get; set; }
        public DbSet<TaskEntity> Tasksk { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
