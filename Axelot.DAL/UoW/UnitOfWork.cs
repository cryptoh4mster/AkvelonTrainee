using Axelot.DAL.Context;
using Axelot.DAL.Interfaces;
using Axelot.DAL.Interfaces.Repositories;
using Axelot.DAL.Repositories;

namespace Axelot.DAL.UoW
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private readonly AppDbContext _db;
        private ITaskRepository _taskRepository;
        private IProjectRepository _projectRepository;
        private bool disposed = false;
        public UnitOfWork(AppDbContext db)
        {
            _db = db;
        }

        public ITaskRepository TaskRepository
        {
            get
            {
                if (_taskRepository is null)               
                    _taskRepository = new TaskRepository(_db);
                
                return _taskRepository;
            }
        }

        public IProjectRepository ProjectRepository
        {
            get
            {
                if (_projectRepository is null)               
                    _projectRepository = new ProjectRepository(_db);
                
                return _projectRepository;
            }
        }

        public async Task SaveChangesAsync()
        {
            await _db.SaveChangesAsync();
        }

        public virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _db.Dispose();
                }
                disposed = true;
            }
        }

        public void Dispose() 
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }   
    }
}
