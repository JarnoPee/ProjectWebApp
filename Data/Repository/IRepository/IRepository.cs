using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ProjectWebApp.Data.Repository
{
    public interface IRepository<TEntity> where TEntity :class
    {
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = null
            );

        TEntity GetFirstOrDefault(
            Expression<Func<TEntity, bool>> filter = null,
            string includeProperties = null
            );

        void Add(TEntity entity);
        void Remove(int id);
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
    }
}
