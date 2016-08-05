using GoodsTracking.Domain;
using GoodsTracking.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GoodsTracking.DataAccess
{
    public class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : EntityBase
    {
        internal DataContext _dataContext;
        internal DbSet<TEntity> _dbSet;

        public GenericRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
            _dbSet = dataContext.Set<TEntity>();
        }

        public virtual IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null,
                                                Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
                                                params string[] includedProperties)
        {
            IQueryable<TEntity> query = _dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includedProperties)
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }

        public virtual TEntity GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public virtual void Insert(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public virtual void Delete(int id)
        {
            TEntity entityToDelete = _dbSet.Find(id);
            Delete(entityToDelete);
        }

        public virtual void Delete(TEntity entityToDelete)
        {
            if (_dataContext.Entry(entityToDelete).State == EntityState.Detached)
            {
                _dbSet.Attach(entityToDelete);
            }
            _dbSet.Remove(entityToDelete);
        }

        public virtual void Update(TEntity entityToUpdate)
        {
            _dbSet.Attach(entityToUpdate);
            _dataContext.Entry(entityToUpdate).State = EntityState.Modified;
        }

        public virtual void Delete(Expression<Func<TEntity, bool>> where)
        {
            IEnumerable<TEntity> objects = _dbSet.Where(where).AsEnumerable();
            foreach (TEntity obj in objects)
            {
                _dbSet.Remove(obj);
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> where)
        {
            return _dbSet.Where(where).FirstOrDefault<TEntity>();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _dbSet.ToList();
        }

        public IEnumerable<TEntity> GetMany(Expression<Func<TEntity, bool>> where)
        {
            return _dbSet.Where(where).ToList();
        }

        public bool Exists(int id)
        {
            return _dbSet.Any(e => e.Id == id);
        }
    }
}
