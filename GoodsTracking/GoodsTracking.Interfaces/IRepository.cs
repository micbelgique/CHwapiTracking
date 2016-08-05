
using GoodsTracking.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace GoodsTracking.Interfaces
{
    public interface IRepository<TEntity> where TEntity : EntityBase
    {
        void Delete(TEntity entityToDelete);

        void Delete(int id);

        void Delete(Expression<Func<TEntity, bool>> where);

        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, params string[] includedProperties);

        void Insert(TEntity entity);

        void Update(TEntity entity);

        // Get an entity by int id
        TEntity GetById(int id);

        // Get an entity using delegate
        TEntity Get(Expression<Func<TEntity, bool>> where);

        // Gets all entities of type T
        IEnumerable<TEntity> GetAll();

        // Gets entities using delegate
        IEnumerable<TEntity> GetMany(Expression<Func<TEntity, bool>> where);

        bool Exists(int id);
    }
}