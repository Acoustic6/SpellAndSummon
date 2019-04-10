using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SpellAndSummon.Core
{
    public interface IRepository<TEntity, TId>
        where TEntity: class 
    {
        void Add(TEntity entity);
        Task AddAsync(TEntity entity);
        void Remove(TEntity entity);
        TEntity Get(TId id);
        Task<TEntity> GetAsync(System.Int32 id);
        IEnumerable<TEntity> GetAll();
        Task<IEnumerable<TEntity>> GetAllAsync();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
    }
}