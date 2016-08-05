
using GoodsTracking.Domain;
using System;

namespace GoodsTracking.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<TEntity> GetRepository<TEntity>() where TEntity : EntityBase;

        void Commit();
    }
}
