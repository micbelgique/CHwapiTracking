using GoodsTracking.Domain;
using GoodsTracking.Interfaces;
using System;

namespace GoodsTracking.DataAccess
{
    internal class UnitOfWork : IUnitOfWork
    {
        private DataContext _dataContext;
        private bool _isDisposed;

        internal UnitOfWork(string connectionString)
        {
            _dataContext = new DataContext(connectionString);
        }

        ~UnitOfWork()
        {
            Dispose(false);
        }

        public void Commit()
        {
            _dataContext.Commit();
        }

        public IRepository<TEntity> GetRepository<TEntity>() where TEntity : EntityBase
        {
            return new GenericRepository<TEntity>(_dataContext);
        }
        
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        private void Dispose(bool disposing)
        {
            if (!_isDisposed && disposing)
            {
                _dataContext.Dispose();
            }

            _isDisposed = true;
        }
    }
}
