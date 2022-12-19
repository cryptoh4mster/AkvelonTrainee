using Akvelon.DAL.Context;
using Akvelon.DAL.Interfaces;
using Akvelon.DAL.Interfaces.Repositories;
using Akvelon.DAL.Repositories;

namespace Akvelon.DAL.UoW
{
    /// <summary>
    /// Uow pattern class
    /// </summary>
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

        /// <summary>
        /// This property provides instance to work with task repository
        /// </summary>
        public ITaskRepository TaskRepository
        {
            get
            {
                if (_taskRepository is null)               
                    _taskRepository = new TaskRepository(_db);
                
                return _taskRepository;
            }
        }

        /// <summary>
        /// This property provides instance to work with project repository
        /// </summary>
        public IProjectRepository ProjectRepository
        {
            get
            {
                if (_projectRepository is null)               
                    _projectRepository = new ProjectRepository(_db);
                
                return _projectRepository;
            }
        }

        /// <summary>
        /// Save changes made in this context in db
        /// </summary>
        /// <returns>Task that represents the asynchronious save operation</returns>
        public async Task SaveChangesAsync()
        {
            await _db.SaveChangesAsync();
        }

        /// <summary>
        /// Virtual method for release the allocated resources
        /// </summary>
        /// <param name="disposing"></param>
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

        /// <summary>
        /// Method for release the allocated resources with supressfinalize
        /// </summary>
        public void Dispose() 
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }   
    }
}
