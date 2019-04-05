using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SpellAndSummon.Persistence
{
    public class Repository<TEntity, TId> 
        where TEntity: class
    {
        protected readonly DbContext _context;
        private readonly DbSet<TEntity> _entities;
        public Repository(DbContext context)
        {
            this._context = context;
            _entities = this._context.Set<TEntity>();
        }
        public void Add(TEntity entity)
        {
            _context.Add(entity);
        }
        public async Task AddAsync(TEntity entity)
        {
            await _context.AddAsync(entity);
        }
        public void Remove(TEntity entity)
        {
            _context.Remove(entity);
        }
        public TEntity Get(TId id)
        {
            return _entities.Find(id);
        }
        public async Task<TEntity> GetAsync(System.Int32 id)
        {
            return await _entities.FindAsync(id);
        }
        public IEnumerable<TEntity> GetAll()
        {
            return _entities.ToList();
        }
        public async Task<IList<TEntity>> GetAllAsync()
        {
            return await _entities.ToListAsync();
        }
        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return _entities.Where(predicate).ToList();
        }
    }
}