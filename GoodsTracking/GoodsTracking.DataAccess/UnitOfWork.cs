using GoodsTracking.Domain;
using GoodsTracking.Interfaces;
using System;

namespace GoodsTracking.DataAccess
{
    internal class UnitOfWork : IUnitOfWork
    {
        private DataContext _dataContext;
        private bool _isDisposed, _autoCommit;

        internal UnitOfWork(string connectionString, bool autoCommit)
        {
            _dataContext = new DataContext(connectionString);
            _autoCommit = autoCommit;
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
            if (_autoCommit)
            {
                Commit();
            }
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
