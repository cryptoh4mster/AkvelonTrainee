using Axelot.DAL.Context;

namespace Axelot.DAL.UoW
{
    public class UnitOfWork : IDisposable
    {
        private readonly AppDbContext _db;
        public UnitOfWork(AppDbContext db)
        {
            _db = db;
        }

        private bool disposed = false;
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
